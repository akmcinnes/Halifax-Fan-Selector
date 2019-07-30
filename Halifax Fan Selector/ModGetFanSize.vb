Imports System.Diagnostics
Module ModGetFanSize
    Public Function GetFanSize(ByVal fanno As Integer)
        Dim retval As Double = 0.0
        Try
            count = 0
            Dim tempkp As Double = 1.0
            fsizes(fanno, count) = 1.0
            Do While fsizes(fanno, count) <> 0
                count1 = 0
                Do While Powr(fanno, count1) <> 0
                    '-scaling for fan sizes
                    If vol(fanno, count1) = 0 Then
                        vol(fanno, count1) = 0.0001
                    End If
                    fsps(fanno, count1) = ScalePFSize(fsp(fanno, count1), datafansize(fanno), fsizes(fanno, count))
                    ftps(fanno, count1) = ScalePFSize(ftp(fanno, count1), datafansize(fanno), fsizes(fanno, count))
                    vols(fanno, count1) = ScaleVFSize(vol(fanno, count1), datafansize(fanno), fsizes(fanno, count))
                    Pows(fanno, count1) = ScalePowFSize(Powr(fanno, count1), datafansize(fanno), fsizes(fanno, count))
                    '-scales for constant volume at each datapoint
                    ftspeed(fanno, count1) = flowrate * datafanspeed(fanno) / vols(fanno, count1)
                    vols(fanno, count1) = flowrate
                    fsps(fanno, count1) = ScalePFSpeed(fsps(fanno, count1), datafanspeed(fanno), ftspeed(fanno, count1))
                    ftps(fanno, count1) = ScalePFSpeed(ftps(fanno, count1), datafanspeed(fanno), ftspeed(fanno, count1))
                    Pows(fanno, count1) = ScalePowFSpeed(Pows(fanno, count1), datafanspeed(fanno), ftspeed(fanno, count1))
                    'correct for kp akm 260319 no size no speed
                    tempkp = CalculateKP(1.4, kpatmos, fsps(fanno, count1), 0)
                    'If fanclass(fanno) = "MBI" Then
                    '    Debug.Print(fanclass(fanno) + " fsps = " + fsps(fanno, count1).ToString + " speed = " + ftspeed(fanno, count1).ToString + " size = " + fsizes(fanno, count1).ToString)
                    'End If
                    'If Frmselectfan.chkKP.Checked = False Then
                    '    If fanclass(fanno) = "CBC" And CInt(fsizes(fanno, count)) = 30 Then
                    '        fsps(fanno, count1) = fsps(fanno, count1) * tempkp '1.0 / tempkp1.0 / tempkp
                    '        ftps(fanno, count1) = ftps(fanno, count1) * tempkp '1.0 / tempkp1.0 / tempkp
                    '    Else
                    '        fsps(fanno, count1) = fsps(fanno, count1) * tempkp '1.0 / tempkp1.0 / tempkp
                    '        ftps(fanno, count1) = ftps(fanno, count1) * tempkp '1.0 / tempkp1.0 / tempkp
                    '    End If
                    'End If
                    count1 = count1 + 1
                Loop
                count2 = 0
                '-finds the point where the pressure is nearest
                If PresType = 0 Then
                    Do While (pressrise - fsps(fanno, count2)) ^ 2 > (pressrise - fsps(fanno, count2 + 1)) ^ 2
                        count2 = count2 + 1
                    Loop
                Else
                    Do While (pressrise - ftps(fanno, count2)) ^ 2 > (pressrise - ftps(fanno, count2 + 1)) ^ 2
                        count2 = count2 + 1
                    Loop
                End If
                '-recording the best point for each fan size
                datapointI(fanno, fsizes(fanno, count)) = count2
                fspI(fanno, fsizes(fanno, count)) = fsps(fanno, count2)
                ftpI(fanno, fsizes(fanno, count)) = ftps(fanno, count2)
                fanspeedI(fanno, fsizes(fanno, count)) = ftspeed(fanno, count2)
                aa = ftps(fanno, count2)
                count = count + 1
            Loop
            '-finds the point nearest the highest efficiency point
            fsizes(fanno, 0) = 1
            count = 0
            Do While Math.Abs(medpoint(fanno) - datapointI(fanno, fsizes(fanno, count))) ^ 2 >= Math.Abs(medpoint(fanno) - datapointI(fanno, fsizes(fanno, count + 1))) ^ 2 Or fanspeedI(fanno, fsizes(fanno, count)) > maxspeed
                If count = 50 Then
                    retval = 0
                    Exit Do
                End If
                count = count + 1
                retval = fsizes(fanno, count)
            Loop
            '-end of getting the best fan size at anyspeed for efficiency
            Return retval
        Catch ex As Exception
            If StartArg.ToLower.Contains("-def") Then ErrorMessage(ex, 5201)
        End Try
        Return retval
    End Function
End Module
