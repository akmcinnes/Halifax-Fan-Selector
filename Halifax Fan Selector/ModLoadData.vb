﻿Module ModLoadData
    Public Function LoadFanData(filename, fanno) As String
        LoadFanData = ""
        Try
            If Frmselectfan.chkOriginalData.Checked = True Then
                filename = Replace(filename, ".bin", ".bon")
            End If
            ReadfromBinaryfile(filename, fanno)
            ''----setting the number of decimal places-------------------------------------------
            If Units(0).UnitSelected = 2 Then
                voldecplaces = 3
            ElseIf Units(0).UnitSelected = 1 Then
                voldecplaces = 2
            Else
                voldecplaces = 0
            End If

            If Units(5).UnitSelected = 0 Then lengthdecplaces = 0
            If Units(5).UnitSelected = 1 Then lengthdecplaces = 2

            If flowrate > 10000 Then
                voldecplaces = 0
            ElseIf flowrate > 1000 Then
                voldecplaces = 1
            ElseIf flowrate > 100 Then
                voldecplaces = 2
            ElseIf flowrate > 10 Then
                voldecplaces = 3
            End If

            pressplaceRise = 2
            If pressrise > 10000 Then
                pressplaceRise = 0
            ElseIf pressrise > 1000 Then
                pressplaceRise = 1
            ElseIf pressrise > 100 Then
                pressplaceRise = 2
            ElseIf pressrise > 10 Then
                pressplaceRise = 3
            End If

            count = 0
            countefft = 0
            counteffs = 0
            row = 9

            ReDim ftp(40, 50)
            ReDim vol(40, 50)
            ReDim Powr(40, 50)
            ReDim fte(40, 50)
            ReDim fsp(40, 50)
            ReDim fse(40, 50)
            ReDim ovel(40, 50)

            For count = 0 To Num_Readings - 1
                If Units(1).UnitSelected = 0 Then
                    fsp(fanno, count) = FSP_pa(count)
                    ftp(fanno, count) = FTP_pa(count)
                ElseIf Units(1).UnitSelected = 1 Then
                    fsp(fanno, count) = FSP_insWG(count)
                    ftp(fanno, count) = FTP_insWG(count)
                ElseIf Units(1).UnitSelected = 2 Then
                    fsp(fanno, count) = FSP_mmwg(count)
                    ftp(fanno, count) = FTP_mmWG(count)
                ElseIf Units(1).UnitSelected = 3 Then
                    fsp(fanno, count) = FSP_mbar(count)
                    ftp(fanno, count) = FTP_mbar(count)
                ElseIf Units(1).UnitSelected = 4 Then
                    fsp(fanno, count) = FSP_kpa(count)
                    ftp(fanno, count) = FTP_kpa(count)
                End If
                If Units(0).UnitSelected = 0 Then
                    vol(fanno, count) = Vol_m3hr(count)
                ElseIf Units(0).UnitSelected = 1 Then
                    vol(fanno, count) = Vol_m3min(count)
                ElseIf Units(0).UnitSelected = 2 Then
                    vol(fanno, count) = Vol_m3sec(count)
                ElseIf Units(0).UnitSelected = 3 Then
                    vol(fanno, count) = Vol_cfm(count)
                ElseIf Units(0).UnitSelected = 4 Then
                    vol(fanno, count) = Vol_m3hr(count)
                ElseIf Units(0).UnitSelected = 5 Then
                    vol(fanno, count) = Vol_cfm(count)
                End If
                If Units(4).UnitSelected = 0 Then
                    Powr(fanno, count) = Pow_kw(count)
                ElseIf Units(4).UnitSelected = 1 Then
                    Powr(fanno, count) = Pow_hp(count)
                ElseIf Units(4).UnitSelected = 2 Then
                    Powr(fanno, count) = Pow_kw(count)
                End If
                fte(fanno, count) = FTE1(count)
                fse(fanno, count) = FSE1(count)
                If Units(7).UnitSelected = 0 Then
                    ovel(fanno, count) = OV_msec(count)
                ElseIf Units(7).UnitSelected = 1 Then
                    ovel(fanno, count) = OV_fmin(count)
                End If
                If fte(fanno, count) > fte(fanno, countefft) Then countefft = count
                If fse(fanno, count) > fse(fanno, counteffs) Then counteffs = count
            Next
            datafansize(fanno) = FanSize1
            datafanspeed(fanno) = FanSpeed1
            dataoutletlen(fanno) = OutLen_mm
            dataoutletwid(fanno) = OutWid_mm
            dataoutletdia(fanno) = OutDia_mm
            dataoutletarea(fanno) = OutArea_m2
            dataoutletareaftsq(fanno) = OutArea_ft2
            datainletdia(fanno) = In_Dia_mm
            blade_type(fanno) = Type_Blade
            blade_number(fanno) = Num_Blades
            datapoints1 = Num_Readings

            For count = 0 To Num_Readings - 1
            Next

            If PresType = 0 Then
                medpoint(fanno) = counteffs
            Else
                medpoint(fanno) = countefft
            End If
            medpoint(fanno) = Most_Eff_Pt - 1 'akm201218

            FanMaxCount(fanno) = datapoints1
            If PresType = 1 Then
                For II = datapoints1 To 0 Step -1
                    If ftp(fanno, II) > ftp(fanno, FanMaxCount(fanno)) Then FanMaxCount(fanno) = II
                Next II
            Else
                For II = datapoints1 To 0 Step -1
                    If fsp(fanno, II) > fsp(fanno, FanMaxCount(fanno)) Then FanMaxCount(fanno) = II
                Next II
            End If

            count = 1
            row = 9
            Return "Complete"

        Catch ex As Exception
            If StartArg.ToLower.Contains("-dev") Then ErrorMessage(ex, 5401)
        End Try
    End Function

    Public Function GetMotorSize(abspower, Optional ByVal Both = False)
        ReadMotorFromBinaryFile()
        Try
            count = 0
            Do While (abspower * Motor_Margin) > Motor_Information(count).PowerKW
                count = count + 1
                If count = 100 Then
                    GetMotorSize = "Out Of Range"
                    Exit Do
                End If
            Loop
            GetMotorSize = Motor_Information(count).PowerKW
        Catch ex As Exception
            Do While (abspower * Motor_Margin) > Motor_Information(count).PowerKW
                count = count + 1
                If count = 100 Then
                    GetMotorSize = "Out Of Range"
                    Exit Do
                End If
            Loop
            GetMotorSize = Motor_Information(count).PowerKW
            ErrorMessage(ex, 5402)
        End Try
    End Function

    Public Sub ReadMotorFromBinaryFile()
        Try
            If DataPath Is Nothing Then
                Exit Sub
            End If

            Dim col As Integer
            If (Units(4).UnitSelected = 0 Or Units(4).UnitSelected = 2) Then
                col = 0
            Else
                col = 1
            End If
            Dim FullFilePathtxt As String
            FullFilePathtxt = DataPath + "motors.bin"

            fs = New System.IO.FileStream(FullFilePathtxt, IO.FileMode.Open)
            br = New System.IO.BinaryReader(fs)

            br.BaseStream.Seek(0, IO.SeekOrigin.Begin)

            Dim k As Integer = 0

            k = 0
            'Try
            Do While br.PeekChar > -1
                Motor_Information(k).PowerKW = br.ReadDouble()
                Motor_Information(k).PowerHP = br.ReadDouble()
                Motor_Information(k).Speed50(0) = br.ReadDouble()
                Motor_Information(k).Speed50(1) = br.ReadDouble()
                Motor_Information(k).Speed50(2) = br.ReadDouble()
                Motor_Information(k).Speed50(3) = br.ReadDouble()
                Motor_Information(k).Speed50(4) = br.ReadDouble()
                Motor_Information(k).Speed50(5) = br.ReadDouble()
                Motor_Information(k).Speed60(0) = br.ReadDouble()
                Motor_Information(k).Speed60(1) = br.ReadDouble()
                Motor_Information(k).Speed60(2) = br.ReadDouble()
                Motor_Information(k).Speed60(3) = br.ReadDouble()
                Motor_Information(k).Speed60(4) = br.ReadDouble()
                Motor_Information(k).Speed60(5) = br.ReadDouble()
                k = k + 1
            Loop
            br.Close()

        Catch ex As Exception
            If StartArg.ToLower.Contains("-dev") Then ErrorMessage(ex, 5403)
        End Try
    End Sub

    Public Sub ReadfromBinaryfile(filename, fanno)
        Try
            Dim dimult As Integer = 1
            If SelectDIDW = True Then dimult = 2
            Dim i As Integer
            'filename = filename.Replace(".txt", ".bin")
            Dim FullFilePathtxt As String

            'If Frmselectfan.chkOriginalData.Checked = False Then
            FullFilePathtxt = DataPath + filename
            'Else
            '    FullFilePathtxt = DataPath + "Binary Old Files\" + filename
            'End If

            fs = New System.IO.FileStream(FullFilePathtxt, IO.FileMode.Open)
            br = New System.IO.BinaryReader(fs)
            br.BaseStream.Seek(0, IO.SeekOrigin.Begin)

            FanSize2 = br.ReadDouble()
            FanSpeed1 = br.ReadDouble()
            FanSize1 = br.ReadDouble()
            Num_Readings = br.ReadInt32()
            Most_Eff_Pt = br.ReadInt32()
            OutLen_mm = br.ReadDouble()
            OutWid_mm = br.ReadDouble() * dimult
            OutDia_mm = br.ReadDouble() * dimult ^ 0.5
            OutArea_m2 = br.ReadDouble() * dimult
            OutLen_ft = br.ReadDouble()
            OutWid_ft = br.ReadDouble() * dimult
            OutDia_ft = br.ReadDouble() * dimult ^ 0.5
            OutArea_ft2 = br.ReadDouble() * dimult
            In_Dia_mm = br.ReadDouble()
            Eye_Area_m2 = br.ReadDouble()
            Type_Blade = br.ReadString()
            Num_Blades = br.ReadInt32()

            For i = 0 To Num_Readings - 1
                FSP_insWG(i) = br.ReadDouble()
            Next
            For i = 0 To Num_Readings - 1
                Pow_hp(i) = br.ReadDouble() * dimult
            Next
            For i = 0 To Num_Readings - 1
                Vol_cfm(i) = br.ReadDouble() * dimult
            Next
            For i = 0 To Num_Readings - 1
                FTP_insWG(i) = br.ReadDouble()
            Next
            For i = 0 To Num_Readings - 1
                FSP_mmwg(i) = br.ReadDouble()
            Next
            For i = 0 To Num_Readings - 1
                Pow_kw(i) = br.ReadDouble() * dimult
            Next
            For i = 0 To Num_Readings - 1
                Vol_m3hr(i) = br.ReadDouble() * dimult
            Next
            For i = 0 To Num_Readings - 1
                FTP_mmWG(i) = br.ReadDouble()
            Next
            For i = 0 To Num_Readings - 1
                Vol_m3min(i) = br.ReadDouble() * dimult
            Next
            For i = 0 To Num_Readings - 1
                Vol_m3sec(i) = br.ReadDouble() * dimult
            Next
            For i = 0 To Num_Readings - 1
                FSP_pa(i) = br.ReadDouble()
                FSP_kpa(i) = FSP_pa(i) / 1000.0
            Next
            For i = 0 To Num_Readings - 1
                FTP_pa(i) = br.ReadDouble()
                FTP_kpa(i) = FTP_pa(i) / 1000.0
            Next
            For i = 0 To Num_Readings - 1
                FSP_mbar(i) = br.ReadDouble()
            Next
            For i = 0 To Num_Readings - 1
                FTP_mbar(i) = br.ReadDouble()
            Next
            For i = 0 To Num_Readings - 1
                OV_msec(i) = br.ReadDouble()
            Next
            For i = 0 To Num_Readings - 1
                OV_fmin(i) = br.ReadDouble()
            Next
            For i = 0 To Num_Readings - 1
                FSE1(i) = br.ReadDouble()
            Next
            For i = 0 To Num_Readings - 1
                FTE1(i) = br.ReadDouble()
            Next
            For i = 0 To 49 '29
                STD_Fan_Size(i) = br.ReadDouble()
                fsizes(fanno, i) = STD_Fan_Size(i)
            Next
            br.Close() 'Close 

            If Not DDInputRatio = 0.0 Then
                OutLen_mm = OutLen_mm * DDInputRatio ^ 0.5
                OutWid_mm = OutWid_mm * DDInputRatio ^ 0.5
                OutDia_mm = OutDia_mm * DDInputRatio ^ 0.5
                OutArea_m2 = OutArea_m2 * DDInputRatio
                OutLen_ft = OutLen_ft * DDInputRatio ^ 0.5
                OutWid_ft = OutWid_ft * DDInputRatio ^ 0.5
                OutDia_ft = OutDia_ft * DDInputRatio ^ 0.5
                OutArea_ft2 = OutArea_ft2 * DDInputRatio
                Dim hv As Double
                For i = 0 To Num_Readings - 1
                    hv = 0.5 * 1.2 * (Vol_m3sec(i) / OutArea_m2) ^ 2
                    FSP_pa(i) = FTP_pa(i) - hv
                    FSP_kpa(i) = FSP_pa(i) / 1000.0
                    FSP_insWG(i) = FTP_insWG(i) - hv * 40146307866177
                    FSP_mbar(i) = FTP_mbar(i) - hv * 0.01
                    FSP_mmwg(i) = FTP_mmWG(i) - hv * 0.10197162129779283
                Next

            End If

            'modify FSP for discharge duct ratio
        Catch ex As Exception
            failindex = failindex + 1
            fanfailures(failindex, 0) = fantypename(fanno)
            fanfailures(failindex, 1) = ex.Message
        End Try
    End Sub

    Public Sub ReadFailuresFromBinaryFile()
        Try
            If DataPath Is Nothing Then
                Exit Sub
            End If

            Dim FullFilePathtxt As String
            FullFilePathtxt = DataPath + "Failures List.bin"

            fs = New System.IO.FileStream(FullFilePathtxt, IO.FileMode.Open)
            br = New System.IO.BinaryReader(fs)

            br.BaseStream.Seek(0, IO.SeekOrigin.Begin)

            Dim i As Integer
            Dim j As Integer
            For i = 0 To 20
                FailuresList(i).IndexLan = br.ReadInt32()
                For j = 0 To 5
                    FailuresList(i).Languages(j) = br.ReadString
                Next
            Next
            br.Close()

        Catch ex As Exception
            If StartArg.ToLower.Contains("-dev") Then ErrorMessage(ex, 5405)
        End Try
    End Sub
End Module
