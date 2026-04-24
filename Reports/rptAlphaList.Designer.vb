<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptAlphaList
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
        Dim StringFormat1 As System.Drawing.StringFormat = New System.Drawing.StringFormat()
        Dim StringFormat2 As System.Drawing.StringFormat = New System.Drawing.StringFormat()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptAlphaList))
        Me.cboCutoff = New NxnControls.NxNComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboCompany = New NxnControls.NxNComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lvDivision = New NxnControls.NxNListview()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvEmployee = New NxnControls.NxNListview()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnPrint = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'cboCutoff
        '
        Me.cboCutoff.ColumnNum = 0
        Me.cboCutoff.ColumnWidth = Nothing
        Me.cboCutoff.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCutoff.DropDownSize = 0
        Me.cboCutoff.drview = Nothing
        Me.cboCutoff.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCutoff.FormattingEnabled = True
        Me.cboCutoff.IntegralHeight = False
        Me.cboCutoff.Location = New System.Drawing.Point(125, 39)
        Me.cboCutoff.Name = "cboCutoff"
        StringFormat1.Alignment = System.Drawing.StringAlignment.Near
        StringFormat1.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None
        StringFormat1.LineAlignment = System.Drawing.StringAlignment.Near
        StringFormat1.Trimming = System.Drawing.StringTrimming.Character
        Me.cboCutoff.SetTextFormat = StringFormat1
        Me.cboCutoff.Size = New System.Drawing.Size(232, 27)
        Me.cboCutoff.TabIndex = 119
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(107, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 18)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(6, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 18)
        Me.Label4.TabIndex = 117
        Me.Label4.Text = "Alphalist Type"
        '
        'cboCompany
        '
        Me.cboCompany.ColumnNum = 0
        Me.cboCompany.ColumnWidth = Nothing
        Me.cboCompany.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCompany.DropDownSize = 0
        Me.cboCompany.drview = Nothing
        Me.cboCompany.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCompany.FormattingEnabled = True
        Me.cboCompany.Location = New System.Drawing.Point(125, 6)
        Me.cboCompany.Name = "cboCompany"
        StringFormat2.Alignment = System.Drawing.StringAlignment.Near
        StringFormat2.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None
        StringFormat2.LineAlignment = System.Drawing.StringAlignment.Near
        StringFormat2.Trimming = System.Drawing.StringTrimming.Character
        Me.cboCompany.SetTextFormat = StringFormat2
        Me.cboCompany.Size = New System.Drawing.Size(232, 27)
        Me.cboCompany.TabIndex = 116
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(107, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 18)
        Me.Label2.TabIndex = 115
        Me.Label2.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(6, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 18)
        Me.Label9.TabIndex = 114
        Me.Label9.Text = "Company"
        '
        'lvDivision
        '
        Me.lvDivision.CheckBoxes = True
        Me.lvDivision.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvDivision.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvDivision.FullRowSelect = True
        Me.lvDivision.HideSelection = False
        Me.lvDivision.isCheckedAll = False
        Me.lvDivision.itemTrigger = Nothing
        Me.lvDivision.Location = New System.Drawing.Point(7, 226)
        Me.lvDivision.Name = "lvDivision"
        Me.lvDivision.OwnerDraw = True
        Me.lvDivision.Size = New System.Drawing.Size(391, 407)
        Me.lvDivision.TabIndex = 595
        Me.lvDivision.UseCompatibleStateImageBehavior = False
        Me.lvDivision.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "CODE"
        Me.ColumnHeader1.Width = 108
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "DIVISION NAME"
        Me.ColumnHeader2.Width = 254
        '
        'lvEmployee
        '
        Me.lvEmployee.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvEmployee.CheckBoxes = True
        Me.lvEmployee.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvEmployee.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvEmployee.FullRowSelect = True
        Me.lvEmployee.HideSelection = False
        Me.lvEmployee.isCheckedAll = False
        Me.lvEmployee.itemTrigger = Nothing
        Me.lvEmployee.Location = New System.Drawing.Point(404, 151)
        Me.lvEmployee.Name = "lvEmployee"
        Me.lvEmployee.OwnerDraw = True
        Me.lvEmployee.Size = New System.Drawing.Size(653, 446)
        Me.lvEmployee.TabIndex = 596
        Me.lvEmployee.UseCompatibleStateImageBehavior = False
        Me.lvEmployee.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "IDNO"
        Me.ColumnHeader3.Width = 131
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Fullname"
        Me.ColumnHeader4.Width = 494
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.btnPrint.IconColor = System.Drawing.Color.White
        Me.btnPrint.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPrint.IconSize = 24
        Me.btnPrint.Location = New System.Drawing.Point(961, 603)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(96, 30)
        Me.btnPrint.TabIndex = 597
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'rptAlphaList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1063, 639)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lvEmployee)
        Me.Controls.Add(Me.lvDivision)
        Me.Controls.Add(Me.cboCutoff)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboCompany)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rptAlphaList"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BIR Alpha Listing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboCutoff As NxnControls.NxNComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboCompany As NxnControls.NxNComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lvDivision As NxnControls.NxNListview
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents lvEmployee As NxnControls.NxNListview
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents btnPrint As FontAwesome.Sharp.IconButton
End Class
