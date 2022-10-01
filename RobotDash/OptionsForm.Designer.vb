<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsForm
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptionsForm))
      Me.LabelRevised = New System.Windows.Forms.Label()
      Me.TextPort = New System.Windows.Forms.TextBox()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.TextAddress = New System.Windows.Forms.TextBox()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.ButtonCancel = New System.Windows.Forms.Button()
      Me.ButtonSave = New System.Windows.Forms.Button()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.TextZoom = New System.Windows.Forms.TextBox()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.ListButtons = New System.Windows.Forms.ComboBox()
      Me.SuspendLayout
      '
      'LabelRevised
      '
      Me.LabelRevised.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelRevised.ForeColor = System.Drawing.Color.Red
      Me.LabelRevised.Location = New System.Drawing.Point(237, 0)
      Me.LabelRevised.Name = "LabelRevised"
      Me.LabelRevised.Size = New System.Drawing.Size(78, 14)
      Me.LabelRevised.TabIndex = 1
      Me.LabelRevised.Text = "Revised"
      Me.LabelRevised.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      Me.LabelRevised.Visible = false
      '
      'TextPort
      '
      Me.TextPort.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.TextPort.Location = New System.Drawing.Point(135, 55)
      Me.TextPort.Name = "TextPort"
      Me.TextPort.Size = New System.Drawing.Size(115, 23)
      Me.TextPort.TabIndex = 1
      Me.TextPort.Tag = "1"
      Me.TextPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'Label3
      '
      Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label3.Location = New System.Drawing.Point(10, 60)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(120, 20)
      Me.Label3.TabIndex = 7
      Me.Label3.Text = "Host Port.........."
      '
      'TextAddress
      '
      Me.TextAddress.BackColor = System.Drawing.SystemColors.Window
      Me.TextAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.TextAddress.Location = New System.Drawing.Point(135, 20)
      Me.TextAddress.Name = "TextAddress"
      Me.TextAddress.Size = New System.Drawing.Size(165, 23)
      Me.TextAddress.TabIndex = 0
      Me.TextAddress.Tag = "0"
      Me.TextAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'Label2
      '
      Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label2.Location = New System.Drawing.Point(10, 25)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(120, 20)
      Me.Label2.TabIndex = 5
      Me.Label2.Text = "Host IP............."
      '
      'ButtonCancel
      '
      Me.ButtonCancel.Enabled = false
      Me.ButtonCancel.Location = New System.Drawing.Point(159, 175)
      Me.ButtonCancel.Name = "ButtonCancel"
      Me.ButtonCancel.Size = New System.Drawing.Size(78, 30)
      Me.ButtonCancel.TabIndex = 5
      Me.ButtonCancel.Text = "Cancel"
      Me.ButtonCancel.UseVisualStyleBackColor = true
      '
      'ButtonSave
      '
      Me.ButtonSave.Enabled = false
      Me.ButtonSave.Location = New System.Drawing.Point(79, 175)
      Me.ButtonSave.Name = "ButtonSave"
      Me.ButtonSave.Size = New System.Drawing.Size(78, 30)
      Me.ButtonSave.TabIndex = 4
      Me.ButtonSave.Text = "Save"
      Me.ButtonSave.UseVisualStyleBackColor = true
      '
      'Label4
      '
      Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label4.Location = New System.Drawing.Point(10, 83)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(120, 35)
      Me.Label4.TabIndex = 8
      Me.Label4.Text = "Dash Form Zoom Factor (%)........"
      '
      'TextZoom
      '
      Me.TextZoom.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.TextZoom.Location = New System.Drawing.Point(135, 95)
      Me.TextZoom.Name = "TextZoom"
      Me.TextZoom.Size = New System.Drawing.Size(115, 23)
      Me.TextZoom.TabIndex = 2
      Me.TextZoom.Tag = "2"
      Me.TextZoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'Label1
      '
      Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label1.Location = New System.Drawing.Point(10, 135)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(120, 20)
      Me.Label1.TabIndex = 9
      Me.Label1.Text = "Dash Buttons...."
      '
      'ListButtons
      '
      Me.ListButtons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.ListButtons.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.ListButtons.FormattingEnabled = true
      Me.ListButtons.Items.AddRange(New Object() {"Disabled", "Enabled"})
      Me.ListButtons.Location = New System.Drawing.Point(135, 130)
      Me.ListButtons.Name = "ListButtons"
      Me.ListButtons.Size = New System.Drawing.Size(85, 22)
      Me.ListButtons.TabIndex = 3
      '
      'OptionsForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 14!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225,Byte),Integer), CType(CType(230,Byte),Integer), CType(CType(245,Byte),Integer))
      Me.ClientSize = New System.Drawing.Size(314, 216)
      Me.Controls.Add(Me.ListButtons)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.TextZoom)
      Me.Controls.Add(Me.TextPort)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.Label4)
      Me.Controls.Add(Me.TextAddress)
      Me.Controls.Add(Me.ButtonCancel)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.ButtonSave)
      Me.Controls.Add(Me.LabelRevised)
      Me.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
      Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
      Me.MaximizeBox = false
      Me.Name = "OptionsForm"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
      Me.Text = "Dashboard: Options"
      Me.ResumeLayout(false)
      Me.PerformLayout

End Sub

   Friend WithEvents LabelRevised As Label
   Friend WithEvents TextPort As TextBox
   Friend WithEvents Label3 As Label
   Friend WithEvents TextAddress As TextBox
   Friend WithEvents Label2 As Label
   Friend WithEvents ButtonCancel As Button
   Friend WithEvents ButtonSave As Button
   Friend WithEvents Label4 As Label
   Friend WithEvents TextZoom As TextBox
   Friend WithEvents Label1 As Label
   Friend WithEvents ListButtons As ComboBox
End Class
