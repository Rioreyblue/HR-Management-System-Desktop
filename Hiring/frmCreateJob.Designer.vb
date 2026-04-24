<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCreateJob
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
        Dim StringFormat1 As System.Drawing.StringFormat = New System.Drawing.StringFormat()
        Dim StringFormat2 As System.Drawing.StringFormat = New System.Drawing.StringFormat()
        Dim StringFormat3 As System.Drawing.StringFormat = New System.Drawing.StringFormat()
        Dim StringFormat4 As System.Drawing.StringFormat = New System.Drawing.StringFormat()
        Dim StringFormat5 As System.Drawing.StringFormat = New System.Drawing.StringFormat()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreateJob))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCreateJob = New FontAwesome.Sharp.IconButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.dtNeeded2 = New System.Windows.Forms.DateTimePicker()
        Me.dtNeeded1 = New System.Windows.Forms.DateTimePicker()
        Me.txtPlaceOfAssignment = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtSalary2 = New System.Windows.Forms.TextBox()
        Me.txtSalary1 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkVAWC = New System.Windows.Forms.CheckBox()
        Me.chkVacation = New System.Windows.Forms.CheckBox()
        Me.chkMaternity = New System.Windows.Forms.CheckBox()
        Me.chkMagnaCarta = New System.Windows.Forms.CheckBox()
        Me.chkLifeInsurance = New System.Windows.Forms.CheckBox()
        Me.chkHealthInsurance = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.chkSignInBonus = New System.Windows.Forms.CheckBox()
        Me.chkReimbursements = New System.Windows.Forms.CheckBox()
        Me.chkPerformance = New System.Windows.Forms.CheckBox()
        Me.chkMileage = New System.Windows.Forms.CheckBox()
        Me.chkLocPackage = New System.Windows.Forms.CheckBox()
        Me.chkDiminimis = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.chkSoloParent = New System.Windows.Forms.CheckBox()
        Me.chkSick = New System.Windows.Forms.CheckBox()
        Me.chkPaternity = New System.Windows.Forms.CheckBox()
        Me.chkEmergency = New System.Windows.Forms.CheckBox()
        Me.chkBday = New System.Windows.Forms.CheckBox()
        Me.chkBereavement = New System.Windows.Forms.CheckBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.chkSSS = New System.Windows.Forms.CheckBox()
        Me.chkPhealth = New System.Windows.Forms.CheckBox()
        Me.chkPagibig = New System.Windows.Forms.CheckBox()
        Me.chkOvertime = New System.Windows.Forms.CheckBox()
        Me.chkNightShift = New System.Windows.Forms.CheckBox()
        Me.chk13thMonth = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtJobExperiences = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtJobSummary = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtJobResponsibilities = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtJobQualifications = New System.Windows.Forms.TextBox()
        Me.txtHiresNeeded = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtJobTitle = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboJobGrade = New NxnControls.NxNComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbojobtype = New NxnControls.NxNComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboDepartment = New NxnControls.NxNComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboDivision = New NxnControls.NxNComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboCompany = New NxnControls.NxNComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnCreateJob)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.lblName)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(775, 66)
        Me.Panel2.TabIndex = 8
        '
        'btnCreateJob
        '
        Me.btnCreateJob.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreateJob.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnCreateJob.FlatAppearance.BorderSize = 0
        Me.btnCreateJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateJob.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateJob.ForeColor = System.Drawing.Color.White
        Me.btnCreateJob.IconChar = FontAwesome.Sharp.IconChar.Add
        Me.btnCreateJob.IconColor = System.Drawing.Color.White
        Me.btnCreateJob.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCreateJob.IconSize = 24
        Me.btnCreateJob.Location = New System.Drawing.Point(642, 30)
        Me.btnCreateJob.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCreateJob.Name = "btnCreateJob"
        Me.btnCreateJob.Size = New System.Drawing.Size(127, 30)
        Me.btnCreateJob.TabIndex = 507
        Me.btnCreateJob.Text = "Save Job"
        Me.btnCreateJob.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCreateJob.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label6.Location = New System.Drawing.Point(3, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(509, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fill in the details below to post a new opening and start building your team."
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(0, 12)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(130, 25)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Create Job"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.Label29)
        Me.Panel1.Controls.Add(Me.Label30)
        Me.Panel1.Controls.Add(Me.Label28)
        Me.Panel1.Controls.Add(Me.dtNeeded2)
        Me.Panel1.Controls.Add(Me.dtNeeded1)
        Me.Panel1.Controls.Add(Me.txtPlaceOfAssignment)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.txtSalary2)
        Me.Panel1.Controls.Add(Me.txtSalary1)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.chkActive)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.txtHiresNeeded)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.txtJobTitle)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.cboJobGrade)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.cbojobtype)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.cboDepartment)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cboDivision)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cboCompany)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(775, 787)
        Me.Panel1.TabIndex = 9
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label29.Location = New System.Drawing.Point(122, 158)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(12, 16)
        Me.Label29.TabIndex = 203
        Me.Label29.Text = ":"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label30.Location = New System.Drawing.Point(3, 158)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(100, 16)
        Me.Label30.TabIndex = 202
        Me.Label30.Text = "Date Needed"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label28.Location = New System.Drawing.Point(271, 158)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(14, 16)
        Me.Label28.TabIndex = 201
        Me.Label28.Text = "-"
        '
        'dtNeeded2
        '
        Me.dtNeeded2.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtNeeded2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtNeeded2.Location = New System.Drawing.Point(286, 153)
        Me.dtNeeded2.Name = "dtNeeded2"
        Me.dtNeeded2.Size = New System.Drawing.Size(125, 23)
        Me.dtNeeded2.TabIndex = 200
        '
        'dtNeeded1
        '
        Me.dtNeeded1.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtNeeded1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtNeeded1.Location = New System.Drawing.Point(140, 153)
        Me.dtNeeded1.Name = "dtNeeded1"
        Me.dtNeeded1.Size = New System.Drawing.Size(125, 23)
        Me.dtNeeded1.TabIndex = 199
        '
        'txtPlaceOfAssignment
        '
        Me.txtPlaceOfAssignment.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaceOfAssignment.Location = New System.Drawing.Point(181, 182)
        Me.txtPlaceOfAssignment.Name = "txtPlaceOfAssignment"
        Me.txtPlaceOfAssignment.Size = New System.Drawing.Size(566, 23)
        Me.txtPlaceOfAssignment.TabIndex = 198
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label26.Location = New System.Drawing.Point(163, 185)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(12, 16)
        Me.Label26.TabIndex = 197
        Me.Label26.Text = ":"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label27.Location = New System.Drawing.Point(3, 185)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(154, 16)
        Me.Label27.TabIndex = 196
        Me.Label27.Text = "Place of Assignment"
        '
        'txtSalary2
        '
        Me.txtSalary2.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalary2.Location = New System.Drawing.Point(634, 124)
        Me.txtSalary2.Name = "txtSalary2"
        Me.txtSalary2.Size = New System.Drawing.Size(113, 23)
        Me.txtSalary2.TabIndex = 195
        '
        'txtSalary1
        '
        Me.txtSalary1.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalary1.Location = New System.Drawing.Point(515, 124)
        Me.txtSalary1.Name = "txtSalary1"
        Me.txtSalary1.Size = New System.Drawing.Size(113, 23)
        Me.txtSalary1.TabIndex = 194
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label23.Location = New System.Drawing.Point(497, 127)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(12, 16)
        Me.Label23.TabIndex = 193
        Me.Label23.Text = ":"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label24.Location = New System.Drawing.Point(378, 127)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(102, 16)
        Me.Label24.TabIndex = 192
        Me.Label24.Text = "Salary Range"
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActive.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkActive.Location = New System.Drawing.Point(381, 7)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(71, 20)
        Me.chkActive.TabIndex = 191
        Me.chkActive.Text = "Active"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkVAWC)
        Me.GroupBox2.Controls.Add(Me.chkVacation)
        Me.GroupBox2.Controls.Add(Me.chkMaternity)
        Me.GroupBox2.Controls.Add(Me.chkMagnaCarta)
        Me.GroupBox2.Controls.Add(Me.chkLifeInsurance)
        Me.GroupBox2.Controls.Add(Me.chkHealthInsurance)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.chkSignInBonus)
        Me.GroupBox2.Controls.Add(Me.chkReimbursements)
        Me.GroupBox2.Controls.Add(Me.chkPerformance)
        Me.GroupBox2.Controls.Add(Me.chkMileage)
        Me.GroupBox2.Controls.Add(Me.chkLocPackage)
        Me.GroupBox2.Controls.Add(Me.chkDiminimis)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.chkSoloParent)
        Me.GroupBox2.Controls.Add(Me.chkSick)
        Me.GroupBox2.Controls.Add(Me.chkPaternity)
        Me.GroupBox2.Controls.Add(Me.chkEmergency)
        Me.GroupBox2.Controls.Add(Me.chkBday)
        Me.GroupBox2.Controls.Add(Me.chkBereavement)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.chkSSS)
        Me.GroupBox2.Controls.Add(Me.chkPhealth)
        Me.GroupBox2.Controls.Add(Me.chkPagibig)
        Me.GroupBox2.Controls.Add(Me.chkOvertime)
        Me.GroupBox2.Controls.Add(Me.chkNightShift)
        Me.GroupBox2.Controls.Add(Me.chk13thMonth)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox2.Location = New System.Drawing.Point(6, 688)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(742, 427)
        Me.GroupBox2.TabIndex = 190
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Benefits and Perks"
        '
        'chkVAWC
        '
        Me.chkVAWC.AutoSize = True
        Me.chkVAWC.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVAWC.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkVAWC.Location = New System.Drawing.Point(300, 246)
        Me.chkVAWC.Name = "chkVAWC"
        Me.chkVAWC.Size = New System.Drawing.Size(248, 20)
        Me.chkVAWC.TabIndex = 29
        Me.chkVAWC.Text = "Violation Against Women (VAWC)"
        Me.chkVAWC.UseVisualStyleBackColor = True
        '
        'chkVacation
        '
        Me.chkVacation.AutoSize = True
        Me.chkVacation.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVacation.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkVacation.Location = New System.Drawing.Point(300, 220)
        Me.chkVacation.Name = "chkVacation"
        Me.chkVacation.Size = New System.Drawing.Size(86, 20)
        Me.chkVacation.TabIndex = 28
        Me.chkVacation.Text = "Vacation"
        Me.chkVacation.UseVisualStyleBackColor = True
        '
        'chkMaternity
        '
        Me.chkMaternity.AutoSize = True
        Me.chkMaternity.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMaternity.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkMaternity.Location = New System.Drawing.Point(9, 246)
        Me.chkMaternity.Name = "chkMaternity"
        Me.chkMaternity.Size = New System.Drawing.Size(92, 20)
        Me.chkMaternity.TabIndex = 27
        Me.chkMaternity.Text = "Maternity"
        Me.chkMaternity.UseVisualStyleBackColor = True
        '
        'chkMagnaCarta
        '
        Me.chkMagnaCarta.AutoSize = True
        Me.chkMagnaCarta.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMagnaCarta.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkMagnaCarta.Location = New System.Drawing.Point(9, 220)
        Me.chkMagnaCarta.Name = "chkMagnaCarta"
        Me.chkMagnaCarta.Size = New System.Drawing.Size(188, 20)
        Me.chkMagnaCarta.TabIndex = 26
        Me.chkMagnaCarta.Text = "Magna Carta for Women"
        Me.chkMagnaCarta.UseVisualStyleBackColor = True
        '
        'chkLifeInsurance
        '
        Me.chkLifeInsurance.AutoSize = True
        Me.chkLifeInsurance.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLifeInsurance.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkLifeInsurance.Location = New System.Drawing.Point(300, 401)
        Me.chkLifeInsurance.Name = "chkLifeInsurance"
        Me.chkLifeInsurance.Size = New System.Drawing.Size(122, 20)
        Me.chkLifeInsurance.TabIndex = 25
        Me.chkLifeInsurance.Text = "Life Insurance"
        Me.chkLifeInsurance.UseVisualStyleBackColor = True
        '
        'chkHealthInsurance
        '
        Me.chkHealthInsurance.AutoSize = True
        Me.chkHealthInsurance.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHealthInsurance.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkHealthInsurance.Location = New System.Drawing.Point(9, 401)
        Me.chkHealthInsurance.Name = "chkHealthInsurance"
        Me.chkHealthInsurance.Size = New System.Drawing.Size(141, 20)
        Me.chkHealthInsurance.TabIndex = 22
        Me.chkHealthInsurance.Text = "Health Insurance"
        Me.chkHealthInsurance.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label19.Location = New System.Drawing.Point(6, 382)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 16)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "Insurance"
        '
        'chkSignInBonus
        '
        Me.chkSignInBonus.AutoSize = True
        Me.chkSignInBonus.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSignInBonus.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkSignInBonus.Location = New System.Drawing.Point(300, 349)
        Me.chkSignInBonus.Name = "chkSignInBonus"
        Me.chkSignInBonus.Size = New System.Drawing.Size(119, 20)
        Me.chkSignInBonus.TabIndex = 20
        Me.chkSignInBonus.Text = "Sign In Bonus"
        Me.chkSignInBonus.UseVisualStyleBackColor = True
        '
        'chkReimbursements
        '
        Me.chkReimbursements.AutoSize = True
        Me.chkReimbursements.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReimbursements.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkReimbursements.Location = New System.Drawing.Point(300, 323)
        Me.chkReimbursements.Name = "chkReimbursements"
        Me.chkReimbursements.Size = New System.Drawing.Size(224, 20)
        Me.chkReimbursements.TabIndex = 19
        Me.chkReimbursements.Text = "Reimbursements for Expenses"
        Me.chkReimbursements.UseVisualStyleBackColor = True
        '
        'chkPerformance
        '
        Me.chkPerformance.AutoSize = True
        Me.chkPerformance.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPerformance.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkPerformance.Location = New System.Drawing.Point(300, 297)
        Me.chkPerformance.Name = "chkPerformance"
        Me.chkPerformance.Size = New System.Drawing.Size(155, 20)
        Me.chkPerformance.TabIndex = 18
        Me.chkPerformance.Text = "Performance Bonus"
        Me.chkPerformance.UseVisualStyleBackColor = True
        '
        'chkMileage
        '
        Me.chkMileage.AutoSize = True
        Me.chkMileage.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMileage.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkMileage.Location = New System.Drawing.Point(9, 349)
        Me.chkMileage.Name = "chkMileage"
        Me.chkMileage.Size = New System.Drawing.Size(189, 20)
        Me.chkMileage.TabIndex = 17
        Me.chkMileage.Text = "Mileage Reimbursements"
        Me.chkMileage.UseVisualStyleBackColor = True
        '
        'chkLocPackage
        '
        Me.chkLocPackage.AutoSize = True
        Me.chkLocPackage.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLocPackage.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkLocPackage.Location = New System.Drawing.Point(9, 323)
        Me.chkLocPackage.Name = "chkLocPackage"
        Me.chkLocPackage.Size = New System.Drawing.Size(145, 20)
        Me.chkLocPackage.TabIndex = 16
        Me.chkLocPackage.Text = "Location Package"
        Me.chkLocPackage.UseVisualStyleBackColor = True
        '
        'chkDiminimis
        '
        Me.chkDiminimis.AutoSize = True
        Me.chkDiminimis.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDiminimis.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkDiminimis.Location = New System.Drawing.Point(9, 297)
        Me.chkDiminimis.Name = "chkDiminimis"
        Me.chkDiminimis.Size = New System.Drawing.Size(97, 20)
        Me.chkDiminimis.TabIndex = 15
        Me.chkDiminimis.Text = "De Minimis"
        Me.chkDiminimis.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label18.Location = New System.Drawing.Point(6, 278)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(111, 16)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "Additional Pay"
        '
        'chkSoloParent
        '
        Me.chkSoloParent.AutoSize = True
        Me.chkSoloParent.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSoloParent.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkSoloParent.Location = New System.Drawing.Point(300, 194)
        Me.chkSoloParent.Name = "chkSoloParent"
        Me.chkSoloParent.Size = New System.Drawing.Size(105, 20)
        Me.chkSoloParent.TabIndex = 13
        Me.chkSoloParent.Text = "Solo Parent"
        Me.chkSoloParent.UseVisualStyleBackColor = True
        '
        'chkSick
        '
        Me.chkSick.AutoSize = True
        Me.chkSick.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSick.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkSick.Location = New System.Drawing.Point(300, 168)
        Me.chkSick.Name = "chkSick"
        Me.chkSick.Size = New System.Drawing.Size(56, 20)
        Me.chkSick.TabIndex = 12
        Me.chkSick.Text = "Sick"
        Me.chkSick.UseVisualStyleBackColor = True
        '
        'chkPaternity
        '
        Me.chkPaternity.AutoSize = True
        Me.chkPaternity.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPaternity.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkPaternity.Location = New System.Drawing.Point(300, 142)
        Me.chkPaternity.Name = "chkPaternity"
        Me.chkPaternity.Size = New System.Drawing.Size(89, 20)
        Me.chkPaternity.TabIndex = 11
        Me.chkPaternity.Text = "Paternity"
        Me.chkPaternity.UseVisualStyleBackColor = True
        '
        'chkEmergency
        '
        Me.chkEmergency.AutoSize = True
        Me.chkEmergency.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEmergency.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkEmergency.Location = New System.Drawing.Point(9, 194)
        Me.chkEmergency.Name = "chkEmergency"
        Me.chkEmergency.Size = New System.Drawing.Size(101, 20)
        Me.chkEmergency.TabIndex = 10
        Me.chkEmergency.Text = "Emergency"
        Me.chkEmergency.UseVisualStyleBackColor = True
        '
        'chkBday
        '
        Me.chkBday.AutoSize = True
        Me.chkBday.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBday.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkBday.Location = New System.Drawing.Point(9, 168)
        Me.chkBday.Name = "chkBday"
        Me.chkBday.Size = New System.Drawing.Size(83, 20)
        Me.chkBday.TabIndex = 9
        Me.chkBday.Text = "Birthday"
        Me.chkBday.UseVisualStyleBackColor = True
        '
        'chkBereavement
        '
        Me.chkBereavement.AutoSize = True
        Me.chkBereavement.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBereavement.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkBereavement.Location = New System.Drawing.Point(9, 142)
        Me.chkBereavement.Name = "chkBereavement"
        Me.chkBereavement.Size = New System.Drawing.Size(115, 20)
        Me.chkBereavement.TabIndex = 8
        Me.chkBereavement.Text = "Bereavement"
        Me.chkBereavement.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label17.Location = New System.Drawing.Point(6, 123)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 16)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Leave's"
        '
        'chkSSS
        '
        Me.chkSSS.AutoSize = True
        Me.chkSSS.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSSS.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkSSS.Location = New System.Drawing.Point(300, 90)
        Me.chkSSS.Name = "chkSSS"
        Me.chkSSS.Size = New System.Drawing.Size(182, 20)
        Me.chkSSS.TabIndex = 6
        Me.chkSSS.Text = "Social Security System"
        Me.chkSSS.UseVisualStyleBackColor = True
        '
        'chkPhealth
        '
        Me.chkPhealth.AutoSize = True
        Me.chkPhealth.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPhealth.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkPhealth.Location = New System.Drawing.Point(300, 64)
        Me.chkPhealth.Name = "chkPhealth"
        Me.chkPhealth.Size = New System.Drawing.Size(100, 20)
        Me.chkPhealth.TabIndex = 5
        Me.chkPhealth.Text = "Phil-Health"
        Me.chkPhealth.UseVisualStyleBackColor = True
        '
        'chkPagibig
        '
        Me.chkPagibig.AutoSize = True
        Me.chkPagibig.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPagibig.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkPagibig.Location = New System.Drawing.Point(300, 38)
        Me.chkPagibig.Name = "chkPagibig"
        Me.chkPagibig.Size = New System.Drawing.Size(84, 20)
        Me.chkPagibig.TabIndex = 4
        Me.chkPagibig.Text = "Pag-Ibig"
        Me.chkPagibig.UseVisualStyleBackColor = True
        '
        'chkOvertime
        '
        Me.chkOvertime.AutoSize = True
        Me.chkOvertime.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOvertime.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkOvertime.Location = New System.Drawing.Point(9, 90)
        Me.chkOvertime.Name = "chkOvertime"
        Me.chkOvertime.Size = New System.Drawing.Size(117, 20)
        Me.chkOvertime.TabIndex = 3
        Me.chkOvertime.Text = "Overtime Pay"
        Me.chkOvertime.UseVisualStyleBackColor = True
        '
        'chkNightShift
        '
        Me.chkNightShift.AutoSize = True
        Me.chkNightShift.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNightShift.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkNightShift.Location = New System.Drawing.Point(9, 64)
        Me.chkNightShift.Name = "chkNightShift"
        Me.chkNightShift.Size = New System.Drawing.Size(175, 20)
        Me.chkNightShift.TabIndex = 2
        Me.chkNightShift.Text = "Night Shift Differential"
        Me.chkNightShift.UseVisualStyleBackColor = True
        '
        'chk13thMonth
        '
        Me.chk13thMonth.AutoSize = True
        Me.chk13thMonth.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk13thMonth.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chk13thMonth.Location = New System.Drawing.Point(9, 38)
        Me.chk13thMonth.Name = "chk13thMonth"
        Me.chk13thMonth.Size = New System.Drawing.Size(134, 20)
        Me.chk13thMonth.TabIndex = 1
        Me.chk13thMonth.Text = "13th Month Pay"
        Me.chk13thMonth.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label12.Location = New System.Drawing.Point(6, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(237, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Government Mandated Benefits"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.txtJobExperiences)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.txtJobSummary)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtJobResponsibilities)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.txtJobQualifications)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox1.Location = New System.Drawing.Point(6, 211)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(742, 471)
        Me.GroupBox1.TabIndex = 189
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Job Description"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label25.Location = New System.Drawing.Point(4, 355)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(96, 16)
        Me.Label25.TabIndex = 167
        Me.Label25.Text = "Experiences"
        '
        'txtJobExperiences
        '
        Me.txtJobExperiences.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJobExperiences.Location = New System.Drawing.Point(6, 374)
        Me.txtJobExperiences.Multiline = True
        Me.txtJobExperiences.Name = "txtJobExperiences"
        Me.txtJobExperiences.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtJobExperiences.Size = New System.Drawing.Size(729, 90)
        Me.txtJobExperiences.TabIndex = 166
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label22.Location = New System.Drawing.Point(5, 19)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(106, 16)
        Me.Label22.TabIndex = 161
        Me.Label22.Text = "Job Summary"
        '
        'txtJobSummary
        '
        Me.txtJobSummary.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJobSummary.Location = New System.Drawing.Point(7, 38)
        Me.txtJobSummary.Multiline = True
        Me.txtJobSummary.Name = "txtJobSummary"
        Me.txtJobSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtJobSummary.Size = New System.Drawing.Size(729, 90)
        Me.txtJobSummary.TabIndex = 160
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label20.Location = New System.Drawing.Point(5, 131)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(120, 16)
        Me.Label20.TabIndex = 163
        Me.Label20.Text = "Responsibilities"
        '
        'txtJobResponsibilities
        '
        Me.txtJobResponsibilities.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJobResponsibilities.Location = New System.Drawing.Point(7, 150)
        Me.txtJobResponsibilities.Multiline = True
        Me.txtJobResponsibilities.Name = "txtJobResponsibilities"
        Me.txtJobResponsibilities.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtJobResponsibilities.Size = New System.Drawing.Size(729, 90)
        Me.txtJobResponsibilities.TabIndex = 162
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label21.Location = New System.Drawing.Point(5, 243)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(106, 16)
        Me.Label21.TabIndex = 165
        Me.Label21.Text = "Qualifications"
        '
        'txtJobQualifications
        '
        Me.txtJobQualifications.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJobQualifications.Location = New System.Drawing.Point(7, 262)
        Me.txtJobQualifications.Multiline = True
        Me.txtJobQualifications.Name = "txtJobQualifications"
        Me.txtJobQualifications.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtJobQualifications.Size = New System.Drawing.Size(729, 90)
        Me.txtJobQualifications.TabIndex = 164
        '
        'txtHiresNeeded
        '
        Me.txtHiresNeeded.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHiresNeeded.Location = New System.Drawing.Point(140, 124)
        Me.txtHiresNeeded.Name = "txtHiresNeeded"
        Me.txtHiresNeeded.Size = New System.Drawing.Size(232, 23)
        Me.txtHiresNeeded.TabIndex = 188
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label15.Location = New System.Drawing.Point(122, 127)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(12, 16)
        Me.Label15.TabIndex = 187
        Me.Label15.Text = ":"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label16.Location = New System.Drawing.Point(3, 127)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(108, 16)
        Me.Label16.TabIndex = 186
        Me.Label16.Text = "Hire's Needed"
        '
        'txtJobTitle
        '
        Me.txtJobTitle.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJobTitle.Location = New System.Drawing.Point(140, 95)
        Me.txtJobTitle.Name = "txtJobTitle"
        Me.txtJobTitle.Size = New System.Drawing.Size(607, 23)
        Me.txtJobTitle.TabIndex = 185
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label13.Location = New System.Drawing.Point(122, 98)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(12, 16)
        Me.Label13.TabIndex = 184
        Me.Label13.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label14.Location = New System.Drawing.Point(3, 98)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 16)
        Me.Label14.TabIndex = 183
        Me.Label14.Text = "Job Title"
        '
        'cboJobGrade
        '
        Me.cboJobGrade.ColumnNum = 0
        Me.cboJobGrade.ColumnWidth = Nothing
        Me.cboJobGrade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboJobGrade.DropDownSize = 0
        Me.cboJobGrade.drview = Nothing
        Me.cboJobGrade.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboJobGrade.FormattingEnabled = True
        Me.cboJobGrade.Location = New System.Drawing.Point(515, 65)
        Me.cboJobGrade.Name = "cboJobGrade"
        StringFormat1.Alignment = System.Drawing.StringAlignment.Near
        StringFormat1.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None
        StringFormat1.LineAlignment = System.Drawing.StringAlignment.Near
        StringFormat1.Trimming = System.Drawing.StringTrimming.Character
        Me.cboJobGrade.SetTextFormat = StringFormat1
        Me.cboJobGrade.Size = New System.Drawing.Size(232, 24)
        Me.cboJobGrade.TabIndex = 178
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label7.Location = New System.Drawing.Point(497, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(12, 16)
        Me.Label7.TabIndex = 177
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label8.Location = New System.Drawing.Point(378, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 16)
        Me.Label8.TabIndex = 176
        Me.Label8.Text = "Job Grade"
        '
        'cbojobtype
        '
        Me.cbojobtype.ColumnNum = 0
        Me.cbojobtype.ColumnWidth = Nothing
        Me.cbojobtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbojobtype.DropDownSize = 0
        Me.cbojobtype.drview = Nothing
        Me.cbojobtype.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbojobtype.FormattingEnabled = True
        Me.cbojobtype.Location = New System.Drawing.Point(140, 65)
        Me.cbojobtype.Name = "cbojobtype"
        StringFormat2.Alignment = System.Drawing.StringAlignment.Near
        StringFormat2.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None
        StringFormat2.LineAlignment = System.Drawing.StringAlignment.Near
        StringFormat2.Trimming = System.Drawing.StringTrimming.Character
        Me.cbojobtype.SetTextFormat = StringFormat2
        Me.cbojobtype.Size = New System.Drawing.Size(232, 24)
        Me.cbojobtype.TabIndex = 175
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label10.Location = New System.Drawing.Point(122, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(12, 16)
        Me.Label10.TabIndex = 174
        Me.Label10.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label11.Location = New System.Drawing.Point(3, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 16)
        Me.Label11.TabIndex = 173
        Me.Label11.Text = "Job Type"
        '
        'cboDepartment
        '
        Me.cboDepartment.ColumnNum = 0
        Me.cboDepartment.ColumnWidth = Nothing
        Me.cboDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDepartment.DropDownSize = 0
        Me.cboDepartment.drview = Nothing
        Me.cboDepartment.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Location = New System.Drawing.Point(515, 35)
        Me.cboDepartment.Name = "cboDepartment"
        StringFormat3.Alignment = System.Drawing.StringAlignment.Near
        StringFormat3.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None
        StringFormat3.LineAlignment = System.Drawing.StringAlignment.Near
        StringFormat3.Trimming = System.Drawing.StringTrimming.Character
        Me.cboDepartment.SetTextFormat = StringFormat3
        Me.cboDepartment.Size = New System.Drawing.Size(232, 24)
        Me.cboDepartment.TabIndex = 172
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label4.Location = New System.Drawing.Point(497, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 16)
        Me.Label4.TabIndex = 171
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label5.Location = New System.Drawing.Point(378, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 16)
        Me.Label5.TabIndex = 170
        Me.Label5.Text = "Department"
        '
        'cboDivision
        '
        Me.cboDivision.ColumnNum = 0
        Me.cboDivision.ColumnWidth = Nothing
        Me.cboDivision.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDivision.DropDownSize = 0
        Me.cboDivision.drview = Nothing
        Me.cboDivision.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDivision.FormattingEnabled = True
        Me.cboDivision.Location = New System.Drawing.Point(140, 35)
        Me.cboDivision.Name = "cboDivision"
        StringFormat4.Alignment = System.Drawing.StringAlignment.Near
        StringFormat4.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None
        StringFormat4.LineAlignment = System.Drawing.StringAlignment.Near
        StringFormat4.Trimming = System.Drawing.StringTrimming.Character
        Me.cboDivision.SetTextFormat = StringFormat4
        Me.cboDivision.Size = New System.Drawing.Size(232, 24)
        Me.cboDivision.TabIndex = 169
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label1.Location = New System.Drawing.Point(122, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 16)
        Me.Label1.TabIndex = 168
        Me.Label1.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label3.Location = New System.Drawing.Point(3, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 167
        Me.Label3.Text = "Division"
        '
        'cboCompany
        '
        Me.cboCompany.ColumnNum = 0
        Me.cboCompany.ColumnWidth = Nothing
        Me.cboCompany.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCompany.DropDownSize = 0
        Me.cboCompany.drview = Nothing
        Me.cboCompany.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCompany.FormattingEnabled = True
        Me.cboCompany.Location = New System.Drawing.Point(140, 5)
        Me.cboCompany.Name = "cboCompany"
        StringFormat5.Alignment = System.Drawing.StringAlignment.Near
        StringFormat5.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None
        StringFormat5.LineAlignment = System.Drawing.StringAlignment.Near
        StringFormat5.Trimming = System.Drawing.StringTrimming.Character
        Me.cboCompany.SetTextFormat = StringFormat5
        Me.cboCompany.Size = New System.Drawing.Size(232, 24)
        Me.cboCompany.TabIndex = 113
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label2.Location = New System.Drawing.Point(122, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 16)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label9.Location = New System.Drawing.Point(3, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 16)
        Me.Label9.TabIndex = 111
        Me.Label9.Text = "Company"
        '
        'Timer1
        '
        '
        'frmCreateJob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(775, 853)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCreateJob"
        Me.Text = "Recruitment"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCreateJob As FontAwesome.Sharp.IconButton
    Friend WithEvents Label6 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cboCompany As NxnControls.NxNComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtJobQualifications As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtJobResponsibilities As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtJobSummary As TextBox
    Friend WithEvents cboJobGrade As NxnControls.NxNComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbojobtype As NxnControls.NxNComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cboDepartment As NxnControls.NxNComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboDivision As NxnControls.NxNComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHiresNeeded As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtJobTitle As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents chkSoloParent As CheckBox
    Friend WithEvents chkSick As CheckBox
    Friend WithEvents chkPaternity As CheckBox
    Friend WithEvents chkEmergency As CheckBox
    Friend WithEvents chkBday As CheckBox
    Friend WithEvents chkBereavement As CheckBox
    Friend WithEvents Label17 As Label
    Friend WithEvents chkSSS As CheckBox
    Friend WithEvents chkPhealth As CheckBox
    Friend WithEvents chkPagibig As CheckBox
    Friend WithEvents chkOvertime As CheckBox
    Friend WithEvents chkNightShift As CheckBox
    Friend WithEvents chk13thMonth As CheckBox
    Friend WithEvents chkLifeInsurance As CheckBox
    Friend WithEvents chkHealthInsurance As CheckBox
    Friend WithEvents Label19 As Label
    Friend WithEvents chkSignInBonus As CheckBox
    Friend WithEvents chkReimbursements As CheckBox
    Friend WithEvents chkPerformance As CheckBox
    Friend WithEvents chkMileage As CheckBox
    Friend WithEvents chkLocPackage As CheckBox
    Friend WithEvents chkDiminimis As CheckBox
    Friend WithEvents Label18 As Label
    Friend WithEvents chkActive As CheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtSalary2 As TextBox
    Friend WithEvents txtSalary1 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtJobExperiences As TextBox
    Friend WithEvents txtPlaceOfAssignment As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents chkVAWC As CheckBox
    Friend WithEvents chkVacation As CheckBox
    Friend WithEvents chkMaternity As CheckBox
    Friend WithEvents chkMagnaCarta As CheckBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents dtNeeded2 As DateTimePicker
    Friend WithEvents dtNeeded1 As DateTimePicker
End Class
