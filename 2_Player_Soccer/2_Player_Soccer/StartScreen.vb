Public Class StartScreen

    Private Sub StartGameButton_Click(sender As Object, e As EventArgs) Handles StartGameButton.Click

        Game_Screen.Show()
        Me.Close()

    End Sub

    Private Sub CloseGameButton_Click(sender As Object, e As EventArgs) Handles CloseGameButton.Click

        Me.Close()

    End Sub

    Private Sub Player1RadioButton_Click(sender As Object, e As EventArgs) Handles Player1RadioButton.Click
        PictureBox1.Image = My.Resources.player1controls
    End Sub

    Private Sub Player2RadioButton_Click(sender As Object, e As EventArgs) Handles Player2RadioButton.Click
        PictureBox1.Image = My.Resources.player2controls
    End Sub

    Private Sub HelpRadioButton_Click(sender As Object, e As EventArgs) Handles HelpRadioButton.Click
        PictureBox1.Image = My.Resources.help
    End Sub

    Private Sub StartScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HelpRadioButton_Click(sender, e)
    End Sub

End Class