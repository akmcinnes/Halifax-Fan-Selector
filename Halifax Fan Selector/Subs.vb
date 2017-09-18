Imports System.Xml
Module Subs
    Public Sub Initialize()
        Try
            'flow units 
            Units(0).UnitName(0) = "m³/hr"
        Units(0).UnitConversion(0) = 1.0 / 3600.0
        Units(0).UnitPlaces(0) = 0
        Units(0).UnitName(1) = "m³/min"
        Units(0).UnitConversion(1) = 1.0 / 60.0
        Units(0).UnitPlaces(1) = 1
        Units(0).UnitName(2) = "m³/sec"
        Units(0).UnitConversion(2) = 1.0
        Units(0).UnitPlaces(2) = 2
        Units(0).UnitName(3) = "cfm"
        Units(0).UnitConversion(3) = 0.00047192
        Units(0).UnitPlaces(3) = 0
        Units(0).UnitName(4) = "kg/hr"
        Units(0).UnitPlaces(4) = 0
        Units(0).UnitName(5) = "lb/hr"
        Units(0).UnitPlaces(5) = 0
        Units(0).UnitDefault = 0
        'FlowType = 0
        colvol = 9

        'pressure units 
        Units(1).UnitName(0) = "Pa"
        Units(1).UnitConversion(0) = 1.0
        Units(1).UnitPlaces(0) = 0
        Units(1).UnitName(1) = "InsWG"
        Units(1).UnitConversion(1) = 249.09
        Units(1).UnitPlaces(1) = 1
        Units(1).UnitName(2) = "mmWG"
        Units(1).UnitConversion(2) = 9.81
        Units(1).UnitPlaces(2) = 0
        Units(1).UnitName(3) = "mBar"
        Units(1).UnitConversion(3) = 100.0
        Units(1).UnitPlaces(3) = 2
        Units(1).UnitDefault = 0
        fspcol = 13
        ftpcol = 14
        'atmos = 101389

        'temperature units
        Units(2).UnitName(0) = "°C"
        Units(2).UnitConversion(0) = 1.0
        Units(2).UnitPlaces(0) = 1
        Units(2).UnitName(1) = "°F"
        Units(2).UnitConversion(1) = 1.0
        Units(2).UnitPlaces(1) = 1
        Units(2).UnitDefault = 0

        'density units
        Units(3).UnitName(0) = "kg/m³"
        Units(3).UnitConversion(0) = 1.0
        Units(3).UnitPlaces(0) = 3
        Units(3).UnitName(1) = "lbs/ft³"
        Units(3).UnitConversion(1) = 1.0 / 16.02
        Units(3).UnitPlaces(1) = 4
        Units(3).UnitDefault = 0

        'power units
        Units(4).UnitName(0) = "kW"
        Units(4).UnitConversion(0) = 1.0
        Units(4).UnitName(1) = "HP(nema)"
        Units(4).UnitConversion(1) = 1.0 / 0.746
        Units(4).UnitDefault = 0
        colpow = 8

        'length units
        Units(5).UnitName(0) = "mm"
        Units(5).UnitConversion(0) = 1.0
        Units(5).UnitName(1) = "ins"
        Units(5).UnitConversion(1) = 1 / 25.4
        Units(5).UnitDefault = 0

        'altitude units
        Units(6).UnitName(0) = "m"
        Units(6).UnitConversion(0) = 1.0
        Units(6).UnitName(1) = "ft"
        Units(6).UnitConversion(1) = 1 / 0.3048
        Units(6).UnitDefault = 0

        'velocity units
        Units(7).UnitName(0) = "m/s"
        Units(7).UnitConversion(0) = 1.0
        Units(7).UnitName(1) = "ft/min"
        Units(7).UnitConversion(1) = 1 / 0.3048
        Units(7).UnitDefault = 0

        If NewProject = True Then
            For i = 0 To No_of_units
                Units(i).UnitSelected = Units(i).UnitDefault
            Next
        End If


        'populating Pressure Type
        '        Frmselectfan.cmbPressType.AddItem "Fan Static"
        '        Frmselectfan.cmbPressType.AddItem "Fan Total"
        '        DensMult = 1

        NextSpeed = "2 Pole"
        RunTemp = 20
        For II = 0 To 50 - 1
            Widthratios(II) = 1
        Next II
        Customer = ""
        FileSaved = False
        designtemp = 20.0
        maximumtemp = 20.0
        ambienttemp = 20.0
        altitude = 0.0
        humidity = 0.0
        atmospress = 101325.0
        knowndensity = 1.205
        calcdensity = 0.0
        flowrate = 180000.0
        reshead = 5.0
        inletpress = 0.0
        dischpress = 0.0
        pressrise = 4000.0
        maxspeed = 4000.0
        fansize = 0.0

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

        Catch ex As Exception
            MsgBox("ReadSelectionInputInfo")
        End Try
    End Sub

    Sub ReadGeneralInfo(ByVal TextReader As XmlTextReader)
        Try
            If TextReader.Name = "Customer" Then Customer = TextReader.ReadString
            If TextReader.Name = "Engineer" Then Engineer = TextReader.ReadString
        If TextReader.Name = "Flow_Units" Then Units(0).UnitSelected = TextReader.ReadString
        If TextReader.Name = "Pressure_Units" Then Units(1).UnitSelected = TextReader.ReadString
        If TextReader.Name = "Temperature_Units" Then Units(2).UnitSelected = TextReader.ReadString
        If TextReader.Name = "Density_Units" Then Units(3).UnitSelected = TextReader.ReadString
        If TextReader.Name = "Power_Units" Then Units(4).UnitSelected = TextReader.ReadString
        If TextReader.Name = "Size_Units" Then Units(5).UnitSelected = TextReader.ReadString
        If TextReader.Name = "Altitude_Units" Then Units(6).UnitSelected = TextReader.ReadString

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

End Module
