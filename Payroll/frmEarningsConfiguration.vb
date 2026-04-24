Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports NXNParsing
'rey task
Public Class frmEarningsConfiguration
    Private jStr_Input As String = "[]"
    Private ws As New WSConnection
    Private Token As String = String.Empty
    Private ActiveFrm As String = "frmAmortizedConfiguration.php"

    Dim formUpdate As Boolean = False
    Dim formCtr As String = String.Empty

    Private Sub frmEarningsConfiguration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                    Call EarningsConfiguration(GetEarningsConfigurationData())
                    Call classTimer.CloseLoading(frmLoading)
                    Call groupBoxFormulatedFalse()
                    Call classTimer.TimerReset()
            End Select
        End If
        classTimer.TimerCount += 1
    End Sub
    Private Sub Clear()
        txtIncomeCode.Text = ""
        txtDescription.Text = ""
        txtCeilingAmount.Text = ""
        txtLrType.Text = ""
        chkNonTaxable.Checked = False
        chkDeductible.Checked = False
        chkMonthly.Checked = False
        chkIncludeBanking.Checked = False
        chkAutomaticCalculation.Checked = False
        chkAddOnMonthly.Checked = False
        chkAutomaticContraAccount.Checked = False
        ckhFormulated.Checked = False
        txtIncomeCode.Enabled = True
        formUpdate = False
        formCtr = ""
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

    Public Sub EarningsConfiguration(ByVal pList As List(Of EarningsConfiguration))
        With lvEarningConfig
            .Items.Clear()
            For Each item In pList
                Dim lv_ As ListViewItem = New ListViewItem(item.IncCode)
                lv_.SubItems.Add(item.Description)

                If (item.NonTaxable = "true") Then
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
                lv_.SubItems.Add(item.CeilingAmount)
                If item.Deductible = True Then
                    lv_.SubItems.Add("DEDUCTIBLE")
                Else
                    lv_.SubItems.Add("NON-DEDUCTIBLE")
                End If
                lv_.SubItems.Add(item.IncludeInAlphalisting.ToUpper)
                If item.PayrollType = "1" Then
                    lv_.SubItems.Add("NORMAL")
                Else
                    lv_.SubItems.Add("SPECIAL")
                End If
                lv_.SubItems.Add(item.AutomaticGross.ToUpper)
                lv_.SubItems.Add(item.InclBasedOn.ToUpper)
                lv_.SubItems.Add(item.AutomaticContraAcct.ToUpper)
                lv_.SubItems.Add(item.LrType)

                If item.CeilingConfig = "1" Then
                    lv_.SubItems.Add("ANNUAL")
                Else
                    lv_.SubItems.Add("MONTHLY")
                End If
                .Items.Add(lv_)
            Next
        End With
        'q
    End Sub

    Private Sub chkMonthly_CheckedChanged(sender As Object, e As EventArgs) Handles chkMonthly.CheckedChanged
        If (chkMonthly.Checked) Then
            lblCeilingAmount.Text = "Monthly Ceiling"
        Else
            lblCeilingAmount.Text = "Annual Ceiling"
        End If

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
    Private Sub txtAnnualCeiling_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCeilingAmount.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()
    End Sub

    Private Sub btnClearDisplay_Click(sender As Object, e As EventArgs) Handles btnClearDisplay.Click
        ClearDisplay()
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
    Private Sub ckhFormulated_CheckedChanged(sender As Object, e As EventArgs) Handles ckhFormulated.CheckedChanged
        If Not ckhFormulated.Checked Then
            groupBoxFormulatedFalse()
            ClearDisplay()
        Else
            groupBoxFormulatedTrue()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim input As New EarningsConfiguration()
            input.IncCode = txtIncomeCode.Text.Trim()
            input.Description = txtDescription.Text.Trim()
            input.CeilingAmount = txtCeilingAmount.Text.Trim()
            input.LrType = txtLrType.Text.Trim()
            input.Formula = lblDisplay.Text.Trim()
            If chkNonTaxable.Checked Then
                input.NonTaxable = "True"
            Else
                input.NonTaxable = "False"
            End If
            If chkDeductible.Checked Then
                input.Deductible = "True"
            Else
                input.Deductible = "False"
            End If
            If chkMonthly.Checked Then
                input.CeilingConfig = "1"
            Else
                input.CeilingConfig = "0"
            End If
            'bottons payroll type
            If rbtnNormalPayroll.Checked = True Then
                input.PayrollType = "1"
            Else
                input.PayrollType = "0"
            End If
            If rbtnSpecialPayroll.Checked = True Then
                input.PayrollType = "0"
            Else
                input.PayrollType = "1"
            End If
            'back to checkboxes
            If chkIncludeBanking.Checked Then
                input.IncludeInAlphalisting = "True"
            Else
                input.IncludeInAlphalisting = "False"
            End If
            If chkAutomaticCalculation.Checked Then
                input.AutomaticGross = "True"
            Else
                input.AutomaticGross = "False"
            End If
            If chkAutomaticContraAccount.Checked Then
                input.AutomaticContraAcct = "True"
            Else
                input.AutomaticContraAcct = "False"
            End If
            If ckhFormulated.Checked Then
                input.Formulated = "True"
            Else
                input.Formulated = "False"
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
                .Add("MC", "EARN02")
                .Add("token", ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933"))
                .Add("user", ActiveUser)
            End With

            Dim jStr_Input As String = JsonConvert.SerializeObject(jObj)
            Dim res As String = ws.JsonStr2JsonStr(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If res = """done""" Then
                If input.IsUpdate = "False" Then
                    MsgBox("Earnings Setup Successfully Added !", vbInformation)
                Else
                    MsgBox("Earnings Setup Successfully Updated !", vbInformation)
                End If
                Call Reload(1)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub UpdateTool_Click(sender As Object, e As EventArgs)
        If lvEarningConfig.SelectedItems.Count > 0 Then
            Dim item As ListViewItem = lvEarningConfig.SelectedItems(0)
            'txtIncomeCode.Text = item.SubItems(0).Text
            'txtDescription.Text = item.SubItems(1).Text
            'txtCeilingAmount.Text = item.SubItems(2).Text
            'txtLrType.Text = item.SubItems(3).Text
            'If item.SubItems(4).Text = "True" Then
            '    chkNonTaxable.Checked = True
            'Else
            '    chkNonTaxable.Checked = False
            'End If
            'If item.SubItems(5).Text = "True" Then
            '    chkDeductible.Checked = True
            'Else
            '    chkDeductible.Checked = False
            'End If
            'If item.SubItems(6).Text = "True" Then
            '    rbtnNormalPayroll.Checked = True
            'Else
            '    rbtnSpecialPayroll.Checked = False
            'End If
            'If item.SubItems(7).Text = "True" Then
            '    rbtnSpecialPayroll.Checked = True
            'Else
            '    rbtnNormalPayroll.Checked = False
            'End If
            txtIncomeCode.Text = item.SubItems(0).Text
            txtDescription.Text = item.SubItems(1).Text
            lblDisplay.Text = item.SubItems(4).Text
            txtCeilingAmount.Text = item.SubItems(5).Text
            txtLrType.Text = item.SubItems(12).Text

            chkNonTaxable.Checked = (item.SubItems(2).Text)
            ckhFormulated.Checked = (item.SubItems(3).Text)
            chkDeductible.Checked = (item.SubItems(6).Text)
            chkIncludeBanking.Checked = (item.SubItems(7).Text)

            If item.SubItems(8).Text = "NORMAL" Then
                rbtnNormalPayroll.Checked = True
                rbtnSpecialPayroll.Checked = False
            Else
                rbtnNormalPayroll.Checked = False
                rbtnSpecialPayroll.Checked = True
            End If

            chkAutomaticCalculation.Checked = (item.SubItems(9).Text)


            chkAutomaticContraAccount.Checked = (item.SubItems(11).Text)
            chkMonthly.Checked = (item.SubItems(13).Text)
            formUpdate = True
            formCtr = item.SubItems(0).Text
            txtIncomeCode.Enabled = False
        End If
    End Sub

    'Private Sub UpdateTool_Click(sender As Object, e As EventArgs)
    '    If lvEarningConfig.SelectedItems.Count > 0 Then
    '        Dim item As ListViewItem = lvEarningConfig.SelectedItems(0)

    '        txtIncomeCode.Text = item.SubItems(0).Text
    '        txtDescription.Text = item.SubItems(1).Text
    '        lblDisplay.Text = item.SubItems(4).Text
    '        txtCeilingAmount.Text = item.SubItems(5).Text
    '        txtLrType.Text = item.SubItems(12).Text

    '        chkNonTaxable.Checked = (item.SubItems(2).Text = "NON-TAXABLE")
    '        ckhFormulated.Checked = (item.SubItems(3).Text = "*")
    '        chkDeductible.Checked = (item.SubItems(6).Text = "DEDUCTIBLE")
    '        chkIncludeBanking.Checked = (item.SubItems(7).Text = "TRUE")

    '        If item.SubItems(8).Text = "NORMAL" Then
    '            rbtnNormalPayroll.Checked = True
    '            rbtnSpecialPayroll.Checked = False
    '        Else
    '            rbtnNormalPayroll.Checked = False
    '            rbtnSpecialPayroll.Checked = True
    '        End If

    '        chkAutomaticCalculation.Checked = (item.SubItems(9).Text = "TRUE")


    '        chkAutomaticContraAccount.Checked = (item.SubItems(11).Text = "TRUE")
    '        chkMonthly.Checked = (item.SubItems(13).Text = "MONTHLY")

    '        formUpdate = True
    '        formCtr = item.SubItems(0).Text
    '        txtIncomeCode.Enabled = False
    '    End If
    'End Sub

    Private Sub lvEarning_MouseClick(sender As Object, e As MouseEventArgs) Handles lvEarningConfig.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim focusedItem = lvEarningConfig.FocusedItem
            If focusedItem IsNot Nothing AndAlso focusedItem.Bounds.Contains(e.Location) Then
                ContextMenuStrip1.Show(Cursor.Position)
            End If
        End If
    End Sub

    Private Sub DeleteTool_Click(sender As Object, e As EventArgs)
        If lvEarningConfig.SelectedItems.Count > 0 Then
            Dim item As ListViewItem = lvEarningConfig.SelectedItems(0)
            If MsgBox("Are you sure you want to delete?", vbQuestion + vbYesNo) = vbYes Then
                DeleteEarningConfig(item.SubItems(0).Text)
            End If
        End If
    End Sub

    Private Sub DeleteEarningConfig(var_del As String)
        Try
            Dim MC As String = "EARN03"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            jStr_Input = "{" + """token" + """:""" + Token + """," &
                         """" + "var_del" + """:""" + var_del + """," &
                         """" + "MC" + """:""" + MC + """}"

            Dim res As String = ws.JsonStr2JsonStr(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")

            If res = """sysmaint""" Then
                MsgBox("Cannot delete system maintenance records.", vbExclamation)
            ElseIf res = """done""" Then
                MsgBox("Earnings Setup Successfully Deleted.", vbInformation)
                Call Reload(1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

End Class