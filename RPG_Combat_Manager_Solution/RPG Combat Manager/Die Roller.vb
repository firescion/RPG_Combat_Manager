Public Class frmDiceRoller

    Private Sub frmDieRoller_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Fills the combo boxes with values
        cboDieSize.Items.Add("20")
        cboDieSize.Items.Add("12")
        cboDieSize.Items.Add("10")
        cboDieSize.Items.Add("8")
        cboDieSize.Items.Add("6")
        cboDieSize.Items.Add("4")
        cboDieSize.Items.Add("2")
        cboDieSize.Items.Add("100")
        cboDieSize.SelectedIndex = 0

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmLoad.Close()
    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        Dim randDieRoll As New Random
        Dim intDieSize As Integer
        Dim intDieResult As Integer
        Dim intDieTotal As Integer = 0
        Dim intDieModifier As Integer
        Dim intNumberOfDice As Integer
        Dim intCounter As Integer = 0


        'Determine die size from user input
        intDieSize = Convert.ToInt64(cboDieSize.Text)

        'Error test user input for number of dice and one time modifiers
        Integer.TryParse(txtModifier.Text, intDieModifier)
        Integer.TryParse(txtNumberOfDice.Text, intNumberOfDice)

        'Calculate and display die roll results

        Do
            intDieResult = randDieRoll.Next(1, intDieSize + 1)
            intDieTotal = intDieTotal + intDieResult
            intCounter = intCounter + 1
        Loop While intCounter <= intNumberOfDice - 1

        'Add one time modifiers after die roll has been calculated
        intDieTotal = intDieTotal + intDieModifier

        'Display results in list box
        lstResultsDisplay.Items.Add(txtNumberOfDice.Text & "D" & cboDieSize.Text & "+" & txtModifier.Text & "=" & intDieTotal.ToString)


    End Sub

    Private Sub btnClearResults_Click(sender As Object, e As EventArgs) Handles btnClearResults.Click
        'clear results list box
        lstResultsDisplay.Items.Clear()
    End Sub
End Class