Public Class FrmUnits
    Private Sub FrmUnits_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.CenterToParent()
            'Flow
            'OptFlowM3PerHr.Checked = False
            'OptFlowM3PerMin.Checked = False
            'OptFlowM3PerSec.Checked = False
            'OptFlowCfm.Checked = False
            'OptFlowKgPerHr.Checked = False
            'OptFlowLbPerHr.Checked = False
            If Units(0).UnitSelected = 0 Then OptFlowM3PerHr.Checked = True
        If Units(0).UnitSelected = 1 Then OptFlowM3PerMin.Checked = True
        If Units(0).UnitSelected = 2 Then OptFlowM3PerSec.Checked = True
        If Units(0).UnitSelected = 3 Then OptFlowCfm.Checked = True
        If Units(0).UnitSelected = 4 Then OptFlowKgPerHr.Checked = True
        If Units(0).UnitSelected = 5 Then OptFlowLbPerHr.Checked = True

        'Pressure
        'OptPressurePa.Checked = False
        'OptPressuremBar.Checked = False
        'OptPressureinWG.Checked = False
        'OptPressuremmWG.Checked = False
        If Units(1).UnitSelected = 0 Then OptPressurePa.Checked = True
        If Units(1).UnitSelected = 1 Then OptPressureinWG.Checked = True
        If Units(1).UnitSelected = 2 Then OptPressuremmWG.Checked = True
        If Units(1).UnitSelected = 3 Then OptPressuremBar.Checked = True

        'Temperature
        'OptTemperatureC.Checked = False
        'OptTemperatureF.Checked = False
        If Units(2).UnitSelected = 0 Then OptTemperatureC.Checked = True
        If Units(2).UnitSelected = 1 Then OptTemperatureF.Checked = True

        'Density
        'OptDensityKgPerM3.Checked = False
        'OptDensityLbPerFt3.Checked = False
        If Units(3).UnitSelected = 0 Then OptDensityKgPerM3.Checked = True
        If Units(3).UnitSelected = 1 Then OptDensityLbPerFt3.Checked = True

        'Power
        'OptPowerKW.Checked = False
        'OptPowerHp.Checked = False
        If Units(4).UnitSelected = 0 Then OptPowerKW.Checked = True
        If Units(4).UnitSelected = 1 Then OptPowerHp.Checked = True

        'Length
        'OptLengthIn.Checked = False
        'OptLengthMm.Checked = False
        If Units(5).UnitSelected = 0 Then OptLengthMm.Checked = True
        If Units(5).UnitSelected = 1 Then OptLengthIn.Checked = True

        'Altitude
        'OptAltitudeM.Checked = False
        'OptAltitudeFt.Checked = False
        If Units(6).UnitSelected = 0 Then OptAltitudeM.Checked = True
        If Units(6).UnitSelected = 1 Then OptAltitudeFt.Checked = True

        'Velocity
        'OptVelocityMpers.Checked = False
        'OptVelocityFtpermin.Checked = False
        If Units(7).UnitSelected = 0 Then OptVelocityMpers.Checked = True
        If Units(7).UnitSelected = 1 Then OptVelocityFtpermin.Checked = True

        'Set defaults
        OptDefaultMetric.Checked = False
        OptDefaultImperial.Checked = False
        OptDefaultNone.Checked = True

        Catch ex As Exception
            MsgBox("load")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Try
            'flow units
            If OptFlowM3PerHr.Checked = True Then
            If Units(0).UnitSelected = 0 Then convflow = 1.0
            If Units(0).UnitSelected = 1 Then convflow = 60.0
            If Units(0).UnitSelected = 2 Then convflow = 3600.0
            If Units(0).UnitSelected = 3 Then convflow = 1.0 / 0.58857777021102 '3600.0 * 0.00047192
            If Units(0).UnitSelected = 4 Then convflow = 1.0
            'Select Case Units(0).UnitSelected
            '    Case 0
            '        convflow = 1
            '    Case 1
            '        convflow = 1 / 60
            '    Case 2
            '        convflow = 1 / 3600
            '    Case 3
            '        convflow = 1 / 3600 / 0.00047192
            '    Case 4
            '    Case 5
            'End Select
            Units(0).UnitSelected = 0
            colvol = 9
            FlowType = 1
        End If
        If OptFlowM3PerMin.Checked = True Then
            If Units(0).UnitSelected = 0 Then convflow = 1.0 / 60.0
            If Units(0).UnitSelected = 1 Then convflow = 1.0
            If Units(0).UnitSelected = 2 Then convflow = 60.0
            If Units(0).UnitSelected = 3 Then convflow = 1.0 / 0.58857777021102 / 60.0
            If Units(0).UnitSelected = 4 Then convflow = 1.0

            'Select Case Units(0).UnitSelected
            '    Case 0
            '        convflow = 60
            '    Case 1
            '        convflow = 1
            '    Case 2
            '        convflow = 1 / 60
            '    Case 3
            '        convflow = 1 / 60 / 0.00047192
            '    Case 4
            '    Case 5
            'End Select
            Units(0).UnitSelected = 1
            colvol = 11
            FlowType = 2
        End If
        If OptFlowM3PerSec.Checked = True Then
            If Units(0).UnitSelected = 0 Then convflow = 1.0 / 3600.0
            If Units(0).UnitSelected = 1 Then convflow = 1.0 / 60.0
            If Units(0).UnitSelected = 2 Then convflow = 1.0
            If Units(0).UnitSelected = 3 Then convflow = 1.0 / 0.58857777021102 / 3600.0
            If Units(0).UnitSelected = 4 Then convflow = 1.0
            'Select Case Units(0).UnitSelected
            '    Case 0
            '        convflow = 3600
            '    Case 1
            '        convflow = 60
            '    Case 2
            '        convflow = 1
            '    Case 3
            '        convflow = 1 / 0.00047192
            '    Case 4
            '    Case 5
            'End Select
            Units(0).UnitSelected = 2
            colvol = 12
            FlowType = 3
        End If
        If OptFlowCfm.Checked = True Then
            If Units(0).UnitSelected = 0 Then convflow = 0.58857777021102 '0.00047192 / 3600.0
            If Units(0).UnitSelected = 1 Then convflow = 60.0 * 0.58857777021102 '0.00047192 / 60.0
            If Units(0).UnitSelected = 2 Then convflow = 3600.0 * 0.58857777021102 '0.00047192
            If Units(0).UnitSelected = 3 Then convflow = 1.0
            If Units(0).UnitSelected = 4 Then convflow = 1.0
            'Select Case Units(0).UnitSelected
            '    Case 0
            '        convflow = 3600 * 0.00047192
            '    Case 1
            '        convflow = 60 * 0.00047192
            '    Case 2
            '        convflow = 1 * 0.00047192
            '    Case 3
            '        convflow = 1
            '    Case 4
            '    Case 5
            'End Select
            Units(0).UnitSelected = 3
            colvol = 4
            FlowType = 4
        End If
        If OptFlowKgPerHr.Checked = True Then
            Units(0).UnitSelected = 4
        End If
        If OptFlowLbPerHr.Checked = True Then
            Units(0).UnitSelected = 5
        End If

        'pressure units
        If OptPressurePa.Checked = True Then
            If Units(1).UnitSelected = 0 Then convpres = 1.0
            If Units(1).UnitSelected = 1 Then convpres = 249.0891
            If Units(1).UnitSelected = 2 Then convpres = 9.80665
            If Units(1).UnitSelected = 3 Then convpres = 100.0
            'Select Case Units(1).UnitSelected
            '    Case 0
            '        convpres = 1
            '    Case 1
            '        convpres = 249.08891
            '    Case 2
            '        convpres = 9.80665
            '    Case 3
            '        convpres = 100
            'End Select
            Units(1).UnitSelected = 0
            fspcol = 13
            ftpcol = 14
            '            atmos = 101389.0
        End If
        If OptPressureinWG.Checked = True Then
            If Units(1).UnitSelected = 0 Then convpres = 1.0 / 249.0891
            If Units(1).UnitSelected = 1 Then convpres = 1.0
            If Units(1).UnitSelected = 2 Then convpres = 1.0 / 25.4
            If Units(1).UnitSelected = 3 Then convpres = 1.0 / 2.4908891
            'Select Case Units(1).UnitSelected
            '    Case 0
            '        convpres = 1 / 249.08891
            '    Case 1
            '        convpres = 1
            '    Case 2
            '        convpres = 1 / 25.4
            '    Case 3
            '        convpres = 1 / 2.4908891
            'End Select
            Units(1).UnitSelected = 1
            fspcol = 2
            ftpcol = 5
            'atmos = 407.45
        End If
        If OptPressuremmWG.Checked = True Then
            If Units(1).UnitSelected = 0 Then convpres = 1.0 / 9.80665
            If Units(1).UnitSelected = 1 Then convpres = 25.4
            If Units(1).UnitSelected = 2 Then convpres = 1.0
            If Units(1).UnitSelected = 3 Then convpres = 1.0 / 0.0980665
            'Select Case Units(1).UnitSelected
            '    Case 0
            '        convpres = 1 / 9.80665
            '    Case 1
            '        convpres = 25.4
            '    Case 2
            '        convpres = 1
            '    Case 3
            '        convpres = 1 / 0.0980665
            'End Select
            Units(1).UnitSelected = 2
            fspcol = 7
            ftpcol = 10
            'atmos = 10349.1
        End If
        If OptPressuremBar.Checked = True Then
            If Units(1).UnitSelected = 0 Then convpres = 1.0 / 100.0
            If Units(1).UnitSelected = 1 Then convpres = 2.4908891
            If Units(1).UnitSelected = 2 Then convpres = 0.0980665
            If Units(1).UnitSelected = 3 Then convpres = 1.0
            'Select Case Units(1).UnitSelected
            '    Case 0
            '        convpres = 1 / 100
            '    Case 1
            '        convpres = 2.4908891
            '    Case 2
            '        convpres = 0.0980665
            '    Case 3
            '        convpres = 1
            'End Select
            Units(1).UnitSelected = 3
            fspcol = 15
            ftpcol = 16
            'atmos = 1013.89
        End If

        'temperature units
        If OptTemperatureC.Checked = True Then
            Units(2).UnitSelected = 0
        End If
        If OptTemperatureF.Checked = True Then
            Units(2).UnitSelected = 1
        End If

        'density units
        If OptDensityKgPerM3.Checked = True Then
            If Units(3).UnitSelected = 0 Then convdens = 1.0
            If Units(3).UnitSelected = 1 Then convdens = 16.02
            'Select Case Units(3).UnitSelected
            '    Case 0
            '        convdens = 1.0
            '    Case 1
            '        convdens = 1.0 / 16.02
            'End Select
            Units(3).UnitSelected = 0
        End If
        If OptDensityLbPerFt3.Checked = True Then
            If Units(3).UnitSelected = 0 Then convdens = 1.0 / 16.02
            If Units(3).UnitSelected = 1 Then convdens = 1.0
            'Select Case Units(3).UnitSelected
            '    Case 0
            '        convdens = 16.02
            '    Case 1
            '        convdens = 1.0
            'End Select
            Units(3).UnitSelected = 1
        End If

        ''density units

        ''density units
        'Units(3).UnitName(0) = "kg/m³"
        'Units(3).UnitConversion(0) = 1.0
        'Units(3).UnitPlaces(0) = 3
        'Units(3).UnitName(1) = "lbs/ft³"
        'Units(3).UnitConversion(1) = 1.0 / 16.02
        'Units(3).UnitPlaces(1) = 4
        'Units(3).UnitDefault = 0

        'power units
        If OptPowerKW.Checked = True Then
            If Units(4).UnitSelected = 0 Then convpow = 1.0
            If Units(4).UnitSelected = 1 Then convpow = 1.34102209
            'Select Case Units(4).UnitSelected
            '    Case 0
            '        convpow = 1.0
            '    Case 1
            '        convpow = 1.34102209
            'End Select
            Units(4).UnitSelected = 0
        End If
        If OptPowerHp.Checked = True Then
            If Units(4).UnitSelected = 0 Then convpow = 1.0 / 1.34102209
            If Units(4).UnitSelected = 1 Then convpow = 1.0
            'Select Case Units(4).UnitSelected
            '    Case 0
            '        convpow = 1 / 1.34102209
            '    Case 1
            '        convpow = 1.0
            'End Select
            Units(4).UnitSelected = 1
        End If

        'length
        If OptLengthMm.Checked = True Then
            If Units(5).UnitSelected = 0 Then convlen = 1.0
            If Units(5).UnitSelected = 1 Then convlen = 25.4
            'Select Case Units(5).UnitSelected
            '    Case 0
            '        convlen = 1.0
            '    Case 1
            '        convlen = 25.4
            'End Select
            Units(5).UnitSelected = 0
        End If
        If OptLengthIn.Checked = True Then
            If Units(5).UnitSelected = 0 Then convlen = 1.0 / 25.4
            If Units(5).UnitSelected = 1 Then convlen = 1.0
            'Select Case Units(5).UnitSelected
            '    Case 0
            '        convlen = 1 / 25.4
            '    Case 1
            '        convlen = 1.0
            'End Select
            Units(5).UnitSelected = 1
        End If

        'altitude
        If OptAltitudeM.Checked = True Then
            If Units(6).UnitSelected = 0 Then convalt = 1.0
            If Units(6).UnitSelected = 1 Then convalt = 3.2808399
            'Select Case Units(6).UnitSelected
            '    Case 0
            '        convalt = 1.0
            '    Case 1
            '        convalt = 1.0 / 3.2808399
            'End Select
            Units(6).UnitSelected = 0
        End If
        If OptAltitudeFt.Checked = True Then
            If Units(6).UnitSelected = 0 Then convalt = 1.0 / 3.2808399
            If Units(6).UnitSelected = 1 Then convalt = 1.0
            'Select Case Units(6).UnitSelected
            '    Case 0
            '        convalt = 1.0
            '    Case 1
            '        convalt = 3.2808399
            'End Select
            Units(6).UnitSelected = 1
        End If

        'velocity
        If OptVelocityMpers.Checked = True Then
            If Units(7).UnitSelected = 0 Then convvel = 1.0
            If Units(7).UnitSelected = 1 Then convvel = 196.850394
            'Select Case Units(7).UnitSelected
            '    Case 0
            '        convvel = 1.0
            '    Case 1
            '        convvel = 196.850394
            'End Select
            Units(7).UnitSelected = 0
        End If
        If OptVelocityFtpermin.Checked = True Then
            If Units(7).UnitSelected = 0 Then convvel = 1.0 / 196.850394
            If Units(7).UnitSelected = 1 Then convvel = 1.0
            'Select Case Units(7).UnitSelected
            '    Case 0
            '        convvel = 1 / 196.850394
            '    Case 1
            '        convvel = 1.0
            'End Select
            Units(7).UnitSelected = 1
        End If

        'If OptLengthIn.Checked = True Then
        '    Units(5).UnitSelected = 0
        '    Units(6).UnitSelected = 0
        'End If
        'If OptLengthMm.Checked = True Then
        '    Units(5).UnitSelected = 1
        '    Units(6).UnitSelected = 1
        'End If

        Frmselectfan.LblFlowRateUnits.Text = Units(0).UnitName(Units(0).UnitSelected)
        Frmselectfan.GrpDesignPressure.Text = "Design Pressure (" + Units(1).UnitName(Units(1).UnitSelected) + ")"
        Frmselectfan.LblAtmosphericPressureUnits.Text = Units(1).UnitName(Units(1).UnitSelected)
        Frmselectfan.GrpInletTemperature.Text = "Inlet Temperature (" + Units(2).UnitName(Units(2).UnitSelected) + ")"
        Frmselectfan.LblAmbientTemperatureUnits.Text = Units(2).UnitName(Units(2).UnitSelected)
        Frmselectfan.GrpInletDensity.Text = "Inlet Density (" + Units(3).UnitName(Units(3).UnitSelected) + ")"
        Frmselectfan.LblLengthUnits.Text = Units(5).UnitName(Units(5).UnitSelected)
        Frmselectfan.LblAltitudeUnits.Text = Units(6).UnitName(Units(6).UnitSelected)

        If Units(0).UnitSelected < 4 Then
            Frmselectfan.OptVolumeFlow.Checked = True
        Else
            Frmselectfan.OptMassFlow.Checked = True
        End If
        'Frmselectfan.TxtAtmosphericPressure.Text = atmos
        '        colfte = 20
        '        colfse = 19

        '----setting the number of decimal places-------------------------------------------
        If FlowType = 3 Then
            voldecplaces = 3
        Else
            voldecplaces = 0
        End If
        If FlowType = 2 Then
            voldecplaces = 2
        End If
        If Val(Frmselectfan.Txtflow.Text) * convflow > 10000 Then
            voldecplaces = 0
        ElseIf Val(Frmselectfan.Txtflow.Text) * convflow > 1000 Then
            voldecplaces = 1
        ElseIf Val(Frmselectfan.Txtflow.Text) * convflow > 100 Then
            voldecplaces = 2
        ElseIf Val(Frmselectfan.Txtflow.Text) * convflow > 10 Then
            voldecplaces = 3
        End If

        pressplaceAtmos = 2
        If Val(Frmselectfan.TxtAtmosphericPressure.Text) * convpres > 10000 Then
            pressplaceAtmos = 0
        ElseIf Val(Frmselectfan.TxtAtmosphericPressure.Text) * convpres > 1000 Then
            pressplaceAtmos = 1
        ElseIf Val(Frmselectfan.TxtAtmosphericPressure.Text) * convpres > 100 Then
            pressplaceAtmos = 2
        ElseIf Val(Frmselectfan.TxtAtmosphericPressure.Text) * convpres > 10 Then
            pressplaceAtmos = 3
        End If

        pressplaceIn = 2
        If Val(Frmselectfan.TxtInletPressure.Text) * convpres > 10000 Then
            pressplaceIn = 0
        ElseIf Val(Frmselectfan.TxtInletPressure.Text) * convpres > 1000 Then
            pressplaceIn = 1
        ElseIf Val(Frmselectfan.TxtInletPressure.Text) * convpres > 100 Then
            pressplaceIn = 2
        ElseIf Val(Frmselectfan.TxtInletPressure.Text) * convpres > 10 Then
            pressplaceIn = 3
        End If

        pressplaceOut = 2
        If Val(Frmselectfan.TxtDischargePressure.Text) * convpres > 10000 Then
            pressplaceOut = 0
        ElseIf Val(Frmselectfan.TxtDischargePressure.Text) * convpres > 1000 Then
            pressplaceOut = 1
        ElseIf Val(Frmselectfan.TxtDischargePressure.Text) * convpres > 100 Then
            pressplaceOut = 2
        ElseIf Val(Frmselectfan.TxtDischargePressure.Text) * convpres > 10 Then
            pressplaceOut = 3
        End If

        pressplaceRise = 2
        If Val(Frmselectfan.Txtfsp.Text) * convpres > 10000 Then
            pressplaceRise = 0
        ElseIf Val(Frmselectfan.Txtfsp.Text) * convpres > 1000 Then
            pressplaceRise = 1
        ElseIf Val(Frmselectfan.Txtfsp.Text) * convpres > 100 Then
            pressplaceRise = 2
        ElseIf Val(Frmselectfan.Txtfsp.Text) * convpres > 10 Then
            pressplaceRise = 3
        End If

        Frmselectfan.Txtflow.Text = Math.Round(Val(Frmselectfan.Txtflow.Text) * convflow, voldecplaces).ToString
        Frmselectfan.TxtAtmosphericPressure.Text = Math.Round(Val(Frmselectfan.TxtAtmosphericPressure.Text) * convpres, pressplaceAtmos).ToString
        Frmselectfan.TxtInletPressure.Text = Math.Round(Val(Frmselectfan.TxtInletPressure.Text) * convpres, pressplaceIn).ToString
        Frmselectfan.TxtDischargePressure.Text = Math.Round(Val(Frmselectfan.TxtDischargePressure.Text) * convpres, pressplaceOut).ToString
        Frmselectfan.Txtfsp.Text = Math.Round(Val(Frmselectfan.Txtfsp.Text) * convpres, pressplaceRise).ToString
        Frmselectfan.Txtdens.Text = Math.Round(Val(Frmselectfan.Txtdens.Text) * convdens, 3).ToString
        Frmselectfan.Txtfansize.Text = Math.Round(Val(Frmselectfan.Txtfansize.Text) * convlen, 3).ToString
        Frmselectfan.TxtAltitude.Text = Math.Round(Val(Frmselectfan.TxtAltitude.Text) * convalt, 0).ToString

        Me.Close()

        Catch ex As Exception
            MsgBox("click")
        End Try
    End Sub

    Private Sub RadioButton16_CheckedChanged(sender As Object, e As EventArgs) Handles OptDefaultMetric.CheckedChanged
        Try
            OptFlowM3PerHr.Checked = True
            OptPressurePa.Checked = True
        OptTemperatureC.Checked = True
        OptDensityKgPerM3.Checked = True
        OptPowerKW.Checked = True
        OptLengthMm.Checked = True
        OptAltitudeM.Checked = True
        OptVelocityMpers.Checked = True
        OptVelocityFtpermin.Checked = False

        Catch ex As Exception
            MsgBox("checkedchanged")
        End Try
    End Sub

    Private Sub RadioButton17_CheckedChanged(sender As Object, e As EventArgs) Handles OptDefaultImperial.CheckedChanged
        Try
            OptFlowCfm.Checked = True
            OptPressureinWG.Checked = True
        OptTemperatureF.Checked = True
        OptDensityLbPerFt3.Checked = True
        OptPowerHp.Checked = True
        OptLengthIn.Checked = True
        OptAltitudeFt.Checked = True
        OptVelocityFtpermin.Checked = True

        Catch ex As Exception
            MsgBox("checkedchanged2")
        End Try
    End Sub
End Class