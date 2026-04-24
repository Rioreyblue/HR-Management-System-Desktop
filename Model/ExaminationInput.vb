Imports Newtonsoft.Json

Public Class ExaminationInput
    <JsonProperty("jobcode")>
    Public Property JobCode As String

    <JsonProperty("inp_keyctr")>
    Public Property InpKeyCtr As String = ""

    <JsonProperty("with_situation")>
    Public Property WithSituation As String = "False"

    <JsonProperty("sit_keyctr")>
    Public Property SitKeyCtr As String = ""

    <JsonProperty("is_quespic")>
    Public Property IsQuesPic As String = "False"

    <JsonProperty("question_")>
    Public Property Question As String = ""

    '<JsonProperty("quespic")>
    'Public Property QuesPic As String = ""

    '<JsonProperty("ques_main")>
    'Public Property QuesMain As String = ""

    <JsonProperty("correct_answer")>
    Public Property CorrectAnswer As String = ""

    <JsonProperty("pts")>
    Public Property Pts As String = "0"

    <JsonProperty("image_filename")>
    Public Property ImageFilename As String = ""

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
