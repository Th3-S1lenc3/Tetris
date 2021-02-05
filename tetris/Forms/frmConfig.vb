Public Class frmConfig
    Dim keyPressed As String
    Dim controlKeys As New gameControls
    Dim config As New Config
    Dim editedControls As New List(Of String)

    Private Sub frmConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clipboard.Clear()
        txtMVLeft.Text = controlKeys.left
        txtMVRight.Text = controlKeys.right
        txtHardDrop.Text = controlKeys.hardDrop
        txtRotate.Text = controlKeys.rotate
    End Sub

    Private Sub frmConfig_Active(sender As Object, e As EventArgs) Handles MyBase.Activated
        ActiveControl = Nothing
    End Sub

    Private Function modifierKey(ByVal e As KeyEventArgs) As Boolean
        If e.KeyCode.ToString = "ControlKey" Then
            Return True
        ElseIf e.KeyCode.ToString = "Menu, Alt" Then
            Return True
        ElseIf e.KeyCode.ToString = "ShiftKey" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub txtMVLeft_TextChanged(sender As Object, e As KeyEventArgs) Handles txtMVLeft.KeyDown
        If e.Modifiers And Not modifierKey(e) Then
            keyPressed = e.Modifiers.ToString & " " & e.KeyCode.ToString
        Else
            keyPressed = e.KeyCode.ToString
        End If
    End Sub

    Private Sub txtMVLeft_TextChangeFinished(sender As Object, e As KeyEventArgs) Handles txtMVLeft.KeyUp
        txtMVLeft.Text = keyPressed
        txtMVLeft.Enabled = False
    End Sub

    Private Sub btnEditMVLeft_Click(sender As Object, e As EventArgs) Handles btnEditMVLeft.Click
        txtMVLeft.Enabled = True
        txtMVLeft.Focus()
        btnApply.Enabled = True
        If Not editedControls.Contains("left") Then
            editedControls.Add("left")
        End If
    End Sub

    Private Sub txtMVRight_TextChanged(sender As Object, e As KeyEventArgs) Handles txtMVRight.KeyDown
        If e.Modifiers And Not modifierKey(e) Then
            keyPressed = e.Modifiers.ToString & " " & e.KeyCode.ToString
        Else
            keyPressed = e.KeyCode.ToString
        End If
    End Sub

    Private Sub txtMVRight_TextChangeFinised(sender As Object, e As KeyEventArgs) Handles txtMVRight.KeyUp
        txtMVRight.Text = keyPressed
        txtMVRight.Enabled = False
    End Sub

    Private Sub btnEditMVRight_Click(sender As Object, e As EventArgs) Handles btnEditMVRight.Click
        txtMVRight.Enabled = True
        txtMVRight.Focus()
        btnApply.Enabled = True
        If Not editedControls.Contains("right") Then
            editedControls.Add("right")
        End If
    End Sub

    Private Sub txtHardDrop_TextChanged(sender As Object, e As KeyEventArgs) Handles txtHardDrop.KeyDown
        If e.Modifiers And Not modifierKey(e) Then
            keyPressed = e.Modifiers.ToString & " " & e.KeyCode.ToString
        Else
            keyPressed = e.KeyCode.ToString
        End If
    End Sub

    Private Sub txtHardDrop_TextChangeFinished(sender As Object, e As KeyEventArgs) Handles txtHardDrop.KeyUp
        txtHardDrop.Text = keyPressed
        txtHardDrop.Enabled = False
    End Sub

    Private Sub btnEditHardDrop_Click(sender As Object, e As EventArgs) Handles btnEditHardDrop.Click
        txtHardDrop.Enabled = True
        txtHardDrop.Focus()
        btnApply.Enabled = True
        If Not editedControls.Contains("hardDrop") Then
            editedControls.Add("hardDrop")
        End If
    End Sub

    Private Sub txtRotate_TextChanged(sender As Object, e As KeyEventArgs) Handles txtRotate.KeyDown
        If e.Modifiers And Not modifierKey(e) Then
            keyPressed = e.Modifiers.ToString & " " & e.KeyCode.ToString
        Else
            keyPressed = e.KeyCode.ToString
        End If
    End Sub

    Private Sub txtRotate_TextChangeFinished(sender As Object, e As KeyEventArgs) Handles txtRotate.KeyUp
        txtRotate.Text = keyPressed
        txtRotate.Enabled = False
    End Sub

    Private Sub btnEditRotate_Click(sender As Object, e As EventArgs) Handles btnEditRotate.Click
        txtRotate.Enabled = True
        txtRotate.Focus()
        btnApply.Enabled = True
        If Not editedControls.Contains("rotate") Then
            editedControls.Add("rotate")
        End If
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        For Each editedControl In editedControls
            Select Case editedControl
                Case "left"
                    config.write("controls", "left", txtMVLeft.Text)
                    txtMVLeft.Enabled = False
                Case "right"
                    config.write("controls", "right", txtMVRight.Text)
                    txtMVRight.Enabled = False
                Case "hardDrop"
                    config.write("controls", "hardDrop", txtHardDrop.Text)
                    txtHardDrop.Enabled = False
                Case "rotate"
                    config.write("controls", "rotate", txtRotate.Text)
                    txtRotate.Enabled = False
            End Select
        Next
        editedControls.Clear()
    End Sub
End Class