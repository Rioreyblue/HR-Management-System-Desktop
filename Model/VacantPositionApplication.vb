Imports Newtonsoft.Json

Public Class VacantPositionApplication
    <JsonProperty("keyctr")>
    Public Property KeyCtr As Long

    <JsonProperty("idno")>
    Public Property IdNo As String

    <JsonProperty("application_date")>
    Public Property ApplicationDate As Date?

    <JsonProperty("applied_position")>
    Public Property AppliedPosition As String

    <JsonProperty("item_no")>
    Public Property ItemNo As Integer?

    <JsonProperty("divcode")>
    Public Property DivCode As String

    <JsonProperty("active_emp")>
    Public Property ActiveEmp As Boolean

    <JsonProperty("trail")>
    Public Property Trail As String

    <JsonProperty("closed")>
    Public Property Closed As Boolean

    <JsonProperty("selected_lineup")>
    Public Property SelectedLineup As Boolean

    <JsonProperty("hired")>
    Public Property Hired As Boolean

    <JsonProperty("req_id")>
    Public Property ReqId As Integer?

    <JsonProperty("not_qualified")>
    Public Property NotQualified As Boolean

    <JsonProperty("salarysched")>
    Public Property SalarySched As String

    <JsonProperty("pyear")>
    Public Property PYear As String

    <JsonProperty("status_update")>
    Public Property StatusUpdate As Boolean

    <JsonProperty("education_remarks")>
    Public Property EducationRemarks As String

    <JsonProperty("training_remarks")>
    Public Property TrainingRemarks As String

    <JsonProperty("experience_remarks")>
    Public Property ExperienceRemarks As String

    <JsonProperty("eligibility_remarks")>
    Public Property EligibilityRemarks As String

    <JsonProperty("application_received")>
    Public Property ApplicationReceived As Boolean?

    <JsonProperty("for_pooling")>
    Public Property ForPooling As Boolean

    <JsonProperty("exam_mainkeyctr")>
    Public Property ExamMainKeyCtr As Long?

    <JsonProperty("remarks")>
    Public Property Remarks As String

    <JsonProperty("complete_req")>
    Public Property CompleteReq As Boolean

    <JsonProperty("for_backout")>
    Public Property ForBackout As Boolean

    <JsonProperty("employment_targetdate")>
    Public Property EmploymentTargetDate As Date?

    <JsonProperty("for_blacklisted")>
    Public Property ForBlacklisted As Boolean

    <JsonProperty("for_returnee")>
    Public Property ForReturnee As Boolean

    <JsonProperty("nq_remarks")>
    Public Property NqRemarks As String

    <JsonProperty("for_requirements")>
    Public Property ForRequirements As Boolean

    'Applicant Profile
    <JsonProperty("lname")>
    Public Property LName As String

    <JsonProperty("fname")>
    Public Property FName As String

    <JsonProperty("mname")>
    Public Property MName As String

    <JsonProperty("jobtitle")>
    Public Property JobTitle As String

    <JsonProperty("place_of_assignment")>
    Public Property PlaceAssignment As String

    <JsonProperty("job_responsibilities")>
    Public Property JobResponsibilities As String

    <JsonProperty("job_qualifications")>
    Public Property JobQualifications As String

    <JsonProperty("job_summary")>
    Public Property JobSummary As String

    <JsonProperty("pincode")>
    Public Property PinCode As String

    'Maintenance Job
    <JsonProperty("date_needed1")>
    Public Property DateNeeded1 As Date

    <JsonProperty("date_needed2")>
    Public Property DateNeeded2 As Date

    'Applicant Examination Main
    <JsonProperty("batch_exam")>
    Public Property BatchExam As String

End Class
