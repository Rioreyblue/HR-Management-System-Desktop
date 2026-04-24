<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApplicantExamination
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
        Dim StringFormat19 As System.Drawing.StringFormat = New System.Drawing.StringFormat()
        Dim StringFormat20 As System.Drawing.StringFormat = New System.Drawing.StringFormat()
        Dim StringFormat17 As System.Drawing.StringFormat = New System.Drawing.StringFormat()
        Dim StringFormat18 As System.Drawing.StringFormat = New System.Drawing.StringFormat()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmApplicantExamination))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtRate = New NxnControls.NxNNumericTextbox()
        Me.txtScore = New NxnControls.NxNNumericTextbox()
        Me.btnResched = New FontAwesome.Sharp.IconButton()
        Me.btnClear = New FontAwesome.Sharp.IconButton()
        Me.btnSave = New FontAwesome.Sharp.IconButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.cboExamBatchNo1 = New NxnControls.NxNComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtResched2 = New System.Windows.Forms.DateTimePicker()
        Me.dtResched1 = New System.Windows.Forms.DateTimePicker()
        Me.cboExam = New NxnControls.NxNComboBox()
        Me.chkResched = New System.Windows.Forms.CheckBox()
        Me.lvApplicantExamination = New NxnControls.NxNListview()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtAnswered = New System.Windows.Forms.DateTimePicker()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.dtOpen2 = New System.Windows.Forms.DateTimePicker()
        Me.dtOpen1 = New System.Windows.Forms.DateTimePicker()
        Me.cboExamBatchNo = New NxnControls.NxNComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lvApplicant = New NxnControls.NxNListview()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtAssesment = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboJob = New NxnControls.NxNComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UpdateTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.lblName)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(20, 20)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1277, 71)
        Me.Panel2.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label6.Location = New System.Drawing.Point(3, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(494, 36)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "A descriptive writing assessment designed to evaluate a candidate's critical thin" &
    "king,communication skills, and subject matter depth."
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(0, 12)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(264, 25)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Applicant Examination"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtRate)
        Me.Panel1.Controls.Add(Me.txtScore)
        Me.Panel1.Controls.Add(Me.btnResched)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.lvApplicantExamination)
        Me.Panel1.Controls.Add(Me.txtRemarks)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.dtAnswered)
        Me.Panel1.Controls.Add(Me.Label29)
        Me.Panel1.Controls.Add(Me.Label30)
        Me.Panel1.Controls.Add(Me.Label28)
        Me.Panel1.Controls.Add(Me.dtOpen2)
        Me.Panel1.Controls.Add(Me.dtOpen1)
        Me.Panel1.Controls.Add(Me.cboExamBatchNo)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.lvApplicant)
        Me.Panel1.Controls.Add(Me.txtAssesment)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.cboJob)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(20, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1277, 731)
        Me.Panel1.TabIndex = 12
        '
        'txtRate
        '
        Me.txtRate.AllowDecimal = True
        Me.txtRate.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.Location = New System.Drawing.Point(907, 93)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(175, 23)
        Me.txtRate.TabIndex = 624
        '
        'txtScore
        '
        Me.txtScore.AllowDecimal = True
        Me.txtScore.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore.Location = New System.Drawing.Point(589, 93)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(175, 23)
        Me.txtScore.TabIndex = 623
        '
        'btnResched
        '
        Me.btnResched.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnResched.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btnResched.Enabled = False
        Me.btnResched.FlatAppearance.BorderSize = 0
        Me.btnResched.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResched.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResched.ForeColor = System.Drawing.Color.White
        Me.btnResched.IconChar = FontAwesome.Sharp.IconChar.Add
        Me.btnResched.IconColor = System.Drawing.Color.White
        Me.btnResched.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnResched.IconSize = 24
        Me.btnResched.Location = New System.Drawing.Point(439, 698)
        Me.btnResched.Margin = New System.Windows.Forms.Padding(2)
        Me.btnResched.Name = "btnResched"
        Me.btnResched.Size = New System.Drawing.Size(197, 30)
        Me.btnResched.TabIndex = 622
        Me.btnResched.Text = "Re-Schedule Exam"
        Me.btnResched.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnResched.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.IconChar = FontAwesome.Sharp.IconChar.Eraser
        Me.btnClear.IconColor = System.Drawing.Color.White
        Me.btnClear.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClear.IconSize = 24
        Me.btnClear.Location = New System.Drawing.Point(1024, 698)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 30)
        Me.btnClear.TabIndex = 622
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.IconChar = FontAwesome.Sharp.IconChar.Add
        Me.btnSave.IconColor = System.Drawing.Color.White
        Me.btnSave.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSave.IconSize = 24
        Me.btnSave.Location = New System.Drawing.Point(1128, 698)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(142, 30)
        Me.btnSave.TabIndex = 621
        Me.btnSave.Text = "Save Exam"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.txtReason)
        Me.GroupBox1.Controls.Add(Me.cboExamBatchNo1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtResched2)
        Me.GroupBox1.Controls.Add(Me.dtResched1)
        Me.GroupBox1.Controls.Add(Me.cboExam)
        Me.GroupBox1.Controls.Add(Me.chkResched)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox1.Location = New System.Drawing.Point(439, 586)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(831, 107)
        Me.GroupBox1.TabIndex = 620
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RE-SCHEDULING OF EXAM"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label21.Location = New System.Drawing.Point(72, 80)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(12, 16)
        Me.Label21.TabIndex = 620
        Me.Label21.Text = ":"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label22.Location = New System.Drawing.Point(6, 80)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(60, 16)
        Me.Label22.TabIndex = 619
        Me.Label22.Text = "Reason"
        '
        'txtReason
        '
        Me.txtReason.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReason.Location = New System.Drawing.Point(90, 77)
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(651, 23)
        Me.txtReason.TabIndex = 618
        Me.txtReason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboExamBatchNo1
        '
        Me.cboExamBatchNo1.ColumnNum = 0
        Me.cboExamBatchNo1.ColumnWidth = Nothing
        Me.cboExamBatchNo1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboExamBatchNo1.DropDownSize = 0
        Me.cboExamBatchNo1.drview = Nothing
        Me.cboExamBatchNo1.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboExamBatchNo1.FormattingEnabled = True
        Me.cboExamBatchNo1.IntegralHeight = False
        Me.cboExamBatchNo1.Location = New System.Drawing.Point(470, 47)
        Me.cboExamBatchNo1.Name = "cboExamBatchNo1"
        StringFormat19.Alignment = System.Drawing.StringAlignment.Near
        StringFormat19.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None
        StringFormat19.LineAlignment = System.Drawing.StringAlignment.Near
        StringFormat19.Trimming = System.Drawing.StringTrimming.Character
        Me.cboExamBatchNo1.SetTextFormat = StringFormat19
        Me.cboExamBatchNo1.Size = New System.Drawing.Size(271, 24)
        Me.cboExamBatchNo1.TabIndex = 617
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label5.Location = New System.Drawing.Point(452, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 16)
        Me.Label5.TabIndex = 616
        Me.Label5.Text = ":"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label20.Location = New System.Drawing.Point(321, 50)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(122, 16)
        Me.Label20.TabIndex = 615
        Me.Label20.Text = "Exam Batch No."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label1.Location = New System.Drawing.Point(452, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 16)
        Me.Label1.TabIndex = 614
        Me.Label1.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label3.Location = New System.Drawing.Point(320, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 613
        Me.Label3.Text = "Date Open"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label4.Location = New System.Drawing.Point(601, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 16)
        Me.Label4.TabIndex = 612
        Me.Label4.Text = "-"
        '
        'dtResched2
        '
        Me.dtResched2.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtResched2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtResched2.Location = New System.Drawing.Point(616, 18)
        Me.dtResched2.Name = "dtResched2"
        Me.dtResched2.Size = New System.Drawing.Size(125, 23)
        Me.dtResched2.TabIndex = 611
        '
        'dtResched1
        '
        Me.dtResched1.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtResched1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtResched1.Location = New System.Drawing.Point(470, 18)
        Me.dtResched1.Name = "dtResched1"
        Me.dtResched1.Size = New System.Drawing.Size(125, 23)
        Me.dtResched1.TabIndex = 610
        '
        'cboExam
        '
        Me.cboExam.ColumnNum = 0
        Me.cboExam.ColumnWidth = Nothing
        Me.cboExam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboExam.DropDownSize = 0
        Me.cboExam.drview = Nothing
        Me.cboExam.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboExam.FormattingEnabled = True
        Me.cboExam.Location = New System.Drawing.Point(82, 20)
        Me.cboExam.Name = "cboExam"
        StringFormat20.Alignment = System.Drawing.StringAlignment.Near
        StringFormat20.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None
        StringFormat20.LineAlignment = System.Drawing.StringAlignment.Near
        StringFormat20.Trimming = System.Drawing.StringTrimming.Character
        Me.cboExam.SetTextFormat = StringFormat20
        Me.cboExam.Size = New System.Drawing.Size(232, 24)
        Me.cboExam.TabIndex = 114
        '
        'chkResched
        '
        Me.chkResched.AutoSize = True
        Me.chkResched.ForeColor = System.Drawing.SystemColors.GrayText
        Me.chkResched.Location = New System.Drawing.Point(6, 22)
        Me.chkResched.Name = "chkResched"
        Me.chkResched.Size = New System.Drawing.Size(70, 20)
        Me.chkResched.TabIndex = 0
        Me.chkResched.Text = "Exam"
        Me.chkResched.UseVisualStyleBackColor = True
        '
        'lvApplicantExamination
        '
        Me.lvApplicantExamination.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvApplicantExamination.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15})
        Me.lvApplicantExamination.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvApplicantExamination.FullRowSelect = True
        Me.lvApplicantExamination.HideSelection = False
        Me.lvApplicantExamination.isCheckedAll = False
        Me.lvApplicantExamination.itemTrigger = Nothing
        Me.lvApplicantExamination.Location = New System.Drawing.Point(439, 314)
        Me.lvApplicantExamination.Name = "lvApplicantExamination"
        Me.lvApplicantExamination.OwnerDraw = True
        Me.lvApplicantExamination.Size = New System.Drawing.Size(831, 266)
        Me.lvApplicantExamination.TabIndex = 619
        Me.lvApplicantExamination.UseCompatibleStateImageBehavior = False
        Me.lvApplicantExamination.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Code"
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "IDNO"
        Me.ColumnHeader4.Width = 200
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Name of Applicant"
        Me.ColumnHeader5.Width = 200
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Examination Conf."
        Me.ColumnHeader6.Width = 200
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Date Open From"
        Me.ColumnHeader7.Width = 200
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Date Open To"
        Me.ColumnHeader8.Width = 200
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Date Answered"
        Me.ColumnHeader9.Width = 200
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Score"
        Me.ColumnHeader10.Width = 200
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Rate"
        Me.ColumnHeader11.Width = 200
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Assessment"
        Me.ColumnHeader12.Width = 200
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Remarks"
        Me.ColumnHeader13.Width = 200
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Reason for Scheduled Exam"
        Me.ColumnHeader14.Width = 200
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Batch Exam"
        Me.ColumnHeader15.Width = 200
        '
        'txtRemarks
        '
        Me.txtRemarks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemarks.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(589, 218)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(681, 90)
        Me.txtRemarks.TabIndex = 618
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label18.Location = New System.Drawing.Point(571, 221)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(12, 16)
        Me.Label18.TabIndex = 617
        Me.Label18.Text = ":"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label19.Location = New System.Drawing.Point(439, 221)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 16)
        Me.Label19.TabIndex = 616
        Me.Label19.Text = "Remarks"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label16.Location = New System.Drawing.Point(889, 96)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(12, 16)
        Me.Label16.TabIndex = 614
        Me.Label16.Text = ":"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label17.Location = New System.Drawing.Point(770, 96)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 16)
        Me.Label17.TabIndex = 613
        Me.Label17.Text = "Rate"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label14.Location = New System.Drawing.Point(571, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(12, 16)
        Me.Label14.TabIndex = 612
        Me.Label14.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label15.Location = New System.Drawing.Point(439, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(117, 16)
        Me.Label15.TabIndex = 611
        Me.Label15.Text = "Date Answered"
        '
        'dtAnswered
        '
        Me.dtAnswered.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtAnswered.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtAnswered.Location = New System.Drawing.Point(589, 64)
        Me.dtAnswered.Name = "dtAnswered"
        Me.dtAnswered.Size = New System.Drawing.Size(125, 23)
        Me.dtAnswered.TabIndex = 610
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label29.Location = New System.Drawing.Point(571, 40)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(12, 16)
        Me.Label29.TabIndex = 609
        Me.Label29.Text = ":"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label30.Location = New System.Drawing.Point(439, 40)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(83, 16)
        Me.Label30.TabIndex = 608
        Me.Label30.Text = "Date Open"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label28.Location = New System.Drawing.Point(720, 40)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(14, 16)
        Me.Label28.TabIndex = 607
        Me.Label28.Text = "-"
        '
        'dtOpen2
        '
        Me.dtOpen2.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtOpen2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtOpen2.Location = New System.Drawing.Point(735, 35)
        Me.dtOpen2.Name = "dtOpen2"
        Me.dtOpen2.Size = New System.Drawing.Size(125, 23)
        Me.dtOpen2.TabIndex = 606
        '
        'dtOpen1
        '
        Me.dtOpen1.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtOpen1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtOpen1.Location = New System.Drawing.Point(589, 35)
        Me.dtOpen1.Name = "dtOpen1"
        Me.dtOpen1.Size = New System.Drawing.Size(125, 23)
        Me.dtOpen1.TabIndex = 605
        '
        'cboExamBatchNo
        '
        Me.cboExamBatchNo.ColumnNum = 0
        Me.cboExamBatchNo.ColumnWidth = Nothing
        Me.cboExamBatchNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboExamBatchNo.DropDownSize = 0
        Me.cboExamBatchNo.drview = Nothing
        Me.cboExamBatchNo.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboExamBatchNo.FormattingEnabled = True
        Me.cboExamBatchNo.IntegralHeight = False
        Me.cboExamBatchNo.Location = New System.Drawing.Point(976, 5)
        Me.cboExamBatchNo.Name = "cboExamBatchNo"
        StringFormat17.Alignment = System.Drawing.StringAlignment.Near
        StringFormat17.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None
        StringFormat17.LineAlignment = System.Drawing.StringAlignment.Near
        StringFormat17.Trimming = System.Drawing.StringTrimming.Character
        Me.cboExamBatchNo.SetTextFormat = StringFormat17
        Me.cboExamBatchNo.Size = New System.Drawing.Size(232, 24)
        Me.cboExamBatchNo.TabIndex = 604
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label10.Location = New System.Drawing.Point(958, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(12, 16)
        Me.Label10.TabIndex = 603
        Me.Label10.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label11.Location = New System.Drawing.Point(827, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 16)
        Me.Label11.TabIndex = 602
        Me.Label11.Text = "Exam Batch No."
        '
        'lvApplicant
        '
        Me.lvApplicant.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvApplicant.CheckBoxes = True
        Me.lvApplicant.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvApplicant.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvApplicant.FullRowSelect = True
        Me.lvApplicant.HideSelection = False
        Me.lvApplicant.isCheckedAll = False
        Me.lvApplicant.itemTrigger = Nothing
        Me.lvApplicant.Location = New System.Drawing.Point(6, 5)
        Me.lvApplicant.Name = "lvApplicant"
        Me.lvApplicant.OwnerDraw = True
        Me.lvApplicant.Size = New System.Drawing.Size(427, 723)
        Me.lvApplicant.TabIndex = 595
        Me.lvApplicant.UseCompatibleStateImageBehavior = False
        Me.lvApplicant.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "IDNO"
        Me.ColumnHeader1.Width = 140
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name of Applicant"
        Me.ColumnHeader2.Width = 262
        '
        'txtAssesment
        '
        Me.txtAssesment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAssesment.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAssesment.Location = New System.Drawing.Point(589, 122)
        Me.txtAssesment.Multiline = True
        Me.txtAssesment.Name = "txtAssesment"
        Me.txtAssesment.Size = New System.Drawing.Size(681, 90)
        Me.txtAssesment.TabIndex = 215
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label12.Location = New System.Drawing.Point(571, 125)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(12, 16)
        Me.Label12.TabIndex = 214
        Me.Label12.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label13.Location = New System.Drawing.Point(439, 125)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 16)
        Me.Label13.TabIndex = 213
        Me.Label13.Text = "Assesment"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label7.Location = New System.Drawing.Point(571, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(12, 16)
        Me.Label7.TabIndex = 208
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label8.Location = New System.Drawing.Point(439, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 207
        Me.Label8.Text = "Score"
        '
        'cboJob
        '
        Me.cboJob.ColumnNum = 0
        Me.cboJob.ColumnWidth = Nothing
        Me.cboJob.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboJob.DropDownSize = 0
        Me.cboJob.drview = Nothing
        Me.cboJob.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboJob.FormattingEnabled = True
        Me.cboJob.Location = New System.Drawing.Point(589, 5)
        Me.cboJob.Name = "cboJob"
        StringFormat18.Alignment = System.Drawing.StringAlignment.Near
        StringFormat18.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None
        StringFormat18.LineAlignment = System.Drawing.StringAlignment.Near
        StringFormat18.Trimming = System.Drawing.StringTrimming.Character
        Me.cboJob.SetTextFormat = StringFormat18
        Me.cboJob.Size = New System.Drawing.Size(232, 24)
        Me.cboJob.TabIndex = 113
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label2.Location = New System.Drawing.Point(571, 8)
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
        Me.Label9.Location = New System.Drawing.Point(439, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 16)
        Me.Label9.TabIndex = 111
        Me.Label9.Text = "Job"
        '
        'Timer1
        '
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
        'frmApplicantExamination
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1317, 842)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmApplicantExamination"
        Me.Padding = New System.Windows.Forms.Padding(20)
        Me.Text = "Recruitment"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lvApplicant As NxnControls.NxNListview
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents txtAssesment As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cboJob As NxnControls.NxNComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents UpdateTool As ToolStripMenuItem
    Friend WithEvents DeleteTool As ToolStripMenuItem
    Friend WithEvents cboExamBatchNo As NxnControls.NxNComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents dtAnswered As DateTimePicker
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents dtOpen2 As DateTimePicker
    Friend WithEvents dtOpen1 As DateTimePicker
    Friend WithEvents lvApplicantExamination As NxnControls.NxNListview
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSave As FontAwesome.Sharp.IconButton
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
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents cboExamBatchNo1 As NxnControls.NxNComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtResched2 As DateTimePicker
    Friend WithEvents dtResched1 As DateTimePicker
    Friend WithEvents cboExam As NxnControls.NxNComboBox
    Friend WithEvents chkResched As CheckBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txtReason As TextBox
    Friend WithEvents btnClear As FontAwesome.Sharp.IconButton
    Friend WithEvents btnResched As FontAwesome.Sharp.IconButton
    Friend WithEvents txtScore As NxnControls.NxNNumericTextbox
    Friend WithEvents txtRate As NxnControls.NxNNumericTextbox
End Class
