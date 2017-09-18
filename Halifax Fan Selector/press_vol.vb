Module press_vol
    Public Sub getpressure(size, speed, Volume, fanno)
        Try
            Dim temp_fsp As Double
            temp_fsp = CDbl(Frmselectfan.Txtfsp.Text)
        '        If Val(Frmselectfan.Txtfsp.Text) <> 0 Then
        If temp_fsp <> 0 Then
            correctedforSUCTIONS(fanno) = "no"
        End If
        count1 = 0
        Do While fsp(fanno, count1) <> 0
            '-scaling for fan sizes
            'Call ModifyDatapoints(fanno, count1, size, speed, 2)
            fsps(fanno, count1) = scalePFSize(fsp(fanno, count1), datafansize(fanno), size)
            ftps(fanno, count1) = scalePFSize(ftp(fanno, count1), datafansize(fanno), size)
            vols(fanno, count1) = scaleVFSize(vol(fanno, count1), datafansize(fanno), size)
                Pows(fanno, count1) = scalePowFSize(Powr(fanno, count1), datafansize(fanno), size)
                '-scales for constant volume at each datapoint
                vols(fanno, count1) = scaleVFSpeed(vols(fanno, count1), datafanspeed(fanno), speed)
            fsps(fanno, count1) = scalePFSpeed(fsps(fanno, count1), datafanspeed(fanno), speed)
            ftps(fanno, count1) = scalePFSpeed(ftps(fanno, count1), datafanspeed(fanno), speed)
            Pows(fanno, count1) = scalePowFSpeed(Pows(fanno, count1), datafanspeed(fanno), speed)
            count1 = count1 + 1
        Loop
        count = 0
        Dim temp_flow As Double = CDbl(Frmselectfan.Txtflow.Text)

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

        If Volume > vols(fanno, datapoint2) And Volume > vols(fanno, datapoint3) Then
            'MsgBox("Fan type 1; Volume cannot be achieved with a " & fanclass(fanno) & " Fan at this size and speed, the Max Volume available is " & Math.Round(vols(fanno, datapoint3), 2) & " " & FrmSelections.ColumnHeader(3) & (Chr(10)) & "the volume has been changed to suit the highest volume available!", vbInformation)
            Call getpressure(size, speed, vols(fanno, count) - 0.01, fanno)
            Exit Sub
        End If
        If Volume < vols(fanno, datapoint3) And vols(fanno, datapoint2) = 0 Then
            'MsgBox("Fan type 1; " & fanclass(fanno) & " volume is too low and falls outside performance data, suggest a volume above " & Math.Round(vols(fanno, 1), 2) & " " & FrmSelections.ColumnHeader(3) & Chr(13) & "the volume has been changed to suit the lowest volume within the performance data!", vbInformation)
            Call getpressure(size, speed, vols(fanno, 1) + 0.01, fanno)
            Exit Sub
        End If

        '-rescaling data for the selected fan size
        'Frmselectfan.Txtfanspeed.Text = speed
        'Frmselectfan.Txtfansize.Text = size
        '-calculated the fan speed required to get the duty
        '-now calculating the power
        gradpow = (Pows(fanno, datapoint3) - Pows(fanno, datapoint2)) / (vols(fanno, datapoint3) - vols(fanno, datapoint2))
        selectedpow(fanno) = Pows(fanno, datapoint3) + ((((Volume - vols(fanno, datapoint3))) * gradpow))
        selectedpow(fanno) = Math.Round(selectedpow(fanno), 2)
        selectedmot(fanno) = getmotorsize(selectedpow(fanno))
        selectedmot(fanno) = Math.Round(selectedmot(fanno), 2)

        '-calculating fan static efficiency
        gradfse = (fse(fanno, datapoint3) - fse(fanno, datapoint2)) / (vols(fanno, datapoint3) - vols(fanno, datapoint2))
        selectedfse(fanno) = fse(fanno, datapoint3) + ((((Volume - vols(fanno, datapoint3))) * gradfse))
        selectedfse(fanno) = Math.Round(selectedfse(fanno), 1)
        '-calculating fan total efficiency
        gradfte = (fte(fanno, datapoint3) - fte(fanno, datapoint2)) / (vols(fanno, datapoint3) - vols(fanno, datapoint2))
        selectedfte(fanno) = fte(fanno, datapoint3) + ((((Volume - vols(fanno, datapoint3))) * gradfte))
        selectedfte(fanno) = Math.Round(selectedfte(fanno), 1)
        '-output volume
        selectedvol(fanno) = Math.Round(Volume, voldecplaces)
        '--outlet velocity
        Call outletvel(size, fanno)
        '-calculating FTP
        gradfsp = (fsps(fanno, datapoint3) - fsps(fanno, datapoint2)) / (vols(fanno, datapoint3) - vols(fanno, datapoint2))
        selectedfsp(fanno) = fsps(fanno, datapoint3) + ((((Volume - vols(fanno, datapoint3))) * gradfsp))
        selectedfsp(fanno) = Math.Round(selectedfsp(fanno), 2)

        gradftp = (ftps(fanno, datapoint3) - ftps(fanno, datapoint2)) / (vols(fanno, datapoint3) - vols(fanno, datapoint2))
        selectedftp(fanno) = ftps(fanno, datapoint3) + ((((Volume - vols(fanno, datapoint3))) * gradftp))
        selectedftp(fanno) = Math.Round(selectedftp(fanno), 2)


        selectedfantype(fanno) = fanclass(fanno)

        '---corecting for suction
        If Frmselectfan.Optsucy.Checked = True Then
            Call suctioncorrection(Val(selectedfsp(fanno)), Val(selectedpow(fanno)), Val(Frmselectfan.Txtdens.Text))
            selectedpow(fanno) = Math.Round(NEWpower, 2)
            selectedfsp(fanno) = Math.Round(NEWpressure, 2)
            Call suctioncorrection(Val(selectedftp(fanno)), 0, Val(Frmselectfan.Txtdens.Text))
            selectedftp(fanno) = Math.Round(NEWpressure, 2)
        End If

        Catch ex As Exception
            MsgBox("getpressure")
        End Try
    End Sub

    Public Sub getvol(size, speed, pressure, fanno)
        Try
            count1 = 0
            Do While fsp(fanno, count1) <> 0
            '-scaling for fan sizes
            fsps(fanno, count1) = scalePFSize(fsp(fanno, count1), datafansize(fanno), size)
            ftps(fanno, count1) = scalePFSize(ftp(fanno, count1), datafansize(fanno), size)
            vols(fanno, count1) = scaleVFSize(vol(fanno, count1), datafansize(fanno), size)
                Pows(fanno, count1) = scalePowFSize(Powr(fanno, count1), datafansize(fanno), size)
                '-scales for constant volume at each datapoint
                vols(fanno, count1) = scaleVFSpeed(vols(fanno, count1), datafanspeed(fanno), speed)
            fsps(fanno, count1) = scalePFSpeed(fsps(fanno, count1), datafanspeed(fanno), speed)
            ftps(fanno, count1) = scalePFSpeed(ftps(fanno, count1), datafanspeed(fanno), speed)
            Pows(fanno, count1) = scalePowFSpeed(Pows(fanno, count1), datafanspeed(fanno), speed)
            count1 = count1 + 1
        Loop
        count = count1
        If PType = 0 Then
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
        If PType = 0 Then
            PressCheck2 = ftps(fanno, datapoint2)
            If pressure > PressCheck2 And pressure > PressCheck1 Then
                'akm temp removed                MsgBox("Fan type 1; Pressure cannot be achieved with a " & fanclass(fanno) & " Fan at this size and speed, the Max Pressure available is " & Math.Round(PressCheck1, 2) & " " & FrmSelections.ColumnHeader(4) & (Chr(10)) & "the pressure has been changed to suit the highest pressure available!", vbInformation)
                Call getvol(size, speed, Math.Round(PressCheck1, 2) - 0.01, fanno)
                Exit Sub
            End If
            If pressure < PressCheck2 And PressCheck1 = 0 Then
                'akm temp removed MsgBox("Fan type 1; " & fanclass(fanno) & " Pressure is too low and falls outside performance data, suggest a pressure above " & Math.Round(fsps(fanno, count1 - 1), 2) & " " & FrmSelections.ColumnHeader(4) & Chr(13) & "the pressure has been changed to suit the lowest pressure within the performance data!", vbInformation)
                Call getvol(size, speed, Math.Round(fsps(fanno, count1 - 1), 2) + 0.01, fanno)
                Exit Sub
            End If
        Else
            PressCheck2 = ftps(fanno, datapoint2)
            If pressure > PressCheck2 And pressure > PressCheck1 Then
                'akm temp removed                MsgBox("Fan type 1; Pressure cannot be achieved with a " & fanclass(fanno) & " Fan at this size and speed, the Max Pressure available is " & Math.Round(PressCheck1, 2) & " " & FrmSelections.ColumnHeader(4) & (Chr(10)) & "the pressure has been changed to suit the highest pressure available!", vbInformation)
                Call getvol(size, speed, Math.Round(ftps(fanno, count), 2) - 0.01, fanno)
                Exit Sub
            End If
            If pressure < ftps(fanno, datapoint2) And PressCheck1 = 0 Then
                ' akm temp removed MsgBox("Fan type 1; " & fanclass(fanno) & " Pressure is too low and falls outside performance data, suggest a pressure above " & Math.Round(ftps(fanno, count1 - 1), 2) & " " & FrmSelections.ColumnHeader(4) & Chr(13) & "the pressure has been changed to suit the lowest pressure within the performance data!", vbInformation)
                Call getvol(size, speed, Math.Round(ftps(fanno, count1 - 1), 2) + 0.01, fanno)
                Exit Sub
            End If
        End If

        '-rescaling data for the selected fan size
        Frmselectfan.Txtfanspeed.Text = speed
        Frmselectfan.Txtfansize.Text = size
        '-calculated the fan speed required to get the duty
        '-now calculating the power
        gradpow = (Pows(fanno, datapoint2) - Pows(fanno, datapoint3)) / (PressCheck1 - PressCheck2)
        selectedpow(fanno) = Pows(fanno, datapoint3) + ((((PressCheck1 - pressure)) * gradpow))
        selectedpow(fanno) = Math.Round(selectedpow(fanno), 2)

        '-calculating fan static efficiency
        gradfse = (fse(fanno, datapoint2) - fse(fanno, datapoint3)) / (PressCheck1 - PressCheck2)
        selectedfse(fanno) = fse(fanno, datapoint3) + ((((PressCheck1 - pressure)) * gradfse))
        selectedfse(fanno) = Math.Round(selectedfse(fanno), 1)
        '-calculating fan total efficiency
        gradfte = (fte(fanno, datapoint2) - fte(fanno, datapoint3)) / (PressCheck1 - PressCheck2)
        selectedfte(fanno) = fte(fanno, datapoint3) + ((((PressCheck1 - pressure)) * gradfte))
        selectedfte(fanno) = Math.Round(selectedfte(fanno), 1)
        '-output fsp
        gradfsp = (fsps(fanno, datapoint2) - fsps(fanno, datapoint3)) / (PressCheck1 - PressCheck2)
        selectedfsp(fanno) = fsps(fanno, datapoint3) + ((((PressCheck1 - pressure)) * gradfsp))
        selectedfsp(fanno) = Math.Round(selectedfsp(fanno), 2)
        '-calculating volume
        gradvol = (vols(fanno, datapoint2) - vols(fanno, datapoint3)) / (PressCheck1 - PressCheck2)
        selectedvol(fanno) = vols(fanno, datapoint3) + ((((PressCheck1 - pressure)) * gradvol))
        selectedvol(fanno) = Math.Round(Val(Frmselectfan.Txtflow.Text), voldecplaces)
        '--------calculating ftp
        gradftp = (ftps(fanno, datapoint2) - ftps(fanno, datapoint3)) / (PressCheck1 - PressCheck2)
        selectedftp(fanno) = ftps(fanno, datapoint3) + ((((PressCheck1 - pressure)) * gradftp))
        selectedftp(fanno) = Math.Round(selectedftp(fanno), 2)
        '--outlet velocity
        Call outletvel(size, fanno)

        selectedfansize(fanno) = fanclass(fanno)

        Catch ex As Exception
            MsgBox("getvol")
        End Try
    End Sub
End Module
