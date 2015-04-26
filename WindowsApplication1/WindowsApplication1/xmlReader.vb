
Imports Microsoft.VisualBasic
Imports System.Xml

'This xml reader code was mainly taken from the microsoft support pages'

Public Class xmlReader
    Public Shared Sub main()
        Dim reader As XmlTextReader = New XmlTextReader("project4.xml")
        Do While (reader.Read())
            Select Case reader.NodeType
                Case XmlNodeType.Element
                    'Display beginning of element
                    Console.Write("<" + reader.Name)
                    If reader.HasAttributes Then
                        While reader.MoveToNextAttribute()
                            Console.Write(" {0}='{1}'", reader.Name, reader.Value)
                        End While
                    End If
                    Console.WriteLine(">")
                Case XmlNodeType.Text
                    Console.WriteLine(reader.Value)
                Case XmlNodeType.EndElement
                    Console.Write("</" + reader.Name)
                    Console.WriteLine(">")
            End Select
        Loop
        Console.ReadLine()
    End Sub
End Class

