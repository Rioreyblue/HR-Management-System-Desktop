Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports NXNParsing

Public Class frmExaminationInput
    Private jStr_Input As String = "[]"
    Private ws As New WSConnection
    Private Token As String = String.Empty
    Private ActiveFrm As String = "frmExaminationInput.php"

    Dim formUpdate As Boolean = False
    Dim formCtr As String = String.Empty
    Private Sub frmExaminationInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                    Call LoadExaminationInput(GetExaminationInput)
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
        txtAnswer.Text = ""
    End Sub
    Public Sub Reload(ByVal pAction As Integer)
        If pAction = 0 OrElse pAction = 1 Then
            classTimer.EventType = 1
            Timer1.Enabled = True
        End If
    End Sub
    Public Sub LoadExaminationInput(ByVal pList As List(Of ExaminationInput))
        With lvExaminationInput
            .Items.Clear()
            For Each item In pList
                Dim lv_ As ListViewItem = New ListViewItem(item.InpKeyCtr)
                lv_.SubItems.Add(item.Question.ToProperCase)
                lv_.SubItems.Add(If(item.IsQuesPic = True, "YES", "NO"))
                lv_.SubItems.Add(If(item.WithSituation = True, "YES", "NO"))
                lv_.SubItems.Add(item.Pts)
                lv_.SubItems.Add(item.CorrectAnswer)
                lv_.SubItems.Add(item.ImageFilename)
                lv_.SubItems.Add(item.JobCode)
                lv_.SubItems.Add(item.SitKeyCtr)
                .Items.Add(lv_)
            Next
        End With
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim input As New ExaminationInput()
            input.JobCode = cboJob.Text
            input.Question = txtQuestion.Text
            input.CorrectAnswer = txtAnswer.Text
            input.Pts = txtPoints.Text
            input.ImageFilename = txtImage.Text
            If input.ImageFilename <> "" Then
                input.IsQuesPic = "True"
            Else
                input.IsQuesPic = "False"
            End If
            input.SitKeyCtr = Trim(cboSituation.Text)
            If input.SitKeyCtr <> "" Then
                input.WithSituation = "True"
            Else
                input.WithSituation = "False"
            End If
            input.ImageFilename = txtImage.Text
            input.Trail = ActiveUser
            If formUpdate = True Then
                input.IsUpdate = "True"
                input.InpKeyCtr = formCtr
            Else
                input.IsUpdate = "False"
                input.InpKeyCtr = GetExaminationInput().Count + 1
            End If

            Dim validation = input.IsValid()
            If Not validation.Success Then
                MessageBox.Show(validation.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim jObj As JObject = JObject.FromObject(input)
            With jObj
                .Add("MC", "INPUT02")
                .Add("token", ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933"))
                .Add("user", ActiveUser)
            End With

            Dim jStr_Input As String = JsonConvert.SerializeObject(jObj)
            Dim res As String = ws.JsonStr2JsonStr(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If res = """done""" Then
                If input.IsUpdate = False Then
                    MsgBox("Examination Input Successfully Added !", vbInformation)
                Else
                    MsgBox("Examination Input Successfully Updated !", vbInformation)
                End If
                Call Reload(1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub lvExaminationInput_MouseClick(sender As Object, e As MouseEventArgs) Handles lvExaminationInput.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim focusedItem = lvExaminationInput.FocusedItem
            If focusedItem IsNot Nothing AndAlso focusedItem.Bounds.Contains(e.Location) Then
                ContextMenuStrip1.Show(Cursor.Position)
            End If
        End If
    End Sub
    Private Sub DeleteTool_Click(sender As Object, e As EventArgs) Handles DeleteTool.Click
        If lvExaminationInput.SelectedItems.Count > 0 Then
            Dim item As ListViewItem = lvExaminationInput.SelectedItems(0)
            If MsgBox("Are you sure you want to Delete?", vbQuestion + vbYesNo) = vbYes Then
                DeleteExamInput(item.SubItems(0).Text)
            End If
        End If
    End Sub
    Private Sub UpdateTool_Click(sender As Object, e As EventArgs) Handles UpdateTool.Click
        If lvExaminationInput.SelectedItems.Count > 0 Then
            Dim item As ListViewItem = lvExaminationInput.SelectedItems(0)
            txtAnswer.Text = item.SubItems(5).Text
            cboJob.Text = item.SubItems(7).Text
            txtQuestion.Text = item.SubItems(1).Text
            txtPoints.Text = item.SubItems(4).Text
            txtImage.Text = item.SubItems(6).Text
            cboSituation.Text = item.SubItems(8).Text
            formUpdate = True
            formCtr = item.SubItems(0).Text
        End If
    End Sub
    Private Sub DeleteExamInput(var_del As String)
        Try
            MC = "INPUT03"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "var_del" + """:""" + var_del + """," &
                  """" + "MC" + """:""" + MC + """}"
            Dim res As String = ws.JsonStr2JsonStr(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If res = """sysmaint""" Then
            ElseIf res = """done""" Then
                MsgBox("Examination Input Successfully Deleted.", vbInformation)
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