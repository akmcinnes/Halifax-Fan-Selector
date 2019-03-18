Module ModSelectCalcs
    Sub NoSpeedNosize(k)
        Try
            Call LoadFanData(fantypefilename(k), k)
            Call scaledensity(k, getscalefactor)
            Dim temp_size As Double
            '-----repeating if the fansize falls into the secondary data range
            temp_size = ModGetFanSize.GetFanSize(k)
            'If temp_size >= fansizelimit(k) And Val(fansizelimit(k)) <> 0 Then 'akm 150219
            '    Call LoadFanData(fantypesecfilename(k), k)
            '    Call scaledensity(k, getscalefactor)
            'End If
            If ModGetFanSize.GetFanSize(k) = 0 Then
                'MsgBox("The duty is outside the selected fantype duty range")
                'MsgBox("The duty is outside the " + fanclass(k) + " duty range")
                failindex = failindex + 1
                fanfailures(failindex, 0) = fanclass(k)
                'fanfailures(failindex, 1) = "The duty is outside the " + fanclass(k) + " duty range"
                fanfailures(failindex, 1) = "Sorry this duty is out of range for this fan type"

            Else
                temp_size = ModGetFanSize.GetFanSize(k)
                Call GetFanSpeed(ModGetFanSize.GetFanSize(k), k)
            End If
        Catch ex As Exception
            'MsgBox("NoSpeedNoSize")
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
            'selectedfansize(k) = Size

        Catch ex As Exception
            'MsgBox("WithSpeedNoSize")
            ErrorMessage(ex, 5902)

        End Try
    End Sub

    Sub WithSpeedWithSize(k)
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

    Sub WithSizeVolPressure(k)
        Try
            If Val(Frmselectfan.Txtfansize.Text) >= fansizelimit(k) And fansizelimit(k) <> 0 Then
                failindex = failindex + 1
                fanfailures(failindex, 0) = fantypename(k)
                fanfailures(failindex, 1) = "Sorry this duty is out of range for this fan type"

                Exit Sub
                'Call LoadFanData(fantypesecfilename(k), k)'akm 150219
            Else
                Call LoadFanData(fantypefilename(k), k)
            End If
            Call scaledensity(k, getscalefactor)
            Call GetFanSpeed(Val(Frmselectfan.Txtfansize.Text), k)

        Catch ex As Exception
            'MsgBox("WithSizeVolPressure")
            ErrorMessage(ex, 5904)

        End Try
    End Sub

    Sub WithSpeedSizeVolume(k)
        Try
            'If Val(Frmselectfan.Txtfansize.Text) >= fansizelimit(k) And fansizelimit(k) <> 0 Then'akm 150219
            '    Call LoadFanData(fantypesecfilename(k), k)
            'Else
            Call LoadFanData(fantypefilename(k), k)
            'End If'akm 150219
            'If Val(Frmselectfan.Txtfsp.Text) <> 0 Then
            If pressrise <> 0 Then
                Frmselectfan.Txtdens.Text = originaldensity
                'akmMsgBox("Fan Type " + k.ToString + ": " & fanclass(k) & ", A new value for Pressure has been calculated!", vbInformation)
            End If
            Call scaledensity(k, getscalefactor)
            'Call GetPressure(CDbl(Frmselectfan.Txtfansize.Text), CDbl(Frmselectfan.Txtfanspeed.Text), CDbl(Frmselectfan.Txtflow.Text), k)
            Call GetPressure(CDbl(Frmselectfan.Txtfansize.Text), CDbl(Frmselectfan.Txtfanspeed.Text), flowrate, k)


        Catch ex As Exception
            'MsgBox("WithSpeedSizeVolume")
            ErrorMessage(ex, 5905)

        End Try
    End Sub

    Sub WithSpeedPressure(k)
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

            'FrmSelections.txtpow1.BackColor = &H80FF80
            'PowMin = Val(FrmSelections.txtpow1.Value)

            'End If

        Catch ex As Exception
            'MsgBox("ResHDandVolTD")
            ErrorMessage(ex, 5907)

        End Try

    End Sub

End Module
