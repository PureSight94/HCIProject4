Imports Microsoft.VisualBasic
Imports System.Xml
Module Module1
    'The following three lines creates the lists I will add the input strings to
    Dim Genre As New List(Of String)()
    Dim Artist As New List(Of String)()
    Dim Title As New List(Of String)()

    'Reads in the file, adds the inputs to appropriate lists, finally prints out the lists
    Function Main() As Integer
        Dim count As New Integer
        count = 0

        'Opens the file and reads the elements
        'Continues to loop through file until no Attributes are left
        Dim reader As XmlTextReader = New XmlTextReader("project4.xml")
        Do While (reader.Read())
            Select Case reader.NodeType
                Case XmlNodeType.Element
                    If reader.HasAttributes Then
                        While reader.MoveToNextAttribute()
                            Console.WriteLine(" {0}='{1}'", reader.Name, reader.Value)
                        End While
                    End If
                Case XmlNodeType.Text
                    If count Mod 3 = 2 Then
                        Title.Add(reader.Value)
                    End If
                    If count Mod 3 = 1 Then
                        Artist.Add(reader.Value)
                    End If
                    If count Mod 3 = 0 Then
                        Genre.Add(reader.Value)
                    End If
                    count = count + 1
                Case XmlNodeType.EndElement
            End Select
        Loop

        'Converts lists to strings and prints them to the Console
        Console.WriteLine("Genre")
        Dim stringGenre As String = ""
        Dim stringTitle As String = ""
        Dim stringArtist As String = ""
        For Each elem As String In Genre
            stringGenre &= elem & vbCrLf
        Next
        For Each elem As String In Artist
            stringArtist &= elem & vbCrLf
        Next
        For Each elem As String In Title
            stringTitle &= elem & vbCrLf
        Next
        Console.WriteLine(stringGenre)
        Console.WriteLine("Title")
        Console.WriteLine(stringTitle)
        Console.WriteLine("Artist")
        Console.WriteLine(stringArtist)
        Console.ReadLine()
        Return 0
    End Function

    'Actually calls the function that will read the XML file
    Dim xmlRead = Main()
End Module
