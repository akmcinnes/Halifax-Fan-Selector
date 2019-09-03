Module ModSizeAtFixedSpeed
    'subroutines
    'GetSizeAtfixedSpeed
    'modifies curve points for fan diameters fixed speed 

    Public Sub GetSizeAtfixedSpeed(ByVal fanno As Integer)
        SizeAtFixedSpeed = 0.0
        Try
            Dim ii As Integer
            For ii = 0 To 1000
                vols(fanno, ii) = 0.0
            Next
            'count = 0
            'If fsizes(fanno, 1) > 100 Then
            '    stepsize = 5
            'Else
            'stepsize = 0.25
            ''End If
            'If fanunits(fanno) = "mm" Then stepsize = 5
            count = 0
            Dim fanlimit As Double = 0 '102
            'If fansizelimit(fanno) > 0 Then fanlimit = fansizelimit(fanno)
            Dim i As Integer = 0
            Do While fsizes(fanno, i) > 0
                If fsizes(fanno, i) > fanlimit Then fanlimit = fsizes(fanno, i)
                i = i + 1
            Loop
            count = 0
            fansize = fsizes(fanno, 0)
            Do While fansize <= fanlimit '<>102
                If fanclass(fanno) = "MBI" Then
                    'If Frmselectfan.chkWide.Checked = True Then Debug.Print("Wide")
                    'If Frmselectfan.chkMedium.Checked = True Then Debug.Print("Medium")
                    Debug.Print("fanlimit = " + fanlimit.ToString)
                    Debug.Print("fansize = " + fansize.ToString)
                    'For i = 0 To 30
                    '    Debug.Print("powr(" + i.ToString + ") = " + Powr(fanno, i).ToString)
                    'Next

                End If
                count1 = 0
                Do While Powr(fanno, count1) <> 0
                    '-scaling for fan sizes
                    If vol(fanno, count1) = 0 Then
                        vol(fanno, count1) = 0.0001
                    End If
                    'Call ModifyDatapoints(fanno, count1, fansize, speed, 4)
                    vols(fanno, count1) = ScaleVFSize(vol(fanno, count1), datafansize(fanno), fansize)
                    ftps(fanno, count1) = ScalePFSize(ftp(fanno, count1), datafansize(fanno), fansize)
                    fsps(fanno, count1) = ScalePFSize(fsp(fanno, count1), datafansize(fanno), fansize)
                    If Frmselectfan.optDDUserDefined.Checked = True Then
                        fsps(fanno, count1) = fsps(fanno, count1) - CorrectforDDArea(dataoutletarea(fanno), datafansize(fanno), fansize)
                    End If
                    Pows(fanno, count1) = ScalePowFSize(Powr(fanno, count1), datafansize(fanno), fansize)
                    '-scales for constant speed at each datapoint
                    speed = Val(Frmselectfan.Txtfanspeed.Text)
                    vols(fanno, count1) = ScaleVFSpeed(vols(fanno, count1), datafanspeed(fanno), speed)
                    ftps(fanno, count1) = ScalePFSpeed(ftps(fanno, count1), datafanspeed(fanno), speed)
                    fsps(fanno, count1) = ScalePFSpeed(fsps(fanno, count1), datafanspeed(fanno), speed)
                    Pows(fanno, count1) = ScalePowFSpeed(Pows(fanno, count1), datafanspeed(fanno), speed)
                    count1 = count1 + 1
                Loop
                count2 = 0
                '-finds the point where the volume is nearest
                'Do While (Val(Frmselectfan.Txtflow.Text) - vols(fanno, count2)) ^ 2 > (Val(Frmselectfan.Txtflow.Text) - vols(fanno, count2 + 1)) ^ 2
                ''Do While (flowrate * convflow - vols(fanno, count2)) ^ 2 > (flowrate * convflow - vols(fanno, count2 + 1)) ^ 2
                Do While (flowrate - vols(fanno, count2)) ^ 2 > (flowrate - vols(fanno, count2 + 1)) ^ 2
                    If count2 = 500 Then
                        Exit Do
                    Else
                        count2 = count2 + 1
                    End If
                Loop
                '-recording the nearest volume point for each fan size

                datapointI(fanno, count) = count2
                fspI(fanno, count) = fsps(fanno, count2)
                ftpI(fanno, count) = ftps(fanno, count2)
                'volI(fanno, count) = vols(fanno, count2)'300119
                'powI(fanno, count) = Pows(fanno, count2)'300119

                'fseI(fanno, count) = fse(fanno, count2)'300119
                'fteI(fanno, count) = fte(fanno, count2)'300119
                fsizes(fanno, count) = fansize
                fansize = fansize + stepsize
                If count = 500 Then
                    Exit Do
                End If
                count = count + 1
            Loop
            count = 0
            '-finds the point nearest the specified pressure point
            'fsizes(fanno, 0) = 1 'akm200319
            'fsizes(0, 0) = 1
            If PresType = 0 Then
                'Do While (Val(Frmselectfan.Txtfsp.Text) - fspI(fanno, count)) ^ 2 >= (Val(Frmselectfan.Txtfsp.Text) - fspI(fanno, count + 1)) ^ 2
                'Do While (pressrise * convpres - fspI(fanno, count)) ^ 2 >= (pressrise * convpres - fspI(fanno, count + 1)) ^ 2
                Do While (pressrise - fspI(fanno, count)) ^ 2 >= (pressrise - fspI(fanno, count + 1)) ^ 2
                    If count = 500 Then
                        SizeAtFixedSpeed = 0
                        Exit Do
                    End If
                    count = count + 1
                Loop
            Else
                'Do While (Val(Frmselectfan.Txtfsp.Text) - ftpI(fanno, count)) ^ 2 >= (Val(Frmselectfan.Txtfsp.Text) - ftpI(fanno, count + 1)) ^ 2
                'Do While (pressrise * convpres - ftpI(fanno, count)) ^ 2 >= (pressrise * convpres - ftpI(fanno, count + 1)) ^ 2
                Do While (pressrise - ftpI(fanno, count)) ^ 2 >= (pressrise - ftpI(fanno, count + 1)) ^ 2
                    If count = 500 Then
                        SizeAtFixedSpeed = 0
                        Exit Do
                    End If
                    count = count + 1
                Loop

            End If
            SizeAtFixedSpeed = fsizes(fanno, count)
            If fanclass(fanno) = "MBI" Then
                Debug.Print(fanclass(fanno) + " fspI = " + fspI(fanno, count).ToString + " fspI = " + fspI(fanno, count + 1).ToString + " size = " + fsizes(fanno, count).ToString)
            End If


            ''---------checking for secondary data
            'If fsizes(fanno, count) >= fansizelimit(fanno) And fansizelimit(fanno) <> 0 And runonce <> "yes" Then
            '    Call LoadFanData(fantypesecfilename(fanno), fanno)
            '    Call scaledensity(fanno, getscalefactor)
            '    runonce = "yes"
            '    Call GetSizeAtfixedSpeed(fanno)
            '    Exit Function
            'End If
            '-------------------------------------
            'If Val(Frmselectfan.Txtfsp.Text) <> 0 And Frmselectfan.Optsucy.Checked = True Then
            If pressrise * convpres <> 0 And Frmselectfan.Optsucy.Checked = True Then
                Call scaledensity(fanno, originaldensity / Val(Frmselectfan.Txtdens))
                MsgBox("Fan Type " + fanno.ToString + ": " & fanclass(fanno) & ", A new value for Pressure has been calculated!", vbInformation)
            End If
            '-----------------------------------------------
            'If SizeAtFixedSpeed = 0 Then
            '    failindex = failindex + 1
            '    fanfailures(failindex, 0) = fantypename(fanno)
            '    fanfailures(failindex, 1) = 9 '"Sorry this duty is out of range for this fan type"
            '    failurevalue(failindex) = ""
            '    'MsgBox("Fan Type " + fanclass(fanno) + ": Sorry this duty is out of range for this fan type")
            '    Exit Sub
            'End If

            'Call GetPressure(GetSizeAtfixedSpeed(fanno), speed, Val(Frmselectfan.Txtflow.Text), fanno)
            Call GetPressure(SizeAtFixedSpeed, speed, flowrate, fanno)

        Catch ex As Exception
            'MsgBox(ex.Message + vbCrLf + fanno.ToString + " Getsizeatfixedspeed " + fansize.ToString + " " + Powr(fanno, count1).ToString)
            If StartArg.ToLower.Contains("-dev") Then
                ErrorMessage(ex, 6001)
                failindex = failindex + 1
                fanfailures(failindex, 0) = fantypename(fanno)
                fanfailures(failindex, 1) = ex.Message
                failurevalue(failindex) = ""
                MsgBox(fanclass(fanno))
            End If
        End Try
        'Return GetSizeAtfixedSpeed
    End Sub
End Module
