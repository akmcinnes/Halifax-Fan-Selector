Module ModUnits
    Public Sub SetUnits()
        Try
            'Flow
            If Units(0).UnitSelected = 0 Then Frmselectfan.OptFlowM3PerHr.Checked = True
            If Units(0).UnitSelected = 1 Then Frmselectfan.OptFlowM3PerMin.Checked = True
            If Units(0).UnitSelected = 2 Then Frmselectfan.OptFlowM3PerSec.Checked = True
            If Units(0).UnitSelected = 3 Then Frmselectfan.OptFlowCfm.Checked = True
            If Units(0).UnitSelected = 4 Then Frmselectfan.OptFlowKgPerHr.Checked = True
            If Units(0).UnitSelected = 5 Then Frmselectfan.OptFlowLbPerHr.Checked = True

            'Pressure
            If Units(1).UnitSelected = 0 Then Frmselectfan.OptPressurePa.Checked = True
            If Units(1).UnitSelected = 1 Then Frmselectfan.OptPressureinWG.Checked = True
            If Units(1).UnitSelected = 2 Then Frmselectfan.OptPressuremmWG.Checked = True
            If Units(1).UnitSelected = 3 Then Frmselectfan.OptPressuremBar.Checked = True
            If Units(1).UnitSelected = 4 Then Frmselectfan.OptPressurekPa.Checked = True

            'Temperature
            If Units(2).UnitSelected = 0 Then Frmselectfan.OptTemperatureC.Checked = True
            If Units(2).UnitSelected = 1 Then Frmselectfan.OptTemperatureF.Checked = True

            'Density
            If Units(3).UnitSelected = 0 Then Frmselectfan.OptDensityKgPerM3.Checked = True
            If Units(3).UnitSelected = 1 Then Frmselectfan.OptDensityLbPerFt3.Checked = True

            'Power
            If Units(4).UnitSelected = 0 Then Frmselectfan.OptPowerKW.Checked = True
            If Units(4).UnitSelected = 1 Then Frmselectfan.OptPowerHp.Checked = True
            If Units(4).UnitSelected = 2 Then Frmselectfan.OptPowerBoth.Checked = True

            'Length
            If Units(5).UnitSelected = 0 Then Frmselectfan.OptLengthMm.Checked = True
            If Units(5).UnitSelected = 1 Then Frmselectfan.OptLengthIn.Checked = True

            'Altitude
            If Units(6).UnitSelected = 0 Then Frmselectfan.OptAltitudeM.Checked = True
            If Units(6).UnitSelected = 1 Then Frmselectfan.OptAltitudeFt.Checked = True

            'Velocity
            If Units(7).UnitSelected = 0 Then Frmselectfan.OptVelocityMpers.Checked = True
            If Units(7).UnitSelected = 1 Then Frmselectfan.OptVelocityFtpermin.Checked = True

            'Set defaults
        Catch ex As Exception
            'MsgBox("load")
            ErrorMessage(ex, 6201)
        End Try

    End Sub

    Public Sub SetUnitValues()
        Try
            'flow units
            If Frmselectfan.OptFlowM3PerHr.Checked = True Then
                If Units(0).UnitSelected = 0 Then
                    convflow = 1.0
                ElseIf Units(0).UnitSelected = 1 Then
                    convflow = 60.0
                ElseIf Units(0).UnitSelected = 2 Then
                    convflow = 3600.0
                ElseIf Units(0).UnitSelected = 3 Then
                    convflow = 1.0 / 0.58857777021102 '3600.0 * 0.00047192
                ElseIf Units(0).UnitSelected = 4 Then
                    convflow = 1.0
                End If
                Units(0).UnitSelected = 0
                colvol = 9
                'FlowType = 1
            End If
            If Frmselectfan.OptFlowM3PerMin.Checked = True Then
                If Units(0).UnitSelected = 0 Then
                    convflow = 1.0 / 60.0
                ElseIf Units(0).UnitSelected = 1 Then
                    convflow = 1.0
                ElseIf Units(0).UnitSelected = 2 Then
                    convflow = 60.0
                ElseIf Units(0).UnitSelected = 3 Then
                    convflow = 1.0 / 0.58857777021102 / 60.0
                ElseIf Units(0).UnitSelected = 4 Then
                    convflow = 1.0
                End If
                Units(0).UnitSelected = 1
                colvol = 11
                'FlowType = 2
            End If
            If Frmselectfan.OptFlowM3PerSec.Checked = True Then
                If Units(0).UnitSelected = 0 Then
                    convflow = 1.0 / 3600.0
                ElseIf Units(0).UnitSelected = 1 Then
                    convflow = 1.0 / 60.0
                ElseIf Units(0).UnitSelected = 2 Then
                    convflow = 1.0
                ElseIf Units(0).UnitSelected = 3 Then
                    convflow = 1.0 / 0.58857777021102 / 3600.0
                ElseIf Units(0).UnitSelected = 4 Then
                    convflow = 1.0
                End If
                Units(0).UnitSelected = 2
                colvol = 12
                'FlowType = 3
            End If
            If Frmselectfan.OptFlowCfm.Checked = True Then
                If Units(0).UnitSelected = 0 Then
                    convflow = 0.58857777021102 '0.00047192 / 3600.0
                ElseIf Units(0).UnitSelected = 1 Then
                    convflow = 60.0 * 0.58857777021102 '0.00047192 / 60.0
                ElseIf Units(0).UnitSelected = 2 Then
                    convflow = 3600.0 * 0.58857777021102 '0.00047192
                ElseIf Units(0).UnitSelected = 3 Then
                    convflow = 1.0
                ElseIf Units(0).UnitSelected = 4 Then
                    convflow = 1.0
                End If
                Units(0).UnitSelected = 3
                colvol = 4
                'FlowType = 4
            End If
            If Frmselectfan.OptFlowKgPerHr.Checked = True Then
                Units(0).UnitSelected = 4
            End If
            If Frmselectfan.OptFlowLbPerHr.Checked = True Then
                Units(0).UnitSelected = 5
            End If

            'pressure units
            If Frmselectfan.OptPressurePa.Checked = True Then
                If Units(1).UnitSelected = 0 Then
                    convpres = 1.0
                ElseIf Units(1).UnitSelected = 1 Then
                    convpres = 249.0891
                ElseIf Units(1).UnitSelected = 2 Then
                    convpres = 9.80665
                ElseIf Units(1).UnitSelected = 3 Then
                    convpres = 100.0
                ElseIf Units(1).UnitSelected = 4 Then
                    convpres = 1000.0 'check
                End If
                Units(1).UnitSelected = 0
                fspcol = 13
                ftpcol = 14
                'PresType = 0
                '            atmos = 101389.0
            End If
            If Frmselectfan.OptPressureinWG.Checked = True Then
                If Units(1).UnitSelected = 0 Then
                    convpres = 1.0 / 249.0891
                ElseIf Units(1).UnitSelected = 1 Then
                    convpres = 1.0
                ElseIf Units(1).UnitSelected = 2 Then
                    convpres = 1.0 / 25.4
                ElseIf Units(1).UnitSelected = 3 Then
                    convpres = 1.0 / 2.4908891
                ElseIf Units(1).UnitSelected = 4 Then
                    convpres = 10.0 / 2.4908891 'check
                End If
                Units(1).UnitSelected = 1
                fspcol = 2
                ftpcol = 5
                'PresType = 1
                'atmos = 407.45
            End If
            If Frmselectfan.OptPressuremmWG.Checked = True Then
                If Units(1).UnitSelected = 0 Then
                    convpres = 1.0 / 9.80665
                ElseIf Units(1).UnitSelected = 1 Then
                    convpres = 25.4
                ElseIf Units(1).UnitSelected = 2 Then
                    convpres = 1.0
                ElseIf Units(1).UnitSelected = 3 Then
                    convpres = 1.0 / 0.0980665
                ElseIf Units(1).UnitSelected = 4 Then
                    convpres = 10.0 / 0.0980665 'check
                End If
                Units(1).UnitSelected = 2
                fspcol = 7
                ftpcol = 10
                'PresType = 2
                'atmos = 10349.1
            End If
            If Frmselectfan.OptPressuremBar.Checked = True Then
                If Units(1).UnitSelected = 0 Then
                    convpres = 1.0 / 100.0
                ElseIf Units(1).UnitSelected = 1 Then
                    convpres = 2.4908891
                ElseIf Units(1).UnitSelected = 2 Then
                    convpres = 0.0980665
                ElseIf Units(1).UnitSelected = 3 Then
                    convpres = 1.0
                ElseIf Units(1).UnitSelected = 4 Then
                    convpres = 10.0 'check
                End If
                Units(1).UnitSelected = 3
                fspcol = 15
                ftpcol = 16
                'PresType = 3
                'atmos = 1013.89
            End If
            '#### check conversions
            If Frmselectfan.OptPressurekPa.Checked = True Then
                If Units(1).UnitSelected = 0 Then
                    convpres = 1.0 / 1000.0
                ElseIf Units(1).UnitSelected = 1 Then
                    convpres = 0.24908891
                ElseIf Units(1).UnitSelected = 2 Then
                    convpres = 0.00980665
                ElseIf Units(1).UnitSelected = 3 Then
                    convpres = 0.1
                ElseIf Units(1).UnitSelected = 4 Then
                    convpres = 1.0
                End If
                Units(1).UnitSelected = 4
                fspcol = 13
                ftpcol = 14
                'PresType = 3
                'atmos = 1013.89
            End If

            'temperature units
            If Frmselectfan.OptTemperatureC.Checked = True Then
                Units(2).UnitSelected = 0
            End If
            If Frmselectfan.OptTemperatureF.Checked = True Then
                Units(2).UnitSelected = 1
            End If

            'density units
            If Frmselectfan.OptDensityKgPerM3.Checked = True Then
                If Units(3).UnitSelected = 0 Then
                    convdens = 1.0
                ElseIf Units(3).UnitSelected = 1 Then
                    convdens = 16.02
                End If
                Units(3).UnitSelected = 0
            End If
            If Frmselectfan.OptDensityLbPerFt3.Checked = True Then
                If Units(3).UnitSelected = 0 Then
                    convdens = 1.0 / 16.02
                ElseIf Units(3).UnitSelected = 1 Then
                    convdens = 1.0
                End If
                Units(3).UnitSelected = 1
            End If

            'power units
            If Frmselectfan.OptPowerKW.Checked = True Then
                If Units(4).UnitSelected = 0 Then
                    convpow = 1.0
                ElseIf Units(4).UnitSelected = 1 Then
                    convpow = 1.34102209
                End If
                Units(4).UnitSelected = 0
            End If
            If Frmselectfan.OptPowerHp.Checked = True Then
                If Units(4).UnitSelected = 0 Then
                    convpow = 1.0 / 1.34102209
                ElseIf Units(4).UnitSelected = 1 Then
                    convpow = 1.0
                End If
                Units(4).UnitSelected = 1
            End If
            If Frmselectfan.OptPowerBoth.Checked = True Then
                If Units(4).UnitSelected = 0 Then
                    convpow = 1.0
                ElseIf Units(4).UnitSelected = 1 Then
                    convpow = 1.34102209
                End If
                Units(4).UnitSelected = 2 'calculate in kW display both units
            End If
            'length
            If Frmselectfan.OptLengthMm.Checked = True Then
                If Units(5).UnitSelected = 0 Then
                    convlen = 1.0
                ElseIf Units(5).UnitSelected = 1 Then
                    convlen = 25.4
                End If
                Units(5).UnitSelected = 0
            End If
            If Frmselectfan.OptLengthIn.Checked = True Then
                If Units(5).UnitSelected = 0 Then
                    convlen = 1.0 / 25.4
                ElseIf Units(5).UnitSelected = 1 Then
                    convlen = 1.0
                End If
                Units(5).UnitSelected = 1
            End If

            'altitude
            If Frmselectfan.OptAltitudeM.Checked = True Then
                If Units(6).UnitSelected = 0 Then
                    convalt = 1.0
                ElseIf Units(6).UnitSelected = 1 Then
                    convalt = 3.2808399
                End If
                Units(6).UnitSelected = 0
            End If
            If Frmselectfan.OptAltitudeFt.Checked = True Then
                If Units(6).UnitSelected = 0 Then
                    convalt = 1.0 / 3.2808399
                ElseIf Units(6).UnitSelected = 1 Then
                    convalt = 1.0
                End If
                Units(6).UnitSelected = 1
            End If

            'velocity
            If Frmselectfan.OptVelocityMpers.Checked = True Then
                If Units(7).UnitSelected = 0 Then
                    convvel = 1.0
                ElseIf Units(7).UnitSelected = 1 Then
                    convvel = 196.850394
                End If
                Units(7).UnitSelected = 0
                'VelType = 0
            End If
            If Frmselectfan.OptVelocityFtpermin.Checked = True Then
                If Units(7).UnitSelected = 0 Then
                    convvel = 1.0 / 196.850394
                ElseIf Units(7).UnitSelected = 1 Then
                    convvel = 1.0
                End If
                Units(7).UnitSelected = 1
                'VelType = 1
            End If

            Frmselectfan.LblFlowRateUnits.Text = Units(0).UnitName(Units(0).UnitSelected)
            Frmselectfan.GrpDesignPressure.Text = "Design Pressure (" + Units(1).UnitName(Units(1).UnitSelected) + ")"
            Frmselectfan.LblAtmosphericPressureUnits.Text = Units(1).UnitName(Units(1).UnitSelected)
            Frmselectfan.GrpInletTemperature.Text = "Inlet Temperature (" + Units(2).UnitName(Units(2).UnitSelected) + ")"
            Frmselectfan.LblAmbientTemperatureUnits.Text = Units(2).UnitName(Units(2).UnitSelected)
            Frmselectfan.GrpInletDensity.Text = "Inlet Density (" + Units(3).UnitName(Units(3).UnitSelected) + ")"
            Frmselectfan.LblLengthUnits.Text = Units(5).UnitName(Units(5).UnitSelected)
            Frmselectfan.LblAltitudeUnits.Text = Units(6).UnitName(Units(6).UnitSelected)
            Frmselectfan.lblAcousticFlowUnits.Text = Units(0).UnitName(Units(0).UnitSelected)
            Frmselectfan.lblAcousticFSPUnits.Text = Units(1).UnitName(Units(1).UnitSelected)

            If Units(0).UnitSelected < 4 Then
                Frmselectfan.OptVolumeFlow.Checked = True
            Else
                Frmselectfan.OptMassFlow.Checked = True
            End If
            'TxtAtmosphericPressure.Text = atmos
            '        colfte = 20
            '        colfse = 19

            '----setting the number of decimal places-------------------------------------------
            'If FlowType = 3 Then
            If Units(0).UnitSelected = 2 Then
                voldecplaces = 3
            Else
                voldecplaces = 0
            End If
            'If FlowType = 2 Then
            If Units(0).UnitSelected = 1 Then
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
            'flowrate = CDbl(Frmselectfan.Txtflow.Text)
            'TxtAltitude.Text = Math.Round(Val(TxtAltitude.Text) * convalt, 0).ToString

            'Me.Close()

        Catch ex As Exception
            ErrorMessage(ex, 6202)
        End Try


    End Sub

    Public Sub SetUnitStructure()
        Try
            'flow units 
            Units(0).UnitName(0) = "m³/hr"
            Units(0).UnitConversion(0) = 1.0 / 3600.0
            Units(0).UnitPlaces(0) = 0
            Frmselectfan.OptFlowM3PerHr.Text = Units(0).UnitName(0)

            Units(0).UnitName(1) = "m³/min"
            Units(0).UnitConversion(1) = 1.0 / 60.0
            Units(0).UnitPlaces(1) = 1
            Frmselectfan.OptFlowM3PerMin.Text = Units(0).UnitName(1)

            Units(0).UnitName(2) = "m³/sec"
            Units(0).UnitConversion(2) = 1.0
            Units(0).UnitPlaces(2) = 2
            Frmselectfan.OptFlowM3PerSec.Text = Units(0).UnitName(2)

            Units(0).UnitName(3) = "cfm"
            Units(0).UnitConversion(3) = 0.00047192
            Units(0).UnitPlaces(3) = 0
            Frmselectfan.OptFlowCfm.Text = Units(0).UnitName(3)

            Units(0).UnitName(4) = "kg/hr"
            Units(0).UnitPlaces(4) = 0
            Frmselectfan.OptFlowKgPerHr.Text = Units(0).UnitName(4)

            Units(0).UnitName(5) = "lb/hr"
            Units(0).UnitPlaces(5) = 0
            Frmselectfan.OptFlowLbPerHr.Text = Units(0).UnitName(5)

            Units(0).UnitDefault = 0
            'FlowType = 0
            colvol = 9

            'pressure units 
            Units(1).UnitName(0) = "Pa"
            Units(1).UnitConversion(0) = 1.0
            Units(1).UnitPlaces(0) = 0
            Frmselectfan.OptPressurePa.Text = Units(1).UnitName(0)

            Units(1).UnitName(1) = "InsWG"
            Units(1).UnitConversion(1) = 249.09
            Units(1).UnitPlaces(1) = 1
            Frmselectfan.OptPressureinWG.Text = Units(1).UnitName(1)

            Units(1).UnitName(2) = "mmWG"
            Units(1).UnitConversion(2) = 9.81
            Units(1).UnitPlaces(2) = 0
            Frmselectfan.OptPressuremmWG.Text = Units(1).UnitName(2)

            Units(1).UnitName(3) = "mBar"
            Units(1).UnitConversion(3) = 100.0
            Units(1).UnitPlaces(3) = 2
            Frmselectfan.OptPressuremBar.Text = Units(1).UnitName(3)

            Units(1).UnitName(4) = "kPa"
            Units(1).UnitConversion(4) = 1000.0
            Units(1).UnitPlaces(4) = 2
            Frmselectfan.OptPressurekPa.Text = Units(1).UnitName(4)

            Units(1).UnitDefault = 0
            fspcol = 13
            ftpcol = 14
            'atmos = 101389

            'temperature units
            Units(2).UnitName(0) = "°C"
            Units(2).UnitConversion(0) = 1.0
            Units(2).UnitPlaces(0) = 1
            Frmselectfan.OptTemperatureC.Text = Units(2).UnitName(0)

            Units(2).UnitName(1) = "°F"
            Units(2).UnitConversion(1) = 1.0
            Units(2).UnitPlaces(1) = 1
            Frmselectfan.OptTemperatureF.Text = Units(2).UnitName(1)

            Units(2).UnitDefault = 0

            'density units
            Units(3).UnitName(0) = "kg/m³"
            Units(3).UnitConversion(0) = 1.0
            Units(3).UnitPlaces(0) = 3
            Frmselectfan.OptDensityKgPerM3.Text = Units(3).UnitName(0)

            Units(3).UnitName(1) = "lbs/ft³"
            Units(3).UnitConversion(1) = 1.0 / 16.02
            Units(3).UnitPlaces(1) = 4
            Frmselectfan.OptDensityLbPerFt3.Text = Units(3).UnitName(1)

            Units(3).UnitDefault = 0

            'power units
            Units(4).UnitName(0) = "kW"
            Units(4).UnitConversion(0) = 1.0
            Frmselectfan.OptPowerKW.Text = Units(4).UnitName(0)

            Units(4).UnitName(1) = "HP"
            Units(4).UnitConversion(1) = 1.0 / 0.746
            Frmselectfan.OptPowerHp.Text = Units(4).UnitName(1)

            Units(4).UnitName(2) = "kW"
            Units(4).UnitConversion(2) = 1.0
            Frmselectfan.OptPowerBoth.Text = "Display Both"

            Units(4).UnitDefault = 0
            colpow = 8

            'length units
            Units(5).UnitName(0) = "mm"
            Units(5).UnitConversion(0) = 1.0
            Frmselectfan.OptLengthMm.Text = Units(5).UnitName(0)

            Units(5).UnitName(1) = "ins"
            Units(5).UnitConversion(1) = 1 / 25.4
            Frmselectfan.OptLengthIn.Text = Units(5).UnitName(1)

            Units(5).UnitDefault = 0

            'altitude units
            Units(6).UnitName(0) = "m"
            Units(6).UnitConversion(0) = 1.0
            Frmselectfan.OptAltitudeM.Text = Units(6).UnitName(0)

            Units(6).UnitName(1) = "ft"
            Units(6).UnitConversion(1) = 1 / 0.3048
            Frmselectfan.OptAltitudeFt.Text = Units(6).UnitName(1)

            Units(6).UnitDefault = 0

            'velocity units
            Units(7).UnitName(0) = "m/s"
            Units(7).UnitConversion(0) = 1.0
            Frmselectfan.OptVelocityMpers.Text = Units(7).UnitName(0)

            Units(7).UnitName(1) = "ft/min"
            Units(7).UnitConversion(1) = 1 / 0.3048
            Frmselectfan.OptVelocityFtpermin.Text = Units(7).UnitName(1)

            Units(7).UnitDefault = 0

            If NewProject = True Then
                For i = 0 To No_of_units
                    Units(i).UnitSelected = Units(i).UnitDefault
                Next
            End If

        Catch ex As Exception
            ErrorMessage(ex, 6203)
        End Try

    End Sub
End Module
