<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.NxNRoundedPanel7 = New NxnControls.NxNRoundedPanel()
        Me.IconPictureBox7 = New FontAwesome.Sharp.IconPictureBox()
        Me.cntLeave = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.NxNRoundedPanel6 = New NxnControls.NxNRoundedPanel()
        Me.IconPictureBox6 = New FontAwesome.Sharp.IconPictureBox()
        Me.cntApplicant = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.NxNRoundedPanel5 = New NxnControls.NxNRoundedPanel()
        Me.IconPictureBox5 = New FontAwesome.Sharp.IconPictureBox()
        Me.cntEmployee = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NxNRoundedPanel4 = New NxnControls.NxNRoundedPanel()
        Me.IconPictureBox4 = New FontAwesome.Sharp.IconPictureBox()
        Me.cntTravel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chrtAttendance = New LiveCharts.WinForms.PieChart()
        Me.CartesianChart1 = New LiveCharts.WinForms.CartesianChart()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlLoad = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvRecords = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.NxNRoundedPanel7.SuspendLayout()
        CType(Me.IconPictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NxNRoundedPanel6.SuspendLayout()
        CType(Me.IconPictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NxNRoundedPanel5.SuspendLayout()
        CType(Me.IconPictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NxNRoundedPanel4.SuspendLayout()
        CType(Me.IconPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLoad.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(4, 366)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Attendance Logs"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.NxNRoundedPanel7, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.NxNRoundedPanel6, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.NxNRoundedPanel5, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.NxNRoundedPanel4, 3, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1178, 88)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'NxNRoundedPanel7
        '
        Me.NxNRoundedPanel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.NxNRoundedPanel7.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.NxNRoundedPanel7.BackgroundGradientColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.NxNRoundedPanel7.BackgroundGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.NxNRoundedPanel7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.NxNRoundedPanel7.BorderGradientColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.NxNRoundedPanel7.BorderGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.NxNRoundedPanel7.BorderRadius = 10
        Me.NxNRoundedPanel7.BorderSize = 1
        Me.NxNRoundedPanel7.Controls.Add(Me.IconPictureBox7)
        Me.NxNRoundedPanel7.Controls.Add(Me.cntLeave)
        Me.NxNRoundedPanel7.Controls.Add(Me.Label14)
        Me.NxNRoundedPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NxNRoundedPanel7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NxNRoundedPanel7.Location = New System.Drawing.Point(591, 3)
        Me.NxNRoundedPanel7.Name = "NxNRoundedPanel7"
        Me.NxNRoundedPanel7.Size = New System.Drawing.Size(288, 82)
        Me.NxNRoundedPanel7.TabIndex = 12
        Me.NxNRoundedPanel7.TextColor = System.Drawing.SystemColors.ControlText
        '
        'IconPictureBox7
        '
        Me.IconPictureBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.IconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.UserAltSlash
        Me.IconPictureBox7.IconColor = System.Drawing.Color.White
        Me.IconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox7.IconSize = 30
        Me.IconPictureBox7.Location = New System.Drawing.Point(12, 24)
        Me.IconPictureBox7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.IconPictureBox7.Name = "IconPictureBox7"
        Me.IconPictureBox7.Size = New System.Drawing.Size(30, 32)
        Me.IconPictureBox7.TabIndex = 6
        Me.IconPictureBox7.TabStop = False
        '
        'cntLeave
        '
        Me.cntLeave.AutoSize = True
        Me.cntLeave.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cntLeave.ForeColor = System.Drawing.Color.White
        Me.cntLeave.Location = New System.Drawing.Point(55, 41)
        Me.cntLeave.Name = "cntLeave"
        Me.cntLeave.Size = New System.Drawing.Size(50, 23)
        Me.cntLeave.TabIndex = 2
        Me.cntLeave.Text = "3354"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(56, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(161, 20)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "On-Leave Employees"
        '
        'NxNRoundedPanel6
        '
        Me.NxNRoundedPanel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.NxNRoundedPanel6.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.NxNRoundedPanel6.BackgroundGradientColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.NxNRoundedPanel6.BackgroundGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.NxNRoundedPanel6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.NxNRoundedPanel6.BorderGradientColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.NxNRoundedPanel6.BorderGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.NxNRoundedPanel6.BorderRadius = 10
        Me.NxNRoundedPanel6.BorderSize = 1
        Me.NxNRoundedPanel6.Controls.Add(Me.IconPictureBox6)
        Me.NxNRoundedPanel6.Controls.Add(Me.cntApplicant)
        Me.NxNRoundedPanel6.Controls.Add(Me.Label12)
        Me.NxNRoundedPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NxNRoundedPanel6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NxNRoundedPanel6.Location = New System.Drawing.Point(297, 3)
        Me.NxNRoundedPanel6.Name = "NxNRoundedPanel6"
        Me.NxNRoundedPanel6.Size = New System.Drawing.Size(288, 82)
        Me.NxNRoundedPanel6.TabIndex = 11
        Me.NxNRoundedPanel6.TextColor = System.Drawing.SystemColors.ControlText
        '
        'IconPictureBox6
        '
        Me.IconPictureBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.IconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.UserClock
        Me.IconPictureBox6.IconColor = System.Drawing.Color.White
        Me.IconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox6.IconSize = 30
        Me.IconPictureBox6.Location = New System.Drawing.Point(12, 24)
        Me.IconPictureBox6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.IconPictureBox6.Name = "IconPictureBox6"
        Me.IconPictureBox6.Size = New System.Drawing.Size(30, 32)
        Me.IconPictureBox6.TabIndex = 6
        Me.IconPictureBox6.TabStop = False
        '
        'cntApplicant
        '
        Me.cntApplicant.AutoSize = True
        Me.cntApplicant.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cntApplicant.ForeColor = System.Drawing.Color.White
        Me.cntApplicant.Location = New System.Drawing.Point(55, 41)
        Me.cntApplicant.Name = "cntApplicant"
        Me.cntApplicant.Size = New System.Drawing.Size(50, 23)
        Me.cntApplicant.TabIndex = 2
        Me.cntApplicant.Text = "3354"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(56, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(127, 20)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Total Applicants"
        '
        'NxNRoundedPanel5
        '
        Me.NxNRoundedPanel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.NxNRoundedPanel5.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.NxNRoundedPanel5.BackgroundGradientColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.NxNRoundedPanel5.BackgroundGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.NxNRoundedPanel5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.NxNRoundedPanel5.BorderGradientColour = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.NxNRoundedPanel5.BorderGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.NxNRoundedPanel5.BorderRadius = 10
        Me.NxNRoundedPanel5.BorderSize = 1
        Me.NxNRoundedPanel5.Controls.Add(Me.IconPictureBox5)
        Me.NxNRoundedPanel5.Controls.Add(Me.cntEmployee)
        Me.NxNRoundedPanel5.Controls.Add(Me.Label10)
        Me.NxNRoundedPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NxNRoundedPanel5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NxNRoundedPanel5.Location = New System.Drawing.Point(3, 3)
        Me.NxNRoundedPanel5.Name = "NxNRoundedPanel5"
        Me.NxNRoundedPanel5.Size = New System.Drawing.Size(288, 82)
        Me.NxNRoundedPanel5.TabIndex = 10
        Me.NxNRoundedPanel5.TextColor = System.Drawing.SystemColors.ControlText
        '
        'IconPictureBox5
        '
        Me.IconPictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.IconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.UserGroup
        Me.IconPictureBox5.IconColor = System.Drawing.Color.White
        Me.IconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox5.IconSize = 30
        Me.IconPictureBox5.Location = New System.Drawing.Point(12, 24)
        Me.IconPictureBox5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.IconPictureBox5.Name = "IconPictureBox5"
        Me.IconPictureBox5.Size = New System.Drawing.Size(30, 32)
        Me.IconPictureBox5.TabIndex = 6
        Me.IconPictureBox5.TabStop = False
        '
        'cntEmployee
        '
        Me.cntEmployee.AutoSize = True
        Me.cntEmployee.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cntEmployee.ForeColor = System.Drawing.Color.White
        Me.cntEmployee.Location = New System.Drawing.Point(55, 41)
        Me.cntEmployee.Name = "cntEmployee"
        Me.cntEmployee.Size = New System.Drawing.Size(50, 23)
        Me.cntEmployee.TabIndex = 2
        Me.cntEmployee.Text = "3354"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(56, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 20)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Total Employees"
        '
        'NxNRoundedPanel4
        '
        Me.NxNRoundedPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.NxNRoundedPanel4.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.NxNRoundedPanel4.BackgroundGradientColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.NxNRoundedPanel4.BackgroundGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.NxNRoundedPanel4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.NxNRoundedPanel4.BorderGradientColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.NxNRoundedPanel4.BorderGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.NxNRoundedPanel4.BorderRadius = 10
        Me.NxNRoundedPanel4.BorderSize = 1
        Me.NxNRoundedPanel4.Controls.Add(Me.IconPictureBox4)
        Me.NxNRoundedPanel4.Controls.Add(Me.cntTravel)
        Me.NxNRoundedPanel4.Controls.Add(Me.Label9)
        Me.NxNRoundedPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NxNRoundedPanel4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NxNRoundedPanel4.Location = New System.Drawing.Point(885, 3)
        Me.NxNRoundedPanel4.Name = "NxNRoundedPanel4"
        Me.NxNRoundedPanel4.Size = New System.Drawing.Size(290, 82)
        Me.NxNRoundedPanel4.TabIndex = 10
        Me.NxNRoundedPanel4.TextColor = System.Drawing.SystemColors.ControlText
        '
        'IconPictureBox4
        '
        Me.IconPictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.IconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Plane
        Me.IconPictureBox4.IconColor = System.Drawing.Color.White
        Me.IconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox4.IconSize = 30
        Me.IconPictureBox4.Location = New System.Drawing.Point(12, 24)
        Me.IconPictureBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.IconPictureBox4.Name = "IconPictureBox4"
        Me.IconPictureBox4.Size = New System.Drawing.Size(30, 32)
        Me.IconPictureBox4.TabIndex = 6
        Me.IconPictureBox4.TabStop = False
        '
        'cntTravel
        '
        Me.cntTravel.AutoSize = True
        Me.cntTravel.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cntTravel.ForeColor = System.Drawing.Color.White
        Me.cntTravel.Location = New System.Drawing.Point(55, 41)
        Me.cntTravel.Name = "cntTravel"
        Me.cntTravel.Size = New System.Drawing.Size(50, 23)
        Me.cntTravel.TabIndex = 2
        Me.cntTravel.Text = "3354"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(56, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(163, 20)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "On-Travel Employees"
        '
        'chrtAttendance
        '
        Me.chrtAttendance.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chrtAttendance.Location = New System.Drawing.Point(830, 32)
        Me.chrtAttendance.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chrtAttendance.Name = "chrtAttendance"
        Me.chrtAttendance.Size = New System.Drawing.Size(333, 310)
        Me.chrtAttendance.TabIndex = 6
        Me.chrtAttendance.Text = "chrtAttendance"
        '
        'CartesianChart1
        '
        Me.CartesianChart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CartesianChart1.BackColor = System.Drawing.Color.White
        Me.CartesianChart1.Location = New System.Drawing.Point(3, 32)
        Me.CartesianChart1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CartesianChart1.Name = "CartesianChart1"
        Me.CartesianChart1.Size = New System.Drawing.Size(794, 310)
        Me.CartesianChart1.TabIndex = 6
        Me.CartesianChart1.Text = "CartesianChart1"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 8)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Employee Statistics"
        '
        'pnlLoad
        '
        Me.pnlLoad.Controls.Add(Me.Panel1)
        Me.pnlLoad.Controls.Add(Me.TableLayoutPanel2)
        Me.pnlLoad.Location = New System.Drawing.Point(2, 51)
        Me.pnlLoad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlLoad.Name = "pnlLoad"
        Me.pnlLoad.Size = New System.Drawing.Size(1178, 687)
        Me.pnlLoad.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Panel1.Controls.Add(Me.dgvRecords)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.chrtAttendance)
        Me.Panel1.Controls.Add(Me.CartesianChart1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(0, 88)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1178, 639)
        Me.Panel1.TabIndex = 4
        '
        'dgvRecords
        '
        Me.dgvRecords.AllowUserToAddRows = False
        Me.dgvRecords.AllowUserToDeleteRows = False
        Me.dgvRecords.BackgroundColor = System.Drawing.SystemColors.InactiveBorder
        Me.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecords.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvRecords.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvRecords.Location = New System.Drawing.Point(0, 387)
        Me.dgvRecords.Name = "dgvRecords"
        Me.dgvRecords.ReadOnly = True
        Me.dgvRecords.RowHeadersWidth = 51
        Me.dgvRecords.RowTemplate.Height = 24
        Me.dgvRecords.Size = New System.Drawing.Size(1178, 252)
        Me.dgvRecords.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(828, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Attendance Chart"
        '
        'lblName
        '
        Me.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(2, 10)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(133, 25)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Dashboard"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lblName, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1181, 45)
        Me.TableLayoutPanel4.TabIndex = 5
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.pnlLoad, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(15, 16)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1185, 740)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Employee ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Employee Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Attendance Date"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1215, 772)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDashboard"
        Me.Padding = New System.Windows.Forms.Padding(15, 16, 15, 16)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.NxNRoundedPanel7.ResumeLayout(False)
        Me.NxNRoundedPanel7.PerformLayout()
        CType(Me.IconPictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NxNRoundedPanel6.ResumeLayout(False)
        Me.NxNRoundedPanel6.PerformLayout()
        CType(Me.IconPictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NxNRoundedPanel5.ResumeLayout(False)
        Me.NxNRoundedPanel5.PerformLayout()
        CType(Me.IconPictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NxNRoundedPanel4.ResumeLayout(False)
        Me.NxNRoundedPanel4.PerformLayout()
        CType(Me.IconPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLoad.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents NxNRoundedPanel7 As NxnControls.NxNRoundedPanel
    Friend WithEvents IconPictureBox7 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents cntLeave As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents NxNRoundedPanel6 As NxnControls.NxNRoundedPanel
    Friend WithEvents IconPictureBox6 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents cntApplicant As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents NxNRoundedPanel5 As NxnControls.NxNRoundedPanel
    Friend WithEvents IconPictureBox5 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents cntEmployee As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents NxNRoundedPanel4 As NxnControls.NxNRoundedPanel
    Friend WithEvents IconPictureBox4 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents cntTravel As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents chrtAttendance As LiveCharts.WinForms.PieChart
    Friend WithEvents CartesianChart1 As LiveCharts.WinForms.CartesianChart
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlLoad As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dgvRecords As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
