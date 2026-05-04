<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeductionConfigurations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeductionConfigurations))
        Me.chkNonTaxable = New System.Windows.Forms.CheckBox()
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
        Me.chkDeduction = New System.Windows.Forms.CheckBox()
        Me.txtLrType = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtDdctCode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvDeductionConfig = New NxnControls.NxNListview()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTranType = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkPlottedDeduction = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkBanking = New System.Windows.Forms.CheckBox()
        Me.txtGLAccount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkNonTaxable
        '
        Me.chkNonTaxable.AutoSize = True
        Me.chkNonTaxable.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNonTaxable.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkNonTaxable.Location = New System.Drawing.Point(299, 7)
        Me.chkNonTaxable.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkNonTaxable.Name = "chkNonTaxable"
        Me.chkNonTaxable.Size = New System.Drawing.Size(121, 20)
        Me.chkNonTaxable.TabIndex = 692
        Me.chkNonTaxable.Text = "Non-Taxable"
        Me.chkNonTaxable.UseVisualStyleBackColor = True
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
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GroupBox1.Location = New System.Drawing.Point(177, 124)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(591, 113)
        Me.GroupBox1.TabIndex = 696
        Me.GroupBox1.TabStop = False
        '
        'lblDisplay
        '
        Me.lblDisplay.BackColor = System.Drawing.Color.Blue
        Me.lblDisplay.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.ForeColor = System.Drawing.Color.White
        Me.lblDisplay.Location = New System.Drawing.Point(16, 73)
        Me.lblDisplay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(493, 25)
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
        Me.btnClearDisplay.Location = New System.Drawing.Point(516, 73)
        Me.btnClearDisplay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClearDisplay.Name = "btnClearDisplay"
        Me.btnClearDisplay.Size = New System.Drawing.Size(59, 25)
        Me.btnClearDisplay.TabIndex = 673
        Me.btnClearDisplay.Text = "Clear"
        Me.btnClearDisplay.TextColor = System.Drawing.Color.White
        Me.btnClearDisplay.UseVisualStyleBackColor = False
        '
        'txtFixed
        '
        Me.txtFixed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFixed.Location = New System.Drawing.Point(301, 46)
        Me.txtFixed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFixed.Name = "txtFixed"
        Me.txtFixed.Size = New System.Drawing.Size(101, 22)
        Me.txtFixed.TabIndex = 673
        '
        'cboBracket
        '
        Me.cboBracket.FormattingEnabled = True
        Me.cboBracket.Items.AddRange(New Object() {"'('", "')'"})
        Me.cboBracket.Location = New System.Drawing.Point(445, 43)
        Me.cboBracket.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboBracket.Name = "cboBracket"
        Me.cboBracket.Size = New System.Drawing.Size(100, 24)
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
        Me.btnBracket.Location = New System.Drawing.Point(551, 42)
        Me.btnBracket.Margin = New System.Windows.Forms.Padding(3, 2, 11, 2)
        Me.btnBracket.Name = "btnBracket"
        Me.btnBracket.Size = New System.Drawing.Size(24, 25)
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
        Me.btnFixed.Location = New System.Drawing.Point(408, 43)
        Me.btnFixed.Margin = New System.Windows.Forms.Padding(3, 2, 11, 2)
        Me.btnFixed.Name = "btnFixed"
        Me.btnFixed.Size = New System.Drawing.Size(24, 25)
        Me.btnFixed.TabIndex = 681
        Me.btnFixed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFixed.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label14.Location = New System.Drawing.Point(443, 20)
        Me.Label14.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.Label13.Location = New System.Drawing.Point(299, 20)
        Me.Label13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 16)
        Me.Label13.TabIndex = 680
        Me.Label13.Text = "Fixed :"
        '
        'cboOperator
        '
        Me.cboOperator.FormattingEnabled = True
        Me.cboOperator.Items.AddRange(New Object() {"+", "-", "*", "/"})
        Me.cboOperator.Location = New System.Drawing.Point(159, 43)
        Me.cboOperator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboOperator.Name = "cboOperator"
        Me.cboOperator.Size = New System.Drawing.Size(100, 24)
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
        Me.btnOperator.Location = New System.Drawing.Point(265, 43)
        Me.btnOperator.Margin = New System.Windows.Forms.Padding(3, 2, 11, 2)
        Me.btnOperator.Name = "btnOperator"
        Me.btnOperator.Size = New System.Drawing.Size(24, 25)
        Me.btnOperator.TabIndex = 678
        Me.btnOperator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOperator.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label10.Location = New System.Drawing.Point(156, 21)
        Me.Label10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 16)
        Me.Label10.TabIndex = 677
        Me.Label10.Text = "Operator :"
        '
        'cboInternal
        '
        Me.cboInternal.FormattingEnabled = True
        Me.cboInternal.Items.AddRange(New Object() {"BASIC", "ACTUALBASIC", "GROSSPAY", "MRATE", "TAXGROSS", "DAILYATTEND", "LATEMINS", "NUMBDAYS", "PERHOUR", "GROSS ALL"})
        Me.cboInternal.Location = New System.Drawing.Point(16, 42)
        Me.cboInternal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboInternal.Name = "cboInternal"
        Me.cboInternal.Size = New System.Drawing.Size(100, 24)
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
        Me.btnInternal.Location = New System.Drawing.Point(123, 43)
        Me.btnInternal.Margin = New System.Windows.Forms.Padding(3, 2, 11, 2)
        Me.btnInternal.Name = "btnInternal"
        Me.btnInternal.Size = New System.Drawing.Size(24, 25)
        Me.btnInternal.TabIndex = 675
        Me.btnInternal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnInternal.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label8.Location = New System.Drawing.Point(13, 20)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.chkFormulated.Location = New System.Drawing.Point(5, 129)
        Me.chkFormulated.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.btnAdd.Location = New System.Drawing.Point(509, 777)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(83, 30)
        Me.btnAdd.TabIndex = 701
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
        Me.btnClose.Location = New System.Drawing.Point(685, 777)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(83, 30)
        Me.btnClose.TabIndex = 700
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
        Me.btnClear.Location = New System.Drawing.Point(597, 777)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(83, 30)
        Me.btnClear.TabIndex = 699
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
        'chkDeduction
        '
        Me.chkDeduction.AutoSize = True
        Me.chkDeduction.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDeduction.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkDeduction.Location = New System.Drawing.Point(603, 7)
        Me.chkDeduction.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkDeduction.Name = "chkDeduction"
        Me.chkDeduction.Size = New System.Drawing.Size(166, 20)
        Me.chkDeduction.TabIndex = 691
        Me.chkDeduction.Text = "Deduct to Gross All"
        Me.chkDeduction.UseVisualStyleBackColor = True
        '
        'txtLrType
        '
        Me.txtLrType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLrType.Location = New System.Drawing.Point(177, 96)
        Me.txtLrType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLrType.Name = "txtLrType"
        Me.txtLrType.Size = New System.Drawing.Size(199, 22)
        Me.txtLrType.TabIndex = 690
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label1.Location = New System.Drawing.Point(159, 98)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 16)
        Me.Label1.TabIndex = 689
        Me.Label1.Text = ":"
        '
        'txtDescription
        '
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.Location = New System.Drawing.Point(177, 34)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(591, 56)
        Me.txtDescription.TabIndex = 687
        '
        'txtDdctCode
        '
        Me.txtDdctCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDdctCode.Location = New System.Drawing.Point(177, 6)
        Me.txtDdctCode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDdctCode.Name = "txtDdctCode"
        Me.txtDdctCode.Size = New System.Drawing.Size(110, 22)
        Me.txtDdctCode.TabIndex = 685
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label9.Location = New System.Drawing.Point(3, 9)
        Me.Label9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 16)
        Me.Label9.TabIndex = 678
        Me.Label9.Text = "DdctCode"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Non-Taxable"
        Me.ColumnHeader1.Width = 120
        '
        'lvDeductionConfig
        '
        Me.lvDeductionConfig.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader7, Me.ColumnHeader10})
        Me.lvDeductionConfig.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvDeductionConfig.FullRowSelect = True
        Me.lvDeductionConfig.HideSelection = False
        Me.lvDeductionConfig.isCheckedAll = False
        Me.lvDeductionConfig.itemTrigger = Nothing
        Me.lvDeductionConfig.Location = New System.Drawing.Point(5, 271)
        Me.lvDeductionConfig.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lvDeductionConfig.Name = "lvDeductionConfig"
        Me.lvDeductionConfig.OwnerDraw = True
        Me.lvDeductionConfig.Size = New System.Drawing.Size(761, 500)
        Me.lvDeductionConfig.TabIndex = 677
        Me.lvDeductionConfig.UseCompatibleStateImageBehavior = False
        Me.lvDeductionConfig.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "DdctCode"
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
        Me.ColumnHeader5.Width = 150
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "For Banking"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Gl Account #"
        Me.ColumnHeader8.Width = 150
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Plotted Deductions"
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Tran Type"
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Deduct To Gross All"
        Me.ColumnHeader10.Width = 200
        '
        'Timer1
        '
        Me.Timer1.Interval = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label12.Location = New System.Drawing.Point(3, 39)
        Me.Label12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 16)
        Me.Label12.TabIndex = 682
        Me.Label12.Text = "Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label4.Location = New System.Drawing.Point(159, 39)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 16)
        Me.Label4.TabIndex = 681
        Me.Label4.Text = ":"
        '
        'lblTranType
        '
        Me.lblTranType.AutoSize = True
        Me.lblTranType.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTranType.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblTranType.Location = New System.Drawing.Point(3, 98)
        Me.lblTranType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblTranType.Name = "lblTranType"
        Me.lblTranType.Size = New System.Drawing.Size(78, 16)
        Me.lblTranType.TabIndex = 680
        Me.lblTranType.Text = "Tran Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label2.Location = New System.Drawing.Point(159, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 16)
        Me.Label2.TabIndex = 679
        Me.Label2.Text = ":"
        '
        'chkPlottedDeduction
        '
        Me.chkPlottedDeduction.AutoSize = True
        Me.chkPlottedDeduction.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPlottedDeduction.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkPlottedDeduction.Location = New System.Drawing.Point(427, 7)
        Me.chkPlottedDeduction.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkPlottedDeduction.Name = "chkPlottedDeduction"
        Me.chkPlottedDeduction.Size = New System.Drawing.Size(166, 20)
        Me.chkPlottedDeduction.TabIndex = 684
        Me.chkPlottedDeduction.Text = "Plotted Deductions"
        Me.chkPlottedDeduction.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label3.Location = New System.Drawing.Point(29, 130)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 702
        Me.Label3.Text = "Formulated"
        '
        'chkBanking
        '
        Me.chkBanking.AutoSize = True
        Me.chkBanking.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBanking.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkBanking.Location = New System.Drawing.Point(5, 245)
        Me.chkBanking.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkBanking.Name = "chkBanking"
        Me.chkBanking.Size = New System.Drawing.Size(115, 20)
        Me.chkBanking.TabIndex = 703
        Me.chkBanking.Text = "For Banking"
        Me.chkBanking.UseVisualStyleBackColor = True
        '
        'txtGLAccount
        '
        Me.txtGLAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGLAccount.Location = New System.Drawing.Point(352, 242)
        Me.txtGLAccount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtGLAccount.Name = "txtGLAccount"
        Me.txtGLAccount.Size = New System.Drawing.Size(415, 22)
        Me.txtGLAccount.TabIndex = 706
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label5.Location = New System.Drawing.Point(333, 245)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 16)
        Me.Label5.TabIndex = 705
        Me.Label5.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label6.Location = New System.Drawing.Point(179, 245)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 16)
        Me.Label6.TabIndex = 704
        Me.Label6.Text = "GL Account #"
        '
        'frmDeductionConfigurations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(779, 818)
        Me.Controls.Add(Me.txtGLAccount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chkBanking)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkNonTaxable)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.chkDeduction)
        Me.Controls.Add(Me.txtLrType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtDdctCode)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lvDeductionConfig)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.chkFormulated)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTranType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkPlottedDeduction)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDeductionConfigurations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deduction Configurations"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkNonTaxable As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
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
    Friend WithEvents chkFormulated As CheckBox
    Friend WithEvents btnAdd As NxnControls.CustomControls.NxNControls.NxNButton
    Friend WithEvents btnClose As NxnControls.CustomControls.NxNControls.NxNButton
    Friend WithEvents btnClear As NxnControls.CustomControls.NxNControls.NxNButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents UpdateTool As ToolStripMenuItem
    Friend WithEvents DeleteTool As ToolStripMenuItem
    Friend WithEvents chkDeduction As CheckBox
    Friend WithEvents txtLrType As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtDdctCode As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents lvDeductionConfig As NxnControls.NxNListview
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label12 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTranType As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chkPlottedDeduction As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chkBanking As CheckBox
    Friend WithEvents txtGLAccount As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
End Class
