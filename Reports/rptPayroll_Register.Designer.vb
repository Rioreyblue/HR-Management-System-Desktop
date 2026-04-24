<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptPayroll_Register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim StringFormat1 As System.Drawing.StringFormat = New System.Drawing.StringFormat()
        Dim StringFormat2 As System.Drawing.StringFormat = New System.Drawing.StringFormat()
        Dim StringFormat3 As System.Drawing.StringFormat = New System.Drawing.StringFormat()
        Dim StringFormat4 As System.Drawing.StringFormat = New System.Drawing.StringFormat()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptPayroll_Register))
        Me.lvEmployee = New NxnControls.NxNListview()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnPrint = New FontAwesome.Sharp.IconButton()
        Me.btnClose = New NxnControls.CustomControls.NxNControls.NxNButton()
        Me.lvDivision = New NxnControls.NxNListview()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cboCompany = New NxnControls.NxNComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboCutoff = New NxnControls.NxNComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboJobStatus = New NxnControls.NxNComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboYear = New NxnControls.NxNComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.chkShowPaymode = New System.Windows.Forms.CheckBox()
        Me.chkEmployerShare = New System.Windows.Forms.CheckBox()
        Me.chkShowTaxableGross = New System.Windows.Forms.CheckBox()
        Me.chkShowDivision = New System.Windows.Forms.CheckBox()
        Me.chkShowJobStatus = New System.Windows.Forms.CheckBox()
        Me.chkShowDepartment = New System.Windows.Forms.CheckBox()
        Me.chkShowHours = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.chkShowCutoff = New System.Windows.Forms.CheckBox()
        Me.chkShowCostCenter = New System.Windows.Forms.CheckBox()
        Me.chkDetailedLeave = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvEmployee
        '
        Me.lvEmployee.CheckBoxes = True
        Me.lvEmployee.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvEmployee.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvEmployee.FullRowSelect = True
        Me.lvEmployee.HideSelection = False
        Me.lvEmployee.isCheckedAll = False
        Me.lvEmployee.itemTrigger = Nothing
        Me.lvEmployee.Location = New System.Drawing.Point(400, 66)
        Me.lvEmployee.MultiSelect = False
        Me.lvEmployee.Name = "lvEmployee"
        Me.lvEmployee.OwnerDraw = True
        Me.lvEmployee.Size = New System.Drawing.Size(388, 476)
        Me.lvEmployee.TabIndex = 512
        Me.lvEmployee.UseCompatibleStateImageBehavior = False
        Me.lvEmployee.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Fullname"
        Me.ColumnHeader2.Width = 265
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.btnPrint.IconColor = System.Drawing.Color.White
        Me.btnPrint.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPrint.IconSize = 24
        Me.btnPrint.Location = New System.Drawing.Point(622, 548)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 30)
        Me.btnPrint.TabIndex = 511
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnClose.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnClose.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnClose.BorderRadius = 0
        Me.btnClose.BorderSize = 0
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(708, 548)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 30)
        Me.btnClose.TabIndex = 510
        Me.btnClose.Text = "Close"
        Me.btnClose.TextColor = System.Drawing.Color.White
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lvDivision
        '
        Me.lvDivision.CheckBoxes = True
        Me.lvDivision.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvDivision.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvDivision.FullRowSelect = True
        Me.lvDivision.HideSelection = False
        Me.lvDivision.isCheckedAll = False
        Me.lvDivision.itemTrigger = Nothing
        Me.lvDivision.Location = New System.Drawing.Point(6, 66)
        Me.lvDivision.Name = "lvDivision"
        Me.lvDivision.OwnerDraw = True
        Me.lvDivision.Size = New System.Drawing.Size(388, 476)
        Me.lvDivision.TabIndex = 509
        Me.lvDivision.UseCompatibleStateImageBehavior = False
        Me.lvDivision.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "   Division Code"
        Me.ColumnHeader3.Width = 112
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Division Name"
        Me.ColumnHeader4.Width = 253
        '
        'cboCompany
        '
        Me.cboCompany.ColumnNum = 0
        Me.cboCompany.ColumnWidth = Nothing
        Me.cboCompany.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCompany.DropDownSize = 0
        Me.cboCompany.drview = Nothing
        Me.cboCompany.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCompany.FormattingEnabled = True
        Me.cboCompany.Location = New System.Drawing.Point(162, 6)
        Me.cboCompany.Name = "cboCompany"
        StringFormat1.Alignment = System.Drawing.StringAlignment.Near
        StringFormat1.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None
        StringFormat1.LineAlignment = System.Drawing.StringAlignment.Near
        StringFormat1.Trimming = System.Drawing.StringTrimming.Character
        Me.cboCompany.SetTextFormat = StringFormat1
        Me.cboCompany.Size = New System.Drawing.Size(232, 24)
        Me.cboCompany.TabIndex = 508
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(146, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 17)
        Me.Label2.TabIndex = 507
        Me.Label2.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(6, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 17)
        Me.Label9.TabIndex = 506
        Me.Label9.Text = "Company"
        '
        'cboCutoff
        '
        Me.cboCutoff.ColumnNum = 0
        Me.cboCutoff.ColumnWidth = Nothing
        Me.cboCutoff.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCutoff.DropDownSize = 0
        Me.cboCutoff.drview = Nothing
        Me.cboCutoff.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCutoff.FormattingEnabled = True
        Me.cboCutoff.IntegralHeight = False
        Me.cboCutoff.Location = New System.Drawing.Point(162, 36)
        Me.cboCutoff.Name = "cboCutoff"
        StringFormat2.Alignment = System.Drawing.StringAlignment.Near
        StringFormat2.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None
        StringFormat2.LineAlignment = System.Drawing.StringAlignment.Near
        StringFormat2.Trimming = System.Drawing.StringTrimming.Character
        Me.cboCutoff.SetTextFormat = StringFormat2
        Me.cboCutoff.Size = New System.Drawing.Size(232, 24)
        Me.cboCutoff.TabIndex = 515
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(146, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 17)
        Me.Label1.TabIndex = 514
        Me.Label1.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(6, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 17)
        Me.Label3.TabIndex = 513
        Me.Label3.Text = "Cutoff"
        '
        'cboJobStatus
        '
        Me.cboJobStatus.ColumnNum = 0
        Me.cboJobStatus.ColumnWidth = Nothing
        Me.cboJobStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboJobStatus.DropDownSize = 0
        Me.cboJobStatus.drview = Nothing
        Me.cboJobStatus.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboJobStatus.FormattingEnabled = True
        Me.cboJobStatus.IntegralHeight = False
        Me.cboJobStatus.Location = New System.Drawing.Point(556, 36)
        Me.cboJobStatus.Name = "cboJobStatus"
        StringFormat3.Alignment = System.Drawing.StringAlignment.Near
        StringFormat3.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None
        StringFormat3.LineAlignment = System.Drawing.StringAlignment.Near
        StringFormat3.Trimming = System.Drawing.StringTrimming.Character
        Me.cboJobStatus.SetTextFormat = StringFormat3
        Me.cboJobStatus.Size = New System.Drawing.Size(232, 24)
        Me.cboJobStatus.TabIndex = 521
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(540, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 17)
        Me.Label4.TabIndex = 520
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(400, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 519
        Me.Label5.Text = "Job Status"
        '
        'cboYear
        '
        Me.cboYear.ColumnNum = 0
        Me.cboYear.ColumnWidth = Nothing
        Me.cboYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboYear.DropDownSize = 0
        Me.cboYear.drview = Nothing
        Me.cboYear.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.IntegralHeight = False
        Me.cboYear.Location = New System.Drawing.Point(556, 6)
        Me.cboYear.Name = "cboYear"
        StringFormat4.Alignment = System.Drawing.StringAlignment.Near
        StringFormat4.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None
        StringFormat4.LineAlignment = System.Drawing.StringAlignment.Near
        StringFormat4.Trimming = System.Drawing.StringTrimming.Character
        Me.cboYear.SetTextFormat = StringFormat4
        Me.cboYear.Size = New System.Drawing.Size(232, 24)
        Me.cboYear.TabIndex = 518
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(540, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 17)
        Me.Label6.TabIndex = 517
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(400, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 17)
        Me.Label7.TabIndex = 516
        Me.Label7.Text = "Process Year"
        '
        'Timer1
        '
        Me.Timer1.Interval = 8
        '
        'chkShowPaymode
        '
        Me.chkShowPaymode.AutoSize = True
        Me.chkShowPaymode.Checked = True
        Me.chkShowPaymode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowPaymode.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowPaymode.Location = New System.Drawing.Point(3, 30)
        Me.chkShowPaymode.Name = "chkShowPaymode"
        Me.chkShowPaymode.Size = New System.Drawing.Size(119, 21)
        Me.chkShowPaymode.TabIndex = 523
        Me.chkShowPaymode.Text = "Show Paymode"
        Me.chkShowPaymode.UseVisualStyleBackColor = True
        '
        'chkEmployerShare
        '
        Me.chkEmployerShare.AutoSize = True
        Me.chkEmployerShare.Checked = True
        Me.chkEmployerShare.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEmployerShare.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEmployerShare.Location = New System.Drawing.Point(3, 57)
        Me.chkEmployerShare.Name = "chkEmployerShare"
        Me.chkEmployerShare.Size = New System.Drawing.Size(122, 21)
        Me.chkEmployerShare.TabIndex = 524
        Me.chkEmployerShare.Text = "Employer Share"
        Me.chkEmployerShare.UseVisualStyleBackColor = True
        '
        'chkShowTaxableGross
        '
        Me.chkShowTaxableGross.AutoSize = True
        Me.chkShowTaxableGross.Checked = True
        Me.chkShowTaxableGross.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowTaxableGross.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowTaxableGross.Location = New System.Drawing.Point(206, 30)
        Me.chkShowTaxableGross.Name = "chkShowTaxableGross"
        Me.chkShowTaxableGross.Size = New System.Drawing.Size(147, 21)
        Me.chkShowTaxableGross.TabIndex = 527
        Me.chkShowTaxableGross.Text = "Show Taxable Gross"
        Me.chkShowTaxableGross.UseVisualStyleBackColor = True
        '
        'chkShowDivision
        '
        Me.chkShowDivision.AutoSize = True
        Me.chkShowDivision.Checked = True
        Me.chkShowDivision.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowDivision.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowDivision.Location = New System.Drawing.Point(3, 84)
        Me.chkShowDivision.Name = "chkShowDivision"
        Me.chkShowDivision.Size = New System.Drawing.Size(110, 21)
        Me.chkShowDivision.TabIndex = 525
        Me.chkShowDivision.Text = "Show Division"
        Me.chkShowDivision.UseVisualStyleBackColor = True
        '
        'chkShowJobStatus
        '
        Me.chkShowJobStatus.AutoSize = True
        Me.chkShowJobStatus.Checked = True
        Me.chkShowJobStatus.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowJobStatus.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowJobStatus.Location = New System.Drawing.Point(206, 84)
        Me.chkShowJobStatus.Name = "chkShowJobStatus"
        Me.chkShowJobStatus.Size = New System.Drawing.Size(125, 21)
        Me.chkShowJobStatus.TabIndex = 529
        Me.chkShowJobStatus.Text = "Show Job Status"
        Me.chkShowJobStatus.UseVisualStyleBackColor = True
        '
        'chkShowDepartment
        '
        Me.chkShowDepartment.AutoSize = True
        Me.chkShowDepartment.Checked = True
        Me.chkShowDepartment.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowDepartment.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowDepartment.Location = New System.Drawing.Point(206, 57)
        Me.chkShowDepartment.Name = "chkShowDepartment"
        Me.chkShowDepartment.Size = New System.Drawing.Size(134, 21)
        Me.chkShowDepartment.TabIndex = 528
        Me.chkShowDepartment.Text = "Show Department"
        Me.chkShowDepartment.UseVisualStyleBackColor = True
        '
        'chkShowHours
        '
        Me.chkShowHours.AutoSize = True
        Me.chkShowHours.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowHours.Location = New System.Drawing.Point(409, 30)
        Me.chkShowHours.Name = "chkShowHours"
        Me.chkShowHours.Size = New System.Drawing.Size(100, 21)
        Me.chkShowHours.TabIndex = 531
        Me.chkShowHours.Text = "Show Hours"
        Me.chkShowHours.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.Controls.Add(Me.chkEmployerShare, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.chkShowPaymode, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.chkShowCutoff, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.chkShowDivision, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.chkShowCostCenter, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.chkShowTaxableGross, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.chkShowDepartment, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.chkShowJobStatus, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.chkDetailedLeave, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.chkShowHours, 2, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 548)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(610, 109)
        Me.TableLayoutPanel1.TabIndex = 533
        '
        'chkShowCutoff
        '
        Me.chkShowCutoff.AutoSize = True
        Me.chkShowCutoff.Checked = True
        Me.chkShowCutoff.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowCutoff.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowCutoff.Location = New System.Drawing.Point(3, 3)
        Me.chkShowCutoff.Name = "chkShowCutoff"
        Me.chkShowCutoff.Size = New System.Drawing.Size(100, 21)
        Me.chkShowCutoff.TabIndex = 522
        Me.chkShowCutoff.Text = "Show Cutoff"
        Me.chkShowCutoff.UseVisualStyleBackColor = True
        '
        'chkShowCostCenter
        '
        Me.chkShowCostCenter.AutoSize = True
        Me.chkShowCostCenter.Checked = True
        Me.chkShowCostCenter.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowCostCenter.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowCostCenter.Location = New System.Drawing.Point(206, 3)
        Me.chkShowCostCenter.Name = "chkShowCostCenter"
        Me.chkShowCostCenter.Size = New System.Drawing.Size(133, 21)
        Me.chkShowCostCenter.TabIndex = 526
        Me.chkShowCostCenter.Text = "Show Cost Center"
        Me.chkShowCostCenter.UseVisualStyleBackColor = True
        '
        'chkDetailedLeave
        '
        Me.chkDetailedLeave.AutoSize = True
        Me.chkDetailedLeave.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDetailedLeave.Location = New System.Drawing.Point(409, 3)
        Me.chkDetailedLeave.Name = "chkDetailedLeave"
        Me.chkDetailedLeave.Size = New System.Drawing.Size(115, 21)
        Me.chkDetailedLeave.TabIndex = 530
        Me.chkDetailedLeave.Text = "Detailed Leave"
        Me.chkDetailedLeave.UseVisualStyleBackColor = True
        '
        'rptPayroll_Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(795, 662)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.cboJobStatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboYear)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboCutoff)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lvEmployee)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lvDivision)
        Me.Controls.Add(Me.cboCompany)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rptPayroll_Register"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll Register"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvEmployee As NxnControls.NxNListview
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents btnPrint As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClose As NxnControls.CustomControls.NxNControls.NxNButton
    Friend WithEvents lvDivision As NxnControls.NxNListview
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents cboCompany As NxnControls.NxNComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cboCutoff As NxnControls.NxNComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboJobStatus As NxnControls.NxNComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboYear As NxnControls.NxNComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents chkShowPaymode As CheckBox
    Friend WithEvents chkEmployerShare As CheckBox
    Friend WithEvents chkShowTaxableGross As CheckBox
    Friend WithEvents chkShowDivision As CheckBox
    Friend WithEvents chkShowJobStatus As CheckBox
    Friend WithEvents chkShowDepartment As CheckBox
    Friend WithEvents chkShowHours As CheckBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents chkShowCutoff As CheckBox
    Friend WithEvents chkShowCostCenter As CheckBox
    Friend WithEvents chkDetailedLeave As CheckBox
End Class
