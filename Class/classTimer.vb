Imports System.Windows

Public Class classTimer

    Public Shared Property TimerCount As Integer
    Public Shared Property EventType As Integer
    Public Shared Sub TimerStop(ByVal pTimer As Timer)
        pTimer.Enabled = False
    End Sub
    Public Shared Sub TimerReset()
        TimerCount = 0
    End Sub
    Public Shared Sub CloseLoading(ByVal pForm As Form)
        pForm.Close()
    End Sub
    Public Shared Sub OpenLoading(ByVal pForm As Form)
        pForm.Show()
    End Sub
End Class
