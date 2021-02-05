Namespace Shapes.J
    Public Class Color
        Private Shared _color As Integer = 2
        Public Shared Property getColor As Integer
            Get
                Return _color
            End Get
            Set(value As Integer)
                _color = value
            End Set
        End Property
    End Class

    Public Class _0
        Public Shared Function Positions(ByVal origin As Point) As List(Of Point)
            Dim shape As New List(Of Point)
            shape.Add(New Point(origin.X - 1, origin.Y + 1))
            shape.Add(New Point(origin.X - 1, origin.Y))
            shape.Add(New Point(origin.X, origin.Y))
            shape.Add(New Point(origin.X + 1, origin.Y))
            Return shape
        End Function

        Protected Shared _forbiddenIndexes As Integer()

        Public Shared Function ForbiddenIndexes(ByVal Direction As String) As Integer()
            Dim indexes As Integer()
            Select Case Direction
                Case "Down"
                    indexes = {0}
                Case "Left"
                    indexes = {2, 3}
                Case "Right"
                    indexes = {1, 2}
                Case "Rotate"
                    indexes = {2}
            End Select

            Return indexes
        End Function
    End Class

    Public Class _90
        Public Shared Function Positions(ByVal origin As Point) As List(Of Point)
            Dim shape As New List(Of Point)
            shape.Add(New Point(origin.X + 1, origin.Y + 1))
            shape.Add(New Point(origin.X, origin.Y + 1))
            shape.Add(New Point(origin.X, origin.Y))
            shape.Add(New Point(origin.X, origin.Y - 1))
            Return shape
        End Function

        Protected Shared _forbiddenIndexes As Integer()

        Public Shared Function ForbiddenIndexes(ByVal Direction As String) As Integer()
            Dim indexes As Integer()
            Select Case Direction
                Case "Down"
                    indexes = {1, 2}
                Case "Left"
                    indexes = {0}
                Case "Right"
                    indexes = {1}
                Case "Rotate"
                    indexes = {2}
            End Select

            Return indexes
        End Function
    End Class

    Public Class _180
        Public Shared Function Positions(ByVal origin As Point) As List(Of Point)
            Dim shape As New List(Of Point)
            shape.Add(New Point(origin.X + 1, origin.Y - 1))
            shape.Add(New Point(origin.X - 1, origin.Y))
            shape.Add(New Point(origin.X, origin.Y))
            shape.Add(New Point(origin.X - 1, origin.Y))
            Return shape
        End Function

        Public Shared Function ForbiddenIndexes(ByVal Direction As String) As Integer()
            Dim indexes As Integer()
            Select Case Direction
                Case "Down"
                    indexes = {1}
                Case "Left"
                    indexes = {1, 2}
                Case "Right"
                    indexes = {2, 3}
                Case "Rotate"
                    indexes = {2}
            End Select

            Return indexes
        End Function
    End Class

    Public Class _270
        Public Shared Function Positions(ByVal origin As Point) As List(Of Point)
            Dim shape As New List(Of Point)
            shape.Add(New Point(origin.X - 1, origin.Y - 1))
            shape.Add(New Point(origin.X, origin.Y - 1))
            shape.Add(New Point(origin.X, origin.Y))
            shape.Add(New Point(origin.X, origin.Y + 1))
            Return shape
        End Function

        Public Shared Function ForbiddenIndexes(ByVal Direction As String) As Integer()
            Dim indexes As Integer()
            Select Case Direction
                Case "Down"
                    indexes = {2, 3}
                Case "Left"
                    indexes = {1}
                Case "Right"
                    indexes = {0}
                Case "Rotate"
                    indexes = {2}
            End Select

            Return indexes
        End Function
    End Class
End Namespace