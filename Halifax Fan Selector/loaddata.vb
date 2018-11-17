Imports System.IO
Module loaddata
    Public Function LoadFanData(filename, fanno) As String
        LoadFanData = ""
        Try
            ReadfromBinaryfile(filename, fanno)
            ''----setting the number of decimal places-------------------------------------------
            'If FlowType = 3 Then
            If Units(0).UnitSelected = 2 Then
                    voldecplaces = 3
                Else
                    voldecplaces = 0
            End If
            'If FlowType = 2 Then
            If Units(0).UnitSelected = 1 Then
                    voldecplaces = 2
                End If
                If Val(Frmselectfan.Txtflow.Text) > 10000 Then
                voldecplaces = 0
            ElseIf Val(Frmselectfan.Txtflow.Text) > 1000 Then
                voldecplaces = 1
            ElseIf Val(Frmselectfan.Txtflow.Text) > 100 Then
                voldecplaces = 2
            ElseIf Val(Frmselectfan.Txtflow.Text) > 10 Then
                voldecplaces = 3
            End If

            pressplaceRise = 2
            If Val(Frmselectfan.Txtfsp.Text) > 10000 Then
                pressplaceRise = 0
            ElseIf Val(Frmselectfan.Txtfsp.Text) > 1000 Then
                pressplaceRise = 1
            ElseIf Val(Frmselectfan.Txtfsp.Text) > 100 Then
                pressplaceRise = 2
            ElseIf Val(Frmselectfan.Txtfsp.Text) > 10 Then
                pressplaceRise = 3
            End If

            count = 0

            countefft = 0
            counteffs = 0
            row = 9

            ReDim ftp(30, 50)
            ReDim vol(30, 50)
            ReDim Powr(30, 50)
            ReDim fte(30, 50)
            ReDim fsp(30, 50)
            ReDim fse(30, 50)
            ReDim ovel(30, 50)

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
                End If
                If Units(0).UnitSelected = 0 Then
                    vol(fanno, count) = Vol_m3hr(count)
                ElseIf Units(0).UnitSelected = 1 Then
                    vol(fanno, count) = Vol_m3min(count)
                ElseIf Units(0).UnitSelected = 2 Then
                    vol(fanno, count) = Vol_m3sec(count)
                ElseIf Units(0).UnitSelected = 3 Then
                    vol(fanno, count) = Vol_cfm(count)
                End If
                If Units(4).UnitSelected = 0 Then
                    Powr(fanno, count) = Pow_kw(count)
                ElseIf Units(4).UnitSelected = 1 Then
                    Powr(fanno, count) = Pow_hp(count)
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
                '            count = count + 1
                '            row = row + 1
            Next
            datafansize(fanno) = FanSize1
            datafanspeed(fanno) = FanSpeed1
            dataoutletarea(fanno) = OutArea_m2
            dataoutletareaftsq(fanno) = OutArea_ft2
            blade_type(fanno) = Type_Blade
            blade_number(fanno) = Num_Blades
            datapoints1 = Num_Readings
            'medpoint(fanno) = Most_Eff_Pt - 1
            If PresType = 0 Then
                medpoint(fanno) = counteffs
            Else
                medpoint(fanno) = countefft
            End If

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
            MsgBox("loadfandata")
        End Try
    End Function

    Public Function GetMotorSize(abspower)
        Dim col As Integer
        If (Units(4).UnitSelected = 0) Then
            col = 0
        Else
            col = 1
        End If
        Dim FullFilePathtxt As String
        'FullFilePathtxt = "C:\Halifax\Performance Data new\motors.bin"
        FullFilePathtxt = DataPath + "motors.bin"

        fs = New System.IO.FileStream(FullFilePathtxt, IO.FileMode.Open)
        br = New System.IO.BinaryReader(fs)

        br.BaseStream.Seek(0, IO.SeekOrigin.Begin)

        Dim k As Integer = 0
        Dim motorcount As Integer = 0
        k = 0
        Try
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
            count = 0
            Do While (abspower * 1.1) > Motor_Information(count).PowerKW
                count = count + 1
                If count = 100 Then
                    'akm temp removed                MsgBox("A Larger Non-Standard Motor is required for selected Fan!", vbInformation)
                    GetMotorSize = "Out Of Range"
                    Exit Do
                End If
            Loop
            GetMotorSize = Motor_Information(count).PowerKW
            'getmotorsize = abspower * 1.1 'temp entry

        Catch ex As Exception
            Do While (abspower * 1.1) > Motor_Information(count).PowerKW
                count = count + 1
                If count = 100 Then
                    'akm temp removed                MsgBox("A Larger Non-Standard Motor is required for selected Fan!", vbInformation)
                    GetMotorSize = "Out Of Range"
                    Exit Do
                End If
            Loop
            GetMotorSize = Motor_Information(count).PowerKW
        End Try
    End Function

    Public Sub ReadfromBinaryfile(filename, fanno)
        Try
            Dim i As Integer
            filename = filename.Replace(".txt", ".bin")
            Dim FullFilePathtxt As String
            'FullFilePathtxt = "C:\Halifax" + filename
            FullFilePathtxt = DataPath + filename

            fs = New System.IO.FileStream(FullFilePathtxt, IO.FileMode.Open)
            br = New System.IO.BinaryReader(fs)
            br.BaseStream.Seek(0, IO.SeekOrigin.Begin)

            FanSize2 = br.ReadDouble()
            FanSpeed1 = br.ReadDouble()
            FanSize1 = br.ReadDouble()
            Num_Readings = br.ReadInt32()
            Most_Eff_Pt = br.ReadInt32()
            OutLen_mm = br.ReadDouble()
            OutWid_mm = br.ReadDouble()
            OutArea_m2 = br.ReadDouble()
            OutLen_ft = br.ReadDouble()
            OutWid_ft = br.ReadDouble()
            OutArea_ft2 = br.ReadDouble()
            In_Dia_mm = br.ReadDouble()
            Eye_Area_m2 = br.ReadDouble()
            Type_Blade = br.ReadString()
            Num_Blades = br.ReadInt32()

            For i = 0 To Num_Readings - 1
                FSP_insWG(i) = br.ReadDouble()
            Next
            For i = 0 To Num_Readings - 1
                Pow_hp(i) = br.ReadDouble()
            Next
            For i = 0 To Num_Readings - 1
                Vol_cfm(i) = br.ReadDouble()
            Next
            For i = 0 To Num_Readings - 1
                FTP_insWG(i) = br.ReadDouble()
            Next
            For i = 0 To Num_Readings - 1
                FSP_mmwg(i) = br.ReadDouble()
            Next
            For i = 0 To Num_Readings - 1
                Pow_kw(i) = br.ReadDouble()
            Next
            For i = 0 To Num_Readings - 1
                Vol_m3hr(i) = br.ReadDouble()
            Next
            For i = 0 To Num_Readings - 1
                FTP_mmWG(i) = br.ReadDouble()
            Next
            For i = 0 To Num_Readings - 1
                Vol_m3min(i) = br.ReadDouble()
            Next
            For i = 0 To Num_Readings - 1
                Vol_m3sec(i) = br.ReadDouble()
            Next
            For i = 0 To Num_Readings - 1
                FSP_pa(i) = br.ReadDouble()
            Next
            For i = 0 To Num_Readings - 1
                FTP_pa(i) = br.ReadDouble()
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
            For i = 0 To 29 '29
                STD_Fan_Size(i) = br.ReadDouble()
                fsizes(fanno, i) = STD_Fan_Size(i)
            Next
            'Dim fstep As Double
            'i = 0
            'Dim maxdia As Double
            'Dim stepsize As Double
            'If FanSize1 < 100 Then
            '    maxdia = 100.0
            '    stepsize = 5.0
            'Else
            '    maxdia = 2500.0
            '    stepsize = 5.0
            'End If
            'For fstep = CDbl(STD_Fan_Size(0)) To maxdia Step stepsize
            '    fsizes(fanno, i) = fstep
            '    i = i + 1
            'Next
            br.Close() 'Close 
        Catch ex As Exception
            'MsgBox(filename + "  readfrombinaryfile")
        End Try
    End Sub


End Module
