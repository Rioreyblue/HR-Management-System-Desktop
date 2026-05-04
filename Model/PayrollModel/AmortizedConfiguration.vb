Imports Newtonsoft.Json

Public Class AmortizedConfiguration
    <JsonProperty("loan_id")>
    Public Property LoanId As String = ""

    <JsonProperty("loan_desc")>
    Public Property LoanDesc As String = ""

    <JsonProperty("banking")>
    Public Property Banking As String = "False"

    <JsonProperty("glaccount_no")>
    Public Property GlAccountNo As String = ""

    <JsonProperty("lr_type")>
    Public Property LrType As String = ""

    <JsonProperty("trail")>
    Public Property Trail As String = ""

    Public Property IsUpdate As String = "False"

    Public Function IsValid() As (Success As Boolean, Message As String)
        If String.IsNullOrWhiteSpace(Me.LoanId) OrElse Me.LoanId = "" Then
            Return (False, "Please enter a Loan ID.")
        End If

        If String.IsNullOrWhiteSpace(Me.LoanDesc) OrElse Me.LoanDesc = "" Then
            Return (False, "Please enter a Amortized Description.")
        End If

        ' Optional: Add validation for GL Account if it is mandatory in your UI
        ' If String.IsNullOrWhiteSpace(Me.GlAccountNo) OrElse Me.GlAccountNo = "" Then
        '     Return (False, "Please enter a GL Account Number.")
        ' End If

        Return (True, "Success")
    End Function
End Class
