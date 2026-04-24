Public Class MyFormula
    Public Function Eval(expr As String) As Decimal
        Dim dt As New DataTable()
        Dim result = dt.Compute(expr, Nothing)
        Return Convert.ToDecimal(result)
    End Function

End Class
