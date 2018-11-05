Imports System.Xml
Module Subs
    Public Sub Initialize(Set1stTime As Boolean)
        Try
            If Set1stTime = True Then SetUnitStructure()

            SetUnits()
            'populating Pressure Type
            '        Frmselectfan.cmbPressType.AddItem "Fan Static"
            '        Frmselectfan.cmbPressType.AddItem "Fan Total"
            '        DensMult = 1

            NextSpeed = "2 Pole"
            RunTemp = 20
            For II = 0 To 50 - 1
                Widthratios(II) = 1
            Next II
            'Customer = ""
            FileSaved = False
            designtemp = 0.0
            maximumtemp = 0.0
            ambienttemp = 0.0
            altitude = 0.0
            humidity = 0.0
            atmospress = 0.0
            knowndensity = 0.0
            calcdensity = 0.0
            flowrate = 0.0
            reshead = 5.0
            inletpress = 0.0
            dischpress = 0.0
            pressrise = 0.0
            maxspeed = 0.0
            fansize = 0.0
            If UserName.ToLower.Contains("akm") = True Then
                designtemp = 20.0
                maximumtemp = 20.0
                ambienttemp = 20.0
                atmospress = 101325.0
                knowndensity = 1.2
                flowrate = 10000.0
                pressrise = 4000.0
                maxspeed = 3600.0
            End If

        Catch ex As Exception
            MsgBox("Initialize")
        End Try
    End Sub

    Sub WriteGeneralInfo(ByVal TextWriter As XmlTextWriter)
        Try
            Write_to_XML(TextWriter, "General_information")
            If Customer Is Nothing Then Customer = "xxxx"
            If Engineer Is Nothing Then Engineer = "xxxx"
            Write_to_XML(TextWriter, "Customer", Customer)
            Write_to_XML(TextWriter, "Engineer", Engineer)
            Write_to_XML(TextWriter, "Flow_Units", Units(0).UnitSelected)
            Write_to_XML(TextWriter, "Pressure_Units", Units(1).UnitSelected)
            Write_to_XML(TextWriter, "Temperature_Units", Units(2).UnitSelected)
            Write_to_XML(TextWriter, "Density_Units", Units(3).UnitSelected)
            Write_to_XML(TextWriter, "Power_Units", Units(4).UnitSelected)
            Write_to_XML(TextWriter, "Size_Units", Units(5).UnitSelected)
            Write_to_XML(TextWriter, "Altitude_Units", Units(6).UnitSelected)
            Write_to_XML(TextWriter)

        Catch ex As Exception
            MsgBox("WriteGeneralInfo")
        End Try
    End Sub
    Sub WriteSelectionInputInfo(ByVal TextWriter As XmlTextWriter)
        Try
            Write_to_XML(TextWriter, "Selection_Input_information")
            Write_to_XML(TextWriter, "Design_Temperature", designtemp.ToString)
            Write_to_XML(TextWriter, "Maximum_Temperature", maximumtemp.ToString)
            Write_to_XML(TextWriter, "Ambient_Temperature", ambienttemp.ToString)
            Write_to_XML(TextWriter, "Altitude", altitude.ToString)
            Write_to_XML(TextWriter, "Relative_Humidity", humidity.ToString)
            Write_to_XML(TextWriter, "Atmospheric_Pressure", atmospress.ToString)
            Write_to_XML(TextWriter, "Known_Density", knowndensity.ToString)
            Write_to_XML(TextWriter, "Flow_Rate", flowrate.ToString)
            Write_to_XML(TextWriter, "Inlet_Pressure", inletpress.ToString)
            Write_to_XML(TextWriter, "Discharge_Pressure", dischpress.ToString)
            Write_to_XML(TextWriter, "Pressure_Rise", pressrise.ToString)
            Write_to_XML(TextWriter, "Reserve_Head", reshead.ToString)
            Write_to_XML(TextWriter, "Maximum_Speed", maxspeed.ToString)
            Write_to_XML(TextWriter)

        Catch ex As Exception
            MsgBox("WriteSelectionInputInfo")
        End Try
    End Sub

    Sub WriteSelectionOutputInfo(ByVal TextWriter As XmlTextWriter)
        Try
            Write_to_XML(TextWriter, "Selection_Output_information")
            Write_to_XML(TextWriter, "Fan_Design", designtemp.ToString)
            Write_to_XML(TextWriter, "Fan_Size", maximumtemp.ToString)
            Write_to_XML(TextWriter, "Ambient_Temperature", ambienttemp.ToString)
            Write_to_XML(TextWriter, "Altitude", altitude.ToString)
            Write_to_XML(TextWriter, "Relative_Humidity", humidity.ToString)
            Write_to_XML(TextWriter, "Atmospheric_Pressure", atmospress.ToString)
            Write_to_XML(TextWriter, "Known_Density", knowndensity.ToString)
            Write_to_XML(TextWriter, "Flow_Rate", flowrate.ToString)
            Write_to_XML(TextWriter, "Inlet_Pressure", inletpress.ToString)
            Write_to_XML(TextWriter, "Discharge_Pressure", dischpress.ToString)
            Write_to_XML(TextWriter, "Pressure_Rise", pressrise.ToString)
            Write_to_XML(TextWriter, "Reserve_Head", reshead.ToString)
            Write_to_XML(TextWriter, "Maximum_Speed", maxspeed.ToString)
            Write_to_XML(TextWriter)

        Catch ex As Exception
            MsgBox("WriteSelectionOutputInfo")
        End Try
    End Sub

    Sub WriteNoiseInfo(ByVal TextWriter As XmlTextWriter)
        Try
            Write_to_XML(TextWriter, "Noise_information")
            Write_to_XML(TextWriter, "Design_Temperature", designtemp.ToString)
            Write_to_XML(TextWriter, "Maximum_Temperature", maximumtemp.ToString)
            Write_to_XML(TextWriter, "Ambient_Temperature", ambienttemp.ToString)
            Write_to_XML(TextWriter, "Altitude", altitude.ToString)
            Write_to_XML(TextWriter, "Relative_Humidity", humidity.ToString)
            Write_to_XML(TextWriter, "Atmospheric_Pressure", atmospress.ToString)
            Write_to_XML(TextWriter, "Known_Density", knowndensity.ToString)
            Write_to_XML(TextWriter, "Flow_Rate", flowrate.ToString)
            Write_to_XML(TextWriter, "Inlet_Pressure", inletpress.ToString)
            Write_to_XML(TextWriter, "Discharge_Pressure", dischpress.ToString)
            Write_to_XML(TextWriter, "Pressure_Rise", pressrise.ToString)
            Write_to_XML(TextWriter, "Reserve_Head", reshead.ToString)
            Write_to_XML(TextWriter, "Maximum_Speed", maxspeed.ToString)
            Write_to_XML(TextWriter)

        Catch ex As Exception
            MsgBox("WriteNoisetInfo")
        End Try
    End Sub

    Sub SaveToFile()
        Try
            'set values for saving
            Dim SaveFileDialog1 As SaveFileDialog = New SaveFileDialog()
            SaveFileDialog1.InitialDirectory = "c:\Halifax\Projects\"
            SaveFileDialog1.Filter = "Halifax Selection|*.hfs"
            SaveFileDialog1.Title = "Save a Halifax Selection File"
            SaveFileDialog1.ShowDialog()
            SaveFileName = SaveFileDialog1.FileName

            If (SaveFileName.Length > 0) Then

                ' ### Open the save text file ###
                Dim textwriter As XmlTextWriter = New XmlTextWriter(SaveFileName, Nothing)

                ' ### Prepare the save text file ###
                textwriter.Formatting = Formatting.Indented
                textwriter.Indentation = 3
                textwriter.IndentChar = Char.Parse(" ")

                ' ### Write the data ###
                textwriter.WriteStartDocument()
                Write_to_XML(textwriter, "HFS_File")
                WriteGeneralInfo(textwriter)
                WriteSelectionInputInfo(textwriter)

                ' ### Close the save text file ###
                textwriter.WriteEndDocument()
                textwriter.Close()

                MsgBox("File has been saved")

            End If

        Catch ex As Exception
            MsgBox("SaveProjectToolStripMenuItem_Click")
        End Try


    End Sub

    Public Sub Write_to_XML(ByVal TextWriter As XmlTextWriter, ByVal Parameter As String, ByVal Value As String)
        Try
            TextWriter.WriteStartElement(Parameter)
            TextWriter.WriteString(Value)
        TextWriter.WriteEndElement()

        Catch ex As Exception
            MsgBox("Write_To_XML 1")
        End Try
    End Sub

    Public Sub Write_to_XML(ByVal TextWriter As XmlTextWriter, ByVal Parameter As String)
        Try
            TextWriter.WriteStartElement(Parameter)

        Catch ex As Exception
            MsgBox("Write_To_XML 2")
        End Try
    End Sub

    Public Sub Write_to_XML(ByVal TextWriter As XmlTextWriter)
        Try
            TextWriter.WriteEndElement()

        Catch ex As Exception
            MsgBox("Write_To_XML 3")

        End Try
    End Sub

    Sub ReadSelectionInputInfo(ByVal TextReader As XmlTextReader)
        Try
            Do While TextReader.Read
                If TextReader.Name = "Design_Temperature" Then designtemp = TextReader.ReadString
                If TextReader.Name = "Maximum_Temperature" Then maximumtemp = TextReader.ReadString
                If TextReader.Name = "Ambient_Temperature" Then ambienttemp = TextReader.ReadString
                If TextReader.Name = "Altitude" Then altitude = TextReader.ReadString
                If TextReader.Name = "Relative_Humidity" Then humidity = TextReader.ReadString
                If TextReader.Name = "Atmospheric_Pressure" Then atmospress = TextReader.ReadString
                If TextReader.Name = "Known_Density" Then knowndensity = TextReader.ReadString
                If TextReader.Name = "Flow_Rate" Then flowrate = TextReader.ReadString
                If TextReader.Name = "Inlet_Pressure" Then inletpress = TextReader.ReadString
                If TextReader.Name = "Discharge_Pressure" Then dischpress = TextReader.ReadString
                If TextReader.Name = "Pressure_Rise" Then pressrise = TextReader.ReadString
                If TextReader.Name = "Reserve_Head" Then reshead = TextReader.ReadString
                If TextReader.Name = "Maximum_Speed" Then maxspeed = TextReader.ReadString
            Loop
        Catch ex As Exception
            MsgBox("ReadSelectionInputInfo")
        End Try
    End Sub

    Sub ReadGeneralInfo(ByVal TextReader As XmlTextReader)
        Try
            Do While TextReader.Read
                If TextReader.Name = "Customer" Then Customer = TextReader.ReadString
                If TextReader.Name = "Engineer" Then Engineer = TextReader.ReadString
                If TextReader.Name = "Flow_Units" Then Units(0).UnitSelected = TextReader.ReadString
                If TextReader.Name = "Pressure_Units" Then Units(1).UnitSelected = TextReader.ReadString
                If TextReader.Name = "Temperature_Units" Then Units(2).UnitSelected = TextReader.ReadString
                If TextReader.Name = "Density_Units" Then Units(3).UnitSelected = TextReader.ReadString
                If TextReader.Name = "Power_Units" Then Units(4).UnitSelected = TextReader.ReadString
                If TextReader.Name = "Size_Units" Then Units(5).UnitSelected = TextReader.ReadString
                If TextReader.Name = "Altitude_Units" Then Units(6).UnitSelected = TextReader.ReadString
            Loop

        Catch ex As Exception
            MsgBox("ReadGeneralInfo")
        End Try
    End Sub

    Sub ModifyDatapoints(ByVal fanno As Integer, ByVal count1 As Integer, ByVal fsize As Double, ByVal fspeed As Double, ByVal num As Integer)
        Try
            fsps(fanno, count1) = scalePFSize(fsp(fanno, count1), datafansize(fanno), fsize)
            ftps(fanno, count1) = scalePFSize(ftp(fanno, count1), datafansize(fanno), fsize)
        vols(fanno, count1) = scaleVFSize(vol(fanno, count1), datafansize(fanno), fsize)
            Pows(fanno, count1) = scalePowFSize(Powr(fanno, count1), datafansize(fanno), fsize)
            '-scales for constant volume at each datapoint
            If (num = 1) Then
            fspeed = Val(Frmselectfan.Txtflow.Text) * datafanspeed(fanno) / vols(fanno, count1)
            vols(fanno, count1) = Val(Frmselectfan.Txtflow.Text)
        ElseIf (num = 2) Then
            vols(fanno, count1) = scaleVFSpeed(vols(fanno, count1), datafanspeed(fanno), fspeed)
        ElseIf (num = 3) Then
            ftspeed(fanno, count1) = Val(Frmselectfan.Txtflow.Text) * datafanspeed(fanno) / vols(fanno, count1)
            vols(fanno, count1) = Val(Frmselectfan.Txtflow.Text)
        ElseIf (num = 4) Then
            fspeed = Val(Frmselectfan.Txtfanspeed.Text)
            vols(fanno, count1) = scaleVFSpeed(vols(fanno, count1), datafanspeed(fanno), fspeed)
        End If
        fsps(fanno, count1) = scalePFSpeed(fsps(fanno, count1), datafanspeed(fanno), fspeed)
        ftps(fanno, count1) = scalePFSpeed(ftps(fanno, count1), datafanspeed(fanno), fspeed)
        Pows(fanno, count1) = scalePowFSpeed(Pows(fanno, count1), datafanspeed(fanno), fspeed)
            'count1 = count1 + 1

        Catch ex As Exception
            MsgBox("ModifyDatapoints")
        End Try
    End Sub

    Public Function IntToByteArray(toBeConverted As Integer) As String
        Dim result As Integer = 0
        If (toBeConverted >= 16 And toBeConverted < 32) Then
            result = result + 10000
            toBeConverted = toBeConverted - 16
        End If
        If (toBeConverted >= 8 And toBeConverted < 16) Then
            result = result + 1000
            toBeConverted = toBeConverted - 8
        End If
        If (toBeConverted >= 4 And toBeConverted < 8) Then
            result = result + 100
            toBeConverted = toBeConverted - 4
        End If
        If (toBeConverted >= 2 And toBeConverted < 4) Then
            result = result + 10
            toBeConverted = toBeConverted - 2
        End If
        If (toBeConverted >= 1 And toBeConverted < 2) Then
            result = result + 1
            toBeConverted = toBeConverted - 1
        End If
        Return result.ToString("0000")
    End Function

End Module
