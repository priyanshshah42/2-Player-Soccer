Public Class Game_Screen

    Const MovementIncrement As Byte = 15

    Dim player1Score As Integer = 0, player2Score As Integer = 0

    Private Shared ReadOnly Control() As Keys = {Keys.Right, Keys.Left, Keys.Up, Keys.W, Keys.A, Keys.D}

    Dim BallBitmap As New Bitmap(My.Resources.footbal_1282)
    Dim Player1Bitmap As New Bitmap(My.Resources.Player1Head1)
    Dim Player1FootBitmap As New Bitmap(My.Resources.Player1Foot)
    Dim Player2Bitmap As New Bitmap(My.Resources.Player2Head)
    Dim Player2FootBitmap As New Bitmap(My.Resources.Player2Foot)

    Dim BallLocation As Point
    Dim player1Location As Point, player2Location As Point
    Dim player1FootLocation As Point, player2FootLocation As Point

    Dim player1Dropping As Boolean, player2Dropping As Boolean
    Dim player1Jumping As Boolean, player2Jumping As Boolean
    Dim player1MovingLeft As Boolean, player1MovingRight As Boolean
    Dim player2MovingLeft As Boolean, player2MovingRight As Boolean

    Protected Overrides Function IsInputKey(ByVal keyData As Keys) As Boolean

        If Control.Contains(keyData) Then
            Return True
        Else
            Return MyBase.IsInputKey(keyData)
        End If

    End Function

    Private Sub UpdateScore(player1Goals As Integer, player2Goals As Integer)

        ScoreLabel.Text = player1Goals & " - " & player2Goals
        BallLocation = New Point(553, 385)
        Ball.Location = BallLocation
        player1Location = New Point(299, 595)
        Player1.Location = player1Location
        player2Location = New Point(807, 595)
        Player2.Location = player2Location
        player1FootLocation = New Point(299, 632)
        Player1Foot.Location = player1FootLocation
        player2FootLocation = New Point(824, 632)
        Player2Foot.Location = player2FootLocation
        player1Dropping = False
        player2Dropping = False
        player1Jumping = False
        player2Jumping = False
        player1MovingLeft = False
        player1MovingRight = False
        player2MovingLeft = False
        player2MovingRight = False

    End Sub

    Private Sub ProcessFrame()

        'TRAP CASES TO PREVENT ERRORS
        If player1MovingRight AndAlso player1MovingLeft Then
            Throw New InvalidOperationException("Code should not let the player move both left and right at the same time.")
        End If

        If player2MovingRight AndAlso player2MovingLeft Then
            Throw New InvalidOperationException("Code should not let the player move both left and right at the same time.")
        End If

        'DEALS WITH BALL COLLISIONS
        If Player1.Bounds.IntersectsWith(Ball.Bounds) Then
            If player1Location.X >= BallLocation.X - Player1.Width And player1Location.Y = BallLocation.Y Then
                BallLocation.X += MovementIncrement
                Ball.Location = BallLocation
            ElseIf player1Location.X >= BallLocation.X - Player1.Width And player1Location.Y < BallLocation.Y Then
                BallLocation.X += MovementIncrement
                BallLocation.Y -= MovementIncrement
                Ball.Location = BallLocation
            ElseIf player1Location.X >= BallLocation.X - Player1.Width And player1Location.Y > BallLocation.Y Then
                BallLocation.X += MovementIncrement
                BallLocation.Y += MovementIncrement
                Ball.Location = BallLocation
            End If
        End If

        If Player2.Bounds.IntersectsWith(Ball.Bounds) Then
            If player2Location.X <= BallLocation.X + Player2.Width And player2Location.Y = BallLocation.Y Then
                BallLocation.X -= MovementIncrement
                Ball.Location = BallLocation
            ElseIf player2Location.X <= BallLocation.X + Player2.Width And player2Location.Y < BallLocation.Y Then
                BallLocation.X -= MovementIncrement
                BallLocation.Y -= MovementIncrement
                Ball.Location = BallLocation
            ElseIf player2Location.X <= BallLocation.X + Player2.Width And player2Location.Y > BallLocation.Y Then
                BallLocation.X -= MovementIncrement
                BallLocation.Y += MovementIncrement
                Ball.Location = BallLocation
            End If
        End If

        'DEALS WITH GRAVITY
        If player1FootLocation.Y >= Ground.Top - Player1Foot.Height Then
            player1Dropping = False
        End If

        If player1Dropping = True Then
            player1Location.Y += MovementIncrement
            player1FootLocation.Y += MovementIncrement
            Player1.Location = player1Location
            Player1Foot.Location = player1FootLocation
        End If

        If player2FootLocation.Y >= Ground.Top - Player2Foot.Height Then
            player2Dropping = False
        End If

        If player2Dropping = True Then
            player2Location.Y += MovementIncrement
            player2FootLocation.Y += MovementIncrement
            Player2.Location = player2Location
            Player2Foot.Location = player2FootLocation
        End If

        'UPDATES PLAYER MOVEMENT
        If player1MovingLeft = True Then
            player1Location.X -= MovementIncrement
            player1FootLocation.X -= MovementIncrement
            Player1.Location = player1Location
            Player1Foot.Location = player1FootLocation
        End If

        If player1MovingRight = True Then
            player1Location.X += MovementIncrement
            player1FootLocation.X += MovementIncrement
            Player1.Location = player1Location
            Player1Foot.Location = player1FootLocation
        End If

        If player1Jumping = True Then
            player1Location.Y -= 3 * MovementIncrement
            player1FootLocation.Y -= 3 * MovementIncrement
            Player1.Location = player1Location
            Player1Foot.Location = player1FootLocation
        End If

        If player2MovingLeft = True Then
            player2Location.X -= MovementIncrement
            player2FootLocation.X -= MovementIncrement
            Player2.Location = player2Location
            Player2Foot.Location = player2FootLocation
        End If

        If player2MovingRight = True Then
            player2Location.X += MovementIncrement
            player2FootLocation.X += MovementIncrement
            Player2.Location = player2Location
            Player2Foot.Location = player2FootLocation
        End If

        If player2Jumping = True Then
            player2Location.Y -= 3 * MovementIncrement
            player2FootLocation.Y -= 3 * MovementIncrement
            Player2.Location = player2Location
            Player2Foot.Location = player2FootLocation
        End If

        'IF A PLAYER HAS SCORED
        If Ball.Bounds.IntersectsWith(Player1Goal.Bounds) Then
            player2Score += 1
            UpdateScore(player1Score, player2Score)
        End If

        If Ball.Bounds.IntersectsWith(Player2Goal.Bounds) Then
            player1Score += 1
            UpdateScore(player1Score, player2Score)
        End If

    End Sub

    'UPDATES THE TIME LEFT IN THE GAME AND ENDS THE GAME
    Private Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick

        If Val(TimeLabel.Text) > 0 Then
            TimeLabel.Text -= 1
        Else
            RefreshTimer.Enabled = False
            GameTimer.Enabled = False
            EndGame.Show()
            Me.Close()
        End If

    End Sub

    'RESPONSES TO KEY PRESSES
    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)

        MyBase.OnKeyDown(e)

        'FOR MOVING LEFT AND RIGHT FOR PLAYER 1
        If e.KeyCode = Keys.A Then
            player1MovingRight = False
            player1MovingLeft = True
        ElseIf e.KeyCode = Keys.D Then
            player1MovingLeft = False
            player1MovingRight = True
        End If

        'FOR JUMPING FOR PLAYER 1
        If e.KeyCode = Keys.W Then
            player1Jumping = True
        End If

        'FOR MOVING LEFT AND RIGHT FOR PLAYER 2
        If e.KeyCode = Keys.Left Then
            player2MovingRight = False
            player2MovingLeft = True
        ElseIf e.KeyCode = Keys.Right Then
            player2MovingLeft = False
            player2MovingRight = True
        End If

        'FOR JUMPING FOR PLAYER 2
        If e.KeyCode = Keys.Up Then
            player2Jumping = True
        End If

    End Sub

    'RESPONSES TO KEY RELEASES
    Protected Overrides Sub OnKeyUp(ByVal e As System.Windows.Forms.KeyEventArgs)

        MyBase.OnKeyUp(e)

        If e.KeyCode = Keys.A Then
            player1MovingLeft = False
        ElseIf e.KeyCode = Keys.D Then
            player1MovingRight = False
        End If

        If e.KeyCode = Keys.W Then
            player1Jumping = False
            player1Dropping = True
        End If

        If e.KeyCode = Keys.Left Then
            player2MovingLeft = False
        ElseIf e.KeyCode = Keys.Right Then
            player2MovingRight = False
        End If

        If e.KeyCode = Keys.Up Then
            player2Jumping = False
            player2Dropping = True
        End If

    End Sub

    'THIS SUB UPDATES THE SCREEN AT REGULAR INTERVALS
    Private Sub RefreshTimer_Tick(sender As Object, e As EventArgs) Handles RefreshTimer.Tick

        ProcessFrame()
        Invalidate()

    End Sub

    Private Sub Game_Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Player1NameLabel.Text = StartScreen.Player1NameTextBox.Text
        Player2NameLabel.Text = StartScreen.Player2NameTextBox.Text
        BallLocation = New Point(553, 385)
        player1Location = New Point(299, 595)
        player2Location = New Point(807, 595)
        player1FootLocation = New Point(299, 632)
        player2FootLocation = New Point(824, 632)
        player1Dropping = False
        player2Dropping = False
        player1Jumping = False
        player2Jumping = False
        player1MovingLeft = False
        player1MovingRight = False
        player2MovingLeft = False
        player2MovingRight = False
        RefreshTimer.Enabled = True
        GameTimer.Enabled = True

    End Sub

    'THIS SUB UPDATES ALL GRAPHICS ON THE SCREEN
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)

        MyBase.OnPaint(e)

        'DRAWS BALL GRAPHICS
        e.Graphics.DrawImage(BallBitmap, BallLocation)

        'DRAWS PLAYER 1'S GRAPHICS IMAGE
        e.Graphics.DrawImage(Player1Bitmap, player1Location)
        e.Graphics.DrawImage(Player1FootBitmap, player1FootLocation)

        'DRAWS PLAYER 2'S GRAPHICS IMAGE
        e.Graphics.DrawImage(Player2Bitmap, player2Location)
        e.Graphics.DrawImage(Player2FootBitmap, player2FootLocation)

    End Sub

End Class