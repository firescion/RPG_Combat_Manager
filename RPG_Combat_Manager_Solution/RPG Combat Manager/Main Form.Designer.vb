<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoad
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
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.lblRun = New System.Windows.Forms.Label()
        Me.radDiceRoller = New System.Windows.Forms.RadioButton()
        Me.radInitiativeTracker = New System.Windows.Forms.RadioButton()
        Me.radBoth = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(54, 114)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'lblRun
        '
        Me.lblRun.AutoSize = True
        Me.lblRun.Location = New System.Drawing.Point(51, 13)
        Me.lblRun.Name = "lblRun"
        Me.lblRun.Size = New System.Drawing.Size(105, 13)
        Me.lblRun.TabIndex = 1
        Me.lblRun.Text = "Run which program?"
        '
        'radDiceRoller
        '
        Me.radDiceRoller.AutoSize = True
        Me.radDiceRoller.Location = New System.Drawing.Point(54, 43)
        Me.radDiceRoller.Name = "radDiceRoller"
        Me.radDiceRoller.Size = New System.Drawing.Size(77, 17)
        Me.radDiceRoller.TabIndex = 2
        Me.radDiceRoller.TabStop = True
        Me.radDiceRoller.Text = "Dice Roller"
        Me.radDiceRoller.UseVisualStyleBackColor = True
        '
        'radInitiativeTracker
        '
        Me.radInitiativeTracker.AutoSize = True
        Me.radInitiativeTracker.Location = New System.Drawing.Point(54, 67)
        Me.radInitiativeTracker.Name = "radInitiativeTracker"
        Me.radInitiativeTracker.Size = New System.Drawing.Size(104, 17)
        Me.radInitiativeTracker.TabIndex = 3
        Me.radInitiativeTracker.TabStop = True
        Me.radInitiativeTracker.Text = "Initiative Tracker"
        Me.radInitiativeTracker.UseVisualStyleBackColor = True
        '
        'radBoth
        '
        Me.radBoth.AutoSize = True
        Me.radBoth.Location = New System.Drawing.Point(54, 91)
        Me.radBoth.Name = "radBoth"
        Me.radBoth.Size = New System.Drawing.Size(47, 17)
        Me.radBoth.TabIndex = 4
        Me.radBoth.TabStop = True
        Me.radBoth.Text = "Both"
        Me.radBoth.UseVisualStyleBackColor = True
        '
        'frmLoad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(222, 149)
        Me.Controls.Add(Me.radBoth)
        Me.Controls.Add(Me.radInitiativeTracker)
        Me.Controls.Add(Me.radDiceRoller)
        Me.Controls.Add(Me.lblRun)
        Me.Controls.Add(Me.btnLoad)
        Me.Name = "frmLoad"
        Me.Text = "Combat Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents lblRun As System.Windows.Forms.Label
    Friend WithEvents radDiceRoller As System.Windows.Forms.RadioButton
    Friend WithEvents radInitiativeTracker As System.Windows.Forms.RadioButton
    Friend WithEvents radBoth As System.Windows.Forms.RadioButton

End Class
