<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashForm
   Inherits System.Windows.Forms.Form

   'Form overrides dispose to clean up the component list.
   <System.Diagnostics.DebuggerNonUserCode()> _
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      Try
         If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
         End If
      Finally
         MyBase.Dispose(disposing)
      End Try
   End Sub

   'Required by the Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'NOTE: The following procedure is required by the Windows Form Designer
   'It can be modified using the Windows Form Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashForm))
      Me.DashMenu = New System.Windows.Forms.MenuStrip()
      Me.MenuFile = New System.Windows.Forms.ToolStripMenuItem()
      Me.FileReconnect = New System.Windows.Forms.ToolStripMenuItem()
      Me.FileSeparator = New System.Windows.Forms.ToolStripSeparator()
      Me.FileExit = New System.Windows.Forms.ToolStripMenuItem()
      Me.MenuView = New System.Windows.Forms.ToolStripMenuItem()
      Me.ViewSettings = New System.Windows.Forms.ToolStripMenuItem()
      Me.ViewTune = New System.Windows.Forms.ToolStripMenuItem()
      Me.ViewSeparator1 = New System.Windows.Forms.ToolStripSeparator()
      Me.ViewData = New System.Windows.Forms.ToolStripMenuItem()
      Me.ViewTraffic = New System.Windows.Forms.ToolStripMenuItem()
      Me.ViewOptions = New System.Windows.Forms.ToolStripMenuItem()
      Me.LedRobot = New System.Windows.Forms.Label()
      Me.LabelStatus = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.PanelAuto = New System.Windows.Forms.Panel()
      Me.Label15 = New System.Windows.Forms.Label()
      Me.ListRRR = New System.Windows.Forms.ComboBox()
      Me.Label14 = New System.Windows.Forms.Label()
      Me.ListLLL = New System.Windows.Forms.ComboBox()
      Me.Label13 = New System.Windows.Forms.Label()
      Me.ListRLR = New System.Windows.Forms.ComboBox()
      Me.ListStart = New System.Windows.Forms.ComboBox()
      Me.Label11 = New System.Windows.Forms.Label()
      Me.ListDelay = New System.Windows.Forms.ComboBox()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.ListLRL = New System.Windows.Forms.ComboBox()
      Me.ButtonLiftScaleHigh = New System.Windows.Forms.Button()
      Me.ButtonLiftTravel = New System.Windows.Forms.Button()
      Me.Label5 = New System.Windows.Forms.Label()
      Me.PanelDrive = New System.Windows.Forms.Panel()
      Me.Label20 = New System.Windows.Forms.Label()
      Me.LabelShift = New System.Windows.Forms.Label()
      Me.Label19 = New System.Windows.Forms.Label()
      Me.Label16 = New System.Windows.Forms.Label()
      Me.LabelDriveRight = New System.Windows.Forms.Label()
      Me.LabelGyro = New System.Windows.Forms.Label()
      Me.LabelDriveLeft = New System.Windows.Forms.Label()
      Me.LabelEncoderRight = New System.Windows.Forms.Label()
      Me.LabelEncoderLeft = New System.Windows.Forms.Label()
      Me.Label8 = New System.Windows.Forms.Label()
      Me.Label7 = New System.Windows.Forms.Label()
      Me.Label6 = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.PanelLift = New System.Windows.Forms.Panel()
      Me.LabelLiftPwmBottom = New System.Windows.Forms.Label()
      Me.LabelLiftAmpsBottom = New System.Windows.Forms.Label()
      Me.LabelLiftAmpsTop = New System.Windows.Forms.Label()
      Me.LabelLiftPwmTop = New System.Windows.Forms.Label()
      Me.LabelLiftSetpoint = New System.Windows.Forms.Label()
      Me.LabelLiftNow = New System.Windows.Forms.Label()
      Me.ButtonLiftBumpDown = New System.Windows.Forms.Button()
      Me.ButtonLiftBumpUp = New System.Windows.Forms.Button()
      Me.ButtonLiftSwitch = New System.Windows.Forms.Button()
      Me.ButtonLiftScaleLow = New System.Windows.Forms.Button()
      Me.ButtonLiftScaleBal = New System.Windows.Forms.Button()
      Me.LiftPosition = New RobotDash.VerticalProgressBar()
      Me.LiftSetpoint = New RobotDash.VerticalProgressBar()
      Me.ButtonIntakeStow = New System.Windows.Forms.Button()
      Me.TimerClick = New System.Windows.Forms.Timer(Me.components)
      Me.ImageRollerL = New System.Windows.Forms.PictureBox()
      Me.LabelCube = New System.Windows.Forms.Label()
      Me.LabelGripperL = New System.Windows.Forms.Label()
      Me.LabelGripperR = New System.Windows.Forms.Label()
      Me.ImageRollerR = New System.Windows.Forms.PictureBox()
      Me.ArmPosition = New System.Windows.Forms.ProgressBar()
      Me.PanelIntake = New System.Windows.Forms.Panel()
      Me.ButtonIntakeTilt = New System.Windows.Forms.Button()
      Me.CubeNear = New System.Windows.Forms.Label()
      Me.CubeFar = New System.Windows.Forms.Label()
      Me.ButtonIntakeDrop = New System.Windows.Forms.Button()
      Me.ButtonIntakeLaunch = New System.Windows.Forms.Button()
      Me.ButtonIntakePickup = New System.Windows.Forms.Button()
      Me.ButtonIntakeEject = New System.Windows.Forms.Button()
      Me.LabelArmPwm = New System.Windows.Forms.Label()
      Me.LabelArmSetpoint = New System.Windows.Forms.Label()
      Me.ArmSetpoint = New System.Windows.Forms.ProgressBar()
      Me.LabelArmNow = New System.Windows.Forms.Label()
      Me.Label12 = New System.Windows.Forms.Label()
      Me.Label9 = New System.Windows.Forms.Label()
      Me.TimerRestart = New System.Windows.Forms.Timer(Me.components)
      Me.ButtonDataCapture = New System.Windows.Forms.Button()
      Me.DashMenu.SuspendLayout
      Me.PanelAuto.SuspendLayout
      Me.PanelDrive.SuspendLayout
      Me.PanelLift.SuspendLayout
      CType(Me.ImageRollerL,System.ComponentModel.ISupportInitialize).BeginInit
      CType(Me.ImageRollerR,System.ComponentModel.ISupportInitialize).BeginInit
      Me.PanelIntake.SuspendLayout
      Me.SuspendLayout
      '
      'DashMenu
      '
      Me.DashMenu.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.DashMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuFile, Me.MenuView})
      Me.DashMenu.Location = New System.Drawing.Point(0, 0)
      Me.DashMenu.Name = "DashMenu"
      Me.DashMenu.Size = New System.Drawing.Size(634, 24)
      Me.DashMenu.TabIndex = 0
      Me.DashMenu.Text = "MenuStrip1"
      '
      'MenuFile
      '
      Me.MenuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileReconnect, Me.FileSeparator, Me.FileExit})
      Me.MenuFile.Name = "MenuFile"
      Me.MenuFile.Size = New System.Drawing.Size(40, 20)
      Me.MenuFile.Text = "File"
      '
      'FileReconnect
      '
      Me.FileReconnect.Name = "FileReconnect"
      Me.FileReconnect.Size = New System.Drawing.Size(139, 22)
      Me.FileReconnect.Text = "Reconnect"
      '
      'FileSeparator
      '
      Me.FileSeparator.Name = "FileSeparator"
      Me.FileSeparator.Size = New System.Drawing.Size(136, 6)
      '
      'FileExit
      '
      Me.FileExit.Name = "FileExit"
      Me.FileExit.Size = New System.Drawing.Size(139, 22)
      Me.FileExit.Text = "Exit"
      '
      'MenuView
      '
      Me.MenuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewSettings, Me.ViewTune, Me.ViewSeparator1, Me.ViewData, Me.ViewTraffic, Me.ViewOptions})
      Me.MenuView.Name = "MenuView"
      Me.MenuView.Size = New System.Drawing.Size(49, 20)
      Me.MenuView.Text = "View"
      '
      'ViewSettings
      '
      Me.ViewSettings.Name = "ViewSettings"
      Me.ViewSettings.Size = New System.Drawing.Size(167, 22)
      Me.ViewSettings.Text = "Robot Settings"
      '
      'ViewTune
      '
      Me.ViewTune.Name = "ViewTune"
      Me.ViewTune.Size = New System.Drawing.Size(167, 22)
      Me.ViewTune.Text = "Tune PID"
      '
      'ViewSeparator1
      '
      Me.ViewSeparator1.Name = "ViewSeparator1"
      Me.ViewSeparator1.Size = New System.Drawing.Size(164, 6)
      '
      'ViewData
      '
      Me.ViewData.Name = "ViewData"
      Me.ViewData.Size = New System.Drawing.Size(167, 22)
      Me.ViewData.Text = "Data Tables"
      '
      'ViewTraffic
      '
      Me.ViewTraffic.Name = "ViewTraffic"
      Me.ViewTraffic.Size = New System.Drawing.Size(167, 22)
      Me.ViewTraffic.Text = "Host Traffic"
      '
      'ViewOptions
      '
      Me.ViewOptions.Name = "ViewOptions"
      Me.ViewOptions.Size = New System.Drawing.Size(167, 22)
      Me.ViewOptions.Text = "Options"
      '
      'LedRobot
      '
      Me.LedRobot.BackColor = System.Drawing.Color.WhiteSmoke
      Me.LedRobot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LedRobot.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LedRobot.Location = New System.Drawing.Point(567, 0)
      Me.LedRobot.Name = "LedRobot"
      Me.LedRobot.Size = New System.Drawing.Size(58, 24)
      Me.LedRobot.TabIndex = 24
      Me.LedRobot.Text = "Robot"
      Me.LedRobot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'LabelStatus
      '
      Me.LabelStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(252,Byte),Integer), CType(CType(252,Byte),Integer), CType(CType(252,Byte),Integer))
      Me.LabelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelStatus.ForeColor = System.Drawing.Color.Red
      Me.LabelStatus.Location = New System.Drawing.Point(416, 0)
      Me.LabelStatus.Name = "LabelStatus"
      Me.LabelStatus.Size = New System.Drawing.Size(146, 24)
      Me.LabelStatus.TabIndex = 25
      Me.LabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label2
      '
      Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label2.Location = New System.Drawing.Point(20, 28)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(110, 20)
      Me.Label2.TabIndex = 33
      Me.Label2.Text = "AUTONOMOUS"
      Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'PanelAuto
      '
      Me.PanelAuto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.PanelAuto.Controls.Add(Me.Label15)
      Me.PanelAuto.Controls.Add(Me.ListRRR)
      Me.PanelAuto.Controls.Add(Me.Label14)
      Me.PanelAuto.Controls.Add(Me.ListLLL)
      Me.PanelAuto.Controls.Add(Me.Label13)
      Me.PanelAuto.Controls.Add(Me.ListRLR)
      Me.PanelAuto.Controls.Add(Me.ListStart)
      Me.PanelAuto.Controls.Add(Me.Label11)
      Me.PanelAuto.Controls.Add(Me.ListDelay)
      Me.PanelAuto.Controls.Add(Me.Label4)
      Me.PanelAuto.Controls.Add(Me.Label3)
      Me.PanelAuto.Controls.Add(Me.ListLRL)
      Me.PanelAuto.Location = New System.Drawing.Point(10, 38)
      Me.PanelAuto.Name = "PanelAuto"
      Me.PanelAuto.Size = New System.Drawing.Size(350, 192)
      Me.PanelAuto.TabIndex = 0
      '
      'Label15
      '
      Me.Label15.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label15.Location = New System.Drawing.Point(6, 156)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(50, 20)
      Me.Label15.TabIndex = 44
      Me.Label15.Text = "RRR"
      Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'ListRRR
      '
      Me.ListRRR.BackColor = System.Drawing.SystemColors.Window
      Me.ListRRR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.ListRRR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.ListRRR.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.ListRRR.FormattingEnabled = true
      Me.ListRRR.ImeMode = System.Windows.Forms.ImeMode.Hangul
      Me.ListRRR.Items.AddRange(New Object() {"None"})
      Me.ListRRR.Location = New System.Drawing.Point(60, 150)
      Me.ListRRR.Name = "ListRRR"
      Me.ListRRR.Size = New System.Drawing.Size(272, 26)
      Me.ListRRR.TabIndex = 5
      Me.ListRRR.Tag = "4"
      '
      'Label14
      '
      Me.Label14.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label14.Location = New System.Drawing.Point(6, 121)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(50, 20)
      Me.Label14.TabIndex = 42
      Me.Label14.Text = "LLL"
      Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'ListLLL
      '
      Me.ListLLL.BackColor = System.Drawing.SystemColors.Window
      Me.ListLLL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.ListLLL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.ListLLL.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.ListLLL.FormattingEnabled = true
      Me.ListLLL.ImeMode = System.Windows.Forms.ImeMode.Hangul
      Me.ListLLL.Items.AddRange(New Object() {"None"})
      Me.ListLLL.Location = New System.Drawing.Point(60, 115)
      Me.ListLLL.Name = "ListLLL"
      Me.ListLLL.Size = New System.Drawing.Size(272, 26)
      Me.ListLLL.TabIndex = 4
      Me.ListLLL.Tag = "3"
      '
      'Label13
      '
      Me.Label13.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label13.Location = New System.Drawing.Point(6, 86)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(50, 20)
      Me.Label13.TabIndex = 40
      Me.Label13.Text = "RLR"
      Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'ListRLR
      '
      Me.ListRLR.BackColor = System.Drawing.SystemColors.Window
      Me.ListRLR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.ListRLR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.ListRLR.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.ListRLR.FormattingEnabled = true
      Me.ListRLR.ImeMode = System.Windows.Forms.ImeMode.Hangul
      Me.ListRLR.Items.AddRange(New Object() {"None"})
      Me.ListRLR.Location = New System.Drawing.Point(60, 80)
      Me.ListRLR.Name = "ListRLR"
      Me.ListRLR.Size = New System.Drawing.Size(272, 26)
      Me.ListRLR.TabIndex = 3
      Me.ListRLR.Tag = "2"
      '
      'ListStart
      '
      Me.ListStart.BackColor = System.Drawing.SystemColors.Window
      Me.ListStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.ListStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.ListStart.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.ListStart.FormattingEnabled = true
      Me.ListStart.ImeMode = System.Windows.Forms.ImeMode.Hangul
      Me.ListStart.Items.AddRange(New Object() {"Left", "Center", "Right"})
      Me.ListStart.Location = New System.Drawing.Point(60, 10)
      Me.ListStart.Name = "ListStart"
      Me.ListStart.Size = New System.Drawing.Size(90, 26)
      Me.ListStart.TabIndex = 0
      '
      'Label11
      '
      Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label11.Location = New System.Drawing.Point(5, 15)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(50, 20)
      Me.Label11.TabIndex = 36
      Me.Label11.Text = "Start"
      Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'ListDelay
      '
      Me.ListDelay.BackColor = System.Drawing.SystemColors.Window
      Me.ListDelay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.ListDelay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.ListDelay.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.ListDelay.FormattingEnabled = true
      Me.ListDelay.ImeMode = System.Windows.Forms.ImeMode.Hangul
      Me.ListDelay.Items.AddRange(New Object() {"None", "0.25", "0.50", "0.75", "1.00", "1.25", "1.50", "1.75", "2.00", "2.25", "2.50", "2.75", "3.00", "3.25", "3.50", "3.75", "4.00", ""})
      Me.ListDelay.Location = New System.Drawing.Point(252, 10)
      Me.ListDelay.Name = "ListDelay"
      Me.ListDelay.Size = New System.Drawing.Size(80, 26)
      Me.ListDelay.TabIndex = 1
      '
      'Label4
      '
      Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label4.Location = New System.Drawing.Point(156, 15)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(92, 20)
      Me.Label4.TabIndex = 35
      Me.Label4.Text = "Delay (sec)"
      Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'Label3
      '
      Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label3.Location = New System.Drawing.Point(6, 51)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(50, 20)
      Me.Label3.TabIndex = 34
      Me.Label3.Text = "LRL"
      Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'ListLRL
      '
      Me.ListLRL.BackColor = System.Drawing.SystemColors.Window
      Me.ListLRL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.ListLRL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.ListLRL.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.ListLRL.FormattingEnabled = true
      Me.ListLRL.ImeMode = System.Windows.Forms.ImeMode.Hangul
      Me.ListLRL.Items.AddRange(New Object() {"None"})
      Me.ListLRL.Location = New System.Drawing.Point(60, 45)
      Me.ListLRL.Name = "ListLRL"
      Me.ListLRL.Size = New System.Drawing.Size(272, 26)
      Me.ListLRL.TabIndex = 2
      Me.ListLRL.Tag = "1"
      '
      'ButtonLiftScaleHigh
      '
      Me.ButtonLiftScaleHigh.BackColor = System.Drawing.Color.FromArgb(CType(CType(190,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(190,Byte),Integer))
      Me.ButtonLiftScaleHigh.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.ButtonLiftScaleHigh.Location = New System.Drawing.Point(88, 60)
      Me.ButtonLiftScaleHigh.Name = "ButtonLiftScaleHigh"
      Me.ButtonLiftScaleHigh.Size = New System.Drawing.Size(150, 60)
      Me.ButtonLiftScaleHigh.TabIndex = 0
      Me.ButtonLiftScaleHigh.Tag = "1"
      Me.ButtonLiftScaleHigh.Text = " SCALE HIGH"
      Me.ButtonLiftScaleHigh.UseVisualStyleBackColor = false
      '
      'ButtonLiftTravel
      '
      Me.ButtonLiftTravel.BackColor = System.Drawing.Color.FromArgb(CType(CType(190,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(190,Byte),Integer))
      Me.ButtonLiftTravel.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.ButtonLiftTravel.Location = New System.Drawing.Point(88, 530)
      Me.ButtonLiftTravel.Name = "ButtonLiftTravel"
      Me.ButtonLiftTravel.Size = New System.Drawing.Size(150, 60)
      Me.ButtonLiftTravel.TabIndex = 5
      Me.ButtonLiftTravel.Tag = "5"
      Me.ButtonLiftTravel.Text = "TRAVEL"
      Me.ButtonLiftTravel.UseVisualStyleBackColor = false
      '
      'Label5
      '
      Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label5.Location = New System.Drawing.Point(20, 235)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(55, 20)
      Me.Label5.TabIndex = 40
      Me.Label5.Text = "DRIVE"
      Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'PanelDrive
      '
      Me.PanelDrive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.PanelDrive.Controls.Add(Me.Label20)
      Me.PanelDrive.Controls.Add(Me.LabelShift)
      Me.PanelDrive.Controls.Add(Me.Label19)
      Me.PanelDrive.Controls.Add(Me.Label16)
      Me.PanelDrive.Controls.Add(Me.LabelDriveRight)
      Me.PanelDrive.Controls.Add(Me.LabelGyro)
      Me.PanelDrive.Controls.Add(Me.LabelDriveLeft)
      Me.PanelDrive.Controls.Add(Me.LabelEncoderRight)
      Me.PanelDrive.Controls.Add(Me.LabelEncoderLeft)
      Me.PanelDrive.Controls.Add(Me.Label8)
      Me.PanelDrive.Controls.Add(Me.Label7)
      Me.PanelDrive.Controls.Add(Me.Label6)
      Me.PanelDrive.Location = New System.Drawing.Point(10, 245)
      Me.PanelDrive.Name = "PanelDrive"
      Me.PanelDrive.Size = New System.Drawing.Size(350, 92)
      Me.PanelDrive.TabIndex = 39
      '
      'Label20
      '
      Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label20.Location = New System.Drawing.Point(198, 36)
      Me.Label20.Name = "Label20"
      Me.Label20.Size = New System.Drawing.Size(50, 20)
      Me.Label20.TabIndex = 61
      Me.Label20.Text = "Right"
      Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'LabelShift
      '
      Me.LabelShift.BackColor = System.Drawing.Color.White
      Me.LabelShift.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelShift.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelShift.ForeColor = System.Drawing.Color.DarkGreen
      Me.LabelShift.Location = New System.Drawing.Point(252, 60)
      Me.LabelShift.Name = "LabelShift"
      Me.LabelShift.Size = New System.Drawing.Size(80, 20)
      Me.LabelShift.TabIndex = 60
      Me.LabelShift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label19
      '
      Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label19.Location = New System.Drawing.Point(198, 11)
      Me.Label19.Name = "Label19"
      Me.Label19.Size = New System.Drawing.Size(50, 20)
      Me.Label19.TabIndex = 59
      Me.Label19.Text = "Right"
      Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'Label16
      '
      Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label16.Location = New System.Drawing.Point(6, 11)
      Me.Label16.Name = "Label16"
      Me.Label16.Size = New System.Drawing.Size(100, 20)
      Me.Label16.TabIndex = 58
      Me.Label16.Text = "Motors: Left"
      Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'LabelDriveRight
      '
      Me.LabelDriveRight.BackColor = System.Drawing.Color.White
      Me.LabelDriveRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelDriveRight.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelDriveRight.ForeColor = System.Drawing.Color.Black
      Me.LabelDriveRight.Location = New System.Drawing.Point(252, 10)
      Me.LabelDriveRight.Name = "LabelDriveRight"
      Me.LabelDriveRight.Size = New System.Drawing.Size(80, 20)
      Me.LabelDriveRight.TabIndex = 57
      Me.LabelDriveRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'LabelGyro
      '
      Me.LabelGyro.BackColor = System.Drawing.Color.White
      Me.LabelGyro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelGyro.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelGyro.Location = New System.Drawing.Point(112, 60)
      Me.LabelGyro.Name = "LabelGyro"
      Me.LabelGyro.Size = New System.Drawing.Size(80, 20)
      Me.LabelGyro.TabIndex = 40
      Me.LabelGyro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'LabelDriveLeft
      '
      Me.LabelDriveLeft.BackColor = System.Drawing.Color.White
      Me.LabelDriveLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelDriveLeft.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelDriveLeft.ForeColor = System.Drawing.Color.Black
      Me.LabelDriveLeft.Location = New System.Drawing.Point(112, 10)
      Me.LabelDriveLeft.Name = "LabelDriveLeft"
      Me.LabelDriveLeft.Size = New System.Drawing.Size(80, 20)
      Me.LabelDriveLeft.TabIndex = 56
      Me.LabelDriveLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'LabelEncoderRight
      '
      Me.LabelEncoderRight.BackColor = System.Drawing.Color.White
      Me.LabelEncoderRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelEncoderRight.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelEncoderRight.Location = New System.Drawing.Point(252, 35)
      Me.LabelEncoderRight.Name = "LabelEncoderRight"
      Me.LabelEncoderRight.Size = New System.Drawing.Size(80, 20)
      Me.LabelEncoderRight.TabIndex = 39
      Me.LabelEncoderRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'LabelEncoderLeft
      '
      Me.LabelEncoderLeft.BackColor = System.Drawing.Color.White
      Me.LabelEncoderLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelEncoderLeft.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelEncoderLeft.Location = New System.Drawing.Point(112, 35)
      Me.LabelEncoderLeft.Name = "LabelEncoderLeft"
      Me.LabelEncoderLeft.Size = New System.Drawing.Size(80, 20)
      Me.LabelEncoderLeft.TabIndex = 38
      Me.LabelEncoderLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label8
      '
      Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label8.Location = New System.Drawing.Point(24, 60)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(50, 20)
      Me.Label8.TabIndex = 37
      Me.Label8.Text = "Gyro:"
      Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'Label7
      '
      Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label7.Location = New System.Drawing.Point(198, 60)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(50, 20)
      Me.Label7.TabIndex = 36
      Me.Label7.Text = "Shift:"
      Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'Label6
      '
      Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label6.Location = New System.Drawing.Point(6, 36)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(100, 20)
      Me.Label6.TabIndex = 35
      Me.Label6.Text = "Encoder: Left"
      Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'Label1
      '
      Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label1.Location = New System.Drawing.Point(389, 28)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(50, 20)
      Me.Label1.TabIndex = 42
      Me.Label1.Text = "LIFT"
      Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'PanelLift
      '
      Me.PanelLift.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.PanelLift.Controls.Add(Me.LabelLiftPwmBottom)
      Me.PanelLift.Controls.Add(Me.LabelLiftAmpsBottom)
      Me.PanelLift.Controls.Add(Me.LabelLiftAmpsTop)
      Me.PanelLift.Controls.Add(Me.LabelLiftPwmTop)
      Me.PanelLift.Controls.Add(Me.LabelLiftSetpoint)
      Me.PanelLift.Controls.Add(Me.LabelLiftNow)
      Me.PanelLift.Controls.Add(Me.ButtonLiftBumpDown)
      Me.PanelLift.Controls.Add(Me.ButtonLiftBumpUp)
      Me.PanelLift.Controls.Add(Me.ButtonLiftSwitch)
      Me.PanelLift.Controls.Add(Me.ButtonLiftScaleLow)
      Me.PanelLift.Controls.Add(Me.ButtonLiftScaleBal)
      Me.PanelLift.Controls.Add(Me.LiftPosition)
      Me.PanelLift.Controls.Add(Me.LiftSetpoint)
      Me.PanelLift.Controls.Add(Me.ButtonLiftTravel)
      Me.PanelLift.Controls.Add(Me.ButtonLiftScaleHigh)
      Me.PanelLift.Location = New System.Drawing.Point(370, 38)
      Me.PanelLift.Name = "PanelLift"
      Me.PanelLift.Size = New System.Drawing.Size(256, 649)
      Me.PanelLift.TabIndex = 1
      '
      'LabelLiftPwmBottom
      '
      Me.LabelLiftPwmBottom.BackColor = System.Drawing.Color.White
      Me.LabelLiftPwmBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelLiftPwmBottom.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelLiftPwmBottom.Location = New System.Drawing.Point(98, 619)
      Me.LabelLiftPwmBottom.Name = "LabelLiftPwmBottom"
      Me.LabelLiftPwmBottom.Size = New System.Drawing.Size(65, 20)
      Me.LabelLiftPwmBottom.TabIndex = 63
      Me.LabelLiftPwmBottom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'LabelLiftAmpsBottom
      '
      Me.LabelLiftAmpsBottom.BackColor = System.Drawing.Color.White
      Me.LabelLiftAmpsBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelLiftAmpsBottom.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelLiftAmpsBottom.Location = New System.Drawing.Point(164, 619)
      Me.LabelLiftAmpsBottom.Name = "LabelLiftAmpsBottom"
      Me.LabelLiftAmpsBottom.Size = New System.Drawing.Size(65, 20)
      Me.LabelLiftAmpsBottom.TabIndex = 62
      Me.LabelLiftAmpsBottom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'LabelLiftAmpsTop
      '
      Me.LabelLiftAmpsTop.BackColor = System.Drawing.Color.White
      Me.LabelLiftAmpsTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelLiftAmpsTop.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelLiftAmpsTop.Location = New System.Drawing.Point(164, 10)
      Me.LabelLiftAmpsTop.Name = "LabelLiftAmpsTop"
      Me.LabelLiftAmpsTop.Size = New System.Drawing.Size(65, 20)
      Me.LabelLiftAmpsTop.TabIndex = 61
      Me.LabelLiftAmpsTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'LabelLiftPwmTop
      '
      Me.LabelLiftPwmTop.BackColor = System.Drawing.Color.White
      Me.LabelLiftPwmTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelLiftPwmTop.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelLiftPwmTop.Location = New System.Drawing.Point(98, 10)
      Me.LabelLiftPwmTop.Name = "LabelLiftPwmTop"
      Me.LabelLiftPwmTop.Size = New System.Drawing.Size(65, 20)
      Me.LabelLiftPwmTop.TabIndex = 58
      Me.LabelLiftPwmTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'LabelLiftSetpoint
      '
      Me.LabelLiftSetpoint.BackColor = System.Drawing.Color.White
      Me.LabelLiftSetpoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelLiftSetpoint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelLiftSetpoint.Location = New System.Drawing.Point(45, 10)
      Me.LabelLiftSetpoint.Name = "LabelLiftSetpoint"
      Me.LabelLiftSetpoint.Size = New System.Drawing.Size(40, 20)
      Me.LabelLiftSetpoint.TabIndex = 43
      Me.LabelLiftSetpoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'LabelLiftNow
      '
      Me.LabelLiftNow.BackColor = System.Drawing.Color.White
      Me.LabelLiftNow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelLiftNow.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelLiftNow.Location = New System.Drawing.Point(4, 10)
      Me.LabelLiftNow.Name = "LabelLiftNow"
      Me.LabelLiftNow.Size = New System.Drawing.Size(40, 20)
      Me.LabelLiftNow.TabIndex = 42
      Me.LabelLiftNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'ButtonLiftBumpDown
      '
      Me.ButtonLiftBumpDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(190,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(190,Byte),Integer))
      Me.ButtonLiftBumpDown.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.ButtonLiftBumpDown.Image = CType(resources.GetObject("ButtonLiftBumpDown.Image"),System.Drawing.Image)
      Me.ButtonLiftBumpDown.Location = New System.Drawing.Point(128, 445)
      Me.ButtonLiftBumpDown.Name = "ButtonLiftBumpDown"
      Me.ButtonLiftBumpDown.Size = New System.Drawing.Size(70, 60)
      Me.ButtonLiftBumpDown.TabIndex = 41
      Me.ButtonLiftBumpDown.Tag = "6"
      Me.ButtonLiftBumpDown.UseVisualStyleBackColor = false
      '
      'ButtonLiftBumpUp
      '
      Me.ButtonLiftBumpUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(190,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(190,Byte),Integer))
      Me.ButtonLiftBumpUp.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.ButtonLiftBumpUp.Image = CType(resources.GetObject("ButtonLiftBumpUp.Image"),System.Drawing.Image)
      Me.ButtonLiftBumpUp.Location = New System.Drawing.Point(128, 370)
      Me.ButtonLiftBumpUp.Name = "ButtonLiftBumpUp"
      Me.ButtonLiftBumpUp.Size = New System.Drawing.Size(70, 60)
      Me.ButtonLiftBumpUp.TabIndex = 40
      Me.ButtonLiftBumpUp.Tag = "7"
      Me.ButtonLiftBumpUp.UseVisualStyleBackColor = false
      '
      'ButtonLiftSwitch
      '
      Me.ButtonLiftSwitch.BackColor = System.Drawing.Color.FromArgb(CType(CType(190,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(190,Byte),Integer))
      Me.ButtonLiftSwitch.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.ButtonLiftSwitch.Location = New System.Drawing.Point(88, 285)
      Me.ButtonLiftSwitch.Name = "ButtonLiftSwitch"
      Me.ButtonLiftSwitch.Size = New System.Drawing.Size(150, 60)
      Me.ButtonLiftSwitch.TabIndex = 3
      Me.ButtonLiftSwitch.Tag = "4"
      Me.ButtonLiftSwitch.Text = "SWITCH"
      Me.ButtonLiftSwitch.UseVisualStyleBackColor = false
      '
      'ButtonLiftScaleLow
      '
      Me.ButtonLiftScaleLow.BackColor = System.Drawing.Color.FromArgb(CType(CType(190,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(190,Byte),Integer))
      Me.ButtonLiftScaleLow.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.ButtonLiftScaleLow.Location = New System.Drawing.Point(88, 210)
      Me.ButtonLiftScaleLow.Name = "ButtonLiftScaleLow"
      Me.ButtonLiftScaleLow.Size = New System.Drawing.Size(150, 60)
      Me.ButtonLiftScaleLow.TabIndex = 2
      Me.ButtonLiftScaleLow.Tag = "3"
      Me.ButtonLiftScaleLow.Text = " SCALE LOW"
      Me.ButtonLiftScaleLow.UseVisualStyleBackColor = false
      '
      'ButtonLiftScaleBal
      '
      Me.ButtonLiftScaleBal.BackColor = System.Drawing.Color.FromArgb(CType(CType(190,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(190,Byte),Integer))
      Me.ButtonLiftScaleBal.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.ButtonLiftScaleBal.Location = New System.Drawing.Point(88, 135)
      Me.ButtonLiftScaleBal.Name = "ButtonLiftScaleBal"
      Me.ButtonLiftScaleBal.Size = New System.Drawing.Size(150, 60)
      Me.ButtonLiftScaleBal.TabIndex = 1
      Me.ButtonLiftScaleBal.Tag = "2"
      Me.ButtonLiftScaleBal.Text = " SCALE BALANCED"
      Me.ButtonLiftScaleBal.UseVisualStyleBackColor = false
      '
      'LiftPosition
      '
      Me.LiftPosition.BackColor = System.Drawing.Color.White
      Me.LiftPosition.ForeColor = System.Drawing.Color.LimeGreen
      Me.LiftPosition.Location = New System.Drawing.Point(15, 35)
      Me.LiftPosition.Name = "LiftPosition"
      Me.LiftPosition.Size = New System.Drawing.Size(20, 604)
      Me.LiftPosition.Style = System.Windows.Forms.ProgressBarStyle.Continuous
      Me.LiftPosition.TabIndex = 35
      '
      'LiftSetpoint
      '
      Me.LiftSetpoint.BackColor = System.Drawing.Color.White
      Me.LiftSetpoint.ForeColor = System.Drawing.Color.Orange
      Me.LiftSetpoint.Location = New System.Drawing.Point(54, 35)
      Me.LiftSetpoint.Name = "LiftSetpoint"
      Me.LiftSetpoint.Size = New System.Drawing.Size(20, 604)
      Me.LiftSetpoint.Style = System.Windows.Forms.ProgressBarStyle.Continuous
      Me.LiftSetpoint.TabIndex = 37
      '
      'ButtonIntakeStow
      '
      Me.ButtonIntakeStow.BackColor = System.Drawing.Color.FromArgb(CType(CType(190,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(190,Byte),Integer))
      Me.ButtonIntakeStow.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.ButtonIntakeStow.Location = New System.Drawing.Point(18, 266)
      Me.ButtonIntakeStow.Name = "ButtonIntakeStow"
      Me.ButtonIntakeStow.Size = New System.Drawing.Size(150, 60)
      Me.ButtonIntakeStow.TabIndex = 4
      Me.ButtonIntakeStow.Tag = "9"
      Me.ButtonIntakeStow.Text = "STOW"
      Me.ButtonIntakeStow.UseVisualStyleBackColor = false
      '
      'TimerClick
      '
      '
      'ImageRollerL
      '
      Me.ImageRollerL.BackColor = System.Drawing.Color.FromArgb(CType(CType(230,Byte),Integer), CType(CType(230,Byte),Integer), CType(CType(230,Byte),Integer))
      Me.ImageRollerL.Location = New System.Drawing.Point(88, 14)
      Me.ImageRollerL.Name = "ImageRollerL"
      Me.ImageRollerL.Size = New System.Drawing.Size(38, 38)
      Me.ImageRollerL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
      Me.ImageRollerL.TabIndex = 43
      Me.ImageRollerL.TabStop = false
      '
      'LabelCube
      '
      Me.LabelCube.BackColor = System.Drawing.Color.Yellow
      Me.LabelCube.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelCube.Location = New System.Drawing.Point(155, 14)
      Me.LabelCube.Name = "LabelCube"
      Me.LabelCube.Size = New System.Drawing.Size(38, 38)
      Me.LabelCube.TabIndex = 44
      Me.LabelCube.Visible = false
      '
      'LabelGripperL
      '
      Me.LabelGripperL.BackColor = System.Drawing.Color.FromArgb(CType(CType(230,Byte),Integer), CType(CType(230,Byte),Integer), CType(CType(230,Byte),Integer))
      Me.LabelGripperL.Font = New System.Drawing.Font("Verdana", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelGripperL.Location = New System.Drawing.Point(130, 4)
      Me.LabelGripperL.Name = "LabelGripperL"
      Me.LabelGripperL.Size = New System.Drawing.Size(38, 55)
      Me.LabelGripperL.TabIndex = 45
      Me.LabelGripperL.Text = "\"
      Me.LabelGripperL.TextAlign = System.Drawing.ContentAlignment.TopRight
      '
      'LabelGripperR
      '
      Me.LabelGripperR.BackColor = System.Drawing.Color.FromArgb(CType(CType(230,Byte),Integer), CType(CType(230,Byte),Integer), CType(CType(230,Byte),Integer))
      Me.LabelGripperR.Font = New System.Drawing.Font("Verdana", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelGripperR.Location = New System.Drawing.Point(185, 4)
      Me.LabelGripperR.Name = "LabelGripperR"
      Me.LabelGripperR.Size = New System.Drawing.Size(38, 55)
      Me.LabelGripperR.TabIndex = 46
      Me.LabelGripperR.Text = "/"
      '
      'ImageRollerR
      '
      Me.ImageRollerR.BackColor = System.Drawing.Color.FromArgb(CType(CType(230,Byte),Integer), CType(CType(230,Byte),Integer), CType(CType(230,Byte),Integer))
      Me.ImageRollerR.Location = New System.Drawing.Point(222, 14)
      Me.ImageRollerR.Name = "ImageRollerR"
      Me.ImageRollerR.Size = New System.Drawing.Size(38, 38)
      Me.ImageRollerR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
      Me.ImageRollerR.TabIndex = 47
      Me.ImageRollerR.TabStop = false
      '
      'ArmPosition
      '
      Me.ArmPosition.BackColor = System.Drawing.Color.White
      Me.ArmPosition.ForeColor = System.Drawing.Color.LimeGreen
      Me.ArmPosition.Location = New System.Drawing.Point(75, 66)
      Me.ArmPosition.Name = "ArmPosition"
      Me.ArmPosition.Size = New System.Drawing.Size(200, 20)
      Me.ArmPosition.Style = System.Windows.Forms.ProgressBarStyle.Continuous
      Me.ArmPosition.TabIndex = 48
      '
      'PanelIntake
      '
      Me.PanelIntake.BackColor = System.Drawing.Color.FromArgb(CType(CType(230,Byte),Integer), CType(CType(230,Byte),Integer), CType(CType(230,Byte),Integer))
      Me.PanelIntake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.PanelIntake.Controls.Add(Me.ButtonIntakeTilt)
      Me.PanelIntake.Controls.Add(Me.CubeNear)
      Me.PanelIntake.Controls.Add(Me.CubeFar)
      Me.PanelIntake.Controls.Add(Me.ButtonIntakeDrop)
      Me.PanelIntake.Controls.Add(Me.ButtonIntakeLaunch)
      Me.PanelIntake.Controls.Add(Me.ButtonIntakePickup)
      Me.PanelIntake.Controls.Add(Me.ButtonIntakeEject)
      Me.PanelIntake.Controls.Add(Me.LabelArmPwm)
      Me.PanelIntake.Controls.Add(Me.LabelArmSetpoint)
      Me.PanelIntake.Controls.Add(Me.ArmSetpoint)
      Me.PanelIntake.Controls.Add(Me.ButtonIntakeStow)
      Me.PanelIntake.Controls.Add(Me.LabelArmNow)
      Me.PanelIntake.Controls.Add(Me.Label12)
      Me.PanelIntake.Controls.Add(Me.LabelCube)
      Me.PanelIntake.Controls.Add(Me.ImageRollerL)
      Me.PanelIntake.Controls.Add(Me.ImageRollerR)
      Me.PanelIntake.Controls.Add(Me.ArmPosition)
      Me.PanelIntake.Controls.Add(Me.LabelGripperL)
      Me.PanelIntake.Controls.Add(Me.LabelGripperR)
      Me.PanelIntake.Location = New System.Drawing.Point(10, 352)
      Me.PanelIntake.Name = "PanelIntake"
      Me.PanelIntake.Size = New System.Drawing.Size(350, 335)
      Me.PanelIntake.TabIndex = 49
      '
      'ButtonIntakeTilt
      '
      Me.ButtonIntakeTilt.BackColor = System.Drawing.Color.FromArgb(CType(CType(190,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(190,Byte),Integer))
      Me.ButtonIntakeTilt.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.ButtonIntakeTilt.Location = New System.Drawing.Point(180, 193)
      Me.ButtonIntakeTilt.Name = "ButtonIntakeTilt"
      Me.ButtonIntakeTilt.Size = New System.Drawing.Size(150, 60)
      Me.ButtonIntakeTilt.TabIndex = 66
      Me.ButtonIntakeTilt.Tag = "13"
      Me.ButtonIntakeTilt.Text = "TILT"
      Me.ButtonIntakeTilt.UseVisualStyleBackColor = false
      '
      'CubeNear
      '
      Me.CubeNear.BackColor = System.Drawing.Color.WhiteSmoke
      Me.CubeNear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.CubeNear.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.CubeNear.Location = New System.Drawing.Point(265, 42)
      Me.CubeNear.Name = "CubeNear"
      Me.CubeNear.Size = New System.Drawing.Size(10, 10)
      Me.CubeNear.TabIndex = 65
      Me.CubeNear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'CubeFar
      '
      Me.CubeFar.BackColor = System.Drawing.Color.WhiteSmoke
      Me.CubeFar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.CubeFar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.CubeFar.Location = New System.Drawing.Point(265, 29)
      Me.CubeFar.Name = "CubeFar"
      Me.CubeFar.Size = New System.Drawing.Size(10, 10)
      Me.CubeFar.TabIndex = 64
      Me.CubeFar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'ButtonIntakeDrop
      '
      Me.ButtonIntakeDrop.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(210,Byte),Integer), CType(CType(210,Byte),Integer))
      Me.ButtonIntakeDrop.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.ButtonIntakeDrop.Location = New System.Drawing.Point(18, 194)
      Me.ButtonIntakeDrop.Name = "ButtonIntakeDrop"
      Me.ButtonIntakeDrop.Size = New System.Drawing.Size(150, 60)
      Me.ButtonIntakeDrop.TabIndex = 63
      Me.ButtonIntakeDrop.Tag = "12"
      Me.ButtonIntakeDrop.Text = "DROP"
      Me.ButtonIntakeDrop.UseVisualStyleBackColor = false
      '
      'ButtonIntakeLaunch
      '
      Me.ButtonIntakeLaunch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(210,Byte),Integer), CType(CType(210,Byte),Integer))
      Me.ButtonIntakeLaunch.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.ButtonIntakeLaunch.Location = New System.Drawing.Point(180, 122)
      Me.ButtonIntakeLaunch.Name = "ButtonIntakeLaunch"
      Me.ButtonIntakeLaunch.Size = New System.Drawing.Size(150, 60)
      Me.ButtonIntakeLaunch.TabIndex = 62
      Me.ButtonIntakeLaunch.Tag = "11"
      Me.ButtonIntakeLaunch.Text = "LAUNCH"
      Me.ButtonIntakeLaunch.UseVisualStyleBackColor = false
      '
      'ButtonIntakePickup
      '
      Me.ButtonIntakePickup.BackColor = System.Drawing.Color.FromArgb(CType(CType(190,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(190,Byte),Integer))
      Me.ButtonIntakePickup.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.ButtonIntakePickup.Location = New System.Drawing.Point(180, 265)
      Me.ButtonIntakePickup.Name = "ButtonIntakePickup"
      Me.ButtonIntakePickup.Size = New System.Drawing.Size(150, 60)
      Me.ButtonIntakePickup.TabIndex = 61
      Me.ButtonIntakePickup.Tag = "8"
      Me.ButtonIntakePickup.Text = "PICKUP"
      Me.ButtonIntakePickup.UseVisualStyleBackColor = false
      '
      'ButtonIntakeEject
      '
      Me.ButtonIntakeEject.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(210,Byte),Integer), CType(CType(210,Byte),Integer))
      Me.ButtonIntakeEject.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.ButtonIntakeEject.Location = New System.Drawing.Point(18, 122)
      Me.ButtonIntakeEject.Name = "ButtonIntakeEject"
      Me.ButtonIntakeEject.Size = New System.Drawing.Size(150, 60)
      Me.ButtonIntakeEject.TabIndex = 60
      Me.ButtonIntakeEject.Tag = "10"
      Me.ButtonIntakeEject.Text = "EJECT"
      Me.ButtonIntakeEject.UseVisualStyleBackColor = false
      '
      'LabelArmPwm
      '
      Me.LabelArmPwm.BackColor = System.Drawing.Color.White
      Me.LabelArmPwm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelArmPwm.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelArmPwm.Location = New System.Drawing.Point(5, 90)
      Me.LabelArmPwm.Name = "LabelArmPwm"
      Me.LabelArmPwm.Size = New System.Drawing.Size(65, 20)
      Me.LabelArmPwm.TabIndex = 59
      Me.LabelArmPwm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'LabelArmSetpoint
      '
      Me.LabelArmSetpoint.BackColor = System.Drawing.Color.White
      Me.LabelArmSetpoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelArmSetpoint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelArmSetpoint.Location = New System.Drawing.Point(280, 90)
      Me.LabelArmSetpoint.Name = "LabelArmSetpoint"
      Me.LabelArmSetpoint.Size = New System.Drawing.Size(50, 20)
      Me.LabelArmSetpoint.TabIndex = 55
      Me.LabelArmSetpoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'ArmSetpoint
      '
      Me.ArmSetpoint.BackColor = System.Drawing.Color.White
      Me.ArmSetpoint.ForeColor = System.Drawing.Color.Orange
      Me.ArmSetpoint.Location = New System.Drawing.Point(75, 90)
      Me.ArmSetpoint.Name = "ArmSetpoint"
      Me.ArmSetpoint.Size = New System.Drawing.Size(200, 20)
      Me.ArmSetpoint.Style = System.Windows.Forms.ProgressBarStyle.Continuous
      Me.ArmSetpoint.TabIndex = 54
      '
      'LabelArmNow
      '
      Me.LabelArmNow.BackColor = System.Drawing.Color.White
      Me.LabelArmNow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelArmNow.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelArmNow.Location = New System.Drawing.Point(280, 66)
      Me.LabelArmNow.Name = "LabelArmNow"
      Me.LabelArmNow.Size = New System.Drawing.Size(50, 20)
      Me.LabelArmNow.TabIndex = 51
      Me.LabelArmNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label12
      '
      Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label12.Location = New System.Drawing.Point(7, 54)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(60, 35)
      Me.Label12.TabIndex = 50
      Me.Label12.Text = "Intake Arm"
      Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label9
      '
      Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label9.Location = New System.Drawing.Point(20, 342)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(125, 20)
      Me.Label9.TabIndex = 50
      Me.Label9.Text = "CUBE HANDLER"
      Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'TimerRestart
      '
      Me.TimerRestart.Interval = 1000
      '
      'ButtonDataCapture
      '
      Me.ButtonDataCapture.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ButtonDataCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.ButtonDataCapture.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.ButtonDataCapture.Location = New System.Drawing.Point(301, 0)
      Me.ButtonDataCapture.Name = "ButtonDataCapture"
      Me.ButtonDataCapture.Size = New System.Drawing.Size(110, 24)
      Me.ButtonDataCapture.TabIndex = 51
      Me.ButtonDataCapture.Tag = "1"
      Me.ButtonDataCapture.Text = "Data Capture"
      Me.ButtonDataCapture.UseVisualStyleBackColor = false
      '
      'DashForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 14!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230,Byte),Integer), CType(CType(230,Byte),Integer), CType(CType(230,Byte),Integer))
      Me.ClientSize = New System.Drawing.Size(634, 691)
      Me.Controls.Add(Me.ButtonDataCapture)
      Me.Controls.Add(Me.Label9)
      Me.Controls.Add(Me.PanelIntake)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.PanelLift)
      Me.Controls.Add(Me.Label5)
      Me.Controls.Add(Me.PanelDrive)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.PanelAuto)
      Me.Controls.Add(Me.LabelStatus)
      Me.Controls.Add(Me.LedRobot)
      Me.Controls.Add(Me.DashMenu)
      Me.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
      Me.MainMenuStrip = Me.DashMenu
      Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
      Me.MaximizeBox = false
      Me.Name = "DashForm"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Dashboard: 525"
      Me.DashMenu.ResumeLayout(false)
      Me.DashMenu.PerformLayout
      Me.PanelAuto.ResumeLayout(false)
      Me.PanelDrive.ResumeLayout(false)
      Me.PanelLift.ResumeLayout(false)
      CType(Me.ImageRollerL,System.ComponentModel.ISupportInitialize).EndInit
      CType(Me.ImageRollerR,System.ComponentModel.ISupportInitialize).EndInit
      Me.PanelIntake.ResumeLayout(false)
      Me.ResumeLayout(false)
      Me.PerformLayout

End Sub

   Friend WithEvents DashMenu As MenuStrip
   Friend WithEvents MenuFile As ToolStripMenuItem
   Friend WithEvents FileExit As ToolStripMenuItem
   Friend WithEvents MenuView As ToolStripMenuItem
   Friend WithEvents ViewSettings As ToolStripMenuItem
   Friend WithEvents ViewTune As ToolStripMenuItem
   Friend WithEvents ViewSeparator1 As ToolStripSeparator
   Friend WithEvents ViewData As ToolStripMenuItem
   Friend WithEvents ViewOptions As ToolStripMenuItem
   Friend WithEvents LedRobot As Label
   Friend WithEvents LabelStatus As Label
   Friend WithEvents ViewTraffic As ToolStripMenuItem
   Friend WithEvents Label2 As Label
   Friend WithEvents PanelAuto As Panel
   Friend WithEvents ListDelay As ComboBox
   Friend WithEvents Label4 As Label
   Friend WithEvents Label3 As Label
   Friend WithEvents ListLRL As ComboBox
   Friend WithEvents LiftPosition As VerticalProgressBar
   Friend WithEvents ButtonLiftScaleHigh As Button
   Friend WithEvents LiftSetpoint As VerticalProgressBar
   Friend WithEvents ButtonLiftTravel As Button
   Friend WithEvents Label5 As Label
   Friend WithEvents PanelDrive As Panel
   Friend WithEvents LabelGyro As Label
   Friend WithEvents LabelEncoderRight As Label
   Friend WithEvents LabelEncoderLeft As Label
   Friend WithEvents Label8 As Label
   Friend WithEvents Label7 As Label
   Friend WithEvents Label6 As Label
   Friend WithEvents Label1 As Label
   Friend WithEvents PanelLift As Panel
   Friend WithEvents ButtonLiftScaleLow As Button
   Friend WithEvents ButtonLiftScaleBal As Button
   Friend WithEvents ButtonIntakeStow As Button
   Friend WithEvents ButtonLiftSwitch As Button
   Friend WithEvents TimerClick As Timer
   Friend WithEvents ListStart As ComboBox
   Friend WithEvents Label11 As Label
   Friend WithEvents Label15 As Label
   Friend WithEvents ListRRR As ComboBox
   Friend WithEvents Label14 As Label
   Friend WithEvents ListLLL As ComboBox
   Friend WithEvents Label13 As Label
   Friend WithEvents ListRLR As ComboBox
   Friend WithEvents ButtonLiftBumpDown As Button
   Friend WithEvents ButtonLiftBumpUp As Button
   Friend WithEvents LabelLiftNow As Label
   Friend WithEvents FileReconnect As ToolStripMenuItem
   Friend WithEvents FileSeparator As ToolStripSeparator
   Friend WithEvents LabelLiftSetpoint As Label
   Friend WithEvents ImageRollerL As PictureBox
   Friend WithEvents LabelCube As Label
   Friend WithEvents LabelGripperL As Label
   Friend WithEvents LabelGripperR As Label
   Friend WithEvents ImageRollerR As PictureBox
   Friend WithEvents ArmPosition As ProgressBar
   Friend WithEvents PanelIntake As Panel
   Friend WithEvents Label9 As Label
   Friend WithEvents LabelArmNow As Label
   Friend WithEvents Label12 As Label
   Friend WithEvents LabelArmSetpoint As Label
   Friend WithEvents ArmSetpoint As ProgressBar
   Friend WithEvents LabelDriveRight As Label
   Friend WithEvents LabelDriveLeft As Label
   Friend WithEvents LabelLiftPwmTop As Label
   Friend WithEvents LabelArmPwm As Label
   Friend WithEvents Label19 As Label
   Friend WithEvents Label16 As Label
   Friend WithEvents ButtonIntakeLaunch As Button
   Friend WithEvents ButtonIntakePickup As Button
   Friend WithEvents ButtonIntakeEject As Button
   Friend WithEvents LabelLiftAmpsBottom As Label
   Friend WithEvents LabelLiftAmpsTop As Label
   Friend WithEvents TimerRestart As Timer
   Friend WithEvents LabelShift As Label
   Friend WithEvents Label20 As Label
   Friend WithEvents ButtonIntakeDrop As Button
   Friend WithEvents LabelLiftPwmBottom As Label
   Friend WithEvents CubeNear As Label
   Friend WithEvents CubeFar As Label
   Friend WithEvents ButtonIntakeTilt As Button
   Friend WithEvents ButtonDataCapture As Button
End Class
