<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCSkills
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
        Me.NxNRoundedPanel1 = New NxnControls.NxNRoundedPanel()
        Me.lblSkills = New System.Windows.Forms.Label()
        Me.NxNRoundedPanel2 = New NxnControls.NxNRoundedPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSkillsRating = New System.Windows.Forms.Label()
        Me.NxNRoundedPanel1.SuspendLayout()
        Me.NxNRoundedPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NxNRoundedPanel1
        '
        Me.NxNRoundedPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.NxNRoundedPanel1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.NxNRoundedPanel1.BackgroundGradientColor = System.Drawing.SystemColors.Control
        Me.NxNRoundedPanel1.BackgroundGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.NxNRoundedPanel1.BorderColor = System.Drawing.Color.Empty
        Me.NxNRoundedPanel1.BorderGradientColour = System.Drawing.Color.Empty
        Me.NxNRoundedPanel1.BorderGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.NxNRoundedPanel1.BorderRadius = 25
        Me.NxNRoundedPanel1.BorderSize = 1
        Me.NxNRoundedPanel1.Controls.Add(Me.lblSkills)
        Me.NxNRoundedPanel1.Controls.Add(Me.NxNRoundedPanel2)
        Me.NxNRoundedPanel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NxNRoundedPanel1.Location = New System.Drawing.Point(0, 0)
        Me.NxNRoundedPanel1.Name = "NxNRoundedPanel1"
        Me.NxNRoundedPanel1.Size = New System.Drawing.Size(305, 47)
        Me.NxNRoundedPanel1.TabIndex = 0
        Me.NxNRoundedPanel1.TextColor = System.Drawing.SystemColors.ControlText
        '
        'lblSkills
        '
        Me.lblSkills.AutoSize = True
        Me.lblSkills.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSkills.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.lblSkills.Location = New System.Drawing.Point(48, 16)
        Me.lblSkills.Name = "lblSkills"
        Me.lblSkills.Size = New System.Drawing.Size(112, 16)
        Me.lblSkills.TabIndex = 2
        Me.lblSkills.Text = "User Experience"
        '
        'NxNRoundedPanel2
        '
        Me.NxNRoundedPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.NxNRoundedPanel2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.NxNRoundedPanel2.BackgroundGradientColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.NxNRoundedPanel2.BackgroundGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.NxNRoundedPanel2.BorderColor = System.Drawing.Color.Empty
        Me.NxNRoundedPanel2.BorderGradientColour = System.Drawing.Color.Empty
        Me.NxNRoundedPanel2.BorderGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.NxNRoundedPanel2.BorderRadius = 17
        Me.NxNRoundedPanel2.BorderSize = 1
        Me.NxNRoundedPanel2.Controls.Add(Me.TableLayoutPanel1)
        Me.NxNRoundedPanel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NxNRoundedPanel2.Location = New System.Drawing.Point(6, 6)
        Me.NxNRoundedPanel2.Name = "NxNRoundedPanel2"
        Me.NxNRoundedPanel2.Size = New System.Drawing.Size(36, 35)
        Me.NxNRoundedPanel2.TabIndex = 1
        Me.NxNRoundedPanel2.TextColor = System.Drawing.SystemColors.ControlText
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblSkillsRating, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 9)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(32, 17)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblSkillsRating
        '
        Me.lblSkillsRating.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSkillsRating.AutoSize = True
        Me.lblSkillsRating.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSkillsRating.ForeColor = System.Drawing.Color.White
        Me.lblSkillsRating.Location = New System.Drawing.Point(3, 0)
        Me.lblSkillsRating.Name = "lblSkillsRating"
        Me.lblSkillsRating.Size = New System.Drawing.Size(25, 16)
        Me.lblSkillsRating.TabIndex = 1
        Me.lblSkillsRating.Text = "10"
        '
        'UCSkills
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.NxNRoundedPanel1)
        Me.Name = "UCSkills"
        Me.Size = New System.Drawing.Size(305, 45)
        Me.NxNRoundedPanel1.ResumeLayout(False)
        Me.NxNRoundedPanel1.PerformLayout()
        Me.NxNRoundedPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NxNRoundedPanel1 As NxnControls.NxNRoundedPanel
    Friend WithEvents lblSkills As Label
    Friend WithEvents NxNRoundedPanel2 As NxnControls.NxNRoundedPanel
    Friend WithEvents lblSkillsRating As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
