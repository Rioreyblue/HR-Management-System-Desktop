Imports NXNParsing

Public Class UserControl1
    Private jStr_Input As String = "[]"
    Private ws As New WSConnection
    Private Token As String = String.Empty
    Private ActiveFrm As String = "frmRecruitment.php"
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If lblJobCode.Text <> "" Then
            With frmCreateJob
                .jobctr_ = lblJobCode.Text
                .StartPosition = FormStartPosition.CenterScreen
                .ShowDialog()
            End With
        End If
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lblJobCode.Text <> "" Then
            With frmCreateJob
                .jobctr_ = lblJobCode.Text
                If MsgBox("Are you sure you want to Delete?", vbQuestion + vbYesNo) = vbYes Then
                    Dim var_del As String = lblJobCode.Text
                    DeleteJob(var_del)
                End If
            End With
        End If
    End Sub

    Private Sub DeleteJob(var_del As String)
        Try
            MC = "REC05"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            jStr_Input = "{" + """token" + """:""" + Token + """," &
                  """" + "var_del" + """:""" + var_del + """," &
                  """" + "MC" + """:""" + MC + """}"
            Dim res As String = ws.JsonStr2JsonStr(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If res = """sysmaint""" Then
                MsgBox("Unable to Delete, only administrator.", vbCritical)
            ElseIf res = """done""" Then
                MsgBox("Job Maintenance Deleted.", vbInformation)
                Call frmHiringJob.HiringJob_List()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class
