Imports Microsoft.Reporting.WinForms

Public Class rptCustomReport
    Private Sub rptCustomReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

                    classComboBox.setCboSex(cboSex)
                    classComboBox.setCboNumber(cboAge1)
                    classComboBox.setCboNumber(cboAge2)
                    classComboBox.setCboCivilStatus(cboCivilStatus)
                    paramTable = "profile"
                    classComboBox.setCboReligion(cboReligion)
                    classComboBox.setCboJobStatus(cboJobStatus)
                    classComboBox.setCboJobLevel(cboJobLevel)
                    classComboBox.setCboJobType(cboJobType)
                    classComboBox.setCboPosition(cboPosition)
                    classComboBox.setCboTaxCode(cboTaxcode)
                    classComboBox.setCboBank(cboBank)
                    classComboBox.setCboPaymode(cboPaymode)
                    classComboBox.setCboProv(cboProvince)

                    Call classTimer.CloseLoading(frmLoading)
                    Call classTimer.TimerReset()
            End Select
        End If
        classTimer.TimerCount += 1
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'Try

        'Fields

        Dim selectedFields As New List(Of String)

        If chkID.Checked Then selectedFields.Add("idno")
        If chkLname.Checked Then selectedFields.Add("lname")
        If chkFname.Checked Then selectedFields.Add("fname")
        If chkMname.Checked Then selectedFields.Add("mname")
        If chkMaiden.Checked Then selectedFields.Add("maiden")
        If chkNameExtension.Checked Then selectedFields.Add("nameextension")
        If chkSex.Checked Then selectedFields.Add("gender_def")
        If chkCivilStatus.Checked Then selectedFields.Add("civilstatus_def")
        If chkCitizenship.Checked Then selectedFields.Add("citizenship")
        If chkBdate.Checked Then selectedFields.Add("bdate")
        If chkAge.Checked Then selectedFields.Add("age")
        If chkHeight.Checked Then selectedFields.Add("height")
        If chkWeight.Checked Then selectedFields.Add("weight")
        If chkBloodType.Checked Then selectedFields.Add("blood_type")
        If chkSSS.Checked Then selectedFields.Add("sss_no")
        If chkPhealth.Checked Then selectedFields.Add("phealth_no")
        If chkHDMF.Checked Then selectedFields.Add("hdmf_no")
        If chkTIN.Checked Then selectedFields.Add("tin_no")
        If chkGSIS.Checked Then selectedFields.Add("gsis_no")
        If chkReligion.Checked Then selectedFields.Add("religion")
        If chkPlaceofBirth.Checked Then selectedFields.Add("placeofbirth")
        If chkPrefix.Checked Then selectedFields.Add("prefix")
        If chkPostfix.Checked Then selectedFields.Add("postfix")
        If chkBadgeNo.Checked Then selectedFields.Add("xtra_idno")
        If chkPhilID.Checked Then selectedFields.Add("philid_no")

        'Employment Status
        If chkPosition.Checked Then selectedFields.Add("myposition")
        If chkPositionDate.Checked Then selectedFields.Add("position_date")
        If chkJobLevel.Checked Then selectedFields.Add("jlevelname")
        If chkJobLevelDate.Checked Then selectedFields.Add("joblevel_date")
        If chkJobType.Checked Then selectedFields.Add("jtypename")
        If chkJobTypeDate.Checked Then selectedFields.Add("jobtype_date")
        If chkJobStatus.Checked Then selectedFields.Add("jstatusname")
        If chkJobStatusDate.Checked Then selectedFields.Add("jobstatus_date")
        If chkJobGrade.Checked Then selectedFields.Add("jgradename")
        If chkSteps.Checked Then selectedFields.Add("steps")
        If chkDateHired.Checked Then selectedFields.Add("date_hire")
        If chkDateAssigned.Checked Then selectedFields.Add("date_assign")
        If chkDateRegular.Checked Then selectedFields.Add("date_regular")
        If chkBasicRate.Checked Then selectedFields.Add("basic_rate")
        If chkBasicRateDate.Checked Then selectedFields.Add("basicrate_date")
        If chkTaxcode.Checked Then selectedFields.Add("taxcode")
        If chkDivision.Checked Then selectedFields.Add("divname")
        If chkDivisionDate.Checked Then selectedFields.Add("division_date")
        If chkDepartment.Checked Then selectedFields.Add("deptname")
        If chkDepartmentDate.Checked Then selectedFields.Add("dept_date")
        If chkCostCenter.Checked Then selectedFields.Add("costname")
        If chkCostCenterDate.Checked Then selectedFields.Add("ccenter_date")
        If chkSection.Checked Then selectedFields.Add("secname")
        If chkGroup.Checked Then selectedFields.Add("grpname")
        If chkArea.Checked Then selectedFields.Add("area_description")
        If chkBank.Checked Then selectedFields.Add("bankcode")
        If chkAccount.Checked Then selectedFields.Add("acctno")
        If chkImmediateHead.Checked Then selectedFields.Add("immediate_head")
        If chkLenghtofService.Checked Then selectedFields.Add("length_of_service")
        If chkPaymode.Checked Then selectedFields.Add("paymode")

        If chkStreet.Checked Then selectedFields.Add("street_address")
        If chkBarangay.Checked Then selectedFields.Add("brgyname")
        If chkCity.Checked Then selectedFields.Add("cityname")
        If chkProvince.Checked Then selectedFields.Add("provname")
        If chkCountry.Checked Then selectedFields.Add("country")
        If chkZipCode.Checked Then selectedFields.Add("zipcode")
        If chkMobile.Checked Then selectedFields.Add("mobile")
        If chkTelephone.Checked Then selectedFields.Add("tel_office")
        If chkFax.Checked Then selectedFields.Add("fax")
        If chkEmail.Checked Then selectedFields.Add("email_address")
        If chkWebPage.Checked Then selectedFields.Add("webpage")
        If chkCedula.Checked Then selectedFields.Add("cedula_number")

        'Educational Attainment
        If chkElementary.Checked Then selectedFields.Add("elementary")
        If chkElementaryHonor.Checked Then selectedFields.Add("elem_honor")
        If chkElementaryYear.Checked Then selectedFields.Add("pri_grad")

        If chkSecondary.Checked Then selectedFields.Add("secondary")
        If chkSecondaryHonor.Checked Then selectedFields.Add("secon_honor")
        If chkSecondaryYear.Checked Then selectedFields.Add("sec_grad")

        If chkCollege.Checked Then selectedFields.Add("edinstitution")
        If chkCollegeHonor.Checked Then selectedFields.Add("eddegree")
        If chkCollegeYear.Checked Then selectedFields.Add("edhonor")
        If chkCollegeDegree.Checked Then selectedFields.Add("edyear_grad")

        If chkVocational.Checked Then selectedFields.Add("vcinstitution")
        If chkVocationalHonor.Checked Then selectedFields.Add("vcvocation")
        If chkVocationalYear.Checked Then selectedFields.Add("vcyear_grad")

        'Parameters
        Dim qry_ As String = ""
        Dim DTH_param_ As String = ""
        Dim AGE_param As String = ""

        If cboSex.Text <> "" Then
            qry_ = qry_ & " and (gender_def='" & Trim(cboSex.Text) & "')"
        Else
            qry_ = ""
        End If

        If Trim(cboAge1.Text) <> "" AndAlso Trim(cboAge2.Text) <> "" Then
            If Val(Trim(cboAge1.Text)) > Val(Trim(cboAge2.Text)) Then
                MsgBox("Invalid Age Range, Age Range 2 must be greater than the Age Range 1 !", vbExclamation)
                Exit Sub
            Else
                AGE_param = " AND (age >= '" & Trim(cboAge1.Text) & "' AND  age <= '" & Trim(cboAge2.Text) & "')"
            End If
        End If

        If cboCivilStatus.Text <> "" Then
            qry_ = qry_ & " and (civilstatus_def='" & Trim(cboCivilStatus.Text) & "')"
        Else
            qry_ = qry_
        End If

        If cboDepartment.Text <> "" And cboDepartment.Text <> "ALL" Then
            qry_ = qry_ & " and (deptcode='" & Trim(cboDepartment.Text) & "')"
        Else
            qry_ = qry_
        End If

        If cboReligion.Text <> "" Then
            qry_ = qry_ & " and (religion='" & Trim(cboReligion.Text) & "')"
        Else
            qry_ = qry_
        End If

        If chkParamDateHire.Checked = True Then
            If CDate(dpDateHireFrom.Text) > CDate(dpDateHireTo.Text) Then
                MsgBox("Invalid Date Format, End date must be greater than the Start date!", vbExclamation)
                Exit Sub
            Else
                DTH_param_ = " AND (date_hire >= '" & Format(CDate(dpDateHireFrom.Text), "yyyy-MM-dd") & "' AND  date_hire <= '" & Format(CDate(dpDateHireTo.Text), "yyyy-MM-dd") & "')"
            End If
        End If

        If cboJobStatus.Text <> "" Then
            qry_ = qry_ & " and (jobstatus='" & Trim(cboJobStatus.Text) & "')"
        Else
            qry_ = qry_
        End If

        If cboJobLevel.Text <> "" Then
            qry_ = qry_ & " and (joblevel='" & Trim(cboJobLevel.Text) & "')"
        Else
            qry_ = qry_
        End If

        If cboJobType.Text <> "" Then
            qry_ = qry_ & " and (jobtype='" & Trim(cboJobType.Text) & "')"
        Else
            qry_ = qry_
        End If

        If cboPosition.Text <> "" Then
            qry_ = qry_ & " and (position='" & Trim(cboPosition.Text) & "')"
        Else
            qry_ = qry_
        End If

        If cboTaxcode.Text <> "" Then
            qry_ = qry_ & " and (taxcode='" & Trim(cboTaxcode.Text) & "')"
        Else
            qry_ = qry_
        End If

        If cboBank.Text <> "" Then
            qry_ = qry_ & " and (bankcode='" & Trim(cboBank.Text) & "')"
        Else
            qry_ = qry_
        End If

        If cboPaymode.Text <> "" Then
            qry_ = qry_ & " and (paymode='" & Trim(cboPaymode.Text) & "')"
        Else
            qry_ = qry_
        End If

        If cboProvince.Text <> "" Then
            qry_ = qry_ & " and (provid='" & Trim(cboProvince.Text) & "')"
        Else
            qry_ = qry_
        End If

        If cboCity.Text <> "" Then
            qry_ = qry_ & " and (cityid='" & Trim(cboCity.Text) & "')"
        Else
            qry_ = qry_
        End If

        If cboBarangay.Text <> "" Then
            qry_ = qry_ & " and (brgyid='" & Trim(cboBarangay.Text) & "')"
        Else
            qry_ = qry_
        End If

        If Trim(cboDivision.Text) = "" Then
            MsgBox("Please select Division !", vbExclamation)
            cboDivision.Focus()
            Exit Sub
        End If

        If lvEmployee.CheckedItems.Count = 0 Then
            MsgBox("Please select Employee ID !", vbExclamation)
            lvEmployee.Focus()
            Exit Sub
        End If

        If rbtnDataReport.Checked = True Then
            If selectedFields.Count > 8 Then
                MsgBox("Maximum of (8) checked items for Data Report !", vbExclamation)
                lvEmployee.Focus()
                Exit Sub
            End If
        End If

        Dim fullTable As New DataTable
        If chkElementary.Checked OrElse chkSecondary.Checked OrElse chkCollege.Checked OrElse chkVocational.Checked Then
            fullTable = getAllEmployee_Record_Custom_Report_wEducational_Attainment(ActiveCompany)
        Else
            fullTable = getAllEmployee_Record_Custom_Report(ActiveCompany)
        End If
        Dim ij As Integer = fullTable.Rows.Count
        Dim empData_ As DataTable = fullTable.Clone()

        ' Loop through checked items and select matching rows
        For Each item As ListViewItem In Me.lvEmployee.Items
            If item.Checked = True Then
                Dim matchingRows() As DataRow = fullTable.Select("idno = '" & Trim(item.SubItems(0).Text) & "' " & qry_ & " " & DTH_param_ & " " & AGE_param & " ")
                For Each row As DataRow In matchingRows
                    empData_.ImportRow(row)
                Next
            End If
        Next

        For Each row As DataRow In empData_.Rows
            row("basic_rate") = FormatNumber(row("basic_rate").ToString())
            row("age") = row("age").ToString() & " years"
        Next

        ' Create a tempTable with fixed column names
        Dim dtEmployee As New DataTable()
        For i As Integer = 1 To selectedFields.Count
            dtEmployee.Columns.Add("Col" & i)
        Next

        ' Fill the tempTable
        For Each row As DataRow In empData_.Rows
            Dim newRow As DataRow = dtEmployee.NewRow()
            For i As Integer = 0 To selectedFields.Count - 1
                newRow("Col" & (i + 1)) = StrConv(row(selectedFields(i)).ToString(), vbProperCase)
            Next
            dtEmployee.Rows.Add(newRow)
        Next

        ' Create report headers
        Dim reportParams As New List(Of ReportParameter)
        For i As Integer = 0 To selectedFields.Count - 1
            Dim field As String = selectedFields(i)
            Dim headerName As String

            Select Case field.ToLower()
                Case "idno"
                    headerName = "ID Number"
                Case "lname"
                    headerName = "Last Name"
                Case "fname"
                    headerName = "First Name"
                Case "mname"
                    headerName = "Middle Name"
                Case "maiden"
                    headerName = "Maiden Name"
                Case "nameextension"
                    headerName = "Name Extension"
                Case "gender_def"
                    headerName = "Gender"
                Case "civilstatus_def"
                    headerName = "Civil Status"
                Case "bdate"
                    headerName = "Birth Date"
                Case "age"
                    headerName = "Age"
                Case "height"
                    headerName = "Height"
                Case "weight"
                    headerName = "Weight"
                Case "blood_type"
                    headerName = "Blood Type"
                Case "sss_no"
                    headerName = "SSS #"
                Case "phealth_no"
                    headerName = "PHealth #"
                Case "hdmf_no"
                    headerName = "HDMF #"
                Case "gsis_no"
                    headerName = "GSIS #"
                Case "tin_no"
                    headerName = "TIN #"
                Case "religion"
                    headerName = "Religion"
                Case "placeofbirth"
                    headerName = "Place of Birth"
                Case "prefix"
                    headerName = "Place of Birth"
                Case "postfix"
                    headerName = "Place of Birth"
                Case "xtra_idno"
                    headerName = "Badge No."
                Case "philid_no"
                    headerName = "National ID"
                Case "myposition"
                    headerName = "Position"
                Case "position_date"
                    headerName = "Position Date"
                Case "jlevelname"
                    headerName = "Job Level"
                Case "joblevel_date"
                    headerName = "Job Level Date"
                Case "jtypename"
                    headerName = "Job Type"
                Case "jobtype_date"
                    headerName = "Job Type Date"
                Case "jstatusname"
                    headerName = "Job Status"
                Case "jobstatus_date"
                    headerName = "Job Status Date"
                Case "jgradename"
                    headerName = "Job Grade"
                Case "steps"
                    headerName = "Steps"
                Case "date_hire"
                    headerName = "Date Hire"
                Case "date_assign"
                    headerName = "Date Assign"
                Case "date_regular"
                    headerName = "Date Regular"
                Case "basic_rate"
                    headerName = "Basic Rate"
                Case "basicrate_date"
                    headerName = "Basic Rate Date"
                Case "taxcode"
                    headerName = "Taxcode"
                Case "divname"
                    headerName = "Division"
                Case "division_date"
                    headerName = "Division Date"
                Case "deptname"
                    headerName = "Department"
                Case "dept_date"
                    headerName = "Department Date"
                Case "costname"
                    headerName = "Cost Center"
                Case "ccenter_date"
                    headerName = "Cost Center Date"
                Case "secname"
                    headerName = "Section"
                Case "grpname"
                    headerName = "Group"
                Case "area_description"
                    headerName = "Area"
                Case "bankcode"
                    headerName = "Bank Code"
                Case "acctno"
                    headerName = "Account #"
                Case "immediate_head"
                    headerName = "Immediate Head"
                Case "length_of_service"
                    headerName = "Lenght of Service"
                Case "paymode"
                    headerName = "Paymode"
                Case "cedula_number"
                    headerName = "Cedula #"
                Case "street_address"
                    headerName = "Street"
                Case "brgyname"
                    headerName = "Barangay"
                Case "cityname"
                    headerName = "City"
                Case "provname"
                    headerName = "Province"
                Case "country"
                    headerName = "Country"
                Case "zipcode"
                    headerName = "Zip Code"
                Case "mobile"
                    headerName = "Mobile"
                Case "tel_office"
                    headerName = "Telephone"
                Case "fax"
                    headerName = "Fax"
                Case "email_address"
                    headerName = "Email"
                Case "webpage"
                    headerName = "Web Page"
                Case "elementary"
                    headerName = "Elementary"
                Case "elem_honor"
                    headerName = "Elementary Honor"
                Case "pri_grad"
                    headerName = "Elemantary Year Graduated"
                Case "secondary"
                    headerName = "Secondary"
                Case "secon_honor"
                    headerName = "Secondary Honor"
                Case "sec_grad"
                    headerName = "Secondary Year Graduated"
                Case "edinstitution"
                    headerName = "College"
                Case "eddegree"
                    headerName = "College Degree"
                Case "edhonor"
                    headerName = "College Honor"
                Case "edyear_grad"
                    headerName = "College Year Graduated"
                Case "vcinstitution"
                    headerName = "Vocation"
                Case "vcvocation"
                    headerName = "Vocational Honor"
                Case "vcyear_grad"
                    headerName = "Vocational Year Graduated"
                Case Else
                    headerName = StrConv(field, VbStrConv.ProperCase)
            End Select
            reportParams.Add(New ReportParameter("Header" & (i + 1), headerName))
        Next

        ' Load report
        Dim reportForm As New drReportViewer()
        reportForm.ReportViewer1.Reset() ' <- Ensures clean slate

        reportParams.Add(New ReportParameter("paramCompany", ActiveCompanyName))
        reportParams.Add(New ReportParameter("paramAddress", ActiveCompanyAddress))
        reportParams.Add(New ReportParameter("paramContact", ActiveCompanyContact))
        reportParams.Add(New ReportParameter("paramTitle", "List of Employee"))

        ' For unique male count
        Dim uniqueMales = empData_.AsEnumerable() _
                            .Where(Function(r) r.Field(Of String)("gender") = "M") _
                            .Select(Function(r) r.Field(Of String)("IDNO")) _
                            .Distinct() _
                            .Count()

        ' For unique female count
        Dim uniqueFemales = empData_.AsEnumerable() _
                            .Where(Function(r) r.Field(Of String)("gender") = "F") _
                            .Select(Function(r) r.Field(Of String)("IDNO")) _
                            .Distinct() _
                            .Count()

        ' For total unique headcount
        Dim uniqueHeadcount = empData_.AsEnumerable() _
                            .Select(Function(r) r.Field(Of String)("IDNO")) _
                            .Distinct() _
                            .Count()

        If rbtnDataReport.Checked = True Then

            reportParams.Add(New ReportParameter("paramTotal1", "Total Male : " & uniqueMales))
            reportParams.Add(New ReportParameter("paramTotal2", "Total Female : " & uniqueFemales))
            reportParams.Add(New ReportParameter("paramTotal3", "Total Headcount : " & uniqueHeadcount))

            With reportForm.ReportViewer1
                .ProcessingMode = ProcessingMode.Local
                .LocalReport.ReportPath = Application.StartupPath & "\Designer\drCustomReport.rdlc"
                .LocalReport.DataSources.Clear()
                .LocalReport.DataSources.Add(New ReportDataSource("DataSet1", dtEmployee))
                .LocalReport.SetParameters(reportParams)
                .SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                .ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
                .ZoomPercent = 100
                .RefreshReport()
            End With
            reportForm.Show()
        Else 'XLSX
            GenerateCustomReportXLSX(dtEmployee, "Custom Report", selectedFields, uniqueMales, uniqueFemales, uniqueHeadcount)
        End If
        'Catch ex As Exception
        '    MessageBox.Show("An error occurred while generating the report: " & ex.Message)
        'End Try
    End Sub

    Private Sub cboDivision_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboDivision.SelectionChangeCommitted
        paramDiv = String.Empty
        paramDiv = GetColumnValue(cboDivision, 0)
        If ActiveCompany <> "" And paramDiv <> "" Then
            Call classComboBox.setCboDepartment(cboDepartment, Trim(cboDivision.Text))

            paramDiv = "'" & paramDiv & "'"
            Call classEmployee.LoadDivisionEmployee_(getDivisionEmployee.Copy, lvEmployee)

        End If
    End Sub

    Private Sub chkElementary_CheckedChanged(sender As Object, e As EventArgs) Handles chkElementary.CheckedChanged
        If chkElementary.Checked = True Then
            chkElementaryHonor.Enabled = True
            chkElementaryYear.Enabled = True
        Else
            chkElementaryHonor.Enabled = False
            chkElementaryYear.Enabled = False
        End If
    End Sub

    Private Sub chkSecondary_CheckedChanged(sender As Object, e As EventArgs) Handles chkSecondary.CheckedChanged
        If chkSecondary.Checked = True Then
            chkSecondaryHonor.Enabled = True
            chkSecondaryYear.Enabled = True
        Else
            chkSecondaryHonor.Enabled = False
            chkSecondaryYear.Enabled = False
        End If
    End Sub

    Private Sub chkCollege_CheckedChanged(sender As Object, e As EventArgs) Handles chkCollege.CheckedChanged
        If chkCollege.Checked = True Then
            chkCollegeHonor.Enabled = True
            chkCollegeYear.Enabled = True
            chkCollegeDegree.Enabled = True
        Else
            chkCollegeHonor.Enabled = False
            chkCollegeYear.Enabled = False
            chkCollegeDegree.Enabled = False
        End If
    End Sub

    Private Sub chkVocational_CheckedChanged(sender As Object, e As EventArgs) Handles chkVocational.CheckedChanged
        If chkVocational.Checked = True Then
            chkVocationalHonor.Enabled = True
            chkVocationalYear.Enabled = True
        Else
            chkVocationalHonor.Enabled = False
            chkVocationalYear.Enabled = False
        End If
    End Sub

    Private Sub chkGraduateStudies_CheckedChanged(sender As Object, e As EventArgs) Handles chkGraduateStudies.CheckedChanged
        If chkGraduateStudies.Checked = True Then
            chkGraduateStudiesHonor.Enabled = True
            chkGraduateStudiesYear.Enabled = True
            chkGraduateStudiesDegree.Enabled = True
        Else
            chkGraduateStudiesHonor.Enabled = False
            chkGraduateStudiesYear.Enabled = False
            chkGraduateStudiesDegree.Enabled = False
        End If
    End Sub

    Private Sub cboProvince_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboProvince.SelectionChangeCommitted
        paramProv = String.Empty
        paramProv = GetColumnValue(cboProvince, 1)
        If paramProv <> "" Then
            Call classComboBox.setCboCity(cboCity)
        End If
    End Sub

    Private Sub cboCity_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboCity.SelectionChangeCommitted
        paramCity = String.Empty
        paramCity = GetColumnValue(cboCity, 1)
        If paramCity <> "" Then
            classComboBox.setCboBarangay(cboBarangay)
        End If
    End Sub

    Private Sub dp1_ValueChanged(sender As Object, e As EventArgs) Handles dp1.ValueChanged
        dpDateHireFrom.Text = dp1.Value.ToShortDateString()
    End Sub

    Private Sub dp2_ValueChanged(sender As Object, e As EventArgs) Handles dp2.ValueChanged
        dpDateHireTo.Text = dp2.Value.ToShortDateString()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class