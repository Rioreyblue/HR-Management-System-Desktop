<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEarningsConfiguration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEarningsConfiguration))
        Me.txtLrType = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCeilingAmount = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtCeilingAmount = New System.Windows.Forms.TextBox()
        Me.txtIncomeCode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvEarningConfig = New NxnControls.NxNListview()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTranType = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkDeductible = New System.Windows.Forms.CheckBox()
        Me.chkMonthly = New System.Windows.Forms.CheckBox()
        Me.chkNonTaxable = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rbtnSpecialPayroll = New System.Windows.Forms.RadioButton()
        Me.rbtnNormalPayroll = New System.Windows.Forms.RadioButton()
        Me.chkIncludeAlphaListing = New System.Windows.Forms.CheckBox()
        Me.chkAutomaticGross = New System.Windows.Forms.CheckBox()
        Me.chkInclBadsedOn = New System.Windows.Forms.CheckBox()
        Me.chkAutomaticContraAcct = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btnClearDisplay = New NxnControls.CustomControls.NxNControls.NxNButton()
        Me.txtFixed = New System.Windows.Forms.TextBox()
        Me.cboBracket = New System.Windows.Forms.ComboBox()
        Me.btnBracket = New FontAwesome.Sharp.IconButton()
        Me.btnFixed = New FontAwesome.Sharp.IconButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboOperator = New System.Windows.Forms.ComboBox()
        Me.btnOperator = New FontAwesome.Sharp.IconButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboInternal = New System.Windows.Forms.ComboBox()
        Me.btnInternal = New FontAwesome.Sharp.IconButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkFormulated = New System.Windows.Forms.CheckBox()
        Me.btnAdd = New NxnControls.CustomControls.NxNControls.NxNButton()
        Me.btnClose = New NxnControls.CustomControls.NxNControls.NxNButton()
        Me.btnClear = New NxnControls.CustomControls.NxNControls.NxNButton()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UpdateTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLrType
        '
        Me.txtLrType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLrType.Location = New System.Drawing.Point(133, 80)
        Me.txtLrType.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtLrType.Name = "txtLrType"
        Me.txtLrType.Size = New System.Drawing.Size(203, 20)
        Me.txtLrType.TabIndex = 662
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label1.Location = New System.Drawing.Point(113, 80)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 16)
        Me.Label1.TabIndex = 657
        Me.Label1.Text = ":"
        '
        'lblCeilingAmount
        '
        Me.lblCeilingAmount.AutoSize = True
        Me.lblCeilingAmount.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCeilingAmount.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblCeilingAmount.Location = New System.Drawing.Point(2, 56)
        Me.lblCeilingAmount.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lblCeilingAmount.Name = "lblCeilingAmount"
        Me.lblCeilingAmount.Size = New System.Drawing.Size(110, 16)
        Me.lblCeilingAmount.TabIndex = 656
        Me.lblCeilingAmount.Text = "Annual Ceiling"
        '
        'txtDescription
        '
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.Location = New System.Drawing.Point(133, 32)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(203, 20)
        Me.txtDescription.TabIndex = 655
        '
        'txtCeilingAmount
        '
        Me.txtCeilingAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCeilingAmount.Location = New System.Drawing.Point(133, 56)
        Me.txtCeilingAmount.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCeilingAmount.MaxLength = 12
        Me.txtCeilingAmount.Name = "txtCeilingAmount"
        Me.txtCeilingAmount.Size = New System.Drawing.Size(133, 20)
        Me.txtCeilingAmount.TabIndex = 654
        '
        'txtIncomeCode
        '
        Me.txtIncomeCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIncomeCode.Location = New System.Drawing.Point(133, 7)
        Me.txtIncomeCode.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtIncomeCode.Name = "txtIncomeCode"
        Me.txtIncomeCode.Size = New System.Drawing.Size(139, 20)
        Me.txtIncomeCode.TabIndex = 653
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label9.Location = New System.Drawing.Point(2, 7)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 16)
        Me.Label9.TabIndex = 646
        Me.Label9.Text = "Income Code"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Non-Taxable"
        Me.ColumnHeader1.Width = 120
        '
        'lvEarningConfig
        '
        Me.lvEarningConfig.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14})
        Me.lvEarningConfig.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvEarningConfig.FullRowSelect = True
        Me.lvEarningConfig.HideSelection = False
        Me.lvEarningConfig.isCheckedAll = False
        Me.lvEarningConfig.itemTrigger = Nothing
        Me.lvEarningConfig.Location = New System.Drawing.Point(4, 288)
        Me.lvEarningConfig.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lvEarningConfig.Name = "lvEarningConfig"
        Me.lvEarningConfig.OwnerDraw = True
        Me.lvEarningConfig.Size = New System.Drawing.Size(469, 407)
        Me.lvEarningConfig.TabIndex = 645
        Me.lvEarningConfig.UseCompatibleStateImageBehavior = False
        Me.lvEarningConfig.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Income Code"
        Me.ColumnHeader3.Width = 120
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Description"
        Me.ColumnHeader4.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Formulated"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Formula"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Annual Ceiling Amount"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Deductible"
        Me.ColumnHeader7.Width = 150
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Include Alphalist?"
        Me.ColumnHeader8.Width = 150
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Payrol Type"
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Automatic Gross"
        Me.ColumnHeader10.Width = 100
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Include Based-On"
        Me.ColumnHeader11.Width = 100
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Auto Contra-Accnt?"
        Me.ColumnHeader12.Width = 120
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Lr Type"
        Me.ColumnHeader13.Width = 100
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Ceiling"
        Me.ColumnHeader14.Width = 100
        '
        'Timer1
        '
        Me.Timer1.Interval = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label11.Location = New System.Drawing.Point(113, 56)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(12, 16)
        Me.Label11.TabIndex = 651
        Me.Label11.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label12.Location = New System.Drawing.Point(2, 32)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 16)
        Me.Label12.TabIndex = 650
        Me.Label12.Text = "Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label4.Location = New System.Drawing.Point(113, 32)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 16)
        Me.Label4.TabIndex = 649
        Me.Label4.Text = ":"
        '
        'lblTranType
        '
        Me.lblTranType.AutoSize = True
        Me.lblTranType.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTranType.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblTranType.Location = New System.Drawing.Point(2, 80)
        Me.lblTranType.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lblTranType.Name = "lblTranType"
        Me.lblTranType.Size = New System.Drawing.Size(78, 16)
        Me.lblTranType.TabIndex = 648
        Me.lblTranType.Text = "Tran Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label2.Location = New System.Drawing.Point(113, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 16)
        Me.Label2.TabIndex = 647
        Me.Label2.Text = ":"
        '
        'chkDeductible
        '
        Me.chkDeductible.AutoSize = True
        Me.chkDeductible.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDeductible.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkDeductible.Location = New System.Drawing.Point(378, 8)
        Me.chkDeductible.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkDeductible.Name = "chkDeductible"
        Me.chkDeductible.Size = New System.Drawing.Size(106, 20)
        Me.chkDeductible.TabIndex = 652
        Me.chkDeductible.Text = "Deductible"
        Me.chkDeductible.UseVisualStyleBackColor = True
        '
        'chkMonthly
        '
        Me.chkMonthly.AutoSize = True
        Me.chkMonthly.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMonthly.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkMonthly.Location = New System.Drawing.Point(270, 58)
        Me.chkMonthly.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkMonthly.Name = "chkMonthly"
        Me.chkMonthly.Size = New System.Drawing.Size(87, 20)
        Me.chkMonthly.TabIndex = 665
        Me.chkMonthly.Text = "Monthly"
        Me.chkMonthly.UseVisualStyleBackColor = True
        '
        'chkNonTaxable
        '
        Me.chkNonTaxable.AutoSize = True
        Me.chkNonTaxable.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNonTaxable.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkNonTaxable.Location = New System.Drawing.Point(276, 8)
        Me.chkNonTaxable.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkNonTaxable.Name = "chkNonTaxable"
        Me.chkNonTaxable.Size = New System.Drawing.Size(121, 20)
        Me.chkNonTaxable.TabIndex = 666
        Me.chkNonTaxable.Text = "Non-Taxable"
        Me.chkNonTaxable.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rbtnSpecialPayroll)
        Me.GroupBox5.Controls.Add(Me.rbtnNormalPayroll)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GroupBox5.Location = New System.Drawing.Point(340, 29)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(133, 64)
        Me.GroupBox5.TabIndex = 668
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Payroll Type"
        '
        'rbtnSpecialPayroll
        '
        Me.rbtnSpecialPayroll.AutoSize = True
        Me.rbtnSpecialPayroll.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnSpecialPayroll.ForeColor = System.Drawing.SystemColors.GrayText
        Me.rbtnSpecialPayroll.Location = New System.Drawing.Point(4, 38)
        Me.rbtnSpecialPayroll.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbtnSpecialPayroll.Name = "rbtnSpecialPayroll"
        Me.rbtnSpecialPayroll.Size = New System.Drawing.Size(134, 20)
        Me.rbtnSpecialPayroll.TabIndex = 669
        Me.rbtnSpecialPayroll.Text = "Special Payroll"
        Me.rbtnSpecialPayroll.UseVisualStyleBackColor = True
        '
        'rbtnNormalPayroll
        '
        Me.rbtnNormalPayroll.AutoSize = True
        Me.rbtnNormalPayroll.Checked = True
        Me.rbtnNormalPayroll.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnNormalPayroll.ForeColor = System.Drawing.SystemColors.GrayText
        Me.rbtnNormalPayroll.Location = New System.Drawing.Point(4, 17)
        Me.rbtnNormalPayroll.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbtnNormalPayroll.Name = "rbtnNormalPayroll"
        Me.rbtnNormalPayroll.Size = New System.Drawing.Size(134, 20)
        Me.rbtnNormalPayroll.TabIndex = 530
        Me.rbtnNormalPayroll.TabStop = True
        Me.rbtnNormalPayroll.Text = "Normal Payroll"
        Me.rbtnNormalPayroll.UseVisualStyleBackColor = True
        '
        'chkIncludeAlphaListing
        '
        Me.chkIncludeAlphaListing.AutoSize = True
        Me.chkIncludeAlphaListing.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIncludeAlphaListing.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkIncludeAlphaListing.Location = New System.Drawing.Point(133, 103)
        Me.chkIncludeAlphaListing.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkIncludeAlphaListing.Name = "chkIncludeAlphaListing"
        Me.chkIncludeAlphaListing.Size = New System.Drawing.Size(253, 20)
        Me.chkIncludeAlphaListing.TabIndex = 669
        Me.chkIncludeAlphaListing.Text = "Include Earning on Alphalisting"
        Me.chkIncludeAlphaListing.UseVisualStyleBackColor = True
        '
        'chkAutomaticGross
        '
        Me.chkAutomaticGross.AutoSize = True
        Me.chkAutomaticGross.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAutomaticGross.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkAutomaticGross.Location = New System.Drawing.Point(133, 124)
        Me.chkAutomaticGross.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkAutomaticGross.Name = "chkAutomaticGross"
        Me.chkAutomaticGross.Size = New System.Drawing.Size(424, 20)
        Me.chkAutomaticGross.TabIndex = 670
        Me.chkAutomaticGross.Text = "Automatic Calculation of Gross Tax Based on Tax Code"
        Me.chkAutomaticGross.UseVisualStyleBackColor = True
        '
        'chkInclBadsedOn
        '
        Me.chkInclBadsedOn.AutoSize = True
        Me.chkInclBadsedOn.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInclBadsedOn.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkInclBadsedOn.Location = New System.Drawing.Point(133, 145)
        Me.chkInclBadsedOn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkInclBadsedOn.Name = "chkInclBadsedOn"
        Me.chkInclBadsedOn.Size = New System.Drawing.Size(414, 20)
        Me.chkInclBadsedOn.TabIndex = 671
        Me.chkInclBadsedOn.Text = "Add on Monthly Rate Based-on Amount for Premiums"
        Me.chkInclBadsedOn.UseVisualStyleBackColor = True
        '
        'chkAutomaticContraAcct
        '
        Me.chkAutomaticContraAcct.AutoSize = True
        Me.chkAutomaticContraAcct.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAutomaticContraAcct.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkAutomaticContraAcct.Location = New System.Drawing.Point(133, 167)
        Me.chkAutomaticContraAcct.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkAutomaticContraAcct.Name = "chkAutomaticContraAcct"
        Me.chkAutomaticContraAcct.Size = New System.Drawing.Size(324, 20)
        Me.chkAutomaticContraAcct.TabIndex = 672
        Me.chkAutomaticContraAcct.Text = "Automatic Contra-Account for Deduction"
        Me.chkAutomaticContraAcct.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDisplay)
        Me.GroupBox1.Controls.Add(Me.btnClearDisplay)
        Me.GroupBox1.Controls.Add(Me.txtFixed)
        Me.GroupBox1.Controls.Add(Me.cboBracket)
        Me.GroupBox1.Controls.Add(Me.btnBracket)
        Me.GroupBox1.Controls.Add(Me.btnFixed)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cboOperator)
        Me.GroupBox1.Controls.Add(Me.btnOperator)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cboInternal)
        Me.GroupBox1.Controls.Add(Me.btnInternal)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.chkFormulated)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GroupBox1.Location = New System.Drawing.Point(4, 188)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(468, 96)
        Me.GroupBox1.TabIndex = 670
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "   Formulated : "
        '
        'lblDisplay
        '
        Me.lblDisplay.BackColor = System.Drawing.Color.Blue
        Me.lblDisplay.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.ForeColor = System.Drawing.Color.White
        Me.lblDisplay.Location = New System.Drawing.Point(17, 63)
        Me.lblDisplay.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(370, 20)
        Me.lblDisplay.TabIndex = 677
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClearDisplay
        '
        Me.btnClearDisplay.BackColor = System.Drawing.Color.DimGray
        Me.btnClearDisplay.BackgroundColor = System.Drawing.Color.DimGray
        Me.btnClearDisplay.BorderColor = System.Drawing.Color.DimGray
        Me.btnClearDisplay.BorderRadius = 0
        Me.btnClearDisplay.BorderSize = 0
        Me.btnClearDisplay.FlatAppearance.BorderSize = 0
        Me.btnClearDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearDisplay.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearDisplay.ForeColor = System.Drawing.Color.White
        Me.btnClearDisplay.Location = New System.Drawing.Point(392, 63)
        Me.btnClearDisplay.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClearDisplay.Name = "btnClearDisplay"
        Me.btnClearDisplay.Size = New System.Drawing.Size(44, 20)
        Me.btnClearDisplay.TabIndex = 673
        Me.btnClearDisplay.Text = "Clear"
        Me.btnClearDisplay.TextColor = System.Drawing.Color.White
        Me.btnClearDisplay.UseVisualStyleBackColor = False
        '
        'txtFixed
        '
        Me.txtFixed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFixed.Location = New System.Drawing.Point(232, 40)
        Me.txtFixed.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFixed.Name = "txtFixed"
        Me.txtFixed.Size = New System.Drawing.Size(76, 22)
        Me.txtFixed.TabIndex = 673
        '
        'cboBracket
        '
        Me.cboBracket.FormattingEnabled = True
        Me.cboBracket.Items.AddRange(New Object() {"'('", "')'"})
        Me.cboBracket.Location = New System.Drawing.Point(339, 38)
        Me.cboBracket.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboBracket.Name = "cboBracket"
        Me.cboBracket.Size = New System.Drawing.Size(76, 24)
        Me.cboBracket.TabIndex = 679
        '
        'btnBracket
        '
        Me.btnBracket.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnBracket.FlatAppearance.BorderSize = 0
        Me.btnBracket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBracket.ForeColor = System.Drawing.Color.White
        Me.btnBracket.IconChar = FontAwesome.Sharp.IconChar.Add
        Me.btnBracket.IconColor = System.Drawing.Color.White
        Me.btnBracket.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnBracket.IconSize = 24
        Me.btnBracket.Location = New System.Drawing.Point(418, 37)
        Me.btnBracket.Margin = New System.Windows.Forms.Padding(2, 2, 8, 2)
        Me.btnBracket.Name = "btnBracket"
        Me.btnBracket.Size = New System.Drawing.Size(18, 20)
        Me.btnBracket.TabIndex = 678
        Me.btnBracket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBracket.UseVisualStyleBackColor = False
        '
        'btnFixed
        '
        Me.btnFixed.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnFixed.FlatAppearance.BorderSize = 0
        Me.btnFixed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFixed.ForeColor = System.Drawing.Color.White
        Me.btnFixed.IconChar = FontAwesome.Sharp.IconChar.Add
        Me.btnFixed.IconColor = System.Drawing.Color.White
        Me.btnFixed.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnFixed.IconSize = 24
        Me.btnFixed.Location = New System.Drawing.Point(311, 38)
        Me.btnFixed.Margin = New System.Windows.Forms.Padding(2, 2, 8, 2)
        Me.btnFixed.Name = "btnFixed"
        Me.btnFixed.Size = New System.Drawing.Size(18, 20)
        Me.btnFixed.TabIndex = 681
        Me.btnFixed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFixed.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label14.Location = New System.Drawing.Point(337, 20)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 16)
        Me.Label14.TabIndex = 677
        Me.Label14.Text = "Bracket :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label13.Location = New System.Drawing.Point(230, 20)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 16)
        Me.Label13.TabIndex = 680
        Me.Label13.Text = "Fixed :"
        '
        'cboOperator
        '
        Me.cboOperator.FormattingEnabled = True
        Me.cboOperator.Items.AddRange(New Object() {"+", "-", "*", "/"})
        Me.cboOperator.Location = New System.Drawing.Point(124, 38)
        Me.cboOperator.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboOperator.Name = "cboOperator"
        Me.cboOperator.Size = New System.Drawing.Size(76, 24)
        Me.cboOperator.TabIndex = 679
        '
        'btnOperator
        '
        Me.btnOperator.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnOperator.FlatAppearance.BorderSize = 0
        Me.btnOperator.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOperator.ForeColor = System.Drawing.Color.White
        Me.btnOperator.IconChar = FontAwesome.Sharp.IconChar.Add
        Me.btnOperator.IconColor = System.Drawing.Color.White
        Me.btnOperator.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnOperator.IconSize = 24
        Me.btnOperator.Location = New System.Drawing.Point(204, 38)
        Me.btnOperator.Margin = New System.Windows.Forms.Padding(2, 2, 8, 2)
        Me.btnOperator.Name = "btnOperator"
        Me.btnOperator.Size = New System.Drawing.Size(18, 20)
        Me.btnOperator.TabIndex = 678
        Me.btnOperator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOperator.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label10.Location = New System.Drawing.Point(122, 20)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 16)
        Me.Label10.TabIndex = 677
        Me.Label10.Text = "Operator :"
        '
        'cboInternal
        '
        Me.cboInternal.FormattingEnabled = True
        Me.cboInternal.Items.AddRange(New Object() {"ALLHRS", "REGHRS", "RSTHRS", "LEGHRS", "SPCHRS", "CMPHRS", "LEGRST", "SPCRST", "CMPRST", "FSHIFT", "CTOFDAYS", "REGDAYS", "RSTDAYS", "LEGDAYS", "SPCDAYS", "CMPDAYS", "LEGRSTDAYS", "SPCRSTDAYS", "CMPRSTDAYS", "DAILYATTEND", "LWPAY", "DWRK+HOLIDAY-ABS", "REGHRS-ABS", "BASIC", "ACTUALBASIC", "DWRK+HOLIDAY", "DWRK+HOLIDAY-(ABS+LV)", "DWRK+HOLIDAY-LEAVE", "DAYSABSENT+LV", "DAYSABSENT-HALFDAY_LV", "DAYSABSENT", "MINSABSENT", "ATTDAYS", "OTDAYS", "ABSHRS", "CUTOFFDAYS", "DWRK+LGLHOL-ABS"})
        Me.cboInternal.Location = New System.Drawing.Point(17, 37)
        Me.cboInternal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboInternal.Name = "cboInternal"
        Me.cboInternal.Size = New System.Drawing.Size(76, 24)
        Me.cboInternal.TabIndex = 676
        '
        'btnInternal
        '
        Me.btnInternal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnInternal.FlatAppearance.BorderSize = 0
        Me.btnInternal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInternal.ForeColor = System.Drawing.Color.White
        Me.btnInternal.IconChar = FontAwesome.Sharp.IconChar.Add
        Me.btnInternal.IconColor = System.Drawing.Color.White
        Me.btnInternal.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnInternal.IconSize = 24
        Me.btnInternal.Location = New System.Drawing.Point(97, 38)
        Me.btnInternal.Margin = New System.Windows.Forms.Padding(2, 2, 8, 2)
        Me.btnInternal.Name = "btnInternal"
        Me.btnInternal.Size = New System.Drawing.Size(18, 20)
        Me.btnInternal.TabIndex = 675
        Me.btnInternal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnInternal.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label8.Location = New System.Drawing.Point(15, 20)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 16)
        Me.Label8.TabIndex = 673
        Me.Label8.Text = "Internal :"
        '
        'chkFormulated
        '
        Me.chkFormulated.AutoSize = True
        Me.chkFormulated.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFormulated.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkFormulated.Location = New System.Drawing.Point(0, 0)
        Me.chkFormulated.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkFormulated.Name = "chkFormulated"
        Me.chkFormulated.Size = New System.Drawing.Size(18, 17)
        Me.chkFormulated.TabIndex = 673
        Me.chkFormulated.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnAdd.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnAdd.BorderRadius = 0
        Me.btnAdd.BorderSize = 0
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(279, 700)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(62, 24)
        Me.btnAdd.TabIndex = 676
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextColor = System.Drawing.Color.White
        Me.btnAdd.UseVisualStyleBackColor = False
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
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(411, 700)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(62, 24)
        Me.btnClose.TabIndex = 675
        Me.btnClose.Text = "Close"
        Me.btnClose.TextColor = System.Drawing.Color.White
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DimGray
        Me.btnClear.BackgroundColor = System.Drawing.Color.DimGray
        Me.btnClear.BorderColor = System.Drawing.Color.DimGray
        Me.btnClear.BorderRadius = 0
        Me.btnClear.BorderSize = 0
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(345, 700)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(62, 24)
        Me.btnClear.TabIndex = 674
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextColor = System.Drawing.Color.White
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateTool, Me.DeleteTool})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(126, 56)
        '
        'UpdateTool
        '
        Me.UpdateTool.Image = CType(resources.GetObject("UpdateTool.Image"), System.Drawing.Image)
        Me.UpdateTool.Name = "UpdateTool"
        Me.UpdateTool.Size = New System.Drawing.Size(125, 26)
        Me.UpdateTool.Text = "Update"
        '
        'DeleteTool
        '
        Me.DeleteTool.Image = CType(resources.GetObject("DeleteTool.Image"), System.Drawing.Image)
        Me.DeleteTool.Name = "DeleteTool"
        Me.DeleteTool.Size = New System.Drawing.Size(125, 26)
        Me.DeleteTool.Text = "Delete"
        '
        'frmEarningsConfiguration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(482, 730)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.chkAutomaticContraAcct)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkInclBadsedOn)
        Me.Controls.Add(Me.chkAutomaticGross)
        Me.Controls.Add(Me.chkIncludeAlphaListing)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.chkNonTaxable)
        Me.Controls.Add(Me.chkMonthly)
        Me.Controls.Add(Me.txtLrType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCeilingAmount)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtCeilingAmount)
        Me.Controls.Add(Me.txtIncomeCode)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lvEarningConfig)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTranType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkDeductible)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEarningsConfiguration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Other Earnings Configuration"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLrType As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCeilingAmount As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtCeilingAmount As TextBox
    Friend WithEvents txtIncomeCode As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents lvEarningConfig As NxnControls.NxNListview
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTranType As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chkDeductible As CheckBox
    Friend WithEvents chkMonthly As CheckBox
    Friend WithEvents chkNonTaxable As CheckBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents rbtnNormalPayroll As RadioButton
    Friend WithEvents rbtnSpecialPayroll As RadioButton
    Friend WithEvents chkIncludeAlphaListing As CheckBox
    Friend WithEvents chkAutomaticGross As CheckBox
    Friend WithEvents chkInclBadsedOn As CheckBox
    Friend WithEvents chkAutomaticContraAcct As CheckBox
    Friend WithEvents chkFormulated As CheckBox
    Friend WithEvents btnAdd As NxnControls.CustomControls.NxNControls.NxNButton
    Friend WithEvents btnClose As NxnControls.CustomControls.NxNControls.NxNButton
    Friend WithEvents btnClear As NxnControls.CustomControls.NxNControls.NxNButton
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents UpdateTool As ToolStripMenuItem
    Friend WithEvents DeleteTool As ToolStripMenuItem
    Friend WithEvents lblDisplay As Label
    Friend WithEvents btnClearDisplay As NxnControls.CustomControls.NxNControls.NxNButton
    Friend WithEvents txtFixed As TextBox
    Friend WithEvents cboBracket As ComboBox
    Friend WithEvents btnBracket As FontAwesome.Sharp.IconButton
    Friend WithEvents btnFixed As FontAwesome.Sharp.IconButton
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cboOperator As ComboBox
    Friend WithEvents btnOperator As FontAwesome.Sharp.IconButton
    Friend WithEvents Label10 As Label
    Friend WithEvents cboInternal As ComboBox
    Friend WithEvents btnInternal As FontAwesome.Sharp.IconButton
    Friend WithEvents Label8 As Label
End Class
