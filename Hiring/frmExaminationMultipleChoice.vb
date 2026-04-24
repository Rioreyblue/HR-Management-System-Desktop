Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports NXNParsing

Public Class frmExaminationMultipleChoice
    Private jStr_Input As String = "[]"
    Private ws As New WSConnection
    Private Token As String = String.Empty
    Private ActiveFrm As String = "frmExaminationMultipleChoice.php"

    Dim formUpdate As Boolean = False
    Dim formCtr As String = String.Empty
    Private Sub frmExaminationMultipleChoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        classTimer.OpenLoading(frmLoading)
        classTimer.EventType = 1
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If classTimer.TimerCount = 1 Then
            Select Case classTimer.EventType
                Case 0
                    Timer1.Enabled = False
                    frmLoading.Close()
                    classTimer.TimerCount = 0
                Case 1

                    Call classTimer.TimerStop(Timer1)

                    Call Clear()
                    Call classComboBox.setCboJobMaintenance(cboJob)
                    Call LoadExaminationMultipleChoice(GetExaminationMultipleChoice)
                    Call classComboBox.setCboExaminationSituation(cboSituation)

                    Call classTimer.CloseLoading(frmLoading)
                    Call classTimer.TimerReset()
            End Select
        End If
        classTimer.TimerCount += 1
    End Sub
    Private Sub Clear()
        cboJob.Text = ""
        txtQuestion.Text = ""
        txtPoints.Text = ""
        txtImage.Text = ""
        cboSituation.Text = ""

        txtChoice1.Text = ""
        txtChoice2.Text = ""
        txtChoice3.Text = ""
        txtChoice4.Text = ""
        txtChoice5.Text = ""
        txtChoice6.Text = ""
        txtChoice7.Text = ""
        txtChoice8.Text = ""
        txtChoice9.Text = ""
        txtChoice10.Text = ""

        rbtnChecked1.Checked = False
        rbtnChecked2.Checked = False
        rbtnChecked3.Checked = False
        rbtnChecked4.Checked = False
        rbtnChecked5.Checked = False
        rbtnChecked6.Checked = False
        rbtnChecked7.Checked = False
        rbtnChecked8.Checked = False
        rbtnChecked9.Checked = False
        rbtnChecked10.Checked = False
    End Sub
    Public Sub Reload(ByVal pAction As Integer)
        If pAction = 0 OrElse pAction = 1 Then
            classTimer.EventType = 1
            Timer1.Enabled = True
        End If
    End Sub
    Public Sub LoadExaminationMultipleChoice(ByVal pList As List(Of ExaminationMultipleChoice))
        Dim choice_ As String = ""
        With lvExaminationMultipleChoice
            .Items.Clear()
            For Each item In pList
                Dim lv_ As ListViewItem = New ListViewItem(item.MChoiceKeyCtr)
                lv_.SubItems.Add(item.Question.ToProperCase)
                lv_.SubItems.Add(If(item.IsQuesPic = True, "YES", "NO"))
                lv_.SubItems.Add(item.Choice1)
                lv_.SubItems.Add(item.Choice2)
                lv_.SubItems.Add(item.Choice3)
                lv_.SubItems.Add(item.Choice4)
                lv_.SubItems.Add(item.Choice5)
                lv_.SubItems.Add(item.Choice6)
                lv_.SubItems.Add(item.Choice7)
                lv_.SubItems.Add(item.Choice8)
                lv_.SubItems.Add(item.Choice9)
                lv_.SubItems.Add(item.Choice10)
                lv_.SubItems.Add(If(item.WithSituation = True, "YES", "NO"))

                If item.IsCorrect1 = True Then
                    choice_ = "CHOICE 1"
                ElseIf item.IsCorrect2 = True Then
                    choice_ = "CHOICE 2"
                ElseIf item.IsCorrect3 = True Then
                    choice_ = "CHOICE 3"
                ElseIf item.IsCorrect4 = True Then
                    choice_ = "CHOICE 4"
                ElseIf item.IsCorrect5 = True Then
                    choice_ = "CHOICE 5"
                ElseIf item.IsCorrect6 = True Then
                    choice_ = "CHOICE 6"
                ElseIf item.IsCorrect7 = True Then
                    choice_ = "CHOICE 7"
                ElseIf item.IsCorrect8 = True Then
                    choice_ = "CHOICE 8"
                ElseIf item.IsCorrect9 = True Then
                    choice_ = "CHOICE 9"
                ElseIf item.IsCorrect10 = True Then
                    choice_ = "CHOICE 10"
                End If

                lv_.SubItems.Add(choice_)
                lv_.SubItems.Add(item.Pts)

                lv_.SubItems.Add(item.JobCode)
                lv_.SubItems.Add(item.ImageFilename)

                .Items.Add(lv_)
            Next
        End With
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim exam As New ExaminationMultipleChoice()
            exam.JobCode = cboJob.Text
            exam.Question = txtQuestion.Text
            exam.Pts = txtPoints.Text
            exam.ImageFilename = txtImage.Text
            If exam.ImageFilename <> "" Then
                exam.IsQuesPic = "True"
            Else
                exam.IsQuesPic = "False"
            End If
            exam.SitKeyCtr = Trim(cboSituation.Text)
            If exam.SitKeyCtr <> "" Then
                exam.WithSituation = "True"
            Else
                exam.WithSituation = "False"
            End If
            exam.ImageFilename = txtImage.Text
            exam.Trail = ActiveUser
            If formUpdate = True Then
                exam.IsUpdate = "True"
                exam.MChoiceKeyCtr = formCtr
            Else
                exam.IsUpdate = "False"
                exam.MChoiceKeyCtr = GetExaminationMultipleChoice().Count + 1
            End If

            'Choices
            exam.Choice1 = txtChoice1.Text
            exam.Choice2 = txtChoice2.Text
            exam.Choice3 = txtChoice3.Text
            exam.Choice4 = txtChoice4.Text
            exam.Choice5 = txtChoice5.Text
            exam.Choice6 = txtChoice6.Text
            exam.Choice7 = txtChoice7.Text
            exam.Choice8 = txtChoice8.Text
            exam.Choice9 = txtChoice9.Text
            exam.Choice10 = txtChoice10.Text

            'Answer
            exam.IsCorrect1 = rbtnChecked1.Checked.ToString()
            exam.IsCorrect2 = rbtnChecked2.Checked.ToString()
            exam.IsCorrect3 = rbtnChecked3.Checked.ToString()
            exam.IsCorrect4 = rbtnChecked4.Checked.ToString()
            exam.IsCorrect5 = rbtnChecked5.Checked.ToString()
            exam.IsCorrect6 = rbtnChecked6.Checked.ToString()
            exam.IsCorrect7 = rbtnChecked7.Checked.ToString()
            exam.IsCorrect8 = rbtnChecked8.Checked.ToString()
            exam.IsCorrect9 = rbtnChecked9.Checked.ToString()
            exam.IsCorrect10 = rbtnChecked10.Checked.ToString()

            exam.IsCorrect1 = rbtnChecked1.Checked

            Dim validation = exam.IsValid()
            If Not validation.Success Then
                MessageBox.Show(validation.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim jObj As JObject = JObject.FromObject(exam)
            With jObj
                .Add("MC", "CH02")
                .Add("token", ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933"))
                .Add("user", ActiveUser)
            End With

            Dim jStr_Input As String = JsonConvert.SerializeObject(jObj)
            Dim res As String = ws.JsonStr2JsonStr(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If res = """done""" Then
                If exam.IsUpdate = False Then
                    MsgBox("Examination Essay Successfully Added !", vbInformation)
                Else
                    MsgBox("Examination Essay Successfully Updated !", vbInformation)
                End If
                Call Reload(1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub lvExaminationMultipleChoice_MouseClick(sender As Object, e As MouseEventArgs) Handles lvExaminationMultipleChoice.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim focusedItem = lvExaminationMultipleChoice.FocusedItem
            If focusedItem IsNot Nothing AndAlso focusedItem.Bounds.Contains(e.Location) Then
                ContextMenuStrip1.Show(Cursor.Position)
            End If
        End If
    End Sub
    Private Sub DeleteTool_Click(sender As Object, e As EventArgs) Handles DeleteTool.Click
        If lvExaminationMultipleChoice.SelectedItems.Count > 0 Then
            Dim item As ListViewItem = lvExaminationMultipleChoice.SelectedItems(0)
            If MsgBox("Are you sure you want to Delete?", vbQuestion + vbYesNo) = vbYes Then
                DeleteExamMultipleChoice(item.SubItems(0).Text)
            End If
        End If
    End Sub
    Private Sub UpdateTool_Click(sender As Object, e As EventArgs) Handles UpdateTool.Click
        If lvExaminationMultipleChoice.SelectedItems.Count > 0 Then
            Dim item As ListViewItem = lvExaminationMultipleChoice.SelectedItems(0)
            formCtr = item.SubItems(0).Text
            txtQuestion.Text = item.SubItems(1).Text
            txtChoice1.Text = item.SubItems(3).Text
            txtChoice2.Text = item.SubItems(4).Text
            txtChoice3.Text = item.SubItems(5).Text
            txtChoice4.Text = item.SubItems(6).Text
            txtChoice5.Text = item.SubItems(7).Text
            txtChoice6.Text = item.SubItems(8).Text
            txtChoice7.Text = item.SubItems(9).Text
            txtChoice8.Text = item.SubItems(10).Text
            txtChoice9.Text = item.SubItems(11).Text
            txtChoice10.Text = item.SubItems(12).Text
            Dim correctChoice As String = item.SubItems(14).Text
            Select Case correctChoice
                Case "CHOICE 1" : rbtnChecked1.Checked = True
                Case "CHOICE 2" : rbtnChecked2.Checked = True
                Case "CHOICE 3" : rbtnChecked3.Checked = True
                Case "CHOICE 4" : rbtnChecked4.Checked = True
                Case "CHOICE 5" : rbtnChecked5.Checked = True
                Case "CHOICE 6" : rbtnChecked6.Checked = True
                Case "CHOICE 7" : rbtnChecked7.Checked = True
                Case "CHOICE 8" : rbtnChecked8.Checked = True
                Case "CHOICE 9" : rbtnChecked9.Checked = True
                Case "CHOICE 10" : rbtnChecked10.Checked = True
            End Select
            txtPoints.Text = item.SubItems(15).Text
            cboJob.Text = item.SubItems(16).Text
            txtImage.Text = item.SubItems(17).Text
            formUpdate = True
        End If
    End Sub
    Private Sub DeleteExamMultipleChoice(var_del As String)
        Try
            MC = "CH03"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "var_del" + """:""" + var_del + """," &
                  """" + "MC" + """:""" + MC + """}"
            Dim res As String = ws.JsonStr2JsonStr(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If res = """sysmaint""" Then
            ElseIf res = """done""" Then
                MsgBox("Examination Multiple Choice Successfully Deleted.", vbInformation)
                Call Reload(1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub cboJob_Leave(sender As Object, e As EventArgs) Handles cboJob.Leave
        If Not IsInList(cboJob) Then
            MsgBox("Not in List", MessageBoxIcon.Exclamation)
            cboJob.Text = ""
            Exit Sub
        End If
    End Sub
    Private Sub cboSituation_Leave(sender As Object, e As EventArgs) Handles cboSituation.Leave
        If Not IsInList(cboSituation) Then
            MsgBox("Not in List", MessageBoxIcon.Exclamation)
            cboSituation.Text = ""
            Exit Sub
        End If
    End Sub

End Class