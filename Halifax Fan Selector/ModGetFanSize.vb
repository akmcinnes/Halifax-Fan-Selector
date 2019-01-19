Module ModGetFanSize
    Public Function GetFanSize(ByVal fanno As Integer)
        'GetFanSize = 0.0
        Dim retval As Double = 0.0
        Try

            count = 0
            Do While fsizes(fanno, count) <> 0
                'objStreamWriterDebug.WriteLine("fsizes = " + fsizes(fanno, count).ToString)
                count1 = 0
                Do While Powr(fanno, count1) <> 0
                    'objStreamWriterDebug.WriteLine("datafansize = " + datafansize(fanno).ToString)
                    'objStreamWriterDebug.WriteLine("datafanspeed = " + datafanspeed(fanno).ToString)
                    '-scaling for fan sizes
                    If vol(fanno, count1) = 0 Then
                        vol(fanno, count1) = 0.0001
                    End If
                    ' Call ModifyDatapoints(fanno, count1, fsizes(fanno, count), ftspeed(fanno, count1), 1)
                    fsps(fanno, count1) = ScalePFSize(fsp(fanno, count1), datafansize(fanno), fsizes(fanno, count))
                    ftps(fanno, count1) = ScalePFSize(ftp(fanno, count1), datafansize(fanno), fsizes(fanno, count))
                    vols(fanno, count1) = ScaleVFSize(vol(fanno, count1), datafansize(fanno), fsizes(fanno, count))
                    Pows(fanno, count1) = ScalePowFSize(Powr(fanno, count1), datafansize(fanno), fsizes(fanno, count))
                    'objStreamWriterDebug.WriteLine("0 vol = " + vol(fanno, count1).ToString)
                    'objStreamWriterDebug.WriteLine("0 fsp = " + fsp(fanno, count1).ToString)
                    'objStreamWriterDebug.WriteLine("0 ftp = " + ftp(fanno, count1).ToString)
                    'objStreamWriterDebug.WriteLine("0 Powr = " + Powr(fanno, count1).ToString)
                    'objStreamWriterDebug.WriteLine("1 vols = " + vols(fanno, count1).ToString)
                    'objStreamWriterDebug.WriteLine("1 fsps = " + fsps(fanno, count1).ToString)
                    'objStreamWriterDebug.WriteLine("1 ftps = " + ftps(fanno, count1).ToString)
                    'objStreamWriterDebug.WriteLine("1 Pows = " + Pows(fanno, count1).ToString)
                    '-scales for constant volume at each datapoint
                    ftspeed(fanno, count1) = Val(Frmselectfan.Txtflow.Text) * datafanspeed(fanno) / vols(fanno, count1)
                    vols(fanno, count1) = Val(Frmselectfan.Txtflow.Text)
                    fsps(fanno, count1) = ScalePFSpeed(fsps(fanno, count1), datafanspeed(fanno), ftspeed(fanno, count1))
                    ftps(fanno, count1) = ScalePFSpeed(ftps(fanno, count1), datafanspeed(fanno), ftspeed(fanno, count1))
                    Pows(fanno, count1) = ScalePowFSpeed(Pows(fanno, count1), datafanspeed(fanno), ftspeed(fanno, count1))
                    'objStreamWriterDebug.WriteLine("2 Powr = " + Powr(fanno, count1).ToString)
                    'objStreamWriterDebug.WriteLine("2 ftspeed = " + ftspeed(fanno, count1).ToString)
                    'objStreamWriterDebug.WriteLine("2 vols = " + vols(fanno, count1).ToString)
                    'objStreamWriterDebug.WriteLine("2 fsps = " + fsps(fanno, count1).ToString)
                    'objStreamWriterDebug.WriteLine("2 ftps = " + ftps(fanno, count1).ToString)
                    'objStreamWriterDebug.WriteLine("2 Pows = " + Pows(fanno, count1).ToString)
                    count1 = count1 + 1
                Loop
                count2 = 0
                '-finds the point where the pressure is nearest
                If PresType = 0 Then
                    Do While Math.Abs(Val(Frmselectfan.Txtfsp.Text) - fsps(fanno, count2)) ^ 2 > Math.Abs(Val(Frmselectfan.Txtfsp.Text) - fsps(fanno, count2 + 1)) ^ 2
                        'Do While Math.Abs(Val(Frmselectfan.Txtfsp.Text) - fsps(fanno, count2)) > Math.Abs(Val(Frmselectfan.Txtfsp.Text) - fsps(fanno, count2 + 1))
                        count2 = count2 + 1
                    Loop
                Else
                    Do While (Val(Frmselectfan.Txtfsp.Text) - ftps(fanno, count2)) ^ 2 > (Val(Frmselectfan.Txtfsp.Text) - ftps(fanno, count2 + 1)) ^ 2
                        count2 = count2 + 1
                    Loop
                End If
                '-recording the best point for each fan size
                datapointI(fanno, fsizes(fanno, count)) = count2
                fspI(fanno, fsizes(fanno, count)) = fsps(fanno, count2)
                ftpI(fanno, fsizes(fanno, count)) = ftps(fanno, count2)
                volI(fanno, fsizes(fanno, count)) = vols(fanno, count2)
                powI(fanno, fsizes(fanno, count)) = Pows(fanno, count2)
                fanspeedI(fanno, fsizes(fanno, count)) = ftspeed(fanno, count2)
                aa = ftps(fanno, count2)
                count = count + 1
            Loop
            'objStreamWriterDebug.WriteLine(fsizes(fanno, count - 1))
            'objStreamWriterDebug.WriteLine(fanno)
            'objStreamWriterDebug.WriteLine(count)

            '-finds the point nearest the highest efficiency point
            fsizes(fanno, 0) = 1
            count = 0
            'objStreamWriterDebug.WriteLine("med = " + medpoint(fanno).ToString)
            'objStreamWriterDebug.WriteLine("dat = " + datapointI(fanno, fsizes(fanno, count)).ToString)
            'objStreamWriterDebug.WriteLine("diff1 = " + (medpoint(fanno) - datapointI(fanno, fsizes(fanno, count))).ToString)
            'objStreamWriterDebug.WriteLine("diff2 = " + (medpoint(fanno) - datapointI(fanno, fsizes(fanno, count + 1))).ToString)
            'Do While (medpoint(1) - datapointI(1, fsizes(1, count))) ^ 2 >= (medpoint(1) - datapointI(1, fsizes(1, count + 1))) ^ 2 Or fanspeedI(1, fsizes(1, count)) > Val(Frmselectfan.Txtspeedlimit.Value)
            Do While Math.Abs(medpoint(fanno) - datapointI(fanno, fsizes(fanno, count))) ^ 2 >= Math.Abs(medpoint(fanno) - datapointI(fanno, fsizes(fanno, count + 1))) ^ 2 Or fanspeedI(fanno, fsizes(fanno, count)) > maxspeed
                'Do While medpoint(fanno) - datapointI(fanno, fsizes(fanno, count)) ^ 2 >= medpoint(fanno) - datapointI(fanno, fsizes(fanno, count + 1)) ^ 2 Or fanspeedI(fanno, fsizes(fanno, count)) > maxspeed
                If count = 50 Then
                    retval = 0
                    Exit Do
                End If
                count = count + 1
                retval = fsizes(fanno, count)
            Loop
            'objStreamWriterDebug.WriteLine("retval = " + retval.ToString)

            '-end of getting the best fan size at anyspeed for efficiency
            'objStreamWriterDebug.WriteLine("#############################################")
            Return retval

        Catch ex As Exception
            'MsgBox(ex.Message + vbCrLf + "Getfansize " + fantypefilename(fanno) + " count=" + count.ToString + " fanno=" + fanno.ToString)
            If StartArg.ToLower.Contains("-def") Then ErrorMessage(ex, 5201)
        End Try
        Return retval
    End Function
End Module
