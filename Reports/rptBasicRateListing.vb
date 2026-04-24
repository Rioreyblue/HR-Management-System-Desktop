Imports Microsoft.Reporting.WinForms

Public Class rptBasicRateListing
    Dim fData As New DataTable
    Private Sub rptBasicRateListing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        classTimer.OpenLoading(frmLoading)
        classTimer.EventType = 1
        Timer1.Enabled = True
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
                    classComboBox.setCboDivision(cboDivision)

                    Call classTimer.CloseLoading(frmLoading)
                    Call classTimer.TimerReset()
            End Select
        End If
        classTimer.TimerCount += 1
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

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

        If chkParamDateHire.Checked = True Then
            ' Get the data
            dt = getBasicRateListingWithDateHire(idnos.ToArray, CDate(dp1.Value), CDate(dp2.Value))
            'dt = get_basic_rate_lisiting_with_date_hire(idnos.ToArray, CDate(dpDateHireTo.Text), CDate(dpDateHireFrom.Text))
        Else
            ' Get the data
            dt = getBasicRateListing(idnos.ToArray)
        End If

        For Each row As DataRow In dt.Rows
            row("basic_rate") = FormatNumber(row("basic_rate").ToString())
            row("paymode") = ConvertPaymode(row("paymode").ToString())
        Next

        ' Check which output format is selected
        If RadioButton2.Checked = True Then
            ' Export to Excel
            GenerateBasicRateListingXLSX(dt, "Basic_Rate_Listing_" & Format(Now, "yyyyMMdd_HHmmss"), ActiveCompanyName, dt.Rows.Count)
        Else
            ' Show Data Report
            Dim reportParams As New List(Of ReportParameter)
            Dim reportForm As New drReportViewer()
            reportForm.ReportViewer1.Reset()

            reportParams.Add(New ReportParameter("paramCompany", ActiveCompanyName))
            reportParams.Add(New ReportParameter("paramAddress", ActiveCompanyAddress))
            reportParams.Add(New ReportParameter("paramContact", ActiveCompanyContact))
            reportParams.Add(New ReportParameter("paramTitle", "Basic Rate Listing"))
            reportParams.Add(New ReportParameter("paramDiv", "Division :"))
            reportParams.Add(New ReportParameter("paramCname", ActiveCompanyName))
            reportParams.Add(New ReportParameter("paramTotal1", dt.Rows.Count & "  record(s) found."))

            With reportForm.ReportViewer1
                .ProcessingMode = ProcessingMode.Local
                .LocalReport.ReportPath = Application.StartupPath & "\Designer\drBasicRateListing.rdlc"
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


    Private Sub cboDivision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDivision.SelectedIndexChanged
        paramDiv = String.Empty
        paramDiv = Trim(cboDivision.Text)
        If ActiveCompany <> "" And paramDiv <> "" Then
            Call classComboBox.setCboDepartment(cboDepartment, Trim(cboDivision.Text))
            Call classComboBox.setCboStatus(cboStatus)
            If paramDiv = "ALL" Then
                fData = getAllDivisionEmployee(ActiveCompany)
            Else
                fData = getDivisionEmployee()
            End If
            Call LoadEmployee(fData, lvEmployee)
        End If
    End Sub

    Private Sub cboDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDepartment.SelectedIndexChanged
        paramDept = String.Empty
        paramDept = Trim(cboDepartment.Text)
        If fData IsNot Nothing AndAlso fData.Rows.Count > 0 Then
            If paramDept <> "" AndAlso paramDept <> "ALL" Then
                Dim dv As New DataView(fData)
                dv.RowFilter = "deptcode = '" & paramDept & "'"
                Call LoadEmployee(dv.ToTable(), lvEmployee)
            Else
                Call LoadEmployee(fData, lvEmployee)
            End If
        Else
            lvEmployee.Items.Clear()
        End If
    End Sub
    Private Sub cboStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatus.SelectedIndexChanged
        If fData IsNot Nothing AndAlso fData.Rows.Count > 0 Then
            Dim dv As New DataView(fData)
            Dim filter As String = ""

            Select Case Trim(cboStatus.Text)
                Case "ACTIVE"
                    filter = "jobstatus = '01'"
                Case "INACTIVE"
                    filter = "jobstatus <> '01'"
                Case "ALL"
                    filter = ""
                Case Else
                    filter = ""
            End Select

            dv.RowFilter = filter
            Call LoadEmployee(dv.ToTable(), lvEmployee)
        Else
            lvEmployee.Items.Clear()
        End If
    End Sub

    Private Sub LoadEmployee(ByVal pDTable As DataTable, ByVal pListView As NxnControls.NxNListview)
        Dim _dr As DataRow
        With pListView
            .Items.Clear()
            For Each _dr In pDTable.Rows
                Dim lv_ As ListViewItem = New ListViewItem(_dr("idno").ToString)
                lv_.SubItems.Add(StrConv(_dr("lname").ToString & ", " & _dr("fname").ToString & " " & _dr("mname").ToString, vbProperCase))
                lv_.SubItems.Add(_dr("divcode").ToString.ToUpper)
                If pDTable.Columns.Contains("deptcode") Then
                    lv_.SubItems.Add(_dr("deptcode").ToString.ToUpper)
                End If
                .Items.Add(lv_)
            Next
        End With
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dp1_ValueChanged(sender As Object, e As EventArgs) Handles dp1.ValueChanged
        dpDateHireFrom.Text = dp1.Value.ToShortDateString()
    End Sub

    Private Sub dp2_ValueChanged(sender As Object, e As EventArgs) Handles dp2.ValueChanged
        dpDateHireTo.Text = dp2.Value.ToShortDateString()
    End Sub

    Private Sub chkParamDateHire_CheckedChanged(sender As Object, e As EventArgs) Handles chkParamDateHire.CheckedChanged
        If chkParamDateHire.Checked = True Then
            dp1.Enabled = True
            dp2.Enabled = True
        Else
            dp1.Enabled = False
            dp2.Enabled = False
        End If
    End Sub


End Class