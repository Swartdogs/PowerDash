Imports System.ComponentModel

Public Class TunePidForm

   Public Enum DataGroup
      All = 0
      RobotValue = 1
      DashValue = 2
      DashButton = 3
   End Enum

   Private c_formName      As String = "TUNE PID"
   Private c_ignoreEvents  As Boolean = False

   Private Sub ButtonRun_KeyDown(sender As Object, e As KeyEventArgs) Handles ButtonRun.KeyDown
      If e.KeyCode = Keys.Space Then DashButton(DBIndex.dbRunPID) = True
   End Sub

   Private Sub ButtonRun_KeyUp(sender As Object, e As KeyEventArgs) Handles ButtonRun.KeyUp
      If e.KeyCode = Keys.Space Then DashButton(DBIndex.dbRunPID) = False
   End Sub

   Private Sub ButtonRun_MouseDown(sender As Object, e As MouseEventArgs) Handles ButtonRun.MouseDown
      DashButton(DBIndex.dbRunPID) = True
   End Sub

   Private Sub ButtonRun_MouseUp(sender As Object, e As MouseEventArgs) Handles ButtonRun.MouseUp
      DashButton(DBIndex.dbRunPID) = False
   End Sub

   Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click
      If m_dashValue(DVindex.dvPidSelect).revised       Then DashValue(DVindex.dvPidSelect, False)       = CDbl(ListPID.SelectedIndex)
      If m_dashValue(DVindex.dvPidSetpoint).revised     Then DashValue(DVindex.dvPidSetpoint, False)     = ConvertToDouble(TextSetpoint.Text)
      If m_dashValue(DVindex.dvPidMaxOut).revised       Then DashValue(DVindex.dvPidMaxOut, False)       = ConvertToDouble(TextMaxOut.Text)
      If m_dashValue(DVindex.dvPidPthreshold).revised   Then DashValue(DVindex.dvPidPthreshold, False)   = ConvertToDouble(TextPThreshold.Text)
      If m_dashValue(DVindex.dvPidPabove).revised       Then DashValue(DVindex.dvPidPabove, False)       = ConvertToDouble(TextPAbove.Text)
      If m_dashValue(DVindex.dvPidPbelow).revised       Then DashValue(DVindex.dvPidPbelow, False)       = ConvertToDouble(TextPBelow.Text)
      If m_dashValue(DVindex.dvPidIthreshold).revised   Then DashValue(DVindex.dvPidIthreshold, False)   = ConvertToDouble(TextIThreshold.Text)
      If m_dashValue(DVindex.dvPidIabove).revised       Then DashValue(DVindex.dvPidIabove, False)       = ConvertToDouble(TextIAbove.Text)
      If m_dashValue(DVindex.dvPidIbelow).revised       Then DashValue(DVindex.dvPidIbelow, False)       = ConvertToDouble(TextIBelow.Text)
      If m_dashValue(DVindex.dvPidDthreshold).revised   Then DashValue(DVindex.dvPidDthreshold, False)   = ConvertToDouble(TextDThreshold.Text)
      If m_dashValue(DVindex.dvPidDabove).revised       Then DashValue(DVindex.dvPidDabove, False)       = ConvertToDouble(TextDAbove.Text)
      If m_dashValue(DVindex.dvPidDbelow).revised       Then DashValue(DVindex.dvPidDbelow, False)       = ConvertToDouble(TextDBelow.Text)

      DashValue(-1, True) = 0
   End Sub

   Private Sub ListPID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListPID.SelectedIndexChanged
      If Not c_ignoreEvents
         m_dashValue(DVindex.dvPidSelect).revised = True
         ListPID.BackColor = m_colorPending
         ButtonSend.Enabled = True
         ButtonRun.Enabled = False
      End If
   End Sub

   Private Sub ShowSettings()
      Dim sendEnabled As Boolean = False

      c_ignoreEvents = True

      ListPID.SelectedIndex = m_dashValue(DVindex.dvPidSelect).value
      If Not m_dashValue(DVindex.dvPidSelect).sentToHost
         ListPID.BackColor = m_colorPending
         sendEnabled = True
      End If

      TextSetpoint.Text = FormatValue(m_dashValue(DVindex.dvPidSetpoint).value, 2)
      If Not m_dashValue(DVindex.dvPidSetpoint).sentToHost
         TextSetpoint.BackColor = m_colorPending
         sendEnabled = True
      End If

      TextMaxOut.Text = FormatValue(m_dashValue(DVindex.dvPidMaxOut).value , 2)
      If Not m_dashValue(DVindex.dvPidMaxOut).sentToHost
         TextMaxOut.BackColor = m_colorPending
         sendEnabled = True
      End If

      TextPThreshold.Text = FormatValue(m_dashValue(DVindex.dvPidPthreshold).value, 6)
      If Not m_dashValue(DVindex.dvPidPthreshold).sentToHost
         TextPThreshold.BackColor = m_colorPending
         sendEnabled = True
      End If

      TextPAbove.Text = FormatValue(m_dashValue(DVindex.dvPidPabove).value, 6)
      If Not m_dashValue(DVindex.dvPidPabove).sentToHost
         TextPAbove.BackColor = m_colorPending
         sendEnabled = True
      End If

      TextPBelow.Text = FormatValue(m_dashValue(DVindex.dvPidPbelow).value, 6)
      If Not m_dashValue(DVindex.dvPidPbelow).sentToHost
         TextPBelow.BackColor = m_colorPending
         sendEnabled = True
      End If

      TextIThreshold.Text = FormatValue(m_dashValue(DVindex.dvPidIthreshold).value, 6)
      If Not m_dashValue(DVindex.dvPidIthreshold).sentToHost
         TextIThreshold.BackColor = m_colorPending
         sendEnabled = True
      End If

      TextIAbove.Text = FormatValue(m_dashValue(DVindex.dvPidIabove).value, 6)
      If Not m_dashValue(DVindex.dvPidIabove).sentToHost
         TextIAbove.BackColor = m_colorPending
         sendEnabled = True
      End If

      TextIBelow.Text = FormatValue(m_dashValue(DVindex.dvPidIbelow).value, 6)
      If Not m_dashValue(DVindex.dvPidIbelow).sentToHost
         TextIbelow.BackColor = m_colorPending
         sendEnabled = True
      End If

      TextDThreshold.Text = FormatValue(m_dashValue(DVindex.dvPidDthreshold).value, 6)
      If Not m_dashValue(DVindex.dvPidDthreshold).sentToHost
         TextDThreshold.BackColor = m_colorPending
         sendEnabled = True
      End If

      TextDAbove.Text = FormatValue(m_dashValue(DVindex.dvPidDabove).value, 6)
      If Not m_dashValue(DVindex.dvPidDabove).sentToHost
         TextDAbove.BackColor = m_colorPending
         sendEnabled = True
      End If

      TextDBelow.Text = FormatValue(m_dashValue(DVindex.dvPidDbelow).value, 6)
      If Not m_dashValue(DVindex.dvPidDbelow).sentToHost
         TextDBelow.BackColor = m_colorPending
         sendEnabled = True
      End If

      c_ignoreEvents = False

      ButtonSend.Enabled = sendEnabled
      ButtonRun.Enabled = False
   End Sub

   Private Sub Text_GotFocus(sender As Object, e As EventArgs) Handles TextSetpoint.GotFocus, TextMaxOut.GotFocus, _
                                                                       TextPThreshold.GotFocus, TextPAbove.GotFocus, TextPBelow.GotFocus, _
                                                                       TextIThreshold.GotFocus, TextIAbove.GotFocus, TextIBelow.GotFocus, _
                                                                       TextDThreshold.GotFocus, TextDAbove.GotFocus, TextDBelow.GotFocus
      Dim box As TextBox = CType(sender, TextBox)
      box.SelectAll()
   End Sub

   Private Sub Text_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextSetpoint.KeyPress, TextMaxOut.KeyPress, _
                                                                               TextPThreshold.KeyPress, TextPAbove.KeyPress, TextPBelow.KeyPress, _
                                                                               TextIThreshold.KeyPress, TextIAbove.KeyPress, TextIBelow.KeyPress, _
                                                                               TextDThreshold.KeyPress, TextDAbove.KeyPress, TextDBelow.KeyPress
      Dim box As TextBox = CType(sender, TextBox)
      e.KeyChar = TextBoxKeyPress(TextBoxType.Float, e.KeyChar)
   End Sub

   Private Sub Text_Validating(sender As Object, e As CancelEventArgs) Handles TextSetpoint.Validating, TextMaxOut.Validating, _
                                                                               TextPThreshold.Validating, TextPAbove.Validating, TextPBelow.Validating, _
                                                                               TextIThreshold.Validating, TextIAbove.Validating, TextIBelow.Validating, _
                                                                               TextDThreshold.Validating, TextDAbove.Validating, TextDBelow.Validating
      Dim box     As TextBox = CType(sender, TextBox)
      Dim count   As Integer = 0
      Dim found   As Integer

      If box.Text.Length = 0 Then box.Text = "0"
      Dim text As String = box.Text

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
         e.Cancel = True

      Else
         Dim index      As Integer
         Dim newValue   As Double = ConvertToDouble(box.Text)
         
         Select box.Tag
            Case 0:  index = DVindex.dvPidSetpoint
            Case 1:  index = DVindex.dvPidMaxOut
            Case 2:  index = DVindex.dvPidPthreshold
            Case 3:  index = DVindex.dvPidPabove
            Case 4:  index = DVindex.dvPidPbelow
            Case 5:  index = DVindex.dvPidIthreshold
            Case 6:  index = DVindex.dvPidIabove
            Case 7:  index = DVindex.dvPidIbelow
            Case 8:  index = DVindex.dvPidDthreshold
            Case 9:  index = DVindex.dvPidDabove
            Case 10: index = DVindex.dvPidDbelow
         End Select

         If index < 2 Then box.Text = FormatValue(newValue, 2) Else box.Text = FormatValue(newValue, 6)

         If m_dashValue(index).value <> newValue
            m_dashValue(index).revised = True
            box.BackColor = m_colorPending
            ButtonSend.Enabled = True
            ButtonRun.Enabled = False
         End If
      End If
   End Sub

   Private Sub TunePidForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
      m_tunePIDForm = Nothing
   End Sub

   Private Sub TunePidForm_Load(sender As Object, e As EventArgs) Handles Me.Load
      Me.Top = m_dashForm.Top + 60
      Me.Left = m_dashForm.Left + 20
      ShowSettings()
   End Sub

   Public Sub UpdateStatus(group As DataGroup)
      Static testReady As Boolean = False

      If group = DataGroup.RobotValue
         ButtonRun.Enabled = testReady And (m_robotMode = 4)

      ElseIf group = DataGroup.DashValue
         testReady = True

         If Not m_dashValue(DVindex.dvPidSelect).revised And m_dashValue(DVindex.dvPidSelect).sentToHost
            ListPID.BackColor = Color.White
         Else
            testReady = False
         End If

         If Not m_dashValue(DVindex.dvPidSetpoint).revised And  m_dashValue(DVindex.dvPidSetpoint).sentToHost
             TextSetpoint.BackColor = Color.White
         Else
             testReady = False
         End If

         If Not m_dashValue(DVindex.dvPidMaxOut).revised And m_dashValue(DVindex.dvPidMaxOut).sentToHost 
             TextMaxOut.BackColor = Color.White
         Else
             testReady = False
         End If

         If Not m_dashValue(DVindex.dvPidPthreshold).revised And m_dashValue(DVindex.dvPidPthreshold).sentToHost 
             TextPThreshold.BackColor = Color.White
         Else
             testReady = False
         End If

         If Not m_dashValue(DVindex.dvPidPabove).revised   And m_dashValue(DVindex.dvPidPabove).sentToHost 
             TextPAbove.BackColor = Color.White
         Else
             testReady = False
         End If

         If Not m_dashValue(DVindex.dvPidPbelow).revised And m_dashValue(DVindex.dvPidPbelow).sentToHost 
             TextPBelow.BackColor = Color.White
         Else
             testReady = False
         End If

         If Not m_dashValue(DVindex.dvPidIthreshold).revised And m_dashValue(DVindex.dvPidIthreshold).sentToHost 
             TextIThreshold.BackColor = Color.White
         Else
             testReady = False
         End If

         If Not m_dashValue(DVindex.dvPidIabove).revised And m_dashValue(DVindex.dvPidIabove).sentToHost 
             TextIAbove.BackColor = Color.White
         Else
             testReady = False
         End If

         If Not m_dashValue(DVindex.dvPidIbelow).revised And m_dashValue(DVindex.dvPidIbelow).sentToHost 
             TextIBelow.BackColor = Color.White
         Else
             testReady = False
         End If

         If Not m_dashValue(DVindex.dvPidDthreshold).revised And m_dashValue(DVindex.dvPidDthreshold).sentToHost 
             TextDThreshold.BackColor = Color.White
         Else
             testReady = False

         End If
         If Not m_dashValue(DVindex.dvPidDabove).revised And m_dashValue(DVindex.dvPidDabove).sentToHost 
             TextDAbove.BackColor = Color.White
         Else
             testReady = False
         End If

         If Not m_dashValue(DVindex.dvPidDbelow).revised And m_dashValue(DVindex.dvPidDbelow).sentToHost 
             TextDBelow.BackColor = Color.White
         Else
             testReady = False
         End If

         ButtonSend.Enabled = Not testReady
         ButtonRun.Enabled = testReady And (m_robotMode = 4)
      End If
   End Sub

End Class