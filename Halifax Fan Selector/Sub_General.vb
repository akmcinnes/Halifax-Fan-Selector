﻿Module Sub_General

    Public Sub MetricUnits()
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
            .TxtAltitude.Text = Math.Round(Val(.TxtAltitude.Text) * convalt, 0).ToString

        End With
    End Sub

    Public Sub ImperialUnits()
        With Frmselectfan
            .OptFlowCfm.Checked = True
            .OptPressureinWG.Checked = True
            .OptTemperatureF.Checked = True
            .OptDensityLbPerFt3.Checked = True
            .OptPowerHp.Checked = True
            .OptLengthIn.Checked = True
            .OptAltitudeFt.Checked = True
            .OptVelocityFtpermin.Checked = True
            .TxtAltitude.Text = Math.Round(Val(.TxtAltitude.Text) * convalt, 0).ToString

        End With
    End Sub

End Module
