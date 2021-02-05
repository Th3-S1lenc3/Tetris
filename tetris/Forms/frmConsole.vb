Public Class frmConsole
    Private Event input(sender As Object, e As EventArgs)
    Private grid As String = "default"

    Private Sub frmConsole_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initConsole()
    End Sub

    Private Sub initConsole()
        Select Case grid
            Case "default"
                drawGrid()
            Case "nextShapes"
                drawNextShapesGrid()
        End Select
        txtInput.Text = "> "
        txtInput.SelectionStart = txtInput.TextLength + 1
    End Sub

    Public Sub drawGrid()
        rtbConsole.Clear()
        For row As Integer = 0 To frmTetris.gridRows - 1
            For col As Integer = 0 To frmTetris.gridColumns - 1
                rtbConsole.AppendText($"{frmTetris.grid(col, row)}")
            Next
            If Not row = frmTetris.gridRows - 1 Then
                rtbConsole.AppendText($"{vbCrLf}")
            End If
        Next
    End Sub

    Public Sub drawNextShapesGrid()
        rtbConsole.Clear()
        For row As Integer = 0 To frmTetris.nextShapes_gridRows - 1
            For col As Integer = 0 To frmTetris.nextShapes_gridColumns - 1
                rtbConsole.AppendText($"{frmTetris.nextShapes_grid(col, row)}")
            Next
            If Not row = frmTetris.nextShapes_gridRows - 1 Then
                rtbConsole.AppendText($"{vbCrLf}")
            End If
        Next
    End Sub

    Private Sub txtInput_Input(sender As Object, e As EventArgs) Handles Me.input
        Dim rawInput = txtInput.Text
        Dim cutPoint = "> "
        Dim stringSeparators() As String = {cutPoint}
        Dim splitInput = rawInput.Split(stringSeparators, 2, StringSplitOptions.RemoveEmptyEntries)
        Dim input = splitInput(0)

        Select Case input
            Case "left"
                frmTetris.mvLeft()
                initConsole()
            Case "right"
                frmTetris.mvRight()
                initConsole()
            Case "down"
                frmTetris.mvDown()
                initConsole()
            Case "drop"
                frmTetris.hardDrop()
                initConsole()
            Case "rotate"
                frmTetris.rotate()
                initConsole()
            Case "refresh"
                initConsole()
            Case "switch"
                switchGrid()
                initConsole()
            Case "generate new shapes"
                frmTetris.drawNextShapesToGrid()
                initConsole()
            Case "exit"
                End
        End Select
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        Select Case keyData.ToString
            Case "Return"
                RaiseEvent input(Me, New EventArgs)
                Return True
            Case "Back"
                If txtInput.TextLength <= 2 Then
                    Return True
                End If
        End Select
        Return False
    End Function

    Private Sub txtInput_GotFocus(sender As Object, e As EventArgs) Handles txtInput.GotFocus
        txtInput.SelectionStart = txtInput.TextLength + 1
    End Sub

    Private Sub rtbConsole_GotFocus() Handles rtbConsole.GotFocus
        txtInput.Select()
    End Sub

    Private Sub switchGrid()
        Select Case grid
            Case "default"
                grid = "nextShapes"
                initConsole()
            Case "nextShapes"
                grid = "default"
                initConsole()
        End Select
    End Sub
End Class