Imports System.Xml

Public Class GenreForm

    'For now this application only supports up to 100 albums. This is more of a high fidelity prorotype than a full program anyway
    Dim allAlbums(100) As Album

    'The following three lines creates the lists I will add the input strings to
    Dim GenreList As New List(Of String)()
    Dim ArtistList As New List(Of String)()
    Dim TitleList As New List(Of String)()

    'Keeps track of the unique genres, artists and albums so that the panels can be generated
    Dim uniqueGenre As List(Of String)
    Dim uniqueAlbum As List(Of String)
    Dim uniqueArtist As List(Of String)

    'Keeps track of the current data while reading the XML File
    'This assumes that every element of the XML File has each of the following: genre, artist, and album in the specified order
    Dim currentGenre As String
    Dim currentArtist As String
    Dim currentAlbum As String

    'Reads in the file, adds the inputs to appropriate lists, finally prints out the lists
    Sub readXML()
        Dim count As New Integer
        Dim albumCount As New Integer
        count = 0
        albumCount = 1
        'Opens the file and reads the elements
        'Continues to loop through file until no Attributes are left
        Dim reader As XmlTextReader = New XmlTextReader("project4.xml")
        Do While (reader.Read())
            Select Case reader.NodeType
                Case XmlNodeType.Element
                    If reader.HasAttributes Then
                        While reader.MoveToNextAttribute()
                        End While
                    End If
                Case XmlNodeType.Text
                    If count Mod 3 = 2 Then
                        currentAlbum = reader.Value
                        TitleList.Add(reader.Value)
                    End If
                    If count Mod 3 = 1 Then
                        currentArtist = reader.Value
                        ArtistList.Add(reader.Value)
                    End If
                    If count Mod 3 = 0 Then
                        currentGenre = reader.Value
                        GenreList.Add(reader.Value)
                    End If
                    count = count + 1

                    If count Mod 3 = 2 Then
                        allAlbums(albumCount) = New Album(currentGenre, currentAlbum, currentArtist)
                        albumCount += 1
                    End If
                Case XmlNodeType.EndElement
            End Select
        Loop

        'Remove duplicates from the list of genres, albums, and artists
        uniqueGenre = GenreList.Distinct().ToList
        uniqueAlbum = TitleList.Distinct().ToList
        uniqueArtist = ArtistList.Distinct.ToList

    End Sub

    'Entry form for the form!!!
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load, Back.Click
        readXML()
        Back.Enabled = False
        Forward.Enabled = False
        addButtonsToGenreForm()
    End Sub

    'Generates the buttons and adds them to the form
    Private Sub addButtonsToGenreForm()

        'This allows for a max of 100 buttons on each form
        Dim genreButton(100) As Button
        Dim genrePanel As New Panel
        Dim columnCount As New Integer
        Dim rowCount As New Integer
        columnCount = 0
        rowCount = 1

        'Creates the Panel and adds the buttons to the panel
        With genrePanel
            For i As Integer = 1 To uniqueGenre.Count - 1
                genreButton(i) = New Button
                With genreButton(i)
                    If columnCount Mod 3 = 0 Then
                        .Location = New System.Drawing.Point(150, 30 * rowCount)
                    End If
                    If columnCount Mod 3 = 1 Then
                        .Location = New System.Drawing.Point(500, 30 * rowCount)
                    End If
                    If columnCount Mod 3 = 2 Then
                        .Location = New System.Drawing.Point(850, 30 * rowCount)
                        rowCount += 5
                    End If
                    .Size = New System.Drawing.Size(150, 100)
                    .Text = uniqueGenre(i)
                End With
                .Controls.Add(genreButton(i))
                columnCount += 1
                AddHandler genreButton(i).Click, AddressOf Me.Button_Click
            Next
            .Location = New System.Drawing.Point(12, 121)
            .Name = "GenrePanel"
            .Size = New System.Drawing.Size(1210, 413)
        End With
        genrePanel.AutoScroll = True
        Me.Controls.Add(genrePanel)
    End Sub

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim SecondForm As New ArtristForm
        SecondForm.GenreButton.Text = sender.Text
        SecondForm.Show()
        Me.Close()
    End Sub

    Private Sub Genre_Click(sender As System.Object, e As System.EventArgs) Handles GenreButton.Click

    End Sub


    Private Sub Help_Click(sender As System.Object, e As System.EventArgs) Handles Help.Click
        Dim help As New HelpBox
        help.showHelp()
    End Sub
End Class

'This class will store information about each album read in from the XML file
Public Class Album
    Public albumName As String
    Public artistName As String
    Public genreName As String

    Public Sub New(ByVal album, ByVal artist, ByVal genre)
        albumName = album
        artistName = artist
        genreName = genre
    End Sub

End Class