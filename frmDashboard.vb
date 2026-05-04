Imports System.Data
Imports System.Net
Imports LiveCharts
Imports LiveCharts.Wpf
Imports WinColor = System.Drawing.Color
Imports WinFont = System.Drawing.Font
Imports WpfMedia = System.Windows.Media
Public Class frmDashboard

    Dim dtDivision As New DataTable

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Call Statistics()
        Call EmployeePieChart()
        Call LoadEmployeeRecords()
        'Call Analytics()
        'Call GenderPieChart()
        'Call GenderPieChart2()
    End Sub

    'Private Sub Statistics()
    '    ' Sample data would be replaced by DataTable values
    '    Dim jobTypes As New List(Of String)()
    '    Dim employeeCounts As New List(Of Integer)()

    '    ' Loop through the DataTable to get job types and employee counts
    '    For Each _dr In getDashboard_Analytics.Rows
    '        jobTypes.Add(StrConv(_dr("jtypename").ToString, vbProperCase)) ' Add department (job type) name
    '        employeeCounts.Add(Convert.ToInt32(_dr("jtype_cnt"))) ' Add employee count
    '    Next

    '    ' Create a SeriesCollection
    '    Dim seriesCollection As New SeriesCollection()

    '    ' Create a LineSeries for the line chart
    '    Dim lineSeries As New LineSeries With {
    '    .Title = "Employees",
    '    .Values = New ChartValues(Of Integer)(employeeCounts),
    '    .Fill = New SolidColorBrush(Color.FromArgb(50, 135, 206, 250)), ' Light blue transparent fill for shaded area
    '    .StrokeThickness = 2, ' Thickness of the line
    '    .PointGeometry = DefaultGeometries.Circle, ' Circle markers on data points
    '    .PointGeometrySize = 8 ' Size of the markers
    '}

    '    ' Add the LineSeries to the collection
    '    seriesCollection.Add(lineSeries)

    '    ' Assign the series collection to the CartesianChart
    '    CartesianChart1.Series = seriesCollection

    '    ' Configure the X-axis with job types (categories)
    '    CartesianChart1.AxisX.Clear() ' Clear any previous axis configurations if needed
    '    CartesianChart1.AxisX.Add(New Axis With {
    '    .Title = "Job Types",
    '    .Labels = jobTypes.ToList(), ' Bind dynamic job types to the X-axis
    '    .Separator = New Separator() With {
    '        .Step = 1 ' Ensure that there is a separator for each label (optional)
    '    }
    '})

    '    ' Configure the Y-axis for numeric values (employee counts)
    '    CartesianChart1.AxisY.Clear() ' Clear any previous Y-axis configurations if needed
    '    CartesianChart1.AxisY.Add(New Axis With {
    '    .Title = "Number of Employees",
    '    .LabelFormatter = Function(value) value.ToString("N0"), ' Format as whole numbers
    '    .Separator = New Separator() With {
    '        .Step = 100 ' Adjust step value for better spacing (optional)
    '    }
    '})

    '    ' Enable default tooltips
    '    CartesianChart1.Hoverable = True
    'End Sub

    'Private Sub GenderPieChart()
    '    Dim seriesCollection As New SeriesCollection()

    '    ' Define your custom colors based on your image
    '    Dim customColors As New List(Of Brush) From {
    '    New SolidColorBrush(Color.FromRgb(112, 128, 144)), ' Slate Gray
    '    New SolidColorBrush(Color.FromRgb(30, 144, 255)),  ' Dodger Blue
    '    New SolidColorBrush(Color.FromRgb(255, 69, 58)),   ' Soft Red
    '    New SolidColorBrush(Color.FromRgb(255, 193, 7))    ' Amber/Yellow
    '}

    '    Dim colorIndex As Integer = 0

    '    For Each _dr As DataRow In getDashboard_Analytics.Rows
    '        Dim ps As New PieSeries With {
    '        .Title = _dr("category").ToString(),
    '        .Values = New ChartValues(Of Integer)({Convert.ToInt32(_dr("count_"))}),
    '        .Fill = customColors(colorIndex Mod customColors.Count), ' Assigns the color
    '        .Stroke = Brushes.White, ' Adds the white gap between slices
    '        .StrokeThickness = 2
    '    }

    '        seriesCollection.Add(ps)
    '        colorIndex += 1
    '    Next

    '    PieChart1.Series = seriesCollection
    'End Sub

    Private Sub Statistics()
        Dim months As New List(Of String) From {
        "January", "February", "March", "April", "May", "June",
        "July", "August", "September", "October", "November", "December"
    }

        Dim monthData As New Dictionary(Of String, Dictionary(Of String, Integer))()

        ' Process data rows
        For Each _dr As DataRow In getDashboard_Analytics.Rows
            Dim month As String = _dr("month_").ToString().Trim() ' Ensure no trailing spaces
            Dim remark As String = _dr("remarks_").ToString()
            Dim count As Integer = Convert.ToInt32(_dr("totalcnt_"))

            ' Check if the month already exists in the dictionary
            If Not monthData.ContainsKey(month) Then
                ' If not, add a new dictionary for the month
                monthData(month) = New Dictionary(Of String, Integer)()
            End If

            ' Add or update the remark and count in the month's dictionary
            monthData(month)(remark) = count
        Next

        ' Extract unique remarks
        Dim uniqueRemarks As New HashSet(Of String)
        For Each monthDataEntry In monthData.Values
            For Each remark In monthDataEntry.Keys
                uniqueRemarks.Add(remark)
            Next
        Next

        ' Create a SeriesCollection
        Dim seriesCollection As New SeriesCollection()

        ' Add a LineSeries for each remark
        For Each remark In uniqueRemarks
            Dim counts As New ChartValues(Of Integer)()

            ' Collect counts for this remark across all months
            For Each currentMonth In months
                If monthData.ContainsKey(currentMonth) AndAlso monthData(currentMonth).ContainsKey(remark) Then
                    counts.Add(monthData(currentMonth)(remark))
                Else
                    counts.Add(0) ' Default to 0 if no data for this month/remark
                End If
            Next

            ' Create the LineSeries
            Dim lineSeries As New LineSeries With {
            .Title = remark,
            .Values = counts,
            .PointGeometry = DefaultGeometries.Circle,
            .PointGeometrySize = 8
        }

            seriesCollection.Add(lineSeries)
        Next

        ' Assign the series collection to the CartesianChart
        CartesianChart1.Series = seriesCollection

        ' Configure the X-axis with months
        CartesianChart1.AxisX.Clear()
        CartesianChart1.AxisX.Add(New Axis With {
        .Title = "",
        .Labels = months,
        .Separator = New Separator() With {
            .Step = 1
        }
    })

        ' Configure the Y-axis for numeric values (set range to 10–100)
        CartesianChart1.AxisY.Clear()
        CartesianChart1.AxisY.Add(New Axis With {
        .Title = "",
        .MinValue = 0, ' Set the minimum value to 10
        .MaxValue = 20, ' Set the maximum value to 100
        .LabelFormatter = Function(value) value.ToString("N0"),
        .Separator = New Separator() With {
            .Step = 2 ' Adjust as needed
        }
    })

        ' Enable default tooltips
        CartesianChart1.Hoverable = True
    End Sub


    'rey task
    Private Sub EmployeePieChart()
        Dim dt As DataTable = getEmployeeChart()

        Dim cAbsent As Integer = 2, cPresent As Integer = 4
        Dim cSick As Integer = 3, cBusiness As Integer = 1


        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            Integer.TryParse(row("total_absent").ToString(), cAbsent)
            Integer.TryParse(row("total_present").ToString(), cPresent)
            Integer.TryParse(row("total_sick").ToString(), cSick)
            Integer.TryParse(row("total_business").ToString(), cBusiness)
        End If

        Dim labelFormatter As Func(Of ChartPoint, String) =
        Function(cp) String.Format("{0}: {1} ({2:P1})", cp.SeriesView.Title, cp.Y, cp.Participation)

        Dim seriesCollection As New SeriesCollection()

        Dim addSlice = Sub(title As String, value As Integer)
                           If value > 0 Then
                               seriesCollection.Add(New PieSeries With {
                               .Title = title,
                               .Values = New ChartValues(Of Integer)({value}),
                               .DataLabels = True,
                               .LabelPoint = labelFormatter
                           })
                           End If
                       End Sub

        addSlice("Absent", cAbsent)
        addSlice("Present", cPresent)
        addSlice("Sick Leave", cSick)
        addSlice("Business Travel", cBusiness)
        'addSlice("Vacation Leave", cVacation)
        'addSlice("Maternity Leave", cMaternity)
        'addSlice("Late", cLate)
        'addSlice("Holiday", cHoliday)

        chrtAttendance.Series = seriesCollection
        chrtAttendance.LegendLocation = LegendLocation.Bottom
    End Sub

    'rey task 2
    Private Sub LoadEmployeeRecords()
        Dim dtDisplay As New DataTable()
        dtDisplay.Columns.Add("EMPLOYEE ID")
        dtDisplay.Columns.Add("DIVCODE")
        dtDisplay.Columns.Add("EMPLOYEE NAME")
        dtDisplay.Columns.Add("REMARKS")
        dtDisplay.Columns.Add("ATTENDANCE DATE")
        dtDisplay.Columns.Add("TRAIL")

        Dim dtSource As DataTable = getEmployeeLogs()

        If dtSource IsNot Nothing AndAlso dtSource.Rows.Count > 0 Then
            For Each row As DataRow In dtSource.Rows

                dtDisplay.Rows.Add(
                row("idno").ToString(),
                row("divcode").ToString(),
                row("full_name").ToString(),
                row("remarks").ToString(),
                row("attdate").ToString(),
                row("trail").ToString()
            )
            Next
        End If

        dgvRecords.DataSource = dtDisplay
        StyleGrid()
    End Sub

    Private Sub StyleGrid()
        With dgvRecords
            .BackgroundColor = WinColor.White
            .BorderStyle = BorderStyle.None
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .GridColor = WinColor.FromArgb(230, 230, 230)

            .EnableHeadersVisualStyles = False
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .ColumnHeadersDefaultCellStyle.BackColor = WinColor.FromArgb(52, 73, 94)
            .ColumnHeadersDefaultCellStyle.ForeColor = WinColor.White
            .ColumnHeadersDefaultCellStyle.Font = New WinFont("Segoe UI Semibold", 10)
            .ColumnHeadersHeight = 45

            .DefaultCellStyle.Font = New WinFont("Segoe UI", 9)
            .DefaultCellStyle.SelectionBackColor = WinColor.FromArgb(235, 243, 255)
            .DefaultCellStyle.SelectionForeColor = WinColor.FromArgb(0, 120, 215)
            .RowTemplate.Height = 40

            .RowHeadersVisible = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .AllowUserToAddRows = False
        End With
    End Sub

    'com
    'Private Sub GenderPieChart()
    '    ' Sample data would be replaced by your DataTable or actual data
    '    Dim genderLabels As New List(Of String) From {"Male", "Female"}
    '    Dim genderCounts As New List(Of Integer) From {60, 40} ' Example: 60 males, 40 females

    '    ' Create a SeriesCollection for the pie chart
    '    Dim seriesCollection As New SeriesCollection()

    ' Create a PieSeries for Male
    'Dim malePieSeries As New PieSeries With {
    '    .Title = "Male",
    '    .Values = New ChartValues(Of Integer)({genderCounts(0)}), ' Male count
    '    .DataLabels = True, ' Show data labels
    '    .LabelPoint = Function(chartPoint) chartPoint.Y.ToString("N0") ' Format label
    '}

    '    ' Create a PieSeries for Female
    '    Dim femalePieSeries As New PieSeries With {
    '    .Title = "Female",
    '    .Values = New ChartValues(Of Integer)({genderCounts(1)}), ' Female count
    '    .DataLabels = True, ' Show data labels
    '    .LabelPoint = Function(chartPoint) chartPoint.Y.ToString("N0") ' Format label
    '}

    '    ' Add the PieSeries to the SeriesCollection
    '    SeriesCollection.Add(malePieSeries)
    '    SeriesCollection.Add(femalePieSeries)

    '    ' Assign the SeriesCollection to the PieChart
    '    PieChart1.Series = SeriesCollection

    '    ' Optional: Configure the chart title
    '    'PieChart1.ChartTitle = "Gender Distribution" (If you want to add a title)
    'End Sub

    'Private Sub GenderPieChart2()
    '    ' Sample data would be replaced by your DataTable or actual data
    '    Dim genderLabels As New List(Of String) From {"Present", "Absent", "Late"}
    '    Dim genderCounts As New List(Of Integer) From {60, 40, 30} ' Example: 60 males, 40 females

    '    ' Create a SeriesCollection for the pie chart
    '    Dim seriesCollection As New SeriesCollection()

    '    ' Create a PieSeries for Male
    '    Dim malePieSeries As New PieSeries With {
    '    .Title = "Male",
    '    .Values = New ChartValues(Of Integer)({genderCounts(0)}), ' Male count
    '    .DataLabels = True, ' Show data labels
    '    .LabelPoint = Function(chartPoint) chartPoint.Y.ToString("N0") ' Format label
    '}

    '    ' Create a PieSeries for Female
    '    Dim femalePieSeries As New PieSeries With {
    '    .Title = "Female",
    '    .Values = New ChartValues(Of Integer)({genderCounts(1)}), ' Female count
    '    .DataLabels = True, ' Show data labels
    '    .LabelPoint = Function(chartPoint) chartPoint.Y.ToString("N0") ' Format label
    '}

    '    ' Add the PieSeries to the SeriesCollection
    '    seriesCollection.Add(malePieSeries)
    '    seriesCollection.Add(femalePieSeries)

    '    ' Assign the SeriesCollection to the PieChart
    '    PieChart2.Series = seriesCollection

    '    ' Optional: Configure the chart title
    '    ' PieChart1.ChartTitle = "Gender Distribution" (If you want to add a title)
    'End Sub


    Private Sub Analytics()
        For Each _dr In getTotalEmployees.Rows
            cntEmployee.Text = _dr("total_employee").ToString
        Next
        For Each _dr In getTotalApplicant.Rows
            cntApplicant.Text = _dr("total_applicant").ToString
        Next

        For Each _dr In getTotalOnLeaveEmployees.Rows
            cntLeave.Text = _dr("total_leave").ToString
        Next

        For Each _dr In getTotaLOnTravelEmployees.Rows
            cntTravel.Text = _dr("total_travel").ToString
        Next
    End Sub
End Class