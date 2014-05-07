﻿Public Class frmInitiativeTracker

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
        frmLoad.Close()
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
        Dim intInitiativeRoll(7) As Integer

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
End Class