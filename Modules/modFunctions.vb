Imports NxnControls
Imports NXNParsing

Public Module modFunctions
    Public WorkingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
    Public ReTryCnt As Integer

    Private ActiveFrm As String = String.Empty
    Private jStr_Input As String = "[]"
    Private ws As New WSConnection
    Private Token As String = String.Empty

    'DC: 06/05/2018
    'Calling a function StrCollData() 
    ' * when you are using DataGridView with binding to datasource:     StrCollData(your DataGridView1.DataSource)   return as string value
    ' * when you are using DataGridView without binding to datasource:  StrCollData(your DataGridView1.GetDataTable) return as string value
    ' * when you are using ListView:                                    StrCollData(your ListView1.GetDataTable)     return as string value
    ' * when you are using DataTable:                                   StrCollData(your DataTable)                  return as string value

    Public Function StrCollData(ByVal dtStrCollData As DataTable) As String
        StrCollData = String.Empty
        Dim cCnt As Integer = CInt(dtStrCollData.Columns.Count)
        Dim StrSptr As String = "|"
        Dim fLoop As Boolean = True
        Try
            With dtStrCollData
                For i As Integer = 0 To .Rows.Count - 1 Step 1
                    For j As Integer = 0 To .Columns.Count - 1 Step 1
                        If NotNull(dtStrCollData, i) Then
                            If fLoop Then
                                StrCollData = Trim(.Rows(i).Item(j).ToString)
                                fLoop = False
                            Else
                                StrCollData = StrCollData & StrSptr & Trim(.Rows(i).Item(j).ToString)
                            End If
                        End If
                    Next
                Next
            End With
            StrCollData = cCnt.ToString & "#" & StrCollData.ToString
        Catch ex As Exception
            StrCollData = String.Empty
        End Try
        'string return values
    End Function

    'DC: 06/08/2018
    'Calling a function GetMonthName() 
    ' * MultiColumnComboBox..DataSource = GetMonthName()                                              return as datatable

    Public Function GetMonthName() As DataTable
        Dim DTable As New DataTable
        Try
            With DTable
                .Columns.Add("Month", GetType(String))
                .Columns.Add("MonthName", GetType(String))
                .Rows.Add(String.Empty, String.Empty)
                For i As Integer = 1 To 12 Step 1
                    .Rows.Add(i.ToString.PadLeft(2, Convert.ToChar("0")), MonthName(i, False))
                Next
            End With
        Catch ex As Exception
            Return DTable
        End Try
        Return DTable
    End Function

    Public Function NotNull(ByVal pDT As DataTable, ByVal pRow As Integer) As Boolean
        Dim _NotNull As Boolean = True
        Dim ChkStr As String = String.Empty
        With pDT
            For pCol As Integer = 0 To .Columns.Count - 1 Step 1
                ChkStr = ChkStr & Trim(.Rows(pRow).Item(pCol).ToString)
            Next
            If String.IsNullOrEmpty(ChkStr) Then _NotNull = False
        End With
        Return _NotNull
    End Function

    'DC: 06/08/2018
    'Calling a function GetColumnValue() 
    ' * GetColumnValue(your MultiColumnComboBox, MultiColumnComboBox Column)                         return as string value

    'Public Function GetColumnValue(ByVal combobox As ComboBox, ByVal column As Integer) As String
    '    Try
    '        GetColumnValue = DirectCast(combobox.SelectedItem, System.Data.DataRowView).Row.ItemArray(column).ToString()
    '    Catch ex As Exception
    '        GetColumnValue = String.Empty
    '    End Try
    'End Function

    Public Function GetColumnValue(ByVal combobox As ComboBox, ByVal column As Integer) As String
        Try
            If combobox.SelectedItem IsNot Nothing Then
                Dim selectedItem As System.Data.DataRowView = DirectCast(combobox.SelectedItem, System.Data.DataRowView)

                If selectedItem.Row.ItemArray.Length > column Then
                    Return selectedItem.Row.ItemArray(column).ToString()
                End If
            End If

            Return String.Empty
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

    Public Function IsInList(ByVal NXGcbo As ComboBox) As Boolean
        Dim InList As Boolean
        Dim cboIndex As Integer
        cboIndex = NXGcbo.FindString(NXGcbo.Text)
        If (cboIndex = -1) Then
            InList = False
        Else
            NXGcbo.SelectedIndex = cboIndex
            InList = True
        End If
        Return InList
    End Function
    Public Function SelectIntoDataTable(ByVal selectFilter As String, ByVal sourceDataTable As DataTable) As DataTable
        Dim newDataTable As DataTable = sourceDataTable.Clone
        Dim dataRows As DataRow() = sourceDataTable.Select(selectFilter)
        Dim typeDataRow As DataRow
        For Each typeDataRow In dataRows
            newDataTable.ImportRow(typeDataRow)
        Next
        Return newDataTable
    End Function

    Public Function GetColumnIndex(ByVal lvw As ListView, ByVal MouseX As Integer) As Integer

        Dim result As Integer = 0
        Dim ColW As New List(Of Integer)
        Dim Index As Integer = 0
        For Each col As ColumnHeader In lvw.Columns
            ColW.Add(col.Width)
            Dim X As Integer = 0
            For i As Integer = 0 To ColW.Count - 1
                X += ColW(i)
            Next
            If MouseX <= X Then
                result = Index
                Exit For
            End If
            Index += 1
        Next
        Return result
    End Function

    Public Function mValidate_Keypress(TxtBox As TextBox, sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Asc(vbBack) Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = Asc("-") Then
            If Len(TxtBox.Text) > 0 Then
                If TxtBox.Text.Count(Function(c As Char) c = "-") = 0 Then
                    e.Handled = True
                    TxtBox.Text = "-" + Trim(TxtBox.Text)
                    TxtBox.SelectionStart = Len(Trim(TxtBox.Text))
                Else
                    e.Handled = True
                End If
            Else
                e.Handled = True
            End If
        Else
            If Char.IsDigit(e.KeyChar) Or (Asc(e.KeyChar) = Asc(".")) And TxtBox.Text.Count(Function(c As Char) c = ".") = 0 Then e.Handled = False Else e.Handled = True
        End If
        Return String.Empty
    End Function

    Public Function mValidate_Keycode(TxtBox As TextBox, sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Asc(vbBack) Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = Asc("-") Then
            If Len(TxtBox.Text) > 0 Then
                If TxtBox.Text.Count(Function(c As Char) c = "-") = 0 Then
                    e.Handled = True
                    TxtBox.Text = "-" + Trim(TxtBox.Text)
                    TxtBox.SelectionStart = Len(Trim(TxtBox.Text))
                Else
                    e.Handled = True
                End If
            Else
                e.Handled = True
            End If
        Else
            If Char.IsDigit(e.KeyChar) Then e.Handled = False Else e.Handled = True
        End If
        Return String.Empty
    End Function
    Public Function mCalculateAge(ByVal birthDate As Date, ByVal curdate As Date) As String

        Try
            Dim mySpan As Int16 = CInt(curdate.Subtract(birthDate).TotalDays) 'CInt(Date.Now.Subtract(birthDate).TotalDays)
            Dim nowYear As Int16 = curdate.Year  'Date.Now.Year
            Dim nowMonth As Int16 = curdate.Month 'Date.Now.Month
            Dim birthYear As Int16 = birthDate.Year
            Dim birthMonth As Int16 = birthDate.Month

            Dim yearCount As Int16
            'For yearCount = Date.Now.Year To birthYear Step -1
            For yearCount = curdate.Year To birthYear Step -1
                If yearCount Mod 4 = 0 Then
                    Select Case True
                        Case yearCount = nowYear And nowMonth < 3
                        Case yearCount = birthYear And birthMonth > 2
                        Case Else
                            mySpan -= 1
                    End Select
                End If
            Next
            Dim myYears As Int16 = mySpan / 365
            Dim myDays As Int16 = mySpan - (myYears * 365)
            If myDays < 0 Then
                myYears -= 1
                myDays = 365 + myDays
            End If

            mCalculateAge = myYears.ToString  '"You are " & myYears & " years and " & myDays & " days old."

        Catch ex As Exception
            Return String.Empty
        End Try

    End Function

    Public Function TextboxValidate(sender As Object, e As KeyPressEventArgs, Txtbox As TextBox) As Boolean
        If Char.IsNumber(e.KeyChar) OrElse (Asc(e.KeyChar) = Asc(".")) OrElse e.KeyChar = Chr(Keys.Back) Then
            If Asc(e.KeyChar) = Asc(".") AndAlso Txtbox.Text.Count(Function(c As Char) c = ".") = 0 Then
                If Val(Len(Txtbox.Text)) + 1 = Val(Txtbox.MaxLength) Then
                    TextboxValidate = True
                Else
                    TextboxValidate = False
                End If
            ElseIf e.KeyChar = Chr(Keys.Back) Then
                TextboxValidate = False
            ElseIf Char.IsNumber(e.KeyChar) Then
                TextboxValidate = False
            Else
                TextboxValidate = True
            End If
        Else
            TextboxValidate = True
        End If
    End Function

    Public Sub ValidateCheckBoxes(checkbox As CheckBox)
        checkbox.ForeColor = IIf(checkbox.Checked, Color.Red, Color.Black) 'checkbox.ForeColor
    End Sub

    Public Function getCode(ByVal listview As ListView) As String
        Dim item As ListViewItem
        Dim tCode As String = String.Empty
        Dim fLoop As Boolean = True

        For Each item In listview.Items
            If item.Checked = True Then
                If fLoop Then
                    tCode = Trim(item.SubItems(1).Text)
                    fLoop = False
                Else
                    tCode = tCode & "|" & Trim(item.SubItems(1).Text)
                End If
            End If
        Next
        getCode = Trim(tCode)
    End Function

    Public Sub lvDrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs)
        Try
            Using brush As Brush = New SolidBrush(e.BackColor)
                e.Graphics.FillRectangle(brush, e.Bounds)
            End Using

            Dim bounds As Rectangle = e.Bounds

            bounds.Width -= 1
            bounds.Height -= 1

            e.Graphics.DrawRectangle(SystemPens.ControlDarkDark, bounds)

            bounds.Width -= 1
            bounds.Height -= 1

            e.Graphics.DrawLine(SystemPens.ControlLightLight, bounds.X, bounds.Y, bounds.Right, bounds.Y)
            e.Graphics.DrawLine(SystemPens.ControlLightLight, bounds.X, bounds.Y, bounds.X, bounds.Bottom)
            e.Graphics.DrawLine(SystemPens.ControlDark, (bounds.X + 1), bounds.Bottom, bounds.Right, bounds.Bottom)
            e.Graphics.DrawLine(SystemPens.ControlDark, bounds.Right, (bounds.Y + 1), bounds.Right, bounds.Bottom)

            'Text

            Dim textAlign As HorizontalAlignment = e.Header.TextAlign
            Dim headerFont As New Font("Arial", 8, FontStyle.Bold)
            Dim flags As TextFormatFlags = If((textAlign = HorizontalAlignment.Left), TextFormatFlags.GlyphOverhangPadding, If((textAlign = HorizontalAlignment.Center), TextFormatFlags.HorizontalCenter, TextFormatFlags.Right))

            flags = (flags Or TextFormatFlags.VerticalCenter)

            Dim text As String = e.Header.Text
            Dim width As Integer = TextRenderer.MeasureText("", e.Font).Width
            bounds = Rectangle.Inflate(e.Bounds, -width, 0)
            TextRenderer.DrawText(e.Graphics, [text], headerFont, bounds, Color.DarkBlue, flags)
        Finally
        End Try

    End Sub

    'DC: 02/13/2019
    'ReplaceSTR(String As Expression)
    Public Function ReplaceSTR(ByVal pString As String) As String
        Dim pStrValue As String = String.Empty
        pStrValue = Replace(Trim(pString), vbTab, "")
        pStrValue = Replace(Trim(pStrValue), "'", "''")
        pStrValue = Replace(Trim(pStrValue), vbCrLf, " ")
        pStrValue = Replace(Trim(pStrValue), vbLf, " ")
        pStrValue = Replace(Trim(pStrValue), vbNewLine, " ")

        'pStrValue = Replace(Trim(pString), vbTab, "")
        'pStrValue = Replace(Trim(pStrValue), "'", "''")
        'pStrValue = Replace(Trim(pStrValue), vbCrLf, "vbLf")
        'pStrValue = Replace(Trim(pStrValue), vbLf, "vbLf")
        'pStrValue = Replace(Trim(pStrValue), vbNewLine, "vbLf")

        If String.IsNullOrEmpty(pStrValue) Then pStrValue = ""
        Return pStrValue
    End Function

    'DC: 02/13/2019
    'ReplaceSTRNewLine(String As Expression)
    Public Function ReplaceSTRNewLine(ByVal pString As String) As String
        Dim pStrValue As String = String.Empty
        pStrValue = Replace(Trim(pString), "vbLf", vbNewLine)
        pStrValue = Replace(Trim(pStrValue), "vbLf", vbNewLine)
        pStrValue = Replace(Trim(pStrValue), "vbNewLine", vbNewLine)

        pStrValue = Replace(Trim(pStrValue), "\r\n", vbNewLine)

        If String.IsNullOrEmpty(pStrValue) Then pStrValue = ""
        Return pStrValue
    End Function

    'DC: 02/13/2019
    'ReplaceQuotes(String As Expression, Optional Integer As Optional Parameter)
    Public Function ReplaceQuotes(ByVal pString As String, Optional pDup As Integer = 2) As String
        Dim pStrValue As String = String.Empty
        Dim tmpStr As String = String.Empty

        If pDup > 2 Then
            For iDup As Integer = pDup To 2 Step -1
                tmpStr = StrDup(iDup, Chr(39))
                pString = Replace(pString, tmpStr, Chr(39))
            Next
            tmpStr = StrDup(2, Chr(39))
            pString = Replace(pString, tmpStr, Chr(39))
        Else
            tmpStr = StrDup(2, Chr(39))
            pString = Replace(pString, tmpStr, Chr(39))
        End If

        If pDup > 2 Then
            For iDup As Integer = pDup To 2 Step -1
                tmpStr = StrDup(iDup, Chr(34))
                pString = Replace(pString, tmpStr, Chr(92) & Chr(34))
            Next
            tmpStr = StrDup(2, Chr(34))
            pString = Replace(pString, tmpStr, Chr(92) & Chr(34))
        Else
            tmpStr = StrDup(1, Chr(34))
            pString = Replace(pString, tmpStr, Chr(92) & Chr(34))
        End If


        Return pString
    End Function

    'DC: 01/16/2020
    'CNewLine(String As Expression)
    Public Function CNewLine(ByVal pString As String) As String
        Dim pStrValue As String = String.Empty
        Dim pNewLine As String = "\r\n"
        pStrValue = Replace(Trim(pString), vbCrLf, "\r\n")
        pStrValue = Replace(Trim(pStrValue), vbLf, "\r\n")
        pStrValue = Replace(Trim(pStrValue), vbNewLine, "\r\n")
        If String.IsNullOrEmpty(pStrValue) Then pStrValue = ""
        Return pStrValue
    End Function

    'DC: 01/16/2020
    'ValidateString(String As Expression)

    Public Function ValidateString(ByVal pString As String) As String
        Dim pStrValue As String = String.Empty
        pStrValue = Replace(Trim(pString), vbTab, "")
        pStrValue = Replace(Trim(pStrValue), "'", "")
        pStrValue = Replace(Trim(pStrValue), """", "")
        pStrValue = Replace(Trim(pStrValue), vbCrLf, "")
        pStrValue = Replace(Trim(pStrValue), vbLf, "")
        pStrValue = Replace(Trim(pStrValue), vbNewLine, "")
        pStrValue = UCase(Trim(pStrValue))
        If String.IsNullOrEmpty(pStrValue) Then pStrValue = ""
        Return pStrValue
    End Function

    'DC: 03/14/2023
    'ValidateText(String As Expression)

    Public Function ValidateText(ByVal pString As String) As String
        Dim pStrValue As String = String.Empty
        pStrValue = Replace(Trim(pString), vbTab, "")
        pStrValue = Replace(Trim(pStrValue), "'", "")
        pStrValue = Replace(Trim(pStrValue), """", "")
        pStrValue = Replace(Trim(pStrValue), vbCrLf, "")
        pStrValue = Replace(Trim(pStrValue), vbLf, "")
        pStrValue = Replace(Trim(pStrValue), vbNewLine, "")
        If String.IsNullOrEmpty(pStrValue) Then pStrValue = ""

        ' Ensure the first letter is uppercase
        If Not String.IsNullOrEmpty(pStrValue) Then
            pStrValue = pStrValue.Substring(0, 1).ToUpper() + pStrValue.Substring(1)
        End If

        Return pStrValue
    End Function

    'DC: 02/13/2019
    'isValidEmailAddress(String As EmailAddress, String As Reference)
    Public Function isValidEmailAddress(ByVal emailAddress As String, ByRef errorMessage As String) As Boolean
        If emailAddress.Length = 0 Then
            errorMessage = "E-mail address is required."
            Return False
        End If
        If emailAddress.IndexOf("@") > -1 Then
            If (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@")) AndAlso emailAddress.Split(".").Length > 0 AndAlso emailAddress.Split(".")(1) <> "" Then
                errorMessage = ""
                Return True
            End If
        End If
        errorMessage = "E-mail address is not Valid, Email must contain @ !"
        Return False
    End Function

    'DC: 02/13/2019
    'CheckURL(String As URL)
    Public Function CheckURL(ByVal HostAddress As String) As Boolean
        CheckURL = False
        Dim url As New System.Uri(HostAddress)
        Dim wRequest As System.Net.WebRequest
        wRequest = System.Net.WebRequest.Create(url)
        Dim wResponse As System.Net.WebResponse
        Try
            wResponse = wRequest.GetResponse()
            If wResponse.ResponseUri.AbsoluteUri().ToString = HostAddress Then
                CheckURL = True
            End If
            wResponse.Close()
            wRequest = Nothing
        Catch ex As Exception
            wRequest = Nothing
            MsgBox(ex.ToString)
        End Try

        Return CheckURL
    End Function

    Public Function lvFindSubItem(ByVal lv As ListView,
                                    ByVal pColumnText As String,
                                        ByVal SearchString As String) As Boolean
        Dim idx = (From c In lv.Columns Where c.Text = pColumnText Select c = c.Index).First()
        For Each itm As ListViewItem In lv.Items
            If itm.SubItems(idx).Text = SearchString Then Return True
        Next
        Return False
    End Function

    'DC: 03/19/2019
    'CalculateAgeValue(Date As DateTime)
    Public Function CalculateAgeValue(ByVal pDOB As Date) As String

        Dim strAge As String = String.Empty
        Dim DOB As DateTime

        Try

            DOB = New DateTime(pDOB.Year, pDOB.Month, pDOB.Day)

            Dim tday As TimeSpan = DateTime.Now.Subtract(DOB)
            Dim years As Integer, months As Integer, days As Integer

            months = 12 * (DateTime.Now.Year - DOB.Year) + (DateTime.Now.Month - DOB.Month)

            If DateTime.Now.Day < DOB.Day Then
                months -= 1
                days = DateTime.DaysInMonth(DOB.Year, DOB.Month) - DOB.Day + DateTime.Now.Day
            Else
                days = DateTime.Now.Day - DOB.Day
            End If

            years = Math.Floor(months / 12)
            months -= years * 12

            strAge = years.ToString

            'strAge = "Your age as on " & Format(Now, "dd-MMM-yyyy") & vbCrLf & years & " Years, " & months & " Months and " & days & " Days"

        Catch ex As Exception
            strAge = String.Empty
        End Try

        Return strAge

    End Function

    'DC: 03/19/2019
    'GetNumbWeeks(Date1 As DateTime, Date2 As DateTime, DayOfWeek As FirstDayOfWeek)
    Function GetNumbWeeks(ByVal startDate As Date,
                                    ByVal endDate As Date,
                                        ByVal pDayofWeek As Integer) As List(Of Date)

        Dim result As New List(Of Date)
        Dim checkDate = startDate
        Dim Is1stWeek As Boolean = True
        Do While checkDate <= endDate
            If checkDate.DayOfWeek = pDayofWeek Then 'DayOfWeek.Monday
                result.Add(checkDate)
                If Is1stWeek Then Is1stWeek = False
            Else
                If Is1stWeek Then
                    result.Add(checkDate.AddDays(-checkDate.DayOfWeek + 1))
                    Is1stWeek = False
                End If
            End If
            checkDate = checkDate.AddDays(1)
        Loop

        Return result

    End Function

    'DC: 03/19/2019
    'ConvertListToDataTable(List(Of DataType))
    Public Function ConvertListToDataTable(Of t)(ByVal list As IList(Of t)) As DataTable

        Dim table As New DataTable()
        If Not list.Any Then Return table
        Dim FieldCountStr As String = "RecordCount"
        Dim fields() = list.First.GetType.GetProperties
        For Each field In fields
            table.Columns.Add(field.Name, field.PropertyType)
        Next

        table.Columns.Add(FieldCountStr, GetType(String))

        Dim pCount As Integer = 1

        For Each item In list

            Dim row As DataRow = table.NewRow()

            For Each field In fields
                Dim p = item.GetType.GetProperty(field.Name)
                row(field.Name) = p.GetValue(item, Nothing)
            Next
            row(FieldCountStr) = pCount.ToString
            table.Rows.Add(row)
            pCount += 1
        Next

        Return table

    End Function

    Public Function GetDayOfWeekNames(ByVal pValues As Integer) As String
        Dim pGetDayOfWeekNames As String = String.Empty
        Select Case pValues
            Case 0
                pGetDayOfWeekNames = "Sunday"
            Case 1
                pGetDayOfWeekNames = "Monday"
            Case 2
                pGetDayOfWeekNames = "Tuesday"
            Case 3
                pGetDayOfWeekNames = "Wednesday"
            Case 4
                pGetDayOfWeekNames = "Thursday"
            Case 5
                pGetDayOfWeekNames = "Friday"
            Case 6
                pGetDayOfWeekNames = "Saturday"
        End Select
        Return pGetDayOfWeekNames
    End Function

    'Auto Generate Code
    Public Function GenerateAddOnsCode() As String
        Dim xCharArray() As Char = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray
        Dim xNumbArray() As Char = "0123456789".ToCharArray
        Dim xGenerator As System.Random = New System.Random()
        Dim xStr As String = String.Empty

        While xStr.Length < 4
            If xGenerator.Next(0, 2) = 0 Then
                xStr &= xCharArray(xGenerator.Next(0, xCharArray.Length))
            Else
                xStr &= xNumbArray(xGenerator.Next(0, xNumbArray.Length))
            End If
        End While
        Return xStr
    End Function

    Public Function GetPaymentDueDayTable(Optional pDefault As Boolean = True) As DataTable
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("code", GetType(String))
            .Columns.Add("desc", GetType(String))
            .Rows.Add("", "")
            If pDefault Then
                For Each day As String In [Enum].GetValues(GetType(DayOfWeek))   '[Enum].GetNames(GetType(DayOfWeek))
                    .Rows.Add(CInt(day).ToString(), " " & GetDayOfWeekNames(CInt(day)))
                Next
            Else
                For pDayVal As Integer = 1 To 31 Step 1
                    .Rows.Add(pDayVal.ToString, " " & pDayVal.ToString)
                Next
            End If
        End With
        Return pDTable
    End Function

    Public Sub ListViewBGColor(ByVal pListView As ListView)
        Try
            For i = 0 To pListView.Items.Count - 1 Step 1
                pListView.BackColor = Color.White
                If isEven(i) Then
                    pListView.Items(i).BackColor = Color.White
                Else
                    pListView.Items(i).BackColor = Color.AliceBlue
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub

    Public Function getServerTxtAddress(ByVal pBrancCode As String) As String
        Dim StrServerTxt As String = String.Empty
        Dim dtBranches_RS() As DataRow = dtBranches.Select("TRIM(Column1)='" & pBrancCode & "'")
        If dtBranches_RS.Length > 0 Then
            StrServerTxt = Trim(dtBranches_RS(0).Item("Column3").ToString) & "/xdesktop/"
        End If
        Return StrServerTxt
    End Function


    Public Function RGBToBGR(ByVal rgb As Integer) As Integer
        Dim blue As Integer = (rgb And &HFF)        ' Extract blue
        Dim green As Integer = (rgb >> 8) And &HFF  ' Extract green
        Dim red As Integer = (rgb >> 16) And &HFF    ' Extract red
        Return (blue << 16) Or (green << 8) Or red   ' Combine into BGR
    End Function
    Public Function isCheckedLV(lv As NxNListview) As Boolean
        Return lv.Items.Cast(Of ListViewItem).Any(Function(item) item.Checked)
    End Function

    'Pres 12/04/2025
    'GetNumberOfDays per month 
    Public Function GetNumberOfDays(myDate1 As DateTime) As Integer
        Select Case myDate1.Month
            Case 1, 3, 5, 7, 8, 10, 12
                Return 31
            Case 4, 6, 9, 11
                Return 30
            Case 2
                If (myDate1.Year Mod 4) = 0 Then
                    If (myDate1.Year Mod 100) = 0 Then
                        If (myDate1.Year Mod 400) = 0 Then
                            Return 29
                        Else
                            Return 28
                        End If
                    Else
                        Return 29
                    End If
                Else
                    Return 28
                End If
            Case Else
                ' Should never hit this, but return a safe default
                Return 30
        End Select
    End Function

    'Pres 12/04/2025
    'My Formula
    Public Class MyFormula
        Public Function Eval(expr As String) As Decimal
            ' Use DataTable.Compute for simple arithmetic evaluation
            Dim dt As New DataTable()
            Dim result = dt.Compute(expr, Nothing)
            Return Convert.ToDecimal(result)
        End Function
    End Class



End Module
