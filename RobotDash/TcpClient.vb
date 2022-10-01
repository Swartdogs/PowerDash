Imports System.Net
Imports System.Timers

Public Class TcpClient
   Private Enum ReceiveState
      None = 0
      Ignore = 1
      Login = 2
      GetCategory = 3
      GetColors = 4
      GetRank = 5
      GetTeam = 6
   End Enum

   Private c_connected        As Boolean = False
   Private c_getTimer         As Timer
   Private c_hostAddress      As IPAddress
   Private c_messageList      As List(Of String) = New List(Of String)
   Private c_newCounts        As Boolean
   Private c_readMessage      As Boolean = False
   Private c_openTimer        As Timer
   Private c_readTimer        As Timer
   Private c_receiveState     As ReceiveState = ReceiveState.None
   Private c_retryTimer       As Timer

   Private WithEvents c_clientSocket   As ClientSocket

   Private Sub AddMessage(ByVal message As String) Handles c_clientSocket.NewMessage
      c_messageList.Add(message)

      If Not c_readMessage
         c_readMessage = True
         c_readTimer.Start()
      End If
   End Sub

   Private Sub Connect(connected as Boolean) Handles c_clientSocket.Connect
      If m_shellForm IsNot Nothing
         If connected
            m_shellForm.InvokeClientStatus(ShellForm.LinkStatus.Connected)
         Else
            m_shellForm.InvokeClientStatus(ShellForm.LinkStatus.None)
         End If
      End If

      c_connected = connected

      If connected
         ShowTraffic(TrafficFrom.Code, "Connected")
         m_robotMode = -1
         c_getTimer.Start()
      Else
         c_readTimer.Stop()
         c_retryTimer.Start()
      End If
   End Sub

   Private Sub Disconnect(message As String) Handles c_clientSocket.Disconnect
      c_connected = False
      m_robotMode = -1
      If m_dashForm IsNot Nothing Then m_shellForm.InvokeClientStatus(ShellForm.LinkStatus.None)

      c_clientSocket.Close()
      c_getTimer.Stop()
      c_readTimer.Stop()

      c_retryTimer.Start()

      ShowTraffic(TrafficFrom.Code, message)
   End Sub

   Public Sub GetHostAddress()
      If m_dashForm IsNot Nothing Then m_shellForm.InvokeClientStatus(ShellForm.LinkStatus.Connecting)
      Dns.BeginGetHostAddresses(m_dashOptions.robotHost, AddressOf GetHostAddressCallback, Nothing)
   End Sub

   Public Sub GetHostAddressCallback(ar As IAsyncResult)
      Try
         Dim hostIP() as IPAddress = Dns.EndGetHostAddresses(ar)

         For index As Integer = 0 To hostIP.Count - 1
            If (Not hostIP(index).IsIPv6LinkLocal) And (Not hostIP(index).IsIPv6Multicast) And (Not hostIP(index).IsIPv6SiteLocal)
               c_clientSocket.Open(hostIP(index), m_dashOptions.robotPort)
               Exit For
            End If
         Next

      Catch e As Exception
         If m_dashForm IsNot Nothing Then m_shellForm.InvokeClientStatus(ShellForm.LinkStatus.NoAddress)
         c_retryTimer.Start()
      End Try
   End Sub

   Private Sub GetTimeout()
      c_getTimer.Stop()

      If c_connected
         If m_robotMode < 0
            m_robotMode = 0
            c_newCounts = False
            SendMessage("COUNT:")

         ElseIf c_newCounts
            c_newCounts = False
            SendMessage("COUNT:")

         Else
            SendMessage("GET:" & DateAndTime.Now.ToString("MM/dd/yy hh:mm|"))
         End If
      End If
   End Sub

   Public Function IsConnected() As Boolean
      Return c_connected
   End Function

   Public Sub NewCounts()
      c_newCounts = True
   End Sub

   Private Sub ReadMessage()
      Dim command             As String = String.Empty
      Dim colon               As Integer
      Dim errorMessage        As String = String.Empty
      Dim message             As String
      Dim parse()             As String
      Dim startGetTimer       As Boolean = False
      Dim validCommand        As Boolean = False

      c_readTimer.Stop()

      Do While c_messageList.Count > 0
         If Not c_connected Then Exit Sub

         message = c_messageList(0)
         c_messageList.RemoveAt(0)

         ShowTraffic(TrafficFrom.Host, message)

         colon = message.IndexOf(":")

         If colon < 0
            ShowTraffic(TrafficFrom.Code, "No command in message")

         Else
            command = message.Substring(0, colon)
            message = message.Substring(colon + 1).Trim

            Select command
               Case "COUNT"
                  parse = message.Split(",")

                  If parse.Count = 5
                     m_shellForm.InvokeFinishCount(ConvertToInt(parse(0)), ConvertToInt(parse(1)), ConvertToInt(parse(2)), _
                                                   ConvertToInt(parse(3)), ConvertToInt(parse(4)))
                     SendDashboardData()
                  Else
                     ShowTraffic(TrafficFrom.Code, "Invalid COUNT response") 
                  End If

                  startGetTimer = True

               Case "GET"
                  parse = message.Split("|")

                  If parse.Count = 3
                     Dim count   As Integer
                     Dim mode    As Integer = ConvertToInt(parse(0))
                     Dim status  As String = parse(1)
                     Dim value   As String = parse(2)

                     parse = status.Split(",")
                     count = parse.Count
                     If count > m_robotStatusCount Then count = m_robotStatusCount

                     For i As Integer = 0 To count - 1
                        m_robotStatus(i) = ConvertToLong(parse(i))
                     Next

                     parse = value.Split(",")
                     count = parse.Count
                     If count > m_robotValueCount Then count = m_robotValueCount

                     For i As Integer = 0 To count - 1
                        m_robotValue(i) = ConvertToDouble(parse(i))
                     Next

                     m_shellForm.InvokeFinshGet(mode)

                  Else
                     ShowTraffic(TrafficFrom.Code, "Invalid GET response")
                  End If

                  startGetTimer = True

               Case "PUT"
                  Dim ack()      as String
                  Dim buttonAck  As Boolean = False
                  Dim index      As Integer = 0
                  Dim valueAck   As Boolean = False

                  parse = message.Split("|")

                  For i As Integer = 0 To parse.Count - 1
                     ack = parse(i).Split(",")

                     If ack.Count = 2
                        index = ConvertToInt(ack(1))

                        Select ack(0)
                           Case "B"
                              If index < m_dashButtonCount
                                 m_dashButton(index).sentToHost = True
                                 buttonAck = True
                              End If

                           Case "V"
                              If index < m_dashValueCount
                                 m_dashValue(index).sentToHost = True
                                 valueAck = True
                              End If
                        End Select
                     End If
                  Next

                  m_shellForm.InvokeFinishPut(buttonAck, valueAck)
            End Select
         End If
      Loop

      c_readMessage = False
      If startGetTimer Then c_getTimer.Start()
   End Sub

   Private Sub NewTraffic(message As String) Handles c_clientSocket.NewTraffic
      ShowTraffic(TrafficFrom.Code, message)
   End Sub

   Private Sub OpenPort()
      If c_openTimer IsNot Nothing Then c_openTimer.Stop()

      If c_getTimer Is Nothing
         c_getTimer = New Timer(200)
         c_getTimer.AutoReset = False
         AddHandler c_getTimer.Elapsed, New ElapsedEventHandler(AddressOf GetTimeout)
      End If

      If c_readTimer Is Nothing
         c_readTimer = New Timer(50)
         c_readTimer.AutoReset = False
         AddHandler c_readTimer.Elapsed, New ElapsedEventHandler(AddressOf ReadMessage)
      End If

      If c_retryTimer Is Nothing
         c_retryTimer = New Timer(5000)
         c_retryTimer.AutoReset = False
         AddHandler c_retryTimer.Elapsed, New ElapsedEventHandler(AddressOf RetryConnect)
      End If

      GetHostAddress()
   End Sub

   Private Sub RetryConnect(sender As Object, e As ElapsedEventArgs)
      c_retryTimer.Stop()
      GetHostAddress()
   End Sub

   Private Sub SendDashboardData()
      Dim i          As Integer
      Dim dash       As String = String.Empty

      For i = 0 To m_dashButtonCount - 1
         dash &= "B," & i.ToString & "," & m_dashButton(i).value.ToString & "|"
      Next

      For i = 0 To m_dashValueCount - 1
         dash &= "V," & i.ToString & "," & FormatValue(m_dashValue(i).value, 6) & "|"
      Next

      If dash.Length > 0 Then SendMessage("PUT:" & dash)
   End Sub

   Public Sub SendMessage(message As String)
      If c_connected
         ShowTraffic(TrafficFrom.Client, message)
         c_clientSocket.Send(message)
      End If
   End Sub

   Private Sub ShowTraffic(from As TrafficFrom, message As String)
      If m_hostTrafficForm IsNot Nothing
         m_hostTrafficForm.AddMessage(from, message)
      End If
   End Sub

   Public Sub Shutdown()
      If c_getTimer     IsNot Nothing Then c_getTimer.Stop()
      If c_readTimer    IsNot Nothing Then c_readTimer.Stop()
      If c_retryTimer   IsNot Nothing Then c_retryTimer.Stop()

      c_connected = False
      c_clientSocket.Close()
      m_dashForm.LedRobot.BackColor = Color.LightPink
   End Sub

   Public Sub Start()
      If c_clientSocket Is Nothing Then
         c_clientSocket = New ClientSocket
         OpenPort()         
      Else
         c_connected = False
         c_clientSocket.Close()

         If c_openTimer Is Nothing
            c_openTimer = New Timer(2000)
            c_openTimer.AutoReset = False
            AddHandler c_openTimer.Elapsed, New ElapsedEventHandler(AddressOf OpenPort)
         End If

         c_openTimer.Start()
      End If
   End Sub

End Class
