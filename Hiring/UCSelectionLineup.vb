Public Class UCSelectionLineup
    Private Sub lbJobTitle_Click(sender As Object, e As EventArgs) Handles lbJobTitle.Click
        With frmSelectionLineupApplicant
            .WindowState = FormWindowState.Maximized
            .TopLevel = False
            frmMain.pnlLoad.Controls.Add(frmSelectionLineupApplicant)
            .jobcode_ = lblJobCode.Text
            .lblName.Text = lbJobTitle.Text
            '.lblDesc.Text = lbJobSummary.Text
            .BringToFront()
            .Show()
            .Applied_Applicants()
        End With
    End Sub
End Class
