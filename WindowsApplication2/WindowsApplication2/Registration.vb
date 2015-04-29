Public Class Registration

    'The font used throughout the program
    Dim newFont As New Font("Microsoft Sans Serif", 16)

    'These lines declare the Labels I use for this form
    Dim emailLabel As New Label
    Dim emailVerifyLabel As New Label
    Dim passwordLabel As New Label
    Dim passwordVerifyLabel As New Label
    Dim dobLabel As New Label

    'These lines declare the TextBoxes I use for this form
    Public emailTextBox As New TextBox
    Public emailVerifyTextBox As New TextBox
    Public passwordTextBox As New TextBox
    Public passwordVerifyTextBox As New TextBox
    Public monthTextBox As New TextBox
    Public dayTextBox As New TextBox
    Public yearTextBox As New TextBox

    'This declares the Registration Button
    Dim RegisterButton As New Button

    'Gets called when the form loads
    Private Sub Registration_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        setUpLabels()
        setUpTextBoxes()
        setUpRegisterButton()
    End Sub

    'Puts the labels on the form
    Private Sub setUpLabels()
        With emailLabel
            .Location = New System.Drawing.Point(155, 20)
            .Text = "Email"
            .Font = newFont
            .Size = New System.Drawing.Size(80, 50)
        End With

        With emailVerifyLabel
            .Location = New System.Drawing.Point(79, 80)
            .Text = "Verify Email"
            .Font = newFont
            .Size = New System.Drawing.Size(180, 50)
        End With

        With passwordLabel
            .Location = New System.Drawing.Point(100, 140)
            .Text = "Password"
            .Font = newFont
            .Size = New System.Drawing.Size(150, 50)
        End With

        With passwordVerifyLabel
            .Location = New System.Drawing.Point(20, 200)
            .Text = "Verify Password"
            .Font = newFont
            .Size = New System.Drawing.Size(250, 50)
        End With

        With dobLabel
            .Location = New System.Drawing.Point(70, 260)
            .Text = "Date of Birth"
            .Font = newFont
            .Size = New System.Drawing.Size(200, 40)
        End With

        Me.MainPanel.Controls.Add(emailLabel)
        Me.MainPanel.Controls.Add(emailVerifyLabel)
        Me.MainPanel.Controls.Add(passwordLabel)
        Me.MainPanel.Controls.Add(passwordVerifyLabel)
        Me.MainPanel.Controls.Add(dobLabel)
    End Sub

    'Places the text boxes on the form
    Private Sub setUpTextBoxes()
        With emailTextBox
            .Location = New System.Drawing.Point(275, 20)
            .Font = newFont
            .Size = New System.Drawing.Size(250, 100)
        End With

        With emailVerifyTextBox
            .Location = New System.Drawing.Point(275, 80)
            .Font = newFont
            .Size = New System.Drawing.Size(250, 100)
        End With

        With passwordTextBox
            .Location = New System.Drawing.Point(275, 140)
            .Font = newFont
            .Size = New System.Drawing.Size(250, 100)
            .PasswordChar = "*"
        End With

        With passwordVerifyTextBox
            .Location = New System.Drawing.Point(275, 200)
            .Font = newFont
            .Size = New System.Drawing.Size(250, 100)
            .PasswordChar = "*"
        End With

        With monthTextBox
            .Location = New System.Drawing.Point(275, 260)
            .Font = newFont
            .Size = New System.Drawing.Size(75, 100)
        End With

        With dayTextBox
            .Location = New System.Drawing.Point(355, 260)
            .Font = newFont
            .Size = New System.Drawing.Size(75, 100)
        End With

        With yearTextBox
            .Location = New System.Drawing.Point(435, 260)
            .Font = newFont
            .Size = New System.Drawing.Size(90, 100)
        End With

        Me.MainPanel.Controls.Add(emailTextBox)
        Me.MainPanel.Controls.Add(emailVerifyTextBox)
        Me.MainPanel.Controls.Add(passwordTextBox)
        Me.MainPanel.Controls.Add(passwordVerifyTextBox)
        Me.MainPanel.Controls.Add(monthTextBox)
        Me.MainPanel.Controls.Add(dayTextBox)
        Me.MainPanel.Controls.Add(yearTextBox)
    End Sub

    'Places the registration button on the form
    Private Sub setUpRegisterButton()
        With RegisterButton
            .Location = New System.Drawing.Point(25, 350)
                .Font = newFont
            .Size = New System.Drawing.Size(500, 100)
            .Text = "Register"
        End With
        AddHandler RegisterButton.Click, AddressOf Me.registerButton_Click
        Me.MainPanel.Controls.Add(RegisterButton)
    End Sub

    Public Sub registerButton_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    'Makes the form pop up
    Public Sub popup()
        Me.Show()
    End Sub
End Class