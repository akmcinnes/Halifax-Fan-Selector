Imports Excel = Microsoft.Office.Interop.Excel
Module ModPrintCurve
    'subroutines & Functions
    'PopulatePrintoutChart

    'ChartDamper
    'draw damper curves

    'Chartdamperpower
    'draw damper power curves

    'Chartfansystem
    'draw fan system curve

    'deletecurveftp - not used
    'deletes ftp curve

    Sub PopulatePrintoutChart(xlsWB)
        Try
            Dim i As Integer
            Dim ilang As Integer
            If StandAlone = True Then
                ilang = 1
            Else
                ilang = 2
            End If

            Dim found As Boolean = False
            For i = 141 To 170
                If final.fantypename = lang_dict(ilang, i) Then '2
                    found = True
                    Exit For
                End If
            Next
            Dim didw As String = ""
            If SelectDIDW = True Then didw = " (DIDW)"
            'title
            sheet = "Chart"
            xlsWB.ActiveChart.Name = sheet
            xlsWB.ActiveSheet.Shapes.AddChart2(240, Excel.XlChartType.xlXYScatterSmoothNoMarkers).Select
            Dim ser As Integer = 0

            With xlsWB.ActiveChart
                If found = False Then
                    .ChartTitle.Text = lang_dict(PrintLanguage, 75) & " " & final.fansize.ToString & " " & final.fantypename & " " & lang_dict(PrintLanguage, 3) & didw
                Else
                    .ChartTitle.Text = lang_dict(PrintLanguage, 75) & " " & final.fansize.ToString & " " & lang_dict(PrintLanguage, i) & " " & lang_dict(PrintLanguage, 3) & didw
                End If

                .ChartTitle.Font.Name = "Arial"
                .ChartTitle.Font.Size = 12
                .ChartTitle.Font.Bold = True
                .ChartTitle.Font.Underline = True
                .ChartTitle.Top = 2

                .PlotArea.Interior.Color = RGB(255, 255, 245)

                .HasLegend = False
                .ChartArea.Width = 730
                .ChartArea.Height = 475
                .PlotArea.Border.LineStyle = Excel.XlLineStyle.xlContinuous
                .PlotArea.Border.Weight = Excel.XlBorderWeight.xlMedium
                .PlotArea.Height = 375 '375
                .PlotArea.Width = 650 '650
                .PlotArea.Top = 70
                .PlotArea.Left = 40
                If numdensities = 1 And numspeeds = 1 Then
                    If FrmCurveOptions.optFSPonly.Checked = True Or FrmCurveOptions.optFSPandFTP.Checked = True Then
                        ser = ser + 1
                        .SeriesCollection.NewSeries
                        .FullSeriesCollection(ser).XValues = "=Datapoints!$A$9:$A$" + (Num_Readings + 9).ToString
                        .FullSeriesCollection(ser).Values = "=Datapoints!$b$9:$b$" + (Num_Readings + 9).ToString
                        '.FullSeriesCollection(ser).Name = "=""Fan Curve"""
                        .SeriesCollection(ser).Name = "FSP"
                        .SeriesCollection(ser).Border.ColorIndex = 1
                        With .SeriesCollection(ser).Points(.SeriesCollection(ser).Points.count - 1)
                            .HasDataLabel = True
                            .DataLabel.Text = lang_dict(PrintLanguage, 126)
                            .DataLabel.Font.Name = "Arial"
                            .DataLabel.Font.size = 8
                            .DataLabel.Font.Italic = True
                            .DataLabel.Interior.ColorIndex = 2
                        End With
                    End If

                    If FrmCurveOptions.optFTPonly.Checked = True Or FrmCurveOptions.optFSPandFTP.Checked = True Then
                    ser = ser + 1
                    .SeriesCollection.NewSeries
                    .FullSeriesCollection(ser).XValues = "=Datapoints!$A$9:$A$" + (Num_Readings + 9).ToString
                    .FullSeriesCollection(ser).Values = "=Datapoints!$c$9:$c$" + (Num_Readings + 9).ToString
                    .SeriesCollection(ser).Name = "FTP"
                    .SeriesCollection(ser).Border.ColorIndex = 1
                    With .SeriesCollection(ser).Points(.SeriesCollection(ser).Points.count - 1)
                        .HasDataLabel = True
                        .DataLabel.Text = lang_dict(PrintLanguage, 126)
                        .DataLabel.Font.Name = "Arial"
                        .DataLabel.Font.size = 8
                        .DataLabel.Font.Italic = True
                        .DataLabel.Interior.ColorIndex = 2
                    End With
                End If

                ser = ser + 1
                .SeriesCollection.NewSeries
                .FullSeriesCollection(ser).XValues = "=Datapoints!$A$9:$A$" + (Num_Readings + 9).ToString
                .FullSeriesCollection(ser).Values = "=Datapoints!$d$9:$d$" + (Num_Readings + 9).ToString
                .SeriesCollection(ser).Name = "Power " & "" 'snme(1)
                .SeriesCollection(ser).AxisGroup = Excel.XlAxisGroup.xlSecondary
                .SeriesCollection(ser).Border.ColorIndex = 1
                    .SeriesCollection(ser).Border.LineStyle = Excel.XlLineStyle.xlDash

                    With .SeriesCollection(ser).Points(.SeriesCollection(ser).Points.count - 1)
                    .HasDataLabel = True
                    .DataLabel.Text = lang_dict(PrintLanguage, 112) '"Power Fully Open" ' & snme(1)
                    .DataLabel.Font.Name = "Arial"
                    .DataLabel.Font.size = 8
                    .DataLabel.Font.Italic = True
                    .DataLabel.Interior.ColorIndex = 2
                End With

                End If
                If Not StandAlone Then IncludeDutyPoint = True

                If IncludeDutyPoint Then
                    ser = ser + 1
                    .SeriesCollection.NewSeries
                    .SeriesCollection(ser).XValues = "=Datapoints!$s$9"
                    .SeriesCollection(ser).Values = "=Datapoints!$t$9"
                    .SeriesCollection(ser).AxisGroup = Excel.XlAxisGroup.xlPrimary
                    .SeriesCollection(ser).Name = "Duty Point"
                    .SeriesCollection(ser).MarkerStyle = Excel.XlMarkerStyle.xlMarkerStyleCircle
                    .SeriesCollection(ser).MarkerForegroundColorIndex = 11    'dark blue
                    .SeriesCollection(ser).MarkerBackgroundColorIndex = 11    'dark blue
                    .SeriesCollection(ser).Border.ColorIndex = 3
                    .SeriesCollection(ser).Border.LineStyle = Excel.XlLineStyle.xlDot
                    With .SeriesCollection(ser).Points(1)
                        .HasDataLabel = True
                        .DataLabel.Text = lang_dict(PrintLanguage, 125) '"Duty Point"
                        .DataLabel.Font.Name = "Arial"
                        .DataLabel.Font.size = 10
                        .DataLabel.Interior.ColorIndex = 2
                        .DataLabel.Font.Italic = True
                        .DataLabel.Font.ColorIndex = 1
                    End With

                    ser = ser + 1
                    .SeriesCollection.NewSeries
                    .SeriesCollection(ser).XValues = "=Datapoints!$s$9"
                    .SeriesCollection(ser).Values = "=Datapoints!$u$9"
                    .SeriesCollection(ser).AxisGroup = Excel.XlAxisGroup.xlSecondary
                    .SeriesCollection(ser).Name = "Power Duty"
                    .SeriesCollection(ser).MarkerStyle = Excel.XlMarkerStyle.xlMarkerStyleCircle
                    .SeriesCollection(ser).MarkerForegroundColorIndex = 3    'dark red
                    .SeriesCollection(ser).MarkerBackgroundColorIndex = 3    'dark red
                    .SeriesCollection(ser).Border.ColorIndex = 3
                    .SeriesCollection(ser).Border.LineStyle = Excel.XlLineStyle.xlDot
                    With .SeriesCollection(ser).Points(1)
                        .HasDataLabel = True
                        .DataLabel.Text = lang_dict(PrintLanguage, 125) ' "Duty Point"
                        .DataLabel.Font.Name = "Arial"
                        .DataLabel.Font.size = 10
                        .DataLabel.Interior.ColorIndex = 2
                        .DataLabel.Font.Italic = True
                        .DataLabel.Font.ColorIndex = 1
                    End With
                End If

                .Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).HasTitle = True
                .Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).HasMajorGridlines = True
                .Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).MajorGridlines.Border.LineStyle = Excel.XlLineStyle.xlDashDot
                .Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).MajorGridlines.Border.Weight = Excel.XlBorderWeight.xlHairline
                .Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).MajorGridlines.Border.Color = RGB(150, 150, 150)
                .Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).AxisTitle.Caption = lang_dict(PrintLanguage, 117) + " (" + Units(0).UnitName(Units(0).UnitSelected) + ")"
                .Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).AxisTitle.Font.Name = "Arial"
                .Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).AxisTitle.Font.size = 9
                .Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).TickLabels.Font.Name = "Arial"
                .Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).TickLabels.Font.size = 8
                .Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).TickLabels.Font.Italic = True

                '.Excel.Axes(.xlValue, .xlPrimary).HasTitle = True
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary).HasTitle = True
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary).HasMajorGridlines = True
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary).MajorGridlines.Border.LineStyle = Excel.XlLineStyle.xlDashDot
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary).MajorGridlines.Border.Weight = Excel.XlBorderWeight.xlHairline
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary).MajorGridlines.Border.Color = RGB(150, 150, 150)
                Dim prtitle As String = ""
                If FrmCurveOptions.optFSPonly.Checked = True Then
                    prtitle = lang_dict(PrintLanguage, 118) + " (" + Units(1).UnitName(Units(1).UnitSelected) + ")"
                End If
                If FrmCurveOptions.optFTPonly.Checked = True Then
                    prtitle = lang_dict(PrintLanguage, 119) + " (" + Units(1).UnitName(Units(1).UnitSelected) + ")"
                End If
                If FrmCurveOptions.optFSPandFTP.Checked = True Then
                    prtitle = lang_dict(PrintLanguage, 124) + " (" + Units(1).UnitName(Units(1).UnitSelected) + ")"
                End If
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary).AxisTitle.Caption = prtitle
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary).AxisTitle.Font.Name = "Arial"
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary).AxisTitle.Font.size = 9
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary).TickLabels.Font.Name = "Arial"
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary).TickLabels.Font.size = 8
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary).TickLabels.Font.Italic = True

                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlSecondary).HasTitle = True
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlSecondary).HasMajorGridlines = False
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlSecondary).MajorGridlines.Border.LineStyle = Excel.XlLineStyle.xlDashDot
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlSecondary).MajorGridlines.Border.Weight = Excel.XlBorderWeight.xlHairline
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlSecondary).MajorGridlines.Border.Color = RGB(150, 150, 150)
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlSecondary).AxisTitle.Caption = lang_dict(PrintLanguage, 120) + " (" + Units(4).UnitName(Units(4).UnitSelected) + ")"
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlSecondary).AxisTitle.Font.Name = "Arial"
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlSecondary).AxisTitle.Font.size = 9
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlSecondary).TickLabels.Font.Name = "Arial"
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlSecondary).TickLabels.Font.size = 8
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlSecondary).TickLabels.Font.Italic = True

                Dim LastString As String
                Dim LastPosn As Integer
                Dim lastheight As Integer
                Dim si As Integer = 0

                Dim NN As Integer = 37
                Dim MM As Integer = 27
                ' shape 1 is the logo
                'textbox 2 - copyright
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 80, 415, 600, 30).TextFrame.Characters.Text = lang_dict(PrintLanguage, 16)
                .Shapes(si + 1).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(si + 1).TextFrame.Characters.Font.size = 6

                'textbox 3 - engineer, etc
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 0, 460, 500, 14).TextFrame.Characters.Text = lang_dict(PrintLanguage, 108) + Engineer + " " + lang_dict(PrintLanguage, 15) + Date.Now.ToString("dd/MM/yyyy") + " " + lang_dict(PrintLanguage, 109) 'DrawnBy
                .Shapes(si + 2).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(si + 2).TextFrame.Characters.Font.size = 7

                'textbox 4 - company
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 580, MM, 120, 15).TextFrame.Characters.Text = cstring
                .Shapes(si + 3).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(si + 3).TextFrame.Characters.Font.size = 7

                'textbox 5 - address
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 580, MM + 8, 150, 25).TextFrame.Characters.Text = astring 'Address(1) & Chr(13) & Address(2)
                .Shapes(si + 4).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(si + 4).TextFrame.Characters.Font.size = 6
                .Shapes(si + 4).TextFrame.Characters.Font.Italic = True

                'textbox 6 - email
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 580, MM + 23, 150, 45).TextFrame.Characters.Text = estring + vbCr + tstring '"eemm" 'EmailName & TelNo
                .Shapes(si + 5).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(si + 5).TextFrame.Characters.Font.size = 7

                'textbox 7 - operating conditions
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 170, NN, 150, 20).TextFrame.Characters.Text = lang_dict(PrintLanguage, 107)
                .Shapes(si + 6).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(si + 6).TextFrame.Characters.Font.size = 9 '9
                .Shapes(si + 6).TextFrame.Characters.Font.Bold = True
                '.Shapes(7).TextFrame.Characters.Font.Underline = True

                'textbox 8 - speed
                'If frmcurveoptions.Optsingle.Value = True Then
                If numspeeds > 1 Then
                    .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 310, NN, 150, 20).TextFrame.Characters.Text = lang_dict(PrintLanguage, 129)
                Else
                    .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 310, NN, 150, 20).TextFrame.Characters.Text = lang_dict(PrintLanguage, 123) & vbTab & final.speed.ToString & " " & "RPM"
                End If
                .Shapes(si + 7).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(si + 7).TextFrame.Characters.Font.size = 9

                'textbox 9 - density
                If numdensities > 1 Then
                    .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 440, NN, 150, 20).TextFrame.Characters.Text = lang_dict(PrintLanguage, 128)
                Else
                    .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 440, NN, 150, 20).TextFrame.Characters.Text = lang_dict(PrintLanguage, 121) & vbTab & knowndensity.ToString & " " & Units(3).UnitName(Units(3).UnitSelected)
                End If
                .Shapes(si + 8).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(si + 8).TextFrame.Characters.Font.size = 9

                'textbox 10 - duty title
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 140, NN + 12, 150, 20).TextFrame.Characters.Text = lang_dict(PrintLanguage, 122)
                .Shapes(si + 9).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(si + 9).TextFrame.Characters.Font.size = 9
                .Shapes(si + 9).TextFrame.Characters.Font.bold = True

                'textbox 11 - flow
                If StandAlone Then SetPlaces(plotvol(Most_Eff_Pt), plotfsp(Most_Eff_Pt), plotpow(Most_Eff_Pt))
                If StandAlone = True Then
                    .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 170, NN + 12, 150, 20).TextFrame.Characters.Text = lang_dict(PrintLanguage, 117) & vbTab & Math.Round(plotvol(Most_Eff_Pt), voldecplaces).ToString & " " & Units(0).UnitName(Units(0).UnitSelected)
                Else
                    .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 170, NN + 12, 150, 20).TextFrame.Characters.Text = lang_dict(PrintLanguage, 117) & vbTab & final.vol.ToString & " " & Units(0).UnitName(Units(0).UnitSelected)
                End If
                .Shapes(si + 10).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(si + 10).TextFrame.Characters.Font.size = 9

                'textbox 12 - pressure
                If PresType = 0 Then
                    If StandAlone = True Then
                        .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 310, NN + 12, 150, 20).TextFrame.Characters.Text = lang_dict(PrintLanguage, 118) & vbTab & Math.Round(plotfsp(Most_Eff_Pt), pressplaceRise).ToString & " " & Units(1).UnitName(Units(1).UnitSelected)
                    Else
                        .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 310, NN + 12, 150, 20).TextFrame.Characters.Text = lang_dict(PrintLanguage, 118) & vbTab & final.fsp.ToString & " " & Units(1).UnitName(Units(1).UnitSelected)
                    End If
                End If
                If PresType = 1 Then
                    If StandAlone = True Then
                        .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 310, NN + 12, 150, 20).TextFrame.Characters.Text = lang_dict(PrintLanguage, 119) & vbTab & Math.Round(plotftp(Most_Eff_Pt), pressplaceRise).ToString & " " & Units(1).UnitName(Units(1).UnitSelected)
                    Else
                        .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 310, NN + 12, 150, 20).TextFrame.Characters.Text = lang_dict(PrintLanguage, 119) & vbTab & final.ftp.ToString & " " & Units(1).UnitName(Units(1).UnitSelected)
                    End If
                End If
                .Shapes(si + 11).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(si + 11).TextFrame.Characters.Font.size = 9

                'TextBox 13 - power
                If StandAlone = True Then
                    .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 440, NN + 12, 150, 20).TextFrame.Characters.Text = lang_dict(PrintLanguage, 120) & vbTab & Math.Round(plotpow(Most_Eff_Pt), powerdecplaces).ToString & " " & Units(4).UnitName(Units(4).UnitSelected)
                Else
                    .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 440, NN + 12, 150, 20).TextFrame.Characters.Text = lang_dict(PrintLanguage, 120) & vbTab & final.pow.ToString & " " & Units(4).UnitName(Units(4).UnitSelected)
                End If
                .Shapes(si + 12).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(si + 12).TextFrame.Characters.Font.size = 9

                LastString = ""
                LastPosn = 372
                lastheight = 0

                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 425, NN + 36, 250, lastheight).TextFrame.Characters.Text = LastString
                .Shapes.AddShape(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 580, 0, 145, 30).Fill.UserPicture(DataPath + "Logo-2019.jpg") 'Logo-2019a.jpg'header2015.jpg
                .Shapes(.Shapes.count).Line.Visible = False
            End With

            If FrmCurveOptions.chkDamper.Checked = True Then
                ser = Chartdamper(xlsWB, ser)
                ser = Chartdamperpower(xlsWB, ser)
            End If
            If FrmCurveOptions.chkSystem.Checked = True Then
                ser = Chartfansystem(xlsWB, ser)
            End If
            If numspeeds > 1 Then
                ser = ChartSpeeds(xlsWB, ser)
            End If
            If numdensities > 1 Then
                ser = ChartDensities(xlsWB, ser)

            End If
        Catch ex As Exception
            ErrorMessage(ex, 6802)
        End Try

    End Sub

    Function Chartdamper(xlsWB, ser) As Integer
        Try
            Dim DATASETS1 As Single
            DATASETS1 = Num_Readings * 0.33
            count = 1

            Do While count < DATASETS1
                count = count + 1
            Loop

            With xlsWB.ActiveChart
                ser = ser + 1
                .SeriesCollection.NewSeries
                .FullSeriesCollection(ser).Values = "=Datapoints!$b$" + (count + 9).ToString + ":$b$39"
                .FullSeriesCollection(ser).XValues = "=Datapoints!$f$" + (count + 9).ToString + ":$f$39"
                .SeriesCollection(ser).AxisGroup = Excel.XlAxisGroup.xlPrimary
                .SeriesCollection(ser).Name = "Damper 60º"
                .SeriesCollection(ser).MarkerStyle = Excel.XlMarkerStyle.xlMarkerStyleNone
                .SeriesCollection(ser).Border.ColorIndex = 41
                .SeriesCollection(ser).Border.Weight = Excel.XlBorderWeight.xlThin
                With .SeriesCollection(ser).Points(Num_Readings - (count + 1))
                    .HasDataLabel = True
                    .DataLabel.Text = lang_dict(PrintLanguage, 110) + " 60º"
                    .DataLabel.Font.Name = "Arial"
                    .DataLabel.Font.size = 8
                    .DataLabel.Font.Italic = True
                    .DataLabel.Interior.ColorIndex = 2
                    .DataLabel.Font.ColorIndex = 41
                End With

                ser = ser + 1
                .SeriesCollection.NewSeries
                .FullSeriesCollection(ser).Values = "=Datapoints!$b$" + (count + 9).ToString + ":$b$39"
                .FullSeriesCollection(ser).XValues = "=Datapoints!$g$" + (count + 9).ToString + ":$g$39"
                .SeriesCollection(ser).AxisGroup = Excel.XlAxisGroup.xlPrimary
                .SeriesCollection(ser).Name = "Damper 50º"
                .SeriesCollection(ser).MarkerStyle = Excel.XlMarkerStyle.xlMarkerStyleNone
                .SeriesCollection(ser).Border.Color = RGB(0, 51, 102)
                .SeriesCollection(ser).Border.Weight = Excel.XlBorderWeight.xlThin
                'With .SeriesCollection(ser).Points(.SeriesCollection(ser).Points.count)
                With .SeriesCollection(ser).Points(Num_Readings - (count + 1))
                    .HasDataLabel = True
                    .DataLabel.Text = lang_dict(PrintLanguage, 110) + " 50º"
                    .DataLabel.Font.Name = "Arial"
                    .DataLabel.Font.size = 8
                    .DataLabel.Interior.ColorIndex = 2
                    .DataLabel.Font.Italic = True
                    .DataLabel.Font.Color = RGB(0, 51, 102)
                End With

                ser = ser + 1
                .SeriesCollection.NewSeries
                .FullSeriesCollection(ser).Values = "=Datapoints!$b$" + (count + 9).ToString + ":$b$39"
                .FullSeriesCollection(ser).XValues = "=Datapoints!$h$" + (count + 9).ToString + ":$h$39"
                .SeriesCollection(ser).AxisGroup = Excel.XlAxisGroup.xlPrimary
                .SeriesCollection(ser).Name = "Damper 40º"
                .SeriesCollection(ser).MarkerStyle = Excel.XlMarkerStyle.xlMarkerStyleNone
                .SeriesCollection(ser).Border.Color = RGB(0, 102, 0)
                .SeriesCollection(ser).Border.Weight = Excel.XlBorderWeight.xlThin
                With .SeriesCollection(ser).Points(Num_Readings - (count + 1))
                    .HasDataLabel = True
                    .DataLabel.Text = lang_dict(PrintLanguage, 110) + " 40º"
                    .DataLabel.Font.Name = "Arial"
                    .DataLabel.Font.size = 8
                    .DataLabel.Interior.ColorIndex = 2
                    .DataLabel.Font.Italic = True
                    .DataLabel.Font.Color = RGB(0, 102, 0)
                End With

                ser = ser + 1
                .SeriesCollection.NewSeries
                .FullSeriesCollection(ser).Values = "=Datapoints!$b$" + (count + 9).ToString + ":$b$39"
                .FullSeriesCollection(ser).XValues = "=Datapoints!$i$" + (count + 9).ToString + ":$i$39"
                .SeriesCollection(ser).AxisGroup = Excel.XlAxisGroup.xlPrimary
                .SeriesCollection(ser).Name = "Damper 30º"
                .SeriesCollection(ser).MarkerStyle = Excel.XlMarkerStyle.xlMarkerStyleNone
                .SeriesCollection(ser).Border.Color = RGB(255, 0, 0)
                .SeriesCollection(ser).Border.Weight = Excel.XlBorderWeight.xlThin
                With .SeriesCollection(ser).Points(Num_Readings - (count + 1))
                    .HasDataLabel = True
                    .DataLabel.Text = lang_dict(PrintLanguage, 110) + " 30º"
                    .DataLabel.Font.Name = "Arial"
                    .DataLabel.Font.size = 8
                    .DataLabel.Interior.ColorIndex = 2
                    .DataLabel.Font.Italic = True
                    .DataLabel.Font.Color = RGB(255, 0, 0)
                End With

                .FullSeriesCollection(ser).Values = "=Datapoints!$b$" + (count + 9).ToString + ":$b$39"
                .SeriesCollection(ser).Name = "FSP"
                .SeriesCollection(ser).Border.ColorIndex = 1
            End With
            Return ser
        Catch ex As Exception
            ErrorMessage(ex, 6803)
        End Try
        Return ser
    End Function

    Public Function Chartdamperpower(xlsWB, ser)
        Try
            Dim DATASETS1 As Single
            DATASETS1 = Num_Readings * 0.33
            count = 1

            Do While count < DATASETS1
                count = count + 1
            Loop
            With xlsWB.ActiveChart
                ser = ser + 1
                .SeriesCollection.NewSeries
                .FullSeriesCollection(ser).XValues = "=Datapoints!$f$" + (count + 9).ToString + ":$f$39"
                .FullSeriesCollection(ser).Values = "=Datapoints!$n$" + (count + 9).ToString + ":$n$39"
                .SeriesCollection(ser).Border.LineStyle = Excel.XlLineStyle.xlDash
                .SeriesCollection(ser).AxisGroup = Excel.XlAxisGroup.xlSecondary
                .SeriesCollection(ser).Name = "Damper 60º"
                .SeriesCollection(ser).MarkerStyle = Excel.XlMarkerStyle.xlMarkerStyleNone
                .SeriesCollection(ser).Border.ColorIndex = 41
                .SeriesCollection(ser).Border.Weight = Excel.XlBorderWeight.xlThin
                With .SeriesCollection(ser).Points(Num_Readings - (count + 1))
                    .HasDataLabel = True
                    .DataLabel.Text = lang_dict(PrintLanguage, 120) + " 60º"
                    .DataLabel.Font.Name = "Arial"
                    .DataLabel.Font.size = 8
                    .DataLabel.Font.Italic = True
                    .DataLabel.Interior.ColorIndex = 2
                    .DataLabel.Font.ColorIndex = 41
                End With

                ser = ser + 1
                .SeriesCollection.NewSeries
                .FullSeriesCollection(ser).XValues = "=Datapoints!$g$" + (count + 9).ToString + ":$g$39"
                .FullSeriesCollection(ser).Values = "=Datapoints!$o$" + (count + 9).ToString + ":$o$39"
                .SeriesCollection(ser).Border.LineStyle = Excel.XlLineStyle.xlDash
                .SeriesCollection(ser).AxisGroup = Excel.XlAxisGroup.xlSecondary
                .SeriesCollection(ser).Name = "Damper 50º"
                .SeriesCollection(ser).MarkerStyle = Excel.XlMarkerStyle.xlMarkerStyleNone
                .SeriesCollection(ser).Border.Color = RGB(0, 51, 102)
                .SeriesCollection(ser).Border.Weight = Excel.XlBorderWeight.xlThin
                With .SeriesCollection(ser).Points(Num_Readings - (count + 1))
                    .HasDataLabel = True
                    .DataLabel.Text = lang_dict(PrintLanguage, 120) + " 50º"
                    .DataLabel.Font.Name = "Arial"
                    .DataLabel.Font.size = 8
                    .DataLabel.Interior.ColorIndex = 2
                    .DataLabel.Font.Italic = True
                    .DataLabel.Font.Color = RGB(0, 51, 102)
                End With

                ser = ser + 1
                .SeriesCollection.NewSeries
                .FullSeriesCollection(ser).XValues = "=Datapoints!$h$" + (count + 9).ToString + ":$h$39"
                .FullSeriesCollection(ser).Values = "=Datapoints!$p$" + (count + 9).ToString + ":$p$39"
                .SeriesCollection(ser).Border.LineStyle = Excel.XlLineStyle.xlDash
                .SeriesCollection(ser).AxisGroup = Excel.XlAxisGroup.xlSecondary
                .SeriesCollection(ser).Name = "Damper 40º"
                .SeriesCollection(ser).MarkerStyle = Excel.XlMarkerStyle.xlMarkerStyleNone
                .SeriesCollection(ser).Border.Color = RGB(0, 102, 0)
                .SeriesCollection(ser).Border.Weight = Excel.XlBorderWeight.xlThin
                With .SeriesCollection(ser).Points(Num_Readings - (count + 1))
                    .HasDataLabel = True
                    .DataLabel.Text = lang_dict(PrintLanguage, 120) + " 40º"
                    .DataLabel.Font.Name = "Arial"
                    .DataLabel.Font.size = 8
                    .DataLabel.Interior.ColorIndex = 2
                    .DataLabel.Font.Italic = True
                    .DataLabel.Font.Color = RGB(0, 102, 0)
                End With

                ser = ser + 1
                .SeriesCollection.NewSeries
                .FullSeriesCollection(ser).XValues = "=Datapoints!$i$" + (count + 9).ToString + ":$i$39"
                .FullSeriesCollection(ser).Values = "=Datapoints!$q$" + (count + 9).ToString + ":$q$39"
                .SeriesCollection(ser).Border.LineStyle = Excel.XlLineStyle.xlDash
                .SeriesCollection(ser).AxisGroup = Excel.XlAxisGroup.xlSecondary
                .SeriesCollection(ser).Name = "Damper 30º"
                .SeriesCollection(ser).MarkerStyle = Excel.XlMarkerStyle.xlMarkerStyleNone
                .SeriesCollection(ser).Border.Color = RGB(255, 0, 0)
                .SeriesCollection(ser).Border.Weight = Excel.XlBorderWeight.xlThin
                With .SeriesCollection(ser).Points(Num_Readings - (count + 1))
                    .HasDataLabel = True
                    .DataLabel.Text = lang_dict(PrintLanguage, 120) + " 30º"
                    .DataLabel.Font.Name = "Arial"
                    .DataLabel.Font.size = 8
                    .DataLabel.Interior.ColorIndex = 2
                    .DataLabel.Font.Italic = True
                    .DataLabel.Font.Color = RGB(255, 0, 0)
                End With
            End With
            Return ser
        Catch ex As Exception
            ErrorMessage(ex, 6804)
        End Try
        Return ser
    End Function

    Function Chartfansystem(xlsWB, ser) As Integer
        Try
            count = 0

            With xlsWB.ActiveChart
                ser = ser + 1
                .SeriesCollection.NewSeries
                .FullSeriesCollection(ser).Values = "=Datapoints!$l$9:$l$39"
                .FullSeriesCollection(ser).XValues = "=Datapoints!$k$9:$k$39"
                .SeriesCollection(ser).AxisGroup = Excel.XlAxisGroup.xlPrimary
                .SeriesCollection(ser).Name = "System Curve"
                .SeriesCollection(ser).MarkerStyle = Excel.XlMarkerStyle.xlMarkerStyleNone
                .SeriesCollection(ser).Border.ColorIndex = 1
                .SeriesCollection(ser).Border.LineStyle = Excel.XlLineStyle.xlDot
                With .SeriesCollection(ser).Points(Num_Readings - (count + 1))
                    .HasDataLabel = True
                    .DataLabel.Text = lang_dict(PrintLanguage, 127)
                    .DataLabel.Font.Name = "Arial"
                    .DataLabel.Font.size = 10
                    .DataLabel.Font.Italic = True
                    .DataLabel.Interior.ColorIndex = 2
                    .DataLabel.Font.ColorIndex = 1
                End With
            End With
            Return ser
        Catch ex As Exception
            ErrorMessage(ex, 6805)
        End Try
        Return ser
    End Function

    Public Function ChartSpeeds(xlswb, ser)
        Try
            For i = 1 To numspeeds
                If i = 1 Then
                    ser = Charts2(xlswb, ser, 1, 9, 1, 1, i - 1)
                End If
                If i = 2 Then
                    ser = Charts2(xlswb, ser, 1, 9, 6, 41, i - 1)
                End If
                If i = 3 Then
                    ser = Charts2(xlswb, ser, 1, 44, 1, 49, i - 1)
                End If
                If i = 4 Then
                    ser = Charts2(xlswb, ser, 1, 44, 6, 10, i - 1)
                End If
                If i = 5 Then
                    ser = Charts2(xlswb, ser, 1, 79, 1, 26, i - 1)
                End If
                If i = 6 Then
                    ser = Charts2(xlswb, ser, 1, 79, 6, 3, i - 1)
                End If
                If i = 7 Then
                    ser = Charts2(xlswb, ser, 1, 114, 1, 54, i - 1)
                End If
                If i = 8 Then
                    ser = Charts2(xlswb, ser, 1, 114, 6, 56, i - 1)
                End If
            Next
            Return ser
        Catch ex As Exception
            ErrorMessage(ex, 6806)
            Return ser
        End Try
    End Function

    Public Function ChartDensities(xlswb, ser)
        Try
            For i = 1 To numdensities
                If i = 1 Then
                    ser = Charts2(xlswb, ser, 2, 9, 1, 1, i - 1)
                End If
                If i = 2 Then
                    ser = Charts2(xlswb, ser, 2, 9, 6, 41, i - 1)
                End If
                If i = 3 Then
                    ser = Charts2(xlswb, ser, 2, 44, 1, 49, i - 1)
                End If
                If i = 4 Then
                    ser = Charts2(xlswb, ser, 2, 44, 6, 10, i - 1)
                End If
                If i = 5 Then
                    ser = Charts2(xlswb, ser, 2, 79, 1, 26, i - 1)
                End If
                If i = 6 Then
                    ser = Charts2(xlswb, ser, 2, 79, 6, 3, i - 1)
                End If
                If i = 7 Then
                    ser = Charts2(xlswb, ser, 2, 114, 1, 54, i - 1)
                End If
                If i = 8 Then
                    ser = Charts2(xlswb, ser, 2, 114, 6, 56, i - 1)
                End If
            Next
            'With xlswb.ActiveChart
            '    ser = ser + 1
            '    .SeriesCollection.NewSeries
            'End With
            Return ser
        Catch ex As Exception
            ErrorMessage(ex, 6807)
            Return ser
        End Try
    End Function

    Function Charts2(xlswb, ser, linelabel, row1, col1, color1, num) As Integer
        Try
            Dim abcd() As String = {" ", "a", "b", "c", "d", "e", "f", "g", "h", "i"}
            Dim DATASETS1 As Single
            DATASETS1 = Num_Readings
            count = 1

            Do While count < DATASETS1
                count = count + 1
            Loop
            With xlswb.ActiveChart
                If FrmCurveOptions.optFSPonly.Checked = True Or FrmCurveOptions.optFSPandFTP.Checked = True Then
                    ser = ser + 1
                    .SeriesCollection.NewSeries
                    .SeriesCollection(ser).XValues = "=Datapoints!" + abcd(col1) + row1.ToString + ":" + abcd(col1) + (row1 + Num_Readings).ToString
                    .SeriesCollection(ser).Values = "=Datapoints!" + abcd(col1 + 1) + row1.ToString + ":" + abcd(col1 + 1) + (row1 + Num_Readings).ToString
                    .SeriesCollection(ser).AxisGroup = Excel.XlAxisGroup.xlPrimary
                    .SeriesCollection(ser).Name = "FSP" ' & snme(2)
                    .SeriesCollection(ser).MarkerStyle = Excel.XlMarkerStyle.xlMarkerStyleNone
                    .SeriesCollection(ser).Border.ColorIndex = color1
                    .SeriesCollection(ser).Border.Weight = Excel.XlBorderWeight.xlThin
                    With .SeriesCollection(ser).Points(1)
                        .HasDataLabel = True
                        'If linelabel = 1 Then .DataLabel.Text = lang_dict(PrintLanguage, 124) + " " + AddedSpeeds(num).ToString '"Pressure " & snme(2)
                        'If linelabel = 2 Then .DataLabel.Text = lang_dict(PrintLanguage, 124) + " " + AddedDensities(num).ToString '"Pressure " & snme(2)
                        If linelabel = 1 Then .DataLabel.Text = lang_dict(PrintLanguage, 124) + " [" + AddedSpeeds(num).ToString + "RPM}]" '"Power " & snme(2)'snme(2) = "[" & frmcurveoptions.txtfanspd2.Value & " RPM]"
                        If linelabel = 2 Then .DataLabel.Text = lang_dict(PrintLanguage, 124) + " [" + AddedDensities(num).ToString + " " + Units(3).UnitName(Units(3).UnitSelected) + "]" '"Power " & snme(2)snme(1) = "[" & frmcurveoptions.txtgd1.Value & " Kg/m³]"
                        .DataLabel.Font.Name = "Arial"
                        .DataLabel.Font.size = 10
                        .DataLabel.Font.Italic = True
                        .DataLabel.Interior.ColorIndex = 2
                        .DataLabel.Font.ColorIndex = color1
                        .DataLabel.Top = .DataLabel.Top - 10
                        .DataLabel.Left = .DataLabel.Left + 10
                    End With
                    .SeriesCollection(ser).HasLeaderLines = False
                End If
                If FrmCurveOptions.optFTPonly.Checked = True Or FrmCurveOptions.optFSPandFTP.Checked = True Then
                    ser = ser + 1
                    .SeriesCollection.NewSeries
                    .SeriesCollection(ser).XValues = "=Datapoints!" + abcd(col1) + row1.ToString + ":" + abcd(col1) + (row1 + Num_Readings).ToString
                    .SeriesCollection(ser).Values = "=Datapoints!" + abcd(col1 + 2) + row1.ToString + ":" + abcd(col1 + 2) + (row1 + Num_Readings).ToString
                    .SeriesCollection(ser).AxisGroup = Excel.XlAxisGroup.xlPrimary
                    .SeriesCollection(ser).Name = "FTP" ' & snme(2)
                    .SeriesCollection(ser).MarkerStyle = Excel.XlMarkerStyle.xlMarkerStyleNone
                    .SeriesCollection(ser).Border.ColorIndex = color1
                    .SeriesCollection(ser).Border.Weight = Excel.XlBorderWeight.xlThin
                    With .SeriesCollection(ser).Points(1)
                        .HasDataLabel = True
                        'If linelabel = 1 Then .DataLabel.Text = lang_dict(PrintLanguage, 124) + " " + AddedSpeeds(num).ToString '"Pressure " & snme(2)
                        'If linelabel = 2 Then .DataLabel.Text = lang_dict(PrintLanguage, 124) + " " + AddedDensities(num).ToString '"Pressure " & snme(2)
                        If linelabel = 1 Then .DataLabel.Text = lang_dict(PrintLanguage, 124) + " [" + AddedSpeeds(num).ToString + "RPM}]" '"Power " & snme(2)'snme(2) = "[" & frmcurveoptions.txtfanspd2.Value & " RPM]"
                        If linelabel = 2 Then .DataLabel.Text = lang_dict(PrintLanguage, 124) + " [" + AddedDensities(num).ToString + " " + Units(3).UnitName(Units(3).UnitSelected) + "]" '"Power " & snme(2)snme(1) = "[" & frmcurveoptions.txtgd1.Value & " Kg/m³]"
                        .DataLabel.Font.Name = "Arial"
                        .DataLabel.Font.size = 10
                        .DataLabel.Interior.ColorIndex = 2
                        .DataLabel.Font.Italic = True
                        .DataLabel.Font.ColorIndex = color1
                        .DataLabel.Top = .DataLabel.Top - 10
                        .DataLabel.Left = .DataLabel.Left + 10
                    End With
                    .SeriesCollection(ser).HasLeaderLines = False
                End If
                ser = ser + 1
                .SeriesCollection.NewSeries
                .SeriesCollection(ser).XValues = "=Datapoints!" + abcd(col1) + row1.ToString + ":" + abcd(col1) + (row1 + Num_Readings).ToString
                .SeriesCollection(ser).Values = "=Datapoints!" + abcd(col1 + 3) + row1.ToString + ":" + abcd(col1 + 3) + (row1 + Num_Readings).ToString
                .SeriesCollection(ser).AxisGroup = Excel.XlAxisGroup.xlSecondary
                .SeriesCollection(ser).Name = "Power" ' & snme(2)
                .SeriesCollection(ser).MarkerStyle = Excel.XlMarkerStyle.xlMarkerStyleNone
                .SeriesCollection(ser).Border.ColorIndex = color1
                .SeriesCollection(ser).Border.LineStyle = Excel.XlLineStyle.xlDash
                .SeriesCollection(ser).Border.Weight = Excel.XlBorderWeight.xlThin
                'With .SeriesCollection(ser).Points(.SeriesCollection(ser).Points.count - 1)
                With .SeriesCollection(ser).Points(Num_Readings - 1)
                    .HasDataLabel = True
                    If linelabel = 1 Then .DataLabel.Text = lang_dict(PrintLanguage, 120) + " [" + AddedSpeeds(num).ToString + "RPM}]" '"Power " & snme(2)'snme(2) = "[" & frmcurveoptions.txtfanspd2.Value & " RPM]"
                    If linelabel = 2 Then .DataLabel.Text = lang_dict(PrintLanguage, 120) + " [" + AddedDensities(num).ToString + " " + Units(3).UnitName(Units(3).UnitSelected) + "]" '"Power " & snme(2)snme(1) = "[" & frmcurveoptions.txtgd1.Value & " Kg/m³]"
                    .DataLabel.Font.Name = "Arial"
                    .DataLabel.Font.size = 10
                    .DataLabel.Interior.ColorIndex = 2
                    .DataLabel.Font.Italic = True
                    .DataLabel.Font.ColorIndex = color1
                    .DataLabel.Top = .DataLabel.Top - 10
                    .DataLabel.Left = .DataLabel.Left - 20
                End With
                .SeriesCollection(ser).HasLeaderLines = False
            End With
            Return ser
        Catch ex As Exception
            ErrorMessage(ex, 6808)
            Return ser
        End Try
    End Function

    Public Sub deletecurveftp(xlsWB)
        Try
            sheet = "Chart"
            xlsWB.ActiveChart.Name = sheet
            With xlsWB.activechart
                Dim NN As Integer
                NN = PresType
                .SeriesCollection(2 - NN).Delete
            End With
        Catch ex As Exception
            ErrorMessage(ex, 6809)
        End Try
    End Sub
End Module
