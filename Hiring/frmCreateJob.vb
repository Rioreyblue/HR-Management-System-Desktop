Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports NXNParsing

Public Class frmCreateJob
    Private jStr_Input As String = "[]"
    Private ws As New WSConnection
    Private Token As String = String.Empty
    Private ActiveFrm As String = "frmRecruitment.php"

    Public Property jobctr_ As String = ""
    Private Sub frmCreateJob_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

                    Call classComboBox.setCboCompany(cboCompany)
                    Call classComboBox.setCboDivision(cboDivision)
                    Call classComboBox.setCboJobType(cbojobtype)
                    Call classComboBox.setCboJobGrading(cboJobGrade)
                    Call Update_Job()

                    Call classTimer.CloseLoading(frmLoading)
                    Call classTimer.TimerReset()
            End Select
        End If
        classTimer.TimerCount += 1
    End Sub
    Private Sub Clear()
        cboCompany.Text = ""
        cboDivision.Text = ""
        cboDepartment.Text = ""
        cboJobGrade.Text = ""
        cbojobtype.Text = ""

        txtJobTitle.Text = ""
        txtHiresNeeded.Text = ""
        txtSalary1.Text = ""
        txtSalary2.Text = ""
        txtPlaceOfAssignment.Text = ""
        txtJobSummary.Text = ""
        txtJobResponsibilities.Text = ""
        txtJobQualifications.Text = ""
        txtJobExperiences.Text = ""

        dtNeeded1.Value = DateTime.Now
        dtNeeded2.Value = DateTime.Now

        chk13thMonth.Checked = False
        chkNightShift.Checked = False
        chkOvertime.Checked = False
        chkPagibig.Checked = False
        chkPhealth.Checked = False
        chkSSS.Checked = False
        chkBereavement.Checked = False
        chkBday.Checked = False
        chkEmergency.Checked = False
        chkMagnaCarta.Checked = False
        chkMaternity.Checked = False
        chkPaternity.Checked = False
        chkSick.Checked = False
        chkSoloParent.Checked = False
        chkVacation.Checked = False
        chkVAWC.Checked = False
        chkDiminimis.Checked = False
        chkLocPackage.Checked = False
        chkMileage.Checked = False
        chkPerformance.Checked = False
        chkReimbursements.Checked = False
        chkSignInBonus.Checked = False
        chkHealthInsurance.Checked = False
        chkLifeInsurance.Checked = False

        jobctr_ = ""
    End Sub
    Private Sub Update_Job()
        If jobctr_ <> "" Then
            Dim job = GetMaintenanceJobs.FirstOrDefault(Function(j) j.JobCode = jobctr_)
            If job IsNot Nothing Then
                job.PopulateForm(Me)
            Else
                MessageBox.Show("Job details not found for: " & jobctr_, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            Call Clear()
        End If
    End Sub

    Private Sub cboDivision_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboDivision.SelectionChangeCommitted
        paramDiv = String.Empty
        paramDiv = GetColumnValue(cboDivision, 0)
        If ActiveCompany <> "" And paramDiv <> "" Then
            Call classComboBox.setCboDepartment(cboDepartment, Trim(cboDivision.Text))
        End If
    End Sub

    Private Sub btnCreateJob_Click(sender As Object, e As EventArgs) Handles btnCreateJob.Click
        Try
            Dim job As New MaintenanceJob()
            job.Company = cboCompany.Text
            job.DivCode = cboDivision.Text
            job.DeptCode = cboDepartment.Text
            job.JobType = cbojobtype.Text
            If jobctr_ <> "" Then
                job.IsUpdate = True
                job.JobCode = jobctr_
            Else
                job.IsUpdate = False
                job.JobCode = "JOB-" & DateTime.Now.ToString("yy") & "-" & (GetMaintenanceJobs().Count + 1).ToString("D4")
            End If
            job.JobTitle = txtJobTitle.Text
            job.JobGrade = cboJobGrade.Text
            job.HiresNeeded = Val(txtHiresNeeded.Text)
            job.Salary1 = Val(txtSalary1.Text)
            job.Salary2 = Val(txtSalary2.Text)
            job.DateNeeded1 = dtNeeded1.Value
            job.DateNeeded2 = dtNeeded2.Value
            job.PlaceOfAssignment = txtPlaceOfAssignment.Text
            job.JobSummary = txtJobSummary.Text
            job.JobResponsibilities = txtJobResponsibilities.Text
            job.JobQualifications = txtJobQualifications.Text
            job.JobExperiences = txtJobExperiences.Text
            job.Is13thMonthPay = chk13thMonth.Checked
            job.NightShiftDiff = chkNightShift.Checked
            job.OtPay = chkOvertime.Checked
            job.Pagibig = chkPagibig.Checked
            job.Philhealth = chkPhealth.Checked
            job.Sss = chkSSS.Checked
            job.LvBereavement = chkBereavement.Checked
            job.LvBday = chkBday.Checked
            job.LvEmergency = chkEmergency.Checked
            job.LvMagnaCarta = chkMagnaCarta.Checked
            job.LvMaternity = chkMaternity.Checked
            job.LvPaternity = chkPaternity.Checked
            job.LvSick = chkSick.Checked
            job.LvSoloParent = chkSoloParent.Checked
            job.LvVacation = chkVacation.Checked
            job.LvVawc = chkVAWC.Checked
            job.AddDiminimis = chkDiminimis.Checked
            job.AddLocPackage = chkLocPackage.Checked
            job.AddMileage = chkMileage.Checked
            job.AddPerformance = chkPerformance.Checked
            job.AddReimbursements = chkReimbursements.Checked
            job.AddSigninBonus = chkSignInBonus.Checked
            job.HealthInsurance = chkHealthInsurance.Checked
            job.LifeInsurance = chkLifeInsurance.Checked
            job.Trail = ActiveUser


            Dim validation = job.IsValid()
            If Not validation.Success Then
                MessageBox.Show(validation.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim jObj As JObject = JObject.FromObject(job)
            With jObj
                .Add("MC", "REC04")
                .Add("token", ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933"))
                .Add("user", ActiveUser)
            End With

            Dim jStr_Input As String = JsonConvert.SerializeObject(jObj)
            Dim res As String = ws.JsonStr2JsonStr(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If res = """done""" Then
                If job.IsUpdate = True Then
                    MsgBox("Job Maintenance Successfully Updated !", vbInformation)
                Else
                    MsgBox("Job Maintenance Successfully Added !", vbInformation)
                End If
                Call frmHiringJob.HiringJob_List()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

End Class