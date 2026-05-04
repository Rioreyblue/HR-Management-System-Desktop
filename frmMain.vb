
Public Class frmMain

    Dim isCollapsed As Boolean = True
    Dim isCollapsed2 As Boolean = True
    Dim isCollapsed3 As Boolean = True
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Call frmLogin.ShowDialog()
        Call Initialized_Dropdown()
    End Sub

    Private Sub Initialized_Dropdown()
        With NxNDropdownMenu1
            .MenuItemHeight = btnPayroll.Height - 6
            '.BackgroundColor = Color.FromArgb(80, 80, 80)
            .PrimaryColor = Color.FromArgb(36, 97, 152)
            '.MenuItemTextColor = Color.FromArgb(80, 80, 80)
            '.LeftColumnColor = Color.FromArgb(128, 128, 255)
            .ForeColor = Color.FromArgb(0, 0, 64)
            .Renderer = New ToolStripProfessionalRenderer()
        End With
        With NxNDropdownMenu2
            .MenuItemHeight = btnPayroll.Height - 6
            '.BackgroundColor = Color.FromArgb(80, 80, 80)
            .PrimaryColor = Color.FromArgb(36, 97, 152)
            '.MenuItemTextColor = Color.FromArgb(80, 80, 80)
            '.LeftColumnColor = Color.FromArgb(128, 128, 255)
            .ForeColor = Color.FromArgb(0, 0, 64)
            .Renderer = New ToolStripProfessionalRenderer()
        End With
        With NxNDropdownMenu3
            .MenuItemHeight = btnPayroll.Height - 6
            '.BackgroundColor = Color.FromArgb(80, 80, 80)
            .PrimaryColor = Color.FromArgb(36, 97, 152)
            '.MenuItemTextColor = Color.FromArgb(80, 80, 80)
            '.LeftColumnColor = Color.FromArgb(128, 128, 255)
            .ForeColor = Color.FromArgb(0, 0, 64)
            .Renderer = New ToolStripProfessionalRenderer()
        End With
        With NxNDropdownMenu4
            .MenuItemHeight = btnPayroll.Height - 6
            '.BackgroundColor = Color.FromArgb(80, 80, 80)
            .PrimaryColor = Color.FromArgb(36, 97, 152)
            '.MenuItemTextColor = Color.FromArgb(80, 80, 80)
            '.LeftColumnColor = Color.FromArgb(128, 128, 255)
            .ForeColor = Color.FromArgb(0, 0, 64)
            .Renderer = New ToolStripProfessionalRenderer()
        End With
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        With frmDashboard
            .WindowState = FormWindowState.Maximized
            .TopLevel = False
            pnlLoad.Controls.Add(frmDashboard)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub btnEmpMaintenance_Click(sender As Object, e As EventArgs) Handles btnEmpMaintenance.Click

    End Sub
    Private Sub btnEmpReports_Click(sender As Object, e As EventArgs) Handles btnEmpReports.Click
        'With frmEmploymentReports
        '    .WindowState = FormWindowState.Maximized
        '    .TopLevel = False
        '    pnlLoad.Controls.Add(frmEmploymentReports)
        '    .BringToFront()
        '    .Show()
        'End With
        With btnEmpReports
            .BackColor = Color.FromArgb(36, 97, 152)
            .ForeColor = Color.White
            .IconColor = Color.White
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            NxNDropdownMenu3.Show(btnEmpReports, btnEmpReports.Width - 0, 0)
        End With
    End Sub
    Private Sub btnTmkMaintenance_Click(sender As Object, e As EventArgs) Handles btnTmkMaintenance.Click

    End Sub
    Private Sub btnManageProfile_Click(sender As Object, e As EventArgs) Handles btnManageProfile.Click

    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MsgBox("Are you sure you want to Logout ?", vbQuestion + vbYesNo) = vbYes Then
            Application.Exit()
        End If
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If isCollapsed Then
            pnlHiring.Height += 10
            If pnlHiring.Size = pnlHiring.MaximumSize Then
                Timer1.Stop()
                isCollapsed = False
            End If
        Else
            pnlHiring.Height -= 10
            If pnlHiring.Size = pnlHiring.MinimumSize Then
                Timer1.Stop()
                isCollapsed = True
            End If
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If isCollapsed2 Then
            pnlEmployment.Height += 10
            If pnlEmployment.Size = pnlEmployment.MaximumSize Then
                Timer2.Stop()
                isCollapsed2 = False
            End If
        Else
            pnlEmployment.Height -= 10
            If pnlEmployment.Size = pnlEmployment.MinimumSize Then
                Timer2.Stop()
                isCollapsed2 = True
            End If
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If isCollapsed3 Then
            pnlPayroll.Height += 10
            If pnlPayroll.Size = pnlPayroll.MaximumSize Then
                Timer3.Stop()
                isCollapsed3 = False
            End If
        Else
            pnlPayroll.Height -= 10
            If pnlPayroll.Size = pnlPayroll.MinimumSize Then
                Timer3.Stop()
                isCollapsed3 = True
            End If
        End If
    End Sub

    Private Sub btnHiring_Click(sender As Object, e As EventArgs) Handles btnHiring.Click
        isCollapsed2 = False
        isCollapsed3 = False
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
    End Sub

    Private Sub btnEmployment_Click(sender As Object, e As EventArgs) Handles btnEmployment.Click
        isCollapsed = False
        isCollapsed3 = False
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
    End Sub
    Private Sub btnPayroll_Click(sender As Object, e As EventArgs) Handles btnPayroll.Click
        isCollapsed2 = False
        isCollapsed = False
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
    End Sub

    Private Sub btnPayrollReports_Click(sender As Object, e As EventArgs) Handles btnPayrollReports.Click
        With btnPayrollReports
            .BackColor = Color.FromArgb(36, 97, 152)
            .ForeColor = Color.White
            .IconColor = Color.White
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            NxNDropdownMenu4.Show(btnPayrollReports, btnPayrollReports.Width - 0, 0)
        End With
    End Sub
    Private Sub btnJobs_Click(sender As Object, e As EventArgs) Handles btnJobs.Click
        With frmHiringJob
            .WindowState = FormWindowState.Maximized
            .TopLevel = False
            pnlLoad.Controls.Add(frmHiringJob)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub btnApplicants_Click(sender As Object, e As EventArgs) Handles btnApplicants.Click
        With frmApplicantListing
            .WindowState = FormWindowState.Maximized
            .TopLevel = False
            pnlLoad.Controls.Add(frmApplicantListing)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub btnSelectionLineup_Click(sender As Object, e As EventArgs) Handles btnSelectionLineup.Click
        With frmSelectionLineup
            .WindowState = FormWindowState.Maximized
            .TopLevel = False
            pnlLoad.Controls.Add(frmSelectionLineup)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnExaminationMenu_Click(sender As Object, e As EventArgs) Handles btnExaminationMenu.Click
        With btnExaminationMenu
            .BackColor = Color.FromArgb(36, 97, 152)
            .ForeColor = Color.White
            .IconColor = Color.White
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            NxNDropdownMenu1.Show(btnExaminationMenu, btnExaminationMenu.Width - 0, 0)
        End With
    End Sub
    'Tool Strip
    Private Sub ApplicantExaminationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplicantExaminationToolStripMenuItem.Click
        With frmApplicantExamination
            .WindowState = FormWindowState.Maximized
            .TopLevel = False
            pnlLoad.Controls.Add(frmApplicantExamination)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub ExaminationMainConfigurationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExaminationMainConfigurationToolStripMenuItem.Click
        With frmExaminationMain
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub

    Private Sub EssayConfigurationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EssayConfigurationToolStripMenuItem.Click
        With frmExaminationEssay
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub

    Private Sub InputConfigurationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputConfigurationToolStripMenuItem.Click
        With frmExaminationInput
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub

    Private Sub MultipleChoiceConfigurationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MultipleChoiceConfigurationToolStripMenuItem.Click
        With frmExaminationMultipleChoice
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub

    Private Sub btnProcessPayroll_Click(sender As Object, e As EventArgs) Handles btnProcessPayroll.Click

    End Sub

    Private Sub btnPayrollMaintenance_Click(sender As Object, e As EventArgs) Handles btnPayrollMaintenance.Click
        With btnPayrollMaintenance
            .BackColor = Color.FromArgb(36, 97, 152)
            .ForeColor = Color.White
            .IconColor = Color.White
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            NxNDropdownMenu2.Show(btnPayrollMaintenance, btnPayrollMaintenance.Width - 0, 0)
        End With
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        With frmMaintenanceCutoff
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
            pnlLoad.Controls.Clear()
            pnlLoad.Controls.Add(frmMaintenanceCutoff)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BasicRateListingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BasicRateListingToolStripMenuItem.Click
        Using frm As New rptBasicRateListing
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub CertificationListingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CertificationListingToolStripMenuItem.Click
        Using frm As New rptCertificateListing
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub EmergencyContactToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmergencyContactToolStripMenuItem.Click
        Using frm As New rptEmergencyContact
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub JobStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JobStatusToolStripMenuItem.Click
        Using frm As New rptEmployeeJobStatus
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Using frm As New rptPayslip
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Using frm As New frmAmortizedConfiguration
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub btnEarningConfiguration_Click(sender As Object, e As EventArgs) Handles btnEarningConfiguration.Click
        Using frm As New frmEarningsConfiguration
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub btnDeductionConfiguration_Click(sender As Object, e As EventArgs) Handles btnDeductionConfiguration.Click
        Using frm As New frmDeductionConfigurations
            frm.ShowDialog()
        End Using
    End Sub
End Class
