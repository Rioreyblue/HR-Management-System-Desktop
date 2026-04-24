
Imports NXNParsing

Public Class UCJobAction
    Private jStr_Input As String = "[]"
    Private ws As New WSConnection
    Private Token As String = String.Empty
    Private ActiveFrm As String = "frmRecruitment.php"
    Public Property appName_ As String = String.Empty
    Public Property appContact_ As String = String.Empty
    Public Property appID_ As String = String.Empty
    Public Property appPINCODE_ As String = String.Empty
    Private Sub btnAction_Click(sender As Object, e As EventArgs) Handles btnAction.Click
        Dim message_ As String = String.Empty

        Try
            MC = "AFFL04"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                                      """" + "paramID" + """:""" + paramID + """," &
                                      """" + "MC" + """:""" + MC + """}"
            Dim res As String = ws.JsonStr2JsonStr(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            If res = """done""" Then
                message_ = "HRMAX RECRUITMENT:" & vbCrLf &
                       "Hi " & Me.appName_ & ", we've reviewed your application. Please use Applicant No. : " & appID_ & " and PINCODE : " & appPINCODE_ & " as your credentials. " & vbCrLf &
                       "Please take the exam here: http://192.168.99.4/hrmaxv14_bugemco/hrmax/applicant/app_exam/" & vbCrLf &
                       "Thank you!"

                MsgBox("Applicants moved to For Examination !", vbInformation)
            Else
                MsgBox("Error to Save, Please Contact System Administrator !", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        If btnAction.Text = "For Examination" Then

            AddSmsData("NEXEN", appContact_.Replace("-", "").Trim(), message_, CDate(Now))
        End If
    End Sub
End Class
