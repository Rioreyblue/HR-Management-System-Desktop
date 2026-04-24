Imports Newtonsoft.Json

Public Class MaintenanceJob
    ' --- Basic Information ---
    <JsonProperty("jobcode")>
    Public Property JobCode As String

    <JsonProperty("jobtitle")>
    Public Property JobTitle As String
    <JsonProperty("company")>
    Public Property Company As String

    <JsonProperty("divcode")>
    Public Property DivCode As String

    <JsonProperty("deptcode")>
    Public Property DeptCode As String

    <JsonProperty("jobtype")>
    Public Property JobType As String

    '<JsonProperty("jobcode")>
    'Public Property JobCode As String

    '<JsonProperty("jobtitle")>
    'Public Property JobTitle As String

    <JsonProperty("jobgrade")>
    Public Property JobGrade As String

    <JsonProperty("hires_needed")>
    Public Property HiresNeeded As Integer

    <JsonProperty("salary1")>
    Public Property Salary1 As Double

    <JsonProperty("salary2")>
    Public Property Salary2 As Double

    <JsonProperty("date_needed1")>
    Public Property DateNeeded1 As Date

    <JsonProperty("date_needed2")>
    Public Property DateNeeded2 As Date

    <JsonProperty("place_of_assignment")>
    Public Property PlaceOfAssignment As String

    <JsonProperty("job_summary")>
    Public Property JobSummary As String

    <JsonProperty("job_responsibilities")>
    Public Property JobResponsibilities As String

    <JsonProperty("job_qualifications")>
    Public Property JobQualifications As String

    <JsonProperty("job_experiences")>
    Public Property JobExperiences As String

    ' --- Benefits & Government ---
    <JsonProperty("_13thmonth_pay")>
    Public Property Is13thMonthPay As String

    <JsonProperty("night_shift_diff")>
    Public Property NightShiftDiff As String

    <JsonProperty("ot_pay")>
    Public Property OtPay As String

    <JsonProperty("pagibig")>
    Public Property Pagibig As String

    <JsonProperty("philhealth")>
    Public Property Philhealth As String

    <JsonProperty("sss")>
    Public Property Sss As String

    ' --- Leaves  ---
    <JsonProperty("lv_bereavement")>
    Public Property LvBereavement As String

    <JsonProperty("lv_bday")>
    Public Property LvBday As String

    <JsonProperty("lv_emergency")>
    Public Property LvEmergency As String

    <JsonProperty("lv_magna_carta")>
    Public Property LvMagnaCarta As String

    <JsonProperty("lv_maternity")>
    Public Property LvMaternity As String

    <JsonProperty("lv_paternity")>
    Public Property LvPaternity As String

    <JsonProperty("lv_sick")>
    Public Property LvSick As String

    <JsonProperty("lv_solo_parent")>
    Public Property LvSoloParent As String

    <JsonProperty("lv_vacation")>
    Public Property LvVacation As String

    <JsonProperty("lv_vawc")>
    Public Property LvVawc As String

    ' --- Additional Packages ---
    <JsonProperty("add_diminimis")>
    Public Property AddDiminimis As String

    <JsonProperty("add_loc_package")>
    Public Property AddLocPackage As String

    <JsonProperty("add_mileage")>
    Public Property AddMileage As String

    <JsonProperty("add_performance")>
    Public Property AddPerformance As String

    <JsonProperty("add_reimbursements")>
    Public Property AddReimbursements As String

    <JsonProperty("add_signin_bonus")>
    Public Property AddSigninBonus As String

    ' --- Insurance & Audit ---
    <JsonProperty("health_insurance")>
    Public Property HealthInsurance As String

    <JsonProperty("life_insurance")>
    Public Property LifeInsurance As String

    <JsonProperty("trail")>
    Public Property Trail As String
    Public Property IsUpdate As String

    Public Function IsValid() As (Success As Boolean, Message As String)
        If String.IsNullOrWhiteSpace(Me.Company) OrElse Me.Company = "" Then
            Return (False, "Please select a Company.")
        End If

        If String.IsNullOrWhiteSpace(Me.DivCode) OrElse Me.DivCode = "" Then
            Return (False, "Please select a Division.")
        End If

        If String.IsNullOrWhiteSpace(Me.DeptCode) OrElse Me.DeptCode = "" Then
            Return (False, "Please select a Department.")
        End If

        If String.IsNullOrWhiteSpace(Me.JobType) OrElse Me.JobType = "" Then
            Return (False, "Please select a Job Type.")
        End If

        If String.IsNullOrWhiteSpace(Me.JobGrade) OrElse Me.JobGrade = "" Then
            Return (False, "Please select a Job Grade.")
        End If

        If String.IsNullOrWhiteSpace(Me.JobTitle) OrElse Me.JobTitle = "" Then
            Return (False, "Please select a Job Title.")
        End If

        If Me.HiresNeeded = 0 Then
            Return (False, "Please enter Hires Needed (must be at least 1).")
        End If

        If Me.Salary1 = 0 Then
            Return (False, "Please enter Salary Range.")
        End If

        If Me.Salary2 = 0 Then
            Return (False, "Please enter Salary Range.")
        End If

        If String.IsNullOrWhiteSpace(Me.JobSummary) OrElse Me.JobSummary = "" Then
            Return (False, "Please enter Job Summary.")
        End If

        Return (True, "Success")
    End Function

    Public Sub PopulateForm(ByVal frm As frmCreateJob)
        frm.cboCompany.Text = Me.Company
        frm.cboDivision.Text = Me.DivCode
        frm.cboDepartment.Text = Me.DeptCode
        frm.txtJobTitle.Text = Me.JobTitle
        frm.cboJobGrade.Text = Me.JobGrade
        frm.txtHiresNeeded.Text = Me.HiresNeeded.ToString()
        frm.txtSalary1.Text = Me.Salary1.ToString("N2")
        frm.txtSalary2.Text = Me.Salary2.ToString("N2")

        frm.dtNeeded1.Value = If(IsDate(Me.DateNeeded1), CDate(Me.DateNeeded1), DateTime.Now)
        frm.dtNeeded2.Value = If(IsDate(Me.DateNeeded2), CDate(Me.DateNeeded2), DateTime.Now)
        frm.txtPlaceOfAssignment.Text = Me.PlaceOfAssignment

        frm.txtJobSummary.Text = Me.JobSummary
        frm.txtJobResponsibilities.Text = Me.JobResponsibilities
        frm.txtJobQualifications.Text = Me.JobQualifications
        frm.txtJobExperiences.Text = Me.JobExperiences

        frm.chk13thMonth.Checked = Me.Is13thMonthPay
        frm.chkNightShift.Checked = Me.NightShiftDiff
        frm.chkOvertime.Checked = Me.OtPay
        frm.chkPagibig.Checked = Me.Pagibig
        frm.chkPhealth.Checked = Me.Philhealth
        frm.chkSSS.Checked = Me.Sss

        frm.chkBereavement.Checked = Me.LvBereavement
        frm.chkBday.Checked = Me.LvBday
        frm.chkEmergency.Checked = Me.LvEmergency
        frm.chkMagnaCarta.Checked = Me.LvMagnaCarta
        frm.chkMaternity.Checked = Me.LvMaternity
        frm.chkPaternity.Checked = Me.LvPaternity
        frm.chkSick.Checked = Me.LvSick
        frm.chkSoloParent.Checked = Me.LvSoloParent
        frm.chkVacation.Checked = Me.LvVacation
        frm.chkVAWC.Checked = Me.LvVawc

        frm.chkDiminimis.Checked = Me.AddDiminimis
        frm.chkLocPackage.Checked = Me.AddLocPackage
        frm.chkMileage.Checked = Me.AddMileage
        frm.chkPerformance.Checked = Me.AddPerformance
        frm.chkReimbursements.Checked = Me.AddReimbursements
        frm.chkSignInBonus.Checked = Me.AddSigninBonus
        frm.chkHealthInsurance.Checked = Me.HealthInsurance
        frm.chkLifeInsurance.Checked = Me.LifeInsurance
    End Sub

End Class
