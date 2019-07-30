Module ModErrorMessages
    Sub ErrorMessage(ex As Exception, ErrNo As Integer)
        'create error message to enable location of errors, if any.
        Try
            Dim company As String = "Halifax Fan Limited - "
            Dim ErrMsg As String
            ErrMsg = " Error HF0x000" + Hex(ErrNo).ToString + vbCrLf + ex.Message + vbCrLf + vbCrLf + lang_dict(PrintLanguage, 201) '"" '= "Error Number HF0x000" + Hex(1004).ToString
            Select Case ErrNo
        'Sub errors 1000 to 1999
                Case 1000 To 1099
                    ErrMsg = company + "Sub_General" + ErrMsg
                Case 1100 To 1199
                    ErrMsg = company + "Sub_Duty" + ErrMsg
                Case 1200 To 1299
                    ErrMsg = company + "Sub_FanParameters" + ErrMsg
                Case 1300 To 1399
                    ErrMsg = company + "Sub_Selections" + ErrMsg
                Case 1400 To 1499
                    ErrMsg = company + "Sub_Acoustics" + ErrMsg
                Case 1500 To 1599
                    ErrMsg = company + "Sub_ProjectFile" + ErrMsg
                Case 1600 To 1699
                    ErrMsg = company + "Sub_Impeller" + ErrMsg ' no code yet
        'Module errors 5000 to 9999
                Case 5000 To 5099
                    ErrMsg = company + "ModDensity" + ErrMsg
                Case 5100 To 5199
                    ErrMsg = company + "ModErrorMessages" + ErrMsg
                Case 5200 To 5299
                    ErrMsg = company + "ModGetFanSize" + ErrMsg
                Case 5300 To 5399
                    ErrMsg = company + "ModGetFileData" + ErrMsg
                Case 5400 To 5499
                    ErrMsg = company + "ModLoadData" + ErrMsg
                Case 5500 To 5599
                    ErrMsg = company + "ModMisc" + ErrMsg
                Case 5600 To 5699
                    ErrMsg = company + "ModNoiseMainFunctions" + ErrMsg
                Case 5700 To 5799
                    ErrMsg = company + "ModPressVol" + ErrMsg
                Case 5800 To 5899
                    ErrMsg = company + "ModScaleData" + ErrMsg
                Case 5900 To 5999
                    ErrMsg = company + "ModSelectCalcs" + ErrMsg
                Case 6000 To 6099
                    ErrMsg = company + "ModSizeAtFixedSpeed" + ErrMsg
                Case 6100 To 6199
                    ErrMsg = company + "ModSuction" + ErrMsg
                Case 6200 To 6299
                    ErrMsg = company + "ModUnits" + ErrMsg
                Case 6300 To 6399
                    ErrMsg = company + "ModUserDetails" + ErrMsg
                Case 6400 To 6499
                    ErrMsg = company + "ModPrinting" + ErrMsg
                Case 6500 To 6599
                    ErrMsg = company + "ModReadWriteXML" + ErrMsg
                Case 6600 To 6699
                    ErrMsg = company + "ModINI" + ErrMsg
                Case 6700 To 6799
                    ErrMsg = company + "ModLicencing" + ErrMsg
                Case 6800 To 6899
                    ErrMsg = company + "ModPrintCurve" + ErrMsg
                Case 6900 To 6999
                    ErrMsg = company + "ModPrintDatapoints" + ErrMsg
                Case 7000 To 7099
                    ErrMsg = company + "ModPrintPerformance" + ErrMsg
                Case 7100 To 7199
                    ErrMsg = company + "ModPrintSound" + ErrMsg
        'Form errors 20000 to 29999
                Case 20000 To 20099
                    ErrMsg = company + "FrmDensityCalcs" + ErrMsg
                Case 20100 To 20199
                    ErrMsg = company + "FrmFanChart" + ErrMsg
                Case 20200 To 20299
                    ErrMsg = company + "FrmProjectDetails" + ErrMsg
                Case 20300 To 20449
                    ErrMsg = company + "FrmSelectFan" + ErrMsg
                Case 20450 To 20499
                    ErrMsg = company + "FrmSettings" + ErrMsg
                Case 20500 To 20599
                    ErrMsg = company + "FrmStart" + ErrMsg
                Case 20600 To 20699
                    ErrMsg = company + "FrmDisplayRejects" + ErrMsg
                Case 20700 To 20799
                    ErrMsg = company + "FrmCurveOptions" + ErrMsg
                Case 20800 To 20899
                    ErrMsg = company + "FrmCurveProgress" + ErrMsg
                Case Else
                    ErrMsg = company + "FrmMiscellaneous" + ErrMsg
            End Select
            MsgBox(ErrMsg, vbOKOnly + vbSystemModal + vbCritical, "Error Message")
        Catch ex1 As Exception
            ErrorMessage(ex1, 5101)
        End Try
    End Sub
End Module
