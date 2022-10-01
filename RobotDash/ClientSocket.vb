Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Timers

Public Class ClientSocket
   Private Structure ReceiveBuffer
      Dim bufferSize          As Integer
      Dim buffer()            As Byte
      Dim message             As String
   End Structure

   Private c_hostIP           As IPAddress
   Private c_hostPort         As Int32
   Private c_openTimer        As Timer
   Private c_receive          As ReceiveBuffer
   Private c_socket           As Socket
   Private c_socketOpen       As Boolean = False

   Public Event Connect(connected As Boolean)
   Public Event Disconnect(message As String)
   Public Event NewMessage(message As String)
   Public Event NewTraffic(message As String)

   Private Sub ConnectCallback(result As IAsyncResult)
      Try
         c_openTimer.Stop()

         If c_socket Is Nothing
            RaiseEvent NewTraffic("Connection Timeout")
            RaiseEvent Connect(False)
         Else
            c_socket.EndConnect(result)
            c_socket.BeginReceive(c_receive.buffer, 0, c_receive.bufferSize, 0, New AsyncCallback(AddressOf ReceiveCallback), c_receive)
            RaiseEvent Connect(c_socket.Connected)
         End If

      Catch ex As Exception
         If c_socket Is Nothing Then RaiseEvent Connect(False) Else RaiseEvent Connect(c_socket.Connected)
         RaiseEvent NewTraffic("Connect Error: " & ex.Message.ToString)
      End Try
   End Sub

   Public Sub Close()
      If c_openTimer IsNot Nothing Then c_openTimer.Stop()

      If c_socket IsNot Nothing
         c_socketOpen = False       ' Set to False prior to Shutdown to avoid ObjectDisposedException

         If c_socket.Connected
            c_socket.Shutdown(SocketShutdown.Both)
            c_socket.Close()
         End If

         c_socket = Nothing
      End If
   End Sub

   Public Sub Open(hostIP As IPAddress, hostPort As Int32, optional bufferSize As Integer = 512)
      If c_openTimer Is Nothing
         c_openTimer = New Timer(7000)
         c_openTimer.AutoReset = False
         AddHandler c_openTimer.Elapsed, New ElapsedEventHandler(AddressOf OpenTimeout)
      End If

      Try
         c_hostIP = hostIP
         c_hostPort = hostPort
         c_receive.bufferSize = bufferSize
         ReDim c_receive.buffer(c_receive.bufferSize)

         c_socket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)

         Dim hostEndPoint As New IPEndPoint(c_hostIP, c_hostPort)
         c_socket.BeginConnect(hostEndPoint, New AsyncCallback(AddressOf ConnectCallback), c_socket)
         c_openTimer.Start()
         c_socketOpen = True

      Catch ex As Exception
         RaiseEvent NewTraffic("Open Error: " & ex.Message.ToString)
      End Try
   End Sub

   Private Sub OpenTimeout()
      c_openTimer.Stop()
      c_socket.Close()
      c_socket = Nothing
   End Sub

   Private Sub ReceiveCallback(result As IAsyncResult)
      Dim message As String = String.Empty
      Dim eol     As Integer

      If Not c_socketOpen Then Exit Sub

      Try
         Dim bytesRead  As Integer =  0
         bytesRead = c_socket.EndReceive(result)

         If bytesRead > 0 Then
            c_receive.message &= Encoding.ASCII.GetString(c_receive.buffer, 0, bytesRead)

            Do
               eol = c_receive.message.IndexOf(vbCrLf)                     ' Look for End-of_Line string

               If eol < 0 
                  Exit Do
               Else                            
                  message = c_receive.message.Substring(0, eol)            ' Get message from string
                  c_receive.message = c_receive.message.Substring(eol + 2) ' Remove message from string
                  RaiseEvent NewMessage(message)
               End If
            Loop

            If c_socketOpen
               c_socket.BeginReceive(c_receive.buffer, 0, c_receive.bufferSize, 0, New AsyncCallback(AddressOf ReceiveCallback), c_receive)
            End if
         Else
            RaiseEvent Disconnect("Disconnected: No Message Received")
         End If

      Catch ex As Exception
         message = ex.Message.ToString
         eol = message.IndexOf(vbCrLf)    
         if eol > 0 Then message = message.Substring(0, eol)

         RaiseEvent NewTraffic("Receive Error: " & message)
         RaiseEvent Disconnect("Disconnected: Receive Error")
      End Try
   End Sub

   Public Sub Send(message As String)
      If Not c_socketOpen Then Exit Sub

      Dim byteBuffer As Byte() = Encoding.ASCII.GetBytes(message & vbCrLf)

      Try
         c_socket.BeginSend(byteBuffer, 0, byteBuffer.Length, 0, New AsyncCallback(AddressOf SendCallback), c_socket)

      Catch e As SocketException
         RaiseEvent NewTraffic("Send Error: " & e.Message.ToString)
      End Try
   End Sub

   Private Sub SendCallback(result As IAsyncResult)
      'Debug.Print("SendCallback")
   End Sub
End Class
