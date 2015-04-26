<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim SearchBox As System.Windows.Forms.TextBox
        Me.ToolbarGroupBox = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Help = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Genre = New System.Windows.Forms.Button()
        Me.DirectoryGroup = New System.Windows.Forms.GroupBox()
        SearchBox = New System.Windows.Forms.TextBox()
        Me.ToolbarGroupBox.SuspendLayout()
        Me.DirectoryGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolbarGroupBox
        '
        Me.ToolbarGroupBox.Controls.Add(Me.Help)
        Me.ToolbarGroupBox.Controls.Add(Me.Button2)
        Me.ToolbarGroupBox.Controls.Add(Me.Button1)
        Me.ToolbarGroupBox.Controls.Add(Me.DirectoryGroup)
        Me.ToolbarGroupBox.Location = New System.Drawing.Point(0, 0)
        Me.ToolbarGroupBox.Name = "ToolbarGroupBox"
        Me.ToolbarGroupBox.Size = New System.Drawing.Size(1266, 65)
        Me.ToolbarGroupBox.TabIndex = 0
        Me.ToolbarGroupBox.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 47)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "<-"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(87, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 47)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "->"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Help
        '
        Me.Help.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Help.Location = New System.Drawing.Point(1220, 12)
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(40, 47)
        Me.Help.TabIndex = 3
        Me.Help.Text = "?"
        Me.Help.UseVisualStyleBackColor = True
        '
        'SearchBox
        '
        SearchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SearchBox.Location = New System.Drawing.Point(963, 71)
        SearchBox.Multiline = True
        SearchBox.Name = "SearchBox"
        SearchBox.Size = New System.Drawing.Size(196, 32)
        SearchBox.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1165, 71)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 32)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "SearchConfirm"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Genre
        '
        Me.Genre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Genre.Location = New System.Drawing.Point(15, 12)
        Me.Genre.Name = "Genre"
        Me.Genre.Size = New System.Drawing.Size(539, 47)
        Me.Genre.TabIndex = 4
        Me.Genre.Text = "Genre"
        Me.Genre.UseVisualStyleBackColor = True
        '
        'DirectoryGroup
        '
        Me.DirectoryGroup.Controls.Add(Me.Genre)
        Me.DirectoryGroup.Location = New System.Drawing.Point(288, 0)
        Me.DirectoryGroup.Name = "DirectoryGroup"
        Me.DirectoryGroup.Size = New System.Drawing.Size(560, 65)
        Me.DirectoryGroup.TabIndex = 3
        Me.DirectoryGroup.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1263, 546)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(SearchBox)
        Me.Controls.Add(Me.ToolbarGroupBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ToolbarGroupBox.ResumeLayout(False)
        Me.DirectoryGroup.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolbarGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Help As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DirectoryGroup As System.Windows.Forms.GroupBox
    Friend WithEvents Genre As System.Windows.Forms.Button

End Class
