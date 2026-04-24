Imports Newtonsoft.Json

Public Class ExaminationMain
    <JsonProperty("jobcode")>
    Public Property JobCode As String

    <JsonProperty("description")>
    Public Property Description As String = ""

    <JsonProperty("exam_keyctr")>
    Public Property ExamKeyCtr As Long = 0

    <JsonProperty("short_def")>
    Public Property ShortDef As String = ""

    '<JsonProperty("description")>
    'Public Property Description As String = ""

    <JsonProperty("remark")>
    Public Property Remark As String = ""

    <JsonProperty("trail")>
    Public Property Trail As String = ""

    <JsonProperty("time_bound")>
    Public Property IsTimeBound As Boolean = False

    <JsonProperty("time_min")>
    Public Property TimeMinutes As Integer = 0

    <JsonProperty("random_")>
    Public Property IsRandomized As Boolean = False

    <JsonProperty("passing_rate")>
    Public Property PassingRate As Double = 0.0

    <JsonProperty("max_question")>
    Public Property MaxQuestion As Double = 0.0

    <JsonProperty("perfect_score")>
    Public Property PerfectScore As Double = 0.0

    <JsonProperty("instruction")>
    Public Property Instruction As String = ""

    <JsonProperty("item_timebound")>
    Public Property IsItemTimeBound As Boolean = False
    Public Property IsUpdate As String = "False"
    Public Function IsValid() As (Success As Boolean, Message As String)
        If String.IsNullOrWhiteSpace(Me.JobCode) OrElse Me.JobCode = "" Then
            Return (False, "Please select a Job.")
        End If
        If Me.TimeMinutes = 0 Then
            Return (False, "Please enter Time Minutes.")
        End If
        If Me.PassingRate = 0 Then
            Return (False, "Please enter Passing Rate.")
        End If
        If Me.PerfectScore = 0 Then
            Return (False, "Please enter Perfect Score.")
        End If
        If Me.MaxQuestion = 0 Then
            Return (False, "Please enter Max Question.")
        End If
        Return (True, "Success")
    End Function
End Class
