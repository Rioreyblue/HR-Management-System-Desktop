Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports NXNParsing

Public Class frmExaminationMain
    Private jStr_Input As String = "[]"
    Private ws As New WSConnection
    Private Token As String = String.Empty
    Private ActiveFrm As String = "frmExaminationMain.php"

    Dim formUpdate As Boolean = False
    Dim formCtr As String = String.Empty
    Private Sub frmExaminationMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                    Call LoadExaminationMain(GetExaminationMain)

                    Call classTimer.CloseLoading(frmLoading)
                    Call classTimer.TimerReset()
            End Select
        End If
        classTimer.TimerCount += 1
    End Sub
    Private Sub Clear()
        cboJob.Text = ""
        chkTimeBounded.Checked = True
        chkRandomQuestion.Checked = True
        txtTimeMins.Text = ""
        txtPassingRate.Text = ""
        txtPerfectScore.Text = ""
        txtMaxQuestion.Text = ""
        txtInstructions.Text = ""
        txtRemarks.Text = ""
    End Sub
    Public Sub Reload(ByVal pAction As Integer)
        If pAction = 0 OrElse pAction = 1 Then
            classTimer.EventType = 1
            Timer1.Enabled = True
        End If
    End Sub
    Public Sub LoadExaminationMain(ByVal pList As List(Of ExaminationMain))
        With lvExaminationMain
            .Items.Clear()
            For Each item In pList
                Dim lv_ As ListViewItem = New ListViewItem(item.ExamKeyCtr)
                lv_.SubItems.Add(item.Description.ToProperCase)
                lv_.SubItems.Add(If(item.IsTimeBound = "1", "Y", "N"))
                lv_.SubItems.Add(item.TimeMinutes)
                lv_.SubItems.Add(If(item.IsRandomized = "1", "Y", "N"))
                lv_.SubItems.Add(item.PassingRate)
                lv_.SubItems.Add(item.MaxQuestion)
                lv_.SubItems.Add(item.PerfectScore)
                lv_.SubItems.Add(item.Instruction)
                lv_.SubItems.Add(item.Remark)
                lv_.SubItems.Add(item.JobCode)
                .Items.Add(lv_)
            Next
        End With
    End Sub

    Private Sub btnbtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim main As New ExaminationMain()
            main.JobCode = cboJob.Text
            main.Description = GetColumnValue(cboJob, 1)
            main.IsTimeBound = chkTimeBounded.Checked
            main.IsRandomized = chkRandomQuestion.Checked
            main.TimeMinutes = Val(txtTimeMins.Text)
            main.PassingRate = Val(txtPassingRate.Text)
            main.PerfectScore = Val(txtPerfectScore.Text)
            main.MaxQuestion = Val(txtMaxQuestion.Text)
            main.Instruction = txtInstructions.Text
            main.Remark = txtRemarks.Text
            main.Trail = ActiveUser
            If formUpdate = True Then
                main.IsUpdate = "True"
                main.ExamKeyCtr = formCtr
            Else
                main.IsUpdate = "False"
                main.ExamKeyCtr = GetExaminationMain().Count + 1
            End If

            Dim validation = main.IsValid()
            If Not validation.Success Then
                MessageBox.Show(validation.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim jObj As JObject = JObject.FromObject(main)
            With jObj
                .Add("MC", "MAIN02")
                .Add("token", ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933"))
                .Add("user", ActiveUser)
            End With

            Dim jStr_Input As String = JsonConvert.SerializeObject(jObj)
            Dim res As String = ws.JsonStr2JsonStr(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If res = """done""" Then
                If main.IsUpdate = False Then
                    MsgBox("Examination Main Successfully Added !", vbInformation)
                Else
                    MsgBox("Examination Main Successfully Updated !", vbInformation)
                End If
                Call Reload(1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub lvExaminationMain_MouseClick(sender As Object, e As MouseEventArgs) Handles lvExaminationMain.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim focusedItem = lvExaminationMain.FocusedItem
            If focusedItem IsNot Nothing AndAlso focusedItem.Bounds.Contains(e.Location) Then
                ContextMenuStrip1.Show(Cursor.Position)
            End If
        End If
    End Sub
    Private Sub DeleteTool_Click(sender As Object, e As EventArgs) Handles DeleteTool.Click
        If lvExaminationMain.SelectedItems.Count > 0 Then
            Dim item As ListViewItem = lvExaminationMain.SelectedItems(0)
            If MsgBox("Are you sure you want to Delete?", vbQuestion + vbYesNo) = vbYes Then
                DeleteExamMain(item.SubItems(0).Text)
            End If
        End If
    End Sub
    Private Sub UpdateTool_Click(sender As Object, e As EventArgs) Handles UpdateTool.Click
        If lvExaminationMain.SelectedItems.Count > 0 Then
            Dim item As ListViewItem = lvExaminationMain.SelectedItems(0)
            cboJob.Text = item.SubItems(10).Text
            chkTimeBounded.Checked = item.SubItems(2).Text = "Y"
            chkRandomQuestion.Checked = item.SubItems(4).Text = "Y"
            txtTimeMins.Text = item.SubItems(3).Text
            txtPassingRate.Text = item.SubItems(5).Text
            txtPerfectScore.Text = item.SubItems(7).Text
            txtMaxQuestion.Text = item.SubItems(6).Text
            txtInstructions.Text = item.SubItems(8).Text
            txtRemarks.Text = item.SubItems(9).Text
            formUpdate = True
            formCtr = item.SubItems(0).Text
        End If
    End Sub
    Private Sub DeleteExamMain(var_del As String)
        Try
            MC = "MAIN03"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "var_del" + """:""" + var_del + """," &
                  """" + "MC" + """:""" + MC + """}"
            Dim res As String = ws.JsonStr2JsonStr(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If res = """sysmaint""" Then
            ElseIf res = """done""" Then
                MsgBox("Examination Main Successfully Deleted.", vbInformation)
                Call Reload(1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class