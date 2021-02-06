Imports System.IO
Imports System.Xml

Public Class scoreManager
    Public score As Integer
    Public Shared line1Points As Integer = 40
    Public Shared line2Points As Integer = 100
    Public Shared line3Points As Integer = 300
    Public Shared line4Points As Integer = 1200
    Public Shared lineElsePoints As Integer = 1500

    Public Sub add(ByVal lines As Integer, ByVal level As Integer)
        Select Case lines
            Case 1
                score += line1Points * (level + 1)
            Case 2
                score += line2Points * (level + 1)
            Case 3
                score += line3Points * (level + 1)
            Case 4
                score += line4Points * (level + 1)
            Case Else
                score += lineElsePoints * (level + 1)
        End Select
    End Sub

    Public Sub remove(ByVal lines As Integer)

    End Sub
End Class

Public Class Config
    Private configFile As String = FileSystem.CurDir & "\config.xml"
    Private config As New XmlDocument()
    Private configNode As XmlNodeList
    Public Sub New()
        config.Load(configFile)
    End Sub

    Public Function read(ByVal nodeToRead As String) As XmlNodeList
        configNode = config.GetElementsByTagName(nodeToRead)
        Return configNode
    End Function

    Public Sub write(ByVal parent As String, ByVal child As String, ByVal newValue As String)
        configNode = config.GetElementsByTagName(parent)
        For Each node As XmlNode In configNode
            node.SelectSingleNode(child).InnerText = newValue
        Next
        config.Save(configFile)
    End Sub

    Public Sub delete()

    End Sub
End Class

Public Class gameControls
    Public left As String
    Public right As String
    Public hardDrop As String
    Public rotate As String

    Public Sub New()
        loadControls()
    End Sub

    Private Sub loadControls()
        Dim config As New Config
        Dim controls As XmlNodeList = config.read("controls")
        For Each node As XmlNode In controls
            left = node.SelectSingleNode("left").InnerText
            right = node.SelectSingleNode("right").InnerText
            hardDrop = node.SelectSingleNode("hardDrop").InnerText
            rotate = node.SelectSingleNode("rotate").InnerText
        Next
    End Sub
End Class

Public Class shapeManager
    Private numOfShapesToGenerate As Integer = 3
    Public shapesLibrary As New List(Of Integer)
    Private rng As New Random
    Private shapeTranslator As New Shapes.shapeTranslator

    Public Sub New()
        initLibrary()
    End Sub

    Private Sub initLibrary()
        shapesLibrary.Clear()
        Console.WriteLine("Generating New Shapes.")
        For i As Integer = 1 To numOfShapesToGenerate
            shapesLibrary.Add(rng.Next(1, 7))
        Next
    End Sub

    Public Sub spawnNew()
#Disable Warning BC42104 ' Variable is used before it has been assigned a value
        Console.WriteLine("Spawning new shape")
        Dim toSpawn = shapeTranslator.getShapeFromIndex(shapesLibrary.First)
        Dim newActiveShape
        Select Case toSpawn
            Case "Shape_I"
                newActiveShape = New Shapes.Base With {.X = frmTetris.spawnX, .Y = frmTetris.spawnY, .Orientation = 0, .ShapeType = "I"}
            Case "Shape_J"
                newActiveShape = New Shapes.Base With {.X = frmTetris.spawnX, .Y = frmTetris.spawnY, .Orientation = 0, .ShapeType = "J"}
            Case "Shape_L"
                newActiveShape = New Shapes.Base With {.X = frmTetris.spawnX, .Y = frmTetris.spawnY, .Orientation = 0, .ShapeType = "L"}
            Case "Shape_O"
                newActiveShape = New Shapes.Base With {.X = frmTetris.spawnX, .Y = frmTetris.spawnY, .Orientation = 0, .ShapeType = "O"}
            Case "Shape_S"
                newActiveShape = New Shapes.Base With {.X = frmTetris.spawnX, .Y = frmTetris.spawnY, .Orientation = 0, .ShapeType = "S"}
            Case "Shape_T"
                newActiveShape = New Shapes.Base With {.X = frmTetris.spawnX, .Y = frmTetris.spawnY, .Orientation = 0, .ShapeType = "T"}
            Case "Shape_Z"
                newActiveShape = New Shapes.Base With {.X = frmTetris.spawnX, .Y = frmTetris.spawnY, .Orientation = 0, .ShapeType = "Z"}
        End Select
        newActiveShape.addShape()
        frmTetris.activeShape = newActiveShape
        shapesLibrary.Remove(shapesLibrary.First)
        genNewShape()
        frmTetris.drawNextShapesToGrid()
#Enable Warning BC42104 ' Variable is used before it has been assigned a value
    End Sub

    Private Sub genNewShape()
        Console.WriteLine("Generating New Shape For Next Shapes.")
        shapesLibrary.Add(rng.Next(1, 8))
    End Sub
End Class

Public Class lineManager
    Private scoreManager = frmTetris.scoreManager
    Private shapeTemplate = New Shapes.LC_Template._0
    Private grid = frmTetris.grid
    Private linesComplete As New List(Of Integer)
    Private Event lineCleared(sender As Object, e As EventArgs)

    Public Sub checkLines()
        Console.WriteLine("Checking Lines")
        Dim lineComplete As Boolean = True

        For row = 0 To frmTetris.gridRows
            For col As Integer = 0 To frmTetris.gridColumns - 1
                If grid(col, row) = 0 Then
                    lineComplete = False
                End If

                Console.WriteLine($"Line {row}; Column {col}: {grid(col, row)}")
            Next

            If lineComplete Then
                linesComplete.Add(row)
                Console.WriteLine($"Line {row}: Complete")
            End If
        Next

        If linesComplete.Count > 0 Then
            scoreManager.add(linesComplete.Count, frmTetris.level)
            clearLines()
        End If

        linesComplete.Clear()
    End Sub

    Private Sub clearLines()
        Console.WriteLine("Clearing Lines")
        For Each line In linesComplete
            For col As Integer = 0 To frmTetris.gridColumns - 1
                grid(col, line) = 0
            Next
        Next
        frmTetris.gridPainted = False
        frmTetris.Invalidate()
        'RaiseEvent lineCleared(Me, New EventArgs)
    End Sub

    Private Sub checkForFloatingShape(sender As Object, e As EventArgs) Handles Me.lineCleared
        Dim blocks As New List(Of XElement)
        Dim minXCandidates As New List(Of Integer)
        Dim minYCandidates As New List(Of Integer)
        Dim maxXCandidates As New List(Of Integer)
        Dim maxYCandidates As New List(Of Integer)
        Dim minX As Integer
        Dim minY As Integer
        Dim maxX As Integer
        Dim maxY As Integer
        Dim topPiece As Boolean = False
        Dim leftEdgePiece As Boolean = False
        Dim rightEdgePiece As Boolean = False
        Dim bottomPiece As Boolean = False
        Dim centrePiece As Boolean = False

        For row = 0 To frmTetris.gridColumns - 1
            For col = 0 To frmTetris.gridColumns - 1
                If Not grid(col, row) = 0 Then
                    If grid(col, row + 1) = 0 Then
                        topPiece = True
                    End If
                    If grid(col - 1, row) = 0 Then
                        leftEdgePiece = True
                    End If
                    If grid(col + 1, row) = 0 Then
                        rightEdgePiece = True
                    End If
                    If grid(col, row - 1) = 0 Then
                        bottomPiece = True
                    End If
                    If topPiece = False And leftEdgePiece = False And rightEdgePiece = False And bottomPiece = False Then
                        centrePiece = True
                    End If

                    Dim newBlock As XElement = New XElement("block",
                                                            New XAttribute("x", col),
                                                            New XAttribute("y", row),
                                                            New XElement("topPiece", topPiece),
                                                            New XElement("leftEdgePiece", leftEdgePiece),
                                                            New XElement("rightEdgePiece", rightEdgePiece),
                                                            New XElement("bottomPiece", bottomPiece),
                                                            New XElement("centrePiece", centrePiece))
                    blocks.Add(newBlock)
                End If
            Next
        Next

        For Each block In blocks
            Dim x = block.Attribute("x").Value
            Dim y = block.Attribute("y").Value
            Dim isTopPiece = block.Element("topPiece").Value
            Dim isLeftEdgePiece = block.Element("leftEdgePiece").Value
            Dim isRightEdgePiece = block.Element("rightEdgePiece").Value
            Dim isBottomPiece = block.Element("bottomPiece").Value
            Dim isCentrePiece = block.Element("centrePiece").Value

            If isTopPiece Then
                minYCandidates.Add(y)
            End If
            If isLeftEdgePiece Then
                minXCandidates.Add(x)
            End If
            If isRightEdgePiece Then
                maxXCandidates.Add(x)
            End If
            If isBottomPiece Then
                maxYCandidates.Add(y)
            End If
        Next

        minY = minYCandidates.Min
        minX = minXCandidates.Min
        maxX = maxXCandidates.Max
        maxY = maxYCandidates.Max

        For row = minX To maxX
            For col = minY To maxY
                If Not grid(row, col) = 0 Then
                    shapeTemplate.Positions.Add(New Shapes.LC_Template.block With {.position = New Point(row, col), .color = grid(row, col)})
                    If Not row = minY Then
                        shapeTemplate.ForbiddenIndexes.Add(shapeTemplate.Positions.Last)
                    End If
                End If
            Next
        Next
    End Sub
End Class