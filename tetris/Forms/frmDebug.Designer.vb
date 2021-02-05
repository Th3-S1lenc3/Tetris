<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDebug
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rtbDebug = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'rtbDebug
        '
        Me.rtbDebug.Location = New System.Drawing.Point(12, 12)
        Me.rtbDebug.Name = "rtbDebug"
        Me.rtbDebug.ReadOnly = True
        Me.rtbDebug.Size = New System.Drawing.Size(246, 131)
        Me.rtbDebug.TabIndex = 1
        Me.rtbDebug.Text = ""
        '
        'frmDebug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 157)
        Me.Controls.Add(Me.rtbDebug)
        Me.Name = "frmDebug"
        Me.Text = "frmDebug"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtbDebug As RichTextBox
End Class
