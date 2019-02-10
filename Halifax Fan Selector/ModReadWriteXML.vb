Imports System.Xml
Module ModReadWriteXML
    Sub WriteAllFile(ByVal SaveFileName As String)
        Try
            Dim textwriter As XmlTextWriter = New XmlTextWriter(SaveFileName, Nothing)

            ' ### Prepare the save text file ###
            textwriter.Formatting = Formatting.Indented
            textwriter.Indentation = 3
            textwriter.IndentChar = Char.Parse(" ")

            ' ### Write the data ###
            textwriter.WriteStartDocument()
            Write_to_XML(textwriter, "HFS_File")
            'Dim countflag As Integer = 0
            Do While Flag(countflag) = True
                countflag = countflag + 1
            Loop
            countflag = countflag - 1

            ' #### HeaderInfo
            Write_to_XML(textwriter, "Header_information")
            Write_to_XML(textwriter, "Flag", countflag.ToString)
            If Customer Is Nothing Then Customer = "xxxx"
            If Engineer Is Nothing Then Engineer = "xxxx"
            Write_to_XML(textwriter, "Customer", Customer)
            Write_to_XML(textwriter, "Engineer", Engineer)
            Write_to_XML(textwriter)
            ' #### GeneralInfo
            If countflag >= 0 Then
                Write_to_XML(textwriter, "General_information")
                Write_to_XML(textwriter, "Ambient_Temperature", ambienttemp.ToString)
                Write_to_XML(textwriter, "Altitude", altitude.ToString)
                Write_to_XML(textwriter, "Relative_Humidity", humidity.ToString)
                Write_to_XML(textwriter, "Atmospheric_Pressure", atmospress.ToString)
                Write_to_XML(textwriter, "Calculate_Atmospheric_Pressure", CalcAtmos.ToString)
                Write_to_XML(textwriter, "Frequency", freqHz.ToString)
                Write_to_XML(textwriter, "Flow_Units", Units(0).UnitSelected)
                Write_to_XML(textwriter, "Pressure_Units", Units(1).UnitSelected)
                Write_to_XML(textwriter, "Temperature_Units", Units(2).UnitSelected)
                Write_to_XML(textwriter, "Density_Units", Units(3).UnitSelected)
                Write_to_XML(textwriter, "Power_Units", Units(4).UnitSelected)
                Write_to_XML(textwriter, "Size_Units", Units(5).UnitSelected)
                Write_to_XML(textwriter, "Altitude_Units", Units(6).UnitSelected)
                Write_to_XML(textwriter)
            End If
            ' #### DutyInfo
            If countflag >= 1 Then
                Write_to_XML(textwriter, "Duty_information")
                Write_to_XML(textwriter, "Design_Temperature", designtemp.ToString)
                Write_to_XML(textwriter, "Maximum_Temperature", maximumtemp.ToString)
                Write_to_XML(textwriter, "Known_Density", humidity.ToString)
                Write_to_XML(textwriter, "Flow_Rate", atmospress.ToString)
                Write_to_XML(textwriter, "Inlet_Pressure", Units(0).UnitSelected)
                Write_to_XML(textwriter, "Discharge_Pressure", Units(1).UnitSelected)
                Write_to_XML(textwriter, "Temperature_Units", Units(2).UnitSelected)
                Write_to_XML(textwriter, "Density_Units", Units(3).UnitSelected)
                Write_to_XML(textwriter, "Power_Units", Units(4).UnitSelected)
                Write_to_XML(textwriter, "Size_Units", Units(5).UnitSelected)
                Write_to_XML(textwriter, "Altitude_Units", Units(6).UnitSelected)
                Write_to_XML(textwriter)
            End If
            ' #### FanParameterInfo
            If countflag >= 2 Then
                Write_to_XML(textwriter, "Fan_Parameter_information")
                Write_to_XML(textwriter, "Design_Temperature", designtemp.ToString)
                Write_to_XML(textwriter, "Maximum_Temperature", maximumtemp.ToString)
                Write_to_XML(textwriter, "Ambient_Temperature", ambienttemp.ToString)
                Write_to_XML(textwriter, "Altitude", altitude.ToString)
                Write_to_XML(textwriter, "Relative_Humidity", humidity.ToString)
                Write_to_XML(textwriter, "Atmospheric_Pressure", atmospress.ToString)
                Write_to_XML(textwriter, "Known_Density", knowndensity.ToString)
                Write_to_XML(textwriter, "Flow_Rate", flowrate.ToString)
                Write_to_XML(textwriter, "Inlet_Pressure", inletpress.ToString)
                Write_to_XML(textwriter, "Discharge_Pressure", dischpress.ToString)
                Write_to_XML(textwriter, "Pressure_Rise", pressrise.ToString)
                Write_to_XML(textwriter, "Reserve_Head", reshead.ToString)
                Write_to_XML(textwriter, "Maximum_Speed", maxspeed.ToString)
                Write_to_XML(textwriter)
            End If
            ' #### SelectionInfo
            If countflag >= 3 Then
                Write_to_XML(textwriter, "Selection_information")
                Write_to_XML(textwriter, "Fan_Size", final.fansize.ToString)
                Write_to_XML(textwriter, "Fan_Type", final.fantype.ToString)
                Write_to_XML(textwriter, "Fan_Speed", final.speed.ToString)
                Write_to_XML(textwriter, "Fan_Flow", final.vol.ToString)
                Write_to_XML(textwriter, "Static_Pressure", final.fsp.ToString)
                Write_to_XML(textwriter, "Static_Efficiency", final.fse.ToString)
                Write_to_XML(textwriter, "Total_Pressure", final.ftp.ToString)
                Write_to_XML(textwriter, "Total_Efficiency", final.fte.ToString)
                Write_to_XML(textwriter, "Fan_Power", final.pow.ToString)
                Write_to_XML(textwriter, "Fan_Power2", final.pow2.ToString)
                Write_to_XML(textwriter, "Motor_Power", final.mot.ToString)
                Write_to_XML(textwriter, "Motor_Power2", final.mot2.ToString)
                Write_to_XML(textwriter, "Reserve_Head", final.resHD.ToString)
                Write_to_XML(textwriter, "Volume_D", final.VD.ToString)
                Write_to_XML(textwriter, "Blade_Number", final.BladeNumber.ToString)
                Write_to_XML(textwriter, "Inlet_Diameter", final.inletdia.ToString)
                Write_to_XML(textwriter, "Outlet_Velocity", final.ov.ToString)
                Write_to_XML(textwriter, "Outlet_Area", final.outletarea.ToString)
                Write_to_XML(textwriter, "Outlet_Length", final.outletlen.ToString)
                Write_to_XML(textwriter, "Outlet_Width", final.outletwid.ToString)
                Write_to_XML(textwriter, "Outlet_Diameter", final.outletdia.ToString)
                Write_to_XML(textwriter)
            End If
            ' #### AcousticInfo
            If countflag >= 4 Then
                Write_to_XML(textwriter, "Acoustic_information")
                Write_to_XML(textwriter, "Known_Density", knowndensity.ToString)
                Write_to_XML(textwriter, "Flow_Rate", flowrate.ToString)
                Write_to_XML(textwriter, "Inlet_Pressure", inletpress.ToString)
                Write_to_XML(textwriter, "Discharge_Pressure", dischpress.ToString)
                Write_to_XML(textwriter, "Pressure_Rise", pressrise.ToString)
                Write_to_XML(textwriter, "Reserve_Head", reshead.ToString)
                Write_to_XML(textwriter, "Maximum_Speed", maxspeed.ToString)
                Write_to_XML(textwriter)
            End If

            textwriter.WriteEndDocument()
            textwriter.Close()
        Catch ex As Exception

        End Try
    End Sub

    Sub ReadAllFile(ByVal OpenFileName As String)
        Try
            Dim textReader As XmlTextReader = New XmlTextReader(OpenFileName)
            textReader.MoveToFirstAttribute()

            Do While textReader.Read
                While (textReader.Read())
                    Dim type = textReader.NodeType
                    If (type = XmlNodeType.Element) Then
                        ' #### Header - checked
                        If textReader.Name = "Flag" Then countflag = textReader.ReadString
                        If textReader.Name = "Customer" Then Customer = textReader.ReadString
                        If textReader.Name = "Engineer" Then Engineer = textReader.ReadString
                        ' #### General Info - checked
                        If textReader.Name = "Ambient_Temperature" Then ambienttemp = textReader.ReadString
                        If textReader.Name = "Altitude" Then altitude = textReader.ReadString
                        If textReader.Name = "Relative_Humidity" Then humidity = textReader.ReadString
                        If textReader.Name = "Atmospheric_Pressure" Then atmospress = textReader.ReadString
                        If textReader.Name = "Calculate_Atmospheric_Pressure" Then CalcAtmos = textReader.ReadString
                        If textReader.Name = "Frequency" Then freqHz = textReader.ReadString
                        If textReader.Name = "Flow_Units" Then Units(0).UnitSelected = textReader.ReadString
                        If textReader.Name = "Pressure_Units" Then Units(1).UnitSelected = textReader.ReadString
                        If textReader.Name = "Temperature_Units" Then Units(2).UnitSelected = textReader.ReadString
                        If textReader.Name = "Density_Units" Then Units(3).UnitSelected = textReader.ReadString
                        If textReader.Name = "Power_Units" Then Units(4).UnitSelected = textReader.ReadString
                        If textReader.Name = "Size_Units" Then Units(5).UnitSelected = textReader.ReadString
                        If textReader.Name = "Altitude_Units" Then Units(6).UnitSelected = textReader.ReadString
                        ' #### Duty Info
                        'If TextReader.Name = "Ambient_Temperature" Then ambienttemp = TextReader.ReadString
                        'If TextReader.Name = "Altitude" Then altitude = TextReader.ReadString
                        'If TextReader.Name = "Relative_Humidity" Then humidity = TextReader.ReadString
                        'If TextReader.Name = "Atmospheric_Pressure" Then atmospress = TextReader.ReadString
                        'If TextReader.Name = "Calculate_Atmospheric_Pressure" Then CalcAtmos = TextReader.ReadString
                        'If TextReader.Name = "Frequency" Then freqHz = TextReader.ReadString
                        'If TextReader.Name = "Flow_Units" Then Units(0).UnitSelected = TextReader.ReadString
                        'If TextReader.Name = "Pressure_Units" Then Units(1).UnitSelected = TextReader.ReadString
                        'If TextReader.Name = "Temperature_Units" Then Units(2).UnitSelected = TextReader.ReadString
                        'If TextReader.Name = "Density_Units" Then Units(3).UnitSelected = TextReader.ReadString
                        'If TextReader.Name = "Power_Units" Then Units(4).UnitSelected = TextReader.ReadString
                        'If TextReader.Name = "Size_Units" Then Units(5).UnitSelected = TextReader.ReadString
                        'If TextReader.Name = "Altitude_Units" Then Units(6).UnitSelected = TextReader.ReadString
                        '' #### Fan Parameters
                        'If TextReader.Name = "Design_Temperature" Then designtemp = TextReader.ReadString
                        'If TextReader.Name = "Maximum_Temperature" Then maximumtemp = TextReader.ReadString
                        'If TextReader.Name = "Ambient_Temperature" Then ambienttemp = TextReader.ReadString
                        'If TextReader.Name = "Altitude" Then altitude = TextReader.ReadString
                        'If TextReader.Name = "Relative_Humidity" Then humidity = TextReader.ReadString
                        'If TextReader.Name = "Atmospheric_Pressure" Then atmospress = TextReader.ReadString
                        'If TextReader.Name = "Known_Density" Then knowndensity = TextReader.ReadString
                        'If TextReader.Name = "Flow_Rate" Then flowrate = TextReader.ReadString
                        'If TextReader.Name = "Inlet_Pressure" Then inletpress = TextReader.ReadString
                        'If TextReader.Name = "Discharge_Pressure" Then dischpress = TextReader.ReadString
                        'If TextReader.Name = "Pressure_Rise" Then pressrise = TextReader.ReadString
                        'If TextReader.Name = "Reserve_Head" Then reshead = TextReader.ReadString
                        'If TextReader.Name = "Maximum_Speed" Then maxspeed = TextReader.ReadString
                        ' #### Selection - checked
                        If textReader.Name = "Fan_Size" Then final.fansize = textReader.ReadString
                        If textReader.Name = "Fan_Type" Then final.fantype = textReader.ReadString
                        If textReader.Name = "Fan_Speed" Then final.speed = textReader.ReadString
                        If textReader.Name = "Fan_Flow" Then final.vol = textReader.ReadString
                        If textReader.Name = "Static_Pressure" Then final.fsp = textReader.ReadString
                        If textReader.Name = "Static_Efficiency" Then final.fse = textReader.ReadString
                        If textReader.Name = "Total_Pressure" Then final.ftp = textReader.ReadString
                        If textReader.Name = "Total_Efficiency" Then final.fte = textReader.ReadString
                        If textReader.Name = "Fan_Power" Then final.pow = textReader.ReadString
                        If textReader.Name = "Fan_Power2" Then final.pow2 = textReader.ReadString
                        If textReader.Name = "Motor_Power" Then final.mot = textReader.ReadString
                        If textReader.Name = "Motor_Power2" Then final.mot2 = textReader.ReadString
                        If textReader.Name = "Reserve_Head" Then final.resHD = textReader.ReadString
                        If textReader.Name = "Volume_D" Then final.VD = textReader.ReadString
                        If textReader.Name = "Blade_Number" Then final.BladeNumber = textReader.ReadString
                        If textReader.Name = "Inlet_Diameter" Then final.inletdia = textReader.ReadString
                        If textReader.Name = "Outlet_Velocity" Then final.ov = textReader.ReadString
                        If textReader.Name = "Outlet_Area" Then final.outletarea = textReader.ReadString
                        If textReader.Name = "Outlet_Length" Then final.outletlen = textReader.ReadString
                        If textReader.Name = "Outlet_Width" Then final.outletwid = textReader.ReadString
                        If textReader.Name = "Outlet_Diameter" Then final.outletdia = textReader.ReadString
                        '' ##### Acoustics
                        'If TextReader.Name = "Design_Temperature" Then designtemp = TextReader.ReadString
                        'If TextReader.Name = "Maximum_Temperature" Then maximumtemp = TextReader.ReadString
                        'If TextReader.Name = "Ambient_Temperature" Then ambienttemp = TextReader.ReadString
                        'If TextReader.Name = "Altitude" Then altitude = TextReader.ReadString
                        'If TextReader.Name = "Relative_Humidity" Then humidity = TextReader.ReadString
                        'If TextReader.Name = "Atmospheric_Pressure" Then atmospress = TextReader.ReadString
                        'If TextReader.Name = "Known_Density" Then knowndensity = TextReader.ReadString
                        'If TextReader.Name = "Flow_Rate" Then flowrate = TextReader.ReadString
                        'If TextReader.Name = "Inlet_Pressure" Then inletpress = TextReader.ReadString
                        'If TextReader.Name = "Discharge_Pressure" Then dischpress = TextReader.ReadString
                        'If TextReader.Name = "Pressure_Rise" Then pressrise = TextReader.ReadString
                        'If TextReader.Name = "Reserve_Head" Then reshead = TextReader.ReadString
                        'If TextReader.Name = "Maximum_Speed" Then maxspeed = TextReader.ReadString
                    End If
                End While
            Loop
            textReader.Close()
            'MsgBox("header " + countflag.ToString)
        Catch ex As Exception
            ErrorMessage(ex, 5511)
        End Try
    End Sub

    '################################################################################################

    Public Sub Write_to_XML(ByVal TextWriter As XmlTextWriter, ByVal Parameter As String, ByVal Value As String)
        Try
            TextWriter.WriteStartElement(Parameter)
            TextWriter.WriteString(Value)
            TextWriter.WriteEndElement()
        Catch ex As Exception
            ErrorMessage(ex, 5507)
        End Try
    End Sub

    Public Sub Write_to_XML(ByVal TextWriter As XmlTextWriter, ByVal Parameter As String)
        Try
            TextWriter.WriteStartElement(Parameter)
        Catch ex As Exception
            ErrorMessage(ex, 5508)
        End Try
    End Sub

    Public Sub Write_to_XML(ByVal TextWriter As XmlTextWriter)
        Try
            TextWriter.WriteEndElement()
        Catch ex As Exception
            ErrorMessage(ex, 5509)
        End Try
    End Sub
End Module
