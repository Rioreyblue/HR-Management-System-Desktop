Public Class classComboBox
    'Pres 06/07/2024

#Region "Hiring"
    Public Shared Sub setCboBatch(ByVal pCboBox As NxnControls.NxNComboBox)
        Dim code = 1
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("code", GetType(String))
            For i = code To 100
                .Rows.Add(i)
            Next
        End With

        With pCboBox
            .DataSource = pDTable
            .DisplayMember = "code"
            .ValueMember = "code"
            .ColumnNum = 0
            .ColumnWidth = pCboBox.Width
            .DropDownSize = pCboBox.Width
            '.Text = ""
        End With
    End Sub
    Public Shared Sub setCboExam(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = ConvertListToDataTable(GetExaminationMain())
            .DisplayMember = "JobCode"
            .ValueMember = "Description"
            .ColumnNum = 1
            .ColumnWidth = "100|500"
            .DropDownSize = 600
            .Text = ""
        End With
    End Sub
    Public Shared Sub setCboJobMaintenance(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = ConvertListToDataTable(GetMaintenanceJobs())
            .DisplayMember = "JobCode"
            .ValueMember = "JobTitle"
            .ColumnNum = 1
            .ColumnWidth = "100|500"
            .DropDownSize = 600
            .Text = ""
        End With
    End Sub
    Public Shared Sub setCboExaminationSituation(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = ConvertListToDataTable(GetExaminationSituation())
            .DisplayMember = "SitKeyCtr"
            .ValueMember = "Situation"
            .ColumnNum = 1
            .ColumnWidth = "100|500"
            .DropDownSize = 600
            .Text = ""
        End With
    End Sub
#End Region

    'Employment

    Public Shared Sub setCboSex(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboSex.Copy
            .DisplayMember = "desc"
            .ValueMember = "code"
            .ColumnNum = 1
            .ColumnWidth = "-1|" & pCboBox.Width
            .DropDownSize = pCboBox.Width
            .Text = ""
        End With
    End Sub
    Public Shared Sub setCboCivilStatus(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboCivilStatus.Copy
            .DisplayMember = "desc"
            .ValueMember = "code"
            .ColumnNum = 1
            .ColumnWidth = "-1|" & pCboBox.Width
            .DropDownSize = pCboBox.Width
            .Text = ""
        End With
    End Sub
    Public Shared Sub setCboReligion(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboReligion().Copy
            .DisplayMember = "religion"
            .ValueMember = "religion"
            .ColumnNum = 0
            .ColumnWidth = 500
            .DropDownSize = 500
            .Text = ""
        End With
    End Sub
    Public Shared Sub setCboTranche(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboTranche.Copy
            .DisplayMember = "code"
            .ValueMember = "code"
            .ColumnNum = 1
            .ColumnWidth = "50|107"
            .DropDownSize = 157
            .Text = ""
        End With
    End Sub
    Public Shared Sub setCboCountry(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboCountry.Copy
            .DisplayMember = "countrycode"
            .ValueMember = "countryname"
            .ColumnNum = 1
            .ColumnWidth = "100 | 150"
            .DropDownSize = 250
            .Text = ""
        End With
    End Sub
    Public Shared Sub setCboProv(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboProvince.Copy
            .DisplayMember = "provid"
            .ValueMember = "provname"
            .ColumnNum = 1
            .ColumnWidth = "200|190"
            .DropDownSize = 300
            .Text = ""
        End With
    End Sub
    Public Shared Sub setCboCity(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboCity.Copy
            .DisplayMember = "cityid"
            .ValueMember = "cityname"
            .ColumnNum = 1
            .ColumnWidth = "200|100"
            .DropDownSize = 300
            .Text = ""
        End With
    End Sub
    Public Shared Sub setCboBarangay(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboBarangay.Copy
            .DisplayMember = "brgyid"
            .ValueMember = "brgyname"
            .ColumnNum = 1
            .ColumnWidth = "200|100"
            .DropDownSize = "300"
            .Text = ""
        End With
    End Sub
    Public Shared Sub setCboEmployee(ByVal pCboBox As NxnControls.NxNComboBox)
        Dim empData_ As DataTable = getEmployee.Copy()

        For Each row As DataRow In empData_.Rows
            row("fullname") = StrConv(row("fullname").ToString(), vbProperCase)
        Next

        Dim rrow As DataRow = empData_.NewRow
        empData_.Rows.InsertAt(rrow, 0)

        With pCboBox
            .DataSource = empData_
            .DisplayMember = "fullname"
            .ValueMember = "idno"
            .ColumnNum = 1
            .ColumnWidth = "100|300"
            .DropDownSize = 400
            .Text = ""
        End With

    End Sub
    Public Shared Sub setCboCompany(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getActiveCompany.Copy
            .DisplayMember = "keyctr"
            .ValueMember = "area_description"
            .ColumnNum = 2
            .ColumnWidth = "50|400|100"
            .DropDownSize = "550"
            .Text = ActiveCompany
        End With
    End Sub

    Public Shared Sub setCboDivision(ByVal pCboBox As NxnControls.NxNComboBox)
        Dim divData_ As DataTable = getCboDivision.Copy()
        With pCboBox
            .DataSource = divData_
            .DisplayMember = "divcode"
            .ValueMember = "divname"
            .ColumnNum = 1
            .ColumnWidth = "100|500"
            .DropDownSize = "600"
            .Text = ""
        End With
    End Sub
    Public Shared Sub setCboArea(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboArea.Copy
            .DisplayMember = "keyctr_"
            .ValueMember = "area_description"
            .ColumnNum = 1
            .ColumnWidth = "100|300"
            .DropDownSize = "400"
            .Text = "ALL"
        End With
    End Sub
    Public Shared Sub setCboDepartment(ByVal pCboBox As NxnControls.NxNComboBox, ByVal divcode As String)
        Dim deptData_ As DataTable
        Dim fRows_ As DataRow()
        If divcode = "ALL" Then
            fRows_ = getCboDepartment.Select()
        Else
            fRows_ = getCboDepartment.Select("divcode = '" & divcode & "'")
        End If
        If fRows_.Length > 0 Then
            deptData_ = fRows_.CopyToDataTable()
        Else
            deptData_ = getCboDepartment.Clone()
        End If
        With pCboBox
            .DataSource = deptData_
            .DisplayMember = "deptcode"
            .ValueMember = "deptname"
            .ColumnNum = 1
            .ColumnWidth = "100|300"
            .DropDownSize = "400"
            .Text = ""
        End With
    End Sub
    Public Shared Sub setCboSection(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboSection.Copy
            .DisplayMember = "seccode"
            .ValueMember = "secname"
            .ColumnNum = 1
            .ColumnWidth = "100|300"
            .DropDownSize = "400"
            .Text = ""
        End With
    End Sub
    Public Shared Sub setCboGroup(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboGroup.Copy
            .DisplayMember = "grpcode"
            .ValueMember = "grpname"
            .ColumnNum = 1
            .ColumnWidth = "100|300"
            .DropDownSize = "400"
            .Text = ""
        End With
    End Sub
    Public Shared Sub setCboCostCenter(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboCostCenter.Copy
            .DisplayMember = "costcode"
            .ValueMember = "costname"
            .ColumnNum = 1
            .ColumnWidth = "100|300"
            .DropDownSize = "400"
            .Text = ""
        End With
    End Sub
    Public Shared Sub setCboJobLevel(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboJobLevel.Copy
            .DisplayMember = "jlevelcode"
            .ValueMember = "jlevelname"
            .ColumnNum = 1
            .ColumnWidth = "100|300"
            .DropDownSize = "400"
            .Text = ""
        End With
    End Sub
    Public Shared Sub setCboJobType(ByVal pCboBox As NxnControls.NxNComboBox)
        Dim jtypeData_ As DataTable = getCboJobType.Copy()

        For Each row As DataRow In jtypeData_.Rows
            row("jtypename") = StrConv(row("jtypename").ToString(), vbProperCase)
        Next

        With pCboBox
            .DataSource = jtypeData_
            .DisplayMember = "jtypecode"
            .ValueMember = "jtypename"
            .ColumnNum = 2
            .ColumnWidth = "100|300|-1"
            .DropDownSize = "400"
            .Text = ""
        End With
    End Sub
    Public Shared Sub setCboJobStatus(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboJobStatus.Copy
            .DisplayMember = "jstatuscode"
            .ValueMember = "jstatusname"
            .ColumnNum = 2
            .ColumnWidth = "100|300|-1"
            .DropDownSize = "400"
            .Text = ""
        End With
    End Sub
    'payslip
    Public Shared Sub setCboPaySlipCutOff(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboPaySlipCutOff.Copy
            .DisplayMember = "cutoff"
            .ValueMember = "cutoff"
            .ColumnNum = 3
            .ColumnWidth = "100|200|100|300"
            .DropDownSize = "600"
            .Text = ""
        End With
    End Sub
    Public Shared Sub setCboStatus(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboStatus.Copy
            .DisplayMember = "desc"
            .ValueMember = "desc"
            .ColumnNum = 0
            .ColumnWidth = "100|300"
            .DropDownSize = "400"
            .Text = "ALL"
        End With
    End Sub
    Public Shared Sub setCboPosition(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboPosition.Copy
            .DisplayMember = "pcode"
            .ValueMember = "description"
            .ColumnNum = 1
            .ColumnWidth = "100|300"
            .DropDownSize = "400"
            .Text = ""
        End With
    End Sub

    Public Shared Sub setCboPositionCategory(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboPositionCategory.Copy
            .DisplayMember = "catcode"
            .ValueMember = "description"
            .ColumnNum = 1
            .ColumnWidth = "50|300"
            .DropDownSize = "350"
            .Text = ""
        End With
    End Sub
    Public Shared Sub setCboPositionStatus(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboPositionStatus.Copy
            .DisplayMember = "pcode"
            .ValueMember = "description"
            .ColumnNum = 1
            .ColumnWidth = "100|300"
            .DropDownSize = "400"
            .Text = ""
        End With
    End Sub

    Public Shared Sub setCboSalarySchedule(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = GetCboSalSched.Copy
            .DisplayMember = "scode"
            .ValueMember = "scode"
            .ColumnNum = 0
            .ColumnWidth = pCboBox.Width
            .DropDownSize = pCboBox.Width
            .Text = ""
        End With
    End Sub
    Public Shared Sub setCboNumber(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboNumber.Copy
            .DisplayMember = "code"
            .ValueMember = "code"
            .ColumnNum = 0
            .ColumnWidth = pCboBox.Width
            .DropDownSize = pCboBox.Width
            '.Text = ""
        End With
    End Sub
    Public Shared Sub setCboYear(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboYear()
            .DisplayMember = "code"
            .ValueMember = "code"
            .ColumnNum = 0
            .ColumnWidth = pCboBox.Width
            .DropDownSize = pCboBox.Width
            '.Text = ""
        End With
    End Sub
    Public Shared Sub setCboPaymode(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboPaymode.Copy
            .DisplayMember = "desc"
            .ValueMember = "code"
            .ColumnNum = 1
            .ColumnWidth = "-1|" & pCboBox.Width
            .DropDownSize = pCboBox.Width
        End With
    End Sub
    Public Shared Sub setCboTaxCode(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboTaxCode.Copy
            .DisplayMember = "desc"
            .ValueMember = "code"
            .ColumnNum = 1
            .ColumnWidth = "-1|" & pCboBox.Width
            .DropDownSize = pCboBox.Width
        End With
    End Sub
    Public Shared Sub setCboJobGrading(ByVal pCboBox As NxnControls.NxNComboBox)
        Dim jgradeData_ As DataTable = GetCboJobGrading.Copy()

        For Each row As DataRow In jgradeData_.Rows
            row("jgradename") = StrConv(row("jgradename").ToString(), vbProperCase)
        Next
        With pCboBox
            .DataSource = jgradeData_
            .DisplayMember = "jgradecode"
            .ValueMember = "jgradename"
            .ColumnNum = 1
            .ColumnWidth = "100|300"
            .DropDownSize = "400"
            .Text = ""
        End With
    End Sub
    Public Shared Sub setCboJobSteps(ByVal pCboBox As NxnControls.NxNComboBox)
        Dim jstepsData_ As DataTable = getCboJobSteps.Copy()

        For Each row As DataRow In jstepsData_.Rows
            row("stepname") = StrConv(row("stepname").ToString(), vbProperCase)
        Next

        With pCboBox
            .DataSource = jstepsData_
            .DisplayMember = "stepcode"
            .ValueMember = "stepname"
            .ColumnNum = 1
            .ColumnWidth = "100|300"
            .DropDownSize = 400
            .Text = ""
        End With
    End Sub
    Public Shared Sub setCboBank(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboBank.Copy
            .DisplayMember = "bankcode"
            .ValueMember = "bankname"
            .ColumnNum = 1
            .ColumnWidth = "100|300"
            .DropDownSize = 400
            .Text = ""
        End With
    End Sub

    Public Shared Sub setCboTermYear(ByVal pCboBox As NxnControls.NxNComboBox)
        Dim code = 1
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("code", GetType(String))
            For i = code To 30
                .Rows.Add(i)
            Next
        End With

        With pCboBox
            .DataSource = pDTable
            .DisplayMember = "code"
            .ValueMember = "code"
            .ColumnNum = 0
            .ColumnWidth = pCboBox.Width
            .DropDownSize = pCboBox.Width
            '.Text = ""
        End With
    End Sub

    Public Shared Sub setCboCTCIssue(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboCTCIssue.Copy
            .DisplayMember = "cedula_place"
            .ValueMember = "cedula_place"
            .ColumnNum = 0
            .ColumnWidth = 400
            .DropDownSize = 400
            .Text = ""
        End With
    End Sub

    'MAINTENANCE FORMS
    Public Shared Sub setCboModule(ByVal pCboBox As NxnControls.NxNComboBox)
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("desc", GetType(String))
            .Columns.Add("code", GetType(String))
            .Rows.Add("", "")
            .Rows.Add("Employment", "1")
            .Rows.Add("TimeRecords", "2")
            .Rows.Add("Benefits", "3")
            .Rows.Add("Payroll", "4")
            .Rows.Add("Administrator", "5")
            .Rows.Add("Reports", "6")
        End With

        With pCboBox
            .DataSource = pDTable.Copy
            .DisplayMember = "desc"
            .ValueMember = "code"
            .ColumnNum = 1
            .ColumnWidth = pCboBox.Width & "|50"
            .DropDownSize = pCboBox.Width
            .Text = ""
        End With
    End Sub

    Public Shared Sub setCboForms(ByVal pCboBox As NxnControls.NxNComboBox)
        Dim formsData_ As DataTable = getForms.Copy()

        For Each row As DataRow In formsData_.Rows
            row("formid") = row("formid")
            row("formname") = StrConv(row("formname").ToString(), vbProperCase)
        Next

        With pCboBox
            .DataSource = formsData_
            .DisplayMember = "formid"
            .ValueMember = "formname"
            .ColumnNum = 2
            .ColumnWidth = "-1|100|300"
            .DropDownSize = 400
            .Text = ""
        End With
    End Sub

    'USER POLICY
    Public Shared Sub setCboPolicyForms(ByVal pCboBox As NxnControls.NxNComboBox, ByVal mod_ As String)
        Dim formsData_ As DataTable = getPolicyForms(mod_).Copy()

        For Each row As DataRow In formsData_.Rows
            row("formid") = row("formid")
            row("formname") = StrConv(row("formname").ToString(), vbProperCase)
        Next

        With pCboBox
            .DataSource = formsData_
            .DisplayMember = "formid"
            .ValueMember = "formname"
            .ColumnNum = 2
            .ColumnWidth = "-1|100|300"
            .DropDownSize = 400
            .Text = ""
        End With
    End Sub
    Public Shared Sub setCboPolicyGroup(ByVal pCboBox As NxnControls.NxNComboBox)
        Dim formsData_ As DataTable = getUserGroup.Copy()

        For Each row As DataRow In formsData_.Rows
            row("grpcode") = row("grpcode")
            row("description") = StrConv(row("description").ToString(), vbProperCase)
        Next

        Dim rrow As DataRow = formsData_.NewRow
        formsData_.Rows.InsertAt(rrow, 0)

        With pCboBox
            .DataSource = formsData_
            .DisplayMember = "grpcode"
            .ValueMember = "description"
            .ColumnNum = 1
            .ColumnWidth = "100|300"
            .DropDownSize = 400
            .Text = ""
        End With
    End Sub

    Public Shared Sub setCboUserPolicyGroup(ByVal pCboBox As NxnControls.NxNComboBox)
        Dim formsData_ As DataTable = getUserGroupPolicy.Copy()

        For Each row As DataRow In formsData_.Rows
            row("grpcode") = row("grpcode")
            row("description") = StrConv(row("description").ToString(), vbProperCase)
        Next

        Dim rrow As DataRow = formsData_.NewRow
        formsData_.Rows.InsertAt(rrow, 0)

        With pCboBox
            .DataSource = formsData_
            .DisplayMember = "grpcode"
            .ValueMember = "description"
            .ColumnNum = 1
            .ColumnWidth = "100|300"
            .DropDownSize = 400
            .Text = ""
        End With
    End Sub

    Public Shared Sub setCboPolicyStatus(ByVal pCboBox As NxnControls.NxNComboBox)
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("desc", GetType(String))
            .Rows.Add("")
            .Rows.Add("Active")
            .Rows.Add("Suspended")
            .Rows.Add("Expired")
        End With

        With pCboBox
            .DataSource = pDTable.Copy
            .DisplayMember = "desc"
            .ValueMember = "desc"
            .ColumnNum = 0
            .ColumnWidth = pCboBox.Width
            .DropDownSize = pCboBox.Width
            .Text = ""
        End With
    End Sub

#Region "Payroll"
    Public Shared Sub setCboActiveCutoffListing(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboActiveCutOffListing()
            .DisplayMember = "cutoff"
            .ValueMember = "cutoff"
            .ColumnNum = 3
            .ColumnWidth = "100|100|100|200"
            .DropDownSize = "500"
        End With
    End Sub
    Public Shared Sub setCboEmployeeStatus(ByVal pCboBox As NxnControls.NxNComboBox)
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("desc", GetType(String))
            .Rows.Add("ACTIVE")
            .Rows.Add("INACTIVE")
        End With

        With pCboBox
            .DataSource = pDTable.Copy
            .DisplayMember = "desc"
            .ValueMember = "desc"
            .ColumnNum = 0
            .ColumnWidth = pCboBox.Width
            .DropDownSize = pCboBox.Width
            .Text = ""
        End With
    End Sub
    Public Shared Sub setCboCutoff_wProcess(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboCutOff_wProcess.Copy
            .DisplayMember = "cutoff"
            .ValueMember = "cutoff"
            .ColumnNum = 3
            .ColumnWidth = "100|100|100|200"
            .DropDownSize = "500"
        End With
    End Sub
    Public Shared Sub setCboDeductions(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboDeductions_Code.Copy()
            .DisplayMember = "ddctcode"
            .ValueMember = "description"
            .ColumnNum = 4
            .ColumnWidth = "100|300|100|100|100"
            .DropDownSize = 700
            .Text = ""
        End With
    End Sub
    Public Shared Sub setCboFrequent(ByVal pCboBox As NxnControls.NxNComboBox)
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("desc", GetType(String))
            .Columns.Add("code", GetType(String))
            .Rows.Add("", "")
            .Rows.Add("0", "Always")
            .Rows.Add("1", "1st Cutoff of the Month")
            .Rows.Add("2", "2nd Cutoff of the Month")
            .Rows.Add("3", "1st Week")
            .Rows.Add("4", "2nd Week")
            .Rows.Add("5", "3rd Week")
            .Rows.Add("6", "4th Week")
            .Rows.Add("7", "5th Week")
        End With

        With pCboBox
            .DataSource = pDTable.Copy
            .DisplayMember = "desc"
            .ValueMember = "code"
            .ColumnNum = 1
            .ColumnWidth = "50|250"
            .DropDownSize = 300
            .Text = ""
        End With
    End Sub

    Public Shared Sub setCboLoanType(ByVal pCboBox As NxnControls.NxNComboBox)
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("desc", GetType(String))
            .Columns.Add("code", GetType(String))
            .Rows.Add("", "")
            .Rows.Add("Salary", "S")
            .Rows.Add("Calamity", "C")
            .Rows.Add("Emergency", "E")
        End With

        With pCboBox
            .DataSource = pDTable.Copy
            .DisplayMember = "desc"
            .ValueMember = "code"
            .ColumnNum = 1
            .ColumnWidth = pCboBox.Width & "|-1"
            .DropDownSize = pCboBox.Width
            .Text = ""
        End With
    End Sub

#End Region
#Region "Timekeeping"
    Public Shared Sub setCboCutoff(ByVal pCboBox As NxnControls.NxNComboBox, ByVal process_year As String)

        Dim dtCutoff() As DataRow = getCboActiveCutOffListing.Select("cutoff like '*" & process_year & "*' ")
        If dtCutoff.Length > 0 Then
            ' Create a new DataTable and define its columns
            Dim cutoffData_ As New DataTable()
            cutoffData_.Columns.Add("cutoff", GetType(String))
            cutoffData_.Columns.Add("datestart", GetType(String))
            cutoffData_.Columns.Add("dateend", GetType(String))
            cutoffData_.Columns.Add("cutoff_date", GetType(String))

            ' Populate the new DataTable with rows from dtCutoff
            For Each row In dtCutoff
                cutoffData_.Rows.Add(row("cutoff"), row("datestart"), row("dateend"), row("cutoff_date"))
            Next

            Dim rrow As DataRow = cutoffData_.NewRow
            cutoffData_.Rows.InsertAt(rrow, 0)

            With pCboBox
                .DataSource = cutoffData_
                .DisplayMember = "cutoff"
                .ValueMember = "cutoff"
                .ColumnNum = 3
                .ColumnWidth = "100|100|100|200"
                .DropDownSize = "500"
            End With

        End If
    End Sub
#End Region
End Class
