Imports System.IO
Imports NXNParsing

Public Class rptBankTextFile
    Private jStr_Input As String = "[]"
    Private ws As New WSConnection
    Private Token As String = String.Empty
    Private ActiveFrm As String = "rptBankTextFile.php"
    Private Sub rptBankTextFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

                    classComboBox.setCboCompany(cboCompany)
                    classComboBox.setCboCutoff_wProcess(cboCutoff)
                    classEmployee.LoadCostCenter(getCostCenterMaintenance.Copy(), lvCostCenter)

                    Call classTimer.CloseLoading(frmLoading)
                    Call classTimer.TimerReset()
            End Select
        End If
        classTimer.TimerCount += 1
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim glaccount_ As String = ""
        Dim cnt_ As Integer = 1
        Dim sbtotal_ As Double = 0
        Dim filePath As String = Path.Combine(Application.StartupPath & "\Downloads\BankTextFile\ " & txtDescription.Text & ".txt")
        FileOpen(1, filePath, OpenMode.Output)

        'Dim lineIn As String = """" & txtJL_Account.Text & """," & """" & txtDescription.Text & """," & Format(CDate(dpBatch.Text), "yyyy-mm-dd") & "," & """" & txtContraAcc.Text & """"
        'Print(1, lineIn)

        Dim lineHeader As String = """" & txtJL_Account.Text & """," &
                           """" & txtDescription.Text & """," &
                           Format(CDate(dpBatch.Text), "yyyy-MM-dd") & "," &
                           """" & txtContraAcc.Text & """"
        PrintLine(1, lineHeader)

        ' Blank line
        PrintLine(1, "")


        For x As Integer = 0 To lvCostCenter.Items.Count - 1
            If lvCostCenter.Items(x).Checked = True Then

                Dim dtCostCenter() As DataRow = getCostCenterMaintenance().Select("costcode = '" & lvCostCenter.Items(x).Text & "' ")
                If dtCostCenter.Length > 0 Then
                    If IsDBNull(dtCostCenter(0).Item("dr_account")) = False Then glaccount_ = dtCostCenter(0).Item("dr_account")
                End If

                Dim dtPayroll_Net() As DataRow = getPayroll_Register(Trim(cboCutoff.Text)).Select("costcode = '" & lvCostCenter.Items(x).Text & "' ")
                If dtPayroll_Net.Length > 0 Then

                    For Each row As DataRow In dtPayroll_Net
                        If row("netpay") > 0 AndAlso row("acctno") Then

                            'Dim netpayFormatted As String = Replace(Format(CDbl(row("netpay")), "####.00"), ".", "")
                            'Dim lineOut As String = """" & """," & "F," & """" & row("acctno") & """" & "," & "F" & "," & "0" & "," & Replace(Format(row("netpay"), "####.00"), ".", "") & "," & """" & cboCutoff.Text & " NET" & """," & Format(CDate(dpBatch.Text), "yyyy-mm-dd") & "," & """" & "Ref" & cnt_ & """"
                            'Print(1, lineOut)

                            ' Second line
                            Dim detailLine As String = """" & """," &
                            "F," &
                            """" & row("acctno") & """," &
                            "F," &
                            "0," &
                            Replace(Format(CDbl(row("netpay")), "####.00"), ".", "") & "," &
                            """" & cboCutoff.Text & " NET" & """," &
                            Format(CDate(dpBatch.Text), "yyyy-MM-dd") & "," &
                            """Ref" & cnt_ & """"
                            PrintLine(1, detailLine)

                            cnt_ += 1
                            sbtotal_ += CDbl(row("netpay"))

                        End If
                    Next
                End If

                If Val(sbtotal_) > 0 Then
                    'Dim lineOut As String = """" & glaccount_ & """," & "F," & """" & """" & "," & "F" & "," & Replace(Format(sbtotal_, "####.00"), ".", "") & "," & "0" & "," & """" & cboCutoff.Text & " NPY" & """," & Format(CDate(dpBatch.Text), "yyyy-mm-dd") & "," & """" & "Ref" & cnt_ & """"
                    'Print(1, lineOut)

                    Dim lineOut As String = """" & glaccount_ & """," &
                        "F," &
                        """" & """," & _ ' this outputs an empty string inside quotes
                        "F," &
                        Replace(Format(sbtotal_, "####.00"), ".", "") & "," &
                        "0," &
                        """" & cboCutoff.Text & " NPY" & """," &
                        Format(CDate(dpBatch.Text), "yyyy-MM-dd") & "," &
                        """" & "Ref" & cnt_ & """"

                    PrintLine(1, lineOut)
                End If

                sbtotal_ = 0

            End If
        Next

        FileClose(1)

        If IO.File.Exists(filePath) Then
            Process.Start("notepad.exe", filePath)
        Else
            MessageBox.Show("File not found: " & filePath)
        End If
    End Sub

    Private Sub dp1_ValueChanged(sender As Object, e As EventArgs) Handles dp1.ValueChanged
        dpBatch.Text = dp1.Value.ToShortDateString()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class