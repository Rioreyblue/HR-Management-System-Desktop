Public Class UCApplicantList
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblfullname.Click
        With frmApplicantProfile
            .idno_ = lblidno.Text
            .WindowState = FormWindowState.Maximized
            .TopLevel = False
            frmMain.pnlLoad.Controls.Add(frmApplicantProfile)
            .BringToFront()
            .Show()
            .GetViewApplicantProfile()
            .GetViewApplicantSkills()
        End With
    End Sub
End Class