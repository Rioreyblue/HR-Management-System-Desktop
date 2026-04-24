Public Class frmApplicantListing
    Private Sub frmApplicantListing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Applicant_List()
    End Sub
    Public Sub Applicant_List()
        FlowLayoutPanel1.Controls.Clear()

        Dim appList As List(Of ApplicantProfile) = GetApplicantProfile()
        Dim i As Integer = 0
        For Each app In appList
            Dim card As New UCApplicantList()

            card.Width = FlowLayoutPanel1.ClientSize.Width

            If i Mod 2 = 0 Then
                card.BackColor = Color.White
            Else
                card.BackColor = Color.FromArgb(245, 245, 245)
            End If

            card.lblidno.Text = app.IdNo
            card.lblfullname.Text = StrConv(app.LName & ", " & app.FName & " " & app.MName, vbProperCase)

            Dim appContact = GetApplicantContacts.FirstOrDefault(Function(j) j.IdNo = app.IdNo)
            If appContact IsNot Nothing Then
                card.lblPlaceofBirth.Text = StrConv(appContact.BarangayName & ", " & appContact.CityName & ", " & appContact.ProvinceName, vbProperCase)
                card.lblMobile.Text = If(String.IsNullOrWhiteSpace(appContact?.MobileNo), "< No Contact Info >", appContact.MobileNo)
                card.lblEmail.Text = If(String.IsNullOrWhiteSpace(appContact?.EmailAddress), "< No Email Address >", appContact.EmailAddress.ToLower())
            Else
                card.lblPlaceofBirth.Text = "< No Information Available >"
                card.lblMobile.Text = "< No Contact Info >"
                card.lblEmail.Text = "< No Email Address >"
            End If

            FlowLayoutPanel1.Controls.Add(card)
            i += 1
        Next
    End Sub
End Class