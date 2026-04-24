Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports NXNParsing

Public Class frmApplicantExamination
    Private jStr_Input As String = "[]"
    Private ws As New WSConnection
    Private Token As String = String.Empty
    Private ActiveFrm As String = "frmApplicantExamination.php"

    Dim formUpdate As Boolean = False
    Dim formCtr As String = String.Empty
    Private Sub frmApplicantExamination_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                    Call LoadApplicant(GetApplicantProfile)
                    If Trim(cboJob.Text) <> "" Then
                        Call LoadApplicantExamination(GetApplicantExamination(Trim(cboJob.Text)))
                    End If
                    Call classComboBox.setCboBatch(cboExamBatchNo)
                    Call classComboBox.setCboBatch(cboExamBatchNo1)
                    Call classComboBox.setCboExam(cboExam)

                    Call classTimer.CloseLoading(frmLoading)
                    Call classTimer.TimerReset()
            End Select
        End If
        classTimer.TimerCount += 1
    End Sub
    Private Sub Clear()
        cboJob.Text = ""
        cboExamBatchNo.Text = ""
        dtOpen1.Text = ""
        dtOpen2.Text = ""
        dtAnswered.Text = ""
        txtScore.Text = ""
        txtRate.Text = ""
        txtAssesment.Text = ""
        txtRemarks.Text = ""
        cboExam.Text = ""
        txtReason.Text = ""
        cboExamBatchNo1.Text = ""

        For Each item As ListViewItem In lvApplicant.Items
            item.Checked = False
        Next

        formUpdate = False
        formCtr = ""
    End Sub
    Public Sub Reload(ByVal pAction As Integer)
        If pAction = 0 OrElse pAction = 1 Then
            classTimer.EventType = 1
            Timer1.Enabled = True
        End If
    End Sub
    Public Sub LoadApplicant(ByVal pList As List(Of ApplicantProfile))
        With lvApplicant
            .Items.Clear()
            For Each item In pList
                Dim lv_ As ListViewItem = New ListViewItem(item.IdNo)
                lv_.SubItems.Add(item.LName.ToProperCase & ", " & item.FName.ToProperCase & " " & item.MName.ToProperCase)
                .Items.Add(lv_)
            Next
        End With
    End Sub
    Public Sub LoadApplicantExamination(ByVal pList As List(Of ApplicantExamination))
        With lvApplicantExamination
            .Items.Clear()
            For Each item In pList
                Dim lv_ As ListViewItem = New ListViewItem(item.MainKeyCtr)
                lv_.SubItems.Add(item.IdNo)
                lv_.SubItems.Add(item.LName.ToProperCase & ", " & item.FName.ToProperCase & " " & item.MName.ToProperCase)
                lv_.SubItems.Add(item.JobCode)
                lv_.SubItems.Add(item.DateOpenFrom)
                lv_.SubItems.Add(item.DateOpenTo)
                lv_.SubItems.Add(item.DateAnswered)
                lv_.SubItems.Add(item.Score)
                lv_.SubItems.Add(item.Rate)
                lv_.SubItems.Add(item.Assessment)
                lv_.SubItems.Add(item.Remark)
                lv_.SubItems.Add(item.ReschedReason)
                lv_.SubItems.Add(item.BatchExam)
                .Items.Add(lv_)
            Next
        End With
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim res_ As String = ""
            Dim app As New ApplicantExamination()
            app.JobCode = cboJob.Text
            app.BatchExam = cboExamBatchNo.Text
            app.DateOpenFrom = dtOpen1.Text
            app.DateOpenTo = dtOpen2.Text
            app.DateAnswered = dtAnswered.Text
            app.Score = Val(txtScore.Text)
            app.Rate = Val(txtRate.Text)
            app.Assessment = txtAssesment.Text
            app.Remark = txtRemarks.Text
            app.Trail = ActiveUser
            If formUpdate = True Then
                app.IsUpdate = "True"
                app.MainKeyCtr = formCtr
            Else
                app.IsUpdate = "False"
                app.MainKeyCtr = GetApplicantExamination(Trim(cboExamBatchNo.Text)).Count + 1
            End If

            If lvApplicant.CheckedItems.Count = 0 Then
                MessageBox.Show("Please select at least one applicant from the list.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim validation = app.IsValid()
            If Not validation.Success Then
                MessageBox.Show(validation.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim varID As String = ""
            For Each item As ListViewItem In Me.lvApplicant.Items
                If item.Checked = True Then
                    varID = Trim(item.SubItems(0).Text)

                    Dim job = GetApplicantExamination(Trim(cboJob.Text)).FirstOrDefault(Function(j) j.JobCode = app.JobCode And j.IdNo = Trim(item.SubItems(0).Text))
                    If job IsNot Nothing Then
                        If MsgBox("Applicant " & Trim(item.SubItems(1).Text) & " examinaton has already exist. Do you want to overwrite it?", vbYesNo + vbQuestion) = vbNo Then
                            Continue For
                        Else
                            app.IsUpdate = "True"
                        End If
                    End If

                    Dim jObj As JObject = JObject.FromObject(app)
                    With jObj
                        .Add("MC", "EXAM02")
                        .Add("token", ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933"))
                        .Add("user", ActiveUser)
                        .Add("varID", varID)
                    End With

                    Dim jStr_Input As String = JsonConvert.SerializeObject(jObj)
                    Dim res As String = ws.JsonStr2JsonStr(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
                    res_ = res
                End If
            Next

            If res_ = """done""" Then
                If app.IsUpdate = False Then
                    MsgBox("Applicant Examination Successfully Added !", vbInformation)
                Else
                    MsgBox("Applicant Examination Successfully Updated !", vbInformation)
                End If
                Call Reload(1)
                Call LoadApplicantExamination(GetApplicantExamination(app.JobCode))

            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub cboJob_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboJob.SelectedIndexChanged
        If Trim(cboExamBatchNo.Text) <> "" Then
            Call LoadApplicantExamination(GetApplicantExamination(Trim(cboJob.Text)))
        End If
    End Sub
    Private Sub lvApplicantExamination_MouseClick(sender As Object, e As MouseEventArgs) Handles lvApplicantExamination.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim focusedItem = lvApplicantExamination.FocusedItem
            If focusedItem IsNot Nothing AndAlso focusedItem.Bounds.Contains(e.Location) Then
                ContextMenuStrip1.Show(Cursor.Position)
            End If
        End If
    End Sub
    Private Sub DeleteTool_Click(sender As Object, e As EventArgs) Handles DeleteTool.Click
        If lvApplicantExamination.SelectedItems.Count > 0 Then
            Dim item As ListViewItem = lvApplicantExamination.SelectedItems(0)
            If MsgBox("Are you sure you want to Delete?", vbQuestion + vbYesNo) = vbYes Then
                DeleteApplicantExamination(item.SubItems(0).Text)
            End If
        End If
    End Sub
    Private Sub UpdateTool_Click(sender As Object, e As EventArgs) Handles UpdateTool.Click
        If lvApplicantExamination.SelectedItems.Count > 0 Then
            Dim item As ListViewItem = lvApplicantExamination.SelectedItems(0)

            For Each chk As ListViewItem In lvApplicant.Items
                If chk.SubItems.Count > 1 AndAlso chk.SubItems(0).Text = item.SubItems(1).Text Then
                    chk.Checked = True
                End If
            Next

            cboJob.Text = item.SubItems(3).Text
            cboExamBatchNo.Text = item.SubItems(12).Text
            dtOpen1.Text = item.SubItems(4).Text
            dtOpen2.Text = item.SubItems(5).Text
            dtAnswered.Text = item.SubItems(6).Text
            txtScore.Text = item.SubItems(7).Text
            txtRate.Text = item.SubItems(8).Text
            txtAssesment.Text = item.SubItems(9).Text
            txtRemarks.Text = item.SubItems(10).Text

            formUpdate = True
            formCtr = item.SubItems(0).Text
        End If
    End Sub
    Private Sub DeleteApplicantExamination(var_del As String)
        Try
            MC = "EXAM03"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "var_del" + """:""" + var_del + """," &
                  """" + "MC" + """:""" + MC + """}"
            Dim res As String = ws.JsonStr2JsonStr(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If res = """sysmaint""" Then
            ElseIf res = """done""" Then
                MsgBox("Applicant Examination Successfully Deleted.", vbInformation)
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
    Private Sub cboExamBatchNo_Leave(sender As Object, e As EventArgs) Handles cboExamBatchNo.Leave
        If Not IsInList(cboExamBatchNo) Then
            MsgBox("Not in List", MessageBoxIcon.Exclamation)
            cboExamBatchNo.Text = ""
            Exit Sub
        End If
    End Sub
    Private Sub cboExamBatchNo1_Leave(sender As Object, e As EventArgs) Handles cboExamBatchNo1.Leave
        If Not IsInList(cboExamBatchNo1) Then
            MsgBox("Not in List", MessageBoxIcon.Exclamation)
            cboExamBatchNo1.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub btnResched_Click(sender As Object, e As EventArgs) Handles btnResched.Click
        Try
            Dim app As New ApplicantExamination()
            app.JobCode = cboExam.Text
            app.DateOpenFrom = dtResched1.Text
            app.DateOpenTo = dtResched2.Text
            app.BatchExam = cboExamBatchNo1.Text
            app.ReschedReason = txtReason.Text

            Dim validation = app.IsValidResched()
            If Not validation.Success Then
                MessageBox.Show(validation.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim jObj As JObject = JObject.FromObject(app)
            With jObj
                .Add("MC", "EXAM04")
                .Add("token", ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933"))
                .Add("user", ActiveUser)
            End With

            Dim jStr_Input As String = JsonConvert.SerializeObject(jObj)
            Dim res As String = ws.JsonStr2JsonStr(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If res = """done""" Then
                MsgBox("Applicant Examination Successfully Rescheduled !", vbInformation)
                Call Reload(1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub chkResched_CheckedChanged(sender As Object, e As EventArgs) Handles chkResched.CheckedChanged
        If chkResched.Checked = True Then
            btnResched.Enabled = True
        Else
            btnResched.Enabled = False
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call Clear()
    End Sub
End Class