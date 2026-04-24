Public Class frmMDI_Main
    Private Declare Auto Function SetWindowLong Lib "User32.Dll" (ByVal hWnd As IntPtr, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
    Private Declare Auto Function GetWindowLong Lib "User32.Dll" (ByVal hWnd As System.IntPtr, ByVal nIndex As Integer) As Integer
    Private Const GWL_EXSTYLE = (-20)
    Private Const WS_EX_CLIENTEDGE = &H200
    Private Sub frmMDI_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' SET BACKGROUND COLOR AND REMOVE BORDER FROM MDICLIENT CONTROL
        For Each c As Control In Me.Controls()
            If TypeOf (c) Is MdiClient Then
                'c.BackColor = Color.FromArgb(37, 150, 190)
                Dim windowLong As Integer = GetWindowLong(c.Handle, GWL_EXSTYLE)
                windowLong = windowLong And (Not WS_EX_CLIENTEDGE)
                SetWindowLong(c.Handle, GWL_EXSTYLE, windowLong)
                c.Width = c.Width + 1
                Exit For
            End If
        Next

    End Sub
    Private Sub SetMdiClientBackColor(color As Color)
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is MdiClient Then
                ctrl.BackColor = color
            End If
        Next
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click

    End Sub
End Class