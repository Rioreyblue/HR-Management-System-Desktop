Public Class rptLikeExcel
    Private Sub rptLikeExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        GenerateCSVFromDataGridView(DataGridView1, "Payroll Register")
    End Sub
End Class