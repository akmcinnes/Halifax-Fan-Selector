Module ModPrintDatapoints
    Public Sub OutputDataTableHeaderPO(xlsWB)
        'sheet = "Performance"
        PlaceData(xlsWB, sheet, lang_dict(79), 17, 2, True,, True, 17, 2, 17, 3) 'flow
        PlaceData(xlsWB, sheet, Units(0).UnitName(Units(0).UnitSelected), 18, 2, True,, True, 18, 2, 18, 3)
        PlaceData(xlsWB, sheet, "FSP", 17, 4, True,, True, 17, 4, 17, 5) 'static pressure
        PlaceData(xlsWB, sheet, Units(1).UnitName(Units(1).UnitSelected), 18, 4, True,, True, 18, 4, 18, 5)
        PlaceData(xlsWB, sheet, "FTP", 17, 6, True,, True, 17, 6, 17, 7) 'total pressure
        PlaceData(xlsWB, sheet, Units(1).UnitName(Units(1).UnitSelected), 18, 6, True,, True, 18, 6, 18, 7)
        PlaceData(xlsWB, sheet, lang_dict(80), 17, 8, True,, True, 17, 8, 17, 9) 'fan power
        PlaceData(xlsWB, sheet, Units(4).UnitName(Units(4).UnitSelected), 18, 8, True,, True, 18, 8, 18, 9)
        PlaceData(xlsWB, sheet, "FSE", 17, 10, True,, True, 17, 10, 17, 11) 'static efficiency
        PlaceData(xlsWB, sheet, "%", 18, 10, True,, True, 18, 10, 18, 11)
        PlaceData(xlsWB, sheet, "FTE", 17, 12, True,, True, 17, 12, 17, 13) 'total efficiency
        PlaceData(xlsWB, sheet, "%", 18, 12, True,, True, 18, 12, 18, 13)
        PlaceData(xlsWB, sheet, lang_dict(81), 17, 14, True,, True, 17, 14, 17, 15) 'outlet velocity
        PlaceData(xlsWB, sheet, Units(7).UnitName(Units(7).UnitSelected), 18, 14, True,, True, 18, 14, 18, 15)
    End Sub

    Public Sub OutputDataTablePO(xlsWB)
        ConvertData()
        Dim i As Integer
        xlsWB.ActiveSheet.Name = sheet
        For i = 1 To Num_Readings
            SetPlaces(plotvol(i - 1), plotfsp(i - 1), plotpow(i - 1))
            PlaceData(xlsWB, sheet, Math.Round(plotvol(i - 1), voldecplaces), 18 + i, 2,,, True, 18 + i, 2, 18 + i, 3) 'performance data header
            PlaceData(xlsWB, sheet, Math.Round(plotfsp(i - 1), pressplaceRise), 18 + i, 4,,, True, 18 + i, 4, 18 + i, 5) 'performance data header
            PlaceData(xlsWB, sheet, Math.Round(plotftp(i - 1), pressplaceRise), 18 + i, 6,,, True, 18 + i, 6, 18 + i, 7) 'performance data header
            PlaceData(xlsWB, sheet, Math.Round(plotpow(i - 1), powerdecplaces), 18 + i, 8,,, True, 18 + i, 8, 18 + i, 9) 'performance data header
            PlaceData(xlsWB, sheet, Math.Round(plotfse(i - 1), 2), 18 + i, 10,,, True, 18 + i, 10, 18 + i, 11) 'performance data header
            PlaceData(xlsWB, sheet, Math.Round(plotfte(i - 1), 2), 18 + i, 12,,, True, 18 + i, 12, 18 + i, 13) 'performance data header
            PlaceData(xlsWB, sheet, Math.Round(plotov(i - 1), 2), 18 + i, 14,,, True, 18 + i, 14, 18 + i, 15) 'performance data header
        Next
    End Sub

    Public Sub OutputDataDutyPO(xslWB)
        xlsWB.ActiveSheet.Name = sheet
        PlaceData(xlsWB, sheet, "Duty", 7, 19) 'performance data header
        PlaceData(xlsWB, sheet, "Duty", 7, 20) 'performance data header
        PlaceData(xlsWB, sheet, "Duty", 7, 21) 'performance data header
        PlaceData(xlsWB, sheet, "Vol.", 8, 19) 'performance data header
        PlaceData(xlsWB, sheet, "Pres.", 8, 20) 'performance data header
        PlaceData(xlsWB, sheet, "Pow.", 8, 21) 'performance data header
        SetPlaces(flowrate, final.fsp, final.pow)
        PlaceData(xlsWB, sheet, Math.Round(flowrate, voldecplaces), 9, 19) 'performance data header
        If PresType = 0 Then
            PlaceData(xlsWB, sheet, Math.Round(final.fsp, pressplaceRise), 9, 20) 'performance data header
        Else
            PlaceData(xlsWB, sheet, Math.Round(final.ftp, pressplaceRise), 9, 20) 'performance data header
        End If
        PlaceData(xlsWB, sheet, Math.Round(final.pow, powerdecplaces), 9, 21) 'performance data header
    End Sub

    Public Sub OutputDataTableDamperVolPowPO(xlsWB, text1, factor, col1, col2)
        Dim vol, pwr As Double
        xlsWB.ActiveSheet.Name = sheet
        'Dim factors(3) As Double
        'Dim Factor = New Integer() {0.9, 0.8, 0.67, 0.5}
        'ConvertData()
        PlaceData(xlsWB, sheet, text1, 7, col1)
        PlaceData(xlsWB, sheet, Math.Round(factor * 100).ToString + "%", 8, col1)
        PlaceData(xlsWB, sheet, text1, 7, col2)
        PlaceData(xlsWB, sheet, Math.Round(factor * 100).ToString + "%", 8, col2)
        Dim i As Integer
        For i = 1 To Num_Readings
            vol = plotvol(i - 1) * factor
            pwr = plotpow(i - 1) * factor
            SetPlaces(vol)
            PlaceData(xlsWB, sheet, Math.Round(vol, voldecplaces), 8 + i, col1) 'performance data header
            PlaceData(xlsWB, sheet, Math.Round(pwr, powerdecplaces), 8 + i, col2) 'performance data header
        Next
    End Sub

    Public Sub OutputDataTableSystemPO(xlsWB, text1, text2, text3, col1, col2)
        Dim vol, prs As Double

        xlsWB.ActiveSheet.Name = sheet
        PlaceData(xlsWB, sheet, text1, 7, col1)
        PlaceData(xlsWB, sheet, text2, 8, col1)
        PlaceData(xlsWB, sheet, text3, 8, col2)
        Dim i As Integer
        For i = 0 To 21
            vol = i * final.vol / 20
            If PresType = 0 Then
                prs = final.fsp * (vol / final.vol) ^ 2.0
            Else
                prs = final.ftp * (vol / final.vol) ^ 2.0
            End If
            SetPlaces(vol)
            PlaceData(xlsWB, sheet, Math.Round(vol, voldecplaces), 9 + i, col1) 'performance data header
            PlaceData(xlsWB, sheet, Math.Round(prs, pressplaceRise), 9 + i, col2) 'performance data header
        Next
    End Sub

    Public Sub OutputDutyPointsPO(xlsWB)
        ConvertData()
        Dim i As Integer
        xlsWB.ActiveSheet.Name = sheet

        PlaceData(xlsWB, sheet, "FAN PERFORMANCE FIGURES", 1, 1)
        PlaceData(xlsWB, sheet, "curvevol", 7, 1)
        PlaceData(xlsWB, sheet, "curvefsp", 7, 2)
        PlaceData(xlsWB, sheet, "curveftp", 7, 3)
        PlaceData(xlsWB, sheet, "curvepower", 7, 4)
        PlaceData(xlsWB, sheet, Units(0).UnitName(Units(0).UnitSelected), 8, 1)
        PlaceData(xlsWB, sheet, Units(1).UnitName(Units(1).UnitSelected), 8, 2)
        PlaceData(xlsWB, sheet, Units(1).UnitName(Units(1).UnitSelected), 8, 3)
        PlaceData(xlsWB, sheet, Units(4).UnitName(Units(4).UnitSelected), 8, 4)
        For i = 1 To Num_Readings
            SetPlaces(plotvol(i - 1), plotfsp(i - 1), plotpow(i - 1))
            PlaceData(xlsWB, sheet, Math.Round(plotvol(i - 1), voldecplaces), 8 + i, 1)
            PlaceData(xlsWB, sheet, Math.Round(plotfsp(i - 1), pressplaceRise), 8 + i, 2)
            PlaceData(xlsWB, sheet, Math.Round(plotftp(i - 1), pressplaceRise), 8 + i, 3)
            PlaceData(xlsWB, sheet, Math.Round(plotpow(i - 1), powerdecplaces), 8 + i, 4)
            'PlaceData(xlsWB, sheet, Math.Round(plotfse(i - 1), 2), 18 + i, 10,,, True, 18 + i, 10, 18 + i, 11) 'performance data header
            'PlaceData(xlsWB, sheet, Math.Round(plotfte(i - 1), 2), 18 + i, 12,,, True, 18 + i, 12, 18 + i, 13) 'performance data header
            'PlaceData(xlsWB, sheet, Math.Round(plotov(i - 1), 2), 18 + i, 14,,, True, 18 + i, 14, 18 + i, 15) 'performance data header
        Next
    End Sub

End Module
