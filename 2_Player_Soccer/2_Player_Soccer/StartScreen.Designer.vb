<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartScreen
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
        Me.StartGameButton = New System.Windows.Forms.Button()
        Me.Player1RadioButton = New System.Windows.Forms.RadioButton()
        Me.Player2RadioButton = New System.Windows.Forms.RadioButton()
        Me.CloseGameButton = New System.Windows.Forms.Button()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.HelpRadioButton = New System.Windows.Forms.RadioButton()
        Me.Player1NameTextBox = New System.Windows.Forms.TextBox()
        Me.Player2NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartGameButton
        '
        Me.StartGameButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartGameButton.Location = New System.Drawing.Point(359, 119)
        Me.StartGameButton.Name = "StartGameButton"
        Me.StartGameButton.Size = New System.Drawing.Size(170, 44)
        Me.StartGameButton.TabIndex = 0
        Me.StartGameButton.Text = "Start Game"
        Me.StartGameButton.UseVisualStyleBackColor = True
        '
        'Player1RadioButton
        '
        Me.Player1RadioButton.AutoSize = True
        Me.Player1RadioButton.Location = New System.Drawing.Point(724, 95)
        Me.Player1RadioButton.Name = "Player1RadioButton"
        Me.Player1RadioButton.Size = New System.Drawing.Size(104, 17)
        Me.Player1RadioButton.TabIndex = 1
        Me.Player1RadioButton.TabStop = True
        Me.Player1RadioButton.Text = "Player 1 Controls"
        Me.Player1RadioButton.UseVisualStyleBackColor = True
        '
        'Player2RadioButton
        '
        Me.Player2RadioButton.AutoSize = True
        Me.Player2RadioButton.Location = New System.Drawing.Point(724, 119)
        Me.Player2RadioButton.Name = "Player2RadioButton"
        Me.Player2RadioButton.Size = New System.Drawing.Size(104, 17)
        Me.Player2RadioButton.TabIndex = 2
        Me.Player2RadioButton.TabStop = True
        Me.Player2RadioButton.Text = "Player 2 Controls"
        Me.Player2RadioButton.UseVisualStyleBackColor = True
        '
        'CloseGameButton
        '
        Me.CloseGameButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseGameButton.Location = New System.Drawing.Point(359, 260)
        Me.CloseGameButton.Name = "CloseGameButton"
        Me.CloseGameButton.Size = New System.Drawing.Size(170, 44)
        Me.CloseGameButton.TabIndex = 3
        Me.CloseGameButton.Text = "Exit"
        Me.CloseGameButton.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Myriad Pro Light", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(186, 9)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(522, 78)
        Me.NameLabel.TabIndex = 5
        Me.NameLabel.Text = "2 PLAYER SOCCER"
        '
        'HelpRadioButton
        '
        Me.HelpRadioButton.AutoSize = True
        Me.HelpRadioButton.Checked = True
        Me.HelpRadioButton.Location = New System.Drawing.Point(724, 72)
        Me.HelpRadioButton.Name = "HelpRadioButton"
        Me.HelpRadioButton.Size = New System.Drawing.Size(80, 17)
        Me.HelpRadioButton.TabIndex = 6
        Me.HelpRadioButton.TabStop = True
        Me.HelpRadioButton.Text = "Help/About"
        Me.HelpRadioButton.UseVisualStyleBackColor = True
        '
        'Player1NameTextBox
        '
        Me.Player1NameTextBox.Location = New System.Drawing.Point(48, 176)
        Me.Player1NameTextBox.Name = "Player1NameTextBox"
        Me.Player1NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Player1NameTextBox.TabIndex = 7
        Me.Player1NameTextBox.Text = "Player 1"
        '
        'Player2NameTextBox
        '
        Me.Player2NameTextBox.Location = New System.Drawing.Point(48, 247)
        Me.Player2NameTextBox.Name = "Player2NameTextBox"
        Me.Player2NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Player2NameTextBox.TabIndex = 8
        Me.Player2NameTextBox.Text = "Player 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Enter Player 1's Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Enter Player 2's Name:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(597, 152)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(294, 201)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'StartScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 365)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Player2NameTextBox)
        Me.Controls.Add(Me.Player1NameTextBox)
        Me.Controls.Add(Me.HelpRadioButton)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CloseGameButton)
        Me.Controls.Add(Me.Player2RadioButton)
        Me.Controls.Add(Me.Player1RadioButton)
        Me.Controls.Add(Me.StartGameButton)
        Me.Name = "StartScreen"
        Me.Text = "Start Screen"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartGameButton As Button
    Friend WithEvents Player1RadioButton As RadioButton
    Friend WithEvents Player2RadioButton As RadioButton
    Friend WithEvents CloseGameButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents HelpRadioButton As RadioButton
    Friend WithEvents Player1NameTextBox As TextBox
    Friend WithEvents Player2NameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
