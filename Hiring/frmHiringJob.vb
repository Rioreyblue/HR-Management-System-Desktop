Public Class frmHiringJob
    Private Sub frmHiringJob_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call HiringJob_List()
    End Sub

    Public Sub HiringJob_List()
        FlowLayoutPanel1.Controls.Clear()

        Dim jobList As List(Of MaintenanceJob) = GetMaintenanceJobs()
        Dim i As Integer = 0
        For Each job In jobList
            Dim card As New UserControl1()

            card.Width = FlowLayoutPanel1.ClientSize.Width

            If i Mod 2 = 0 Then
                card.BackColor = Color.White
            Else
                card.BackColor = Color.FromArgb(245, 245, 245)
            End If

            card.lblJobCode.Text = job.JobCode
            card.Label1.Text = Format(job.DateNeeded1, "MMM dd") & " - " & Format(job.DateNeeded2, "MMM dd, yyyy")
            card.Label2.Text = StrConv(job.JobSummary, vbProperCase)
            card.Label3.Text = StrConv(job.JobTitle, vbProperCase)
            card.Label4.Text = StrConv(job.PlaceOfAssignment, vbProperCase)
            card.Label5.Text = StrConv(job.HiresNeeded, vbProperCase)

            FlowLayoutPanel1.Controls.Add(card)
            i += 1
        Next
    End Sub

    Private Sub btnCreateJob_Click(sender As Object, e As EventArgs) Handles btnCreateJob.Click
        With frmCreateJob
            .jobctr_ = ""
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub
End Class