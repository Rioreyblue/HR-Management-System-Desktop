Imports System.Runtime.CompilerServices

Module modStringExtensions
    <Extension()>
    Public Function ToProperCase(ByVal str As String) As String
        If String.IsNullOrEmpty(str) Then Return ""
        Return StrConv(str, VbStrConv.ProperCase)
    End Function
End Module
