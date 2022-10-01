<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TunePidForm
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TunePidForm))
      Me.ListPID = New System.Windows.Forms.ComboBox()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.TextSetpoint = New System.Windows.Forms.TextBox()
      Me.TextMaxOut = New System.Windows.Forms.TextBox()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.Panel1 = New System.Windows.Forms.Panel()
      Me.TextDBelow = New System.Windows.Forms.TextBox()
      Me.TextDAbove = New System.Windows.Forms.TextBox()
      Me.TextDThreshold = New System.Windows.Forms.TextBox()
      Me.Label14 = New System.Windows.Forms.Label()
      Me.TextIBelow = New System.Windows.Forms.TextBox()
      Me.TextIAbove = New System.Windows.Forms.TextBox()
      Me.TextIThreshold = New System.Windows.Forms.TextBox()
      Me.Label13 = New System.Windows.Forms.Label()
      Me.TextPBelow = New System.Windows.Forms.TextBox()
      Me.TextPAbove = New System.Windows.Forms.TextBox()
      Me.TextPThreshold = New System.Windows.Forms.TextBox()
      Me.Label9 = New System.Windows.Forms.Label()
      Me.Label10 = New System.Windows.Forms.Label()
      Me.Label11 = New System.Windows.Forms.Label()
      Me.Label12 = New System.Windows.Forms.Label()
      Me.ButtonSend = New System.Windows.Forms.Button()
      Me.ButtonRun = New System.Windows.Forms.Button()
      Me.Label5 = New System.Windows.Forms.Label()
      Me.Panel1.SuspendLayout
      Me.SuspendLayout
      '
      'ListPID
      '
      Me.ListPID.BackColor = System.Drawing.SystemColors.Window
      Me.ListPID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.ListPID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.ListPID.FormattingEnabled = true
      Me.ListPID.Items.AddRange(New Object() {"Drive: Drive", "Drive: Rotate", "Lift: Position", "Cube: Arm Position"})
      Me.ListPID.Location = New System.Drawing.Point(109, 15)
      Me.ListPID.Name = "ListPID"
      Me.ListPID.Size = New System.Drawing.Size(193, 22)
      Me.ListPID.TabIndex = 0
      '
      'Label1
      '
      Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label1.Location = New System.Drawing.Point(50, 20)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(56, 20)
      Me.Label1.TabIndex = 2
      Me.Label1.Text = "PID....."
      '
      'Label2
      '
      Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label2.Location = New System.Drawing.Point(50, 50)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(135, 20)
      Me.Label2.TabIndex = 3
      Me.Label2.Text = "Setpoint.............."
      '
      'Label3
      '
      Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label3.Location = New System.Drawing.Point(50, 80)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(135, 20)
      Me.Label3.TabIndex = 4
      Me.Label3.Text = "Maximum Output..."
      '
      'TextSetpoint
      '
      Me.TextSetpoint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.TextSetpoint.Location = New System.Drawing.Point(190, 45)
      Me.TextSetpoint.Name = "TextSetpoint"
      Me.TextSetpoint.Size = New System.Drawing.Size(95, 23)
      Me.TextSetpoint.TabIndex = 1
      Me.TextSetpoint.Tag = "0"
      Me.TextSetpoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'TextMaxOut
      '
      Me.TextMaxOut.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.TextMaxOut.Location = New System.Drawing.Point(190, 75)
      Me.TextMaxOut.Name = "TextMaxOut"
      Me.TextMaxOut.Size = New System.Drawing.Size(95, 23)
      Me.TextMaxOut.TabIndex = 2
      Me.TextMaxOut.Tag = "1"
      Me.TextMaxOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'Label4
      '
      Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label4.Location = New System.Drawing.Point(20, 110)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(90, 20)
      Me.Label4.TabIndex = 8
      Me.Label4.Text = "Coefficients"
      '
      'Panel1
      '
      Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.Panel1.Controls.Add(Me.TextDBelow)
      Me.Panel1.Controls.Add(Me.TextDAbove)
      Me.Panel1.Controls.Add(Me.TextDThreshold)
      Me.Panel1.Controls.Add(Me.Label14)
      Me.Panel1.Controls.Add(Me.TextIBelow)
      Me.Panel1.Controls.Add(Me.TextIAbove)
      Me.Panel1.Controls.Add(Me.TextIThreshold)
      Me.Panel1.Controls.Add(Me.Label13)
      Me.Panel1.Controls.Add(Me.TextPBelow)
      Me.Panel1.Controls.Add(Me.TextPAbove)
      Me.Panel1.Controls.Add(Me.TextPThreshold)
      Me.Panel1.Controls.Add(Me.Label9)
      Me.Panel1.Controls.Add(Me.Label10)
      Me.Panel1.Controls.Add(Me.Label11)
      Me.Panel1.Controls.Add(Me.Label12)
      Me.Panel1.Location = New System.Drawing.Point(10, 120)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(343, 128)
      Me.Panel1.TabIndex = 3
      '
      'TextDBelow
      '
      Me.TextDBelow.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.TextDBelow.Location = New System.Drawing.Point(240, 85)
      Me.TextDBelow.Name = "TextDBelow"
      Me.TextDBelow.Size = New System.Drawing.Size(90, 23)
      Me.TextDBelow.TabIndex = 8
      Me.TextDBelow.Tag = "10"
      Me.TextDBelow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'TextDAbove
      '
      Me.TextDAbove.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.TextDAbove.Location = New System.Drawing.Point(145, 85)
      Me.TextDAbove.Name = "TextDAbove"
      Me.TextDAbove.Size = New System.Drawing.Size(90, 23)
      Me.TextDAbove.TabIndex = 7
      Me.TextDAbove.Tag = "9"
      Me.TextDAbove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'TextDThreshold
      '
      Me.TextDThreshold.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.TextDThreshold.Location = New System.Drawing.Point(50, 85)
      Me.TextDThreshold.Name = "TextDThreshold"
      Me.TextDThreshold.Size = New System.Drawing.Size(90, 23)
      Me.TextDThreshold.TabIndex = 6
      Me.TextDThreshold.Tag = "8"
      Me.TextDThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'Label14
      '
      Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label14.Location = New System.Drawing.Point(9, 90)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(40, 20)
      Me.Label14.TabIndex = 15
      Me.Label14.Text = "D....."
      '
      'TextIBelow
      '
      Me.TextIBelow.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.TextIBelow.Location = New System.Drawing.Point(240, 55)
      Me.TextIBelow.Name = "TextIBelow"
      Me.TextIBelow.Size = New System.Drawing.Size(90, 23)
      Me.TextIBelow.TabIndex = 5
      Me.TextIBelow.Tag = "7"
      Me.TextIBelow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'TextIAbove
      '
      Me.TextIAbove.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.TextIAbove.Location = New System.Drawing.Point(145, 55)
      Me.TextIAbove.Name = "TextIAbove"
      Me.TextIAbove.Size = New System.Drawing.Size(90, 23)
      Me.TextIAbove.TabIndex = 4
      Me.TextIAbove.Tag = "6"
      Me.TextIAbove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'TextIThreshold
      '
      Me.TextIThreshold.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.TextIThreshold.Location = New System.Drawing.Point(50, 55)
      Me.TextIThreshold.Name = "TextIThreshold"
      Me.TextIThreshold.Size = New System.Drawing.Size(90, 23)
      Me.TextIThreshold.TabIndex = 3
      Me.TextIThreshold.Tag = "5"
      Me.TextIThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'Label13
      '
      Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label13.Location = New System.Drawing.Point(9, 60)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(40, 20)
      Me.Label13.TabIndex = 11
      Me.Label13.Text = "I....."
      '
      'TextPBelow
      '
      Me.TextPBelow.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.TextPBelow.Location = New System.Drawing.Point(240, 25)
      Me.TextPBelow.Name = "TextPBelow"
      Me.TextPBelow.Size = New System.Drawing.Size(90, 23)
      Me.TextPBelow.TabIndex = 2
      Me.TextPBelow.Tag = "4"
      Me.TextPBelow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'TextPAbove
      '
      Me.TextPAbove.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.TextPAbove.Location = New System.Drawing.Point(145, 25)
      Me.TextPAbove.Name = "TextPAbove"
      Me.TextPAbove.Size = New System.Drawing.Size(90, 23)
      Me.TextPAbove.TabIndex = 1
      Me.TextPAbove.Tag = "3"
      Me.TextPAbove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'TextPThreshold
      '
      Me.TextPThreshold.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.TextPThreshold.Location = New System.Drawing.Point(50, 25)
      Me.TextPThreshold.Name = "TextPThreshold"
      Me.TextPThreshold.Size = New System.Drawing.Size(90, 23)
      Me.TextPThreshold.TabIndex = 0
      Me.TextPThreshold.Tag = "2"
      Me.TextPThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'Label9
      '
      Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label9.Location = New System.Drawing.Point(9, 30)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(40, 20)
      Me.Label9.TabIndex = 7
      Me.Label9.Text = "P....."
      '
      'Label10
      '
      Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label10.Location = New System.Drawing.Point(240, 5)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(90, 20)
      Me.Label10.TabIndex = 6
      Me.Label10.Text = "Below"
      Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label11
      '
      Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label11.Location = New System.Drawing.Point(145, 5)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(90, 20)
      Me.Label11.TabIndex = 5
      Me.Label11.Text = "Above"
      Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label12
      '
      Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label12.Location = New System.Drawing.Point(50, 5)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(90, 20)
      Me.Label12.TabIndex = 4
      Me.Label12.Text = "Threshold"
      Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'ButtonSend
      '
      Me.ButtonSend.Enabled = false
      Me.ButtonSend.Location = New System.Drawing.Point(69, 295)
      Me.ButtonSend.Name = "ButtonSend"
      Me.ButtonSend.Size = New System.Drawing.Size(110, 30)
      Me.ButtonSend.TabIndex = 4
      Me.ButtonSend.Text = "Send to Robot"
      Me.ButtonSend.UseVisualStyleBackColor = true
      '
      'ButtonRun
      '
      Me.ButtonRun.Enabled = false
      Me.ButtonRun.Location = New System.Drawing.Point(184, 295)
      Me.ButtonRun.Name = "ButtonRun"
      Me.ButtonRun.Size = New System.Drawing.Size(110, 30)
      Me.ButtonRun.TabIndex = 5
      Me.ButtonRun.Text = "Run PID Test"
      Me.ButtonRun.UseVisualStyleBackColor = true
      '
      'Label5
      '
      Me.Label5.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label5.Location = New System.Drawing.Point(10, 256)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(342, 30)
      Me.Label5.TabIndex = 9
      Me.Label5.Text = "NOTE: To run a Test, the robot must be in Test Mode and Enabled."
      '
      'TunePidForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 14!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225,Byte),Integer), CType(CType(230,Byte),Integer), CType(CType(245,Byte),Integer))
      Me.ClientSize = New System.Drawing.Size(364, 341)
      Me.Controls.Add(Me.Label5)
      Me.Controls.Add(Me.ButtonRun)
      Me.Controls.Add(Me.ButtonSend)
      Me.Controls.Add(Me.Label4)
      Me.Controls.Add(Me.Panel1)
      Me.Controls.Add(Me.TextMaxOut)
      Me.Controls.Add(Me.TextSetpoint)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.ListPID)
      Me.Controls.Add(Me.Label1)
      Me.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
      Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
      Me.MaximizeBox = false
      Me.Name = "TunePidForm"
      Me.Text = "Dashboard: Tune PID"
      Me.Panel1.ResumeLayout(false)
      Me.Panel1.PerformLayout
      Me.ResumeLayout(false)
      Me.PerformLayout

End Sub

   Friend WithEvents ListPID As ComboBox
   Friend WithEvents Label1 As Label
   Friend WithEvents Label2 As Label
   Friend WithEvents Label3 As Label
   Friend WithEvents TextSetpoint As TextBox
   Friend WithEvents TextMaxOut As TextBox
   Friend WithEvents Label4 As Label
   Friend WithEvents Panel1 As Panel
   Friend WithEvents TextDBelow As TextBox
   Friend WithEvents TextDAbove As TextBox
   Friend WithEvents TextDThreshold As TextBox
   Friend WithEvents Label14 As Label
   Friend WithEvents TextIBelow As TextBox
   Friend WithEvents TextIAbove As TextBox
   Friend WithEvents TextIThreshold As TextBox
   Friend WithEvents Label13 As Label
   Friend WithEvents TextPBelow As TextBox
   Friend WithEvents TextPAbove As TextBox
   Friend WithEvents TextPThreshold As TextBox
   Friend WithEvents Label9 As Label
   Friend WithEvents Label10 As Label
   Friend WithEvents Label11 As Label
   Friend WithEvents Label12 As Label
   Friend WithEvents ButtonSend As Button
   Friend WithEvents ButtonRun As Button
   Friend WithEvents Label5 As Label
End Class
