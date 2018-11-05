Module Sub_Environment
    Public Sub MetricUnits()
        Frmselectfan.OptFlowM3PerHr.Checked = True
        Frmselectfan.OptPressurePa.Checked = True
        Frmselectfan.OptTemperatureC.Checked = True
        Frmselectfan.OptDensityKgPerM3.Checked = True
        Frmselectfan.OptPowerKW.Checked = True
        Frmselectfan.OptLengthMm.Checked = True
        Frmselectfan.OptAltitudeM.Checked = True
        Frmselectfan.OptVelocityMpers.Checked = True
        'frmselectfan.OptVelocityFtpermin.Checked = False
        Frmselectfan.TxtAltitude.Text = Math.Round(Val(Frmselectfan.TxtAltitude.Text) * convalt, 0).ToString
    End Sub

    Public Sub ImperialUnits()
        Frmselectfan.OptFlowCfm.Checked = True
        Frmselectfan.OptPressureinWG.Checked = True
        Frmselectfan.OptTemperatureF.Checked = True
        Frmselectfan.OptDensityLbPerFt3.Checked = True
        Frmselectfan.OptPowerHp.Checked = True
        Frmselectfan.OptLengthIn.Checked = True
        Frmselectfan.OptAltitudeFt.Checked = True
        Frmselectfan.OptVelocityFtpermin.Checked = True
        Frmselectfan.TxtAltitude.Text = Math.Round(Val(Frmselectfan.TxtAltitude.Text) * convalt, 0).ToString
    End Sub

End Module
