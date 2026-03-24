Imports NXNParsing

Module modDashboard
    Private ActiveFrm As String = "modDashboard.php"
    Private jStr_Input As String = "[]"
    Private ws As New WSConnection
    Private Token As String = String.Empty
    Public Function getTotalEmployees() As DataTable
        Dim dtable As New DataTable
        Try

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "DASH01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "ActiveCompany" + """:""" + ActiveCompany + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("total_employee", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getTotalApplicant() As DataTable
        Dim dtable As New DataTable
        Try

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "DASH02"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("total_applicant", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getTotalOnLeaveEmployees() As DataTable
        Dim dtable As New DataTable
        Try

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "DASH03"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "varDateNow" + """:""" + CDate(Now) + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("total_leave", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getTotaLOnTravelEmployees() As DataTable
        Dim dtable As New DataTable
        Try

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "DASH04"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "varDateNow" + """:""" + CDate(Now) + """," &
                         """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("total_travel", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    Public Function getDashboard_Analytics() As DataTable
        Dim dtable As New DataTable

        Try

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            MC = "DASH05"

            ActiveUserID = "083171"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "varYear" + """:""" + 2024.ToString + """," &
                  """" + "ActiveUserID" + """:""" + ActiveUserID + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If IsNothing(dtable) Then
                dtable = New DataTable
                With dtable
                    .Columns.Add("div_count", GetType(String))
                    .Columns.Add("divcode", GetType(String))
                    .Columns.Add("divname", GetType(String))
                End With
            End If

        Catch ex As Exception
        End Try
        Return dtable
    End Function

    'rey
    Public Function getEmployeeLogs() As DataTable
        Dim dtable As New DataTable
        Try

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "DASH06"


            ActiveUserID = "083171"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "varYear" + """:""" + 2024.ToString + """," &
                  """" + "varDateNow" + """:""" + CDate(Now) + """," &
                  """" + "ActiveUserID" + """:""" + ActiveUserID + """," &
                  """" + "MC" + """:""" + MC + """}"

            dtable = ws.JsonStr2DTable(jStr_Input,
                                        ServerTxt & ActiveFrm,
                                        "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")


            If IsNothing(dtable) OrElse dtable.Columns.Count = 0 Then
                dtable = New DataTable
                With dtable.Columns
                    .Add("idno", GetType(String))
                    .Add("full_name", GetType(String))
                    .Add("final_remarks", GetType(String))
                    .Add("attdate", GetType(String))
                End With
            End If

        Catch ex As Exception

        End Try
        Return dtable
    End Function


End Module
