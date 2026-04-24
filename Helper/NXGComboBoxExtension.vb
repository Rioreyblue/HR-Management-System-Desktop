Imports System.Runtime.CompilerServices

Module NXGComboBoxExtension
    <Extension()> _
    Public Function ColumnValue(ByVal combobox As Windows.Forms.ComboBox, ByVal column As Integer) As String
        Try
            ColumnValue = DirectCast(ComboBox.SelectedItem, System.Data.DataRowView).Row.ItemArray(column).ToString()
        Catch ex As Exception
            ColumnValue = String.Empty
        End Try
    End Function
End Module
