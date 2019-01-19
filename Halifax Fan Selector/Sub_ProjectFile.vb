Imports System.Xml
Module Sub_ProjectFile
    Sub ReadProjectFile(OpenFileName As String)
        Try

            Dim textReader As XmlTextReader = New XmlTextReader(OpenFileName)
        textReader.MoveToFirstAttribute()

        'While (document.Read())

        '    Dim type = document.NodeType

        '    'if node type was element
        '    If (type = XmlNodeType.Element) Then

        '        'if the loop found a <FirstName> tag
        '        If (document.Name = "FirstName") Then

        '            TextBox1.Text = document.ReadInnerXml.ToString()

        '        End If

        '        'if the loop found a <LastName tag
        '        If (document.Name = "LastName") Then

        '            TextBox2.Text = document.ReadInnerXml.ToString()

        '        End If

        '    End If

        'End While

        While (textReader.Read())
            Dim type = textReader.NodeType
            'ReadGeneralInfo(textReader)
            'ReadSelectionInputInfo(textReader)
            'MsgBox("textReader.NameOf = ", textReader.Name)
            If (type = XmlNodeType.Element) Then
                If textReader.Name = "Customer" Then Customer = textReader.ReadString
                If textReader.Name = "Engineer" Then Engineer = textReader.ReadString
                If textReader.Name = "Flow_Units" Then Units(0).UnitSelected = textReader.ReadString
                If textReader.Name = "Pressure_Units" Then Units(1).UnitSelected = textReader.ReadString
                If textReader.Name = "Temperature_Units" Then Units(2).UnitSelected = textReader.ReadString
                If textReader.Name = "Density_Units" Then Units(3).UnitSelected = textReader.ReadString
                If textReader.Name = "Power_Units" Then Units(4).UnitSelected = textReader.ReadString
                If textReader.Name = "Size_Units" Then Units(5).UnitSelected = textReader.ReadString
                If textReader.Name = "Altitude_Units" Then Units(6).UnitSelected = textReader.ReadString
                If textReader.Name = "Design_Temperature" Then designtemp = textReader.ReadString
                If textReader.Name = "Maximum_Temperature" Then maximumtemp = textReader.ReadString
                If textReader.Name = "Ambient_Temperature" Then ambienttemp = textReader.ReadString
                If textReader.Name = "Altitude" Then altitude = textReader.ReadString
                If textReader.Name = "Relative_Humidity" Then humidity = textReader.ReadString
                If textReader.Name = "Atmospheric_Pressure" Then atmospress = textReader.ReadString
                If textReader.Name = "Known_Density" Then knowndensity = textReader.ReadString
                If textReader.Name = "Flow_Rate" Then flowrate = textReader.ReadString
                If textReader.Name = "Inlet_Pressure" Then inletpress = textReader.ReadString
                If textReader.Name = "Discharge_Pressure" Then dischpress = textReader.ReadString
                If textReader.Name = "Pressure_Rise" Then pressrise = textReader.ReadString
                If textReader.Name = "Reserve_Head" Then reshead = textReader.ReadString
                If textReader.Name = "Maximum_Speed" Then maxspeed = textReader.ReadString
            End If

        End While
        ' ### Close the load text file ###
        textReader.Close()

        With Frmselectfan
            .TxtAtmosphericPressure.Text = atmos.ToString
            .TxtDesignTemperature.Text = designtemp.ToString
            .TxtMaximumTemperature.Text = maximumtemp.ToString
            .TxtAmbientTemperature.Text = ambienttemp.ToString
            .TxtAltitude.Text = altitude.ToString
            .TxtHumidity.Text = humidity.ToString
            .TxtAtmosphericPressure.Text = atmospress.ToString
            .Txtdens.Text = knowndensity.ToString
            .Txtflow.Text = flowrate.ToString
            .TxtInletPressure.Text = inletpress.ToString
            .TxtDischargePressure.Text = dischpress.ToString
            .Txtfsp.Text = pressrise.ToString
            .CmbReserveHead.Text = reshead.ToString + "%"
            .Txtspeedlimit.Text = maxspeed.ToString
            ReadFromProjectFile = True
        End With
            'Catch ex As Exception
            '    'MsgBox("OpenProjectToolStripMenuItem_Click")
            '    'Resume
            'End Try

        Catch ex As Exception
            ErrorMessage(ex, 1501)
        End Try

    End Sub

End Module
