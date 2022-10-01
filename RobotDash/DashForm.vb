Imports System.ComponentModel

Public Class DashForm

   Private c_buttonIndex         As Integer = -1
   Private c_colorGreen          As Color = Color.FromArgb(190, 255, 190)
   Private c_colorRed            As Color = Color.FromArgb(255, 210, 210)
   Private c_formName            As String = "Dashboard"
   Private c_formResize          As Boolean = False
   Private c_ignoreEvents        As Boolean = False
   Private c_intakeButtonList    As List(Of Button) = New List(Of Button)
   Private c_liftButtonList      As List(Of Button) = New List(Of Button)

   Private Sub ButtonDataCapture_Click(sender As Object, e As EventArgs) Handles ButtonDataCapture.Click
      If DashButton(DBIndex.dbDataCapture)
         DashButton(DBIndex.dbDataCapture) = False
         ButtonDataCapture.BackColor = Color.WhiteSmoke
      Else
         DashButton(DBIndex.dbDataCapture) = True
         ButtonDataCapture.BackColor = Color.SpringGreen
      End If
   End Sub

   Private Sub ButtonIntake_Click(sender As Object, e As EventArgs) Handles ButtonIntakePickup.Click, ButtonIntakeStow.Click, ButtonIntakeEject.Click, _
                                                                            ButtonIntakeLaunch.Click, ButtonIntakeDrop.Click, ButtonIntakeTilt.Click
      If m_dashOptions.buttonsEnabled And c_buttonIndex < 0 And m_robotMode = 3
         Dim intakeButton  As Button = CType(sender, Button)

         c_buttonIndex = intakeButton.Tag

         DashButton(c_buttonIndex) = True
         SetIntakeButton(c_buttonIndex, m_colorPending)
         TimerClick.Enabled = True

         My.Computer.Audio.Play(Application.StartupPath & "\Resources\IntakeButton.wav", AudioPlayMode.Background)
      End If
   End Sub

   Private Sub ButtonLift_Click(sender As Object, e As EventArgs) Handles ButtonLiftTravel.Click, ButtonLiftSwitch.Click, ButtonLiftScaleLow.Click, _
                                                                          ButtonLiftScaleBal.Click, ButtonLiftScaleHigh.Click, ButtonLiftBumpDown.Click, _
                                                                          ButtonLiftBumpUp.Click
      If m_dashOptions.buttonsEnabled And c_buttonIndex < 0 And m_robotMode = 3
         Dim liftButton    As Button = CType(sender, Button)

         c_buttonIndex = liftButton.Tag

         DashButton(c_buttonIndex) = True
         SetLiftButton(c_buttonIndex, m_colorPending)
         TimerClick.Enabled = True

         My.Computer.Audio.Play(Application.StartupPath & "\Resources\LiftButton.wav", AudioPlayMode.Background)
      End if
   End Sub

   Private Sub DashForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
      m_dashForm = Nothing
   End Sub

   Private Sub DashForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
      If c_formResize
         c_formResize = False
      Else
         SaveDashValues()
         StopClient()
         m_tcpClient = Nothing
         m_shellForm.Close()
      End If
   End Sub

   Private Sub DashForm_Load(sender As Object, e As EventArgs) Handles Me.Load
      m_dashForm = Me
      SetFormZoom(m_dashOptions.dashFormZoom, 100, Me)

      c_intakeButtonList.Add(ButtonIntakeStow)
      c_intakeButtonList.Add(ButtonIntakePickup)
      c_intakeButtonList.Add(ButtonIntakeEject)
      c_intakeButtonList.Add(ButtonIntakeLaunch)
      c_intakeButtonList.Add(ButtonIntakeDrop)
      c_intakeButtonList.Add(ButtonIntakeTilt)

      c_liftButtonList.Add(ButtonLiftTravel)
      c_liftButtonList.Add(ButtonLiftSwitch)
      c_liftButtonList.Add(ButtonLiftScaleLow)
      c_liftButtonList.Add(ButtonLiftScaleBal)
      c_liftButtonList.Add(ButtonLiftScaleHigh)
      c_liftButtonList.Add(ButtonLiftBumpDown)
      c_liftButtonList.Add(ButtonLiftBumpUp)

      ShowData()

      c_ignoreEvents = True
         ListStart.SelectedIndex = DashValue(DVindex.dvAutoStart)
         If ListStart.SelectedIndex < 0 Then ListStart.SelectedIndex = 0
         If Not m_dashValue(DVindex.dvAutoStart).sentToHost Then ListStart.BackColor = m_colorPending

         ListDelay.SelectedIndex = DashValue(DVindex.dvAutoDelay)
         If Not m_dashValue(DVindex.dvAutoDelay).sentToHost Then ListDelay.BackColor = m_colorPending

         FindAutoIndex(ListLRL, DVindex.dvAutoSelectLRL)
         FindAutoIndex(ListRLR, DVindex.dvAutoSelectRLR)
         FindAutoIndex(ListLLL, DVindex.dvAutoSelectLLL)
         FindAutoIndex(ListRRR, DVindex.dvAutoSelectRRR)
      c_ignoreEvents = False

      Me.Top = Screen.GetBounds(Me).Top + 5
      Me.Left = Screen.GetBounds(Me).Left + (Screen.GetBounds(Me).Width - Me.Width) / 2
   End Sub

   Private Sub DashForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
      Static myWindowState As FormWindowState = FormWindowState.Normal

      If myWindowState <> Me.WindowState
         myWindowState = Me.WindowState
         SetAppWindowState(myWindowState)
      End If
   End Sub

   Private Sub FileExit_Click(sender As Object, e As EventArgs) Handles FileExit.Click
      Me.Close()
   End Sub

   Private Sub FileReconnect_Click(sender As Object, e As EventArgs) Handles FileReconnect.Click
      LabelStatus.BackColor = Color.FromArgb(252, 252, 252)         
      LabelStatus.Text = ""

      StopClient()
      m_tcpClient = Nothing
      TimerRestart.Start()
   End Sub

   Private Sub FindAutoIndex(list As ComboBox, dashIndex As Integer)
      Dim autoIndex  As Integer = DashValue(dashIndex)
      Dim listIndex  As Integer = -1

      For i As Integer = 0 To list.Items.Count - 1
         If list.Items(i).ItemId = autoIndex
            listIndex = i
            Exit For
         End If
      Next

      list.SelectedIndex = listIndex
      If Not m_dashValue(dashIndex).sentToHost Then list.BackColor = m_colorPending
   End Sub

   Private Function FindIntakeIndex(mode As Integer) As Integer
      Dim buttonIndex As Integer = -1

      Select mode
         Case 1:     buttonIndex = DBIndex.dbIntakePickup
         Case 2:     buttonIndex = DBIndex.dbIntakeStow
         Case 3:     buttonIndex = DBIndex.dbIntakeDrop
         Case 4:     buttonIndex = DBIndex.dbIntakeEject
         Case 5:     buttonIndex = DBIndex.dbIntakeLaunch
      End Select

      Return buttonIndex
   End Function

   Private Function FindLiftIndex(valueIndex As Integer) As Integer
      Dim buttonIndex As Integer = -1

      If valueIndex <> - 1
         Select valueIndex
            Case DVindex.dvLiftScaleTop:     buttonIndex = DBIndex.dbLiftScaleTop
            Case DVindex.dvLiftScaleMid:     buttonIndex = DBIndex.dbLiftScaleMid
            Case DVindex.dvLiftScaleBot:     buttonIndex = DBIndex.dbLiftScaleBot
            Case DVindex.dvLiftSwitch:       buttonIndex = DBIndex.dbLiftSwitch
            Case DVindex.dvLiftTravel:       buttonIndex = DBIndex.dbLiftTravel
         End Select
      End If

      Return buttonIndex
   End Function

   Public Property FormResize() As Boolean
      Get
         FormResize = c_formResize
      End Get
       Set(value As Boolean)
         c_formResize = value
       End Set
   End Property

   Private Sub ListDelay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListDelay.SelectedIndexChanged
      If Not c_ignoreEvents
         m_dashValue(DVindex.dvAutoDelay).revised = True
         ListDelay.BackColor = m_colorPending
         DashValue(DVindex.dvAutoDelay, True) =  CDbl(ListDelay.SelectedIndex)
      End If
   End Sub

   Private Sub ListAuto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListLLL.SelectedIndexChanged, ListLRL.SelectedIndexChanged, _
                                                                                       ListRLR.SelectedIndexChanged, ListRRR.SelectedIndexChanged
      If Not c_ignoreEvents
         Dim dashIndex  As Integer
         Dim list       As ComboBox = CType(sender, ComboBox)

         Select list.Tag
            Case 1:  dashIndex = DVindex.dvAutoSelectLRL
            Case 2:  dashIndex = DVindex.dvAutoSelectRLR
            Case 3:  dashIndex = DVindex.dvAutoSelectLLL
            Case 4:  dashIndex = DVindex.dvAutoSelectRRR
         End Select

         m_dashValue(dashIndex).revised = True
         list.BackColor = m_colorPending
         DashValue(dashIndex, True) = CDbl(list.SelectedItem.ItemId)
      End If
   End Sub

   Private Sub ListStart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListStart.SelectedIndexChanged
      LoadAutoSelections()

      If Not c_ignoreEvents
         m_dashValue(DVindex.dvAutoStart).revised = True
         ListStart.BackColor = m_colorPending
         DashValue(DVindex.dvAutoStart, True) = CDbl(ListStart.SelectedIndex)
      End If
   End Sub

   Private Sub LoadAutoSelections()
      Dim startBit   As Integer = 2 ^ ListStart.SelectedIndex

      ListLRL.Items.Clear()
      ListRLR.Items.Clear()
      ListLLL.Items.Clear()
      ListRRR.Items.Clear()

      ListLRL.Items.Add(New ListItem(0, "None"))
      ListRLR.Items.Add(New ListItem(0, "None"))
      ListLLL.Items.Add(New ListItem(0, "None"))
      ListRRR.Items.Add(New ListItem(0, "None"))

      For Each auto As AutoOption In m_autoList
         If (auto.startPositions And startBit) > 0
            If auto.validForLRL Then ListLRL.Items.Add(New ListItem(auto.autoIndex, auto.description))
            If auto.validForRLR Then ListRLR.Items.Add(New ListItem(auto.autoIndex, auto.description))
            If auto.validForLLL Then ListLLL.Items.Add(New ListItem(auto.autoIndex, auto.description))
            If auto.validForRRR Then ListRRR.Items.Add(New ListItem(auto.autoIndex, auto.description))
         End If
      Next

      ListLRL.SelectedIndex = 0
      ListRLR.SelectedIndex = 0
      ListLLL.SelectedIndex = 0
      ListRRR.SelectedIndex = 0
   End Sub

   Private Function PercentValue(value As Double, range As Double) As Integer
      Dim percent As Integer = 0

      If range > 0
         percent = 100 * (value / range)
         If percent < 0
            percent = 0
         ElseIf percent > 100
            percent = 100
         End If
      End If

      Return percent
   End Function

   Private Sub SetIntakeButton(index As Integer, backColor As Color)
      For Each button In c_intakeButtonList
         If button.Tag = index
            button.BackColor = backColor
         Else
            Select button.Tag
               Case DBIndex.dbIntakeEject, DBIndex.dbIntakeLaunch, DBIndex.dbIntakeDrop
                  button.BackColor = c_colorRed
               Case Else
                  button.BackColor = c_colorGreen
            End Select
         End If
      Next
   End Sub

   Private Sub SetLiftButton(index As Integer, backColor As Color)
      For Each button In c_liftButtonList
         If button.Tag = index
            button.BackColor = backColor
         Else
            button.BackColor = c_colorGreen
         End If
      Next
   End Sub

   Public Sub ShowData()
      Static cubeOnboard   As Boolean = False
      Static rollerMode    As Integer = 0
      Static shiftLow      As Boolean = False
      Dim newValue         As Integer

      If m_robotValueCount > 0
         LabelDriveLeft.Text        = (GetRobotValue(RVindex.rvDriveLeftPwm) * 100).ToString("0") & "%"
         LabelDriveRight.Text       = (GetRobotValue(RVindex.rvDriveRightPwm) * 100).ToString("0") & "%"
         LabelEncoderLeft.Text      = GetRobotValue(RVindex.rvDriveEncoderL).ToString("0.0")
         LabelEncoderRight.Text     = GetRobotValue(RVindex.rvDriveEncoderR).ToString("0.0")
         LabelGyro.Text             = GetRobotValue(RVindex.rvDriveGyro).ToString("0.0")
         LabelArmNow.Text           = GetRobotValue(RVindex.rvIntakeArmPosition).ToString("0")
         LabelArmSetpoint.Text      = GetRobotValue(RVindex.rvIntakeArmSetpoint).ToString("0")
         LabelArmPwm.Text           = (GetRobotValue(RVindex.rvIntakeArmPwm) * 100).ToString("0") & "%"
         LabelLiftNow.Text          = GetRobotValue(RVindex.rvLiftPosition).ToString("0.0")
         LabelLiftSetpoint.Text     = GetRobotValue(RVindex.rvLiftSetpoint).ToString("0.0")
         LabelLiftAmpsTop.Text      = (GetRobotValue(RVindex.rvLiftAmpsTop)).ToString("0.0")
         LabelLiftAmpsBottom.Text   = (GetRobotValue(RVindex.rvLiftAmpsBottom)).ToString("0.0")

         Dim liftPwm As String      = (-GetRobotValue(RVindex.rvLiftPwm) * 100).ToString("0" ) & "%"
         LabelLiftPwmTop.Text       = liftPwm

         If Not GetRobotStatus(RSIndex.rsLiftDirectionUp) Then liftPwm = "0%"
         LabelLiftPwmBottom.Text    = liftPwm

         If GetRobotStatus(RSIndex.rsDriveShiftState)
            LabelShift.ForeColor = Color.Red
            LabelShift.Text = "LOW"
            If Not shiftLow Then My.Computer.Audio.Play(Application.StartupPath & "\Resources\LowGear.wav", AudioPlayMode.Background)
            shiftLow = True
         Else
            LabelShift.ForeColor = Color.DarkGreen
            LabelShift.Text = "HIGH"
            shiftLow = False
         End If

         LiftPosition.Value = PercentValue(GetRobotValue(RVindex.rvLiftPosition), DashValue(DVindex.dvLiftHighLimit))
         LiftSetpoint.Value = PercentValue(GetRobotValue(RVindex.rvLiftSetpoint), DashValue(DVindex.dvLiftHighLimit))

         Dim armValue As Double = DashValue(DVindex.dvIntakeLimit) - GetRobotValue(RVindex.rvIntakeArmPosition)
         ArmPosition.Value = PercentValue(armValue, DashValue(DVindex.dvIntakeLimit))

         armValue = DashValue(DVindex.dvIntakeLimit) - GetRobotValue(RVindex.rvIntakeArmSetpoint)
         ArmSetpoint.Value = PercentValue(armValue, DashValue(DVindex.dvIntakeLimit))

         SetLiftButton(FindLiftIndex(CInt(GetRobotValue(RVindex.rvLiftIndex))), Color.Yellow)
         SetIntakeButton(FindIntakeIndex(CInt(GetRobotValue(RVindex.rvIntakeMode))), Color.Yellow)

         Select GetRobotValue(RVindex.rvIntakeRollerState)
            Case Is > 0:   newValue = 1
            Case Is < 0:   newValue = 2
            Case Else:     newValue = 0
         End Select

         If rollerMode <> newValue
            rollerMode = newValue
            Select rollerMode
               Case 0:  ImageRollerL.Image = Nothing
                        ImageRollerR.Image = Nothing
               Case 1:  ImageRollerL.Image = m_imageRollerCW
                        ImageRollerR.Image = m_imageRollerCCW
               Case 2:  ImageRollerL.Image = m_imageRollerCCW
                        ImageRollerR.Image = m_imageRollerCW
            End Select
         End If

         If GetRobotStatus(RSIndex.rsCubeGrip)
            LabelGripperL.Text = "|"
            LabelGripperR.Text = "|"
         ElseIf GetRobotStatus(RSIndex.rsCubeDrop)
            LabelGripperL.Text = "_"
            LabelGripperR.Text = "_"
         Else
            LabelGripperL.Text = "\"
            LabelGripperR.Text = "/"
         End If

         LabelCube.Visible = GetRobotStatus(RSIndex.rsCubeSensorFar)

         If GetRobotStatus(RSIndex.rsCubeSensorFar)
            CubeFar.BackColor = Color.SpringGreen
         Else
            CubeFar.BackColor = Color.WhiteSmoke
         End If

         If GetRobotStatus(RSIndex.rsCubeSensorNear)
            CubeNear.BackColor = Color.SpringGreen
         Else
            CubeNear.BackColor = Color.WhiteSmoke
         End If

         If GetRobotStatus(RSIndex.rsCubeOnboard)
            If Not cubeOnboard
               cubeOnboard = True
               My.Computer.Audio.Play(Application.StartupPath & "\Resources\GotCube.wav", AudioPlayMode.Background)
            End If
         Else
            cubeOnboard = False
         End If

         If GetRobotStatus(RSIndex.rsDriveLeftAlert)
            LabelDriveLeft.BackColor = Color.Red
            LabelDriveLeft.ForeColor = Color.White
         Else
            LabelDriveLeft.BackColor = Color.White
            LabelDriveLeft.ForeColor = Color.Black
         End If

         If GetRobotStatus(RSIndex.rsDriveRightAlert)
            LabelDriveRight.BackColor = Color.Red
            LabelDriveRight.ForeColor = Color.White
         Else
            LabelDriveRight.BackColor = Color.White
            LabelDriveRight.ForeColor = Color.Black
         End If
      End If
   End Sub

   Private Sub TimerClick_Tick(sender As Object, e As EventArgs) Handles TimerClick.Tick
      TimerClick.Enabled = False
      DashButton(c_buttonIndex) = False
      c_buttonIndex = -1
   End Sub

   Private Sub TimerRestart_Tick(sender As Object, e As EventArgs) Handles TimerRestart.Tick
      TimerRestart.Enabled = False
      StartClient()
   End Sub

   Public Sub UpdateStatus()
      If Not m_dashValue(DVindex.dvAutoStart).revised And m_dashValue(DVindex.dvAutoStart).sentToHost Then ListStart.BackColor = Color.White
      If Not m_dashValue(DVindex.dvAutoDelay).revised And m_dashValue(DVindex.dvAutoDelay).sentToHost Then ListDelay.BackColor = Color.White
      If Not m_dashValue(DVindex.dvAutoSelectLRL).revised And m_dashValue(DVindex.dvAutoSelectLRL).sentToHost Then ListLRL.BackColor = Color.White
      If Not m_dashValue(DVindex.dvAutoSelectRLR).revised And m_dashValue(DVindex.dvAutoSelectRLR).sentToHost Then ListRLR.BackColor = Color.White
      If Not m_dashValue(DVindex.dvAutoSelectLLL).revised And m_dashValue(DVindex.dvAutoSelectLLL).sentToHost Then ListLLL.BackColor = Color.White
      If Not m_dashValue(DVindex.dvAutoSelectRRR).revised And m_dashValue(DVindex.dvAutoSelectRRR).sentToHost Then ListRRR.BackColor = Color.White
   End Sub

   Private Sub ViewData_Click(sender As Object, e As EventArgs) Handles ViewData.Click
      If m_dataForm Is Nothing
         m_dataForm = New DataForm
         m_dataForm.Show()
      ElseIf m_dataForm.WindowState = FormWindowState.Minimized
         m_dataForm.WindowState = FormWindowState.Normal
      Else
         m_dataForm.Activate()
      End If
   End Sub

   Private Sub ViewOptions_Click(sender As Object, e As EventArgs) Handles ViewOptions.Click
      If m_optionsForm Is Nothing
         m_optionsForm = New OptionsForm
         m_optionsForm.Show()
      ElseIf m_optionsForm.WindowState = FormWindowState.Minimized
         m_optionsForm.WindowState = FormWindowState.Normal
      Else
         m_optionsForm.Activate()
      End If
   End Sub

   Private Sub ViewSettings_Click(sender As Object, e As EventArgs) Handles ViewSettings.Click
      If m_settingsForm Is Nothing
         m_settingsForm = New SettingsForm
         m_settingsForm.Show()
      ElseIf m_settingsForm.WindowState = FormWindowState.Minimized
         m_settingsForm.WindowState = FormWindowState.Normal
      Else
         m_settingsForm.Activate()
      End If
   End Sub

   Private Sub ViewTraffic_Click(sender As Object, e As EventArgs) Handles ViewTraffic.Click 
      If m_hostTrafficForm Is Nothing
         m_hostTrafficForm = New HostTrafficForm
         m_hostTrafficForm.Show()
      ElseIf m_hostTrafficForm.WindowState = FormWindowState.Minimized
         m_hostTrafficForm.WindowState = FormWindowState.Normal
      Else
         m_hostTrafficForm.Activate()
      End If
   End Sub

   Private Sub ViewTune_Click(sender As Object, e As EventArgs) Handles ViewTune.Click
      If m_tunePIDForm Is Nothing
         m_tunePIDForm = New TunePidForm
         m_tunePIDForm.Show()
      ElseIf m_tunePIDForm.WindowState = FormWindowState.Minimized
         m_tunePIDForm.WindowState = FormWindowState.Normal
      Else
         m_tunePIDForm.Activate()
      End If
   End Sub

End Class
