<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenreForm
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
        Me.username = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.genrePanel = New System.Windows.Forms.Panel()
        Me.ToolbarGroupBox.SuspendLayout()
        Me.DirectoryGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolbarGroupBox
        '
        Me.ToolbarGroupBox.Controls.Add(Me.Forward)
        Me.ToolbarGroupBox.Controls.Add(Me.Back)
        Me.ToolbarGroupBox.Controls.Add(Me.DirectoryGroup)
        Me.ToolbarGroupBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.ToolbarGroupBox.Location = New System.Drawing.Point(0, 0)
        Me.ToolbarGroupBox.Name = "ToolbarGroupBox"
        Me.ToolbarGroupBox.Size = New System.Drawing.Size(1243, 65)
        Me.ToolbarGroupBox.TabIndex = 0
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
        Me.DirectoryGroup.Controls.Add(Me.username)
        Me.DirectoryGroup.Controls.Add(Me.password)
        Me.DirectoryGroup.Location = New System.Drawing.Point(190, 0)
        Me.DirectoryGroup.Name = "DirectoryGroup"
        Me.DirectoryGroup.Size = New System.Drawing.Size(1053, 65)
        Me.DirectoryGroup.TabIndex = 3
        Me.DirectoryGroup.TabStop = False
        '
        'Help
        '
        Me.Help.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Help.Location = New System.Drawing.Point(1007, 12)
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(40, 47)
        Me.Help.TabIndex = 3
        Me.Help.Text = "?"
        Me.Help.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login.Location = New System.Drawing.Point(829, 20)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(75, 32)
        Me.Login.TabIndex = 3
        Me.Login.Text = "Login"
        Me.Login.UseVisualStyleBackColor = True
        '
        'Register
        '
        Me.Register.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Register.Location = New System.Drawing.Point(910, 20)
        Me.Register.Name = "Register"
        Me.Register.Size = New System.Drawing.Size(91, 32)
        Me.Register.TabIndex = 6
        Me.Register.Text = "Register"
        Me.Register.UseVisualStyleBackColor = True
        '
        'username
        '
        Me.username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.Location = New System.Drawing.Point(584, 20)
        Me.username.Multiline = True
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(112, 32)
        Me.username.TabIndex = 5
        '
        'password
        '
        Me.password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(702, 20)
        Me.password.Multiline = True
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.Size = New System.Drawing.Size(112, 32)
        Me.password.TabIndex = 4
        '
        'genrePanel
        '
        Me.genrePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.genrePanel.Location = New System.Drawing.Point(0, 65)
        Me.genrePanel.Name = "genrePanel"
        Me.genrePanel.Size = New System.Drawing.Size(1243, 677)
        Me.genrePanel.TabIndex = 1
        '
        'GenreForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 742)
        Me.Controls.Add(Me.genrePanel)
        Me.Controls.Add(Me.ToolbarGroupBox)
        Me.Name = "GenreForm"
        Me.Text = "9"
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
    Friend WithEvents genrePanel As System.Windows.Forms.Panel

End Class
