<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EndGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Player1NameLabel = New System.Windows.Forms.Label()
        Me.FinalScoreLabel = New System.Windows.Forms.Label()
        Me.Player2NameLabel = New System.Windows.Forms.Label()
        Me.RestartButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(302, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Final Score"
        '
        'Player1NameLabel
        '
        Me.Player1NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player1NameLabel.Location = New System.Drawing.Point(169, 119)
        Me.Player1NameLabel.Name = "Player1NameLabel"
        Me.Player1NameLabel.Size = New System.Drawing.Size(192, 31)
        Me.Player1NameLabel.TabIndex = 1
        Me.Player1NameLabel.Text = "Player 1"
        Me.Player1NameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FinalScoreLabel
        '
        Me.FinalScoreLabel.AutoSize = True
        Me.FinalScoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinalScoreLabel.Location = New System.Drawing.Point(367, 110)
        Me.FinalScoreLabel.Name = "FinalScoreLabel"
        Me.FinalScoreLabel.Size = New System.Drawing.Size(120, 55)
        Me.FinalScoreLabel.TabIndex = 2
        Me.FinalScoreLabel.Text = "0 - 0"
        '
        'Player2NameLabel
        '
        Me.Player2NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player2NameLabel.Location = New System.Drawing.Point(493, 119)
        Me.Player2NameLabel.Name = "Player2NameLabel"
        Me.Player2NameLabel.Size = New System.Drawing.Size(192, 31)
        Me.Player2NameLabel.TabIndex = 3
        Me.Player2NameLabel.Text = "Player 2"
        '
        'RestartButton
        '
        Me.RestartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestartButton.Location = New System.Drawing.Point(360, 200)
        Me.RestartButton.Name = "RestartButton"
        Me.RestartButton.Size = New System.Drawing.Size(138, 48)
        Me.RestartButton.TabIndex = 4
        Me.RestartButton.Text = "Restart"
        Me.RestartButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(360, 297)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(138, 48)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'EndGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 386)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.RestartButton)
        Me.Controls.Add(Me.Player2NameLabel)
        Me.Controls.Add(Me.FinalScoreLabel)
        Me.Controls.Add(Me.Player1NameLabel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EndGame"
        Me.Text = "Game Over"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Player1NameLabel As Label
    Friend WithEvents FinalScoreLabel As Label
    Friend WithEvents Player2NameLabel As Label
    Friend WithEvents RestartButton As Button
    Friend WithEvents ExitButton As Button
End Class
