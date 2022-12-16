'12/13/2022
' This program will display 2 plahyer names and then when you hit "Game action" it will display 2 players from diffrent team showing an action

Imports System.Reflection.Metadata.Ecma335

Public Class Form1


    'Button 1 block of code will select 1 player from Blue and Red team and display them to the court
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Rnd is a variable for Random
        Dim rand As New Random()

        ' Generate a random number between 1 and 2 which will help to choose a player to send in court
        Dim num As Integer = rand.Next(1, 3)

        ' Use the random number to index into the list of players and once the number have been selected then it will chose a player with that number
        Dim players As New List(Of String) From {"John Smith, #1", "Patty Jones, #21"}
        ' Tells that a player variable = One player which is selected from the 2 in above names
        Dim player As String = players(num - 1)

        ' Output the player's name
        Console.WriteLine(player)
        ' Display the player name on label 10 under "Player Who Are In Court"
        Label10.Text = player

        'Rnd is a variable for Random does the same thing but for the red team this time
        Dim randnum As New Random()

        ' Generate a random number between 1 and 2 which will help to choose a player to send in court
        Dim number As Integer = randnum.Next(1, 3)

        ' Use the random number to index into the list of players and once the number have been selected then it will chose a player with that number
        Dim playersinredteam As New List(Of String) From {"Sheila Cook, #5", "Brian Ning, #14"}
        ' Tells that a player variable = One player which is selected from the 2 in above names
        Dim playerred As String = playersinredteam(num - 1)

        ' Output the player's name
        Console.WriteLine(playerred)
        ' Display the player name on label 11 under "Player Who Are In Court"
        Label11.Text = playerred


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'End the program
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Call Button1_Click(Label11.Text, Label10.Text)

        Dim ranaction As New Random()

        ' Generate a random number between 1 and 3
        Dim number As Integer = ranaction.Next(1, 4)

        ' Use the random number to index into an action it will have a nimber from 1 to 3 assign to every action listed below and select one out of 3
        Dim actionproformed As New List(Of String) From {"dribble", "pass", "shoot"}
        'tells that actionproformed is a variable and will select one action from 3 listed above and assign it with the variable "action"
        Dim action As String = actionproformed(number - 1)

        ' Output the players action
        Console.WriteLine(action)
        ' Display the action what is happning with 2 players and with string and spaces to put all that into a sentence
        Label14.Text = (Label10.Text & Space(1) & "and" & Space(1) & Label11.Text & Space(1) & action & Space(1) & "the ball.")

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub
End Class
