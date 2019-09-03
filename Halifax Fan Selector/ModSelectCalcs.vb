Module ModSelectCalcs
    'subroutines
    'NoSpeedNosize
    'calculate fan sizes & speeds

    'WithSpeedNoSize
    'calculate fan sizes with fixed speed

    'WithSizeVolPressure
    'calculate speed from fan size, volume and pressure

    'WithSpeedVolPressure
    'calculate size from fan speed, volume and pressure

    'ResHDandVolTD
    'calculate reserve head and voluem turndown

    Sub NoSpeedNosize(k)
        Try
            Call LoadFanData(fantypefilename(k), k)
            Call scaledensity(k, getscalefactor)
            If GetFanSize(k) = 0 Then
                failindex = failindex + 1
                fanfailures(failindex, 0) = fantypename(k)
                fanfailures(failindex, 1) = 9
                failurevalue(failindex) = ""
            Else
                Call GetFanSpeed(ModGetFanSize.GetFanSize(k), k)
            End If
        Catch ex As Exception
            ErrorMessage(ex, 5901)
        End Try
    End Sub

    Sub WithSpeedNoSize(k)
        Try
            Call LoadFanData(fantypefilename(k), k)
            '---running the suction correction to get the new density at the inlet
            Call scaledensity(k, getscalefactor)
            runonce = "no"
            Call GetSizeAtfixedSpeed(k)
            selected(k).speed = speed
        Catch ex As Exception
            ErrorMessage(ex, 5902)
        End Try
    End Sub

    Sub WithSizeVolPressure(k)
        Try
            If Val(Frmselectfan.Txtfansize.Text) >= fansizelimit(k) And fansizelimit(k) <> 0 Then
                failindex = failindex + 1
                fanfailures(failindex, 0) = fantypename(k)
                fanfailures(failindex, 1) = 9
                failurevalue(failindex) = ""
                Exit Sub
            Else
                Call LoadFanData(fantypefilename(k), k)
            End If
            Call scaledensity(k, getscalefactor)
            Call GetFanSpeed(Val(Frmselectfan.Txtfansize.Text), k)

        Catch ex As Exception
            ErrorMessage(ex, 5903)

        End Try
    End Sub

    Sub WithSpeedSizeVolume(k)
        Try
            Call LoadFanData(fantypefilename(k), k)
            If pressrise <> 0 Then
                Frmselectfan.Txtdens.Text = originaldensity
            End If
            Call scaledensity(k, getscalefactor)
            Call GetPressure(CDbl(Frmselectfan.Txtfansize.Text), CDbl(Frmselectfan.Txtfanspeed.Text), flowrate, k)
        Catch ex As Exception
            ErrorMessage(ex, 5904)
        End Try
    End Sub

    Sub ResHDandVolTD(fanno)
        Try
            fspmax = ScalePFSize(fsp(fanno, FanMaxCount(fanno)), datafansize(fanno), selected(fanno).fansize)
            ftpmax = ScalePFSize(ftp(fanno, FanMaxCount(fanno)), datafansize(fanno), selected(fanno).fansize)
            volmax = ScaleVFSize(vol(fanno, FanMaxCount(fanno)), datafansize(fanno), selected(fanno).fansize)
            '-scales for speed
            volmax = ScaleVFSpeed(volmax, datafanspeed(fanno), selected(fanno).speed)
            fspmax = ScalePFSpeed(fspmax, datafanspeed(fanno), selected(fanno).speed)
            ftpmax = ScalePFSpeed(ftpmax, datafanspeed(fanno), selected(fanno).speed)
            selected(fanno).VD = Math.Round((1 - volmax / selected(fanno).vol) * 100, 1)
            If PresType = 1 Then
                selected(fanno).resHD = Math.Round((1 - selected(fanno).ftp / ftpmax) * 100, 1)
            Else
                selected(fanno).resHD = Math.Round((1 - selected(fanno).fsp / fspmax) * 100, 1)
            End If
        Catch ex As Exception
            ErrorMessage(ex, 5905)
        End Try
    End Sub
End Module
