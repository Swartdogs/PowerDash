Imports System.ComponentModel

Public Class OptionsForm
   Private c_countChange      As Boolean = False
   Private c_dashOptions      As DashOptions
   Private c_formName         As String = "DASHBOARD OPTIONS"
   Private c_hostChange       As Boolean = False
   Private c_ignoreEvents     As Boolean = True
   Private c_revised          As Boolean = False

   Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
      Dim result As DialogResult = MessageBox.Show(Me, "CAUTION:  Canceling the current edit session will restore the Options to the last saved values.  " _ 
                                    & "Any unsaved changes will be lost.  Do you wish to proceed?", _ 
                                   c_formName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

      If result = DialogResult.Yes
         c_dashOptions = m_dashOptions
         ShowOptions()
         Revised(False)
         c_countChange = False
         c_hostChange = False
      End If
   End Sub

   Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
      Dim newZoom As Boolean = (m_dashOptions.dashFormZoom <> c_dashOptions.dashFormZoom)

      m_dashOptions = c_dashOptions
      SaveOptions()
      Revised(False)

      If c_hostChange Then StartClient()
      c_hostChange = False

      If newZoom
         m_dashForm.FormResize = True
         m_dashForm.Close()
         m_dashForm = New DashForm
         m_dashForm.Show()
      End If
   End Sub

   Private Sub ListButtons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListButtons.SelectedIndexChanged
      If Not c_ignoreEvents
         c_dashOptions.buttonsEnabled = (ListButtons.SelectedIndex = 1)
         Revised(True)
      End If
   End Sub

   Private Sub OptionsForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
      m_optionsForm = Nothing
   End Sub

   Private Sub OptionsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
      Me.Top = m_dashForm.Top + 60
      Me.Left = m_dashForm.Left + 20
      c_dashOptions = m_dashOptions
      ShowOptions()
   End Sub

   Private Sub Revised(state As Boolean)
      If c_revised <> state
         c_revised = state
         ButtonSave.Enabled = state
         ButtonCancel.Enabled = state
         LabelRevised.Visible = state
      End If
   End Sub

   Private Sub ShowOptions()
      c_ignoreEvents = True

      With c_dashOptions
         TextAddress.Text = .robotHost
         TextPort.Text = .robotPort.ToString
         TextZoom.Text = .dashFormZoom.ToString

         If .buttonsEnabled
            ListButtons.SelectedIndex = 1
         Else
            ListButtons.SelectedIndex = 0
         End If
      End With

      c_ignoreEvents = False
   End Sub

   Private Sub Text_GotFocus(sender As Object, e As EventArgs) Handles TextAddress.GotFocus, TextPort.GotFocus
      Dim box As TextBox = CType(sender, TextBox)
      box.SelectAll
   End Sub

   Private Sub Text_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextAddress.KeyPress, TextPort.KeyPress, TextZoom.KeyPress
      Dim box As TextBox = CType(sender, TextBox)

      If box.Tag = 0
         e.KeyChar = TextBoxKeyPress(TextBoxType.Text, e.KeyChar)
      Else
         e.KeyChar = TextBoxKeyPress(TextBoxType.PositiveInteger, e.KeyChar)
      End If

      Revised(True)
   End Sub

   Private Sub TextAddress_Validating(sender As Object, e As CancelEventArgs) Handles TextAddress.Validating
      If c_dashOptions.robotHost <> TextAddress.Text
         c_dashOptions.robotHost = TextAddress.Text
         c_hostChange = True
      End If
   End Sub

   Private Sub TextPort_Validating(sender As Object, e As CancelEventArgs) Handles TextPort.Validating
      If TextPort.Text.Length = 0 Then TextPort.Text = "0"
      
      Dim port As Long = CLng(TextPort.Text)

      If port > 65535
         Dim result As DialogResult = MessageBox.Show(Me, "Host Port range = 0 to 65535.", c_formName, MessageBoxButtons.OK, MessageBoxIcon.Information)
         TextPort.Text = c_dashOptions.robotPort.ToString
         e.Cancel = True
      ElseIf c_dashOptions.robotPort <> port
         c_dashOptions.robotPort = port
         c_hostChange = True
      End If
   End Sub

   Private Sub TextZoom_Validating(sender As Object, e As CancelEventArgs) Handles TextZoom.Validating
      If TextZoom.Text.Length = 0 Then TextZoom.Text = "50"

      Dim zoom As Integer = CInt(TextZoom.Text)
      If zoom < 50 Then TextZoom.Text = "50"

      If zoom > 200
         Dim result As DialogResult = MessageBox.Show(Me, "Dashboard Form Zoom range = 50 to 200%.", c_formName, MessageBoxButtons.OK, MessageBoxIcon.Information)
         TextZoom.Text = c_dashOptions.dashFormZoom.ToString
         e.Cancel = True
      Else
         c_dashOptions.dashFormZoom = zoom
      End If
   End Sub

End Class