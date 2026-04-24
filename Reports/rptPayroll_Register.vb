Imports NXNParsing

Public Class rptPayroll_Register
    Private jStr_Input As String = "[]"
    Private ws As New WSConnection
    Private Token As String = String.Empty
    Private ActiveFrm As String = "rptPayroll_Register.php"

    Dim process_year As String = ""

    Private Sub rptPayroll_Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                    classEmployee.LoadDivision(getDivision.Copy(), lvDivision)
                    classComboBox.setCboYear(cboYear)
                    classComboBox.setCboEmployeeStatus(cboJobStatus)
                    cboJobStatus.Text = "ACTIVE"

                    Call classTimer.CloseLoading(frmLoading)
                    Call classTimer.TimerReset()
            End Select
        End If
        classTimer.TimerCount += 1
    End Sub
    Private Sub Handler()
        classEmployee.TriggerItemChecked_(lvDivision, lvEmployee, Trim(cboJobStatus.Text))
    End Sub
    Private Sub lvDivision_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles lvDivision.ItemChecked
        If lvDivision.isCheckedAll = True Then
            classEmployee.TriggerItemChecked_(lvDivision, lvEmployee, Trim(cboJobStatus.Text))
        End If
    End Sub
    Private Sub set_grid()

        With rptLikeExcel.DataGridView1
            .Columns.Clear()
            .Rows.Clear()
            .ClearSelection()

            .Columns.Add("idno", "ID")
            .Columns.Add("name", "Employee Name")
            .Columns("name").Width = 300
            .Columns.Add("basic_rate", "Latest Monthly Rate")

            If chkShowPaymode.Checked = True Then
                .Columns.Add("paymode", "Paymode")
            End If

            If chkShowCutoff.Checked = True Then
                .Columns.Add("cutoff", "Cutoff")
            End If

            If chkShowDivision.Checked = True Then
                .Columns.Add("divcode", "Division")
            End If

            If chkShowDepartment.Checked = True Then
                .Columns.Add("deptcode", "Department")
            End If

            If chkShowCostCenter.Checked = True Then
                .Columns.Add("costcode", "Cost Center")
            End If

            If chkShowJobStatus.Checked = True Then
                .Columns.Add("jstatusname", "Job Status")
            End If
            .Columns.Add("jtypename", "Job Type")
            .Columns.Add("days_work", "Days Work")

            'Hours
            If chkShowHours.Checked = True Then
                .Columns.Add("reghrs", "reghrs(Hrs)")
                .Columns.Add("reghrsot", "reghrsot(Hrs)")
                .Columns.Add("regnp", "regnp(Hrs)")
                .Columns.Add("regnpot", "regnpot(Hrs)")
                .Columns.Add("rsthrs", "rsthrs(Hrs)")
                .Columns.Add("rstot", "rstot(Hrs)")
                .Columns.Add("rstnp", "rstnp(Hrs)")
                .Columns.Add("rstnpot", "rstnpot(Hrs)")
                .Columns.Add("splhrs", "splhrs(Hrs)")
                .Columns.Add("splhrsot", "splhrsot(Hrs)")
                .Columns.Add("splnp", "splnp(Hrs)")
                .Columns.Add("splnpot", "splnpot(Hrs)")
                .Columns.Add("cmphrs", "cmphrs(Hrs)")
                .Columns.Add("cmphrsot", "cmphrsot(Hrs)")
                .Columns.Add("cmpnp", "cmpnp(Hrs)")
                .Columns.Add("cmpnpot", "cmpnpot(Hrs)")
                .Columns.Add("lghrs", "lghrs(Hrs)")
                .Columns.Add("lghrsot", "lghrsot(Hrs)")
                .Columns.Add("lgnp", "lgnp(Hrs)")
                .Columns.Add("lgnpot", "lgnpot(Hrs)")
                .Columns.Add("rstsplhrs", "rstsplhrs(Hrs)")
                .Columns.Add("rstsplhrsot", "rstsplhrsot(Hrs)")
                .Columns.Add("rstsplnp", "rstsplnp(Hrs)")
                .Columns.Add("rstsplnpot", "rstsplnpot(Hrs)")
                .Columns.Add("rstlghrs", "rstlghrs(Hrs)")
                .Columns.Add("rstlghrsot", "rstlghrsot(Hrs)")
                .Columns.Add("rstlgnp", "rstlgnp(Hrs)")
                .Columns.Add("rstlgnpot", "rstlgnpot(Hrs)")
                .Columns.Add("rstcmphrs", "rstcmphrs(Hrs)")
                .Columns.Add("rstcmphrsot", "rstcmphrsot(Hrs)")
                .Columns.Add("rstcmpnp", "rstcmpnp(Hrs)")
                .Columns.Add("rstcmpnpot", "rstcmpnpot(Hrs)")
            End If

            'Amount
            .Columns.Add("reghrs_amt", "reghrs(Amount)")
            .Columns.Add("reghrsot_amt", "reghrsot(Amount)")
            .Columns.Add("regnp_amt", "regnp(Amount)")
            .Columns.Add("regnpot_amt", "regnpot(Amount)")
            .Columns.Add("rsthrs_amt", "rsthrs(Amount)")
            .Columns.Add("rstot_amt", "rstot(Amount)")
            .Columns.Add("rstnp_amt", "rstnp(Amount)")
            .Columns.Add("rstnpot_amt", "rstnpot(Amount)")
            .Columns.Add("splhrs_amt", "splhrs(Amount)")
            .Columns.Add("splhrsot_amt", "splhrsot(Amount)")
            .Columns.Add("splnp_amt", "splnp(Amount)")
            .Columns.Add("splnpot_amt", "splnpot(Amount)")
            .Columns.Add("cmphrs_amt", "cmphrs(Amount)")
            .Columns.Add("cmphrsot_amt", "cmphrsot(Amount)")
            .Columns.Add("cmpnp_amt", "cmpnp(Amount)")
            .Columns.Add("cmpnpot_amt", "cmpnpot(Amount)")
            .Columns.Add("lghrs_amt", "lghrs(Amount)")
            .Columns.Add("lghrsot_amt", "lghrsot(Amount)")
            .Columns.Add("lgnp_amt", "lgnp(Amount)")
            .Columns.Add("lgnpot_amt", "lgnpot(Amount)")
            .Columns.Add("rstsplhrs_amt", "rstsplhrs(Amount)")
            .Columns.Add("rstsplhrsot_amt", "rstsplhrsot(Amount)")
            .Columns.Add("rstsplnp_amt", "rstsplnp(Amount)")
            .Columns.Add("rstsplnpot_amt", "rstsplnpot(Amount)")
            .Columns.Add("rstlghrs_amt", "rstlghrs(Amount)")
            .Columns.Add("rstlghrsot_amt", "rstlghrsot(Amount)")
            .Columns.Add("rstlgnp_amt", "rstlgnp(Amount)")
            .Columns.Add("rstlgnpot_amt", "rstlgnpot(Amount)")
            .Columns.Add("rstcmphrs_amt", "rstcmphrs(Amount)")
            .Columns.Add("rstcmphrsot_amt", "rstcmphrsot(Amount)")
            .Columns.Add("rstcmpnp_amt", "rstcmpnp(Amount)")
            .Columns.Add("rstcmpnpot_amt", "rstcmpnpot(Amount)")
            .Columns.Add("acchrs", "acchrs")
            .Columns.Add("late", "late")
            .Columns.Add("undertime", "undertime")
            .Columns.Add("absent_hrs", "absent_hrs")
            .Columns.Add("legal_pay", "legal_pay")
            .Columns.Add("leavewpay", "leavewpay")
            .Columns.Add("formulated_shift", "formulated_shift")

            '
            If chkDetailedLeave.Checked = True Then
                .Columns.Add("sl_wpay", "sl_wpay")
                .Columns.Add("vl_wpay", "vl_wpay")
                .Columns.Add("el_wpay", "el_wpay")
                .Columns.Add("pl_wpay", "pl_wpay")
                .Columns.Add("ml_wpay", "ml_wpay")
                .Columns.Add("ul_wpay", "ul_wpay")
                .Columns.Add("ol_wpay", "ol_wpay")
                .Columns.Add("xl_wpay", "xl_wpay")
                .Columns.Add("al_wpay", "al_wpay")
            End If

            '
            .Columns.Add("adv_calculated_ot", "adv_calculated_ot")

            'Adjusted Payroll
            .Columns.Add("ADJ_reghrs", "ADJ_reghrs")
            .Columns.Add("ADJ_reghrsot", "ADJ_reghrsot")
            .Columns.Add("ADJ_regnp", "ADJ_regnp")
            .Columns.Add("ADJ_regnpot", "ADJ_regnpot")
            .Columns.Add("ADJ_rsthrs", "ADJ_rsthrs")
            .Columns.Add("ADJ_rstot", "ADJ_rstot")
            .Columns.Add("ADJ_rstnp", "ADJ_rstnp")
            .Columns.Add("ADJ_rstnpot", "ADJ_rstnpot")
            .Columns.Add("ADJ_splhrs", "ADJ_splhrs")
            .Columns.Add("ADJ_splhrsot", "ADJ_splhrsot")
            .Columns.Add("ADJ_splnp", "ADJ_splnp")
            .Columns.Add("ADJ_splnpot", "ADJ_splnpot")
            .Columns.Add("ADJ_cmphrs", "ADJ_cmphrs")
            .Columns.Add("ADJ_cmphrsot", "ADJ_cmphrsot")
            .Columns.Add("ADJ_cmpnp", "ADJ_cmpnp")
            .Columns.Add("ADJ_cmpnpot", "ADJ_cmpnpot")
            .Columns.Add("ADJ_lghrs", "ADJ_lghrs")
            .Columns.Add("ADJ_lghrsot", "ADJ_lghrsot")
            .Columns.Add("ADJ_lgnp", "ADJ_lgnp")
            .Columns.Add("ADJ_lgnpot", "ADJ_lgnpot")
            .Columns.Add("ADJ_rstsplhrs", "ADJ_rstsplhrs")
            .Columns.Add("ADJ_rstsplhrsot", "ADJ_rstsplhrsot")
            .Columns.Add("ADJ_rstsplnp", "ADJ_rstsplnp")
            .Columns.Add("ADJ_rstsplnpot", "ADJ_rstsplnpot")
            .Columns.Add("ADJ_rstlghrs", "ADJ_rstlghrs")
            .Columns.Add("ADJ_rstlghrsot", "ADJ_rstlghrsot")
            .Columns.Add("ADJ_rstlgnp", "ADJ_rstlgnp")
            .Columns.Add("ADJ_rstlgnpot", "ADJ_rstlgnpot")
            .Columns.Add("ADJ_rstcmphrs", "ADJ_rstcmphrs")
            .Columns.Add("ADJ_rstcmphrsot", "ADJ_rstcmphrsot")
            .Columns.Add("ADJ_rstcmpnp", "ADJ_rstcmpnp")
            .Columns.Add("ADJ_rstcmpnpot", "ADJ_rstcmpnpot")

            'Earnings
            Dim dtEarnCode() As DataRow = getEarnings_Code().Select
            If dtEarnCode.Length > 0 Then
                For Each rrow In dtEarnCode
                    .Columns.Add(rrow("inccode"), rrow("inccode"))
                Next
            End If

            'GrossPay
            .Columns.Add("actual_basic", "Actual Basic")

            If chkShowTaxableGross.Checked = True Then
                .Columns.Add("gross_taxable", "Gross Taxable")
            End If

            .Columns.Add("gross_all", "Gross All")

            'Deductions
            Dim dtDeductCode() As DataRow = getCutoffDeductions_Code(Trim(cboCutoff.Text)).Select
            If dtDeductCode.Length > 0 Then
                For Each rrow In dtDeductCode
                    .Columns.Add(rrow("ddctcode"), rrow("ddctcode"))
                Next
            End If

            'SSS Premiumns
            .Columns.Add("sss_yee", "sss_yee")
            If chkEmployerShare.Checked = True Then
                .Columns.Add("sss_yer", "sss_yer")
                .Columns.Add("sss_ec", "sss_ec")
            End If

            .Columns.Add("sss_loan_salary", "sss_loan_salary")
            .Columns.Add("sss_loan_calamity", "sss_loan_calamity")
            .Columns.Add("sss_loan_emergency", "sss_loan_emergency")

            'Phealth Premiums
            .Columns.Add("phealth_yee", "phealth_yee")
            If chkEmployerShare.Checked = True Then
                .Columns.Add("phealth_yer", "phealth_yer")
            End If

            'BIR
            .Columns.Add("BIR", "BIR")

            'HDMF Premiums
            .Columns.Add("hdmf_yee", "hdmf_yee")

            If chkEmployerShare.Checked = True Then
                .Columns.Add("hdmf_yer", "hdmf_yer")
            End If

            .Columns.Add("hdmf_loan_salary", "hdmf_loan_salary")
            .Columns.Add("hdmf_loan_housing", "hdmf_loan_housing")
            .Columns.Add("hdmf_loan_calamity", "hdmf_loan_calamity")

            'Medicare
            .Columns.Add("medicare_yee", "medicare_yee")
            .Columns.Add("medicare_yer", "medicare_yer")

            'GSIS
            .Columns.Add("gsis_yee", "gsis_yee")
            If chkEmployerShare.Checked = True Then
                .Columns.Add("gsis_yer", "gsis_yer")
            End If

            .Columns.Add("gsis_ecc", "gsis_ecc")
            .Columns.Add("gsis_ehp", "gsis_ehp")
            .Columns.Add("gsis_loan_salary", "gsis_loan_salary")
            .Columns.Add("gsis_loan_housing", "gsis_loan_housing")
            .Columns.Add("gsis_loan_emergency", "gsis_loan_emergency")
            .Columns.Add("gsis_loan_policy", "gsis_loan_policy")

            'Company Loans
            .Columns.Add("coop_loan_1", "Coop Loan 1")
            .Columns.Add("coop_loan_2", "Coop Loan 2")
            .Columns.Add("coop_loan_3", "Coop Loan 3")
            .Columns.Add("coop_loan_4", "Coop Loan 4")
            .Columns.Add("coop_loan_5", "Coop Loan 5")
            .Columns.Add("coop_loan_6", "Coop Loan 6")

            'Multi Loan
            Dim dtMultiLoan() As DataRow = getMultiLoan_Code_wCutoff(Trim(cboCutoff.Text)).Select
            If dtMultiLoan.Length > 0 Then
                For Each rrow In dtMultiLoan
                    .Columns.Add(rrow("loan_desc"), rrow("loan_desc"))
                Next
            End If

            .Columns.Add("13th_Month", "13th_Month")
            .Columns.Add("shared_benefits_yee", "shared_benefits_yee")
            If chkEmployerShare.Checked = True Then
                .Columns.Add("shared_benefits_yer", "shared_benefits_yer")
            End If

            'Net Pay
            .Columns.Add("Net_Pay", "Net_Pay")
            .Columns.Add("Coin_Savings", "Coin_Savings")

        End With
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim lightBlue As Color = Color.FromArgb(204, 229, 255) ' light pastel blue
        Dim lightgreen As Color = Color.FromArgb(204, 255, 204) ' light pastel green
        Dim lightRed As Color = Color.FromArgb(255, 204, 204) ' light pastel red
        Dim lightorange As Color = Color.FromArgb(255, 223, 186) 'light orange

        paramID = ""

        For Each item As ListViewItem In Me.lvEmployee.Items
            If item.Checked = True Then
                Dim keyName As String = "'" & Trim(item.SubItems(0).Text) & "'" ' add single quotes
                If paramID = String.Empty Then
                    paramID = keyName
                Else
                    paramID &= "," & keyName
                End If
            End If
        Next

        If Trim(cboCutoff.Text) = "" Then
            MsgBox("Please select Cutoff", vbExclamation)
            cboCutoff.Focus()
            Exit Sub
        End If

        If paramID = "" Then
            MsgBox("Please select Employee ID", vbExclamation)
            Exit Sub
        End If

        Call set_grid()

        rptLikeExcel.lblCompany.Text = ActiveCompanyName
        rptLikeExcel.lblPeriod.Text = "Payroll Register for the Month of " & Format(CDate(GetColumnValue(cboCutoff, 1)), "MM/dd/yyyy") & " - " & Format(CDate(GetColumnValue(cboCutoff, 2)), "MM/dd/yyyy")

        Dim dtFilter() As DataRow = getPayroll_Register(Trim(cboCutoff.Text)).Select("idno in (" & paramID & ")  ")
        If dtFilter.Length > 0 Then
            For Each rrow In dtFilter

                Dim newRowIndex As Integer
                With rptLikeExcel.DataGridView1
                    newRowIndex = .Rows.Add()
                End With

                Dim currentRow As DataGridViewRow = rptLikeExcel.DataGridView1.Rows(newRowIndex)

                currentRow.Cells("idno").Value = rrow("idno").ToString()
                currentRow.Cells("name").Value = StrConv(rrow("lname").ToString & ", " & rrow("fname").ToString & " " & rrow("mname").ToString, vbProperCase)
                currentRow.Cells("basic_rate").Value = FormatNumber(rrow("basic_rate"))

                If chkShowPaymode.Checked = True Then

                    If rrow("paymode").ToString() = "2" Then
                        currentRow.Cells("paymode").Value = "Monthly"
                    ElseIf rrow("paymode").ToString() = "1" Then
                        currentRow.Cells("paymode").Value = "Daily"
                    ElseIf rrow("paymode").ToString() = "3" Then
                        currentRow.Cells("paymode").Value = "Hourly"
                    ElseIf rrow("paymode").ToString() = "4" Then
                        currentRow.Cells("paymode").Value = "Hourly"
                    ElseIf rrow("paymode").ToString() = "5" Then
                        currentRow.Cells("paymode").Value = "Hourly"
                    End If

                End If

                If chkShowCutoff.Checked = True Then
                    currentRow.Cells("cutoff").Value = rrow("cutoff").ToString()
                End If

                If chkShowDivision.Checked = True Then
                    currentRow.Cells("divcode").Value = rrow("divcode").ToString()
                End If

                If chkShowDepartment.Checked = True Then
                    currentRow.Cells("deptcode").Value = rrow("deptcode").ToString()
                End If

                If chkShowCostCenter.Checked = True Then
                    currentRow.Cells("costcode").Value = rrow("costcode").ToString()
                End If

                If chkShowJobStatus.Checked = True Then
                    currentRow.Cells("jstatusname").Value = StrConv(rrow("jstatusname").ToString(), vbProperCase)
                End If

                currentRow.Cells("jtypename").Value = StrConv(rrow("jtypename").ToString(), vbProperCase)

                Dim dtreghrs() As DataRow = getttlreghrs(rrow("idno").ToString(), Trim(cboCutoff.Text)).Select
                If dtreghrs.Length > 0 Then
                    currentRow.Cells("days_work").Value = Format(Val(dtreghrs(0).Item("ttl_reg_hrs")), "#,###.00")
                Else
                    currentRow.Cells("days_work").Value = ""
                End If


                'Amount
                Dim dtPayreg_AMT() As DataRow = getPayrollRegister_Summary_Amount(rrow("idno").ToString(), Trim(cboCutoff.Text)).Select
                If dtPayreg_AMT.Length > 0 Then

                    If chkShowHours.Checked = True Then
                        'Hours
                        Dim dtPayreg_HRS() As DataRow = getPayrollRegister_Summary_Hours(rrow("idno").ToString(), Trim(cboCutoff.Text)).Select
                        If dtPayreg_HRS.Length > 0 Then
                            currentRow.Cells("reghrs").Value = dtPayreg_HRS(0).Item("ttlreghrs")
                            currentRow.Cells("reghrsot").Value = dtPayreg_HRS(0).Item("ttlreghrsot")
                            currentRow.Cells("regnp").Value = dtPayreg_HRS(0).Item("ttlregnp")
                            currentRow.Cells("regnpot").Value = dtPayreg_HRS(0).Item("ttlregnpot")
                            currentRow.Cells("rsthrs").Value = dtPayreg_HRS(0).Item("ttlrsthrs")
                            currentRow.Cells("rstot").Value = dtPayreg_HRS(0).Item("ttlrstot")
                            currentRow.Cells("rstnp").Value = dtPayreg_HRS(0).Item("ttlrstnp")
                            currentRow.Cells("rstnpot").Value = dtPayreg_HRS(0).Item("ttlrstnpot")
                            currentRow.Cells("splhrs").Value = dtPayreg_HRS(0).Item("ttlsplhrs")
                            currentRow.Cells("splhrsot").Value = dtPayreg_HRS(0).Item("ttlsplhrsot")
                            currentRow.Cells("splnp").Value = dtPayreg_HRS(0).Item("ttlsplnp")
                            currentRow.Cells("splnpot").Value = dtPayreg_HRS(0).Item("ttlsplnpot")
                            currentRow.Cells("cmphrs").Value = dtPayreg_HRS(0).Item("ttlcmphrs")
                            currentRow.Cells("cmphrsot").Value = dtPayreg_HRS(0).Item("ttlcmphrsot")
                            currentRow.Cells("cmpnp").Value = dtPayreg_HRS(0).Item("ttlcmpnp")
                            currentRow.Cells("cmpnpot").Value = dtPayreg_HRS(0).Item("ttlcmpnpot")
                            currentRow.Cells("lghrs").Value = dtPayreg_HRS(0).Item("ttllghrs")
                            currentRow.Cells("lghrsot").Value = dtPayreg_HRS(0).Item("ttllghrsot")
                            currentRow.Cells("lgnp").Value = dtPayreg_HRS(0).Item("ttllgnp")
                            currentRow.Cells("lgnpot").Value = dtPayreg_HRS(0).Item("ttllgnpot")
                            currentRow.Cells("rstsplhrs").Value = dtPayreg_HRS(0).Item("ttlrstsplhrs")
                            currentRow.Cells("rstsplhrsot").Value = dtPayreg_HRS(0).Item("ttlrstsplhrsot")
                            currentRow.Cells("rstsplnp").Value = dtPayreg_HRS(0).Item("ttlrstsplnp")
                            currentRow.Cells("rstsplnpot").Value = dtPayreg_HRS(0).Item("ttlrstsplnpot")
                            currentRow.Cells("rstlghrs").Value = dtPayreg_HRS(0).Item("ttlrstlghrs")
                            currentRow.Cells("rstlghrsot").Value = dtPayreg_HRS(0).Item("ttlrstlghrsot")
                            currentRow.Cells("rstlgnp").Value = dtPayreg_HRS(0).Item("ttlrstlgnp")
                            currentRow.Cells("rstlgnpot").Value = dtPayreg_HRS(0).Item("ttlrstlgnpot")
                            currentRow.Cells("rstcmphrs").Value = dtPayreg_HRS(0).Item("ttlrstcmphrs")
                            currentRow.Cells("rstcmphrsot").Value = dtPayreg_HRS(0).Item("ttlrstcmphrsot")
                            currentRow.Cells("rstcmpnp").Value = dtPayreg_HRS(0).Item("ttlrstcmpnp")
                            currentRow.Cells("rstcmpnpot").Value = dtPayreg_HRS(0).Item("ttlrstcmpnpot")
                        End If
                    End If

                    currentRow.Cells("reghrs_amt").Value = dtPayreg_AMT(0).Item("ttlreghrs")
                    currentRow.Cells("reghrsot_amt").Value = dtPayreg_AMT(0).Item("ttlreghrsot")
                    currentRow.Cells("regnp_amt").Value = dtPayreg_AMT(0).Item("ttlregnp")
                    currentRow.Cells("regnpot_amt").Value = dtPayreg_AMT(0).Item("ttlregnpot")
                    currentRow.Cells("rsthrs_amt").Value = dtPayreg_AMT(0).Item("ttlrsthrs")
                    currentRow.Cells("rstot_amt").Value = dtPayreg_AMT(0).Item("ttlrstot")
                    currentRow.Cells("rstnp_amt").Value = dtPayreg_AMT(0).Item("ttlrstnp")
                    currentRow.Cells("rstnpot_amt").Value = dtPayreg_AMT(0).Item("ttlrstnpot")
                    currentRow.Cells("splhrs_amt").Value = dtPayreg_AMT(0).Item("ttlsplhrs")
                    currentRow.Cells("splhrsot_amt").Value = dtPayreg_AMT(0).Item("ttlsplhrsot")
                    currentRow.Cells("splnp_amt").Value = dtPayreg_AMT(0).Item("ttlsplnp")
                    currentRow.Cells("splnpot_amt").Value = dtPayreg_AMT(0).Item("ttlsplnpot")
                    currentRow.Cells("cmphrs_amt").Value = dtPayreg_AMT(0).Item("ttlcmphrs")
                    currentRow.Cells("cmphrsot_amt").Value = dtPayreg_AMT(0).Item("ttlcmphrsot")
                    currentRow.Cells("cmpnp_amt").Value = dtPayreg_AMT(0).Item("ttlcmpnp")
                    currentRow.Cells("cmpnpot_amt").Value = dtPayreg_AMT(0).Item("ttlcmpnpot")
                    currentRow.Cells("lghrs_amt").Value = dtPayreg_AMT(0).Item("ttllghrs")
                    currentRow.Cells("lghrsot_amt").Value = dtPayreg_AMT(0).Item("ttllghrsot")
                    currentRow.Cells("lgnp_amt").Value = dtPayreg_AMT(0).Item("ttllgnp")
                    currentRow.Cells("lgnpot_amt").Value = dtPayreg_AMT(0).Item("ttllgnpot")
                    currentRow.Cells("rstsplhrs_amt").Value = dtPayreg_AMT(0).Item("ttlrstsplhrs")
                    currentRow.Cells("rstsplhrsot_amt").Value = dtPayreg_AMT(0).Item("ttlrstsplhrsot")
                    currentRow.Cells("rstsplnp_amt").Value = dtPayreg_AMT(0).Item("ttlrstsplnp")
                    currentRow.Cells("rstsplnpot_amt").Value = dtPayreg_AMT(0).Item("ttlrstsplnpot")
                    currentRow.Cells("rstlghrs_amt").Value = dtPayreg_AMT(0).Item("ttlrstlghrs")
                    currentRow.Cells("rstlghrsot_amt").Value = dtPayreg_AMT(0).Item("ttlrstlghrsot")
                    currentRow.Cells("rstlgnp_amt").Value = dtPayreg_AMT(0).Item("ttlrstlgnp")
                    currentRow.Cells("rstlgnpot_amt").Value = dtPayreg_AMT(0).Item("ttlrstlgnpot")
                    currentRow.Cells("rstcmphrs_amt").Value = dtPayreg_AMT(0).Item("ttlrstcmphrs")
                    currentRow.Cells("rstcmphrsot_amt").Value = dtPayreg_AMT(0).Item("ttlrstcmphrsot")
                    currentRow.Cells("rstcmpnp_amt").Value = dtPayreg_AMT(0).Item("ttlrstcmpnp")
                    currentRow.Cells("rstcmpnpot_amt").Value = dtPayreg_AMT(0).Item("ttlrstcmpnpot")
                    currentRow.Cells("acchrs").Value = dtPayreg_AMT(0).Item("ttlacchrs")
                    currentRow.Cells("late").Value = dtPayreg_AMT(0).Item("ttllate")
                    currentRow.Cells("undertime").Value = dtPayreg_AMT(0).Item("ttlundertime")
                    currentRow.Cells("absent_hrs").Value = dtPayreg_AMT(0).Item("ttlabsent_hrs")
                    currentRow.Cells("legal_pay").Value = dtPayreg_AMT(0).Item("ttllegal_pay")
                    currentRow.Cells("leavewpay").Value = dtPayreg_AMT(0).Item("ttlleavewpay")
                    currentRow.Cells("formulated_shift").Value = dtPayreg_AMT(0).Item("ttlformulated_shift")
                    '
                    If chkDetailedLeave.Checked = True Then
                        currentRow.Cells("sl_wpay").Value = dtPayreg_AMT(0).Item("ttlsl_wpay")
                        currentRow.Cells("vl_wpay").Value = dtPayreg_AMT(0).Item("ttlvl_wpay")
                        currentRow.Cells("el_wpay").Value = dtPayreg_AMT(0).Item("ttlel_wpay")
                        currentRow.Cells("pl_wpay").Value = dtPayreg_AMT(0).Item("ttlpl_wpay")
                        currentRow.Cells("ml_wpay").Value = dtPayreg_AMT(0).Item("ttlml_wpay")
                        currentRow.Cells("ul_wpay").Value = dtPayreg_AMT(0).Item("ttlul_wpay")
                        currentRow.Cells("ol_wpay").Value = dtPayreg_AMT(0).Item("ttlol_wpay")
                        currentRow.Cells("xl_wpay").Value = dtPayreg_AMT(0).Item("ttlxl_wpay")
                        currentRow.Cells("al_wpay").Value = dtPayreg_AMT(0).Item("ttlal_wpay")
                    End If
                    '
                    currentRow.Cells("adv_calculated_ot").Value = dtPayreg_AMT(0).Item("ttladv_calculated_ot")

                    'Adjusted Payroll

                    Dim dtPayreg_ADJ() As DataRow = getPayrollRegister_Summary_Adjusted(rrow("idno").ToString(), Trim(cboCutoff.Text)).Select
                    If dtPayreg_ADJ.Length > 0 Then
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttlreghrs")) = False Then currentRow.Cells("ADJ_reghrs").Value = dtPayreg_ADJ(0).Item("ttlreghrs")
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttlreghrsot")) = False Then currentRow.Cells("ADJ_reghrsot").Value = dtPayreg_ADJ(0).Item("ttlreghrsot")
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttlregnp")) = False Then currentRow.Cells("ADJ_regnp").Value = dtPayreg_ADJ(0).Item("ttlregnp")
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttlregnpot")) = False Then currentRow.Cells("ADJ_regnpot").Value = dtPayreg_ADJ(0).Item("ttlregnpot")
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttlrsthrs")) = False Then currentRow.Cells("ADJ_rsthrs").Value = dtPayreg_ADJ(0).Item("ttlrsthrs")
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttlrstot")) = False Then currentRow.Cells("ADJ_rstot").Value = dtPayreg_ADJ(0).Item("ttlrstot")
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttlrstnp")) = False Then currentRow.Cells("ADJ_rstnp").Value = dtPayreg_ADJ(0).Item("ttlrstnp")
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttlrstnpot")) = False Then currentRow.Cells("ADJ_rstnpot").Value = dtPayreg_ADJ(0).Item("ttlrstnpot")
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttlsplhrs")) = False Then currentRow.Cells("ADJ_splhrs").Value = dtPayreg_ADJ(0).Item("ttlsplhrs")
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttlsplhrsot")) = False Then currentRow.Cells("ADJ_splhrsot").Value = dtPayreg_ADJ(0).Item("ttlsplhrsot")
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttlsplnp")) = False Then currentRow.Cells("ADJ_splnp").Value = dtPayreg_ADJ(0).Item("ttlsplnp")
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttlsplnpot")) = False Then currentRow.Cells("ADJ_splnpot").Value = dtPayreg_ADJ(0).Item("ttlsplnpot")
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttlcmphrs")) = False Then currentRow.Cells("ADJ_cmphrs").Value = dtPayreg_ADJ(0).Item("ttlcmphrs")
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttlcmphrsot")) = False Then currentRow.Cells("ADJ_cmphrsot").Value = dtPayreg_ADJ(0).Item("ttlcmphrsot")
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttlcmpnp")) = False Then currentRow.Cells("ADJ_cmpnp").Value = dtPayreg_ADJ(0).Item("ttlcmpnp")
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttlcmpnpot")) = False Then currentRow.Cells("ADJ_cmpnpot").Value = dtPayreg_ADJ(0).Item("ttlcmpnpot")
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttllghrs")) = False Then currentRow.Cells("ADJ_lghrs").Value = dtPayreg_ADJ(0).Item("ttllghrs")
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttllghrsot")) = False Then currentRow.Cells("ADJ_lghrsot").Value = dtPayreg_ADJ(0).Item("ttllghrsot")
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttllgnp")) = False Then currentRow.Cells("ADJ_lgnp").Value = dtPayreg_ADJ(0).Item("ttllgnp")
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttllgnpot")) = False Then currentRow.Cells("ADJ_lgnpot").Value = dtPayreg_ADJ(0).Item("ttllgnpot")
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttlrstsplhrs")) = False Then currentRow.Cells("ADJ_rstsplhrs").Value = dtPayreg_ADJ(0).Item("ttlrstsplhrs")
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttlrstsplhrsot")) = False Then currentRow.Cells("ADJ_rstsplhrsot").Value = dtPayreg_ADJ(0).Item("ttlrstsplhrsot")
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttlrstsplnp")) = False Then currentRow.Cells("ADJ_rstsplnp").Value = dtPayreg_ADJ(0).Item("ttlrstsplnp")
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttlrstsplnpot")) = False Then currentRow.Cells("ADJ_rstsplnpot").Value = dtPayreg_ADJ(0).Item("ttlrstsplnpot")
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttlrstlghrs")) = False Then currentRow.Cells("ADJ_rstlghrs").Value = dtPayreg_ADJ(0).Item("ttlrstlghrs")
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttlrstlghrsot")) = False Then currentRow.Cells("ADJ_rstlghrsot").Value = dtPayreg_ADJ(0).Item("ttlrstlghrsot")
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttlrstlgnp")) = False Then currentRow.Cells("ADJ_rstlgnp").Value = dtPayreg_ADJ(0).Item("ttlrstlgnp")
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttlreghrsot")) = False Then currentRow.Cells("ADJ_rstlgnpot").Value = dtPayreg_ADJ(0).Item("ttlrstlgnpot")
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttlreghrsot")) = False Then currentRow.Cells("ADJ_rstcmphrs").Value = dtPayreg_ADJ(0).Item("ttlrstcmphrs")
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttlreghrsot")) = False Then currentRow.Cells("ADJ_rstcmphrsot").Value = dtPayreg_ADJ(0).Item("ttlrstcmphrsot")
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttlreghrsot")) = False Then currentRow.Cells("ADJ_rstcmpnp").Value = dtPayreg_ADJ(0).Item("ttlrstcmpnp")
                        If IsDBNull(dtPayreg_ADJ(0).Item("ttlreghrsot")) = False Then currentRow.Cells("ADJ_rstcmpnpot").Value = dtPayreg_ADJ(0).Item("ttlrstcmpnpot")
                    End If

                    'FixEarnings
                    Dim dtFixPayroll() As DataRow = getFixEarnings_Payroll(rrow("idno").ToString(), Trim(cboCutoff.Text)).Select
                    If dtFixPayroll.Length > 0 Then
                        For Each rrow_earn In dtFixPayroll
                            For Each col As DataGridViewColumn In rptLikeExcel.DataGridView1.Columns
                                If col.Name = Trim(rrow_earn("inccode").ToString) Then
                                    currentRow.Cells(col.Index).Value = FormatNumber(rrow_earn("amt_"), 2)
                                    col.HeaderCell.Style.BackColor = lightBlue
                                    col.DefaultCellStyle.BackColor = lightBlue
                                    Exit For
                                End If
                            Next
                        Next
                    End If

                    'OtherEarnings
                    Dim dtEarnPayroll() As DataRow = getOtherEarnings_Payroll(rrow("idno").ToString(), Trim(cboCutoff.Text)).Select
                    If dtEarnPayroll.Length > 0 Then
                        For Each rrow_earn In dtEarnPayroll
                            For Each col As DataGridViewColumn In rptLikeExcel.DataGridView1.Columns
                                If col.Name = Trim(rrow_earn("inccode").ToString) Then
                                    currentRow.Cells(col.Index).Value = FormatNumber(rrow_earn("amt_"), 2)
                                    col.HeaderCell.Style.BackColor = lightBlue
                                    col.DefaultCellStyle.BackColor = lightBlue
                                    Exit For
                                End If
                            Next
                        Next
                    End If

                    'Gross ALL
                    currentRow.Cells("actual_basic").Value = FormatNumber(dtPayreg_AMT(0).Item("ttlactual_basic_pay"), 2)
                    If chkShowTaxableGross.Checked = True Then
                        currentRow.Cells("gross_taxable").Value = FormatNumber(dtPayreg_AMT(0).Item("ttlgross_taxable"), 2)
                    End If
                    currentRow.Cells("gross_all").Value = FormatNumber(dtPayreg_AMT(0).Item("ttlgross_all"), 2)

                    'Deductions
                    Dim dtDeductPayroll() As DataRow = getCutoff_Dedcutions_MergeList_Amount(rrow("idno").ToString(), Trim(cboCutoff.Text)).Select
                    If dtDeductPayroll.Length > 0 Then
                        For Each rrow_ddct In dtDeductPayroll
                            For Each col As DataGridViewColumn In rptLikeExcel.DataGridView1.Columns
                                If col.Name = Trim(rrow_ddct("ddctcode").ToString) Then
                                    currentRow.Cells(col.Index).Value = FormatNumber(rrow_ddct("amt_"), 2)
                                    col.HeaderCell.Style.BackColor = lightRed
                                    col.DefaultCellStyle.BackColor = lightRed
                                    Exit For
                                End If
                            Next
                        Next
                    End If

                    ''SSS
                    currentRow.Cells("sss_yee").Value = FormatNumber(dtPayreg_AMT(0).Item("ttlsss_yee"), 2)

                    If chkEmployerShare.Checked = True Then
                        currentRow.Cells("sss_yer").Value = dtPayreg_AMT(0).Item("ttlsss_yer")
                        currentRow.Cells("sss_ec").Value = dtPayreg_AMT(0).Item("ttlsss_ec")
                    End If

                    currentRow.Cells("sss_loan_salary").Value = dtPayreg_AMT(0).Item("ttlsss_loan_salary")
                    currentRow.Cells("sss_loan_calamity").Value = dtPayreg_AMT(0).Item("ttlsss_loan_calamity")
                    currentRow.Cells("sss_loan_emergency").Value = dtPayreg_AMT(0).Item("ttlsss_loan_emergency")

                    'Phealth
                    currentRow.Cells("phealth_yee").Value = dtPayreg_AMT(0).Item("ttlphealth_yee")
                    If chkEmployerShare.Checked = True Then
                        currentRow.Cells("phealth_yer").Value = dtPayreg_AMT(0).Item("ttlphealth_yer")
                    End If

                    'BIR
                    currentRow.Cells("BIR").Value = dtPayreg_AMT(0).Item("ttlmygov_tax")

                    'HDMF
                    currentRow.Cells("hdmf_yee").Value = dtPayreg_AMT(0).Item("ttlhdmf_yee")
                    If chkEmployerShare.Checked = True Then
                        currentRow.Cells("hdmf_yer").Value = dtPayreg_AMT(0).Item("ttlhdmf_yer")
                    End If

                    currentRow.Cells("hdmf_loan_salary").Value = dtPayreg_AMT(0).Item("ttlhdmf_loan_salary")
                    currentRow.Cells("hdmf_loan_housing").Value = dtPayreg_AMT(0).Item("ttlhdmf_loan_housing")
                    currentRow.Cells("hdmf_loan_calamity").Value = dtPayreg_AMT(0).Item("ttlhdmf_loan_calamity")

                    'Medicare
                    currentRow.Cells("medicare_yee").Value = dtPayreg_AMT(0).Item("ttlmedicare_yee")
                    currentRow.Cells("medicare_yer").Value = dtPayreg_AMT(0).Item("ttlmedicare_yer")

                    'GSIS
                    currentRow.Cells("gsis_yee").Value = dtPayreg_AMT(0).Item("ttlgsis_yee")

                    If chkEmployerShare.Checked = True Then
                        currentRow.Cells("gsis_yer").Value = dtPayreg_AMT(0).Item("ttlgsis_yer")
                    End If

                    currentRow.Cells("gsis_ecc").Value = dtPayreg_AMT(0).Item("ttlgsis_ecc")
                    currentRow.Cells("gsis_ehp").Value = dtPayreg_AMT(0).Item("ttlgsis_ehp")
                    currentRow.Cells("gsis_loan_salary").Value = dtPayreg_AMT(0).Item("ttlgsis_loan_salary")
                    currentRow.Cells("gsis_loan_housing").Value = dtPayreg_AMT(0).Item("ttlgsis_loan_housing")
                    currentRow.Cells("gsis_loan_emergency").Value = dtPayreg_AMT(0).Item("ttlgsis_loan_emergency")
                    currentRow.Cells("gsis_loan_policy").Value = dtPayreg_AMT(0).Item("ttlgsis_loan_policy")

                    'Company Loan
                    For st_ = 1 To 6 Step 1
                        For Each col As DataGridViewColumn In rptLikeExcel.DataGridView1.Columns
                            If col.Name = "coop_loan_" & st_ Then
                                currentRow.Cells(col.Index).Value = dtPayreg_AMT(0).Item("ttlcompany_loan_" & st_)
                                Exit For
                            End If
                        Next
                    Next

                    'Multiple loans
                    Dim dtMultipleLoan() As DataRow = getPayrollRegister_Loan_Multiple_Payment_Ledger(rrow("idno").ToString(), Trim(cboCutoff.Text)).Select
                    If dtMultipleLoan.Length > 0 Then
                        For Each rrow_mloan In dtMultipleLoan
                            For Each col As DataGridViewColumn In rptLikeExcel.DataGridView1.Columns
                                If col.Name = Trim(rrow_mloan("mcode").ToString) Then
                                    currentRow.Cells(col.Index).Value = FormatNumber(rrow_mloan("amount"), 2)
                                    col.HeaderCell.Style.BackColor = lightRed
                                    col.DefaultCellStyle.BackColor = lightRed
                                    Exit For
                                End If
                            Next
                        Next
                    End If


                    currentRow.Cells("13th_Month").Value = dtPayreg_AMT(0).Item("ttlmy13th_month_ntaxable") + dtPayreg_AMT(0).Item("ttlmy13th_month_taxable")

                    currentRow.Cells("shared_benefits_yee").Value = dtPayreg_AMT(0).Item("ttlshared_benefits_yee")

                    If chkEmployerShare.Checked = True Then
                        currentRow.Cells("shared_benefits_yer").Value = dtPayreg_AMT(0).Item("ttlshared_benefits_yer")
                    End If

                    currentRow.Cells("Net_Pay").Value = dtPayreg_AMT(0).Item("ttlnetpay")
                    currentRow.Cells("Net_Pay").Style.BackColor = lightgreen
                    currentRow.DataGridView.Columns("Net_Pay").HeaderCell.Style.BackColor = lightgreen

                    currentRow.Cells("Coin_Savings").Value = dtPayreg_AMT(0).Item("ttlnet_dec")

                End If

            Next
        End If

        With rptLikeExcel.DataGridView1
            For Each col As DataGridViewColumn In .Columns
                Dim hideColumn As Boolean = True

                For Each row As DataGridViewRow In .Rows
                    If Not row.IsNewRow Then
                        Dim cellValue = row.Cells(col.Index).Value

                        If Not (IsNothing(cellValue) OrElse cellValue.ToString().Trim() = "" OrElse cellValue.ToString() = "0") Then
                            hideColumn = False
                            Exit For
                        End If
                    End If
                Next

                col.Visible = Not hideColumn
            Next
        End With

        MsgBox("Done!", vbInformation)
        rptLikeExcel.ShowDialog()

    End Sub

    Private Sub cboYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYear.SelectedIndexChanged
        process_year = GetColumnValue(cboYear, 0)
        If process_year <> "" Then
            process_year = process_year.Substring(process_year.Length - 2)
            Call classComboBox.setCboCutoff(cboCutoff, process_year)
        End If
    End Sub
    Private Sub cboJobStatus_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboJobStatus.SelectionChangeCommitted
        If lvDivision.isCheckedAll = True Then
            classEmployee.TriggerItemChecked_(lvDivision, lvEmployee, GetColumnValue(cboJobStatus, 0))
        End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class