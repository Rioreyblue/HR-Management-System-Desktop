Imports System.IO
Imports System.Text
Imports ClosedXML.Excel
Imports Microsoft.VisualBasic.FileIO

Public Module modHrmaxFunctions
    Public Function GetSysID() As String
        Dim idStr As String = ""
        Dim dtime As DateTime = DateTime.Now
        Dim dtimeStr As String = String.Format("{0:hhmmss}", dtime)


        Dim sPrefix As String = ""
        Dim rdm As New Random()
        For i As Integer = 1 To 3 ' 3 Letters enough ?
            sPrefix &= ChrW(rdm.Next(65, 90))
        Next
        idStr = sPrefix & dtimeStr
        Return idStr
    End Function
    Public Function GetKeyDict(dict As Dictionary(Of String, String), value As String)
        Dim key As String = ""
        For Each pair As KeyValuePair(Of String, String) In dict
            If pair.Value = value Then
                key = pair.Key
            End If
        Next
        Return key
    End Function
    Public Function GetSex(sex As String) As String
        Dim code As String = ""
        Select Case sex
            Case "MALE"
                code = "M"
            Case "M"
                code = "MALE"
            Case "FEMALE"
                code = "F"
            Case "F"
                code = "FEMALE"
        End Select
        Return code
    End Function
    Public Function GetCivilStatus(stat As String) As String
        Dim code As String = ""

        Select Case stat
            Case "SINGLE"
                code = "1"
            Case "1"
                code = "SINGLE"
            Case "MARRIED"
                code = "2"
            Case "2"
                code = "MARRIED"
            Case "WIDOW"
                code = "3"
            Case "3"
                code = "WIDOW"
            Case "SEPARATED"
                code = "4"
            Case "4"
                code = "SEPARATED"
        End Select
        Return code
    End Function

    Public Function GetOptionType(option_type As String) As String
        Dim option_code As String = ""
        Select Case option_type

            Case "1"
                option_code = "Normal/Abnormal"
            Case "2"
                option_code = "Normal/Findings"
            Case "3"
                option_code = "Yes/No"
            Case "4"
                option_code = "Positive/Negative"
            Case "5"
                option_code = "Positive/Non-Reactive"
            Case "6"
                option_code = "Adequate/Defective"
            Case "7"
                option_code = "Left/Right"
            Case Else
                option_code = "None"
        End Select

        Return option_code
    End Function

    Public Function GetTransactionFlow(transaction_ As String) As String
        Dim transact_code As String = ""
        Select Case transaction_

            Case "ALW"
                transact_code = "Online Allowances Flow"
            Case "DC"
                transact_code = "Deduction Flow"
            Case "ES"
                transact_code = "HRMAXV16 Status Flow"
            Case "FE"
                transact_code = "Fixed Earnings Flow"
            Case "FL"
                transact_code = "Field Flow"
            Case "HV"
                transact_code = "Home Visitation Benefits Flow"
            Case "LV"
                transact_code = "Leave Flow"
            Case "LV_M"
                transact_code = "Leave Multiple"
            Case "OE"
                transact_code = "Other Earnings Flow"
            Case "OT"
                transact_code = "Overtime Flow"
            Case "SK"
                transact_code = "Schedule Flow"
            Case "TC"
                transact_code = "Time Correction Flow"
            Case "TR"
                transact_code = "Travel Flow"
            Case "UT"
                transact_code = "Undertime Flow"
            Case Else
                transact_code = "None"
        End Select

        Return transact_code
    End Function

    Public Function GetTranche(ctr As String) As String
        Dim newcode As String = ""

        Select Case ctr
            Case "1"
                newcode = "TRANCHE - 1"
            Case "2"
                newcode = "TRANCHE - 2"
            Case "3"
                newcode = "TRANCHE - 3"
            Case "4"
                newcode = "TRANCHE - 4"
            Case "5"
                newcode = "TRANCHE - 5"
            Case "6"
                newcode = "TRANCHE - 6"
            Case "7"
                newcode = "TRANCHE - 7"
            Case "8"
                newcode = "TRANCHE - 8"
            Case "9"
                newcode = "TRANCHE - 9"
            Case "10"
                newcode = "TRANCHE - 10"
            Case Else
                newcode = "None"
        End Select

        Return newcode


    End Function

    Public Function GetEducLevelCode(educLevel As String) As String
        Dim level As String = ""
        Select Case educLevel
            Case "Elementary"
                level = "1"
            Case "Secondary"
                level = "2"
            Case "College Level"
                level = "3"
            Case "College Graduate"
                level = "4"
            Case "Masteral"
                level = "5"
            Case "Doctorate"
                level = "6"
        End Select
        Return level
    End Function
    Public Function GetEducLevelDesc(educCode As String)
        Dim levelDesc As String = ""
        Select Case educCode
            Case "1"
                levelDesc = "Elementary"
            Case "2"
                levelDesc = "Secondary"
            Case "3"
                levelDesc = "College Level"
            Case "4"
                levelDesc = "College Graduate"
            Case "5"
                levelDesc = "Masteral"
            Case "6"
                levelDesc = "Doctorate"
        End Select
        Return levelDesc
    End Function
    Public Function GetEducStatCode(educStat) As String
        Dim stat As String = ""
        Select Case educStat
            Case "Currently Enrolled"
                stat = "1"
            Case "Undergrad"
                stat = "2"
            Case "Graduate"
                stat = "3"
        End Select
        Return stat
    End Function
    Public Function GetEducStatDesc(educStatCode) As String
        Dim statDesc As String = ""
        Select Case educStatCode
            Case "1"
                statDesc = "Currently Enrolled"
            Case "2"
                statDesc = "Undergrad"
            Case "3"
                statDesc = "Graduate"
        End Select
        Return statDesc
    End Function
    Public Function GetModuleValue(sex As String) As String
        Dim code As String = ""
        Select Case sex
            Case "1"
                code = "Employment"
            Case "2"
                code = "Timerecords"
            Case "3"
                code = "Benefits"
            Case "4"
                code = "Payroll"
            Case "5"
                code = "Administrator"
            Case "6"
                code = "Reports"
        End Select
        Return code
    End Function
















    Public Function ConvertBdayToDateFormat(dte As String) As String
        Dim finalDte As String = ""
        Dim firstTwoChar As String = dte.Substring(0, 2)
        Dim secondPart As String = dte.Substring(2, 2)
        Dim lastPart As String = dte.Substring(4, 4)
        finalDte = firstTwoChar + "/" + secondPart + "/" + lastPart
        Return finalDte
    End Function

    'PRES 2023 Added Functions
    Public Function isYNBoolean(ByVal data As Boolean) As String
        If data Then
            Return "Y"
        Else
            Return "N"
        End If
    End Function
    Public Function isYNString(ByVal data As String) As String
        If data = "Y" Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function isYesNoBoolean(ByVal data As Boolean) As String
        If data Then
            Return "YES"
        Else
            Return "NO"
        End If
    End Function

    Public Function isYesNoString(ByVal data As String) As String
        If data = "YES" Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function GenerateRandomPIN() As String
        Dim random As New Random()
        Dim pinBuilder As New StringBuilder()

        For i As Integer = 0 To 4 ' Generate 5 digits
            Dim randomNumber As Integer = random.Next(0, 10) ' Generate a random digit (0 to 9)
            pinBuilder.Append(randomNumber)
        Next
        Return pinBuilder.ToString()
    End Function

    Public Function FormatMobileNumber(ByVal phoneNumber As String) As String
        If phoneNumber.Length = 11 AndAlso phoneNumber.StartsWith("09") Then
            Return "+63 " & phoneNumber.Substring(1, 2) & "-" & phoneNumber.Substring(3, 3) & "-" & phoneNumber.Substring(6)
        Else
            Return "Invalid Phone number format"
        End If
    End Function

    Public Sub ResizeListviewColumns(ByVal lv As ListView)
        Dim totalWidth As Integer = lv.Width
        Dim columnCount As Integer = lv.Columns.Count

        If columnCount > 0 Then
            Dim columnWidth As Integer = totalWidth \ columnCount
            For Each column As ColumnHeader In lv.Columns
                column.Width = columnWidth
            Next
        End If
    End Sub


    'Pres : It will only be used if you are using the NxnControls of NxnListview August 8 ,2023
    Public Function IsCodeAlreadyUsed(codeToCheck As String, ByVal pIsinList As NxnControls.NxNListview) As Boolean
        For Each item As ListViewItem In pIsinList.Items
            Dim codeInListView As String = item.SubItems(0).Text
            If codeInListView = codeToCheck Then
                Return True ' Code already exists in the ListView
            End If
        Next
        Return False ' Code is not found in the ListView
    End Function

    'Images
    Public Sub getProfile_Image(ByVal pic As PictureBox, ByVal image_filename As String)
        Try
            Dim FilePath As String = "Employee_Files"
            Dim FileFoler As String = "Profile"
            Dim image_path As String = Path.Combine(ServerTxt & FilePath & "/" & FileFoler & "\" & image_filename)
            Dim localDirectory As String = Application.StartupPath & "\Downloads\" & FilePath & "\" & FileFoler
            Dim localPath As String = Path.Combine(localDirectory, Path.GetFileName(image_path))

            If Not Directory.Exists(localDirectory) Then
                Directory.CreateDirectory(localDirectory)
            End If

            If File.Exists(localPath) Then
                File.Delete(localPath)
            End If

            ' Download the new file
            Try
                My.Computer.Network.DownloadFile(image_path, localPath)
                ' Load the image into memory to avoid locking the file
                Dim imageBytes As Byte() = File.ReadAllBytes(localPath)
                Using ms As New MemoryStream(imageBytes)
                    Dim safeImage As New Bitmap(ms)
                    pic.Image = safeImage
                End Using
            Catch ex As Exception
                MessageBox.Show("Error downloading or loading the image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    'CSV
    Public Sub GenerateCustomReportXLSX(dtFilter As DataTable, fileName As String, selectedFields As List(Of String), ByVal ttlMale As Integer, ByVal ttlFemale As Integer, ByVal ttlHeadCount As Integer)
        Try
            ' Ensure the DataTable is not empty
            If dtFilter Is Nothing OrElse dtFilter.Rows.Count = 0 Then
                Throw New Exception("The DataTable is empty. Nothing to export.")
            End If

            ' Get the Downloads folder path
            Dim downloadsPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")

            ' Ensure the fileName ends with .xlsx
            If Not fileName.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase) Then
                fileName &= ".xlsx"
            End If

            ' Combine Downloads path and fileName
            Dim fullPath As String = Path.Combine(downloadsPath, fileName)

            ' Create a new workbook
            Using workbook As New XLWorkbook()
                ' Add a worksheet
                Dim worksheet = workbook.Worksheets.Add("Employees")

                Dim currentRow As Integer = 1

                ' Add custom headers (merge cells across all columns for better presentation)
                worksheet.Range(currentRow, 1, currentRow, dtFilter.Columns.Count).Merge().Value = ActiveCompanyName
                worksheet.Row(currentRow).Style.Font.Bold = True
                currentRow += 2 ' Leave one empty row after header

                worksheet.Range(currentRow, 1, currentRow, dtFilter.Columns.Count).Merge().Value = "List of Employee"
                worksheet.Row(currentRow).Style.Font.Bold = True
                currentRow += 2 ' Leave one empty row

                ' Add column headers
                For i As Integer = 0 To selectedFields.Count - 1
                    Dim field = selectedFields(i).ToLower()
                    Dim headerName As String

                    Select Case field
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

                    worksheet.Cell(currentRow, i + 1).Value = headerName
                    worksheet.Cell(currentRow, i + 1).Style.Font.Bold = True
                    worksheet.Cell(currentRow, i + 1).Style.Fill.BackgroundColor = XLColor.LightGray
                Next
                currentRow += 1

                ' Add rows
                For Each row As DataRow In dtFilter.Rows
                    For i As Integer = 0 To dtFilter.Columns.Count - 1
                        Dim value = If(IsDBNull(row(i)), "", row(i).ToString())
                        worksheet.Cell(currentRow, i + 1).Value = value
                    Next
                    currentRow += 1
                Next

                'Add Parameter Totals
                currentRow += 1
                worksheet.Cell(currentRow, 1).Value = "Total Male:"
                worksheet.Cell(currentRow, 2).Value = ttlMale
                currentRow += 1

                worksheet.Cell(currentRow, 1).Value = "Total Female:"
                worksheet.Cell(currentRow, 2).Value = ttlFemale
                currentRow += 1

                worksheet.Cell(currentRow, 1).Value = "Total Headcount:"
                worksheet.Cell(currentRow, 2).Value = ttlHeadCount


                ' Adjust columns to fit content
                worksheet.Columns().AdjustToContents()

                ' Save the workbook to file
                workbook.SaveAs(fullPath)
            End Using

            ' Open the file
            Process.Start("explorer.exe", fullPath)

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'DatagridView
    Public Sub GenerateCSVFromDataGridView(dgv As DataGridView, fileName As String)
        Try
            ' Ensure the DataGridView is not empty
            If dgv Is Nothing OrElse dgv.Rows.Count = 0 Then
                Throw New Exception("The DataGridView is empty. Nothing to export.")
            End If

            ' Get the Downloads folder path
            Dim downloadsPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")

            ' Ensure the fileName ends with .csv
            If Not fileName.EndsWith(".csv", StringComparison.OrdinalIgnoreCase) Then
                fileName &= ".csv"
            End If

            ' Combine Downloads path and fileName
            Dim fullPath As String = Path.Combine(downloadsPath, fileName)

            ' Create a StringBuilder to hold the CSV data
            Dim csvBuilder As New StringBuilder()

            ' Add custom headers
            csvBuilder.AppendLine(QuoteIfNeeded(ActiveCompanyName))
            csvBuilder.AppendLine()
            csvBuilder.AppendLine("Payroll Register")
            csvBuilder.AppendLine()

            ' Add column headers from DataGridView
            Dim columnHeaders = String.Join(",", dgv.Columns.Cast(Of DataGridViewColumn)().Where(Function(c) c.Visible).Select(Function(col) col.HeaderText))
            csvBuilder.AppendLine(columnHeaders)

            ' Add rows
            For Each row As DataGridViewRow In dgv.Rows
                If Not row.IsNewRow Then ' Skip the empty new row
                    Dim fields = String.Join(",", row.Cells.Cast(Of DataGridViewCell)().Where(Function(c) c.OwningColumn.Visible).Select(Function(cell) QuoteIfNeeded(cell.Value?.ToString())))
                    csvBuilder.AppendLine(fields)
                End If
            Next

            ' Write to the file
            File.WriteAllText(fullPath, csvBuilder.ToString(), Encoding.UTF8)
            Process.Start("explorer.exe", fullPath)
            'MessageBox.Show($"CSV file generated successfully at {fullPath}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Helper function to quote fields if needed
    Private Function QuoteIfNeeded(field As String) As String
        If field Is Nothing Then field = ""
        If field.Contains(",") OrElse field.Contains("""") OrElse field.Contains(vbCrLf) Then
            field = """" & field.Replace("""", """""") & """"
        End If
        Return field
    End Function
    'Private Function QuoteIfNeeded(value As String) As String
    '    ' Quote the value if it contains a comma, quote, or newline
    '    If value.Contains(",") OrElse value.Contains("""") OrElse value.Contains(Environment.NewLine) Then
    '        value = $"""{value.Replace("""", """""")}"""
    '    End If
    '    Return value
    'End Function

    ' Function to load CSV data into a DataTable
    Public Function LoadCSV(filePath As String) As DataTable
        Dim dt As New DataTable()

        Try
            ' Initialize TextFieldParser
            Using parser As New TextFieldParser(filePath)
                parser.TextFieldType = FieldType.Delimited
                parser.SetDelimiters(",")

                ' Read header row
                If Not parser.EndOfData Then
                    Dim headers() As String = parser.ReadFields()
                    For Each header As String In headers
                        dt.Columns.Add(header.ToString.ToUpper().Trim())
                    Next
                End If

                ' Read data rows
                While Not parser.EndOfData
                    Dim fields() As String = parser.ReadFields()
                    dt.Rows.Add(fields)
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Error reading CSV: " & ex.Message)
        End Try

        Return dt
    End Function

    Public Sub GroupAccessPolicy(ByVal grpcode_ As String, ByVal formid_ As String)
        Dim dtFilter() As DataRow = getUserGroupPolicy.Select("grpcode='" & grpcode_ & "' and formid = '" & formid_ & "' ")
        If dtFilter.Length > 0 Then
            For Each rrow In dtFilter
                If rrow("xView").ToString = True Then
                    xView = "YES"
                Else
                    xView = "NO"
                End If
                If rrow("xAdd").ToString = True Then
                    xAdd = "YES"
                Else
                    xAdd = "NO"
                End If
                If rrow("xDelete").ToString = True Then
                    xDelete = "YES"
                Else
                    xDelete = "NO"
                End If
                If rrow("xPrint").ToString = True Then
                    xPrint = "YES"
                Else
                    xPrint = "NO"
                End If
            Next
        End If
    End Sub

    'OJT
    ''' <summary>
    ''' Generic Reusable Excel Export Function
    ''' Exports a DataTable to Excel with customizable headers and footers
    ''' </summary>
    ''' <param name="dt">DataTable containing the data to export</param>
    ''' <param name="fileName">Name of the output file (without extension)</param>
    ''' <param name="reportTitle">Title of the report to display in Excel</param>
    ''' <param name="companyName">Company name to display in header</param>
    ''' <param name="companyAddress">Company address (optional)</param>
    ''' <param name="companyContact">Company contact info (optional)</param>
    ''' <param name="additionalParams">Optional dictionary for additional parameters to display</param>
    ''' <param name="footerText">Optional footer text (e.g., total records)</param>
    Public Sub GenerateExcelReport(dt As DataTable, fileName As String, reportTitle As String,
                                    Optional companyName As String = "",
                                    Optional companyAddress As String = "",
                                    Optional companyContact As String = "",
                                    Optional additionalParams As Dictionary(Of String, String) = Nothing,
                                    Optional footerText As String = "",
                                    Optional csvfile As String = "")
        Try
            ' Ensure the DataTable is not empty
            If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                Throw New Exception("The DataTable is empty. Nothing to export.")
            End If

            ' Get the Downloads folder path
            Dim downloadsPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")

            ' Ensure the fileName ends with .xlsx
            If Not fileName.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase) Then
                fileName &= ".xlsx"
            End If

            ' Combine Downloads path and fileName
            Dim fullPath As String = Path.Combine(downloadsPath, fileName)

            ' Create a new workbook
            Using workbook As New XLWorkbook()
                ' Add a worksheet
                Dim worksheet = workbook.Worksheets.Add("Report")

                Dim currentRow As Integer = 1

                ' Add Company Name Header (if provided)
                If Not String.IsNullOrEmpty(companyName) Then
                    worksheet.Range(currentRow, 1, currentRow, dt.Columns.Count).Merge().Value = companyName
                    worksheet.Row(currentRow).Style.Font.Bold = True
                    worksheet.Row(currentRow).Style.Font.FontSize = 14
                    worksheet.Row(currentRow).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                    currentRow += 1
                End If

                ' Add Company Address (if provided)
                If Not String.IsNullOrEmpty(companyAddress) Then
                    worksheet.Range(currentRow, 1, currentRow, dt.Columns.Count).Merge().Value = companyAddress
                    worksheet.Row(currentRow).Style.Font.FontSize = 10
                    worksheet.Row(currentRow).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                    currentRow += 1
                End If

                ' Add Company Contact (if provided)
                If Not String.IsNullOrEmpty(companyContact) Then
                    worksheet.Range(currentRow, 1, currentRow, dt.Columns.Count).Merge().Value = companyContact
                    worksheet.Row(currentRow).Style.Font.FontSize = 10
                    worksheet.Row(currentRow).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                    currentRow += 1
                End If

                ' Add spacing
                If Not String.IsNullOrEmpty(companyName) Then
                    currentRow += 1
                End If

                ' Add Report Title
                worksheet.Range(currentRow, 1, currentRow, dt.Columns.Count).Merge().Value = reportTitle
                worksheet.Row(currentRow).Style.Font.Bold = True
                worksheet.Row(currentRow).Style.Font.FontSize = 12
                worksheet.Row(currentRow).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                currentRow += 1

                ' Add spacing
                currentRow += 1

                ' Add additional parameters (if provided)
                If additionalParams IsNot Nothing Then
                    For Each param In additionalParams
                        worksheet.Cell(currentRow, 1).Value = param.Key
                        worksheet.Cell(currentRow, 1).Style.Font.Bold = True
                        worksheet.Cell(currentRow, 2).Value = param.Value
                        currentRow += 1
                    Next
                    currentRow += 1
                End If

                ' Add column headers from DataTable
                For i As Integer = 0 To dt.Columns.Count - 1
                    worksheet.Cell(currentRow, i + 1).Value = dt.Columns(i).ColumnName
                    worksheet.Cell(currentRow, i + 1).Style.Font.Bold = True
                    worksheet.Cell(currentRow, i + 1).Style.Fill.BackgroundColor = XLColor.LightGray
                    worksheet.Cell(currentRow, i + 1).Style.Border.OutsideBorder = XLBorderStyleValues.Thin
                Next
                currentRow += 1


                ' Add data rows
                If csvfile = "1" Then
                    For Each row As DataRow In dt.Rows
                        For i As Integer = 0 To dt.Columns.Count - 1
                            Dim value = If(IsDBNull(row(i)), "", row(i).ToString())
                            worksheet.Cell(currentRow, i + 1).Value = value
                            worksheet.Cell(currentRow, i + 1).Style.Border.OutsideBorder = XLBorderStyleValues.Thin
                        Next
                        currentRow += 1
                    Next
                Else
                    ' DATA ROWS
                    ' Track previous row values for blanking duplicates
                    Dim previousRowValues(dt.Columns.Count - 1) As String
                    For i As Integer = 0 To previousRowValues.Length - 1
                        previousRowValues(i) = ""
                    Next

                    For Each dr As DataRow In dt.Rows
                        For i As Integer = 0 To dt.Columns.Count - 1
                            Dim currentValue As String
                            If IsDBNull(dr(i)) Then
                                currentValue = ""
                            Else
                                currentValue = dr(i).ToString()
                            End If

                            ' Blank out consecutive duplicates for the first 4 columns only
                            ' (typically DIVCODE, DEPTCODE, ID #, NAME)
                            If i < 4 AndAlso currentValue = previousRowValues(i) AndAlso currentValue <> "" Then
                                worksheet.Cell(currentRow, i + 1).Value = ""
                                worksheet.Cell(currentRow, i + 1).Style.Border.OutsideBorder = XLBorderStyleValues.Thin
                            Else
                                worksheet.Cell(currentRow, i + 1).Value = currentValue
                                worksheet.Cell(currentRow, i + 1).Style.Border.OutsideBorder = XLBorderStyleValues.Thin
                                previousRowValues(i) = currentValue
                            End If
                        Next
                        currentRow += 1
                    Next
                End If

                ' Add footer text (if provided)
                If Not String.IsNullOrEmpty(footerText) Then
                    currentRow += 1
                    worksheet.Cell(currentRow, 1).Value = footerText
                    worksheet.Cell(currentRow, 1).Style.Font.Bold = True
                End If

                ' Adjust columns to fit content
                worksheet.Columns().AdjustToContents()

                ' Save the workbook to file
                workbook.SaveAs(fullPath)
            End Using

            ' Open the file
            Process.Start("explorer.exe", fullPath)

            ' Show success message
            'MessageBox.Show($"Excel file generated successfully!{vbCrLf}File saved to: {fullPath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show($"Error generating Excel report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function ConvertPaymode(val As Object) As String
        Dim pmode As String = If(val Is Nothing, "", val.ToString())
        Select Case pmode
            Case "1"
                Return "DAILY"
            Case "2"
                Return "MONTHLY"
            Case "3"
                Return "PIECE WORK"
            Case "4"
                Return "MULTIPLE"
            Case "5"
                Return "HOURLY"
            Case "6"
                Return "TRANSPO"
            Case Else
                Return ""
        End Select
    End Function

End Module
