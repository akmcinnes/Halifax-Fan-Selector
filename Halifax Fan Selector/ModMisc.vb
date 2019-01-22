Imports System.Xml
Module ModMisc
    Public Sub Initialize(Set1stTime As Boolean)
        Try
            If Set1stTime = True Then
                SetUnitStructure()

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
                'If UserName.ToLower.Contains("akm") = True Then
                If StartArg.ToLower.Contains("-dev") = True Then
                    designtemp = 20.0
                    maximumtemp = 20.0
                    ambienttemp = 20.0
                    atmospress = 101325.0
                    'knowndensity = 1.2
                    'flowrate = 10000.0
                    'pressrise = 4000.0
                    knowndensity = 1.2
                    flowrate = 10000.0
                    'pressrise = 4000.0
                    maxspeed = 3600.0
                End If
            End If

        Catch ex As Exception
            '            MsgBox("Initialize")
            ErrorMessage(ex, 5501)
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
            '            MsgBox("WriteGeneralInfo")
            ErrorMessage(ex, 5502)
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
            '            MsgBox("WriteSelectionInputInfo")
            ErrorMessage(ex, 5503)
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
            'MsgBox("WriteSelectionOutputInfo")
            ErrorMessage(ex, 5504)
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
            'MsgBox("WriteNoisetInfo")
            ErrorMessage(ex, 5505)
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
            'MsgBox("SaveProjectToolStripMenuItem_Click")
            ErrorMessage(ex, 5506)
        End Try
    End Sub

    Public Sub Write_to_XML(ByVal TextWriter As XmlTextWriter, ByVal Parameter As String, ByVal Value As String)
        Try
            TextWriter.WriteStartElement(Parameter)
            TextWriter.WriteString(Value)
            TextWriter.WriteEndElement()
        Catch ex As Exception
            'MsgBox("Write_To_XML 1")
            ErrorMessage(ex, 5507)
        End Try
    End Sub

    Public Sub Write_to_XML(ByVal TextWriter As XmlTextWriter, ByVal Parameter As String)
        Try
            TextWriter.WriteStartElement(Parameter)
        Catch ex As Exception
            'MsgBox("Write_To_XML 2")
            ErrorMessage(ex, 5508)
        End Try
    End Sub

    Public Sub Write_to_XML(ByVal TextWriter As XmlTextWriter)
        Try
            TextWriter.WriteEndElement()
        Catch ex As Exception
            'MsgBox("Write_To_XML 3")
            ErrorMessage(ex, 5509)
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
            'MsgBox("ReadSelectionInputInfo")
            ErrorMessage(ex, 5510)
        End Try
    End Sub

    Sub ReadGeneralInfo(ByVal TextReader As XmlTextReader)
        Try
            Do While TextReader.Read
                If TextReader.Name = "Customer" Then Customer = TextReader.ReadString
                If TextReader.Name = "Engineer" Then Engineer = TextReader.ReadString If TextReader.Name = "Flow_Units" Then Units(0).UnitSelected = TextReader.ReadString
                If TextReader.Name = "Pressure_Units" Then Units(1).UnitSelected = TextReader.ReadString
                If TextReader.Name = "Temperature_Units" Then Units(2).UnitSelected = TextReader.ReadString
                If TextReader.Name = "Density_Units" Then Units(3).UnitSelected = TextReader.ReadString
                If TextReader.Name = "Power_Units" Then Units(4).UnitSelected = TextReader.ReadString
                If TextReader.Name = "Size_Units" Then Units(5).UnitSelected = TextReader.ReadString
                If TextReader.Name = "Altitude_Units" Then Units(6).UnitSelected = TextReader.ReadString
            Loop

        Catch ex As Exception
            'MsgBox("ReadGeneralInfo")
            ErrorMessage(ex, 5511)
        End Try
    End Sub

    Sub ModifyDatapoints(ByVal fanno As Integer, ByVal count1 As Integer, ByVal fsize As Double, ByVal fspeed As Double, ByVal num As Integer)
        Try
            fsps(fanno, count1) = ScalePFSize(fsp(fanno, count1), datafansize(fanno), fsize)
            ftps(fanno, count1) = ScalePFSize(ftp(fanno, count1), datafansize(fanno), fsize)
            vols(fanno, count1) = ScaleVFSize(vol(fanno, count1), datafansize(fanno), fsize)
            Pows(fanno, count1) = ScalePowFSize(Powr(fanno, count1), datafansize(fanno), fsize)
            '-scales for constant volume at each datapoint
            If (num = 1) Then
                fspeed = Val(Frmselectfan.Txtflow.Text) * datafanspeed(fanno) / vols(fanno, count1)
                vols(fanno, count1) = Val(Frmselectfan.Txtflow.Text)
            ElseIf (num = 2) Then
                vols(fanno, count1) = ScaleVFSpeed(vols(fanno, count1), datafanspeed(fanno), fspeed)
            ElseIf (num = 3) Then
                ftspeed(fanno, count1) = Val(Frmselectfan.Txtflow.Text) * datafanspeed(fanno) / vols(fanno, count1)
                vols(fanno, count1) = Val(Frmselectfan.Txtflow.Text)
            ElseIf (num = 4) Then
                fspeed = Val(Frmselectfan.Txtfanspeed.Text)
                vols(fanno, count1) = ScaleVFSpeed(vols(fanno, count1), datafanspeed(fanno), fspeed)
            End If
            fsps(fanno, count1) = ScalePFSpeed(fsps(fanno, count1), datafanspeed(fanno), fspeed)
            ftps(fanno, count1) = ScalePFSpeed(ftps(fanno, count1), datafanspeed(fanno), fspeed)
            Pows(fanno, count1) = ScalePowFSpeed(Pows(fanno, count1), datafanspeed(fanno), fspeed)
            'count1 = count1 + 1

        Catch ex As Exception
            'MsgBox("ModifyDatapoints")
            ErrorMessage(ex, 5512)
        End Try
    End Sub

    Public Function IntToByteArray(toBeConverted As Integer) As String
        Dim result As Integer = 0
        Try
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

        Catch ex As Exception
            ErrorMessage(ex, 5513)
            Return result.ToString
        End Try
    End Function

    Public Sub Yellow(Ctrl As System.Windows.Forms.TextBox, Optional MinValue As Double = 0.0)
        Try
            '' ### Check if an information is missing ###
            'For Each TP As TabPage In Me.TabControl1.Controls
            '    For Each Ctrl As Control In TP.Controls
            '        If TypeOf Ctrl Is System.Windows.Forms.TextBox Then
            '            Ctrl.BackColor = System.Drawing.Color.White
            '            If Ctrl.Text = "0" Then
            '                Ctrl.BackColor = System.Drawing.Color.Yellow
            '                'Temporary.A = 1
            '                move_on = False
            '            End If
            '        End If
            '        If TypeOf Ctrl Is System.Windows.Forms.ComboBox Then
            '            Ctrl.BackColor = System.Drawing.Color.White
            '            If Ctrl.Text = "0" Then
            '                Ctrl.BackColor = System.Drawing.Color.Yellow
            '                'Temporary.A = 1
            '                move_on = False
            '            End If
            '        End If
            '    Next
            'Next

            Dim val As Double
            'If Ctrl.Text.All(AddressOf Char.IsLetter) Then
            If Double.TryParse(Ctrl.Text, val) = False Then
                Ctrl.BackColor = Color.LightYellow
                Ctrl.Text = ""
                move_on = False
                'ElseIf Ctrl.Text.Contains(",") Then
                '    Ctrl.BackColor = Color.LightYellow
                '    Ctrl.Text = ""
                '    move_on = False
                'ElseIf Len(Ctrl.Text) <= 0 Then
                '    Ctrl.BackColor = Color.LightYellow
                '    Ctrl.Text = ""
                '    move_on = False
            ElseIf CDbl(Ctrl.Text) <= MinValue Then
                Ctrl.BackColor = Color.LightYellow
                Ctrl.Text = ""
                move_on = False
            Else
                Ctrl.BackColor = Color.White
                'Dim asdf As Double = "aqaqa"
            End If
        Catch ex As Exception
            ErrorMessage(ex, 5514)
        End Try
    End Sub
End Module
