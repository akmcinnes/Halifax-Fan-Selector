﻿Module Sub_General

    Public Sub MetricUnits()
        Try
            With Frmselectfan
                .OptFlowM3PerHr.Checked = True
                .OptPressurePa.Checked = True
                .OptTemperatureC.Checked = True
                .OptDensityKgPerM3.Checked = True
                .OptPowerKW.Checked = True
                .OptLengthMm.Checked = True
                .OptAltitudeM.Checked = True
                .OptVelocityMpers.Checked = True
                '.OptVelocityFtpermin.Checked = False
                ''.TxtAltitude.Text = Math.Round(Val(.TxtAltitude.Text) * convalt, 0).ToString

            End With

        Catch ex As Exception
            ErrorMessage(ex, 1000)
        End Try
    End Sub

    Public Sub ImperialUnits()
        Try
            With Frmselectfan
                .OptFlowCfm.Checked = True
                .OptPressureinWG.Checked = True
                .OptTemperatureF.Checked = True
                .OptDensityLbPerFt3.Checked = True
                .OptPowerHp.Checked = True
                .OptLengthIn.Checked = True
                .OptAltitudeFt.Checked = True
                .OptVelocityFtpermin.Checked = True
                ''.TxtAltitude.Text = Math.Round(Val(.TxtAltitude.Text) * convalt, 0).ToString

            End With

        Catch ex As Exception
            ErrorMessage(ex, 1001)
        End Try
    End Sub

End Module
