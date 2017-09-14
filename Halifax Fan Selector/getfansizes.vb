Module getfansizes
    Public Function Getfansize(ByVal fanno As Integer)
        Try
            Dim retval As Double
            count = 0
        Do While fsizes(fanno, count) <> 0
            count1 = 0
            Do While Pow(fanno, count1) <> 0
                '-scaling for fan sizes
                If vol(fanno, count1) = 0 Then
                    vol(fanno, count1) = 0.0001
                End If
                ' Call ModifyDatapoints(fanno, count1, fsizes(fanno, count), ftspeed(fanno, count1), 1)
                fsps(fanno, count1) = scalePFSize(fsp(fanno, count1), datafansize(fanno), fsizes(fanno, count))
                ftps(fanno, count1) = scalePFSize(ftp(fanno, count1), datafansize(fanno), fsizes(fanno, count))
                vols(fanno, count1) = scaleVFSize(vol(fanno, count1), datafansize(fanno), fsizes(fanno, count))
                Pows(fanno, count1) = scalePowFSize(Pow(fanno, count1), datafansize(fanno), fsizes(fanno, count))
                '-scales for constant volume at each datapoint
                ftspeed(fanno, count1) = Val(Frmselectfan.Txtflow.Text) * datafanspeed(fanno) / vols(fanno, count1)
                vols(fanno, count1) = Val(Frmselectfan.Txtflow.Text)
                fsps(fanno, count1) = scalePFSpeed(fsps(fanno, count1), datafanspeed(fanno), ftspeed(fanno, count1))
                ftps(fanno, count1) = scalePFSpeed(ftps(fanno, count1), datafanspeed(fanno), ftspeed(fanno, count1))
                Pows(fanno, count1) = scalePowFSpeed(Pows(fanno, count1), datafanspeed(fanno), ftspeed(fanno, count1))
                count1 = count1 + 1
            Loop
            count2 = 0
            '-finds the point where the pressure is nearest
            If PType = 0 Then
                Do While (Val(Frmselectfan.Txtfsp.Text) - fsps(fanno, count2)) ^ 2 > (Val(Frmselectfan.Txtfsp.Text) - fsps(fanno, count2 + 1)) ^ 2
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
        '-finds the point nearest the highest efficiency point
        fsizes(fanno, 0) = 1
        count = 0
        Do While (medpoint(fanno) - datapointI(fanno, fsizes(fanno, count))) ^ 2 >= (medpoint(fanno) - datapointI(fanno, fsizes(fanno, count + 1))) ^ 2 Or fanspeedI(fanno, fsizes(fanno, count)) > Val(Frmselectfan.Txtspeedlimit.Text)
            If count = 50 Then
                retval = 0
                Exit Do
            End If
            count = count + 1
            '            Getfansize = fsizes(fanno, count)
            retval = fsizes(fanno, count)
        Loop
        '-end of getting the best fan size at anyspeed for efficiency
        Return retval

        Catch ex As Exception
            MsgBox("Getfansize")
        End Try
    End Function
End Module
