<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArtristForm
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
        Me.ToolbarGroupBox = New System.Windows.Forms.GroupBox()
        Me.Forward = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.DirectoryGroup = New System.Windows.Forms.GroupBox()
        Me.Help = New System.Windows.Forms.Button()
        Me.Login = New System.Windows.Forms.Button()
        Me.Register = New System.Windows.Forms.Button()
        Me.password = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.GenreButton = New System.Windows.Forms.Button()
        Me.ToolbarGroupBox.SuspendLayout()
        Me.DirectoryGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolbarGroupBox
        '
        Me.ToolbarGroupBox.Controls.Add(Me.Forward)
        Me.ToolbarGroupBox.Controls.Add(Me.Back)
        Me.ToolbarGroupBox.Controls.Add(Me.DirectoryGroup)
        Me.ToolbarGroupBox.Location = New System.Drawing.Point(0, 1)
        Me.ToolbarGroupBox.Name = "ToolbarGroupBox"
        Me.ToolbarGroupBox.Size = New System.Drawing.Size(1266, 65)
        Me.ToolbarGroupBox.TabIndex = 1
        Me.ToolbarGroupBox.TabStop = False
        '
        'Forward
        '
        Me.Forward.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Forward.Location = New System.Drawing.Point(87, 12)
        Me.Forward.Name = "Forward"
        Me.Forward.Size = New System.Drawing.Size(75, 47)
        Me.Forward.TabIndex = 2
        Me.Forward.Text = "->"
        Me.Forward.UseVisualStyleBackColor = True
        '
        'Back
        '
        Me.Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(6, 12)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(75, 47)
        Me.Back.TabIndex = 1
        Me.Back.Text = "<-"
        Me.Back.UseVisualStyleBackColor = True
        '
        'DirectoryGroup
        '
        Me.DirectoryGroup.Controls.Add(Me.Help)
        Me.DirectoryGroup.Controls.Add(Me.Login)
        Me.DirectoryGroup.Controls.Add(Me.Register)
        Me.DirectoryGroup.Controls.Add(Me.password)
        Me.DirectoryGroup.Controls.Add(Me.username)
        Me.DirectoryGroup.Controls.Add(Me.GenreButton)
        Me.DirectoryGroup.Location = New System.Drawing.Point(310, 0)
        Me.DirectoryGroup.Name = "DirectoryGroup"
        Me.DirectoryGroup.Size = New System.Drawing.Size(956, 65)
        Me.DirectoryGroup.TabIndex = 3
        Me.DirectoryGroup.TabStop = False
        '
        'Help
        '
        Me.Help.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Help.Location = New System.Drawing.Point(910, 12)
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(40, 47)
        Me.Help.TabIndex = 3
        Me.Help.Text = "?"
        Me.Help.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login.Location = New System.Drawing.Point(720, 21)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(75, 32)
        Me.Login.TabIndex = 3
        Me.Login.Text = "Login"
        Me.Login.UseVisualStyleBackColor = True
        '
        'Register
        '
        Me.Register.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Register.Location = New System.Drawing.Point(801, 21)
        Me.Register.Name = "Register"
        Me.Register.Size = New System.Drawing.Size(91, 32)
        Me.Register.TabIndex = 6
        Me.Register.Text = "Register"
        Me.Register.UseVisualStyleBackColor = True
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(602, 21)
        Me.password.Multiline = True
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(112, 32)
        Me.password.TabIndex = 4
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(484, 21)
        Me.username.Multiline = True
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(112, 32)
        Me.username.TabIndex = 5
        '
        'GenreButton
        '
        Me.GenreButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenreButton.Location = New System.Drawing.Point(0, 12)
        Me.GenreButton.Name = "GenreButton"
        Me.GenreButton.Size = New System.Drawing.Size(465, 47)
        Me.GenreButton.TabIndex = 4
        Me.GenreButton.Text = "Genre"
        Me.GenreButton.UseVisualStyleBackColor = True
        '
        'ArtristForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1263, 546)
        Me.Controls.Add(Me.ToolbarGroupBox)
        Me.Name = "ArtristForm"
        Me.Text = "ArtristForm"
        Me.ToolbarGroupBox.ResumeLayout(False)
        Me.DirectoryGroup.ResumeLayout(False)
        Me.DirectoryGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolbarGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Forward As System.Windows.Forms.Button
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents DirectoryGroup As System.Windows.Forms.GroupBox
    Friend WithEvents Help As System.Windows.Forms.Button
    Friend WithEvents Login As System.Windows.Forms.Button
    Friend WithEvents Register As System.Windows.Forms.Button
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents username As System.Windows.Forms.TextBox
    Friend WithEvents GenreButton As System.Windows.Forms.Button
End Class
