Imports NXNParsing
Public Class frmLogin

    Private jStr_Input As String = "[]"
    Private ws As New WSConnection
    Private Token As String = String.Empty
    Private ActiveFrm As String = String.Empty

    Private attemptCount As Integer = 0
    Private Const maxAttempts As Integer = 3
    Dim cnt As Integer

    Private Declare Auto Function SetWindowLong Lib "User32.Dll" (ByVal hWnd As IntPtr, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
    Private Declare Auto Function GetWindowLong Lib "User32.Dll" (ByVal hWnd As System.IntPtr, ByVal nIndex As Integer) As Integer
    Private Const GWL_EXSTYLE = (-20)
    Private Const WS_EX_CLIENTEDGE = &H200

    Private Sub e_frmLoginSecurity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call setCboCompany(cboCompany)
    End Sub
    Private Sub ClearFields()
        txtUser.Text = ""
        txtPass.Text = ""
    End Sub
    Private Sub Login_Auth()
        Try

            Application.DoEvents()

            'For Hashing
            pwdHash = ws.HashStr(txtPass.Text, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            ActiveFrm = "xUserConn.php"
            MC = "CON01"
            Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            jStr_Input = "{" + """token" + """:""" + Token + """," &
                        """" + "usrname" + """:""" + Trim(txtUser.Text) + """}"

            Dim dtable As DataTable = ws.JsonStr2DTable(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
            Dim rs() As DataRow = dtable.Select()
            If rs.Count > 0 Then
                If rs(0).Item(0) = "-1" Then
                    MsgBox("Unable to connect remote Server !" & vbCr & vbCr & "Please Contact your system admininistrator !", vbCritical)
                ElseIf Trim(txtUser.Text) = "admin" And Trim(txtPass.Text) = "nexen" Then

                    'frmMain.ToolStripLabel3.Text = ActiveUserName
                    frmMain.lblName.Text = "Administrator"
                    frmMain.lblId.Text = "000000"

                    ActiveCompany = cboCompany.SelectedValue
                    ActiveCompanyName = cboCompany.Text
                    ActiveUserName = "Administrator"
                    ActiveUser = "Administrator"
                    ActiveUserID = "000000"

                    'Company Info
                    Dim rsComp() As DataRow = getCompanyList.Select("keyctr = '" & ActiveCompany & "' ")
                    If rsComp.Count > 0 Then
                        ActiveCompanyAddress = rsComp(0).Item("address")
                        ActiveCompanyContact = rsComp(0).Item("contact_no")
                        ActiveYear = rsComp(0).Item("active_year")
                    End If

                    If ActiveImage <> "" Then
                        Call getProfile_Image(frmMain.picUser, ActiveImage)
                    Else
                        frmMain.picUser.Image = My.Resources.ResourceManager.GetObject("user-woman128px")
                    End If

                    Me.Close()

                    Call MDI_Properties()

                    'With frmDashboard
                    '    .MdiParent = frmMain
                    '    .StartPosition = FormStartPosition.Manual
                    '    .Location = New Point(0, 0)`
                    '    .Size = New Size(mdiClient_.ClientSize.Width, mdiClient_.ClientSize.Height - 50)
                    '    .Show()
                    'End With

                    With frmDashboard
                        .WindowState = FormWindowState.Maximized
                        .TopLevel = False
                        frmMain.pnlLoad.Controls.Add(frmDashboard)
                        .BringToFront()
                        .Show()
                    End With


                ElseIf rs(0).Item(0) = "-0" Then
                    pnlNotif.Visible = True
                    lblNotif.Text = "         Account does not Exist "
                    attemptCount += 1

                    Call ClearFields()
                Else
                    If Trim(cboCompany.Text) <> "" Then
                        If rs(0).Item("x_password").ToString = pwdHash Then

                            ActiveCompany = cboCompany.SelectedValue
                            ActiveCompanyName = cboCompany.Text
                            ActiveUserName = rs(0).Item("x_username")
                            ActiveUser = StrConv(rs(0).Item("fullname"), vbProperCase)
                            ActiveUserID = rs(0).Item("idno")
                            GroupCode = rs(0).Item("grpcode")
                            If IsDBNull(rs(0).Item("image_filename")) = False Then ActiveImage = rs(0).Item("image_filename") Else ActiveImage = ""

                            'Update the Employee to Active
                            Try
                                MC = "HRMAX06"
                                ActiveFrm = "modHRMAX.php"
                                Token = ws.xGenKey(ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
                                jStr_Input = "{" + """token" + """:""" + Token + """," &
                                              """" + "varActive" + """:""" + True.ToString + """," &
                                              """" + "ActiveUserID" + """:""" + ActiveUserID + """," &
                                              """" + "MC" + """:""" + MC + """}"
                                Dim res As String = ws.JsonStr2JsonStr(jStr_Input, ServerTxt & ActiveFrm, "E4BCDCFDA0E6CFB3B35064D458E8C5A0034E6138FD440933")
                            Catch ex As Exception
                                MsgBox(ex.Message, vbCritical)
                            End Try

                            'frmMain.ToolStripLabel3.Text = ActiveUserName
                            frmMain.lblName.Text = ActiveUser
                            frmMain.lblId.Text = ActiveUserID

                            For Each _dr In getDatabase.Rows
                                'frmMain.ToolStripLabel2.Text = _dr("serverip").ToString & " - " & _dr("mydatabase").ToString
                            Next

                            'Company Info
                            Dim rsComp() As DataRow = getCompanyList.Select("keyctr = '" & ActiveCompany & "' ")
                            If rsComp.Count > 0 Then
                                ActiveCompanyAddress = rsComp(0).Item("address")
                                ActiveCompanyContact = rsComp(0).Item("contact_no")
                                ActiveYear = rsComp(0).Item("active_year")
                            End If

                            If ActiveImage <> "" Then
                                Call getProfile_Image(frmMain.picUser, ActiveImage)
                            Else
                                frmMain.picUser.Image = My.Resources.ResourceManager.GetObject("user-woman128px")
                            End If

                            Me.Close()

                            Call MDI_Properties()

                            'frmDash = New frmDashboard
                            'With frmDash
                            '    .MdiParent = frmMain
                            '    .Dock = DockStyle.Fill
                            '    frmDash.Show()
                            'End With

                            With frmDashboard
                                .WindowState = FormWindowState.Maximized
                                .TopLevel = False
                                frmMain.pnlLoad.Controls.Add(frmDashboard)
                                .BringToFront()
                                .Show()
                            End With


                        Else
                            pnlNotif.Visible = True
                            lblNotif.Text = "         Invalid Username and Password ! "
                            attemptCount += 1
                            Call ClearFields()
                        End If
                    Else
                        pnlNotif.Visible = True
                        lblNotif.Text = "         Please select your Company ! "
                    End If
                End If
            Else
                pnlNotif.Visible = True
                lblNotif.Text = "         Username and Password is Required ! "
                attemptCount += 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCr & vbCr & "Please Contact your system admininistrator", vbExclamation)
        End Try
    End Sub

    Public Sub setCboCompany(ByVal pCboBox As NxnControls.NxNComboBox)

        With pCboBox
            .DataSource = getCompany.Copy()
            .DisplayMember = "area_description"
            .ValueMember = "keyctr"
            .ColumnNum = 1
            .ColumnWidth = "50|" & pCboBox.Width
            .DropDownSize = pCboBox.Width
            .Text = ""
            .SelectedValue = 7
        End With
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Call Login_Auth()
        If maxAttempts = attemptCount Then
            MsgBox("Warning !" & vbCr & vbCr & " (3) Consecutives Invalid Log-in will terminate the System !", vbCritical)
            Me.Dispose()
            Application.Exit()
        End If
    End Sub
    Private Sub MDI_Properties()

        'If frmMain.IsMdiContainer = False Then frmMain.IsMdiContainer = True
        frmMain.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        '' SET BACKGROUND COLOR AND REMOVE BORDER FROM MDICLIENT CONTROL
        'For Each c As Control In frmMain.Controls()
        '    If TypeOf (c) Is MdiClient Then
        '        c.BackColor = Color.FromArgb(249, 251, 253)
        '        Dim windowLong As Integer = GetWindowLong(c.Handle, GWL_EXSTYLE)
        '        windowLong = windowLong And (Not WS_EX_CLIENTEDGE)
        '        SetWindowLong(c.Handle, GWL_EXSTYLE, windowLong)
        '        c.Width = c.Width + 1
        '        mdiClient_ = CType(c, MdiClient)
        '        Exit For
        '    End If
        'Next

        frmMain.pnlSideBar.Visible = True
        frmMain.pnlHeader.Visible = True
        frmMain.pnlLoad.Visible = True

        frmMain.Text = "HRMAX v" & Application.ProductVersion '& "-" & codeName & " - " & UCase(BrnName)
    End Sub

    'Button Events
    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            e.Handled = False
            txtPass.Focus()
        End If
    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            e.Handled = False
            cboCompany.Focus()
        End If
    End Sub

    Private Sub cboCompany_KeyDown(sender As Object, e As KeyEventArgs) Handles cboCompany.KeyDown
        If e.KeyValue = 13 Then
            e.Handled = False
            btnLogin.Focus()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MsgBox("Are you sure you want to Exit the System ?", vbQuestion + vbYesNo) = vbYes Then
            Me.Dispose()
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        AddSmsData("NEXEN", "09639614171", "IM ALWAYS AT YOUR SIDE", CDate(Now))
    End Sub

    Private Sub linkForgot_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkForgot.LinkClicked

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class