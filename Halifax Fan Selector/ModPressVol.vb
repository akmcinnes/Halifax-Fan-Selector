Module ModPressVol
    Public Sub GetPressure(ssize, speed, Volume, fanno)
        Try
            Dim temp_fsp As Double
            temp_fsp = pressrise
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
                'correct for kp akm 260319 no size pole speed
                Dim tempkp As Double = 1.0
                tempkp = CalculateKP(1.4, kpatmos, fsps(fanno, count1), 0)
                If Frmselectfan.chkKP.Checked = False Then
                    fsps(fanno, count1) = fsps(fanno, count1) * tempkp '1.0 / tempkp1.0 / tempkp
                    ftps(fanno, count1) = ftps(fanno, count1) * tempkp '1.0 / tempkp1.0 / tempkp
                    Pows(fanno, count1) = Pows(fanno, count1) * tempkp '1.0 / tempkp1.0 / tempkp
                End If

                count1 = count1 + 1
            Loop
            count = 0
            Dim temp_flow As Double
            temp_flow = flowrate

            Do While (vols(fanno, count) - temp_flow) ^ 2 > (vols(fanno, count + 1) - temp_flow) ^ 2
                count = count + 1
            Loop
            datapoint3 = count
            '-finished now data is in correct size at constant volume
            '-looking at the selected fan size datapoint which best matches the pressure at constant volume
            '- looking either above or below the point to interpolate
            '-deciding if to interpolate between the previous or next datapoint
            If vols(fanno, datapoint3) < Volume Then
                datapoint2 = datapoint3 + 1
            Else
                datapoint2 = datapoint3 - 1
            End If

            If Volume > vols(fanno, datapoint2) And Volume > vols(fanno, datapoint3) Then
                Call GetPressure(ssize, speed, vols(fanno, count) - 0.01, fanno)
                failindex = failindex + 1
                fanfailures(failindex, 0) = fantypename(fanno)
                fanfailures(failindex, 1) = 1 '"Volume cannot be achieved at this size and speed, the Max Volume available is " & Math.Round(vols(fanno, datapoint3), 2)
                failurevalue(failindex) = Math.Round(vols(fanno, datapoint3), 2).ToString
                Exit Sub
            End If
            If Volume < vols(fanno, datapoint3) And vols(fanno, datapoint2) = 0 Then
                Call GetPressure(ssize, speed, vols(fanno, 1) + 0.01, fanno)
                failindex = failindex + 1
                fanfailures(failindex, 0) = fantypename(fanno)
                fanfailures(failindex, 1) = 2 '"The volume is too low and falls outside performance data, suggest a volume above " & Math.Round(vols(fanno, 1), 2)
                failurevalue(failindex) = Math.Round(vols(fanno, 1), 2).ToString
                Exit Sub
            End If

            '-rescaling data for the selected fan size
            Frmselectfan.Txtfanspeed.Text = speed
            Frmselectfan.Txtfansize.Text = ssize
            '-calculated the fan speed required to get the duty
            '-now calculating the power
            gradpow = (Pows(fanno, datapoint3) - Pows(fanno, datapoint2)) / (vols(fanno, datapoint3) - vols(fanno, datapoint2))
            selected(fanno).pow = Pows(fanno, datapoint3) + ((((Volume - vols(fanno, datapoint3))) * gradpow))
            selected(fanno).pow = selected(fanno).pow ' / temp_kp
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
            selected(fanno).fse = selected(fanno).fse ' * temp_kp
            selected(fanno).fse = Math.Round(selected(fanno).fse, 1)
            '-calculating fan total efficiency
            gradfte = (fte(fanno, datapoint3) - fte(fanno, datapoint2)) / (vols(fanno, datapoint3) - vols(fanno, datapoint2))
            selected(fanno).fte = fte(fanno, datapoint3) + ((((Volume - vols(fanno, datapoint3))) * gradfte))
            selected(fanno).fte = selected(fanno).fte ' * temp_kp
            selected(fanno).fte = Math.Round(selected(fanno).fte, 1)
            '-output volume
            selected(fanno).vol = Math.Round(Volume, voldecplaces)
            selected(fanno).fansize = ssize
            '--outlet velocity
            Call OutletVel(ssize, fanno)
            selected(fanno).BladeNumber = blade_number(fanno)
            selected(fanno).inletdia = datainletdia(fanno) * (selected(fanno).fansize / datafansize(fanno))
            selected(fanno).inletdia = selected(fanno).inletdia - (casethickness * 2)
            selected(fanno).outletlen = dataoutletlen(fanno) * (selected(fanno).fansize / datafansize(fanno))
            selected(fanno).outletwid = dataoutletwid(fanno) * (selected(fanno).fansize / datafansize(fanno))
            selected(fanno).outletdia = dataoutletdia(fanno) * (selected(fanno).fansize / datafansize(fanno))
            selected(fanno).outletdia = selected(fanno).outletdia - (casethickness * 2)
            selected(fanno).outletarea = dataoutletarea(fanno) * (selected(fanno).fansize / datafansize(fanno)) ^ 2
            If Frmselectfan.optDDUserDefined.Checked = True Then
                Dim ratioW2L As Double = DDInputArea / selected(fanno).outletarea
                selected(fanno).outletarea = DDInputArea
                selected(fanno).outletlen = selected(fanno).outletlen * ratioW2L ^ 0.5
                selected(fanno).outletwid = selected(fanno).outletwid * ratioW2L ^ 0.5
                selected(fanno).outletdia = selected(fanno).outletdia * ratioW2L ^ 0.5
            End If

            '-calculating FTP
            gradfsp = (fsps(fanno, datapoint3) - fsps(fanno, datapoint2)) / (vols(fanno, datapoint3) - vols(fanno, datapoint2))
            selected(fanno).fsp = fsps(fanno, datapoint3) + ((((Volume - vols(fanno, datapoint3))) * gradfsp))
            selected(fanno).fsp = Math.Round(selected(fanno).fsp, 2)

            gradftp = (ftps(fanno, datapoint3) - ftps(fanno, datapoint2)) / (vols(fanno, datapoint3) - vols(fanno, datapoint2))
            selected(fanno).ftp = ftps(fanno, datapoint3) + ((((Volume - vols(fanno, datapoint3))) * gradftp))
            selected(fanno).ftp = Math.Round(selected(fanno).ftp, 2)

            selected(fanno).fantype = fanclass(fanno)

            '---correcting for suction
            If Frmselectfan.Optsucy.Checked = True Then
                Call SuctionCorrection(Val(selected(fanno).fsp), Val(selected(fanno).pow), knowndensity)
                selected(fanno).pow = Math.Round(NEWpower, 2)
                selected(fanno).fsp = Math.Round(NEWpressure, 2)
                'Call SuctionCorrection(Val(selected(fanno).ftp), 0, Val(Frmselectfan.Txtdens.Text))
                Call SuctionCorrection(Val(selected(fanno).ftp), 0, knowndensity)
                selected(fanno).ftp = Math.Round(NEWpressure, 2)
            End If

        Catch ex As Exception
            failindex = failindex + 1
            fanfailures(failindex, 0) = fantypename(fanno)
            fanfailures(failindex, 1) = ex.Message
            failurevalue(failindex) = ""
        End Try
    End Sub
End Module
