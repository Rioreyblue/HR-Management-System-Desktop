Imports NXNParsing

Public Class UCAppliedPosition
    Private jStr_Input As String = "[]"
    Private ws As New WSConnection
    Private Token As String = String.Empty
    Private ActiveFrm As String = "frmSelectionLineupApplicant.php"

    Public Property ApplicantName As String = String.Empty
    Public Property ApplicantMobile As String = String.Empty
    Public Property ApplicantJob As String = String.Empty
    Public Property ApplicantID As String = String.Empty
    Public Property ApplicantPIN As String = String.Empty
    Public Property ApplicantBatch As String = String.Empty

    Public Property for_examination As String = "false"
    Public Property for_requirements As String = "false"
    Public Property for_interview As String = "false"
    Public Property for_pooling As String = "false"
    Public Property hired As String = "false"
    Public Property not_qaulified As String = "false"

    Private Sub UCAppliedPosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' rey task 
        If hired.ToLower() = "true" Or not_qaulified.ToLower() = "true" Then
            Me.Visible = False
            Exit Sub
        End If
    End Sub

    Private Sub btnExamination_Click(sender As Object, e As EventArgs) Handles btnExamination.Click, btnRequirements.Click, btnInterview.Click, btnPooling.Click, btnHired.Click, btnFail.Click
        Dim message_ As String = String.Empty
        Dim cBtn As Button = CType(sender, Button)
        ' move from up to reuse nako
        Dim ask = MsgBox("Are you sure you want to move this applicant to " & cBtn.Text.Replace("+ ", "") & "?",
                         vbYesNo + vbQuestion, "Confirm Action")

        If ask = vbNo Then Exit Sub

        Try
            Dim ApplicantAction As String = String.Empty

            Select Case cBtn.Name
                Case "btnExamination" : ApplicantAction = 1
                Case "btnRequirements" : ApplicantAction = 2
                Case "btnInterview" : ApplicantAction = 3
                Case "btnPooling" : ApplicantAction = 4
                Case "btnHired" : ApplicantAction = 5
                Case "btnFail" : ApplicantAction = 6
            End Select

            MC = "SEL02"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                            """" + "ApplicantID" + """:""" + ApplicantID + """," &
                            """" + "ApplicantJob" + """:""" + ApplicantJob + """," &
                            """" + "ApplicantAction" + """:""" + ApplicantAction + """," &
                            """" + "MC" + """:""" + MC + """}"

            Dim res As String = ws.JsonStr2JsonStr(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If res = """done""" Then
                If cBtn.Name = "btnHired" Or cBtn.Name = "btnFail" Then
                    Me.Visible = False
                End If

                If ApplicantAction = 1 Then
                    message_ = "HRMAX RECRUITMENT:" & vbCrLf &
                               "Hi " & Me.ApplicantName & ", we've reviewed your application..."
                    AddSmsData("NEXEN", ApplicantMobile.Replace("-", "").Trim(), message_, CDate(Now))
                    MsgBox("Applicants moved to For Examination !", vbInformation)
                ElseIf ApplicantAction = 2 Then
                    MsgBox("Applicants moved to For Requirements !", vbInformation)
                ElseIf ApplicantAction = 3 Then
                    MsgBox("Applicants moved to For Interview !", vbInformation)
                ElseIf ApplicantAction = 4 Then
                    MsgBox("Applicants moved to For Pooling !", vbInformation)
                ElseIf ApplicantAction = 5 Then
                    MsgBox("Applicants has been Hired !", vbInformation)
                ElseIf ApplicantAction = 6 Then
                    MsgBox("Applicants has been Failed !", vbInformation)
                End If
            Else
                MsgBox("Error to Save!", vbCritical)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class