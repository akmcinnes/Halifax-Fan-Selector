Module ModPressVol
    Public Sub GetPressure(size, speed, Volume, fanno)
        Try
            Dim temp_kp As Double = kp
            If Frmselectfan.chkKP.Checked = True Then temp_kp = 1.0


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
            temp_flow = CDbl(Frmselectfan.Txtflow.Text)

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
                Exit Sub
            End If
            If Volume < vols(fanno, datapoint3) And vols(fanno, datapoint2) = 0 Then
                'MsgBox("Fan type 1; " & fanclass(fanno) & " volume is too low and falls outside performance data, suggest a volume above " & Math.Round(vols(fanno, 1), 2) & " " & FrmSelections.ColumnHeader(3) & Chr(13) & "the volume has been changed to suit the lowest volume within the performance data!", vbInformation)
                Call GetPressure(size, speed, vols(fanno, 1) + 0.01, fanno)
                Exit Sub
            End If

            '-rescaling data for the selected fan size
            Frmselectfan.Txtfanspeed.Text = speed
            Frmselectfan.Txtfansize.Text = size
            '-calculated the fan speed required to get the duty
            '-now calculating the power
            gradpow = (Pows(fanno, datapoint3) - Pows(fanno, datapoint2)) / (vols(fanno, datapoint3) - vols(fanno, datapoint2))
            selectedpow(fanno) = Pows(fanno, datapoint3) + ((((Volume - vols(fanno, datapoint3))) * gradpow))
            selectedpow(fanno) = selectedpow(fanno) / temp_kp
            selectedpow(fanno) = Math.Round(selectedpow(fanno), 2)
            selectedpow2(fanno) = Math.Round(selectedpow(fanno) / 0.746, 2)
            selectedmot(fanno) = GetMotorSize(selectedpow(fanno))
            selectedmot(fanno) = Math.Round(selectedmot(fanno), 2)
            selectedmot2(fanno) = GetMotorSize(selectedpow(fanno) / 0.746, True)
            selectedmot2(fanno) = Math.Round(selectedmot2(fanno), 2)

            '-calculating fan static efficiency
            gradfse = (fse(fanno, datapoint3) - fse(fanno, datapoint2)) / (vols(fanno, datapoint3) - vols(fanno, datapoint2))
            selectedfse(fanno) = fse(fanno, datapoint3) + ((((Volume - vols(fanno, datapoint3))) * gradfse))
            selectedfse(fanno) = selectedfse(fanno) * temp_kp
            selectedfse(fanno) = Math.Round(selectedfse(fanno), 1)
            '-calculating fan total efficiency
            gradfte = (fte(fanno, datapoint3) - fte(fanno, datapoint2)) / (vols(fanno, datapoint3) - vols(fanno, datapoint2))
            selectedfte(fanno) = fte(fanno, datapoint3) + ((((Volume - vols(fanno, datapoint3))) * gradfte))
            selectedfte(fanno) = selectedfte(fanno) * temp_kp
            selectedfte(fanno) = Math.Round(selectedfte(fanno), 1)
            '-output volume
            selectedvol(fanno) = Math.Round(Volume, voldecplaces)
            selectedfansize(fanno) = size
            '--outlet velocity
            Call OutletVel(size, fanno)
            selectedinletdia(fanno) = datainletdia(fanno)
            selectedoutletarea(fanno) = dataoutletarea(fanno)
            selectedinletdia(fanno) = inletdia
            selectedoutletarea(fanno) = outletsize
            selectedBladeNumber(fanno) = blade_number(fanno)
            selectedoutletlen(fanno) = dataoutletlen(fanno)
            selectedoutletwid(fanno) = dataoutletwid(fanno)
            selectedoutletlen(fanno) = outletlength
            selectedoutletwid(fanno) = outletwidth

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
                Call SuctionCorrection(Val(selectedfsp(fanno)), Val(selectedpow(fanno)), Val(Frmselectfan.Txtdens.Text))
                selectedpow(fanno) = Math.Round(NEWpower, 2)
                selectedfsp(fanno) = Math.Round(NEWpressure, 2)
                Call SuctionCorrection(Val(selectedftp(fanno)), 0, Val(Frmselectfan.Txtdens.Text))
                selectedftp(fanno) = Math.Round(NEWpressure, 2)
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
                    MsgBox("Fan type 1; Pressure cannot be achieved with a " & fanclass(fanno) & " Fan at this size and speed, the Max Pressure available is " & Math.Round(PressCheck1, 2) & " " & Frmselectfan.ColumnHeader(4) & (Chr(10)) & "the pressure has been changed to suit the highest pressure available!", vbInformation)
                    Call GetVol(size, speed, Math.Round(PressCheck1, 2) - 0.01, fanno)
                    Exit Sub
                End If
                If pressure < PressCheck2 And PressCheck1 = 0 Then
                    MsgBox("Fan type 1; " & fanclass(fanno) & " Pressure is too low and falls outside performance data, suggest a pressure above " & Math.Round(fsps(fanno, count1 - 1), 2) & " " & Frmselectfan.ColumnHeader(4) & Chr(13) & "the pressure has been changed to suit the lowest pressure within the performance data!", vbInformation)
                    Call GetVol(size, speed, Math.Round(fsps(fanno, count1 - 1), 2) + 0.01, fanno)
                    Exit Sub
                End If
            Else
                PressCheck2 = ftps(fanno, datapoint2)
                If pressure > PressCheck2 And pressure > PressCheck1 Then
                    MsgBox("Fan type 1; Pressure cannot be achieved with a " & fanclass(fanno) & " Fan at this size and speed, the Max Pressure available is " & Math.Round(PressCheck1, 2) & " " & Frmselectfan.ColumnHeader(4) & (Chr(10)) & "the pressure has been changed to suit the highest pressure available!", vbInformation)
                    Call GetVol(size, speed, Math.Round(ftps(fanno, count), 2) - 0.01, fanno)
                    Exit Sub
                End If
                If pressure < ftps(fanno, datapoint2) And PressCheck1 = 0 Then
                    MsgBox("Fan type 1; " & fanclass(fanno) & " Pressure is too low and falls outside performance data, suggest a pressure above " & Math.Round(ftps(fanno, count1 - 1), 2) & " " & Frmselectfan.ColumnHeader(4) & Chr(13) & "the pressure has been changed to suit the lowest pressure within the performance data!", vbInformation)
                    Call GetVol(size, speed, Math.Round(ftps(fanno, count1 - 1), 2) + 0.01, fanno)
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
            Call OutletVel(size, fanno)

            selectedfansize(fanno) = fanclass(fanno)
            selectedBladeType(fanno) = blade_type(fanno)
            selectedBladeNumber(fanno) = blade_number(fanno)
            selectedinletdia(fanno) = datainletdia(fanno)
            selectedoutletarea(fanno) = dataoutletarea(fanno)
            selectedinletdia(fanno) = inletdia
            selectedoutletarea(fanno) = outletsize
            selectedoutletlen(fanno) = dataoutletlen(fanno)
            selectedoutletwid(fanno) = dataoutletwid(fanno)
            selectedoutletlen(fanno) = outletlength
            selectedoutletwid(fanno) = outletwidth


        Catch ex As Exception
            'MsgBox("getvol")
            ErrorMessage(ex, 5702)

        End Try
    End Sub
End Module
