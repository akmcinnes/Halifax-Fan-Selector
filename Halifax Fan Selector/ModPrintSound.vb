Module ModPrintSound
    'subroutines
    'PopulatePrintoutSound
    'script to write acoustics to excel worksheet

    'OutputSWLPO
    'write SWL to excel worksheet

    'OutputductPO
    'write duct inlet to excel worksheet

    'OutputopeninletPO
    'write open inlet to excel worksheet

    'OutputopeninletPO
    'write open outlet to excel worksheet

    'OutputbrgPO
    'write bearing sound to excel worksheet

    'OutputmotorPO
    'write motor sound to excel worksheet

    'OutputbpfPO
    'write bpf to excel worksheet

    Sub PopulatePrintoutSound(xlsWB)
        Try
            sheet = "Sound"
            xlsWB.ActiveSheet.Name = sheet
            With xlsWB.ActiveSheet
                .Activate
                SetupPagePO(xlsWB)
                OutputHeaderPO(xlsWB)
                OutputFanDetailsPO(xlsWB, 2)
                OutputSWLPO(xlsWB, 12)
                OutputductPO(xlsWB, 20)
                OutputopeninletPO(xlsWB, 26)
                OutputopenoutletPO(xlsWB, 33)
                OutputbrgPO(xlsWB, 42)
                OutputmotorPO(xlsWB, 44)
                OutputbpfPO(xlsWB, 40)
                OutputFooterPO(xlsWB)
            End With
        Catch ex As Exception
            ErrorMessage(ex, 7101)
        End Try
    End Sub

    Public Sub OutputSWLPO(xlsWB, swlrow)
        Try
            xlsWB.ActiveSheet.Name = sheet
            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 35), swlrow, 1, True,, True, swlrow, 1, swlrow, 16, 11,, 3)
            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 36), swlrow + 1, 1, True,, True, swlrow + 1, 1, swlrow + 1, 8)
            PlaceData(xlsWB, sheet, 63, swlrow + 1, 9)
            PlaceData(xlsWB, sheet, 125, swlrow + 1, 10)
            PlaceData(xlsWB, sheet, 250, swlrow + 1, 11)
            PlaceData(xlsWB, sheet, 500, swlrow + 1, 12)
            PlaceData(xlsWB, sheet, 1000, swlrow + 1, 13)
            PlaceData(xlsWB, sheet, 2000, swlrow + 1, 14)
            PlaceData(xlsWB, sheet, 4000, swlrow + 1, 15)
            PlaceData(xlsWB, sheet, 8000, swlrow + 1, 16)
            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 37), swlrow + 2, 1,,, True, swlrow + 2, 1, swlrow + 2, 8)
            For count = 0 To 7
                PlaceData(xlsWB, sheet, IDSPL(count), swlrow + 2, count + 9)
            Next count
            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 38) & " " & spl2 & " " & lang_dict(PrintLanguage, 39), swlrow + 3, 1,,, True, swlrow + 3, 1, swlrow + 3, 16, 11)
            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 40) & " " & bospl2 & " " & lang_dict(PrintLanguage, 39), swlrow + 5, 1,,, True, swlrow + 5, 1, swlrow + 5, 16)
            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 41) & " " & bospl1M2 & " " & lang_dict(PrintLanguage, 39), swlrow + 6, 1,,, True, swlrow + 6, 1, swlrow + 6, 16)
        Catch ex As Exception
            ErrorMessage(ex, 7102)
        End Try
    End Sub

    Public Sub OutputductPO(xlsWB, Drow)
        Try
            xlsWB.ActiveSheet.Name = sheet
            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 42), Drow, 1, True,, True, Drow, 1, Drow, 16, 11,, 3)
            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 43), Drow + 1, 1, True,, True, Drow + 1, 1, Drow + 1, 16)
            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 36), Drow + 2, 1, True,, True, Drow + 2, 1, Drow + 2, 8)
            PlaceData(xlsWB, sheet, 63, Drow + 2, 9)
            PlaceData(xlsWB, sheet, 125, Drow + 2, 10)
            PlaceData(xlsWB, sheet, 250, Drow + 2, 11)
            PlaceData(xlsWB, sheet, 500, Drow + 2, 12)
            PlaceData(xlsWB, sheet, 1000, Drow + 2, 13)
            PlaceData(xlsWB, sheet, 2000, Drow + 2, 14)
            PlaceData(xlsWB, sheet, 4000, Drow + 2, 15)
            PlaceData(xlsWB, sheet, 8000, Drow + 2, 16)
            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 44), Drow + 3, 1,,, True, Drow + 3, 1, Drow + 3, 8)
            For count = 0 To 7
                PlaceData(xlsWB, sheet, Ascale(count), Drow + 3, count + 9)
            Next count
            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 45) & " " & NCoverall & " " & lang_dict(PrintLanguage, 46), Drow + 4, 1, True, True, True, Drow + 4, 1, Drow + 4, 16, 11)
            With xlsWB.ActiveSheet
                Dim rowstring As String
                For kk = Drow To Drow + 5
                    rowstring = kk.ToString + ":" + kk.ToString
                    .Rows(rowstring).EntireRow.Hidden = Not InclDuctNoise
                Next
            End With
        Catch ex As Exception
            ErrorMessage(ex, 7103)
        End Try
    End Sub

    Public Sub OutputopeninletPO(xlsWB, OIrow)
        Try
            xlsWB.ActiveSheet.Name = sheet
            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 47), OIrow, 1, True,, True, OIrow, 1, OIrow, 16, 11,, 3)
            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 48) & " " & Math.Round(final.inletdia).ToString & Units(5).UnitName(Units(5).UnitSelected), OIrow + 1, 1,,, True, OIrow + 1, 1, OIrow + 1, 16)
            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 43), OIrow + 2, 1, True,, True, OIrow + 2, 1, OIrow + 2, 16, 10)
            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 36), OIrow + 3, 1,,, True, OIrow + 3, 1, OIrow + 3, 8)
            PlaceData(xlsWB, sheet, 63, OIrow + 3, 9)
            PlaceData(xlsWB, sheet, 125, OIrow + 3, 10)
            PlaceData(xlsWB, sheet, 250, OIrow + 3, 11)
            PlaceData(xlsWB, sheet, 500, OIrow + 3, 12)
            PlaceData(xlsWB, sheet, 1000, OIrow + 3, 13)
            PlaceData(xlsWB, sheet, 2000, OIrow + 3, 14)
            PlaceData(xlsWB, sheet, 4000, OIrow + 3, 15)
            PlaceData(xlsWB, sheet, 8000, OIrow + 3, 16)
            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 49), OIrow + 4, 1,,, True, OIrow + 4, 1, OIrow + 4, 8)
            For count = 0 To 7
                PlaceData(xlsWB, sheet, INascale(count), OIrow + 4, count + 9)
            Next count
            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 50) & " " & Math.Round(inNCoverall) & " " & lang_dict(PrintLanguage, 46), OIrow + 5, 1, True, True, True, OIrow + 5, 1, OIrow + 5, 16)
            With xlsWB.ActiveSheet
                Dim rowstring As String
                For kk = OIrow To OIrow + 6
                    rowstring = kk.ToString + ":" + kk.ToString
                    .Rows(rowstring).EntireRow.Hidden = Not InclOpenInletNoise
                Next
            End With
        Catch ex As Exception
            ErrorMessage(ex, 7104)
        End Try
    End Sub

    Public Sub OutputopenoutletPO(xlsWB, OOrow)
        Try
            xlsWB.ActiveSheet.Name = sheet
            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 51), OOrow, 1, True,, True, OOrow, 1, OOrow, 16, 11,, 3)
            If final.outletlen > 0 And final.outletwid > 0 Then
                PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 52) & " " & Math.Round(final.outletlen).ToString & " x " & Math.Round(final.outletwid).ToString & Units(5).UnitName(Units(5).UnitSelected), OOrow + 1, 1,,, True, OOrow + 1, 1, OOrow + 1, 16, 11,, 1)
            Else
                PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 57) & " " & Math.Round(final.outletdia).ToString & Units(5).UnitName(Units(5).UnitSelected), OOrow + 1, 1,, True, OOrow + 1, 1, OOrow + 1, 16, 11,, 1)
            End If
            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 43), OOrow + 2, 1, True,, True, OOrow + 2, 1, OOrow + 2, 16, 10)
            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 36), OOrow + 3, 1, True,, True, OOrow + 3, 1, OOrow + 3, 8)
            PlaceData(xlsWB, sheet, 63, OOrow + 3, 9)
            PlaceData(xlsWB, sheet, 125, OOrow + 3, 10)
            PlaceData(xlsWB, sheet, 250, OOrow + 3, 11)
            PlaceData(xlsWB, sheet, 500, OOrow + 3, 12)
            PlaceData(xlsWB, sheet, 1000, OOrow + 3, 13)
            PlaceData(xlsWB, sheet, 2000, OOrow + 3, 14)
            PlaceData(xlsWB, sheet, 4000, OOrow + 3, 15)
            PlaceData(xlsWB, sheet, 8000, OOrow + 3, 16)
            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 49), OOrow + 4, 1,,, True, OOrow + 4, 1, OOrow + 4, 8)
            For count = 0 To 7
                PlaceData(xlsWB, sheet, OUTascale(count), OOrow + 4, count + 9)
            Next count
            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 53) & " " & Math.Round(OUTNCoverall) & " " & lang_dict(PrintLanguage, 46), OOrow + 5, 1, True, True, True, OOrow + 5, 1, OOrow + 5, 16)
            With xlsWB.ActiveSheet
                Dim rowstring As String
                For kk = OOrow To OOrow + 6
                    rowstring = kk.ToString + ":" + kk.ToString
                    .Rows(rowstring).EntireRow.Hidden = Not InclOpenOutletNoise
                Next
            End With
        Catch ex As Exception
            ErrorMessage(ex, 7105)
        End Try
    End Sub

    Public Sub OutputbrgPO(xlsWB, brgrow)
        Try
            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 55) & " " & BRGnoise & " dBA", brgrow, 1, True, True, True, brgrow, 1, brgrow, 6) 'Bearing SPL
            xlsWB.ActiveSheet.Name = sheet
            With xlsWB.ActiveSheet
                Dim rowstring As String
                For kk = brgrow To brgrow + 1
                    rowstring = kk.ToString + ":" + kk.ToString
                    .Rows(rowstring).EntireRow.Hidden = Not InclBrgNoise
                Next
            End With
        Catch ex As Exception
            ErrorMessage(ex, 7106)
        End Try
    End Sub

    Public Sub OutputmotorPO(xlsWB, Motorrow)
        Try
            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 56) & " " & MTRnoise & " dBA", Motorrow, 1, True, True, True, Motorrow, 1, Motorrow, 6) 'Motor SPL
            xlsWB.ActiveSheet.Name = sheet
            With xlsWB.ActiveSheet
                Dim rowstring As String
                For kk = Motorrow To Motorrow
                    rowstring = kk.ToString + ":" + kk.ToString
                    .Rows(rowstring).EntireRow.Hidden = Not InclMotorNoise
                Next
            End With
        Catch ex As Exception
            ErrorMessage(ex, 7107)
        End Try
    End Sub

    Public Sub OutputbpfPO(xlsWB, bpfroW)
        Try
            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 54) & " " & BPfreq & " Hz", bpfroW, 1, True, True, True, bpfroW, 1, bpfroW, 8) 'BPF
        Catch ex As Exception
            ErrorMessage(ex, 7108)
        End Try
    End Sub

End Module
