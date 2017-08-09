

Public Class ValueAndTextBL
    Private _value As Object
    Private _text As String


    Sub New(ByVal value As Object, ByVal text As String)
        _value = value
        _text = text
    End Sub
    Public Property Value() As Object
        Get
            Return _value
        End Get
        Set(ByVal value As Object)
            _value = value
        End Set
    End Property


    Public Property Text() As String
        Get
            Return _text
        End Get
        Set(ByVal value As String)
            _text = value
        End Set
    End Property


    Public Overrides Function ToString() As String
        Return _text
    End Function


End Class


