﻿Module Sub_Duty
    Sub SetupDutyPage()
        Try
            If ReadFromProjectFile = False Then Initialize(False)
            With Frmselectfan
                '.TxtAtmosphericPressure.Text = atmos.ToString
                .TxtDesignTemperature.Text = designtemp.ToString
                .TxtMaximumTemperature.Text = maximumtemp.ToString
                .TxtAmbientTemperature.Text = ambienttemp.ToString
                .TxtAtmosphericPressure.Text = atmospress.ToString
                If freqHz = 50 Then maxspeed = 3000
                If freqHz = 60 Then maxspeed = 3600
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
End Module
