<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHelp
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
        Me.tblControls = New System.Windows.Forms.TableLayoutPanel()
        Me.lblControlsTitle = New System.Windows.Forms.Label()
        Me.lblMoveRightTitle = New System.Windows.Forms.Label()
        Me.lblHardDropTitle = New System.Windows.Forms.Label()
        Me.lblMoveLeftTitle = New System.Windows.Forms.Label()
        Me.lblRotateTitle = New System.Windows.Forms.Label()
        Me.lblMoveLeft = New System.Windows.Forms.Label()
        Me.lblMoveRight = New System.Windows.Forms.Label()
        Me.lblHardDrop = New System.Windows.Forms.Label()
        Me.lblRotate = New System.Windows.Forms.Label()
        Me.tblScoring = New System.Windows.Forms.TableLayoutPanel()
        Me.lblScoringTitle = New System.Windows.Forms.Label()
        Me.lblScoringTitleDescription = New System.Windows.Forms.Label()
        Me.lblLineTitle = New System.Windows.Forms.Label()
        Me.lblPointsTitle = New System.Windows.Forms.Label()
        Me.lblLine1 = New System.Windows.Forms.Label()
        Me.lblLine2 = New System.Windows.Forms.Label()
        Me.lblLine3 = New System.Windows.Forms.Label()
        Me.lblLine4 = New System.Windows.Forms.Label()
        Me.lblPoints1 = New System.Windows.Forms.Label()
        Me.lblPoints2 = New System.Windows.Forms.Label()
        Me.lblPoints3 = New System.Windows.Forms.Label()
        Me.lblPoints4 = New System.Windows.Forms.Label()
        Me.tblControls.SuspendLayout()
        Me.tblScoring.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblControls
        '
        Me.tblControls.BackColor = System.Drawing.Color.White
        Me.tblControls.ColumnCount = 2
        Me.tblControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblControls.Controls.Add(Me.lblControlsTitle, 0, 0)
        Me.tblControls.Controls.Add(Me.lblMoveRightTitle, 0, 2)
        Me.tblControls.Controls.Add(Me.lblHardDropTitle, 0, 3)
        Me.tblControls.Controls.Add(Me.lblMoveLeftTitle, 0, 1)
        Me.tblControls.Controls.Add(Me.lblRotateTitle, 0, 4)
        Me.tblControls.Controls.Add(Me.lblMoveLeft, 1, 1)
        Me.tblControls.Controls.Add(Me.lblMoveRight, 1, 2)
        Me.tblControls.Controls.Add(Me.lblHardDrop, 1, 3)
        Me.tblControls.Controls.Add(Me.lblRotate, 1, 4)
        Me.tblControls.Location = New System.Drawing.Point(12, 12)
        Me.tblControls.Name = "tblControls"
        Me.tblControls.RowCount = 5
        Me.tblControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblControls.Size = New System.Drawing.Size(350, 150)
        Me.tblControls.TabIndex = 0
        '
        'lblControlsTitle
        '
        Me.tblControls.SetColumnSpan(Me.lblControlsTitle, 2)
        Me.lblControlsTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblControlsTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControlsTitle.Location = New System.Drawing.Point(3, 0)
        Me.lblControlsTitle.Name = "lblControlsTitle"
        Me.lblControlsTitle.Size = New System.Drawing.Size(344, 30)
        Me.lblControlsTitle.TabIndex = 0
        Me.lblControlsTitle.Text = "Controls"
        Me.lblControlsTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblMoveRightTitle
        '
        Me.lblMoveRightTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMoveRightTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoveRightTitle.Location = New System.Drawing.Point(3, 65)
        Me.lblMoveRightTitle.Name = "lblMoveRightTitle"
        Me.lblMoveRightTitle.Size = New System.Drawing.Size(169, 20)
        Me.lblMoveRightTitle.TabIndex = 2
        Me.lblMoveRightTitle.Text = "Move Right"
        Me.lblMoveRightTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHardDropTitle
        '
        Me.lblHardDropTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHardDropTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHardDropTitle.Location = New System.Drawing.Point(3, 95)
        Me.lblHardDropTitle.Name = "lblHardDropTitle"
        Me.lblHardDropTitle.Size = New System.Drawing.Size(169, 20)
        Me.lblHardDropTitle.TabIndex = 3
        Me.lblHardDropTitle.Text = "Hard Drop"
        Me.lblHardDropTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMoveLeftTitle
        '
        Me.lblMoveLeftTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMoveLeftTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoveLeftTitle.Location = New System.Drawing.Point(3, 35)
        Me.lblMoveLeftTitle.Name = "lblMoveLeftTitle"
        Me.lblMoveLeftTitle.Size = New System.Drawing.Size(169, 20)
        Me.lblMoveLeftTitle.TabIndex = 1
        Me.lblMoveLeftTitle.Text = "Move Left"
        Me.lblMoveLeftTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRotateTitle
        '
        Me.lblRotateTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRotateTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRotateTitle.Location = New System.Drawing.Point(3, 125)
        Me.lblRotateTitle.Name = "lblRotateTitle"
        Me.lblRotateTitle.Size = New System.Drawing.Size(169, 20)
        Me.lblRotateTitle.TabIndex = 4
        Me.lblRotateTitle.Text = "Rotate"
        Me.lblRotateTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMoveLeft
        '
        Me.lblMoveLeft.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMoveLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoveLeft.Location = New System.Drawing.Point(178, 35)
        Me.lblMoveLeft.Name = "lblMoveLeft"
        Me.lblMoveLeft.Size = New System.Drawing.Size(169, 20)
        Me.lblMoveLeft.TabIndex = 5
        Me.lblMoveLeft.Text = "Keys.Left"
        Me.lblMoveLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMoveRight
        '
        Me.lblMoveRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMoveRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoveRight.Location = New System.Drawing.Point(178, 65)
        Me.lblMoveRight.Name = "lblMoveRight"
        Me.lblMoveRight.Size = New System.Drawing.Size(169, 20)
        Me.lblMoveRight.TabIndex = 6
        Me.lblMoveRight.Text = "Keys.Right"
        Me.lblMoveRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHardDrop
        '
        Me.lblHardDrop.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHardDrop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHardDrop.Location = New System.Drawing.Point(178, 95)
        Me.lblHardDrop.Name = "lblHardDrop"
        Me.lblHardDrop.Size = New System.Drawing.Size(169, 20)
        Me.lblHardDrop.TabIndex = 7
        Me.lblHardDrop.Text = "Keys.Down"
        Me.lblHardDrop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRotate
        '
        Me.lblRotate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRotate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRotate.Location = New System.Drawing.Point(178, 125)
        Me.lblRotate.Name = "lblRotate"
        Me.lblRotate.Size = New System.Drawing.Size(169, 20)
        Me.lblRotate.TabIndex = 8
        Me.lblRotate.Text = "Keys.Space"
        Me.lblRotate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tblScoring
        '
        Me.tblScoring.BackColor = System.Drawing.Color.White
        Me.tblScoring.ColumnCount = 2
        Me.tblScoring.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblScoring.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblScoring.Controls.Add(Me.lblScoringTitle, 0, 0)
        Me.tblScoring.Controls.Add(Me.lblScoringTitleDescription, 0, 1)
        Me.tblScoring.Controls.Add(Me.lblLineTitle, 0, 2)
        Me.tblScoring.Controls.Add(Me.lblPointsTitle, 1, 2)
        Me.tblScoring.Controls.Add(Me.lblLine1, 0, 3)
        Me.tblScoring.Controls.Add(Me.lblLine2, 0, 4)
        Me.tblScoring.Controls.Add(Me.lblLine3, 0, 5)
        Me.tblScoring.Controls.Add(Me.lblLine4, 0, 6)
        Me.tblScoring.Controls.Add(Me.lblPoints1, 1, 3)
        Me.tblScoring.Controls.Add(Me.lblPoints2, 1, 4)
        Me.tblScoring.Controls.Add(Me.lblPoints3, 1, 5)
        Me.tblScoring.Controls.Add(Me.lblPoints4, 1, 6)
        Me.tblScoring.Location = New System.Drawing.Point(12, 187)
        Me.tblScoring.Name = "tblScoring"
        Me.tblScoring.RowCount = 7
        Me.tblScoring.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.tblScoring.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.tblScoring.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.tblScoring.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.tblScoring.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.tblScoring.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.tblScoring.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28816!))
        Me.tblScoring.Size = New System.Drawing.Size(350, 223)
        Me.tblScoring.TabIndex = 1
        '
        'lblScoringTitle
        '
        Me.tblScoring.SetColumnSpan(Me.lblScoringTitle, 2)
        Me.lblScoringTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblScoringTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoringTitle.Location = New System.Drawing.Point(3, 0)
        Me.lblScoringTitle.Name = "lblScoringTitle"
        Me.lblScoringTitle.Size = New System.Drawing.Size(344, 31)
        Me.lblScoringTitle.TabIndex = 0
        Me.lblScoringTitle.Text = "Scoring"
        Me.lblScoringTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScoringTitleDescription
        '
        Me.tblScoring.SetColumnSpan(Me.lblScoringTitleDescription, 2)
        Me.lblScoringTitleDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblScoringTitleDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoringTitleDescription.Location = New System.Drawing.Point(3, 31)
        Me.lblScoringTitleDescription.Name = "lblScoringTitleDescription"
        Me.lblScoringTitleDescription.Size = New System.Drawing.Size(344, 31)
        Me.lblScoringTitleDescription.TabIndex = 1
        Me.lblScoringTitleDescription.Text = "Scores are calculated by the following equation:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Points For Lines Cleared Multip" &
    "lied By Level + 1"
        Me.lblScoringTitleDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLineTitle
        '
        Me.lblLineTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLineTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLineTitle.Location = New System.Drawing.Point(3, 67)
        Me.lblLineTitle.Name = "lblLineTitle"
        Me.lblLineTitle.Size = New System.Drawing.Size(169, 20)
        Me.lblLineTitle.TabIndex = 2
        Me.lblLineTitle.Text = "Line"
        Me.lblLineTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPointsTitle
        '
        Me.lblPointsTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPointsTitle.AutoSize = True
        Me.lblPointsTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPointsTitle.Location = New System.Drawing.Point(178, 67)
        Me.lblPointsTitle.Name = "lblPointsTitle"
        Me.lblPointsTitle.Size = New System.Drawing.Size(169, 20)
        Me.lblPointsTitle.TabIndex = 3
        Me.lblPointsTitle.Text = "Points"
        Me.lblPointsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine1
        '
        Me.lblLine1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLine1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine1.Location = New System.Drawing.Point(3, 98)
        Me.lblLine1.Name = "lblLine1"
        Me.lblLine1.Size = New System.Drawing.Size(169, 20)
        Me.lblLine1.TabIndex = 4
        Me.lblLine1.Text = "Line 1"
        Me.lblLine1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine2
        '
        Me.lblLine2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLine2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine2.Location = New System.Drawing.Point(3, 129)
        Me.lblLine2.Name = "lblLine2"
        Me.lblLine2.Size = New System.Drawing.Size(169, 20)
        Me.lblLine2.TabIndex = 5
        Me.lblLine2.Text = "Line 2"
        Me.lblLine2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine3
        '
        Me.lblLine3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLine3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine3.Location = New System.Drawing.Point(3, 160)
        Me.lblLine3.Name = "lblLine3"
        Me.lblLine3.Size = New System.Drawing.Size(169, 20)
        Me.lblLine3.TabIndex = 6
        Me.lblLine3.Text = "Line 3"
        Me.lblLine3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine4
        '
        Me.lblLine4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLine4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine4.Location = New System.Drawing.Point(3, 194)
        Me.lblLine4.Name = "lblLine4"
        Me.lblLine4.Size = New System.Drawing.Size(169, 20)
        Me.lblLine4.TabIndex = 7
        Me.lblLine4.Text = "Line 4"
        Me.lblLine4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPoints1
        '
        Me.lblPoints1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPoints1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints1.Location = New System.Drawing.Point(178, 98)
        Me.lblPoints1.Name = "lblPoints1"
        Me.lblPoints1.Size = New System.Drawing.Size(169, 20)
        Me.lblPoints1.TabIndex = 8
        Me.lblPoints1.Text = "40"
        Me.lblPoints1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPoints2
        '
        Me.lblPoints2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPoints2.AutoSize = True
        Me.lblPoints2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints2.Location = New System.Drawing.Point(178, 129)
        Me.lblPoints2.Name = "lblPoints2"
        Me.lblPoints2.Size = New System.Drawing.Size(169, 20)
        Me.lblPoints2.TabIndex = 9
        Me.lblPoints2.Text = "100"
        Me.lblPoints2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPoints3
        '
        Me.lblPoints3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPoints3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints3.Location = New System.Drawing.Point(178, 160)
        Me.lblPoints3.Name = "lblPoints3"
        Me.lblPoints3.Size = New System.Drawing.Size(169, 20)
        Me.lblPoints3.TabIndex = 10
        Me.lblPoints3.Text = "300"
        Me.lblPoints3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPoints4
        '
        Me.lblPoints4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPoints4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints4.Location = New System.Drawing.Point(178, 194)
        Me.lblPoints4.Name = "lblPoints4"
        Me.lblPoints4.Size = New System.Drawing.Size(169, 20)
        Me.lblPoints4.TabIndex = 11
        Me.lblPoints4.Text = "1200"
        Me.lblPoints4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 422)
        Me.Controls.Add(Me.tblScoring)
        Me.Controls.Add(Me.tblControls)
        Me.Name = "frmHelp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Help"
        Me.tblControls.ResumeLayout(False)
        Me.tblScoring.ResumeLayout(False)
        Me.tblScoring.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblControls As TableLayoutPanel
    Friend WithEvents lblControlsTitle As Label
    Friend WithEvents lblMoveRightTitle As Label
    Friend WithEvents lblHardDropTitle As Label
    Friend WithEvents lblMoveLeftTitle As Label
    Friend WithEvents lblRotateTitle As Label
    Friend WithEvents lblMoveLeft As Label
    Friend WithEvents lblMoveRight As Label
    Friend WithEvents lblHardDrop As Label
    Friend WithEvents lblRotate As Label
    Friend WithEvents tblScoring As TableLayoutPanel
    Friend WithEvents lblScoringTitle As Label
    Friend WithEvents lblScoringTitleDescription As Label
    Friend WithEvents lblLineTitle As Label
    Friend WithEvents lblPointsTitle As Label
    Friend WithEvents lblLine1 As Label
    Friend WithEvents lblLine2 As Label
    Friend WithEvents lblLine3 As Label
    Friend WithEvents lblLine4 As Label
    Friend WithEvents lblPoints1 As Label
    Friend WithEvents lblPoints2 As Label
    Friend WithEvents lblPoints3 As Label
    Friend WithEvents lblPoints4 As Label
End Class
