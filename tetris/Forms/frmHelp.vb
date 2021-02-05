Public Class frmHelp
    Dim gameControls As New gameControls
    Private Sub frmHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMoveLeft.Text = gameControls.left
        lblMoveRight.Text = gameControls.right
        lblHardDrop.Text = gameControls.hardDrop
        lblRotate.Text = gameControls.rotate
        lblPoints1.Text = ScoreManager.line1Points
        lblPoints2.Text = ScoreManager.line2Points
        lblPoints3.Text = ScoreManager.line3Points
        lblPoints4.Text = ScoreManager.line4Points
    End Sub

    Private Sub frmHelp_Active(sender As Object, e As EventArgs) Handles MyBase.Activated
        ActiveControl = Nothing
    End Sub

    Private Sub tblControls_OnPaint(sender As Object, e As TableLayoutCellPaintEventArgs) Handles tblControls.CellPaint
        If e.Column = 1 Then
            e.Graphics.DrawLine(New Pen(Color.Black), New Point(e.CellBounds.X, e.CellBounds.Y), New Point(e.CellBounds.X, e.CellBounds.X + e.CellBounds.Height))
        End If
        Select Case e.Row
            Case 2
                e.Graphics.DrawLine(New Pen(Color.Black), New Point(e.CellBounds.X, e.CellBounds.Y), New Point(e.CellBounds.X + e.CellBounds.Width, e.CellBounds.Y))
            Case 3
                e.Graphics.DrawLine(New Pen(Color.Black), New Point(e.CellBounds.X, e.CellBounds.Y), New Point(e.CellBounds.X + e.CellBounds.Width, e.CellBounds.Y))
            Case 4
                e.Graphics.DrawLine(New Pen(Color.Black), New Point(e.CellBounds.X, e.CellBounds.Y), New Point(e.CellBounds.X + e.CellBounds.Width, e.CellBounds.Y))
        End Select
    End Sub

    Private Sub tblScoring_OnPaint(sender As Object, e As TableLayoutCellPaintEventArgs) Handles tblScoring.CellPaint
        If e.Column = 1 Then
            e.Graphics.DrawLine(New Pen(Color.Black), New Point(e.CellBounds.X, e.CellBounds.Y), New Point(e.CellBounds.X, e.CellBounds.X + e.CellBounds.Height))
        End If
        Select Case e.Row
            Case 3
                e.Graphics.DrawLine(New Pen(Color.Black), New Point(e.CellBounds.X, e.CellBounds.Y), New Point(e.CellBounds.X + e.CellBounds.Width, e.CellBounds.Y))
            Case 4
                e.Graphics.DrawLine(New Pen(Color.Black), New Point(e.CellBounds.X, e.CellBounds.Y), New Point(e.CellBounds.X + e.CellBounds.Width, e.CellBounds.Y))
            Case 5
                e.Graphics.DrawLine(New Pen(Color.Black), New Point(e.CellBounds.X, e.CellBounds.Y), New Point(e.CellBounds.X + e.CellBounds.Width, e.CellBounds.Y))
            Case 6
                e.Graphics.DrawLine(New Pen(Color.Black), New Point(e.CellBounds.X, e.CellBounds.Y), New Point(e.CellBounds.X + e.CellBounds.Width, e.CellBounds.Y))
        End Select
    End Sub
End Class