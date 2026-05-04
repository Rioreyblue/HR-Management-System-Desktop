Imports Newtonsoft.Json

Public Class DeductionConfiguration
    <JsonProperty("ddctcode")>
    Public Property DdctCode As String = ""

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

    <JsonProperty("banking")>
    Public Property Banking As String = "False"

    <JsonProperty("glaccount_no")>
    Public Property GlAccountNo As String = ""

    <JsonProperty("ref_ded_code")>
    Public Property RefDedCode As String = ""

    <JsonProperty("divcode")>
    Public Property DivCode As String = ""

    <JsonProperty("avail_all")>
    Public Property AvailAll As String = "False"


    <JsonProperty("plotted")>
    Public Property Plotted As String = "False"

    <JsonProperty("lr_type")>
    Public Property LrType As String = ""

    <JsonProperty("deduct_to_grossall")>
    Public Property DeductToGrossAll As String = "False"

    <JsonProperty("oid")>
    Public Property Oid As String = ""

    Public Property IsUpdate As String = "False"

    Public Function IsValid() As (Success As Boolean, Message As String)
        If String.IsNullOrWhiteSpace(Me.DdctCode) OrElse Me.DdctCode = "" Then
            Return (False, "Please enter a DdctCode.")
        End If

        If String.IsNullOrWhiteSpace(Me.Description) OrElse Me.Description = "" Then
            Return (False, "Please enter a Deduction Description.")
        End If

        ' Optional: Add validation for GL Account if it is mandatory in your UI
        'If String.IsNullOrWhiteSpace(Me.GlAccountNo) OrElse Me.GlAccountNo = "" Then
        '    Return (False, "Please enter a GL Account Number.")
        'End If

        Return (True, "Success")
    End Function

End Class
