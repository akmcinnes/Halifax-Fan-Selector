Module ModNoiseMainFunctions
    Public Function ConvUnits()
        Try
            ConvUnits = 0.0
            NCQ = flowrate   'reading in values from form
            NCFSP = pressrise
            NCN = final.speed

            Select Case Units(0).UnitSelected
                Case 0, 4
                    NCQ = NCQ * 1.0
                Case 1
                    NCQ = NCQ * 60
                Case 2
                    NCQ = NCQ * 3600
                Case 3, 5
                    NCQ = NCQ / 0.5875
                    'Case 4
            End Select

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

            WScale(0) = -26
            WScale(1) = -16
            WScale(2) = -8.5
            WScale(3) = -3.2
            WScale(4) = 0
            WScale(5) = 1.2
            WScale(6) = 1
            WScale(7) = -1.1

        Catch ex As Exception
            ErrorMessage(ex, 5601)
        End Try
        Return NCFSP
    End Function

    Public Function EntryandExitLoss() As Double
        Try
            EntryandExitLoss = 0.0
            Dim FullFilePathtxt As String = DataPath + "Fig5.bin"
            fs = New System.IO.FileStream(FullFilePathtxt, IO.FileMode.Open)
            br = New System.IO.BinaryReader(fs)

            br.BaseStream.Seek(0, IO.SeekOrigin.Begin)

            Dim i As Integer
            Dim j As Integer

            For i = 0 To 18
                diameters(i) = br.ReadInt32()
            Next
            For i = 0 To 18
                For j = 0 To 7
                    sounddata(i, j) = br.ReadInt32()
                Next
            Next
            br.Close()

        Catch ex As Exception
            ErrorMessage(ex, 5602)
        End Try
        Return EntryandExitLoss
    End Function

    '
    '#####################################################################################
    '######  Acoustics Calculations  #####################################################
    '#####################################################################################

    Public Function CalcSPL() 'FUNCTION TO CALCULATE THE overall SOUND POWER LEVEL - should this be Sound Pressure Level or SWL??????? akm
        Try
            Dim FullFilePathtxt As String = DataPath + "Table1.bin"

            fs = New System.IO.FileStream(FullFilePathtxt, IO.FileMode.Open)
            br = New System.IO.BinaryReader(fs)

            br.BaseStream.Seek(0, IO.SeekOrigin.Begin)

            Dim sounddata(8, 9) As Integer

            CalcSPL = 0.0

            '4 to 8 rows
            '2 to 9 cols
            For i = 0 To 4 '4 to 8
                For j = 0 To 7 '2 to 9
                    sounddata(i, j) = br.ReadInt32()
                Next
            Next
            br.Close()

            Dim count_num As Integer
            SPL = 25 + (10 * (0.4342944 * Math.Log(NCQ))) + (20 * (0.4342944 * (Math.Log(NCFSP))))

            If final.fantype.Contains("PB") Then
                SPL = SPL + 8
            End If
            spl2 = SPL 'for rounding off purposes

            If final.fantype.Contains("FC") Then
                For count_num = 0 To 7
                    CF(count_num) = sounddata(0, count_num)
                Next count_num
            End If

            If final.fantype.Contains("BC") Then
                count_num = 0
                For count_num = 0 To 7
                    CF(count_num) = sounddata(1, count_num)
                Next count_num
            End If

            If final.fantype.Contains("BI") Then
                For count_num = 0 To 7
                    CF(count_num) = sounddata(2, count_num)
                Next count_num
            End If

            If final.fantype.Contains("RAD") Then
                For count_num = 0 To 7
                    CF(count_num) = sounddata(3, count_num)
                Next count_num
            End If

            If final.fantype.Contains("Axial") Then
                For count_num = 0 To 7
                    CF(count_num) = sounddata(4, count_num)
                Next count_num
            End If

            count_num = 0
            For count_num = 0 To 7
                IDSPL(count_num) = SPL - CF(count_num)
            Next count_num

        Catch ex As Exception
            ErrorMessage(ex, 5603)
        End Try
        Return IDSPL
    End Function

    Public Function DuctCalcs() As Double
        Try
            DuctCalcs = 0.0
            Dim FullFilePathtxt As String = DataPath + "Table2.bin"

            fs = New System.IO.FileStream(FullFilePathtxt, IO.FileMode.Open)
            br = New System.IO.BinaryReader(fs)

            Dim output As System.Text.StringBuilder
            output = New System.Text.StringBuilder()

            br.BaseStream.Seek(0, IO.SeekOrigin.Begin)

            Dim soundflow(21), minfsp(21), maxfsp(21), minspeed(21), maxspeed(21), sounddata(21, 21) As Integer

            Dim j As Integer
            For i = 0 To 19 '4 to 8
                soundflow(i) = br.ReadInt32()
            Next
            For i = 0 To 16
                minfsp(i) = br.ReadInt32()
                maxfsp(i) = br.ReadInt32()
                minspeed(i) = br.ReadInt32()
                maxspeed(i) = br.ReadInt32()
                For j = 0 To 19
                    sounddata(i, j) = br.ReadInt32()
                Next
            Next
            br.Close()

            j = 0
            Do While soundflow(j) < NCQ / 1000
                j = j + 1
            Loop
            Dim k As Integer
            For k = 0 To 19
                If minfsp(k) <= NCFSP And maxfsp(k) >= NCFSP And minspeed(k) <= final.speed And maxspeed(k) >= final.speed Then Exit For
            Next
            ductCF = sounddata(k, j)
            boSPL = SPL - ductCF    'calculating break out sound power level
            bospl2 = boSPL 'rounding of only
            bospl1M = boSPL * 0.85  'calculating break out sound power level @ 1m
            bospl1M2 = bospl1M 'rounding of only

            'converting to an a wieghted scale
            Ascale(0) = bospl1M + WScale(0) - CF(0)
            Ascale(1) = bospl1M + WScale(1) - CF(1)
            Ascale(2) = bospl1M + WScale(2) - CF(2)
            Ascale(3) = bospl1M + WScale(3) - CF(3)
            Ascale(4) = bospl1M + WScale(4) - CF(4)
            Ascale(5) = bospl1M + WScale(5) - CF(5)
            Ascale(6) = bospl1M + WScale(6) - CF(6)
            Ascale(7) = bospl1M + WScale(7) - CF(7)

            If final.fantype.Contains("BC") Then
                NCoverall = bospl1M - 9
            End If
            If final.fantype.Contains("BI") Then
                NCoverall = bospl1M - 8
            End If
            If final.fantype.Contains("FC") Then
                NCoverall = bospl1M - 13
            End If
            If final.fantype.Contains("RAD") Then
                NCoverall = bospl1M - 9
            End If
            If final.fantype.Contains("axial") Then
                NCoverall = bospl1M - 10
            End If

        Catch ex As Exception
            ErrorMessage(ex, 5604)
        End Try
        Return DuctCalcs
    End Function

    Public Function OpenInletCalcs() As Double 'calculating noise for open ducts
        Try
            OpenInletCalcs = 0.0
            NCINdia = final.inletdia

            inX = 10 * (0.4342944 * Math.Log(4 * ((1000 / NCINdia) ^ 2)))

            count = 0
            If NCINdia > 2500 Then
                For count = 0 To 7
                    INascale(count) = IDSPL(count) - inX + WScale(count)
                Next count
            End If
            If NCINdia <= 2500 And NCINdia > 2000 Then
                For count = 0 To 7
                    INascale(count) = IDSPL(count) - sounddata(18, count) - inX + WScale(count)
                Next count
            End If
            If NCINdia <= 2000 And NCINdia > 1500 Then
                For count = 0 To 7
                    INascale(count) = IDSPL(count) - sounddata(17, count) - inX + WScale(count)
                Next count
            End If
            If NCINdia <= 1500 And NCINdia > 1000 Then
                For count = 0 To 7
                    INascale(count) = IDSPL(count) - sounddata(16, count) - inX + WScale(count)
                Next count
            End If
            If NCINdia <= 1000 And NCINdia > 750 Then
                For count = 0 To 7
                    INascale(count) = IDSPL(count) - sounddata(15, count) - inX + WScale(count)
                Next count
            End If
            If NCINdia <= 750 And NCINdia > 625 Then
                For count = 0 To 7
                    INascale(count) = IDSPL(count) - sounddata(14, count) - inX + WScale(count)
                Next count
            End If
            If NCINdia <= 625 And NCINdia > 500 Then
                For count = 0 To 7
                    INascale(count) = IDSPL(count) - sounddata(13, count) - inX + WScale(count)
                Next count
            End If
            If NCINdia <= 500 And NCINdia > 425 Then
                For count = 0 To 7
                    INascale(count) = IDSPL(count) - sounddata(12, count) - inX + WScale(count)
                Next count
            End If
            If NCINdia <= 425 And NCINdia > 350 Then
                For count = 0 To 7
                    INascale(count) = IDSPL(count) - sounddata(11, count) - inX + WScale(count)
                Next count
            End If
            If NCINdia <= 350 And NCINdia > 300 Then
                For count = 0 To 7
                    INascale(count) = IDSPL(count) - sounddata(10, count) - inX + WScale(count)
                Next count
            End If
            If NCINdia <= 300 And NCINdia > 250 Then
                For count = 0 To 7
                    INascale(count) = IDSPL(count) - sounddata(9, count) - inX + WScale(count)
                Next count
            End If
            If NCINdia <= 250 And NCINdia > 225 Then
                For count = 0 To 7
                    INascale(count) = IDSPL(count) - sounddata(8, count) - inX + WScale(count)
                Next count
            End If
            If NCINdia <= 225 And NCINdia > 200 Then
                For count = 0 To 7
                    INascale(count) = IDSPL(count) - sounddata(7, count) - inX + WScale(count)
                Next count
            End If
            If NCINdia <= 200 And NCINdia > 175 Then
                For count = 0 To 7
                    INascale(count) = IDSPL(count) - sounddata(6, count) - inX + WScale(count)
                Next count
            End If
            If NCINdia <= 175 And NCINdia > 150 Then
                For count = 0 To 7
                    INascale(count) = IDSPL(count) - sounddata(5, count) - inX + WScale(count)
                Next count
            End If
            If NCINdia <= 150 And NCINdia > 125 Then
                For count = 0 To 7
                    INascale(count) = IDSPL(count) - sounddata(4, count) - inX + WScale(count)
                Next count
            End If
            If NCINdia <= 125 And NCINdia > 100 Then
                For count = 0 To 7
                    INascale(count) = IDSPL(count) - sounddata(3, count) - inX + WScale(count)
                Next count
            End If
            If NCINdia <= 100 And NCINdia > 75 Then
                For count = 0 To 7
                    INascale(count) = IDSPL(count) - sounddata(2, count) - inX + WScale(count)
                Next count
            End If
            If NCINdia <= 75 And NCINdia > 50 Then
                For count = 0 To 7
                    INascale(count) = IDSPL(count) - sounddata(1, count) - inX + WScale(count)
                Next count
            End If
            If NCINdia <= 50 Then
                For count = 0 To 7
                    INascale(count) = IDSPL(count) - sounddata(0, count) - inX + WScale(count)
                Next count
            End If

            inNCoverall = 0
            For count = 0 To 7
                Octaves(count) = INascale(count)
                inNCoverall = inNCoverall + 10.0# ^ (Octaves(count) / 10.0#)
            Next count
            inNCoverall = 10.0# * (Math.Log(inNCoverall) / Math.Log(10.0#))

        Catch ex As Exception
            ErrorMessage(ex, 5605)
        End Try
        Return OpenInletCalcs
    End Function

    Public Function OpenOutletCalcs() As Double 'calculating noise for open ducts
        Try
            OpenOutletCalcs = 0.0
            If final.outletlen > 0 And final.outletwid > 0 Then
                OUTdia = 1.13 * Math.Sqrt(final.outletarea) * 1000
            Else
                OUTdia = final.outletdia
            End If

            outX = 10 * (0.4342944 * Math.Log(4 * ((1000 / OUTdia) ^ 2)))

            count = 0
            If OUTdia > 2500 Then
                For count = 0 To 7
                    OUTascale(count) = IDSPL(count) - outX + WScale(count)
                Next count
            End If
            If OUTdia <= 2500 And OUTdia > 2000 Then
                For count = 0 To 7
                    OUTascale(count) = IDSPL(count) - sounddata(18, count) - outX + WScale(count)
                Next count
            End If
            If OUTdia <= 2000 And OUTdia > 1500 Then
                For count = 0 To 7
                    OUTascale(count) = IDSPL(count) - sounddata(17, count) - outX + WScale(count)
                Next count
            End If
            If OUTdia <= 1500 And OUTdia > 1000 Then
                For count = 0 To 7
                    OUTascale(count) = IDSPL(count) - sounddata(16, count) - outX + WScale(count)
                Next count
            End If
            If OUTdia <= 1000 And OUTdia > 750 Then
                For count = 0 To 7
                    OUTascale(count) = IDSPL(count) - sounddata(15, count) - outX + WScale(count)
                Next count
            End If
            If OUTdia <= 750 And OUTdia > 625 Then
                For count = 0 To 7
                    OUTascale(count) = IDSPL(count) - sounddata(14, count) - outX + WScale(count)
                Next count
            End If
            If OUTdia <= 625 And OUTdia > 500 Then
                For count = 0 To 7
                    OUTascale(count) = IDSPL(count) - sounddata(13, count) - outX + WScale(count)
                Next count
            End If
            If OUTdia <= 500 And OUTdia > 425 Then
                For count = 0 To 7
                    OUTascale(count) = IDSPL(count) - sounddata(12, count) - outX + WScale(count)
                Next count
            End If
            If OUTdia <= 425 And OUTdia > 350 Then
                For count = 0 To 7
                    OUTascale(count) = IDSPL(count) - sounddata(11, count) - outX + WScale(count)
                Next count
            End If
            If OUTdia <= 350 And OUTdia > 300 Then
                For count = 0 To 7
                    OUTascale(count) = IDSPL(count) - sounddata(10, count) - outX + WScale(count)
                Next count
            End If
            If OUTdia <= 300 And OUTdia > 250 Then
                For count = 0 To 7
                    OUTascale(count) = IDSPL(count) - sounddata(9, count) - outX + WScale(count)
                Next count
            End If
            If OUTdia <= 250 And OUTdia > 225 Then
                For count = 0 To 7
                    OUTascale(count) = IDSPL(count) - sounddata(8, count) - outX + WScale(count)
                Next count
            End If
            If OUTdia <= 225 And OUTdia > 200 Then
                For count = 0 To 7
                    OUTascale(count) = IDSPL(count) - sounddata(7, count) - outX + WScale(count)
                Next count
            End If
            If OUTdia <= 200 And OUTdia > 175 Then
                For count = 0 To 7
                    OUTascale(count) = IDSPL(count) - sounddata(6, count) - outX + WScale(count)
                Next count
            End If
            If OUTdia <= 175 And OUTdia > 150 Then
                For count = 0 To 7
                    OUTascale(count) = IDSPL(count) - sounddata(5, count) - outX + WScale(count)
                Next count
            End If
            If OUTdia <= 150 And OUTdia > 125 Then
                For count = 0 To 7
                    OUTascale(count) = IDSPL(count) - sounddata(4, count) - outX + WScale(count)
                Next count
            End If
            If OUTdia <= 125 And OUTdia > 100 Then
                For count = 0 To 7
                    OUTascale(count) = IDSPL(count) - sounddata(3, count) - outX + WScale(count)
                Next count
            End If
            If OUTdia <= 100 And OUTdia > 75 Then
                For count = 0 To 7
                    OUTascale(count) = IDSPL(count) - sounddata(2, count) - outX + WScale(count)
                Next count
            End If
            If OUTdia <= 75 And OUTdia > 50 Then
                For count = 0 To 7
                    OUTascale(count) = IDSPL(count) - sounddata(1, count) - outX + WScale(count)
                Next count
            End If
            If OUTdia <= 50 Then
                For count = 0 To 7
                    OUTascale(count) = IDSPL(count) - sounddata(0, count) - outX + WScale(count)
                Next count
            End If

            OUTNCoverall = 0
            For count = 0 To 7
                Octaves(count) = OUTascale(count)
                OUTNCoverall = OUTNCoverall + 10.0 ^ (Octaves(count) / 10.0)
            Next count
            OUTNCoverall = 10.0 * (Math.Log(OUTNCoverall) / Math.Log(10.0))

        Catch ex As Exception
            ErrorMessage(ex, 5606)
        End Try
        Return OpenOutletCalcs
    End Function

    Public Function CalcBrg() As Double
        Try
            CalcBrg = 0.0
            NCN = final.speed
            BRGnoise = 21 * 0.4342944 * Math.Log(NCN)

        Catch ex As Exception
            ErrorMessage(ex, 5607)
        End Try
        Return CalcBrg
    End Function

    Public Function CalcBPFreq() As Double
        Try
            CalcBPFreq = 0.0
            NCN = final.speed
            BPfreq = (NCN / 60) * final.BladeNumber ' bladecount

        Catch ex As Exception
            ErrorMessage(ex, 5608)
        End Try
        Return CalcBPFreq
    End Function
    '
    '#####################################################################################
    '######  Acoustics Outputs  ##########################################################
    '#####################################################################################

    Public Function OutputSPL() As Double
        Try
            OutputSPL = 0.0
            Dim txtSPLlabel = New Label()
            txtSPLlabel.Text = Frmselectfan.lblSoundPowerLevel.Text + " (dB)"
            Frmselectfan.DataGridView2.Rows(0).Cells(0).Value = txtSPLlabel.Text
            Dim txtSPL(8) As Label
            For q As Integer = 0 To 7
                txtSPL(q) = New Label()
            Next q
            'IDSPL
            For i = 0 To 7
                txtSPL(i).Text = IDSPL(i).ToString
                Frmselectfan.DataGridView2.Rows(0).Cells(i + 1).Value = txtSPL(i).Text
            Next
            Frmselectfan.DataGridView2.Rows(0).Cells(9).Value = spl2.ToString
            Frmselectfan.DataGridView2.Rows(1).Cells(0).Value = Frmselectfan.lblBreakOut.Text + " " + Frmselectfan.lblSWL1m.Text
            Frmselectfan.DataGridView2.Rows(1).Cells(1).Value = bospl2.ToString
            Frmselectfan.DataGridView2.Rows(2).Cells(0).Value = Frmselectfan.lblBreakOut.Text + " " + Frmselectfan.lblSPL1m.Text
            Frmselectfan.DataGridView2.Rows(2).Cells(1).Value = bospl1M2.ToString
        Catch ex As Exception
            ErrorMessage(ex, 5609)
        End Try
        Return OutputSPL
    End Function

    Public Function OutputDuct(rownum As Integer) As Double
        Try
            OutputDuct = 0.0
            Dim txtSPLlabel = New Label()
            txtSPLlabel.Text = "**" + Frmselectfan.chkDuct.Text + " SPL @ 1m (dBA)"
            txtSPLlabel.Text = txtSPLlabel.Text.Replace("&&", "&")
            Frmselectfan.DataGridView2.Rows(rownum).Cells(0).Value = txtSPLlabel.Text
            Dim txtSPL(8) As Label
            For q As Integer = 0 To 7
                txtSPL(q) = New Label()
            Next q

            'IDSPL
            For i = 0 To 7
                txtSPL(i).Text = Ascale(i).ToString
                Frmselectfan.DataGridView2.Rows(rownum).Cells(i + 1).Value = txtSPL(i).Text
            Next
            Frmselectfan.DataGridView2.Rows(rownum).Cells(9).Value = NCoverall.ToString

        Catch ex As Exception
            ErrorMessage(ex, 5610)
        End Try
        Return OutputDuct
    End Function

    Public Function OutputOpenInlet(rownum As Integer) As Double
        Try
            OutputOpenInlet = 0.0
            Dim txtSPLlabel = New Label()
            txtSPLlabel.Text = "**" + Frmselectfan.chkOpenInlet.Text + " SPL @ 1m (dBA)"
            txtSPLlabel.Text = txtSPLlabel.Text.Replace("&&", "&")
            Frmselectfan.DataGridView2.Rows(rownum).Cells(0).Value = txtSPLlabel.Text
            Dim txtSPL(8) As Label
            For q As Integer = 0 To 7
                txtSPL(q) = New Label()
            Next q
            For i = 0 To 7
                txtSPL(i).Text = INascale(i).ToString
                Frmselectfan.DataGridView2.Rows(rownum).Cells(i + 1).Value = txtSPL(i).Text
            Next
            Frmselectfan.DataGridView2.Rows(rownum).Cells(9).Value = Math.Round(inNCoverall).ToString

        Catch ex As Exception
            ErrorMessage(ex, 5611)
        End Try
        Return OutputOpenInlet
    End Function

    Public Function OutputOpenOutlet(rownum As Integer) As Double
        Try
            OutputOpenOutlet = 0.0
            Dim txtSPLlabel = New Label()
            txtSPLlabel.Text = "**" + Frmselectfan.chkOpenOutlet.Text + " SPL @ 1m (dBA)"
            txtSPLlabel.Text = txtSPLlabel.Text.Replace("&&", "&")
            Frmselectfan.DataGridView2.Rows(rownum).Cells(0).Value = txtSPLlabel.Text
            Dim txtSPL(8) As Label
            For q As Integer = 0 To 7
                txtSPL(q) = New Label()
            Next q
            For i = 0 To 7
                txtSPL(i).Text = OUTascale(i).ToString
                Frmselectfan.DataGridView2.Rows(rownum).Cells(i + 1).Value = txtSPL(i).Text
            Next
            Frmselectfan.DataGridView2.Rows(rownum).Cells(9).Value = Math.Round(OUTNCoverall).ToString

        Catch ex As Exception
            ErrorMessage(ex, 5612)
        End Try
        Return OutputOpenOutlet
    End Function

    Public Function OutputBrg(rownum) As Double
        Try
            OutputBrg = 0.0
            Dim txtSPLlabel = New Label()
            Dim txtSPL As Label
            If Frmselectfan.chkBrg.Checked = True Then
                txtSPLlabel.Text = Frmselectfan.chkBrg.Text + " (dBA)"
                Frmselectfan.DataGridView2.Rows(rownum).Cells(0).Value = txtSPLlabel.Text
                txtSPL = New Label()
                txtSPL.Text = BRGnoise.ToString
                Frmselectfan.DataGridView2.Rows(rownum).Cells(1).Value = txtSPL.Text
            Else
                Frmselectfan.DataGridView2.Rows(rownum).Cells(0).Value = ""
                Frmselectfan.DataGridView2.Rows(rownum).Cells(1).Value = ""
            End If

        Catch ex As Exception
            ErrorMessage(ex, 5613)
        End Try
        Return OutputBrg
    End Function

    Public Function OutputMotor(rownum) As Double
        Try
            OutputMotor = 0.0
            Dim txtSPLlabel = New Label()
            Dim txtSPL As Label
            If Frmselectfan.chkMotor.Checked = True Then
                txtSPLlabel.Text = Frmselectfan.chkMotor.Text + " (dBA)"
                Frmselectfan.DataGridView2.Rows(rownum).Cells(0).Value = txtSPLlabel.Text
                txtSPL = New Label()
                'IDSPL
                txtSPL.Text = Frmselectfan.txtMotordba.Text
                Frmselectfan.DataGridView2.Rows(rownum).Cells(1).Value = txtSPL.Text
                MTRnoise = CInt(Frmselectfan.txtMotordba.Text)
            Else
                Frmselectfan.DataGridView2.Rows(rownum).Cells(0).Value = ""
                Frmselectfan.DataGridView2.Rows(rownum).Cells(1).Value = ""
                MTRnoise = 0
            End If

        Catch ex As Exception
            ErrorMessage(ex, 5614)
        End Try
        Return OutputMotor
    End Function

    Public Function OutputBPF(rownum) As Double
        Try
            OutputBPF = 0.0
            Dim txtSPLlabel = New Label()
            Dim txtSPL As Label
            txtSPL = New Label()
            txtSPL.Text = BPfreq.ToString
            Frmselectfan.lblBPF2.Text = txtSPL.Text + " Hz"

        Catch ex As Exception
            ErrorMessage(ex, 5615)
        End Try
        Return OutputBPF
    End Function
End Module
