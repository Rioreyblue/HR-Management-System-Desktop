Imports Newtonsoft.Json

Public Class JobAction
    <JsonProperty("action_code")>
    Public Property ActionCode As String

    <JsonProperty("job_action")>
    Public Property JobAction As String

    <JsonProperty("backcolor")>
    Public Property BackColorRGB As String
End Class
