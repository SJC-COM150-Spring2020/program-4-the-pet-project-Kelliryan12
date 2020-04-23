Public Class ThePetPoject1

    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click

        'Declare variables 
        Dim vote As String
        Dim D, C, F, B As Integer

        'Display input box for user to vote and add up all the votes 
        Do
            vote = InputBox("Cast Your Vote Below By Entering the First Initial of Animal's Name Using a Capital Letter: (Example: For Dog Enter 'D')" & "                         
*ENTER 'E' TO EXIT/RETURN TO MAIN SCREEN")
            If (vote = "D") Then
                D = D + 1
            ElseIf (vote = "C") Then
                C = C + 1
            ElseIf (vote = "F") Then
                F = F + 1
            ElseIf (vote = "B") Then
                B = B + 1
            ElseIf (vote = "E") Then
                MessageBox.Show("Thank You For Voting! Calculating Results...")
            End If
        Loop Until (vote = "E")

        'Output all votes to list box
        lstOut.Items.Add("Dog Votes: " & D)
        lstOut.Items.Add("Cat Votes: " & C)
        lstOut.Items.Add("Fish Votes: " & F)
        lstOut.Items.Add("Bird Votes: " & B)

        'Calculate results and display winner's picture 

        If (D > C And D > F And D > B) Then
            lstOut.Items.Add("The Winner is...Dog!")
        ElseIf (C > D And C > F And C > B) Then
            lstOut.Items.Add("The Winner is...Cat!")
            picCat2.Visible = True
        ElseIf (F > D And F > C And F > B) Then
            lstOut.Items.Add("The Winner is...Fish!")
            picFish2.Visible = True
        ElseIf (B > D And B > C And B > F) Then
            lstOut.Items.Add("The Winner is...Bird!")
            picBird2.Visible = True
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'When user clicks, clear the list box and the winner's pictures
        lstOut.Items.Clear()
        picDog2.Visible = False
        picCat2.Visible = False
        picFish2.Visible = False
        picBird2.Visible = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exit the progam 
        Application.Exit()
    End Sub
End Class
