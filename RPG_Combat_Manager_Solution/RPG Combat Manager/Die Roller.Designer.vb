<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiceRoller
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
        Me.lblResults = New System.Windows.Forms.Label()
        Me.lblNumberOfDice = New System.Windows.Forms.Label()
        Me.txtNumberOfDice = New System.Windows.Forms.TextBox()
        Me.lblD = New System.Windows.Forms.Label()
        Me.cboDieSize = New System.Windows.Forms.ComboBox()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.txtModifier = New System.Windows.Forms.TextBox()
        Me.lblModifier = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.lstResultsDisplay = New System.Windows.Forms.ListBox()
        Me.btnClearResults = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(13, 13)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(42, 13)
        Me.lblResults.TabIndex = 0
        Me.lblResults.Text = "Results"
        '
        'lblNumberOfDice
        '
        Me.lblNumberOfDice.AutoSize = True
        Me.lblNumberOfDice.Location = New System.Drawing.Point(178, 125)
        Me.lblNumberOfDice.Name = "lblNumberOfDice"
        Me.lblNumberOfDice.Size = New System.Drawing.Size(51, 13)
        Me.lblNumberOfDice.TabIndex = 7
        Me.lblNumberOfDice.Text = "# of Dice"
        '
        'txtNumberOfDice
        '
        Me.txtNumberOfDice.Location = New System.Drawing.Point(185, 141)
        Me.txtNumberOfDice.Name = "txtNumberOfDice"
        Me.txtNumberOfDice.Size = New System.Drawing.Size(36, 20)
        Me.txtNumberOfDice.TabIndex = 1
        '
        'lblD
        '
        Me.lblD.AutoSize = True
        Me.lblD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblD.Location = New System.Drawing.Point(227, 142)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(16, 17)
        Me.lblD.TabIndex = 10
        Me.lblD.Text = "d"
        '
        'cboDieSize
        '
        Me.cboDieSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDieSize.FormattingEnabled = True
        Me.cboDieSize.Location = New System.Drawing.Point(241, 141)
        Me.cboDieSize.Name = "cboDieSize"
        Me.cboDieSize.Size = New System.Drawing.Size(54, 21)
        Me.cboDieSize.TabIndex = 2
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(255, 124)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(27, 13)
        Me.lblSize.TabIndex = 8
        Me.lblSize.Text = "Size"
        '
        'txtModifier
        '
        Me.txtModifier.Location = New System.Drawing.Point(315, 142)
        Me.txtModifier.Name = "txtModifier"
        Me.txtModifier.Size = New System.Drawing.Size(30, 20)
        Me.txtModifier.TabIndex = 3
        '
        'lblModifier
        '
        Me.lblModifier.AutoSize = True
        Me.lblModifier.Location = New System.Drawing.Point(308, 124)
        Me.lblModifier.Name = "lblModifier"
        Me.lblModifier.Size = New System.Drawing.Size(44, 13)
        Me.lblModifier.TabIndex = 9
        Me.lblModifier.Text = "Modifier"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(278, 458)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnRoll
        '
        Me.btnRoll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoll.Location = New System.Drawing.Point(230, 184)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(75, 23)
        Me.btnRoll.TabIndex = 4
        Me.btnRoll.Text = "&Roll Dice!"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'lstResultsDisplay
        '
        Me.lstResultsDisplay.FormattingEnabled = True
        Me.lstResultsDisplay.Location = New System.Drawing.Point(12, 33)
        Me.lstResultsDisplay.Name = "lstResultsDisplay"
        Me.lstResultsDisplay.Size = New System.Drawing.Size(146, 446)
        Me.lstResultsDisplay.TabIndex = 11
        '
        'btnClearResults
        '
        Me.btnClearResults.Location = New System.Drawing.Point(230, 223)
        Me.btnClearResults.Name = "btnClearResults"
        Me.btnClearResults.Size = New System.Drawing.Size(75, 23)
        Me.btnClearResults.TabIndex = 5
        Me.btnClearResults.Text = "Clear Reults"
        Me.btnClearResults.UseVisualStyleBackColor = True
        '
        'frmDiceRoller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 493)
        Me.Controls.Add(Me.btnClearResults)
        Me.Controls.Add(Me.lstResultsDisplay)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblModifier)
        Me.Controls.Add(Me.txtModifier)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.cboDieSize)
        Me.Controls.Add(Me.lblD)
        Me.Controls.Add(Me.txtNumberOfDice)
        Me.Controls.Add(Me.lblNumberOfDice)
        Me.Controls.Add(Me.lblResults)
        Me.Name = "frmDiceRoller"
        Me.Text = "Dice Roller"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblResults As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfDice As System.Windows.Forms.Label
    Friend WithEvents txtNumberOfDice As System.Windows.Forms.TextBox
    Friend WithEvents lblD As System.Windows.Forms.Label
    Friend WithEvents cboDieSize As System.Windows.Forms.ComboBox
    Friend WithEvents lblSize As System.Windows.Forms.Label
    Friend WithEvents txtModifier As System.Windows.Forms.TextBox
    Friend WithEvents lblModifier As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnRoll As System.Windows.Forms.Button
    Friend WithEvents lstResultsDisplay As System.Windows.Forms.ListBox
    Friend WithEvents btnClearResults As System.Windows.Forms.Button
End Class
