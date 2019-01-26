Module ModErrorMessages
    Sub ErrorMessage(ex As Exception, ErrNo As Integer)
        Try
            Dim company As String = "Halifax Fan Limited - "
            Dim ErrMsg As String
            ErrMsg = " Error HF0x000" + Hex(ErrNo).ToString + vbCrLf + ex.Message + vbCrLf + vbCrLf + "Please contact Halifax Fan Limited quoting the above error message." '"" '= "Error Number HF0x000" + Hex(1004).ToString
            If StartArg.ToLower.Contains("-dev") Then ErrMsg = " Error HF000" + ErrNo.ToString + vbCrLf + ex.Message + vbCrLf + vbCrLf + "Please contact Halifax Fan Limited quoting the above error message." '"" '= "Error Number HF0x000" + Hex(1004).ToString
            Select Case ErrNo
'Sub errors 1000 to 1999
                Case 1000 To 1099 'General Information Input
                    ErrMsg = company + "Sub_General" + ErrMsg
                Case 1100 To 1199 'okay
                    ErrMsg = company + "Sub_Duty" + ErrMsg
                Case 1200 To 1299 'okay
                    ErrMsg = company + "Sub_FanParameters" + ErrMsg
                Case 1300 To 1399 'okay
                    ErrMsg = company + "Sub_Selections" + ErrMsg
                Case 1400 To 1499 'okay
                    ErrMsg = company + "Sub_Acoustics" + ErrMsg
                Case 1500 To 1599 'okay
                    ErrMsg = company + "Sub_ProjectFile" + ErrMsg
                Case 1600 To 1699 'okay
                    ErrMsg = company + "Sub_Impeller" + ErrMsg
'Module errors 5000 to 9999
                Case 5000 To 5099 'okay
                    ErrMsg = company + "ModDensity" + ErrMsg
                Case 5100 To 5199 'okay
                    ErrMsg = company + "ModErrorMessages" + ErrMsg
                Case 5200 To 5299 'okay
                    ErrMsg = company + "ModGetFanSize" + ErrMsg
                Case 5300 To 5399 'okay
                    ErrMsg = company + "ModGetFileData" + ErrMsg
                Case 5400 To 5499 'okay
                    ErrMsg = company + "ModLoadData" + ErrMsg
                Case 5500 To 5599 'okay
                    ErrMsg = company + "ModMisc" + ErrMsg
                Case 5600 To 5699
                    ErrMsg = company + "ModNoiseMainFunctions" + ErrMsg
                Case 5700 To 5799 'okay
                    ErrMsg = company + "ModPressVol" + ErrMsg
                Case 5800 To 5899
                    ErrMsg = company + "ModScaleData" + ErrMsg
                Case 5900 To 5999 'okay
                    ErrMsg = company + "ModSelectCalcs" + ErrMsg
                Case 6000 To 6099 'okay
                    ErrMsg = company + "ModSizeAtFixedSpeed" + ErrMsg
                Case 6100 To 6199 'okay
                    ErrMsg = company + "ModSuction" + ErrMsg
                Case 6200 To 6299 'okay
                    ErrMsg = company + "ModUnits" + ErrMsg
                Case 6300 To 6399 'okay
                    ErrMsg = company + "ModUserDetails" + ErrMsg
'Form errors 20000 to 29999
                Case 20000 To 20099
                    ErrMsg = company + "FrmDensityCalcs" + ErrMsg
                Case 20100 To 20199
                    ErrMsg = company + "FrmFanChart" + ErrMsg
                Case 20200 To 20299
                    ErrMsg = company + "FrmProjectDetails" + ErrMsg
                Case 20300 To 20399
                    ErrMsg = company + "FrmSelectFan" + ErrMsg
                Case 20400 To 20499
                    ErrMsg = company + "FrmSettings" + ErrMsg
                Case 20500 To 20599
                    ErrMsg = company + "FrmStart" + ErrMsg
            End Select
            MsgBox(ErrMsg, vbOKOnly + vbSystemModal + vbCritical, "Error Message")
        Catch ex1 As Exception
            ErrorMessage(ex1, 5101)
        End Try
    End Sub
End Module
