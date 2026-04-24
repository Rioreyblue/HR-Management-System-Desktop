<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class rptBankTextFile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptBankTextFile))
        Me.lvCostCenter = New NxnControls.NxNListview()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cboCompany = New NxnControls.NxNComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnPrint = New FontAwesome.Sharp.IconButton()
        Me.btnClose = New NxnControls.CustomControls.NxNControls.NxNButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dp1 = New System.Windows.Forms.DateTimePicker()
        Me.dpBatch = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtContraAcc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtJL_Account = New System.Windows.Forms.TextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.NxNComboBox1 = New NxnControls.NxNComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboCutoff = New NxnControls.NxNComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvCostCenter
        '
        Me.lvCostCenter.CheckBoxes = True
        Me.lvCostCenter.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvCostCenter.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvCostCenter.FullRowSelect = True
        Me.lvCostCenter.HideSelection = False
        Me.lvCostCenter.isCheckedAll = False
        Me.lvCostCenter.itemTrigger = Nothing
        Me.lvCostCenter.Location = New System.Drawing.Point(6, 66)
        Me.lvCostCenter.Name = "lvCostCenter"
        Me.lvCostCenter.OwnerDraw = True
        Me.lvCostCenter.Size = New System.Drawing.Size(388, 476)
        Me.lvCostCenter.TabIndex = 360
        Me.lvCostCenter.UseCompatibleStateImageBehavior = False
        Me.lvCostCenter.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "   CostCode"
        Me.ColumnHeader3.Width = 112
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Description"
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
        Me.cboCompany.TabIndex = 359
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(146, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 17)
        Me.Label2.TabIndex = 358
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
        Me.Label9.TabIndex = 357
        Me.Label9.Text = "Company"
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
        Me.btnPrint.Location = New System.Drawing.Point(624, 548)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 30)
        Me.btnPrint.TabIndex = 506
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
        Me.btnClose.Location = New System.Drawing.Point(710, 548)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 30)
        Me.btnClose.TabIndex = 505
        Me.btnClose.Text = "Close"
        Me.btnClose.TextColor = System.Drawing.Color.White
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(400, 36)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(390, 506)
        Me.TabControl1.TabIndex = 507
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.dp1)
        Me.TabPage1.Controls.Add(Me.dpBatch)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.txtContraAcc)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txtDescription)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtJL_Account)
        Me.TabPage1.Controls.Add(Me.RadioButton2)
        Me.TabPage1.Controls.Add(Me.RadioButton1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(382, 477)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Pinoy Coop"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HRMAXV16.My.Resources.Resources.Pinoy_Coop_Logo_Full_Color_Primary_1536x408
        Me.PictureBox1.Location = New System.Drawing.Point(6, 234)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(370, 121)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 530
        Me.PictureBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Maroon
        Me.Label12.Location = New System.Drawing.Point(166, 143)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 17)
        Me.Label12.TabIndex = 529
        Me.Label12.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Maroon
        Me.Label14.Location = New System.Drawing.Point(6, 143)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 17)
        Me.Label14.TabIndex = 528
        Me.Label14.Text = "Batch Date"
        '
        'dp1
        '
        Me.dp1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dp1.Location = New System.Drawing.Point(274, 140)
        Me.dp1.Name = "dp1"
        Me.dp1.Size = New System.Drawing.Size(16, 25)
        Me.dp1.TabIndex = 527
        '
        'dpBatch
        '
        Me.dpBatch.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpBatch.Location = New System.Drawing.Point(183, 140)
        Me.dpBatch.Mask = "00/00/0000"
        Me.dpBatch.Name = "dpBatch"
        Me.dpBatch.Size = New System.Drawing.Size(92, 25)
        Me.dpBatch.TabIndex = 526
        Me.dpBatch.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.dpBatch.ValidatingType = GetType(Date)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(166, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 17)
        Me.Label10.TabIndex = 525
        Me.Label10.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(6, 174)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 17)
        Me.Label11.TabIndex = 524
        Me.Label11.Text = "Contra Account"
        '
        'txtContraAcc
        '
        Me.txtContraAcc.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraAcc.Location = New System.Drawing.Point(183, 171)
        Me.txtContraAcc.MaxLength = 15
        Me.txtContraAcc.Name = "txtContraAcc"
        Me.txtContraAcc.Size = New System.Drawing.Size(193, 23)
        Me.txtContraAcc.TabIndex = 523
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(166, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 17)
        Me.Label7.TabIndex = 522
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(6, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 17)
        Me.Label8.TabIndex = 521
        Me.Label8.Text = "Batch Description"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(183, 111)
        Me.txtDescription.MaxLength = 6
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(193, 23)
        Me.txtDescription.TabIndex = 520
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Maroon
        Me.Label13.Location = New System.Drawing.Point(166, 85)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(11, 17)
        Me.Label13.TabIndex = 519
        Me.Label13.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(6, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 17)
        Me.Label6.TabIndex = 518
        Me.Label6.Text = "Journal Ledger's Account"
        '
        'txtJL_Account
        '
        Me.txtJL_Account.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJL_Account.Location = New System.Drawing.Point(183, 82)
        Me.txtJL_Account.MaxLength = 15
        Me.txtJL_Account.Name = "txtJL_Account"
        Me.txtJL_Account.Size = New System.Drawing.Size(193, 23)
        Me.txtJL_Account.TabIndex = 517
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(6, 33)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(231, 21)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Other/Fixed/Amortized Deductions"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(6, 6)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(74, 21)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Net Pay"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'NxNComboBox1
        '
        Me.NxNComboBox1.ColumnNum = 0
        Me.NxNComboBox1.ColumnWidth = Nothing
        Me.NxNComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.NxNComboBox1.DropDownSize = 0
        Me.NxNComboBox1.drview = Nothing
        Me.NxNComboBox1.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NxNComboBox1.FormattingEnabled = True
        Me.NxNComboBox1.Location = New System.Drawing.Point(558, 6)
        Me.NxNComboBox1.Name = "NxNComboBox1"
        StringFormat2.Alignment = System.Drawing.StringAlignment.Near
        StringFormat2.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None
        StringFormat2.LineAlignment = System.Drawing.StringAlignment.Near
        StringFormat2.Trimming = System.Drawing.StringTrimming.Character
        Me.NxNComboBox1.SetTextFormat = StringFormat2
        Me.NxNComboBox1.Size = New System.Drawing.Size(232, 24)
        Me.NxNComboBox1.TabIndex = 510
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(542, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 17)
        Me.Label1.TabIndex = 509
        Me.Label1.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(402, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 508
        Me.Label3.Text = "Bank Name"
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
        StringFormat3.Alignment = System.Drawing.StringAlignment.Near
        StringFormat3.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None
        StringFormat3.LineAlignment = System.Drawing.StringAlignment.Near
        StringFormat3.Trimming = System.Drawing.StringTrimming.Character
        Me.cboCutoff.SetTextFormat = StringFormat3
        Me.cboCutoff.Size = New System.Drawing.Size(232, 24)
        Me.cboCutoff.TabIndex = 513
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(146, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 17)
        Me.Label4.TabIndex = 512
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(6, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 17)
        Me.Label5.TabIndex = 511
        Me.Label5.Text = "Cutoff"
        '
        'Timer1
        '
        Me.Timer1.Interval = 8
        '
        'rptBankTextFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(795, 585)
        Me.Controls.Add(Me.cboCutoff)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NxNComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lvCostCenter)
        Me.Controls.Add(Me.cboCompany)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rptBankTextFile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bank Text File"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvCostCenter As NxnControls.NxNListview
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents cboCompany As NxnControls.NxNComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnPrint As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClose As NxnControls.CustomControls.NxNControls.NxNButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents NxNComboBox1 As NxnControls.NxNComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboCutoff As NxnControls.NxNComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtContraAcc As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtJL_Account As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents dp1 As DateTimePicker
    Friend WithEvents dpBatch As MaskedTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
