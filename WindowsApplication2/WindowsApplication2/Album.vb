'This class holds the data about each Album
Imports Microsoft.VisualBasic

Public Class Album
    Public albumName As String
    Public artistName As String
    Public genreName As String
    Public locationString As String
    Public priceString As String

    Public Sub New(ByVal album As String, ByVal artist As String, ByVal genre As String, ByVal location As String, ByVal price As String)
        albumName = album
        artistName = artist
        genreName = genre
        locationString = location
        priceString = price
    End Sub


End Class
