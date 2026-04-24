Imports System.Net
Imports NXNParsing
Public Module modHRMAX

    Public frmDash As New frmDashboard

    Private ActiveFrm As String = ""
    Private jStr_Input As String = "[]"
    Private ws As New WSConnection
    Private Token As String = ""
    Public pwdHash As String

    'Group Access
    Public xView As String
    Public xAdd As String
    Public xDelete As String
    Public xPrint As String
#Region "SMS NOTFICATION"
    'SMS NOTIFICATION
    Private Function TestServer() As Boolean
        Dim result As Boolean = False
        Try
            Dim url As String = "http://192.168.99.83:87"
            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            request.Timeout = 3000 ' 3 seconds timeout
            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)

            If response.StatusCode = HttpStatusCode.OK Then
                result = True
            End If

            response.Close()
        Catch ex As WebException
            result = False
        End Try
        Return result
    End Function
    Public Function AddSmsData(ByRef maskname As String, ByRef to_number As String, ByRef sms_message As String,
                                ByRef sent_datetime As Date)
        If TestServer() Then
            Dim ServerSide = "http://192.168.99.83:87/hrmaxv16/xdesktop/ChatBridgeImport/"

            ActiveFrm = "frmSMS.php"
            MC = "SB01"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            Dim formatted_sms_message As String = Replace(sms_message, vbCrLf, "\n")

            ' Build the JSON string with the formatted sms_message
            Dim jStr_Input As String = "{" &
                                       """token"":""" & Token & """," &
                                       """maskname"":""" & Trim(maskname) & """," &
                                       """to_number"":""" & Trim(to_number) & """," &
                                       """sms_message"":""" & formatted_sms_message & """," &
                                       """sent_datetime"":""" & Trim(sent_datetime) & """," &
                                       """MC"":""" & MC & """}"

            Dim res As String = ws.JsonStr2JsonStr(jStr_Input, ServerSide & ActiveFrm,
                                                   "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")?.ToString
            If res = """done""" Then
                Return True
            End If
            Return False
        Else
            Return False
        End If
    End Function

    'END SMS NOTIFICATION

#End Region

    Public Function getCompany() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "modHRMAX.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "HRMAX01"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        If Not IsNothing(dtable) Then
            Dim rs() As DataRow = dtable.Select()
            If rs.Count > 0 Then
                If rs(0).Item(0) = "-1" Then
                    MsgBox("Connection Failed : Unable to connect remote Server !" & vbCr & vbCr & "Please Contact your system admininistrator !", vbCritical)
                    dtable = New DataTable
                    With dtable
                        .Columns.Add("keyctr", GetType(String))
                        .Columns.Add("area_description", GetType(String))
                        .Columns.Add("active_year", GetType(String))
                    End With
                End If
            End If
        Else
            dtable = New DataTable
            With dtable
                .Columns.Add("keyctr", GetType(String))
                .Columns.Add("area_description", GetType(String))
                .Columns.Add("active_year", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getActiveCompany() As DataTable
        Dim dtable As New DataTable

        Try
            ActiveFrm = "modHRMAX.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "HRMAX02"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "ActiveCompany" + """:""" + ActiveCompany + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("keyctr", GetType(String))
                    .Columns.Add("area_description", GetType(String))
                    .Columns.Add("active_year", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    'payslip
    'Public Function getPaySlipCutOff() As DataTable
    '    Dim dtable As New DataTable

    '    Try
    '        ActiveFrm = "rptPayslip.php"

    '        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

    '        MC = "RPT03"

    '        jStr_Input = "{" + """token" + """:""" + Token + """," &
    '              """" + "ActiveCompany" + """:""" + ActiveCompany + """," &
    '              """" + "MC" + """:""" + MC + """}"

    '        dtable = ws.JsonStr2DTable(jStr_Input,
    '                                    ServerTxt & ActiveFrm,
    '                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

    '        If IsNothing(dtable) Then
    '            dtable = New DataTable
    '            With dtable
    '                .Columns.Add("cutoff", GetType(String))
    '                .Columns.Add("payroll_date", GetType(String))
    '                .Columns.Add("datestart", GetType(String))
    '                .Columns.Add("dateend", GetType(String))
    '            End With
    '        End If

    '    Catch ex As Exception
    '    End Try
    '    Return dtable
    'End Function

    Public Function getEmployee() As DataTable
        Dim dtable As New DataTable

        Try
            ActiveFrm = "modHRMAX.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "HRMAX03"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                      """" + "ActiveCompany" + """:""" + ActiveCompany + """," &
                      """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("fullname", GetType(String))
                    .Columns.Add("divcode", GetType(String))
                    .Columns.Add("deptcode", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getDivisionEmployee() As DataTable
        Dim dtable As New DataTable

        Try
            ActiveFrm = "modHRMAX.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "HRMAX04"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "ActiveCompany" + """:""" + ActiveCompany + """," &
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
                    .Columns.Add("divcode", GetType(String))
                    .Columns.Add("deptcode", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getAllDivisionEmployee(ByVal company_ As String) As DataTable
        Dim dtable As New DataTable

        Try
            ActiveFrm = "modHRMAX.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "HRMAX08"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "ActiveCompany" + """:""" + company_ + """," &
                  """" + "paramJobStatus" + """:""" + paramJobStatus + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("fullname", GetType(String))
                    .Columns.Add("divcode", GetType(String))
                    .Columns.Add("deptcode", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getHrmaxUsers() As DataTable
        Dim dtable As New DataTable

        Try
            ActiveFrm = "modHRMAX.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "HRMAX05"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno_sec", GetType(String))
                    .Columns.Add("full_name", GetType(String))
                    .Columns.Add("accesslevel", GetType(String))
                    .Columns.Add("disable_user", GetType(String))
                    .Columns.Add("online_user", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getDatabase() As DataTable
        Dim dtable As New DataTable

        Try
            ActiveFrm = "modHRMAX.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "HRMAX06"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("mytime", GetType(String))
                    .Columns.Add("serverip", GetType(String))
                    .Columns.Add("mydatabase", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    'USER POLICY

    Public Function getForms() As DataTable
        Dim dtable As New DataTable

        Try
            ActiveFrm = "frmMaintenanceForms.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "FORM01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("modid", GetType(String))
                    .Columns.Add("formid", GetType(String))
                    .Columns.Add("formname", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getUserGroup() As DataTable
        Dim dtable As New DataTable

        Try
            ActiveFrm = "frmUserPolicy.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "USER01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("grpcode", GetType(String))
                    .Columns.Add("description", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getPolicyForms(ByVal mod_ As String) As DataTable
        Dim dtable As New DataTable

        Try
            ActiveFrm = "frmUserPolicy.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "USER05"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "mod_" + """:""" + mod_ + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("modid", GetType(String))
                    .Columns.Add("formid", GetType(String))
                    .Columns.Add("formname", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getUserGroupPolicy() As DataTable
        Dim dtable As New DataTable

        Try
            ActiveFrm = "frmUserPolicy.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "USER06"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("keyctr", GetType(String))
                    .Columns.Add("grpcode", GetType(String))
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("modid", GetType(String))
                    .Columns.Add("formid", GetType(String))
                    .Columns.Add("xview", GetType(String))
                    .Columns.Add("xadd", GetType(String))
                    .Columns.Add("xdelete", GetType(String))
                    .Columns.Add("xprint", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getUserPolicyList() As DataTable
        Dim dtable As New DataTable

        Try
            ActiveFrm = "frmUserPolicy.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "USER10"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("fullname", GetType(String))
                    .Columns.Add("username", GetType(String))
                    .Columns.Add("password", GetType(String))
                    .Columns.Add("grpcode", GetType(String))
                    .Columns.Add("expiration", GetType(String))
                    .Columns.Add("auto_renew", GetType(String))
                    .Columns.Add("status", GetType(String))
                    .Columns.Add("remarks", GetType(String))
                    .Columns.Add("otp", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function


End Module
