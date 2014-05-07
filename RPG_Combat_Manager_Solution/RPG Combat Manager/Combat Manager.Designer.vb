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
        Me.lstResultsDisplay = New System.Windows.Forms.ListBox()
        Me.lblModifier = New System.Windows.Forms.Label()
        Me.txtModifier = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblD = New System.Windows.Forms.Label()
        Me.txtNumberOfDice = New System.Windows.Forms.TextBox()
        Me.lblNumberOfDice = New System.Windows.Forms.Label()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.btnAddM = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstIntOrder = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAddP = New System.Windows.Forms.Button()
        Me.txtMonster4 = New System.Windows.Forms.TextBox()
        Me.txtMonster3 = New System.Windows.Forms.TextBox()
        Me.txtMonster2 = New System.Windows.Forms.TextBox()
        Me.txtMonster1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPlayer4 = New System.Windows.Forms.TextBox()
        Me.txtPlayer3 = New System.Windows.Forms.TextBox()
        Me.txtPlayer2 = New System.Windows.Forms.TextBox()
        Me.txtPlayer1 = New System.Windows.Forms.TextBox()
        Me.grpDieRoller = New System.Windows.Forms.GroupBox()
        Me.grpInitiative = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstResultsDisplay
        '
        Me.lstResultsDisplay.FormattingEnabled = True
        Me.lstResultsDisplay.Location = New System.Drawing.Point(31, 46)
        Me.lstResultsDisplay.Name = "lstResultsDisplay"
        Me.lstResultsDisplay.Size = New System.Drawing.Size(146, 446)
        Me.lstResultsDisplay.TabIndex = 17
        '
        'lblModifier
        '
        Me.lblModifier.AutoSize = True
        Me.lblModifier.Location = New System.Drawing.Point(313, 43)
        Me.lblModifier.Name = "lblModifier"
        Me.lblModifier.Size = New System.Drawing.Size(44, 13)
        Me.lblModifier.TabIndex = 16
        Me.lblModifier.Text = "Modifier"
        '
        'txtModifier
        '
        Me.txtModifier.Location = New System.Drawing.Point(320, 61)
        Me.txtModifier.Name = "txtModifier"
        Me.txtModifier.Size = New System.Drawing.Size(30, 20)
        Me.txtModifier.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(260, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Size"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(246, 60)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(54, 21)
        Me.ComboBox1.TabIndex = 13
        '
        'lblD
        '
        Me.lblD.AutoSize = True
        Me.lblD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblD.Location = New System.Drawing.Point(232, 61)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(16, 17)
        Me.lblD.TabIndex = 12
        Me.lblD.Text = "d"
        '
        'txtNumberOfDice
        '
        Me.txtNumberOfDice.Location = New System.Drawing.Point(190, 60)
        Me.txtNumberOfDice.Name = "txtNumberOfDice"
        Me.txtNumberOfDice.Size = New System.Drawing.Size(36, 20)
        Me.txtNumberOfDice.TabIndex = 11
        '
        'lblNumberOfDice
        '
        Me.lblNumberOfDice.AutoSize = True
        Me.lblNumberOfDice.Location = New System.Drawing.Point(183, 44)
        Me.lblNumberOfDice.Name = "lblNumberOfDice"
        Me.lblNumberOfDice.Size = New System.Drawing.Size(51, 13)
        Me.lblNumberOfDice.TabIndex = 10
        Me.lblNumberOfDice.Text = "# of Dice"
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(28, 24)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(42, 13)
        Me.lblResults.TabIndex = 9
        Me.lblResults.Text = "Results"
        '
        'btnAddM
        '
        Me.btnAddM.Location = New System.Drawing.Point(648, 274)
        Me.btnAddM.Name = "btnAddM"
        Me.btnAddM.Size = New System.Drawing.Size(75, 23)
        Me.btnAddM.TabIndex = 34
        Me.btnAddM.Text = "&Add"
        Me.btnAddM.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(813, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Initiative Order:"
        '
        'lstIntOrder
        '
        Me.lstIntOrder.FormattingEnabled = True
        Me.lstIntOrder.Location = New System.Drawing.Point(813, 88)
        Me.lstIntOrder.Name = "lstIntOrder"
        Me.lstIntOrder.Size = New System.Drawing.Size(179, 251)
        Me.lstIntOrder.TabIndex = 32
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(621, 397)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 23)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Roll Initiative!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnAddP
        '
        Me.btnAddP.Location = New System.Drawing.Point(651, 153)
        Me.btnAddP.Name = "btnAddP"
        Me.btnAddP.Size = New System.Drawing.Size(75, 23)
        Me.btnAddP.TabIndex = 30
        Me.btnAddP.Text = "&Add"
        Me.btnAddP.UseVisualStyleBackColor = True
        '
        'txtMonster4
        '
        Me.txtMonster4.Location = New System.Drawing.Point(430, 331)
        Me.txtMonster4.Name = "txtMonster4"
        Me.txtMonster4.Size = New System.Drawing.Size(179, 20)
        Me.txtMonster4.TabIndex = 29
        '
        'txtMonster3
        '
        Me.txtMonster3.Location = New System.Drawing.Point(430, 304)
        Me.txtMonster3.Name = "txtMonster3"
        Me.txtMonster3.Size = New System.Drawing.Size(179, 20)
        Me.txtMonster3.TabIndex = 28
        '
        'txtMonster2
        '
        Me.txtMonster2.Location = New System.Drawing.Point(430, 277)
        Me.txtMonster2.Name = "txtMonster2"
        Me.txtMonster2.Size = New System.Drawing.Size(179, 20)
        Me.txtMonster2.TabIndex = 27
        '
        'txtMonster1
        '
        Me.txtMonster1.Location = New System.Drawing.Point(430, 250)
        Me.txtMonster1.Name = "txtMonster1"
        Me.txtMonster1.Size = New System.Drawing.Size(179, 20)
        Me.txtMonster1.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(427, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Monster/Opponent name(s) and initiative modifier(s). Seperate with a comma"
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(651, 126)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 24
        Me.btnLoad.Text = "&Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(651, 100)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(430, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(308, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Player name(s) and initiative modifier(s).  Seperate with a comma"
        '
        'txtPlayer4
        '
        Me.txtPlayer4.Location = New System.Drawing.Point(430, 166)
        Me.txtPlayer4.Name = "txtPlayer4"
        Me.txtPlayer4.Size = New System.Drawing.Size(182, 20)
        Me.txtPlayer4.TabIndex = 21
        '
        'txtPlayer3
        '
        Me.txtPlayer3.Location = New System.Drawing.Point(430, 140)
        Me.txtPlayer3.Name = "txtPlayer3"
        Me.txtPlayer3.Size = New System.Drawing.Size(182, 20)
        Me.txtPlayer3.TabIndex = 20
        '
        'txtPlayer2
        '
        Me.txtPlayer2.Location = New System.Drawing.Point(430, 114)
        Me.txtPlayer2.Name = "txtPlayer2"
        Me.txtPlayer2.Size = New System.Drawing.Size(182, 20)
        Me.txtPlayer2.TabIndex = 19
        '
        'txtPlayer1
        '
        Me.txtPlayer1.Location = New System.Drawing.Point(430, 88)
        Me.txtPlayer1.Name = "txtPlayer1"
        Me.txtPlayer1.Size = New System.Drawing.Size(182, 20)
        Me.txtPlayer1.TabIndex = 18
        '
        'grpDieRoller
        '
        Me.grpDieRoller.Location = New System.Drawing.Point(12, 12)
        Me.grpDieRoller.Name = "grpDieRoller"
        Me.grpDieRoller.Size = New System.Drawing.Size(357, 496)
        Me.grpDieRoller.TabIndex = 35
        Me.grpDieRoller.TabStop = False
        '
        'grpInitiative
        '
        Me.grpInitiative.Location = New System.Drawing.Point(408, 43)
        Me.grpInitiative.Name = "grpInitiative"
        Me.grpInitiative.Size = New System.Drawing.Size(605, 392)
        Me.grpInitiative.TabIndex = 36
        Me.grpInitiative.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(673, 469)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 37
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmCombatManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 519)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAddM)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstIntOrder)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAddP)
        Me.Controls.Add(Me.txtMonster4)
        Me.Controls.Add(Me.txtMonster3)
        Me.Controls.Add(Me.txtMonster2)
        Me.Controls.Add(Me.txtMonster1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPlayer4)
        Me.Controls.Add(Me.txtPlayer3)
        Me.Controls.Add(Me.txtPlayer2)
        Me.Controls.Add(Me.txtPlayer1)
        Me.Controls.Add(Me.lstResultsDisplay)
        Me.Controls.Add(Me.lblModifier)
        Me.Controls.Add(Me.txtModifier)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblD)
        Me.Controls.Add(Me.txtNumberOfDice)
        Me.Controls.Add(Me.lblNumberOfDice)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.grpDieRoller)
        Me.Controls.Add(Me.grpInitiative)
        Me.Name = "frmCombatManager"
        Me.Text = "Combat Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstResultsDisplay As System.Windows.Forms.ListBox
    Friend WithEvents lblModifier As System.Windows.Forms.Label
    Friend WithEvents txtModifier As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblD As System.Windows.Forms.Label
    Friend WithEvents txtNumberOfDice As System.Windows.Forms.TextBox
    Friend WithEvents lblNumberOfDice As System.Windows.Forms.Label
    Friend WithEvents lblResults As System.Windows.Forms.Label
    Friend WithEvents btnAddM As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstIntOrder As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnAddP As System.Windows.Forms.Button
    Friend WithEvents txtMonster4 As System.Windows.Forms.TextBox
    Friend WithEvents txtMonster3 As System.Windows.Forms.TextBox
    Friend WithEvents txtMonster2 As System.Windows.Forms.TextBox
    Friend WithEvents txtMonster1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPlayer4 As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayer3 As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayer2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayer1 As System.Windows.Forms.TextBox
    Friend WithEvents grpDieRoller As System.Windows.Forms.GroupBox
    Friend WithEvents grpInitiative As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
