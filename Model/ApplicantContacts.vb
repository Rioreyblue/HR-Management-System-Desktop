Imports Newtonsoft.Json

Public Class ApplicantContacts
    <JsonProperty("idno")>
    Public Property IdNo As String

    <JsonProperty("brgyname")>
    Public Property BarangayName As String

    <JsonProperty("cityname")>
    Public Property CityName As String

    <JsonProperty("provname")>
    Public Property ProvinceName As String

    <JsonProperty("mobile")>
    Public Property MobileNo As String

    <JsonProperty("email_address")>
    Public Property EmailAddress As String
End Class
