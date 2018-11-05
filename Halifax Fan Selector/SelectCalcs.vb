Module SelectCalcs
    Sub NoSpeedNosize(k)
        Try
            Call loadfandata(fantypefilename(k), k)
            Call scaledensity(k, getscalefactor)
            Dim temp_size As Double
            '-----repeating if the fansize falls into the secondary data range
            temp_size = GetFanSize.GetFanSize(k)
            If temp_size >= fansizelimit(k) And Val(fansizelimit(k)) <> 0 Then
                Call LoadFanData(fantypesecfilename(k), k)
                Call scaledensity(k, getscalefactor)
            End If
            If GetFanSize.Getfansize(k) = 0 Then
                'MsgBox("The duty is outside the selected fantype duty range")
                'MsgBox("The duty is outside the " + fanclass(k) + " duty range")
            Else
                temp_size = GetFanSize.Getfansize(k)
                Call getfanspeed(GetFanSize.Getfansize(k), k)
            End If
        Catch ex As Exception
            MsgBox("NoSpeedNoSize")
        End Try
    End Sub

    Sub WithSpeedNoSize(k)
        Try
            Call loadfandata(fantypefilename(k), k)
            '---running the suction correction to get the new density at the inlet
            Call scaledensity(k, getscalefactor)
            runonce = "no"
            Call Getsizeatfixedspeed(k)

        Catch ex As Exception
            MsgBox("WithSpeedNoSize")
        End Try
    End Sub

    Sub WithSpeedWithSize(k)
        Try
            If Val(Frmselectfan.Txtfansize.Text) >= fansizelimit(k) And fansizelimit(k) <> 0 Then
                Call loadfandata(fantypesecfilename(k), k)
            Else
                Call loadfandata(fantypefilename(k), k)
            End If
            Call scaledensity(k, getscalefactor)
            Call scalesizespeed(Frmselectfan.Txtfansize.Text, Frmselectfan.Txtfanspeed.Text, k)

        Catch ex As Exception
            MsgBox("WithSpeedWithSize")
        End Try
    End Sub

    Sub WithSizeVolPressure(k)
        Try
            If Val(Frmselectfan.Txtfansize.Text) >= fansizelimit(k) And fansizelimit(k) <> 0 Then
                Call loadfandata(fantypesecfilename(k), k)
            Else
                Call loadfandata(fantypefilename(k), k)
            End If
            Call scaledensity(k, getscalefactor)
            Call getfanspeed(Val(Frmselectfan.Txtfansize.Text), k)

        Catch ex As Exception
            MsgBox("WithSizeVolPressure")
        End Try
    End Sub

    Sub WithSpeedSizeVolume(k)
        Try
            If Val(Frmselectfan.Txtfansize.Text) >= fansizelimit(k) And fansizelimit(k) <> 0 Then
                Call loadfandata(fantypesecfilename(k), k)
            Else
                Call loadfandata(fantypefilename(k), k)
            End If
            If Val(Frmselectfan.Txtfsp.Text) <> 0 Then
                Frmselectfan.Txtdens.Text = originaldensity
                'akmMsgBox("Fan Type " + k.ToString + ": " & fanclass(k) & ", A new value for Pressure has been calculated!", vbInformation)
            End If
            Call scaledensity(k, getscalefactor)
            Call getpressure(CDbl(Frmselectfan.Txtfansize.Text), CDbl(Frmselectfan.Txtfanspeed.Text), CDbl(Frmselectfan.Txtflow.Text), k)

        Catch ex As Exception
            MsgBox("WithSpeedSizeVolume")
        End Try
    End Sub

    Sub WithSpeedPressure(k)
        Try
            If Val(Frmselectfan.Txtfansize.Text) >= fansizelimit(k) And fansizelimit(k) <> 0 Then
                Call loadfandata(fantypesecfilename(k), k)
            Else
                Call loadfandata(fantypefilename(k), k)
            End If
            Call scaledensity(k, getscalefactor)
            Call getvol(Val(Frmselectfan.Txtfansize.Text), Val(Frmselectfan.Txtfanspeed.Text), Val(Frmselectfan.Txtfsp.Text), k)

        Catch ex As Exception
            MsgBox("WithSpeedPressure")
        End Try
    End Sub

    Sub ResHDandVolTD(fanno)
        Try
            fspmax = scalePFSize(fsp(fanno, FanMaxCount(fanno)), datafansize(fanno), selectedfansize(fanno))
            ftpmax = scalePFSize(ftp(fanno, FanMaxCount(fanno)), datafansize(fanno), selectedfansize(fanno))
            volmax = scaleVFSize(vol(fanno, FanMaxCount(fanno)), datafansize(fanno), selectedfansize(fanno))
            '-scales for speed
            volmax = scaleVFSpeed(volmax, datafanspeed(fanno), selectedspeed(fanno))
            fspmax = scalePFSpeed(fspmax, datafanspeed(fanno), selectedspeed(fanno))
            ftpmax = scalePFSpeed(ftpmax, datafanspeed(fanno), selectedspeed(fanno))
            selectedVD(fanno) = Math.Round((1 - volmax / selectedvol(fanno)) * 100, 1)
            If PresType = 1 Then
                selectedresHD(fanno) = Math.Round((1 - selectedftp(fanno) / ftpmax) * 100, 1)
            Else
                selectedresHD(fanno) = Math.Round((1 - selectedfsp(fanno) / fspmax) * 100, 1)
            End If

            'FrmSelections.txtpow1.BackColor = &H80FF80
            'PowMin = Val(FrmSelections.txtpow1.Value)

            'End If

        Catch ex As Exception
            MsgBox("ResHDandVolTD")
        End Try

    End Sub

End Module
