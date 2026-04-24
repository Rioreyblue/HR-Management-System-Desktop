Imports Microsoft.Reporting.WinForms
Imports NXNParsing

Public Class rptNewHiredEmployee
    Private jStr_Input As String = "[]"
    Private ws As New WSConnection
    Private Token As String = String.Empty
    Private ActiveFrm As String = "rptNewHiredEmployee.php"
    Private Sub rptNewHiredEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                    Call classEmployee.LoadDivision(getDivision.Copy(), lvDivision)

                    Call classTimer.CloseLoading(frmLoading)
                    Call classTimer.TimerReset()
            End Select
        End If
        classTimer.TimerCount += 1
    End Sub
    Private Sub Handler()
        Call classEmployee.TriggerItemChecked_(lvDivision, lvEmployee, paramJobStatus)
    End Sub
    Private Sub lvDivision_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles lvDivision.ItemChecked
        If lvDivision.isCheckedAll = True Then
            classEmployee.TriggerItemChecked_(lvDivision, lvEmployee, paramJobStatus)
        End If
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        ' Load report
        Dim reportParams As New List(Of ReportParameter)
        Dim reportForm As New drReportViewer()
        reportForm.ReportViewer1.Reset()

        Dim idnos As New List(Of String)

        For Each item As ListViewItem In Me.lvEmployee.Items
            If item.Checked = True Then
                idnos.Add(Trim(item.SubItems(0).Text))
            End If
        Next

        reportParams.Add(New ReportParameter("paramCompany", ActiveCompanyName))
        reportParams.Add(New ReportParameter("paramAddress", ActiveCompanyAddress))
        reportParams.Add(New ReportParameter("paramContact", ActiveCompanyContact))
        reportParams.Add(New ReportParameter("paramTitle", "NEW EMPLOYEE LISTING"))

        With reportForm.ReportViewer1
            .ProcessingMode = ProcessingMode.Local
            .LocalReport.ReportPath = Application.StartupPath & "\Designer\drNewHiredEmployee.rdlc"
            .LocalReport.DataSources.Clear()
            .LocalReport.DataSources.Add(New ReportDataSource("DataSet1", get_newly_hired_employee(idnos.ToArray, CDate(dpDateTo.Text))))
            .LocalReport.SetParameters(reportParams)
            .SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            .ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
            .ZoomPercent = 100
            .RefreshReport()
        End With
        reportForm.Show()
    End Sub
End Class