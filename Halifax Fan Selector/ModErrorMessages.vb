Module ModErrorMessages
    Sub ErrorMessage(ex As Exception, ErrNo As Integer)
        Try
            Dim company As String = "Halifax Fan Limited - "
            Dim ErrMsg As String
            ErrMsg = " Error HF0x000" + Hex(ErrNo).ToString + vbCrLf + ex.Message + vbCrLf + vbCrLf + "Please contact Halifax Fan Limited quoting the above error message." '"" '= "Error Number HF0x000" + Hex(1004).ToString
            If StartArg.ToLower.Contains("-dev") Then ErrMsg = " Error HF000" + ErrNo.ToString + vbCrLf + ex.Message + vbCrLf + vbCrLf + "Please contact Halifax Fan Limited quoting the above error message." '"" '= "Error Number HF0x000" + Hex(1004).ToString
            Select Case ErrNo
'Sub errors 1000 to 1999
                Case 1000 To 1099 'okay
                    ErrMsg = company + "Sub_General" + ErrMsg ' done
                Case 1100 To 1199 'okay
                    ErrMsg = company + "Sub_Duty" + ErrMsg ' done
                Case 1200 To 1299 'okay
                    ErrMsg = company + "Sub_FanParameters" + ErrMsg ' done
                Case 1300 To 1399 'okay
                    ErrMsg = company + "Sub_Selections" + ErrMsg ' done
                Case 1400 To 1499 'okay
                    ErrMsg = company + "Sub_Acoustics" + ErrMsg ' done
                Case 1500 To 1599 'okay
                    ErrMsg = company + "Sub_ProjectFile" + ErrMsg ' done
                Case 1600 To 1699 'okay
                    ErrMsg = company + "Sub_Impeller" + ErrMsg ' no code yet
'Module errors 5000 to 9999
                Case 5000 To 5099 'okay
                    ErrMsg = company + "ModDensity" + ErrMsg ' done
                Case 5100 To 5199 'okay
                    ErrMsg = company + "ModErrorMessages" + ErrMsg ' done
                Case 5200 To 5299 'okay
                    ErrMsg = company + "ModGetFanSize" + ErrMsg ' done
                Case 5300 To 5399 'okay
                    ErrMsg = company + "ModGetFileData" + ErrMsg ' done
                Case 5400 To 5499 'okay
                    ErrMsg = company + "ModLoadData" + ErrMsg ' done
                Case 5500 To 5599 'okay
                    ErrMsg = company + "ModMisc" + ErrMsg ' done
                Case 5600 To 5699
                    ErrMsg = company + "ModNoiseMainFunctions" + ErrMsg ' done
                Case 5700 To 5799 'okay
                    ErrMsg = company + "ModPressVol" + ErrMsg ' done
                Case 5800 To 5899
                    ErrMsg = company + "ModScaleData" + ErrMsg ' done
                Case 5900 To 5999 'okay
                    ErrMsg = company + "ModSelectCalcs" + ErrMsg ' done
                Case 6000 To 6099 'okay
                    ErrMsg = company + "ModSizeAtFixedSpeed" + ErrMsg ' done
                Case 6100 To 6199 'okay
                    ErrMsg = company + "ModSuction" + ErrMsg ' done
                Case 6200 To 6299 'okay
                    ErrMsg = company + "ModUnits" + ErrMsg ' done
                Case 6300 To 6399 'okay
                    ErrMsg = company + "ModUserDetails" + ErrMsg ' done
'Form errors 20000 to 29999
                Case 20000 To 20099
                    ErrMsg = company + "FrmDensityCalcs" + ErrMsg ' done
                Case 20100 To 20199
                    ErrMsg = company + "FrmFanChart" + ErrMsg ' done
                Case 20200 To 20299
                    ErrMsg = company + "FrmProjectDetails" + ErrMsg ' done
                Case 20300 To 20399
                    ErrMsg = company + "FrmSelectFan" + ErrMsg ' done
                Case 20400 To 20499
                    ErrMsg = company + "FrmSettings" + ErrMsg ' done
                Case 20500 To 20599
                    ErrMsg = company + "FrmStart" + ErrMsg ' done
                Case 20600 To 20699
                    ErrMsg = company + "FrmDisplayRejects" + ErrMsg ' done
            End Select
            MsgBox(ErrMsg, vbOKOnly + vbSystemModal + vbCritical, "Error Message")
        Catch ex1 As Exception
            ErrorMessage(ex1, 5101)
        End Try
    End Sub
End Module
