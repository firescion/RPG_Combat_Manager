<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCombatManager
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
        Me.grpDieRoller = New System.Windows.Forms.GroupBox()
        Me.btnClearResults = New System.Windows.Forms.Button()
        Me.lstResultsDisplay = New System.Windows.Forms.ListBox()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.lblNumberOfDice = New System.Windows.Forms.Label()
        Me.txtNumberOfDice = New System.Windows.Forms.TextBox()
        Me.lblModifier = New System.Windows.Forms.Label()
        Me.lblD = New System.Windows.Forms.Label()
        Me.txtModifier = New System.Windows.Forms.TextBox()
        Me.cboDieSize = New System.Windows.Forms.ComboBox()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.grpInitiative = New System.Windows.Forms.GroupBox()
        Me.dgvResults = New System.Windows.Forms.DataGridView()
        Me.lblMonsterInitiative = New System.Windows.Forms.Label()
        Me.lblPlayerInitiative = New System.Windows.Forms.Label()
        Me.txtMonster4Initiative = New System.Windows.Forms.TextBox()
        Me.txtMonster3Initiative = New System.Windows.Forms.TextBox()
        Me.txtMonster2Initiative = New System.Windows.Forms.TextBox()
        Me.txtMonster1Initiative = New System.Windows.Forms.TextBox()
        Me.txtPlayer4Initiative = New System.Windows.Forms.TextBox()
        Me.txtPlayer3Initiative = New System.Windows.Forms.TextBox()
        Me.txtPlayer2Initiative = New System.Windows.Forms.TextBox()
        Me.txtPlayer1Initiative = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRollInitiative = New System.Windows.Forms.Button()
        Me.txtMonster4 = New System.Windows.Forms.TextBox()
        Me.txtMonster3 = New System.Windows.Forms.TextBox()
        Me.txtMonster2 = New System.Windows.Forms.TextBox()
        Me.txtMonster1 = New System.Windows.Forms.TextBox()
        Me.lblMonsterName = New System.Windows.Forms.Label()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.txtPlayer4 = New System.Windows.Forms.TextBox()
        Me.txtPlayer3 = New System.Windows.Forms.TextBox()
        Me.txtPlayer2 = New System.Windows.Forms.TextBox()
        Me.txtPlayer1 = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLoadPlayers = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.grpDieRoller.SuspendLayout()
        Me.grpInitiative.SuspendLayout()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpDieRoller
        '
        Me.grpDieRoller.Controls.Add(Me.btnClearResults)
        Me.grpDieRoller.Controls.Add(Me.lstResultsDisplay)
        Me.grpDieRoller.Controls.Add(Me.lblResults)
        Me.grpDieRoller.Controls.Add(Me.btnRoll)
        Me.grpDieRoller.Controls.Add(Me.lblNumberOfDice)
        Me.grpDieRoller.Controls.Add(Me.txtNumberOfDice)
        Me.grpDieRoller.Controls.Add(Me.lblModifier)
        Me.grpDieRoller.Controls.Add(Me.lblD)
        Me.grpDieRoller.Controls.Add(Me.txtModifier)
        Me.grpDieRoller.Controls.Add(Me.cboDieSize)
        Me.grpDieRoller.Controls.Add(Me.lblSize)
        Me.grpDieRoller.Location = New System.Drawing.Point(12, 12)
        Me.grpDieRoller.Name = "grpDieRoller"
        Me.grpDieRoller.Size = New System.Drawing.Size(357, 347)
        Me.grpDieRoller.TabIndex = 35
        Me.grpDieRoller.TabStop = False
        '
        'btnClearResults
        '
        Me.btnClearResults.Location = New System.Drawing.Point(224, 224)
        Me.btnClearResults.Name = "btnClearResults"
        Me.btnClearResults.Size = New System.Drawing.Size(75, 23)
        Me.btnClearResults.TabIndex = 43
        Me.btnClearResults.Text = "Clear Reults"
        Me.btnClearResults.UseVisualStyleBackColor = True
        '
        'lstResultsDisplay
        '
        Me.lstResultsDisplay.FormattingEnabled = True
        Me.lstResultsDisplay.Location = New System.Drawing.Point(6, 34)
        Me.lstResultsDisplay.Name = "lstResultsDisplay"
        Me.lstResultsDisplay.Size = New System.Drawing.Size(146, 303)
        Me.lstResultsDisplay.TabIndex = 49
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(7, 14)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(42, 13)
        Me.lblResults.TabIndex = 38
        Me.lblResults.Text = "Results"
        '
        'btnRoll
        '
        Me.btnRoll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoll.Location = New System.Drawing.Point(224, 185)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(75, 23)
        Me.btnRoll.TabIndex = 42
        Me.btnRoll.Text = "&Roll Dice!"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'lblNumberOfDice
        '
        Me.lblNumberOfDice.AutoSize = True
        Me.lblNumberOfDice.Location = New System.Drawing.Point(172, 126)
        Me.lblNumberOfDice.Name = "lblNumberOfDice"
        Me.lblNumberOfDice.Size = New System.Drawing.Size(51, 13)
        Me.lblNumberOfDice.TabIndex = 45
        Me.lblNumberOfDice.Text = "# of Dice"
        '
        'txtNumberOfDice
        '
        Me.txtNumberOfDice.Location = New System.Drawing.Point(179, 142)
        Me.txtNumberOfDice.Name = "txtNumberOfDice"
        Me.txtNumberOfDice.Size = New System.Drawing.Size(36, 20)
        Me.txtNumberOfDice.TabIndex = 39
        '
        'lblModifier
        '
        Me.lblModifier.AutoSize = True
        Me.lblModifier.Location = New System.Drawing.Point(302, 125)
        Me.lblModifier.Name = "lblModifier"
        Me.lblModifier.Size = New System.Drawing.Size(44, 13)
        Me.lblModifier.TabIndex = 47
        Me.lblModifier.Text = "Modifier"
        '
        'lblD
        '
        Me.lblD.AutoSize = True
        Me.lblD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblD.Location = New System.Drawing.Point(221, 143)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(16, 17)
        Me.lblD.TabIndex = 48
        Me.lblD.Text = "d"
        '
        'txtModifier
        '
        Me.txtModifier.Location = New System.Drawing.Point(309, 143)
        Me.txtModifier.Name = "txtModifier"
        Me.txtModifier.Size = New System.Drawing.Size(30, 20)
        Me.txtModifier.TabIndex = 41
        '
        'cboDieSize
        '
        Me.cboDieSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDieSize.FormattingEnabled = True
        Me.cboDieSize.Location = New System.Drawing.Point(235, 142)
        Me.cboDieSize.Name = "cboDieSize"
        Me.cboDieSize.Size = New System.Drawing.Size(54, 21)
        Me.cboDieSize.TabIndex = 40
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(249, 125)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(27, 13)
        Me.lblSize.TabIndex = 46
        Me.lblSize.Text = "Size"
        '
        'grpInitiative
        '
        Me.grpInitiative.Controls.Add(Me.btnLoadPlayers)
        Me.grpInitiative.Controls.Add(Me.btnSave)
        Me.grpInitiative.Controls.Add(Me.dgvResults)
        Me.grpInitiative.Controls.Add(Me.lblMonsterInitiative)
        Me.grpInitiative.Controls.Add(Me.lblPlayerInitiative)
        Me.grpInitiative.Controls.Add(Me.txtMonster4Initiative)
        Me.grpInitiative.Controls.Add(Me.txtMonster3Initiative)
        Me.grpInitiative.Controls.Add(Me.txtMonster2Initiative)
        Me.grpInitiative.Controls.Add(Me.txtMonster1Initiative)
        Me.grpInitiative.Controls.Add(Me.txtPlayer4Initiative)
        Me.grpInitiative.Controls.Add(Me.txtPlayer3Initiative)
        Me.grpInitiative.Controls.Add(Me.txtPlayer2Initiative)
        Me.grpInitiative.Controls.Add(Me.txtPlayer1Initiative)
        Me.grpInitiative.Controls.Add(Me.Label3)
        Me.grpInitiative.Controls.Add(Me.btnRollInitiative)
        Me.grpInitiative.Controls.Add(Me.txtMonster4)
        Me.grpInitiative.Controls.Add(Me.txtMonster3)
        Me.grpInitiative.Controls.Add(Me.txtMonster2)
        Me.grpInitiative.Controls.Add(Me.txtMonster1)
        Me.grpInitiative.Controls.Add(Me.lblMonsterName)
        Me.grpInitiative.Controls.Add(Me.lblPlayerName)
        Me.grpInitiative.Controls.Add(Me.txtPlayer4)
        Me.grpInitiative.Controls.Add(Me.txtPlayer3)
        Me.grpInitiative.Controls.Add(Me.txtPlayer2)
        Me.grpInitiative.Controls.Add(Me.txtPlayer1)
        Me.grpInitiative.Location = New System.Drawing.Point(403, 26)
        Me.grpInitiative.Name = "grpInitiative"
        Me.grpInitiative.Size = New System.Drawing.Size(571, 333)
        Me.grpInitiative.TabIndex = 36
        Me.grpInitiative.TabStop = False
        '
        'dgvResults
        '
        Me.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResults.Location = New System.Drawing.Point(292, 44)
        Me.dgvResults.Name = "dgvResults"
        Me.dgvResults.Size = New System.Drawing.Size(268, 251)
        Me.dgvResults.TabIndex = 53
        '
        'lblMonsterInitiative
        '
        Me.lblMonsterInitiative.AutoSize = True
        Me.lblMonsterInitiative.Location = New System.Drawing.Point(185, 170)
        Me.lblMonsterInitiative.Name = "lblMonsterInitiative"
        Me.lblMonsterInitiative.Size = New System.Drawing.Size(46, 13)
        Me.lblMonsterInitiative.TabIndex = 52
        Me.lblMonsterInitiative.Text = "Initiative"
        '
        'lblPlayerInitiative
        '
        Me.lblPlayerInitiative.AutoSize = True
        Me.lblPlayerInitiative.Location = New System.Drawing.Point(185, 30)
        Me.lblPlayerInitiative.Name = "lblPlayerInitiative"
        Me.lblPlayerInitiative.Size = New System.Drawing.Size(46, 13)
        Me.lblPlayerInitiative.TabIndex = 49
        Me.lblPlayerInitiative.Text = "Initiative"
        '
        'txtMonster4Initiative
        '
        Me.txtMonster4Initiative.Location = New System.Drawing.Point(194, 268)
        Me.txtMonster4Initiative.Name = "txtMonster4Initiative"
        Me.txtMonster4Initiative.Size = New System.Drawing.Size(29, 20)
        Me.txtMonster4Initiative.TabIndex = 45
        '
        'txtMonster3Initiative
        '
        Me.txtMonster3Initiative.Location = New System.Drawing.Point(194, 241)
        Me.txtMonster3Initiative.Name = "txtMonster3Initiative"
        Me.txtMonster3Initiative.Size = New System.Drawing.Size(29, 20)
        Me.txtMonster3Initiative.TabIndex = 43
        '
        'txtMonster2Initiative
        '
        Me.txtMonster2Initiative.Location = New System.Drawing.Point(195, 214)
        Me.txtMonster2Initiative.Name = "txtMonster2Initiative"
        Me.txtMonster2Initiative.Size = New System.Drawing.Size(29, 20)
        Me.txtMonster2Initiative.TabIndex = 41
        '
        'txtMonster1Initiative
        '
        Me.txtMonster1Initiative.Location = New System.Drawing.Point(195, 187)
        Me.txtMonster1Initiative.Name = "txtMonster1Initiative"
        Me.txtMonster1Initiative.Size = New System.Drawing.Size(29, 20)
        Me.txtMonster1Initiative.TabIndex = 39
        '
        'txtPlayer4Initiative
        '
        Me.txtPlayer4Initiative.Location = New System.Drawing.Point(194, 128)
        Me.txtPlayer4Initiative.Name = "txtPlayer4Initiative"
        Me.txtPlayer4Initiative.Size = New System.Drawing.Size(29, 20)
        Me.txtPlayer4Initiative.TabIndex = 37
        '
        'txtPlayer3Initiative
        '
        Me.txtPlayer3Initiative.Location = New System.Drawing.Point(195, 101)
        Me.txtPlayer3Initiative.Name = "txtPlayer3Initiative"
        Me.txtPlayer3Initiative.Size = New System.Drawing.Size(29, 20)
        Me.txtPlayer3Initiative.TabIndex = 35
        '
        'txtPlayer2Initiative
        '
        Me.txtPlayer2Initiative.Location = New System.Drawing.Point(194, 76)
        Me.txtPlayer2Initiative.Name = "txtPlayer2Initiative"
        Me.txtPlayer2Initiative.Size = New System.Drawing.Size(29, 20)
        Me.txtPlayer2Initiative.TabIndex = 33
        '
        'txtPlayer1Initiative
        '
        Me.txtPlayer1Initiative.Location = New System.Drawing.Point(194, 50)
        Me.txtPlayer1Initiative.Name = "txtPlayer1Initiative"
        Me.txtPlayer1Initiative.Size = New System.Drawing.Size(29, 20)
        Me.txtPlayer1Initiative.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(289, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Initiative Order:"
        '
        'btnRollInitiative
        '
        Me.btnRollInitiative.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRollInitiative.Location = New System.Drawing.Point(403, 301)
        Me.btnRollInitiative.Name = "btnRollInitiative"
        Me.btnRollInitiative.Size = New System.Drawing.Size(158, 23)
        Me.btnRollInitiative.TabIndex = 47
        Me.btnRollInitiative.Text = "Roll Initiative!"
        Me.btnRollInitiative.UseVisualStyleBackColor = True
        '
        'txtMonster4
        '
        Me.txtMonster4.Location = New System.Drawing.Point(9, 268)
        Me.txtMonster4.Name = "txtMonster4"
        Me.txtMonster4.Size = New System.Drawing.Size(179, 20)
        Me.txtMonster4.TabIndex = 44
        Me.txtMonster4.Text = "Monster 4"
        '
        'txtMonster3
        '
        Me.txtMonster3.Location = New System.Drawing.Point(9, 241)
        Me.txtMonster3.Name = "txtMonster3"
        Me.txtMonster3.Size = New System.Drawing.Size(179, 20)
        Me.txtMonster3.TabIndex = 42
        Me.txtMonster3.Text = "Monster 3"
        '
        'txtMonster2
        '
        Me.txtMonster2.Location = New System.Drawing.Point(9, 214)
        Me.txtMonster2.Name = "txtMonster2"
        Me.txtMonster2.Size = New System.Drawing.Size(179, 20)
        Me.txtMonster2.TabIndex = 40
        Me.txtMonster2.Text = "Monster 2"
        '
        'txtMonster1
        '
        Me.txtMonster1.Location = New System.Drawing.Point(9, 187)
        Me.txtMonster1.Name = "txtMonster1"
        Me.txtMonster1.Size = New System.Drawing.Size(179, 20)
        Me.txtMonster1.TabIndex = 38
        Me.txtMonster1.Text = "Monster 1"
        '
        'lblMonsterName
        '
        Me.lblMonsterName.AutoSize = True
        Me.lblMonsterName.Location = New System.Drawing.Point(6, 170)
        Me.lblMonsterName.Name = "lblMonsterName"
        Me.lblMonsterName.Size = New System.Drawing.Size(128, 13)
        Me.lblMonsterName.TabIndex = 51
        Me.lblMonsterName.Text = "Monster/Opponent Name"
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.Location = New System.Drawing.Point(6, 30)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(65, 13)
        Me.lblPlayerName.TabIndex = 48
        Me.lblPlayerName.Text = "Player name"
        '
        'txtPlayer4
        '
        Me.txtPlayer4.Location = New System.Drawing.Point(6, 128)
        Me.txtPlayer4.Name = "txtPlayer4"
        Me.txtPlayer4.Size = New System.Drawing.Size(182, 20)
        Me.txtPlayer4.TabIndex = 36
        Me.txtPlayer4.Text = "Player 4"
        '
        'txtPlayer3
        '
        Me.txtPlayer3.Location = New System.Drawing.Point(6, 102)
        Me.txtPlayer3.Name = "txtPlayer3"
        Me.txtPlayer3.Size = New System.Drawing.Size(182, 20)
        Me.txtPlayer3.TabIndex = 34
        Me.txtPlayer3.Text = "Player 3"
        '
        'txtPlayer2
        '
        Me.txtPlayer2.Location = New System.Drawing.Point(6, 76)
        Me.txtPlayer2.Name = "txtPlayer2"
        Me.txtPlayer2.Size = New System.Drawing.Size(182, 20)
        Me.txtPlayer2.TabIndex = 32
        Me.txtPlayer2.Text = "Player 2"
        '
        'txtPlayer1
        '
        Me.txtPlayer1.Location = New System.Drawing.Point(6, 50)
        Me.txtPlayer1.Name = "txtPlayer1"
        Me.txtPlayer1.Size = New System.Drawing.Size(182, 20)
        Me.txtPlayer1.TabIndex = 30
        Me.txtPlayer1.Text = "Player 1"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(899, 365)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 37
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnLoadPlayers
        '
        Me.btnLoadPlayers.Location = New System.Drawing.Point(104, 304)
        Me.btnLoadPlayers.Name = "btnLoadPlayers"
        Me.btnLoadPlayers.Size = New System.Drawing.Size(85, 23)
        Me.btnLoadPlayers.TabIndex = 55
        Me.btnLoadPlayers.Text = "&Load Players"
        Me.btnLoadPlayers.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(9, 304)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 23)
        Me.btnSave.TabIndex = 54
        Me.btnSave.Text = "&Save Players"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmCombatManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 398)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpDieRoller)
        Me.Controls.Add(Me.grpInitiative)
        Me.Name = "frmCombatManager"
        Me.Text = "Combat Manager"
        Me.grpDieRoller.ResumeLayout(False)
        Me.grpDieRoller.PerformLayout()
        Me.grpInitiative.ResumeLayout(False)
        Me.grpInitiative.PerformLayout()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpDieRoller As System.Windows.Forms.GroupBox
    Friend WithEvents grpInitiative As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClearResults As System.Windows.Forms.Button
    Friend WithEvents lstResultsDisplay As System.Windows.Forms.ListBox
    Friend WithEvents lblResults As System.Windows.Forms.Label
    Friend WithEvents btnRoll As System.Windows.Forms.Button
    Friend WithEvents lblNumberOfDice As System.Windows.Forms.Label
    Friend WithEvents txtNumberOfDice As System.Windows.Forms.TextBox
    Friend WithEvents lblModifier As System.Windows.Forms.Label
    Friend WithEvents lblD As System.Windows.Forms.Label
    Friend WithEvents txtModifier As System.Windows.Forms.TextBox
    Friend WithEvents cboDieSize As System.Windows.Forms.ComboBox
    Friend WithEvents lblSize As System.Windows.Forms.Label
    Friend WithEvents dgvResults As System.Windows.Forms.DataGridView
    Friend WithEvents lblMonsterInitiative As System.Windows.Forms.Label
    Friend WithEvents lblPlayerInitiative As System.Windows.Forms.Label
    Friend WithEvents txtMonster4Initiative As System.Windows.Forms.TextBox
    Friend WithEvents txtMonster3Initiative As System.Windows.Forms.TextBox
    Friend WithEvents txtMonster2Initiative As System.Windows.Forms.TextBox
    Friend WithEvents txtMonster1Initiative As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayer4Initiative As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayer3Initiative As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayer2Initiative As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayer1Initiative As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnRollInitiative As System.Windows.Forms.Button
    Friend WithEvents txtMonster4 As System.Windows.Forms.TextBox
    Friend WithEvents txtMonster3 As System.Windows.Forms.TextBox
    Friend WithEvents txtMonster2 As System.Windows.Forms.TextBox
    Friend WithEvents txtMonster1 As System.Windows.Forms.TextBox
    Friend WithEvents lblMonsterName As System.Windows.Forms.Label
    Friend WithEvents lblPlayerName As System.Windows.Forms.Label
    Friend WithEvents txtPlayer4 As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayer3 As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayer2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayer1 As System.Windows.Forms.TextBox
    Friend WithEvents btnLoadPlayers As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
