<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInitiativeTracker
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
        Me.components = New System.ComponentModel.Container()
        Me.txtPlayer1 = New System.Windows.Forms.TextBox()
        Me.txtPlayer2 = New System.Windows.Forms.TextBox()
        Me.txtPlayer3 = New System.Windows.Forms.TextBox()
        Me.txtPlayer4 = New System.Windows.Forms.TextBox()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblMonsterName = New System.Windows.Forms.Label()
        Me.txtMonster1 = New System.Windows.Forms.TextBox()
        Me.txtMonster2 = New System.Windows.Forms.TextBox()
        Me.txtMonster3 = New System.Windows.Forms.TextBox()
        Me.txtMonster4 = New System.Windows.Forms.TextBox()
        Me.btnRollInitiative = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPlayer1Initiative = New System.Windows.Forms.TextBox()
        Me.txtPlayer2Initiative = New System.Windows.Forms.TextBox()
        Me.txtPlayer3Initiative = New System.Windows.Forms.TextBox()
        Me.txtPlayer4Initiative = New System.Windows.Forms.TextBox()
        Me.txtMonster1Initiative = New System.Windows.Forms.TextBox()
        Me.txtMonster2Initiative = New System.Windows.Forms.TextBox()
        Me.txtMonster3Initiative = New System.Windows.Forms.TextBox()
        Me.txtMonster4Initiative = New System.Windows.Forms.TextBox()
        Me.lblPlayerInitiative = New System.Windows.Forms.Label()
        Me.lblMonsterInitiative = New System.Windows.Forms.Label()
        Me.dgvResults = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InitiativeModDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InitiativeTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CharacterBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CharacterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CharacterBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CharacterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPlayer1
        '
        Me.txtPlayer1.Location = New System.Drawing.Point(12, 54)
        Me.txtPlayer1.Name = "txtPlayer1"
        Me.txtPlayer1.Size = New System.Drawing.Size(182, 20)
        Me.txtPlayer1.TabIndex = 1
        Me.txtPlayer1.Text = "Player 1"
        '
        'txtPlayer2
        '
        Me.txtPlayer2.Location = New System.Drawing.Point(12, 80)
        Me.txtPlayer2.Name = "txtPlayer2"
        Me.txtPlayer2.Size = New System.Drawing.Size(182, 20)
        Me.txtPlayer2.TabIndex = 3
        Me.txtPlayer2.Text = "Player 2"
        '
        'txtPlayer3
        '
        Me.txtPlayer3.Location = New System.Drawing.Point(12, 106)
        Me.txtPlayer3.Name = "txtPlayer3"
        Me.txtPlayer3.Size = New System.Drawing.Size(182, 20)
        Me.txtPlayer3.TabIndex = 5
        Me.txtPlayer3.Text = "Player 3"
        '
        'txtPlayer4
        '
        Me.txtPlayer4.Location = New System.Drawing.Point(12, 132)
        Me.txtPlayer4.Name = "txtPlayer4"
        Me.txtPlayer4.Size = New System.Drawing.Size(182, 20)
        Me.txtPlayer4.TabIndex = 7
        Me.txtPlayer4.Text = "Player 4"
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.Location = New System.Drawing.Point(12, 34)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(65, 13)
        Me.lblPlayerName.TabIndex = 23
        Me.lblPlayerName.Text = "Player name"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(232, 325)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 23)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "&Save Players"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblMonsterName
        '
        Me.lblMonsterName.AutoSize = True
        Me.lblMonsterName.Location = New System.Drawing.Point(12, 174)
        Me.lblMonsterName.Name = "lblMonsterName"
        Me.lblMonsterName.Size = New System.Drawing.Size(128, 13)
        Me.lblMonsterName.TabIndex = 26
        Me.lblMonsterName.Text = "Monster/Opponent Name"
        '
        'txtMonster1
        '
        Me.txtMonster1.Location = New System.Drawing.Point(15, 191)
        Me.txtMonster1.Name = "txtMonster1"
        Me.txtMonster1.Size = New System.Drawing.Size(179, 20)
        Me.txtMonster1.TabIndex = 9
        Me.txtMonster1.Text = "Monster 1"
        '
        'txtMonster2
        '
        Me.txtMonster2.Location = New System.Drawing.Point(15, 218)
        Me.txtMonster2.Name = "txtMonster2"
        Me.txtMonster2.Size = New System.Drawing.Size(179, 20)
        Me.txtMonster2.TabIndex = 11
        Me.txtMonster2.Text = "Monster 2"
        '
        'txtMonster3
        '
        Me.txtMonster3.Location = New System.Drawing.Point(15, 245)
        Me.txtMonster3.Name = "txtMonster3"
        Me.txtMonster3.Size = New System.Drawing.Size(179, 20)
        Me.txtMonster3.TabIndex = 13
        Me.txtMonster3.Text = "Monster 3"
        '
        'txtMonster4
        '
        Me.txtMonster4.Location = New System.Drawing.Point(15, 272)
        Me.txtMonster4.Name = "txtMonster4"
        Me.txtMonster4.Size = New System.Drawing.Size(179, 20)
        Me.txtMonster4.TabIndex = 15
        Me.txtMonster4.Text = "Monster 4"
        '
        'btnRollInitiative
        '
        Me.btnRollInitiative.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRollInitiative.Location = New System.Drawing.Point(327, 325)
        Me.btnRollInitiative.Name = "btnRollInitiative"
        Me.btnRollInitiative.Size = New System.Drawing.Size(158, 23)
        Me.btnRollInitiative.TabIndex = 21
        Me.btnRollInitiative.Text = "Roll Initiative!"
        Me.btnRollInitiative.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(295, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Initiative Order:"
        '
        'txtPlayer1Initiative
        '
        Me.txtPlayer1Initiative.Location = New System.Drawing.Point(200, 54)
        Me.txtPlayer1Initiative.Name = "txtPlayer1Initiative"
        Me.txtPlayer1Initiative.Size = New System.Drawing.Size(29, 20)
        Me.txtPlayer1Initiative.TabIndex = 2
        '
        'txtPlayer2Initiative
        '
        Me.txtPlayer2Initiative.Location = New System.Drawing.Point(200, 80)
        Me.txtPlayer2Initiative.Name = "txtPlayer2Initiative"
        Me.txtPlayer2Initiative.Size = New System.Drawing.Size(29, 20)
        Me.txtPlayer2Initiative.TabIndex = 4
        '
        'txtPlayer3Initiative
        '
        Me.txtPlayer3Initiative.Location = New System.Drawing.Point(201, 105)
        Me.txtPlayer3Initiative.Name = "txtPlayer3Initiative"
        Me.txtPlayer3Initiative.Size = New System.Drawing.Size(29, 20)
        Me.txtPlayer3Initiative.TabIndex = 6
        '
        'txtPlayer4Initiative
        '
        Me.txtPlayer4Initiative.Location = New System.Drawing.Point(200, 132)
        Me.txtPlayer4Initiative.Name = "txtPlayer4Initiative"
        Me.txtPlayer4Initiative.Size = New System.Drawing.Size(29, 20)
        Me.txtPlayer4Initiative.TabIndex = 8
        '
        'txtMonster1Initiative
        '
        Me.txtMonster1Initiative.Location = New System.Drawing.Point(201, 191)
        Me.txtMonster1Initiative.Name = "txtMonster1Initiative"
        Me.txtMonster1Initiative.Size = New System.Drawing.Size(29, 20)
        Me.txtMonster1Initiative.TabIndex = 10
        '
        'txtMonster2Initiative
        '
        Me.txtMonster2Initiative.Location = New System.Drawing.Point(201, 218)
        Me.txtMonster2Initiative.Name = "txtMonster2Initiative"
        Me.txtMonster2Initiative.Size = New System.Drawing.Size(29, 20)
        Me.txtMonster2Initiative.TabIndex = 12
        '
        'txtMonster3Initiative
        '
        Me.txtMonster3Initiative.Location = New System.Drawing.Point(200, 245)
        Me.txtMonster3Initiative.Name = "txtMonster3Initiative"
        Me.txtMonster3Initiative.Size = New System.Drawing.Size(29, 20)
        Me.txtMonster3Initiative.TabIndex = 14
        '
        'txtMonster4Initiative
        '
        Me.txtMonster4Initiative.Location = New System.Drawing.Point(200, 272)
        Me.txtMonster4Initiative.Name = "txtMonster4Initiative"
        Me.txtMonster4Initiative.Size = New System.Drawing.Size(29, 20)
        Me.txtMonster4Initiative.TabIndex = 16
        '
        'lblPlayerInitiative
        '
        Me.lblPlayerInitiative.AutoSize = True
        Me.lblPlayerInitiative.Location = New System.Drawing.Point(191, 34)
        Me.lblPlayerInitiative.Name = "lblPlayerInitiative"
        Me.lblPlayerInitiative.Size = New System.Drawing.Size(46, 13)
        Me.lblPlayerInitiative.TabIndex = 24
        Me.lblPlayerInitiative.Text = "Initiative"
        '
        'lblMonsterInitiative
        '
        Me.lblMonsterInitiative.AutoSize = True
        Me.lblMonsterInitiative.Location = New System.Drawing.Point(191, 174)
        Me.lblMonsterInitiative.Name = "lblMonsterInitiative"
        Me.lblMonsterInitiative.Size = New System.Drawing.Size(46, 13)
        Me.lblMonsterInitiative.TabIndex = 27
        Me.lblMonsterInitiative.Text = "Initiative"
        '
        'dgvResults
        '
        Me.dgvResults.AutoGenerateColumns = False
        Me.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResults.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.InitiativeModDataGridViewTextBoxColumn, Me.InitiativeTotalDataGridViewTextBoxColumn})
        Me.dgvResults.DataSource = Me.CharacterBindingSource1
        Me.dgvResults.Location = New System.Drawing.Point(298, 48)
        Me.dgvResults.Name = "dgvResults"
        Me.dgvResults.Size = New System.Drawing.Size(268, 251)
        Me.dgvResults.TabIndex = 28
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'InitiativeModDataGridViewTextBoxColumn
        '
        Me.InitiativeModDataGridViewTextBoxColumn.DataPropertyName = "InitiativeMod"
        Me.InitiativeModDataGridViewTextBoxColumn.HeaderText = "InitiativeMod"
        Me.InitiativeModDataGridViewTextBoxColumn.Name = "InitiativeModDataGridViewTextBoxColumn"
        Me.InitiativeModDataGridViewTextBoxColumn.Visible = False
        '
        'InitiativeTotalDataGridViewTextBoxColumn
        '
        Me.InitiativeTotalDataGridViewTextBoxColumn.DataPropertyName = "InitiativeTotal"
        Me.InitiativeTotalDataGridViewTextBoxColumn.HeaderText = "InitiativeTotal"
        Me.InitiativeTotalDataGridViewTextBoxColumn.Name = "InitiativeTotalDataGridViewTextBoxColumn"
        '
        'CharacterBindingSource1
        '
        Me.CharacterBindingSource1.DataSource = GetType(RPG_Combat_Manager.Character)
        '
        'CharacterBindingSource
        '
        Me.CharacterBindingSource.DataSource = GetType(RPG_Combat_Manager.Character)
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(491, 325)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 29
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmInitiativeTracker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 360)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.dgvResults)
        Me.Controls.Add(Me.lblMonsterInitiative)
        Me.Controls.Add(Me.lblPlayerInitiative)
        Me.Controls.Add(Me.txtMonster4Initiative)
        Me.Controls.Add(Me.txtMonster3Initiative)
        Me.Controls.Add(Me.txtMonster2Initiative)
        Me.Controls.Add(Me.txtMonster1Initiative)
        Me.Controls.Add(Me.txtPlayer4Initiative)
        Me.Controls.Add(Me.txtPlayer3Initiative)
        Me.Controls.Add(Me.txtPlayer2Initiative)
        Me.Controls.Add(Me.txtPlayer1Initiative)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnRollInitiative)
        Me.Controls.Add(Me.txtMonster4)
        Me.Controls.Add(Me.txtMonster3)
        Me.Controls.Add(Me.txtMonster2)
        Me.Controls.Add(Me.txtMonster1)
        Me.Controls.Add(Me.lblMonsterName)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Controls.Add(Me.txtPlayer4)
        Me.Controls.Add(Me.txtPlayer3)
        Me.Controls.Add(Me.txtPlayer2)
        Me.Controls.Add(Me.txtPlayer1)
        Me.Name = "frmInitiativeTracker"
        Me.Text = "Initiative Tracker"
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CharacterBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CharacterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPlayer1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayer2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayer3 As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayer4 As System.Windows.Forms.TextBox
    Friend WithEvents lblPlayerName As System.Windows.Forms.Label
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblMonsterName As System.Windows.Forms.Label
    Friend WithEvents txtMonster1 As System.Windows.Forms.TextBox
    Friend WithEvents txtMonster2 As System.Windows.Forms.TextBox
    Friend WithEvents txtMonster3 As System.Windows.Forms.TextBox
    Friend WithEvents txtMonster4 As System.Windows.Forms.TextBox
    Friend WithEvents btnRollInitiative As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPlayer1Initiative As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayer2Initiative As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayer3Initiative As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayer4Initiative As System.Windows.Forms.TextBox
    Friend WithEvents txtMonster1Initiative As System.Windows.Forms.TextBox
    Friend WithEvents txtMonster2Initiative As System.Windows.Forms.TextBox
    Friend WithEvents txtMonster3Initiative As System.Windows.Forms.TextBox
    Friend WithEvents txtMonster4Initiative As System.Windows.Forms.TextBox
    Friend WithEvents lblPlayerInitiative As System.Windows.Forms.Label
    Friend WithEvents lblMonsterInitiative As System.Windows.Forms.Label
    Friend WithEvents CharacterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dgvResults As System.Windows.Forms.DataGridView
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InitiativeModDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InitiativeTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KInitiativeTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CharacterBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
