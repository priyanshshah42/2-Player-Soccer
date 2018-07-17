<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Game_Screen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Ball = New System.Windows.Forms.PictureBox()
        Me.Player2 = New System.Windows.Forms.PictureBox()
        Me.Player2Foot = New System.Windows.Forms.PictureBox()
        Me.Player1 = New System.Windows.Forms.PictureBox()
        Me.Player1Foot = New System.Windows.Forms.PictureBox()
        Me.Ground = New System.Windows.Forms.PictureBox()
        Me.RefreshTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Player1Net = New System.Windows.Forms.PictureBox()
        Me.Player2Net = New System.Windows.Forms.PictureBox()
        Me.Player1Goal = New System.Windows.Forms.PictureBox()
        Me.Player2Goal = New System.Windows.Forms.PictureBox()
        Me.Player1NameLabel = New System.Windows.Forms.Label()
        Me.Player2NameLabel = New System.Windows.Forms.Label()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        CType(Me.Ball, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2Foot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1Foot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1Net, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2Net, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1Goal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2Goal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ball
        '
        Me.Ball.BackColor = System.Drawing.Color.Transparent
        Me.Ball.BackgroundImage = Global._2_Player_Soccer.My.Resources.Resources.footbal_1282
        Me.Ball.Location = New System.Drawing.Point(553, 379)
        Me.Ball.Name = "Ball"
        Me.Ball.Size = New System.Drawing.Size(50, 50)
        Me.Ball.TabIndex = 0
        Me.Ball.TabStop = False
        Me.Ball.Visible = False
        '
        'Player2
        '
        Me.Player2.BackColor = System.Drawing.Color.Transparent
        Me.Player2.BackgroundImage = Global._2_Player_Soccer.My.Resources.Resources.Player2Head
        Me.Player2.Location = New System.Drawing.Point(807, 595)
        Me.Player2.Name = "Player2"
        Me.Player2.Size = New System.Drawing.Size(37, 39)
        Me.Player2.TabIndex = 2
        Me.Player2.TabStop = False
        Me.Player2.Visible = False
        '
        'Player2Foot
        '
        Me.Player2Foot.BackColor = System.Drawing.Color.Transparent
        Me.Player2Foot.BackgroundImage = Global._2_Player_Soccer.My.Resources.Resources.Player2Foot
        Me.Player2Foot.Location = New System.Drawing.Point(824, 632)
        Me.Player2Foot.Name = "Player2Foot"
        Me.Player2Foot.Size = New System.Drawing.Size(20, 18)
        Me.Player2Foot.TabIndex = 4
        Me.Player2Foot.TabStop = False
        Me.Player2Foot.Visible = False
        '
        'Player1
        '
        Me.Player1.BackColor = System.Drawing.Color.Transparent
        Me.Player1.Image = Global._2_Player_Soccer.My.Resources.Resources.Player1Head1
        Me.Player1.Location = New System.Drawing.Point(299, 595)
        Me.Player1.Name = "Player1"
        Me.Player1.Size = New System.Drawing.Size(38, 41)
        Me.Player1.TabIndex = 5
        Me.Player1.TabStop = False
        Me.Player1.Visible = False
        '
        'Player1Foot
        '
        Me.Player1Foot.BackColor = System.Drawing.Color.Transparent
        Me.Player1Foot.Image = Global._2_Player_Soccer.My.Resources.Resources.Player1Foot
        Me.Player1Foot.Location = New System.Drawing.Point(299, 632)
        Me.Player1Foot.Name = "Player1Foot"
        Me.Player1Foot.Size = New System.Drawing.Size(20, 18)
        Me.Player1Foot.TabIndex = 6
        Me.Player1Foot.TabStop = False
        Me.Player1Foot.Visible = False
        '
        'Ground
        '
        Me.Ground.Location = New System.Drawing.Point(0, 651)
        Me.Ground.Name = "Ground"
        Me.Ground.Size = New System.Drawing.Size(1076, 10)
        Me.Ground.TabIndex = 7
        Me.Ground.TabStop = False
        Me.Ground.Visible = False
        '
        'RefreshTimer
        '
        Me.RefreshTimer.Interval = 50
        '
        'GameTimer
        '
        Me.GameTimer.Interval = 1000
        '
        'Player1Net
        '
        Me.Player1Net.BackColor = System.Drawing.Color.Transparent
        Me.Player1Net.BackgroundImage = Global._2_Player_Soccer.My.Resources.Resources.left_goalpost1
        Me.Player1Net.Location = New System.Drawing.Point(-136, 412)
        Me.Player1Net.Name = "Player1Net"
        Me.Player1Net.Size = New System.Drawing.Size(247, 246)
        Me.Player1Net.TabIndex = 8
        Me.Player1Net.TabStop = False
        '
        'Player2Net
        '
        Me.Player2Net.BackColor = System.Drawing.Color.Transparent
        Me.Player2Net.BackgroundImage = Global._2_Player_Soccer.My.Resources.Resources.slide_8003482_2_198228sektion1
        Me.Player2Net.Location = New System.Drawing.Point(967, 412)
        Me.Player2Net.Name = "Player2Net"
        Me.Player2Net.Size = New System.Drawing.Size(210, 247)
        Me.Player2Net.TabIndex = 9
        Me.Player2Net.TabStop = False
        '
        'Player1Goal
        '
        Me.Player1Goal.Location = New System.Drawing.Point(0, 418)
        Me.Player1Goal.Name = "Player1Goal"
        Me.Player1Goal.Size = New System.Drawing.Size(61, 240)
        Me.Player1Goal.TabIndex = 10
        Me.Player1Goal.TabStop = False
        Me.Player1Goal.Visible = False
        '
        'Player2Goal
        '
        Me.Player2Goal.Location = New System.Drawing.Point(1015, 417)
        Me.Player2Goal.Name = "Player2Goal"
        Me.Player2Goal.Size = New System.Drawing.Size(61, 240)
        Me.Player2Goal.TabIndex = 11
        Me.Player2Goal.TabStop = False
        Me.Player2Goal.Visible = False
        '
        'Player1NameLabel
        '
        Me.Player1NameLabel.BackColor = System.Drawing.Color.White
        Me.Player1NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player1NameLabel.Location = New System.Drawing.Point(373, 24)
        Me.Player1NameLabel.Name = "Player1NameLabel"
        Me.Player1NameLabel.Size = New System.Drawing.Size(132, 24)
        Me.Player1NameLabel.TabIndex = 12
        Me.Player1NameLabel.Text = "Player 1"
        Me.Player1NameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Player2NameLabel
        '
        Me.Player2NameLabel.BackColor = System.Drawing.Color.White
        Me.Player2NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player2NameLabel.Location = New System.Drawing.Point(637, 24)
        Me.Player2NameLabel.Name = "Player2NameLabel"
        Me.Player2NameLabel.Size = New System.Drawing.Size(133, 24)
        Me.Player2NameLabel.TabIndex = 13
        Me.Player2NameLabel.Text = "Player 2"
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.BackColor = System.Drawing.Color.White
        Me.ScoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreLabel.Location = New System.Drawing.Point(511, 9)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(120, 55)
        Me.ScoreLabel.TabIndex = 14
        Me.ScoreLabel.Text = "0 - 0"
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.BackColor = System.Drawing.Color.White
        Me.TimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.Location = New System.Drawing.Point(552, 73)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(36, 26)
        Me.TimeLabel.TabIndex = 15
        Me.TimeLabel.Text = "60"
        '
        'Game_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._2_Player_Soccer.My.Resources.Resources.stadium
        Me.ClientSize = New System.Drawing.Size(1077, 661)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.Player2NameLabel)
        Me.Controls.Add(Me.Player1NameLabel)
        Me.Controls.Add(Me.Player2Goal)
        Me.Controls.Add(Me.Player1Goal)
        Me.Controls.Add(Me.Player2Net)
        Me.Controls.Add(Me.Player1Net)
        Me.Controls.Add(Me.Ground)
        Me.Controls.Add(Me.Player1Foot)
        Me.Controls.Add(Me.Player1)
        Me.Controls.Add(Me.Player2Foot)
        Me.Controls.Add(Me.Player2)
        Me.Controls.Add(Me.Ball)
        Me.MaximizeBox = False
        Me.Name = "Game_Screen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "2 Player Soccer"
        CType(Me.Ball, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2Foot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1Foot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1Net, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2Net, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1Goal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2Goal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Ball As PictureBox
    Friend WithEvents Player2 As PictureBox
    Friend WithEvents Player2Foot As PictureBox
    Friend WithEvents Player1 As PictureBox
    Friend WithEvents Player1Foot As PictureBox
    Friend WithEvents Ground As PictureBox
    Friend WithEvents RefreshTimer As Timer
    Friend WithEvents GameTimer As Timer
    Friend WithEvents Player1Net As PictureBox
    Friend WithEvents Player2Net As PictureBox
    Friend WithEvents Player1Goal As PictureBox
    Friend WithEvents Player2Goal As PictureBox
    Friend WithEvents Player1NameLabel As Label
    Friend WithEvents Player2NameLabel As Label
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents TimeLabel As Label
End Class
