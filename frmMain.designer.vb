<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.pnlSideBar = New System.Windows.Forms.Panel()
        Me.pnlPayroll = New System.Windows.Forms.Panel()
        Me.btnEarningConfiguration = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.btnPayrollMaintenance = New FontAwesome.Sharp.IconButton()
        Me.btnPayrollReports = New FontAwesome.Sharp.IconButton()
        Me.btnProcessPayroll = New FontAwesome.Sharp.IconButton()
        Me.btnPayroll = New FontAwesome.Sharp.IconButton()
        Me.pnlTimekeeping = New System.Windows.Forms.Panel()
        Me.btnTmkMaintenance = New FontAwesome.Sharp.IconButton()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.pnlEmployment = New System.Windows.Forms.Panel()
        Me.btnEmpReports = New FontAwesome.Sharp.IconButton()
        Me.btnEmpMaintenance = New FontAwesome.Sharp.IconButton()
        Me.btnManageProfile = New FontAwesome.Sharp.IconButton()
        Me.btnEmployment = New FontAwesome.Sharp.IconButton()
        Me.pnlHiring = New System.Windows.Forms.Panel()
        Me.btnExaminationMenu = New FontAwesome.Sharp.IconButton()
        Me.btnSelectionLineup = New FontAwesome.Sharp.IconButton()
        Me.btnApplicants = New FontAwesome.Sharp.IconButton()
        Me.btnJobs = New FontAwesome.Sharp.IconButton()
        Me.btnHiring = New FontAwesome.Sharp.IconButton()
        Me.IconButton5 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.btnDashboard = New FontAwesome.Sharp.IconButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picUser = New NxnControls.NxNCircularPictureBox()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnLogout = New FontAwesome.Sharp.IconButton()
        Me.btnBars = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlLoad = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.NxNDropdownMenu1 = New NxnControls.NxNDropdownMenu(Me.components)
        Me.ApplicantExaminationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExaminationMainConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EssayConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultipleChoiceConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExaminationSituationConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NxNDropdownMenu2 = New NxnControls.NxNDropdownMenu(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NxNDropdownMenu3 = New NxnControls.NxNDropdownMenu(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AwardsAndRecognitionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BasicRateListingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CertificationListingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmergencyContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JobStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JobCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtherEmployeeNumberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NxNDropdownMenu4 = New NxnControls.NxNDropdownMenu(Me.components)
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayrollRegisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDeductionConfiguration = New FontAwesome.Sharp.IconButton()
        Me.pnlSideBar.SuspendLayout()
        Me.pnlPayroll.SuspendLayout()
        Me.pnlTimekeeping.SuspendLayout()
        Me.pnlEmployment.SuspendLayout()
        Me.pnlHiring.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NxNDropdownMenu1.SuspendLayout()
        Me.NxNDropdownMenu2.SuspendLayout()
        Me.NxNDropdownMenu3.SuspendLayout()
        Me.NxNDropdownMenu4.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSideBar
        '
        Me.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.pnlSideBar.Controls.Add(Me.pnlPayroll)
        Me.pnlSideBar.Controls.Add(Me.pnlTimekeeping)
        Me.pnlSideBar.Controls.Add(Me.pnlEmployment)
        Me.pnlSideBar.Controls.Add(Me.pnlHiring)
        Me.pnlSideBar.Controls.Add(Me.IconButton5)
        Me.pnlSideBar.Controls.Add(Me.IconButton3)
        Me.pnlSideBar.Controls.Add(Me.btnDashboard)
        Me.pnlSideBar.Controls.Add(Me.Panel3)
        Me.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSideBar.Location = New System.Drawing.Point(0, 49)
        Me.pnlSideBar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlSideBar.Name = "pnlSideBar"
        Me.pnlSideBar.Size = New System.Drawing.Size(224, 560)
        Me.pnlSideBar.TabIndex = 1
        Me.pnlSideBar.Visible = False
        '
        'pnlPayroll
        '
        Me.pnlPayroll.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.pnlPayroll.Controls.Add(Me.btnDeductionConfiguration)
        Me.pnlPayroll.Controls.Add(Me.btnEarningConfiguration)
        Me.pnlPayroll.Controls.Add(Me.IconButton1)
        Me.pnlPayroll.Controls.Add(Me.btnPayrollMaintenance)
        Me.pnlPayroll.Controls.Add(Me.btnPayrollReports)
        Me.pnlPayroll.Controls.Add(Me.btnProcessPayroll)
        Me.pnlPayroll.Controls.Add(Me.btnPayroll)
        Me.pnlPayroll.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPayroll.Location = New System.Drawing.Point(0, 221)
        Me.pnlPayroll.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlPayroll.MaximumSize = New System.Drawing.Size(224, 235)
        Me.pnlPayroll.MinimumSize = New System.Drawing.Size(224, 32)
        Me.pnlPayroll.Name = "pnlPayroll"
        Me.pnlPayroll.Size = New System.Drawing.Size(224, 235)
        Me.pnlPayroll.TabIndex = 25
        '
        'btnEarningConfiguration
        '
        Me.btnEarningConfiguration.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEarningConfiguration.FlatAppearance.BorderSize = 0
        Me.btnEarningConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEarningConfiguration.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEarningConfiguration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEarningConfiguration.IconChar = FontAwesome.Sharp.IconChar.Gear
        Me.btnEarningConfiguration.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEarningConfiguration.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEarningConfiguration.IconSize = 24
        Me.btnEarningConfiguration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEarningConfiguration.Location = New System.Drawing.Point(0, 160)
        Me.btnEarningConfiguration.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEarningConfiguration.Name = "btnEarningConfiguration"
        Me.btnEarningConfiguration.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.btnEarningConfiguration.Size = New System.Drawing.Size(224, 32)
        Me.btnEarningConfiguration.TabIndex = 27
        Me.btnEarningConfiguration.Text = "Earning Configuration"
        Me.btnEarningConfiguration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEarningConfiguration.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Gear
        Me.IconButton1.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 24
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(0, 128)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.IconButton1.Size = New System.Drawing.Size(224, 32)
        Me.IconButton1.TabIndex = 26
        Me.IconButton1.Text = "sample"
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'btnPayrollMaintenance
        '
        Me.btnPayrollMaintenance.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPayrollMaintenance.FlatAppearance.BorderSize = 0
        Me.btnPayrollMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayrollMaintenance.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayrollMaintenance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPayrollMaintenance.IconChar = FontAwesome.Sharp.IconChar.Gear
        Me.btnPayrollMaintenance.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPayrollMaintenance.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPayrollMaintenance.IconSize = 24
        Me.btnPayrollMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayrollMaintenance.Location = New System.Drawing.Point(0, 96)
        Me.btnPayrollMaintenance.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPayrollMaintenance.Name = "btnPayrollMaintenance"
        Me.btnPayrollMaintenance.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.btnPayrollMaintenance.Size = New System.Drawing.Size(224, 32)
        Me.btnPayrollMaintenance.TabIndex = 25
        Me.btnPayrollMaintenance.Text = "   Maintenance"
        Me.btnPayrollMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPayrollMaintenance.UseVisualStyleBackColor = True
        '
        'btnPayrollReports
        '
        Me.btnPayrollReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPayrollReports.FlatAppearance.BorderSize = 0
        Me.btnPayrollReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayrollReports.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayrollReports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPayrollReports.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.btnPayrollReports.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPayrollReports.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPayrollReports.IconSize = 24
        Me.btnPayrollReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayrollReports.Location = New System.Drawing.Point(0, 64)
        Me.btnPayrollReports.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPayrollReports.Name = "btnPayrollReports"
        Me.btnPayrollReports.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.btnPayrollReports.Size = New System.Drawing.Size(224, 32)
        Me.btnPayrollReports.TabIndex = 24
        Me.btnPayrollReports.Text = "   Reports"
        Me.btnPayrollReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPayrollReports.UseVisualStyleBackColor = False
        '
        'btnProcessPayroll
        '
        Me.btnProcessPayroll.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProcessPayroll.FlatAppearance.BorderSize = 0
        Me.btnProcessPayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcessPayroll.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcessPayroll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnProcessPayroll.IconChar = FontAwesome.Sharp.IconChar.Calculator
        Me.btnProcessPayroll.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnProcessPayroll.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnProcessPayroll.IconSize = 24
        Me.btnProcessPayroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProcessPayroll.Location = New System.Drawing.Point(0, 32)
        Me.btnProcessPayroll.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnProcessPayroll.Name = "btnProcessPayroll"
        Me.btnProcessPayroll.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.btnProcessPayroll.Size = New System.Drawing.Size(224, 32)
        Me.btnProcessPayroll.TabIndex = 23
        Me.btnProcessPayroll.Text = "   Process Payroll"
        Me.btnProcessPayroll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProcessPayroll.UseVisualStyleBackColor = True
        '
        'btnPayroll
        '
        Me.btnPayroll.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnPayroll.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPayroll.FlatAppearance.BorderSize = 0
        Me.btnPayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayroll.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayroll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPayroll.IconChar = FontAwesome.Sharp.IconChar.UserCheck
        Me.btnPayroll.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPayroll.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPayroll.IconSize = 24
        Me.btnPayroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayroll.Location = New System.Drawing.Point(0, 0)
        Me.btnPayroll.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPayroll.Name = "btnPayroll"
        Me.btnPayroll.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.btnPayroll.Size = New System.Drawing.Size(224, 32)
        Me.btnPayroll.TabIndex = 22
        Me.btnPayroll.Text = "   Payroll"
        Me.btnPayroll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPayroll.UseVisualStyleBackColor = False
        '
        'pnlTimekeeping
        '
        Me.pnlTimekeeping.Controls.Add(Me.btnTmkMaintenance)
        Me.pnlTimekeeping.Controls.Add(Me.IconButton4)
        Me.pnlTimekeeping.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTimekeeping.Location = New System.Drawing.Point(0, 189)
        Me.pnlTimekeeping.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlTimekeeping.MaximumSize = New System.Drawing.Size(224, 65)
        Me.pnlTimekeeping.MinimumSize = New System.Drawing.Size(224, 32)
        Me.pnlTimekeeping.Name = "pnlTimekeeping"
        Me.pnlTimekeeping.Size = New System.Drawing.Size(224, 32)
        Me.pnlTimekeeping.TabIndex = 25
        '
        'btnTmkMaintenance
        '
        Me.btnTmkMaintenance.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTmkMaintenance.FlatAppearance.BorderSize = 0
        Me.btnTmkMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTmkMaintenance.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTmkMaintenance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnTmkMaintenance.IconChar = FontAwesome.Sharp.IconChar.Gear
        Me.btnTmkMaintenance.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnTmkMaintenance.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnTmkMaintenance.IconSize = 24
        Me.btnTmkMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTmkMaintenance.Location = New System.Drawing.Point(0, 32)
        Me.btnTmkMaintenance.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTmkMaintenance.Name = "btnTmkMaintenance"
        Me.btnTmkMaintenance.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.btnTmkMaintenance.Size = New System.Drawing.Size(224, 32)
        Me.btnTmkMaintenance.TabIndex = 19
        Me.btnTmkMaintenance.Text = "   Maintenance"
        Me.btnTmkMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTmkMaintenance.UseVisualStyleBackColor = True
        '
        'IconButton4
        '
        Me.IconButton4.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton4.FlatAppearance.BorderSize = 0
        Me.IconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton4.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.UserClock
        Me.IconButton4.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton4.IconSize = 24
        Me.IconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton4.Location = New System.Drawing.Point(0, 0)
        Me.IconButton4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.IconButton4.Size = New System.Drawing.Size(224, 32)
        Me.IconButton4.TabIndex = 18
        Me.IconButton4.Text = "   Timekeeping"
        Me.IconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton4.UseVisualStyleBackColor = False
        '
        'pnlEmployment
        '
        Me.pnlEmployment.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.pnlEmployment.Controls.Add(Me.btnEmpReports)
        Me.pnlEmployment.Controls.Add(Me.btnEmpMaintenance)
        Me.pnlEmployment.Controls.Add(Me.btnManageProfile)
        Me.pnlEmployment.Controls.Add(Me.btnEmployment)
        Me.pnlEmployment.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlEmployment.Location = New System.Drawing.Point(0, 157)
        Me.pnlEmployment.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlEmployment.MaximumSize = New System.Drawing.Size(224, 130)
        Me.pnlEmployment.MinimumSize = New System.Drawing.Size(224, 32)
        Me.pnlEmployment.Name = "pnlEmployment"
        Me.pnlEmployment.Size = New System.Drawing.Size(224, 32)
        Me.pnlEmployment.TabIndex = 26
        '
        'btnEmpReports
        '
        Me.btnEmpReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEmpReports.FlatAppearance.BorderSize = 0
        Me.btnEmpReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpReports.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpReports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEmpReports.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.btnEmpReports.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEmpReports.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEmpReports.IconSize = 24
        Me.btnEmpReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmpReports.Location = New System.Drawing.Point(0, 96)
        Me.btnEmpReports.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEmpReports.Name = "btnEmpReports"
        Me.btnEmpReports.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.btnEmpReports.Size = New System.Drawing.Size(224, 32)
        Me.btnEmpReports.TabIndex = 25
        Me.btnEmpReports.Text = "   Reports"
        Me.btnEmpReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEmpReports.UseVisualStyleBackColor = False
        '
        'btnEmpMaintenance
        '
        Me.btnEmpMaintenance.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEmpMaintenance.FlatAppearance.BorderSize = 0
        Me.btnEmpMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpMaintenance.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpMaintenance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEmpMaintenance.IconChar = FontAwesome.Sharp.IconChar.Gear
        Me.btnEmpMaintenance.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEmpMaintenance.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEmpMaintenance.IconSize = 24
        Me.btnEmpMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmpMaintenance.Location = New System.Drawing.Point(0, 64)
        Me.btnEmpMaintenance.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEmpMaintenance.Name = "btnEmpMaintenance"
        Me.btnEmpMaintenance.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.btnEmpMaintenance.Size = New System.Drawing.Size(224, 32)
        Me.btnEmpMaintenance.TabIndex = 17
        Me.btnEmpMaintenance.Text = "   Maintenance"
        Me.btnEmpMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEmpMaintenance.UseVisualStyleBackColor = True
        '
        'btnManageProfile
        '
        Me.btnManageProfile.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnManageProfile.FlatAppearance.BorderSize = 0
        Me.btnManageProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageProfile.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageProfile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnManageProfile.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.btnManageProfile.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnManageProfile.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnManageProfile.IconSize = 24
        Me.btnManageProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManageProfile.Location = New System.Drawing.Point(0, 32)
        Me.btnManageProfile.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnManageProfile.Name = "btnManageProfile"
        Me.btnManageProfile.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.btnManageProfile.Size = New System.Drawing.Size(224, 32)
        Me.btnManageProfile.TabIndex = 15
        Me.btnManageProfile.Text = "   Manage Profile"
        Me.btnManageProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnManageProfile.UseVisualStyleBackColor = True
        '
        'btnEmployment
        '
        Me.btnEmployment.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnEmployment.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEmployment.FlatAppearance.BorderSize = 0
        Me.btnEmployment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmployment.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEmployment.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.btnEmployment.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEmployment.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEmployment.IconSize = 24
        Me.btnEmployment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmployment.Location = New System.Drawing.Point(0, 0)
        Me.btnEmployment.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEmployment.Name = "btnEmployment"
        Me.btnEmployment.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.btnEmployment.Size = New System.Drawing.Size(224, 32)
        Me.btnEmployment.TabIndex = 14
        Me.btnEmployment.Text = "   Employment"
        Me.btnEmployment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEmployment.UseVisualStyleBackColor = False
        '
        'pnlHiring
        '
        Me.pnlHiring.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.pnlHiring.Controls.Add(Me.btnExaminationMenu)
        Me.pnlHiring.Controls.Add(Me.btnSelectionLineup)
        Me.pnlHiring.Controls.Add(Me.btnApplicants)
        Me.pnlHiring.Controls.Add(Me.btnJobs)
        Me.pnlHiring.Controls.Add(Me.btnHiring)
        Me.pnlHiring.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHiring.Location = New System.Drawing.Point(0, 125)
        Me.pnlHiring.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlHiring.MaximumSize = New System.Drawing.Size(224, 162)
        Me.pnlHiring.MinimumSize = New System.Drawing.Size(224, 32)
        Me.pnlHiring.Name = "pnlHiring"
        Me.pnlHiring.Size = New System.Drawing.Size(224, 32)
        Me.pnlHiring.TabIndex = 26
        '
        'btnExaminationMenu
        '
        Me.btnExaminationMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnExaminationMenu.FlatAppearance.BorderSize = 0
        Me.btnExaminationMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExaminationMenu.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExaminationMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnExaminationMenu.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnExaminationMenu.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnExaminationMenu.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnExaminationMenu.IconSize = 24
        Me.btnExaminationMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExaminationMenu.Location = New System.Drawing.Point(0, 128)
        Me.btnExaminationMenu.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnExaminationMenu.Name = "btnExaminationMenu"
        Me.btnExaminationMenu.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.btnExaminationMenu.Size = New System.Drawing.Size(224, 32)
        Me.btnExaminationMenu.TabIndex = 26
        Me.btnExaminationMenu.Text = "   Examination Configuration"
        Me.btnExaminationMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExaminationMenu.UseVisualStyleBackColor = True
        '
        'btnSelectionLineup
        '
        Me.btnSelectionLineup.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSelectionLineup.FlatAppearance.BorderSize = 0
        Me.btnSelectionLineup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectionLineup.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectionLineup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSelectionLineup.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnSelectionLineup.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSelectionLineup.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSelectionLineup.IconSize = 24
        Me.btnSelectionLineup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSelectionLineup.Location = New System.Drawing.Point(0, 96)
        Me.btnSelectionLineup.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSelectionLineup.Name = "btnSelectionLineup"
        Me.btnSelectionLineup.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.btnSelectionLineup.Size = New System.Drawing.Size(224, 32)
        Me.btnSelectionLineup.TabIndex = 25
        Me.btnSelectionLineup.Text = "   Selection Lineup"
        Me.btnSelectionLineup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSelectionLineup.UseVisualStyleBackColor = True
        '
        'btnApplicants
        '
        Me.btnApplicants.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnApplicants.FlatAppearance.BorderSize = 0
        Me.btnApplicants.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApplicants.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApplicants.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnApplicants.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnApplicants.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnApplicants.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnApplicants.IconSize = 24
        Me.btnApplicants.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnApplicants.Location = New System.Drawing.Point(0, 64)
        Me.btnApplicants.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnApplicants.Name = "btnApplicants"
        Me.btnApplicants.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.btnApplicants.Size = New System.Drawing.Size(224, 32)
        Me.btnApplicants.TabIndex = 24
        Me.btnApplicants.Text = "   Applicants"
        Me.btnApplicants.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnApplicants.UseVisualStyleBackColor = True
        '
        'btnJobs
        '
        Me.btnJobs.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnJobs.FlatAppearance.BorderSize = 0
        Me.btnJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJobs.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJobs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnJobs.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnJobs.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnJobs.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnJobs.IconSize = 24
        Me.btnJobs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnJobs.Location = New System.Drawing.Point(0, 32)
        Me.btnJobs.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnJobs.Name = "btnJobs"
        Me.btnJobs.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.btnJobs.Size = New System.Drawing.Size(224, 32)
        Me.btnJobs.TabIndex = 23
        Me.btnJobs.Text = "   Jobs"
        Me.btnJobs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnJobs.UseVisualStyleBackColor = True
        '
        'btnHiring
        '
        Me.btnHiring.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnHiring.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHiring.FlatAppearance.BorderSize = 0
        Me.btnHiring.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHiring.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHiring.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnHiring.IconChar = FontAwesome.Sharp.IconChar.Briefcase
        Me.btnHiring.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnHiring.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnHiring.IconSize = 24
        Me.btnHiring.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHiring.Location = New System.Drawing.Point(0, 0)
        Me.btnHiring.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnHiring.Name = "btnHiring"
        Me.btnHiring.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.btnHiring.Size = New System.Drawing.Size(224, 32)
        Me.btnHiring.TabIndex = 22
        Me.btnHiring.Text = "   Recruitment"
        Me.btnHiring.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHiring.UseVisualStyleBackColor = False
        '
        'IconButton5
        '
        Me.IconButton5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.IconButton5.FlatAppearance.BorderSize = 0
        Me.IconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton5.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.IconButton5.IconChar = FontAwesome.Sharp.IconChar.Bell
        Me.IconButton5.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.IconButton5.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton5.IconSize = 24
        Me.IconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton5.Location = New System.Drawing.Point(0, 496)
        Me.IconButton5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.IconButton5.Name = "IconButton5"
        Me.IconButton5.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.IconButton5.Size = New System.Drawing.Size(224, 32)
        Me.IconButton5.TabIndex = 21
        Me.IconButton5.Text = "   Notifications"
        Me.IconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton5.UseVisualStyleBackColor = True
        '
        'IconButton3
        '
        Me.IconButton3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.UserShield
        Me.IconButton3.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 24
        Me.IconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.Location = New System.Drawing.Point(0, 528)
        Me.IconButton3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.IconButton3.Size = New System.Drawing.Size(224, 32)
        Me.IconButton3.TabIndex = 20
        Me.IconButton3.Text = "   Administrator"
        Me.IconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton3.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartPie
        Me.btnDashboard.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDashboard.IconSize = 24
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 93)
        Me.btnDashboard.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(224, 32)
        Me.btnDashboard.TabIndex = 13
        Me.btnDashboard.Text = "   Dashboard"
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.lblId)
        Me.Panel3.Controls.Add(Me.lblName)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.picUser)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(224, 93)
        Me.Panel3.TabIndex = 2
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.ForeColor = System.Drawing.Color.White
        Me.lblId.Location = New System.Drawing.Point(76, 50)
        Me.lblId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(74, 18)
        Me.lblId.TabIndex = 2
        Me.lblId.Text = "090024"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(76, 32)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(170, 20)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Armando Bacang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(76, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome"
        '
        'picUser
        '
        Me.picUser.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.picUser.BorderColor = System.Drawing.Color.White
        Me.picUser.BorderColor2 = System.Drawing.Color.White
        Me.picUser.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.picUser.BorderSize = 0
        Me.picUser.GradientAngle = 50.0!
        Me.picUser.Image = Global.HRMAXV16.My.Resources.Resources.user_woman128px
        Me.picUser.Location = New System.Drawing.Point(9, 11)
        Me.picUser.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.picUser.Name = "picUser"
        Me.picUser.Size = New System.Drawing.Size(64, 64)
        Me.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUser.TabIndex = 2
        Me.picUser.TabStop = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.btnLogout)
        Me.pnlHeader.Controls.Add(Me.btnBars)
        Me.pnlHeader.Controls.Add(Me.PictureBox1)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1028, 49)
        Me.pnlHeader.TabIndex = 0
        Me.pnlHeader.Visible = False
        '
        'btnLogout
        '
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.btnLogout.IconColor = System.Drawing.Color.White
        Me.btnLogout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLogout.IconSize = 30
        Me.btnLogout.Location = New System.Drawing.Point(985, 0)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(43, 49)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnBars
        '
        Me.btnBars.FlatAppearance.BorderSize = 0
        Me.btnBars.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBars.Image = Global.HRMAXV16.My.Resources.Resources.menu_bars
        Me.btnBars.Location = New System.Drawing.Point(230, 15)
        Me.btnBars.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBars.Name = "btnBars"
        Me.btnBars.Size = New System.Drawing.Size(19, 20)
        Me.btnBars.TabIndex = 2
        Me.btnBars.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(225, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.HeaderText = "Modules"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'pnlLoad
        '
        Me.pnlLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.pnlLoad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLoad.Location = New System.Drawing.Point(224, 49)
        Me.pnlLoad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlLoad.Name = "pnlLoad"
        Me.pnlLoad.Size = New System.Drawing.Size(804, 560)
        Me.pnlLoad.TabIndex = 3
        Me.pnlLoad.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 15
        '
        'Timer2
        '
        Me.Timer2.Interval = 15
        '
        'Timer3
        '
        Me.Timer3.Interval = 15
        '
        'NxNDropdownMenu1
        '
        Me.NxNDropdownMenu1.BackgroundColor = System.Drawing.Color.Empty
        Me.NxNDropdownMenu1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.NxNDropdownMenu1.IsMainMenu = False
        Me.NxNDropdownMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplicantExaminationToolStripMenuItem, Me.ExaminationMainConfigurationToolStripMenuItem, Me.EssayConfigurationToolStripMenuItem, Me.InputConfigurationToolStripMenuItem, Me.MultipleChoiceConfigurationToolStripMenuItem, Me.ExaminationSituationConfigurationToolStripMenuItem})
        Me.NxNDropdownMenu1.LeftColumnColor = System.Drawing.Color.Empty
        Me.NxNDropdownMenu1.MenuItemHeight = 25
        Me.NxNDropdownMenu1.MenuItemTextColor = System.Drawing.Color.Empty
        Me.NxNDropdownMenu1.Name = "NxNDropdownMenu1"
        Me.NxNDropdownMenu1.PrimaryColor = System.Drawing.Color.Empty
        Me.NxNDropdownMenu1.Size = New System.Drawing.Size(319, 148)
        '
        'ApplicantExaminationToolStripMenuItem
        '
        Me.ApplicantExaminationToolStripMenuItem.Name = "ApplicantExaminationToolStripMenuItem"
        Me.ApplicantExaminationToolStripMenuItem.Size = New System.Drawing.Size(318, 24)
        Me.ApplicantExaminationToolStripMenuItem.Text = "Applicant Examination"
        '
        'ExaminationMainConfigurationToolStripMenuItem
        '
        Me.ExaminationMainConfigurationToolStripMenuItem.Name = "ExaminationMainConfigurationToolStripMenuItem"
        Me.ExaminationMainConfigurationToolStripMenuItem.Size = New System.Drawing.Size(318, 24)
        Me.ExaminationMainConfigurationToolStripMenuItem.Text = "Examination Main Configuration"
        '
        'EssayConfigurationToolStripMenuItem
        '
        Me.EssayConfigurationToolStripMenuItem.Name = "EssayConfigurationToolStripMenuItem"
        Me.EssayConfigurationToolStripMenuItem.Size = New System.Drawing.Size(318, 24)
        Me.EssayConfigurationToolStripMenuItem.Text = "Essay Configuration"
        '
        'InputConfigurationToolStripMenuItem
        '
        Me.InputConfigurationToolStripMenuItem.Name = "InputConfigurationToolStripMenuItem"
        Me.InputConfigurationToolStripMenuItem.Size = New System.Drawing.Size(318, 24)
        Me.InputConfigurationToolStripMenuItem.Text = "Input Configuration"
        '
        'MultipleChoiceConfigurationToolStripMenuItem
        '
        Me.MultipleChoiceConfigurationToolStripMenuItem.Name = "MultipleChoiceConfigurationToolStripMenuItem"
        Me.MultipleChoiceConfigurationToolStripMenuItem.Size = New System.Drawing.Size(318, 24)
        Me.MultipleChoiceConfigurationToolStripMenuItem.Text = "Multiple Choice Configuration"
        '
        'ExaminationSituationConfigurationToolStripMenuItem
        '
        Me.ExaminationSituationConfigurationToolStripMenuItem.Name = "ExaminationSituationConfigurationToolStripMenuItem"
        Me.ExaminationSituationConfigurationToolStripMenuItem.Size = New System.Drawing.Size(318, 24)
        Me.ExaminationSituationConfigurationToolStripMenuItem.Text = "Examination Situation Configuration"
        '
        'NxNDropdownMenu2
        '
        Me.NxNDropdownMenu2.BackgroundColor = System.Drawing.Color.Empty
        Me.NxNDropdownMenu2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.NxNDropdownMenu2.IsMainMenu = False
        Me.NxNDropdownMenu2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.NxNDropdownMenu2.LeftColumnColor = System.Drawing.Color.Empty
        Me.NxNDropdownMenu2.MenuItemHeight = 25
        Me.NxNDropdownMenu2.MenuItemTextColor = System.Drawing.Color.Empty
        Me.NxNDropdownMenu2.Name = "NxNDropdownMenu1"
        Me.NxNDropdownMenu2.PrimaryColor = System.Drawing.Color.Empty
        Me.NxNDropdownMenu2.Size = New System.Drawing.Size(168, 28)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(167, 24)
        Me.ToolStripMenuItem1.Text = "Payroll Cutoff"
        '
        'NxNDropdownMenu3
        '
        Me.NxNDropdownMenu3.BackgroundColor = System.Drawing.Color.Empty
        Me.NxNDropdownMenu3.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NxNDropdownMenu3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.NxNDropdownMenu3.IsMainMenu = False
        Me.NxNDropdownMenu3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.AwardsAndRecognitionsToolStripMenuItem, Me.BasicRateListingToolStripMenuItem, Me.CertificationListingToolStripMenuItem, Me.EmergencyContactToolStripMenuItem, Me.JobStatusToolStripMenuItem, Me.JobCategoryToolStripMenuItem, Me.OtherEmployeeNumberToolStripMenuItem})
        Me.NxNDropdownMenu3.LeftColumnColor = System.Drawing.Color.Empty
        Me.NxNDropdownMenu3.MenuItemHeight = 25
        Me.NxNDropdownMenu3.MenuItemTextColor = System.Drawing.Color.Empty
        Me.NxNDropdownMenu3.Name = "NxNDropdownMenu1"
        Me.NxNDropdownMenu3.PrimaryColor = System.Drawing.Color.Empty
        Me.NxNDropdownMenu3.Size = New System.Drawing.Size(240, 180)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(239, 22)
        Me.ToolStripMenuItem2.Text = "Custom Report"
        '
        'AwardsAndRecognitionsToolStripMenuItem
        '
        Me.AwardsAndRecognitionsToolStripMenuItem.Name = "AwardsAndRecognitionsToolStripMenuItem"
        Me.AwardsAndRecognitionsToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.AwardsAndRecognitionsToolStripMenuItem.Text = "Awards and Recognitions"
        '
        'BasicRateListingToolStripMenuItem
        '
        Me.BasicRateListingToolStripMenuItem.Name = "BasicRateListingToolStripMenuItem"
        Me.BasicRateListingToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.BasicRateListingToolStripMenuItem.Text = "Basic Rate Listing"
        '
        'CertificationListingToolStripMenuItem
        '
        Me.CertificationListingToolStripMenuItem.Name = "CertificationListingToolStripMenuItem"
        Me.CertificationListingToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.CertificationListingToolStripMenuItem.Text = "Certification Listing"
        '
        'EmergencyContactToolStripMenuItem
        '
        Me.EmergencyContactToolStripMenuItem.Name = "EmergencyContactToolStripMenuItem"
        Me.EmergencyContactToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.EmergencyContactToolStripMenuItem.Text = "Emergency Contact"
        '
        'JobStatusToolStripMenuItem
        '
        Me.JobStatusToolStripMenuItem.Name = "JobStatusToolStripMenuItem"
        Me.JobStatusToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.JobStatusToolStripMenuItem.Text = "Job Status Listing"
        '
        'JobCategoryToolStripMenuItem
        '
        Me.JobCategoryToolStripMenuItem.Name = "JobCategoryToolStripMenuItem"
        Me.JobCategoryToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.JobCategoryToolStripMenuItem.Text = "Job Category"
        '
        'OtherEmployeeNumberToolStripMenuItem
        '
        Me.OtherEmployeeNumberToolStripMenuItem.Name = "OtherEmployeeNumberToolStripMenuItem"
        Me.OtherEmployeeNumberToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.OtherEmployeeNumberToolStripMenuItem.Text = "Other Employee Number"
        '
        'NxNDropdownMenu4
        '
        Me.NxNDropdownMenu4.BackgroundColor = System.Drawing.Color.Empty
        Me.NxNDropdownMenu4.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NxNDropdownMenu4.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.NxNDropdownMenu4.IsMainMenu = False
        Me.NxNDropdownMenu4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.PayrollRegisterToolStripMenuItem})
        Me.NxNDropdownMenu4.LeftColumnColor = System.Drawing.Color.Empty
        Me.NxNDropdownMenu4.MenuItemHeight = 25
        Me.NxNDropdownMenu4.MenuItemTextColor = System.Drawing.Color.Empty
        Me.NxNDropdownMenu4.Name = "NxNDropdownMenu1"
        Me.NxNDropdownMenu4.PrimaryColor = System.Drawing.Color.Empty
        Me.NxNDropdownMenu4.Size = New System.Drawing.Size(189, 48)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(188, 22)
        Me.ToolStripMenuItem3.Text = "Payslip"
        '
        'PayrollRegisterToolStripMenuItem
        '
        Me.PayrollRegisterToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText
        Me.PayrollRegisterToolStripMenuItem.Name = "PayrollRegisterToolStripMenuItem"
        Me.PayrollRegisterToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.PayrollRegisterToolStripMenuItem.Text = "Payroll Register"
        '
        'btnDeductionConfiguration
        '
        Me.btnDeductionConfiguration.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDeductionConfiguration.FlatAppearance.BorderSize = 0
        Me.btnDeductionConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeductionConfiguration.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeductionConfiguration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnDeductionConfiguration.IconChar = FontAwesome.Sharp.IconChar.Gear
        Me.btnDeductionConfiguration.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnDeductionConfiguration.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDeductionConfiguration.IconSize = 24
        Me.btnDeductionConfiguration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeductionConfiguration.Location = New System.Drawing.Point(0, 192)
        Me.btnDeductionConfiguration.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeductionConfiguration.Name = "btnDeductionConfiguration"
        Me.btnDeductionConfiguration.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.btnDeductionConfiguration.Size = New System.Drawing.Size(224, 32)
        Me.btnDeductionConfiguration.TabIndex = 28
        Me.btnDeductionConfiguration.Text = "Deduction Configuration"
        Me.btnDeductionConfiguration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeductionConfiguration.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.pnlLoad)
        Me.Controls.Add(Me.pnlSideBar)
        Me.Controls.Add(Me.pnlHeader)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmMain"
        Me.Text = "HRMAXV24_V1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlSideBar.ResumeLayout(False)
        Me.pnlPayroll.ResumeLayout(False)
        Me.pnlTimekeeping.ResumeLayout(False)
        Me.pnlEmployment.ResumeLayout(False)
        Me.pnlHiring.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NxNDropdownMenu1.ResumeLayout(False)
        Me.NxNDropdownMenu2.ResumeLayout(False)
        Me.NxNDropdownMenu3.ResumeLayout(False)
        Me.NxNDropdownMenu4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlSideBar As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblId As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents picUser As NxnControls.NxNCircularPictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBars As Button
    Friend WithEvents btnLogout As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents pnlLoad As Panel
    Friend WithEvents btnEmployment As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents btnTmkMaintenance As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEmpMaintenance As FontAwesome.Sharp.IconButton
    Friend WithEvents btnManageProfile As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPayrollReports As FontAwesome.Sharp.IconButton
    Friend WithEvents btnProcessPayroll As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEmpReports As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPayroll As FontAwesome.Sharp.IconButton
    Friend WithEvents btnHiring As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlHiring As Panel
    Friend WithEvents btnApplicants As FontAwesome.Sharp.IconButton
    Friend WithEvents btnJobs As FontAwesome.Sharp.IconButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pnlEmployment As Panel
    Friend WithEvents Timer2 As Timer
    Friend WithEvents pnlTimekeeping As Panel
    Friend WithEvents pnlPayroll As Panel
    Friend WithEvents btnSelectionLineup As FontAwesome.Sharp.IconButton
    Friend WithEvents Timer3 As Timer
    Friend WithEvents btnPayrollMaintenance As FontAwesome.Sharp.IconButton
    Friend WithEvents btnExaminationMenu As FontAwesome.Sharp.IconButton
    Friend WithEvents NxNDropdownMenu1 As NxnControls.NxNDropdownMenu
    Friend WithEvents ApplicantExaminationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExaminationMainConfigurationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EssayConfigurationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InputConfigurationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MultipleChoiceConfigurationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExaminationSituationConfigurationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NxNDropdownMenu2 As NxnControls.NxNDropdownMenu
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NxNDropdownMenu3 As NxnControls.NxNDropdownMenu
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents AwardsAndRecognitionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BasicRateListingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CertificationListingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmergencyContactToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JobStatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JobCategoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OtherEmployeeNumberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NxNDropdownMenu4 As NxnControls.NxNDropdownMenu
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents PayrollRegisterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEarningConfiguration As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDeductionConfiguration As FontAwesome.Sharp.IconButton
End Class
