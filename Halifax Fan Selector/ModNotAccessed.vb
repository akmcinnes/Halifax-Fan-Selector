Module ModNotAccessed
    Sub WithSpeedWithSize(k) 'not used
        Try
            'If Val(Frmselectfan.Txtfansize.Text) >= fansizelimit(k) And fansizelimit(k) <> 0 Then'akm 150219
            '    Call LoadFanData(fantypesecfilename(k), k)
            'Else
            Call LoadFanData(fantypefilename(k), k)
            'End If'akm 150219
            Call scaledensity(k, getscalefactor)
            Call ScaleSizeSpeed(Frmselectfan.Txtfansize.Text, Frmselectfan.Txtfanspeed.Text, k)

        Catch ex As Exception
            'MsgBox("WithSpeedWithSize")
            ErrorMessage(ex, 5903)

        End Try
    End Sub

    Public Sub ScaleSizeSpeed(size, speed, fanno)
        Try
            'scaling most efficient datapoint values to the selected fan size
            fsps(fanno, medpoint(fanno)) = ScalePFSize(fsp(fanno, medpoint(fanno)), datafansize(fanno), size)
            ftps(fanno, medpoint(fanno)) = ScalePFSize(ftp(fanno, medpoint(fanno)), datafansize(fanno), size)
            vols(fanno, medpoint(fanno)) = ScaleVFSize(vol(fanno, medpoint(fanno)), datafansize(fanno), size)
            Pows(fanno, medpoint(fanno)) = ScalePowFSize(Powr(fanno, medpoint(fanno)), datafansize(fanno), size)
            '-scales for constant speed at each datapoint
            vols(fanno, medpoint(fanno)) = ScaleVFSpeed(vols(fanno, medpoint(fanno)), datafanspeed(fanno), speed)
            fsps(fanno, medpoint(fanno)) = ScalePFSpeed(fsps(fanno, medpoint(fanno)), datafanspeed(fanno), speed)
            ftps(fanno, medpoint(fanno)) = ScalePFSpeed(ftps(fanno, medpoint(fanno)), datafanspeed(fanno), speed)
            Pows(fanno, medpoint(fanno)) = ScalePowFSpeed(Pows(fanno, medpoint(fanno)), datafanspeed(fanno), speed)

            'correct for kp akm 260319
            '-end of scaling most efficient data point----- start of output to frmselections

            selected(fanno).fanindex = fanno

            selected(fanno).fansize = size
            '-calculated the fan speed required to get the duty
            '-now calculating the power
            selected(fanno).pow = Math.Round(Pows(fanno, medpoint(fanno)), 2)
            '-calculating fan static efficiency
            selected(fanno).fse = Math.Round(fse(fanno, medpoint(fanno)), 1)
            '-calculating fan total efficiency
            selected(fanno).fte = Math.Round(fte(fanno, medpoint(fanno)), 1)
            '-output volume
            Frmselectfan.Txtflow.Text = Math.Round(vols(fanno, medpoint(fanno)), voldecplaces)
            selected(fanno).fsp = Math.Round(fsps(fanno, medpoint(fanno)), 2)
            '-calculating FTP

            selected(fanno).ftp = Math.Round(ftps(fanno, medpoint(fanno)), 2)
            selected(fanno).fantype = fanclass(fanno)
            selected(fanno).speed = speed
            Call OutletVel(size, fanno)
            selected(fanno).inletdia = inletdia
            'selectedoutletd(fanno)=outletdia

            '---corecting for suction
            If Frmselectfan.Optsucy.Checked = True Then
                'Call SuctionCorrection(Val(selected(fanno).fsp), Val(selected(fanno).pow), Val(Frmselectfan.Txtdens.Text))
                Call SuctionCorrection(Val(selected(fanno).fsp), Val(selected(fanno).pow), knowndensity)
                selected(fanno).pow = Math.Round(NEWpower, 2)
                selected(fanno).fsp = Math.Round(NEWpressure, 2)
            End If

        Catch ex As Exception
            'MsgBox("scalesizespeed")
            ErrorMessage(ex, 5807)
        End Try
    End Sub

    Sub WithSpeedPressure(k) 'not used
        Try
            'If Val(Frmselectfan.Txtfansize.Text) >= fansizelimit(k) And fansizelimit(k) <> 0 Then'akm 150219
            '    Call LoadFanData(fantypesecfilename(k), k)
            'Else
            Call LoadFanData(fantypefilename(k), k)
            'End If'akm 150219
            Call scaledensity(k, getscalefactor)
            'Call GetVol(Val(Frmselectfan.Txtfansize.Text), Val(Frmselectfan.Txtfanspeed.Text), Val(Frmselectfan.Txtfsp.Text), k)
            Call GetVol(Val(Frmselectfan.Txtfansize.Text), Val(Frmselectfan.Txtfanspeed.Text), pressrise, k)

        Catch ex As Exception
            'MsgBox("WithSpeedPressure")
            ErrorMessage(ex, 5906)

        End Try
    End Sub

    Public Sub GetVol(ssize, speed, pressure, fanno) 'not used
        Try
            count1 = 0
            Do While fsp(fanno, count1) <> 0
                '-scaling for fan sizes
                fsps(fanno, count1) = ScalePFSize(fsp(fanno, count1), datafansize(fanno), ssize)
                ftps(fanno, count1) = ScalePFSize(ftp(fanno, count1), datafansize(fanno), ssize)
                vols(fanno, count1) = ScaleVFSize(vol(fanno, count1), datafansize(fanno), ssize)
                Pows(fanno, count1) = ScalePowFSize(Powr(fanno, count1), datafansize(fanno), ssize)
                '-scales for constant volume at each datapoint
                vols(fanno, count1) = ScaleVFSpeed(vols(fanno, count1), datafanspeed(fanno), speed)
                fsps(fanno, count1) = ScalePFSpeed(fsps(fanno, count1), datafanspeed(fanno), speed)
                ftps(fanno, count1) = ScalePFSpeed(ftps(fanno, count1), datafanspeed(fanno), speed)
                Pows(fanno, count1) = ScalePowFSpeed(Pows(fanno, count1), datafanspeed(fanno), speed)
                'correct for kp akm 260319
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
                    Call GetVol(ssize, speed, Math.Round(PressCheck1, 2) - 0.01, fanno)
                    failindex = failindex + 1
                    fanfailures(failindex, 0) = fantypename(fanno)
                    'fanfailures(failindex, 1) = "Pressure cannot be achieved with a " & fanclass(fanno) & " Fan at this size and speed, the Max Pressure available is " & Math.Round(PressCheck1, 2)
                    fanfailures(failindex, 1) = 3 ' "Pressure cannot be achieved at this size and speed, the Max Pressure available is " & Math.Round(PressCheck1, 2)
                    failurevalue(failindex) = Math.Round(PressCheck1, 2).ToString
                    Exit Sub
                End If
                If pressure < PressCheck2 And PressCheck1 = 0 Then
                    'MsgBox("Fan type 1; " & fanclass(fanno) & " Pressure is too low and falls outside performance data, suggest a pressure above " & Math.Round(fsps(fanno, count1 - 1), 2) & " " & Frmselectfan.ColumnHeader(4) & Chr(13) & "the pressure has been changed to suit the lowest pressure within the performance data!", vbInformation)
                    Call GetVol(ssize, speed, Math.Round(fsps(fanno, count1 - 1), 2) + 0.01, fanno)
                    failindex = failindex + 1
                    fanfailures(failindex, 0) = fantypename(fanno)
                    'fanfailures(failindex, 1) = fanclass(fanno) & " Pressure is too low and falls outside performance data, suggest a pressure above " & Math.Round(fsps(fanno, count1 - 1), 2)
                    fanfailures(failindex, 1) = 4 '"Pressure is too low and falls outside performance data, suggest a pressure above " & Math.Round(fsps(fanno, count1 - 1), 2)
                    failurevalue(failindex) = Math.Round(fsps(fanno, count1 - 1), 2).ToString
                    Exit Sub
                End If
            Else
                PressCheck2 = ftps(fanno, datapoint2)
                If pressure > PressCheck2 And pressure > PressCheck1 Then
                    'MsgBox("Fan type 1; Pressure cannot be achieved with a " & fanclass(fanno) & " Fan at this size and speed, the Max Pressure available is " & Math.Round(PressCheck1, 2) & " " & Frmselectfan.ColumnHeader(4) & (Chr(10)) & "the pressure has been changed to suit the highest pressure available!", vbInformation)
                    Call GetVol(ssize, speed, Math.Round(ftps(fanno, count), 2) - 0.01, fanno)
                    failindex = failindex + 1
                    fanfailures(failindex, 0) = fantypename(fanno)
                    'fanfailures(failindex, 1) = "Pressure cannot be achieved with a " & fanclass(fanno) & " Fan at this size and speed, the Max Pressure available is " & Math.Round(PressCheck1, 2)
                    fanfailures(failindex, 1) = 5 '"Pressure cannot be achieved with at this size and speed, the Max Pressure available is " & Math.Round(PressCheck1, 2)
                    failurevalue(failindex) = Math.Round(PressCheck1, 2).ToString
                    Exit Sub
                End If
                If pressure < ftps(fanno, datapoint2) And PressCheck1 = 0 Then
                    'MsgBox("Fan type 1; " & fanclass(fanno) & " Pressure is too low and falls outside performance data, suggest a pressure above " & Math.Round(ftps(fanno, count1 - 1), 2) & " " & Frmselectfan.ColumnHeader(4) & Chr(13) & "the pressure has been changed to suit the lowest pressure within the performance data!", vbInformation)
                    Call GetVol(ssize, speed, Math.Round(ftps(fanno, count1 - 1), 2) + 0.01, fanno)
                    failindex = failindex + 1
                    fanfailures(failindex, 0) = fantypename(fanno)
                    'fanfailures(failindex, 1) = fanclass(fanno) & " Pressure is too low and falls outside performance data, suggest a pressure above " & Math.Round(ftps(fanno, count1 - 1), 2)
                    fanfailures(failindex, 1) = 6 '"Pressure is too low and falls outside performance data, suggest a pressure above " & Math.Round(ftps(fanno, count1 - 1), 2)
                    failurevalue(failindex) = Math.Round(ftps(fanno, count1 - 1), 2).ToString
                    Exit Sub
                End If
            End If

            '-rescaling data for the selected fan size
            Frmselectfan.Txtfanspeed.Text = speed
            Frmselectfan.Txtfansize.Text = ssize
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
            Call OutletVel(ssize, fanno)

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
            'ErrorMessage(ex, 5702)
            failindex = failindex + 1
            fanfailures(failindex, 0) = fantypename(fanno)
            fanfailures(failindex, 1) = ex.Message
            failurevalue(failindex) = ""
        End Try
    End Sub

    Sub ModifyDatapoints(ByVal fanno As Integer, ByVal count1 As Integer, ByVal fsize As Double, ByVal fspeed As Double, ByVal num As Integer)
        Try
            fsps(fanno, count1) = ScalePFSize(fsp(fanno, count1), datafansize(fanno), fsize)
            ftps(fanno, count1) = ScalePFSize(ftp(fanno, count1), datafansize(fanno), fsize)
            vols(fanno, count1) = ScaleVFSize(vol(fanno, count1), datafansize(fanno), fsize)
            Pows(fanno, count1) = ScalePowFSize(Powr(fanno, count1), datafansize(fanno), fsize)
            '-scales for constant volume at each datapoint
            'If (num = 1) Then
            '    fspeed = Val(Frmselectfan.Txtflow.Text) * datafanspeed(fanno) / vols(fanno, count1)
            '    vols(fanno, count1) = Val(Frmselectfan.Txtflow.Text)
            'ElseIf (num = 2) Then
            '    vols(fanno, count1) = ScaleVFSpeed(vols(fanno, count1), datafanspeed(fanno), fspeed)
            'ElseIf (num = 3) Then
            '    ftspeed(fanno, count1) = Val(Frmselectfan.Txtflow.Text) * datafanspeed(fanno) / vols(fanno, count1)
            '    vols(fanno, count1) = Val(Frmselectfan.Txtflow.Text)
            'ElseIf (num = 4) Then
            '    fspeed = Val(Frmselectfan.Txtfanspeed.Text)
            '    vols(fanno, count1) = ScaleVFSpeed(vols(fanno, count1), datafanspeed(fanno), fspeed)
            'End If
            If (num = 1) Then
                fspeed = flowrate * datafanspeed(fanno) / vols(fanno, count1)
                vols(fanno, count1) = flowrate
            ElseIf (num = 2) Then
                vols(fanno, count1) = ScaleVFSpeed(vols(fanno, count1), datafanspeed(fanno), fspeed)
            ElseIf (num = 3) Then
                ftspeed(fanno, count1) = flowrate * datafanspeed(fanno) / vols(fanno, count1)
                vols(fanno, count1) = flowrate
            ElseIf (num = 4) Then
                fspeed = Val(Frmselectfan.Txtfanspeed.Text)
                vols(fanno, count1) = ScaleVFSpeed(vols(fanno, count1), datafanspeed(fanno), fspeed)
            End If
            fsps(fanno, count1) = ScalePFSpeed(fsps(fanno, count1), datafanspeed(fanno), fspeed)
            ftps(fanno, count1) = ScalePFSpeed(ftps(fanno, count1), datafanspeed(fanno), fspeed)
            Pows(fanno, count1) = ScalePowFSpeed(Pows(fanno, count1), datafanspeed(fanno), fspeed)
            'correct for kp akm 260319
            'count1 = count1 + 1

        Catch ex As Exception
            ErrorMessage(ex, 5512)
        End Try
    End Sub
End Module
