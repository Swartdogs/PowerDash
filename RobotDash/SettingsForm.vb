Public Class SettingsForm

   Private Structure CellError
      Public grid          As DataGridView
      Public columnIndex   As Integer
      Public rowIndex      As Integer
   End Structure

   Private c_allowKey         As Boolean = False
   Private c_cellError        As CellError
   Private c_formName         As String = "ROBOT SETTINGS"

   Private Sub BuildGrid()
      Dim cIndex  As Integer = colDvIndex.Index
      Dim cDesc   As Integer = colDesc.Index

      With GridSetting
         .RowCount = 23

         .Item(cIndex, 0).Value  = DVindex.dvIntakeInSpeed
         .Item(cDesc, 0).Value   = "Intake: In Speed"

         .Item(cIndex, 1).Value  = DVindex.dvIntakeEjectSpeed
         .Item(cDesc, 1).Value   = "        Eject Speed"

         .Item(cIndex, 2).Value  = DVindex.dvIntakeLaunchSpeed
         .Item(cDesc, 2).Value   = "        Launch Speed"

         .Item(cIndex, 3).Value  = DVindex.dvIntakePotOffset
         .Item(cDesc, 3).Value   = "        Arm Pot Offset"

         .Item(cIndex, 4).Value  = DVindex.dvIntakeLimit
         .Item(cDesc, 4).Value   = "        Arm Limit"

         .Item(cIndex, 5).Value  = DVindex.dvIntakeStow
         .Item(cDesc, 5).Value   = "        Arm Stow Position"

         .Item(cIndex, 6).Value  = DVindex.dvIntakePickup
         .Item(cDesc, 6).Value   = "        Arm Pickup Position"

         .Item(cIndex, 7).Value  = DVindex.dvIntakeTilt
         .Item(cDesc, 7).Value   = "        Arm Tilt Position"

         .Item(cIndex, 8).Value  = DVindex.dvLiftPotOffsetTop
         .Item(cDesc, 8).Value   = "Lift:   Top Pot Offset"

         .Item(cIndex, 9).Value  = DVindex.dvLiftPotOffsetBot
         .Item(cDesc, 9).Value   = "        Bottom Pot Offset"

         .Item(cIndex, 10).Value = DVindex.dvLiftHighLimit
         .Item(cDesc, 10).Value  = "        High Limit"

         .Item(cIndex, 11).Value = DVindex.dvLiftHighThres
         .Item(cDesc, 11).Value  = "        High Threshold"

         .Item(cIndex, 12).Value = DVindex.dvLiftLowLimit
         .Item(cDesc, 12).Value  = "        Low Limit"

         .Item(cIndex, 13).Value = DVindex.dvLiftLowThres
         .Item(cDesc, 13).Value  = "        Low Threshold"

         .Item(cIndex, 14).Value = DVindex.dvLiftScaleTop
         .Item(cDesc, 14).Value  = "        Scale High"

         .Item(cIndex, 15).Value = DVindex.dvLiftScaleMid
         .Item(cDesc, 15).Value  = "        Scale Balanced"

         .Item(cIndex, 16).Value = DVindex.dvLiftScaleBot
         .Item(cDesc, 16).Value  = "        Scale Low"

         .Item(cIndex, 17).Value = DVindex.dvLiftSwitch
         .Item(cDesc, 17).Value  = "        Switch"

         .Item(cIndex, 18).Value = DVindex.dvLiftTravel
         .Item(cDesc, 18).Value  = "        Travel"

         .Item(cIndex, 19).Value = DVindex.dvLiftBumpStep
         .Item(cDesc, 19).Value = "        Bump Step"

         .Item(cIndex, 20).Value = DVindex.dvCameraOn
         .Item(cDesc, 20).Value = "Camera: ON"

         .Item(cIndex, 21).Value = DVindex.dvHookPotOffset
         .Item(cDesc, 21).Value = "Hook:   Pot Offset"

         .Item(cIndex, 22).Value = DVindex.dvHookPotLimit
         .Item(cDesc, 22).Value = "        Pot Limit"
      End With

      ShowSettings()
   End Sub

   Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
      ShowSettings()
      ButtonSend.Enabled = False
      ButtonCancel.Enabled = False
   End Sub

   Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click
      Dim index As Integer

      With GridSetting
         For row As Integer = 0 To .RowCount - 1
            index = .Item(colDvIndex.Index, row).Value
            If m_dashValue(index).revised Then DashValue(index, False) = .Item(colValue.Index, row).Value
         Next
      End With

      DashValue(-1, True) = 0
   End Sub

   Private Sub Grid_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles GridSetting.CellEndEdit
      Dim grid    As DataGridView = CType(sender, DataGridView)

      Dim count   As Integer = 0
      Dim found   As Integer
      Dim text    As String

      If grid.Item(e.ColumnIndex, e.RowIndex).Value Is Nothing
         text = "0"
      Else
         text = grid.Item(e.ColumnIndex, e.RowIndex).Value.ToString
      End If

      Do
         found = text.IndexOf(".")

         If found >= 0
            count += 1
            text = Mid(text, found + 2)
         Else
            Exit Do
         End If
      Loop

      If count > 1
         Dim result As DialogResult = MessageBox.Show(Me, "Multiple decimal points are not permitted", c_formName, _
                                                      MessageBoxButtons.OK, MessageBoxIcon.Information)

         With c_cellError
            .grid = grid
            .columnIndex = e.ColumnIndex
            .rowIndex = e.RowIndex
         End With
         TimerError.Start()

      Else
         Dim index      As Integer = grid.Item(colDvIndex.Index, e.RowIndex).Value
         Dim newValue   As Double = ConvertToDouble(grid.Item(e.ColumnIndex, e.RowIndex).Value)
         
         If m_dashValue(index).value <> newValue
            m_dashValue(index).revised = True
            grid.Item(e.ColumnIndex, e.RowIndex).Value = newValue
            grid.Item(e.ColumnIndex, e.RowIndex).Style.BackColor = m_colorPending   

            ButtonSend.Enabled = True
            ButtonCancel.Enabled = True
         End If
      End If
   End Sub

   Private Sub Grid_CurrentCellChanged(sender As Object, e As EventArgs) Handles GridSetting.CurrentCellChanged
      If GridSetting.CurrentCell IsNot Nothing
         Select GridSetting.CurrentCell.ColumnIndex
             Case 1: c_allowKey = True: SendKeys.Send("{RIGHT}")
         End Select
      End If
   End Sub

   Private Sub Grid_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles GridSetting.EditingControlShowing
      Dim grid    As DataGridView = CType(sender, DataGridView)

      If grid.CurrentCell.ColumnIndex = colValue.Index
         AddHandler e.Control.KeyPress, AddressOf GridTextBox_Keypress
      Else
         RemoveHandler e.Control.KeyPress, AddressOf GridTextBox_Keypress
      End If
   End Sub

   Private Sub Grid_KeyDown(sender As Object, e As KeyEventArgs) Handles GridSetting.KeyDown
      Select e.KeyCode
         Case Keys.Right
            If c_allowKey Then c_allowKey = False Else e.Handled = True
      End Select
   End Sub

   Private Sub Grid_LostFocus(sender As Object, e As EventArgs) Handles GridSetting.LostFocus
      Dim grid    As DataGridView = CType(sender, DataGridView)
      grid.ClearSelection()
   End Sub

   Private Sub GridTextBox_Keypress(sender As Object, e As KeyPressEventArgs) 
      e.KeyChar = TextBoxKeyPress(TextBoxType.Float, e.KeyChar)
   End Sub

   Private Sub SettingsForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
      m_settingsForm = Nothing
   End Sub

   Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
      Me.Top = m_dashForm.Top + 60
      Me.Left = m_dashForm.Left + 20
      BuildGrid()
   End Sub

   Public Sub ShowSettings()
      Dim index As Integer

      With GridSetting
         .SuspendLayout()

         For row As Integer = 0 To .RowCount - 1
            index = .Item(colDvIndex.Index, row).Value
            .Item(colValue.Index, row).Value = m_dashValue(index).value
            
            If m_dashValue(index).sentToHost
               .Item(colValue.Index, row).Style.BackColor = Color.White
            Else
               .Item(colValue.Index, row).Style.BackColor = m_colorPending
            End If                  
         Next

         .ResumeLayout()
      End With
   End Sub

   Private Sub TimerError_Tick(sender As Object, e As EventArgs) Handles TimerError.Tick
      TimerError.Stop()
      With c_cellError
         .grid.CurrentCell = .grid.Item(.columnIndex, .rowIndex)
      End With
   End Sub

   Public Sub UpdateStatus()
      Dim index  As Integer

      With GridSetting
         .SuspendLayout()

         For row As Integer = 0 To .RowCount - 1
            index = .Item(colDvIndex.Index, row).Value

            If Not m_dashValue(index).revised And m_dashValue(index).sentToHost
               .Item(colValue.Index, row).Style.BackColor = Color.White
            Else
               .Item(colValue.Index, row).Style.BackColor = m_colorPending
            End If
         Next

         .ResumeLayout()
      End With
   End Sub

End Class