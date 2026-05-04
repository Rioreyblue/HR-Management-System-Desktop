Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports NXNParsing
'rey task
Public Class frmAmortizedConfiguration
    Private jStr_Input As String = "[]"
    Private ws As New WSConnection
    Private Token As String = String.Empty
    Private ActiveFrm As String = "frmAmortizedConfiguration.php"

    Dim formUpdate As Boolean = False
    Dim formCtr As String = String.Empty
    Dim counter As Integer = 0

    Private Sub frmAmortizedConfiguration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                    Call Clear()
                    Call loadlvArmotizedDeduction(GetAmortizedConfiguration())
                    Call classTimer.CloseLoading(frmLoading)
                    Call classTimer.TimerReset()
                    lblcounter.Text = counter.ToString()
            End Select
        End If
        classTimer.TimerCount += 1
    End Sub

    Private Sub Clear()
        txtMCode.Text = ""
        txtDescription.Text = ""
        txtTranType.Text = ""
        txtGLAccount.Text = ""
        chkBanking.Checked = False

        txtMCode.Enabled = True
        formUpdate = False
        formCtr = ""
        btnSave.Text = "Add"
    End Sub

    Public Sub Reload(ByVal pAction As Integer)
        If pAction = 0 OrElse pAction = 1 Then
            classTimer.EventType = 1
            Timer1.Enabled = True
        End If
    End Sub

    Public Sub loadlvArmotizedDeduction(ByVal pList As List(Of AmortizedConfiguration))
        With lvArmotizedDeduction
            .Items.Clear()
            For Each item In pList
                Dim lv_ As ListViewItem = New ListViewItem(item.LoanId)
                lv_.SubItems.Add(item.LoanDesc)
                lv_.SubItems.Add(item.LrType)
                lv_.SubItems.Add(item.GlAccountNo)
                lv_.SubItems.Add(item.Banking)

                .Items.Add(lv_)

            Next
            counter = pList.Count
        End With
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim input As New AmortizedConfiguration()

            input.LoanId = txtMCode.Text.Trim()
            input.LoanDesc = txtDescription.Text.Trim()
            input.LrType = txtTranType.Text.Trim()
            input.GlAccountNo = txtGLAccount.Text.Trim()

            If chkBanking.Checked Then
                input.Banking = "True"
            Else
                input.Banking = "False"
            End If

            input.Trail = ActiveUser


            If formUpdate = True Then
                input.IsUpdate = "True"
                input.LoanId = formCtr
            Else
                input.IsUpdate = "False"
            End If

            Dim validation = input.IsValid()
            If Not validation.Success Then
                MessageBox.Show(validation.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim jObj As JObject = JObject.FromObject(input)
            With jObj
                .Add("MC", "AMORT02")
                .Add("token", ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933"))
                .Add("user", ActiveUser)
            End With

            Dim jStr_Input As String = JsonConvert.SerializeObject(jObj)
            Dim res As String = ws.JsonStr2JsonStr(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If res = """done""" Then
                If input.IsUpdate = "False" Then
                    MsgBox("Armortized Setup Successfully Added !", vbInformation)
                Else
                    MsgBox("Armortized Setup Successfully Updated !", vbInformation)
                End If
                Call Reload(1)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub


    Private Sub lvMultiLoan_MouseClick(sender As Object, e As MouseEventArgs) Handles lvArmotizedDeduction.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim focusedItem = lvArmotizedDeduction.FocusedItem
            If focusedItem IsNot Nothing AndAlso focusedItem.Bounds.Contains(e.Location) Then
                ContextMenuStrip1.Show(Cursor.Position)
            End If
        End If
    End Sub

    Private Sub DeleteTool_Click(sender As Object, e As EventArgs) Handles DeleteTool.Click
        Dim var_del As String = lvArmotizedDeduction.FocusedItem.SubItems(0).Text
        Dim item As ListViewItem = lvArmotizedDeduction.SelectedItems(0)
        If MsgBox("Are you sure you want to Delete?", vbQuestion + vbYesNo) = vbYes Then
            DeleteMultiLoan(item.SubItems(0).Text)
        End If
    End Sub

    Private Sub UpdateTool_Click(sender As Object, e As EventArgs) Handles UpdateTool.Click
        If lvArmotizedDeduction.SelectedItems.Count > 0 Then
            Dim item As ListViewItem = lvArmotizedDeduction.SelectedItems(0)
            txtMCode.Text = item.SubItems(0).Text
            txtDescription.Text = item.SubItems(1).Text
            txtTranType.Text = item.SubItems(2).Text
            txtGLAccount.Text = item.SubItems(3).Text
            If item.SubItems(4).Text = "True" Then
                chkBanking.Checked = True
            Else
                chkBanking.Checked = False
            End If
            formUpdate = True
            formCtr = item.SubItems(0).Text
            txtMCode.Enabled = False
            btnSave.Text = "Update"
        End If
    End Sub


    Private Sub DeleteMultiLoan(var_del As String)
        Try
            Dim MC As String = "AMORT03"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "var_del" + """:""" + var_del + """," &
                         """" + "MC" + """:""" + MC + """}"

            Dim res As String = ws.JsonStr2JsonStr(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If res = """sysmaint""" Then
                MsgBox("Cannot delete system maintenance records.", vbExclamation)
            ElseIf res = """done""" Then
                MsgBox("Amortized Setup Successfully Deleted.", vbInformation)
                Call Reload(1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class