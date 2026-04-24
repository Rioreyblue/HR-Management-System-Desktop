Public Class frmTransparentBGV
    Dim _Child As Form

    Public Sub ShowForm(child As Form)
        InitializeComponent()
        _Child = child
        Me.MaximizedBounds = WorkingArea
        Me.WindowState = FormWindowState.Maximized
        Me.ShowDialog()
    End Sub

    Public Sub ShowForm(Parent As Form, child As Form)
        InitializeComponent()
        _Child = child
        Me.Location = Parent.Location
        Me.Size = Parent.Size
        Me.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not IsNothing(_Child) Then
            Timer1.Stop()
            _Child.ShowDialog()
            Me.Close()
        End If
    End Sub

End Class