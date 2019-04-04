Module Sub_FanParameters
    Sub SetupFanParametersPage()
        Try
            With Frmselectfan
                Dim temppower As Double
                Dim presconv, flowconv As Double
                Dim v As Double
                Dim p As Double
                'v = CDbl(.Txtflow.Text) / convflow / 3600.0
                ''v = flowrate / convflow / 3600.0
                If Units(0).UnitSelected = 0 Then flowconv = 3600.0
                If Units(0).UnitSelected = 1 Then flowconv = 60.0
                If Units(0).UnitSelected = 2 Then flowconv = 1.0
                If Units(0).UnitSelected = 3 Then flowconv = 2118.8799727597
                v = flowrate / flowconv
                'p = CDbl(.Txtfsp.Text) / convpres / 1000.0
                If Units(1).UnitSelected = 0 Then presconv = 1000.0
                If Units(1).UnitSelected = 1 Then presconv = 10.0
                If Units(1).UnitSelected = 2 Then presconv = 4.014742133113
                If Units(1).UnitSelected = 3 Then presconv = 101.974428892211
                If Units(1).UnitSelected = 4 Then presconv = 1.0

                p = pressrise / presconv
                temppower = v * p / 0.7
                ReadMotorFromBinaryFile()
                count = 0
                Do While (temppower * 1.1) > Motor_Information(count).PowerKW
                    count = count + 1
                    If count = 100 Then
                        Exit Do
                    End If
                Loop
                Motor_Pole_Speeds = Motor_Information(count)
                Select Case freqHz
                    Case 50
                        If Motor_Pole_Speeds.Speed50(0) = 0 Then .Opt2Pole.Visible = False
                        If Motor_Pole_Speeds.Speed50(1) = 0 Then .Opt4Pole.Visible = False
                        If Motor_Pole_Speeds.Speed50(2) = 0 Then .Opt6Pole.Visible = False
                        If Motor_Pole_Speeds.Speed50(3) = 0 Then .Opt8Pole.Visible = False
                        If Motor_Pole_Speeds.Speed50(4) = 0 Then .Opt10Pole.Visible = False
                        If Motor_Pole_Speeds.Speed50(5) = 0 Then .Opt12Pole.Visible = False
                    Case 60
                        If Motor_Pole_Speeds.Speed60(0) = 0 Then .Opt2Pole.Visible = False
                        If Motor_Pole_Speeds.Speed60(1) = 0 Then .Opt4Pole.Visible = False
                        If Motor_Pole_Speeds.Speed60(2) = 0 Then .Opt6Pole.Visible = False
                        If Motor_Pole_Speeds.Speed60(3) = 0 Then .Opt8Pole.Visible = False
                        If Motor_Pole_Speeds.Speed60(4) = 0 Then .Opt10Pole.Visible = False
                        If Motor_Pole_Speeds.Speed60(5) = 0 Then .Opt12Pole.Visible = False
                End Select

                If .Opt2Pole.Visible = False And .Opt2Pole.Checked = True Then .OptAnySpeed.Checked = True
                If .Opt4Pole.Visible = False And .Opt4Pole.Checked = True Then .Opt2Pole.Checked = True
                If .Opt6Pole.Visible = False And .Opt6Pole.Checked = True Then .Opt2Pole.Checked = True
                If .Opt8Pole.Visible = False And .Opt8Pole.Checked = True Then .Opt2Pole.Checked = True
                If .Opt10Pole.Visible = False And .Opt10Pole.Checked = True Then .Opt2Pole.Checked = True
                If .Opt10Pole.Visible = False And .Opt12Pole.Checked = True Then .Opt2Pole.Checked = True

                Select Case freqHz
                    Case 50
                        If .Opt2Pole.Checked = True Then .Txtfanspeed.Text = Motor_Pole_Speeds.Speed50(0).ToString
                        If .Opt4Pole.Checked = True Then .Txtfanspeed.Text = Motor_Pole_Speeds.Speed50(1).ToString
                        If .Opt6Pole.Checked = True Then .Txtfanspeed.Text = Motor_Pole_Speeds.Speed50(2).ToString
                        If .Opt8Pole.Checked = True Then .Txtfanspeed.Text = Motor_Pole_Speeds.Speed50(3).ToString
                        If .Opt10Pole.Checked = True Then .Txtfanspeed.Text = Motor_Pole_Speeds.Speed50(4).ToString
                        If .Opt12Pole.Checked = True Then .Txtfanspeed.Text = Motor_Pole_Speeds.Speed50(5).ToString
                    Case 60
                        If .Opt2Pole.Checked = True Then .Txtfanspeed.Text = Motor_Pole_Speeds.Speed60(0).ToString
                        If .Opt4Pole.Checked = True Then .Txtfanspeed.Text = Motor_Pole_Speeds.Speed60(1).ToString
                        If .Opt6Pole.Checked = True Then .Txtfanspeed.Text = Motor_Pole_Speeds.Speed60(2).ToString
                        If .Opt8Pole.Checked = True Then .Txtfanspeed.Text = Motor_Pole_Speeds.Speed60(3).ToString
                        If .Opt10Pole.Checked = True Then .Txtfanspeed.Text = Motor_Pole_Speeds.Speed60(4).ToString
                        If .Opt12Pole.Checked = True Then .Txtfanspeed.Text = Motor_Pole_Speeds.Speed60(5).ToString
                End Select
                .TabControl1.SelectTab(.TabPageFanParameters)

                'kp = CalculateKP(1.4, CDbl(.TxtAtmosphericPressure.Text), CDbl(.Txtfsp.Text), CDbl(.TxtInletPressure.Text))
                ''kp = CalculateKP(1.4, CDbl(.TxtAtmosphericPressure.Text), pressrise, inletpress)
            End With
        Catch ex As Exception
            ErrorMessage(ex, 1201)

        End Try
    End Sub
    Sub SetSpeeds(Poles As Integer)
        Try
            With Frmselectfan
                If freqHz = 50 Then .Txtfanspeed.Text = Motor_Pole_Speeds.Speed50(Poles).ToString
                If freqHz = 60 Then .Txtfanspeed.Text = Motor_Pole_Speeds.Speed60(Poles).ToString
                .Txtspeedlimit.Text = .Txtfanspeed.Text
            End With
        Catch ex As Exception
            ErrorMessage(ex, 1202)
        End Try
    End Sub
    Public Function CalculateKP(gamma As Double, atmos As Double, fsp As Double, ip As Double) As Double
        Try
            Dim a, b, c As Double
            a = gamma / (gamma - 1)
            b = (gamma - 1) / gamma
            c = (atmos + fsp) / (atmos + ip)
            kp = (a * ((c ^ b) - 1)) / (c - 1)
            Return kp
        Catch ex As Exception
            ErrorMessage(ex, 1203)
        End Try
        Return kp
    End Function
End Module

