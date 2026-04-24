Imports NXNParsing

Public Class frmMaintenanceCutoff
    Private jStr_Input As String = "[]"
    Private ws As New WSConnection
    Private Token As String = String.Empty
    Private ActiveFrm As String = "frmExaminationEssay.php"

    Dim formUpdate As Boolean = False
    Dim formCtr As String = String.Empty
    Private Sub frmMaintenanceCutoff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        classTimer.OpenLoading(frmLoading)
        classTimer.EventType = 1
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If classTimer.TimerCount = 1 Then
            Select Case classTimer.EventType
                Case 0
                    Timer1.Enabled = False
                    frmLoading.Close()
                    classTimer.TimerCount = 0
                Case 1

                    Call classTimer.TimerStop(Timer1)

                    'Call Clear()
                    Call classComboBox.setCboCompany(cboCompany)
                    Call classComboBox.setCboYear(cboYear)
                    If Trim(cboYear.Text) <> "" Then
                        Call LoadCutoffMaintenance(GetPayrollCutoffMaintenance(Trim(cboYear.Text), Trim(cboCompany.Text)))
                    End If

                    Call classTimer.CloseLoading(frmLoading)
                    Call classTimer.TimerReset()
            End Select
        End If
        classTimer.TimerCount += 1
    End Sub
    Public Sub Reload(ByVal pAction As Integer)
        If pAction = 0 OrElse pAction = 1 Then
            classTimer.EventType = 1
            Timer1.Enabled = True
        End If
    End Sub
    Public Sub LoadCutoffMaintenance(ByVal pList As List(Of PayrollCutoff))
        With lvCutoff
            .Items.Clear()
            For Each item In pList
                Dim lv_ As ListViewItem = New ListViewItem(item.Cutoff)
                lv_.SubItems.Add(Format(item.DateStart, "MMM dd,yyyy") & " to " & Format(item.DateEnd, "MMM dd,yyyy"))
                lv_.SubItems.Add(CDate(item.DateStart))
                lv_.SubItems.Add(CDate(item.DateEnd))
                If item.Hide = True Then
                    lv_.SubItems.Add("LOCKED")
                End If
                If item.TaxWithheld <> "" Then
                    If item.TaxWithheld = "1" Then
                        lv_.SubItems.Add("DAILY")
                    ElseIf item.TaxWithheld = "0" Then
                        lv_.SubItems.Add("")
                    ElseIf item.TaxWithheld = "2" Then
                        lv_.SubItems.Add("WEEKLY")
                    ElseIf item.TaxWithheld = "3" Then
                        lv_.SubItems.Add("SEMI-MONTHLY")
                    ElseIf item.TaxWithheld = "4" Then
                        lv_.SubItems.Add("MONTHLY")
                    ElseIf item.TaxWithheld = "5" Then
                        lv_.SubItems.Add("ANNUALY")
                    End If
                End If

                .Items.Add(lv_)
            Next
        End With
    End Sub
    Private Sub cboYear_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboYear.SelectionChangeCommitted
        If Trim(cboYear.Text) <> "" Then
            Call LoadCutoffMaintenance(GetPayrollCutoffMaintenance(Trim(cboYear.Text), Trim(cboCompany.Text)))

        End If

    End Sub

End Class