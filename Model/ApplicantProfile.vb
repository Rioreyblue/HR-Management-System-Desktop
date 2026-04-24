Imports Newtonsoft.Json

Public Class ApplicantProfile
    <JsonProperty("idno")>
    Public Property IdNo As String

    <JsonProperty("xtra_idno")>
    Public Property XtraIdNo As String

    <JsonProperty("lname")>
    Public Property LName As String

    <JsonProperty("fname")>
    Public Property FName As String

    <JsonProperty("mname")>
    Public Property MName As String

    <JsonProperty("maiden")>
    Public Property Maiden As String

    <JsonProperty("gender")>
    Public Property Gender As String

    <JsonProperty("civil_status")>
    Public Property CivilStatus As String

    <JsonProperty("spouse")>
    Public Property Spouse As String

    <JsonProperty("citizenship")>
    Public Property Citizenship As String

    <JsonProperty("bdate")>
    Public Property BDate As Date?

    <JsonProperty("tin_no")>
    Public Property TinNo As String

    <JsonProperty("sss_no")>
    Public Property SssNo As String

    <JsonProperty("hdmf_no")>
    Public Property HdmfNo As String

    <JsonProperty("phealth_no")>
    Public Property PHealthNo As String

    <JsonProperty("philid_no")>
    Public Property PhilIdNo As String

    <JsonProperty("religion")>
    Public Property Religion As String

    <JsonProperty("placeofbirth")>
    Public Property PlaceOfBirth As String

    <JsonProperty("pincode")>
    Public Property PinCode As String

    ' picture (lo) - Typically handled as Byte() or skipped in basic JSON
    <JsonProperty("picture")>
    Public Property Picture As Object

    <JsonProperty("main")>
    Public Property Main As Long?

    <JsonProperty("remarks")>
    Public Property Remarks As String

    <JsonProperty("trail")>
    Public Property Trail As String

    <JsonProperty("gsis_no")>
    Public Property GsisNo As String

    <JsonProperty("medicare_no")>
    Public Property MedicareNo As String

    <JsonProperty("hired")>
    Public Property Hired As Boolean = False

    ' my_sign (lo) - Typically handled as Byte() or skipped in basic JSON
    <JsonProperty("my_sign")>
    Public Property MySign As Object

    <JsonProperty("sign_id")>
    Public Property SignId As Long?

    <JsonProperty("mother_maiden")>
    Public Property MotherMaiden As String

    <JsonProperty("father_surname")>
    Public Property FatherSurname As String

    <JsonProperty("blood_type")>
    Public Property BloodType As String

    <JsonProperty("height")>
    Public Property Height As String

    <JsonProperty("weight")>
    Public Property Weight As String

    <JsonProperty("agency_no")>
    Public Property AgencyNo As String

    <JsonProperty("mother_fname")>
    Public Property MotherFName As String

    <JsonProperty("mother_mname")>
    Public Property MotherMName As String

    <JsonProperty("mother_occupation")>
    Public Property MotherOccupation As String

    <JsonProperty("father_fname")>
    Public Property FatherFName As String

    <JsonProperty("father_mname")>
    Public Property FatherMName As String

    <JsonProperty("father_occupation")>
    Public Property FatherOccupation As String

    <JsonProperty("nameextension")>
    Public Property NameExtension As String

    <JsonProperty("mother_surname")>
    Public Property MotherSurname As String

    <JsonProperty("applied_position")>
    Public Property AppliedPosition As String

    <JsonProperty("application_date")>
    Public Property ApplicationDate As Date?

    <JsonProperty("application_status")>
    Public Property ApplicationStatus As String

    <JsonProperty("application_remarks")>
    Public Property ApplicationRemarks As String

    <JsonProperty("application_source")>
    Public Property ApplicationSource As String

    <JsonProperty("exam_schedule")>
    Public Property ExamSchedule As Integer?

    <JsonProperty("Deceased_mother")>
    Public Property DeceasedMother As Boolean = False

    <JsonProperty("Deceased_father")>
    Public Property DeceasedFather As Boolean = False

    <JsonProperty("expected_salary")>
    Public Property ExpectedSalary As Double = 0

    <JsonProperty("rating_exam")>
    Public Property RatingExam As Double = 0

    <JsonProperty("rating_interview")>
    Public Property RatingInterview As Double = 0

    <JsonProperty("rating_evaluation")>
    Public Property RatingEvaluation As Double = 0

    <JsonProperty("assestment_remarks")>
    Public Property AssessmentRemarks As String

    <JsonProperty("interview_score")>
    Public Property InterviewScore As Double = 0

    <JsonProperty("interview_remarks")>
    Public Property InterviewRemarks As String

    <JsonProperty("evaluation_score")>
    Public Property EvaluationScore As Double = 0

    <JsonProperty("evaluation_remarks")>
    Public Property EvaluationRemarks As String

    <JsonProperty("evaluation_education")>
    Public Property EvaluationEducation As Boolean = False

    <JsonProperty("evaluation_experienced")>
    Public Property EvaluationExperienced As Boolean = False

    <JsonProperty("evaluation_attitude")>
    Public Property EvaluationAttitude As Boolean = False

    <JsonProperty("evaluation_appearance")>
    Public Property EvaluationAppearance As Boolean = False

    <JsonProperty("educational_attainment")>
    Public Property EducationalAttainment As String

    <JsonProperty("academic_program")>
    Public Property AcademicProgram As String

    <JsonProperty("yrs_experienced")>
    Public Property YrsExperienced As String

    <JsonProperty("evaluation_recognition")>
    Public Property EvaluationRecognition As Boolean = False

    <JsonProperty("evaluation_license")>
    Public Property EvaluationLicense As Boolean = False

    <JsonProperty("evaluation_skills")>
    Public Property EvaluationSkills As Boolean = False

    <JsonProperty("evaluation_trainings")>
    Public Property EvaluationTrainings As Boolean = False

    <JsonProperty("assessment_score")>
    Public Property AssessmentScore As Double = 0

    <JsonProperty("assessment_rating")>
    Public Property AssessmentRating As Double = 0

    <JsonProperty("companycode")>
    Public Property CompanyCode As String

    <JsonProperty("companydesc")>
    Public Property CompanyDesc As String

    <JsonProperty("mother_bdate")>
    Public Property MotherBDate As Date?

    <JsonProperty("father_bdate")>
    Public Property FatherBDate As Date?

    <JsonProperty("shortlisted")>
    Public Property Shortlisted As Boolean = False

    <JsonProperty("motherinlaw_maiden")>
    Public Property MotherInLawMaiden As String

    <JsonProperty("motherinlaw_surname")>
    Public Property MotherInLawSurname As String

    <JsonProperty("motherinlaw_fname")>
    Public Property MotherInLawFName As String

    <JsonProperty("motherinlaw_mname")>
    Public Property MotherInLawMName As String

    <JsonProperty("motherinlaw_occupation")>
    Public Property MotherInLawOccupation As String

    <JsonProperty("motherinlaw_bdate")>
    Public Property MotherInLawBDate As Date?

    <JsonProperty("fatherinlaw_surname")>
    Public Property FatherInLawSurname As String

    <JsonProperty("fatherinlaw_fname")>
    Public Property FatherInLawFName As String

    <JsonProperty("fatherinlaw_mname")>
    Public Property FatherInLawMName As String

    <JsonProperty("fatherinlaw_occupation")>
    Public Property FatherInLawOccupation As String

    <JsonProperty("fatherinlaw_bdate")>
    Public Property FatherInLawBDate As Date?

    <JsonProperty("passport_no")>
    Public Property PassportNo As String

    <JsonProperty("corporate_nickname")>
    Public Property CorporateNickname As String

    Public Sub PopulateForm(ByVal frm As frmApplicantProfile)
        frm.lblName.Text = StrConv(Me.LName & ", " & Me.FName & " " & Me.MName, vbProperCase)
        frm.lblCname.Text = StrConv(Me.LName & ", " & Me.FName & " " & Me.MName, vbProperCase)
        frm.lblID.Text = Me.IdNo
        frm.lblGender.Text = StrConv(GetSex(Me.Gender), vbProperCase)
        frm.lblCivilStat.Text = StrConv(GetCivilStatus(Me.CivilStatus), vbProperCase)
        frm.lblBdate.Text = CDate(Me.BDate).ToString("MMMM dd, yyyy")
        If IsDBNull(Me.Citizenship) = False Then frm.lblCitizenship.Text = StrConv(Me.Citizenship, vbProperCase)
        If IsDBNull(Me.PlaceOfBirth) = False Then frm.lblPlaceOfBirth.Text = StrConv(Me.PlaceOfBirth, vbProperCase)
        If IsDBNull(Me.ApplicationStatus) = False Then frm.lblApplicantStatus.Text = StrConv(Me.ApplicationStatus, vbProperCase)
        If IsDBNull(Me.Religion) = False Then frm.lblReligion.Text = StrConv(Me.Religion, vbProperCase)
        Dim appContact = GetApplicantContacts.FirstOrDefault(Function(j) j.IdNo = Me.IdNo)
        If appContact IsNot Nothing Then
            If appContact.EmailAddress IsNot Nothing Then
                frm.lblCEmail.Text = StrConv(appContact.EmailAddress, VbStrConv.Lowercase)
            Else
                frm.lblCEmail.Text = String.Empty
            End If
        End If


    End Sub
End Class
