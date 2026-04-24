Imports NXNParsing
Public Module modTimeKeeping
    Private ActiveFrm As String = String.Empty
    Private jStr_Input As String = "[]"
    Private ws As New WSConnection
    Private Token As String = String.Empty

    Public paramJoblevel As String = String.Empty
    Public paramDateHire As String = String.Empty
    Public paramYear As String = String.Empty
    Public paramTempVal As String = String.Empty
    Public paramLeave As String = String.Empty

    '-------------------------------------------
    'Used this for Leave Transaction
    Public payMode As Integer
    Public basic_rate As Integer
    Public hourly_divisor As Integer
    Public year_work_days As Integer

    Public leavePerHour As Double
    Public leaveAmount As Double

    '---------------------------------------------------------'
    '------------------ SHIFTING POLICY ----------------------'
    '---------------------------------------------------------'
    Public Function getShitingPolicy() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "t_frmShiftingPolicy.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "SHIF01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getCboDTRLogs() As DataTable
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("code", GetType(String))
            .Rows.Add("2")
            .Rows.Add("4")
            .Rows.Add("6")
            .Rows.Add("8")
        End With
        Return pDTable
    End Function

    Public Function getCboSearchBy() As DataTable
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("code", GetType(String))
            .Rows.Add("SHIFTCODE")
            .Rows.Add("DESCRIPTION")
        End With
        Return pDTable
    End Function

#Region "HOLIDAY_ENTRIES"

    Public Function getCboHolidayType() As DataTable
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("code", GetType(String))
            .Columns.Add("desc", GetType(String))
            .Rows.Add("", "")
            .Rows.Add("SPL", "SPECIAL")
            .Rows.Add("LGL", "LEGAL")
            .Rows.Add("CMP", "COMPANY HOLIDAY")
            .Rows.Add("DBL", "DOUBLE HOLIDAY")
            .Rows.Add("LSH", "LEGAL AND SPECIAL HOLIDAY")
        End With
        Return pDTable
    End Function
    Public Function getHolidayEntries() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "t_frmHolidayEntries.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "HOL01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramYear" + """:""" + paramYear + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("holcode", GetType(String))
                    .Columns.Add("holdate", GetType(String))
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("remark", GetType(String))
                    .Columns.Add("time_start", GetType(String))
                    .Columns.Add("time_end", GetType(String))
                    .Columns.Add("keyctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getCboHoliday() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "t_frmHolidayEntries.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "HOL01"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramYear" + """:""" + paramYear + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("holcode", GetType(String))
                .Columns.Add("holdate", GetType(String))
                .Columns.Add("description", GetType(String))
                .Columns.Add("remark", GetType(String))
                .Columns.Add("time_start", GetType(String))
                .Columns.Add("time_end", GetType(String))
                .Columns.Add("keyctr", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getHolidayAssignments() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "t_frmHolidayEntries.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "HOL06"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramYear" + """:""" + paramYear + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("holcode", GetType(String))
                    .Columns.Add("holdate", GetType(String))
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("fullname", GetType(String))
                    .Columns.Add("remark", GetType(String))
                    .Columns.Add("divcode", GetType(String))
                    .Columns.Add("deptcode", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

#End Region

#Region "Labor Hours Policy"
    Public Function getLaborHoursPolicy() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmLaborHoursPolicy.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "LB01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramJoblevel" + """:""" + paramJoblevel + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                With dtable
                    .Columns.Add("otcode", GetType(String))
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("dr_rghrs", GetType(String))
                    .Columns.Add("dr_rgot", GetType(String))
                    .Columns.Add("dnp", GetType(String))
                    .Columns.Add("dnpot", GetType(String))
                    .Columns.Add("mr_rghrs", GetType(String))
                    .Columns.Add("mr_rgot", GetType(String))
                    .Columns.Add("mnp", GetType(String))
                    .Columns.Add("mnpot", GetType(String))
                    .Columns.Add("joblevel", GetType(String))
                    .Columns.Add("company_", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
#End Region

#Region "Leave Configuration"
    Public Function getPosition() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmLeaveConfiguration.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "LVC01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "ActiveCompany" + """:""" + ActiveCompany + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("position", GetType(String))
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("divcode", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getLeavePolicy() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmLeaveConfiguration.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "LVC02"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "ActiveCompany" + """:""" + ActiveCompany + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("policy_ctr", GetType(String))
                    .Columns.Add("pcode", GetType(String))
                    .Columns.Add("pos", GetType(String))
                    .Columns.Add("leave_type", GetType(String))
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("active_year", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getCboLeaveFlow() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "frmLeaveConfiguration.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "LVC03"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("short_def", GetType(String))
                .Columns.Add("description", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getLeaveType() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmLeaveConfiguration.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "LVC04"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("leave_type", GetType(String))
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("unused_type", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getCboLeavePolicy() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "frmLeaveConfiguration.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "LVC05"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "ActiveCompany" + """:""" + ActiveCompany + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("ctr", GetType(String))
                .Columns.Add("leave_type", GetType(String))
                .Columns.Add("description", GetType(String))
                .Columns.Add("allowfile_after", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getFlowApproval() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmLeaveConfiguration.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "LVC11"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "ActiveCompany" + """:""" + ActiveCompany + """," &
                         """" + "paramDiv" + """:""" + paramDiv + """," &
                         """" + "paramPos" + """:""" + paramPos + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("name", GetType(String))
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("hr_approved", GetType(String))
                    .Columns.Add("imhead_approved", GetType(String))
                    .Columns.Add("mgt_approved", GetType(String))
                    .Columns.Add("remarks", GetType(String))
                    .Columns.Add("flow_code", GetType(String))
                    .Columns.Add("ctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getCompanyLeave(ByVal ActiveCompany As String, ByVal paramYear As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmLeaveConfiguration.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "LVC12"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "ActiveCompany" + """:""" + ActiveCompany + """," &
                         """" + "paramYear" + """:""" + paramYear + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("company_", GetType(String))
                    .Columns.Add("area_description", GetType(String))
                    .Columns.Add("cyear", GetType(String))
                    .Columns.Add("leave_type", GetType(String))
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("unused_type", GetType(String))
                    .Columns.Add("sex", GetType(String))
                    .Columns.Add("ctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getCboLeaveIncrementation() As DataTable
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("code", GetType(String))
            .Rows.Add("SEMI-MONTHLY")
            .Rows.Add("MONTHLY")
            .Rows.Add("YEAR CLOSING")
            .Rows.Add("DATE HIRED ANNIVERSARRY")
            .Rows.Add("REGULARIZATION")
        End With
        Dim row As DataRow = pDTable.NewRow
        pDTable.Rows.InsertAt(row, 0)
        Return pDTable
    End Function
    Public Function getLeaveConfigurations(ByVal idno_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmLeaveConfiguration.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "LVC14"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + idno_ + """," &
                         """" + "ActiveCompany" + """:""" + ActiveCompany + """," &
                         """" + "paramYear" + """:""" + paramYear + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("company_", GetType(String))
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("name", GetType(String))
                    .Columns.Add("cyear", GetType(String))
                    .Columns.Add("leave_type", GetType(String))
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("debit", GetType(String))
                    .Columns.Add("credit", GetType(String))
                    .Columns.Add("balance", GetType(String))
                    .Columns.Add("date_from", GetType(String))
                    .Columns.Add("date_to", GetType(String))
                    .Columns.Add("Increment", GetType(String))
                    .Columns.Add("keyctr", GetType(String))
                    .Columns.Add("lockin_hrs", GetType(String))
                    .Columns.Add("lock_active", GetType(String))
                    .Columns.Add("lock_until", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

#End Region

    '---------------------------------------------------------'
    '------------------ LEAVE YEARLY CONFIGURATION -----------'
    '---------------------------------------------------------'
    Public Function getLeaveSetup() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "t_frmLeaveYearlyConfiguration.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "LV01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "ActiveCompany" + """:""" + ActiveCompany + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("company_", GetType(String))
                    .Columns.Add("area_description", GetType(String))
                    .Columns.Add("cyear", GetType(String))
                    .Columns.Add("position_", GetType(String))
                    .Columns.Add("leave_type", GetType(String))
                    .Columns.Add("leave_desc", GetType(String))
                    .Columns.Add("setup_", GetType(String))
                    .Columns.Add("debit", GetType(String))
                    .Columns.Add("keyctr", GetType(String))
                    .Columns.Add("setup_code", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    '---------------------------------------------------------'
    '------------------ SCHEDULE PLOTTING --------------------'
    '---------------------------------------------------------'
    Public Function getCboSearchSchedule() As DataTable
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("code", GetType(String))
            .Rows.Add("IDNO")
            .Rows.Add("FULLNAME")
        End With
        Return pDTable
    End Function
    Public Function getViewScheduling() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "t_frmSchedulePlotting.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "SP01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramYear" + """:""" + paramYear + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("mydate", GetType(String))
                    .Columns.Add("day_of_week", GetType(String))
                    .Columns.Add("myshift", GetType(String))
                    .Columns.Add("myrestday", GetType(String))
                    .Columns.Add("app_ot1", GetType(String))
                    .Columns.Add("app_ot2", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getCboRestDay() As DataTable
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("code", GetType(String))
            .Rows.Add("SUNDAY")
            .Rows.Add("MONDAY")
            .Rows.Add("TUESDAY")
            .Rows.Add("WEDNESDAY")
            .Rows.Add("THURSDAY")
            .Rows.Add("FRIDAY")
            .Rows.Add("SATURDAY")
        End With
        Return pDTable
    End Function
    Public Function getDefaultScheduling() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "t_frmSchedulePlotting.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "SP04"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("mon", GetType(String))
                    .Columns.Add("tue", GetType(String))
                    .Columns.Add("wed", GetType(String))
                    .Columns.Add("thu", GetType(String))
                    .Columns.Add("fri", GetType(String))
                    .Columns.Add("sat", GetType(String))
                    .Columns.Add("sun", GetType(String))
                    .Columns.Add("sat_rest", GetType(String))
                    .Columns.Add("mon_rest", GetType(String))
                    .Columns.Add("tue_rest", GetType(String))
                    .Columns.Add("wed_rest", GetType(String))
                    .Columns.Add("thu_rest", GetType(String))
                    .Columns.Add("fri_rest", GetType(String))
                    .Columns.Add("sun_rest", GetType(String))
                End With
            End If


        Catch ex As Exception
        End Try
        Return dtable
    End Function

    '---------------------------------------------------------'
    '------------------ COMPENSATORY OT BRACKET --------------'
    '---------------------------------------------------------'
    Public Function getCompensatoryOTBracket() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "t_frmCompensatoryOTBracket.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "COMP01"
            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("min_val", GetType(String))
                    .Columns.Add("max_val", GetType(String))
                    .Columns.Add("credit_val", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    '---------------------------------------------------------'
    '------------------ ELIGIBILITY FOR COMPENSATORY ---------'
    '---------------------------------------------------------'
    Public Function getCompensatoryPolicy() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "t_frmEligibilityCompensatory.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "EC01"
            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("ctr", GetType(String))
                    .Columns.Add("on_saturday", GetType(String))
                    .Columns.Add("on_sunday", GetType(String))
                    .Columns.Add("on_restday", GetType(String))
                    .Columns.Add("on_lglholiday", GetType(String))
                    .Columns.Add("on_splholiday", GetType(String))
                    .Columns.Add("on_cmpholiday", GetType(String))
                    .Columns.Add("remark", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    '---------------------------------------------------------'
    '------------------ LEAVE CATEGORY -----------------------'
    '---------------------------------------------------------'

    Public Function getLeaveCategory() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "t_frmLeaveCategory.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "LV01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("code", GetType(String))
                    .Columns.Add("description", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    '---------------------------------------------------------'
    '------------------ USER LOGS REMARKS --------------------'
    '---------------------------------------------------------'
    Public Function getUserLogsRemarksMaint() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "t_frmUserLogRemarksMaint.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "REM01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("remcode", GetType(String))
                    .Columns.Add("description", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    '---------------------------------------------------------'
    '------------------ LEAVE INCREMENTOR MAINTENANCE --------'
    '---------------------------------------------------------'
    Public Function getLeaveIncrementor() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "t_frmLeaveIncrementorMaintenance.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "INC01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno_sec", GetType(String))
                    .Columns.Add("fullname", GetType(String))
                    .Columns.Add("allowed", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    '---------------------------------------------------------'
    '------------------ SHIFT PER DIVISION -------------------'
    '---------------------------------------------------------'

    Public Function getCboShiftingPolicyCode() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "t_frmShiftPerDivision.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "SDV01"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("shfcode", GetType(String))
                .Columns.Add("shift_in", GetType(String))
                .Columns.Add("break_start1", GetType(String))
                .Columns.Add("break_end1", GetType(String))
                .Columns.Add("mealbreak_start", GetType(String))
                .Columns.Add("mealbreak_end", GetType(String))
                .Columns.Add("break_start2", GetType(String))
                .Columns.Add("break_end2", GetType(String))
                .Columns.Add("shift_out", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getShiftingPerDivision() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "t_frmShiftPerDivision.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "SDV02"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("shfcode", GetType(String))
                    .Columns.Add("company", GetType(String))
                    .Columns.Add("divcode", GetType(String))
                    .Columns.Add("deptcode", GetType(String))
                    .Columns.Add("seccode", GetType(String))
                    .Columns.Add("grpcode", GetType(String))
                    .Columns.Add("remark", GetType(String))
                    .Columns.Add("is_active", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable

    End Function

    '---------------------------------------------------------'
    '------------------ LEAVE FLOW ---------------------------'
    '---------------------------------------------------------'

    Public Function getLeaveFlowPerson() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "t_frmLeaveFlow.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "LVF01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "ActiveCompany" + """:""" + ActiveCompany + """," &
                         """" + "paramPos" + """:""" + paramPos + """," &
                         """" + "paramDiv" + """:""" + paramDiv + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("fullname", GetType(String))
                    .Columns.Add("date_hire", GetType(String))
                    .Columns.Add("total_length_of_service", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getLeaveFlowMaintenance() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "t_frmLeaveFlow.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "LVF02"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("short_def", GetType(String))
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("hr_approved", GetType(String))
                    .Columns.Add("imhead_approved", GetType(String))
                    .Columns.Add("mgt_approved", GetType(String))
                    .Columns.Add("remarks", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    '---------------------------------------------------------'
    '------------------ LEAVE POLICY MAINTENANCE -------------'
    '---------------------------------------------------------'
    Public Function getLeavePolicyMaintenance() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "t_frmLeavePolicyMaintenance.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "LVP01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "ActiveCompany" + """:""" + ActiveCompany + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("short_def", GetType(String))
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("hr_approved", GetType(String))
                    .Columns.Add("imhead_approved", GetType(String))
                    .Columns.Add("mgt_approved", GetType(String))
                    .Columns.Add("remarks", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getCboLeaveType() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "t_frmLeavePolicyMaintenance.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "LVP02"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "ActiveCompany" + """:""" + ActiveCompany + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("leave_type", GetType(String))
                .Columns.Add("description", GetType(String))
                .Columns.Add("unused_type", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    '---------------------------------------------------------'
    '------------------ LEAVE TRANSACTION --------------------'
    '---------------------------------------------------------'

    Public Function getCboLeaveTransType() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "t_frmLeave.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "LVTRANS01"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("description", GetType(String))
                .Columns.Add("code", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getCboCutOffTMK() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "t_frmLeave.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "LVTRANS02"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("cutoff", GetType(String))
                .Columns.Add("datestart", GetType(String))
                .Columns.Add("dateend", GetType(String))
                .Columns.Add("cutoff_date", GetType(String))
                .Columns.Add("cutoff_start", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getLeaveOnlinePendingApplication_ForValidation() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "t_frmLeave.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "LVTRANS03"
            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "paramYear" + """:""" + paramYear + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("date_applied", GetType(String))
                    .Columns.Add("date_leave", GetType(String))
                    .Columns.Add("leave_type", GetType(String))
                    .Columns.Add("reasons", GetType(String))
                    .Columns.Add("refno", GetType(String))
                    .Columns.Add("wpay_hours", GetType(String))
                    .Columns.Add("wopay_hours", GetType(String))
                    .Columns.Add("certified_by", GetType(String))
                    .Columns.Add("certified_remark", GetType(String))
                    .Columns.Add("trail", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getLeaveOnlinePendingApplication_ForApproval() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "t_frmLeave.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "LVTRANS04"
            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "paramYear" + """:""" + paramYear + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("date_applied", GetType(String))
                    .Columns.Add("date_leave", GetType(String))
                    .Columns.Add("leave_type", GetType(String))
                    .Columns.Add("reasons", GetType(String))
                    .Columns.Add("refno", GetType(String))
                    .Columns.Add("wpay_hours", GetType(String))
                    .Columns.Add("wopay_hours", GetType(String))
                    .Columns.Add("certified_by", GetType(String))
                    .Columns.Add("certified_remark", GetType(String))
                    .Columns.Add("trail", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getCboLeaveTypeTrans() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "t_frmLeave.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "LVTRANS05"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramYear" + """:""" + paramYear + """," &
                     """" + "ActiveCompany" + """:""" + ActiveCompany + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("leave_type", GetType(String))
                .Columns.Add("description", GetType(String))
                .Columns.Add("sex", GetType(String))
                .Columns.Add("ltype", GetType(String))
                .Columns.Add("unused_type", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getCboLeaveCategory() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "t_frmLeave.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "LVTRANS06"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("code", GetType(String))
                .Columns.Add("description", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getFiledLeave() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "t_frmLeave.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "LVTRANS08"
            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "paramYear" + """:""" + paramYear + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("date_leave", GetType(String))
                    .Columns.Add("ldesc", GetType(String))
                    .Columns.Add("reasons", GetType(String))
                    .Columns.Add("refno", GetType(String))
                    .Columns.Add("wpay_hours", GetType(String))
                    .Columns.Add("wopay_hours", GetType(String))
                    .Columns.Add("ctr_", GetType(String))
                    .Columns.Add("posted", GetType(String))
                    .Columns.Add("trail_", GetType(String))
                    .Columns.Add("lv_category", GetType(String))
                    .Columns.Add("vl_place", GetType(String))
                    .Columns.Add("vl_abroad", GetType(String))
                    .Columns.Add("sl_place", GetType(String))
                    .Columns.Add("sl_hospital", GetType(String))
                    .Columns.Add("sl_outpatient", GetType(String))
                    .Columns.Add("is_requested", GetType(String))
                    .Columns.Add("end_bal", GetType(String))
                    .Columns.Add("leavetype", GetType(String))
                    .Columns.Add("lvtranstype", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

End Module
