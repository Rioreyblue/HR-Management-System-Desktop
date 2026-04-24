<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCAppliedPosition
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.NxNCircularPictureBox1 = New NxnControls.NxNCircularPictureBox()
        Me.lblGraduate = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblYears = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnExamination = New FontAwesome.Sharp.IconButton()
        Me.btnRequirements = New FontAwesome.Sharp.IconButton()
        Me.btnInterview = New FontAwesome.Sharp.IconButton()
        Me.btnPooling = New FontAwesome.Sharp.IconButton()
        Me.btnHired = New FontAwesome.Sharp.IconButton()
        Me.btnFail = New FontAwesome.Sharp.IconButton()
        CType(Me.NxNCircularPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NxNCircularPictureBox1
        '
        Me.NxNCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.NxNCircularPictureBox1.BorderColor = System.Drawing.Color.DarkOrange
        Me.NxNCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink
        Me.NxNCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.NxNCircularPictureBox1.BorderSize = 2
        Me.NxNCircularPictureBox1.GradientAngle = 50.0!
        Me.NxNCircularPictureBox1.Image = Global.HRMAXV16.My.Resources.Resources.profile_pic
        Me.NxNCircularPictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.NxNCircularPictureBox1.Name = "NxNCircularPictureBox1"
        Me.NxNCircularPictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.NxNCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.NxNCircularPictureBox1.TabIndex = 16
        Me.NxNCircularPictureBox1.TabStop = False
        '
        'lblGraduate
        '
        Me.lblGraduate.AutoSize = True
        Me.lblGraduate.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGraduate.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblGraduate.Location = New System.Drawing.Point(69, 24)
        Me.lblGraduate.Name = "lblGraduate"
        Me.lblGraduate.Size = New System.Drawing.Size(330, 16)
        Me.lblGraduate.TabIndex = 18
        Me.lblGraduate.Text = "Graduate of Bachelor of Science and Technology"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblName.Location = New System.Drawing.Point(69, 6)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(193, 18)
        Me.lblName.TabIndex = 17
        Me.lblName.Text = "Armando B. Bacang Jr."
        '
        'lblYears
        '
        Me.lblYears.AutoSize = True
        Me.lblYears.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYears.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblYears.Location = New System.Drawing.Point(69, 40)
        Me.lblYears.Name = "lblYears"
        Me.lblYears.Size = New System.Drawing.Size(302, 16)
        Me.lblYears.TabIndex = 19
        Me.lblYears.Text = "29years of Experience at Chowking Restobar"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblAddress.Location = New System.Drawing.Point(69, 56)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(218, 16)
        Me.lblAddress.TabIndex = 20
        Me.lblAddress.Text = "San Vicente Alto,Oroquieta City"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Green
        Me.lblEmail.Location = New System.Drawing.Point(69, 72)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(219, 16)
        Me.lblEmail.TabIndex = 21
        Me.lblEmail.Text = "armando.bacangjr18@gmail.com"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.btnExamination)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnRequirements)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnInterview)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnPooling)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnHired)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnFail)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(495, 48)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1030, 40)
        Me.FlowLayoutPanel1.TabIndex = 22
        '
        'btnExamination
        '
        Me.btnExamination.AutoSize = True
        Me.btnExamination.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnExamination.FlatAppearance.BorderSize = 0
        Me.btnExamination.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExamination.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExamination.ForeColor = System.Drawing.Color.White
        Me.btnExamination.IconChar = FontAwesome.Sharp.IconChar.Add
        Me.btnExamination.IconColor = System.Drawing.Color.White
        Me.btnExamination.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnExamination.IconSize = 24
        Me.btnExamination.Location = New System.Drawing.Point(2, 2)
        Me.btnExamination.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExamination.Name = "btnExamination"
        Me.btnExamination.Size = New System.Drawing.Size(170, 30)
        Me.btnExamination.TabIndex = 514
        Me.btnExamination.Text = "For Examination"
        Me.btnExamination.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExamination.UseVisualStyleBackColor = False
        '
        'btnRequirements
        '
        Me.btnRequirements.AutoSize = True
        Me.btnRequirements.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btnRequirements.FlatAppearance.BorderSize = 0
        Me.btnRequirements.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRequirements.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRequirements.ForeColor = System.Drawing.Color.White
        Me.btnRequirements.IconChar = FontAwesome.Sharp.IconChar.Add
        Me.btnRequirements.IconColor = System.Drawing.Color.White
        Me.btnRequirements.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRequirements.IconSize = 24
        Me.btnRequirements.Location = New System.Drawing.Point(176, 2)
        Me.btnRequirements.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRequirements.Name = "btnRequirements"
        Me.btnRequirements.Size = New System.Drawing.Size(170, 30)
        Me.btnRequirements.TabIndex = 515
        Me.btnRequirements.Text = "For Requirements"
        Me.btnRequirements.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRequirements.UseVisualStyleBackColor = False
        '
        'btnInterview
        '
        Me.btnInterview.AutoSize = True
        Me.btnInterview.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnInterview.FlatAppearance.BorderSize = 0
        Me.btnInterview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInterview.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInterview.ForeColor = System.Drawing.Color.White
        Me.btnInterview.IconChar = FontAwesome.Sharp.IconChar.Add
        Me.btnInterview.IconColor = System.Drawing.Color.White
        Me.btnInterview.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnInterview.IconSize = 24
        Me.btnInterview.Location = New System.Drawing.Point(350, 2)
        Me.btnInterview.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInterview.Name = "btnInterview"
        Me.btnInterview.Size = New System.Drawing.Size(170, 30)
        Me.btnInterview.TabIndex = 516
        Me.btnInterview.Text = "For Interview"
        Me.btnInterview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInterview.UseVisualStyleBackColor = False
        '
        'btnPooling
        '
        Me.btnPooling.AutoSize = True
        Me.btnPooling.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnPooling.FlatAppearance.BorderSize = 0
        Me.btnPooling.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPooling.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPooling.ForeColor = System.Drawing.Color.White
        Me.btnPooling.IconChar = FontAwesome.Sharp.IconChar.Add
        Me.btnPooling.IconColor = System.Drawing.Color.White
        Me.btnPooling.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPooling.IconSize = 24
        Me.btnPooling.Location = New System.Drawing.Point(524, 2)
        Me.btnPooling.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPooling.Name = "btnPooling"
        Me.btnPooling.Size = New System.Drawing.Size(160, 30)
        Me.btnPooling.TabIndex = 517
        Me.btnPooling.Text = "For Pooling"
        Me.btnPooling.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPooling.UseVisualStyleBackColor = False
        '
        'btnHired
        '
        Me.btnHired.AutoSize = True
        Me.btnHired.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnHired.FlatAppearance.BorderSize = 0
        Me.btnHired.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHired.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHired.ForeColor = System.Drawing.Color.White
        Me.btnHired.IconChar = FontAwesome.Sharp.IconChar.Add
        Me.btnHired.IconColor = System.Drawing.Color.White
        Me.btnHired.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnHired.IconSize = 24
        Me.btnHired.Location = New System.Drawing.Point(688, 2)
        Me.btnHired.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHired.Name = "btnHired"
        Me.btnHired.Size = New System.Drawing.Size(160, 30)
        Me.btnHired.TabIndex = 518
        Me.btnHired.Text = "Hired"
        Me.btnHired.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHired.UseVisualStyleBackColor = False
        '
        'btnFail
        '
        Me.btnFail.AutoSize = True
        Me.btnFail.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnFail.FlatAppearance.BorderSize = 0
        Me.btnFail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFail.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFail.ForeColor = System.Drawing.Color.White
        Me.btnFail.IconChar = FontAwesome.Sharp.IconChar.Add
        Me.btnFail.IconColor = System.Drawing.Color.White
        Me.btnFail.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnFail.IconSize = 24
        Me.btnFail.Location = New System.Drawing.Point(852, 2)
        Me.btnFail.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFail.Name = "btnFail"
        Me.btnFail.Size = New System.Drawing.Size(160, 30)
        Me.btnFail.TabIndex = 519
        Me.btnFail.Text = "Fail Applicant"
        Me.btnFail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFail.UseVisualStyleBackColor = False
        '
        'UCAppliedPosition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblYears)
        Me.Controls.Add(Me.NxNCircularPictureBox1)
        Me.Controls.Add(Me.lblGraduate)
        Me.Controls.Add(Me.lblName)
        Me.Name = "UCAppliedPosition"
        Me.Size = New System.Drawing.Size(1528, 94)
        CType(Me.NxNCircularPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NxNCircularPictureBox1 As NxnControls.NxNCircularPictureBox
    Friend WithEvents lblGraduate As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblYears As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnExamination As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRequirements As FontAwesome.Sharp.IconButton
    Friend WithEvents btnInterview As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPooling As FontAwesome.Sharp.IconButton
    Friend WithEvents btnHired As FontAwesome.Sharp.IconButton
    Friend WithEvents btnFail As FontAwesome.Sharp.IconButton
End Class
