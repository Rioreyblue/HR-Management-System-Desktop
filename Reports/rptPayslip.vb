Imports Microsoft.Reporting.WinForms

Public Class rptPayslip
    Private Sub rptPayslip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                    classComboBox.setCboPaySlipCutOff(cboCutoff)
                    Call classEmployee.LoadDivision(getDivision.Copy(), lvDivision)

                    Call classTimer.CloseLoading(frmLoading)
                    Call classTimer.TimerReset()
            End Select
        End If
        classTimer.TimerCount += 1
    End Sub
    Private Sub Handler()
        Call classEmployee.TriggerItemCheckedReport(lvDivision, lvEmployee, paramJobStatus, "EC01")
    End Sub
    Private Sub lvDivision_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles lvDivision.ItemChecked
        If lvDivision.isCheckedAll = True Then
            classEmployee.TriggerItemCheckedReport(lvDivision, lvEmployee, paramJobStatus, "EC01")
        End If
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim idnos As New List(Of String)

        For Each item As ListViewItem In Me.lvEmployee.Items
            If item.Checked = True Then
                idnos.Add(Trim(item.SubItems(0).Text))
            End If
        Next

        If idnos.Count = 0 Then
            MsgBox("Please select at least one employee!", vbExclamation)
            lvEmployee.Focus()
            Exit Sub
        End If

        'this

        'Dim idnos As New List(Of String)
        'Dim dtTmp As New DataTable
        'Dim nrow_ As DataRow

        'For Each item As ListViewItem In Me.lvEmployee.Items
        '    If item.Checked = True Then
        '        idnos.Add(Trim(item.SubItems(0).Text))
        '    End If
        'Next

        'If idnos.Count = 0 Then
        '    MsgBox("Please select at least one employee!", vbExclamation)
        '    lvEmployee.Focus()
        '    Exit Sub
        'End If

        'dtTmp = New DataTable
        'With dtTmp.Columns
        '    .Add("idno", GetType(String))
        '    .Add("name_", GetType(String))

        '    .Add("inc_1", GetType(String))
        '    .Add("inc_2", GetType(String))
        '    .Add("inc_3", GetType(String))
        '    .Add("inc_4", GetType(String))
        '    .Add("inc_5", GetType(String))
        '    .Add("inc_6", GetType(String))
        '    .Add("inc_7", GetType(String))
        '    .Add("inc_8", GetType(String))
        '    .Add("inc_9", GetType(String))

        'End With

        'Dim drow_() As DataRow = getDataPayrollRegisterSummary(idnos.ToArray, Trim(cboCutoff.Text)).Select
        'If drow_.Length > 0 Then
        '    For Each row As DataRow In drow_
        '        nrow_ = dtTmp.NewRow()
        '        nrow_("idno") = row("idno")
        '        nrow_("name_") = row("name_")
        '        dtTmp.Rows.Add(nrow_)
        '    Next
        'End If

        'DataGridView1.DataSource = dtTmp

        'end

        Dim dtPayroll As DataTable = getDataPayrollRegisterSummary(idnos.ToArray, Trim(cboCutoff.Text))
        Dim dtEarnings As DataTable = getDataEarnings(idnos.ToArray, Trim(cboCutoff.Text))

        Dim reportParams As New List(Of ReportParameter)
        Dim reportForm As New drReportViewer()
        reportForm.ReportViewer1.Reset()

        reportParams.Add(New ReportParameter("paramCompany", ActiveCompanyName))
        reportParams.Add(New ReportParameter("paramAddress", ActiveCompanyAddress))
        reportParams.Add(New ReportParameter("paramContact", ActiveCompanyContact))
        reportParams.Add(New ReportParameter("paramTitle", "Payslip"))

        With reportForm.ReportViewer1
            .ProcessingMode = ProcessingMode.Local
            .LocalReport.ReportPath = Application.StartupPath & "\Designer\drPayslip.rdlc"
            .LocalReport.DataSources.Clear()
            .LocalReport.DataSources.Add(New ReportDataSource("dsEarnings", dtPayroll))
            .LocalReport.DataSources.Add(New ReportDataSource("dsEarnings", dtEarnings))
            .LocalReport.SetParameters(reportParams)
            .SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            .ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
            .ZoomPercent = 100
            .RefreshReport()
        End With
        reportForm.Show()
    End Sub
End Class