Imports Newtonsoft.Json

Public Class ApplicantExamination
    <JsonProperty("jobcode")>
    Public Property JobCode As String

    <JsonProperty("main_keyctr")>
    Public Property MainKeyCtr As Long = 0

    <JsonProperty("idno")>
    Public Property IdNo As String = ""

    '<JsonProperty("exam_keyctr")>
    'Public Property ExamKeyCtr As Long = 0

    <JsonProperty("date_open_from")>
    Public Property DateOpenFrom As String = ""

    <JsonProperty("date_open_to")>
    Public Property DateOpenTo As String = ""

    <JsonProperty("open_")>
    Public Property IsOpen As String = "True"

    <JsonProperty("answered")>
    Public Property IsAnswered As String = "False"

    <JsonProperty("date_answered")>
    Public Property DateAnswered As String = ""

    <JsonProperty("remark")>
    Public Property Remark As String = ""

    <JsonProperty("trail")>
    Public Property Trail As String = ""

    <JsonProperty("score")>
    Public Property Score As Double = 0.0

    <JsonProperty("assessment")>
    Public Property Assessment As String = ""

    <JsonProperty("rate_")>
    Public Property Rate As Double = 0.0

    <JsonProperty("has_result")>
    Public Property HasResult As String = "False"

    <JsonProperty("pcode")>
    Public Property PCode As String = ""

    <JsonProperty("no_show")>
    Public Property NoShow As String = "False"

    <JsonProperty("resched_reason")>
    Public Property ReschedReason As String = ""

    <JsonProperty("batch_exam")>
    Public Property BatchExam As Integer = 0
    Public Property IsUpdate As String = "False"

    'Applicant Profile
    <JsonProperty("lname")>
    Public Property LName As String

    <JsonProperty("fname")>
    Public Property FName As String

    <JsonProperty("mname")>
    Public Property MName As String
    Public Function IsValid() As (Success As Boolean, Message As String)
        If String.IsNullOrWhiteSpace(Me.JobCode) OrElse Me.JobCode = "" Then
            Return (False, "Please select a Job.")
        End If
        If Me.BatchExam = 0 Then
            Return (False, "Please select a Batch No.")
        End If
        If Me.Score = 0 Then
            Return (False, "Please enter a Score")
            Me.Score = ""
        End If
        If Me.Rate = 0 Then
            Return (False, "Please enter a Rate")
            Me.Rate = ""
        End If
        Return (True, "Success")
    End Function
    Public Function IsValidResched() As (Success As Boolean, Message As String)
        If String.IsNullOrWhiteSpace(Me.JobCode) OrElse Me.JobCode = "" Then
            Return (False, "Please select an Exam.")
        End If
        If Me.BatchExam = 0 Then
            Return (False, "Please select a Batch No.")
        End If
        Return (True, "Success")
    End Function
End Class
