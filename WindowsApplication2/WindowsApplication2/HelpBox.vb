Imports System.Windows.Forms

'This class is responsible for making and displaying the Help Box when the ? button is clicked

Public Class HelpBox
    Dim HelpMessage As String = "Thank you for visiting our store." & vbCrLf & "The first step in finding the CD you wish to purchase is clicking the genre that the CD belongs." & vbCrLf & "Next, you will need to click the artist of the CD." & vbCrLf & "Then click the button corresponding to the CD you wish to purchase. Add more help here"
    Dim HelpTitle As String = "Help"

    'Actually displays the form
    Sub showHelp()
        MsgBox(HelpMessage, 0, HelpTitle)
    End Sub
End Class
