Module modMain

    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        Dim splash As New frmSplash()
        splash.ShowDialog()

        Application.Run(frmMain)
    End Sub
End Module
