<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCApplicantList
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.NxNCircularPictureBox1 = New NxnControls.NxNCircularPictureBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.lblPlaceofBirth = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblfullname = New System.Windows.Forms.Label()
        Me.lblidno = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.NxNCircularPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblidno)
        Me.Panel2.Controls.Add(Me.NxNCircularPictureBox1)
        Me.Panel2.Controls.Add(Me.lblEmail)
        Me.Panel2.Controls.Add(Me.lblMobile)
        Me.Panel2.Controls.Add(Me.lblPlaceofBirth)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.lblfullname)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1478, 67)
        Me.Panel2.TabIndex = 13
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
        Me.NxNCircularPictureBox1.TabIndex = 0
        Me.NxNCircularPictureBox1.TabStop = False
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblEmail.Location = New System.Drawing.Point(1078, 24)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(219, 16)
        Me.lblEmail.TabIndex = 15
        Me.lblEmail.Text = "armando.bacangjr18@gmail.com"
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobile.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblMobile.Location = New System.Drawing.Point(897, 24)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(112, 16)
        Me.lblMobile.TabIndex = 14
        Me.lblMobile.Text = "+639639614171"
        '
        'lblPlaceofBirth
        '
        Me.lblPlaceofBirth.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaceofBirth.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblPlaceofBirth.Location = New System.Drawing.Point(485, 6)
        Me.lblPlaceofBirth.Name = "lblPlaceofBirth"
        Me.lblPlaceofBirth.Size = New System.Drawing.Size(406, 57)
        Me.lblPlaceofBirth.TabIndex = 13
        Me.lblPlaceofBirth.Text = "San Vicente Alto, Oroquieta City"
        Me.lblPlaceofBirth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label4.Location = New System.Drawing.Point(69, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(330, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Graduate of Bachelor of Science and Technology"
        '
        'lblfullname
        '
        Me.lblfullname.AutoSize = True
        Me.lblfullname.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfullname.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblfullname.Location = New System.Drawing.Point(69, 22)
        Me.lblfullname.Name = "lblfullname"
        Me.lblfullname.Size = New System.Drawing.Size(193, 18)
        Me.lblfullname.TabIndex = 10
        Me.lblfullname.Text = "Armando B. Bacang Jr."
        '
        'lblidno
        '
        Me.lblidno.AutoSize = True
        Me.lblidno.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidno.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblidno.Location = New System.Drawing.Point(69, 6)
        Me.lblidno.Name = "lblidno"
        Me.lblidno.Size = New System.Drawing.Size(54, 16)
        Me.lblidno.TabIndex = 21
        Me.lblidno.Text = "JO-001"
        '
        'UCApplicantList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Name = "UCApplicantList"
        Me.Size = New System.Drawing.Size(1478, 67)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.NxNCircularPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblMobile As Label
    Friend WithEvents lblPlaceofBirth As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblfullname As Label
    Friend WithEvents NxNCircularPictureBox1 As NxnControls.NxNCircularPictureBox
    Friend WithEvents lblidno As Label
End Class
