Imports Excel = Microsoft.Office.Interop.Excel
Module ModPrintCurve
    Sub PopulatePrintoutChart(xlsWB)
        Try
            Dim i As Integer
            Dim found As Boolean = False
            For i = 141 To 170
                If final.fantypename = lang_dictEN(i) Then
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
                    .ChartTitle.Text = lang_dict(75) & " " & final.fansize.ToString & " " & final.fantypename & " " & lang_dict(3) & didw
                Else
                    .ChartTitle.Text = lang_dict(75) & " " & final.fansize.ToString & " " & lang_dict(i) & " " & lang_dict(3) & didw
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
                If FrmCurveOptions.optFSPonly.Checked = True Or FrmCurveOptions.optFSPandFTP.Checked = True Then
                    ser = ser + 1
                    .SeriesCollection.NewSeries
                    .FullSeriesCollection(ser).XValues = "=Datapoints!$A$9:$A$" + (Num_Readings + 9).ToString
                    .FullSeriesCollection(ser).Values = "=Datapoints!$b$9:$b$" + (Num_Readings + 9).ToString
                    '.FullSeriesCollection(ser).Name = "=""Fan Curve"""
                    .SeriesCollection(ser).Name = "FSP"
                    .SeriesCollection(ser).Border.ColorIndex = 1
                    With .SeriesCollection(ser).Points(.SeriesCollection(ser).Points.count - 1) '(Num_Readings - 1)
                        .HasDataLabel = True
                        .DataLabel.Text = lang_dict(126) '"Fully Open" ' & snme(1)
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
                    With .SeriesCollection(ser).Points(.SeriesCollection(ser).Points.count - 1) '(Num_Readings - 1)
                        .HasDataLabel = True
                        .DataLabel.Text = lang_dict(126) '"Fully Open" ' & snme(1)
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

                'With .SeriesCollection(ser).Points(datasets - 1)
                With .SeriesCollection(ser).Points(.SeriesCollection(ser).Points.count - 1) '(Num_Readings - 1)
                    .HasDataLabel = True
                    .DataLabel.Text = lang_dict(112) '"Power Fully Open" ' & snme(1)
                    .DataLabel.Font.Name = "Arial"
                    .DataLabel.Font.size = 8
                    .DataLabel.Font.Italic = True
                    .DataLabel.Interior.ColorIndex = 2
                End With

                ser = ser + 1
                .SeriesCollection.NewSeries
                'If FrmCurveOptions.chkdidw.Value = False Then
                .SeriesCollection(ser).XValues = "=Datapoints!$s$9" 'Worksheets("Sheet1").Cells(9, 19).Value
                .SeriesCollection(ser).Values = "=Datapoints!$t$9" 'Worksheets("Sheet1").Cells(9, 19).Value
                'Else
                '    .SeriesCollection(a).XValues = Worksheets("Sheet1").Cells(10, 19).Value
                'End If
                .SeriesCollection(ser).AxisGroup = Excel.XlAxisGroup.xlPrimary
                .SeriesCollection(ser).Name = "Duty Point"
                .SeriesCollection(ser).MarkerStyle = Excel.XlMarkerStyle.xlMarkerStyleCircle
                .SeriesCollection(ser).MarkerForegroundColorIndex = 11    'dark blue
                .SeriesCollection(ser).MarkerBackgroundColorIndex = 11    'dark blue
                .SeriesCollection(ser).Border.ColorIndex = 3
                .SeriesCollection(ser).Border.LineStyle = Excel.XlLineStyle.xlDot
                With .SeriesCollection(ser).Points(1)
                    .HasDataLabel = True
                    .DataLabel.Text = lang_dict(125) '"Duty Point"
                    .DataLabel.Font.Name = "Arial"
                    .DataLabel.Font.size = 10
                    .DataLabel.Interior.ColorIndex = 2
                    .DataLabel.Font.Italic = True
                    .DataLabel.Font.ColorIndex = 1
                End With

                ser = ser + 1
                .SeriesCollection.NewSeries
                'If FrmCurveOptions.chkdidw.Value = False Then
                .SeriesCollection(ser).XValues = "=Datapoints!$s$9" 'Worksheets("Sheet1").Cells(9, 19).Value
                .SeriesCollection(ser).Values = "=Datapoints!$u$9" 'Worksheets("Sheet1").Cells(9, 19).Value
                'Else
                '    .SeriesCollection(a).XValues = Worksheets("Sheet1").Cells(10, 19).Value
                'End If
                .SeriesCollection(ser).AxisGroup = Excel.XlAxisGroup.xlSecondary
                .SeriesCollection(ser).Name = "Power Duty"
                .SeriesCollection(ser).MarkerStyle = Excel.XlMarkerStyle.xlMarkerStyleCircle
                .SeriesCollection(ser).MarkerForegroundColorIndex = 3    'dark red
                .SeriesCollection(ser).MarkerBackgroundColorIndex = 3    'dark red
                .SeriesCollection(ser).Border.ColorIndex = 3
                .SeriesCollection(ser).Border.LineStyle = Excel.XlLineStyle.xlDot
                With .SeriesCollection(ser).Points(1)
                    .HasDataLabel = True
                    .DataLabel.Text = lang_dict(125) ' "Duty Point"
                    .DataLabel.Font.Name = "Arial"
                    .DataLabel.Font.size = 10
                    .DataLabel.Interior.ColorIndex = 2
                    .DataLabel.Font.Italic = True
                    .DataLabel.Font.ColorIndex = 1
                End With

                .Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).HasTitle = True
                .Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).HasMajorGridlines = True
                .Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).MajorGridlines.Border.LineStyle = Excel.XlLineStyle.xlDashDot
                .Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).MajorGridlines.Border.Weight = Excel.XlBorderWeight.xlHairline
                .Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).MajorGridlines.Border.Color = RGB(150, 150, 150)
                .Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).AxisTitle.Caption = lang_dict(117) + " (" + Units(0).UnitName(Units(0).UnitSelected) + ")"
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
                    prtitle = lang_dict(118) + " (" + Units(1).UnitName(Units(1).UnitSelected) + ")"
                End If
                If FrmCurveOptions.optFTPonly.Checked = True Then
                    prtitle = lang_dict(119) + " (" + Units(1).UnitName(Units(1).UnitSelected) + ")"
                End If
                If FrmCurveOptions.optFSPandFTP.Checked = True Then
                    prtitle = lang_dict(124) + " (" + Units(1).UnitName(Units(1).UnitSelected) + ")"
                End If
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary).AxisTitle.Caption = prtitle
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary).AxisTitle.Font.Name = "Arial"
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary).AxisTitle.Font.size = 9
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary).TickLabels.Font.Name = "Arial"
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary).TickLabels.Font.size = 8
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary).TickLabels.Font.Italic = True

                '.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlSecondary).HasTitle = True
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlSecondary).HasTitle = True
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlSecondary).HasMajorGridlines = True
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlSecondary).MajorGridlines.Border.LineStyle = Excel.XlLineStyle.xlDashDot
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlSecondary).MajorGridlines.Border.Weight = Excel.XlBorderWeight.xlHairline
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlSecondary).MajorGridlines.Border.Color = RGB(150, 150, 150)
                .Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlSecondary).AxisTitle.Caption = lang_dict(120) + " (" + Units(4).UnitName(Units(4).UnitSelected) + ")"
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
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 80, 415, 600, 30).TextFrame.Characters.Text = lang_dict(16) '"All copyright in this document is vested in Halifax Fan Ltd. It contains proprietary information and may not be disclosed to any third party or reproduced in any form without the written permission of Halifax Fan Ltd."
                .Shapes(si + 1).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(si + 1).TextFrame.Characters.Font.size = 6

                'textbox 3 - engineer, etc
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 0, 460, 500, 14).TextFrame.Characters.Text = lang_dict(108) + Engineer + " " + lang_dict(15) + Date.Now.ToString("dd/MM/yyyy") + " " + lang_dict(109) 'DrawnBy
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
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 170, NN, 150, 20).TextFrame.Characters.Text = lang_dict(107)
                .Shapes(si + 6).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(si + 6).TextFrame.Characters.Font.size = 9 '9
                .Shapes(si + 6).TextFrame.Characters.Font.Bold = True
                '.Shapes(7).TextFrame.Characters.Font.Underline = True

                'textbox 8 - speed
                'If frmcurveoptions.Optsingle.Value = True Then
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 310, NN, 150, 20).TextFrame.Characters.Text = lang_dict(123) & vbTab & final.speed.ToString & " " & "RPM"
                .Shapes(si + 7).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(si + 7).TextFrame.Characters.Font.size = 9

                'textbox 9 - density
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 440, NN, 150, 20).TextFrame.Characters.Text = lang_dict(121) & vbTab & knowndensity.ToString & " " & Units(3).UnitName(Units(3).UnitSelected)
                .Shapes(si + 8).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(si + 8).TextFrame.Characters.Font.size = 9

                'textbox 10 - duty title
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 140, NN + 12, 150, 20).TextFrame.Characters.Text = lang_dict(122)
                .Shapes(si + 9).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(si + 9).TextFrame.Characters.Font.size = 9
                .Shapes(si + 9).TextFrame.Characters.Font.bold = True

                'textbox 11 - flow
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 170, NN + 12, 150, 20).TextFrame.Characters.Text = lang_dict(117) & vbTab & final.vol.ToString & " " & Units(0).UnitName(Units(0).UnitSelected)
                .Shapes(si + 10).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(si + 10).TextFrame.Characters.Font.size = 9

                'textbox 12 - pressure
                If PresType = 0 Then
                    .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 310, NN + 12, 150, 20).TextFrame.Characters.Text = lang_dict(118) & vbTab & final.fsp.ToString & " " & Units(1).UnitName(Units(1).UnitSelected)
                End If
                If PresType = 1 Then
                    .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 310, NN + 12, 150, 20).TextFrame.Characters.Text = lang_dict(119) & vbTab & final.fsp.ToString & " " & Units(1).UnitName(Units(1).UnitSelected)
                End If
                .Shapes(si + 11).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(si + 11).TextFrame.Characters.Font.size = 9

                'TextBox 13 - power
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 440, NN + 12, 150, 20).TextFrame.Characters.Text = lang_dict(120) & vbTab & final.pow.ToString & " " & Units(4).UnitName(Units(4).UnitSelected)
                .Shapes(si + 12).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(si + 12).TextFrame.Characters.Font.size = 9

                LastString = ""
                LastPosn = 372
                lastheight = 0

                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 425, NN + 36, 250, lastheight).TextFrame.Characters.Text = LastString
                .Shapes.AddShape(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 580, 0, 145, 30).Fill.UserPicture(DataPath + "header2015.jpg")
                .Shapes(.Shapes.count).Line.Visible = False
            End With

            If FrmCurveOptions.chkDamper.Checked = True Then
                ser = Chartdamper(xlsWB, ser)
                ser = Chartdamperpower(xlsWB, ser)
            End If
            If FrmCurveOptions.chkSystem.Checked = True Then
                ser = Chartfansystem(xlsWB, ser)
            End If
            'If FrmCurveOptions.optFSPonly.Checked = True Or FrmCurveOptions.optFTPonly.Checked = True Then
            '    deletecurveftp(xlsWB)
            'End If
            'xlsWB.Close(SaveChanges:=True)
            'xlsWB = Nothing
            'xlsWorkBooks.Close()
            'xlsWorkBooks = Nothing
            'xlsApp.Quit()
            'xlsApp = Nothing

        Catch ex As Exception
            ErrorMessage(ex, 6802)
        End Try

    End Sub

    Function Chartdamper(xlsWB, ser) As Integer
        Try
            'Dim countpts As Integer = CInt(Math.Round(Num_Readings * 0.33) + 1) + 9
            Dim DATASETS1 As Single


            DATASETS1 = Num_Readings * 0.33
            count = 1

            Do While count < DATASETS1
                count = count + 1
            Loop

            With xlsWB.ActiveChart '        With ActiveWorkbook.Charts("CHART1")
                ser = ser + 1
                .SeriesCollection.NewSeries
                .FullSeriesCollection(ser).Values = "=Datapoints!$b$" + (count + 9).ToString + ":$b$39"
                .FullSeriesCollection(ser).XValues = "=Datapoints!$f$" + (count + 9).ToString + ":$f$39"
                .SeriesCollection(ser).AxisGroup = Excel.XlAxisGroup.xlPrimary
                .SeriesCollection(ser).Name = "Damper 60º"
                .SeriesCollection(ser).MarkerStyle = Excel.XlMarkerStyle.xlMarkerStyleNone
                .SeriesCollection(ser).Border.ColorIndex = 41
                .SeriesCollection(ser).Border.Weight = Excel.XlBorderWeight.xlThin
                'With .SeriesCollection(ser).Points(.SeriesCollection(ser).Points.count)
                With .SeriesCollection(ser).Points(Num_Readings - (count + 1))
                    .HasDataLabel = True
                    .DataLabel.Text = lang_dict(110) + " 60º"
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
                    .DataLabel.Text = lang_dict(110) + " 50º"
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
                'With .SeriesCollection(ser).Points(.SeriesCollection(ser).Points.count)
                With .SeriesCollection(ser).Points(Num_Readings - (count + 1))
                    .HasDataLabel = True
                    .DataLabel.Text = lang_dict(110) + " 40º"
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
                'With .SeriesCollection(ser).Points(.SeriesCollection(ser).Points.count)
                With .SeriesCollection(ser).Points(Num_Readings - (count + 1))
                    .HasDataLabel = True
                    .DataLabel.Text = lang_dict(110) + " 30º"
                    .DataLabel.Font.Name = "Arial"
                    .DataLabel.Font.size = 8
                    .DataLabel.Interior.ColorIndex = 2
                    .DataLabel.Font.Italic = True
                    .DataLabel.Font.Color = RGB(255, 0, 0)
                End With

                .FullSeriesCollection(ser).Values = "=Datapoints!$b$" + (count + 9).ToString + ":$b$39"
                '.FullSeriesCollection(ser).Name = "=""Fan Curve"""
                .SeriesCollection(ser).Name = "FSP"
                .SeriesCollection(ser).Border.ColorIndex = 1
            End With
            'With ActiveChart.SeriesCollection(1).Points(datasets - 1)
            '    .HasDataLabel = True
            '    .DataLabel.Text = "Fully Open" & snme(1)
            '    .DataLabel.Font.Name = "Arial"
            '    .DataLabel.Font.size = 8
            '    .DataLabel.Font.Italic = True
            '    .DataLabel.Interior.ColorIndex = 2
            'End With
            Return ser

        Catch ex As Exception
            ErrorMessage(ex, 6803)

        End Try
        Return ser
    End Function

    Public Function Chartdamperpower(xlsWB, ser)
        Try
            'Dim countpts As Integer = CInt(Math.Round(Num_Readings * 0.33) + 1) + 9
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
                'With .SeriesCollection(ser).Points(.SeriesCollection(ser).Points.count)
                With .SeriesCollection(ser).Points(Num_Readings - (count + 1))
                    .HasDataLabel = True
                    .DataLabel.Text = lang_dict(120) + " 60º"
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
                'With .SeriesCollection(ser).Points(.SeriesCollection(ser).Points.count)
                With .SeriesCollection(ser).Points(Num_Readings - (count + 1))
                    .HasDataLabel = True
                    .DataLabel.Text = lang_dict(120) + " 50º"
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
                'With .SeriesCollection(ser).Points(.SeriesCollection(ser).Points.count)
                With .SeriesCollection(ser).Points(Num_Readings - (count + 1))
                    .HasDataLabel = True
                    .DataLabel.Text = lang_dict(120) + " 40º"
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
                'With .SeriesCollection(ser).Points(.SeriesCollection(ser).Points.count)
                With .SeriesCollection(ser).Points(Num_Readings - (count + 1))
                    .HasDataLabel = True
                    .DataLabel.Text = lang_dict(120) + " 30º"
                    .DataLabel.Font.Name = "Arial"
                    .DataLabel.Font.size = 8
                    .DataLabel.Interior.ColorIndex = 2
                    .DataLabel.Font.Italic = True
                    .DataLabel.Font.Color = RGB(255, 0, 0)
                End With
            End With

            'With ActiveChart.SeriesCollection(3).Points(datasets - 1)
            '    .HasDataLabel = True
            '    .DataLabel.Text = "Power Fully Open" & snme(1)
            '    .DataLabel.Font.Name = "Arial"
            '    .DataLabel.Font.size = 8
            '    .DataLabel.Font.Italic = True
            '    .DataLabel.Interior.ColorIndex = 2
            'End With

            Return ser

        Catch ex As Exception
            ErrorMessage(ex, 6804)

        End Try
        Return ser
    End Function

    Function Chartfansystem(xlsWB, ser) As Integer
        Try
            count = 0

            With xlsWB.ActiveChart '        With ActiveWorkbook.Charts("CHART1")
                ser = ser + 1
                .SeriesCollection.NewSeries
                .FullSeriesCollection(ser).Values = "=Datapoints!$l$9:$l$39"
                .FullSeriesCollection(ser).XValues = "=Datapoints!$k$9:$k$39"
                .SeriesCollection(ser).AxisGroup = Excel.XlAxisGroup.xlPrimary
                .SeriesCollection(ser).Name = "System Curve"
                .SeriesCollection(ser).MarkerStyle = Excel.XlMarkerStyle.xlMarkerStyleNone
                .SeriesCollection(ser).Border.ColorIndex = 1
                .SeriesCollection(ser).Border.LineStyle = Excel.XlLineStyle.xlDot
                'With .SeriesCollection(ser).Points(.SeriesCollection(ser).Points.count)
                With .SeriesCollection(ser).Points(Num_Readings - (count + 1))
                    .HasDataLabel = True
                    .DataLabel.Text = lang_dict(127)
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

    Public Sub deletecurveftp(xlsWB)
        Try
            sheet = "Chart"
            xlsWB.ActiveChart.Name = sheet
            With xlsWB.activechart
                Dim NN As Integer
                'If FrmCurveOptions.optFSPonly.Checked = True Or FrmCurveOptions.optFTPonly.Checked = True Then
                NN = PresType
                'If FrmCurveOptions.txtfanspd8.Visible = True Or FrmCurveOptions.txtgd8.Visible = True Then
                '    ActiveChart.SeriesCollection(23 - NN).Delete
                'End If
                'If FrmCurveOptions.txtfanspd7.Visible = True Or FrmCurveOptions.txtgd7.Visible = True Then
                '    ActiveChart.SeriesCollection(20 - NN).Delete
                'End If
                'If FrmCurveOptions.txtfanspd6.Visible = True Or FrmCurveOptions.txtgd6.Visible = True Then
                '    ActiveChart.SeriesCollection(17 - NN).Delete
                'End If
                'If FrmCurveOptions.txtfanspd5.Visible = True Or FrmCurveOptions.txtgd5.Visible = True Then
                '    ActiveChart.SeriesCollection(14 - NN).Delete
                'End If
                'If FrmCurveOptions.txtfanspd4.Visible = True Or FrmCurveOptions.txtgd4.Visible = True Then
                '    ActiveChart.SeriesCollection(11 - NN).Delete
                'End If
                'If FrmCurveOptions.txtfanspd3.Visible = True Or FrmCurveOptions.txtgd3.Visible = True Then
                '    ActiveChart.SeriesCollection(8 - NN).Delete
                'End If
                'If FrmCurveOptions.txtfanspd2.Visible = True Or FrmCurveOptions.txtgd2.Visible = True Then
                '    ActiveChart.SeriesCollection(5 - NN).Delete
                'End If
                .SeriesCollection(2 - NN).Delete
                'End If

            End With

        Catch ex As Exception
            ErrorMessage(ex, 6806)
        End Try

    End Sub


End Module
