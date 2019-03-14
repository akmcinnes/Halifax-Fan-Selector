Module ModPressVol
    Public Sub GetPressure(size, speed, Volume, fanno)
        Try
            Dim temp_kp As Double = kp
            If Frmselectfan.chkKP.Checked = True Then temp_kp = 1.0


            Dim temp_fsp As Double
            'temp_fsp = CDbl(Frmselectfan.Txtfsp.Text)
            temp_fsp = pressrise
            '        If Val(Frmselectfan.Txtfsp.Text) <> 0 Then
            'If temp_fsp <> 0 Then '300119
            '    correctedforSUCTIONS(fanno) = "no" '300119
            'End If '300119
            count1 = 0
            Do While fsp(fanno, count1) <> 0
                '-scaling for fan sizes
                'Call ModifyDatapoints(fanno, count1, size, speed, 2)
                fsps(fanno, count1) = ScalePFSize(fsp(fanno, count1), datafansize(fanno), size)
                ftps(fanno, count1) = ScalePFSize(ftp(fanno, count1), datafansize(fanno), size)
                vols(fanno, count1) = ScaleVFSize(vol(fanno, count1), datafansize(fanno), size)
                Pows(fanno, count1) = ScalePowFSize(Powr(fanno, count1), datafansize(fanno), size)
                '-scales for constant volume at each datapoint
                vols(fanno, count1) = ScaleVFSpeed(vols(fanno, count1), datafanspeed(fanno), speed)
                fsps(fanno, count1) = ScalePFSpeed(fsps(fanno, count1), datafanspeed(fanno), speed)
                ftps(fanno, count1) = ScalePFSpeed(ftps(fanno, count1), datafanspeed(fanno), speed)
                Pows(fanno, count1) = ScalePowFSpeed(Pows(fanno, count1), datafanspeed(fanno), speed)
                count1 = count1 + 1
            Loop
            count = 0
            Dim temp_flow As Double
            'temp_flow = CDbl(Frmselectfan.Txtflow.Text)
            temp_flow = flowrate
            'If Units(0).UnitSelected = 4 Then
            '    temp_flow = temp_flow * CDbl(Frmselectfan.TxtDensity.Text)
            'End If

            Do While (vols(fanno, count) - temp_flow) ^ 2 > (vols(fanno, count + 1) - temp_flow) ^ 2
                count = count + 1
            Loop
            datapoint3 = count
            '-finished now data is in corect size at constant volume
            '-looking at the selected fan size datapoint which best matches the pressure at constant volume
            '- looking either above or below the point to interpolate
            '-deciding if to interpolate between the previous or next datapoint
            If vols(fanno, datapoint3) < Volume Then
                datapoint2 = datapoint3 + 1
            Else
                datapoint2 = datapoint3 - 1
            End If
            'If datapoint2 < 0 Then datapoint2 = 0

            If Volume > vols(fanno, datapoint2) And Volume > vols(fanno, datapoint3) Then
                'MsgBox("Fan type 1; Volume cannot be achieved with a " & fanclass(fanno) & " Fan at this size and speed, the Max Volume available is " & Math.Round(vols(fanno, datapoint3), 2) & " " & FrmSelections.ColumnHeader(3) & (Chr(10)) & "the volume has been changed to suit the highest volume available!", vbInformation)
                Call GetPressure(size, speed, vols(fanno, count) - 0.01, fanno)
                failindex = failindex + 1
                fanfailures(failindex, 0) = fantypename(fanno)
                fanfailures(failindex, 1) = "Volume cannot be achieved with a " & fanclass(fanno) & " Fan at this size and speed, the Max Volume available is " & Math.Round(vols(fanno, datapoint3), 2)
                Exit Sub
            End If
            If Volume < vols(fanno, datapoint3) And vols(fanno, datapoint2) = 0 Then
                'MsgBox("Fan type 1; " & fanclass(fanno) & " volume is too low and falls outside performance data, suggest a volume above " & Math.Round(vols(fanno, 1), 2) & " " & FrmSelections.ColumnHeader(3) & Chr(13) & "the volume has been changed to suit the lowest volume within the performance data!", vbInformation)
                Call GetPressure(size, speed, vols(fanno, 1) + 0.01, fanno)
                failindex = failindex + 1
                fanfailures(failindex, 0) = fantypename(fanno)
                fanfailures(failindex, 1) = fanclass(fanno) & " volume is too low and falls outside performance data, suggest a volume above " & Math.Round(vols(fanno, 1), 2)
                Exit Sub
            End If

            '-rescaling data for the selected fan size
            Frmselectfan.Txtfanspeed.Text = speed
            Frmselectfan.Txtfansize.Text = size
            '-calculated the fan speed required to get the duty
            '-now calculating the power
            gradpow = (Pows(fanno, datapoint3) - Pows(fanno, datapoint2)) / (vols(fanno, datapoint3) - vols(fanno, datapoint2))
            selected(fanno).pow = Pows(fanno, datapoint3) + ((((Volume - vols(fanno, datapoint3))) * gradpow))
            selected(fanno).pow = selected(fanno).pow / temp_kp
            selected(fanno).pow = Math.Round(selected(fanno).pow, 2)
            selected(fanno).pow2 = Math.Round(selected(fanno).pow / 0.746, 2)
            selected(fanno).mot = GetMotorSize(selected(fanno).pow)
            selected(fanno).mot = Math.Round(selected(fanno).mot, 2)
            selected(fanno).mot2 = GetMotorSize(selected(fanno).pow / 0.746, True)
            selected(fanno).mot2 = Math.Round(selected(fanno).mot2, 2)

            selected(fanno).fanindex = fanno

            '-calculating fan static efficiency
            gradfse = (fse(fanno, datapoint3) - fse(fanno, datapoint2)) / (vols(fanno, datapoint3) - vols(fanno, datapoint2))
            selected(fanno).fse = fse(fanno, datapoint3) + ((((Volume - vols(fanno, datapoint3))) * gradfse))
            selected(fanno).fse = selected(fanno).fse * temp_kp
            selected(fanno).fse = Math.Round(selected(fanno).fse, 1)
            '-calculating fan total efficiency
            gradfte = (fte(fanno, datapoint3) - fte(fanno, datapoint2)) / (vols(fanno, datapoint3) - vols(fanno, datapoint2))
            selected(fanno).fte = fte(fanno, datapoint3) + ((((Volume - vols(fanno, datapoint3))) * gradfte))
            selected(fanno).fte = selected(fanno).fte * temp_kp
            selected(fanno).fte = Math.Round(selected(fanno).fte, 1)
            '-output volume
            selected(fanno).vol = Math.Round(Volume, voldecplaces)
            selected(fanno).fansize = size
            '--outlet velocity
            Call OutletVel(size, fanno)
            'selected(fanno).inletdia = datainletdia(fanno)
            'selected(fanno).outletarea = dataoutletarea(fanno)
            ''selected(fanno).inletdia = inletdia
            ''selected(fanno).outletarea = outletsize
            selected(fanno).BladeNumber = blade_number(fanno)
            'selected(fanno).outletlen = dataoutletlen(fanno)
            'selected(fanno).outletwid = dataoutletwid(fanno)
            ''selected(fanno).outletlen = outletlength
            ''selected(fanno).outletwid = outletwidth
            'selected(fanno).outletdia = dataoutletdia(fanno)
            ''selected(fanno).outletdia = outletdiameter

            selected(fanno).inletdia = datainletdia(fanno) * (selected(fanno).fansize / datafansize(fanno))
            selected(fanno).inletdia = selected(fanno).inletdia - (casethickness * 2)
            selected(fanno).outletlen = dataoutletlen(fanno) * (selected(fanno).fansize / datafansize(fanno))
            selected(fanno).outletwid = dataoutletwid(fanno) * (selected(fanno).fansize / datafansize(fanno))
            selected(fanno).outletdia = dataoutletdia(fanno) * (selected(fanno).fansize / datafansize(fanno))
            selected(fanno).outletdia = selected(fanno).outletdia - (casethickness * 2)
            selected(fanno).outletarea = dataoutletarea(fanno) * (selected(fanno).fansize / datafansize(fanno)) ^ 2


            '-calculating FTP
            gradfsp = (fsps(fanno, datapoint3) - fsps(fanno, datapoint2)) / (vols(fanno, datapoint3) - vols(fanno, datapoint2))
            selected(fanno).fsp = fsps(fanno, datapoint3) + ((((Volume - vols(fanno, datapoint3))) * gradfsp))
            selected(fanno).fsp = Math.Round(selected(fanno).fsp, 2)

            gradftp = (ftps(fanno, datapoint3) - ftps(fanno, datapoint2)) / (vols(fanno, datapoint3) - vols(fanno, datapoint2))
            selected(fanno).ftp = ftps(fanno, datapoint3) + ((((Volume - vols(fanno, datapoint3))) * gradftp))
            selected(fanno).ftp = Math.Round(selected(fanno).ftp, 2)

            selected(fanno).fantype = fanclass(fanno)

            '---corecting for suction
            If Frmselectfan.Optsucy.Checked = True Then
                'Call SuctionCorrection(Val(selected(fanno).fsp), Val(selected(fanno).pow), Val(Frmselectfan.Txtdens.Text))
                Call SuctionCorrection(Val(selected(fanno).fsp), Val(selected(fanno).pow), knowndensity)
                selected(fanno).pow = Math.Round(NEWpower, 2)
                selected(fanno).fsp = Math.Round(NEWpressure, 2)
                'Call SuctionCorrection(Val(selected(fanno).ftp), 0, Val(Frmselectfan.Txtdens.Text))
                Call SuctionCorrection(Val(selected(fanno).ftp), 0, knowndensity)
                selected(fanno).ftp = Math.Round(NEWpressure, 2)
            End If

        Catch ex As Exception
            'If StartArg.ToLower.Contains("-dev") Then
            '    ErrorMessage(ex, 5701)
            'End If
            failindex = failindex + 1
            fanfailures(failindex, 0) = fantypename(fanno)
            fanfailures(failindex, 1) = ex.Message
        End Try
    End Sub

    Public Sub GetVol(size, speed, pressure, fanno)
        Try
            count1 = 0
            Do While fsp(fanno, count1) <> 0
                '-scaling for fan sizes
                fsps(fanno, count1) = ScalePFSize(fsp(fanno, count1), datafansize(fanno), size)
                ftps(fanno, count1) = ScalePFSize(ftp(fanno, count1), datafansize(fanno), size)
                vols(fanno, count1) = ScaleVFSize(vol(fanno, count1), datafansize(fanno), size)
                Pows(fanno, count1) = ScalePowFSize(Powr(fanno, count1), datafansize(fanno), size)
                '-scales for constant volume at each datapoint
                vols(fanno, count1) = ScaleVFSpeed(vols(fanno, count1), datafanspeed(fanno), speed)
                fsps(fanno, count1) = ScalePFSpeed(fsps(fanno, count1), datafanspeed(fanno), speed)
                ftps(fanno, count1) = ScalePFSpeed(ftps(fanno, count1), datafanspeed(fanno), speed)
                Pows(fanno, count1) = ScalePowFSpeed(Pows(fanno, count1), datafanspeed(fanno), speed)
                count1 = count1 + 1
            Loop
            count = count1
            If PresType = 0 Then
                Do While (pressure - fsps(fanno, count)) ^ 2 > (pressure - fsps(fanno, count - 1)) ^ 2
                    count = count - 1
                    If count = 0 Then 'was 1
                        Exit Do
                    End If
                Loop
                PressCheck1 = fsps(fanno, count)
            Else
                Do While (pressure - ftps(fanno, count)) ^ 2 > (pressure - ftps(fanno, count - 1)) ^ 2
                    count = count - 1
                    If count = 0 Then ' was 1
                        Exit Do
                    End If
                Loop
                PressCheck1 = ftps(fanno, count)
            End If
            datapoint3 = count
            '-finished now data is in corect size at constant volume
            '-looking at the selected fan size datapoint which best matches the pressure at constant volume
            '- looking either above or below the point to interpolate
            '-deciding if to interpolate between the previous or next datapoint
            If PressCheck1 > pressure Then
                datapoint2 = datapoint3 + 1
            Else
                datapoint2 = datapoint3 - 1
            End If
            If PresType = 0 Then
                PressCheck2 = ftps(fanno, datapoint2)
                If pressure > PressCheck2 And pressure > PressCheck1 Then
                    'MsgBox("Fan type 1; Pressure cannot be achieved with a " & fanclass(fanno) & " Fan at this size and speed, the Max Pressure available is " & Math.Round(PressCheck1, 2) & " " & Frmselectfan.ColumnHeader(4) & (Chr(10)) & "the pressure has been changed to suit the highest pressure available!", vbInformation)
                    Call GetVol(size, speed, Math.Round(PressCheck1, 2) - 0.01, fanno)
                    failindex = failindex + 1
                    fanfailures(failindex, 0) = fantypename(fanno)
                    fanfailures(failindex, 1) = "Pressure cannot be achieved with a " & fanclass(fanno) & " Fan at this size and speed, the Max Pressure available is " & Math.Round(PressCheck1, 2)

                    Exit Sub
                End If
                If pressure < PressCheck2 And PressCheck1 = 0 Then
                    'MsgBox("Fan type 1; " & fanclass(fanno) & " Pressure is too low and falls outside performance data, suggest a pressure above " & Math.Round(fsps(fanno, count1 - 1), 2) & " " & Frmselectfan.ColumnHeader(4) & Chr(13) & "the pressure has been changed to suit the lowest pressure within the performance data!", vbInformation)
                    Call GetVol(size, speed, Math.Round(fsps(fanno, count1 - 1), 2) + 0.01, fanno)
                    failindex = failindex + 1
                    fanfailures(failindex, 0) = fantypename(fanno)
                    fanfailures(failindex, 1) = fanclass(fanno) & " Pressure is too low and falls outside performance data, suggest a pressure above " & Math.Round(fsps(fanno, count1 - 1), 2)

                    Exit Sub
                End If
            Else
                PressCheck2 = ftps(fanno, datapoint2)
                If pressure > PressCheck2 And pressure > PressCheck1 Then
                    'MsgBox("Fan type 1; Pressure cannot be achieved with a " & fanclass(fanno) & " Fan at this size and speed, the Max Pressure available is " & Math.Round(PressCheck1, 2) & " " & Frmselectfan.ColumnHeader(4) & (Chr(10)) & "the pressure has been changed to suit the highest pressure available!", vbInformation)
                    Call GetVol(size, speed, Math.Round(ftps(fanno, count), 2) - 0.01, fanno)
                    failindex = failindex + 1
                    fanfailures(failindex, 0) = fantypename(fanno)
                    fanfailures(failindex, 1) = "Pressure cannot be achieved with a " & fanclass(fanno) & " Fan at this size and speed, the Max Pressure available is " & Math.Round(PressCheck1, 2)

                    Exit Sub
                End If
                If pressure < ftps(fanno, datapoint2) And PressCheck1 = 0 Then
                    'MsgBox("Fan type 1; " & fanclass(fanno) & " Pressure is too low and falls outside performance data, suggest a pressure above " & Math.Round(ftps(fanno, count1 - 1), 2) & " " & Frmselectfan.ColumnHeader(4) & Chr(13) & "the pressure has been changed to suit the lowest pressure within the performance data!", vbInformation)
                    Call GetVol(size, speed, Math.Round(ftps(fanno, count1 - 1), 2) + 0.01, fanno)
                    failindex = failindex + 1
                    fanfailures(failindex, 0) = fantypename(fanno)
                    fanfailures(failindex, 1) = fanclass(fanno) & " Pressure is too low and falls outside performance data, suggest a pressure above " & Math.Round(ftps(fanno, count1 - 1), 2)

                    Exit Sub
                End If
            End If

            '-rescaling data for the selected fan size
            Frmselectfan.Txtfanspeed.Text = speed
            Frmselectfan.Txtfansize.Text = size
            '-calculated the fan speed required to get the duty
            '-now calculating the power
            gradpow = (Pows(fanno, datapoint2) - Pows(fanno, datapoint3)) / (PressCheck1 - PressCheck2)
            selected(fanno).pow = Pows(fanno, datapoint3) + ((((PressCheck1 - pressure)) * gradpow))
            selected(fanno).pow = Math.Round(selected(fanno).pow, 2)
            '-calculating fan static efficiency
            gradfse = (fse(fanno, datapoint2) - fse(fanno, datapoint3)) / (PressCheck1 - PressCheck2)
            selected(fanno).fse = fse(fanno, datapoint3) + ((((PressCheck1 - pressure)) * gradfse))
            selected(fanno).fse = Math.Round(selected(fanno).fse, 1)
            '-calculating fan total efficiency
            gradfte = (fte(fanno, datapoint2) - fte(fanno, datapoint3)) / (PressCheck1 - PressCheck2)
            selected(fanno).fte = fte(fanno, datapoint3) + ((((PressCheck1 - pressure)) * gradfte))
            selected(fanno).fte = Math.Round(selected(fanno).fte, 1)
            '-output fsp
            gradfsp = (fsps(fanno, datapoint2) - fsps(fanno, datapoint3)) / (PressCheck1 - PressCheck2)
            selected(fanno).fsp = fsps(fanno, datapoint3) + ((((PressCheck1 - pressure)) * gradfsp))
            selected(fanno).fsp = Math.Round(selected(fanno).fsp, 2)
            '-calculating volume
            gradvol = (vols(fanno, datapoint2) - vols(fanno, datapoint3)) / (PressCheck1 - PressCheck2)
            selected(fanno).vol = vols(fanno, datapoint3) + ((((PressCheck1 - pressure)) * gradvol))
            'selected(fanno).vol = Math.Round(Val(Frmselectfan.Txtflow.Text), voldecplaces)
            selected(fanno).vol = Math.Round(flowrate, voldecplaces)
            '--------calculating ftp
            gradftp = (ftps(fanno, datapoint2) - ftps(fanno, datapoint3)) / (PressCheck1 - PressCheck2)
            selected(fanno).ftp = ftps(fanno, datapoint3) + ((((PressCheck1 - pressure)) * gradftp))
            selected(fanno).ftp = Math.Round(selected(fanno).ftp, 2)
            '--outlet velocity
            Call OutletVel(size, fanno)

            selected(fanno).fansize = fanclass(fanno)
            'selected(fanno).BladeType = blade_type(fanno)'300119
            selected(fanno).BladeNumber = blade_number(fanno)
            selected(fanno).inletdia = datainletdia(fanno)
            selected(fanno).outletarea = dataoutletarea(fanno)
            'selected(fanno).inletdia = inletdia
            'selected(fanno).outletarea = outletsize
            selected(fanno).outletlen = dataoutletlen(fanno)
            selected(fanno).outletwid = dataoutletwid(fanno)
            'selected(fanno).outletlen = outletlength
            'selected(fanno).outletwid = outletwidth
            selected(fanno).outletdia = dataoutletdia(fanno)
            'selected(fanno).outletdia = outletdiameter


        Catch ex As Exception
            'MsgBox("getvol")
            ErrorMessage(ex, 5702)

        End Try
    End Sub
End Module
