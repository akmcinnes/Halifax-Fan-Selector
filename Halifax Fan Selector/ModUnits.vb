Module ModUnits
    'Subroutines
    'SetUnits
    'Sets options in form from unit structure

    'SetUnitValues
    'Sets units structure and labels to values from options in form

    'SetUnitStructure
    'Sets unit name and places for each unit parameter

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
            ErrorMessage(ex, 6201)
        End Try
    End Sub

    Public Sub SetUnitValues()
        Try
            'flow units
            If Frmselectfan.OptFlowM3PerHr.Checked = True Then
                Units(0).UnitSelected = 0
            End If
            If Frmselectfan.OptFlowM3PerMin.Checked = True Then
                Units(0).UnitSelected = 1
            End If
            If Frmselectfan.OptFlowM3PerSec.Checked = True Then
                Units(0).UnitSelected = 2
            End If
            If Frmselectfan.OptFlowCfm.Checked = True Then
                Units(0).UnitSelected = 3
            End If
            If Frmselectfan.OptFlowKgPerHr.Checked = True Then
                Units(0).UnitSelected = 4
            End If
            If Frmselectfan.OptFlowLbPerHr.Checked = True Then
                Units(0).UnitSelected = 5
            End If

            'pressure units
            If Frmselectfan.OptPressurePa.Checked = True Then
                Units(1).UnitSelected = 0
            End If
            If Frmselectfan.OptPressureinWG.Checked = True Then
                Units(1).UnitSelected = 1
            End If
            If Frmselectfan.OptPressuremmWG.Checked = True Then
                Units(1).UnitSelected = 2
            End If
            If Frmselectfan.OptPressuremBar.Checked = True Then
                Units(1).UnitSelected = 3
            End If
            '#### check conversions
            If Frmselectfan.OptPressurekPa.Checked = True Then
                Units(1).UnitSelected = 4
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
                Units(3).UnitSelected = 0
            End If
            If Frmselectfan.OptDensityLbPerFt3.Checked = True Then
                Units(3).UnitSelected = 1
            End If

            'power units
            If Frmselectfan.OptPowerKW.Checked = True Then
                Units(4).UnitSelected = 0
            End If
            If Frmselectfan.OptPowerHp.Checked = True Then
                Units(4).UnitSelected = 1
            End If
            If Frmselectfan.OptPowerBoth.Checked = True Then
                Units(4).UnitSelected = 2 'calculate in kW display both units
            End If
            'length
            If Frmselectfan.OptLengthMm.Checked = True Then
                Units(5).UnitSelected = 0
                Units(8).UnitSelected = 0 'area
            End If
            If Frmselectfan.OptLengthIn.Checked = True Then
                Units(5).UnitSelected = 1
                Units(8).UnitSelected = 1 'area
            End If

            'altitude
            If Frmselectfan.OptAltitudeM.Checked = True Then
                Units(6).UnitSelected = 0
            End If
            If Frmselectfan.OptAltitudeFt.Checked = True Then
                Units(6).UnitSelected = 1
            End If

            'velocity
            If Frmselectfan.OptVelocityMpers.Checked = True Then
                Units(7).UnitSelected = 0
            End If
            If Frmselectfan.OptVelocityFtpermin.Checked = True Then
                Units(7).UnitSelected = 1
            End If

            Dim aaaa As String

            aaaa = Frmselectfan.GrpFlowRate.Text
            If aaaa.Contains("(") Then aaaa = aaaa.Remove(aaaa.IndexOf("("))
            aaaa = aaaa + " (" + Units(0).UnitName(Units(0).UnitSelected) + ")"
            Frmselectfan.GrpFlowRate.Text = aaaa


            aaaa = Frmselectfan.GrpDesignPressure.Text
            If aaaa.Contains("(") Then aaaa = aaaa.Remove(aaaa.IndexOf("("))
            aaaa = aaaa + " (" + Units(1).UnitName(Units(1).UnitSelected) + ")"
            Frmselectfan.GrpDesignPressure.Text = aaaa


            aaaa = Frmselectfan.GrpInletTemperature.Text
            If aaaa.Contains("(") Then aaaa = aaaa.Remove(aaaa.IndexOf("("))
            aaaa = aaaa + " (" + Units(2).UnitName(Units(2).UnitSelected) + ")"
            Frmselectfan.GrpInletTemperature.Text = aaaa


            aaaa = Frmselectfan.GrpInletDensity.Text
            If aaaa.Contains("(") Then aaaa = aaaa.Remove(aaaa.IndexOf("("))
            aaaa = aaaa + " (" + Units(3).UnitName(Units(3).UnitSelected) + ")"
            Frmselectfan.GrpInletDensity.Text = aaaa

            Frmselectfan.LblFlowRateUnits.Text = Units(0).UnitName(Units(0).UnitSelected)
            Frmselectfan.LblAtmosphericPressureUnits.Text = Units(1).UnitName(Units(1).UnitSelected)
            Frmselectfan.LblAmbientTemperatureUnits.Text = Units(2).UnitName(Units(2).UnitSelected)
            Frmselectfan.LblLengthUnits.Text = Units(5).UnitName(Units(5).UnitSelected)
            Frmselectfan.LblAltitudeUnits.Text = Units(6).UnitName(Units(6).UnitSelected)
            Frmselectfan.lblAcousticFlowUnits.Text = Units(0).UnitName(Units(0).UnitSelected)
            Frmselectfan.lblAcousticFSPUnits.Text = Units(1).UnitName(Units(1).UnitSelected)
            Frmselectfan.lblAcousticFTPUnits.Text = Units(1).UnitName(Units(1).UnitSelected)

            If Units(0).UnitSelected < 4 Then
                Frmselectfan.lblFlowType.Text = Frmselectfan.lblVolumeFlow.Text
            Else
                Frmselectfan.lblFlowType.Text = Frmselectfan.lblMassFlow.Text
            End If

            '----setting the number of decimal places-------------------------------------------
            'If FlowType = 3 Then
            If Units(0).UnitSelected = 2 Then
                voldecplaces = 3
            ElseIf Units(0).UnitSelected = 1 Then
                voldecplaces = 2
            Else
                voldecplaces = 0
            End If

            If flowrate > 10000 Then
                voldecplaces = 0
            ElseIf flowrate > 1000 Then
                voldecplaces = 1
            ElseIf flowrate > 100 Then
                voldecplaces = 2
            ElseIf flowrate > 10 Then
                voldecplaces = 3
            End If

            pressplaceAtmos = 2
            If Val(Frmselectfan.TxtAtmosphericPressure.Text) > 10000 Then
                pressplaceAtmos = 0
            ElseIf Val(Frmselectfan.TxtAtmosphericPressure.Text) > 1000 Then
                pressplaceAtmos = 1
            ElseIf Val(Frmselectfan.TxtAtmosphericPressure.Text) > 100 Then
                pressplaceAtmos = 2
            ElseIf Val(Frmselectfan.TxtAtmosphericPressure.Text) > 10 Then
                pressplaceAtmos = 3
            End If

            pressplaceIn = 2
            If inletpress > 10000 Then
                pressplaceIn = 0
            ElseIf inletpress > 1000 Then
                pressplaceIn = 1
            ElseIf inletpress > 100 Then
                pressplaceIn = 2
            ElseIf inletpress > 10 Then
                pressplaceIn = 3
            End If

            pressplaceOut = 2
            If dischpress > 10000 Then
                pressplaceOut = 0
            ElseIf dischpress > 1000 Then
                pressplaceOut = 1
            ElseIf dischpress > 100 Then
                pressplaceOut = 2
            ElseIf dischpress > 10 Then
                pressplaceOut = 3
            End If

            pressplaceRise = 2
            If pressrise > 10000 Then
                pressplaceRise = 0
            ElseIf pressrise > 1000 Then
                pressplaceRise = 1
            ElseIf pressrise > 100 Then
                pressplaceRise = 2
            ElseIf pressrise > 10 Then
                pressplaceRise = 3
            End If

            Frmselectfan.Txtflow.Text = Math.Round(Val(Frmselectfan.Txtflow.Text), voldecplaces).ToString
            Frmselectfan.TxtAtmosphericPressure.Text = Math.Round(Val(Frmselectfan.TxtAtmosphericPressure.Text), pressplaceAtmos).ToString
            Frmselectfan.TxtInletPressure.Text = Math.Round(Val(Frmselectfan.TxtInletPressure.Text), pressplaceIn).ToString
            Frmselectfan.TxtDischargePressure.Text = Math.Round(Val(Frmselectfan.TxtDischargePressure.Text), pressplaceOut).ToString
            Frmselectfan.Txtfsp.Text = Math.Round(Val(Frmselectfan.Txtfsp.Text), pressplaceRise).ToString
            Frmselectfan.Txtdens.Text = Math.Round(Val(Frmselectfan.Txtdens.Text), 3).ToString
            Frmselectfan.Txtfansize.Text = Math.Round(Val(Frmselectfan.Txtfansize.Text) * convlen, 3).ToString
            atmospress = CDbl(Frmselectfan.TxtAtmosphericPressure.Text)
        Catch ex As Exception
            ErrorMessage(ex, 6202)
        End Try
    End Sub

    Public Sub SetUnitStructure()
        Try
            'flow units 
            Units(0).UnitName(0) = "m³/hr"
            Units(0).UnitPlaces(0) = 0
            Frmselectfan.OptFlowM3PerHr.Text = Units(0).UnitName(0)

            Units(0).UnitName(1) = "m³/min"
            Units(0).UnitPlaces(1) = 1
            Frmselectfan.OptFlowM3PerMin.Text = Units(0).UnitName(1)

            Units(0).UnitName(2) = "m³/sec"
            Units(0).UnitPlaces(2) = 2
            Frmselectfan.OptFlowM3PerSec.Text = Units(0).UnitName(2)

            Units(0).UnitName(3) = "cfm"
            Units(0).UnitPlaces(3) = 0
            Frmselectfan.OptFlowCfm.Text = Units(0).UnitName(3)

            Units(0).UnitName(4) = "kg/hr"
            Units(0).UnitPlaces(4) = 0
            Frmselectfan.OptFlowKgPerHr.Text = Units(0).UnitName(4)

            Units(0).UnitName(5) = "lb/hr"
            Units(0).UnitPlaces(5) = 0
            Frmselectfan.OptFlowLbPerHr.Text = Units(0).UnitName(5)

            Units(0).UnitDefault = 0

            'pressure units 
            Units(1).UnitName(0) = "Pa"
            Units(1).UnitPlaces(0) = 0
            Frmselectfan.OptPressurePa.Text = Units(1).UnitName(0)

            Units(1).UnitName(1) = "InsWG"
            Units(1).UnitPlaces(1) = 1
            Frmselectfan.OptPressureinWG.Text = Units(1).UnitName(1)

            Units(1).UnitName(2) = "mmWG"
            Units(1).UnitPlaces(2) = 0
            Frmselectfan.OptPressuremmWG.Text = Units(1).UnitName(2)

            Units(1).UnitName(3) = "mBar"
            Units(1).UnitPlaces(3) = 2
            Frmselectfan.OptPressuremBar.Text = Units(1).UnitName(3)

            Units(1).UnitName(4) = "kPa"
            Units(1).UnitPlaces(4) = 2
            Frmselectfan.OptPressurekPa.Text = Units(1).UnitName(4)

            Units(1).UnitDefault = 0

            'temperature units
            Units(2).UnitName(0) = "°C"
            Units(2).UnitPlaces(0) = 1
            Frmselectfan.OptTemperatureC.Text = Units(2).UnitName(0)

            Units(2).UnitName(1) = "°F"
            Units(2).UnitPlaces(1) = 1
            Frmselectfan.OptTemperatureF.Text = Units(2).UnitName(1)

            Units(2).UnitDefault = 0

            'density units
            Units(3).UnitName(0) = "kg/m³"
            Units(3).UnitPlaces(0) = 3
            Frmselectfan.OptDensityKgPerM3.Text = Units(3).UnitName(0)

            Units(3).UnitName(1) = "lbs/ft³"
            Units(3).UnitPlaces(1) = 4
            Frmselectfan.OptDensityLbPerFt3.Text = Units(3).UnitName(1)

            Units(3).UnitDefault = 0

            'power units
            Units(4).UnitName(0) = "kW"
            Frmselectfan.OptPowerKW.Text = Units(4).UnitName(0)

            Units(4).UnitName(1) = "HP"
            Frmselectfan.OptPowerHp.Text = Units(4).UnitName(1)

            Units(4).UnitName(2) = "kW"
            Frmselectfan.OptPowerBoth.Text = "Display Both"

            Units(4).UnitDefault = 0

            'length units
            Units(5).UnitName(0) = "mm"
            Frmselectfan.OptLengthMm.Text = Units(5).UnitName(0)

            Units(5).UnitName(1) = "ins"
            Frmselectfan.OptLengthIn.Text = Units(5).UnitName(1)

            Units(5).UnitDefault = 0

            'altitude units
            Units(6).UnitName(0) = "m"
            Frmselectfan.OptAltitudeM.Text = Units(6).UnitName(0)

            Units(6).UnitName(1) = "ft"
            Frmselectfan.OptAltitudeFt.Text = Units(6).UnitName(1)

            Units(6).UnitDefault = 0

            'velocity units
            Units(7).UnitName(0) = "m/s"
            Frmselectfan.OptVelocityMpers.Text = Units(7).UnitName(0)

            Units(7).UnitName(1) = "ft/min"
            Frmselectfan.OptVelocityFtpermin.Text = Units(7).UnitName(1)

            Units(7).UnitDefault = 0

            'area units
            Units(8).UnitName(0) = "m²"
            'Frmselectfan.OptVelocityMpers.Text = Units(7).UnitName(0)

            Units(8).UnitName(1) = "ft²"
            'Frmselectfan.OptVelocityFtpermin.Text = Units(7).UnitName(1)

            Units(8).UnitDefault = 0

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
