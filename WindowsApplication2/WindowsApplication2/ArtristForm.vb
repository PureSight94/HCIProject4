'This will be the Artist Form that displays after choosing the Genre
Public Class ArtristForm

    Private Sub ArtristForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim GenreButtonName As Button = DirectCast(sender, Button)
        GenreButton.Text = GenreButtonName.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub GenreButton_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Help_Click(sender As System.Object, e As System.EventArgs) Handles Help.Click
        Dim help As New HelpBox
        help.showHelp()
    End Sub

    Private Sub Forward_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class