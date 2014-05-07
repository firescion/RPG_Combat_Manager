Public Class frmLoad

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Select Case True
            Case radDiceRoller.Checked
                frmDiceRoller.Show()
                Me.Hide()
            Case radInitiativeTracker.Checked
                frmInitiativeTracker.Show()
                Me.Hide()
            Case radBoth.Checked
                frmCombatManager.Show()
                Me.Hide()
        End Select
    End Sub
End Class
