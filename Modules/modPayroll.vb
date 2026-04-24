Imports Newtonsoft.Json
Imports NXNParsing

Public Module modPayroll
    Private ActiveFrm As String = String.Empty
    Private jStr_Input As String = "[]"
    Private ws As New WSConnection
    Private Token As String = String.Empty

#Region "Process Payroll"
    Public Function getCboActiveCutOffListing() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "frmProcessPayroll.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "PAY01"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                 """" + "ActiveCompany" + """:""" + ActiveCompany + """," &
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
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function get_all_employee_status_timesheet(ByVal paramID As String, ByVal paramCutoff As String, ByVal posted_ As Boolean) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "PAY02"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                 """" + "paramID" + """:""" + paramID + """," &
                 """" + "paramCutoff" + """:""" + paramCutoff + """," &
                 """" + "posted_" + """:""" + posted_.ToString + """," &
                 """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                              ServerTxt & ActiveFrm,
                              "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("cutoff", GetType(String))
                    .Columns.Add("costcode", GetType(String))
                    .Columns.Add("divcode", GetType(String))
                    .Columns.Add("deptcode", GetType(String))
                    .Columns.Add("taxcode", GetType(String))
                    .Columns.Add("active_year", GetType(String))
                    .Columns.Add("paidtype", GetType(String))
                    .Columns.Add("jobstatus", GetType(String))
                    .Columns.Add("extended_leave", GetType(String))
                    .Columns.Add("minimum_wage", GetType(String))
                    .Columns.Add("electronic_log", GetType(String))
                    .Columns.Add("union_member", GetType(String))
                    .Columns.Add("basic_rate", GetType(String))
                    .Columns.Add("paymode", GetType(String))
                    .Columns.Add("joblevel", GetType(String))
                    .Columns.Add("hourlydiv_daily", GetType(String))
                    .Columns.Add("hourly_divisor", GetType(String))
                    .Columns.Add("hdmf_custom", GetType(String))
                    .Columns.Add("sss_ded", GetType(String))
                    .Columns.Add("sss_ded_amt", GetType(String))
                    .Columns.Add("sss_ded_yer_amt", GetType(String))
                    .Columns.Add("sss_ded_ecc_amt", GetType(String))
                    .Columns.Add("phealth_ded", GetType(String))
                    .Columns.Add("phealth_ded_amt", GetType(String))
                    .Columns.Add("phealth_ded_yer_amt", GetType(String))
                    .Columns.Add("hdmf_ded", GetType(String))
                    .Columns.Add("hdmf_ded_amt", GetType(String))
                    .Columns.Add("hdmf_ded_yer_amt", GetType(String))
                    .Columns.Add("Taxwitheld", GetType(String))
                    .Columns.Add("Taxwitheld_Amt", GetType(String))
                    .Columns.Add("medicare_ded", GetType(String))
                    .Columns.Add("medicare_ded_amt", GetType(String))
                    .Columns.Add("medicare_ded_yer_amt", GetType(String))
                    .Columns.Add("gsis_ded", GetType(String))
                    .Columns.Add("gsis_ded_amt", GetType(String))
                    .Columns.Add("gsis_ded_yer_amt", GetType(String))
                    .Columns.Add("gsis_ecc", GetType(String))
                    .Columns.Add("gsis_ehp", GetType(String))
                    .Columns.Add("ntax_13thmon", GetType(String))
                    .Columns.Add("ntax_allowance", GetType(String))
                    .Columns.Add("disregard_tax_config", GetType(String))
                    .Columns.Add("special_taxation", GetType(String))
                    .Columns.Add("special_tax_percentage", GetType(String))
                    .Columns.Add("projectedtax", GetType(String))
                    .Columns.Add("ovr_rate", GetType(String))
                    .Columns.Add("ovr_rate_amt", GetType(String))
                End With
            End If
        Catch ex As Exception
        End Try
        Return dtable

    End Function

    Public Function get_OTPolicy(ByVal jlevel_ As String, ByVal company_ As String) As DataTable
        Dim dtable As DataTable = New DataTable()

        Try
            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "PAY03"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                 """" + "jlevel_" + """:""" + jlevel_ + """," &
                 """" + "company_" + """:""" + company_ + """," &
                 """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                              ServerTxt & ActiveFrm,
                              "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("cutoff", GetType(String))
                    .Columns.Add("datestart", GetType(String))
                    .Columns.Add("dateend", GetType(String))
                    .Columns.Add("cutoff_date", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function plotted_loading(ByVal paramID As String, ByVal paramDateFrom As String, ByVal paramDateTo As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY04"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramID" + """:""" + paramID + """," &
                     """" + "paramDateFrom" + """:""" + paramDateFrom + """," &
                     """" + "paramDateTo" + """:""" + paramDateTo + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("due_date", GetType(String))
                    .Columns.Add("posted", GetType(String))
                    .Columns.Add("closed", GetType(String))
                    .Columns.Add("ddctcode", GetType(String))
                    .Columns.Add("total", GetType(String))
                    .Columns.Add("nontaxable", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_gsis_premium(ByVal paramID As String, act_year As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY10"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramID" + """:""" + paramID + """," &
                     """" + "act_year" + """:""" + act_year + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("jan_employee", GetType(String))
                    .Columns.Add("feb_employee", GetType(String))
                    .Columns.Add("mar_employee", GetType(String))
                    .Columns.Add("apr_employee", GetType(String))
                    .Columns.Add("may_employee", GetType(String))
                    .Columns.Add("jun_employee", GetType(String))
                    .Columns.Add("jul_employee", GetType(String))
                    .Columns.Add("aug_employee", GetType(String))
                    .Columns.Add("sep_employee", GetType(String))
                    .Columns.Add("oct_employee", GetType(String))
                    .Columns.Add("nov_employee", GetType(String))
                    .Columns.Add("dec_employee", GetType(String))
                    .Columns.Add("jan_employer", GetType(String))
                    .Columns.Add("feb_employer", GetType(String))
                    .Columns.Add("mar_employer", GetType(String))
                    .Columns.Add("apr_employer", GetType(String))
                    .Columns.Add("may_employer", GetType(String))
                    .Columns.Add("jun_employer", GetType(String))
                    .Columns.Add("jul_employer", GetType(String))
                    .Columns.Add("aug_employer", GetType(String))
                    .Columns.Add("sep_employer", GetType(String))
                    .Columns.Add("oct_employer", GetType(String))
                    .Columns.Add("nov_employer", GetType(String))
                    .Columns.Add("dec_employer", GetType(String))
                    .Columns.Add("jan_based_amt", GetType(String))
                    .Columns.Add("feb_based_amt", GetType(String))
                    .Columns.Add("mar_based_amt", GetType(String))
                    .Columns.Add("apr_based_amt", GetType(String))
                    .Columns.Add("may_based_amt", GetType(String))
                    .Columns.Add("jun_based_amt", GetType(String))
                    .Columns.Add("jul_based_amt", GetType(String))
                    .Columns.Add("aug_based_amt", GetType(String))
                    .Columns.Add("sep_based_amt", GetType(String))
                    .Columns.Add("oct_based_amt", GetType(String))
                    .Columns.Add("nov_based_amt", GetType(String))
                    .Columns.Add("dec_based_amt", GetType(String))

                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_sss_premium(ByVal paramID As String, act_year As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY11"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramID" + """:""" + paramID + """," &
                     """" + "act_year" + """:""" + act_year + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("jan_employee", GetType(String))
                    .Columns.Add("feb_employee", GetType(String))
                    .Columns.Add("mar_employee", GetType(String))
                    .Columns.Add("apr_employee", GetType(String))
                    .Columns.Add("may_employee", GetType(String))
                    .Columns.Add("jun_employee", GetType(String))
                    .Columns.Add("jul_employee", GetType(String))
                    .Columns.Add("aug_employee", GetType(String))
                    .Columns.Add("sep_employee", GetType(String))
                    .Columns.Add("oct_employee", GetType(String))
                    .Columns.Add("nov_employee", GetType(String))
                    .Columns.Add("dec_employee", GetType(String))
                    .Columns.Add("jan_employer", GetType(String))
                    .Columns.Add("feb_employer", GetType(String))
                    .Columns.Add("mar_employer", GetType(String))
                    .Columns.Add("apr_employer", GetType(String))
                    .Columns.Add("may_employer", GetType(String))
                    .Columns.Add("jun_employer", GetType(String))
                    .Columns.Add("jul_employer", GetType(String))
                    .Columns.Add("aug_employer", GetType(String))
                    .Columns.Add("sep_employer", GetType(String))
                    .Columns.Add("oct_employer", GetType(String))
                    .Columns.Add("nov_employer", GetType(String))
                    .Columns.Add("dec_employer", GetType(String))
                    .Columns.Add("jan_based_amt", GetType(String))
                    .Columns.Add("feb_based_amt", GetType(String))
                    .Columns.Add("mar_based_amt", GetType(String))
                    .Columns.Add("apr_based_amt", GetType(String))
                    .Columns.Add("may_based_amt", GetType(String))
                    .Columns.Add("jun_based_amt", GetType(String))
                    .Columns.Add("jul_based_amt", GetType(String))
                    .Columns.Add("aug_based_amt", GetType(String))
                    .Columns.Add("sep_based_amt", GetType(String))
                    .Columns.Add("oct_based_amt", GetType(String))
                    .Columns.Add("nov_based_amt", GetType(String))
                    .Columns.Add("dec_based_amt", GetType(String))
                    .Columns.Add("janec", GetType(String))
                    .Columns.Add("febec", GetType(String))
                    .Columns.Add("marec", GetType(String))
                    .Columns.Add("aprec", GetType(String))
                    .Columns.Add("mayec", GetType(String))
                    .Columns.Add("junec", GetType(String))
                    .Columns.Add("julec", GetType(String))
                    .Columns.Add("augec", GetType(String))
                    .Columns.Add("sepec", GetType(String))
                    .Columns.Add("octec", GetType(String))
                    .Columns.Add("novec", GetType(String))
                    .Columns.Add("decec", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_hdmf_premium(ByVal paramID As String, act_year As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY12"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramID" + """:""" + paramID + """," &
                     """" + "act_year" + """:""" + act_year + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("jan_employee", GetType(String))
                    .Columns.Add("feb_employee", GetType(String))
                    .Columns.Add("mar_employee", GetType(String))
                    .Columns.Add("apr_employee", GetType(String))
                    .Columns.Add("may_employee", GetType(String))
                    .Columns.Add("jun_employee", GetType(String))
                    .Columns.Add("jul_employee", GetType(String))
                    .Columns.Add("aug_employee", GetType(String))
                    .Columns.Add("sep_employee", GetType(String))
                    .Columns.Add("oct_employee", GetType(String))
                    .Columns.Add("nov_employee", GetType(String))
                    .Columns.Add("dec_employee", GetType(String))
                    .Columns.Add("jan_employer", GetType(String))
                    .Columns.Add("feb_employer", GetType(String))
                    .Columns.Add("mar_employer", GetType(String))
                    .Columns.Add("apr_employer", GetType(String))
                    .Columns.Add("may_employer", GetType(String))
                    .Columns.Add("jun_employer", GetType(String))
                    .Columns.Add("jul_employer", GetType(String))
                    .Columns.Add("aug_employer", GetType(String))
                    .Columns.Add("sep_employer", GetType(String))
                    .Columns.Add("oct_employer", GetType(String))
                    .Columns.Add("nov_employer", GetType(String))
                    .Columns.Add("dec_employer", GetType(String))
                    .Columns.Add("jan_based_amt", GetType(String))
                    .Columns.Add("feb_based_amt", GetType(String))
                    .Columns.Add("mar_based_amt", GetType(String))
                    .Columns.Add("apr_based_amt", GetType(String))
                    .Columns.Add("may_based_amt", GetType(String))
                    .Columns.Add("jun_based_amt", GetType(String))
                    .Columns.Add("jul_based_amt", GetType(String))
                    .Columns.Add("aug_based_amt", GetType(String))
                    .Columns.Add("sep_based_amt", GetType(String))
                    .Columns.Add("oct_based_amt", GetType(String))
                    .Columns.Add("nov_based_amt", GetType(String))
                    .Columns.Add("dec_based_amt", GetType(String))

                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_phealth_premium(ByVal paramID As String, act_year As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY13"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramID" + """:""" + paramID + """," &
                     """" + "act_year" + """:""" + act_year + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("jan_employee", GetType(String))
                    .Columns.Add("feb_employee", GetType(String))
                    .Columns.Add("mar_employee", GetType(String))
                    .Columns.Add("apr_employee", GetType(String))
                    .Columns.Add("may_employee", GetType(String))
                    .Columns.Add("jun_employee", GetType(String))
                    .Columns.Add("jul_employee", GetType(String))
                    .Columns.Add("aug_employee", GetType(String))
                    .Columns.Add("sep_employee", GetType(String))
                    .Columns.Add("oct_employee", GetType(String))
                    .Columns.Add("nov_employee", GetType(String))
                    .Columns.Add("dec_employee", GetType(String))
                    .Columns.Add("jan_employer", GetType(String))
                    .Columns.Add("feb_employer", GetType(String))
                    .Columns.Add("mar_employer", GetType(String))
                    .Columns.Add("apr_employer", GetType(String))
                    .Columns.Add("may_employer", GetType(String))
                    .Columns.Add("jun_employer", GetType(String))
                    .Columns.Add("jul_employer", GetType(String))
                    .Columns.Add("aug_employer", GetType(String))
                    .Columns.Add("sep_employer", GetType(String))
                    .Columns.Add("oct_employer", GetType(String))
                    .Columns.Add("nov_employer", GetType(String))
                    .Columns.Add("dec_employer", GetType(String))
                    .Columns.Add("jan_based_amt", GetType(String))
                    .Columns.Add("feb_based_amt", GetType(String))
                    .Columns.Add("mar_based_amt", GetType(String))
                    .Columns.Add("apr_based_amt", GetType(String))
                    .Columns.Add("may_based_amt", GetType(String))
                    .Columns.Add("jun_based_amt", GetType(String))
                    .Columns.Add("jul_based_amt", GetType(String))
                    .Columns.Add("aug_based_amt", GetType(String))
                    .Columns.Add("sep_based_amt", GetType(String))
                    .Columns.Add("oct_based_amt", GetType(String))
                    .Columns.Add("nov_based_amt", GetType(String))
                    .Columns.Add("dec_based_amt", GetType(String))

                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_tax_premium(ByVal paramID As String, act_year As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY14"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramID" + """:""" + paramID + """," &
                     """" + "act_year" + """:""" + act_year + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("jan_employee", GetType(String))
                    .Columns.Add("feb_employee", GetType(String))
                    .Columns.Add("mar_employee", GetType(String))
                    .Columns.Add("apr_employee", GetType(String))
                    .Columns.Add("may_employee", GetType(String))
                    .Columns.Add("jun_employee", GetType(String))
                    .Columns.Add("jul_employee", GetType(String))
                    .Columns.Add("aug_employee", GetType(String))
                    .Columns.Add("sep_employee", GetType(String))
                    .Columns.Add("oct_employee", GetType(String))
                    .Columns.Add("nov_employee", GetType(String))
                    .Columns.Add("dec_employee", GetType(String))
                    .Columns.Add("jan_employer", GetType(String))
                    .Columns.Add("feb_employer", GetType(String))
                    .Columns.Add("mar_employer", GetType(String))
                    .Columns.Add("apr_employer", GetType(String))
                    .Columns.Add("may_employer", GetType(String))
                    .Columns.Add("jun_employer", GetType(String))
                    .Columns.Add("jul_employer", GetType(String))
                    .Columns.Add("aug_employer", GetType(String))
                    .Columns.Add("sep_employer", GetType(String))
                    .Columns.Add("oct_employer", GetType(String))
                    .Columns.Add("nov_employer", GetType(String))
                    .Columns.Add("dec_employer", GetType(String))
                    .Columns.Add("jan_based_amt", GetType(String))
                    .Columns.Add("feb_based_amt", GetType(String))
                    .Columns.Add("mar_based_amt", GetType(String))
                    .Columns.Add("apr_based_amt", GetType(String))
                    .Columns.Add("may_based_amt", GetType(String))
                    .Columns.Add("jun_based_amt", GetType(String))
                    .Columns.Add("jul_based_amt", GetType(String))
                    .Columns.Add("aug_based_amt", GetType(String))
                    .Columns.Add("sep_based_amt", GetType(String))
                    .Columns.Add("oct_based_amt", GetType(String))
                    .Columns.Add("nov_based_amt", GetType(String))
                    .Columns.Add("dec_based_amt", GetType(String))

                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_rate_premium(ByVal paramID As String, act_year As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY15"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramID" + """:""" + paramID + """," &
                     """" + "act_year" + """:""" + act_year + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("jan_basic", GetType(String))
                    .Columns.Add("feb_basic", GetType(String))
                    .Columns.Add("mar_basic", GetType(String))
                    .Columns.Add("apr_basic", GetType(String))
                    .Columns.Add("may_basic", GetType(String))
                    .Columns.Add("jun_basic", GetType(String))
                    .Columns.Add("jul_basic", GetType(String))
                    .Columns.Add("aug_basic", GetType(String))
                    .Columns.Add("sep_basic", GetType(String))
                    .Columns.Add("oct_basic", GetType(String))
                    .Columns.Add("nov_basic", GetType(String))
                    .Columns.Add("dec_basic", GetType(String))
                    .Columns.Add("jan_actbasic", GetType(String))
                    .Columns.Add("feb_actbasic", GetType(String))
                    .Columns.Add("mar_actbasic", GetType(String))
                    .Columns.Add("apr_actbasic", GetType(String))
                    .Columns.Add("may_actbasic", GetType(String))
                    .Columns.Add("jun_actbasic", GetType(String))
                    .Columns.Add("jul_actbasic", GetType(String))
                    .Columns.Add("aug_actbasic", GetType(String))
                    .Columns.Add("sep_actbasic", GetType(String))
                    .Columns.Add("oct_actbasic", GetType(String))
                    .Columns.Add("nov_actbasic", GetType(String))
                    .Columns.Add("dec_actbasic", GetType(String))
                    .Columns.Add("jan_gross_all", GetType(String))
                    .Columns.Add("feb_gross_all", GetType(String))
                    .Columns.Add("mar_gross_all", GetType(String))
                    .Columns.Add("apr_gross_all", GetType(String))
                    .Columns.Add("may_gross_all", GetType(String))
                    .Columns.Add("jun_gross_all", GetType(String))
                    .Columns.Add("jul_gross_all", GetType(String))
                    .Columns.Add("aug_gross_all", GetType(String))
                    .Columns.Add("sep_gross_all", GetType(String))
                    .Columns.Add("oct_gross_all", GetType(String))
                    .Columns.Add("nov_gross_all", GetType(String))
                    .Columns.Add("dec_gross_all", GetType(String))
                    .Columns.Add("jan_gross_tax", GetType(String))
                    .Columns.Add("feb_gross_tax", GetType(String))
                    .Columns.Add("mar_gross_tax", GetType(String))
                    .Columns.Add("apr_gross_tax", GetType(String))
                    .Columns.Add("may_gross_tax", GetType(String))
                    .Columns.Add("jun_gross_tax", GetType(String))
                    .Columns.Add("jul_gross_tax", GetType(String))
                    .Columns.Add("aug_gross_tax", GetType(String))
                    .Columns.Add("sep_gross_tax", GetType(String))
                    .Columns.Add("oct_gross_tax", GetType(String))
                    .Columns.Add("nov_gross_tax", GetType(String))
                    .Columns.Add("dec_gross_tax", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_forecasted_rate_loading(ByVal myIDs As String, ByVal paramCutoff As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY16"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "myIDs" + """:""" + myIDs + """," &
                     """" + "paramCutoff" + """:""" + paramCutoff + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("f_rate", GetType(String))
                    .Columns.Add("effectivity", GetType(String))
                    .Columns.Add("flag", GetType(String))
                    .Columns.Add("applicable_cutoff", GetType(String))
                    .Columns.Add("current_rate", GetType(String))
                    .Columns.Add("current_paymode", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_daily_attendance_sumarry_shift_loading(ByVal myIDs As String, ByVal paramCutoff As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY17"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "myIDs" + """:""" + myIDs + """," &
                     """" + "paramCutoff" + """:""" + paramCutoff + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("shift_min", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_daily_attendance_amount_sumarry(ByVal myIDs As String, ByVal dateEffect As Date, ByVal dateEffect_To As Date) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY18"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "myIDs" + """:""" + myIDs + """," &
                     """" + "dateEffect" + """:""" + dateEffect + """," &
                     """" + "dateEffect_To" + """:""" + dateEffect_To + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("late", GetType(String))
                    .Columns.Add("undertime", GetType(String))
                    .Columns.Add("absent_hrs", GetType(String))

                    .Columns.Add("reghrs", GetType(String))
                    .Columns.Add("reghrsot", GetType(String))
                    .Columns.Add("regnp", GetType(String))
                    .Columns.Add("regnpot", GetType(String))
                    .Columns.Add("ashf_reghrsot", GetType(String))
                    .Columns.Add("adv_reghrsot", GetType(String))

                    .Columns.Add("rsthrs", GetType(String))
                    .Columns.Add("rstot", GetType(String))
                    .Columns.Add("rstnp", GetType(String))
                    .Columns.Add("rstnpot", GetType(String))
                    .Columns.Add("ashf_rsthrsot", GetType(String))
                    .Columns.Add("adv_rsthrsot", GetType(String))

                    .Columns.Add("splhrs", GetType(String))
                    .Columns.Add("splhrsot", GetType(String))
                    .Columns.Add("splnp", GetType(String))
                    .Columns.Add("splnpot", GetType(String))
                    .Columns.Add("ashf_splhrsot", GetType(String))
                    .Columns.Add("adv_splhrsot", GetType(String))

                    .Columns.Add("cmphrs", GetType(String))
                    .Columns.Add("cmphrsot", GetType(String))
                    .Columns.Add("cmpnp", GetType(String))
                    .Columns.Add("cmpnpot", GetType(String))
                    .Columns.Add("ashf_cmphrsot", GetType(String))
                    .Columns.Add("adv_cmphrsot", GetType(String))

                    .Columns.Add("lghrs", GetType(String))
                    .Columns.Add("lghrsot", GetType(String))
                    .Columns.Add("lgnp", GetType(String))
                    .Columns.Add("lgnpot", GetType(String))
                    .Columns.Add("ashf_lghrsot", GetType(String))
                    .Columns.Add("adv_lghrsot", GetType(String))

                    .Columns.Add("rstsplhrs", GetType(String))
                    .Columns.Add("rstsplhrsot", GetType(String))
                    .Columns.Add("rstsplnp", GetType(String))
                    .Columns.Add("rstsplnpot", GetType(String))
                    .Columns.Add("ashf_rstsplhrsot", GetType(String))
                    .Columns.Add("adv_rstsplhrsot", GetType(String))

                    .Columns.Add("rstlghrs", GetType(String))
                    .Columns.Add("rstlghrsot", GetType(String))
                    .Columns.Add("rstlgnp", GetType(String))
                    .Columns.Add("rstlgnpot", GetType(String))
                    .Columns.Add("ashf_rstlghrsot", GetType(String))
                    .Columns.Add("adv_rstlghrsot", GetType(String))

                    .Columns.Add("rstcmphrs", GetType(String))
                    .Columns.Add("rstcmphrsot", GetType(String))
                    .Columns.Add("rstcmpnp", GetType(String))
                    .Columns.Add("rstcmpnpot", GetType(String))
                    .Columns.Add("ashf_rstcmphrsot", GetType(String))
                    .Columns.Add("adv_rstcmphrsot", GetType(String))

                    .Columns.Add("acchrs", GetType(String))
                    .Columns.Add("leavewpay", GetType(String))
                    .Columns.Add("leavewopay", GetType(String))
                    .Columns.Add("legal_pay", GetType(String))
                    .Columns.Add("hourlyDiv", GetType(String))
                    .Columns.Add("excess_late_deduct", GetType(String))

                    .Columns.Add("formulated_shift", GetType(String))
                    .Columns.Add("sl_wpay", GetType(String))
                    .Columns.Add("vl_wpay", GetType(String))
                    .Columns.Add("el_wpay", GetType(String))
                    .Columns.Add("pl_wpay", GetType(String))
                    .Columns.Add("ml_wpay", GetType(String))
                    .Columns.Add("ul_wpay", GetType(String))
                    .Columns.Add("ol_wpay", GetType(String))
                    .Columns.Add("xl_wpay", GetType(String))
                    .Columns.Add("al_wpay", GetType(String))
                    .Columns.Add("ashf_calculated_ot", GetType(String))
                    .Columns.Add("adv_calculated_ot", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_OtherSettings() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY19"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("longevity_releasing", GetType(String))
                    .Columns.Add("longevity_actual_release", GetType(String))
                    .Columns.Add("longevity_yearly_release", GetType(String))
                    .Columns.Add("longevity_releasing_option", GetType(String))
                    .Columns.Add("payroll_standard", GetType(String))
                    .Columns.Add("longevity_dtr_cleared", GetType(String))
                    .Columns.Add("deduct_premium_wo_id", GetType(String))
                    .Columns.Add("annualized_based_hdmf_deduct_all", GetType(String))
                    .Columns.Add("monthly_absent_standard", GetType(String))
                    .Columns.Add("annualize_standard", GetType(String))
                    .Columns.Add("late_per_min", GetType(String))
                    .Columns.Add("ut_record_purpose", GetType(String))
                    .Columns.Add("halfcont_prem", GetType(String))
                    .Columns.Add("othrs_min", GetType(String))
                    .Columns.Add("ovr_hdmfntax", GetType(String))
                    .Columns.Add("deduct_late_payroll", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_prevcutoff_absenthrs(ByVal paramID As String, ByVal prvCutOff As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY20"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramID" + """:""" + paramID + """," &
                     """" + "prvCutOff" + """:""" + prvCutOff + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("cutoff", GetType(String))
                    .Columns.Add("late", GetType(String))
                    .Columns.Add("undertime", GetType(String))
                    .Columns.Add("absent_hrs", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_cutoff_config(ByVal paramCutoff As String, ByVal ActiveCompany As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY21"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramCutoff" + """:""" + paramCutoff + """," &
                     """" + "ActiveCompany" + """:""" + ActiveCompany + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("cutoff", GetType(String))
                    .Columns.Add("taxwithheld", GetType(String))
                    .Columns.Add("taxmode", GetType(String))

                    ' Savings and tax-related fields
                    .Columns.Add("mp2_savings", GetType(String))
                    .Columns.Add("tax_based", GetType(String))
                    .Columns.Add("phealth_prem", GetType(String))
                    .Columns.Add("phealth_based", GetType(String))
                    .Columns.Add("sss_prem", GetType(String))
                    .Columns.Add("sss_based", GetType(String))
                    .Columns.Add("hdmf_prem", GetType(String))
                    .Columns.Add("hdmf_based", GetType(String))
                    .Columns.Add("gsis_prem", GetType(String))
                    .Columns.Add("gsis_based", GetType(String))
                    .Columns.Add("medicare_prem", GetType(String))
                    .Columns.Add("medicare_based", GetType(String))

                    ' Loan fields
                    .Columns.Add("loan_sss_sal", GetType(String))
                    .Columns.Add("loan_sss_cal", GetType(String))
                    .Columns.Add("loan_sss_emr", GetType(String))
                    .Columns.Add("loan_hdmf_sal", GetType(String))
                    .Columns.Add("loan_hdmf_cal", GetType(String))
                    .Columns.Add("loan_hdmf_hou", GetType(String))
                    .Columns.Add("loan_gsis_sal", GetType(String))
                    .Columns.Add("loan_gsis_pol", GetType(String))
                    .Columns.Add("loan_gsis_emr", GetType(String))
                    .Columns.Add("loan_company_1", GetType(String))
                    .Columns.Add("loan_company_2", GetType(String))
                    .Columns.Add("loan_company_3", GetType(String))
                    .Columns.Add("loan_company_4", GetType(String))
                    .Columns.Add("loan_company_5", GetType(String))
                    .Columns.Add("loan_company_6", GetType(String))
                    .Columns.Add("loan_multiple", GetType(String))

                    ' Benefits and deductions
                    .Columns.Add("sharedben", GetType(String))
                    .Columns.Add("b_5days", GetType(String))
                    .Columns.Add("b_13thmonth", GetType(String))
                    .Columns.Add("b_13thmonth_based", GetType(String))
                    .Columns.Add("othDed", GetType(String))
                    .Columns.Add("othEarn", GetType(String))
                    .Columns.Add("net_dec_savings", GetType(String))

                    ' Payroll info
                    .Columns.Add("payroll_type", GetType(String))
                    .Columns.Add("half_pay", GetType(String))
                    .Columns.Add("payroll_date", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_13thmonth_loading() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY22"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("my13_given", GetType(String))
                    .Columns.Add("include_13", GetType(String))
                    .Columns.Add("my13_givencutoff", GetType(String))
                    .Columns.Add("my14_given", GetType(String))
                    .Columns.Add("include_14", GetType(String))
                    .Columns.Add("my14_givencutoff", GetType(String))
                    .Columns.Add("my15_given", GetType(String))
                    .Columns.Add("include_15", GetType(String))
                    .Columns.Add("my15_givencutoff", GetType(String))
                    .Columns.Add("my16_given", GetType(String))
                    .Columns.Add("include_16", GetType(String))
                    .Columns.Add("my16_givencutoff", GetType(String))
                    .Columns.Add("ttl13", GetType(String))
                    .Columns.Add("ttl14", GetType(String))
                    .Columns.Add("ttl15", GetType(String))
                    .Columns.Add("ttl16", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_fixed_earnings_payroll(ByVal paramID As String, ByVal dateeffectivity_ As Date) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY25"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramID" + """:""" + paramID + """," &
                     """" + "varDateEffectivity" + """:""" + dateeffectivity_ + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("divcode", GetType(String))
                    .Columns.Add("inccode", GetType(String))
                    .Columns.Add("amt", GetType(Decimal))
                    .Columns.Add("formula", GetType(String))
                    .Columns.Add("proc", GetType(Boolean))
                    .Columns.Add("nontaxable", GetType(Boolean))
                    .Columns.Add("dateeffectivity", GetType(Date))
                    .Columns.Add("frequent", GetType(String))
                    .Columns.Add("override", GetType(Boolean))
                    .Columns.Add("payroll_type", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_other_earnings_payroll(ByVal entry_ID As String, ByVal cutoff_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY29"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramID" + """:""" + paramID + """," &
                     """" + "cutoff_" + """:""" + cutoff_ + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("divcode", GetType(String))
                    .Columns.Add("inccode", GetType(String))
                    .Columns.Add("amt", GetType(Decimal))
                    .Columns.Add("formula", GetType(String))
                    .Columns.Add("proc", GetType(Boolean))
                    .Columns.Add("nontaxable", GetType(Boolean))
                    .Columns.Add("override", GetType(Boolean))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_cummulative_tax_annualized_period(ByVal idno_ As String, ByVal yr_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY32"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "varID" + """:""" + idno_ + """," &
                     """" + "yr_" + """:""" + yr_ + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("period_", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_cummulative_tax_annualized_payroll(ByVal idno_ As String, ByVal yr_ As String, ByVal myperiod_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY33"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "varID" + """:""" + idno_ + """," &
                     """" + "yr_" + """:""" + yr_ + """," &
                     """" + "myperiod_" + """:""" + myperiod_ + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("cutoff", GetType(String))
                    .Columns.Add("basic_pay", GetType(String))
                    .Columns.Add("taxable_gross", GetType(String))
                    .Columns.Add("total_income", GetType(String))
                    .Columns.Add("cummulative_ytd_income", GetType(String))
                    .Columns.Add("average_income", GetType(String))
                    .Columns.Add("estimated_annual_income", GetType(String))
                    .Columns.Add("estimated_annual_taxdue", GetType(String))
                    .Columns.Add("ytd_taxdue", GetType(String))
                    .Columns.Add("recommended_tax_deduction", GetType(String))
                    .Columns.Add("cummulative_ytd_actual_tax", GetType(String))
                    .Columns.Add("period_ctr", GetType(String))
                    .Columns.Add("proc_year", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_oth_incl_basedon(ByVal paramID As String, ByVal varCutoff As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY34"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramID" + """:""" + paramID + """," &
                     """" + "varCutoff" + """:""" + varCutoff + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("inccode", GetType(String))
                    .Columns.Add("amt", GetType(String))
                    .Columns.Add("incl_based_on", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function get_fx_incl_basedon(ByVal paramID As String, ByVal dateeffectivity As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY35"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramID" + """:""" + paramID + """," &
                     """" + "dateeffectivity" + """:""" + dateeffectivity + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("inccode", GetType(String))
                    .Columns.Add("amt", GetType(String))
                    .Columns.Add("incl_based_on", GetType(String))
                    .Columns.Add("frequent", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    'Contributions Table
    Public Function get_gsis_table() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY36"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("emplyshare", GetType(String))
                    .Columns.Add("emplrshare", GetType(String))
                    .Columns.Add("ecc", GetType(String))
                    .Columns.Add("ehp", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_sss_table() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY37"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("lowerlim", GetType(String))
                    .Columns.Add("upperlim", GetType(String))
                    .Columns.Add("emplyshare", GetType(String))
                    .Columns.Add("emplrshare", GetType(String))
                    .Columns.Add("ecc", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_hdmf_table() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY38"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("lowerlim", GetType(String))
                    .Columns.Add("upperlim", GetType(String))
                    .Columns.Add("emplyshare", GetType(String))
                    .Columns.Add("emplrshare", GetType(String))
                    .Columns.Add("amount_ntx", GetType(String))
                    .Columns.Add("percentage", GetType(String))
                    .Columns.Add("round_off", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_phealth_table() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY39"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("lowerlim", GetType(String))
                    .Columns.Add("upperlim", GetType(String))
                    .Columns.Add("emplyshare", GetType(String))
                    .Columns.Add("emplrshare", GetType(String))
                    .Columns.Add("percentage", GetType(String))
                    .Columns.Add("percentage_total", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_tax_table() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY40"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("taxmode", GetType(String))
                    .Columns.Add("taxcode", GetType(String))
                    .Columns.Add("p", GetType(String))
                    .Columns.Add("ntax_allow", GetType(String))
                    .Columns.Add("BRACKET1", GetType(String))
                    .Columns.Add("BRACKET2", GetType(String))
                    .Columns.Add("BRACKET3", GetType(String))
                    .Columns.Add("BRACKET4", GetType(String))
                    .Columns.Add("BRACKET5", GetType(String))
                    .Columns.Add("BRACKET6", GetType(String))
                    .Columns.Add("BRACKET7", GetType(String))
                    .Columns.Add("BRACKET8", GetType(String))
                    .Columns.Add("BRACKETPNT1", GetType(String))
                    .Columns.Add("BRACKETPNT2", GetType(String))
                    .Columns.Add("BRACKETPNT3", GetType(String))
                    .Columns.Add("BRACKETPNT4", GetType(String))
                    .Columns.Add("BRACKETPNT5", GetType(String))
                    .Columns.Add("BRACKETPNT6", GetType(String))
                    .Columns.Add("BRACKETPNT7", GetType(String))
                    .Columns.Add("BRACKETPNT8", GetType(String))
                    .Columns.Add("BRACKETADD1", GetType(String))
                    .Columns.Add("BRACKETADD2", GetType(String))
                    .Columns.Add("BRACKETADD3", GetType(String))
                    .Columns.Add("BRACKETADD4", GetType(String))
                    .Columns.Add("BRACKETADD5", GetType(String))
                    .Columns.Add("BRACKETADD6", GetType(String))
                    .Columns.Add("BRACKETADD7", GetType(String))
                    .Columns.Add("BRACKETADD8", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_previous_employer_records(idno_ As String, year_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY41"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("sss_prv", GetType(String))
                    .Columns.Add("ph_prv", GetType(String))
                    .Columns.Add("hdmf_prv", GetType(String))
                    .Columns.Add("taxwitheld", GetType(String))
                    .Columns.Add("taxable_income", GetType(String))
                    .Columns.Add("tax_13th_month", GetType(String))
                    .Columns.Add("ntax_13th_month", GetType(String))
                    .Columns.Add("tax_year", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_sharedbengross(idno_ As String, ct_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY42"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "idno_" + """:""" + idno_ + """," &
                     """" + "ct_" + """:""" + ct_ + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("sharedbengross", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_sss_taxgross(idno_ As String, ct_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY43"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "idno_" + """:""" + idno_ + """," &
                     """" + "ct_" + """:""" + ct_ + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("taxgross", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_phealth_taxgross(idno_ As String, ct_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY44"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "idno_" + """:""" + idno_ + """," &
                     """" + "ct_" + """:""" + ct_ + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("taxgross", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_payroll_annualized_based_hdmf(idno_ As String, year_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY45"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "idno_" + """:""" + idno_ + """," &
                     """" + "year_" + """:""" + year_ + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("process_year", GetType(String))
                    .Columns.Add("cnt_idno", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_hdmf_yee_taxgross(idno_ As String, ct_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY46"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "idno_" + """:""" + idno_ + """," &
                     """" + "ct_" + """:""" + ct_ + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("taxgross", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_gsis_yee_taxgross(idno_ As String, ct_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY47"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "idno_" + """:""" + idno_ + """," &
                     """" + "ct_" + """:""" + ct_ + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("taxgross", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_annual_earning_taxable_amt(idno_ As String, yr_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY48"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "idno_" + """:""" + idno_ + """," &
                     """" + "yr_" + """:""" + yr_ + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("amt", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_health_insurance_expenses_amount(idno_ As String, yr_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY49"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "idno_" + """:""" + idno_ + """," &
                     """" + "yr_" + """:""" + yr_ + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("exps_amt", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_nontaxable_other_earnings_de_minimis(idno_ As String, yr_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY50"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "idno_" + """:""" + idno_ + """," &
                     """" + "yr_" + """:""" + yr_ + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("month_", GetType(String))
                    .Columns.Add("ntaxEarnings", GetType(String))
                    .Columns.Add("inc", GetType(String))
                    .Columns.Add("ceiling_config", GetType(String))
                    .Columns.Add("ceiling", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_nontaxable_other_earnings_not_de_minimis(idno_ As String, yr_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY51"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "idno_" + """:""" + idno_ + """," &
                     """" + "yr_" + """:""" + yr_ + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("ntaxEarnings", GetType(String))
                    .Columns.Add("ceiling", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_nontaxable_fix_earnings_not_de_minimis(idno_ As String, yr_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY52"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "idno_" + """:""" + idno_ + """," &
                     """" + "yr_" + """:""" + yr_ + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("month_", GetType(String))
                    .Columns.Add("ntaxEarnings", GetType(String))
                    .Columns.Add("inc", GetType(String))
                    .Columns.Add("ceiling_config", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_ceiling_inc(inc As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY53"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "inc" + """:""" + inc + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("ceiling", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_nontaxable_fix_earnings_not_de_minimis_13mon(idno_ As String, ct_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY54"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "idno_" + """:""" + idno_ + """," &
                     """" + "ct_" + """:""" + ct_ + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("ntaxEarnings", GetType(String))
                    .Columns.Add("ceiling", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_exclude_alpha_earnings_oth(idno_ As String, ct_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY55"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "idno_" + """:""" + idno_ + """," &
                     """" + "ct_" + """:""" + ct_ + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("ntaxEarnings", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_exclude_alpha_earnings_fx(idno_ As String, ct_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY56"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "idno_" + """:""" + idno_ + """," &
                     """" + "ct_" + """:""" + ct_ + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("ntaxEarnings", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_ttl13mon_yearly_otherearning(idno_ As String, ct_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY57"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "idno_" + """:""" + idno_ + """," &
                     """" + "ct_" + """:""" + ct_ + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("ntaxEarnings", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_tax_annualized_taxgross(idno_ As String, ct_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY58"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "idno_" + """:""" + idno_ + """," &
                     """" + "ct_" + """:""" + ct_ + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("taxgross", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_tax_annualized_taxgross_actual_basic(idno_ As String, ct_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY59"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "idno_" + """:""" + idno_ + """," &
                     """" + "ct_" + """:""" + ct_ + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("taxgross", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_tax_annualized_taxgross_basic_pay(idno_ As String, ct_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY60"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "idno_" + """:""" + idno_ + """," &
                     """" + "ct_" + """:""" + ct_ + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("taxgross", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_tax_annualized_taxgross_tax_collection(idno_ As String, ct_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY61"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "idno_" + """:""" + idno_ + """," &
                     """" + "ct_" + """:""" + ct_ + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("taxgross", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_tax_annualized_taxgross_tax_deduct(idno_ As String, ct_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY62"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "idno_" + """:""" + idno_ + """," &
                     """" + "ct_" + """:""" + ct_ + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("taxgross", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_health_benefits_ledger_payroll(paramID As String, varCutoff As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY63"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramID" + """:""" + paramID + """," &
                     """" + "varCutoff" + """:""" + varCutoff + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("bencode", GetType(String))
                    .Columns.Add("cutoff", GetType(String))
                    .Columns.Add("amt_", GetType(String))
                    .Columns.Add("year_entry", GetType(String))
                    .Columns.Add("tax_exempt", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_benefits_insurance_payroll(varCutoff As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY65"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "varCutoff" + """:""" + varCutoff + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("benefitcode", GetType(String))
                    .Columns.Add("date_start", GetType(String))
                    .Columns.Add("frequent", GetType(String))
                    .Columns.Add("employee_share", GetType(String))
                    .Columns.Add("employer_share", GetType(String))
                    .Columns.Add("ddctcode", GetType(String))
                    .Columns.Add("tax_deductible", GetType(String))
                    .Columns.Add("yer_table_based", GetType(String))
                    .Columns.Add("yee_table_based", GetType(String))
                    .Columns.Add("yrs", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_pay_earnings_deminimis(paramID As String, cut_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY68"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramID" + """:""" + paramID + """," &
                     """" + "cut_" + """:""" + cut_ + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("amt", GetType(String))
                    .Columns.Add("ceiling_amount", GetType(String))
                    .Columns.Add("inccode", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_pay_earnings_ntax(paramID As String, cut_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY69"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramID" + """:""" + paramID + """," &
                     """" + "cut_" + """:""" + cut_ + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("amt", GetType(String))
                    .Columns.Add("ceiling_amount", GetType(String))
                    .Columns.Add("inccode", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_excess_deduct_payroll(idno_ As String, ct_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY70"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "idno_" + """:""" + idno_ + """," &
                     """" + "ct_" + """:""" + ct_ + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("ntaxable_excess", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_projected_tax_payroll(idno_ As String, yr_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY71"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "idno_" + """:""" + idno_ + """," &
                     """" + "yr_" + """:""" + yr_ + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("divcode", GetType(String))
                    .Columns.Add("taxcode", GetType(String))
                    .Columns.Add("term", GetType(String))
                    .Columns.Add("procyear", GetType(String))
                    .Columns.Add("monthly_rate", GetType(String))
                    .Columns.Add("deminimis", GetType(String))
                    .Columns.Add("ntaxable", GetType(String))
                    .Columns.Add("taxable", GetType(String))
                    .Columns.Add("gsis_prem", GetType(String))
                    .Columns.Add("gsis_based_on", GetType(String))
                    .Columns.Add("sss_prem", GetType(String))
                    .Columns.Add("sss_based_on", GetType(String))
                    .Columns.Add("hdmf_prem", GetType(String))
                    .Columns.Add("hdmf_based_on", GetType(String))
                    .Columns.Add("phealth_prem", GetType(String))
                    .Columns.Add("phealth_based_on", GetType(String))
                    .Columns.Add("tax_based_on", GetType(String))
                    .Columns.Add("tax_exemption", GetType(String))
                    .Columns.Add("tax_based_amt", GetType(String))
                    .Columns.Add("mygov_tax", GetType(String))
                    .Columns.Add("override_status", GetType(String))
                    .Columns.Add("gsis_prem_ovr", GetType(String))
                    .Columns.Add("sss_prem_ovr", GetType(String))
                    .Columns.Add("hdmf_prem_ovr", GetType(String))
                    .Columns.Add("phealth_prem_ovr", GetType(String))
                    .Columns.Add("gsis_amt", GetType(String))
                    .Columns.Add("sss_amt", GetType(String))
                    .Columns.Add("hdmf_amt", GetType(String))
                    .Columns.Add("phic_amt", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_yearend_taxadjustment_payroll(myIDs As String, year_ As String, varCutoff As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY75"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramID" + """:""" + myIDs + """," &
                     """" + "year_" + """:""" + year_ + """," &
                     """" + "varCutoff" + """:""" + varCutoff + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("remaining", GetType(String))
                    .Columns.Add("earning_code", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_fixdeductions_payroll(myidno As String, varDateEffectivity As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY79"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramID" + """:""" + myidno + """," &
                     """" + "varDateEffectivity" + """:""" + varDateEffectivity + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable.Columns
                    .Add("idno", GetType(String))
                    .Add("proc", GetType(String))
                    .Add("divcode", GetType(String))
                    .Add("ddctcode", GetType(String))
                    .Add("formula", GetType(String))
                    .Add("amt", GetType(String))
                    .Add("nontaxable", GetType(String))
                    .Add("frequent", GetType(String))
                    .Add("dateeffectivity", GetType(String))
                    .Add("shared_code", GetType(String))
                    .Add("deduct_to_grossall", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_other_deductions_payroll(entry_ID As String, varCutoff As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY81"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramID" + """:""" + entry_ID + """," &
                     """" + "varCutoff" + """:""" + varCutoff + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable.Columns
                    .Add("idno", GetType(String))
                    .Add("proc", GetType(String))
                    .Add("divcode", GetType(String))
                    .Add("ddctcode", GetType(String))
                    .Add("formula", GetType(String))
                    .Add("amt", GetType(String))
                    .Add("nontaxable", GetType(String))
                    .Add("override", GetType(String))
                    .Add("deduct_to_grossall", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_loan_sss_payroll(myidno As String, fpayment As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY83"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramID" + """:""" + myidno + """," &
                     """" + "fpayment" + """:""" + fpayment + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable.Columns
                    .Add("idno", GetType(String))
                    .Add("mnth_amort", GetType(String))
                    .Add("act_amort", GetType(String))
                    .Add("lastpcode", GetType(String))
                    .Add("loantyp", GetType(String))
                    .Add("loanno", GetType(String))
                    .Add("proc", GetType(String))
                    .Add("balance", GetType(String))
                    .Add("frequent", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_loan_pagibig_payroll(myidno As String, fpayment As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY85"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramID" + """:""" + myidno + """," &
                     """" + "fpayment" + """:""" + fpayment + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable.Columns
                    .Add("idno", GetType(String))
                    .Add("mnth_amort", GetType(String))
                    .Add("act_amort", GetType(String))
                    .Add("lastpcode", GetType(String))
                    .Add("loantyp", GetType(String))
                    .Add("loanno", GetType(String))
                    .Add("proc", GetType(String))
                    .Add("balance", GetType(String))
                    .Add("frequent", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_loan_gsis_payroll(myidno As String, fpayment As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY87"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramID" + """:""" + myidno + """," &
                     """" + "fpayment" + """:""" + fpayment + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable.Columns
                    .Add("idno", GetType(String))
                    .Add("mnth_amort", GetType(String))
                    .Add("act_amort", GetType(String))
                    .Add("lastpcode", GetType(String))
                    .Add("loantyp", GetType(String))
                    .Add("loanno", GetType(String))
                    .Add("proc", GetType(String))
                    .Add("balance", GetType(String))
                    .Add("frequent", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_loan_multiple_payroll(myidno As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY90"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramID" + """:""" + myidno + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable.Columns
                    .Add("idno", GetType(String))

                    ' amort columns
                    .Add("amort", GetType(String))
                    .Add("amort1", GetType(String))
                    .Add("amort2", GetType(String))
                    .Add("amort3", GetType(String))
                    .Add("amort4", GetType(String))
                    .Add("amort5", GetType(String))
                    .Add("amort6", GetType(String))
                    .Add("amort7", GetType(String))
                    .Add("amort8", GetType(String))
                    .Add("amort9", GetType(String))
                    .Add("amort10", GetType(String))
                    .Add("amort11", GetType(String))
                    .Add("amort12", GetType(String))
                    .Add("amort13", GetType(String))
                    .Add("amort14", GetType(String))

                    ' balance columns
                    .Add("balance", GetType(String))
                    .Add("balance1", GetType(String))
                    .Add("balance2", GetType(String))
                    .Add("balance3", GetType(String))
                    .Add("balance4", GetType(String))
                    .Add("balance5", GetType(String))
                    .Add("balance6", GetType(String))
                    .Add("balance7", GetType(String))
                    .Add("balance8", GetType(String))
                    .Add("balance9", GetType(String))
                    .Add("balance10", GetType(String))
                    .Add("balance11", GetType(String))
                    .Add("balance12", GetType(String))
                    .Add("balance13", GetType(String))
                    .Add("balance14", GetType(String))

                    ' act_amort columns
                    .Add("act_amort", GetType(String))
                    .Add("act_amort1", GetType(String))
                    .Add("act_amort2", GetType(String))
                    .Add("act_amort3", GetType(String))
                    .Add("act_amort4", GetType(String))
                    .Add("act_amort5", GetType(String))
                    .Add("act_amort6", GetType(String))
                    .Add("act_amort7", GetType(String))
                    .Add("act_amort8", GetType(String))
                    .Add("act_amort9", GetType(String))
                    .Add("act_amort10", GetType(String))
                    .Add("act_amort11", GetType(String))
                    .Add("act_amort12", GetType(String))
                    .Add("act_amort13", GetType(String))
                    .Add("act_amort14", GetType(String))

                    ' lastpcode columns
                    .Add("lastpcode", GetType(String))
                    .Add("lastpcode1", GetType(String))
                    .Add("lastpcode2", GetType(String))
                    .Add("lastpcode3", GetType(String))
                    .Add("lastpcode4", GetType(String))
                    .Add("lastpcode5", GetType(String))
                    .Add("lastpcode6", GetType(String))
                    .Add("lastpcode7", GetType(String))
                    .Add("lastpcode8", GetType(String))
                    .Add("lastpcode9", GetType(String))
                    .Add("lastpcode10", GetType(String))
                    .Add("lastpcode11", GetType(String))
                    .Add("lastpcode12", GetType(String))
                    .Add("lastpcode13", GetType(String))
                    .Add("lastpcode14", GetType(String))

                    ' proc columns
                    .Add("proc", GetType(String))
                    .Add("proc1", GetType(String))
                    .Add("proc2", GetType(String))
                    .Add("proc3", GetType(String))
                    .Add("proc4", GetType(String))
                    .Add("proc5", GetType(String))
                    .Add("proc6", GetType(String))
                    .Add("proc7", GetType(String))
                    .Add("proc8", GetType(String))
                    .Add("proc9", GetType(String))
                    .Add("proc10", GetType(String))
                    .Add("proc11", GetType(String))
                    .Add("proc12", GetType(String))
                    .Add("proc13", GetType(String))
                    .Add("proc14", GetType(String))

                    ' sdeduct columns
                    .Add("sdeduct", GetType(String))
                    .Add("sdeduct1", GetType(String))
                    .Add("sdeduct2", GetType(String))
                    .Add("sdeduct3", GetType(String))
                    .Add("sdeduct4", GetType(String))
                    .Add("sdeduct5", GetType(String))
                    .Add("sdeduct6", GetType(String))
                    .Add("sdeduct7", GetType(String))
                    .Add("sdeduct8", GetType(String))
                    .Add("sdeduct9", GetType(String))
                    .Add("sdeduct10", GetType(String))
                    .Add("sdeduct11", GetType(String))
                    .Add("sdeduct12", GetType(String))
                    .Add("sdeduct13", GetType(String))
                    .Add("sdeduct14", GetType(String))

                    ' active columns
                    .Add("active", GetType(String))
                    .Add("active1", GetType(String))
                    .Add("active2", GetType(String))
                    .Add("active3", GetType(String))
                    .Add("active4", GetType(String))
                    .Add("active5", GetType(String))
                    .Add("active6", GetType(String))
                    .Add("active7", GetType(String))
                    .Add("active8", GetType(String))
                    .Add("active9", GetType(String))
                    .Add("active10", GetType(String))
                    .Add("active11", GetType(String))
                    .Add("active12", GetType(String))
                    .Add("active13", GetType(String))
                    .Add("active14", GetType(String))

                    ' mcode columns
                    .Add("mcode", GetType(String))
                    .Add("mcode1", GetType(String))
                    .Add("mcode2", GetType(String))
                    .Add("mcode3", GetType(String))
                    .Add("mcode4", GetType(String))
                    .Add("mcode5", GetType(String))
                    .Add("mcode6", GetType(String))
                    .Add("mcode7", GetType(String))
                    .Add("mcode8", GetType(String))
                    .Add("mcode9", GetType(String))
                    .Add("mcode10", GetType(String))
                    .Add("mcode11", GetType(String))
                    .Add("mcode12", GetType(String))
                    .Add("mcode13", GetType(String))
                    .Add("mcode14", GetType(String))

                    ' frequent columns
                    .Add("frequent", GetType(String))
                    .Add("frequent1", GetType(String))
                    .Add("frequent2", GetType(String))
                    .Add("frequent3", GetType(String))
                    .Add("frequent4", GetType(String))
                    .Add("frequent5", GetType(String))
                    .Add("frequent6", GetType(String))
                    .Add("frequent7", GetType(String))
                    .Add("frequent8", GetType(String))
                    .Add("frequent9", GetType(String))
                    .Add("frequent10", GetType(String))
                    .Add("frequent11", GetType(String))
                    .Add("frequent12", GetType(String))
                    .Add("frequent13", GetType(String))
                    .Add("frequent14", GetType(String))

                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_sharedins_bracket_amt_payroll() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY115"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable.Columns
                    .Add("lowerlim", GetType(String))
                    .Add("upperlim", GetType(String))
                    .Add("ee_amount", GetType(String))
                    .Add("er_amount", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_loan_company_payroll(ByVal idno_ As String, ByVal fpayment As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY126"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable.Columns
                    .Add("lowerlim", GetType(String))
                    .Add("upperlim", GetType(String))
                    .Add("ee_amount", GetType(String))
                    .Add("er_amount", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_ftp_deductions_payroll(entry_ID As String, date_entry_from As String, date_entry_to As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY128"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramID" + """:""" + entry_ID + """," &
                     """" + "date_entry_from" + """:""" + date_entry_from + """," &
                     """" + "date_entry_to" + """:""" + date_entry_to + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("ftp_cnt", GetType(String))
                    .Columns.Add("ddctcode", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_undertime_deductions_payroll(entry_ID As String, cutoff As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY131"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramID" + """:""" + entry_ID + """," &
                     """" + "cutoff" + """:""" + cutoff + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("ut_hrs", GetType(String))
                    .Columns.Add("ddctcode", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_maintenance_cashdenominations_payroll() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY134"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("denomination", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_active_employee_electronic_log(ByVal IDNOs As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY138"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramID" + """:""" + IDNOs + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_daily_attendance_summary_list(ByVal IDNOs As String, ByVal cutoff As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY143"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramID" + """:""" + IDNOs + """," &
                     """" + "cutoff" + """:""" + cutoff + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function get_Employee_wPayroll(ByVal paramDiv As String, ByVal cutoff As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmProcessPayroll.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAY144"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramDiv" + """:""" + paramDiv + """," &
                     """" + "cutoff" + """:""" + cutoff + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("posted", GetType(String))
                End With
            End If
        Catch ex As Exception
        End Try
        Return dtable
    End Function

#End Region

#Region "Earnings"
    Public Function get_maintenance_earnings() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmMaintenanceEarning.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "EARN01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("inccode", GetType(String))
                    .Columns.Add("nontaxable", GetType(String))
                    .Columns.Add("trail", GetType(String))
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("formulated", GetType(String))
                    .Columns.Add("formula", GetType(String))
                    .Columns.Add("ceiling_amount", GetType(String))
                    .Columns.Add("deductible", GetType(String))
                    .Columns.Add("include_in_alphalisting", GetType(String))
                    .Columns.Add("payroll_type", GetType(String))
                    .Columns.Add("automatic_gross", GetType(String))
                    .Columns.Add("incl_based_on", GetType(String))
                    .Columns.Add("automatic_contra_acct", GetType(String))
                    .Columns.Add("lr_type", GetType(String))
                    .Columns.Add("ceiling_config", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
#End Region

#Region "Deductions Entry"
    Public Function getCboDeductions_Code() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "frmDeductionsEntry.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "DDCT01"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                 """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                              ServerTxt & ActiveFrm,
                              "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("ddctcode", GetType(String))
                .Columns.Add("description", GetType(String))
                .Columns.Add("formula", GetType(String))
                .Columns.Add("deduct_to_grossall", GetType(String))
                .Columns.Add("nontaxable", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getOtherDeductionEntryList(ByVal paramID As String, ByVal paramCutoff As String) As DataTable
        Dim dtable As New DataTable

        Try

            ActiveFrm = "frmDeductionsEntry.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "DDCT02"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
              """" + "paramID" + """:""" + paramID + """," &
              """" + "paramCutoff" + """:""" + paramCutoff + """," &
              """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("amt", GetType(String))
                    .Columns.Add("formula", GetType(String))
                    .Columns.Add("nontaxable", GetType(String))
                    .Columns.Add("ddctcode", GetType(String))
                    .Columns.Add("cutoff", GetType(String))
                    .Columns.Add("keyctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getFixDeductionEntryList(ByVal paramID As String) As DataTable
        Dim dtable As New DataTable

        Try

            ActiveFrm = "frmDeductionsEntry.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "DDCT05"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
              """" + "paramID" + """:""" + paramID + """," &
              """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("amt", GetType(String))
                    .Columns.Add("formula", GetType(String))
                    .Columns.Add("nontaxable", GetType(String))
                    .Columns.Add("ddctcode", GetType(String))
                    .Columns.Add("dateeffectivity", GetType(String))
                    .Columns.Add("keyctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
#End Region

#Region "SSS Loan"
    Public Function getSSSLoan(ByVal paramID As String, ByVal loan_type As String) As DataTable
        Dim dtable As New DataTable

        Try

            ActiveFrm = "frmLoan_SSS.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "SSS01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
              """" + "paramID" + """:""" + paramID + """," &
              """" + "varLoanType" + """:""" + loan_type + """," &
              """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("loanno", GetType(String))
                    .Columns.Add("loanamt", GetType(String))
                    .Columns.Add("loancapital", GetType(String))
                    .Columns.Add("granted", GetType(String))
                    .Columns.Add("term", GetType(String))
                    .Columns.Add("Mnth_Amort", GetType(String))
                    .Columns.Add("penalty_amt", GetType(String))
                    .Columns.Add("Fpayment", GetType(String))
                    .Columns.Add("LPayment", GetType(String))
                    .Columns.Add("REMARK", GetType(String))
                    .Columns.Add("Remark1", GetType(String))
                    .Columns.Add("totalpaid", GetType(String))
                    .Columns.Add("balance", GetType(String))
                    .Columns.Add("frequent", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getSSSLoanHistory(ByVal paramID As String) As DataTable
        Dim dtable As New DataTable

        Try

            ActiveFrm = "frmLoan_SSS.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "SSS02"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
              """" + "paramID" + """:""" + paramID + """," &
              """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("loanno", GetType(String))
                    .Columns.Add("loantyp", GetType(String))
                    .Columns.Add("loanamt", GetType(String))
                    .Columns.Add("granted", GetType(String))
                    .Columns.Add("term", GetType(String))
                    .Columns.Add("lpayment", GetType(String))
                    .Columns.Add("lastpcode", GetType(String))
                    .Columns.Add("remark", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getSSSLoanPaymentLedger(ByVal paramID As String) As DataTable
        Dim dtable As New DataTable

        Try

            ActiveFrm = "frmLoan_SSS.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "SSS03"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
              """" + "paramID" + """:""" + paramID + """," &
              """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("lcode", GetType(String))
                    .Columns.Add("loantyp", GetType(String))
                    .Columns.Add("cutoff", GetType(String))
                    .Columns.Add("datestart", GetType(String))
                    .Columns.Add("dateend", GetType(String))
                    .Columns.Add("amount", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
#End Region

#Region "Pag-ibig Loan"
    Public Function getHDMFLoan(ByVal paramID As String, ByVal loan_type As String) As DataTable
        Dim dtable As New DataTable

        Try

            ActiveFrm = "frmLoan_HDMF.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "HDMF01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
              """" + "paramID" + """:""" + paramID + """," &
              """" + "varLoanType" + """:""" + loan_type + """," &
              """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("loanno", GetType(String))
                    .Columns.Add("loanamt", GetType(String))
                    .Columns.Add("loancapital", GetType(String))
                    .Columns.Add("granted", GetType(String))
                    .Columns.Add("term", GetType(String))
                    .Columns.Add("Mnth_Amort", GetType(String))
                    .Columns.Add("penalty_amt", GetType(String))
                    .Columns.Add("Fpayment", GetType(String))
                    .Columns.Add("LPayment", GetType(String))
                    .Columns.Add("REMARK", GetType(String))
                    .Columns.Add("Remark1", GetType(String))
                    .Columns.Add("totalpaid", GetType(String))
                    .Columns.Add("balance", GetType(String))
                    .Columns.Add("frequent", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getHDMFLoanHistory(ByVal paramID As String) As DataTable
        Dim dtable As New DataTable

        Try

            ActiveFrm = "frmLoan_HDMF.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "HDMF02"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
              """" + "paramID" + """:""" + paramID + """," &
              """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("loanno", GetType(String))
                    .Columns.Add("loantyp", GetType(String))
                    .Columns.Add("loanamt", GetType(String))
                    .Columns.Add("granted", GetType(String))
                    .Columns.Add("term", GetType(String))
                    .Columns.Add("lpayment", GetType(String))
                    .Columns.Add("lastpcode", GetType(String))
                    .Columns.Add("remark", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getHDMFLoanPaymentLedger(ByVal paramID As String) As DataTable
        Dim dtable As New DataTable

        Try

            ActiveFrm = "frmLoan_HDMF.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "HDMF03"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
              """" + "paramID" + """:""" + paramID + """," &
              """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("lcode", GetType(String))
                    .Columns.Add("loantyp", GetType(String))
                    .Columns.Add("cutoff", GetType(String))
                    .Columns.Add("datestart", GetType(String))
                    .Columns.Add("dateend", GetType(String))
                    .Columns.Add("amount", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
#End Region

#Region "Amortized Entry"
    Public Function getMultiLoan_Code() As DataTable
        Dim dtable As New DataTable

        Try

            ActiveFrm = "frmLoan_Multiple.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "LM01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
              """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                    ServerTxt & ActiveFrm,
                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("loan_id", GetType(String))
                    .Columns.Add("loan_desc", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
#End Region

#Region "Payroll Cutoff Maintenance"
    Public Function GetPayrollCutoffMaintenance(ByVal dateend As String, ByVal company_ As String) As List(Of PayrollCutoff)
        Try
            ActiveFrm = "frmMaintenanceCutoff.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "CUT01"
            Dim inputData = New With {.token = Token, .MC = MC, .dateend = dateend, .company_ = company_}
            Dim jStr_Input As String = JsonConvert.SerializeObject(inputData)

            Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If dtable IsNot Nothing AndAlso dtable.Rows.Count > 0 Then
                Dim json As String = JsonConvert.SerializeObject(dtable)
                Return JsonConvert.DeserializeObject(Of List(Of PayrollCutoff))(json)
            End If

        Catch ex As Exception
            MessageBox.Show("Failed to load Payroll Cutoff." & vbCrLf & vbCrLf &
                            "Error: " & ex.Message,
                            "Database Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
        Return New List(Of PayrollCutoff)()
    End Function
#End Region

End Module
