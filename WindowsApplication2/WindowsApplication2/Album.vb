Imports Microsoft.VisualBasic

Public Class Album
    Private albumName As String
    Private artistName As String
    Private genreName As String

    Public Sub New(ByVal album, ByVal artist, ByVal genre)
        albumName = album
        artistName = artist
        genreName = genre
    End Sub

End Class
