Imports Microsoft.Reporting.WinForms
Public Class rptCertificateListing
    Private Sub rptCertificateListing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                    Call classEmployee.LoadDivision(getDivision(), lvDivision)

                    Call classTimer.CloseLoading(frmLoading)
                    Call classTimer.TimerReset()
            End Select
        End If
        classTimer.TimerCount += 1
    End Sub
    Private Sub Handler()
        Call classEmployee.TriggerItemCheckedReport(lvDivision, lvEmployee, paramJobStatus, "CL01")
    End Sub
    Private Sub lvDivision_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles lvDivision.ItemChecked
        If lvDivision.isCheckedAll = True Then
            classEmployee.TriggerItemCheckedReport(lvDivision, lvEmployee, paramJobStatus, "CL01")
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
        If lvEmployee.CheckedItems.Count = 0 Then
            MsgBox("Please select Employee ID !", vbExclamation)
            lvEmployee.Focus()
            Exit Sub
        End If

        ' Get the data
        Dim dt As DataTable = getEmployeeCertificationsListing(idnos.ToArray)
        Dim total_cert As Integer = dt.Rows.Count

        ' Check which output format is selected
        If RadioButton2.Checked = True Then
            ' Export to Excel
            GenerateCertificateListingXLSX(dt, "Certificate_Listing_" & Format(Now, "yyyyMMdd_HHmmss"), ActiveCompanyName, total_cert)
        Else
            ' Show Data Report
            Dim reportParams As New List(Of ReportParameter)
            Dim reportForm As New drReportViewer()
            reportForm.ReportViewer1.Reset()

            reportParams.Add(New ReportParameter("paramCompany", ActiveCompanyName))
            reportParams.Add(New ReportParameter("paramAddress", ActiveCompanyAddress))
            reportParams.Add(New ReportParameter("paramContact", ActiveCompanyContact))
            reportParams.Add(New ReportParameter("paramTitle", "Certification Listing"))
            reportParams.Add(New ReportParameter("paramLabel", "Employment Status :"))
            reportParams.Add(New ReportParameter("paramStatus", GetColumnValue(cboStatus, 0)))
            reportParams.Add(New ReportParameter("paramTotal1", total_cert & "  record(s) found."))

            With reportForm.ReportViewer1
                .ProcessingMode = ProcessingMode.Local
                .LocalReport.ReportPath = Application.StartupPath & "\Designer\drCertificateListing.rdlc"
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


End Class