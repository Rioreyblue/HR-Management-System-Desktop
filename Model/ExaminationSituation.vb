Imports Newtonsoft.Json

Public Class ExaminationSituation
    <JsonProperty("sit_keyctr")>
    Public Property SitKeyCtr As String = ""

    <JsonProperty("situation")>
    Public Property Situation As String = ""

    <JsonProperty("is_pic")>
    Public Property IsPic As String = ""

    '<JsonProperty("situation")>
    'Public Property Situation As String = ""

    <JsonProperty("pic_")>
    Public Property Pic As String = ""

    <JsonProperty("main_")>
    Public Property Main As String = ""

    <JsonProperty("user")>
    Public Property User As String = ""

    <JsonProperty("trail")>
    Public Property Trail As String = ""
    Public Property IsUpdate As String = "False"
End Class
