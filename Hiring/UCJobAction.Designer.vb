<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCJobAction
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
        Me.btnAction = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'btnAction
        '
        Me.btnAction.AutoSize = True
        Me.btnAction.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnAction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAction.FlatAppearance.BorderSize = 0
        Me.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAction.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAction.ForeColor = System.Drawing.Color.White
        Me.btnAction.IconChar = FontAwesome.Sharp.IconChar.Add
        Me.btnAction.IconColor = System.Drawing.Color.White
        Me.btnAction.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAction.IconSize = 24
        Me.btnAction.Location = New System.Drawing.Point(0, 0)
        Me.btnAction.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAction.Name = "btnAction"
        Me.btnAction.Size = New System.Drawing.Size(95, 30)
        Me.btnAction.TabIndex = 513
        Me.btnAction.Text = "Hired"
        Me.btnAction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAction.UseVisualStyleBackColor = False
        '
        'UCJobAction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.btnAction)
        Me.Name = "UCJobAction"
        Me.Size = New System.Drawing.Size(95, 30)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAction As FontAwesome.Sharp.IconButton
End Class
