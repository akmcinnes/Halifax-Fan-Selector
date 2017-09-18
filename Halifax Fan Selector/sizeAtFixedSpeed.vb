Module sizeAtFixedSpeed
    Public Function Getsizeatfixedspeed(ByVal fanno As Integer)
        Try
            count = 0

            If fsizes(fanno, 1) > 100 Then
            stepsize = 5
        Else
            stepsize = 0.25
        End If
        count = 0
        fansize = fsizes(fanno, 1)
        Do While fansize <> 102
            count1 = 0
                Do While Powr(fanno, count1) <> 0
                    '-scaling for fan sizes
                    If vol(fanno, count1) = 0 Then
                        vol(fanno, count1) = 0.0001
                    End If
                    'Call ModifyDatapoints(fanno, count1, fansize, speed, 4)
                    fsps(fanno, count1) = scalePFSize(fsp(fanno, count1), datafansize(fanno), fansize)
                    ftps(fanno, count1) = scalePFSize(ftp(fanno, count1), datafansize(fanno), fansize)
                    vols(fanno, count1) = scaleVFSize(vol(fanno, count1), datafansize(fanno), fansize)
                    Pows(fanno, count1) = scalePowFSize(Powr(fanno, count1), datafansize(fanno), fansize)
                    '-scales for constant speed at each datapoint
                    speed = Val(Frmselectfan.Txtfanspeed.Text)
                    vols(fanno, count1) = scaleVFSpeed(vols(fanno, count1), datafanspeed(fanno), speed)
                    fsps(fanno, count1) = scalePFSpeed(fsps(fanno, count1), datafanspeed(fanno), speed)
                    ftps(fanno, count1) = scalePFSpeed(ftps(fanno, count1), datafanspeed(fanno), speed)
                    Pows(fanno, count1) = scalePowFSpeed(Pows(fanno, count1), datafanspeed(fanno), speed)
                    count1 = count1 + 1
                Loop
                count2 = 0
            '-finds the point where the volume is nearest
            Do While (Val(Frmselectfan.Txtflow.Text) - vols(fanno, count2)) ^ 2 > (Val(Frmselectfan.Txtflow.Text) - vols(fanno, count2 + 1)) ^ 2
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
            volI(fanno, count) = vols(fanno, count2)
            powI(fanno, count) = Pows(fanno, count2)
            fseI(fanno, count) = fse(fanno, count2)
            fteI(fanno, count) = fte(fanno, count2)
            fsizes(fanno, count) = fansize
            fansize = fansize + stepsize
            If count = 500 Then
                Exit Do
            End If
            count = count + 1
        Loop
        count = 0
        '-finds the point nearest the specified pressure point
        fsizes(fanno, 0) = 1
        If PType = 0 Then
            Do While (Val(Frmselectfan.Txtfsp.Text) - fspI(fanno, count)) ^ 2 >= (Val(Frmselectfan.Txtfsp.Text) - fspI(fanno, count + 1)) ^ 2
                If count = 500 Then
                    Getsizeatfixedspeed = 0
                    Exit Do
                End If
                count = count + 1
            Loop
        Else
            Do While (Val(Frmselectfan.Txtfsp.Text) - ftpI(fanno, count)) ^ 2 >= (Val(Frmselectfan.Txtfsp.Text) - ftpI(fanno, count + 1)) ^ 2
                If count = 500 Then
                    Getsizeatfixedspeed = 0
                    Exit Do
                End If
                count = count + 1
            Loop

        End If
        Getsizeatfixedspeed = fsizes(fanno, count)

        '---------checking for secondary data
        If fsizes(fanno, count) >= fansizelimit(fanno) And fansizelimit(fanno) <> 0 And runonce <> "yes" Then
            Call loadfandata(fantypesecfilename(fanno), fanno)
            Call scaledensity(fanno, getscalefactor)
            runonce = "yes"
            Call Getsizeatfixedspeed(fanno)
            Exit Function
        End If
        '-------------------------------------
        If Val(Frmselectfan.Txtfsp.Text) <> 0 And Frmselectfan.Optsucy.Checked = True Then
            Call scaledensity(fanno, originaldensity / Val(Frmselectfan.Txtdens))
            MsgBox("Fan Type " + fanno.ToString + ": " & fanclass(fanno) & ", A new value for Pressure has been calculated!", vbInformation)
        End If
        '-----------------------------------------------
        If Getsizeatfixedspeed = 0 Then
            MsgBox("Fan Type " + fanclass(fanno) + ": Sorry this duty is out of range for this fan type")
            Exit Function
        End If

        Call getpressure(Getsizeatfixedspeed(fanno), speed, Val(Frmselectfan.Txtflow.Text), fanno)

        Catch ex As Exception
            MsgBox("Getsizeatfixedspeed")
        End Try

    End Function

End Module
