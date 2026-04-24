Imports Newtonsoft.Json

Public Class ExaminationMultipleChoice
    <JsonProperty("jobcode")>
    Public Property JobCode As String

    <JsonProperty("mchoice_keyctr")>
    Public Property MChoiceKeyCtr As String = ""

    <JsonProperty("with_situation")>
    Public Property WithSituation As String = "False"

    <JsonProperty("sit_keyctr")>
    Public Property SitKeyCtr As String = ""

    <JsonProperty("is_quespic")>
    Public Property IsQuesPic As String = "False"

    <JsonProperty("question_")>
    Public Property Question As String = ""

    <JsonProperty("quespic")>
    Public Property QuesPic As String = ""

    <JsonProperty("ques_main")>
    Public Property QuesMain As String = ""

    <JsonProperty("is_choicepic")>
    Public Property IsChoicePic As String = "False"

    <JsonProperty("choice_1")>
    Public Property Choice1 As String = ""

    <JsonProperty("choice_2")>
    Public Property Choice2 As String = ""

    <JsonProperty("choice_3")>
    Public Property Choice3 As String = ""

    <JsonProperty("choice_4")>
    Public Property Choice4 As String = ""

    <JsonProperty("choice_5")>
    Public Property Choice5 As String = ""

    <JsonProperty("choice_6")>
    Public Property Choice6 As String = ""

    <JsonProperty("choice_7")>
    Public Property Choice7 As String = ""

    <JsonProperty("choice_8")>
    Public Property Choice8 As String = ""

    <JsonProperty("choice_9")>
    Public Property Choice9 As String = ""

    <JsonProperty("choice_10")>
    Public Property Choice10 As String = ""

    <JsonProperty("choicepic_1")>
    Public Property ChoicePic1 As String = ""

    <JsonProperty("choicepic_2")>
    Public Property ChoicePic2 As String = ""

    <JsonProperty("choicepic_3")>
    Public Property ChoicePic3 As String = ""

    <JsonProperty("choicepic_4")>
    Public Property ChoicePic4 As String = ""

    <JsonProperty("choicepic_5")>
    Public Property ChoicePic5 As String = ""

    <JsonProperty("choicepic_6")>
    Public Property ChoicePic6 As String = ""

    <JsonProperty("choicepic_7")>
    Public Property ChoicePic7 As String = ""

    <JsonProperty("choicepic_8")>
    Public Property ChoicePic8 As String = ""

    <JsonProperty("choicepic_9")>
    Public Property ChoicePic9 As String = ""

    <JsonProperty("choicepic_10")>
    Public Property ChoicePic10 As String = ""

    <JsonProperty("choicepic_main1")>
    Public Property ChoicePicMain1 As String = ""

    <JsonProperty("choicepic_main2")>
    Public Property ChoicePicMain2 As String = ""

    <JsonProperty("choicepic_main3")>
    Public Property ChoicePicMain3 As String = ""

    <JsonProperty("choicepic_main4")>
    Public Property ChoicePicMain4 As String = ""

    <JsonProperty("choicepic_main5")>
    Public Property ChoicePicMain5 As String = ""

    <JsonProperty("choicepic_main6")>
    Public Property ChoicePicMain6 As String = ""

    <JsonProperty("choicepic_main7")>
    Public Property ChoicePicMain7 As String = ""

    <JsonProperty("choicepic_main8")>
    Public Property ChoicePicMain8 As String = ""

    <JsonProperty("choicepic_main9")>
    Public Property ChoicePicMain9 As String = ""

    <JsonProperty("choicepic_main10")>
    Public Property ChoicePicMain10 As String = ""

    <JsonProperty("is_correct1")>
    Public Property IsCorrect1 As String = "False"

    <JsonProperty("is_correct2")>
    Public Property IsCorrect2 As String = "False"

    <JsonProperty("is_correct3")>
    Public Property IsCorrect3 As String = "False"

    <JsonProperty("is_correct4")>
    Public Property IsCorrect4 As String = "False"

    <JsonProperty("is_correct5")>
    Public Property IsCorrect5 As String = "False"

    <JsonProperty("is_correct6")>
    Public Property IsCorrect6 As String = "False"

    <JsonProperty("is_correct7")>
    Public Property IsCorrect7 As String = "False"

    <JsonProperty("is_correct8")>
    Public Property IsCorrect8 As String = "False"

    <JsonProperty("is_correct9")>
    Public Property IsCorrect9 As String = "False"

    <JsonProperty("is_correct10")>
    Public Property IsCorrect10 As String = "False"

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
