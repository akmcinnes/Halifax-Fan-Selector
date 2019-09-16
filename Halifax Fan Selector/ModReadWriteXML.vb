﻿Imports System.Xml
Module ModReadWriteXML
    'subroutines
    'WriteAllFile
    'writes all fan details to xml file

    'ReadAllFile
    'reads all fan details from xml file

    'Write_to_XML (3 overloads)
    'writes line to xml file (start of node, info & end of node)

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
            Do While Flag(countflag) = True
                countflag = countflag + 1
            Loop
            countflag = countflag - 1
            If countflag = 3 And final.fansize < 1 Then
                countflag = countflag - 1
            End If

            ' #### HeaderInfo
            Write_to_XML(textwriter, "Header_information")
            Write_to_XML(textwriter, "Version", version_number)
            Write_to_XML(textwriter, "Flag", countflag.ToString)
            If Customer Is Nothing Then Customer = "xxxx"
            If Engineer Is Nothing Then Engineer = username '"xxxx"
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
                Write_to_XML(textwriter, "Velocity_Units", Units(7).UnitSelected)
                Write_to_XML(textwriter)
            End If
            ' #### DutyInfo
            If countflag >= 1 Then
                Write_to_XML(textwriter, "Duty_information")
                Write_to_XML(textwriter, "Design_Temperature", designtemp.ToString)
                Write_to_XML(textwriter, "Flow_Rate", flowrate.ToString)
                Write_to_XML(textwriter, "Pressure_Type", PresType.ToString)
                Write_to_XML(textwriter, "Inlet_Pressure", inletpress.ToString)
                Write_to_XML(textwriter, "Pressure_Rise", pressrise.ToString)
                Write_to_XML(textwriter, "Reserve_Head", reshead.ToString)
                Write_to_XML(textwriter, "Inlet_Density", knowndensity.ToString)
                Write_to_XML(textwriter, "Density_Type", CalculatedDensity.ToString) '???????
                Write_to_XML(textwriter)
            End If
            ' #### FanParameterInfo
            If countflag >= 2 Then
                Write_to_XML(textwriter, "Fan_Parameter_information")
                Write_to_XML(textwriter, "Maximum_Speed", maxspeed.ToString)
                Write_to_XML(textwriter, "Entered_Fan_Speed", Frmselectfan.Txtfanspeed.Text)
                Write_to_XML(textwriter, "Fan_Size", fansize.ToString)
                Write_to_XML(textwriter, "Entered_Fan_Size", Frmselectfan.Txtfansize.Text)
                Write_to_XML(textwriter, "Double_Inlet", SelectDIDW.ToString)
                Write_to_XML(textwriter, "VSD", Frmselectfan.OptAnySpeed.Checked.ToString)
                Write_to_XML(textwriter, "Fixed_Speed", Frmselectfan.OptFixedSpeed.Checked.ToString)
                Write_to_XML(textwriter, "Poles_2", Frmselectfan.Opt2Pole.Checked.ToString)
                Write_to_XML(textwriter, "Poles_4", Frmselectfan.Opt4Pole.Checked.ToString)
                Write_to_XML(textwriter, "Poles_6", Frmselectfan.Opt6Pole.Checked.ToString)
                Write_to_XML(textwriter, "Poles_8", Frmselectfan.Opt8Pole.Checked.ToString)
                Write_to_XML(textwriter, "Poles_10", Frmselectfan.Opt10Pole.Checked.ToString)
                Write_to_XML(textwriter, "Poles_12", Frmselectfan.Opt12Pole.Checked.ToString)
                Write_to_XML(textwriter, "Blade_Wide", Frmselectfan.chkWide.Checked.ToString)
                Write_to_XML(textwriter, "Blade_Medium", Frmselectfan.chkMedium.Checked.ToString)
                Write_to_XML(textwriter, "Blade_Narrow", Frmselectfan.chkNarrow.Checked.ToString)
                Write_to_XML(textwriter, "Blade_High_Pressure", Frmselectfan.chkHighPressure.Checked.ToString)
                Write_to_XML(textwriter, "Blade_Curve", Frmselectfan.ChkCurveBlade.Checked.ToString)
                Write_to_XML(textwriter, "Blade_Incline", Frmselectfan.ChkInclineBlade.Checked.ToString)
                Write_to_XML(textwriter, "Blade_Other", Frmselectfan.ChkOtherFanType.Checked.ToString)
                Write_to_XML(textwriter, "Blade_Plastic", Frmselectfan.ChkPlasticFan.Checked.ToString)
                Write_to_XML(textwriter, "Blade_Paddle", Frmselectfan.chkPaddleBlade.Checked.ToString)
                Write_to_XML(textwriter, "Blade_Radial", Frmselectfan.chkRadialBlade.Checked.ToString)
                Write_to_XML(textwriter, "Blade_All", Frmselectfan.chkAllBlades.Checked.ToString)
                'If Frmselectfan.lstFanDesigns.SelectedItem IsNot "" Then
                Write_to_XML(textwriter, "Selected_Design", Frmselectfan.lstFanDesigns.SelectedIndex.ToString)
                'Else
                '    Write_to_XML(textwriter, "Selected_Design", " ")
                'End If
                'Dim iselfan As String
                'iselfan = Frmselectfan.lstFanDesigns.SelectedItem
                Write_to_XML(textwriter)
            End If
                ' #### SelectionInfo
                If countflag >= 3 Then
                Write_to_XML(textwriter, "Selection_information")
                Write_to_XML(textwriter, "SI_Fan_Size", final.fansize.ToString)
                Write_to_XML(textwriter, "SI_Fan_Type", final.fantype.ToString)
                Write_to_XML(textwriter, "SI_Fan_Type_Description", final.fantypename.ToString)
                Write_to_XML(textwriter, "SI_Fan_Speed", final.speed.ToString)
                Write_to_XML(textwriter, "SI_Fan_Flow", final.vol.ToString)
                Write_to_XML(textwriter, "SI_Static_Pressure", final.fsp.ToString)
                Write_to_XML(textwriter, "SI_Static_Efficiency", final.fse.ToString)
                Write_to_XML(textwriter, "SI_Total_Pressure", final.ftp.ToString)
                Write_to_XML(textwriter, "SI_Total_Efficiency", final.fte.ToString)
                Write_to_XML(textwriter, "SI_Fan_Power", final.pow.ToString)
                Write_to_XML(textwriter, "SI_Fan_Power2", final.pow2.ToString)
                Write_to_XML(textwriter, "SI_Motor_Power", final.mot.ToString)
                Write_to_XML(textwriter, "SI_Motor_Power2", final.mot2.ToString)
                Write_to_XML(textwriter, "SI_Reserve_Head", final.resHD.ToString)
                Write_to_XML(textwriter, "SI_Volume_D", final.VD.ToString)
                Write_to_XML(textwriter, "SI_Blade_Number", final.BladeNumber.ToString)
                Write_to_XML(textwriter, "SI_Inlet_Diameter", final.inletdia.ToString)
                Write_to_XML(textwriter, "SI_Outlet_Velocity", final.ov.ToString)
                Write_to_XML(textwriter, "SI_Outlet_Area", final.outletarea.ToString)
                Write_to_XML(textwriter, "SI_Outlet_Length", final.outletlen.ToString)
                Write_to_XML(textwriter, "SI_Outlet_Width", final.outletwid.ToString)
                Write_to_XML(textwriter, "SI_Outlet_Diameter", final.outletdia.ToString)
                Write_to_XML(textwriter, "SI_Width_Factor", final.widthfactor.ToString)
                Write_to_XML(textwriter)
            End If
            ' #### AcousticInfo
            If countflag >= 4 Then
                Dim i As Integer
                Write_to_XML(textwriter, "Acoustic_information")
                'IDSPL
                For i = 0 To 7
                    Write_to_XML(textwriter, "IDSPL_" + i.ToString, IDSPL(i).ToString)
                Next i
                Write_to_XML(textwriter, "spl2", spl2.ToString)
                Write_to_XML(textwriter, "bospl2", bospl2.ToString)
                Write_to_XML(textwriter, "bospl1M2", bospl1M2.ToString)
                For i = 0 To 7
                    Write_to_XML(textwriter, "Ascale_" + i.ToString, Ascale(i).ToString)
                Next i
                Write_to_XML(textwriter, "NCoverall", NCoverall.ToString)
                For i = 0 To 7
                    Write_to_XML(textwriter, "INascale_" + i.ToString, INascale(i).ToString)
                Next i
                Write_to_XML(textwriter, "inNCoverall", inNCoverall.ToString)
                For i = 0 To 7
                    Write_to_XML(textwriter, "OUTascale_" + i.ToString, OUTascale(i).ToString)
                Next i
                Write_to_XML(textwriter, "OUTNCoverall", OUTNCoverall.ToString)
                Write_to_XML(textwriter, "Bearing_Noise", BRGnoise.ToString)
                Write_to_XML(textwriter, "Motor_Noise", MTRnoise.ToString)
                Write_to_XML(textwriter, "Blade_Passing_Frequency", BPfreq.ToString)
                Write_to_XML(textwriter, "Include_Duct_Noise", InclDuctNoise.ToString)
                Write_to_XML(textwriter, "Include_Open_Inlet_Noise", InclOpenInletNoise.ToString)
                Write_to_XML(textwriter, "Include_Open_Outlet_Noise", InclOpenOutletNoise.ToString)
                Write_to_XML(textwriter, "Include_Bearing_Noise", InclBrgNoise.ToString)
                Write_to_XML(textwriter, "Include_Motor_Noise", InclMotorNoise.ToString)
                Write_to_XML(textwriter)
            End If
            textwriter.WriteEndDocument()
            textwriter.Close()
        Catch ex As Exception
            ErrorMessage(ex, 6501)
        End Try
    End Sub

    Sub ReadAllFile(ByVal OpenFileName As String)
        Dim textReader As XmlTextReader = New XmlTextReader(OpenFileName)
        Try
            textReader.MoveToFirstAttribute()
            Do While textReader.Read
                While (textReader.Read())
                    Dim type = textReader.NodeType
                    If (type = XmlNodeType.Element) Then
                        ' #### Header - checked
                        If textReader.Name = "Flag" Then countflag = CInt(textReader.ReadString)
                        If textReader.Name = "Customer" Then Customer = textReader.ReadString
                        If textReader.Name = "Engineer" Then Engineer = textReader.ReadString
                        ' #### General Info - checked
                        If textReader.Name = "Ambient_Temperature" Then ambienttemp = CDbl(textReader.ReadString)
                        If textReader.Name = "Altitude" Then altitude = CDbl(textReader.ReadString)
                        If textReader.Name = "Relative_Humidity" Then humidity = CDbl(textReader.ReadString)
                        If textReader.Name = "Atmospheric_Pressure" Then atmospress = CDbl(textReader.ReadString)
                        If textReader.Name = "Calculate_Atmospheric_Pressure" Then CalcAtmos = CBool(textReader.ReadString)
                        If textReader.Name = "Frequency" Then freqHz = CInt(textReader.ReadString)
                        If textReader.Name = "Flow_Units" Then Units(0).UnitSelected = CInt(textReader.ReadString)
                        If textReader.Name = "Pressure_Units" Then Units(1).UnitSelected = CInt(textReader.ReadString)
                        If textReader.Name = "Temperature_Units" Then Units(2).UnitSelected = CInt(textReader.ReadString)
                        If textReader.Name = "Density_Units" Then Units(3).UnitSelected = CInt(textReader.ReadString)
                        If textReader.Name = "Power_Units" Then Units(4).UnitSelected = CInt(textReader.ReadString)
                        If textReader.Name = "Size_Units" Then Units(5).UnitSelected = CInt(textReader.ReadString)
                        If textReader.Name = "Altitude_Units" Then Units(6).UnitSelected = CInt(textReader.ReadString)
                        If textReader.Name = "Velocity_Units" Then Units(7).UnitSelected = CInt(textReader.ReadString)
                        '' #### Fan Parameters
                        If textReader.Name = "Design_Temperature" Then designtemp = CDbl(textReader.ReadString)
                        If textReader.Name = "Flow_Rate" Then flowrate = CDbl(textReader.ReadString)
                        If textReader.Name = "Pressure_Type" Then PresType = CInt(textReader.ReadString)
                        If textReader.Name = "Inlet_Pressure" Then inletpress = CDbl(textReader.ReadString)
                        If textReader.Name = "Pressure_Rise" Then pressrise = CDbl(textReader.ReadString)
                        If textReader.Name = "Reserve_Head" Then reshead = CDbl(textReader.ReadString)
                        If textReader.Name = "Inlet_Density" Then knowndensity = CDbl(textReader.ReadString)
                        If textReader.Name = "Density_Type" Then CalculatedDensity = CDbl(textReader.ReadString)
                        ' #### FanParameterInfo
                        If textReader.Name = "Maximum_Speed" Then maxspeed = CDbl(textReader.ReadString)
                        If textReader.Name = "Entered_Fan_Speed" Then Frmselectfan.Txtfanspeed.Text = textReader.ReadString
                        If textReader.Name = "Fan_Size" Then fansize = CDbl(textReader.ReadString)
                        If textReader.Name = "Entered_Fan_Size" Then Frmselectfan.Txtfansize.Text = textReader.ReadString
                        If textReader.Name = "Double_Inlet" Then SelectDIDW = CBool(textReader.ReadString)
                        If textReader.Name = "VSD" Then Frmselectfan.OptAnySpeed.Checked = CBool(textReader.ReadString)
                        If textReader.Name = "Fixed_Speed" Then Frmselectfan.OptFixedSpeed.Checked = CBool(textReader.ReadString)
                        If textReader.Name = "Poles_2" Then Frmselectfan.Opt2Pole.Checked = CBool(textReader.ReadString)
                        If textReader.Name = "Poles_4" Then Frmselectfan.Opt4Pole.Checked = CBool(textReader.ReadString)
                        If textReader.Name = "Poles_6" Then Frmselectfan.Opt6Pole.Checked = CBool(textReader.ReadString)
                        If textReader.Name = "Poles_8" Then Frmselectfan.Opt8Pole.Checked = CBool(textReader.ReadString)
                        If textReader.Name = "Poles_10" Then Frmselectfan.Opt10Pole.Checked = CBool(textReader.ReadString)
                        If textReader.Name = "Poles_12" Then Frmselectfan.Opt12Pole.Checked = CBool(textReader.ReadString)
                        If textReader.Name = "Blade_Wide" Then Frmselectfan.chkWide.Checked = CBool(textReader.ReadString)
                        If textReader.Name = "Blade_Medium" Then Frmselectfan.chkMedium.Checked = CBool(textReader.ReadString)
                        If textReader.Name = "Blade_Narrow" Then Frmselectfan.chkNarrow.Checked = CBool(textReader.ReadString)
                        If textReader.Name = "Blade_High_Pressure" Then Frmselectfan.chkHighPressure.Checked = CBool(textReader.ReadString)
                        If textReader.Name = "Blade_Curve" Then Frmselectfan.ChkCurveBlade.Checked = CBool(textReader.ReadString)
                        If textReader.Name = "Blade_Incline" Then Frmselectfan.ChkInclineBlade.Checked = CBool(textReader.ReadString)
                        If textReader.Name = "Blade_Other" Then Frmselectfan.ChkOtherFanType.Checked = CBool(textReader.ReadString)
                        If textReader.Name = "Blade_Plastic" Then Frmselectfan.ChkPlasticFan.Checked = CBool(textReader.ReadString)
                        If textReader.Name = "Blade_Paddle" Then Frmselectfan.chkPaddleBlade.Checked = CBool(textReader.ReadString)
                        If textReader.Name = "Blade_Radial" Then Frmselectfan.chkRadialBlade.Checked = CBool(textReader.ReadString)
                        If textReader.Name = "Blade_All" Then Frmselectfan.chkAllBlades.Checked = CBool(textReader.ReadString)
                        If textReader.Name = "Selected_Design" Then Frmselectfan.lstFanDesigns.SelectedItem = textReader.ReadString

                        ' #### Selection - checked
                        If textReader.Name = "SI_Fan_Size" Then final.fansize = CDbl(textReader.ReadString)
                        If textReader.Name = "SI_Fan_Type" Then final.fantype = textReader.ReadString
                        If textReader.Name = "SI_Fan_Type_Description" Then final.fantypename = textReader.ReadString
                        If textReader.Name = "SI_Fan_Speed" Then final.speed = CDbl(textReader.ReadString)
                        If textReader.Name = "SI_Fan_Flow" Then final.vol = CDbl(textReader.ReadString)
                        If textReader.Name = "SI_Static_Pressure" Then final.fsp = CDbl(textReader.ReadString)
                        If textReader.Name = "SI_Static_Efficiency" Then final.fse = CDbl(textReader.ReadString)
                        If textReader.Name = "SI_Total_Pressure" Then final.ftp = CDbl(textReader.ReadString)
                        If textReader.Name = "SI_Total_Efficiency" Then final.fte = CDbl(textReader.ReadString)
                        If textReader.Name = "SI_Fan_Power" Then final.pow = CDbl(textReader.ReadString)
                        If textReader.Name = "SI_Fan_Power2" Then final.pow2 = CDbl(textReader.ReadString)
                        If textReader.Name = "SI_Motor_Power" Then final.mot = CDbl(textReader.ReadString)
                        If textReader.Name = "SI_Motor_Power2" Then final.mot2 = CDbl(textReader.ReadString)
                        If textReader.Name = "SI_Reserve_Head" Then final.resHD = CDbl(textReader.ReadString)
                        If textReader.Name = "SI_Volume_D" Then final.VD = CDbl(textReader.ReadString)
                        If textReader.Name = "SI_Blade_Number" Then final.BladeNumber = CInt(textReader.ReadString)
                        If textReader.Name = "SI_Inlet_Diameter" Then final.inletdia = CDbl(textReader.ReadString)
                        If textReader.Name = "SI_Outlet_Velocity" Then final.ov = CDbl(textReader.ReadString)
                        If textReader.Name = "SI_Outlet_Area" Then final.outletarea = CDbl(textReader.ReadString)
                        If textReader.Name = "SI_Outlet_Length" Then final.outletlen = CDbl(textReader.ReadString)
                        If textReader.Name = "SI_Outlet_Width" Then final.outletwid = CDbl(textReader.ReadString)
                        If textReader.Name = "SI_Outlet_Diameter" Then final.outletdia = CDbl(textReader.ReadString)
                        If textReader.Name = "SI_Width_Factor" Then final.widthfactor = CDbl(textReader.ReadString)
                        '' ##### Acoustics
                        Dim i As Integer
                        For i = 0 To 7
                            If textReader.Name = "IDSPL_" + i.ToString Then IDSPL(i) = CInt(textReader.ReadString)
                            If textReader.Name = "Ascale_" + i.ToString Then Ascale(i) = CInt(textReader.ReadString)
                            If textReader.Name = "INascale_" + i.ToString Then INascale(i) = CInt(textReader.ReadString)
                            If textReader.Name = "OUTascale_" + i.ToString Then OUTascale(i) = CInt(textReader.ReadString)
                        Next
                        If textReader.Name = "spl2" Then spl2 = CInt(textReader.ReadString)
                        If textReader.Name = "bospl2" Then bospl2 = CInt(textReader.ReadString)
                        If textReader.Name = "bospl1M2" Then bospl1M2 = CInt(textReader.ReadString)
                        If textReader.Name = "NCoverall" Then NCoverall = CInt(textReader.ReadString)
                        If textReader.Name = "inNCoverall" Then inNCoverall = CSng(textReader.ReadString)
                        If textReader.Name = "OUTNCoverall" Then OUTNCoverall = CSng(textReader.ReadString)
                        If textReader.Name = "Bearing_Noise" Then BRGnoise = CInt(textReader.ReadString)
                        If textReader.Name = "Motor_Noise" Then MTRnoise = CInt(textReader.ReadString)
                        If textReader.Name = "Blade_Passing_Frequency" Then BPfreq = CInt(textReader.ReadString)
                        If textReader.Name = "Include_Duct_Noise" Then InclDuctNoise = CBool(textReader.ReadString)
                        If textReader.Name = "Include_Open_Inlet_Noise" Then InclOpenInletNoise = CBool(textReader.ReadString)
                        If textReader.Name = "Include_Open_Outlet_Noise" Then InclOpenOutletNoise = CBool(textReader.ReadString)
                        If textReader.Name = "Include_Bearing_Noise" Then InclBrgNoise = CBool(textReader.ReadString)
                        If textReader.Name = "Include_Motor_Noise" Then InclMotorNoise = CBool(textReader.ReadString)
                    End If
                End While
            Loop
            textReader.Close()
        Catch ex As Exception
            ErrorMessage(ex, 6502)
        End Try
    End Sub

    '################################################################################################

    Public Sub Write_to_XML(ByVal TextWriter As XmlTextWriter, ByVal Parameter As String, ByVal Value As String)
        Try
            TextWriter.WriteStartElement(Parameter)
            TextWriter.WriteString(Value)
            TextWriter.WriteEndElement()
        Catch ex As Exception
            ErrorMessage(ex, 6503)
        End Try
    End Sub

    Public Sub Write_to_XML(ByVal TextWriter As XmlTextWriter, ByVal Parameter As String)
        Try
            TextWriter.WriteStartElement(Parameter)
        Catch ex As Exception
            ErrorMessage(ex, 6504)
        End Try
    End Sub

    Public Sub Write_to_XML(ByVal TextWriter As XmlTextWriter)
        Try
            TextWriter.WriteEndElement()
        Catch ex As Exception
            ErrorMessage(ex, 6505)
        End Try
    End Sub
End Module
