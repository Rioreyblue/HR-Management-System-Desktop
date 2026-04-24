Imports NXNParsing
Imports REPORTS

Public Class rptService_Record
    Private jStr_Input As String = "[]"
    Private ws As New WSConnection
    Private Token As String = String.Empty
    Private ActiveFrm As String = "rptService_Record.php"
    Private Sub rptService_Record_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

                    Call classTimer.CloseLoading(frmLoading)
                    Call classTimer.TimerReset()
            End Select
        End If
        classTimer.TimerCount += 1
    End Sub
    Private Sub Handler()
        classEmployee.TriggerItemChecked(lvDivision, lvEmployee)
    End Sub
    Private Sub lvDivision_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles lvDivision.ItemChecked
        If lvDivision.isCheckedAll = True Then
            classEmployee.TriggerItemChecked(lvDivision, lvEmployee)
        End If
    End Sub

    Private Sub lvEmployee_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles lvEmployee.ItemChecked
        If e.Item.Checked Then
            ' Uncheck all other items except the one just checked
            For Each item As ListViewItem In lvEmployee.Items
                If item IsNot e.Item Then
                    item.Checked = False
                End If
            Next
            paramID = Trim(e.Item.SubItems(0).Text)
        Else
            paramID = ""
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim jtype_from As String = String.Empty
        Dim jtype_to As String = String.Empty
        Dim paymod_ As String = String.Empty
        Dim basic_rate_ As String = String.Empty
        report_forGlobal = _Dispose(report_forGlobal)

        Dim comp_address_ As String = ""
        Dim comp_contact_ As String = ""

        Dim lastname_ As String = ""
        Dim firstname_ As String = ""
        Dim middlename_ As String = ""
        Dim dateofbirth_ As String = ""
        Dim placeofbirth_ As String = ""

        Dim i As Integer = 0
        Dim tmp_jtype_to As String = ""
        Dim isfirstLoop As Boolean = True

        dt = New DataTable
        dt.Columns.Add("jtype_from", GetType(String))
        dt.Columns.Add("jtype_to", GetType(String))
        dt.Columns.Add("designation", GetType(String))
        dt.Columns.Add("jstatusname_", GetType(String))
        dt.Columns.Add("jtypename", GetType(String))
        dt.Columns.Add("basic_rate", GetType(String))
        dt.Columns.Add("division_", GetType(String))
        dt.Columns.Add("department_", GetType(String))
        dt.Columns.Add("costcenter_", GetType(String))

        While i < getService_Record.Rows.Count
            Dim row As DataRow = getService_Record.Rows(i)

            If IsDBNull(row.Item("servc_record_date")) = False AndAlso row.Item("servc_record_date") <> "1900-01-01" Then
                jtype_from = Format(CDate(row.Item("servc_record_date")), "MMM dd, yyyy")
            Else
                jtype_from = "Present"
            End If

            If IsDBNull(row.Item("servc_record_date_to")) = False AndAlso row.Item("servc_record_date_to") <> "1900-01-01" Then
                jtype_to = Format(CDate(row.Item("servc_record_date_to")), "MMM dd, yyyy")
            Else
                jtype_to = "Present"
            End If

            If Trim(row.Item("paymode")) = "1" Then
                paymod_ = "/" & "day"
            ElseIf Trim(row.Item("paymode")) = "2" Then
                paymod_ = "/" & "mo."
            ElseIf Trim(row.Item("paymode")) = "3" Then
                paymod_ = "/" & "fa."
            ElseIf Trim(row.Item("paymode")) = "4" Then
                paymod_ = "/" & "mu."
            ElseIf Trim(row.Item("paymode")) = "5" Then
                paymod_ = "/" & "hr."
            ElseIf Trim(row.Item("paymode")) = "6" Then
                paymod_ = "/" & "tr."
            End If

            If IsDBNull(row.Item("basic_rate")) = False Then basic_rate_ = "P" & FormatNumber(row.Item("basic_rate")) & paymod_
            If isfirstLoop = True Then
                dt.Rows.Add(Format(CDate(row.Item("date_hire")), "MMM dd, yyyy") & " (Date Hired) ", jtype_to, StrConv(row.Item("designation"), vbProperCase), StrConv(row.Item("jstatusname"), vbProperCase), StrConv(row.Item("jtypename"), vbProperCase), basic_rate_, StrConv(row.Item("divname"), vbProperCase), StrConv(row.Item("deptname"), vbProperCase), StrConv(row.Item("costname"), vbProperCase))
                isfirstLoop = False
            Else
                If jtype_from = jtype_to Then
                    jtype_to = "Present"
                End If
                dt.Rows.Add(Format(CDate(jtype_from), "MMM dd, yyyy"), jtype_to, StrConv(row.Item("designation"), vbProperCase), StrConv(row.Item("jstatusname"), vbProperCase), StrConv(row.Item("jtypename"), vbProperCase), basic_rate_, StrConv(row.Item("divname"), vbProperCase), StrConv(row.Item("deptname"), vbProperCase), StrConv(row.Item("costname"), vbProperCase))
            End If
            i += 1
        End While

        Dim dtFilter() As DataRow = getCompanyList.Select("keyctr='" & ActiveCompany & "'")
        If dtFilter.Length > 0 Then
            For Each rrow In dtFilter
                comp_address_ = StrConv(rrow("address").ToString, vbProperCase)
                comp_contact_ = StrConv(rrow("contact_no").ToString, vbProperCase)
            Next
        End If

        dtFilter = getEmployee.Select("idno='" & paramID & "'")
        If dtFilter.Length > 0 Then
            For Each rrow In dtFilter
                lastname_ = rrow("lname").ToString.ToUpper
                firstname_ = rrow("fname").ToString.ToUpper
                middlename_ = rrow("mname").ToString.ToUpper
                dateofbirth_ = Format(CDate(rrow("bdate")), "MMM dd, yyyy").ToString
                placeofbirth_ = StrConv(rrow("placeofbirth"), vbProperCase)
            Next
        End If

        rParam = "company_=" + ActiveCompanyName.ToString.ToUpper +
                         "&address_=" + comp_address_ +
                         "&contact_=" + comp_contact_ +
                         "&lastname_=" + lastname_ +
                         "&firstname_=" + firstname_ +
                         "&middlename_=" + middlename_ +
                         "&dateofbirth_=" + dateofbirth_ +
                         "&placeofbirth_=" + placeofbirth_

        report_forGlobal.Parameters = rParam
        rPath = rDIR & "Report_Service_Record.rdl"

        dataset_ = "Data1"
        Dim rptGlobal_ As New rptGlobal
        Call View_Report(rptGlobal_, "Employment Listing", report_forGlobal, rPath, dataset_, dt, False)

        With rptGlobal_
            .WindowState = FormWindowState.Maximized
            .Show()
            .Focus()
        End With
        Call rptGlobal_.setContent()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class