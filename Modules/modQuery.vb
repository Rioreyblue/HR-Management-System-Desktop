Imports NXNParsing
Module modQuery

    Dim jStr_Input As String
    Dim ws As New WSConnection
    Dim Token As String
    Public phpFile As String = "modQuery.php"

    Public rDtable As New DataTable 'Global Datatable
    Public rsDrow_() As DataRow     'Global Datarow

    Public Function SELECT_QUERY(paramQuery As String) As DataTable
        MC = "MOD01"
        Try
            Token = ws.xGenKey(phpFile, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "sendQuery" + """:""" + paramQuery.ToString + """," &
                         """" + "MC" + """:""" + MC + """}"
            Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input, ServerTxt & phpFile, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If dtable IsNot Nothing Then
                rDtable = New DataTable
                rDtable = dtable.Copy
                rsDrow_ = dtable.Select
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        Return rDtable
    End Function

    Public Function EXEC_QUERY(paramQuery As String) As DataTable
        MC = "MOD03"
        Try
            Token = ws.xGenKey(phpFile, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "sendQuery" + """:""" + paramQuery.ToString + """," &
                         """" + "MC" + """:""" + MC + """}"
            Dim res As String = ws.JsonStr2JsonStr(jStr_Input, ServerTxt & phpFile, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        Return Nothing
    End Function
End Module
