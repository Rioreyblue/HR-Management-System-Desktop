Public Module modCheckedComboBox
    Public Class mItem
        Private _name As String
        Private _code As String

        Public Sub New(ByVal name As String, ByVal code As String)
            _name = name
            _code = code
        End Sub

        Public Property Name As String
            Get
                Return _name
            End Get
            Set(ByVal value As String)
                _name = value
            End Set
        End Property

        Public Property Code As String
            Get
                Return _code
            End Get
            Set(ByVal value As String)
                _code = value
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return _code & " - " & _name
        End Function
    End Class

End Module
