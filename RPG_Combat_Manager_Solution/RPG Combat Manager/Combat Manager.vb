Public Class frmCombatManager

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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'saves player name and initiative modifier to sequential access file

        Dim outFile As IO.StreamWriter

        'open the text file to modify it
        outFile = IO.File.AppendText("players.txt")

        'Write the player info to the file with a comma separating the name and initiative, new line

        outFile.WriteLine(txtPlayer1.Text & " " & txtPlayer1Initiative.Text & "," & ControlChars.NewLine &
                          txtPlayer2.Text & " " & txtPlayer2Initiative.Text & "," & ControlChars.NewLine &
                          txtPlayer3.Text & " " & txtPlayer3Initiative.Text & "," & ControlChars.NewLine &
                          txtPlayer4.Text & " " & txtPlayer4Initiative.Text)

        'close the file
        outFile.Close()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRollInitiative.Click
        ' Instantiate new character objects
        Dim Player1 As New Character
        Dim Player2 As New Character
        Dim Player3 As New Character
        Dim Player4 As New Character
        Dim Monster1 As New Character
        Dim Monster2 As New Character
        Dim Monster3 As New Character
        Dim Monster4 As New Character

        'assigns values to Character's public properties
        Player1.Name = txtPlayer1.Text
        Player2.Name = txtPlayer2.Text
        Player3.Name = txtPlayer3.Text
        Player4.Name = txtPlayer4.Text
        Monster1.Name = txtMonster1.Text
        Monster2.Name = txtMonster2.Text
        Monster3.Name = txtMonster3.Text
        Monster4.Name = txtMonster4.Text

        Integer.TryParse(txtPlayer1Initiative.Text, Player1.InitiativeMod)
        Integer.TryParse(txtPlayer2Initiative.Text, Player2.InitiativeMod)
        Integer.TryParse(txtPlayer3Initiative.Text, Player3.InitiativeMod)
        Integer.TryParse(txtPlayer4Initiative.Text, Player4.InitiativeMod)
        Integer.TryParse(txtMonster1Initiative.Text, Monster1.InitiativeMod)
        Integer.TryParse(txtMonster2Initiative.Text, Monster2.InitiativeMod)
        Integer.TryParse(txtMonster3Initiative.Text, Monster3.InitiativeMod)
        Integer.TryParse(txtMonster4Initiative.Text, Monster4.InitiativeMod)

        Dim list = New List(Of Character)
        list.Add(Player1)
        list.Add(Player2)
        list.Add(Player3)
        list.Add(Player4)
        list.Add(Monster1)
        list.Add(Monster2)
        list.Add(Monster3)
        list.Add(Monster4)

        For Each character As Character In list
            character.GetInitiative()
        Next

        dgvResults.DataSource = (From l In list
                            Order By l.InitiativeTotal Descending
                            Select l).ToList()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmLoad.Close()
    End Sub
End Class


