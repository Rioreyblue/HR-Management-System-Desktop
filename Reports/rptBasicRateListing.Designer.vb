<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptBasicRateListing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptBasicRateListing))
        Me.lvEmployee = New NxnControls.NxNListview()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.rbtnDataReport = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboCompany = New NxnControls.NxNComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboDivision = New NxnControls.NxNComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboDepartment = New NxnControls.NxNComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboStatus = New NxnControls.NxNComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.chkParamDateHire = New System.Windows.Forms.CheckBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.dp2 = New System.Windows.Forms.DateTimePicker()
        Me.dpDateHireTo = New System.Windows.Forms.MaskedTextBox()
        Me.dp1 = New System.Windows.Forms.DateTimePicker()
        Me.dpDateHireFrom = New System.Windows.Forms.MaskedTextBox()
        Me.btnPrint = New FontAwesome.Sharp.IconButton()
        Me.btnClose = New NxnControls.CustomControls.NxNControls.NxNButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label28 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lvEmployee
        '
        Me.lvEmployee.CheckBoxes = True
        Me.lvEmployee.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvEmployee.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvEmployee.FullRowSelect = True
        Me.lvEmployee.HideSelection = False
        Me.lvEmployee.isCheckedAll = False
        Me.lvEmployee.itemTrigger = Nothing
        Me.lvEmployee.Location = New System.Drawing.Point(6, 155)
        Me.lvEmployee.Name = "lvEmployee"
        Me.lvEmployee.OwnerDraw = True
        Me.lvEmployee.Size = New System.Drawing.Size(455, 500)
        Me.lvEmployee.TabIndex = 518
        Me.lvEmployee.UseCompatibleStateImageBehavior = False
        Me.lvEmployee.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "   ID Number"
        Me.ColumnHeader3.Width = 169
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Name"
        Me.ColumnHeader4.Width = 253
        '
        'rbtnDataReport
        '
        Me.rbtnDataReport.AutoSize = True
        Me.rbtnDataReport.Checked = True
        Me.rbtnDataReport.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnDataReport.ForeColor = System.Drawing.Color.Navy
        Me.rbtnDataReport.Location = New System.Drawing.Point(6, 666)
        Me.rbtnDataReport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnDataReport.Name = "rbtnDataReport"
        Me.rbtnDataReport.Size = New System.Drawing.Size(114, 20)
        Me.rbtnDataReport.TabIndex = 529
        Me.rbtnDataReport.TabStop = True
        Me.rbtnDataReport.Text = "Data Report"
        Me.rbtnDataReport.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.Maroon
        Me.RadioButton2.Location = New System.Drawing.Point(126, 666)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(122, 20)
        Me.RadioButton2.TabIndex = 530
        Me.RadioButton2.Text = "Excel (XLSX)"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label9.Location = New System.Drawing.Point(3, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 16)
        Me.Label9.TabIndex = 531
        Me.Label9.Text = "Company"
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
        Me.cboCompany.Location = New System.Drawing.Point(177, 6)
        Me.cboCompany.Name = "cboCompany"
        StringFormat1.Alignment = System.Drawing.StringAlignment.Near
        StringFormat1.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None
        StringFormat1.LineAlignment = System.Drawing.StringAlignment.Near
        StringFormat1.Trimming = System.Drawing.StringTrimming.Character
        Me.cboCompany.SetTextFormat = StringFormat1
        Me.cboCompany.Size = New System.Drawing.Size(204, 24)
        Me.cboCompany.TabIndex = 533
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label2.Location = New System.Drawing.Point(159, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 16)
        Me.Label2.TabIndex = 532
        Me.Label2.Text = ":"
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
        Me.cboDivision.IntegralHeight = False
        Me.cboDivision.Location = New System.Drawing.Point(177, 36)
        Me.cboDivision.Name = "cboDivision"
        StringFormat2.Alignment = System.Drawing.StringAlignment.Near
        StringFormat2.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None
        StringFormat2.LineAlignment = System.Drawing.StringAlignment.Near
        StringFormat2.Trimming = System.Drawing.StringTrimming.Character
        Me.cboDivision.SetTextFormat = StringFormat2
        Me.cboDivision.Size = New System.Drawing.Size(204, 24)
        Me.cboDivision.TabIndex = 536
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label4.Location = New System.Drawing.Point(159, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 16)
        Me.Label4.TabIndex = 535
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label5.Location = New System.Drawing.Point(3, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 534
        Me.Label5.Text = "Division"
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
        Me.cboDepartment.IntegralHeight = False
        Me.cboDepartment.Location = New System.Drawing.Point(177, 66)
        Me.cboDepartment.Name = "cboDepartment"
        StringFormat3.Alignment = System.Drawing.StringAlignment.Near
        StringFormat3.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None
        StringFormat3.LineAlignment = System.Drawing.StringAlignment.Near
        StringFormat3.Trimming = System.Drawing.StringTrimming.Character
        Me.cboDepartment.SetTextFormat = StringFormat3
        Me.cboDepartment.Size = New System.Drawing.Size(204, 24)
        Me.cboDepartment.TabIndex = 539
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label11.Location = New System.Drawing.Point(159, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(12, 16)
        Me.Label11.TabIndex = 538
        Me.Label11.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label12.Location = New System.Drawing.Point(3, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 16)
        Me.Label12.TabIndex = 537
        Me.Label12.Text = "Department"
        '
        'cboStatus
        '
        Me.cboStatus.BackColor = System.Drawing.Color.White
        Me.cboStatus.ColumnNum = 0
        Me.cboStatus.ColumnWidth = Nothing
        Me.cboStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboStatus.DropDownSize = 0
        Me.cboStatus.drview = Nothing
        Me.cboStatus.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.IntegralHeight = False
        Me.cboStatus.Location = New System.Drawing.Point(177, 96)
        Me.cboStatus.Name = "cboStatus"
        StringFormat4.Alignment = System.Drawing.StringAlignment.Near
        StringFormat4.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None
        StringFormat4.LineAlignment = System.Drawing.StringAlignment.Near
        StringFormat4.Trimming = System.Drawing.StringTrimming.Character
        Me.cboStatus.SetTextFormat = StringFormat4
        Me.cboStatus.Size = New System.Drawing.Size(204, 24)
        Me.cboStatus.TabIndex = 542
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label23.Location = New System.Drawing.Point(159, 99)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(12, 16)
        Me.Label23.TabIndex = 541
        Me.Label23.Text = ":"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label24.Location = New System.Drawing.Point(3, 99)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(130, 16)
        Me.Label24.TabIndex = 540
        Me.Label24.Text = "Employee Status"
        '
        'chkParamDateHire
        '
        Me.chkParamDateHire.AutoSize = True
        Me.chkParamDateHire.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkParamDateHire.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkParamDateHire.Location = New System.Drawing.Point(6, 129)
        Me.chkParamDateHire.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkParamDateHire.Name = "chkParamDateHire"
        Me.chkParamDateHire.Size = New System.Drawing.Size(97, 20)
        Me.chkParamDateHire.TabIndex = 578
        Me.chkParamDateHire.Text = "Date Hire"
        Me.chkParamDateHire.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label35.Location = New System.Drawing.Point(159, 130)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(12, 16)
        Me.Label35.TabIndex = 577
        Me.Label35.Text = ":"
        '
        'dp2
        '
        Me.dp2.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dp2.Location = New System.Drawing.Point(413, 126)
        Me.dp2.Name = "dp2"
        Me.dp2.Size = New System.Drawing.Size(20, 23)
        Me.dp2.TabIndex = 576
        '
        'dpDateHireTo
        '
        Me.dpDateHireTo.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpDateHireTo.Location = New System.Drawing.Point(318, 126)
        Me.dpDateHireTo.Mask = "00/00/0000"
        Me.dpDateHireTo.Name = "dpDateHireTo"
        Me.dpDateHireTo.Size = New System.Drawing.Size(115, 23)
        Me.dpDateHireTo.TabIndex = 575
        Me.dpDateHireTo.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.dpDateHireTo.ValidatingType = GetType(Date)
        '
        'dp1
        '
        Me.dp1.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dp1.Location = New System.Drawing.Point(272, 126)
        Me.dp1.Name = "dp1"
        Me.dp1.Size = New System.Drawing.Size(20, 23)
        Me.dp1.TabIndex = 574
        '
        'dpDateHireFrom
        '
        Me.dpDateHireFrom.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpDateHireFrom.Location = New System.Drawing.Point(177, 126)
        Me.dpDateHireFrom.Mask = "00/00/0000"
        Me.dpDateHireFrom.Name = "dpDateHireFrom"
        Me.dpDateHireFrom.Size = New System.Drawing.Size(115, 23)
        Me.dpDateHireFrom.TabIndex = 573
        Me.dpDateHireFrom.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.dpDateHireFrom.ValidatingType = GetType(Date)
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.btnPrint.IconColor = System.Drawing.Color.White
        Me.btnPrint.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPrint.IconSize = 24
        Me.btnPrint.Location = New System.Drawing.Point(272, 661)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(101, 30)
        Me.btnPrint.TabIndex = 580
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
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(379, 661)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(82, 30)
        Me.btnClose.TabIndex = 579
        Me.btnClose.Text = "Close"
        Me.btnClose.TextColor = System.Drawing.Color.White
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 8
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label28.Location = New System.Drawing.Point(298, 130)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(14, 16)
        Me.Label28.TabIndex = 582
        Me.Label28.Text = "-"
        '
        'rptBasicRateListing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(467, 703)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.dp1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.chkParamDateHire)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.dp2)
        Me.Controls.Add(Me.dpDateHireTo)
        Me.Controls.Add(Me.dpDateHireFrom)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.cboDepartment)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cboDivision)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboCompany)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.rbtnDataReport)
        Me.Controls.Add(Me.lvEmployee)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rptBasicRateListing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Basic Rate Listing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvEmployee As NxnControls.NxNListview
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents rbtnDataReport As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents cboCompany As NxnControls.NxNComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboDivision As NxnControls.NxNComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboDepartment As NxnControls.NxNComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cboStatus As NxnControls.NxNComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents chkParamDateHire As CheckBox
    Friend WithEvents Label35 As Label
    Friend WithEvents dp2 As DateTimePicker
    Friend WithEvents dpDateHireTo As MaskedTextBox
    Friend WithEvents dp1 As DateTimePicker
    Friend WithEvents dpDateHireFrom As MaskedTextBox
    Friend WithEvents btnPrint As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClose As NxnControls.CustomControls.NxNControls.NxNButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label28 As Label
End Class
