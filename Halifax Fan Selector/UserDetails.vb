Imports System.IO
Imports System.Xml
Imports System.ComponentModel
Module UserDetails
    Public Sub ReadUserDetails()
        'ReadFromProjectFile = False
        'Dim OpenFileDialog1 As OpenFileDialog = New OpenFileDialog()
        'OpenFileDialog1.InitialDirectory = "c:\Halifax\Projects\"
        'OpenFileDialog1.Filter = "Halifax files (*.hfs)|*.hfs|All files (*.*)|*.*"
        'OpenFileDialog1.ShowDialog()
        OpenFileName = "c:\users\" + Environment.UserName + "\Halifax.xml"
        If File.Exists(OpenFileName) Then
            Dim textReader As XmlTextReader = New XmlTextReader(OpenFileName)
            textReader.MoveToFirstAttribute()
            Do While textReader.Read()
                'Dim type = textReader.NodeType
                'ReadGeneralInfo(textReader)
                'ReadSelectionInputInfo(textReader)
                'MsgBox("textReader.NameOf = ", textReader.Name)
                'If (type = XmlNodeType.Element) Then
                If textReader.Name = "Language" Then ChosenLanguage = textReader.ReadString
                'If textReader.Name = "Engineer" Then Engineer = textReader.ReadString
                'If textReader.Name = "User_Type" Then UserType = textReader.ReadString
                'End If
            Loop
            textReader.Close()
        Else
            FrmStart.Hide()
            FrmSettings.Show()
        End If

        'If OpenFileName = "" Then Exit Sub


        'While (textReader.Read())
        '    Dim type = textReader.NodeType
        '    'ReadGeneralInfo(textReader)
        '    'ReadSelectionInputInfo(textReader)
        '    'MsgBox("textReader.NameOf = ", textReader.Name)
        '    If (type = XmlNodeType.Element) Then
        '        If textReader.Name = "Customer" Then Customer = textReader.ReadString
        '        If textReader.Name = "Engineer" Then Engineer = textReader.ReadString
        '        If textReader.Name = "Flow_Units" Then Units(0).UnitSelected = textReader.ReadString
        '        If textReader.Name = "Pressure_Units" Then Units(1).UnitSelected = textReader.ReadString
        '        If textReader.Name = "Temperature_Units" Then Units(2).UnitSelected = textReader.ReadString
        '    End If

        'End While
        '' ### Close the load text file ###
        'textReader.Close()

        'TxtAtmosphericPressure.Text = atmos.ToString
        'TxtDesignTemperature.Text = designtemp.ToString
        'TxtMaximumTemperature.Text = maximumtemp.ToString
        'TxtAmbientTemperature.Text = ambienttemp.ToString
    End Sub
End Module
