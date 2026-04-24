Imports Microsoft.Reporting.WinForms

Public Class rptEmployeeJobStatus
    Private Sub rptEmployeeJobStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        classTimer.OpenLoading(frmLoading)
        classTimer.EventType = 1
        Timer1.Enabled = True
        lvDivision.itemTrigger = AddressOf Handler
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If classTimer.TimerCount = 1 Then
            Select Case classTimer.EventType
                Case 0
                    Timer1.Enabled = False
                    frmLoading.Close()
                    classTimer.TimerCount = 0
                Case 1

                    Call classTimer.TimerStop(Timer1)

                    classComboBox.setCboCompany(cboCompany)
                    classComboBox.setCboStatus(cboStatus)
                    Call classEmployee.LoadDivision(getDivision.Copy(), lvDivision)

                    Call classTimer.CloseLoading(frmLoading)
                    Call classTimer.TimerReset()
            End Select
        End If
        classTimer.TimerCount += 1
    End Sub
    Private Sub Handler()
        Call classEmployee.TriggerItemCheckedReport(lvDivision, lvEmployee, paramJobStatus, "JS01")
    End Sub
    Private Sub lvDivision_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles lvDivision.ItemChecked
        If lvDivision.isCheckedAll = True Then
            classEmployee.TriggerItemCheckedReport(lvDivision, lvEmployee, paramJobStatus, "JS01")
        End If
    End Sub
    Private Sub cboStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatus.SelectedIndexChanged
        paramJobStatus = String.Empty
        If Trim(cboStatus.Text) = "ACTIVE" Then
            paramJobStatus = "ACTIVE"
        ElseIf Trim(cboStatus.Text) = "INACTIVE" Then
            paramJobStatus = "INACTIVE"
        Else
            paramJobStatus = "ALL"
        End If
        Call Handler()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        ' Collect selected employee IDs
        Dim idnos As New List(Of String)

        For Each item As ListViewItem In Me.lvEmployee.Items
            If item.Checked = True Then
                idnos.Add(Trim(item.SubItems(0).Text))
            End If
        Next

        ' Validate that at least one employee is selected
        If idnos.Count = 0 Then
            MsgBox("Please select at least one employee!", vbExclamation)
            lvEmployee.Focus()
            Exit Sub
        End If

        Dim dt As DataTable
        '' Get the data
        If chkJobStatusDate.Checked = True Then
            dt = getEmployeeJobStatusDateTo(idnos.ToArray, CDate(dpDateFrom.Text), CDate(dpDateTo.Text))
        Else
            dt = getEmployeeJobStatus(idnos.ToArray)
        End If

        If dt.Rows.Count = 0 Then
            MsgBox("No records found.")
            Return
        End If

        ' Check which output format is selected
        If RadioButton2.Checked = True Then
            ' Export to Excel
            GenerateJobStatusListingXLSX(dt, "JOB STATUS LISTING" & Format(Now, "yyyyMMdd_HHmmss"), ActiveCompanyName, dt.Rows.Count)
        Else
            ' Show Data Report
            Dim reportParams As New List(Of ReportParameter)
            Dim reportForm As New drReportViewer()
            reportForm.ReportViewer1.Reset()

            reportParams.Add(New ReportParameter("paramCompany", ActiveCompanyName))
            reportParams.Add(New ReportParameter("paramAddress", ActiveCompanyAddress))
            reportParams.Add(New ReportParameter("paramContact", ActiveCompanyContact))
            reportParams.Add(New ReportParameter("paramTitle", "Job Status Listing"))
            reportParams.Add(New ReportParameter("paramTotal1", dt.Rows.Count & "  record(s) found."))

            With reportForm.ReportViewer1
                .ProcessingMode = ProcessingMode.Local
                .LocalReport.ReportPath = Application.StartupPath & "\Designer\drJobStatusListing.rdlc"
                .LocalReport.DataSources.Clear()
                .LocalReport.DataSources.Add(New ReportDataSource("DataSet1", dt))
                .LocalReport.SetParameters(reportParams)
                .SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                .ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
                .ZoomPercent = 100
                .RefreshReport()
            End With
            reportForm.Show()
        End If
    End Sub
    Private Sub dp1_ValueChanged(sender As Object, e As EventArgs) Handles dp1.ValueChanged
        dpDateFrom.Text = dp1.Value.ToShortDateString()
    End Sub

    Private Sub dp2_ValueChanged(sender As Object, e As EventArgs) Handles dp2.ValueChanged
        dpDateTo.Text = dp2.Value.ToShortDateString()
    End Sub
    Private Sub chkJobStatusDate_CheckedChanged(sender As Object, e As EventArgs) Handles chkJobStatusDate.CheckedChanged
        If chkJobStatusDate.Checked = True Then
            dpDateFrom.Enabled = True
            dpDateTo.Enabled = True
            dp1.Enabled = True
            dp2.Enabled = True
        Else
            dpDateFrom.Enabled = False
            dpDateTo.Enabled = False
            dp1.Enabled = False
            dp2.Enabled = False
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class