Imports NXNParsing
Public Module modEmployee

    Private ActiveFrm As String = String.Empty
    Private jStr_Input As String = "[]"
    Private ws As New WSConnection
    Private Token As String = String.Empty

    'Parameters
    'Public paramYear As String = String.Empty
    Public paramPrevYear As String = String.Empty
    Public paramCnt As String = "PHP"
    Public paramProv As String = String.Empty
    Public paramCity As String = String.Empty
    Public paramBrgy As String = String.Empty

    Public paramSteps As String = String.Empty
    Public paramTranche As String = String.Empty
    Public paramGrade As String = String.Empty
    Public paramSched As String = String.Empty

    Public paramDeptCtr As String = String.Empty
    Public paramDept As String = String.Empty

    Public paramEmpStatus As String = String.Empty
    Public paramDiv As String = String.Empty
    Public paramJobStatus As String = String.Empty
    Public paramSec As String = String.Empty
    Public paramPos As String = String.Empty
    Public paramPosDesc As String = String.Empty
    Public paramJob As String = String.Empty

    Public paramSig As String = String.Empty
    Public paramTrans As String = String.Empty

    Public paramID As String = String.Empty
    Public paramFullname As String = String.Empty
    Public paramTable As String = String.Empty
    Public paramSearch As String = String.Empty
    Public paramEFile As String = String.Empty

    Public paramBenCode As String = String.Empty

    Public isEmployee As Boolean = False
    Public isLink As Boolean = False

    Public chkStatus As String = ""

#Region "Employee"
    Public Function getAllEmployee() As DataTable
        Dim dtable As New DataTable

        Try
            ActiveFrm = "modEmployee.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "MOD01"
            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "ActiveCompany" + """:""" + ActiveCompany + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                       ServerTxt & ActiveFrm,
                                       "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getActiveEmployee() As DataTable
        Dim dtable As New DataTable

        Try
            ActiveFrm = "modEmployee.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "MOD02"
            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "ActiveCompany" + """:""" + ActiveCompany + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                       ServerTxt & ActiveFrm,
                                       "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getInactiveEmployee() As DataTable
        Dim dtable As New DataTable

        Try
            ActiveFrm = "modEmployee.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "MOD03"
            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "ActiveCompany" + """:""" + ActiveCompany + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                       ServerTxt & ActiveFrm,
                                       "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getEmployeeImage(ByVal paramID As String) As DataTable
        Dim dtable As New DataTable

        Try
            ActiveFrm = "modEmployee.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "MOD04"
            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "paramID" + """:""" + paramID + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                       ServerTxt & ActiveFrm,
                                       "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        Catch ex As Exception
        End Try
        Return dtable
    End Function
#End Region



#Region "Change Password"
    Public Function getUser(ByVal paramID As String) As DataTable
        Dim dtable As New DataTable

        Try
            ActiveFrm = "frmChangePassword.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "CH01"

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
                    .Columns.Add("usrname", GetType(String))
                    .Columns.Add("new_pwd", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
#End Region

#Region "User Policy"
    Public Function getHRMAX_User() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmUserPolicy.php"

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
                    .Columns.Add("idno_sec", GetType(String))
                    .Columns.Add("full_name", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getCboByModule() As DataTable
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("code", GetType(String))
            .Columns.Add("desc", GetType(String))
            .Rows.Add("1", "HRMAXV16")
            .Rows.Add("2", "TIME RECORDS")
            .Rows.Add("3", "BENEFITS")
            .Rows.Add("4", "PAYROLL")
            .Rows.Add("5", "ADMINISTRATOR")
            .Rows.Add("6", "REPORTS")
            .Rows.Add("7", "DIVISION")
            .Rows.Add("8", "COST CENTER")
        End With
        Return pDTable
    End Function
    Public Function getCboForms() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmUserPolicy.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "USER02"

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

#End Region

#Region "Active Tranche"
    Public Function getActiveTranche() As DataTable
        Dim dtable As New DataTable

        Try

            ActiveFrm = "e_frmActiveTranche.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "TRANCHE01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("pyear", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
#End Region

#Region "Country"
    Public Function getCountry() As DataTable
        Dim dtable As New DataTable

        Try

            ActiveFrm = "e_frmCountry.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "CNT01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("countrycode", GetType(String))
                    .Columns.Add("countryname", GetType(String))
                    .Columns.Add("ctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
#End Region

#Region "Address References"
    Public Function getCboCountry() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmAddressRefMenu.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "REF01"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("countrycode", GetType(String))
                .Columns.Add("countryname", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboProvince() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmAddressRefMenu.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "REF02"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramCnt" + """:""" + paramCnt + """," &
                     """" + "paramProv" + """:""" + paramProv + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("provid", GetType(String))
                .Columns.Add("provname", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboBarangay() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmAddressRefMenu.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "REF16"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramCity" + """:""" + paramCity + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("brgyid", GetType(String))
                .Columns.Add("brgyname", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboCity() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmAddressRefMenu.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "REF15"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramProv" + """:""" + paramProv + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("cityid", GetType(String))
                .Columns.Add("cityname", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getProvince() As DataTable
        Dim dtable As New DataTable

        Try

            ActiveFrm = "e_frmAddressRefMenu.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "REF03"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "paramCnt" + """:""" + paramCnt + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("provname", GetType(String))
                    .Columns.Add("provid", GetType(String))
                    .Columns.Add("countryname", GetType(String))
                    .Columns.Add("country", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getCity() As DataTable
        Dim dtable As New DataTable

        Try

            ActiveFrm = "e_frmAddressRefMenu.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "REF06"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("cityname", GetType(String))
                    .Columns.Add("cityid", GetType(String))
                    .Columns.Add("provid", GetType(String))
                    .Columns.Add("country", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getBrgy() As DataTable
        Dim dtable As New DataTable

        Try

            ActiveFrm = "e_frmAddressRefMenu.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "REF07"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("brgyname", GetType(String))
                    .Columns.Add("brgyid", GetType(String))
                    .Columns.Add("cityid", GetType(String))
                    .Columns.Add("provid", GetType(String))
                    .Columns.Add("country", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

#End Region


    Public Function getQuote() As DataTable
        Dim dtable As New DataTable

        Try

            ActiveFrm = "e_frmQuoteMaintenance.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "QUOTE01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("saying", GetType(String))
                    .Columns.Add("author", GetType(String))
                    .Columns.Add("posted_by", GetType(String))
                    .Columns.Add("date_added", GetType(String))
                    .Columns.Add("quote_id", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getCboEmployee() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmQuoteMaintenance.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "QUOTE02"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("idno", GetType(String))
                .Columns.Add("fullname", GetType(String))
                .Columns.Add("date_hire", GetType(String))
                .Columns.Add("active_year", GetType(String))
                .Columns.Add("paymode", GetType(String))
                .Columns.Add("basic_rate", GetType(String))
                .Columns.Add("divcode", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getCboEmployeeProfile() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmAddEmployee.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "EMP03"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("idno", GetType(String))
                .Columns.Add("fullname", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getLoan() As DataTable
        Dim dtable As New DataTable

        Try

            ActiveFrm = "e_frmLoanMaintenance.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "LOAN01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("loan_type_id", GetType(String))
                    .Columns.Add("loan_description", GetType(String))
                    .Columns.Add("remarks", GetType(String))
                    .Columns.Add("ctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function


#Region "Future Trainings"
    Public Function getFuture_Trainings() As DataTable
        Dim dtable As New DataTable

        Try

            ActiveFrm = "frmMaintenance_FutureTrainings.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "FT01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "paramID" + """:""" + paramID + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("training_code", GetType(String))
                    .Columns.Add("training_desc", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

#End Region

#Region "Future Seminars"
    Public Function getFuture_Seminars() As DataTable
        Dim dtable As New DataTable

        Try

            ActiveFrm = "frmMaintenance_FutureSeminars.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "FS01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "paramID" + """:""" + paramID + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("title", GetType(String))
                    .Columns.Add("seminar_desc", GetType(String))
                    .Columns.Add("seminar_status", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

#End Region
    Public Function getCboTranche() As DataTable

        Dim var As String = ""
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("code", GetType(String))
            .Columns.Add("desc", GetType(String))
            For x = 1 To 10
                var = "Tranche " & x
                .Rows.Add(x, var)
            Next
        End With
        Dim row As DataRow = pDTable.NewRow
        pDTable.Rows.InsertAt(row, 0)
        Return pDTable
    End Function
    Public Function getCboNumber() As DataTable
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("code", GetType(String))
            For x = 1 To 100
                .Rows.Add(x)
            Next
        End With
        Dim row As DataRow = pDTable.NewRow
        pDTable.Rows.InsertAt(row, 0)
        Return pDTable
    End Function

    Public Function getCboBatch() As DataTable
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("code", GetType(String))
            For x = 1 To 9
                .Rows.Add(x)
            Next
        End With
        Dim row As DataRow = pDTable.NewRow
        pDTable.Rows.InsertAt(row, 0)
        Return pDTable
    End Function

    Public Function getCboStatCode() As DataTable
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("code", GetType(String))
            .Rows.Add("01")
            .Rows.Add("02")
        End With
        Return pDTable
    End Function
    Public Function getCboDesktopApproval() As DataTable
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("code", GetType(String))
            .Rows.Add("NO")
            .Rows.Add("YES")
            .Rows.Add("IH")
        End With
        Return pDTable
    End Function
    Public Function getCboYear() As DataTable
        Dim code = Year(Now)
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("code", GetType(String))
            For i = code To 2015 Step -1
                .Rows.Add(i)
            Next
        End With
        Return pDTable
    End Function
    Public Function getCboPaymode() As DataTable
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("code", GetType(String))
            .Columns.Add("desc", GetType(String))
            .Rows.Add("", "")
            .Rows.Add("1", "DAILY")
            .Rows.Add("2", "MONTHLY")
            .Rows.Add("3", "PIECE WORK")
            .Rows.Add("4", "MULTIPLE")
            .Rows.Add("5", "HOURLY")
            .Rows.Add("6", "TRANSPO")
        End With
        Return pDTable
    End Function
    Public Function getCboTaxCode() As DataTable
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("code", GetType(String))
            .Columns.Add("desc", GetType(String))
            .Rows.Add("", "")
            .Rows.Add("S", "Single")
            .Rows.Add("ME", "Married")
            .Rows.Add("ME1", "Married w/1 Dependent")
            .Rows.Add("ME2", "Married w/2 Dependents")
            .Rows.Add("ME3", "Married w/3 Dependents")
            .Rows.Add("ME4", "Married w/4 Dependents")
            .Rows.Add("HF", "Head of the Family")
            .Rows.Add("HF1", "Head of the Family w/1 Dependent")
            .Rows.Add("HF2", "Head of the Family w/2 Dependents")
            .Rows.Add("Hf3", "Head of the Family w/3 Dependents")
            .Rows.Add("HF4", "Head of the Family w/4 Dependents")
        End With
        Return pDTable
    End Function

    '---------------------------------------------------------'
    '------------------ JOB MAINTENANCE ----------------------'
    '---------------------------------------------------------'

    Public Function getCboJobMaintenance_Position() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmJobMaintenance.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "JOB02"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "ActiveCompany" + """:""" + ActiveCompany + """," &
                     """" + "paramDiv" + """:""" + paramDiv + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("pcode", GetType(String))
                .Columns.Add("description", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getJobMaintenance() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmJobMaintenance.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "JOB03"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("divcode", GetType(String))
                    .Columns.Add("poscode", GetType(String))
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("percentage", GetType(String))
                    .Columns.Add("keyctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getSalaryGrading() As DataTable
        Dim dtable As New DataTable

        Try

            ActiveFrm = "e_frmSalaryGrading.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "SAL02"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("tranche", GetType(String))
                    .Columns.Add("grade", GetType(String))
                    .Columns.Add("step1", GetType(String))
                    .Columns.Add("step2", GetType(String))
                    .Columns.Add("step3", GetType(String))
                    .Columns.Add("step4", GetType(String))
                    .Columns.Add("step5", GetType(String))
                    .Columns.Add("step6", GetType(String))
                    .Columns.Add("step7", GetType(String))
                    .Columns.Add("step8", GetType(String))
                    .Columns.Add("pyear", GetType(String))
                    .Columns.Add("sal_sched", GetType(String))
                    .Columns.Add("gcode", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function GetCboJobGrading() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmSalaryGrading.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "SAL01"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("jgradecode", GetType(String))
                .Columns.Add("jgradename", GetType(String))
                .Columns.Add("grade", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

#Region "Employment Status"
    Public Function getStatusHistory() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmStatus.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "STAT02"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("divcode", GetType(String))
                    .Columns.Add("deptcode", GetType(String))
                    .Columns.Add("seccode", GetType(String))
                    .Columns.Add("grpcode", GetType(String))
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("joblevel", GetType(String))
                    .Columns.Add("jobtype", GetType(String))
                    .Columns.Add("jobstatus", GetType(String))
                    .Columns.Add("jobstatus_date", GetType(String))
                    .Columns.Add("jobstatus_dateto", GetType(String))
                    .Columns.Add("date_hire", GetType(String))
                    .Columns.Add("date_regular", GetType(String))
                    .Columns.Add("paymode", GetType(String))
                    .Columns.Add("taxcode", GetType(String))
                    .Columns.Add("basic_rate", GetType(String))
                    .Columns.Add("bankcode", GetType(String))
                    .Columns.Add("acctno", GetType(String))
                    .Columns.Add("immediate_head", GetType(String))
                    .Columns.Add("trail", GetType(String))
                    .Columns.Add("keyctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

#End Region

    Public Function getLongevity() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmStatus.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "STAT01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("longevitydate", GetType(String))
                    .Columns.Add("longevityterms", GetType(String))
                    .Columns.Add("longevity_percent", GetType(String))
                    .Columns.Add("longevity_amount", GetType(String))
                    .Columns.Add("trail", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function


    Public Function GetCboSalSched() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmSalaryGrading.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "SAL03"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("scode", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getSalSched() As DataTable
        Dim dtable As New DataTable

        Try

            ActiveFrm = "e_frmSalarySchedule.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "SCHED01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("scode", GetType(String))
                    .Columns.Add("description", GetType(String))

                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getCboCompany() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmManageImmediateHead.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "HEAD01"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
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

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getDepartment() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmManageImmediateHead.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "HEAD03"

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
                    .Columns.Add("deptcode", GetType(String))
                    .Columns.Add("deptname", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getCboPositionTransaction() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmTransactionSignatory.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "TRANS01"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "ActiveCompany" + """:""" + ActiveCompany + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("pcode", GetType(String))
                .Columns.Add("description", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getJobLevel() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmJobCategory.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "JOB01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("jlevelcode", GetType(String))
                    .Columns.Add("jlevelname", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getJobType() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmJobCategory.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "JOB02"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("jtypecode", GetType(String))
                    .Columns.Add("jtypename", GetType(String))
                    .Columns.Add("c_batch", GetType(String))
                    .Columns.Add("timebounded", GetType(String))
                    .Columns.Add("disable_holiday", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getJobStatus() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmJobCategory.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "JOB03"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("jstatuscode", GetType(String))
                    .Columns.Add("jstatusname", GetType(String))
                    .Columns.Add("timebounded", GetType(String))
                    .Columns.Add("jcode", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getJobGrade() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmJobCategory.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "JOB04"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("jgradecode", GetType(String))
                    .Columns.Add("jgradename", GetType(String))
                    .Columns.Add("grade", GetType(String))
                    .Columns.Add("keyctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getJobSteps() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmJobCategory.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "JOB05"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("stepcode", GetType(String))
                    .Columns.Add("stepname", GetType(String))
                    .Columns.Add("step", GetType(String))
                    .Columns.Add("keyctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getMedical() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmMedical.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "MED01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("remarks", GetType(String))
                    .Columns.Add("ctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getPhysical() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmMedical.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "MED02"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("remarks", GetType(String))
                    .Columns.Add("option_def", GetType(String))
                    .Columns.Add("option_type", GetType(String))
                    .Columns.Add("ctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getLaboratory() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmMedical.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "MED03"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("remarks", GetType(String))
                    .Columns.Add("option_def", GetType(String))
                    .Columns.Add("option_type", GetType(String))
                    .Columns.Add("ctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getCboOptType() As DataTable
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("code", GetType(String))
            .Columns.Add("desc", GetType(String))
            .Rows.Add("", "")
            .Rows.Add("1", "Normal/Abnormal")
            .Rows.Add("2", "Normal/Findings")
            .Rows.Add("3", "Yes/No")
            .Rows.Add("4", "Positive/Negative")
            .Rows.Add("5", "Reactive/Non-Reactive")
            .Rows.Add("6", "Adequate/Defective")
            .Rows.Add("7", "Left/Right")
        End With
        Return pDTable
    End Function
    Public Function getGroupApprover() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmApprovingBuddy.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "APP01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("short_definition", GetType(String))
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("idno1", GetType(String))
                    .Columns.Add("idno2", GetType(String))
                    .Columns.Add("idno3", GetType(String))
                    .Columns.Add("idno4", GetType(String))
                    .Columns.Add("idno5", GetType(String))
                    .Columns.Add("idno6", GetType(String))
                    .Columns.Add("idno7", GetType(String))
                    .Columns.Add("idno8", GetType(String))
                    .Columns.Add("idno9", GetType(String))
                    .Columns.Add("idno10", GetType(String))
                    .Columns.Add("ctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getCboJobType() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEmployeeTransaction.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "ETRANS02"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("jtypecode", GetType(String))
                .Columns.Add("jtypename", GetType(String))
                .Columns.Add("timebounded", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    '---------------------------------------------------------'
    '------------------ EMPLOYEE TRANSACTION -----------------'
    '---------------------------------------------------------'
    Public Function getCboTransactionType() As DataTable
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("code", GetType(String))
            .Columns.Add("desc", GetType(String))
            .Rows.Add(" ", " ")
            .Rows.Add("ALW", "Online Allowances Flow")
            .Rows.Add("ES", "HRMAXV16 Status Flow")
            .Rows.Add("FE", "Fixed Earnings Flow")
            .Rows.Add("FL", "Field Flow")
            .Rows.Add("HV", "Home Visitation Benefits Flow")
            .Rows.Add("HW", "Home Work")
            .Rows.Add("LV", "Leave Flow")
            .Rows.Add("OE", "Other Earnings Flow")
            .Rows.Add("OT", "Overtime Flow")
            .Rows.Add("TC", "Time Correction Flow")
            .Rows.Add("TR", "Travel Flow")
            .Rows.Add("SK", "Schedule Flow")
        End With
        Return pDTable
    End Function

    Public Function getEmpSignatory() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmEmployeeTransaction.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "ETRANS04"

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
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getEmpTransaction() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmEmployeeTransaction.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "ETRANS04"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "paramTrans" + """:""" + paramTrans + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("fullname", GetType(String))
                    .Columns.Add("transaction_", GetType(String))
                    .Columns.Add("open_", GetType(String))
                    .Columns.Add("datestart", GetType(String))
                    .Columns.Add("dateend", GetType(String))
                    .Columns.Add("alwys", GetType(String))
                    .Columns.Add("ctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getTransactionType() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmTransactionSignatory.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "TRANS02"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("transaction_", GetType(String))
                    .Columns.Add("transaction_def", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getCboZip() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmContactAddress.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "CA04"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramCity" + """:""" + paramCity + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("zipcode", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function GetCboEmergencyAddress() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEmergencyContacts.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "EC05"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("contact_address", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function GetCboEmergencyRelation() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEmergencyContacts.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "EC06"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("relation", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getCboAffiliationsName() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmAffiliation.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "AFFL01"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramTable" + """:""" + paramTable + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("organization", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboAffiliationsPosition() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmAffiliation.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "AFFL02"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramTable" + """:""" + paramTable + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("myposition", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getAffiliations() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmAffiliation.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "AFFL03"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramTable" + """:""" + paramTable + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("organization", GetType(String))
                    .Columns.Add("myposition", GetType(String))
                    .Columns.Add("remarks", GetType(String))
                    .Columns.Add("datefrom", GetType(String))
                    .Columns.Add("dateto", GetType(String))
                    .Columns.Add("hours", GetType(String))
                    .Columns.Add("govt", GetType(String))
                    .Columns.Add("keyctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getSkills() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmSkillsLevel.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "SKILL03"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("skills", GetType(String))
                    .Columns.Add("skillname", GetType(String))
                    .Columns.Add("sklld", GetType(String))
                    .Columns.Add("skillcode", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getCboSkills() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmSkillsLevel.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "SKILL01"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramTable" + """:""" + paramTable + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("skills", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboSkillsRating() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmSkillsLevel.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "SKILL02"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("skillcode", GetType(String))
                .Columns.Add("skillname", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getSkillsRating() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmSkillsRating.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "SKLVL01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("skillcode", GetType(String))
                    .Columns.Add("skillname", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getHistory() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmClinicalRecords.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "CL01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("remarks", GetType(String))
                    .Columns.Add("ctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    '---------------------------------------------------------'
    '------------------ EMPLOYEE PROFILE ---------------------'
    '---------------------------------------------------------'
    Public Function getCboSex() As DataTable
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("code", GetType(String))
            .Columns.Add("desc", GetType(String))
            .Rows.Add("M", "MALE")
            .Rows.Add("F", "FEMALE")
        End With
        Return pDTable
    End Function

    Public Function getCboCivilStatus() As DataTable
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("code", GetType(String))
            .Columns.Add("desc", GetType(String))
            .Rows.Add("1", "SINGLE")
            .Rows.Add("2", "MARRIED")
            .Rows.Add("3", "WIDOW")
            .Rows.Add("4", "SEPARATED")
        End With
        Return pDTable
    End Function
    Public Function getCboNameExtension() As DataTable
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("desc", GetType(String))
            .Rows.Add("I")
            .Rows.Add("II")
            .Rows.Add("III")
            .Rows.Add("JR.")
            .Rows.Add("SR.")
        End With
        Dim row As DataRow = pDTable.NewRow
        pDTable.Rows.InsertAt(row, 0)

        Return pDTable
    End Function
    Public Function getCboStatus() As DataTable
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("desc", GetType(String))
            .Rows.Add("ACTIVE")
            .Rows.Add("INACTIVE")
            .Rows.Add("ALL")
        End With
        Return pDTable
    End Function
    Public Function getEmployeeProfileInfo() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmEmployeeProfile.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PROF01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "paramTable" + """:""" + paramTable + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("fname", GetType(String))
                    .Columns.Add("lname", GetType(String))
                    .Columns.Add("mname", GetType(String))
                    .Columns.Add("nameextension", GetType(String))
                    .Columns.Add("maiden", GetType(String))
                    .Columns.Add("gender_def", GetType(String))
                    .Columns.Add("civilstatus_def", GetType(String))
                    .Columns.Add("bdate", GetType(String))
                    .Columns.Add("age", GetType(String))
                    .Columns.Add("blood_type", GetType(String))
                    .Columns.Add("citizenship", GetType(String))
                    .Columns.Add("weight", GetType(String))
                    .Columns.Add("height", GetType(String))
                    .Columns.Add("religion", GetType(String))
                    .Columns.Add("placeofbirth", GetType(String))
                    .Columns.Add("remarks", GetType(String))
                    .Columns.Add("prefix", GetType(String))
                    .Columns.Add("postfix", GetType(String))
                    .Columns.Add("image_filename", GetType(String))
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("philid_no", GetType(String))
                    .Columns.Add("sss_no", GetType(String))
                    .Columns.Add("tin_no", GetType(String))
                    .Columns.Add("hdmf_no", GetType(String))
                    .Columns.Add("phealth_no", GetType(String))
                    .Columns.Add("gsis_no", GetType(String))
                    .Columns.Add("agency_no", GetType(String))
                    .Columns.Add("medicare_no", GetType(String))
                    .Columns.Add("passport_no", GetType(String))
                    .Columns.Add("mother_maiden", GetType(String))
                    .Columns.Add("mother_surname", GetType(String))
                    .Columns.Add("mother_fname", GetType(String))
                    .Columns.Add("mother_mname", GetType(String))
                    .Columns.Add("mother_occupation", GetType(String))
                    .Columns.Add("mother_bdate", GetType(String))
                    .Columns.Add("father_surname", GetType(String))
                    .Columns.Add("father_fname", GetType(String))
                    .Columns.Add("father_mname", GetType(String))
                    .Columns.Add("father_occupation", GetType(String))
                    .Columns.Add("father_bdate", GetType(String))
                    .Columns.Add("motherinlaw_maiden", GetType(String))
                    .Columns.Add("motherinlaw_surname", GetType(String))
                    .Columns.Add("motherinlaw_fname", GetType(String))
                    .Columns.Add("motherinlaw_mname", GetType(String))
                    .Columns.Add("motherinlaw_occupation", GetType(String))
                    .Columns.Add("motherinlaw_bdate", GetType(String))
                    .Columns.Add("fatherinlaw_surname", GetType(String))
                    .Columns.Add("fatherinlaw_fname", GetType(String))
                    .Columns.Add("fatherinlaw_mname", GetType(String))
                    .Columns.Add("fatherinlaw_occupation", GetType(String))
                    .Columns.Add("fatherinlaw_bdate", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getUpdatedEmployeeProfile() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmEmployeeProfile.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PROF02"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramTable" + """:""" + paramTable + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("fullname", GetType(String))
                    .Columns.Add("myposition", GetType(String))
                    .Columns.Add("jstatusname", GetType(String))
                    .Columns.Add("jobstatus_date", GetType(String))
                    .Columns.Add("deptname", GetType(String))
                    .Columns.Add("divname", GetType(String))
                    .Columns.Add("image", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getSpouse() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmEmployeeProfile.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PROF03"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramTable" + """:""" + paramTable + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("surname", GetType(String))
                    .Columns.Add("fname", GetType(String))
                    .Columns.Add("mname", GetType(String))
                    .Columns.Add("occupation", GetType(String))
                    .Columns.Add("employer", GetType(String))
                    .Columns.Add("business_address", GetType(String))
                    .Columns.Add("business_contact", GetType(String))
                    .Columns.Add("bdate", GetType(String))
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("keyctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getSiblings() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmEmployeeProfile.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PROF04"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramTable" + """:""" + paramTable + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("cname", GetType(String))
                    .Columns.Add("bdate", GetType(String))
                    .Columns.Add("relation", GetType(String))
                    .Columns.Add("occupation", GetType(String))
                    .Columns.Add("keyctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getChild() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmEmployeeProfile.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PROF05"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramTable" + """:""" + paramTable + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("cname", GetType(String))
                    .Columns.Add("bdate", GetType(String))
                    .Columns.Add("relation", GetType(String))
                    .Columns.Add("occupation", GetType(String))
                    .Columns.Add("keyctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getReferences() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmEmployeeProfile.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PROF06"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramTable" + """:""" + paramTable + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("fullname", GetType(String))
                    .Columns.Add("occupation", GetType(String))
                    .Columns.Add("address", GetType(String))
                    .Columns.Add("contact", GetType(String))
                    .Columns.Add("keyctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getEfile() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmEmployeeProfile.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PROF07"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("efile_type", GetType(String))
                    .Columns.Add("doc_code", GetType(String))
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("doc_filename", GetType(String))
                    .Columns.Add("doc_ext", GetType(String))
                    .Columns.Add("remarks", GetType(String))
                    .Columns.Add("active", GetType(String))
                    .Columns.Add("keyctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getMediafile() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmEmployeeProfile.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "PROF08"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("mtype", GetType(String))
                    .Columns.Add("remarks", GetType(String))
                    .Columns.Add("mpath", GetType(String))
                    .Columns.Add("idno", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getCboReligion() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEmployeeProfile.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "PROF09"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramTable" + """:""" + paramTable + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("religion", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboSpouseOccupation() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEmployeeProfile.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "PROF10"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramTable" + """:""" + paramTable + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("occupation", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboSpouseEmployer() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEmployeeProfile.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "PROF11"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramTable" + """:""" + paramTable + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("employer", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboSpouseBusinessAddress() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEmployeeProfile.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "PROF12"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramTable" + """:""" + paramTable + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("business_address", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function geCboSiblingOccupation() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEmployeeProfile.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "PROF13"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramTable" + """:""" + paramTable + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("occupation", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboSiblingRelation() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEmployeeProfile.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "PROF14"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramTable" + """:""" + paramTable + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("relation", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboChildRelation() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEmployeeProfile.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "PROF15"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramTable" + """:""" + paramTable + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("relation", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboChildOccupation() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEmployeeProfile.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "PROF16"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramTable" + """:""" + paramTable + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("occupation", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboMothersOccupation() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEmployeeProfile.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "PROF17"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramTable" + """:""" + paramTable + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("mother_occupation", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboFathersOccupation() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEmployeeProfile.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "PROF18"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramTable" + """:""" + paramTable + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("father_occupation", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboMotherLawOccupation() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEmployeeProfile.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "PROF19"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramTable" + """:""" + paramTable + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("motherinlaw_occupation", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboFatherLawOccupation() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEmployeeProfile.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "PROF20"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramTable" + """:""" + paramTable + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("fatherinlaw_occupation", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboReferencePosition() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEmployeeProfile.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "PROF21"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramTable" + """:""" + paramTable + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("occupation", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboReferenceAddress() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEmployeeProfile.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "PROF22"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramTable" + """:""" + paramTable + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("address", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboEfileType() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEmployeeProfile.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "PROF23"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramTable" + """:""" + paramTable + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("efile_code", GetType(String))
                .Columns.Add("description", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboDocType() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEmployeeProfile.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "PROF24"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramEFile" + """:""" + paramEFile + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("doc_code", GetType(String))
                .Columns.Add("description", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboMediaCategory() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEmployeeProfile.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "PROF25"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramEFile" + """:""" + paramEFile + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("mtype", GetType(String))
                .Columns.Add("description", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    '---------------------------------------------------------'
    '------------------ CONTACTS -----------------------------'
    '---------------------------------------------------------'

    Public Function getContacts() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmContactAddress.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "CA01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramTable" + """:""" + paramTable + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("street_address", GetType(String))
                    .Columns.Add("brgyname", GetType(String))
                    .Columns.Add("cityname", GetType(String))
                    .Columns.Add("mobile", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    '---------------------------------------------------------'
    '------------------ EMERGENCY CONTACTS -------------------'
    '---------------------------------------------------------'

    Public Function getEmergencyContacts() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmEmergencyContacts.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "EC01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("contact_name", GetType(String))
                    .Columns.Add("contact_address", GetType(String))
                    .Columns.Add("relation", GetType(String))
                    .Columns.Add("landline", GetType(String))
                    .Columns.Add("mobile", GetType(String))
                    .Columns.Add("email_address", GetType(String))
                    .Columns.Add("keyctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    '---------------------------------------------------------'
    '------------------ EDUCATIONAL ATTAINMENT ---------------'
    '---------------------------------------------------------'
    Public Function getEducationalAttainment() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmEducational.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "EDUC14"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("elementary", GetType(String))
                    .Columns.Add("secondary", GetType(String))
                    .Columns.Add("elem_honor", GetType(String))
                    .Columns.Add("secon_honor", GetType(String))
                    .Columns.Add("pri_grad_start", GetType(String))
                    .Columns.Add("sec_grad_start", GetType(String))
                    .Columns.Add("pri_grad", GetType(String))
                    .Columns.Add("sec_grad", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getCboElementary() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEducational.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "EDUC01"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("elementary", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboElementaryHonor() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEducational.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "EDUC02"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("elem_honor", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboHighschool() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEducational.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "EDUC03"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("secondary", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboHighschoolHonor() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEducational.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "EDUC04"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("secon_honor", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCollegeEducation() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmEducational.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "EDUC16"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("type_", GetType(String))
                    .Columns.Add("institution", GetType(String))
                    .Columns.Add("degree", GetType(String))
                    .Columns.Add("honor", GetType(String))
                    .Columns.Add("year_grad", GetType(String))
                    .Columns.Add("year_start", GetType(String))
                    .Columns.Add("sponsored_by", GetType(String))
                    .Columns.Add("total_cost", GetType(String))
                    .Columns.Add("keyctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getCboSchool() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEducational.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "EDUC05"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("institution", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getCboCollegeDegree() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEducational.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "EDUC06"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("degree", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboCollegeHonor() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEducational.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "EDUC07"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("honor", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboVocational() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEducational.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "EDUC08"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("institution", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboVocationalCourse() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEducational.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "EDUC09"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("vocation", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getVocationEducation() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmEducational.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "EDUC20"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("institution", GetType(String))
                    .Columns.Add("vocation", GetType(String))
                    .Columns.Add("year_start", GetType(String))
                    .Columns.Add("year_grad", GetType(String))
                    .Columns.Add("year_start", GetType(String))
                    .Columns.Add("sponsored_by", GetType(String))
                    .Columns.Add("total_cost", GetType(String))
                    .Columns.Add("keyctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getCboCertTitle() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEducational.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "EDUC10"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("certification", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCertification() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmEducational.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "EDUC24"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("certification", GetType(String))
                    .Columns.Add("yearcert_start", GetType(String))
                    .Columns.Add("yearcert", GetType(String))
                    .Columns.Add("rate", GetType(String))
                    .Columns.Add("certid", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getGraduates() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmEducational.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "EDUC28"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("institution", GetType(String))
                    .Columns.Add("degree", GetType(String))
                    .Columns.Add("honor", GetType(String))
                    .Columns.Add("year_start", GetType(String))
                    .Columns.Add("year_grad", GetType(String))
                    .Columns.Add("sponsored_by", GetType(String))
                    .Columns.Add("total_cost", GetType(String))
                    .Columns.Add("units", GetType(String))
                    .Columns.Add("keyctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getCboGraduateSchool() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEducational.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "EDUC11"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("institution", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboGraduateDegree() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEducational.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "EDUC12"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("degree", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboGraduateHonor() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmEducational.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "EDUC13"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("honor", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    '---------------------------------------------------------'
    '------------------ AWARDS -------------------------------'
    '---------------------------------------------------------'

    Public Function getCboTitle() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmRecognition.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "AWARD01"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramTable" + """:""" + paramTable + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("title", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboVenue() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmRecognition.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "AWARD02"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramTable" + """:""" + paramTable + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("received_venue", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getAwards() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmRecognition.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "AWARD03"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramTable" + """:""" + paramTable + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("title", GetType(String))
                    .Columns.Add("received_venue", GetType(String))
                    .Columns.Add("received_date", GetType(String))
                    .Columns.Add("keyctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    '---------------------------------------------------------'
    '------------------ LICENSE ------------------------------'
    '---------------------------------------------------------'
    Public Function getLicenses() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmLicenses.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "LISC04"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramTable" + """:""" + paramTable + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("descrip", GetType(String))
                    .Columns.Add("license_number", GetType(String))
                    .Columns.Add("Exp_Date", GetType(String))
                    .Columns.Add("days_prompt", GetType(String))
                    .Columns.Add("licensing_body", GetType(String))
                    .Columns.Add("remarks", GetType(String))
                    .Columns.Add("rating", GetType(String))
                    .Columns.Add("examdate", GetType(String))
                    .Columns.Add("examvenue", GetType(String))
                    .Columns.Add("daterelease", GetType(String))
                    .Columns.Add("eligibility", GetType(String))
                    .Columns.Add("keyctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getCboLiscDescription() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmLicenses.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "LISC01"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramTable" + """:""" + paramTable + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("descrip", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboLiscBody() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmLicenses.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "LISC02"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramTable" + """:""" + paramTable + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("licensing_body", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboLiscVenue() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmLicenses.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "LISC03"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramTable" + """:""" + paramTable + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("licensing_body", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    '---------------------------------------------------------'
    '------------------ EMPLOYEE PROFILE MANAGEMENT ----------'
    '---------------------------------------------------------'

    Public Function getSearchEmployeeProfile() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmEmployeeProfileManagement.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "EMP10"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramSearch" + """:""" + UCase(ValidateString(paramSearch)).ToString() + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("fullname", GetType(String))
                    .Columns.Add("myposition", GetType(String))
                    .Columns.Add("jstatusname", GetType(String))
                    .Columns.Add("jobstatus_date", GetType(String))
                    .Columns.Add("deptname", GetType(String))
                    .Columns.Add("divname", GetType(String))
                    .Columns.Add("image", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getCboNationality() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmAddEmployee.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "EMP02"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("citizenship", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getCboRequestNo() As DataTable

        Dim var As String = ""
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("code", GetType(String))
            For x = 1 To 100
                .Rows.Add(x)
            Next
        End With
        Dim row As DataRow = pDTable.NewRow
        pDTable.Rows.InsertAt(row, 0)
        Return pDTable
    End Function

    '---------------------------------------------------------'
    '------------------ TRAININGS ATTENDED -------------------'
    '---------------------------------------------------------'
    Public Function getTrainings() As DataTable
        Dim dtable As New DataTable

        Try

            ActiveFrm = "e_frmTrainings.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "TR01"

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
    Public Function getCboTrainingCategory() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmTrainingsAttended.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "TR02"

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
        Else
            Dim row As DataRow = dtable.NewRow
            dtable.Rows.InsertAt(row, 0)
        End If

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getCboTrainingProvider() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmTrainingsAttended.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "TR03"

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
        Else
            Dim row As DataRow = dtable.NewRow
            dtable.Rows.InsertAt(row, 0)
        End If

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getCboTrainingTopic(ByVal paramID As String) As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmTrainingsAttended.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "TR04"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramTable" + """:""" + paramTable + """," &
                     """" + "paramID" + """:""" + paramID + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("training", GetType(String))
            End With
        Else
            Dim row As DataRow = dtable.NewRow
            dtable.Rows.InsertAt(row, 0)
        End If

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getCboTrainingRemarks() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmTrainingsAttended.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "TR05"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramTable" + """:""" + paramTable + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("remarks", GetType(String))
            End With
        Else
            Dim row As DataRow = dtable.NewRow
            dtable.Rows.InsertAt(row, 0)
        End If

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getCboTrainingVenue() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmTrainingsAttended.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "TR06"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramTable" + """:""" + paramTable + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("venue", GetType(String))
            End With
        Else
            Dim row As DataRow = dtable.NewRow
            dtable.Rows.InsertAt(row, 0)
        End If

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getTrainingsAttended() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmTrainingsAttended.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "TR07"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("treq", GetType(String))
                    .Columns.Add("training", GetType(String))
                    .Columns.Add("training_provider", GetType(String))
                    .Columns.Add("venue", GetType(String))
                    .Columns.Add("hrs", GetType(String))
                    .Columns.Add("date_conducted", GetType(String))
                    .Columns.Add("total_cost", GetType(String))
                    .Columns.Add("training_category", GetType(String))
                    .Columns.Add("remarks", GetType(String))
                    .Columns.Add("registration_fee", GetType(String))
                    .Columns.Add("points", GetType(String))
                    .Columns.Add("sponsored_by", GetType(String))
                    .Columns.Add("date_start", GetType(String))
                    .Columns.Add("date_end", GetType(String))
                    .Columns.Add("tprovider", GetType(String))
                    .Columns.Add("category", GetType(String))
                    .Columns.Add("keyctr", GetType(String))
                    .Columns.Add("future_training_desc", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getTrainingsAndSeminarsConfig() As DataTable
        Dim dtable As New DataTable

        Try

            ActiveFrm = "e_frmTrainingsAndSeminarsConfig.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "CONF01"

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
    '------------------ SEMINARS ATTENDED --------------------'
    '---------------------------------------------------------'

    Public Function getCboSeminarTopic(ByVal paramID As String) As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmSeminarsAttended.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "SR01"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramID" + """:""" + paramID + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("title", GetType(String))
            End With
        Else
            Dim row As DataRow = dtable.NewRow
            dtable.Rows.InsertAt(row, 0)
        End If

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getCboSeminarRemarks() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmSeminarsAttended.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "SR02"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("remarks", GetType(String))
            End With
        Else
            Dim row As DataRow = dtable.NewRow
            dtable.Rows.InsertAt(row, 0)
        End If

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getCboSeminarVenue() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmSeminarsAttended.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "SR03"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramTable" + """:""" + paramTable + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("venue", GetType(String))
            End With
        Else
            Dim row As DataRow = dtable.NewRow
            dtable.Rows.InsertAt(row, 0)
        End If

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getSeminarsAttended() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmSeminarsAttended.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "SR04"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("treq", GetType(String))
                    .Columns.Add("title", GetType(String))
                    .Columns.Add("training_providerdesc", GetType(String))
                    .Columns.Add("venue", GetType(String))
                    .Columns.Add("hrs", GetType(String))
                    .Columns.Add("date_conducted", GetType(String))
                    .Columns.Add("total_cost", GetType(String))
                    .Columns.Add("training_category", GetType(String))
                    .Columns.Add("remarks", GetType(String))
                    .Columns.Add("registration_fee", GetType(String))
                    .Columns.Add("points", GetType(String))
                    .Columns.Add("sponsored_by", GetType(String))
                    .Columns.Add("date_start", GetType(String))
                    .Columns.Add("date_end", GetType(String))
                    .Columns.Add("training_provider", GetType(String))
                    .Columns.Add("category", GetType(String))
                    .Columns.Add("keyctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getJobDescriptionKRA() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmJobDescriptionKRA.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "KRA01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("jdescription", GetType(String))
                    .Columns.Add("keyctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getAreaResultMaintenance() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmKeyAreaMaintenance.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "AREA01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramPos" + """:""" + paramPos + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("kra_description", GetType(String))
                    .Columns.Add("kra_objectives", GetType(String))
                    .Columns.Add("org_goals", GetType(String))
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("weight", GetType(String))
                    .Columns.Add("joblevel", GetType(String))
                    .Columns.Add("kra_code", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getCboKra() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmJobDescriptionKRA.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "KRA05"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramPos" + """:""" + paramPos + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("kra_code", GetType(String))
                .Columns.Add("kra_description", GetType(String))
            End With
        Else
            Dim row As DataRow = dtable.NewRow
            dtable.Rows.InsertAt(row, 0)
        End If

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getCboKeyPerformance() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmJobDescriptionKRA.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "KRA07"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramID" + """:""" + paramID + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("kra_description", GetType(String))
                .Columns.Add("kra_objectives", GetType(String))
                .Columns.Add("org_goals", GetType(String))
                .Columns.Add("weight", GetType(String))
                .Columns.Add("kra_code", GetType(String))
            End With
        Else
            Dim row As DataRow = dtable.NewRow
            dtable.Rows.InsertAt(row, 0)
        End If

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getKeyPerformance() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmJobDescriptionKRA.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "KRA07"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("kra_description", GetType(String))
                    .Columns.Add("kra_objectives", GetType(String))
                    .Columns.Add("org_goals", GetType(String))
                    .Columns.Add("weight", GetType(String))
                    .Columns.Add("kra_code", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getTrainingKRA() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmJobDescriptionKRA.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "KRA09"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("kra_description", GetType(String))
                    .Columns.Add("competency", GetType(String))
                    .Columns.Add("ratings1", GetType(String))
                    .Columns.Add("ratings2", GetType(String))
                    .Columns.Add("ratings3", GetType(String))
                    .Columns.Add("competency_code", GetType(String))
                    .Columns.Add("kra_code", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getCboOtherID() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmOtherID.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "ID01"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("provider_code", GetType(String))
                .Columns.Add("description", GetType(String))
            End With
        Else
            Dim row As DataRow = dtable.NewRow
            dtable.Rows.InsertAt(row, 0)
        End If

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getOtherID() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmOtherID.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "ID02"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("provider_code", GetType(String))
                    .Columns.Add("o_idno", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getCboShiftCode() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmOfficialTravel.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "TRV01"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramID" + """:""" + paramID + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("shfcode", GetType(String))
                .Columns.Add("shift_In", GetType(String))
                .Columns.Add("sbreak_in", GetType(String))
                .Columns.Add("sbreak_out", GetType(String))
                .Columns.Add("shift_out", GetType(String))
                .Columns.Add("sbreak_start_nxday", GetType(String))
                .Columns.Add("sbreak_end_nxday", GetType(String))
            End With
        Else
            Dim row As DataRow = dtable.NewRow
            dtable.Rows.InsertAt(row, 0)
        End If

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboTravelDestination() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmOfficialTravel.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "TRV04"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("destination", GetType(String))

            End With
        Else
            Dim row As DataRow = dtable.NewRow
            dtable.Rows.InsertAt(row, 0)
        End If

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboTravelVenue() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmOfficialTravel.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "TRV05"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("venue", GetType(String))

            End With
        Else
            Dim row As DataRow = dtable.NewRow
            dtable.Rows.InsertAt(row, 0)
        End If

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getOfficialTravel() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmOfficialTravel.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "TRV12"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("date_file", GetType(String))
                    .Columns.Add("destination", GetType(String))
                    .Columns.Add("estimated_cost", GetType(String))
                    .Columns.Add("actual_cost", GetType(String))
                    .Columns.Add("time_start", GetType(String))
                    .Columns.Add("time_to", GetType(String))
                    .Columns.Add("expense_accom", GetType(String))
                    .Columns.Add("expense_meal", GetType(String))
                    .Columns.Add("expense_transpo", GetType(String))
                    .Columns.Add("expense_allowance", GetType(String))
                    .Columns.Add("expense_misc", GetType(String))
                    .Columns.Add("shftcode", GetType(String))
                    .Columns.Add("venue", GetType(String))
                    .Columns.Add("remarks", GetType(String))
                    .Columns.Add("air_fare", GetType(String))
                    .Columns.Add("reg_fee", GetType(String))
                    .Columns.Add("ca_liquidation", GetType(String))
                    .Columns.Add("driver_idno", GetType(String))
                    .Columns.Add("travel_type", GetType(String))
                    .Columns.Add("date_start", GetType(String))
                    .Columns.Add("date_end", GetType(String))
                    .Columns.Add("keyctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getCboLeaveEmployer() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmBackgroundExperience.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "BACK01"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramTable" + """:""" + paramTable + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("employer_name", GetType(String))

            End With
        Else
            Dim row As DataRow = dtable.NewRow
            dtable.Rows.InsertAt(row, 0)
        End If

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboLeaveAddress() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmBackgroundExperience.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "BACK02"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramTable" + """:""" + paramTable + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("address", GetType(String))

            End With
        Else
            Dim row As DataRow = dtable.NewRow
            dtable.Rows.InsertAt(row, 0)
        End If

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboLeavePosition() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmBackgroundExperience.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "BACK03"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramTable" + """:""" + paramTable + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("myposition", GetType(String))

            End With
        Else
            Dim row As DataRow = dtable.NewRow
            dtable.Rows.InsertAt(row, 0)
        End If

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getBackgroundExperience() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmBackgroundExperience.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "BACK04"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramTable" + """:""" + paramTable + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("governmentservice", GetType(String))
                    .Columns.Add("employer_name", GetType(String))
                    .Columns.Add("address", GetType(String))
                    .Columns.Add("tin_no", GetType(String))
                    .Columns.Add("myposition", GetType(String))
                    .Columns.Add("reason_leave", GetType(String))
                    .Columns.Add("myrate", GetType(String))
                    .Columns.Add("date_started", GetType(String))
                    .Columns.Add("tax_year", GetType(String))
                    .Columns.Add("taxable_income", GetType(String))
                    .Columns.Add("sss_prv", GetType(String))
                    .Columns.Add("ph_prv", GetType(String))
                    .Columns.Add("hdmf_prv", GetType(String))
                    .Columns.Add("taxwitheld", GetType(String))
                    .Columns.Add("tax_13th_month", GetType(String))
                    .Columns.Add("ntax_13th_month", GetType(String))
                    .Columns.Add("salarygrade", GetType(String))
                    .Columns.Add("statusofappointment", GetType(String))
                    .Columns.Add("date_start", GetType(String))
                    .Columns.Add("date_end", GetType(String))
                    .Columns.Add("keyctr", GetType(String))

                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getEmploymentChecklist() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmEmploymentChecklist.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "CHK01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("checklist_code", GetType(String))
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("date_receive", GetType(String))
                    .Columns.Add("time_receive", GetType(String))
                    .Columns.Add("recieve_by", GetType(String))
                    .Columns.Add("remarks", GetType(String))
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("keyctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getChecklistMaintenance() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmChecklistMaintenance.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "CHKM01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("checklist_code", GetType(String))
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("remarks", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getEmergencyRecords() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmEmergencyRecords.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "EMR01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("accident_date", GetType(String))
                    .Columns.Add("accident_time", GetType(String))
                    .Columns.Add("accident_address", GetType(String))
                    .Columns.Add("accident_involved", GetType(String))
                    .Columns.Add("personal_injury", GetType(String))
                    .Columns.Add("property_damage", GetType(String))
                    .Columns.Add("description_accident", GetType(String))
                    .Columns.Add("part_of_job", GetType(String))
                    .Columns.Add("ifnotwhy_1", GetType(String))
                    .Columns.Add("extent_disability", GetType(String))
                    .Columns.Add("permanent_partial", GetType(String))
                    .Columns.Add("nature_injury_ilness", GetType(String))
                    .Columns.Add("date_disability_begun", GetType(String))
                    .Columns.Add("days_lost", GetType(String))
                    .Columns.Add("fatal", GetType(String))
                    .Columns.Add("temporary_total", GetType(String))
                    .Columns.Add("parts_body_affected", GetType(String))
                    .Columns.Add("date_return_work", GetType(String))
                    .Columns.Add("days_charged", GetType(String))
                    .Columns.Add("permanent_total", GetType(String))
                    .Columns.Add("medical_treatment", GetType(String))
                    .Columns.Add("agency_involved", GetType(String))
                    .Columns.Add("agency_part_involved", GetType(String))
                    .Columns.Add("accident_type", GetType(String))
                    .Columns.Add("unsafe_mechanical_physical_condition", GetType(String))
                    .Columns.Add("unsafe_act", GetType(String))
                    .Columns.Add("contributing_factor", GetType(String))
                    .Columns.Add("preventive_measures", GetType(String))
                    .Columns.Add("mechanical_guards", GetType(String))
                    .Columns.Add("safeguard_inused", GetType(String))
                    .Columns.Add("ifnotwhy_2", GetType(String))
                    .Columns.Add("compensation", GetType(String))
                    .Columns.Add("medical_hospitalization", GetType(String))
                    .Columns.Add("burial", GetType(String))
                    .Columns.Add("time_lost_day", GetType(String))
                    .Columns.Add("time_lost_subsequent", GetType(String))
                    .Columns.Add("time_light_work", GetType(String))
                    .Columns.Add("time_lost_day_hrs", GetType(String))
                    .Columns.Add("time_lost_subsequent_hrs", GetType(String))
                    .Columns.Add("time_light_work_day", GetType(String))
                    .Columns.Add("compensation_value", GetType(String))
                    .Columns.Add("time_lost_day_mins", GetType(String))
                    .Columns.Add("time_lost_subsequent_mins", GetType(String))
                    .Columns.Add("percent_output", GetType(String))
                    .Columns.Add("damage_machinery", GetType(String))
                    .Columns.Add("cost_of_repair", GetType(String))
                    .Columns.Add("lost_production_time_1", GetType(String))
                    .Columns.Add("lost_production_time_1_cost", GetType(String))
                    .Columns.Add("damage_materials", GetType(String))
                    .Columns.Add("cost_repair_replacement_1", GetType(String))
                    .Columns.Add("lost_production_time_2", GetType(String))
                    .Columns.Add("lost_production_time_2_cost", GetType(String))
                    .Columns.Add("damage_equipment", GetType(String))
                    .Columns.Add("cost_repair_replacement_2", GetType(String))
                    .Columns.Add("lost_production_time_3", GetType(String))
                    .Columns.Add("leave_start", GetType(String))
                    .Columns.Add("leave_end", GetType(String))
                    .Columns.Add("nohrs", GetType(String))
                    .Columns.Add("accno", GetType(String))
                    .Columns.Add("trail", GetType(String))

                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getCompanyList() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmCompany.php"

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
                    .Columns.Add("area_description", GetType(String))
                    .Columns.Add("address", GetType(String))
                    .Columns.Add("contact_no", GetType(String))
                    .Columns.Add("zip_code", GetType(String))
                    .Columns.Add("date_from", GetType(String))
                    .Columns.Add("date_to", GetType(String))
                    .Columns.Add("keyperson", GetType(String))
                    .Columns.Add("officer_admin", GetType(String))
                    .Columns.Add("officer_standardization", GetType(String))
                    .Columns.Add("officer_hr", GetType(String))
                    .Columns.Add("officer_management", GetType(String))
                    .Columns.Add("officer_finance", GetType(String))
                    .Columns.Add("officer_mis", GetType(String))
                    .Columns.Add("officer_acctng", GetType(String))
                    .Columns.Add("officer_records", GetType(String))
                    .Columns.Add("officer_audit", GetType(String))
                    .Columns.Add("officer_ceo", GetType(String))
                    .Columns.Add("tin_no", GetType(String))
                    .Columns.Add("hdmf_no", GetType(String))
                    .Columns.Add("sss_no", GetType(String))
                    .Columns.Add("gsis_no", GetType(String))
                    .Columns.Add("ph_no", GetType(String))
                    .Columns.Add("active_year", GetType(String))
                    .Columns.Add("sms_description", GetType(String))
                    .Columns.Add("keyctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getDivision() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmDivision.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "DIV01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "ActiveCompany" + """:""" + ActiveCompany + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("area_", GetType(String))
                    .Columns.Add("divcode", GetType(String))
                    .Columns.Add("divname", GetType(String))
                    .Columns.Add("address", GetType(String))
                    .Columns.Add("landline", GetType(String))
                    .Columns.Add("mobile", GetType(String))
                    .Columns.Add("fax", GetType(String))
                    .Columns.Add("email", GetType(String))
                    .Columns.Add("keyperson", GetType(String))
                    .Columns.Add("costcode", GetType(String))
                    .Columns.Add("year_work_days", GetType(String))
                    .Columns.Add("hourly_divisor", GetType(String))
                    .Columns.Add("area_description", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getDepartmentMaintenance() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmDepartment.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "DEPT01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramDiv" + """:""" + paramDiv + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("divcode", GetType(String))
                    .Columns.Add("deptcode", GetType(String))
                    .Columns.Add("deptname", GetType(String))
                    .Columns.Add("keyperson", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getSectionMaintenance() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmSection.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "SEC01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "ActiveCompany" + """:""" + ActiveCompany + """," &
                         """" + "paramDiv" + """:""" + paramDiv + """," &
                         """" + "paramDept" + """:""" + paramDept + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("company_", GetType(String))
                    .Columns.Add("divcode", GetType(String))
                    .Columns.Add("deptcode", GetType(String))
                    .Columns.Add("seccode", GetType(String))
                    .Columns.Add("seccname", GetType(String))
                    .Columns.Add("keyperson", GetType(String))
                    .Columns.Add("landline", GetType(String))
                    .Columns.Add("mobile", GetType(String))
                    .Columns.Add("fax", GetType(String))
                    .Columns.Add("email", GetType(String))
                    .Columns.Add("remarks", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getPositionMaintenance() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmPosition.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "POS01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "ActiveCompany" + """:""" + ActiveCompany + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("pcode", GetType(String))
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("item_no", GetType(String))
                    .Columns.Add("company", GetType(String))
                    .Columns.Add("division", GetType(String))
                    .Columns.Add("jobtype", GetType(String))
                    .Columns.Add("jobgrade", GetType(String))
                    .Columns.Add("steps", GetType(String))
                    .Columns.Add("catcode", GetType(String))
                    .Columns.Add("shortdesc", GetType(String))
                    .Columns.Add("active", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getPositionStatusMaintenance() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmPositionStatus.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "POS01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("pcode", GetType(String))
                    .Columns.Add("description", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getPositionCategoryMaintenance() As DataTable 'For Listview Position Category Maintenance
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmPositionCategory.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "POSC01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("catcode", GetType(String))
                    .Columns.Add("description", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getCboDivision() As DataTable 'For ComboBox Division 
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmGroup.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "GROUP01"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "ActiveCompany" + """:""" + ActiveCompany + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        Dim row As DataRow = dtable.NewRow

        row("divcode") = "ALL"
        row("divname") = "ALL"
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboDepartment() As DataTable ' For ComboBox Department
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "modHRMAX.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "HRMAX07"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramDiv" + """:""" + paramDiv + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        Dim row As DataRow = dtable.NewRow
        row("deptcode") = ""
        row("deptname") = ""
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboSection() As DataTable ' For ComboBox Section
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmGroup.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "GROUP03"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "ActiveCompany" + """:""" + ActiveCompany + """," &
                     """" + "paramDiv" + """:""" + paramDiv + """," &
                     """" + "paramDept" + """:""" + paramDept + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("seccode", GetType(String))
                .Columns.Add("secname", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboGroup() As DataTable ' For ComboBox Group
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmForcastedAssignment.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "FRCS01"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "ActiveCompany" + """:""" + ActiveCompany + """," &
                     """" + "paramDiv" + """:""" + paramDiv + """," &
                     """" + "paramDept" + """:""" + paramDept + """," &
                     """" + "paramSec" + """:""" + paramSec + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("grpcode", GetType(String))
                .Columns.Add("grpname", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboGroupApprover() As DataTable ' For ComboBox Group
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmTransactionSignatory.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "TRANS11"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("ctr", GetType(String))
                .Columns.Add("short_definition", GetType(String))
                .Columns.Add("description", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboCostCenter() As DataTable ' For ComboBox Cost Center
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmForcastedAssignment.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "FRCS02"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("costcode", GetType(String))
                .Columns.Add("costname", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getGroupMaintenance() As DataTable 'For ListView Group Maintenance
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmGroup.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "GROUP04"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "ActiveCompany" + """:""" + ActiveCompany + """," &
                         """" + "paramDiv" + """:""" + paramDiv + """," &
                         """" + "paramDept" + """:""" + paramDept + """," &
                         """" + "paramSec" + """:""" + paramSec + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("company_", GetType(String))
                    .Columns.Add("divcode", GetType(String))
                    .Columns.Add("deptcode", GetType(String))
                    .Columns.Add("seccode", GetType(String))
                    .Columns.Add("grpcode", GetType(String))
                    .Columns.Add("grpname", GetType(String))
                    .Columns.Add("keyperson", GetType(String))
                    .Columns.Add("landline", GetType(String))
                    .Columns.Add("mobile", GetType(String))
                    .Columns.Add("fax", GetType(String))
                    .Columns.Add("email", GetType(String))
                    .Columns.Add("remarks", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getAreaMaintenance() As DataTable 'For ListView Area Maintenance
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmDivisionAreaConfig.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "AREA01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("area_description", GetType(String))
                    .Columns.Add("keyctr_", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getCostCenterMaintenance() As DataTable 'For ListView Area Maintenance
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmCostCenter.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "CNTR01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("costcode", GetType(String))
                    .Columns.Add("costname", GetType(String))
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("dr_account", GetType(String))
                    .Columns.Add("address", GetType(String))
                    .Columns.Add("contact", GetType(String))
                    .Columns.Add("admin_fee", GetType(String))
                    .Columns.Add("vat_ex", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getForcasted() As DataTable 'For ListView Forcasted Maintenance
        Dim dtable As New DataTable
        Try

            ActiveFrm = "e_frmForcastedAssignment.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "FRCS03"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("fullname", GetType(String))
                    .Columns.Add("company_", GetType(String))
                    .Columns.Add("divcode", GetType(String))
                    .Columns.Add("deptcode", GetType(String))
                    .Columns.Add("seccode", GetType(String))
                    .Columns.Add("grpcode", GetType(String))
                    .Columns.Add("costcode", GetType(String))
                    .Columns.Add("immediate_head", GetType(String))
                    .Columns.Add("date_assign_from", GetType(String))
                    .Columns.Add("date_assign_to", GetType(String))
                    .Columns.Add("active_", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getCboPositionCategory() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "e_frmPosition.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "POS02"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("catcode", GetType(String))
                .Columns.Add("description", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

#Region "Health Benefits"
    Public Function getCboBenCode() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "frmHealthBenefits.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "BEN01"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramID" + """:""" + paramID + """," &
                     """" + "paramYear" + """:""" + paramYear + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("benefitscode", GetType(String))
                .Columns.Add("benefitsname", GetType(String))
                .Columns.Add("tax_exempt", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getCboBeneficiary() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "frmHealthBenefits.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "BEN02"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("dname", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getCboComplain() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "frmHealthBenefits.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "BEN03"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("diagnosis", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getCboExist_Physician() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "frmHealthBenefits.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "BEN04"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("physician", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getCboExist_Center() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "frmHealthBenefits.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "BEN05"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("hcenter", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getCboFreq() As DataTable
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("code", GetType(String))
            .Columns.Add("desc", GetType(String))
            .Rows.Add(" ", " ")
            .Rows.Add("1", "ANNUAL")
            .Rows.Add("2", "ONCE EVERY 2 YEARS")
        End With
        Return pDTable
    End Function

    Public Function getBenefits() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmHealthBenefits.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "BEN06"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("benefitscode", GetType(String))
                    .Columns.Add("benefitsname", GetType(String))
                    .Columns.Add("remarks", GetType(String))
                    .Columns.Add("tax_exempt", GetType(String))
                    .Columns.Add("trail", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getCboBenCodeConfig() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "frmHealthBenefits.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "BEN06"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("benefitscode", GetType(String))
                .Columns.Add("benefitsname", GetType(String))
                .Columns.Add("tax_exempt", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getBenefitsApply() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmHealthBenefits.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "BEN12"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "paramYear" + """:""" + paramYear + """," &
                         """" + "paramBenCode" + """:""" + paramBenCode + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("bencode", GetType(String))
                    .Columns.Add("year_entry", GetType(String))
                    .Columns.Add("diagnosis", GetType(String))
                    .Columns.Add("beneficiary", GetType(String))
                    .Columns.Add("physician", GetType(String))
                    .Columns.Add("hcenter", GetType(String))
                    .Columns.Add("used", GetType(String))
                    .Columns.Add("orno", GetType(String))
                    .Columns.Add("amount", GetType(String))
                    .Columns.Add("remarks", GetType(String))
                    .Columns.Add("expenses", GetType(String))
                    .Columns.Add("claimed", GetType(String))
                    .Columns.Add("cutoff", GetType(String))
                    .Columns.Add("disburse_date", GetType(String))
                    .Columns.Add("claim_frequency", GetType(String))
                    .Columns.Add("claim_freq_description", GetType(String))
                    .Columns.Add("keyctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

#End Region

#Region "Shared Benefits"

    Public Function getSharedCboFreq() As DataTable
        Dim pDTable As New DataTable
        With pDTable
            .Columns.Add("code", GetType(String))
            .Columns.Add("desc", GetType(String))
            .Rows.Add(" ", " ")
            .Rows.Add("0", "ALWAYS")
            .Rows.Add("1", "1ST CUTOFF OF THE MONTH")
            .Rows.Add("2", "2ND CUTOFF OF THE MONTH")
            .Rows.Add("5", "1ST WEEK")
            .Rows.Add("6", "2ND WEEK")
            .Rows.Add("7", "3RD WEEK")
            .Rows.Add("8", "4TH WEEK")
            .Rows.Add("9", "5TH WEEK")
        End With
        Return pDTable
    End Function
    Public Function getCboSharedBenCode() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "frmSharedBenefits.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "BEN01"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("benefitcode", GetType(String))
                .Columns.Add("description", GetType(String))
                .Columns.Add("ddctcode", GetType(String))
                .Columns.Add("yer_table_based", GetType(String))
                .Columns.Add("yee_table_based", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getSharedBenefitsGiven(ByVal paramID As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmSharedBenefits.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "BEN02"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("benefitcode", GetType(String))
                    .Columns.Add("description", GetType(String))
                    .Columns.Add("date_start", GetType(String))
                    .Columns.Add("employee_share", GetType(String))
                    .Columns.Add("remarks", GetType(String))
                    .Columns.Add("keyctr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

#End Region

#Region "Appraisal Entries"
    Public Function getAppraisal(ByVal paramID As String, ByVal date_conducted As Date) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmAppraisalEntries.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "APP01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "varConductedDate" + """:""" + date_conducted + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("q1_a", GetType(String))
                    .Columns.Add("q1_b", GetType(String))
                    .Columns.Add("q1_c", GetType(String))
                    .Columns.Add("q2_a", GetType(String))
                    .Columns.Add("q2_b", GetType(String))
                    .Columns.Add("q2_c", GetType(String))
                    .Columns.Add("q2_d", GetType(String))
                    .Columns.Add("q3_a", GetType(String))
                    .Columns.Add("q3_b", GetType(String))
                    .Columns.Add("q3_c", GetType(String))
                    .Columns.Add("q3_d", GetType(String))
                    .Columns.Add("q4_a", GetType(String))
                    .Columns.Add("q4_b", GetType(String))
                    .Columns.Add("q4_c", GetType(String))
                    .Columns.Add("q4_d", GetType(String))
                    .Columns.Add("q4_e", GetType(String))
                    .Columns.Add("q5_a", GetType(String))
                    .Columns.Add("q5_b", GetType(String))
                    .Columns.Add("q5_c", GetType(String))
                    .Columns.Add("q6_a", GetType(String))
                    .Columns.Add("q6_b", GetType(String))
                    .Columns.Add("q7_a", GetType(String))
                    .Columns.Add("q7_b", GetType(String))
                    .Columns.Add("q7_c", GetType(String))
                    .Columns.Add("q8_a", GetType(String))
                    .Columns.Add("q8_b", GetType(String))
                    .Columns.Add("proc_year", GetType(String))
                    .Columns.Add("review_date", GetType(String))
                    .Columns.Add("im_head", GetType(String))
                    .Columns.Add("approvedby", GetType(String))
                    .Columns.Add("q3_e", GetType(String))
                    .Columns.Add("conducted_date", GetType(String))
                    .Columns.Add("comments_", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getAppraisalSubQuery(ByVal paramID As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmAppraisalEntries.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "APP02"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("conducted_date", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getAppraisalAverage(ByVal paramID As String, ByVal date_conducted As Date) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmAppraisalEntries.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "APP03"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "varConductedDate" + """:""" + date_conducted + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("average", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

#End Region

#Region "EFILES"
    Public Function getCboMemoCode(ByVal paramID As String, paramYear As String) As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "frmEfiles.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "EF01"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "paramID" + """:""" + paramID + """," &
                     """" + "paramYear" + """:""" + paramYear + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("memocode", GetType(String))
                .Columns.Add("date_given", GetType(String))
                .Columns.Add("memo_title", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getHRMAX_Generated(ByVal paramID As String, paramYear As String) As DataTable
        Dim dtable As New DataTable

        Try

            ActiveFrm = "frmEfiles.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "EF03"

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
                    .Columns.Add("entrynumber", GetType(String))
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("violationcode", GetType(String))
                    .Columns.Add("servedby", GetType(String))
                    .Columns.Add("dateserved", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    Public Function getCboViolation_Code() As DataTable
        Dim pTable As DataTable = New DataTable()

        ActiveFrm = "frmEfiles.php"

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "EF04"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("violationcode", GetType(String))
                .Columns.Add("description", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
#End Region

#Region "LEAVE ENTRY"

    'Public Function getCboLeaveType() As DataTable
    '    Dim pTable As DataTable = New DataTable()

    '    ActiveFrm = "t_frmLeave.php"

    '    Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
    '    MC = "LVTRANS01"

    '    jStr_Input = "{" + """token" + """:""" + Token + """," &
    '                 """" + "ActiveCompany" + """:""" + ActiveCompany + """," &
    '                 """" + "paramYear" + """:""" + paramYear + """," &
    '                 """" + "MC" + """:""" + MC + """}"

    '    Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
    '                              ServerTxt & ActiveFrm,
    '                              "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

    '    If IsNothing(dtable) Then
    '        dtable = New DataTable
    '        With dtable
    '            .Columns.Add("leave_type", GetType(String))
    '            .Columns.Add("description", GetType(String))
    '            .Columns.Add("sex", GetType(String))
    '            .Columns.Add("ltype", GetType(String))
    '            .Columns.Add("unused_type", GetType(String))
    '        End With
    '    End If

    '    Dim row As DataRow = dtable.NewRow
    '    dtable.Rows.InsertAt(row, 0)

    '    pTable = New DataTable
    '    pTable = dtable.Copy

    '    Return pTable
    'End Function

    Public Function getLeaveBalances() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "t_frmLeave.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "LVTRANS02"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("cyear", GetType(String))
                    .Columns.Add("leave_type", GetType(String))
                    .Columns.Add("balance", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function
    'Public Function getFiledLeave(ByVal paramID As String, ByVal paramYear As String) As DataTable
    '    Dim dtable As New DataTable
    '    Try

    '        ActiveFrm = "t_frmLeave.php"

    '        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

    '        MC = "LVTRANS03"

    '        jStr_Input = "{" + """token" + """:""" + Token + """," &
    '                     """" + "paramID" + """:""" + paramID + """," &
    '                     """" + "paramYear" + """:""" + paramYear + """," &
    '                     """" + "MC" + """:""" + MC + """}"

    '        dtable = ws.JsonStr2DTable(jStr_Input,
    '                                    ServerTxt & ActiveFrm,
    '                                    "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

    '        If IsNothing(dtable) Then
    '            dtable = New DataTable
    '            With dtable
    '                .Columns.Add("date_leave", GetType(String))
    '                .Columns.Add("ldesc", GetType(String))
    '                .Columns.Add("reasons", GetType(String))
    '                .Columns.Add("wpay_hours", GetType(String))
    '                .Columns.Add("wopay_hours", GetType(String))
    '                .Columns.Add("posted", GetType(String))
    '                .Columns.Add("description", GetType(String))
    '                .Columns.Add("lv_category", GetType(String))
    '                .Columns.Add("trail_", GetType(String))
    '                .Columns.Add("ctr_", GetType(String))
    '                .Columns.Add("address_on_leave", GetType(String))
    '                .Columns.Add("leavetype", GetType(String))
    '            End With
    '        End If

    '    Catch ex As Exception
    '    End Try
    '    Return dtable
    'End Function

    Public Function getLeaveScheduling(ByVal paramID As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "t_frmLeave.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "LVTRANS04"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
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
                    .Columns.Add("max_hr", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getLeaveSetupBalances(ByVal paramID As String, ByVal paramYear As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "t_frmLeave.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "LVTRANS05"

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
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("leave_type", GetType(String))
                    .Columns.Add("ltype", GetType(String))
                    .Columns.Add("debit", GetType(String))
                    .Columns.Add("credit", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getLeaveBenefitsTotalHours(ByVal paramID As String, ByVal paramYear As String, ByVal leaveStart As Date, ByVal leaveEnd As Date) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "t_frmLeave.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "LVTRANS06"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "paramYear" + """:""" + paramYear + """," &
                         """" + "leaveStart" + """:""" + Format(CDate(leaveStart), "yyyy-MM-dd") + """," &
                         """" + "leaveEnd" + """:""" + Format(CDate(leaveEnd), "yyyy-MM-dd") + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("leavetype", GetType(String))
                    .Columns.Add("ttl_credit", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getHourlyDivisor(ByVal paramID As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "t_frmLeave.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "LVTRANS07"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("divcode", GetType(String))
                    .Columns.Add("hourly_divisor", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getLeaveYearlyCeiling(ByVal paramID As String, ByVal paramYear As String) As DataTable
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
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("wpay_days", GetType(String))
                    .Columns.Add("lvwpay_days_ceiling", GetType(String))
                    .Columns.Add("hourly_divisor", GetType(String))
                    .Columns.Add("lvwpay_days_ceiling", GetType(String))
                    .Columns.Add("lvwpay_daysbal", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getLeaveMaintenance() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "t_frmLeave.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "LVTRANS09"

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
                    .Columns.Add("convert_leavetype", GetType(String))
                    .Columns.Add("convert_nohrs_ceiling", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getLeaveSavings_Balances(ByVal paramID As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "t_frmLeave.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "LVTRANS10"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("leave_type", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getLeaveSavingsSetup_Balances(ByVal paramID As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "t_frmLeave.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "LVTRANS11"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("leave_type", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getUnused_Ledger(ByVal paramID As String) As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "t_frmLeave.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "LVTRANS11"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "paramID" + """:""" + paramID + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("idno", GetType(String))
                    .Columns.Add("leave_type", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function



#End Region



End Module
