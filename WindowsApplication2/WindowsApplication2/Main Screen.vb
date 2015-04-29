'This class is responsible for making and displaying the genreForm, artistForm, and albumForm.
'The overview of how to read in XML files was taken from the microsoft support pages

Imports System.Xml

Public Class GenreForm

    'Pre Registered user information
    'This user has a wishlilst in the wishlist.xml file
    Dim loggedIn As Boolean = False
    Dim preRegisteredUser As Boolean = False
    Dim usernameRegistered As String = "username"
    Dim passwordRegistered As String = "password"

    'Font used for everything
    Dim newFont As New Font("Microsoft Sans Serif", 16)
    Dim loginFont As New Font("Microsoft Sans Serif", 12)

    'The Directory buttons used in the directory toolbar panel
    Dim specificGenreDirectory As New Button
    Dim GenreDirectoryButton As New Button
    Dim specificArtistDirectory As New Button
    Dim specificAlbumDirectory As New Button

    Dim WishlistButton As New Button
    Dim WelcomeLabel As New Label
    Dim logoutButton As New Button

    'This sets up the initial Genre Directory button
    Sub setupGenreDirectoryButton()
        With GenreDirectoryButton
            Me.Text = "Genre"
            .Name = "GenreDirectoryButton"
            AddHandler GenreDirectoryButton.Click, AddressOf Me.Genre_Click
        End With
    End Sub

    'Sets up the specified genre directory button
    'For example, if the user selects "Pop" then the "Pop" button will appear next to "Genre" in the directory
    Sub setUpGenreSpecificButton()
        With specificGenreDirectory
            .Name = "SpecificGenre"
            AddHandler specificGenreDirectory.Click, AddressOf Me.Specific_Genre_Directory_Click
        End With
    End Sub

    'This sets up the specified artist directory button
    'For example, if the user clicks  "Taylor Swift" then the "Taylor Swift" button will appear next to the specified genre button in the directory panel
    Sub setUpSpecificArtistButton()
        With specificArtistDirectory
            .Name = "SpecificArtist"
            AddHandler specificArtistDirectory.Click, AddressOf Me.specificArtistDirectory_Click
        End With
    End Sub

    'Holds the list of avaliable albums read in from the xml file
    Dim allAlbums As New List(Of Album)

    'The following three lines creates the lists I will add the input strings to
    Dim GenreList As New List(Of String)()
    Dim ArtistList As New List(Of String)()
    Dim TitleList As New List(Of String)()

    'Keeps track of the unique genres, artists and albums so that the panels can be generated
    Dim uniqueGenre As List(Of String)
    Dim uniqueAlbum As List(Of String)
    Dim uniqueArtist As List(Of String)

    'Keeps track of the current data while reading the XML File
    'This assumes that every element of the XML File has each of the following: genre, artist, album, location, and price in the specified order
    Dim currentGenre As String
    Dim currentArtist As String
    Dim currentAlbum As String
    Dim currentLocation As String
    Dim currentPrice As String

    'Holds the title, location, and price of the selected album
    Dim titleLabel As New Label
    Dim locationLabel As New Label
    Dim priceLabel As New Label

    'Reads in the file, adds each read in Album to the allAlbums List
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
                        allAlbums.Add(New Album(currentAlbum, currentArtist, currentGenre, currentLocation, currentPrice))
                    End If
                    count = count + 1

                    If count Mod 3 = 2 Then
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
        setupGenreDirectoryButton()

        With GenreDirectoryButton
            .Size = New System.Drawing.Size(450, 47)
            .Location = New System.Drawing.Point(0, 12)
            .Text = sender.Text
            .Font = newFont
            .TextAlign = ContentAlignment.MiddleCenter
        End With
        Me.DirectoryGroup.Controls.Add(GenreDirectoryButton)
        setupGenreDirectoryButton()
        setUpGenreSpecificButton()
        setUpSpecificArtistButton()
    End Sub

    Dim genreButtons(100) As Button

    'Generates the buttons and adds them to the form
    Private Sub addButtonsToGenreForm()

        'This allows for a max of 100 buttons on each form
        Dim columnCount As New Integer
        Dim rowCount As New Integer
        columnCount = 0
        rowCount = 1

        'Creates the Panel and adds the buttons to the panel
        With genrePanel
            For i As Integer = 1 To uniqueGenre.Count - 1
                genreButtons(i) = New Button
                With genreButtons(i)
                    If columnCount Mod 3 = 0 Then
                        .Location = New System.Drawing.Point(6, 30 * rowCount)
                    End If
                    If columnCount Mod 3 = 1 Then
                        .Location = New System.Drawing.Point(456, 30 * rowCount)
                    End If
                    If columnCount Mod 3 = 2 Then
                        .Location = New System.Drawing.Point(906, 30 * rowCount)
                        rowCount += 8
                    End If
                    .Size = New System.Drawing.Size(300, 200)
                    .Text = uniqueGenre(i)
                    Dim newFont As New Font("Microsoft Sans Serif", 16)
                    .Font = newFont
                End With
                .Controls.Add(genreButtons(i))
                columnCount += 1
                AddHandler genreButtons(i).Click, AddressOf Me.Specific_Genre_Button_Click
            Next
            .Location = New System.Drawing.Point(12, 121)
            .Name = "GenrePanel"
            .Size = New System.Drawing.Size(1210, 413)
        End With
        genrePanel.AutoScroll = True
        genrePanel.Dock = DockStyle.Fill
        'Me.Controls.Add(genrePanel)
    End Sub

    'Removes the genre specific buttons from the main panel
    Private Sub RemoveGenreButtons()
        With Me.genrePanel
            For i As Integer = 1 To uniqueGenre.Count - 1
                .Controls.Remove(genreButtons(i))
            Next
        End With
    End Sub

    'Gets executed when a genre button is pressed, i.e. when "pop" or "country" is selected
    'This function changed the directory buttons to reflect the current location in the UI
    'This function also gets all of the albums of the selected genre and puts them on the screen
    Private Sub Specific_Genre_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        With GenreDirectoryButton
            .Size = New System.Drawing.Size(225, 47)
        End With

        With specificGenreDirectory
            .Size = New System.Drawing.Size(225, 47)
            .Location = New System.Drawing.Point(230, 12)
            .Text = sender.Text
            .Font = newFont
            .TextAlign = ContentAlignment.MiddleCenter
        End With

        Me.DirectoryGroup.Controls.Add(specificGenreDirectory)
        RemoveGenreButtons()

        Dim columnCount As New Integer
        Dim rowCount As New Integer
        Dim CurrentArtistOfGenre As List(Of String)
        CurrentArtistOfGenre = findListMatchingGenre(sender.Text)

        columnCount = 0
        rowCount = 1
        With genrePanel
            For i As Integer = 0 To CurrentArtistOfGenre.Count - 1
                genreButtons(i + 1) = New Button
                With genreButtons(i + 1)
                    If columnCount Mod 3 = 0 Then
                        .Location = New System.Drawing.Point(6, 30 * rowCount)
                    End If
                    If columnCount Mod 3 = 1 Then
                        .Location = New System.Drawing.Point(456, 30 * rowCount)
                    End If
                    If columnCount Mod 3 = 2 Then
                        .Location = New System.Drawing.Point(906, 30 * rowCount)
                        rowCount += 8
                    End If
                    .Size = New System.Drawing.Size(300, 200)
                    .Text = CurrentArtistOfGenre(i)
                    Dim newFont As New Font("Microsoft Sans Serif", 16)
                    .Font = newFont
                End With
                .Controls.Add(genreButtons(i + 1))
                columnCount += 1
                AddHandler genreButtons(i + 1).Click, AddressOf Me.Specific_Artist_Button_Click
            Next
            .Location = New System.Drawing.Point(12, 121)
            .Name = "GenrePanel"
            .Size = New System.Drawing.Size(1210, 413)
        End With
    End Sub

    'Sets up the directory buttons and fills out the panel with the appropraite buttons after a genre is selected
    'This populated the main panel with buttons for each artist of the selected genre
    Private Sub Specific_Artist_Button_Click(sender As System.Object, e As System.EventArgs)
        With GenreDirectoryButton
            .Size = New System.Drawing.Size(160, 47)
            .Location = New System.Drawing.Point(-5, 12)
        End With

        With specificGenreDirectory
            .Size = New System.Drawing.Size(160, 47)
            .Location = New System.Drawing.Point(162, 12)
        End With

        With specificArtistDirectory
            .Size = New System.Drawing.Size(160, 47)
            .Location = New System.Drawing.Point(325, 12)
            .Text = sender.Text
            .Font = newFont
            .TextAlign = ContentAlignment.MiddleCenter
        End With

        Me.DirectoryGroup.Controls.Add(specificGenreDirectory)
        Me.DirectoryGroup.Controls.Add(specificArtistDirectory)
        RemoveGenreButtons()

        Dim columnCount As New Integer
        Dim rowCount As New Integer
        Dim CurrentAlbumOfArtist As List(Of String)
        CurrentAlbumOfArtist = findListMatchingArtist(sender.Text)

        columnCount = 0
        rowCount = 1
        With genrePanel
            For i As Integer = 0 To CurrentAlbumOfArtist.Count - 1
                genreButtons(i + 1) = New Button
                With genreButtons(i + 1)
                    If columnCount Mod 3 = 0 Then
                        .Location = New System.Drawing.Point(6, 30 * rowCount)
                    End If
                    If columnCount Mod 3 = 1 Then
                        .Location = New System.Drawing.Point(456, 30 * rowCount)
                    End If
                    If columnCount Mod 3 = 2 Then
                        .Location = New System.Drawing.Point(906, 30 * rowCount)
                        rowCount += 8
                    End If
                    .Size = New System.Drawing.Size(300, 200)
                    .Text = CurrentAlbumOfArtist(i)
                    Dim newFont As New Font("Microsoft Sans Serif", 16)
                    .Font = newFont
                End With
                .Controls.Add(genreButtons(i + 1))
                columnCount += 1
                AddHandler genreButtons(i + 1).Click, AddressOf Me.specific_Album_Button_Click
            Next
            .Location = New System.Drawing.Point(12, 121)
            .Name = "GenrePanel"
            .Size = New System.Drawing.Size(1210, 413)
        End With
    End Sub

    'Searches through the allAlbums read in from the XML file and returns a list of Artists matching the given genre
    Private Function findListMatchingGenre(stringGenre As String) As List(Of String)
        Dim currentList As New List(Of String)
        For Each CD In allAlbums
            If CD.genreName.Equals(stringGenre) Then
                currentList.Add(CD.artistName)
            End If
        Next
        Return currentList.Distinct.ToList
    End Function

    'Searches through the allAlbums read in from the XML file and returns a list of Album Titles matching the given Artist
    Private Function findListMatchingArtist(stringArtist As String) As List(Of String)
        Dim currentList As New List(Of String)
        For Each CD In allAlbums
            If CD.artistName.Equals(stringArtist) Then
                currentList.Add(CD.albumName)
            End If
        Next
        Return currentList.Distinct.ToList
    End Function

    'Searches through the allAlbums read in from the XML file and returns a list of Album object matching the given Album title
    Private Function findListMatchingAlbum(stringAlbum As String) As Album
        Dim currentAlbumList As New Album(0, 0, 0, 0, 0)
        For Each CD In allAlbums
            If CD.albumName.Equals(stringAlbum) Then
                currentAlbumList = New Album(CD.albumName, CD.artistName, CD.genreName, CD.locationString, CD.priceString)
            End If
        Next
        Return currentAlbumList
    End Function

    'This gets called when the user clicks the specified Artist directory button
    'This repopulates the main panel with the albums from the given artist
    'This also resets the directory buttons to what they were when the user first selected an artist
    Private Sub specificArtistDirectory_Click(sender As System.Object, e As System.EventArgs)
        With GenreDirectoryButton
            .Size = New System.Drawing.Size(160, 47)
            .Location = New System.Drawing.Point(-5, 12)
        End With

        With specificGenreDirectory
            .Size = New System.Drawing.Size(160, 47)
            .Location = New System.Drawing.Point(162, 12)
        End With

        With specificArtistDirectory
            .Size = New System.Drawing.Size(160, 47)
            .Location = New System.Drawing.Point(325, 12)
            .Text = sender.Text
            .Font = newFont
            .TextAlign = ContentAlignment.MiddleCenter
        End With

        Me.genrePanel.Controls.Remove(titleLabel)
        Me.genrePanel.Controls.Remove(locationLabel)
        Me.genrePanel.Controls.Remove(priceLabel)
        Me.DirectoryGroup.Controls.Remove(specificGenreDirectory)
        Me.DirectoryGroup.Controls.Remove(specificArtistDirectory)
        Me.DirectoryGroup.Controls.Remove(specificAlbumDirectory)
        Me.DirectoryGroup.Controls.Add(specificGenreDirectory)
        Me.DirectoryGroup.Controls.Add(specificArtistDirectory)
        RemoveGenreButtons()

        Dim columnCount As New Integer
        Dim rowCount As New Integer
        Dim CurrentAlbumOfArtist As List(Of String)
        CurrentAlbumOfArtist = findListMatchingArtist(sender.Text)

        columnCount = 0
        rowCount = 1
        With genrePanel
            For i As Integer = 0 To CurrentAlbumOfArtist.Count - 1
                genreButtons(i + 1) = New Button
                With genreButtons(i + 1)
                    If columnCount Mod 3 = 0 Then
                        .Location = New System.Drawing.Point(6, 30 * rowCount)
                    End If
                    If columnCount Mod 3 = 1 Then
                        .Location = New System.Drawing.Point(456, 30 * rowCount)
                    End If
                    If columnCount Mod 3 = 2 Then
                        .Location = New System.Drawing.Point(906, 30 * rowCount)
                        rowCount += 8
                    End If
                    .Size = New System.Drawing.Size(300, 200)
                    .Text = CurrentAlbumOfArtist(i)
                    Dim newFont As New Font("Microsoft Sans Serif", 16)
                    .Font = newFont
                End With
                .Controls.Add(genreButtons(i + 1))
                columnCount += 1
                AddHandler genreButtons(i + 1).Click, AddressOf Me.specific_Album_Button_Click
            Next
            .Location = New System.Drawing.Point(12, 121)
            .Name = "GenrePanel"
            .Size = New System.Drawing.Size(1210, 413)
        End With

    End Sub

    'This method gets called when the user clicks on a specific album title in the main panel
    'This removes all buttons from the main panel and displays information about the album matching the selected album title
    Private Sub specific_Album_Button_Click(sender As System.Object, e As System.EventArgs)
        RemoveGenreButtons()

        With GenreDirectoryButton
            .Size = New System.Drawing.Size(125, 47)
            .Location = New System.Drawing.Point(-5, 12)
        End With

        With specificGenreDirectory
            .Size = New System.Drawing.Size(125, 47)
            .Location = New System.Drawing.Point(127, 12)
        End With

        With specificArtistDirectory
            .Size = New System.Drawing.Size(125, 47)
            .Location = New System.Drawing.Point(254, 12)

        End With

        With specificAlbumDirectory
            .Size = New System.Drawing.Size(125, 47)
            .Location = New System.Drawing.Point(381, 12)
            .Text = sender.Text
            .Font = newFont
            .TextAlign = ContentAlignment.MiddleCenter
        End With

        Me.genrePanel.Controls.Remove(titleLabel)
        Me.genrePanel.Controls.Remove(locationLabel)
        Me.genrePanel.Controls.Remove(priceLabel)

        Me.DirectoryGroup.Controls.Remove(specificGenreDirectory)
        Me.DirectoryGroup.Controls.Remove(specificArtistDirectory)
        Me.DirectoryGroup.Controls.Remove(specificAlbumDirectory)
        Me.DirectoryGroup.Controls.Add(specificGenreDirectory)
        Me.DirectoryGroup.Controls.Add(specificArtistDirectory)
        Me.DirectoryGroup.Controls.Add(specificAlbumDirectory)
        RemoveGenreButtons()

        Dim albumList As New Album(0, 0, 0, 0, 0)
        albumList = findListMatchingAlbum(sender.Text)

        With titleLabel
            .Location = New System.Drawing.Point(460, 150)
            .Text = "Title                  " + sender.Text
            .Font = newFont
            .Size = New System.Drawing.Size(700, 100)
        End With

        With locationLabel
            .Location = New System.Drawing.Point(410, 250)
            .Text = "Location                  " + albumList.locationString
            .Font = newFont
            .Size = New System.Drawing.Size(700, 100)
        End With

        With priceLabel
            .Location = New System.Drawing.Point(450, 350)
            .Text = "Price                  " + albumList.priceString
            .Font = newFont
            .Size = New System.Drawing.Size(700, 100)
        End With

        If loggedIn Then
            Dim addToWishListButton As New Button
            With addToWishListButton
                .Location = New System.Drawing.Point(250, 450)
                .Text = "Add to Wishlsit"
                .Font = newFont
                .Size = New System.Drawing.Size(700, 100)
            End With
            Me.genrePanel.Controls.Add(addToWishListButton)
        End If

        Me.genrePanel.Controls.Add(titleLabel)
        Me.genrePanel.Controls.Add(locationLabel)
        Me.genrePanel.Controls.Add(priceLabel)

    End Sub

    'This method gets called when the user clicks on the Genre directory button
    'This resets the form to look like it does when the user first opens it
    Private Sub Genre_Click(sender As System.Object, e As System.EventArgs)
        RemoveGenreButtons()
        addButtonsToGenreForm()
        With GenreDirectoryButton
            .Size = New System.Drawing.Size(450, 47)
            .Location = New System.Drawing.Point(0, 12)
            .Text = sender.Text
            .Font = newFont
            .TextAlign = ContentAlignment.MiddleCenter
        End With

        Me.genrePanel.Controls.Remove(titleLabel)
        Me.genrePanel.Controls.Remove(locationLabel)
        Me.genrePanel.Controls.Remove(priceLabel)

        Me.DirectoryGroup.Controls.Remove(specificAlbumDirectory)
        Me.DirectoryGroup.Controls.Remove(specificGenreDirectory)
        Me.DirectoryGroup.Controls.Remove(specificArtistDirectory)
        Me.DirectoryGroup.Controls.Add(GenreDirectoryButton)
    End Sub

    'This method gets called when the user clicks on the specific genre directory button, such as "Pop"
    'This method resets the form to look like what it did when the user first selected "Pop"
    Private Sub Specific_Genre_Directory_Click(sender As System.Object, e As System.EventArgs)
        With GenreDirectoryButton
            .Size = New System.Drawing.Size(225, 47)
        End With

        With specificGenreDirectory
            .Size = New System.Drawing.Size(225, 47)
            .Location = New System.Drawing.Point(230, 12)
            .Text = sender.Text
            .Font = newFont
            .TextAlign = ContentAlignment.MiddleCenter
        End With

        Me.genrePanel.Controls.Remove(titleLabel)
        Me.genrePanel.Controls.Remove(locationLabel)
        Me.genrePanel.Controls.Remove(priceLabel)

        Me.DirectoryGroup.Controls.Remove(specificGenreDirectory)
        Me.DirectoryGroup.Controls.Remove(specificArtistDirectory)
        Me.DirectoryGroup.Controls.Remove(specificAlbumDirectory)
        Me.DirectoryGroup.Controls.Add(specificGenreDirectory)
        RemoveGenreButtons()

        Dim columnCount As New Integer
        Dim rowCount As New Integer
        Dim CurrentArtistOfGenre As List(Of String)
        CurrentArtistOfGenre = findListMatchingGenre(sender.Text)

        columnCount = 0
        rowCount = 1
        With genrePanel
            For i As Integer = 0 To CurrentArtistOfGenre.Count - 1
                genreButtons(i + 1) = New Button
                With genreButtons(i + 1)
                    If columnCount Mod 3 = 0 Then
                        .Location = New System.Drawing.Point(6, 30 * rowCount)
                    End If
                    If columnCount Mod 3 = 1 Then
                        .Location = New System.Drawing.Point(456, 30 * rowCount)
                    End If
                    If columnCount Mod 3 = 2 Then
                        .Location = New System.Drawing.Point(906, 30 * rowCount)
                        rowCount += 8
                    End If
                    .Size = New System.Drawing.Size(300, 200)
                    .Text = CurrentArtistOfGenre(i)
                    Dim newFont As New Font("Microsoft Sans Serif", 16)
                    .Font = newFont
                End With
                .Controls.Add(genreButtons(i + 1))
                columnCount += 1
                AddHandler genreButtons(i + 1).Click, AddressOf Me.Specific_Artist_Button_Click
            Next
            .Location = New System.Drawing.Point(12, 121)
            .Name = "GenrePanel"
            .Size = New System.Drawing.Size(1210, 413)
        End With

    End Sub

    'This gets called when the user clicks the "?" button
    'This creates an instance of the Help class and displays the Help message box
    Private Sub Help_Click(sender As System.Object, e As System.EventArgs) Handles Help.Click
        Dim help As New HelpBox
        help.showHelp()
    End Sub

    'This gets called when the user clicks the "Register" button
    'This creates an instance of the Register class and displays the Registration Form
    Private Sub Register_Click(sender As System.Object, e As System.EventArgs) Handles Register.Click
        Dim registration As New Registration
        Dim userName As String
        Dim password As String
        registration.popup()
        userName = registration.emailTextBox.Text
        password = registration.passwordTextBox.Text
    End Sub

    Private Sub Login_Click(sender As System.Object, e As System.EventArgs) Handles Login.Click
        Dim usernameField As String
        Dim passwordField As String
        usernameField = username.Text
        passwordField = password.Text

        'Check to see if the user is registered in the system, AKA The single user I have a wishlist xml file for
        If usernameField = usernameRegistered And passwordField = passwordRegistered Then
            preRegisteredUser = True
            loggedIn = True
        End If

        'If the login information matches the pre registered user, then change the toolbar to reflect that
        If preRegisteredUser Then

            'Remove now unnecessary controls
            Me.DirectoryGroup.Controls.Remove(username)
            Me.DirectoryGroup.Controls.Remove(password)
            Me.DirectoryGroup.Controls.Remove(Login)
            Me.DirectoryGroup.Controls.Remove(Register)

            'Add new controls
            With WishlistButton
                .Font = newFont
                .Location = New System.Drawing.Point(755, 10)
                .Size = New System.Drawing.Size(125, 50)
                .Text = "Wishlist"
            End With

            With WelcomeLabel
                .Font = newFont
                .Location = New System.Drawing.Point(500, 20)
                .Size = New System.Drawing.Size(300, 30)
                .Text = "Welcome " + usernameField
            End With

            With logoutButton
                .Font = newFont
                .Location = New System.Drawing.Point(885, 10)
                .Size = New System.Drawing.Size(105, 50)
                .Text = "Logout"
            End With

            AddHandler logoutButton.Click, AddressOf Me.logout_Button_Click
            AddHandler WishlistButton.Click, AddressOf Me.wishlist_Button_Click

            Me.DirectoryGroup.Controls.Add(WishlistButton)
            Me.DirectoryGroup.Controls.Add(WelcomeLabel)
            Me.DirectoryGroup.Controls.Add(logoutButton)
        End If
    End Sub

    'This gets called when the wishlist button is clicked
    'This resets the directory toolbar the way it was
    Private Sub logout_Button_Click(sender As System.Object, e As System.EventArgs)
        Dim usernameField As New TextBox
        Dim passwordField As New TextBox
        Dim LoginButton As New Button
        Dim RegisterButton As New Button

        With usernameField
            .Size = New System.Drawing.Size(112, 30)
            .Location = New System.Drawing.Point(584, 20)
            .Font = newFont
        End With

        With passwordField
            .Size = New System.Drawing.Size(112, 32)
            .Location = New System.Drawing.Point(702, 20)
            .Font = loginFont
        End With

        With LoginButton
            .Size = New System.Drawing.Size(75, 32)
            .Location = New System.Drawing.Point(829, 20)
            .Font = loginFont
            .Text = "Login"
        End With

        With RegisterButton
            .Size = New System.Drawing.Size(91, 32)
            .Location = New System.Drawing.Point(910, 20)
            .Font = loginFont
            .Text = "Register"
        End With

        AddHandler LoginButton.Click, AddressOf Me.Login_Click
        AddHandler RegisterButton.Click, AddressOf Me.Register_Click

        Me.DirectoryGroup.Controls.Remove(logoutButton)
        Me.DirectoryGroup.Controls.Remove(WishlistButton)
        Me.DirectoryGroup.Controls.Remove(WelcomeLabel)

        Me.DirectoryGroup.Controls.Add(usernameField)
        Me.DirectoryGroup.Controls.Add(passwordField)
        Me.DirectoryGroup.Controls.Add(LoginButton)
        Me.DirectoryGroup.Controls.Add(RegisterButton)


    End Sub

    Dim wishlist As New List(Of Album)

    'This gets called when the logout button is clicked
    'This opens up the wishlist form
    Private Sub wishlist_Button_Click(sender As System.Object, e As System.EventArgs)
        Dim wishlist As New Wishlist
        wishlist.popup()
    End Sub


End Class
