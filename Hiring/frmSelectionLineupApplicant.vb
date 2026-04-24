Public Class frmSelectionLineupApplicant
    Public Property jobcode_ As String
    Private Sub frmSelectionLineupApplicant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Public Sub Applied_Applicants()
        FlowLayoutPanel1.Controls.Clear()

        Dim appList As List(Of VacantPositionApplication) = GetVacantPositionApplicationforSelection()
        appList = appList.Where(Function(app) app.AppliedPosition = jobcode_).ToList()

        Dim actionList As List(Of JobAction) = GetJobActionMaintenance()
        Dim i As Integer = 0
        For Each app In appList
            Dim card As New UCAppliedPosition()

            card.Width = FlowLayoutPanel1.ClientSize.Width

            If i Mod 2 = 0 Then
                card.BackColor = Color.White
            Else
                card.BackColor = Color.FromArgb(245, 245, 245)
            End If

            card.ApplicantBatch = app.BatchExam
            card.lblName.Text = StrConv(app.LName & ", " & app.FName & " " & app.MName, vbProperCase)
            Dim appContact = GetApplicantContacts.FirstOrDefault(Function(j) j.IdNo = app.IdNo)
            If appContact IsNot Nothing Then
                card.lblAddress.Text = StrConv(appContact.BarangayName & ", " & appContact.CityName & ", " & appContact.ProvinceName, vbProperCase)
                card.lblEmail.Text = If(String.IsNullOrWhiteSpace(appContact?.EmailAddress), "< No Email Address >", appContact.EmailAddress.ToLower())
                card.ApplicantMobile = appContact.MobileNo
            End If
            card.ApplicantID = app.IdNo
            card.ApplicantJob = jobcode_
            card.ApplicantName = StrConv(app.LName & ", " & app.FName & " " & app.MName, vbProperCase)
            card.ApplicantPIN = app.PinCode
            FlowLayoutPanel1.Controls.Add(card)

            i += 1
        Next
    End Sub
End Class