Public Class classTimekeeping

#Region "HOLIDAY ENTRIES"
    Public Shared Sub setCboHolidayType(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboHolidayType()
            .DisplayMember = "code"
            .ValueMember = "desc"
            .ColumnNum = 1
            .ColumnWidth = "50|200"
            .DropDownSize = 250
            .Text = ""
        End With
    End Sub
    Public Shared Sub setCboHoliday(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboHoliday()
            .DisplayMember = "description"
            .ValueMember = "holcode"
            .ColumnNum = 3
            .ColumnWidth = "100|250|100|250"
            .DropDownSize = 700
            .Text = ""
        End With
    End Sub
#End Region
#Region "LEAVE CONFIGURATION"
    Public Shared Sub setCboLeaveFlow(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboLeaveFlow.Copy
            .DisplayMember = "ctr"
            .ValueMember = "short_def"
            .ColumnNum = 2
            .ColumnWidth = "50|100|510"
            .DropDownSize = "660"
            .Text = ""
        End With
    End Sub
    Public Shared Sub setCboLeavePolicy(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboLeavePolicy.Copy
            .DisplayMember = "ctr"
            .ValueMember = "leave_type"
            .ColumnNum = 3
            .ColumnWidth = "50|100|250|100"
            .DropDownSize = "500"
            .Text = ""
        End With
    End Sub

    Public Shared Sub setCboLeaveType(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboLeaveType.Copy
            .DisplayMember = "leave_type"
            .ValueMember = "leave_type"
            .ColumnNum = 1
            .ColumnWidth = "50|450"
            .DropDownSize = "500"
            .Text = ""
        End With
    End Sub
    Public Shared Sub setCboLeaveIncrementation(ByVal pCboBox As NxnControls.NxNComboBox)
        With pCboBox
            .DataSource = getCboLeaveIncrementation.Copy
            .DisplayMember = "code"
            .ValueMember = "code"
            .ColumnNum = 0
            .ColumnWidth = "200"
            .DropDownSize = 200
            .Text = ""
        End With
    End Sub

#End Region
End Class



