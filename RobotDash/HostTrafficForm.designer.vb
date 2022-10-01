<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HostTrafficForm
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
      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HostTrafficForm))
      Me.GridTraffic = New System.Windows.Forms.DataGridView()
      Me.colTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.colFrom = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.colMessage = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.ButtonHold = New System.Windows.Forms.Button()
      Me.ButtonClear = New System.Windows.Forms.Button()
      Me.ReadTimer = New System.Windows.Forms.Timer(Me.components)
      CType(Me.GridTraffic,System.ComponentModel.ISupportInitialize).BeginInit
      Me.SuspendLayout
      '
      'GridTraffic
      '
      Me.GridTraffic.AllowUserToAddRows = false
      Me.GridTraffic.AllowUserToDeleteRows = false
      Me.GridTraffic.AllowUserToResizeColumns = false
      Me.GridTraffic.AllowUserToResizeRows = false
      Me.GridTraffic.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
      Me.GridTraffic.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(215,Byte),Integer), CType(CType(215,Byte),Integer), CType(CType(215,Byte),Integer))
      Me.GridTraffic.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
      DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      DataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua
      DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
      DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.GridTraffic.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
      Me.GridTraffic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
      Me.GridTraffic.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTime, Me.colFrom, Me.colMessage})
      DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
      DataGridViewCellStyle5.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
      DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
      DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
      Me.GridTraffic.DefaultCellStyle = DataGridViewCellStyle5
      Me.GridTraffic.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
      Me.GridTraffic.EnableHeadersVisualStyles = false
      Me.GridTraffic.Location = New System.Drawing.Point(5, 29)
      Me.GridTraffic.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
      Me.GridTraffic.MultiSelect = false
      Me.GridTraffic.Name = "GridTraffic"
      Me.GridTraffic.ReadOnly = true
      DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
      DataGridViewCellStyle6.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
      DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.GridTraffic.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
      Me.GridTraffic.RowHeadersVisible = false
      Me.GridTraffic.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.GridTraffic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
      Me.GridTraffic.Size = New System.Drawing.Size(540, 245)
      Me.GridTraffic.TabIndex = 2
      '
      'colTime
      '
      Me.colTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
      DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
      DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
      Me.colTime.DefaultCellStyle = DataGridViewCellStyle2
      Me.colTime.HeaderText = "Time"
      Me.colTime.Name = "colTime"
      Me.colTime.ReadOnly = true
      Me.colTime.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
      Me.colTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
      Me.colTime.Width = 70
      '
      'colFrom
      '
      Me.colFrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
      DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
      DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
      Me.colFrom.DefaultCellStyle = DataGridViewCellStyle3
      Me.colFrom.HeaderText = "From"
      Me.colFrom.Name = "colFrom"
      Me.colFrom.ReadOnly = true
      Me.colFrom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
      Me.colFrom.Width = 50
      '
      'colMessage
      '
      Me.colMessage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
      DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
      DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
      Me.colMessage.DefaultCellStyle = DataGridViewCellStyle4
      Me.colMessage.HeaderText = "Message"
      Me.colMessage.Name = "colMessage"
      Me.colMessage.ReadOnly = true
      Me.colMessage.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
      Me.colMessage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
      Me.colMessage.Width = 400
      '
      'ButtonHold
      '
      Me.ButtonHold.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
      Me.ButtonHold.Location = New System.Drawing.Point(386, 2)
      Me.ButtonHold.Name = "ButtonHold"
      Me.ButtonHold.Size = New System.Drawing.Size(78, 25)
      Me.ButtonHold.TabIndex = 0
      Me.ButtonHold.Text = "Hold"
      Me.ButtonHold.UseVisualStyleBackColor = true
      '
      'ButtonClear
      '
      Me.ButtonClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
      Me.ButtonClear.Location = New System.Drawing.Point(467, 2)
      Me.ButtonClear.Name = "ButtonClear"
      Me.ButtonClear.Size = New System.Drawing.Size(78, 25)
      Me.ButtonClear.TabIndex = 1
      Me.ButtonClear.Text = "Clear"
      Me.ButtonClear.UseVisualStyleBackColor = true
      '
      'HostTrafficForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 14!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225,Byte),Integer), CType(CType(230,Byte),Integer), CType(CType(245,Byte),Integer))
      Me.ClientSize = New System.Drawing.Size(550, 279)
      Me.Controls.Add(Me.ButtonClear)
      Me.Controls.Add(Me.ButtonHold)
      Me.Controls.Add(Me.GridTraffic)
      Me.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
      Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
      Me.MaximizeBox = false
      Me.MaximumSize = New System.Drawing.Size(1100, 1000)
      Me.MinimumSize = New System.Drawing.Size(566, 318)
      Me.Name = "HostTrafficForm"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
      Me.Text = "Dashboard: Host Traffic"
      CType(Me.GridTraffic,System.ComponentModel.ISupportInitialize).EndInit
      Me.ResumeLayout(false)

End Sub

   Friend WithEvents GridTraffic As DataGridView
   Friend WithEvents ButtonHold As Button
   Friend WithEvents ButtonClear As Button
   Friend WithEvents colTime As DataGridViewTextBoxColumn
   Friend WithEvents colFrom As DataGridViewTextBoxColumn
   Friend WithEvents colMessage As DataGridViewTextBoxColumn
   Friend WithEvents ReadTimer As Timer
End Class
