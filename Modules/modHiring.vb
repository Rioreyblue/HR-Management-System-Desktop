Imports Newtonsoft.Json
Imports NXNParsing

Module modHiring
    Private ActiveFrm As String = String.Empty
    Private jStr_Input As String = "[]"
    Private ws As New WSConnection
    Private Token As String = String.Empty

#Region "Applicant Listing"
    Public Function get_applicant_profile() As DataTable
        Dim dtable As New DataTable
        Try

            ActiveFrm = "frmRecruitment.php"

            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "REC01"

            jStr_Input = "{" + """token" + """:""" + Token + """," &
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
                End With
            End If
        Catch ex As Exception
        End Try
        Return dtable

    End Function
#End Region
#Region "Applicant Skills"

    Public Function GetApplicantSkills(ByVal paramID As String) As List(Of ApplicantSkills)
        Try
            ActiveFrm = "frmRecruitment.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "REC02"
            Dim inputData = New With {.token = Token, .MC = MC, .paramID = paramID}
            Dim jStr_Input As String = JsonConvert.SerializeObject(inputData)

            Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If dtable IsNot Nothing AndAlso dtable.Rows.Count > 0 Then
                Dim json As String = JsonConvert.SerializeObject(dtable)
                Return JsonConvert.DeserializeObject(Of List(Of ApplicantSkills))(json)
            End If

        Catch ex As Exception
            MessageBox.Show("Failed to load Skills." & vbCrLf & vbCrLf &
                            "Error: " & ex.Message,
                            "Database Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
        Return New List(Of ApplicantSkills)()
    End Function
#End Region

#Region "Maintenance Job"
    Public Function GetMaintenanceJobs() As List(Of MaintenanceJob)
        Try
            ActiveFrm = "frmRecruitment.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "REC03"
            Dim inputData = New With {.token = Token, .MC = MC}
            Dim jStr_Input As String = JsonConvert.SerializeObject(inputData)

            Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If dtable IsNot Nothing AndAlso dtable.Rows.Count > 0 Then
                Dim json As String = JsonConvert.SerializeObject(dtable)
                Return JsonConvert.DeserializeObject(Of List(Of MaintenanceJob))(json)
            End If

        Catch ex As Exception
            MessageBox.Show("Failed to load Maintenance Jobs." & vbCrLf & vbCrLf &
                            "Error: " & ex.Message,
                            "Database Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
        Return New List(Of MaintenanceJob)()
    End Function
#End Region

#Region "Applicant Profile"
    Public Function GetApplicantProfile() As List(Of ApplicantProfile)
        Try
            ActiveFrm = "frmRecruitment.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "REC01"
            Dim inputData = New With {.token = Token, .MC = MC}
            Dim jStr_Input As String = JsonConvert.SerializeObject(inputData)

            Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If dtable IsNot Nothing AndAlso dtable.Rows.Count > 0 Then
                Dim json As String = JsonConvert.SerializeObject(dtable)
                Return JsonConvert.DeserializeObject(Of List(Of ApplicantProfile))(json)
            End If

        Catch ex As Exception
            MessageBox.Show("Failed to load Maintenance Jobs." & vbCrLf & vbCrLf &
                            "Error: " & ex.Message,
                            "Database Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
        Return New List(Of ApplicantProfile)()
    End Function
#End Region

#Region "Applicant Contacts"
    Public Function GetApplicantContacts() As List(Of ApplicantContacts)
        Try
            ActiveFrm = "frmRecruitment.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "REC08"
            Dim inputData = New With {.token = Token, .MC = MC}
            Dim jStr_Input As String = JsonConvert.SerializeObject(inputData)

            Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If dtable IsNot Nothing AndAlso dtable.Rows.Count > 0 Then
                Dim json As String = JsonConvert.SerializeObject(dtable)
                Return JsonConvert.DeserializeObject(Of List(Of ApplicantContacts))(json)
            End If

        Catch ex As Exception
            MessageBox.Show("Failed to load Maintenance Jobs." & vbCrLf & vbCrLf &
                            "Error: " & ex.Message,
                            "Database Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
        Return New List(Of ApplicantContacts)()
    End Function
#End Region

#Region "Vacant Position Application"
    Public Function GetVacantPositionApplication() As List(Of VacantPositionApplication)
        Try
            ActiveFrm = "frmRecruitment.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "REC06"
            Dim inputData = New With {.token = Token, .MC = MC}
            Dim jStr_Input As String = JsonConvert.SerializeObject(inputData)

            Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If dtable IsNot Nothing AndAlso dtable.Rows.Count > 0 Then
                Dim json As String = JsonConvert.SerializeObject(dtable)
                Return JsonConvert.DeserializeObject(Of List(Of VacantPositionApplication))(json)
            End If

        Catch ex As Exception
            MessageBox.Show("Failed to load Maintenance Jobs." & vbCrLf & vbCrLf &
                            "Error: " & ex.Message,
                            "Database Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
        Return New List(Of VacantPositionApplication)()
    End Function
#End Region
#Region "Job Action"
    Public Function GetJobActionMaintenance() As List(Of JobAction)
        Try
            ActiveFrm = "frmRecruitment.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "REC07"
            Dim inputData = New With {.token = Token, .MC = MC}
            Dim jStr_Input As String = JsonConvert.SerializeObject(inputData)

            Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If dtable IsNot Nothing AndAlso dtable.Rows.Count > 0 Then
                Dim json As String = JsonConvert.SerializeObject(dtable)
                Return JsonConvert.DeserializeObject(Of List(Of JobAction))(json)
            End If

        Catch ex As Exception
            MessageBox.Show("Failed to load Maintenance Jobs." & vbCrLf & vbCrLf &
                            "Error: " & ex.Message,
                            "Database Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
        Return New List(Of JobAction)()
    End Function
#End Region
#Region "Examination Applicant"
    Public Function GetApplicantExamination(ByVal jobcode As String) As List(Of ApplicantExamination)
        Try
            ActiveFrm = "frmApplicantExamination.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "EXAM01"
            Dim inputData = New With {.token = Token, .MC = MC, .jobcode = jobcode}
            Dim jStr_Input As String = JsonConvert.SerializeObject(inputData)

            Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If dtable IsNot Nothing AndAlso dtable.Rows.Count > 0 Then
                Dim json As String = JsonConvert.SerializeObject(dtable)
                Return JsonConvert.DeserializeObject(Of List(Of ApplicantExamination))(json)
            End If

        Catch ex As Exception
            MessageBox.Show("Failed to load Applicant Examination." & vbCrLf & vbCrLf &
                            "Error: " & ex.Message,
                            "Database Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
        Return New List(Of ApplicantExamination)()
    End Function
#End Region
#Region "Examination Main"
    Public Function GetExaminationMain() As List(Of ExaminationMain)
        Try
            ActiveFrm = "frmExaminationMain.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "MAIN01"
            Dim inputData = New With {.token = Token, .MC = MC}
            Dim jStr_Input As String = JsonConvert.SerializeObject(inputData)

            Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If dtable IsNot Nothing AndAlso dtable.Rows.Count > 0 Then
                Dim json As String = JsonConvert.SerializeObject(dtable)
                Return JsonConvert.DeserializeObject(Of List(Of ExaminationMain))(json)
            End If

        Catch ex As Exception
            MessageBox.Show("Failed to load Maintenance Jobs." & vbCrLf & vbCrLf &
                            "Error: " & ex.Message,
                            "Database Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
        Return New List(Of ExaminationMain)()
    End Function
#End Region
#Region "Examination Essay"
    Public Function GetExaminationEssay() As List(Of ExaminationEssay)
        Try
            ActiveFrm = "frmExaminationEssay.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "ESSAY01"
            Dim inputData = New With {.token = Token, .MC = MC}
            Dim jStr_Input As String = JsonConvert.SerializeObject(inputData)

            Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If dtable IsNot Nothing AndAlso dtable.Rows.Count > 0 Then
                Dim json As String = JsonConvert.SerializeObject(dtable)
                Return JsonConvert.DeserializeObject(Of List(Of ExaminationEssay))(json)
            End If

        Catch ex As Exception
            MessageBox.Show("Failed to load Examination Essay." & vbCrLf & vbCrLf &
                            "Error: " & ex.Message,
                            "Database Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
        Return New List(Of ExaminationEssay)()
    End Function
#End Region
#Region "Examination Input"
    Public Function GetExaminationInput() As List(Of ExaminationInput)
        Try
            ActiveFrm = "frmExaminationInput.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "INPUT01"
            Dim inputData = New With {.token = Token, .MC = MC}
            Dim jStr_Input As String = JsonConvert.SerializeObject(inputData)

            Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If dtable IsNot Nothing AndAlso dtable.Rows.Count > 0 Then
                Dim json As String = JsonConvert.SerializeObject(dtable)
                Return JsonConvert.DeserializeObject(Of List(Of ExaminationInput))(json)
            End If

        Catch ex As Exception
            MessageBox.Show("Failed to load Examination Essay." & vbCrLf & vbCrLf &
                            "Error: " & ex.Message,
                            "Database Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
        Return New List(Of ExaminationInput)()
    End Function
#End Region

    'rey task
#Region "Armotized Configuration"
    Public Function GetMultiLoanData() As List(Of MaintenanceMultiloan)
        Try
            ActiveFrm = "frmMultiLoan.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "MLOAN01"

            Dim inputData = New With {.token = Token, .MC = MC}
            Dim jStr_Input As String = JsonConvert.SerializeObject(inputData)

            Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If dtable IsNot Nothing AndAlso dtable.Rows.Count > 0 Then
                Dim json As String = JsonConvert.SerializeObject(dtable)
                Return JsonConvert.DeserializeObject(Of List(Of MaintenanceMultiloan))(json)
            End If

        Catch ex As Exception
            MessageBox.Show("Failed to load Multi-Loan Configuration." & vbCrLf & vbCrLf &
                            "Error: " & ex.Message,
                            "Database Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try

        Return New List(Of MaintenanceMultiloan)()
    End Function
#End Region

#Region "Earnings Configuration"
    Public Function GetEarningsConfigurationData() As List(Of EarningsConfiguration)
        Try
            ActiveFrm = "frmEarningsConfiguration.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "EARN01"

            Dim inputData = New With {.token = Token, .MC = MC}
            Dim jStr_Input As String = JsonConvert.SerializeObject(inputData)

            Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If dtable IsNot Nothing AndAlso dtable.Rows.Count > 0 Then
                Dim json As String = JsonConvert.SerializeObject(dtable)
                Return JsonConvert.DeserializeObject(Of List(Of EarningsConfiguration))(json)
            End If

        Catch ex As Exception
            MessageBox.Show("Failed to load Earnings Configuration." & vbCrLf & vbCrLf &
                            "Error: " & ex.Message,
                            "Database Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try

        Return New List(Of EarningsConfiguration)()
    End Function

#End Region
#Region "Examination Multiple Choices"
    Public Function GetExaminationMultipleChoice() As List(Of ExaminationMultipleChoice)
        Try
            ActiveFrm = "frmExaminationMultipleChoice.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "CH01"
            Dim inputData = New With {.token = Token, .MC = MC}
            Dim jStr_Input As String = JsonConvert.SerializeObject(inputData)

            Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If dtable IsNot Nothing AndAlso dtable.Rows.Count > 0 Then
                Dim json As String = JsonConvert.SerializeObject(dtable)
                Return JsonConvert.DeserializeObject(Of List(Of ExaminationMultipleChoice))(json)
            End If

        Catch ex As Exception
            MessageBox.Show("Failed to load Examination Essay." & vbCrLf & vbCrLf &
                            "Error: " & ex.Message,
                            "Database Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
        Return New List(Of ExaminationMultipleChoice)()
    End Function
#End Region
#Region "Examination Situation"
    Public Function GetExaminationSituation() As List(Of ExaminationSituation)
        Try
            ActiveFrm = "frmExaminationSituation.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "SIT01"
            Dim inputData = New With {.token = Token, .MC = MC}
            Dim jStr_Input As String = JsonConvert.SerializeObject(inputData)

            Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If dtable IsNot Nothing AndAlso dtable.Rows.Count > 0 Then
                Dim json As String = JsonConvert.SerializeObject(dtable)
                Return JsonConvert.DeserializeObject(Of List(Of ExaminationSituation))(json)
            End If

        Catch ex As Exception
            MessageBox.Show("Failed to load Examination Essay." & vbCrLf & vbCrLf &
                            "Error: " & ex.Message,
                            "Database Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
        Return New List(Of ExaminationSituation)()
    End Function
#End Region
#Region "Selection Line Up Applicant Examination"
    Public Function GetVacantPositionApplicationforSelection() As List(Of VacantPositionApplication)
        Try
            ActiveFrm = "frmSelectionLineupApplicant.php"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            MC = "SEL01"
            Dim inputData = New With {.token = Token, .MC = MC}
            Dim jStr_Input As String = JsonConvert.SerializeObject(inputData)

            Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If dtable IsNot Nothing AndAlso dtable.Rows.Count > 0 Then
                Dim json As String = JsonConvert.SerializeObject(dtable)
                Return JsonConvert.DeserializeObject(Of List(Of VacantPositionApplication))(json)
            End If

        Catch ex As Exception
            MessageBox.Show("Failed to load Maintenance Jobs." & vbCrLf & vbCrLf &
                            "Error: " & ex.Message,
                            "Database Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
        Return New List(Of VacantPositionApplication)()
    End Function
#End Region
End Module
