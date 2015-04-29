Imports System.Xml

'This class/form displays the wishlist of the user
'The overview of how to read in XML files was taken from the microsoft support pages

Public Class Wishlist

    Public desiredCDs As New List(Of Album)

    Private Sub Wishlist_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        readXML()
        populateWishlistButton()
    End Sub

    Public Sub popup()
        Me.Show()
        readXML()
        populateWishlistButton()
    End Sub

    'This populates the wishlist with the user's current wishlist
    Private Sub populateWishlistButton()
        Dim titleLabels(100) As Label
        Dim priceLabels(100) As Label
        Dim removeButton(100) As Label
        Dim rowCount As Integer = 1
        Dim columnCount As Integer = 1
        With MainPanel
            For i As Integer = 1 To desiredCDs.Count - 1
                For j As Integer = 1 To 3
                    If j = 1 Then
                        titleLabels(i) = New Label
                        With titleLabels(i)
                            .Location = New System.Drawing.Point(75, 30 * rowCount)
                            .Size = New System.Drawing.Size(250, 50)
                            .Text = desiredCDs(i).albumName
                            Dim newFont As New Font("Microsoft Sans Serif", 16)
                            .Font = newFont
                            .TextAlign = ContentAlignment.MiddleRight
                        End With
                        .Controls.Add(titleLabels(i))
                    End If
                    If j = 2 Then
                        priceLabels(i) = New Label
                        With priceLabels(i)
                            .Location = New System.Drawing.Point(330, 30 * rowCount)
                            .Size = New System.Drawing.Size(100, 50)
                            .Text = desiredCDs(i).priceString
                            Dim newFont As New Font("Microsoft Sans Serif", 16)
                            .Font = newFont
                            .TextAlign = ContentAlignment.MiddleRight
                        End With
                        .Controls.Add(priceLabels(i))
                    End If
                    If j = 3 Then
                        removeButton(i) = New Label
                        With removeButton(i)
                            .Location = New System.Drawing.Point(380, 30 * rowCount)
                            .Size = New System.Drawing.Size(150, 50)
                            .Text = "-"
                            Dim newFont As New Font("Microsoft Sans Serif", 16)
                            .Font = newFont
                            .TextAlign = ContentAlignment.MiddleCenter
                        End With
                        .Controls.Add(removeButton(i))
                    End If
                Next
                rowCount += 4
            Next
            .Location = New System.Drawing.Point(12, 121)
            .Name = "GenrePanel"
            .Size = New System.Drawing.Size(1210, 413)
        End With
        MainPanel.AutoScroll = True
        MainPanel.Dock = DockStyle.Fill

    End Sub

    'The following three lines creates the lists I will add the input strings to
    Dim GenreList As New List(Of String)()
    Dim ArtistList As New List(Of String)()
    Dim TitleList As New List(Of String)()

    'Keeps track of the current data while reading the XML File
    'This assumes that every element of the XML File has each of the following: genre, artist, album, location, and price in the specified order
    Dim currentGenre As String
    Dim currentArtist As String
    Dim currentAlbum As String
    Dim currentLocation As String
    Dim currentPrice As String


    'Reads in the Wishlist XML File
    'Reads in the file, adds each read in Album to the allAlbums List
    Sub readXML()

        Dim count As New Integer
        Dim albumCount As New Integer
        count = 0
        albumCount = 1
        'Opens the file and reads the elements
        'Continues to loop through file until no Attributes are left
        Dim reader As XmlTextReader = New XmlTextReader("wishlist.xml")
        Do While (reader.Read())
            Select Case reader.NodeType
                Case XmlNodeType.Element
                    If reader.HasAttributes Then
                        While reader.MoveToNextAttribute()
                        End While
                    End If
                Case XmlNodeType.Text
                    If count Mod 5 = 2 Then
                        currentAlbum = reader.Value
                        TitleList.Add(reader.Value)
                    End If
                    If count Mod 5 = 1 Then
                        currentArtist = reader.Value
                        ArtistList.Add(reader.Value)
                    End If
                    If count Mod 5 = 0 Then
                        currentGenre = reader.Value
                        GenreList.Add(reader.Value)
                    End If
                    If count Mod 5 = 3 Then
                        currentLocation = reader.Value
                    End If
                    If count Mod 5 = 4 Then
                        currentPrice = reader.Value
                        desiredCDs.Add(New Album(currentAlbum, currentArtist, currentGenre, currentLocation, currentPrice))
                    End If
                    count = count + 1

                    If count Mod 3 = 2 Then
                        albumCount += 1
                    End If
                Case XmlNodeType.EndElement
            End Select
        Loop

    End Sub
End Class