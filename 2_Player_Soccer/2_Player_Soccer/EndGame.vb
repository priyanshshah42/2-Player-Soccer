Public Class EndGame

    Private Sub RestartButton_Click(sender As Object, e As EventArgs) Handles RestartButton.Click

        StartScreen.Show()
        Me.Close()

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click

        Me.Close()

    End Sub

    Private Sub EndGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Player1NameLabel.Text = Game_Screen.Player1NameLabel.Text
        Player2NameLabel.Text = Game_Screen.Player2NameLabel.Text
        FinalScoreLabel.Text = Game_Screen.ScoreLabel.Text

    End Sub

End Class