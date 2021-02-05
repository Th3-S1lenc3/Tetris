Namespace Shapes.LC_Template
    Public Class Color
        Private Shared _color As Integer = 1
        Public Shared Property getColor As Integer
            Get
                Return _color
            End Get
            Set(value As Integer)
                _color = value
            End Set
        End Property
    End Class

    Public Class block
        Private _position As Point
        Public Property position As Point
            Get
                Return _position
            End Get
            Set(value As Point)
                _position = value
            End Set
        End Property

        Private _color As Integer
        Public Property color As Integer
            Get
                Return _color
            End Get
            Set(value As Integer)
                _color = value
            End Set
        End Property
    End Class

    Public Class _0
        Protected Shared _positions As List(Of Point)
        Public Shared Property Positions As List(Of Point)
            Get
                Return _positions
            End Get
            Set(value As List(Of Point))
                _positions = value
            End Set
        End Property

        Protected Shared _forbiddenIndexes As Integer()
        Public Shared Property ForbiddenIndexes As Integer()
            Get
                Return _forbiddenIndexes
            End Get
            Set(value As Integer())
                _forbiddenIndexes = value
            End Set
        End Property
    End Class
End Namespace