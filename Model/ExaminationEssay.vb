Imports Newtonsoft.Json

Public Class ExaminationEssay
    <JsonProperty("jobcode")>
    Public Property JobCode As String

    <JsonProperty("description")>
    Public Property Description As String

    <JsonProperty("essay_keyctr")>
    Public Property EssayKeyCtr As String = ""

    <JsonProperty("with_situation")>
    Public Property WithSituation As String = ""

    <JsonProperty("sit_keyctr")>
    Public Property SitKeyCtr As String = ""

    <JsonProperty("is_quespic")>
    Public Property IsQuesPic As String = ""

    <JsonProperty("question_")>
    Public Property Question As String = ""

    <JsonProperty("image_filename")>
    Public Property ImageFilename As String = ""

    <JsonProperty("pts")>
    Public Property Pts As String = ""

    <JsonProperty("trail")>
    Public Property Trail As String = ""
    Public Property IsUpdate As String = "False"
    Public Function IsValid() As (Success As Boolean, Message As String)
        If String.IsNullOrWhiteSpace(Me.JobCode) OrElse Me.JobCode = "" Then
            Return (False, "Please select a Job.")
        End If
        If String.IsNullOrWhiteSpace(Me.Question) OrElse Me.Question = "" Then
            Return (False, "Please enter a Question.")
        End If
        If String.IsNullOrWhiteSpace(Me.Pts) OrElse Me.Pts = "" Then
            Return (False, "Please enter a Points.")
        End If
        Return (True, "Success")
    End Function
End Class
