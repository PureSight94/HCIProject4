Imports Microsoft.VisualBasic
Imports System.Xml

Public Class Form1
    Dim outputFile As System.IO.StreamWriter
    Function main() As Integer
        outputFile = My.Computer.FileSystem.OpenTextFileWriter("testOutput.txt", True)
        Dim reader As XmlTextReader = New XmlTextReader("project4.xml")
        Do While (reader.Read())
            Select Case reader.NodeType
                Case XmlNodeType.Element
                    'Display beginning of element
                    outputFile.WriteLine("<" + reader.Name)
                    If reader.HasAttributes Then
                        While reader.MoveToNextAttribute()
                            outputFile.WriteLine(" {0}='{1}'", reader.Name, reader.Value)
                        End While
                    End If
                    outputFile.WriteLine(">")
                Case XmlNodeType.Text
                    outputFile.WriteLine(reader.Value)
                Case XmlNodeType.EndElement
                    outputFile.WriteLine("</" + reader.Name)
                    outputFile.WriteLine(">")
            End Select
        Loop
        Console.ReadLine()
        Return 0
    End Function
    Dim xmlRead As Integer = main()
End Class
