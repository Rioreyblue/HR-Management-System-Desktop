Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports NXNParsing

'rey task
Public Class frmDeductionConfigurations
    Private jStr_Input As String = "[]"
    Private ws As New WSConnection
    Private Token As String = String.Empty
    Private ActiveFrm As String = "frmDeductionConfiguration.php"

    Dim formUpdate As Boolean = False
    Dim formCtr As String = String.Empty

    Private Sub frmDeductionConfigurations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                    Call ClearDisplay()
                    Call DefaultNontaxble()
                    Call DeductionConfiguration(GetDeductionConfigurationData())
                    Call classTimer.CloseLoading(frmLoading)
                    Call groupBoxFormulatedFalse()
                    Call classTimer.TimerReset()
            End Select
        End If
        classTimer.TimerCount += 1
    End Sub

    Private Sub DefaultNontaxble()
        chkNonTaxable.Checked = True
        chkNonTaxable.Enabled = False
    End Sub

    Private Sub Clear()
        txtDdctCode.Text = ""
        txtDescription.Text = ""
        txtLrType.Text = ""
        txtGLAccount.Text = ""
        btnAdd.Text = "Add"
        chkNonTaxable.Checked = True
        chkPlottedDeduction.Checked = False
        chkDeduction.Checked = False
        chkFormulated.Checked = False
        chkBanking.Checked = False

        txtDdctCode.Enabled = True
        formUpdate = False
        formCtr = String.Empty
    End Sub

    Private Sub ClearDisplay()
        lblDisplay.Text = ""
    End Sub

    Public Sub Reload(ByVal pAction As Integer)
        If pAction = 0 OrElse pAction = 1 Then
            classTimer.EventType = 1
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()
    End Sub

    Private Sub btnClearDisplay_Click(sender As Object, e As EventArgs) Handles btnClearDisplay.Click
        lblDisplay.Text = ""
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnInternal.Click, btnOperator.Click, btnFixed.Click, btnBracket.Click
        Dim btn As Button = DirectCast(sender, Button)
        Dim selectedValue As String = String.Empty
        If btn.Name = "btnInternal" Then
            selectedValue = cboInternal.Text
        ElseIf btn.Name = "btnOperator" Then
            selectedValue = cboOperator.Text
        ElseIf btn.Name = "btnFixed" Then
            selectedValue = txtFixed.Text
        ElseIf btn.Name = "btnBracket" Then
            selectedValue = cboBracket.Text
        End If

        If Not String.IsNullOrWhiteSpace(selectedValue) Then
            lblDisplay.Text &= selectedValue & " "
        End If
    End Sub

    Private Sub groupBoxFormulatedFalse()
        btnBracket.Enabled = False
        cboBracket.Enabled = False
        btnInternal.Enabled = False
        cboInternal.Enabled = False
        btnOperator.Enabled = False
        cboOperator.Enabled = False
        btnFixed.Enabled = False
        txtFixed.Enabled = False
        btnClearDisplay.Enabled = False
    End Sub

    Private Sub groupBoxFormulatedTrue()
        btnBracket.Enabled = True
        cboBracket.Enabled = True
        btnInternal.Enabled = True
        cboInternal.Enabled = True
        btnOperator.Enabled = True
        cboOperator.Enabled = True
        btnFixed.Enabled = True
        txtFixed.Enabled = True
        btnClearDisplay.Enabled = True
    End Sub

    Private Sub ckhFormulated_CheckedChanged(sender As Object, e As EventArgs) Handles chkFormulated.CheckedChanged
        If Not chkFormulated.Checked Then
            groupBoxFormulatedFalse()
            ClearDisplay()
        Else
            groupBoxFormulatedTrue()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Public Sub DeductionConfiguration(ByVal pList As List(Of DeductionConfiguration))
        With lvDeductionConfig
            .Items.Clear()
            For Each item In pList
                Dim lv_ As ListViewItem = New ListViewItem(item.DdctCode)
                lv_.SubItems.Add(item.Description)

                If item.NonTaxable = True Then
                    lv_.SubItems.Add("NON-TAXABLE")
                Else
                    lv_.SubItems.Add("TAXABLE")
                End If

                If item.Formulated = True Then
                    lv_.SubItems.Add("*")
                Else
                    lv_.SubItems.Add("")
                End If

                lv_.SubItems.Add(item.Formula)

                If item.Banking = True Then
                    lv_.SubItems.Add("TRUE")
                Else
                    lv_.SubItems.Add("")
                End If

                lv_.SubItems.Add(item.GlAccountNo)

                If item.Plotted = True Then
                    lv_.SubItems.Add("Yes")
                Else
                    lv_.SubItems.Add("")
                End If

                lv_.SubItems.Add(item.LrType)

                If item.DeductToGrossAll = True Then
                    lv_.SubItems.Add("TRUE")
                Else
                    lv_.SubItems.Add("")
                End If

                .Items.Add(lv_)
            Next
        End With
    End Sub

    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim input As New DeductionConfiguration()
            input.DdctCode = txtDdctCode.Text.Trim()
            input.Description = txtDescription.Text.Trim()
            input.GlAccountNo = txtGLAccount.Text.Trim()
            input.LrType = txtLrType.Text.Trim()
            input.Formula = lblDisplay.Text.Trim()

            input.Trail = ActiveUser

            If chkNonTaxable.Checked Then
                input.NonTaxable = "True"
            Else
                input.NonTaxable = "False"
            End If

            If chkPlottedDeduction.Checked Then
                input.Plotted = "True"
            Else
                input.Plotted = "False"
            End If

            If chkDeduction.Checked Then
                input.DeductToGrossAll = "True"
            Else
                input.DeductToGrossAll = "False"
            End If

            If chkFormulated.Checked Then
                input.Formulated = "True"
            Else
                input.Formulated = "False"
            End If

            If chkBanking.Checked Then
                input.Banking = "True"
            Else
                input.Banking = "False"
            End If

            If formUpdate = True Then
                input.IsUpdate = "True"
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
                .Add("MC", "DEDUCT02")
                .Add("token", ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933"))
                .Add("user", ActiveUser)
                .Add("old_ddctcode", formCtr)
            End With

            Dim jStr_Input As String = JsonConvert.SerializeObject(jObj)
            Dim res As String = ws.JsonStr2JsonStr(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If res = """done""" Then
                If input.IsUpdate = "False" Then
                    MsgBox("Deduction Setup Successfully Added !", vbInformation)
                Else
                    MsgBox("Deduction Setup Successfully Updated !", vbInformation)
                End If
                Call Reload(1)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub UpdateTool_Click(sender As Object, e As EventArgs) Handles UpdateTool.Click
        If lvDeductionConfig.SelectedItems.Count > 0 Then
            Dim item As ListViewItem = lvDeductionConfig.SelectedItems(0)


            txtDdctCode.Text = item.SubItems(0).Text
            txtDescription.Text = item.SubItems(1).Text
            chkNonTaxable.Checked = (item.SubItems(2).Text = "NON-TAXABLE")
            chkFormulated.Checked = (item.SubItems(3).Text = "*")
            lblDisplay.Text = item.SubItems(4).Text
            chkBanking.Checked = (item.SubItems(5).Text = "TRUE")
            txtGLAccount.Text = item.SubItems(6).Text
            chkPlottedDeduction.Checked = (item.SubItems(7).Text = "Yes")
            txtLrType.Text = item.SubItems(8).Text
            chkDeduction.Checked = (item.SubItems(9).Text = "TRUE")

            formUpdate = True
            formCtr = item.SubItems(0).Text
            txtDdctCode.Enabled = False
            btnAdd.Text = "Update"
        End If
    End Sub

    Private Sub lvDeductionConfig_MouseClick(sender As Object, e As MouseEventArgs) Handles lvDeductionConfig.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim focusedItem = lvDeductionConfig.FocusedItem
            If focusedItem IsNot Nothing AndAlso focusedItem.Bounds.Contains(e.Location) Then
                ContextMenuStrip1.Show(Cursor.Position)
            End If
        End If
    End Sub

    Private Sub DeleteTool_Click(sender As Object, e As EventArgs) Handles DeleteTool.Click
        If lvDeductionConfig.SelectedItems.Count > 0 Then
            Dim item As ListViewItem = lvDeductionConfig.SelectedItems(0)
            If MsgBox("Are you sure you want to delete?", vbQuestion + vbYesNo) = vbYes Then
                DeleteDeductionConfig(item.SubItems(0).Text)
            End If
        End If
    End Sub

    Private Sub DeleteDeductionConfig(var_del As String)
        Try
            Dim MC As String = "DEDUCT03"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "var_del" + """:""" + var_del + """," &
                         """" + "boolean" + """:""" + "False" + """," &
                         """" + "MC" + """:""" + MC + """}"

            Dim res As String = ws.JsonStr2JsonStr(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If res = """sysmaint""" Then
                MsgBox("Cannot delete Deduction Setup records.", vbExclamation)
            ElseIf res = """done""" Then
                MsgBox("Deduction Setup Successfully Deleted.", vbInformation)
                Call Reload(1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class