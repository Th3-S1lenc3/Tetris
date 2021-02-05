<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsole
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.rtbConsole = New System.Windows.Forms.RichTextBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'rtbConsole
        '
        Me.rtbConsole.BackColor = System.Drawing.Color.Black
        Me.rtbConsole.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbConsole.Cursor = System.Windows.Forms.Cursors.Default
        Me.rtbConsole.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbConsole.ForeColor = System.Drawing.Color.LightGray
        Me.rtbConsole.Location = New System.Drawing.Point(12, 12)
        Me.rtbConsole.Name = "rtbConsole"
        Me.rtbConsole.ReadOnly = True
        Me.rtbConsole.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.rtbConsole.Size = New System.Drawing.Size(240, 325)
        Me.rtbConsole.TabIndex = 0
        Me.rtbConsole.Text = ""
        '
        'txtInput
        '
        Me.txtInput.BackColor = System.Drawing.Color.Black
        Me.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInput.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.ForeColor = System.Drawing.Color.LightGray
        Me.txtInput.Location = New System.Drawing.Point(12, 335)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(240, 16)
        Me.txtInput.TabIndex = 1
        '
        'frmConsole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 363)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.rtbConsole)
        Me.Name = "frmConsole"
        Me.Text = "Console"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rtbConsole As RichTextBox
    Friend WithEvents txtInput As TextBox
End Class
