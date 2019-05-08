Imports Excel = Microsoft.Office.Interop.Excel
Module ModPrintCurve
    Public Sub PopulatePrintoutChart_old(xlsWB)
        Try

            sheet = "Chart"
            xlsWB.ActiveChart.Name = sheet
            With xlsWB.ActiveChart
                .SeriesCollection(1).Name = "FSP " & "" 'snme(1)
                .SeriesCollection(2).Name = "FTP " & "" ' snme(1)
                .SeriesCollection(3).Name = "Power " & "" 'snme(1)
                'check for fan type frm dictionary
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
                If found = False Then
                    .ChartTitle.text = lang_dict(106) & " " & final.fansize.ToString & " " & final.fantypename & " " & lang_dict(3) & didw
                Else
                    .ChartTitle.text = lang_dict(106) & " " & final.fansize.ToString & " " & lang_dict(i) & " " & lang_dict(3) & didw
                End If

                .ChartTitle.Font.Name = "Arial"
                .ChartTitle.Font.size = 12
                .ChartTitle.Font.Bold = True
                .ChartTitle.Font.Underline = True
                .ChartTitle.Top = 20
                .HasLegend = False
                '.Axes(.xlCategory, .xlPrimary).AxisTitle.Caption = "abcdefg"
                '.Axes(.XlAxisType.xlValue, .XlAxisType.Primary).AxisTitle.Caption = "abcdefg" 'yaxistitle
                Dim LastString As String
                Dim LastPosn As Integer
                Dim lastheight As Integer

                Dim NN As Integer = 37
                Dim MM As Integer = 27
                ' shape 1 is the logo
                'textbox 2 - copyright
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 80, 415, 600, 30).TextFrame.Characters.Text = lang_dict(16) '"All copyright in this document is vested in Halifax Fan Ltd. It contains proprietary information and may not be disclosed to any third party or reproduced in any form without the written permission of Halifax Fan Ltd."
                .Shapes(2).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(2).TextFrame.Characters.Font.size = 6

                'textbox 3 - engineer, etc
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 0, 460, 500, 14).TextFrame.Characters.Text = lang_dict(108) + Engineer + " " + lang_dict(15) + Date.Now.ToString("dd/MM/yyyy") + " " + lang_dict(109) 'DrawnBy
                .Shapes(3).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(3).TextFrame.Characters.Font.size = 7

                'textbox 4 - company
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 580, MM, 120, 15).TextFrame.Characters.Text = cstring
                .Shapes(4).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(4).TextFrame.Characters.Font.size = 7

                'textbox 5 - address
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 580, MM + 8, 150, 25).TextFrame.Characters.Text = astring 'Address(1) & Chr(13) & Address(2)
                .Shapes(5).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(5).TextFrame.Characters.Font.size = 6
                .Shapes(5).TextFrame.Characters.Font.Italic = True

                'textbox 6 - email

                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 580, MM + 23, 150, 45).TextFrame.Characters.Text = estring + vbCr + tstring '"eemm" 'EmailName & TelNo
                .Shapes(6).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(6).TextFrame.Characters.Font.size = 7

                'textbox 7 - operating conditions
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 170, NN, 150, 20).TextFrame.Characters.Text = lang_dict(107)
                .Shapes(7).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(7).TextFrame.Characters.Font.size = 9 '9
                .Shapes(7).TextFrame.Characters.Font.Bold = True
                '.Shapes(7).TextFrame.Characters.Font.Underline = True

                'textbox 8 - speed
                'If frmcurveoptions.Optsingle.Value = True Then
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 310, NN, 150, 20).TextFrame.Characters.Text = lang_dict(123) & vbTab & final.speed.ToString & " " & "RPM"
                .Shapes(8).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(8).TextFrame.Characters.Font.size = 9

                'textbox 9 - density
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 440, NN, 150, 20).TextFrame.Characters.Text = lang_dict(121) & vbTab & knowndensity.ToString & " " & Units(3).UnitName(Units(3).UnitSelected)
                .Shapes(9).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(9).TextFrame.Characters.Font.size = 9

                'textbox 10 - duty title
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 140, NN + 12, 150, 20).TextFrame.Characters.Text = lang_dict(122)
                .Shapes(10).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(10).TextFrame.Characters.Font.size = 9
                .Shapes(10).TextFrame.Characters.Font.bold = True

                'textbox 11 - flow
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 170, NN + 12, 150, 20).TextFrame.Characters.Text = lang_dict(117) & vbTab & final.vol.ToString & " " & Units(0).UnitName(Units(0).UnitSelected)
                .Shapes(11).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(11).TextFrame.Characters.Font.size = 9

                'textbox 12 - pressure

                If PresType = 0 Then
                    .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 310, NN + 12, 150, 20).TextFrame.Characters.Text = lang_dict(118) & vbTab & final.fsp.ToString & " " & Units(1).UnitName(Units(1).UnitSelected)
                End If
                If PresType = 1 Then
                    .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 310, NN + 12, 150, 20).TextFrame.Characters.Text = lang_dict(119) & vbTab & final.fsp.ToString & " " & Units(1).UnitName(Units(1).UnitSelected)
                End If

                .Shapes(12).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(12).TextFrame.Characters.Font.size = 9

                'TextBox 13 - power
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 440, NN + 12, 150, 20).TextFrame.Characters.Text = lang_dict(120) & vbTab & final.pow.ToString & " " & Units(4).UnitName(Units(4).UnitSelected)
                .Shapes(13).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(13).TextFrame.Characters.Font.size = 9

                LastString = ""
                LastPosn = 372
                lastheight = 0

                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 425, NN + 36, 250, lastheight).TextFrame.Characters.Text = LastString
                '.Shapes.AddShape(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 580, 0, 145, 30).Fill.UserPicture(headerlocation)
                .Shapes(.Shapes.count).Line.Visible = False
            End With
            If FrmCurveOptions.optFSPonly.Checked = True Or FrmCurveOptions.optFTPonly.Checked = True Then
                deletecurveftp(xlsWB)
            End If

            With xlsWB.ActiveChart
                Dim axis As Excel.Axis
                axis = CType(.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary), Excel.Axis)
                axis.HasTitle = True

                If FrmCurveOptions.optFSPonly.Checked = True Then
                    axis.AxisTitle.Text = lang_dict(118) + " (" + Units(1).UnitName(Units(1).UnitSelected) + ")"
                End If
                If FrmCurveOptions.optFTPonly.Checked = True Then
                    axis.AxisTitle.Text = lang_dict(119) + " (" + Units(1).UnitName(Units(1).UnitSelected) + ")"
                End If
                If FrmCurveOptions.optFSPandFTP.Checked = True Then
                    axis.AxisTitle.Text = lang_dict(124) + " (" + Units(1).UnitName(Units(1).UnitSelected) + ")"
                End If


                axis = CType(.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlSecondary), Excel.Axis)
                axis.HasTitle = True
                axis.AxisTitle.Text = lang_dict(120) + " (" + Units(4).UnitName(Units(4).UnitSelected) + ")"

                axis = CType(.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary), Excel.Axis)
                axis.HasTitle = True
                axis.AxisTitle.Text = lang_dict(117) + " (" + Units(0).UnitName(Units(0).UnitSelected) + ")"
            End With
        Catch ex As Exception
            ErrorMessage(ex, 64031)
        End Try

    End Sub

    Sub PopulatePrintoutChart(xlsWB)
        Try
            'Dim xlsApp As Excel.Application = Nothing
            'Dim xlsWorkBooks As Excel.Workbooks = Nothing
            ''Dim xlsWB As Excel.Workbook = Nothing

            'Dim NewFileName As String = "C:\Halifax\Projects\Test CBC.xlsx"
            ''open the excel file
            'xlsApp = New Microsoft.Office.Interop.Excel.Application
            'xlsApp.Visible = False
            'xlsWorkBooks = xlsApp.Workbooks

            'xlsWB = xlsWorkBooks.Open(NewFileName)

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
            'With xlsWB.ActiveSheet
            'title

            sheet = "Chart"
            xlsWB.ActiveChart.Name = sheet
            xlsWB.ActiveSheet.Shapes.AddChart2(240, Excel.XlChartType.xlXYScatterSmoothNoMarkers).Select

            With xlsWB.ActiveChart
                '.SetElement.Microsoft.Office.Core.MsoChartElementType.msoElementChartTitleAboveChart
                'Dim myChart As Microsoft.Office.Tools.Excel.Chart

                '.ChartTitle.SetElement(Microsoft.Office.Core.MsoChartElementType.msoElementChartTitleAboveChart)
                '.ChartTitle.Text = "abcdefg"
                '.Format.TextFrame2.TextRange.Characters.Text = "abcdefg"
                If found = False Then
                    .ChartTitle.Text = lang_dict(75) & " " & final.fansize.ToString & " " & final.fantypename & " " & lang_dict(3) & didw
                Else
                    .ChartTitle.Text = lang_dict(75) & " " & final.fansize.ToString & " " & lang_dict(i) & " " & lang_dict(3) & didw
                End If

                '.charttitle.text =
                .ChartTitle.Font.Name = "Arial"
                .ChartTitle.Font.Size = 12
                .ChartTitle.Font.Bold = True
                .ChartTitle.Font.Underline = True
                .ChartTitle.Top = 2

                .PlotArea.Interior.Color = RGB(245, 255, 245)


                .HasLegend = False
                .ChartArea.Width = 730
                .ChartArea.Height = 475
                .PlotArea.Border.LineStyle = Excel.XlLineStyle.xlContinuous
                .PlotArea.Border.Weight = Excel.XlBorderWeight.xlMedium
                .PlotArea.Height = 375 '375
                .PlotArea.Width = 650 '650
                .PlotArea.Top = 70
                .PlotArea.Left = 40
                Dim ser As Integer = 0
                If FrmCurveOptions.optFSPonly.Checked = True Or FrmCurveOptions.optFSPandFTP.Checked = True Then
                    ser = ser + 1
                    .SeriesCollection.NewSeries
                    .FullSeriesCollection(ser).XValues = "=Datapoints!$A$9:$A$30"
                    .FullSeriesCollection(ser).Values = "=Datapoints!$b$9:$b$30"
                    '.FullSeriesCollection(ser).Name = "=""Fan Curve"""
                    .SeriesCollection(ser).Name = "FSP"
                    .SeriesCollection(ser).Border.ColorIndex = 1
                End If

                If FrmCurveOptions.optFTPonly.Checked = True Or FrmCurveOptions.optFSPandFTP.Checked = True Then
                    ser = ser + 1
                    .SeriesCollection.NewSeries
                    .FullSeriesCollection(ser).XValues = "=Datapoints!$A$9:$A$30"
                    .FullSeriesCollection(ser).Values = "=Datapoints!$c$9:$c$30"
                    .SeriesCollection(ser).Name = "FTP"
                    .SeriesCollection(ser).Border.ColorIndex = 1
                End If

                ser = ser + 1
                .SeriesCollection.NewSeries
                .FullSeriesCollection(ser).XValues = "=Datapoints!$A$9:$A$30"
                .FullSeriesCollection(ser).Values = "=Datapoints!$d$9:$d$30"
                .SeriesCollection(ser).Name = "Power " & "" 'snme(1)
                .SeriesCollection(ser).AxisGroup = Excel.XlAxisGroup.xlSecondary

                .SeriesCollection(ser).Border.ColorIndex = 1
                .SeriesCollection(ser).Border.LineStyle = Excel.XlLineStyle.xlDash

                .Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).HasTitle = True
                .Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).HasMajorGridlines = True
                .Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).MajorGridlines.Border.LineStyle = Excel.XlLineStyle.xlDashDot
                .Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).MajorGridlines.Border.Weight = Excel.XlBorderWeight.xlHairline
                .Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).MajorGridlines.Border.Color = RGB(150, 150, 150)
                '.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary).AxisTitle.Caption = yaxistitle + "Numpty Pressure"
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
                '.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary).AxisTitle.Caption = yaxistitle + "Numpty Pressure"
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
                '.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlSecondary).AxisTitle.Caption = y2axistitle + "Numpty Power"
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
            MsgBox(ex.Message)
        End Try


    End Sub

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
            ErrorMessage(ex, 64031)
        End Try

    End Sub


End Module
