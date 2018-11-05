Module scaledata
    Public Function ScalePFSize(P1, d1, d2)
        ScalePFSize = 0.0
        Try
            ScalePFSize = P1 * (d2 / d1) ^ 2

        Catch ex As Exception
            MsgBox("scalePFSize")
        End Try
    End Function
    Public Function ScaleVFSize(V1, d1, d2)
        ScaleVFSize = 0.0
        Try
            ScaleVFSize = V1 * (d2 / d1) ^ 3
            '    If (scaleVFSize < 1) Then
            '    'MsgBox("V1 = " + V1.ToString)
            'End If

        Catch ex As Exception
            MsgBox("scaleVFSize")
        End Try
    End Function
    Public Function ScalePowFSize(Pow1, d1, d2)
        ScalePowFSize = 0.0
        Try
            ScalePowFSize = Pow1 * (d2 / d1) ^ 5

        Catch ex As Exception
            MsgBox("scalePowFSize")
        End Try
    End Function
    Public Function ScalePFSpeed(P1, N1, N2)
        ScalePFSpeed = 0.0
        Try
            ScalePFSpeed = P1 * (N2 / N1) ^ 2

        Catch ex As Exception
            MsgBox("scalePFSpeed")
        End Try
    End Function
    Public Function ScaleVFSpeed(V1, N1, N2)
        ScaleVFSpeed = 0.0
        Try
            ScaleVFSpeed = V1 * (N2 / N1)

        Catch ex As Exception
            MsgBox("scaleVFSpeed")
        End Try
    End Function
    Public Function ScalePowFSpeed(Pow1, N1, N2)
        ScalePowFSpeed = 0.0
        Try
            ScalePowFSpeed = Pow1 * (N2 / N1) ^ 3

        Catch ex As Exception
            MsgBox("scalePowFSpeed")
        End Try
    End Function
    Public Sub GetFanSpeed(fansize, fanno)
        Try
            count1 = 0
            Do While fsp(fanno, count1) <> 0
                '-scaling for fan sizes
                'Call ModifyDatapoints(fanno, count1, fansize, ftspeed(fanno, count1), 3)
                fsps(fanno, count1) = ScalePFSize(fsp(fanno, count1), datafansize(fanno), fansize)
                ftps(fanno, count1) = ScalePFSize(ftp(fanno, count1), datafansize(fanno), fansize)
                vols(fanno, count1) = ScaleVFSize(vol(fanno, count1), datafansize(fanno), fansize)
                Pows(fanno, count1) = ScalePowFSize(Powr(fanno, count1), datafansize(fanno), fansize)
                '-scales for constant volume at each datapoint
                ftspeed(fanno, count1) = Val(Frmselectfan.Txtflow.Text) * datafanspeed(fanno) / vols(fanno, count1)
                vols(fanno, count1) = Val(Frmselectfan.Txtflow.Text)
                fsps(fanno, count1) = ScalePFSpeed(fsps(fanno, count1), datafanspeed(fanno), ftspeed(fanno, count1))
                ftps(fanno, count1) = ScalePFSpeed(ftps(fanno, count1), datafanspeed(fanno), ftspeed(fanno, count1))
                Pows(fanno, count1) = ScalePowFSpeed(Pows(fanno, count1), datafanspeed(fanno), ftspeed(fanno, count1))
                count1 = count1 + 1
            Loop
            '--------------------------------------------
            If Val(datapointI(fanno, fansize)) = 0 Then '-subsection to find the right datapoint where pressure is nearest for fans
                '-where the size has been specified by the user
                count = 0
                If PresType = 0 Then
                    Do While (fsps(fanno, count) - Val(Frmselectfan.Txtfsp.Text)) ^ 2 > (fsps(fanno, count + 1) - Val(Frmselectfan.Txtfsp.Text)) ^ 2
                        count = count + 1
                    Loop
                Else
                    Do While (ftps(fanno, count) - Val(Frmselectfan.Txtfsp.Text)) ^ 2 > (ftps(fanno, count + 1) - Val(Frmselectfan.Txtfsp.Text)) ^ 2
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

            '---------------------------------------------
            '-finished now data is in corect size at constant volume
            '-looking at the selected fan size datapoint which best matches the pressure at constant volume
            '- looking either above or below the point to interpolate
            '-deciding if to interpolate between the previous or next datapoint
            If PressCheck3 > Val(Frmselectfan.Txtfsp.Text) Then
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
            If Val(Frmselectfan.Txtfsp.Text) > PressCheck2 And Val(Frmselectfan.Txtfsp.Text) > PressCheck3 Then
                'akm temp removed            MsgBox(("Fan type 1; " & fanclass(fanno) & " Pressure cannot be achieved at this volume, the Max Pressure available is " & Math.Round(PressCheck3, 2) & " " & FrmSelections.ColumnHeader(4)), vbInformation)
                Exit Sub
            End If
            If Val(Frmselectfan.Txtfsp.Text) < PressCheck2 And PressCheck3 = 0 Then
                'akm temp removed            MsgBox(("Fan type 1; " & fanclass(fanno) & " Pressure is too low at this volume and falls outside performance data, suggest a pressure above " & Math.Round(fsps(fanno, count1 - 1), 2) & " " & FrmSelections.ColumnHeader(4)), vbInformation)
                Exit Sub
            End If
            '----this piece of code more accurate for calculating speed
            '----but is more complicated
            'FRMselections.txtspeed1.Text = ftspeed(fanno,datapoint2) + ((Val(Frmselectfan.Txtfsp.Text) - PressCheck2) * getgrad(PressCheck1, PressCheck2, PressCheck3, PressCheck4, ftspeed(fanno,datapoint1), ftspeed(fanno,datapoint2), ftspeed(fanno,datapoint3), ftspeed(fanno,datapoint4), Val(Frmselectfan.Txtfsp.Text) - PressCheck2))
            'rescaling data for the selected fan size
            grad = (ftspeed(fanno, datapoint3) - ftspeed(fanno, datapoint2)) / (PressCheck3 - PressCheck2)
            selectedspeed(fanno) = ftspeed(fanno, datapoint3) + ((Val(Frmselectfan.Txtfsp.Text) - PressCheck3) * grad)
            selectedspeed(fanno) = Math.Round(selectedspeed(fanno), 0)
            selectedfansize(fanno) = fansize 'akm
            '-calculated the fan speed required to get the duty
            '-now calculating the power
            gradpow = (Pows(fanno, datapoint3) - Pows(fanno, datapoint2)) / (ftspeed(fanno, datapoint3) - ftspeed(fanno, datapoint2))
            selectedpow(fanno) = Pows(fanno, datapoint3) + ((((selectedspeed(fanno) - ftspeed(fanno, datapoint3))) * gradpow))
            selectedpow(fanno) = Math.Round(selectedpow(fanno), 2)
            '-calculating fan static efficiency
            gradfse = (fse(fanno, datapoint3) - fse(fanno, datapoint2)) / (ftspeed(fanno, datapoint3) - ftspeed(fanno, datapoint2))
            selectedfse(fanno) = fse(fanno, datapoint3) + ((((selectedspeed(fanno) - ftspeed(fanno, datapoint3))) * gradfse))
            selectedfse(fanno) = Math.Round(selectedfse(fanno), 1)
            '-calculating fan total efficiency
            gradfte = (fte(fanno, datapoint3) - fte(fanno, datapoint2)) / (ftspeed(fanno, datapoint3) - ftspeed(fanno, datapoint2))
            selectedfte(fanno) = fte(fanno, datapoint3) + ((((selectedspeed(fanno) - ftspeed(fanno, datapoint3))) * gradfte))
            selectedfte(fanno) = Math.Round(selectedfte(fanno), 1)
            '-output volume
            Frmselectfan.Txtflow.Text = Frmselectfan.Txtflow.Text
            '-calculating outlet velocity
            Call outletvel(fansize, fanno)
            '-calculating FSP
            gradfsp = (fsps(fanno, datapoint3) - fsps(fanno, datapoint2)) / (ftspeed(fanno, datapoint3) - ftspeed(fanno, datapoint2))
            selectedfsp(fanno) = fsps(fanno, datapoint3) + ((((selectedspeed(fanno) - ftspeed(fanno, datapoint3))) * gradfsp))
            selectedfsp(fanno) = Math.Round(selectedfsp(fanno), 2)
            '-calculating FTP
            gradftp = (ftps(fanno, datapoint3) - ftps(fanno, datapoint2)) / (ftspeed(fanno, datapoint3) - ftspeed(fanno, datapoint2))
            selectedftp(fanno) = ftps(fanno, datapoint3) + ((((selectedspeed(fanno) - ftspeed(fanno, datapoint3))) * gradftp))
            selectedftp(fanno) = Math.Round(selectedftp(fanno), 2)

            selectedfantype(fanno) = fanclass(fanno)

            selectedfanfile(fanno) = fantypefilename(fanno)

            '-----bringing the fan upto the duty speed after the first quick cslculations
            uptospeed = Val(selectedspeed(fanno))
            TempPress = temppressurE
            count = 0
            Do While difference1 >= difference2
                Call GetPressure(Val(selectedfansize(fanno)), uptospeed, Val(Frmselectfan.Txtflow.Text), fanno)
                If PresType = 0 Then
                    difference1 = Math.Sqrt((TempPress - Val(selectedfsp(fanno))) ^ 2)
                Else
                    difference1 = Math.Sqrt((TempPress - Val(selectedftp(fanno))) ^ 2)
                End If
                Call GetPressure(Val(selectedfansize(fanno)), uptospeed + 1, Val(Frmselectfan.Txtflow.Text), fanno)
                If PresType = 0 Then
                    difference2 = Math.Sqrt((TempPress - Val(selectedfsp(fanno))) ^ 2)
                Else
                    difference2 = Math.Sqrt((TempPress - Val(selectedftp(fanno))) ^ 2)
                End If
                uptospeed = uptospeed + 1
            Loop
            Call GetPressure(Val(selectedfansize(fanno)), uptospeed - 1, Val(Frmselectfan.Txtflow.Text), fanno)

        Catch ex As Exception
            MsgBox("getfanspeed")
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

            '-end of scaling most efficient data point----- start of output to frmselections

            selectedfansize(fanno) = size
            '-calculated the fan speed required to get the duty
            '-now calculating the power
            selectedpow(fanno) = Math.Round(Pows(fanno, medpoint(fanno)), 2)
            '-calculating fan static efficiency
            selectedfse(fanno) = Math.Round(fse(fanno, medpoint(fanno)), 1)
            '-calculating fan total efficiency
            selectedfte(fanno) = Math.Round(fte(fanno, medpoint(fanno)), 1)
            '-output volume
            Frmselectfan.Txtflow.Text = Math.Round(vols(fanno, medpoint(fanno)), voldecplaces)
            selectedfsp(fanno) = Math.Round(fsps(fanno, medpoint(fanno)), 2)
            '-calculating FTP

            selectedftp(fanno) = Math.Round(ftps(fanno, medpoint(fanno)), 2)
            selectedfantype(fanno) = fanclass(fanno)
            selectedspeed(fanno) = speed
            Call outletvel(size, fanno)

            '---corecting for suction
            If Frmselectfan.Optsucy.Checked = True Then
                Call SuctionCorrection(Val(selectedfsp(fanno)), Val(selectedpow(fanno)), Val(Frmselectfan.Txtdens.Text))
                selectedpow(fanno) = Math.Round(NEWpower, 2)
                selectedfsp(fanno) = Math.Round(NEWpressure, 2)
            End If

        Catch ex As Exception
            MsgBox("scalesizespeed")
        End Try
    End Sub

    'Public Sub OutletVel(fansize, fanno)
    '    Try
    '        outletsize = dataoutletarea(fanno) * (fansize / datafansize(fanno)) ^ 2
    '        If FlowType = 4 Then
    '            outletsize = dataoutletareaftsq(fanno) * (fansize / datafansize(fanno)) ^ 2
    '        End If
    '        Select Case FlowType
    '            Case 1
    '                selectedov(fanno) = (Val(Frmselectfan.Txtflow.Text) / 3600) / (outletsize - (casethickness / 1000) ^ 2)
    '            Case 2
    '                selectedov(fanno) = (Val(Frmselectfan.Txtflow.Text) / 60) / (outletsize - (casethickness / 1000) ^ 2)
    '            Case 3
    '                selectedov(fanno) = Val(Frmselectfan.Txtflow.Text) / (outletsize - (casethickness / 1000) ^ 2)
    '            Case 4
    '                selectedov(fanno) = Val(Frmselectfan.Txtflow.Text) / (outletsize - (casethickness / 304.8) ^ 2)
    '        End Select
    '        selectedov(fanno) = Math.Round(Val(selectedov(fanno)), 2)

    '    Catch ex As Exception
    '        MsgBox("outletvel")
    '    End Try
    'End Sub

    Public Sub OutletVel(fansize, fanno)
        Try
            outletsize = dataoutletarea(fanno) * (fansize / datafansize(fanno)) ^ 2
            outletsize = outletsize - (casethickness / 1000) ^ 2
            Select Case Units(0).UnitSelected
            'Select Case FlowType
                Case 0 '2 '1
                    selectedov(fanno) = (Val(Frmselectfan.Txtflow.Text) / 3600) / outletsize'm3/hr
                Case 1 '2
                    selectedov(fanno) = (Val(Frmselectfan.Txtflow.Text) / 60) / outletsize'm3/min
                Case 2 '0 '3
                    selectedov(fanno) = (Val(Frmselectfan.Txtflow.Text)) / outletsize'm3/sec
                Case 3 '4
                    selectedov(fanno) = (Val(Frmselectfan.Txtflow.Text) / 2119.0) / outletsize 'cfm
            End Select

            'If VelType = 1 Then
            If Units(7).UnitSelected = 1 Then
                selectedov(fanno) = selectedov(fanno) / convvel
            End If
            selectedov(fanno) = Math.Round(Val(selectedov(fanno)), 2)

        Catch ex As Exception
            MsgBox("outletvel")
        End Try
    End Sub

    Public Function AnyOutletVel(fansize, Volume, FanPick)
        AnyOutletVel = 0.0
        Try
            outletsize = dataoutletarea(FanPick) * (fansize / datafansize(FanPick)) ^ 2
            'If FlowType = 4 Then
            If Units(0).UnitSelected = 3 Then
                outletsize = dataoutletareaftsq(FanPick) * (fansize / datafansize(FanPick)) ^ 2
            End If
            Select Case Units(0).UnitSelected
            'Select Case FlowType
                Case 0 '1 'm³/hr
                    AnyOutletVel = (Volume / 3600) / (outletsize - (casethickness / 1000) ^ 2)
                Case 1 '2 'm³/min
                    AnyOutletVel = (Volume / 60) / (outletsize - (casethickness / 1000) ^ 2)
                Case 2 '3 'm³/sec
                    AnyOutletVel = Volume / (outletsize - (casethickness / 1000) ^ 2)
                Case 3 '4 'cfm
                    AnyOutletVel = Volume / (outletsize - (casethickness / 304.8) ^ 2)
            End Select
            Return AnyOutletVel

        Catch ex As Exception
            MsgBox("anyoutletvel")
        End Try
    End Function
End Module
