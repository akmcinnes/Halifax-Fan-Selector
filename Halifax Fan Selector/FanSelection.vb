Module FanSelection
    Private Sub Cmdselect_Click()
        If errorcheck1() = 1 Then
            Exit Sub
        End If



        'recording the original density as it may be changed during suction calculations
        '        originaldensity = Val(Frmselectfan.Txtdens.Value)
        originaldensity = Val(Frmselectfan.TxtInletDensity)
        '-this is to ensure that a loop only runs once if a fan size falls into secondary data
        runonce = "no" '- once the secondary data is found it returns "yes"

        Erase fsp '--erasing previous data from calcualtions that may have been run before
        Erase datapointI

        '        temppressurE = Val(Frmselectfan.Txtfsp)
        temppressurE = Val(Frmselectfan.TxtPressureRise)

        '---suction correction for specified duty
        '        If Val(Frmselectfan.Txtfanspeed.Value) <> 0 And Val(Frmselectfan.Txtfsp.Value) <> 0 Then
        If Val(Frmselectfan.Txtfanspeed.Value) <> 0 And Val(Frmselectfan.TxtPressureRise) <> 0 Then
            If Optsucy.Value = True Then
                Val(Frmselectfan.TxtInletDensity) = Inletdensity(Val(Frmselectfan.TxtPressureRise), Frmselectfan.TxtInletDensity)
                correctedforSUCTIONS(1) = "yes"
                correctedforSUCTIONS(2) = "yes"
                correctedforSUCTIONS(3) = "yes"
                correctedforSUCTIONS(4) = "yes"
                correctedforSUCTIONS(5) = "yes"
            End If
        End If
        '---------------------------------------------------------------------------------

        '-filling out the labels on the selections form

        FRMselections.Lblsizeunits.Caption = Frmselectfan.Comimpunits.Value
        FRMselections.LBLdensUNITS.Caption = Frmselectfan.Comairdenunits.Value
        FRMselections.LBLFsPUNITS.Caption = Frmselectfan.Comfspunits.Value
        FRMselections.lblftpunits.Caption = Frmselectfan.Comfspunits.Value
        FRMselections.LBLVUNITS.Caption = Frmselectfan.Comflowunits.Value
        FRMselections.LBLPOWUNITS.Caption = Frmselectfan.Compowunits.Value
        FRMselections.LBLMOTOR.Caption = Frmselectfan.Compowunits.Value
        FRMselections.Txtdensity.Value = Round(originaldensity, 3)
        If FlowType = 4 Then
            FRMselections.Lblov.Caption = "ft/min"
        Else
            FRMselections.Lblov.Caption = "m/s"
        End If
        If Optsucy.Value = True Then
            FRMselections.Lblsuction.Caption = "On Suction -Ve Pressure"
        End If
        '----setting the number of decimal places-------------------------------------------
        If FlowType = 3 Then
            voldecplaces = 3
        Else
            voldecplaces = 0
        End If
        If FlowType = 2 Then
            voldecplaces = 2
        End If
        If Val(Frmselectfan.Txtflow.Value) > 10000 Then
            voldecplaces = 0
        ElseIf Val(Frmselectfan.Txtflow.Value) > 1000 Then
            voldecplaces = 1
        ElseIf Val(Frmselectfan.Txtflow.Value) > 100 Then
            voldecplaces = 2
        ElseIf Val(Frmselectfan.Txtflow.Value) > 10 Then
            voldecplaces = 3
        End If

        pressplace = 2
        If Val(Frmselectfan.Txtfsp.Value) > 10000 Then
            pressplace = 0
        ElseIf Val(Frmselectfan.Txtfsp.Value) > 1000 Then
            pressplace = 1
        ElseIf Val(Frmselectfan.Txtfsp.Value) > 100 Then
            pressplace = 2
        ElseIf Val(Frmselectfan.Txtfsp.Value) > 10 Then
            pressplace = 3
        End If

        If cmbPressType.Value = "Fan Total" Then
            PType = 1
            frmcurveoptions.Optfsp.Caption = "FTP Only"
        Else
            PType = 0
            frmcurveoptions.Optfsp.Caption = "FSP Only"
        End If

        '-----------------------------------------------------------------------------
        '----- FOR KNOWN DUTY BUT NO SPEED OR FAN SIZE GIVEN -------------------------
        '------------------------------------------------------------------------------
        If Val(Frmselectfan.Txtfansize.Value) = 0 And Val(Frmselectfan.Txtfanspeed.Value) = 0 And Val(Frmselectfan.Txtflow.Value) <> 0 And Val(Frmselectfan.Txtfsp.Value) <> 0 Then
            Call loaddata1(fantypefilename(1))
            Call scaledensity(1, getscalefactor)

            '-----repeating if the fansize falls into the secondary data range
            If Getfansize1 >= fansizelimit(1) And Val(fansizelimit(1)) <> 0 Then
                Call loaddata1(fantypesecfilename(1))
                Call scaledensity(1, getscalefactor)
            End If
            If Getfansize1 = 0 Then
                MsgBox("The duty is outside the selected fantype duty range")
            Else
                Call getfanspeed1(Getfansize1)
            End If
            '-----end of checking for secondary range
        End If
        '-----2nd fan type

        If Val(Frmselectfan.Txtfansize2.Value) = 0 And Val(Frmselectfan.Txtfanspeed.Value) = 0 And Val(Frmselectfan.Txtflow.Value) <> 0 And Val(Frmselectfan.Txtfsp.Value) <> 0 Then
            If Frmselectfan.Comfantype2.Visible = True Then

                Call loaddata2(fantypefilename(2))
                Call scaledensity(2, getscalefactor)
                '-----repeating if the fansize falls into the secondary data range
                If Getfansize2 >= fansizelimit(2) And Val(fansizelimit(2)) <> 0 Then
                    Call loaddata2(fantypesecfilename(2))
                    Call scaledensity(2, getscalefactor)
                End If
                If Getfansize2 = 0 Then
                    MsgBox("The duty is outside the selected fantype duty range")
                Else
                    Call getfanspeed2(Getfansize2)
                End If
            End If
            '-----end of checking for secondary range
        End If
        '------3rd fan type
        If Val(Frmselectfan.txtfansize3.Value) = 0 And Val(Frmselectfan.Txtfanspeed.Value) = 0 And Val(Frmselectfan.Txtflow.Value) <> 0 And Val(Frmselectfan.Txtfsp.Value) <> 0 Then
            If Frmselectfan.Comfantype3.Visible = True Then
                Call loaddata3(fantypefilename(3))
                Call scaledensity(3, getscalefactor)
                '-----repeating if the fansize falls into the secondary data range
                If Getfansize3 >= fansizelimit(3) And Val(fansizelimit(3)) <> 0 Then
                    Call loaddata3(fantypesecfilename(3))
                    Call scaledensity(3, getscalefactor)
                End If
                If Getfansize3 = 0 Then
                    MsgBox("The duty is outside the selected fantype duty range")
                Else
                    Call getfanspeed3(Getfansize3)
                End If
                '-----end of checking for secondary range
            End If
        End If
        '------------------------------------4th fan type
        If Val(Frmselectfan.txtfansize4.Value) = 0 And Val(Frmselectfan.Txtfanspeed.Value) = 0 And Val(Frmselectfan.Txtflow.Value) <> 0 And Val(Frmselectfan.Txtfsp.Value) <> 0 Then
            If Frmselectfan.Comfantype4.Visible = True Then
                Call loaddata4(fantypefilename(4))
                Call scaledensity(4, getscalefactor)
                '-----repeating if the fansize falls into the secondary data range
                If Getfansize4 >= fansizelimit(4) And Val(fansizelimit(4)) <> 0 Then
                    Call loaddata4(fantypesecfilename(4))
                    Call scaledensity(4, getscalefactor)
                End If
                If Getfansize4 = 0 Then
                    MsgBox("The duty is outside the selected fantype duty range")
                Else
                    Call getfanspeed4(Getfansize4)
                End If
                '-----end of checking for secondary range
            End If
        End If
        '----------------------5th fan type
        If Val(Frmselectfan.txtfansize5.Value) = 0 And Val(Frmselectfan.Txtfanspeed.Value) = 0 And Val(Frmselectfan.Txtflow.Value) <> 0 And Val(Frmselectfan.Txtfsp.Value) <> 0 Then
            If Frmselectfan.Comfantype5.Visible = True Then
                Call loaddata5(fantypefilename(5))
                Call scaledensity(5, getscalefactor)
                '-----repeating if the fansize falls into the secondary data range
                If Getfansize5 >= fansizelimit(5) And Val(fansizelimit(5)) <> 0 Then
                    Call loaddata5(fantypesecfilename(5))
                    Call scaledensity(5, getscalefactor)
                End If
                If Getfansize5 = 0 Then
                    MsgBox("The duty is outside the selected fantype duty range")
                Else
                    Call getfanspeed5(Getfansize5)
                End If
                '-----end of checking for secondary range
            End If
        End If
        '----------------------------------------------------------------------------------------
        '---------------start of selecting fan size based on a given speed and duty point--------
        '-----------------------------------------------------------------------------------------
        If Val(Frmselectfan.Txtfanspeed.Value) <> 0 And Val(Frmselectfan.Txtflow.Value) <> 0 And Val(Frmselectfan.Txtfsp.Value) <> 0 And Val(Frmselectfan.Txtfansize.Value) = 0 Then

            Call loaddata1(fantypefilename(1))
            '---running the suction correction to get the new density at the inlet
            Call scaledensity(1, getscalefactor)
            runonce = "no"
            Call Getsizeatfixedspeed1
        End If
        '----2nd fan type
        If Val(Frmselectfan.Txtfanspeed.Value) <> 0 And Val(Frmselectfan.Txtflow.Value) <> 0 And Val(Frmselectfan.Txtfsp.Value) <> 0 And Val(Frmselectfan.Txtfansize2.Value) = 0 Then
            If Frmselectfan.Comfantype2.Visible = True Then
                Call loaddata2(fantypefilename(2))
                Call scaledensity(2, getscalefactor)
                runonce = "no"
                Call Getsizeatfixedspeed2
            End If
        End If
        '----3rd fantype
        If Val(Frmselectfan.Txtfanspeed.Value) <> 0 And Val(Frmselectfan.Txtflow.Value) <> 0 And Val(Frmselectfan.Txtfsp.Value) <> 0 And Val(Frmselectfan.txtfansize3.Value) = 0 Then
            If Frmselectfan.Comfantype3.Visible = True Then
                Call loaddata3(fantypefilename(3))
                Call scaledensity(3, getscalefactor)
                runonce = "no"
                Call Getsizeatfixedspeed3
            End If
        End If
        '-----4th fantype
        If Val(Frmselectfan.Txtfanspeed.Value) <> 0 And Val(Frmselectfan.Txtflow.Value) <> 0 And Val(Frmselectfan.Txtfsp.Value) <> 0 And Val(Frmselectfan.txtfansize4.Value) = 0 Then
            If Frmselectfan.Comfantype4.Visible = True Then
                Call loaddata4(fantypefilename(4))
                Call scaledensity(4, getscalefactor)
                runonce = "no"
                Call Getsizeatfixedspeed4
            End If
        End If
        '----------5th fantype
        If Val(Frmselectfan.Txtfanspeed.Value) <> 0 And Val(Frmselectfan.Txtflow.Value) <> 0 And Val(Frmselectfan.Txtfsp.Value) <> 0 And Val(Frmselectfan.txtfansize5.Value) = 0 Then
            If Frmselectfan.Comfantype5.Visible = True Then
                Call loaddata5(fantypefilename(5))
                Call scaledensity(5, getscalefactor)
                runonce = "no"
                Call Getsizeatfixedspeed5
            End If
        End If
        '----------------------------------------------------------------------------------------
        '-----------------------Start of listing duty of known fan size and speed
        '---------------------------------------------------------------------------------------------
        If Val(Frmselectfan.Txtfansize.Value) <> 0 And Val(Frmselectfan.Txtfanspeed.Value) <> 0 And Val(Frmselectfan.Txtflow.Value) = 0 And Val(Frmselectfan.Txtfsp.Value) = 0 Then
            If Val(Frmselectfan.Txtfansize.Value) >= fansizelimit(1) And fansizelimit(1) <> 0 Then
                Call loaddata1(fantypesecfilename(1))
            Else
                Call loaddata1(fantypefilename(1))
            End If
            Call scaledensity(1, getscalefactor)
            Call scalesizespeed1(Frmselectfan.Txtfansize.Value, Frmselectfan.Txtfanspeed.Value)
        End If
        '-----------type 2
        If Val(Frmselectfan.Txtfansize2.Value) <> 0 And Val(Frmselectfan.Txtfanspeed.Value) <> 0 And Val(Frmselectfan.Txtflow.Value) = 0 And Val(Frmselectfan.Txtfsp.Value) = 0 Then

            If Frmselectfan.Comfantype2.Visible = True Then
                If Val(Frmselectfan.Txtfansize2.Value) >= fansizelimit(2) And fansizelimit(2) <> 0 Then
                    Call loaddata2(fantypesecfilename(2))
                Else
                    Call loaddata2(fantypefilename(2))
                End If
                Call scaledensity(2, getscalefactor)
                If Val(Frmselectfan.Txtfansize2.Value) <> 0 Then
                    Call scalesizespeed2(Frmselectfan.Txtfansize2.Value, Frmselectfan.Txtfanspeed.Value)
                Else
                    Call scalesizespeed2(Frmselectfan.Txtfansize2.Value, Frmselectfan.Txtfanspeed.Value)
                End If
            End If
        End If
        '-----------type 3
        If Val(Frmselectfan.txtfansize3.Value) <> 0 And Val(Frmselectfan.Txtfanspeed.Value) <> 0 And Val(Frmselectfan.Txtflow.Value) = 0 And Val(Frmselectfan.Txtfsp.Value) = 0 Then
            If Frmselectfan.Comfantype3.Visible = True Then
                If Val(Frmselectfan.txtfansize3.Value) >= fansizelimit(3) And fansizelimit(3) <> 0 Then
                    Call loaddata3(fantypesecfilename(3))
                Else
                    Call loaddata3(fantypefilename(3))
                End If
                Call scaledensity(3, getscalefactor)
                If Val(Frmselectfan.txtfansize3.Value) <> 0 Then
                    Call scalesizespeed3(Frmselectfan.txtfansize3.Value, Frmselectfan.Txtfanspeed.Value)
                Else
                    Call scalesizespeed3(Frmselectfan.txtfansize3.Value, Frmselectfan.Txtfanspeed.Value)
                End If
            End If
        End If
        '-----------type 4
        If Val(Frmselectfan.txtfansize4.Value) <> 0 And Val(Frmselectfan.Txtfanspeed.Value) <> 0 And Val(Frmselectfan.Txtflow.Value) = 0 And Val(Frmselectfan.Txtfsp.Value) = 0 Then

            If Frmselectfan.Comfantype4.Visible = True Then
                If Val(Frmselectfan.txtfansize4.Value) >= fansizelimit(4) And fansizelimit(4) <> 0 Then
                    Call loaddata4(fantypesecfilename(4))
                Else
                    Call loaddata4(fantypefilename(4))
                End If
                Call scaledensity(4, getscalefactor)
                If Val(Frmselectfan.txtfansize4.Value) <> 0 Then
                    Call scalesizespeed4(Frmselectfan.txtfansize4.Value, Frmselectfan.Txtfanspeed.Value)
                Else
                    Call scalesizespeed4(Frmselectfan.txtfansize4.Value, Frmselectfan.Txtfanspeed.Value)
                End If
            End If
        End If
        '----------type 5
        If Val(Frmselectfan.txtfansize5.Value) <> 0 And Val(Frmselectfan.Txtfanspeed.Value) <> 0 And Val(Frmselectfan.Txtflow.Value) = 0 And Val(Frmselectfan.Txtfsp.Value) = 0 Then
            If Frmselectfan.Comfantype5.Visible = True Then
                If Val(Frmselectfan.txtfansize5.Value) >= fansizelimit(5) And fansizelimit(5) <> 0 Then
                    Call loaddata5(fantypesecfilename(5))
                Else
                    Call loaddata5(fantypefilename(5))
                End If
                Call scaledensity(5, getscalefactor)
                If Val(Frmselectfan.txtfansize5.Value) <> 0 Then
                    Call scalesizespeed5(Frmselectfan.txtfansize5.Value, Frmselectfan.Txtfanspeed.Value)
                Else
                    Call scalesizespeed5(Frmselectfan.txtfansize5.Value, Frmselectfan.Txtfanspeed.Value)
                End If
            End If
        End If
        '-----------------------------------------------------------------------------------------------
        '-----------------------------start of selecting fan with size and volume & pressure------------
        '-----------------------------------------------------------------------------------------------
        If Val(Frmselectfan.Txtfansize.Value) <> 0 And Val(Frmselectfan.Txtflow.Value) <> 0 And Val(Frmselectfan.Txtfsp.Value) <> 0 And Val(Frmselectfan.Txtfanspeed.Value) = 0 Then
            If Val(Frmselectfan.Txtfansize.Value) >= fansizelimit(1) And fansizelimit(1) <> 0 Then
                Call loaddata1(fantypesecfilename(1))
            Else
                Call loaddata1(fantypefilename(1))
            End If
            Call scaledensity(1, getscalefactor)
            Call getfanspeed1(Val(Frmselectfan.Txtfansize.Value))
        End If
        '------------type 2
        If Val(Frmselectfan.Txtfansize2.Value) <> 0 And Val(Frmselectfan.Txtflow.Value) <> 0 And Val(Frmselectfan.Txtfsp.Value) <> 0 And Val(Frmselectfan.Txtfanspeed.Value) = 0 Then
            If Frmselectfan.Comfantype2.Visible = True Then
                If (Val(Frmselectfan.Txtfansize2.Value) >= fansizelimit(2) Or Val(Frmselectfan.Txtfansize2.Value) >= fansizelimit(2)) And fansizelimit(2) <> 0 Then
                    Call loaddata2(fantypesecfilename(2))
                Else
                    Call loaddata2(fantypefilename(2))
                End If
                Call scaledensity(2, getscalefactor)
                Call getfanspeed2(Val(Frmselectfan.Txtfansize2.Value))
            End If
        End If
        '-------------type 3
        If Val(Frmselectfan.txtfansize3.Value) <> 0 And Val(Frmselectfan.Txtflow.Value) <> 0 And Val(Frmselectfan.Txtfsp.Value) <> 0 And Val(Frmselectfan.Txtfanspeed.Value) = 0 Then
            If Frmselectfan.Comfantype3.Visible = True Then
                If (Val(Frmselectfan.txtfansize3.Value) >= fansizelimit(3) Or Val(Frmselectfan.txtfansize3.Value) >= fansizelimit(3)) And fansizelimit(3) <> 0 Then
                    Call loaddata3(fantypesecfilename(3))
                Else
                    Call loaddata3(fantypefilename(3))
                End If
                Call scaledensity(3, getscalefactor)
                Call getfanspeed3(Val(Frmselectfan.txtfansize3.Value))
            End If
        End If
        '-----------type 4
        If Val(Frmselectfan.txtfansize4.Value) <> 0 And Val(Frmselectfan.Txtflow.Value) <> 0 And Val(Frmselectfan.Txtfsp.Value) <> 0 And Val(Frmselectfan.Txtfanspeed.Value) = 0 Then
            If Frmselectfan.Comfantype4.Visible = True Then
                If (Val(Frmselectfan.txtfansize4.Value) >= fansizelimit(4) Or Val(Frmselectfan.txtfansize4.Value) >= fansizelimit(4)) And fansizelimit(4) <> 0 Then
                    Call loaddata4(fantypesecfilename(4))
                Else
                    Call loaddata4(fantypefilename(4))
                End If
                Call scaledensity(4, getscalefactor)
                Call getfanspeed4(Val(Frmselectfan.txtfansize4.Value))
            End If
        End If
        '-----------type 5
        If Val(Frmselectfan.txtfansize5.Value) <> 0 And Val(Frmselectfan.Txtflow.Value) <> 0 And Val(Frmselectfan.Txtfsp.Value) <> 0 And Val(Frmselectfan.Txtfanspeed.Value) = 0 Then
            If Frmselectfan.Comfantype5.Visible = True Then
                If (Val(Frmselectfan.txtfansize5.Value) >= fansizelimit(5) Or Val(Frmselectfan.txtfansize5.Value) >= fansizelimit(5)) And fansizelimit(5) <> 0 Then
                    Call loaddata5(fantypesecfilename(5))
                Else
                    Call loaddata5(fantypefilename(5))
                End If
                Call scaledensity(5, getscalefactor)
                Call getfanspeed5(Val(Frmselectfan.txtfansize5.Value))
            End If
        End If
        '-------------------------------------------------------------------------------------------------
        '-------------------------start of finding pressure for selected fan speed size and volume--------
        '-------------------------------------------------------------------------------------------------
        If Val(Frmselectfan.Txtfansize.Value) <> 0 And Val(Frmselectfan.Txtflow.Value) <> 0 And Val(Frmselectfan.Txtfanspeed.Value) <> 0 Then
            If Val(Frmselectfan.Txtfansize.Value) >= fansizelimit(1) And fansizelimit(1) <> 0 Then
                Call loaddata1(fantypesecfilename(1))
            Else
                Call loaddata1(fantypefilename(1))
            End If
            If Val(Frmselectfan.Txtfsp.Value) <> 0 Then
                Frmselectfan.Txtdens.Value = originaldensity
                MsgBox("Fan Type 1: " & fanclass(1) & ", A new value for Pressure has been calculated!", vbInformation)
            End If
            Call scaledensity(1, getscalefactor)
            Call getpressure1(Val(Frmselectfan.Txtfansize.Value), Val(Frmselectfan.Txtfanspeed.Value), Val(Frmselectfan.Txtflow.Value))
        End If
        '------------------------------------type2
        If Val(Frmselectfan.Txtfansize2.Value) <> 0 And Val(Frmselectfan.Txtflow.Value) <> 0 And Val(Frmselectfan.Txtfanspeed.Value) <> 0 Then
            If Frmselectfan.Comfantype2.Visible = True Then
                If Val(Frmselectfan.Txtfansize2.Value) >= fansizelimit(2) And fansizelimit(2) <> 0 Then
                    Call loaddata2(fantypesecfilename(2))
                Else
                    Call loaddata2(fantypefilename(2))
                End If
                If Val(Frmselectfan.Txtfsp.Value) <> 0 Then
                    Frmselectfan.Txtdens.Value = originaldensity
                    MsgBox("Fan Type 2: " & fanclass(2) & ", A new value for Pressure has been calculated!", vbInformation)
                End If
                Call scaledensity(2, getscalefactor)
                Call getpressure2(Val(Frmselectfan.Txtfansize2.Value), Val(Frmselectfan.Txtfanspeed.Value), Val(Frmselectfan.Txtflow.Value))
            End If
        End If
        '----------------------------------type 3
        If Val(Frmselectfan.txtfansize3.Value) <> 0 And Val(Frmselectfan.Txtflow.Value) <> 0 And Val(Frmselectfan.Txtfanspeed.Value) <> 0 Then
            If Frmselectfan.Comfantype3.Visible = True Then
                If Val(Frmselectfan.txtfansize3.Value) >= fansizelimit(3) And fansizelimit(3) <> 0 Then
                    Call loaddata3(fantypesecfilename(3))
                Else
                    Call loaddata3(fantypefilename(3))
                End If
                If Val(Frmselectfan.Txtfsp.Value) <> 0 Then
                    Frmselectfan.Txtdens.Value = originaldensity
                    MsgBox("Fan Type 3: " & fanclass(3) & ", A new value for Pressure has been calculated!", vbInformation)
                End If
                Call scaledensity(3, getscalefactor)
                Call getpressure3(Val(Frmselectfan.txtfansize3.Value), Val(Frmselectfan.Txtfanspeed.Value), Val(Frmselectfan.Txtflow.Value))
            End If
        End If
        '-----------------------------------type 4
        If Val(Frmselectfan.txtfansize4.Value) <> 0 And Val(Frmselectfan.Txtflow.Value) <> 0 And Val(Frmselectfan.Txtfanspeed.Value) <> 0 Then
            If Frmselectfan.Comfantype4.Visible = True Then
                If Val(Frmselectfan.txtfansize4.Value) >= fansizelimit(4) And fansizelimit(4) <> 0 Then
                    Call loaddata4(fantypesecfilename(4))
                Else
                    Call loaddata4(fantypefilename(4))
                End If
                If Val(Frmselectfan.Txtfsp.Value) <> 0 Then
                    Frmselectfan.Txtdens.Value = originaldensity
                    MsgBox("Fan Type 4: " & fanclass(4) & ", A new value for Pressure has been calculated!", vbInformation)
                End If
                Call scaledensity(4, getscalefactor)
                Call getpressure4(Val(Frmselectfan.txtfansize4.Value), Val(Frmselectfan.Txtfanspeed.Value), Val(Frmselectfan.Txtflow.Value))
            End If
        End If
        '---------------------------------------type 5
        If Val(Frmselectfan.txtfansize5.Value) <> 0 And Val(Frmselectfan.Txtflow.Value) <> 0 And Val(Frmselectfan.Txtfanspeed.Value) <> 0 Then
            If Frmselectfan.Comfantype5.Visible = True Then
                If Val(Frmselectfan.txtfansize5.Value) >= fansizelimit(5) And fansizelimit(5) <> 0 Then
                    Call loaddata5(fantypesecfilename(5))
                Else
                    Call loaddata5(fantypefilename(5))
                End If
                If Val(Frmselectfan.Txtfsp.Value) <> 0 Then
                    Frmselectfan.Txtdens.Value = originaldensity
                    MsgBox("Fan Type 5: " & fanclass(5) & ", A new value for Pressure has been caculated!", vbInformation)
                End If
                Call scaledensity(5, getscalefactor)
                Call getpressure5(Val(Frmselectfan.txtfansize5.Value), Val(Frmselectfan.Txtfanspeed.Value), Val(Frmselectfan.Txtflow.Value))
            End If
        End If
        '--------------------------------------------------------------------------------------
        '-----------------------start of finding volume for given pressure and fan speed------
        '-------------------------------------------------------------------------------------
        If Val(Frmselectfan.Txtfansize.Value) <> 0 And Val(Frmselectfan.Txtflow.Value) = 0 And Val(Frmselectfan.Txtfsp.Value) <> 0 And Val(Frmselectfan.Txtfanspeed.Value) <> 0 Then
            If Val(Frmselectfan.Txtfansize.Value) >= fansizelimit(1) And fansizelimit(1) <> 0 Then
                Call loaddata1(fantypesecfilename(1))
            Else
                Call loaddata1(fantypefilename(1))
            End If
            Call scaledensity(1, getscalefactor)
            Call getvol1(Val(Frmselectfan.Txtfansize.Value), Val(Frmselectfan.Txtfanspeed.Value), Val(Frmselectfan.Txtfsp.Value))
        End If
        '--------------type 2
        If Val(Frmselectfan.Txtfansize2.Value) <> 0 And Val(Frmselectfan.Txtflow.Value) = 0 And Val(Frmselectfan.Txtfsp.Value) <> 0 And Val(Frmselectfan.Txtfanspeed.Value) <> 0 Then
            If Frmselectfan.Comfantype2.Visible = True Then
                If Val(Frmselectfan.Txtfansize2.Value) >= fansizelimit(2) And fansizelimit(2) <> 0 Then
                    Call loaddata2(fantypesecfilename(2))
                Else
                    Call loaddata2(fantypefilename(2))
                End If
                Call scaledensity(2, getscalefactor)
                Call getvol2(Val(Frmselectfan.Txtfansize2.Value), Val(Frmselectfan.Txtfanspeed.Value), Val(Frmselectfan.Txtfsp.Value))
            End If
        End If
        '---------------type 3
        If Val(Frmselectfan.txtfansize3.Value) <> 0 And Val(Frmselectfan.Txtflow.Value) = 0 And Val(Frmselectfan.Txtfsp.Value) <> 0 And Val(Frmselectfan.Txtfanspeed.Value) <> 0 Then
            If Frmselectfan.Comfantype3.Visible = True Then
                If Val(Frmselectfan.txtfansize3.Value) >= fansizelimit(3) And fansizelimit(3) <> 0 Then
                    Call loaddata3(fantypesecfilename(3))
                Else
                    Call loaddata3(fantypefilename(3))
                End If
                Call scaledensity(3, getscalefactor)
                Call getvol3(Val(Frmselectfan.txtfansize3.Value), Val(Frmselectfan.Txtfanspeed.Value), Val(Frmselectfan.Txtfsp.Value))
            End If
        End If
        '---------------type 4
        If Val(Frmselectfan.txtfansize4.Value) <> 0 And Val(Frmselectfan.Txtflow.Value) = 0 And Val(Frmselectfan.Txtfsp.Value) <> 0 And Val(Frmselectfan.Txtfanspeed.Value) <> 0 Then
            If Frmselectfan.Comfantype4.Visible = True Then
                If Val(Frmselectfan.txtfansize4.Value) >= fansizelimit(4) And fansizelimit(4) <> 0 Then
                    Call loaddata4(fantypesecfilename(4))
                Else
                    Call loaddata4(fantypefilename(4))
                End If
                Call scaledensity(4, getscalefactor)
                Call getvol4(Val(Frmselectfan.txtfansize4.Value), Val(Frmselectfan.Txtfanspeed.Value), Val(Frmselectfan.Txtfsp.Value))
            End If
        End If
        '---------------type 5
        If Val(Frmselectfan.txtfansize5.Value) <> 0 And Val(Frmselectfan.Txtflow.Value) = 0 And Val(Frmselectfan.Txtfsp.Value) <> 0 And Val(Frmselectfan.Txtfanspeed.Value) <> 0 Then
            If Frmselectfan.Comfantype5.Visible = True Then
                If Val(Frmselectfan.txtfansize5.Value) >= fansizelimit(5) And fansizelimit(5) <> 0 Then
                    Call loaddata5(fantypesecfilename(5))
                Else
                    Call loaddata5(fantypefilename(5))
                End If
                Call scaledensity(5, getscalefactor)
                Call getvol5(Val(Frmselectfan.txtfansize5.Value), Val(Frmselectfan.Txtfanspeed.Value), Val(Frmselectfan.Txtfsp.Value))
            End If
        End If
        '--------------------------------------------------------------------------
        '--- showing the motor size
        FRMselections.Txtmtr1.Value = getmotorsize(Val(FRMselections.txtpow1.Value))
        If Frmselectfan.Comfantype2.Visible Then
            FRMselections.Txtmtr2.Value = getmotorsize(Val(FRMselections.txtpow2.Value))
        End If
        If Frmselectfan.Comfantype3.Visible Then
            FRMselections.Txtmtr3.Value = getmotorsize(Val(FRMselections.txtpow3.Value))
        End If
        If Frmselectfan.Comfantype4.Visible Then
            FRMselections.Txtmtr4.Value = getmotorsize(Val(FRMselections.txtpow4.Value))
        End If
        If Frmselectfan.Comfantype5.Visible Then
            FRMselections.Txtmtr5.Value = getmotorsize(Val(FRMselections.txtpow5.Value))
        End If
        '---suction correction for specified duty
        If Optsucy.Value = True Then
            If Val(Frmselectfan.Txtfsp.Value) <> 0 And correctedforSUCTIONS(1) = "yes" Then '----resetting density data
                Call scaledensity(1, 1 / (Val(Frmselectfan.Txtdens.Value) / originaldensity))
                correctedforSUCTIONS(1) = "no"
            End If
            If Val(Frmselectfan.Txtfsp.Value) <> 0 And correctedforSUCTIONS(2) = "yes" Then '----resetting density data
                Call scaledensity(2, 1 / (Val(Frmselectfan.Txtdens.Value) / originaldensity))
                correctedforSUCTIONS(2) = "no"
            End If
            If Val(Frmselectfan.Txtfsp.Value) <> 0 And correctedforSUCTIONS(3) = "yes" Then '----resetting density data
                Call scaledensity(3, 1 / (Val(Frmselectfan.Txtdens.Value) / originaldensity))
                correctedforSUCTIONS(3) = "no"
            End If
            If Val(Frmselectfan.Txtfsp.Value) <> 0 And correctedforSUCTIONS(4) = "yes" Then '----resetting density data
                Call scaledensity(4, 1 / (Val(Frmselectfan.Txtdens.Value) / originaldensity))
                correctedforSUCTIONS(4) = "no"
            End If
            If Val(Frmselectfan.Txtfsp.Value) <> 0 And correctedforSUCTIONS(5) = "yes" Then '----resetting density data
                Call scaledensity(5, 1 / (Val(Frmselectfan.Txtdens.Value) / originaldensity))
                correctedforSUCTIONS(5) = "no"
            End If
        End If
        If Widthratios(1) <> 1 Then
            fantitles(1) = FRMselections.txtfansize1 & " / " & Frmselectfan.TxtPBwidth1 & " " & fantypename(1) & " Fan"
        Else
            fantitles(1) = FRMselections.txtfansize1 & " " & fantypename(1) & " Fan"
        End If
        If Widthratios(2) <> 1 Then
            fantitles(2) = FRMselections.Txtfansize2 & " / " & Frmselectfan.TxtPBwidth2 & " " & fantypename(2) & " Fan"
        Else
            fantitles(2) = FRMselections.Txtfansize2 & " " & fantypename(2) & " Fan"
        End If
        If Widthratios(3) <> 1 Then
            fantitles(3) = FRMselections.txtfansize3 & " / " & Frmselectfan.TxtPBwidth3 & " " & fantypename(3) & " Fan"
        Else
            fantitles(3) = FRMselections.txtfansize3 & " " & fantypename(3) & " Fan"
        End If
        If Widthratios(4) <> 1 Then
            fantitles(4) = FRMselections.txtfansize4 & " / " & Frmselectfan.TxtPBwidth4 & " " & fantypename(4) & " Fan"
        Else
            fantitles(4) = FRMselections.txtfansize4 & " " & fantypename(4) & " Fan"
        End If
        If Widthratios(5) <> 1 Then
            fantitles(5) = FRMselections.txtfansize5 & " / " & Frmselectfan.TxtPBwidth5 & " " & fantypename(5) & " Fan"
        Else
            fantitles(5) = FRMselections.txtfansize5 & " " & fantypename(5) & " Fan"
        End If
        '--showing the selections if any of the values are not = to 0
        If Val(FRMselections.txtfansize1.Value) <> 0 Or Val(FRMselections.Txtfansize2.Value) <> 0 Or Val(FRMselections.txtfansize3.Value) <> 0 Or Val(FRMselections.txtfansize4.Value) <> 0 Or Val(FRMselections.txtfansize5.Value) <> 0 Then
            Call frmselectionsformat
            Frmselectfan.Hide
            If FRMselections.txtfansize1.Visible Then
                '-scales for size
                fspmax = scalePFSize(fsp(1, FanMaxCount(1)), datafansize(1), FRMselections.txtfansize1.Value)
                ftpmax = scalePFSize(ftp(1, FanMaxCount(1)), datafansize(1), FRMselections.txtfansize1.Value)
                volmax = scaleVFSize(vol(1, FanMaxCount(1)), datafansize(1), FRMselections.txtfansize1.Value)
                '-scales for speed
                volmax = scaleVFSpeed(volmax, datafanspeed(1), FRMselections.txtspeed1.Value)
                fspmax = scalePFSpeed(fspmax, datafanspeed(1), FRMselections.txtspeed1.Value)
                ftpmax = scalePFSpeed(ftpmax, datafanspeed(1), FRMselections.txtspeed1.Value)
                FRMselections.txtVolTD1.Text = Round((1 - volmax / FRMselections.txtvol1.Value) * 100, 1)
                If FRMselections.txtVolTD1.Value < 0 Then
                    FRMselections.txtVolTD1.Text = "Stall"
                    FRMselections.txtVolTD1.BackColor = &HFFFF&
                    FRMselections.txtVolTD1.ForeColor = &HFF&
                Else
                    FRMselections.txtVolTD1.BackColor = &H80000005
                    FRMselections.txtVolTD1.ForeColor = &H80000012
                End If
                If PType = 1 Then
                    FRMselections.txtRH1.Text = Round((1 - FRMselections.txtftp1.Value / ftpmax) * 100, 1)
                Else
                    FRMselections.txtRH1.Text = Round((1 - FRMselections.txtfsp1.Value / fspmax) * 100, 1)
                End If
                If FRMselections.txtRH1.Value < 5 Then
                    FRMselections.txtRH1.BackColor = &HFFFF&
                    FRMselections.txtRH1.ForeColor = &HFF&
                Else
                    FRMselections.txtRH1.BackColor = &H80000005
                    FRMselections.txtRH1.ForeColor = &H80000012
                End If

                FRMselections.txtpow1.BackColor = &H80FF80
                PowMin = Val(FRMselections.txtpow1.Value)

            End If

            If FRMselections.Txtfansize2.Visible Then
                '-scales for size
                fspmax = scalePFSize(fsp(2, FanMaxCount(2)), datafansize(2), FRMselections.Txtfansize2.Value)
                ftpmax = scalePFSize(ftp(2, FanMaxCount(2)), datafansize(2), FRMselections.Txtfansize2.Value)
                volmax = scaleVFSize(vol(2, FanMaxCount(2)), datafansize(2), FRMselections.Txtfansize2.Value)
                '-scales for speed
                volmax = scaleVFSpeed(volmax, datafanspeed(2), FRMselections.txtspeed2.Value)
                fspmax = scalePFSpeed(fspmax, datafanspeed(2), FRMselections.txtspeed2.Value)
                ftpmax = scalePFSpeed(ftpmax, datafanspeed(2), FRMselections.txtspeed2.Value)
                FRMselections.txtVolTD2.Text = Round((1 - volmax / FRMselections.txtvol2.Value) * 100, 1)
                If FRMselections.txtVolTD2.Value < 0 Then
                    FRMselections.txtVolTD2.Text = "Stall"
                    FRMselections.txtVolTD2.BackColor = &HFFFF&
                    FRMselections.txtVolTD2.ForeColor = &HFF&
                Else
                    FRMselections.txtVolTD2.BackColor = &H80000005
                    FRMselections.txtVolTD2.ForeColor = &H80000012
                End If
                If PType = 1 Then
                    FRMselections.txtRH2.Text = Round((1 - FRMselections.txtftp2.Value / ftpmax) * 100, 1)
                Else
                    FRMselections.txtRH2.Text = Round((1 - FRMselections.txtfsp2.Value / fspmax) * 100, 1)
                End If
                If FRMselections.txtRH2.Value < 5 Then
                    FRMselections.txtRH2.BackColor = &HFFFF&
                    FRMselections.txtRH2.ForeColor = &HFF&
                Else
                    FRMselections.txtRH2.BackColor = &H80000005
                    FRMselections.txtRH2.ForeColor = &H80000012
                End If

                If Val(FRMselections.txtpow2.Value) < PowMin Then
                    PowMin = Val(FRMselections.txtpow2.Value)
                    FRMselections.txtpow1.BackColor = &H80000005
                    FRMselections.txtpow2.BackColor = &H80FF80
                End If

            End If

            If FRMselections.txtfansize3.Visible Then
                '-scales for size
                fspmax = scalePFSize(fsp(3, FanMaxCount(3)), datafansize(3), FRMselections.txtfansize3.Value)
                ftpmax = scalePFSize(ftp(3, FanMaxCount(3)), datafansize(3), FRMselections.txtfansize3.Value)
                volmax = scaleVFSize(vol(3, FanMaxCount(3)), datafansize(3), FRMselections.txtfansize3.Value)
                '-scales for speed
                volmax = scaleVFSpeed(volmax, datafanspeed(3), FRMselections.txtspeed3.Value)
                fspmax = scalePFSpeed(fspmax, datafanspeed(3), FRMselections.txtspeed3.Value)
                ftpmax = scalePFSpeed(ftpmax, datafanspeed(3), FRMselections.txtspeed3.Value)
                FRMselections.txtVolTD3.Text = Round((1 - volmax / FRMselections.txtvol3.Value) * 100, 1)
                If FRMselections.txtVolTD3.Value < 0 Then
                    FRMselections.txtVolTD3.Text = "Stall"
                    FRMselections.txtVolTD3.BackColor = &HFFFF&
                    FRMselections.txtVolTD3.ForeColor = &HFF&
                Else
                    FRMselections.txtVolTD3.BackColor = &H80000005
                    FRMselections.txtVolTD3.ForeColor = &H80000012
                End If
                If PType = 1 Then
                    FRMselections.txtRH3.Text = Round((1 - FRMselections.txtftp3.Value / ftpmax) * 100, 1)
                Else
                    FRMselections.txtRH3.Text = Round((1 - FRMselections.txtfsp3.Value / fspmax) * 100, 1)
                End If
                If FRMselections.txtRH3.Value < 5 Then
                    FRMselections.txtRH3.BackColor = &HFFFF&
                    FRMselections.txtRH3.ForeColor = &HFF&
                Else
                    FRMselections.txtRH3.BackColor = &H80000005
                    FRMselections.txtRH3.ForeColor = &H80000012
                End If

                If Val(FRMselections.txtpow3.Value) < PowMin Then
                    PowMin = Val(FRMselections.txtpow3.Value)
                    FRMselections.txtpow1.BackColor = &H80000005
                    FRMselections.txtpow2.BackColor = &H80000005
                    FRMselections.txtpow3.BackColor = &H80FF80
                End If

            End If

            If FRMselections.txtfansize4.Visible Then
                '-scales for size
                fspmax = scalePFSize(fsp(4, FanMaxCount(4)), datafansize(4), FRMselections.txtfansize4.Value)
                ftpmax = scalePFSize(ftp(4, FanMaxCount(4)), datafansize(4), FRMselections.txtfansize4.Value)
                volmax = scaleVFSize(vol(4, FanMaxCount(4)), datafansize(4), FRMselections.txtfansize4.Value)
                '-scales for speed
                volmax = scaleVFSpeed(volmax, datafanspeed(4), FRMselections.txtspeed4.Value)
                fspmax = scalePFSpeed(fspmax, datafanspeed(4), FRMselections.txtspeed4.Value)
                ftpmax = scalePFSpeed(ftpmax, datafanspeed(4), FRMselections.txtspeed4.Value)
                FRMselections.txtVolTD4.Text = Round((1 - volmax / FRMselections.txtvol4.Value) * 100, 1)
                If FRMselections.txtVolTD4.Value < 0 Then
                    FRMselections.txtVolTD4.Text = "Stall"
                    FRMselections.txtVolTD4.BackColor = &HFFFF&
                    FRMselections.txtVolTD4.ForeColor = &HFF&
                Else
                    FRMselections.txtVolTD4.BackColor = &H80000005
                    FRMselections.txtVolTD4.ForeColor = &H80000012
                End If
                If PType = 1 Then
                    FRMselections.txtRH4.Text = Round((1 - FRMselections.txtftp4.Value / ftpmax) * 100, 1)
                Else
                    FRMselections.txtRH4.Text = Round((1 - FRMselections.txtfsp4.Value / fspmax) * 100, 1)
                End If
                If FRMselections.txtRH4.Value < 5 Then
                    FRMselections.txtRH4.BackColor = &HFFFF&
                    FRMselections.txtRH4.ForeColor = &HFF&
                Else
                    FRMselections.txtRH4.BackColor = &H80000005
                    FRMselections.txtRH4.ForeColor = &H80000012
                End If

                If Val(FRMselections.txtpow4.Value) < PowMin Then
                    PowMin = Val(FRMselections.txtpow4.Value)
                    FRMselections.txtpow1.BackColor = &H80000005
                    FRMselections.txtpow2.BackColor = &H80000005
                    FRMselections.txtpow3.BackColor = &H80000005
                    FRMselections.txtpow4.BackColor = &H80FF80
                End If

            End If

            If FRMselections.txtfansize5.Visible Then
                '-scales for size
                fspmax = scalePFSize(fsp(5, FanMaxCount(5)), datafansize(5), FRMselections.txtfansize5.Value)
                ftpmax = scalePFSize(ftp(5, FanMaxCount(5)), datafansize(5), FRMselections.txtfansize5.Value)
                volmax = scaleVFSize(vol(5, FanMaxCount(5)), datafansize(5), FRMselections.txtfansize5.Value)
                '-scales for speed
                volmax = scaleVFSpeed(volmax, datafanspeed(5), FRMselections.txtspeed5.Value)
                fspmax = scalePFSpeed(fspmax, datafanspeed(5), FRMselections.txtspeed5.Value)
                ftpmax = scalePFSpeed(ftpmax, datafanspeed(5), FRMselections.txtspeed5.Value)
                FRMselections.txtVolTD5.Text = Round((1 - volmax / FRMselections.txtvol5.Value) * 100, 1)
                If FRMselections.txtVolTD5.Value < 0 Then
                    FRMselections.txtVolTD5.Text = "Stall"
                    FRMselections.txtVolTD5.BackColor = &HFFFF&
                    FRMselections.txtVolTD5.ForeColor = &HFF&
                Else
                    FRMselections.txtVolTD5.BackColor = &H80000005
                    FRMselections.txtVolTD5.ForeColor = &H80000012
                End If
                If PType = 1 Then
                    FRMselections.txtRH5.Text = Round((1 - FRMselections.txtftp5.Value / ftpmax) * 100, 1)
                Else
                    FRMselections.txtRH5.Text = Round((1 - FRMselections.txtfsp5.Value / fspmax) * 100, 1)
                End If
                If FRMselections.txtRH5.Value < 5 Then
                    FRMselections.txtRH5.BackColor = &HFFFF&
                    FRMselections.txtRH5.ForeColor = &HFF&
                Else
                    FRMselections.txtRH5.BackColor = &H80000005
                    FRMselections.txtRH5.ForeColor = &H80000012
                End If

                If Val(FRMselections.txtpow5.Value) < PowMin Then
                    PowMin = Val(FRMselections.txtpow5.Value)
                    FRMselections.txtpow1.BackColor = &H80000005
                    FRMselections.txtpow2.BackColor = &H80000005
                    FRMselections.txtpow3.BackColor = &H80000005
                    FRMselections.txtpow4.BackColor = &H80000005
                    FRMselections.txtpow5.BackColor = &H80FF80
                End If

            End If

            FRMselections.Show
        Else
            MsgBox("Sorry not enough information to make a selection, I either need a duty point or fan size and speed")
        End If


    End Sub

End Module
