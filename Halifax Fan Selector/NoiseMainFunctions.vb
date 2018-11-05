﻿Imports System.IO
Module Noisemainfunctions

    Public Function ConvUnits()
        ConvUnits = 0.0

        NCQ = Val(Frmselectfan.Txtflow.Text)   'reading in values from form
        NCFSP = Val(Frmselectfan.Txtfsp.Text)
        NCN = Val(Frmselectfan.Txtfanspeed.Text)

        Select Case Units(0).UnitSelected
            Case 0
                NCQ = NCQ * 1.0
            Case 1
                NCQ = NCQ * 60
            Case 2
                NCQ = NCQ * 3600
            Case 3
                NCQ = NCQ / 0.5875
            Case 4
        End Select

        'If FlowType = 4 Then 'converting flow into si units
        '    NCQ = NCQ / 0.5875
        'End If
        'If FlowType = 2 Then
        '    NCQ = NCQ * 60
        'End If
        'If FlowType = 3 Then
        '    NCQ = NCQ * 3600
        'End If

        Select Case Units(1).UnitSelected
            Case 0
                NCFSP = NCFSP / 9.81
            Case 1
                NCFSP = NCFSP * 25.4
            Case 2
                NCFSP = NCFSP / 0.00981
            Case 3
                NCFSP = NCFSP / 0.0981
        End Select


        ''If Units(1).UnitSelected = 1 Then
        'If PresType = 1 Then
        '    NCFSP = NCFSP * 25.4
        'End If
        ''If Units(1).UnitSelected = 0 Then
        'If PresType = 0 Then
        '    NCFSP = NCFSP / 9.81
        'End If
        ''If Units(1).UnitSelected = 2 Then 'kPa????
        'If PresType = 2 Then 'kPa????
        '    NCFSP = NCFSP / 0.00981
        'End If
        ''If Units(1).UnitSelected = 3 Then
        'If PresType = 3 Then
        '    NCFSP = NCFSP / 0.0981
        'End If

        WScale(1) = -26
        WScale(2) = -16
        WScale(3) = -8.5
        WScale(4) = -3.2
        WScale(5) = 0
        WScale(6) = 1.2
        WScale(7) = 1
        WScale(8) = -1.1

    End Function

    Public Function CalcSPL() 'FUNCTION TO CALCULATE THE overall SOUND POWER LEVEL - should this be Sound Pressure Level or SWL??????? akm
        'Dim FullFilePathtxt As String = "C:\Halifax\Performance Data new\Table1.txt"
        'Dim FullFilePathtxt As String = "C:\Halifax\Performance Data new\Table1.bin"
        Dim FullFilePathtxt As String = DataPath + "Table1.bin"
        'Dim objStreamReader As New StreamReader(FullFilePathtxt)


        fs = New System.IO.FileStream(FullFilePathtxt, IO.FileMode.Open)
        br = New System.IO.BinaryReader(fs)

        'Dim output As System.Text.StringBuilder
        'Output = New System.Text.StringBuilder()

        br.BaseStream.Seek(0, IO.SeekOrigin.Begin)


        Dim sounddata(8, 9) As Integer

        CalcSPL = 0.0

        '4 to 8 rows
        '2 to 9 cols
        For i = 0 To 4 '4 to 8
            For j = 0 To 7 '2 to 9
                'sounddata(i, j) = objStreamReader.ReadLine()
                sounddata(i, j) = br.ReadInt32()
            Next
        Next



        Dim count_num As Integer
        SPL = 25 + (10 * (0.4342944 * Math.Log(NCQ))) + (20 * (0.4342944 * (Math.Log(NCFSP))))

        If finalfantype.Contains("PB") Then
            SPL = SPL + 8
        End If
        spl2 = SPL 'for rounding off purposes

        If finalfantype.Contains("BC") Then
            count_num = 0
            For count_num = 0 To 7
                CF(count_num) = sounddata(1, count_num)
            Next count_num
        End If

        If finalfantype.Contains("BI") Then
            For count_num = 0 To 7
                CF(count_num) = sounddata(2, count_num)
            Next count_num

        End If

        If finalfantype.Contains("FC") Then
            For count_num = 0 To 7
                CF(count_num) = sounddata(0, count_num)
            Next count_num
        End If

        If finalfantype.Contains("RAD") Then
            For count_num = 0 To 7
                CF(count_num) = sounddata(3, count_num)
            Next count_num
        End If

        If finalfantype.Contains("Axial") Then
            For count_num = 0 To 7
                CF(count_num) = sounddata(4, count_num)
            Next count_num
        End If

        count_num = 1
        For count_num = 0 To 7
            IDSPL(count_num) = SPL - CF(count_num)
        Next count_num
        'objStreamReader.Close()
        br.Close()

    End Function

    Public Function CalcBrg()
        CalcBrg = 0.0
        NCN = finalspeed
        BRGnoise = 21 * 0.4342944 * Math.Log(NCN)
    End Function

    Public Function OutputBrg()
        OutputBrg = 0.0
        MsgBox(BRGnoise.ToString)
        'With Worksheets("Sound")
        '    .Cells(brgrow, 1).Value = "Bearing Noise: " & BRGnoise & " dBA"
        '    .Cells(brgrow, 1).Font.Bold = True
        '    .Cells(brgrow, 1).Font.Italic = True
        '    .Range(Cells(brgrow, 1), Cells(brgrow, 6)).Merge
        '    .Range(Cells(brgrow, 1), Cells(brgrow, 6)).Borders.LineStyle = xlContinuous
        'End With
    End Function
    Public Function OutputMotor()
        OutputMotor = 0.0
        'With Worksheets("Sound")
        '    .Cells(Motorrow, 1).Value = "Motor Noise: " & frmNoisemain.txtmotor.Value & " dBA"
        '    .Cells(Motorrow, 1).Font.Bold = True
        '    .Cells(Motorrow, 1).Font.Italic = True
        '    .Range(Cells(Motorrow, 1), Cells(Motorrow, 6)).Merge
        '    .Range(Cells(Motorrow, 1), Cells(Motorrow, 6)).Borders.LineStyle = xlContinuous
        'End With
    End Function
    Public Function OutputBPF()
        OutputBPF = 0.0
        'With Worksheets("Sound")
        '    .Cells(bpfroW, 1).Value = "Blade Pass Cut Off Frequency: " & BPfreq & " Hz"
        '    .Cells(bpfroW, 1).Font.Bold = True
        '    .Cells(bpfroW, 1).Font.Italic = True
        '    .Range(Cells(bpfroW, 1), Cells(bpfroW, 8)).Merge
        '    .Range(Cells(bpfroW, 1), Cells(bpfroW, 8)).Borders.LineStyle = xlContinuous
        'End With
    End Function
    Public Function CalcBPFreq()
        CalcBPFreq = 0.0

        BPfreq = (NCN / 60) * bladecount

    End Function

    Public Function OpenInletCalcs() 'calculating noise for open ducts
        OpenInletCalcs = 0.0

        'NCINdia = frmNoisemain.txtinletdia.Value

        inX = 10 * (0.4342944 * Math.Log(4 * ((1000 / NCINdia) ^ 2)))

        count = 1
        If NCINdia > 2500 Then
            For count = 1 To 8
                INascale(count) = IDSPL(count) - inX + WScale(count)
            Next count
        End If
        If NCINdia <= 2500 And NCINdia > 2000 Then
            For count = 1 To 8
                'INascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(22, count + 1).Value - inX + WScale(count)
            Next count
        End If
        If NCINdia <= 2000 And NCINdia > 1500 Then
            For count = 1 To 8
                'INascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(21, count + 1).Value - inX + WScale(count)
            Next count
        End If
        If NCINdia <= 1500 And NCINdia > 1000 Then
            For count = 1 To 8
                'INascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(20, count + 1).Value - inX + WScale(count)
            Next count
        End If
        If NCINdia <= 1000 And NCINdia > 750 Then
            For count = 1 To 8
                'INascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(19, count + 1).Value - inX + WScale(count)
            Next count
        End If
        If NCINdia <= 750 And NCINdia > 625 Then
            For count = 1 To 8
                'INascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(18, count + 1).Value - inX + WScale(count)
            Next count
        End If
        If NCINdia <= 625 And NCINdia > 500 Then
            For count = 1 To 8
                'INascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(17, count + 1).Value - inX + WScale(count)
            Next count
        End If
        If NCINdia <= 500 And NCINdia > 425 Then
            For count = 1 To 8
                'INascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(16, count + 1).Value - inX + WScale(count)
            Next count
        End If
        If NCINdia <= 425 And NCINdia > 350 Then
            For count = 1 To 8
                'INascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(15, count + 1).Value - inX + WScale(count)
            Next count
        End If
        If NCINdia <= 350 And NCINdia > 300 Then
            For count = 1 To 8
                'INascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(14, count + 1).Value - inX + WScale(count)
            Next count
        End If
        If NCINdia <= 300 And NCINdia > 250 Then
            For count = 1 To 8
                'INascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(13, count + 1).Value - inX + WScale(count)
            Next count
        End If
        If NCINdia <= 250 And NCINdia > 225 Then
            For count = 1 To 8
                'INascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(12, count + 1).Value - inX + WScale(count)
            Next count
        End If
        If NCINdia <= 225 And NCINdia > 200 Then
            For count = 1 To 8
                'INascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(11, count + 1).Value - inX + WScale(count)
            Next count
        End If
        If NCINdia <= 200 And NCINdia > 175 Then
            For count = 1 To 8
                'INascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(10, count + 1).Value - inX + WScale(count)
            Next count
        End If
        If NCINdia <= 175 And NCINdia > 150 Then
            For count = 1 To 8
                'INascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(9, count + 1).Value - inX + WScale(count)
            Next count
        End If
        If NCINdia <= 150 And NCINdia > 125 Then
            For count = 1 To 8
                'INascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(8, count + 1).Value - inX + WScale(count)
            Next count
        End If
        If NCINdia <= 125 And NCINdia > 100 Then
            For count = 1 To 8
                'INascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(7, count + 1).Value - inX + WScale(count)
            Next count
        End If
        If NCINdia <= 100 And NCINdia > 75 Then
            For count = 1 To 8
                'INascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(6, count + 1).Value - inX + WScale(count)
            Next count
        End If
        If NCINdia <= 75 And NCINdia > 50 Then
            For count = 1 To 8
                'INascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(5, count + 1).Value - inX + WScale(count)
            Next count
        End If


        inNCoverall = 0
        For count = 1 To 8
            Octaves(count) = INascale(count)
            inNCoverall = inNCoverall + 10.0# ^ (Octaves(count) / 10.0#)
        Next count
        inNCoverall = 10.0# * (Math.Log(inNCoverall) / Math.Log(10.0#))

    End Function

    Public Function OpenOutletCalcs() 'calculating noise for open ducts
        OpenOutletCalcs = 0.0


        'If frmNoisemain.Optsquare.Value = True Then
        '    OUTarea = frmNoisemain.txtoutletlen.Value * frmNoisemain.txtoutletwid.Value
        '    OUTdia = 1.13 * (Math.Sqrt(OUTarea)) ' calculating equivelent diameter
        'Else
        '    OUTdia = frmNoisemain.txtoutdia.Value
        'End If

        outX = 10 * (0.4342944 * Math.Log(4 * ((1000 / OUTdia) ^ 2)))

        count = 1
        If OUTdia > 2500 Then
            For count = 1 To 8
                OUTascale(count) = IDSPL(count) - outX + WScale(count)
            Next count
        End If
        If OUTdia <= 2500 And OUTdia > 2000 Then
            For count = 1 To 8
                'OUTascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(22, count + 1).Value - outX + WScale(count)
            Next count
        End If
        If OUTdia <= 2000 And OUTdia > 1500 Then
            For count = 1 To 8
                'OUTascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(21, count + 1).Value - outX + WScale(count)
            Next count
        End If
        If OUTdia <= 1500 And OUTdia > 1000 Then
            For count = 1 To 8
                'OUTascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(20, count + 1).Value - outX + WScale(count)
            Next count
        End If
        If OUTdia <= 1000 And OUTdia > 750 Then
            For count = 1 To 8
                'OUTascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(19, count + 1).Value - outX + WScale(count)
            Next count
        End If
        If OUTdia <= 750 And OUTdia > 625 Then
            For count = 1 To 8
                'OUTascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(18, count + 1).Value - outX + WScale(count)
            Next count
        End If
        If OUTdia <= 625 And OUTdia > 500 Then
            For count = 1 To 8
                'OUTascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(17, count + 1).Value - outX + WScale(count)
            Next count
        End If
        If OUTdia <= 500 And OUTdia > 425 Then
            For count = 1 To 8
                'OUTascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(16, count + 1).Value - outX + WScale(count)
            Next count
        End If
        If OUTdia <= 425 And OUTdia > 350 Then
            For count = 1 To 8
                'OUTascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(15, count + 1).Value - outX + WScale(count)
            Next count
        End If
        If OUTdia <= 350 And OUTdia > 300 Then
            For count = 1 To 8
                'OUTascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(14, count + 1).Value - outX + WScale(count)
            Next count
        End If
        If OUTdia <= 300 And OUTdia > 250 Then
            For count = 1 To 8
                'OUTascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(13, count + 1).Value - outX + WScale(count)
            Next count
        End If
        If OUTdia <= 250 And OUTdia > 225 Then
            For count = 1 To 8
                'OUTascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(12, count + 1).Value - outX + WScale(count)
            Next count
        End If
        If OUTdia <= 225 And OUTdia > 200 Then
            For count = 1 To 8
                'OUTascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(11, count + 1).Value - outX + WScale(count)
            Next count
        End If
        If OUTdia <= 200 And OUTdia > 175 Then
            For count = 1 To 8
                'OUTascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(10, count + 1).Value - outX + WScale(count)
            Next count
        End If
        If OUTdia <= 175 And OUTdia > 150 Then
            For count = 1 To 8
                'OUTascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(9, count + 1).Value - outX + WScale(count)
            Next count
        End If
        If OUTdia <= 150 And OUTdia > 125 Then
            For count = 1 To 8
                'OUTascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(8, count + 1).Value - outX + WScale(count)
            Next count
        End If
        If OUTdia <= 125 And OUTdia > 100 Then
            For count = 1 To 8
                'OUTascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(7, count + 1).Value - outX + WScale(count)
            Next count
        End If
        If OUTdia <= 100 And OUTdia > 75 Then
            For count = 1 To 8
                'OUTascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(6, count + 1).Value - outX + WScale(count)
            Next count
        End If
        If OUTdia <= 75 And OUTdia > 50 Then
            For count = 1 To 8
                'OUTascale(count) = IDSPL(count) - ThisWorkbook.Worksheets("Fig5").Cells(5, count + 1).Value - outX + WScale(count)
            Next count
        End If


        OUTNCoverall = 0
        For count = 1 To 8
            Octaves(count) = OUTascale(count)
            OUTNCoverall = OUTNCoverall + 10.0# ^ (Octaves(count) / 10.0#)
        Next count
        OUTNCoverall = 10.0# * (Math.Log(OUTNCoverall) / Math.Log(10.0#))


    End Function

    Public Function OutputDuct()
        OutputDuct = 0.0

        'With Worksheets("Sound")


        '    .Cells(Drow + 3, 1).Value = "Breakout Sound Pressure Level (Ducted Inlet & Outlet)"
        '    .Cells(Drow + 3, 1).Font.size = 11
        '    .Cells(Drow + 3, 1).Font.Bold = True
        '    .Cells(Drow + 3, 1).HorizontalAlignment = xlCenter

        '    .Cells(Drow, 1).Value = "Break out Sound Power Level: " & bospl2 & " dB Linear"
        '    .Cells(Drow + 1, 1).Value = "Break Out Sound Pressure Level at 1 Metre: " & bospl1M2 & " dB Linear"

        '    .Cells(Drow + 4, 1).Value = "Noise In A Weighted Scale"
        '    .Cells(Drow + 4, 1).Font.Bold = True
        '    .Cells(Drow + 4, 1).Font.size = 10


        '    .Cells(Drow + 5, 1).Value = "Octave Mid-Band Frequency (Hz)"
        '    .Cells(Drow + 5, 9).Value = 63
        '    .Cells(Drow + 5, 10).Value = 125
        '    .Cells(Drow + 5, 11).Value = 250
        '    .Cells(Drow + 5, 12).Value = 500
        '    .Cells(Drow + 5, 13).Value = 1000
        '    .Cells(Drow + 5, 14).Value = 2000
        '    .Cells(Drow + 5, 15).Value = 4000
        '    .Cells(Drow + 5, 16).Value = 8000

        '    .Cells(Drow + 6, 1).Value = "Break Out Sound Pressure Level @ 1m (dBA)"
        '    count = 1
        '    For count = 1 To 8
        '        .Cells(Drow + 6, (count + 8)).Value = Ascale(count)
        '    Next count

        Dim txtSPLlabel = New Label()
        'For q As Integer = 0 To 7
        '    txt(q) = New Label()
        'Next q
        txtSPLlabel.Text = "Duct Inlet"
        Frmselectfan.TableLayoutPanel1.Controls.Add(txtSPLlabel, 0, 2) '; //start it In cell 0,0
        Frmselectfan.DataGridView2.Rows(2).Cells(0).Value = txtSPLlabel.Text
        Dim txtSPL(8) As Label
        For q As Integer = 0 To 7
            txtSPL(q) = New Label()
        Next q

        'IDSPL
        For i = 0 To 7
            txtSPL(i).Text = Ascale(i + 1).ToString
            Frmselectfan.TableLayoutPanel1.Controls.Add(txtSPL(i), i + 1, 2) '; //start it In cell 0,0
            Frmselectfan.DataGridView2.Rows(2).Cells(i + 1).Value = txtSPL(i).Text
        Next



        '    .Cells(Drow + 7, 1).Value = "Overall Noise At 1 Metre: " & NCoverall & " dBA In Free Field Conditions"
        '    .Cells(Drow + 7, 1).Font.Bold = True
        '    .Cells(Drow + 7, 1).Font.Italic = True
        '    .Range(Cells(Drow, 1), Cells(Drow + 1, 16)).Borders.LineStyle = xlContinuous
        '    .Range(Cells(Drow + 3, 1), Cells(Drow + 7, 16)).Borders.LineStyle = xlContinuous

        '    .Range(Cells(Drow, 1), Cells(Drow, 16)).Merge
        '    .Range(Cells(Drow + 1, 1), Cells(Drow + 1, 16)).Merge
        '    .Range(Cells(Drow + 3, 1), Cells(Drow + 3, 16)).Merge
        '    .Range(Cells(Drow + 4, 1), Cells(Drow + 4, 16)).Merge
        '    .Range(Cells(Drow + 5, 1), Cells(Drow + 5, 8)).Merge
        '    .Range(Cells(Drow + 6, 1), Cells(Drow + 6, 8)).Merge
        '    .Range(Cells(Drow + 7, 1), Cells(Drow + 7, 16)).Merge
        'End With

    End Function

    Public Function OutputOpenInlet()
        OutputOpenInlet = 0.0

        'With Worksheets("Sound")


        '    .Cells(OIrow, 1).Value = "Open Inlet Ducted Outlet, Sound Pressure Level"
        '    .Cells(OIrow, 1).Font.size = 11
        '    .Cells(OIrow, 1).Font.Bold = True
        '    .Cells(OIrow, 1).HorizontalAlignment = xlCenter

        '    .Cells(OIrow + 1, 1).Value = "Inlet Diameter: " & frmNoisemain.txtinletdia.Value & " mm"

        '    .Cells(OIrow + 2, 1).Value = "Noise In A Weighted Scale"
        '    .Cells(OIrow + 2, 1).Font.Bold = True
        '    .Cells(OIrow + 2, 1).Font.size = 10


        '    .Cells(OIrow + 3, 1).Value = "Octave Mid-Band Frequency (Hz)"
        '    .Cells(OIrow + 3, 9).Value = 63
        '    .Cells(OIrow + 3, 10).Value = 125
        '    .Cells(OIrow + 3, 11).Value = 250
        '    .Cells(OIrow + 3, 12).Value = 500
        '    .Cells(OIrow + 3, 13).Value = 1000
        '    .Cells(OIrow + 3, 14).Value = 2000
        '    .Cells(OIrow + 3, 15).Value = 4000
        '    .Cells(OIrow + 3, 16).Value = 8000

        '    .Cells(OIrow + 4, 1).Value = "Sound Pressure Level @ 1m (dBA)"
        '    count = 1
        '    For count = 1 To 8
        '        .Cells(OIrow + 4, (count + 8)).Value = INascale(count)
        '    Next count

        '    .Cells(OIrow + 5, 1).Value = "Overall Open Inlet Duct Sound Pressure Level @ 1m: " & Round(inNCoverall) & " dBA In Free Field Cond."
        '    .Cells(OIrow + 5, 1).Font.Bold = True
        '    .Cells(OIrow + 5, 1).Font.Italic = True
        '    .Range(Cells(OIrow, 1), Cells(OIrow + 5, 16)).Borders.LineStyle = xlContinuous

        '    .Range(Cells(OIrow, 1), Cells(OIrow, 16)).Merge
        '    .Range(Cells(OIrow + 1, 1), Cells(OIrow + 1, 16)).Merge
        '    .Range(Cells(OIrow + 2, 1), Cells(OIrow + 2, 16)).Merge
        '    .Range(Cells(OIrow + 3, 1), Cells(OIrow + 3, 8)).Merge
        '    .Range(Cells(OIrow + 4, 1), Cells(OIrow + 4, 8)).Merge
        '    .Range(Cells(OIrow + 5, 1), Cells(OIrow + 5, 16)).Merge
        'End With

    End Function

    Public Function OutputOpenOutlet()
        OutputOpenOutlet = 0.0

        'With Worksheets("Sound")


        '    .Cells(OOrow, 1).Value = "Open Outlet Ducted Inlet, Sound Pressure Level"
        '    .Cells(OOrow, 1).Font.size = 11
        '    .Cells(OOrow, 1).Font.Bold = True
        '    .Cells(OOrow, 1).HorizontalAlignment = xlCenter
        '    If frmNoisemain.Optsquare.Value = True Then
        '        .Cells(OOrow + 1, 1).Value = "Outlet Dimensions: " & frmNoisemain.txtoutletlen.Value & " x " & frmNoisemain.txtoutletwid.Value & " mm"
        '    Else
        '        .Cells(OOrow + 1, 1).Value = "Outlet Diameter: " & frmNoisemain.txtoutdia.Value & " mm"
        '    End If

        '    .Cells(OOrow + 2, 1).Value = "Noise In A Weighted Scale"
        '    .Cells(OOrow + 2, 1).Font.Bold = True
        '    .Cells(OOrow + 2, 1).Font.size = 10


        '    .Cells(OOrow + 3, 1).Value = "Octave Mid-Band Frequency (Hz)"
        '    .Cells(OOrow + 3, 9).Value = 63
        '    .Cells(OOrow + 3, 10).Value = 125
        '    .Cells(OOrow + 3, 11).Value = 250
        '    .Cells(OOrow + 3, 12).Value = 500
        '    .Cells(OOrow + 3, 13).Value = 1000
        '    .Cells(OOrow + 3, 14).Value = 2000
        '    .Cells(OOrow + 3, 15).Value = 4000
        '    .Cells(OOrow + 3, 16).Value = 8000

        '    .Cells(OOrow + 4, 1).Value = "Sound Pressure Level @ 1m (dBA)"
        '    count = 1
        '    For count = 1 To 8
        '        .Cells(OOrow + 4, (count + 8)).Value = OUTascale(count)
        '    Next count

        '    .Cells(OOrow + 5, 1).Value = "Overall Open Outlet Duct Sound Pressure Level @ 1m: " & Round(OUTNCoverall) & " dBA In Free Field Cond."
        '    .Cells(OOrow + 5, 1).Font.Bold = True
        '    .Cells(OOrow + 5, 1).Font.Italic = True
        '    .Range(Cells(OOrow, 1), Cells(OOrow + 5, 16)).Borders.LineStyle = xlContinuous

        '    .Range(Cells(OOrow, 1), Cells(OOrow, 16)).Merge
        '    .Range(Cells(OOrow + 1, 1), Cells(OOrow + 1, 16)).Merge
        '    .Range(Cells(OOrow + 2, 1), Cells(OOrow + 2, 16)).Merge
        '    .Range(Cells(OOrow + 3, 1), Cells(OOrow + 3, 8)).Merge
        '    .Range(Cells(OOrow + 4, 1), Cells(OOrow + 4, 8)).Merge
        '    .Range(Cells(OOrow + 5, 1), Cells(OOrow + 5, 16)).Merge
        'End With

    End Function

    Public Function EntryandExitLoss()
        EntryandExitLoss = 0.0
        'Dim FullFilePathtxt As String = "C:\Halifax\Performance Data new\Fig5.bin"
        Dim FullFilePathtxt As String = DataPath + "Fig5.bin"
        'Dim ObjStreamReader As New StreamReader(FullFilePathtxt)
        'Dim temparray() As String


        fs = New System.IO.FileStream(FullFilePathtxt, IO.FileMode.Open)
        br = New System.IO.BinaryReader(fs)

        Dim output As System.Text.StringBuilder
        output = New System.Text.StringBuilder()

        br.BaseStream.Seek(0, IO.SeekOrigin.Begin)

        Dim i As Integer
        Dim j As Integer
        Dim diameters(22) As Integer
        Dim sounddata(22, 9) As Integer
        i = 5
        j = 2
        '4 to 22 rows
        '2 to 9 cols
        For i = 4 To 22
            diameters(i) = br.ReadInt32()
        Next
        For i = 4 To 22
            For j = 2 To 9
                sounddata(i, j) = br.ReadInt32()
                'objStreamWriter.WriteLine(sounddata(i, j))
            Next
        Next
        'Do While xlsWB.Worksheets(1).Cells(i, 1).value IsNot Nothing
        '    motorpower(0, i - 2) = xlsWB.Worksheets(1).Cells(i, 1).Value
        '    i = i + 1
        'Loop
        br.Close()

    End Function

    Public Function DuctCalcs()
        DuctCalcs = 0.0

        If ductCF = 0 Then 'only if a value out of range hasn`t already been put in by the user
            If NCQ <= 150000 Then 'finding the correct column reference in table 2
                T2col = 21
            End If
            If NCQ <= 100000 Then
                T2col = 20
            End If
            If NCQ <= 80000 Then
                T2col = 19
            End If
            If NCQ <= 70000 Then
                T2col = 18
            End If
            If NCQ <= 60000 Then
                T2col = 17
            End If
            If NCQ <= 50000 Then
                T2col = 16
            End If
            If NCQ <= 40000 Then
                T2col = 15
            End If
            If NCQ <= 30000 Then
                T2col = 14
            End If
            If NCQ <= 20000 Then
                T2col = 13
            End If
            If NCQ <= 15000 Then
                T2col = 12
            End If
            If NCQ <= 10000 Then
                T2col = 11
            End If
            If NCQ <= 9000 Then
                T2col = 10
            End If
            If NCQ <= 8000 Then
                T2col = 9
            End If
            If NCQ <= 7000 Then
                T2col = 8
            End If
            If NCQ <= 6000 Then
                T2col = 7
            End If
            If NCQ <= 5000 Then
                T2col = 6
            End If
            If NCQ <= 4000 Then
                T2col = 5
            End If
            If NCQ <= 3000 Then
                T2col = 4
            End If
            If NCQ <= 2000 Then
                T2col = 3
            End If
            If NCQ <= 1000 Then
                T2col = 2
            End If

            If NCFSP <= 50 Then   'start of specifiying correct row from table 2
                T2row = 5
            End If
            If NCFSP > 50 And NCFSP <= 100 And NCN > 2000 Then
                T2row = 6
            End If
            If NCFSP > 50 And NCFSP <= 100 And NCN <= 2000 Then
                T2row = 7
            End If
            If NCFSP > 100 And NCFSP <= 200 And NCN > 2000 Then
                T2row = 8
            End If
            If NCFSP > 100 And NCFSP <= 200 And NCN <= 2000 Then
                T2row = 9
            End If
            If NCFSP > 200 And NCFSP <= 300 And NCN > 2000 Then
                T2row = 10
            End If
            If NCFSP > 200 And NCFSP <= 300 And NCN > 1000 And NCN <= 2000 Then
                T2row = 11
            End If
            If NCFSP > 200 And NCFSP <= 300 And NCN <= 1000 Then
                T2row = 12
            End If
            If NCFSP > 300 And NCFSP <= 400 And NCN > 2000 Then
                T2row = 13
            End If
            If NCFSP > 300 And NCFSP <= 400 And NCN <= 2000 Then
                T2row = 14
            End If
            If NCFSP > 400 And NCFSP <= 500 And NCN > 2000 Then
                T2row = 15
            End If
            If NCFSP > 400 And NCFSP <= 500 And NCN <= 2000 Then
                T2row = 16
            End If
            If NCFSP > 500 And NCFSP <= 600 Then
                T2row = 17
            End If
            If NCFSP > 600 And NCFSP <= 700 Then
                T2row = 18
            End If
            If NCFSP > 700 And NCFSP <= 800 Then
                T2row = 19
            End If
            If NCFSP > 800 And NCFSP <= 900 Then
                T2row = 20
            End If
            If NCFSP > 900 And NCFSP <= 1000 Then
                T2row = 21
            End If
            'getting the coresponding value from table 2
            'ductCF = ThisWorkbook.Worksheets("table2").Cells(T2row, T2col).Value
        End If
        'Dim FullFilePathtxt As String = "C:\Halifax\Performance Data new\Table2.txt"
        'Dim FullFilePathtxt As String = "C:\Halifax\Performance Data new\Table2.bin"
        Dim FullFilePathtxt As String = DataPath + "Table2.bin"
        'Dim ObjStreamReader As New StreamReader(FullFilePathtxt)
        'Dim temparray() As String


        fs = New System.IO.FileStream(FullFilePathtxt, IO.FileMode.Open)
        br = New System.IO.BinaryReader(fs)

        Dim output As System.Text.StringBuilder
        output = New System.Text.StringBuilder()

        br.BaseStream.Seek(0, IO.SeekOrigin.Begin)

        Dim soundflow(21), minfsp(21), maxfsp(21), minspeed(21), maxspeed(21), sounddata(21, 21) As Integer

        '4 to 8 rows
        '2 to 9 cols
        Dim j As Integer
        For i = 2 To 21 '4 to 8
            soundflow(i) = br.ReadInt32()
        Next
        For i = 5 To 21
            minfsp(i) = br.ReadInt32()
            maxfsp(i) = br.ReadInt32()
            minspeed(i) = br.ReadInt32()
            maxspeed(i) = br.ReadInt32()
            For j = 2 To 21
                sounddata(i, j) = br.ReadInt32()
            Next
        Next
        br.Close()


        'temparray = Split(ObjStreamReader.ReadLine, ",")
        'Dim j As Integer = 0
        'Do While temparray(j) < NCQ / 1000
        '    j = j + 1
        'Loop

        'Dim minfsp As Integer = 0
        'Dim maxfsp As Integer = 0
        'Dim minspeed As Integer = 0
        'Dim maxspeed As Integer = 0
        'For i = 0 To 100
        '    temparray = Split(ObjStreamReader.ReadLine, ",")
        '    If temparray(0) <= NCFSP And temparray(1) >= NCFSP And temparray(2) <= finalspeed And temparray(3) >= finalspeed Then
        '        Exit For
        '    Else
        '        temparray = Split(ObjStreamReader.ReadLine, ",")
        '    End If
        'Next
        'temparray = Split(ObjStreamReader.ReadLine, ",")
        'ductCF = CInt(temparray(j))
        j = 2
        Do While soundflow(j) < NCQ / 1000
            j = j + 1
        Loop
        Dim k As Integer
        For k = 2 To 21
            If minfsp(k) <= NCFSP And maxfsp(k) >= NCFSP And minspeed(k) <= finalspeed And maxspeed(k) >= finalspeed Then Exit For
        Next
        ductCF = sounddata(k, j)
        boSPL = SPL - ductCF    'calculating break out sound power level
        bospl2 = boSPL 'rounding of only
        bospl1M = boSPL * 0.85  'calculating break out sound power level @ 1m
        bospl1M2 = bospl1M 'rounding of only

        'converting to an a wieghted scale
        Ascale(1) = bospl1M + WScale(1) - CF(1)
        Ascale(2) = bospl1M + WScale(2) - CF(2)
        Ascale(3) = bospl1M + WScale(3) - CF(3)
        Ascale(4) = bospl1M + WScale(4) - CF(4)
        Ascale(5) = bospl1M + WScale(5) - CF(5)
        Ascale(6) = bospl1M + WScale(6) - CF(6)
        Ascale(7) = bospl1M + WScale(7) - CF(7)
        Ascale(8) = bospl1M + WScale(8) - CF(8)


        If finalfantype.Contains("BC") Then
            NCoverall = bospl1M - 9
        End If
        If finalfantype.Contains("BI") Then
            NCoverall = bospl1M - 8
        End If
        If finalfantype.Contains("FC") Then
            NCoverall = bospl1M - 13
        End If
        If finalfantype.Contains("RAD") Then
            NCoverall = bospl1M - 9
        End If
        If finalfantype.Contains("axial") Then
            NCoverall = bospl1M - 10
        End If

        'ObjStreamReader.Close()

    End Function


    Public Function Output()
        Output = 0.0

        '    Dim ContactDetails, Address As String

        '    ContactDetails = "Tel:- " & ThisWorkbook.Sheets("REF").Cells(6, 2) & "       email:- " & ThisWorkbook.Sheets("REF").Cells(7, 2)
        '    Address = ThisWorkbook.Sheets("REF").Cells(9, 2) & ", " & ThisWorkbook.Sheets("REF").Cells(10, 2)

        '    'Set newsound = Workbooks.Add
        '    Dim SheetName(3) As String
        '    SheetName(1) = "Chart1"
        '    SheetName(2) = "Data"
        '    ISheet = 1
        '    If DataSheetOut Then ISheet = 2

        '    With Workbooks(ResultsFileName)
        '        .Activate
        '        .Sheets.Add
        '        .Sheets(ISheet).Activate
        '    End With

        '    ActiveSheet.Name = "Sound"

        '    'Workbooks(ResultsFileName).Activate
        '    'aaa = Sheets(1).Name
        '    'aab = Sheets(2).Name
        '    'aac = Sheets(3).Name


        '    With ActiveSheet
        '        .Move after:=Sheets(SheetName(ISheet))

        '.PageSetup.LeftMargin = Application.InchesToPoints(0.315)
        '        .PageSetup.RightMargin = Application.InchesToPoints(0.315)

        '        .Activate
        '        .Range("A1:Z250").Font.Name = "Arial"
        '        .Range("A1:Z250").Font.size = 10
        '        .Range("A1:Z250").WrapText = False
        '        .Columns("A:Z").ColumnWidth = 5
        '        .Shapes.AddShape(msoTextOrientationHorizontal, 315, 5, 174, 48).Fill.UserPicture(headerlocation)
        '        .Shapes(1).Line.Visible = False
        '        .Cells(1, 1).Value = "Halifax Fan Ltd."
        '        .Cells(1, 1).Font.size = 11
        '        .Cells(1, 1).Font.Bold = True
        '        .Cells(2, 1).Value = Address
        '        .Cells(2, 1).Font.size = 8
        '        .Cells(2, 1).Font.Italic = True
        '        .Cells(3, 1).Value = "www.halifax-fan.co.uk"
        '        .Cells(3, 1).Font.size = 8
        '        .Cells(4, 1).Value = ContactDetails
        '        .Cells(4, 1).Font.size = 8
        '        .Cells(4, 1).WrapText = False
        '        .Cells(6, 1).Value = "Evaluation Of Sound For Halifax No." & fantitles(FanSave)
        '        .Cells(6, 1).Font.size = 11
        '        .Cells(6, 1).Font.Bold = True
        '        .Cells(6, 1).Font.Underline = True
        '        .Range("a6:p6").Merge
        '        .Cells(6, 1).HorizontalAlignment = xlCenter



        '        If Frmselectfan.Optsucy.Value = True Then
        '            .Cells(7, 1).Value = "Duty Point On Suction"
        '        Else
        '            .Cells(7, 1).Value = "Duty Point"
        '        End If

        '        .Cells(7, 1).Font.Bold = True
        '        .Cells(8, 3).Value = "Volume Flow Rate: " & frmNoisemain.Txtflow.Value & " " & frmNoisemain.lblFlowUnits.Caption
        '        .Cells(8, 11).Value = "Density: " & Frmselectfan.Txtdens.Value & " " & Frmselectfan.Comairdenunits.Value
        '        If PresType = 0 Then
        '            .Cells(9, 3).Value = "Fan Static Pressure: " & Round(NoisePress, 2) & " " & frmNoisemain.LBLFsPUNITS.Caption
        '        Else
        '            .Cells(9, 3).Value = "Fan Total Pressure: " & Round(NoisePress, 2) & " " & frmNoisemain.LBLFsPUNITS.Caption
        '        End If
        '        .Cells(9, 11).Value = "Fan Speed: " & frmNoisemain.Txtfanspeed.Value & " RPM"





        '        .Cells(12, 1).Value = "Sound Power Level"
        '        .Cells(12, 1).Font.Bold = True
        '        .Cells(12, 1).Font.size = 11
        '        .Range("A12:P12").Merge
        '        .Cells(12, 1).HorizontalAlignment = xlCenter

        Dim txtSPLlabel = New Label()
        'For q As Integer = 0 To 7
        '    txt(q) = New Label()
        'Next q
        txtSPLlabel.Text = "Sound Power Level"
        Frmselectfan.TableLayoutPanel1.Controls.Add(txtSPLlabel, 0, 1) '; //start it In cell 0,0
        Frmselectfan.DataGridView2.Rows(1).Cells(0).Value = txtSPLlabel.Text
        Dim txtSPL(8) As Label
        For q As Integer = 0 To 7
            txtSPL(q) = New Label()
        Next q

        'IDSPL
        For i = 0 To 7
            txtSPL(i).Text = IDSPL(i).ToString
            Frmselectfan.TableLayoutPanel1.Controls.Add(txtSPL(i), i + 1, 1) '; //start it In cell 0,0
            Frmselectfan.DataGridView2.Rows(1).Cells(i + 1).Value = txtSPL(i).Text
        Next


        '        .Cells(13, 1).Value = "Octave Mid-Band Frequency (Hz)"
        '        .Range("A13:H13").Merge
        '        .Cells(14, 1).Value = "Sound Power Level (dB)"
        '        .Range("A14:H14").Merge

        '        .Cells(15, 1).Value = "Overall Sound Power Level (SWL): " & spl2 & " dB Linear"
        '        .Cells(15, 1).Font.size = 11
        '        .Range("A15:P15").Merge

        '        .Cells(13, 9).Value = 63
        '        .Cells(13, 10).Value = 125
        '        .Cells(13, 11).Value = 250
        '        .Cells(13, 12).Value = 500
        '        .Cells(13, 13).Value = 1000
        '        .Cells(13, 14).Value = 2000
        '        .Cells(13, 15).Value = 4000
        '        .Cells(13, 16).Value = 8000
        'Frmselectfan.TableLayoutPanel1.Controls.Add("Text", Label, 3, 3)
        'Table.Controls.Add(new Label() { Text = "Type:", Anchor = AnchorStyles.Left, AutoSize = true }, 0, 0);
        '        count = 1
        '        For count = 1 To 8
        '            .Cells(14, (count + 8)).Value = IDSPL(count)
        '        Next count

        '        .Range("a12:p15").Borders.LineStyle = xlContinuous

        '        .Cells(45, 1).Value = "Calc By - " & Application.UserName & "      Date - " & Format(Of Date, "dd/mm/yy")()
        '        .Cells(45, 1).Font.size = 9

        '        .Cells(47, 1).Value = "All copyright held in this document is vested in Halifax Fan Ltd. It contains proprietary information and may not be disclosed to any third party or reproduced"
        '        .Cells(48, 1).Value = "in any form without the written permission of Halifax Fan Ltd."
        '        .Cells(47, 1).Font.size = 7
        '        .Cells(48, 1).Font.size = 7
        '        .Range(.Cells(45, 1), .Cells(48, 1)).HorizontalAlignment = xlLeft

        '    End With


    End Function


End Module
