<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConfig
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
        Me.btnEditRotate = New System.Windows.Forms.Button()
        Me.btnEditHardDrop = New System.Windows.Forms.Button()
        Me.btnEditMVRight = New System.Windows.Forms.Button()
        Me.txtRotate = New System.Windows.Forms.TextBox()
        Me.txtHardDrop = New System.Windows.Forms.TextBox()
        Me.txtMVRight = New System.Windows.Forms.TextBox()
        Me.lblMoveRightTitle = New System.Windows.Forms.Label()
        Me.lblHardDropTitle = New System.Windows.Forms.Label()
        Me.lblMoveLeftTitle = New System.Windows.Forms.Label()
        Me.lblRotateTitle = New System.Windows.Forms.Label()
        Me.lblEditControlsTitle = New System.Windows.Forms.Label()
        Me.txtMVLeft = New System.Windows.Forms.TextBox()
        Me.btnEditMVLeft = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.tblControls.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblControls
        '
        Me.tblControls.ColumnCount = 3
        Me.tblControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblControls.Controls.Add(Me.btnEditRotate, 2, 4)
        Me.tblControls.Controls.Add(Me.btnEditHardDrop, 2, 3)
        Me.tblControls.Controls.Add(Me.btnEditMVRight, 2, 2)
        Me.tblControls.Controls.Add(Me.txtRotate, 1, 4)
        Me.tblControls.Controls.Add(Me.txtHardDrop, 1, 3)
        Me.tblControls.Controls.Add(Me.txtMVRight, 1, 2)
        Me.tblControls.Controls.Add(Me.lblMoveRightTitle, 0, 2)
        Me.tblControls.Controls.Add(Me.lblHardDropTitle, 0, 3)
        Me.tblControls.Controls.Add(Me.lblMoveLeftTitle, 0, 1)
        Me.tblControls.Controls.Add(Me.lblRotateTitle, 0, 4)
        Me.tblControls.Controls.Add(Me.lblEditControlsTitle, 0, 0)
        Me.tblControls.Controls.Add(Me.txtMVLeft, 1, 1)
        Me.tblControls.Controls.Add(Me.btnEditMVLeft, 2, 1)
        Me.tblControls.Location = New System.Drawing.Point(12, 12)
        Me.tblControls.Name = "tblControls"
        Me.tblControls.RowCount = 5
        Me.tblControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblControls.Size = New System.Drawing.Size(433, 289)
        Me.tblControls.TabIndex = 0
        '
        'btnEditRotate
        '
        Me.btnEditRotate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditRotate.Location = New System.Drawing.Point(327, 247)
        Me.btnEditRotate.Name = "btnEditRotate"
        Me.btnEditRotate.Size = New System.Drawing.Size(103, 23)
        Me.btnEditRotate.TabIndex = 24
        Me.btnEditRotate.Text = "Edit"
        Me.btnEditRotate.UseVisualStyleBackColor = True
        '
        'btnEditHardDrop
        '
        Me.btnEditHardDrop.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditHardDrop.Location = New System.Drawing.Point(327, 188)
        Me.btnEditHardDrop.Name = "btnEditHardDrop"
        Me.btnEditHardDrop.Size = New System.Drawing.Size(103, 23)
        Me.btnEditHardDrop.TabIndex = 23
        Me.btnEditHardDrop.Text = "Edit"
        Me.btnEditHardDrop.UseVisualStyleBackColor = True
        '
        'btnEditMVRight
        '
        Me.btnEditMVRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditMVRight.Location = New System.Drawing.Point(327, 131)
        Me.btnEditMVRight.Name = "btnEditMVRight"
        Me.btnEditMVRight.Size = New System.Drawing.Size(103, 23)
        Me.btnEditMVRight.TabIndex = 22
        Me.btnEditMVRight.Text = "Edit"
        Me.btnEditMVRight.UseVisualStyleBackColor = True
        '
        'txtRotate
        '
        Me.txtRotate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRotate.Enabled = False
        Me.txtRotate.Location = New System.Drawing.Point(219, 248)
        Me.txtRotate.Name = "txtRotate"
        Me.txtRotate.Size = New System.Drawing.Size(102, 20)
        Me.txtRotate.TabIndex = 20
        Me.txtRotate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHardDrop
        '
        Me.txtHardDrop.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHardDrop.Enabled = False
        Me.txtHardDrop.Location = New System.Drawing.Point(219, 189)
        Me.txtHardDrop.Name = "txtHardDrop"
        Me.txtHardDrop.Size = New System.Drawing.Size(102, 20)
        Me.txtHardDrop.TabIndex = 19
        Me.txtHardDrop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMVRight
        '
        Me.txtMVRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMVRight.Enabled = False
        Me.txtMVRight.Location = New System.Drawing.Point(219, 132)
        Me.txtMVRight.Name = "txtMVRight"
        Me.txtMVRight.Size = New System.Drawing.Size(102, 20)
        Me.txtMVRight.TabIndex = 18
        Me.txtMVRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMoveRightTitle
        '
        Me.lblMoveRightTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMoveRightTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoveRightTitle.Location = New System.Drawing.Point(3, 114)
        Me.lblMoveRightTitle.Name = "lblMoveRightTitle"
        Me.lblMoveRightTitle.Size = New System.Drawing.Size(210, 57)
        Me.lblMoveRightTitle.TabIndex = 10
        Me.lblMoveRightTitle.Text = "Move Right"
        Me.lblMoveRightTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHardDropTitle
        '
        Me.lblHardDropTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHardDropTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHardDropTitle.Location = New System.Drawing.Point(3, 171)
        Me.lblHardDropTitle.Name = "lblHardDropTitle"
        Me.lblHardDropTitle.Size = New System.Drawing.Size(210, 57)
        Me.lblHardDropTitle.TabIndex = 11
        Me.lblHardDropTitle.Text = "Hard Drop"
        Me.lblHardDropTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMoveLeftTitle
        '
        Me.lblMoveLeftTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMoveLeftTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoveLeftTitle.Location = New System.Drawing.Point(3, 57)
        Me.lblMoveLeftTitle.Name = "lblMoveLeftTitle"
        Me.lblMoveLeftTitle.Size = New System.Drawing.Size(210, 57)
        Me.lblMoveLeftTitle.TabIndex = 9
        Me.lblMoveLeftTitle.Text = "Move Left"
        Me.lblMoveLeftTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRotateTitle
        '
        Me.lblRotateTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRotateTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRotateTitle.Location = New System.Drawing.Point(3, 228)
        Me.lblRotateTitle.Name = "lblRotateTitle"
        Me.lblRotateTitle.Size = New System.Drawing.Size(210, 61)
        Me.lblRotateTitle.TabIndex = 12
        Me.lblRotateTitle.Text = "Rotate"
        Me.lblRotateTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEditControlsTitle
        '
        Me.tblControls.SetColumnSpan(Me.lblEditControlsTitle, 3)
        Me.lblEditControlsTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblEditControlsTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditControlsTitle.Location = New System.Drawing.Point(3, 0)
        Me.lblEditControlsTitle.Name = "lblEditControlsTitle"
        Me.lblEditControlsTitle.Size = New System.Drawing.Size(427, 57)
        Me.lblEditControlsTitle.TabIndex = 0
        Me.lblEditControlsTitle.Text = "Edit Controls"
        Me.lblEditControlsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMVLeft
        '
        Me.txtMVLeft.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMVLeft.Enabled = False
        Me.txtMVLeft.Location = New System.Drawing.Point(219, 75)
        Me.txtMVLeft.Name = "txtMVLeft"
        Me.txtMVLeft.Size = New System.Drawing.Size(102, 20)
        Me.txtMVLeft.TabIndex = 17
        Me.txtMVLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnEditMVLeft
        '
        Me.btnEditMVLeft.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditMVLeft.Location = New System.Drawing.Point(327, 74)
        Me.btnEditMVLeft.Name = "btnEditMVLeft"
        Me.btnEditMVLeft.Size = New System.Drawing.Size(103, 23)
        Me.btnEditMVLeft.TabIndex = 21
        Me.btnEditMVLeft.Text = "Edit"
        Me.btnEditMVLeft.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Enabled = False
        Me.btnApply.Location = New System.Drawing.Point(191, 310)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 25)
        Me.btnApply.TabIndex = 1
        Me.btnApply.Text = "Apply Changes"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'frmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 342)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.tblControls)
        Me.Name = "frmConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Config"
        Me.tblControls.ResumeLayout(False)
        Me.tblControls.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblControls As TableLayoutPanel
    Friend WithEvents lblEditControlsTitle As Label
    Friend WithEvents lblMoveRightTitle As Label
    Friend WithEvents lblHardDropTitle As Label
    Friend WithEvents lblMoveLeftTitle As Label
    Friend WithEvents lblRotateTitle As Label
    Friend WithEvents txtRotate As TextBox
    Friend WithEvents txtHardDrop As TextBox
    Friend WithEvents txtMVRight As TextBox
    Friend WithEvents txtMVLeft As TextBox
    Friend WithEvents btnEditRotate As Button
    Friend WithEvents btnEditHardDrop As Button
    Friend WithEvents btnEditMVRight As Button
    Friend WithEvents btnEditMVLeft As Button
    Friend WithEvents btnApply As Button
End Class
