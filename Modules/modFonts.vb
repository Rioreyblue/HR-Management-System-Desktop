Imports System.Drawing.Text
Imports System.Runtime.InteropServices

Module modFonts
    Private pfc As PrivateFontCollection

    ' Call this once at startup
    Public Sub LoadCustomFonts()
        If pfc Is Nothing Then
            pfc = New PrivateFontCollection()

            ' Replace with your namespace + filename
            Dim fontResourceName As String = "HRMAXV16.Montserrat-Regular.ttf"

            Using fontStream = Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(fontResourceName)
                If fontStream Is Nothing Then
                    Throw New Exception($"Font resource '{fontResourceName}' not found.")
                End If

                Dim fontData(fontStream.Length - 1) As Byte
                fontStream.Read(fontData, 0, fontData.Length)

                Dim fontPtr As IntPtr = Marshal.AllocCoTaskMem(fontData.Length)
                Marshal.Copy(fontData, 0, fontPtr, fontData.Length)

                pfc.AddMemoryFont(fontPtr, fontData.Length)
                Marshal.FreeCoTaskMem(fontPtr)
            End Using
        End If
    End Sub

    ' Get the Montserrat font
    Public Function GetMontserrat(size As Single, style As FontStyle) As Font
        If pfc Is Nothing Then LoadCustomFonts()
        Return New Font(pfc.Families(0), size, style)
    End Function
End Module
