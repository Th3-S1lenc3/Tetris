Namespace Shapes
    Public Class Base
        Protected blockPositions As New List(Of Point)
        Protected Blocks As Integer = 4
        Protected currentX As Integer
        Protected currentY As Integer
        Protected currentOrigin As Point
        Protected forbiddenIndexes() As Integer
        Protected mvLeft As Boolean
        Protected mvRight As Boolean
        Protected mvDown As Boolean
        Protected canMove As Boolean = True
        Protected canAdd As Boolean = True
        Protected canRotate As Boolean = True
        Public Shape As Object
        Protected ShapeColor As Integer

        Protected Event orientationChanged(Orientation As Integer, sender As Object, e As EventArgs)
        Public Sub getDebugInfo()
#Disable Warning BC42104 ' Variable is used before it has been assigned a value
            Console.WriteLine("Getting debug info")
            Dim debugWindow = frmDebug.rtbDebug
            debugWindow.Clear()
            If blockPositions.Count <> 0 Then
                Dim firstPos = blockPositions.First
                Dim lastPos = blockPositions.Last
                Dim movingStatus As String
                Select Case mvLeft
                    Case True
                        movingStatus = "Left"
                    Case False
                        movingStatus = "Not Left"
                End Select
                Select Case mvRight
                    Case True
                        movingStatus = "Right"
                    Case False
                        movingStatus = "Not Right"
                End Select
                For Each blockPosition In blockPositions
                    debugWindow.AppendText($"Block {blockPositions.IndexOf(blockPosition)} Position: X: {blockPosition.X}; Y: {blockPosition.Y}; {vbCrLf}")
                Next
                debugWindow.AppendText($"First Pos: X: {firstPos.X}; Y: {firstPos.Y}; {vbCrLf}")
                debugWindow.AppendText($"Last Pos: X: {lastPos.X}; Y: {lastPos.Y}; {vbCrLf}")

                debugWindow.AppendText($"Moving: {movingStatus}; {vbCrLf}")
                debugWindow.AppendText($"Current Origin: X: {currentOrigin.X}; Y: {currentOrigin.Y}; {vbCrLf}")
                debugWindow.AppendText($"mvLeft: {mvLeft}; {vbCrLf}")
                debugWindow.AppendText($"mvRight: {mvRight}; {vbCrLf}")
                debugWindow.AppendText($"mvDown: {mvDown}; {vbCrLf}")
                debugWindow.AppendText($"canMove: {canMove}; {vbCrLf}")
            Else
                Console.WriteLine("Block Positions is empty")
            End If

#Enable Warning BC42104 ' Variable is used before it has been assigned a value
        End Sub

        Protected _X As Integer
        Public Property X() As Integer
            Get
                Return _X
            End Get
            Set(value As Integer)
                _X = value
            End Set
        End Property

        Protected _Y As Integer
        Public Property Y() As Integer
            Get
                Return _Y
            End Get
            Set(value As Integer)
                _Y = value
            End Set
        End Property

        Protected _shapeType As String
        Protected validShapes() As String = {"I", "J", "L", "O", "S", "T", "Z", "LC_Template"}
        Public Property ShapeType As String
            Get
                Return _shapeType
            End Get
            Set(value As String)
                If Not validShapes.Contains(value) Then
                    Throw New Exception("Invalid Shape")
                End If
                _shapeType = value
            End Set
        End Property

        Protected _orientation As Integer
        Protected validOrientations() As Integer = {0, 90, 180, 270}
        Public Property Orientation As Integer
            Get
                Return _orientation
            End Get
            Set(value As Integer)
                If value = 360 Then
                    value = 0
                ElseIf value = -90 Then
                    value = 270
                End If

                If Not validOrientations.Contains(value) Then
                    Throw New Exception($"Invalid Orientation: {value}")
                End If
                    _orientation = value
                RaiseEvent orientationChanged(value, Me, New EventArgs)
            End Set
        End Property

        Public Sub setShape(Orientation As Integer, sender As Object, e As EventArgs) Handles Me.orientationChanged
            Select Case ShapeType
                Case "I"
                    Select Case Orientation
                        Case 0
                            Shape = New I._0
                        Case 90
                            Shape = New I._90
                        Case 180
                            Shape = New I._180
                        Case 270
                            Shape = New I._270
                    End Select
                Case "J"
                    Select Case Orientation
                        Case 0
                            Shape = New J._0
                        Case 90
                            Shape = New J._90
                        Case 180
                            Shape = New J._180
                        Case 270
                            Shape = New J._270
                    End Select
                Case "L"
                    Select Case Orientation
                        Case 0
                            Shape = New L._0
                        Case 90
                            Shape = New L._90
                        Case 180
                            Shape = New L._180
                        Case 270
                            Shape = New L._270
                    End Select
                Case "O"
                    Select Case Orientation
                        Case 0
                            Shape = New O._0
                        Case 90
                            Shape = New O._90
                        Case 180
                            Shape = New O._180
                        Case 270
                            Shape = New O._270
                    End Select
                Case "S"
                    Select Case Orientation
                        Case 0
                            Shape = New S._0
                        Case 90
                            Shape = New S._90
                        Case 180
                            Shape = New S._180
                        Case 270
                            Shape = New S._270
                    End Select
                Case "T"
                    Select Case Orientation
                        Case 0
                            Shape = New T._0
                        Case 90
                            Shape = New T._90
                        Case 180
                            Shape = New T._180
                        Case 270
                            Shape = New T._270
                    End Select
                Case "Z"
                    Select Case Orientation
                        Case 0
                            Shape = New Z._0
                        Case 90
                            Shape = New Z._90
                        Case 180
                            Shape = New Z._180
                        Case 270
                            Shape = New Z._270
                    End Select
                Case "LC_Template"
                    Shape = New LC_Template._0
            End Select
        End Sub

        Private Sub getShapeColor()
            Select Case ShapeType
                Case "I"
                    ShapeColor = I.Color.getColor
                Case "J"
                    ShapeColor = J.Color.getColor
                Case "L"
                    ShapeColor = L.Color.getColor
                Case "O"
                    ShapeColor = O.Color.getColor
                Case "S"
                    ShapeColor = S.Color.getColor
                Case "T"
                    ShapeColor = T.Color.getColor
                Case "Z"
                    ShapeColor = Z.Color.getColor
            End Select
        End Sub

#Disable Warning BC42353 ' Function doesn't return a value on all code paths
        Protected Function findCollidingIndex(ByVal blockPositions As List(Of Point), ByVal newX As Integer, ByVal newY As Integer) As Integer
            For Each blockPosition In blockPositions
                If blockPosition.X = newX And blockPosition.Y = newY Then
                    Return blockPositions.IndexOf(blockPosition)
                End If
            Next
        End Function
#Enable Warning BC42353 ' Function doesn't return a value on all code paths

        Public Sub addShape()
            Console.WriteLine("Adding Shape")
            setShape(Orientation, Me, New EventArgs)
            getShapeColor()

            currentOrigin = New Point(X, Y)

            If canAddShape() Then
                blockPositions.AddRange(Shape.Positions(currentOrigin))
                For Each blockPosition In blockPositions
                    frmTetris.grid(blockPosition.X, blockPosition.Y) = ShapeColor
                Next
            End If
            getDebugInfo()
        End Sub

        Private Function canAddShape()
            canAdd = True
            Dim newPositions As New List(Of Point)
            newPositions = Shape.Positions(currentOrigin)
            For Each position In newPositions
                If Not frmTetris.grid(position.X, position.Y) = 0 Then
                    canAdd = False
                End If
            Next

            If canAdd Then
                Return True
            Else
                Console.WriteLine("Cannot Add Shape.")
                frmTetris.stopGame()
                Return False
            End If
        End Function

        Public Sub left()
            Console.WriteLine("Moving Left")
            If canMoveLeft() Then
                Console.WriteLine("True")
                mvLeft = True
            Else
                Console.WriteLine("False")
                mvLeft = False
            End If

            If mvLeft Then
                currentOrigin.X -= 1
                drawShape()
                getDebugInfo()
            End If
        End Sub

        Public Function canMoveLeft() As Boolean
            canMove = True
            getDebugInfo()
            forbiddenIndexes = Shape.ForbiddenIndexes("Left")
            For Each blockPosition In blockPositions
                If Not forbiddenIndexes.Contains(blockPositions.IndexOf(blockPosition)) Then
                    Dim newX = blockPosition.X - 1
                    Dim newY = blockPosition.Y
                    Dim minX = 0

                    If newX < minX Then
                        canMove = False
                    ElseIf Not frmTetris.grid(newX, newY) = 0 Then
                        Console.WriteLine($"Cannot Move. {blockPositions.IndexOf(blockPosition)} colliding with {findCollidingIndex(blockPositions, newX, newY)}")
                        canMove = False
                    End If
                End If
            Next

            If canMove = False Then
                Return False
            Else
                Return True
            End If
        End Function

        Public Sub right()
            Console.WriteLine("Moving Right")
            Dim lastPos = blockPositions(blockPositions.Count - 1)
            Dim newBlockPositions As New List(Of Point)
            If canMoveRight() Then
                Console.WriteLine("True")
                mvRight = True
            Else
                Console.WriteLine("False")
                mvRight = False
            End If

            If mvRight Then
                currentOrigin.X += 1
                drawShape()
                getDebugInfo()
            End If
        End Sub

        Public Function canMoveRight() As Boolean
            canMove = True
            getDebugInfo()
            forbiddenIndexes = Shape.ForbiddenIndexes("Right")
            For Each blockPosition In blockPositions
                If Not forbiddenIndexes.Contains(blockPositions.IndexOf(blockPosition)) Then
                    Dim newX = blockPosition.X + 1
                    Dim newY = blockPosition.Y
                    Dim maxX = frmTetris.gridColumns

                    If newX >= maxX Then
                        canMove = False
                    ElseIf Not frmTetris.grid(newX, newY) = 0 Then
                        Console.WriteLine($"Cannot Move. {blockPositions.IndexOf(blockPosition)} colliding with {findCollidingIndex(blockPositions, newX, newY)}")
                        canMove = False
                    End If
                End If
            Next

            If canMove = False Then
                Return False
            Else
                Return True
            End If
        End Function

        Public Sub down()
            Console.WriteLine("Moving Down")
            If canMoveDown() Then
                Console.WriteLine("True")
                mvDown = True
            Else
                Console.WriteLine("False")
                mvDown = False
            End If

            If mvDown Then
                currentOrigin.Y -= 1
                drawShape()
                getDebugInfo()
            End If
        End Sub

        Private Function canMoveDown() As Boolean
            canMove = True
            forbiddenIndexes = Shape.ForbiddenIndexes("Down")
            For Each blockPosition In blockPositions
                If Not forbiddenIndexes.Contains(blockPositions.IndexOf(blockPosition)) Then
                    Dim newX = blockPosition.X
                    Dim newY = blockPosition.Y - 1
                    Dim minY = 0

                    If newY < minY Then
                        canMove = False
                    ElseIf Not frmTetris.grid(newX, newY) = 0 Then
                        Console.WriteLine($"Cannot Move. {blockPositions.IndexOf(blockPosition)} colliding with {findCollidingIndex(blockPositions, newX, newY)}")
                        canMove = False
                    End If
                End If
            Next

            If canMove = False Then
                frmTetris.invalidateShape()
                Return False
            Else
                Return True
            End If
        End Function

        Public Sub hardDrop()
            mvDown = True
            While mvDown
                down()
            End While
        End Sub

        Public Sub rotate()
            Console.WriteLine("Rotating")

            If canRotateShape() Then
                Console.WriteLine("True")
                canRotate = True
            Else
                Console.WriteLine("False")
                canRotate = False
            End If

            If canRotate Then
                Orientation += 90
                drawShape()
                getDebugInfo()
            End If
        End Sub

        Private Function canRotateShape()
            canRotate = True
            Dim oldPositions As New List(Of Point)
            Dim newPositions As List(Of Point)
            oldPositions = blockPositions
            Orientation += 90
            newPositions = Shape.Positions(currentOrigin)
            forbiddenIndexes = Shape.ForbiddenIndexes("Rotate")

            For Each blockPosition In oldPositions
                frmTetris.grid(blockPosition.X, blockPosition.Y) = 0
            Next

            For Each position In newPositions
                Try
                    If Not frmTetris.grid(position.X, position.Y) = 0 Then
                        canRotate = False
                    End If
                Catch ex As Exception
                    canRotate = False
                End Try
            Next

            Orientation -= 90

            For Each blockPosition In oldPositions
                frmTetris.grid(blockPosition.X, blockPosition.Y) = ShapeColor
            Next

            If canRotate Then
                Return True
            Else
                Return False
            End If
        End Function

        Private Sub drawShape()
            Dim newBlockPositions As List(Of Point)
            newBlockPositions = Shape.Positions(currentOrigin)

            For Each blockPosition In blockPositions
                frmTetris.grid(blockPosition.X, blockPosition.Y) = 0
            Next

            For Each newBlockPosition In newBlockPositions
                frmTetris.grid(newBlockPosition.X, newBlockPosition.Y) = ShapeColor
            Next

            blockPositions.Clear()
            blockPositions.AddRange(newBlockPositions)
            frmTetris.gridPainted = False
            frmTetris.Invalidate()
        End Sub
    End Class

    Public Class shapeTranslator
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
        Public Function getColorFromIndex(ByVal colorIndex As Integer) As String
            Select Case colorIndex
                Case 0
                    Return "White"
                Case 1
                    Return "Cyan"
                Case 2
                    Return "Blue"
                Case 3
                    Return "Orange"
                Case 4
                    Return "Yellow"
                Case 5
                    Return "Green"
                Case 6
                    Return "Purple"
                Case 7
                    Return "Red"
            End Select
        End Function

        Public Function getShapeFromIndex(colorIndex As Integer)
            Select Case colorIndex
                Case 0
                    Return "None"
                Case 1
                    Return "Shape_I"
                Case 2
                    Return "Shape_J"
                Case 3
                    Return "Shape_L"
                Case 4
                    Return "Shape_O"
                Case 5
                    Return "Shape_S"
                Case 6
                    Return "Shape_T"
                Case 7
                    Return "Shape_Z"
            End Select
        End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths
    End Class
End Namespace

