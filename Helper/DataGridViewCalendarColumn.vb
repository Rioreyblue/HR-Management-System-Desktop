Public Class DataGridViewCalendarColumn
    Inherits DataGridViewColumn

    Public Sub New()
        MyBase.New(New DataGridViewCalendarCell())
    End Sub

    Public Overrides Property CellTemplate As DataGridViewCell
        Get
            Return MyBase.CellTemplate
        End Get
        Set(value As DataGridViewCell)
            If value IsNot Nothing AndAlso Not TypeOf value Is DataGridViewCalendarCell Then
                Throw New InvalidCastException("Must be a DataGridViewCalendarCell")
            End If
            MyBase.CellTemplate = value
        End Set
    End Property
End Class

Public Class DataGridViewCalendarCell
    Inherits DataGridViewTextBoxCell

    Public Sub New()
        Me.Style.Format = "d"
    End Sub

    Public Overrides Sub InitializeEditingControl(rowIndex As Integer, initialFormattedValue As Object, cellStyle As DataGridViewCellStyle)
        MyBase.InitializeEditingControl(rowIndex, initialFormattedValue, cellStyle)
        Dim ctl As DateTimePickerEditingControl = CType(DataGridView.EditingControl, DateTimePickerEditingControl)
        If Me.Value Is Nothing OrElse Me.Value Is DBNull.Value Then
            ctl.Value = DateTime.Now
        Else
            ctl.Value = Convert.ToDateTime(Me.Value)
        End If
    End Sub

    Public Overrides ReadOnly Property EditType As Type
        Get
            Return GetType(DateTimePickerEditingControl)
        End Get
    End Property

    Public Overrides ReadOnly Property ValueType As Type
        Get
            Return GetType(DateTime)
        End Get
    End Property

    'Public Overrides ReadOnly Property DefaultNewRowValue As Object
    '    Get
    '        Return DateTime.Now
    '    End Get
    'End Property
End Class

Public Class DateTimePickerEditingControl
    Inherits DateTimePicker
    Implements IDataGridViewEditingControl

    Private dataGridViewControl As DataGridView
    Private valueChangedFlag As Boolean
    Private rowIndexNum As Integer

    Public Property EditingControlDataGridView As DataGridView Implements IDataGridViewEditingControl.EditingControlDataGridView
        Get
            Return dataGridViewControl
        End Get
        Set(value As DataGridView)
            dataGridViewControl = value
        End Set
    End Property

    Public Property EditingControlFormattedValue As Object Implements IDataGridViewEditingControl.EditingControlFormattedValue
        Get
            Return Me.Value.ToShortDateString()
        End Get
        Set(value As Object)
            If TypeOf value Is String Then
                Me.Value = DateTime.Parse(value.ToString())
            End If
        End Set
    End Property

    Public Property EditingControlRowIndex As Integer Implements IDataGridViewEditingControl.EditingControlRowIndex
        Get
            Return rowIndexNum
        End Get
        Set(value As Integer)
            rowIndexNum = value
        End Set
    End Property

    Public Property EditingControlValueChanged As Boolean Implements IDataGridViewEditingControl.EditingControlValueChanged
        Get
            Return valueChangedFlag
        End Get
        Set(value As Boolean)
            valueChangedFlag = value
        End Set
    End Property

    Public ReadOnly Property RepositionEditingControlOnValueChange As Boolean Implements IDataGridViewEditingControl.RepositionEditingControlOnValueChange
        Get
            Return False
        End Get
    End Property

    Public Sub ApplyCellStyleToEditingControl(cellStyle As DataGridViewCellStyle) Implements IDataGridViewEditingControl.ApplyCellStyleToEditingControl
        Me.Font = cellStyle.Font
        Me.CalendarForeColor = cellStyle.ForeColor
        Me.CalendarMonthBackground = cellStyle.BackColor
    End Sub

    Public Function EditingControlWantsInputKey(key As Keys, dataGridViewWantsInputKey As Boolean) As Boolean Implements IDataGridViewEditingControl.EditingControlWantsInputKey
        ' Always allow arrow keys, etc., for DateTimePicker
        Select Case key And Keys.KeyCode
            Case Keys.Left, Keys.Up, Keys.Down, Keys.Right, Keys.Home, Keys.End, Keys.PageDown, Keys.PageUp
                Return True
            Case Else
                Return Not dataGridViewWantsInputKey
        End Select
    End Function

    Public Function GetEditingControlFormattedValue(context As DataGridViewDataErrorContexts) As Object Implements IDataGridViewEditingControl.GetEditingControlFormattedValue
        Return Me.Value.ToShortDateString()
    End Function

    Public Sub PrepareEditingControlForEdit(selectAll As Boolean) Implements IDataGridViewEditingControl.PrepareEditingControlForEdit
        ' No special prep
    End Sub

    Public ReadOnly Property EditingPanelCursor As Cursor Implements IDataGridViewEditingControl.EditingPanelCursor
        Get
            Return MyBase.Cursor
        End Get
    End Property

    Protected Overrides Sub OnValueChanged(eventargs As EventArgs)
        valueChangedFlag = True
        dataGridViewControl.NotifyCurrentCellDirty(True)
        MyBase.OnValueChanged(eventargs)
    End Sub
End Class
