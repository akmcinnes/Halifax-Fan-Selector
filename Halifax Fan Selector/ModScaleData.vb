Module ModScaleData
    'subroutines and Functions
    'ScalePFSize
    'scale pressure for size

    'ScaleVFSize
    'scale volume for size

    'ScalePowFSize
    'scale power for size

    'ScalePFSpeed
    'scale pressure for speed

    'ScaleVFSpeed
    'scale volume for speed

    'ScalePowFSpeed
    'scale power for speed

    'CorrectForKP
    'calculate correction forcompressibility

    'CorrectDDArea
    'calculate correction for discharge duct area

    'GetFanSpeed
    'interate through deisgns & diameters, correcting for kp, etc to calculate optimum speed

    'OutletVel
    'calculate outlet velocity for selected fan

    'AnyOutletVel
    'calculate inlet and outlet dimensions for selected fan

    Public Function ScalePFSize(P1, d1, d2)
        ScalePFSize = 0.0
        Try
            If d2 < 15 Then
                ScalePFSize = d2 * (1 - ((15 - d2) ^ 3) / 3000)
            Else
                ScalePFSize = d2
            End If
            ScalePFSize = P1 * (ScalePFSize / d1) ^ 2
        Catch ex As Exception
            ErrorMessage(ex, 5801)
        End Try
    End Function

    Public Function ScaleVFSize(V1, d1, d2)
        ScaleVFSize = 0.0
        Try
            If d2 < 15 Then
                ScaleVFSize = d2 * (1 - ((15 - d2) ^ 3) / 3000)
            Else
                ScaleVFSize = d2
            End If
            ScaleVFSize = V1 * (ScaleVFSize / d1) ^ 3
        Catch ex As Exception
            ErrorMessage(ex, 5802)
        End Try
    End Function

    Public Function ScalePowFSize(Pow1, d1, d2)
        ScalePowFSize = 0.0
        Try
            ScalePowFSize = Pow1 * (d2 / d1) ^ 5
        Catch ex As Exception
            ErrorMessage(ex, 5803)
        End Try
    End Function

    Public Function ScalePFSpeed(P1, N1, N2)
        ScalePFSpeed = 0.0
        Try
            ScalePFSpeed = P1 * (N2 / N1) ^ 2
        Catch ex As Exception
            ErrorMessage(ex, 5804)
        End Try
    End Function

    Public Function ScaleVFSpeed(V1, N1, N2)
        ScaleVFSpeed = 0.0
        Try
            ScaleVFSpeed = V1 * (N2 / N1)
        Catch ex As Exception
            ErrorMessage(ex, 5805)
        End Try
    End Function

    Public Function ScalePowFSpeed(Pow1, N1, N2)
        ScalePowFSpeed = 0.0
        Try
            ScalePowFSpeed = Pow1 * (N2 / N1) ^ 3
        Catch ex As Exception
            ErrorMessage(ex, 5806)
        End Try
    End Function

    Public Function CorrectForKP(P1, kpatmos)
        CorrectForKP = P1
        Try
            Dim calckp As Double = 1.0
            calckp = CalculateKP(1.4, kpatmos, P1, 0)
            CorrectForKP = P1 * 1.0 / calckp
        Catch ex As Exception
            ErrorMessage(ex, 5807)
        End Try
    End Function

    Public Function CorrectforDDArea(o1, d1, d2)
        Dim correction As Double = 1.0
        Dim stdDDarea As Double
        Try
            stdDDarea = (o1 * (d2 / d1) ^ 2)
            correction = (stdDDarea ^ 2) / (DDInputArea ^ 2)
            Return correction
        Catch ex As Exception
            ErrorMessage(ex, 5808)
            Return correction
        End Try
    End Function

    Public Sub GetFanSpeed(fansize, fanno)
        Try
            count1 = 0
            Do While fsp(fanno, count1) <> 0
                '-scaling for fan sizes
                fsps(fanno, count1) = ScalePFSize(fsp(fanno, count1), datafansize(fanno), fansize)
                ftps(fanno, count1) = ScalePFSize(ftp(fanno, count1), datafansize(fanno), fansize)
                vols(fanno, count1) = ScaleVFSize(vol(fanno, count1), datafansize(fanno), fansize)
                Pows(fanno, count1) = ScalePowFSize(Powr(fanno, count1), datafansize(fanno), fansize)
                If Frmselectfan.optDDUserDefined.Checked = True Then
                    fsps(fanno, count1) = fsps(fanno, count1) - CorrectforDDArea(dataoutletarea(fanno), datafansize(fanno), fansize)
                End If
                '-scales for constant volume at each datapoint
                ftspeed(fanno, count1) = Val(Frmselectfan.Txtflow.Text) * datafanspeed(fanno) / vols(fanno, count1)
                vols(fanno, count1) = flowrate
                fsps(fanno, count1) = ScalePFSpeed(fsps(fanno, count1), datafanspeed(fanno), ftspeed(fanno, count1))
                ftps(fanno, count1) = ScalePFSpeed(ftps(fanno, count1), datafanspeed(fanno), ftspeed(fanno, count1))
                Pows(fanno, count1) = ScalePowFSpeed(Pows(fanno, count1), datafanspeed(fanno), ftspeed(fanno, count1))
                Dim tempkp As Double = 1.0
                If Frmselectfan.chkKP.Checked = False Then
                    tempkp = CalculateKP(1.4, kpatmos, fsps(fanno, count1), 0)
                    fsps(fanno, count1) = fsps(fanno, count1) * 1.0 / tempkp '270919
                    'fsps(fanno, count1) = fsps(fanno, count1) * tempkp '270919
                    tempkp = CalculateKP(1.4, kpatmos, ftps(fanno, count1), 0)
                    ftps(fanno, count1) = ftps(fanno, count1) * 1.0 / tempkp
                    'ftps(fanno, count1) = ftps(fanno, count1) * tempkp
                End If
                count1 = count1 + 1
            Loop
            '--------------------------------------------
            If Val(datapointI(fanno, fansize)) = 0 Then '-subsection to find the right datapoint where pressure is nearest for fans
                '-where the size has been specified by the user
                count = 0
                If PresType = 0 Then
                    Do While (fsps(fanno, count) - pressrise) ^ 2 > (fsps(fanno, count + 1) - pressrise) ^ 2
                        count = count + 1
                    Loop
                Else
                    Do While (ftps(fanno, count) - pressrise) ^ 2 > (ftps(fanno, count + 1) - pressrise) ^ 2
                        count = count + 1
                    Loop
                End If
                datapoint3 = count
            Else
                datapoint3 = datapointI(fanno, fansize) '--datapoint found from getfansize sub-program
            End If
            If PresType = 0 Then
                PressCheck3 = fsps(fanno, datapoint3)
            Else
                PressCheck3 = ftps(fanno, datapoint3)
            End If
            If PressCheck3 > pressrise Then
                datapoint2 = datapoint3 + 1
            Else
                datapoint2 = datapoint3 - 1
            End If
            '---checking the pressure is achievable with this volume fan size and type
            If PresType = 0 Then
                PressCheck2 = fsps(fanno, datapoint2)
            Else
                PressCheck2 = ftps(fanno, datapoint2)
            End If
            If pressrise > PressCheck2 And pressrise > PressCheck3 Then
                failindex = failindex + 1
                fanfailures(failindex, 0) = fantypename(fanno)
                fanfailures(failindex, 1) = 7 '"Pressure cannot be achieved at this volume, the Max Pressure available is " & Math.Round(PressCheck3, 2)
                failurevalue(failindex) = Math.Round(PressCheck3, 2).ToString
                Exit Sub
            End If
            If pressrise < PressCheck2 And PressCheck3 = 0 Then
                failindex = failindex + 1
                fanfailures(failindex, 0) = fantypename(fanno)
                fanfailures(failindex, 1) = 8 ' "Pressure is too low at this volume and falls outside performance data, suggest a pressure above " & Math.Round(fsps(fanno, count1 - 1), 2)
                failurevalue(failindex) = Math.Round(fsps(fanno, count1 - 1), 2).ToString
                Exit Sub
            End If
            'rescaling data for the selected fan size
            grad = (ftspeed(fanno, datapoint3) - ftspeed(fanno, datapoint2)) / (PressCheck3 - PressCheck2)
            selected(fanno).speed = ftspeed(fanno, datapoint3) + ((pressrise - PressCheck3) * grad)
            selected(fanno).speed = Math.Round(selected(fanno).speed, 0)
            selected(fanno).fansize = fansize 'akm
            '-calculated the fan speed required to get the duty
            '-now calculating the power
            gradpow = (Pows(fanno, datapoint3) - Pows(fanno, datapoint2)) / (ftspeed(fanno, datapoint3) - ftspeed(fanno, datapoint2))
            selected(fanno).pow = Pows(fanno, datapoint3) + ((((selected(fanno).speed - ftspeed(fanno, datapoint3))) * gradpow))
            selected(fanno).pow = Math.Round(selected(fanno).pow, 2)
            '-calculating fan static efficiency
            gradfse = (fse(fanno, datapoint3) - fse(fanno, datapoint2)) / (ftspeed(fanno, datapoint3) - ftspeed(fanno, datapoint2))
            selected(fanno).fse = fse(fanno, datapoint3) + ((((selected(fanno).speed - ftspeed(fanno, datapoint3))) * gradfse))
            selected(fanno).fse = selected(fanno).fse / selected(fanno).Kp
            selected(fanno).fse = Math.Round(selected(fanno).fse, 1)
            '-calculating fan total efficiency
            gradfte = (fte(fanno, datapoint3) - fte(fanno, datapoint2)) / (ftspeed(fanno, datapoint3) - ftspeed(fanno, datapoint2))
            selected(fanno).fte = fte(fanno, datapoint3) + ((((selected(fanno).speed - ftspeed(fanno, datapoint3))) * gradfte))
            selected(fanno).fte = selected(fanno).fte / selected(fanno).Kp
            selected(fanno).fte = Math.Round(selected(fanno).fte, 1)
            '-output volume
            Frmselectfan.Txtflow.Text = Frmselectfan.Txtflow.Text
            '-calculating outlet velocity
            Call OutletVel(fansize, fanno)
            selected(fanno).inletdia = datainletdia(fanno)
            selected(fanno).outletarea = dataoutletarea(fanno)
            selected(fanno).outletlen = dataoutletlen(fanno)
            selected(fanno).outletwid = dataoutletwid(fanno)
            selected(fanno).outletdia = dataoutletdia(fanno)
            '-calculating FSP
            gradfsp = (fsps(fanno, datapoint3) - fsps(fanno, datapoint2)) / (ftspeed(fanno, datapoint3) - ftspeed(fanno, datapoint2))
            selected(fanno).fsp = fsps(fanno, datapoint3) + ((((selected(fanno).speed - ftspeed(fanno, datapoint3))) * gradfsp))
            selected(fanno).fsp = Math.Round(selected(fanno).fsp, 2)
            '-calculating FTP
            gradftp = (ftps(fanno, datapoint3) - ftps(fanno, datapoint2)) / (ftspeed(fanno, datapoint3) - ftspeed(fanno, datapoint2))
            selected(fanno).ftp = ftps(fanno, datapoint3) + ((((selected(fanno).speed - ftspeed(fanno, datapoint3))) * gradftp))
            selected(fanno).ftp = Math.Round(selected(fanno).ftp, 2)
            selected(fanno).fantype = fanclass(fanno)
            selected(fanno).fantypename = fantypename(fanno)
            '-----bringing the fan upto the duty speed after the first quick cslculations
            uptospeed = Val(selected(fanno).speed)
            TempPress = temppressure
            count = 0
            Do While difference1 >= difference2
                Call GetPressure(Val(selected(fanno).fansize), uptospeed, flowrate, fanno)
                If PresType = 0 Then
                    difference1 = Math.Sqrt((TempPress - Val(selected(fanno).fsp)) ^ 2)
                Else
                    difference1 = Math.Sqrt((TempPress - Val(selected(fanno).ftp)) ^ 2)
                End If
                Call GetPressure(Val(selected(fanno).fansize), uptospeed + 1, flowrate, fanno)
                If PresType = 0 Then
                    difference2 = Math.Sqrt((TempPress - Val(selected(fanno).fsp)) ^ 2)
                Else
                    difference2 = Math.Sqrt((TempPress - Val(selected(fanno).ftp)) ^ 2)
                End If
                uptospeed = uptospeed + 1
            Loop
            Call GetPressure(Val(selected(fanno).fansize), uptospeed - 1, flowrate, fanno)
        Catch ex As Exception
            failindex = failindex + 1
            fanfailures(failindex, 0) = fantypename(fanno)
            fanfailures(failindex, 1) = ex.Message
            failurevalue(failindex) = ""
        End Try
    End Sub

    Public Sub OutletVel(fansize, fanno)
        Try
            outletsize = dataoutletarea(fanno) * (fansize / datafansize(fanno)) ^ 2
            outletsize = outletsize - (casethickness / 1000) ^ 2
            If DDInputArea > 0.0 Then
                Select Case Units(8).UnitSelected
                    Case 0
                        outletsize = DDInputArea
                    Case 1
                        outletsize = DDInputArea * 0.09290304
                End Select
            End If
            If DDInputRatio > 0.0 Then
                outletsize = outletsize * DDInputRatio
            End If
            inletdia = datainletdia(fanno) * (fansize / datafansize(fanno))
            inletdia = inletdia - (casethickness * 2)
            outletlength = dataoutletlen(fanno) * (fansize / datafansize(fanno))
            outletwidth = dataoutletwid(fanno) * (fansize / datafansize(fanno))
            Select Case Units(0).UnitSelected
                Case 0
                    selected(fanno).ov = (flowrate / 3600) / outletsize'm3/hr
                Case 1
                    selected(fanno).ov = (flowrate / 60) / outletsize'm3/min
                Case 2
                    selected(fanno).ov = flowrate / outletsize'm3/sec
                Case 3
                    selected(fanno).ov = (flowrate / 2119.0) / outletsize 'cfm
                Case 4
                    selected(fanno).ov = (flowrate / 3600) / outletsize 'cfm
                Case 5
                    selected(fanno).ov = (flowrate / 2119.0) / outletsize 'cfm
            End Select
            If Units(7).UnitSelected = 1 Then
                selected(fanno).ov = selected(fanno).ov * 196.850394 '/ convvel
            End If
            selected(fanno).ov = Math.Round(Val(selected(fanno).ov), 2)
        Catch ex As Exception
            ErrorMessage(ex, 5810)
        End Try
    End Sub

    Public Function AnyOutletVel(fansize, Volume, FanPick)
        AnyOutletVel = 0.0
        Try
            outletsize = dataoutletarea(FanPick) * (fansize / datafansize(FanPick)) ^ 2
            outletlength = dataoutletlen(FanPick) * (fansize / datafansize(FanPick))
            outletwidth = dataoutletwid(FanPick) * (fansize / datafansize(FanPick))
            inletdia = datainletdia(FanPick) * (fansize / datafansize(FanPick))
            inletdia = inletdia - (casethickness * 2)
            'If FlowType = 4 Then
            If Units(0).UnitSelected = 3 Then
                outletsize = dataoutletareaftsq(FanPick) * (fansize / datafansize(FanPick)) ^ 2
            End If
            Select Case Units(0).UnitSelected
                Case 0 'm³/hr
                    AnyOutletVel = (Volume / 3600) / (outletsize - (casethickness / 1000) ^ 2)
                Case 1 'm³/min
                    AnyOutletVel = (Volume / 60) / (outletsize - (casethickness / 1000) ^ 2)
                Case 2 'm³/sec
                    AnyOutletVel = Volume / (outletsize - (casethickness / 1000) ^ 2)
                Case 3 'cfm
                    AnyOutletVel = Volume / (outletsize - (casethickness / 304.8) ^ 2)
                Case 4 'm³/hr
                    AnyOutletVel = (Volume / 3600) / (outletsize - (casethickness / 1000) ^ 2)
                Case 5 'cfm
                    AnyOutletVel = Volume / (outletsize - (casethickness / 304.8) ^ 2)
            End Select
            Return AnyOutletVel
        Catch ex As Exception
            ErrorMessage(ex, 5811)
            Return 0.0
        End Try
    End Function
End Module
