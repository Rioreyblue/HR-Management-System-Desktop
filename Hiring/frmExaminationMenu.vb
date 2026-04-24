Public Class frmExaminationMenu
    Private Sub btnApplicantExamination_Click(sender As Object, e As EventArgs) Handles btnApplicantExamination.Click
        With frmApplicantExamination
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub
End Class