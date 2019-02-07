Module ModGetFanSize
    Public Function GetFanSize(ByVal fanno As Integer)
        Dim retval As Double = 0.0
        Try
            count = 0
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
                    ftspeed(fanno, count1) = Val(Frmselectfan.Txtflow.Text) * datafanspeed(fanno) / vols(fanno, count1)
                    vols(fanno, count1) = Val(Frmselectfan.Txtflow.Text)
                    fsps(fanno, count1) = ScalePFSpeed(fsps(fanno, count1), datafanspeed(fanno), ftspeed(fanno, count1))
                    ftps(fanno, count1) = ScalePFSpeed(ftps(fanno, count1), datafanspeed(fanno), ftspeed(fanno, count1))
                    Pows(fanno, count1) = ScalePowFSpeed(Pows(fanno, count1), datafanspeed(fanno), ftspeed(fanno, count1))
                    count1 = count1 + 1
                Loop
                count2 = 0
                '-finds the point where the pressure is nearest
                If PresType = 0 Then
                    Do While Math.Abs(Val(Frmselectfan.Txtfsp.Text) - fsps(fanno, count2)) ^ 2 > Math.Abs(Val(Frmselectfan.Txtfsp.Text) - fsps(fanno, count2 + 1)) ^ 2
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
                'volI(fanno, fsizes(fanno, count)) = vols(fanno, count2)'300119
                'powI(fanno, fsizes(fanno, count)) = Pows(fanno, count2)'300119
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
