Module Sub_Duty
    Sub SetupDutyPage()
        Try
            If ReadFromProjectFile = False Then Initialize(False)
            With Frmselectfan
                .TxtAtmosphericPressure.Text = atmos.ToString
                .TxtDesignTemperature.Text = designtemp.ToString
                .TxtMaximumTemperature.Text = maximumtemp.ToString
                .TxtAmbientTemperature.Text = ambienttemp.ToString

                'TxtAltitude.Text = altitude.ToString
                'TxtHumidity.Text = humidity.ToString
                .TxtAtmosphericPressure.Text = atmospress.ToString
                '.Txtdens.Text = knowndensity.ToString
                '.Txtflow.Text = flowrate.ToString
                '.TxtInletPressure.Text = inletpress.ToString
                '.TxtDischargePressure.Text = dischpress.ToString
                '.Txtfsp.Text = pressrise.ToString
                '.CmbReserveHead.Text = reshead.ToString + "%"
                If freqHz = 50 Then maxspeed = 3000
                'If freqHz = 50 And OptPoleSpeed.Checked = True Then
                '    If Opt2Pole.Checked = True Then maxspeed = 3000
                '    If Opt4Pole.Checked = True Then maxspeed = 1500
                '    If Opt6Pole.Checked = True Then maxspeed = 1000
                '    If Opt8Pole.Checked = True Then maxspeed = 750
                '    If Opt10Pole.Checked = True Then maxspeed = 600
                '    If Opt12Pole.Checked = True Then maxspeed = 500
                'End If
                If freqHz = 60 Then maxspeed = 3600
                'If freqHz = 60 And OptPoleSpeed.Checked = True Then
                '    If Opt2Pole.Checked = True Then maxspeed = 3600
                '    If Opt4Pole.Checked = True Then maxspeed = 1800
                '    If Opt6Pole.Checked = True Then maxspeed = 1200
                '    If Opt8Pole.Checked = True Then maxspeed = 900
                '    If Opt10Pole.Checked = True Then maxspeed = 720
                '    If Opt12Pole.Checked = True Then maxspeed = 600
                'End If

                .Txtspeedlimit.Text = maxspeed.ToString
                .Txtfansize.Text = fansize.ToString
                .btnDutyInputForward.Focus()
                'Me.AcceptButton = Button9
                'FlowType = 1

            End With

        Catch ex As Exception
            ErrorMessage(ex, 1101)
        End Try

    End Sub
    Sub DischargeDuct(UserDefinedDD As Boolean, RatioDD As Boolean, PerCentDD As Boolean)
        Try
            Frmselectfan.txtUserDefinedDD.Enabled = UserDefinedDD
            Frmselectfan.txtRatioDD.Enabled = RatioDD
        Frmselectfan.lblUserDefinedUnits.Enabled = UserDefinedDD
        Frmselectfan.lblpercent.Enabled = PerCentDD

        Catch ex As Exception
            ErrorMessage(ex, 1102)

        End Try
    End Sub
End Module
