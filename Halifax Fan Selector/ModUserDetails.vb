Imports System.IO
Imports System.Xml
Module ModUserDetails
    Public Sub ReadUserDetails()
        Try
            OpenFileName = "c:\users\" + Environment.UserName + "\Halifax.xml"
            If File.Exists(OpenFileName) Then
                Dim textReader As XmlTextReader = New XmlTextReader(OpenFileName)
                textReader.MoveToFirstAttribute()
                Do While textReader.Read()
                    If textReader.Name = "Language" Then ChosenLanguage = textReader.ReadString
                Loop
                textReader.Close()
            Else
                FrmStart.Hide()
                FrmSettings.Show()
            End If
        Catch ex As Exception
            ErrorMessage(ex, 6301)
        End Try
    End Sub
End Module
