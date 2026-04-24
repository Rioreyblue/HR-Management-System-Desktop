Imports Newtonsoft.Json

Public Class EarningsConfiguration
    <JsonProperty("inccode")>
    Public Property IncCode As String = ""

    <JsonProperty("description")>
    Public Property Description As String = ""

    <JsonProperty("nontaxable")>
    Public Property NonTaxable As String = "False"

    <JsonProperty("trail")>
    Public Property Trail As String = ""

    <JsonProperty("formulated")>
    Public Property Formulated As String = "False"

    <JsonProperty("formula")>
    Public Property Formula As String = ""

    <JsonProperty("ceiling_amount")>
    Public Property CeilingAmount As String = "0.00"

    <JsonProperty("deductible")>
    Public Property Deductible As String = "False"

    <JsonProperty("include_in_alphalisting")>
    Public Property IncludeInAlphalisting As String = "False"

    <JsonProperty("payroll_type")>
    Public Property PayrollType As String = ""

    <JsonProperty("automatic_gross")>
    Public Property AutomaticGross As String = "False"

    <JsonProperty("incl_based_on")>
    Public Property InclBasedOn As String = ""

    <JsonProperty("automatic_contra_acct")>
    Public Property AutomaticContraAcct As String = ""

    <JsonProperty("lr_type")>
    Public Property LrType As String = ""

    <JsonProperty("ceiling_config")>
    Public Property CeilingConfig As String = ""

    Public Property IsUpdate As String = "False"

    Public Function IsValid() As (Success As Boolean, Message As String)
        If String.IsNullOrWhiteSpace(Me.IncCode) OrElse Me.IncCode = "" Then
            Return (False, "Please enter an Income Code.")
        End If

        If String.IsNullOrWhiteSpace(Me.Description) OrElse Me.Description = "" Then
            Return (False, "Please enter a Description.")
        End If

        ' Logic check: If formulated is True, then a formula should usually exist
        If Me.Formulated = "True" AndAlso String.IsNullOrWhiteSpace(Me.Formula) Then
            Return (False, "Please provide a formula for this earning.")
        End If

        Return (True, "Success")
    End Function
End Class