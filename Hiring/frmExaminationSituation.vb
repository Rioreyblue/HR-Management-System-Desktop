Imports NXNParsing

Public Class frmExaminationSituation
    Private jStr_Input As String = "[]"
    Private ws As New WSConnection
    Private Token As String = String.Empty
    Private ActiveFrm As String = "frmExaminationSituation.php"

    Dim formUpdate As Boolean = False
    Dim formCtr As String = String.Empty
    Private Sub frmExaminationSituation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                    'Call classComboBox.setCboJobMaintenance(cboJob)
                    Call LoadExaminationSituation(GetExaminationSituation)
                    'Call classComboBox.setCboExaminationSituation(cboSituation)

                    Call classTimer.CloseLoading(frmLoading)
                    Call classTimer.TimerReset()
            End Select
        End If
        classTimer.TimerCount += 1
    End Sub
    Public Sub LoadExaminationSituation(ByVal pList As List(Of ExaminationSituation))
        With lvExaminationEssay
            .Items.Clear()
            For Each item In pList
                Dim lv_ As ListViewItem = New ListViewItem(item.SitKeyCtr)
                lv_.SubItems.Add(item.Situation.ToProperCase)
                lv_.SubItems.Add(If(item.IsPic = True, "YES", "NO"))
                .Items.Add(lv_)
            Next
        End With
    End Sub
    'Private Sub Clear()
    '    cboJob.Text = ""
    '    txtQuestion.Text = ""
    '    txtPoints.Text = ""
    '    txtImage.Text = ""
    '    cboSituation.Text = ""
    'End Sub
    Public Sub Reload(ByVal pAction As Integer)
        If pAction = 0 OrElse pAction = 1 Then
            classTimer.EventType = 1
            Timer1.Enabled = True
        End If
    End Sub
End Class