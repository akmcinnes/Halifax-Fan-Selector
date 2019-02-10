Module ModMisc
    Public Sub Initialize(Set1stTime As Boolean)
        Try
            If Set1stTime = True Then
                SetUnitStructure()

                SetUnits()
                'populating Pressure Type
                '        Frmselectfan.cmbPressType.AddItem "Fan Static"
                '        Frmselectfan.cmbPressType.AddItem "Fan Total"
                '        DensMult = 1

                'NextSpeed = "2 Pole"'300119
                RunTemp = 20
                For II = 0 To 50 - 1
                    Widthratios(II) = 1
                Next II
                'Customer = ""
                FileSaved = False
                designtemp = 0.0
                maximumtemp = 0.0
                ambienttemp = 0.0
                altitude = 0.0
                humidity = 0.0
                atmospress = 0.0
                knowndensity = 0.0
                'calcdensity = 0.0'300119
                flowrate = 0.0
                reshead = 5.0
                inletpress = 0.0
                dischpress = 0.0
                pressrise = 0.0
                maxspeed = 0.0
                fansize = 0.0
                'If UserName.ToLower.Contains("akm") = True Then
                If StartArg.ToLower.Contains("-dev") = True Then
                    designtemp = 20.0
                    maximumtemp = 20.0
                    ambienttemp = 20.0
                    atmospress = 101325.0
                    'knowndensity = 1.2
                    'flowrate = 10000.0
                    'pressrise = 4000.0
                    knowndensity = 1.2
                    flowrate = 10000.0
                    pressrise = 4000.0
                    maxspeed = 3600.0
                    'Frmselectfan.Txtflow.Text = flowrate.ToString 'akm 080219
                    'Frmselectfan.Txtfsp.Text = pressrise.ToString 'akm 080219
                End If
            End If

        Catch ex As Exception
            '            MsgBox("Initialize")
            ErrorMessage(ex, 5501)
        End Try
    End Sub

    Sub ModifyDatapoints(ByVal fanno As Integer, ByVal count1 As Integer, ByVal fsize As Double, ByVal fspeed As Double, ByVal num As Integer)
        Try
            fsps(fanno, count1) = ScalePFSize(fsp(fanno, count1), datafansize(fanno), fsize)
            ftps(fanno, count1) = ScalePFSize(ftp(fanno, count1), datafansize(fanno), fsize)
            vols(fanno, count1) = ScaleVFSize(vol(fanno, count1), datafansize(fanno), fsize)
            Pows(fanno, count1) = ScalePowFSize(Powr(fanno, count1), datafansize(fanno), fsize)
            '-scales for constant volume at each datapoint
            'If (num = 1) Then
            '    fspeed = Val(Frmselectfan.Txtflow.Text) * datafanspeed(fanno) / vols(fanno, count1)
            '    vols(fanno, count1) = Val(Frmselectfan.Txtflow.Text)
            'ElseIf (num = 2) Then
            '    vols(fanno, count1) = ScaleVFSpeed(vols(fanno, count1), datafanspeed(fanno), fspeed)
            'ElseIf (num = 3) Then
            '    ftspeed(fanno, count1) = Val(Frmselectfan.Txtflow.Text) * datafanspeed(fanno) / vols(fanno, count1)
            '    vols(fanno, count1) = Val(Frmselectfan.Txtflow.Text)
            'ElseIf (num = 4) Then
            '    fspeed = Val(Frmselectfan.Txtfanspeed.Text)
            '    vols(fanno, count1) = ScaleVFSpeed(vols(fanno, count1), datafanspeed(fanno), fspeed)
            'End If
            If (num = 1) Then
                fspeed = flowrate * datafanspeed(fanno) / vols(fanno, count1)
                vols(fanno, count1) = flowrate
            ElseIf (num = 2) Then
                vols(fanno, count1) = ScaleVFSpeed(vols(fanno, count1), datafanspeed(fanno), fspeed)
            ElseIf (num = 3) Then
                ftspeed(fanno, count1) = flowrate * datafanspeed(fanno) / vols(fanno, count1)
                vols(fanno, count1) = flowrate
            ElseIf (num = 4) Then
                fspeed = Val(Frmselectfan.Txtfanspeed.Text)
                vols(fanno, count1) = ScaleVFSpeed(vols(fanno, count1), datafanspeed(fanno), fspeed)
            End If
            fsps(fanno, count1) = ScalePFSpeed(fsps(fanno, count1), datafanspeed(fanno), fspeed)
            ftps(fanno, count1) = ScalePFSpeed(ftps(fanno, count1), datafanspeed(fanno), fspeed)
            Pows(fanno, count1) = ScalePowFSpeed(Pows(fanno, count1), datafanspeed(fanno), fspeed)
            'count1 = count1 + 1

        Catch ex As Exception
            ErrorMessage(ex, 5512)
        End Try
    End Sub

    Public Function IntToByteArray(toBeConverted As Integer) As String
        Dim result As Integer = 0
        Try
            If (toBeConverted >= 16 And toBeConverted < 32) Then
                result = result + 10000
                toBeConverted = toBeConverted - 16
            End If
            If (toBeConverted >= 8 And toBeConverted < 16) Then
                result = result + 1000
                toBeConverted = toBeConverted - 8
            End If
            If (toBeConverted >= 4 And toBeConverted < 8) Then
                result = result + 100
                toBeConverted = toBeConverted - 4
            End If
            If (toBeConverted >= 2 And toBeConverted < 4) Then
                result = result + 10
                toBeConverted = toBeConverted - 2
            End If
            If (toBeConverted >= 1 And toBeConverted < 2) Then
                result = result + 1
                toBeConverted = toBeConverted - 1
            End If
            Return result.ToString("0000")

        Catch ex As Exception
            ErrorMessage(ex, 5513)
            Return result.ToString
        End Try
    End Function

    Public Sub Yellow(Ctrl As System.Windows.Forms.TextBox, Optional MinValue As Double = 0.0)
        Try
            Dim val As Double
            If Double.TryParse(Ctrl.Text, val) = False Then
                Ctrl.BackColor = Color.LightYellow
                Ctrl.Text = ""
                move_on = False
            ElseIf CDbl(Ctrl.Text) <= MinValue Then
                Ctrl.BackColor = Color.LightYellow
                Ctrl.Text = ""
                move_on = False
            Else
                Ctrl.BackColor = Color.White
            End If
        Catch ex As Exception
            ErrorMessage(ex, 5514)
        End Try
    End Sub
End Module
