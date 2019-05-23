Module Sub_Duty
    Sub SetupDutyPage()
        Try
            If ReadFromProjectFile = False Then Initialize(False)
            SetUnitValues()

            With Frmselectfan
                '.TxtAtmosphericPressure.Text = atmos.ToString
                .TxtDesignTemperature.Text = designtemp.ToString
                .TxtMaximumTemperature.Text = maximumtemp.ToString
                .TxtAmbientTemperature.Text = ambienttemp.ToString
                .TxtAtmosphericPressure.Text = atmospress.ToString
                .lblUserDefinedUnits.Text = Units(8).UnitName(Units(8).UnitSelected)
                If .Opt50Hz.Checked = True Then freqHz = 50
                If .Opt60Hz.Checked = True Then freqHz = 60

                If freqHz = 50 Then maxspeed = 3600 '3000
                If freqHz = 60 Then maxspeed = 4320 '3600
                .Txtspeedlimit.Text = maxspeed.ToString
                .Txtfansize.Text = fansize.ToString
                .btnDutyInputForward.Focus()
                '.Label8.TextAlign = ContentAlignment.MiddleRight
                '.Label9.TextAlign = ContentAlignment.MiddleRight
                '.Label10.TextAlign = ContentAlignment.MiddleRight
                '.Label7.TextAlign = ContentAlignment.MiddleRight
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

    Sub DensityCalculate()
        Try
            With Frmselectfan
                If (.OptDensityCalculated.Checked = True) Then
                    RunTemp = Val(.TxtDesignTemperature.Text)
                    If Units(2).UnitSelected = 1 Then RunTemp = Math.Round(((RunTemp - 32) * 5 / 9), 1)
                    Dim tempdens As Double
                    tempdens = Math.Round((293 / (RunTemp + 273)) * 1.2, 3)
                    If Units(3).UnitSelected = 1 Then tempdens = tempdens / 16.018476
                    .Txtdens.Text = tempdens.ToString
                    .Txtdens.ReadOnly = True
                    .btnCalculateDensity.Enabled = True
                Else
                    .Txtdens.ReadOnly = False
                    .btnCalculateDensity.Enabled = False
                End If
            End With
        Catch ex As Exception
            ErrorMessage(ex, 1103)
        End Try

    End Sub

    Public Sub Check_Leave_Duty()
        Try
            Flag(2) = True
            move_on = True
        Yellow(Frmselectfan.Txtflow)
        'RedBorder(Txtflow)
        Yellow(Frmselectfan.Txtdens)
        Yellow(Frmselectfan.Txtfsp)
        Yellow(Frmselectfan.TxtInletPressure, -9999.99)
        Yellow(Frmselectfan.TxtDesignTemperature, -50.0)
        If Frmselectfan.optDDUserDefined.Checked = True Then
            Yellow(Frmselectfan.txtUserDefinedDD)
        Else
            Frmselectfan.txtUserDefinedDD.BackColor = Color.White
        End If
        If Frmselectfan.optDDRatio.Checked = True Then
            Yellow(Frmselectfan.txtRatioDD)
        Else
            Frmselectfan.txtRatioDD.BackColor = Color.White
        End If

        If move_on = True Then

            flowrate = CDbl(Frmselectfan.Txtflow.Text)
            If Units(0).UnitSelected = 4 Then
                flowrate = CDbl(Frmselectfan.Txtflow.Text) / CDbl(Frmselectfan.Txtdens.Text)
            End If
            If Units(0).UnitSelected = 5 Then
                flowrate = CDbl(Frmselectfan.Txtflow.Text) / (CDbl(Frmselectfan.Txtdens.Text) * 60)
            End If

            designtemp = CDbl(Frmselectfan.TxtDesignTemperature.Text)
            knowndensity = CDbl(Frmselectfan.Txtdens.Text)
            pressrise = CDbl(Frmselectfan.Txtfsp.Text)
            inletpress = CDbl(Frmselectfan.TxtInletPressure.Text)

            dischpress = CDbl(Frmselectfan.TxtDischargePressure.Text)
            Dim str_temp As String
            If Frmselectfan.CmbReserveHead.SelectedIndex < 0 Then Frmselectfan.CmbReserveHead.SelectedIndex = 0
            str_temp = Frmselectfan.CmbReserveHead.Items(Frmselectfan.CmbReserveHead.SelectedIndex)

            reshead = CDbl(str_temp.Remove(str_temp.Length - 1))
            SetupFanParametersPage()
        End If

        Catch ex As Exception
            ErrorMessage(ex, 1104)
        End Try

    End Sub
End Module
