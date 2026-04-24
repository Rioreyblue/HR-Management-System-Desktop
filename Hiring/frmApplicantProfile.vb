Public Class frmApplicantProfile

    Public Property idno_ As String = String.Empty
    Private Sub frmApplicantProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub GetViewApplicantProfile()
        Dim app = GetApplicantProfile.FirstOrDefault(Function(j) j.IdNo = idno_)
        If app IsNot Nothing Then
            app.PopulateForm(Me)
        Else
            MessageBox.Show("Application details not found for: " & idno_, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Public Sub GetViewApplicantSkills()
        FlowLayoutPanel1.Controls.Clear()

        Dim appSkills As List(Of ApplicantSkills) = GetApplicantSkills(idno_)
        Dim i As Integer = 0
        For Each skill In appSkills
            Dim card As New UCSkills()
            card.lblSkillsRating.Text = skill.Remarks
            card.lblSkills.Text = StrConv(skill.Skills, vbProperCase)
            FlowLayoutPanel1.Controls.Add(card)
            i += 1
        Next

    End Sub
End Class