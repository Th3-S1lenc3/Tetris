<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTetris
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
        Me.components = New System.ComponentModel.Container()
        Me.btnStartStopReset = New System.Windows.Forms.Button()
        Me.btnPauseResume = New System.Windows.Forms.Button()
        Me.lblScoreTitle = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblNextTitle = New System.Windows.Forms.Label()
        Me.lblHoldTitle = New System.Windows.Forms.Label()
        Me.lblLevelTitle = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DebugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowConsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrMVShape = New System.Windows.Forms.Timer(Me.components)
        Me.lblNextShapesBackground = New System.Windows.Forms.Label()
        Me.lblHoldPieceBackground = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStartStopReset
        '
        Me.btnStartStopReset.Location = New System.Drawing.Point(28, 388)
        Me.btnStartStopReset.Name = "btnStartStopReset"
        Me.btnStartStopReset.Size = New System.Drawing.Size(100, 100)
        Me.btnStartStopReset.TabIndex = 1
        Me.btnStartStopReset.TabStop = False
        Me.btnStartStopReset.Text = "Start"
        Me.btnStartStopReset.UseVisualStyleBackColor = True
        '
        'btnPauseResume
        '
        Me.btnPauseResume.Location = New System.Drawing.Point(28, 513)
        Me.btnPauseResume.Name = "btnPauseResume"
        Me.btnPauseResume.Size = New System.Drawing.Size(100, 100)
        Me.btnPauseResume.TabIndex = 2
        Me.btnPauseResume.TabStop = False
        Me.btnPauseResume.Text = "Pause"
        Me.btnPauseResume.UseVisualStyleBackColor = True
        '
        'lblScoreTitle
        '
        Me.lblScoreTitle.BackColor = System.Drawing.Color.White
        Me.lblScoreTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreTitle.Location = New System.Drawing.Point(155, 37)
        Me.lblScoreTitle.Name = "lblScoreTitle"
        Me.lblScoreTitle.Size = New System.Drawing.Size(250, 37)
        Me.lblScoreTitle.TabIndex = 7
        Me.lblScoreTitle.Text = "Score:"
        Me.lblScoreTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.White
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(155, 74)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(250, 38)
        Me.lblScore.TabIndex = 8
        Me.lblScore.Text = "0"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNextTitle
        '
        Me.lblNextTitle.BackColor = System.Drawing.Color.White
        Me.lblNextTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNextTitle.Location = New System.Drawing.Point(427, 120)
        Me.lblNextTitle.Name = "lblNextTitle"
        Me.lblNextTitle.Size = New System.Drawing.Size(125, 25)
        Me.lblNextTitle.TabIndex = 9
        Me.lblNextTitle.Text = "Next"
        Me.lblNextTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHoldTitle
        '
        Me.lblHoldTitle.BackColor = System.Drawing.Color.White
        Me.lblHoldTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoldTitle.Location = New System.Drawing.Point(12, 120)
        Me.lblHoldTitle.Name = "lblHoldTitle"
        Me.lblHoldTitle.Size = New System.Drawing.Size(125, 25)
        Me.lblHoldTitle.TabIndex = 11
        Me.lblHoldTitle.Text = "Hold"
        Me.lblHoldTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLevelTitle
        '
        Me.lblLevelTitle.BackColor = System.Drawing.Color.White
        Me.lblLevelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevelTitle.Location = New System.Drawing.Point(427, 499)
        Me.lblLevelTitle.Name = "lblLevelTitle"
        Me.lblLevelTitle.Size = New System.Drawing.Size(125, 25)
        Me.lblLevelTitle.TabIndex = 13
        Me.lblLevelTitle.Text = "Level"
        Me.lblLevelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLevel
        '
        Me.lblLevel.BackColor = System.Drawing.Color.White
        Me.lblLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.Location = New System.Drawing.Point(427, 524)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(125, 100)
        Me.lblLevel.TabIndex = 14
        Me.lblLevel.Text = "1"
        Me.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(28, 263)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(100, 100)
        Me.btnHelp.TabIndex = 15
        Me.btnHelp.TabStop = False
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(576, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditConfigToolStripMenuItem, Me.DebugToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'EditConfigToolStripMenuItem
        '
        Me.EditConfigToolStripMenuItem.Name = "EditConfigToolStripMenuItem"
        Me.EditConfigToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.EditConfigToolStripMenuItem.Text = "Edit Configuration"
        '
        'DebugToolStripMenuItem
        '
        Me.DebugToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowConsoleToolStripMenuItem})
        Me.DebugToolStripMenuItem.Name = "DebugToolStripMenuItem"
        Me.DebugToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.DebugToolStripMenuItem.Text = "Debug"
        '
        'ShowConsoleToolStripMenuItem
        '
        Me.ShowConsoleToolStripMenuItem.Name = "ShowConsoleToolStripMenuItem"
        Me.ShowConsoleToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ShowConsoleToolStripMenuItem.Text = "Show Console"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'tmrMVShape
        '
        Me.tmrMVShape.Interval = 1000
        '
        'lblNextShapesBackground
        '
        Me.lblNextShapesBackground.BackColor = System.Drawing.Color.White
        Me.lblNextShapesBackground.Location = New System.Drawing.Point(427, 145)
        Me.lblNextShapesBackground.Name = "lblNextShapesBackground"
        Me.lblNextShapesBackground.Size = New System.Drawing.Size(125, 250)
        Me.lblNextShapesBackground.TabIndex = 17
        '
        'lblHoldPieceBackground
        '
        Me.lblHoldPieceBackground.BackColor = System.Drawing.Color.White
        Me.lblHoldPieceBackground.Location = New System.Drawing.Point(12, 145)
        Me.lblHoldPieceBackground.Name = "lblHoldPieceBackground"
        Me.lblHoldPieceBackground.Size = New System.Drawing.Size(125, 100)
        Me.lblHoldPieceBackground.TabIndex = 18
        '
        'frmTetris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 640)
        Me.Controls.Add(Me.lblHoldPieceBackground)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.lblLevel)
        Me.Controls.Add(Me.lblLevelTitle)
        Me.Controls.Add(Me.lblHoldTitle)
        Me.Controls.Add(Me.lblNextTitle)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblScoreTitle)
        Me.Controls.Add(Me.btnPauseResume)
        Me.Controls.Add(Me.btnStartStopReset)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblNextShapesBackground)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmTetris"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tetris"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStartStopReset As Button
    Friend WithEvents btnPauseResume As Button
    Friend WithEvents lblScoreTitle As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents lblNextTitle As Label
    Friend WithEvents lblHoldTitle As Label
    Friend WithEvents lblLevelTitle As Label
    Friend WithEvents lblLevel As Label
    Friend WithEvents btnHelp As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditConfigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tmrMVShape As Timer
    Friend WithEvents DebugToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowConsoleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblNextShapesBackground As Label
    Friend WithEvents lblHoldPieceBackground As Label
End Class
