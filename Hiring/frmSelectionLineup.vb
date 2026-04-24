Public Class frmSelectionLineup
    Private Sub frmSelectionLineup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Vacant_Position_List()
    End Sub
    Public Sub Vacant_Position_List()
        FlowLayoutPanel1.Controls.Clear()

        Dim appList As List(Of VacantPositionApplication) = GetVacantPositionApplication()
        Dim i As Integer = 0
        For Each app In appList
            Dim card As New UCSelectionLineup()

            card.Width = FlowLayoutPanel1.ClientSize.Width

            If i Mod 2 = 0 Then
                card.BackColor = Color.White
            Else
                card.BackColor = Color.FromArgb(245, 245, 245)
            End If

            card.lblJobCode.Text = app.AppliedPosition
            card.lbJobTitle.Text = StrConv(app.JobTitle, vbProperCase)
            card.lbPlaceAssignment.Text = StrConv(app.PlaceAssignment, vbProperCase)
            card.lbJobDescription.Text = StrConv(app.JobResponsibilities, vbProperCase)
            'card.lbJobSummary.Text = StrConv(app.JobSummary, vbProperCase)
            'card.lbQualifications.Text = StrConv(app.JobQualifications, vbProperCase)
            card.lbPublishDate.Text = Format(app.DateNeeded1, "MMM dd") & " - " & Format(app.DateNeeded2, "MMM dd, yyyy")

            If app.Closed Then
                With card.btnStatus
                    .BackColor = Color.FromArgb(255, 118, 117)
                    .ForeColor = Color.White
                    .Text = "Closed"
                End With
            Else
                With card.btnStatus
                    .BackColor = Color.FromArgb(0, 184, 148)
                    .ForeColor = Color.White
                    .Text = "Open"
                End With
            End If
            FlowLayoutPanel1.Controls.Add(card)
            i += 1
        Next
    End Sub
End Class