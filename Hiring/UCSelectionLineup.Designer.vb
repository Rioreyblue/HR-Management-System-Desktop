<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCSelectionLineup
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblJobCode = New System.Windows.Forms.Label()
        Me.btnStatus = New NxnControls.CustomControls.NxNControls.NxNButton()
        Me.lbPublishDate = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbJobDescription = New System.Windows.Forms.Label()
        Me.lbPlaceAssignment = New System.Windows.Forms.Label()
        Me.lbJobTitle = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblJobCode)
        Me.Panel1.Controls.Add(Me.btnStatus)
        Me.Panel1.Controls.Add(Me.lbPublishDate)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lbJobDescription)
        Me.Panel1.Controls.Add(Me.lbPlaceAssignment)
        Me.Panel1.Controls.Add(Me.lbJobTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(723, 126)
        Me.Panel1.TabIndex = 1
        '
        'lblJobCode
        '
        Me.lblJobCode.AutoSize = True
        Me.lblJobCode.Location = New System.Drawing.Point(140, 98)
        Me.lblJobCode.Name = "lblJobCode"
        Me.lblJobCode.Size = New System.Drawing.Size(0, 16)
        Me.lblJobCode.TabIndex = 24
        Me.lblJobCode.Visible = False
        '
        'btnStatus
        '
        Me.btnStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnStatus.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnStatus.BorderColor = System.Drawing.Color.Empty
        Me.btnStatus.BorderRadius = 12
        Me.btnStatus.BorderSize = 0
        Me.btnStatus.FlatAppearance.BorderSize = 0
        Me.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatus.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatus.ForeColor = System.Drawing.Color.White
        Me.btnStatus.Location = New System.Drawing.Point(47, 94)
        Me.btnStatus.Name = "btnStatus"
        Me.btnStatus.Size = New System.Drawing.Size(87, 25)
        Me.btnStatus.TabIndex = 23
        Me.btnStatus.Text = "Open"
        Me.btnStatus.TextColor = System.Drawing.Color.White
        Me.btnStatus.UseVisualStyleBackColor = False
        '
        'lbPublishDate
        '
        Me.lbPublishDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbPublishDate.AutoSize = True
        Me.lbPublishDate.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPublishDate.Location = New System.Drawing.Point(534, 5)
        Me.lbPublishDate.Name = "lbPublishDate"
        Me.lbPublishDate.Size = New System.Drawing.Size(147, 16)
        Me.lbPublishDate.TabIndex = 22
        Me.lbPublishDate.Text = "Jan 01 - Jan 02,2026"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(422, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Publish Date :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HRMAXV16.My.Resources.Resources.job_24
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'lbJobDescription
        '
        Me.lbJobDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbJobDescription.AutoEllipsis = True
        Me.lbJobDescription.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbJobDescription.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lbJobDescription.Location = New System.Drawing.Point(44, 43)
        Me.lbJobDescription.Name = "lbJobDescription"
        Me.lbJobDescription.Size = New System.Drawing.Size(676, 48)
        Me.lbJobDescription.TabIndex = 15
        Me.lbJobDescription.Text = "job responsibility"
        '
        'lbPlaceAssignment
        '
        Me.lbPlaceAssignment.AutoSize = True
        Me.lbPlaceAssignment.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPlaceAssignment.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lbPlaceAssignment.Location = New System.Drawing.Point(44, 27)
        Me.lbPlaceAssignment.Name = "lbPlaceAssignment"
        Me.lbPlaceAssignment.Size = New System.Drawing.Size(370, 16)
        Me.lbPlaceAssignment.TabIndex = 14
        Me.lbPlaceAssignment.Text = "Current Chairman of Software Engineer Research Team"
        '
        'lbJobTitle
        '
        Me.lbJobTitle.AutoSize = True
        Me.lbJobTitle.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbJobTitle.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbJobTitle.Location = New System.Drawing.Point(44, 3)
        Me.lbJobTitle.Name = "lbJobTitle"
        Me.lbJobTitle.Size = New System.Drawing.Size(159, 18)
        Me.lbJobTitle.TabIndex = 13
        Me.lbJobTitle.Text = "Software Engineer"
        '
        'UCSelectionLineup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UCSelectionLineup"
        Me.Size = New System.Drawing.Size(723, 126)
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbJobDescription As Label
    Friend WithEvents lbPlaceAssignment As Label
    Friend WithEvents lbJobTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnStatus As NxnControls.CustomControls.NxNControls.NxNButton
    Friend WithEvents lbPublishDate As Label
    Friend WithEvents lblJobCode As Label
End Class
