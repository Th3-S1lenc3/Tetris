Imports System.Xml

Public Class frmTetris
    ' Cell Variable
    Private cellWidth As Integer = 25
    Private cellHeight As Integer = 25
    ' Main Grid
    Public gridStart_X As Integer = 155
    Public gridStart_Y As Integer = 595
    Private grid_X As Integer
    Private grid_Y As Integer
    Public gridRows As Integer = 20
    Public gridColumns As Integer = 10
    Public grid(gridColumns - 1, gridRows) As Integer
    Public gridPainted As Boolean = False
    ' Next Shapes Grid
    Public nextShapesStart_X = 427
    Public nextShapesStart_Y = 145
    Public nextShapes_gridRows = 10
    Public nextShapes_gridColumns = 5
    Public nextShapes_grid(nextShapes_gridColumns, nextShapes_gridRows)
    Private nextShapes_X
    Private nextShapes_Y
    Public nextShapes_gridPainted As Boolean = False
    ' Game Variables
    Public level As Integer = 1
    Private gamePaused As Boolean = False
    Private gameStarted As Boolean = False
    Public spawnX As Integer = 4
    Public spawnY As Integer = 18
    Public activeShape
    Private nextShape
    Private debug As Boolean = True
    ' Game Classes
    Public scoreManager As New scoreManager
    Private gameControls As New gameControls
    Private shapeManager As New shapeManager
    Private shapeTranslator As New Shapes.shapeTranslator
    Private lineManager
    ' Event
    Private Event shapeInvalidated(sender As Object, e As EventArgs)
    Private Event gameStopped(sender As Object, e As EventArgs)

    Private Sub frmTetris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lineManager = New lineManager
        initializeGrid()
        intializeNextShapes_grid()
        drawNextShapesToGrid()
        initGame()
        frmConsole.Show()
        frmDebug.Show()
    End Sub

    Private Sub frmTetris_Active(sender As Object, e As EventArgs) Handles MyBase.Activated
        ActiveControl = Nothing
    End Sub

    Private Sub frmTetris_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles MyBase.Paint
        If Not gridPainted Then
            grid_X = gridStart_X
            grid_Y = gridStart_Y
            drawGridToScreen(e)
            nextShapes_X = nextShapesStart_X
            nextShapes_Y = nextShapesStart_Y
            drawNextShapesGridToScreen(e)
            gridPainted = True
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If gamePaused And Not debug Then
            Console.WriteLine("Game Paused")
            Return True
        ElseIf activeShape Is Nothing Then
            Console.WriteLine("No Active Shape")
            Return True
        ElseIf Not gameStarted And Not debug Then
            Console.WriteLine("Game Not Started")
            Return True
        End If
        Select Case keyData.ToString
            Case gameControls.left
                mvLeft()
                Return True
            Case gameControls.right
                mvRight()
                Return True
            Case gameControls.hardDrop
                hardDrop()
                Return True
            Case gameControls.rotate
                rotate()
                Return True
            Case "Up"
                Return True
            Case "Tab"
                'resetGrid()
                Return True
            Case "Menu, Alt"
                'resetGrid()
                Return True
        End Select
        Return False
    End Function

    Private Sub initializeGrid()
        Console.WriteLine("Intializing Grid")
        For row As Integer = 0 To gridRows - 1
            For col As Integer = 0 To gridColumns - 1
                grid(col, row) = 0
            Next
        Next
    End Sub

    Private Sub intializeNextShapes_grid()
        Console.WriteLine("Intializing Next Shapes Grid")
        RemovePictureBoxes()
        For row As Integer = 0 To nextShapes_gridRows - 1
            For col As Integer = 0 To nextShapes_gridColumns - 1
                nextShapes_grid(col, row) = 0
            Next
        Next
    End Sub

    Public Sub RemovePictureBoxes()
        Dim blocks = Controls.OfType(Of PictureBox)()
        For Each block In blocks
            block.Visible = False
            'block.Dispose()
        Next
    End Sub

    Private Sub drawGridToScreen(ByVal e As PaintEventArgs)
        Dim pen As Pen = New Pen(Brushes.Black)
        Dim gridCell As Rectangle = New Rectangle With {
            .Width = cellWidth,
            .Height = cellHeight
        }

        For row As Integer = 0 To gridRows - 1
            For col As Integer = 0 To gridColumns - 1
                gridCell.Location = New Point(grid_X, grid_Y)
                e.Graphics.FillRectangle(New SolidBrush(Color.FromName(shapeTranslator.getColorFromIndex(grid(col, row)))), gridCell)
                e.Graphics.DrawRectangle(pen, gridCell)
                grid_X += cellWidth
            Next
            grid_X = gridStart_X
            grid_Y -= cellHeight
        Next
        Console.WriteLine()
        pen.Dispose()
    End Sub

    Private Sub drawNextShapesGridToScreen(e As PaintEventArgs)
        Dim cell As PictureBox
        Dim cellColor As Color
        Dim cellPosition
        SuspendLayout()
        For row As Integer = 0 To nextShapes_gridRows - 1
            For col As Integer = 0 To nextShapes_gridColumns - 1
                If Not nextShapes_grid(col, row) = 0 Then
                    cell = New PictureBox
                    cell.Location = New Point(nextShapes_X, nextShapes_Y)
                    cellColor = Color.FromName(shapeTranslator.getColorFromIndex(nextShapes_grid(col, row)))
                    cellPosition = New Point(nextShapes_X, nextShapes_Y)
                    CType(cell, System.ComponentModel.ISupportInitialize).BeginInit()
                    cell.Size = New Size(cellWidth, cellHeight)
                    cell.BackColor = cellColor
                    cell.BorderStyle = BorderStyle.FixedSingle
                    cell.Location = cellPosition
                    cell.TabIndex = 0
                    cell.TabStop = False
                    cell.Name = "Block"
                    Controls.Add(cell)
                    Controls.SetChildIndex(cell, 0)
                End If
                nextShapes_X += cellWidth
            Next
            nextShapes_X = nextShapesStart_X
            nextShapes_Y += cellHeight
        Next
        Console.WriteLine()
        ResumeLayout(False)
    End Sub

    Public Sub drawNextShapesToGrid()
        Dim nextShapePositions As List(Of Point)
        intializeNextShapes_grid()
        gridPainted = False
        Me.Invalidate()
        Dim x = 1
        Dim y = 2
        Dim newShapeName
        For Each newShape In shapeManager.shapesLibrary
            newShapeName = shapeTranslator.getShapeFromIndex(newShape)
            setNextShape(shapeTranslator.getShapeFromIndex(newShape), x, y)
            nextShape.setShape(nextShape.Orientation, Me, New EventArgs)
            nextShapePositions = nextShape.Shape.Positions(New Point(x, y))
            For Each block In nextShapePositions
                nextShapes_grid(block.X, block.Y) = newShape
            Next
            Console.WriteLine($"X: {x}; Y: {y};")
            y += 3
        Next
    End Sub

    Private Function setNextShape(shapeName As String, shapeX As Integer, shapeY As Integer)
        Select Case shapeName
            Case "Shape_I"
                nextShape = New Shapes.Base With {.X = shapeX, .Y = shapeY, .Orientation = 0, .ShapeType = "I"}
            Case "Shape_J"
                nextShape = New Shapes.Base With {.X = shapeX, .Y = shapeY, .Orientation = 0, .ShapeType = "J"}
            Case "Shape_L"
                nextShape = New Shapes.Base With {.X = shapeX, .Y = shapeY, .Orientation = 0, .ShapeType = "L"}
            Case "Shape_O"
                nextShape = New Shapes.Base With {.X = shapeX, .Y = shapeY, .Orientation = 0, .ShapeType = "O"}
            Case "Shape_S"
                nextShape = New Shapes.Base With {.X = shapeX, .Y = shapeY, .Orientation = 0, .ShapeType = "S"}
            Case "Shape_T"
                nextShape = New Shapes.Base With {.X = shapeX, .Y = shapeY, .Orientation = 0, .ShapeType = "T"}
            Case "Shape_Z"
                nextShape = New Shapes.Base With {.X = shapeX, .Y = shapeY, .Orientation = 0, .ShapeType = "Z"}
        End Select
    End Function

    Private Sub tmrMVShape_Tick(sender As Object, e As EventArgs) Handles tmrMVShape.Tick
        mvDown()
    End Sub

    Private Sub EditConfigToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditConfigToolStripMenuItem.Click
        frmConfig.Show()
        ActiveControl = Nothing
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
        ActiveControl = Nothing
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        frmHelp.Show()
        ActiveControl = Nothing
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        frmHelp.Show()
        ActiveControl = Nothing
    End Sub

    Private Sub btnStartStopReset_Click(sender As Object, e As EventArgs) Handles btnStartStopReset.Click
        Dim buttonMode As String = btnStartStopReset.Text
        Select Case buttonMode
            Case "Start"
                startGame()
            Case "Stop"
                stopGame()
            Case "Reset"
                resetGame()
        End Select
        ActiveControl = Nothing
    End Sub

    Private Sub btnPauseResume_Click(sender As Object, e As EventArgs) Handles btnPauseResume.Click
        Dim buttonMode As String = btnPauseResume.Text
        Select Case buttonMode
            Case "Pause"
                pauseGame()
                btnPauseResume.Text = "Resume"
            Case "Resume"
                resumeGame()
                btnPauseResume.Text = "Pause"
        End Select
        ActiveControl = Nothing
    End Sub

    Private Sub Me_shapeInvalidated(sender As Object, e As EventArgs) Handles Me.shapeInvalidated
        Console.WriteLine("Shape Invalidated")
        lineManager.checkLines()
    End Sub

    Private Sub Me_gameStopped(sender As Object, e As EventArgs) Handles Me.gameStopped
        'Stop
    End Sub

    Private Sub initGame()
        Console.WriteLine("Intializing Game")
        shapeManager.spawnNew()
    End Sub

    Public Sub invalidateShape()
        activeShape = Nothing
        shapeManager.spawnNew()
        RaiseEvent shapeInvalidated(Me, New EventArgs)
    End Sub

    Private Sub startGame()
        gameStarted = True
        tmrMVShape.Enabled = True
        Console.WriteLine("startGame")
        btnStartStopReset.Text = "Stop"
    End Sub

    Public Sub stopGame()
        gameStarted = False
        tmrMVShape.Enabled = False
        Console.WriteLine("stopGame")
        btnStartStopReset.Text = "Reset"
        RaiseEvent gameStopped(Me, New EventArgs)
    End Sub

    Private Sub resetGame()
        gamePaused = False
        gameStarted = False
        tmrMVShape.Enabled = False
        activeShape = Nothing
        initializeGrid()
        initGame()
        gridPainted = False
        Me.Invalidate()
        frmConsole.drawGrid()
        Console.WriteLine("resetGame")
        btnStartStopReset.Text = "Start"
    End Sub

    Private Sub pauseGame()
        gamePaused = True
        tmrMVShape.Enabled = False
        Console.WriteLine("pauseGame")
    End Sub

    Private Sub resumeGame()
        gamePaused = False
        tmrMVShape.Enabled = True
        Console.WriteLine("resumeGame")
    End Sub

    Public Sub mvLeft()
        activeShape.left()
        frmConsole.drawGrid()
    End Sub

    Public Sub mvRight()
        activeShape.right()
        frmConsole.drawGrid()
    End Sub

    Public Sub mvDown()
        activeShape.down()
        frmConsole.drawGrid()
    End Sub

    Public Sub hardDrop()
        activeShape.hardDrop()
        frmConsole.drawGrid()
    End Sub

    Public Sub rotate()
        activeShape.rotate()
        frmConsole.drawGrid()
    End Sub

    Private Sub DebugToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DebugToolStripMenuItem.Click
        frmDebug.Show()
    End Sub

    Private Sub ShowConsoleToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ShowConsoleToolStripMenuItem.Click
        frmConsole.Show()
    End Sub
End Class