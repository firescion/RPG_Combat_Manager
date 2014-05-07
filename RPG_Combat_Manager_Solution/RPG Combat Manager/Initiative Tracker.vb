Public Class frmInitiativeTracker

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
        frmLoad.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'saves player name and initiative modifier to sequential access file

        Dim outFile As IO.StreamWriter

        'open the text file to modify it
        outFile = IO.File.AppendText("players.txt")

        'Write the player info to the file with a comma separating the name and initiative, new line


        Dim Player1 As New Character
        Dim Player2 As New Character
        Dim Player3 As New Character
        Dim Player4 As New Character

        Player1.Name = txtPlayer1.Text
        Player2.Name = txtPlayer2.Text
        Player3.Name = txtPlayer3.Text
        Player4.Name = txtPlayer4.Text

        Integer.TryParse(txtPlayer1Initiative.Text, Player1.InitiativeMod)
        Integer.TryParse(txtPlayer2Initiative.Text, Player2.InitiativeMod)
        Integer.TryParse(txtPlayer3Initiative.Text, Player3.InitiativeMod)
        Integer.TryParse(txtPlayer4Initiative.Text, Player4.InitiativeMod)

        Dim list = New List(Of Character)
        list.Add(Player1)
        list.Add(Player2)
        list.Add(Player3)
        list.Add(Player4)

        Dim jss As New System.Web.Script.Serialization.JavaScriptSerializer()

        Dim json = jss.Serialize(list)

        outFile.WriteLine(json)

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

    Private Sub btnLoadPlayers_Click(sender As Object, e As EventArgs) Handles btnLoadPlayers.Click

        Dim inFile As IO.StreamReader

        If IO.File.Exists("players.txt") Then
            ' open the file for input
            inFile = IO.File.OpenText("players.txt")

            'read a name
            Dim jss As New System.Web.Script.Serialization.JavaScriptSerializer()
            Dim list = jss.Deserialize(Of List(Of Character))(inFile.ReadLine)
            'close the file
            inFile.Close()

            Dim players = (From l In list
                          Select l).ToArray()


            'add name to text boxes
            Dim playerFields(3) As TextBox
            playerFields(0) = txtPlayer1
            playerFields(1) = txtPlayer2
            playerFields(2) = txtPlayer3
            playerFields(3) = txtPlayer4

            Dim initiativeFields(3) As TextBox
            initiativeFields(0) = txtPlayer1Initiative
            initiativeFields(1) = txtPlayer2Initiative
            initiativeFields(2) = txtPlayer3Initiative
            initiativeFields(3) = txtPlayer4Initiative

            For index = 0 To 3
                playerFields(index).Text = players(index).Name
                initiativeFields(index).Text = players(index).InitiativeMod
            Next

        Else
            MessageBox.Show("Can't find the file", "players.txt",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information)

        End If
    End Sub
End Class