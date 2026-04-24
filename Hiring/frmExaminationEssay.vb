Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports NXNParsing

Public Class frmExaminationEssay
    Private jStr_Input As String = "[]"
    Private ws As New WSConnection
    Private Token As String = String.Empty
    Private ActiveFrm As String = "frmExaminationEssay.php"

    Dim formUpdate As Boolean = False
    Dim formCtr As String = String.Empty
    Private Sub frmExaminationEssay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                    Call LoadExaminationEssay(GetExaminationEssay)
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
    End Sub
    Public Sub Reload(ByVal pAction As Integer)
        If pAction = 0 OrElse pAction = 1 Then
            classTimer.EventType = 1
            Timer1.Enabled = True
        End If
    End Sub
    Public Sub LoadExaminationEssay(ByVal pList As List(Of ExaminationEssay))
        With lvExaminationEssay
            .Items.Clear()
            For Each item In pList
                Dim lv_ As ListViewItem = New ListViewItem(item.EssayKeyCtr)
                lv_.SubItems.Add(item.Question.ToProperCase)
                lv_.SubItems.Add(If(item.IsQuesPic = True, "YES", "NO"))
                lv_.SubItems.Add(If(item.WithSituation = True, "YES", "NO"))
                lv_.SubItems.Add(item.Pts)
                lv_.SubItems.Add(item.JobCode)
                lv_.SubItems.Add(item.ImageFilename)
                lv_.SubItems.Add(item.SitKeyCtr)
                .Items.Add(lv_)
            Next
        End With
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim essay As New ExaminationEssay()
            essay.JobCode = cboJob.Text
            essay.Question = txtQuestion.Text
            essay.Pts = txtPoints.Text
            essay.ImageFilename = txtImage.Text
            If essay.ImageFilename <> "" Then
                essay.IsQuesPic = "True"
            Else
                essay.IsQuesPic = "False"
            End If
            essay.SitKeyCtr = Trim(cboSituation.Text)
            If essay.SitKeyCtr <> "" Then
                essay.WithSituation = "True"
            Else
                essay.WithSituation = "False"
            End If
            essay.ImageFilename = txtImage.Text
            essay.Trail = ActiveUser
            If formUpdate = True Then
                essay.IsUpdate = "True"
                essay.EssayKeyCtr = formCtr
            Else
                essay.IsUpdate = "False"
                essay.EssayKeyCtr = GetExaminationEssay().Count + 1
            End If

            Dim validation = essay.IsValid()
            If Not validation.Success Then
                MessageBox.Show(validation.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim jObj As JObject = JObject.FromObject(essay)
            With jObj
                .Add("MC", "ESSAY02")
                .Add("token", ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933"))
                .Add("user", ActiveUser)
            End With

            Dim jStr_Input As String = JsonConvert.SerializeObject(jObj)
            Dim res As String = ws.JsonStr2JsonStr(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If res = """done""" Then
                If essay.IsUpdate = False Then
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
    Private Sub lvExaminationEssay_MouseClick(sender As Object, e As MouseEventArgs) Handles lvExaminationEssay.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim focusedItem = lvExaminationEssay.FocusedItem
            If focusedItem IsNot Nothing AndAlso focusedItem.Bounds.Contains(e.Location) Then
                ContextMenuStrip1.Show(Cursor.Position)
            End If
        End If
    End Sub
    Private Sub DeleteTool_Click(sender As Object, e As EventArgs) Handles DeleteTool.Click
        If lvExaminationEssay.SelectedItems.Count > 0 Then
            Dim item As ListViewItem = lvExaminationEssay.SelectedItems(0)
            If MsgBox("Are you sure you want to Delete?", vbQuestion + vbYesNo) = vbYes Then
                DeleteExamEssay(item.SubItems(0).Text)
            End If
        End If
    End Sub
    Private Sub UpdateTool_Click(sender As Object, e As EventArgs) Handles UpdateTool.Click
        If lvExaminationEssay.SelectedItems.Count > 0 Then
            Dim item As ListViewItem = lvExaminationEssay.SelectedItems(0)
            cboJob.Text = item.SubItems(5).Text
            txtQuestion.Text = item.SubItems(1).Text
            txtPoints.Text = item.SubItems(4).Text
            txtImage.Text = item.SubItems(6).Text
            cboSituation.Text = item.SubItems(7).Text
            formUpdate = True
            formCtr = item.SubItems(0).Text
        End If
    End Sub
    Private Sub DeleteExamEssay(var_del As String)
        Try
            MC = "ESSAY03"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "var_del" + """:""" + var_del + """," &
                  """" + "MC" + """:""" + MC + """}"
            Dim res As String = ws.JsonStr2JsonStr(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If res = """sysmaint""" Then
            ElseIf res = """done""" Then
                MsgBox("Examination Essay Successfully Deleted.", vbInformation)
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