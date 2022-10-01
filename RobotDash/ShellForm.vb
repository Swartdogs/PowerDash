Public Class ShellForm

   Public Enum LinkStatus
      None = 0
      Connecting = 1
      NoAddress = 2
      Connected = 3
   End Enum

   Private Delegate Sub ClientStatusCallback(status As LinkStatus)
   Private Delegate Sub FinishCountCallback(mode As Integer, robotStatus As Integer, robotValue As Integer, dashButton As Integer, dashValue As Integer)
   Private Delegate Sub FinishGetCallback(mode As Integer)
   Private Delegate Sub FinishPutCallback(buttonAck As Boolean, valueAck As Boolean)

   Private Sub ClientStatus(status As LinkStatus)
      If m_dashForm IsNot Nothing
         If status = LinkStatus.Connected 
            m_dashForm.LedRobot.BackColor = Color.PaleGreen
            m_dashForm.LabelStatus.BackColor = Color.FromArgb(252, 252, 252)         
         Else
            m_dashForm.LedRobot.BackColor = Color.WhiteSmoke
            m_dashForm.LabelStatus.BackColor = Color.Yellow
         End If

         Select status
            Case LinkStatus.Connecting
               m_dashForm.LabelStatus.Text = "Connecting..."
            Case LinkStatus.NoAddress
               m_dashForm.LabelStatus.Text = "No IP Address"
            Case Else
               m_dashForm.LabelStatus.Text = ""
         End Select
      End If
   End Sub

   Private Sub FinishCount(mode As Integer, robotStatus As Integer, robotValue As Integer, dashButton As Integer, dashValue As Integer)
      m_robotStatusCount = robotStatus
      ReDim m_robotStatus(m_robotStatusCount)

      m_robotValueCount = robotValue
      ReDim m_robotValue(m_robotValueCount)

      If m_robotMode <> mode
         m_robotMode = mode
         If m_dashForm IsNot Nothing Then m_dashForm.LabelStatus.Text = RobotModeCaption(mode)
      End If

      If dashValue <> m_dashValueCount Or dashButton <> m_dashButtonCount
         Dim result As DialogResult = MessageBox.Show(Me, "CAUTION:  The Dashboard and Robot data configurations are inconsistent. " & vbCrLf & vbCrLf & _
                                                      "DASHBOARD: Data Values=" & m_dashValueCount.ToString & "   Button Groups=" &  _
                                                      m_dashButtonCount & vbCrLf & "           ROBOT: Data Values=" & dashValue.ToString & _
                                                      "   Button Groups=" & dashButton.ToString, "Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Warning)
      End If

      If m_dataForm IsNot Nothing Then m_dataForm.BuildGrids(True)
   End Sub

   Private Sub FinishGet(mode As Integer)
      If m_robotMode <> mode
         m_robotMode = mode
         If m_dashForm IsNot Nothing Then m_dashForm.LabelStatus.Text = RobotModeCaption(mode)
      End If

      If m_dashForm IsNot Nothing Then    m_dashForm.showData()
      If m_tunePIDForm IsNot Nothing Then m_tunePIDForm.UpdateStatus(TunePidForm.DataGroup.RobotValue)

      If m_dataForm IsNot Nothing 
         m_dataForm.ShowData(DataForm.DataGroup.RobotValue)
         m_dataForm.ShowData(DataForm.DataGroup.RobotStatus)
      End If
   End Sub

   Private Sub FinishPut(buttonAck As Boolean, valueAck As Boolean)
      If buttonAck
         If m_dataForm IsNot Nothing Then m_dataForm.ShowData(DataForm.DataGroup.DashButton)
      End If

      If valueAck
         If m_dashForm IsNot Nothing Then       m_dashForm.UpdateStatus()
         If m_dataForm IsNot Nothing Then       m_dataForm.ShowData(DataForm.DataGroup.DashValue)
         If m_settingsForm IsNot Nothing Then   m_settingsForm.UpdateStatus()
         If m_tunePIDForm IsNot Nothing Then    m_tunePIDForm.UpdateStatus(TunePidForm.DataGroup.DashValue)
      End If
   End Sub

   Public Sub InvokeClientStatus(status As LinkStatus)
      Try
         Me.Invoke(New ClientStatusCallback(AddressOf ClientStatus), New Object () {status})
      Catch
      End Try
   End Sub

   Public Sub InvokeFinishCount(mode As Integer, robotStatus As Integer, robotValue As Integer, dashButton As Integer, dashValue As Integer)
      Try
         Me.Invoke(New FinishCountCallback(AddressOf FinishCount), New Object () {mode, robotStatus, robotValue, dashButton, dashValue})
      Catch
      End Try
   End Sub

   Public Sub InvokeFinshGet(mode As Integer)
      Try
         Me.Invoke(New FinishGetCallback(AddressOf FinishGet), New Object () {mode})
      Catch
      End Try
   End Sub

   Public Sub InvokeFinishPut(buttonAck As Boolean, valueAck As Boolean)
      Try
         Me.Invoke(New FinishPutCallback(AddressOf FinishPut), New Object () {buttonAck, valueAck})
      Catch
      End Try
   End Sub

   Private Sub ShellForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
      m_shellForm = Nothing
   End Sub

   Private Sub ShellForm_Load(sender As Object, e As EventArgs) Handles Me.Load
      m_shellForm = Me

      Me.Top = Screen.GetBounds(Me).Top
      Me.Left = Screen.GetBounds(Me).Left

      m_imageDone       = Image.FromFile(Application.StartupPath & "\Resources\Done.png")
      m_imagePending    = Image.FromFile(Application.StartupPath & "\Resources\Pending.png")
      m_imageRollerCW   = Image.FromFile(Application.StartupPath & "\Resources\RollerCW.gif")
      m_imageRollerCCW  = Image.FromFile(Application.StartupPath & "\Resources\RollerCCW.gif")

      ReDim m_dashValue(m_dashValueCount)
      ReDim m_dashButton(m_dashButtonCount)

      LoadOptions()
      LoadDashValues()
      LoadAutoList()

      m_dashForm = New DashForm
      m_dashForm.Show()

      StartClient()
   End Sub

End Class