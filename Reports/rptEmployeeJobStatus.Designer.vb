<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptEmployeeJobStatus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptEmployeeJobStatus))
        Me.cboCompany = New NxnControls.NxNComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboStatus = New NxnControls.NxNComboBox()
        Me.lblJobStatus = New System.Windows.Forms.Label()
        Me.lvEmployee = New NxnControls.NxNListview()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvDivision = New NxnControls.NxNListview()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.rbtnDataReport = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.dp1 = New System.Windows.Forms.DateTimePicker()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.dp2 = New System.Windows.Forms.DateTimePicker()
        Me.dpDateTo = New System.Windows.Forms.MaskedTextBox()
        Me.dpDateFrom = New System.Windows.Forms.MaskedTextBox()
        Me.btnPrint = New FontAwesome.Sharp.IconButton()
        Me.btnClose = New NxnControls.CustomControls.NxNControls.NxNButton()
        Me.chkJobStatusDate = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
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
        Me.cboCompany.Size = New System.Drawing.Size(256, 24)
        Me.cboCompany.TabIndex = 519
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label9.Location = New System.Drawing.Point(3, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 16)
        Me.Label9.TabIndex = 517
        Me.Label9.Text = "Company"
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
        Me.cboStatus.Location = New System.Drawing.Point(177, 36)
        Me.cboStatus.Name = "cboStatus"
        StringFormat2.Alignment = System.Drawing.StringAlignment.Near
        StringFormat2.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None
        StringFormat2.LineAlignment = System.Drawing.StringAlignment.Near
        StringFormat2.Trimming = System.Drawing.StringTrimming.Character
        Me.cboStatus.SetTextFormat = StringFormat2
        Me.cboStatus.Size = New System.Drawing.Size(256, 24)
        Me.cboStatus.TabIndex = 588
        '
        'lblJobStatus
        '
        Me.lblJobStatus.AutoSize = True
        Me.lblJobStatus.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobStatus.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblJobStatus.Location = New System.Drawing.Point(3, 39)
        Me.lblJobStatus.Name = "lblJobStatus"
        Me.lblJobStatus.Size = New System.Drawing.Size(83, 16)
        Me.lblJobStatus.TabIndex = 589
        Me.lblJobStatus.Text = "Job Status"
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
        Me.lvEmployee.Location = New System.Drawing.Point(384, 95)
        Me.lvEmployee.Name = "lvEmployee"
        Me.lvEmployee.OwnerDraw = True
        Me.lvEmployee.Size = New System.Drawing.Size(385, 520)
        Me.lvEmployee.TabIndex = 590
        Me.lvEmployee.UseCompatibleStateImageBehavior = False
        Me.lvEmployee.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ID Number"
        Me.ColumnHeader3.Width = 112
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Name"
        Me.ColumnHeader4.Width = 253
        '
        'lvDivision
        '
        Me.lvDivision.CheckBoxes = True
        Me.lvDivision.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvDivision.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvDivision.FullRowSelect = True
        Me.lvDivision.HideSelection = False
        Me.lvDivision.isCheckedAll = False
        Me.lvDivision.itemTrigger = Nothing
        Me.lvDivision.Location = New System.Drawing.Point(6, 95)
        Me.lvDivision.Name = "lvDivision"
        Me.lvDivision.OwnerDraw = True
        Me.lvDivision.Size = New System.Drawing.Size(372, 520)
        Me.lvDivision.TabIndex = 597
        Me.lvDivision.UseCompatibleStateImageBehavior = False
        Me.lvDivision.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Code"
        Me.ColumnHeader1.Width = 108
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Division Name"
        Me.ColumnHeader2.Width = 254
        '
        'Timer1
        '
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.Maroon
        Me.RadioButton2.Location = New System.Drawing.Point(126, 626)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(122, 20)
        Me.RadioButton2.TabIndex = 601
        Me.RadioButton2.Text = "Excel (XLSX)"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'rbtnDataReport
        '
        Me.rbtnDataReport.AutoSize = True
        Me.rbtnDataReport.Checked = True
        Me.rbtnDataReport.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnDataReport.ForeColor = System.Drawing.Color.Navy
        Me.rbtnDataReport.Location = New System.Drawing.Point(6, 626)
        Me.rbtnDataReport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnDataReport.Name = "rbtnDataReport"
        Me.rbtnDataReport.Size = New System.Drawing.Size(114, 20)
        Me.rbtnDataReport.TabIndex = 600
        Me.rbtnDataReport.TabStop = True
        Me.rbtnDataReport.Text = "Data Report"
        Me.rbtnDataReport.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label4.Location = New System.Drawing.Point(159, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 16)
        Me.Label4.TabIndex = 603
        Me.Label4.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label2.Location = New System.Drawing.Point(159, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 16)
        Me.Label2.TabIndex = 602
        Me.Label2.Text = ":"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label28.Location = New System.Drawing.Point(298, 70)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(14, 16)
        Me.Label28.TabIndex = 609
        Me.Label28.Text = "-"
        '
        'dp1
        '
        Me.dp1.Enabled = False
        Me.dp1.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dp1.Location = New System.Drawing.Point(272, 66)
        Me.dp1.Name = "dp1"
        Me.dp1.Size = New System.Drawing.Size(20, 23)
        Me.dp1.TabIndex = 605
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label35.Location = New System.Drawing.Point(159, 70)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(12, 16)
        Me.Label35.TabIndex = 608
        Me.Label35.Text = ":"
        '
        'dp2
        '
        Me.dp2.Enabled = False
        Me.dp2.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dp2.Location = New System.Drawing.Point(413, 66)
        Me.dp2.Name = "dp2"
        Me.dp2.Size = New System.Drawing.Size(20, 23)
        Me.dp2.TabIndex = 607
        '
        'dpDateTo
        '
        Me.dpDateTo.Enabled = False
        Me.dpDateTo.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpDateTo.Location = New System.Drawing.Point(318, 66)
        Me.dpDateTo.Mask = "00/00/0000"
        Me.dpDateTo.Name = "dpDateTo"
        Me.dpDateTo.Size = New System.Drawing.Size(115, 23)
        Me.dpDateTo.TabIndex = 606
        Me.dpDateTo.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.dpDateTo.ValidatingType = GetType(Date)
        '
        'dpDateFrom
        '
        Me.dpDateFrom.Enabled = False
        Me.dpDateFrom.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpDateFrom.Location = New System.Drawing.Point(177, 66)
        Me.dpDateFrom.Mask = "00/00/0000"
        Me.dpDateFrom.Name = "dpDateFrom"
        Me.dpDateFrom.Size = New System.Drawing.Size(115, 23)
        Me.dpDateFrom.TabIndex = 604
        Me.dpDateFrom.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.dpDateFrom.ValidatingType = GetType(Date)
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
        Me.btnPrint.Location = New System.Drawing.Point(580, 621)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(101, 30)
        Me.btnPrint.TabIndex = 611
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
        Me.btnClose.Location = New System.Drawing.Point(687, 621)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(82, 30)
        Me.btnClose.TabIndex = 610
        Me.btnClose.Text = "Close"
        Me.btnClose.TextColor = System.Drawing.Color.White
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'chkJobStatusDate
        '
        Me.chkJobStatusDate.AutoSize = True
        Me.chkJobStatusDate.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkJobStatusDate.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkJobStatusDate.Location = New System.Drawing.Point(6, 70)
        Me.chkJobStatusDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkJobStatusDate.Name = "chkJobStatusDate"
        Me.chkJobStatusDate.Size = New System.Drawing.Size(143, 20)
        Me.chkJobStatusDate.TabIndex = 612
        Me.chkJobStatusDate.Text = "Job Status Date"
        Me.chkJobStatusDate.UseVisualStyleBackColor = True
        '
        'rptEmployeeJobStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(780, 660)
        Me.Controls.Add(Me.chkJobStatusDate)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.dp1)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.dp2)
        Me.Controls.Add(Me.dpDateTo)
        Me.Controls.Add(Me.dpDateFrom)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.rbtnDataReport)
        Me.Controls.Add(Me.lvDivision)
        Me.Controls.Add(Me.lvEmployee)
        Me.Controls.Add(Me.lblJobStatus)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.cboCompany)
        Me.Controls.Add(Me.Label9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rptEmployeeJobStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Job Status"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboCompany As NxnControls.NxNComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cboStatus As NxnControls.NxNComboBox
    Friend WithEvents lblJobStatus As Label
    Friend WithEvents lvEmployee As NxnControls.NxNListview
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents lvDivision As NxnControls.NxNListview
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Timer1 As Timer
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents rbtnDataReport As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents dp1 As DateTimePicker
    Friend WithEvents Label35 As Label
    Friend WithEvents dp2 As DateTimePicker
    Friend WithEvents dpDateTo As MaskedTextBox
    Friend WithEvents dpDateFrom As MaskedTextBox
    Friend WithEvents btnPrint As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClose As NxnControls.CustomControls.NxNControls.NxNButton
    Friend WithEvents chkJobStatusDate As CheckBox
End Class
