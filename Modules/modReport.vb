Imports NXNParsing

Module modReport
    Private ActiveFrm As String = String.Empty
    Private jStr_Input As String = "[]"
    Private ws As New WSConnection
    Private Token As String = String.Empty

#Region "Custom Report"
    Public Function getAllEmployee_Record_Custom_Report(ByVal ActiveCompany_ As String) As DataTable
        Dim dtable As New DataTable
        Try
            ActiveFrm = "rptCustomReport.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "CUST01"
            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "ActiveCompany" + """:""" + ActiveCompany_ + """," &
                         """" + "MC" + """:""" + MC + """}"
            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno_sec", GetType(String))
                    .Columns.Add("full_name", GetType(String))
                End With
            End If
        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getAllEmployee_Record_Custom_Report_wEducational_Attainment(ByVal ActiveCompany_ As String) As DataTable
        Dim dtable As New DataTable
        Try
            ActiveFrm = "rptCustomReport.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "CUST02"
            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "ActiveCompany" + """:""" + ActiveCompany_ + """," &
                         """" + "MC" + """:""" + MC + """}"
            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno_sec", GetType(String))
                    .Columns.Add("full_name", GetType(String))
                End With
            End If
        Catch ex As Exception
        End Try
        Return dtable
    End Function
#End Region

#Region "Newly Hired Employee"
    Public Function get_newly_hired_employee(ByVal idno As String(), ByVal date_to As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "rptNewHiredEmployee.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "RPT01"
            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """idno"":[""" & String.Join(""",""", idno) & """]," &
                         """" + "date_to" + """:""" + date_to + """," &
                         """" + "MC" + """:""" + MC + """}"
            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("divcode", GetType(String))
                    .Columns.Add("deptcode", GetType(String))
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("name_", GetType(String))
                    .Columns.Add("date_hire", GetType(String))
                    .Columns.Add("ans1_", GetType(String))
                    .Columns.Add("deptcode", GetType(String))
                End With
            End If
        Catch ex As Exception
        End Try
        Return dtable
    End Function
#End Region

#Region "Report Service Record"
    Public Function getService_Record() As DataTable
        Dim dtable As New DataTable
        Try
            ActiveFrm = "rptServiceRecord.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "SVC01"
            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"
            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno_sec", GetType(String))
                    .Columns.Add("full_name", GetType(String))
                End With
            End If
        Catch ex As Exception
        End Try
        Return dtable
    End Function
#End Region

#Region "Payroll Register"
    Public Function getPayroll_Register(ByVal cutoff_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "rptPayroll_Register.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAYREG01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramCutoff" + """:""" + cutoff_ + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno_sec", GetType(String))
                    .Columns.Add("full_name", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getttlreghrs(ByVal idno As String, ByVal cutoff_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "rptPayroll_Register.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAYREG02"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + idno + """," &
                         """" + "paramCutoff" + """:""" + cutoff_ + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("ttl_reg_hrs", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getPayrollRegister_Summary_Amount(ByVal idno As String, ByVal cutoff_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "rptPayroll_Register.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAYREG03"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + idno + """," &
                         """" + "paramCutoff" + """:""" + cutoff_ + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("ttl_reg_hrs", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getPayrollRegister_Summary_Hours(ByVal idno As String, ByVal cutoff_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "rptPayroll_Register.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAYREG04"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + idno + """," &
                         """" + "paramCutoff" + """:""" + cutoff_ + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("ttl_reg_hrs", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getPayrollRegister_Summary_Adjusted(ByVal idno As String, ByVal cutoff_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "rptPayroll_Register.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAYREG05"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + idno + """," &
                         """" + "paramCutoff" + """:""" + cutoff_ + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("ttlreghrs", GetType(String))
                    .Columns.Add("ttlreghrsot", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getEarnings_Code() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "rptPayroll_Register.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAYREG06"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("inccode", GetType(String))
                    .Columns.Add("description", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getFixEarnings_Payroll(ByVal idno As String, ByVal cutoff_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "rptPayroll_Register.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAYREG07"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + idno + """," &
                         """" + "paramCutoff" + """:""" + cutoff_ + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("amt_", GetType(String))
                    .Columns.Add("inccode", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getOtherEarnings_Payroll(ByVal idno As String, ByVal cutoff_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "rptPayroll_Register.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAYREG08"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + idno + """," &
                         """" + "paramCutoff" + """:""" + cutoff_ + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("amt_", GetType(String))
                    .Columns.Add("inccode", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getCutoffDeductions_Code(ByVal cutoff_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "rptPayroll_Register.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAYREG09"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramCutoff" + """:""" + cutoff_ + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("ddctcode", GetType(String))
                    .Columns.Add("description", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getCutoff_Dedcutions_MergeList_Amount(ByVal idno As String, ByVal cutoff_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "rptPayroll_Register.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAYREG10"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + idno + """," &
                         """" + "paramCutoff" + """:""" + cutoff_ + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("amt_", GetType(String))
                    .Columns.Add("ddctcode", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getMultiLoan_Code_wCutoff(ByVal cutoff_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "rptPayroll_Register.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAYREG11"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramCutoff" + """:""" + cutoff_ + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("loan_desc", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getPayrollRegister_Loan_Multiple_Payment_Ledger(ByVal idno As String, ByVal cutoff_ As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "rptPayroll_Register.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PAYREG12"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + idno + """," &
                         """" + "paramCutoff" + """:""" + cutoff_ + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("mcode", GetType(String))
                    .Columns.Add("amount", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
#End Region

#Region "Bank Text File"
    Public Function getCboCutOff_wProcess() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "rptBankTextFile.php"
        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "BNK01"
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
                .Columns.Add("payroll_date", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
#End Region

#Region "PaysLip"
    Public Function getDataPayrollRegisterSummary(ByVal idno As String(), ByVal cutoff As String) As DataTable
        Dim dtable As New DataTable
        Try
            ActiveFrm = "rptPayslip.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "RPT02"
            jStr_Input = "{" + """token" + """:""" + Token + """," &
                             """idno"":[""" & String.Join(""",""", idno) & """]," &
                             """" + "cutoff" + """:""" + cutoff + """," &
                             """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("inccode", GetType(String))
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("amount_", GetType(String))
                    .Columns.Add("cutoff", GetType(String))
                    .Columns.Add("payroll_date", GetType(String))
                    .Columns.Add("datestart", GetType(String))
                    .Columns.Add("dateend", GetType(String))

                End With
            End If
        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getDataEarnings(ByVal idno As String(), ByVal cutoff As String) As DataTable
        Dim dtable As New DataTable
        Try
            ActiveFrm = "rptPayslip.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "RPT02"
            jStr_Input = "{" + """token" + """:""" + Token + """," &
                             """idno"":[""" & String.Join(""",""", idno) & """]," &
                             """" + "cutoff" + """:""" + cutoff + """," &
                             """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("inccode", GetType(String))
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("amount_", GetType(String))
                    .Columns.Add("cutoff", GetType(String))
                End With
            End If
        Catch ex As Exception
        End Try
        Return dtable
    End Function
#End Region

    '*// OJT REPORT //*
#Region "Basic Rate Listing"
    Public Function getBasicRateListingWithDateHire(ByVal idno As String(), ByVal date_to As String, ByVal date_from As String) As DataTable
        Dim dtable As New DataTable
        Try
            ActiveFrm = "rptBasicRateListing.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "RPT02"
            jStr_Input = "{" + """token" + """:""" + Token + """," &
                             """idno"":[""" & String.Join(""",""", idno) & """]," &
                             """" + "date_to" + """:""" + date_to + """," &
                             """" + "date_from" + """:""" + date_from + """," &
                             """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("deptcode", GetType(String))
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("name_", GetType(String))
                    .Columns.Add("basic_rate", GetType(String))
                    .Columns.Add("paymode", GetType(String))
                End With
            End If
        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getBasicRateListing(ByVal idno As String()) As DataTable
        Dim dtable As New DataTable
        Try
            ActiveFrm = "rptBasicRateListing.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "RPT01"
            jStr_Input = "{" + """token" + """:""" + Token + """," &
                             """idno"":[""" & String.Join(""",""", idno) & """]," &
                             """" + "MC" + """:""" + MC + """}"
            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("deptcode", GetType(String))
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("name_", GetType(String))
                    .Columns.Add("basic_rate", GetType(String))
                    .Columns.Add("paymode", GetType(String))
                End With
            End If
        Catch ex As Exception
        End Try
        Return dtable
    End Function
#End Region

#Region "Certificate Listing"
    Public Function getEmployeeWithCertifications(ByVal division_ As String(), ByVal paramJobStatus As String) As DataTable
        Dim dtable As New DataTable
        Try
            ActiveFrm = "rptCertificateListing.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "RPT01"
            jStr_Input = "{" + """token" + """:""" + Token + """," &
                             """division"":[""" & String.Join(""",""", division_) & """]," &
                             """" + "paramJobStatus" + """:""" + paramJobStatus + """," &
                             """" + "MC" + """:""" + MC + """}"
            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("lname", GetType(String))
                    .Columns.Add("fname", GetType(String))
                    .Columns.Add("mname", GetType(String))
                    .Columns.Add("divcode", GetType(String))
                    .Columns.Add("deptcode", GetType(String))
                End With
            End If
        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getEmployeeCertificationsListing(ByVal idno As String()) As DataTable

        Dim dtable As New DataTable
        Try
            ActiveFrm = "rptCertificateListing.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "RPT02"
            jStr_Input = "{" + """token" + """:""" + Token + """," &
                             """idno"":[""" & String.Join(""",""", idno) & """]," &
                             """" + "MC" + """:""" + MC + """}"
            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("divcode", GetType(String))
                    .Columns.Add("deptcode", GetType(String))
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("lname", GetType(String))
                    .Columns.Add("fname", GetType(String))
                    .Columns.Add("mname", GetType(String))
                    .Columns.Add("certification", GetType(String))
                    .Columns.Add("yearcert", GetType(String))
                    .Columns.Add("rate", GetType(String))
                End With
            End If
        Catch ex As Exception
        End Try
        Return dtable
    End Function
#End Region

#Region "Emergency Contact"
    Public Function getEmployeeWithEmergencyContacts(ByVal division_ As String(), ByVal paramJobStatus As String) As DataTable
        Dim dtable As New DataTable
        Try
            ActiveFrm = "rptEmergencyContact.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "RPT01"
            jStr_Input = "{" + """token" + """:""" + Token + """," &
                             """division"":[""" & String.Join(""",""", division_) & """]," &
                             """" + "paramJobStatus" + """:""" + paramJobStatus + """," &
                             """" + "MC" + """:""" + MC + """}"
            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("lname", GetType(String))
                    .Columns.Add("fname", GetType(String))
                    .Columns.Add("mname", GetType(String))
                    .Columns.Add("divcode", GetType(String))
                    .Columns.Add("deptcode", GetType(String))
                End With
            End If
        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getEmployeeEmergencyContacts(ByVal idno As String()) As DataTable
        Dim dtable As New DataTable
        Try
            ActiveFrm = "rptEmergencyContact.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "RPT02"
            jStr_Input = "{" + """token" + """:""" + Token + """," &
                             """idno"":[""" & String.Join(""",""", idno) & """]," &
                             """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("fullname", GetType(String))
                    .Columns.Add("contact_name", GetType(String))
                    .Columns.Add("relation", GetType(String))
                    .Columns.Add("address", GetType(String))
                    .Columns.Add("landline", GetType(String))
                    .Columns.Add("mobile", GetType(String))
                    .Columns.Add("email", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
#End Region

#Region "Employee Job Status"
    Public Function getEmployeeWithJobStatus(ByVal division_ As String(), ByVal paramJobStatus As String) As DataTable
        Dim dtable As New DataTable
        Try
            ActiveFrm = "rptJobStatusListing.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "RPT01"
            jStr_Input = "{" + """token" + """:""" + Token + """," &
                             """division"":[""" & String.Join(""",""", division_) & """]," &
                             """" + "paramJobStatus" + """:""" + paramJobStatus + """," &
                             """" + "MC" + """:""" + MC + """}"
            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("lname", GetType(String))
                    .Columns.Add("fname", GetType(String))
                    .Columns.Add("mname", GetType(String))
                    .Columns.Add("nameextension", GetType(String))
                    .Columns.Add("jstatusname", GetType(String))
                    .Columns.Add("divcode", GetType(String))
                    .Columns.Add("deptcode", GetType(String))
                End With
            End If
        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getEmployeeJobStatusDateTo(ByVal idno As String(), ByVal date_from As String, ByVal date_to As String) As DataTable
        Dim dtable As New DataTable
        Try
            ActiveFrm = "rptJobStatusListing.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "RPT02"
            jStr_Input = "{" + """token" + """:""" + Token + """," &
                             """idno"":[""" & String.Join(""",""", idno) & """]," &
                             """" + "date_from" + """:""" + date_from + """," &
                             """" + "date_to" + """:""" + date_to + """," &
                             """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("lname", GetType(String))
                    .Columns.Add("fname", GetType(String))
                    .Columns.Add("mname", GetType(String))
                    .Columns.Add("nameextension", GetType(String))
                    .Columns.Add("divname", GetType(String))
                    .Columns.Add("deptname", GetType(String))
                    .Columns.Add("jobstatus", GetType(String))
                    .Columns.Add("jobstatus_date", GetType(String))
                End With
            End If
        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getEmployeeJobStatus(ByVal idno As String()) As DataTable
        Dim dtable As New DataTable
        Try
            ActiveFrm = "rptJobStatusListing.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "RPT03"
            jStr_Input = "{" + """token" + """:""" + Token + """," &
                             """idno"":[""" & String.Join(""",""", idno) & """]," &
                             """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("lname", GetType(String))
                    .Columns.Add("fname", GetType(String))
                    .Columns.Add("mname", GetType(String))
                    .Columns.Add("nameextension", GetType(String))
                    .Columns.Add("divname", GetType(String))
                    .Columns.Add("deptname", GetType(String))
                    .Columns.Add("jobstatus", GetType(String))
                    .Columns.Add("jobstatus_date", GetType(String))
                End With
            End If
        Catch ex As Exception
        End Try
        Return dtable
    End Function
#End Region

End Module
