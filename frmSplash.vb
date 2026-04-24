Public Class frmSplash
    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 5
        lblLoading.Text = "Loading... " & ProgressBar1.Value.ToString() & "%"

        If ProgressBar1.Value >= ProgressBar1.Maximum Then
            Timer1.Stop()
            Me.Close()
        End If
    End Sub
End Class
