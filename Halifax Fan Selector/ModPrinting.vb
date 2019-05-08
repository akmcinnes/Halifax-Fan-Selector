'Imports Word = Microsoft.Office.Interop.Word
Imports Excel = Microsoft.Office.Interop.Excel
'Imports Microsoft.Office.Interop.Excel.Constants

'Imports Microsoft.Office
'Imports System.IO
'Imports System.Resources
'Imports System.Xml
'Imports System.Windows.Forms
'Imports System.Drawing.Printing
Imports System.IO

Module ModPrinting
    Public xlsApp As Excel.Application = Nothing
    Public xlsWorkBooks As Excel.Workbooks = Nothing
    Public xlsWB As Excel.Workbook = Nothing
    Sub CreateFile(PagesToPrint As Integer)
        Try
            'read the language dictionary
            'set cursor
            If PagesToPrint = 3 Or PagesToPrint = 0 Then
                FrmCurveOptions.ShowDialog()
            End If
            getLanguageDictionary()
            Frmselectfan.Cursor = Cursors.WaitCursor
            Dim MasterFile As String = TemplatesPathDefault + "Output Template New.xlsx"
            Dim NewFileName As String
            NewFileName = OpenFileName.Replace(".hfs", ".xlsx")
            My.Computer.FileSystem.CopyFile(MasterFile, NewFileName, overwrite:=True)
            Dim filename_printout As String = NewFileName
            'open the excel file
            Frmselectfan.Cursor = Cursors.WaitCursor
            xlsWB = xlsWorkBooks.Open(filename_printout)

            'Dim ws As Excel.Worksheet
            'ws = xlsWB.Worksheets.Add(After:=xlsWB.Worksheets(1))
            'ws.Name = "Chart 1"
            'ws = Nothing


            'make the sheets visible/hidden
            Dim isheet As Integer
            For isheet = 1 To xlsWB.Sheets.Count
                xlsWB.Sheets(isheet).Visible = Excel.XlSheetVisibility.xlSheetVisible
            Next
            'xlsWB.Worksheets("Chart 1").Activate

            ''xlsWB.ChartWizard(Source:=xlsWB.Worksheets("Datapoints").Range("a9:d39"), gallery:=xlsWB.Worksheets("Chart 1").ChartObjects.XlChartType.xlXYScatter, title:="Halifax No." & "curvefanname" & "cnztitle" & "DIDWtxt" & " Performance Curve")
            ''xlsWB.PlotBy = xlsWB.XlChartType.xlColumns
            ''xlsWB.ChartType = xlsWB.XlChartType.xlXYScatterSmoothNoMarkers

            'Dim charts As Excel.ChartObjects = CType(xlsWB.ChartObjects(), Excel.ChartObjects)


            '' Adds a chart at x = 100, y = 300, 500 points wide and 300 tall.
            'Dim chartObj As Excel.ChartObject = charts.Add(100, 300, 500, 300)
            'Dim chart As Excel.Chart = chartObj.Chart

            '' Gets the cells that define the bounds of the data to be charted.
            'Dim chartRange As Excel.Range = xlsWB.Range("A2", "B8")
            'chart.SetSourceData(chartRange)

            'chart.ChartType = Excel.XlChartType.xlXYScatter
            'Dim series As Excel.Series
            'Dim seriesCollection As Excel.SeriesCollection = CType(chart.SeriesCollection(), Excel.SeriesCollection)
            'series = seriesCollection.Item(seriesCollection.Count)

            Select Case PagesToPrint
                Case 0 'all pages
                    xlsWB.Worksheets("Performance").Activate
                    PopulatePrintoutPerformance(xlsWB)
                    xlsWB.Worksheets("Sound").Activate
                    PopulatePrintoutSound(xlsWB)
                    xlsWB.Worksheets("Datapoints").Activate
                    PopulatePrintoutDatapoints(xlsWB)
                    xlsWB.Charts("Chart").Activate
                    PopulatePrintoutChart(xlsWB)
                Case 1 'performance details
                    xlsWB.Worksheets("Performance").Activate
                    PopulatePrintoutPerformance(xlsWB)
                    'xlsWB.Worksheets("Datapoints").Activate
                    'PopulatePrintoutDatapoints(xlsWB)
                Case 2 'acoustic details
                    xlsWB.Worksheets("Sound").Activate
                    PopulatePrintoutSound(xlsWB)
                Case 3
                    xlsWB.Worksheets("Datapoints").Activate
                    PopulatePrintoutDatapoints(xlsWB)
                    xlsWB.Charts("Chart").Activate
                    PopulatePrintoutChart(xlsWB)
            End Select

            Select Case PagesToPrint
                Case 0
                    xlsWB.Sheets("Datapoints").Visible = Excel.XlSheetVisibility.xlSheetHidden
                Case 1
                    xlsWB.Sheets("Datapoints").Visible = Excel.XlSheetVisibility.xlSheetHidden
                    xlsWB.Sheets("Chart").Visible = Excel.XlSheetVisibility.xlSheetHidden
                    xlsWB.Sheets("Sound").Visible = Excel.XlSheetVisibility.xlSheetHidden
                Case 2
                    xlsWB.Sheets("Datapoints").Visible = Excel.XlSheetVisibility.xlSheetHidden
                    xlsWB.Sheets("Chart").Visible = Excel.XlSheetVisibility.xlSheetHidden
                    xlsWB.Sheets("Performance").Visible = Excel.XlSheetVisibility.xlSheetHidden
                Case 3
                    xlsWB.Sheets("Datapoints").Visible = Excel.XlSheetVisibility.xlSheetHidden
                    xlsWB.Sheets("Performance").Visible = Excel.XlSheetVisibility.xlSheetHidden
                    xlsWB.Sheets("Sound").Visible = Excel.XlSheetVisibility.xlSheetHidden
                Case Else
            End Select
            'export the excel file
            ExporttoPDFPO(xlsWB)
            'close the excel file
            xlsWB.Close(SaveChanges:=True)
            xlsWB = Nothing
            xlsWorkBooks.Close()
            xlsWorkBooks = Nothing
            xlsApp.Quit()
            xlsApp = Nothing
            Frmselectfan.Cursor = Cursors.Default
        Catch ex As Exception
            ErrorMessage(ex, 20420)
        End Try
    End Sub

    Public Sub getLanguageDictionary()
        Try
            ' read language dictionary
            Dim filename_lang_dict As String = TemplatesPathDefault + "Halifax Output Dictionary.xlsx"
            xlsApp = New Microsoft.Office.Interop.Excel.Application
            xlsApp.Visible = False
            xlsWorkBooks = xlsApp.Workbooks
            xlsWB = xlsWorkBooks.Open(filename_lang_dict)
            Dim ii As Integer
            For ii = 1 To 250
                lang_dict(ii) = xlsWB.Worksheets(ChosenLanguage).Cells(ii, 1).Value
                lang_dictEN(ii) = xlsWB.Worksheets(ChosenLanguage).Cells(ii, 2).Value
            Next
            xlsWB.Close(SaveChanges:=False)
            Select Case ChosenSite
                Case 0
                    cstring = lang_dict(17)
                    astring = lang_dict(18)
                    tstring = lang_dict(19)
                    estring = lang_dict(20)
                Case 1
                    cstring = lang_dict(22)
                    astring = lang_dict(23)
                    tstring = lang_dict(24)
                    estring = lang_dict(29)
                Case 2
                    cstring = lang_dict(22)
                    astring = lang_dict(25)
                    tstring = lang_dict(26)
                    estring = lang_dict(29)
                Case 3
                    cstring = lang_dict(22)
                    astring = lang_dict(27)
                    tstring = lang_dict(28)
                    estring = lang_dict(29)
                Case Else
                    cstring = lang_dict(17)
                    astring = lang_dict(18)
                    tstring = lang_dict(19)
                    estring = lang_dict(20)
            End Select



        Catch ex As Exception
            ErrorMessage(ex, 64021)
        End Try
    End Sub




    'Public Sub PopulatePrintoutChart(xlsWB)
    '    Try
    '        sheet = "Chart"
    '        xlsWB.ActiveChart.Name = sheet
    '        'With xlsWB.ActiveSheet
    '        '.axis(xaxistitle) = "Numpty Volume"
    '        '.axis(yaxistitle) = "Numpty Pressure"
    '        '.axis(y2axistitle) = "Numpty Power"

    '        'With xlsWB.ActiveChart.SeriesCollection(1).Points(1)
    '        '    .HasDataLabel = True
    '        '    .DataLabel.Text = "Pressure " & "RPM" 'snme(1)
    '        '    .DataLabel.Font.Name = "Arial"
    '        '    .DataLabel.Font.size = 10
    '        '    .DataLabel.Font.Italic = True
    '        '    .DataLabel.Interior.ColorIndex = 2
    '        '    .DataLabel.Top = .DataLabel.Top - 10
    '        '    .DataLabel.Left = .DataLabel.Left + 10
    '        'End With
    '        'With xlsWB.ActiveChart.SeriesCollection(2).Points(1)
    '        '    .HasDataLabel = True
    '        '    .DataLabel.Text = "Pressure " & "RPM" 'snme(1)
    '        '    .DataLabel.Font.Name = "Arial"
    '        '    .DataLabel.Font.size = 10
    '        '    .DataLabel.Interior.ColorIndex = 2
    '        '    .DataLabel.Font.Italic = True
    '        '    .DataLabel.Top = .DataLabel.Top - 10
    '        '    .DataLabel.Left = .DataLabel.Left + 10
    '        'End With
    '        'With xlsWB.ActiveChart.SeriesCollection(3).Points(20) '(datasets - 1)
    '        '    .HasDataLabel = True
    '        '    .DataLabel.Text = "Power " & "RPM" 'snme(1)
    '        '    .DataLabel.Font.Name = "Arial"
    '        '    .DataLabel.Font.size = 10
    '        '    .DataLabel.Interior.ColorIndex = 2
    '        '    .DataLabel.Font.Italic = True
    '        '    .DataLabel.Top = .DataLabel.Top - 10
    '        '    .DataLabel.Left = .DataLabel.Left - 20
    '        'End With

    '        '####################################
    '        With xlsWB.ActiveChart
    '            '                .ChartWizard Source:=Worksheets("Sheet1").Range("a9:d39"),
    '            '            gallery:=xlXYScatter, title:="Halifax No." & curvefanname & cnztitle & DIDWtxt & " Performance Curve"
    '            ''            gallery:=xlXYScatter, title:="Halifax No." & curvefanname & cnztitle & DIDWtxt & " Performance Curve"
    '            '                .PlotBy = xlColumns
    '            '                .ChartType = xlXYScatterSmoothNoMarkers

    '            .SeriesCollection(1).Name = "FSP " & "" 'snme(1)
    '            .SeriesCollection(2).Name = "FTP " & "" ' snme(1)
    '            .SeriesCollection(3).Name = "Power " & "" 'snme(1)
    '            '.SeriesCollection(3).AxisGroup = .xlSecondary
    '            '.Excel.Axes(.xlValue, .xlPrimary).HasTitle = True
    '            '.Axes(xlValue, xlPrimary).HasMajorGridlines = True
    '            '.Axes(xlValue, xlPrimary).MajorGridlines.Border.LineStyle = .xlDashDot
    '            '.Axes(xlValue, xlPrimary).MajorGridlines.Border.Weight = xlHairline
    '            '.Axes(xlValue, xlPrimary).MajorGridlines.Border.Color = RGB(150, 150, 150)
    '            '.excel.Axes(.xlValue, .xlPrimary).AxisTitle.Caption = yaxistitle + "Numpty Pressure"
    '            'If frmcurveoptions.optsucy.Value = True Then
    '            '    .Axes(xlValue, xlPrimary).AxisTitle.Caption = "SUCTION " & yaxistitle
    '            'End If
    '            '.Axes(xlValue, xlSecondary).HasTitle = True
    '            '.Axes(.xlValue, .xlSecondary).AxisTitle.Caption = y2axistitle + "Numpty Power"
    '            '.Axes(xlCategory, xlPrimary).HasTitle = True
    '            '.Axes(xlCategory, xlPrimary).HasMajorGridlines = True
    '            '.Axes(xlCategory, xlPrimary).MajorGridlines.Border.LineStyle = xlDashDot
    '            '.Axes(xlCategory, xlPrimary).MajorGridlines.Border.Weight = xlHairline
    '            '.Axes(xlCategory, xlPrimary).MajorGridlines.Border.Color = RGB(150, 150, 150)

    '            'check for fan type frm dictionary
    '            Dim i As Integer
    '            Dim found As Boolean = False
    '            For i = 141 To 170
    '                If final.fantypename = lang_dictEN(i) Then
    '                    found = True
    '                    Exit For
    '                End If
    '            Next
    '            Dim didw As String = ""
    '            If SelectDIDW = True Then didw = " (DIDW)"
    '            'title
    '            If found = False Then
    '                .ChartTitle.text = lang_dict(106) & " " & final.fansize.ToString & " " & final.fantypename & " " & lang_dict(3) & didw
    '            Else
    '                .ChartTitle.text = lang_dict(106) & " " & final.fansize.ToString & " " & lang_dict(i) & " " & lang_dict(3) & didw
    '            End If

    '            .ChartTitle.Font.Name = "Arial"
    '            .ChartTitle.Font.size = 12
    '            .ChartTitle.Font.Bold = True
    '            .ChartTitle.Font.Underline = True
    '            .ChartTitle.Top = 20
    '            '.Axes(.xlCategory) = xaxistitle + "Numpty Flow"
    '            '.axes.primary.text = "xaxis"
    '            '.Axes(xlValue, xlPrimary).AxisTitle.Font.Name = "Arial"
    '            '.Axes(xlValue, xlPrimary).AxisTitle.Font.size = 9
    '            '.Axes(xlValue, xlSecondary).AxisTitle.Font.Name = "Arial"
    '            '.Axes(xlValue, xlSecondary).AxisTitle.Font.size = 9
    '            '.Axes(xlCategory, xlPrimary).AxisTitle.Font.Name = "Arial"
    '            '.Axes(xlCategory, xlPrimary).AxisTitle.Font.size = 9


    '            '.Axes(xlValue, xlPrimary).TickLabels.Font.Name = "Arial"
    '            '.Axes(xlValue, xlPrimary).TickLabels.Font.size = 8
    '            '.Axes(xlValue, xlPrimary).TickLabels.Font.Italic = True
    '            '.Axes(xlValue, xlSecondary).TickLabels.Font.Name = "Arial"
    '            '.Axes(xlValue, xlSecondary).TickLabels.Font.size = 8
    '            '.Axes(xlValue, xlSecondary).TickLabels.Font.Italic = True
    '            '.Axes(xlCategory, xlPrimary).TickLabels.Font.Name = "Arial"
    '            '.Axes(xlCategory, xlPrimary).TickLabels.Font.size = 8
    '            '.Axes(xlCategory, xlPrimary).TickLabels.Font.Italic = True

    '            '.PlotArea.Interior.Color = RGB(245, 255, 245)

    '            '.SeriesCollection(1).Border.ColorIndex = 1
    '            '.SeriesCollection(2).Border.ColorIndex = 1
    '            '.SeriesCollection(3).Border.ColorIndex = 1
    '            '.SeriesCollection(3).Border.LineStyle = xlDash

    '            .HasLegend = False
    '            'aa = .ChartArea.Width = 730
    '            'bb = .ChartArea.Height = 475
    '            '.PlotArea.Border.LineStyle = xlContinuous
    '            '.PlotArea.Border.Weight = xlMedium
    '            '.PlotArea.Height = 375
    '            '.PlotArea.Width = 650
    '            '.PlotArea.Top = 70
    '            '.PlotArea.Left = 40
    '            'Dim TelNo, EmailName, Address(2), LastString As String
    '            Dim LastString As String
    '            Dim LastPosn As Integer
    '            Dim lastheight As Integer

    '            Dim NN As Integer = 37
    '            Dim MM As Integer = 27
    '            'TelNo = lang_dict(19) ' & ThisWorkbook.Sheets("REF").Cells(6, 2)
    '            'EmailName = lang_dict(20) ' & ThisWorkbook.Sheets("REF").Cells(7, 2)
    '            'Address(1) = lang_dict(17) 'ThisWorkbook.Sheets("REF").Cells(9, 2)
    '            'Address(2) = lang_dict(18) 'ThisWorkbook.Sheets("REF").Cells(10, 2)



    '            'textbox 1 - operating conditions
    '            .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 180, NN, 150, 20).TextFrame.Characters.Text = lang_dict(107)
    '            .Shapes(1).TextFrame.Characters.Font.Name = "Arial"
    '            .Shapes(1).TextFrame.Characters.Font.size = 12 '9
    '            '.Shapes(1).TextFrame.Characters.Font.Bold = True
    '            '.Shapes(1).TextFrame.Characters.Font.Underline = True

    '            'textbox 2 - engineer, etc
    '            .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 0, 460, 500, 14).TextFrame.Characters.Text = lang_dict(108) + Engineer + " " + lang_dict(15) + Date.Now.ToString("dd/MM/yyyy") + " " + lang_dict(109) 'DrawnBy
    '            .Shapes(2).TextFrame.Characters.Font.Name = "Arial"
    '            .Shapes(2).TextFrame.Characters.Font.size = 7
    '            .Shapes(2).TextFrame.Characters.Font.Italic = True

    '            'textbox 3 - company
    '            .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 580, MM, 120, 15).TextFrame.Characters.Text = lang_dict(17)
    '            .Shapes(3).TextFrame.Characters.Font.Name = "Arial"
    '            .Shapes(3).TextFrame.Characters.Font.size = 7

    '            'textbox 4 - address
    '            .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 580, MM + 8, 150, 25).TextFrame.Characters.Text = lang_dict(18) 'Address(1) & Chr(13) & Address(2)
    '            .Shapes(4).TextFrame.Characters.Font.Name = "Arial"
    '            .Shapes(4).TextFrame.Characters.Font.size = 6
    '            .Shapes(4).TextFrame.Characters.Font.Italic = True

    '            'textbox 5 - email
    '            .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 580, MM + 23, 150, 45).TextFrame.Characters.Text = lang_dict(20) + vbCr + lang_dict(19) '"eemm" 'EmailName & TelNo
    '            .Shapes(5).TextFrame.Characters.Font.Name = "Arial"
    '            .Shapes(5).TextFrame.Characters.Font.size = 7

    '            'textbox 6 - copyright
    '            .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 80, 415, 600, 30).TextFrame.Characters.Text = lang_dict(16) '"All copyright in this document is vested in Halifax Fan Ltd. It contains proprietary information and may not be disclosed to any third party or reproduced in any form without the written permission of Halifax Fan Ltd."
    '            .Shapes(6).TextFrame.Characters.Font.Name = "Arial"
    '            .Shapes(6).TextFrame.Characters.Font.size = 6

    '            'textbox 7 - speed
    '            'If frmcurveoptions.Optsingle.Value = True Then
    '            .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 300, NN, 150, 20).TextFrame.Characters.Text = lang_dict(8) & final.speed.ToString & "RPM"
    '            .Shapes(7).TextFrame.Characters.Font.Name = "Arial"
    '            .Shapes(7).TextFrame.Characters.Font.size = 9

    '            'textbox 8 - density
    '            .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 420, NN, 150, 20).TextFrame.Characters.Text = lang_dict(9) & knowndensity.ToString & Units(3).UnitName(Units(3).UnitSelected)
    '            .Shapes(8).TextFrame.Characters.Font.Name = "Arial"
    '            .Shapes(8).TextFrame.Characters.Font.size = 9
    '            'End If
    '            'If frmcurveoptions.OptMD.Value = True Then
    '            '    .Shapes.AddTextbox(.msoTextOrientationHorizontal, 300, NN, 150, 20).TextFrame.Characters.Text = " Fan Speed - " & frmcurveoptions.txtfanspd1.Value & "RPM"
    '            '    .Shapes.AddTextbox(.msoTextOrientationHorizontal, 420, NN, 150, 20).TextFrame.Characters.Text = "Multiple Gas Densities"
    '            'End If
    '            'If frmcurveoptions.OptMS.Value = True Then
    '            '    .Shapes.AddTextbox(.msoTextOrientationHorizontal, 300, NN, 150, 20).TextFrame.Characters.Text = "Multiple Fan Speeds"
    '            '    .Shapes.AddTextbox(.msoTextOrientationHorizontal, 420, NN, 150, 20).TextFrame.Characters.Text = " Gas Density - " & frmcurveoptions.txtgd1.Value & Frmselectfan.Comairdenunits.Text
    '            'End If

    '            'textbox 9 - duty title
    '            .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 140, NN + 12, 150, 20).TextFrame.Characters.Text = "Duty : - "
    '            .Shapes(9).TextFrame.Characters.Font.size = 9
    '            .Shapes(9).TextFrame.Characters.Font.Bold = True

    '            'textbox 10 - flow
    '            .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 180, NN + 12, 150, 20).TextFrame.Characters.Text = " Volume - " & final.vol.ToString & Units(0).UnitName(Units(0).UnitSelected)
    '            .Shapes(10).TextFrame.Characters.Font.Name = "Arial"
    '            .Shapes(10).TextFrame.Characters.Font.size = 9

    '            'textbox 11 - pressure
    '            .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 300, NN + 12, 150, 20).TextFrame.Characters.Text = " " & "Static Press - " & final.fsp.ToString & Units(1).UnitName(Units(1).UnitSelected)
    '            .Shapes(11).TextFrame.Characters.Font.Name = "Arial"
    '            .Shapes(11).TextFrame.Characters.Font.size = 9

    '            'TextBox 12 - power
    '            .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 420, NN + 12, 150, 20).TextFrame.Characters.Text = " Power - " & final.pow.ToString & Units(4).UnitName(Units(4).UnitSelected)
    '            .Shapes(12).TextFrame.Characters.Font.Name = "Arial"
    '            .Shapes(12).TextFrame.Characters.Font.size = 9

    '            LastString = ""
    '            LastPosn = 372
    '            LastHeight = 0
    '            'If frmcurveoptions.Optsucy.Value = True Then
    '            '    LastString = LastString & "NOMINAL GAS DENSITY CORRECTED FOR SUCTION"
    '            '    LastPosn = LastPosn - 80
    '            '    LastHeight = LastHeight + 20
    '            'End If
    '            'If frmcurveoptions.Chkdamper.Value = True Then
    '            '    LastString = LastString & "   WITH DAMPER PERFORMANCE CURVE"
    '            '    LastPosn = LastPosn - 80
    '            '    LastHeight = LastHeight + 20
    '            'End If
    '            .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 425, NN + 36, 250, lastheight).TextFrame.Characters.Text = LastString
    '            .Shapes(9).TextFrame.Characters.Font.Name = "Arial"
    '            .Shapes(9).TextFrame.Characters.Font.size = 9
    '            '.Shapes.AddShape(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 580, 0, 145, 30).Fill.UserPicture(headerlocation)
    '            .Shapes(.Shapes.count).Line.Visible = False




    '        End With

    '        'With xlsWB.ActiveChart.SeriesCollection(1).Points(1)
    '        '    .HasDataLabel = True
    '        '    .DataLabel.Text = "Pressure " & snme(1)
    '        '    .DataLabel.Font.Name = "Arial"
    '        '    .DataLabel.Font.size = 10
    '        '    .DataLabel.Font.Italic = True
    '        '    .DataLabel.Interior.ColorIndex = 2
    '        '    .DataLabel.Top = .DataLabel.Top - 10
    '        '    .DataLabel.Left = .DataLabel.Left + 10
    '        'End With
    '        'With xlsWB.ActiveChart.SeriesCollection(2).Points(1)
    '        '    .HasDataLabel = True
    '        '    .DataLabel.Text = "Pressure " & snme(1)
    '        '    .DataLabel.Font.Name = "Arial"
    '        '    .DataLabel.Font.size = 10
    '        '    .DataLabel.Interior.ColorIndex = 2
    '        '    .DataLabel.Font.Italic = True
    '        '    .DataLabel.Top = .DataLabel.Top - 10
    '        '    .DataLabel.Left = .DataLabel.Left + 10
    '        'End With
    '        'With xlsWB.ActiveChart.SeriesCollection(3).Points(datasets - 1)
    '        '    .HasDataLabel = True
    '        '    .DataLabel.Text = "Power " & snme(1)
    '        '    .DataLabel.Font.Name = "Arial"
    '        '    .DataLabel.Font.size = 10
    '        '    .DataLabel.Interior.ColorIndex = 2
    '        '    .DataLabel.Font.Italic = True
    '        '    .DataLabel.Top = .DataLabel.Top - 10
    '        '    .DataLabel.Left = .DataLabel.Left - 20
    '        'End With
    '        'With xlsWB.ActiveChart
    '        '    .SeriesCollection(1).HasLeaderLines = False
    '        '    .SeriesCollection(2).HasLeaderLines = False
    '        '    .SeriesCollection(3).HasLeaderLines = False
    '        '    '.ChartArea.Border.LineStyle = xlNone
    '        'End With


    '        'End With
    '    Catch ex As Exception
    '        ErrorMessage(ex, 64031)
    '    End Try

    'End Sub



    Public Sub SetupPagePO(xlsWB As Excel.Workbook, Optional cellwidth As Integer = 5)
        xlsWB.ActiveSheet.Name = sheet
        With xlsWB.ActiveSheet
            .Range("A1:Z250").Font.Name = "Arial"
            .Range("A1:Z250").Font.size = 10
            .Range("A1:Z250").WrapText = False
            .Columns("A:Z").ColumnWidth = cellwidth
        End With
    End Sub

    Public Sub OutputHeaderPO(xlsWB)
        xlsWB.ActiveSheet.Name = sheet
        PlaceData(xlsWB, sheet, cstring, 1, 1, True,,,,,,, 11) 'company name
        PlaceData(xlsWB, sheet, astring, 2, 1,, True,,,,,, 8) 'company address
        PlaceData(xlsWB, sheet, lang_dict(21), 3, 1,,,,,,,, 8) 'company
        PlaceData(xlsWB, sheet, estring, 4, 1,,,,,,,, 8, False) 'company email
        PlaceData(xlsWB, sheet, tstring, 4, 5,,,,,,,, 8, False) 'company phone
    End Sub

    Public Sub OutputFooterPO(xlsWB)
        Try
            xlsWB.ActiveSheet.Name = sheet
            PlaceData(xlsWB, sheet, lang_dict(14) & " " & Engineer, 46, 1, ,,,,,,, 9) 'engineer
            PlaceData(xlsWB, sheet, lang_dict(15) & " " & Date.Now.ToString("dd/MM/yyyy HH:mm"), 46, 10, ,,,,,,, 9) 'date
            PlaceData(xlsWB, sheet, lang_dict(16), 47, 1, ,,,,,,, 7,, 1) 'legal bit
        Catch ex As Exception
            ErrorMessage(ex, 640329)
        End Try
    End Sub

    Public Sub OutputFanDetailsPO(xlsWB, sheetnum)
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
        Select Case sheetnum
            Case 1
                xlsWB.ActiveSheet.Name = sheet
                With xlsWB.ActiveSheet
                    'title
                    If found = False Then
                        PlaceData(xlsWB, sheet, lang_dict(75) & " " & final.fansize.ToString & " " & final.fantypename & " " & lang_dict(3) & didw, 7, 1, True,, True, 7, 1, 7, 16, 11,, 3) 'company name
                    Else
                        PlaceData(xlsWB, sheet, lang_dict(75) & " " & final.fansize.ToString & " " & lang_dict(i) & " " & lang_dict(3) & didw, 7, 1, True,, True, 7, 1, 7, 16, 11,, 3) 'company name
                    End If
                    'duty point
                    PlaceData(xlsWB, sheet, lang_dict(4), 8, 1, True)
                    'volume flow rate
                    PlaceData(xlsWB, sheet, lang_dict(5), 9, 3)
                    PlaceData(xlsWB, sheet, final.vol, 9, 7)
                    PlaceData(xlsWB, sheet, Units(0).UnitName(Units(0).UnitSelected), 9, 8)
                    'fsp
                    PlaceData(xlsWB, sheet, lang_dict(6), 10, 3)
                    PlaceData(xlsWB, sheet, final.fsp, 10, 7)
                    PlaceData(xlsWB, sheet, Units(1).UnitName(Units(1).UnitSelected), 10, 8)
                    'ftp
                    PlaceData(xlsWB, sheet, lang_dict(7), 11, 3)
                    PlaceData(xlsWB, sheet, final.ftp, 11, 7)
                    PlaceData(xlsWB, sheet, Units(1).UnitName(Units(1).UnitSelected), 11, 8)
                    'fan speed
                    PlaceData(xlsWB, sheet, lang_dict(8), 12, 3)
                    PlaceData(xlsWB, sheet, final.speed, 12, 7)
                    PlaceData(xlsWB, sheet, "RPM", 12, 8)
                    'gas density
                    PlaceData(xlsWB, sheet, lang_dict(9), 13, 3)
                    PlaceData(xlsWB, sheet, knowndensity, 13, 7)
                    PlaceData(xlsWB, sheet, Units(3).UnitName(Units(3).UnitSelected), 13, 8)
                    'fan power
                    PlaceData(xlsWB, sheet, lang_dict(10), 14, 3)
                    PlaceData(xlsWB, sheet, final.pow, 14, 7)
                    PlaceData(xlsWB, sheet, Units(4).UnitName(Units(4).UnitSelected), 14, 8)
                    'outlet velocity
                    PlaceData(xlsWB, sheet, lang_dict(11), 9, 11)
                    PlaceData(xlsWB, sheet, final.ov, 9, 14)
                    PlaceData(xlsWB, sheet, Units(7).UnitName(Units(7).UnitSelected), 9, 15)
                    'fse
                    PlaceData(xlsWB, sheet, lang_dict(12), 10, 11)
                    PlaceData(xlsWB, sheet, final.fse, 10, 14)
                    PlaceData(xlsWB, sheet, "%", 10, 15)
                    'fte
                    PlaceData(xlsWB, sheet, lang_dict(13), 11, 11)
                    PlaceData(xlsWB, sheet, final.fte, 11, 14)
                    PlaceData(xlsWB, sheet, "%", 11, 15)
                    'motor power
                    PlaceData(xlsWB, sheet, lang_dict(82), 14, 11)
                    PlaceData(xlsWB, sheet, final.mot, 14, 14)
                    PlaceData(xlsWB, sheet, Units(4).UnitName(Units(4).UnitSelected), 14, 15)
                End With
            Case 2
                xlsWB.ActiveSheet.Name = sheet
                With xlsWB.ActiveSheet
                    'title
                    If found = False Then
                        PlaceData(xlsWB, sheet, lang_dict(34) & " " & final.fansize.ToString & " " & final.fantypename & " " & lang_dict(3) & didw, 7, 1, True,, True, 7, 1, 7, 16, 11,, 3) 'company name
                    Else
                        PlaceData(xlsWB, sheet, lang_dict(34) & " " & final.fansize.ToString & " " & lang_dict(i) & " " & lang_dict(3) & didw, 7, 1, True,, True, 7, 1, 7, 16, 11,, 3) 'company name
                    End If
                    'duty point
                    PlaceData(xlsWB, sheet, lang_dict(4), 8, 1, True)
                    'volume flow rate
                    PlaceData(xlsWB, sheet, lang_dict(5), 9, 3)
                    PlaceData(xlsWB, sheet, final.vol, 9, 7)
                    PlaceData(xlsWB, sheet, Units(0).UnitName(Units(0).UnitSelected), 9, 8)
                    'fsp
                    If PresType = 0 Then
                        PlaceData(xlsWB, sheet, lang_dict(6), 10, 3)
                        PlaceData(xlsWB, sheet, final.fsp, 10, 7)
                        PlaceData(xlsWB, sheet, Units(1).UnitName(Units(1).UnitSelected), 10, 8)
                    Else
                        PlaceData(xlsWB, sheet, lang_dict(7), 10, 3)
                        PlaceData(xlsWB, sheet, final.ftp, 10, 7)
                        PlaceData(xlsWB, sheet, Units(1).UnitName(Units(1).UnitSelected), 10, 8)
                    End If
                    'gas density
                    PlaceData(xlsWB, sheet, lang_dict(9), 9, 11)
                    PlaceData(xlsWB, sheet, knowndensity, 9, 14)
                    PlaceData(xlsWB, sheet, Units(3).UnitName(Units(3).UnitSelected), 9, 15)
                    'fan speed
                    PlaceData(xlsWB, sheet, lang_dict(8), 10, 11)
                    PlaceData(xlsWB, sheet, final.speed, 10, 14)
                    PlaceData(xlsWB, sheet, "RPM", 10, 15)
                End With
        End Select
    End Sub


    'Public Sub OutputDataTableDamperPowPO(xlsWB, text1, text2)
    '    Dim pwr As Double
    '    'Dim factors(3) As Double
    '    Dim Factor = New Integer() {0.9, 0.8, 0.67, 0.5}
    '    ConvertData()
    '    PlaceData(xlsWB, sheet, text1, 7, 14)
    '    PlaceData(xlsWB, sheet, text2, 7, 14)
    '    Dim i As Integer
    '    xlsWB.ActiveSheet.Name = sheet
    '    For i = 1 To Num_Readings
    '        For j = 0 To 3
    '            pwr = plotpow(i - 1) * Factor(j)
    '            SetPlaces(pwr)
    '            PlaceData(xlsWB, sheet, Math.Round(pwr, powerdecplaces), 8 + i, 14 + j) 'performance data header
    '        Next
    '    Next
    'End Sub

    Public Sub PlaceData(xlsWB As Excel.Workbook, Sheetname As String, text As Object, row As Integer, col As Integer, Optional bold As Boolean = False, Optional italics As Boolean = False, Optional merge As Boolean = False, Optional mrow1 As Integer = 0, Optional mcol1 As Integer = 0, Optional mrow2 As Integer = 0, Optional mcol2 As Integer = 0, Optional fontsize As Integer = 10, Optional wrap As Boolean = False, Optional position As Integer = 99)
        Try
            xlsWB.ActiveSheet.Name = Sheetname
            With xlsWB.ActiveSheet
                .cells(row, col).value = text
                .Cells(row, col).Font.Bold = bold
                .cells(row, col).Font.size = fontsize
                .cells(row, col).wraptext = wrap
                If merge = True Then .range(.cells(mrow1, mcol1), .cells(mrow2, mcol2)).merge
                Select Case position
                    Case 1 'left
                        .Range(.Cells(row, col), .Cells(row, col)).HorizontalAlignment = Excel.Constants.xlLeft
                    Case 2 'right
                        .Range(.Cells(row, col), .Cells(row, col)).HorizontalAlignment = Excel.Constants.xlRight
                    Case 3 'centre
                        .Range(.Cells(row, col), .Cells(row, col)).HorizontalAlignment = Excel.Constants.xlCenter
                    Case Else
                End Select
                '.cells(17, 2).value = lang_dict(79)
                '.Cells(17, 2).Font.Bold = True
                '.range(.cells(17, 2), .cells(17, 3)).merge
            End With


        Catch ex As Exception
            ErrorMessage(ex, 649033)
        End Try

    End Sub
    Private Sub ExporttoPDFPO(xlsWB)
        Try
            Dim ExportName As String = OpenFileName.Replace(".hfs", ".pdf")
            xlsWB.ExportAsFixedFormat(Excel.XlFixedFormatType.xlTypePDF, Filename:=ExportName)
            System.Diagnostics.Process.Start(ExportName)
        Catch ex As Exception
            ErrorMessage(ex, 55555)
        End Try
    End Sub

    Public Sub ConvertData()
        Dim i As Integer
        Dim filenameref As String = "FILENAME REF DATA"
        ReadReffromBinaryfile(filenameref)
        'Do While fanclass(i) <> final.fantype
        For i = 0 To fantypesQTY - 1
            If fanclass(i) = final.fantype And final.fansize <= fansizelimit(i) Then Exit For
        Next
        'i = i + 1
        'Loop
        ReadfromBinaryfile(fantypefilename(i), 0)
        FrmFanChart.ConvertPVtoChart(True)
    End Sub

    Public Sub SetPlaces(q As Double, Optional h As Double = 0.0, Optional k As Double = 0.0)
        voldecplaces = 3
        If q > 10000 Then
            voldecplaces = 0
        ElseIf q > 1000 Then
            voldecplaces = 1
        ElseIf q > 100 Then
            voldecplaces = 2
        ElseIf q > 10 Then
            voldecplaces = 3
        End If
        pressplaceRise = 3
        If h > 10000 Then
            pressplaceRise = 0
        ElseIf h > 1000 Then
            pressplaceRise = 1
        ElseIf h > 100 Then
            pressplaceRise = 2
        ElseIf h > 10 Then
            pressplaceRise = 3
        End If
        powerdecplaces = 2
        If k >= 100 Then powerdecplaces = 1
        If k >= 1000 Then powerdecplaces = 0
    End Sub

    'Public Sub curvetoexcel(filename_excel As String)

    ''Dim xls As Microsoft.Office.Interop.Excel.Application
    ''Dim xlsWorkBook As Microsoft.Office.Interop.Excel.Workbook
    ''Dim xlsWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
    ''Dim misValue As Object = System.Reflection.Missing.Value

    ''xls = New Microsoft.Office.Interop.Excel.Application
    ''xlsWorkBook = xls.Workbooks.Open("D:\bookl.xlsx")
    ''xlsWorkSheet = xlsWorkBook.Sheets("sheet1")

    ''xlsWorkSheet.Cells(1, 1) = TextBox1.Text

    ''xlsWorkBook.Close()
    ''xls.Quit()

    'Try
    '    Dim xlsApp As Excel.Application ' = Nothing
    '    'Dim xlsWorkBooks As Excel.Workbooks = Nothing
    '    Dim xlsWB As Excel.Workbook ' = Nothing
    '    Dim xlsWS As Excel.Worksheet

    '    xlsApp = New Microsoft.Office.Interop.Excel.Application
    '    'xlsApp.Visible = False
    '    'xlsWorkBooks = xlsApp.Workbooks
    '    xlsWB = xlsApp.Workbooks.Open(filename_excel)
    '    xlsWS = xlsWB.Sheets("Sheet1")


    '    'FanSize1 = Val(xlsWB.Worksheets(1).Cells(2, 2).Value) 'x
    '    'If FanSize1 < 0.00001 Then Exit Sub
    '    Dim IN1 As Integer
    '    Dim IN2 As Integer
    '    Dim INext As Integer
    '    Dim JNext As Integer
    '    Dim IData As Integer = 1
    '    Dim cellrow As Integer
    '    IN1 = Int((IData - 1) / 2)
    '    IN2 = IData - 2 * IN1
    '    INext = (IN2 - 1) * 5
    '    JNext = IN1 * 35
    '    '    varResults = ActiveWorkbook
    '    'With xlsWB(filename_excel)
    '    'aa = xlsWB.Name
    '    '.title = "fan curve"
    '    '.Activate
    '    If IData = 1 Then xlsWS.Cells(1, 1).Value = "FAN PERFORMANCE FIGURES"
    '    xlsWS.Cells(7 + JNext, 2 + INext).Value = "curvefsp"
    '    xlsWS.Cells(8 + JNext, 2 + INext).Value = "Pa" 'presunits
    '    xlsWS.Cells(7 + JNext, 4 + INext).Value = "curvepower"
    '    xlsWS.Cells(8 + JNext, 4 + INext).Value = "kw" 'powunits
    '    xlsWS.Cells(7 + JNext, 1 + INext).Value = "curvevol"
    '    xlsWS.Cells(8 + JNext, 1 + INext).Value = "cfm" 'curvevolunits
    '    xlsWS.Cells(7 + JNext, 3 + INext).Value = "curveftp"
    '    xlsWS.Cells(8 + JNext, 3 + INext).Value = "kPa" 'presunits

    '    count = 0
    '    cellrow = 9 + JNext

    '    'Do While count <= Num_Readings - 1 'datasets - 1
    '    '    xlsWS.Cells(cellrow, 2 + INext).Value = 12 'curvefsp(IData, count)
    '    '    xlsWS.Cells(cellrow, 4 + INext).Value = 34 'curvepower(IData, count) * Widthratio
    '    '    xlsWS.Cells(cellrow, 1 + INext).Value = 56 'curvevol(IData, count) * Widthratio
    '    '    xlsWS.Cells(cellrow, 3 + INext).Value = 78 'curveftp(IData, count)

    '    '    count = count + 1
    '    '    cellrow = cellrow + 1
    '    'Loop
    '    ''End With

    '    xlsWB.Close()
    '    'xlsWB = Nothing
    '    'xlsWorkBooks.Close()
    '    'xlsWorkBooks = Nothing
    '    xlsApp.Quit()
    '    'xlsApp = Nothing

    'Catch ex As Exception
    '    ErrorMessage(ex, 6404)
    'End Try


    'End Sub


End Module
