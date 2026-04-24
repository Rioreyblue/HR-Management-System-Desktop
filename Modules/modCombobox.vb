Imports NXNParsing

Module modCombobox

    Private ActiveFrm As String = "modCombobox.php"
    Private jStr_Input As String = "[]"
    Private ws As New WSConnection
    Private Token As String = String.Empty
    Public Function getCboArea() As DataTable 'For Combobox Area
        Dim pTable As DataTable = New DataTable()

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "CMB01"
        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("keyctr_", GetType(String))
                .Columns.Add("area_description", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getCboJobLevel() As DataTable
        Dim pTable As DataTable = New DataTable()

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "CMB02"
        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("jlevelcode", GetType(String))
                .Columns.Add("jlevelname", GetType(String))
            End With
        End If
        Dim row As DataRow = dtable.NewRow
        row("jlevelcode") = "ALL"
        row("jlevelname") = "ALL"
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getCboJobStatus() As DataTable
        Dim pTable As DataTable = New DataTable()

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        MC = "CMB03"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("jstatuscode", GetType(String))
                .Columns.Add("jstatusname", GetType(String))
                .Columns.Add("timebounded", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    'payslip custom by rey
    Public Function getCboPaySlipCutOff() As DataTable
        Dim pTable As DataTable = New DataTable()

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        MC = "CMB10"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        'Dim Interger = dtable.Rows.Count

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("cutoff", GetType(String))
                .Columns.Add("payroll_date", GetType(String))
                .Columns.Add("datestart", GetType(String))
                .Columns.Add("dateend", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getCboPosition() As DataTable
        Dim pTable As DataTable = New DataTable()

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "CMB04"

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

    Public Function getCboPositionStatus() As DataTable
        Dim pTable As DataTable = New DataTable()

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        MC = "CMB05"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
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

    Public Function getCboJobSteps() As DataTable
        Dim pTable As DataTable = New DataTable()

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "CMB06"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("stepcode", GetType(String))
                .Columns.Add("stepname", GetType(String))
                .Columns.Add("stepSelect", GetType(String))
            End With
        End If

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getCboCTCIssue() As DataTable
        Dim pTable As DataTable = New DataTable()

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "CMB07"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("cedula_place", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function

    Public Function getCboTax() As DataTable
        Dim pTable As DataTable = New DataTable()

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "CMB08"

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
                .Columns.Add("tax1", GetType(String))
                .Columns.Add("tax2", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
    Public Function getCboBank() As DataTable
        Dim pTable As DataTable = New DataTable()

        Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        MC = "CMB09"

        jStr_Input = "{" + """token" + """:""" + Token + """," &
                     """" + "MC" + """:""" + MC + """}"

        Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input,
                                  ServerTxt & ActiveFrm,
                                  "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

        If IsNothing(dtable) Then
            dtable = New DataTable
            With dtable
                .Columns.Add("bankcode", GetType(String))
                .Columns.Add("bankname", GetType(String))
            End With
        End If

        Dim row As DataRow = dtable.NewRow
        dtable.Rows.InsertAt(row, 0)

        pTable = New DataTable
        pTable = dtable.Copy

        Return pTable
    End Function
End Module
