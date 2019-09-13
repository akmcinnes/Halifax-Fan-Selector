Imports System.IO
Public Class FrmFanChart

    'Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr

    'Private Declare Function GetWindowRect Lib "user32" _
    '            (ByVal hwnd As IntPtr,
    '            ByRef lpRect As RECT) _
    '            As Integer

    'Private Structure RECT
    '    Public Left As Integer
    '    Public Top As Integer
    '    Public Right As Integer
    '    Public Bottom As Integer
    'End Structure


    Public SeriesAdded As Boolean
    Private Sub FanChart_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            SeriesAdded = False
            curvedesign = Me.Text

            Me.Text = lblTitleHidden.Text + " - " + final.fantype + " " + final.fansize.ToString + " " + lblRunningAtHidden.Text + " " + final.speed.ToString + " rpm"
            If SelectDIDW = True Then Me.Text = Me.Text + " (DIDW)"

            tempyaxistitle = ""
            tempy2axistitle = ""

            xaxistitle = lblVolumeHidden.Text
            yaxistitle = lblPressureHidden.Text
            y2axistitle = lblPowerHidden.Text
            getaxislabels()
            PlotTheCurve()
            SeriesAdded = True
        Catch ex As Exception
            ErrorMessage(ex, 20101)
        End Try
    End Sub

    Private Sub PlotTheCurve() 'Optional printout As Boolean = False
        Try
            Dim i As Integer
            Dim tempsize As Integer = selected(fan2plot).fansize
            Dim tempdesign(10) As String
            Dim filenameref As String = "FILENAME REF DATA"
            ReadReffromBinaryfile(filenameref)
            Dim sizecon As Double
            For i = 0 To fantypesQTY - 1
                sizecon = 1.0
                If fanunits(i) = "mm" Then sizecon = 25.4
                'If fanclass(i) = curvedesign And tempsize / sizecon <= fansizelimit(i) Then Exit For
                If fantypefilename(i) = selected(fan2plot).fantypefilename Then Exit For
            Next
            ReadfromBinaryfile(fantypefilename(i), 0)
            PlotStaticPVCurve()
            PlotTotalPVCurve()
            PlotPowerCurve()
            plotFanSystemCurve()
            Chart1.ChartAreas("ChartArea1").AxisX.MinorGrid.Interval = Chart1.ChartAreas("ChartArea1").AxisX.MajorGrid.Interval / 10.0
            Chart1.ChartAreas("ChartArea1").AxisX.MinorGrid.Enabled = True
            Chart1.ChartAreas("ChartArea1").AxisY.MinorGrid.Interval = Chart1.ChartAreas("ChartArea1").AxisY.MajorGrid.Interval / 10.0
            Chart1.ChartAreas("ChartArea1").AxisY.MinorGrid.Enabled = True
        Catch ex As Exception
            ErrorMessage(ex, 20102)
        End Try
    End Sub

    Public Sub getaxislabels()
        Try
            Chart1.ChartAreas("ChartArea1").BackColor = Color.Bisque

            Chart1.ChartAreas("ChartArea1").AxisX.Title = xaxistitle + " (" + Units(0).UnitName(Units(0).UnitSelected) + ")"
            Chart1.ChartAreas("ChartArea1").AxisX.MajorGrid.LineColor = Color.Gray
            Chart1.ChartAreas("ChartArea1").AxisX.MinorGrid.LineColor = Color.LightGray
            Chart1.ChartAreas("ChartArea1").AxisX.TitleForeColor = Color.White
            Chart1.ChartAreas("ChartArea1").AxisX.LabelStyle.ForeColor = Color.White

            Chart1.ChartAreas("ChartArea1").AxisY.Title = yaxistitle + " (" + Units(1).UnitName(Units(1).UnitSelected) + ")"
            Chart1.ChartAreas("ChartArea1").AxisY.MajorGrid.LineColor = Color.Gray
            Chart1.ChartAreas("ChartArea1").AxisY.MinorGrid.LineColor = Color.LightGray
            Chart1.ChartAreas("ChartArea1").AxisY.TitleForeColor = Color.White
            Chart1.ChartAreas("ChartArea1").AxisY.LabelStyle.ForeColor = Color.White
            tempyaxistitle = Chart1.ChartAreas("ChartArea1").AxisY.Title

            If Units(4).UnitSelected < 2 Then
                Chart1.ChartAreas("ChartArea1").AxisY2.Title = y2axistitle + " (" + Units(4).UnitName(Units(4).UnitSelected) + ")"
            Else
                If optDisplaykW.Checked = True Then
                    Chart1.ChartAreas("ChartArea1").AxisY2.Title = y2axistitle + " (" + Units(4).UnitName(0) + ")"
                Else
                    Chart1.ChartAreas("ChartArea1").AxisY2.Title = y2axistitle + " (" + Units(4).UnitName(1) + ")"
                End If
            End If
            Chart1.ChartAreas("ChartArea1").AxisY2.MajorGrid.LineColor = Color.Blue
            Chart1.ChartAreas("ChartArea1").AxisY2.MinorGrid.LineColor = Color.LightBlue
            Chart1.ChartAreas("ChartArea1").AxisY2.TitleForeColor = Color.White
            Chart1.ChartAreas("ChartArea1").AxisY2.LabelStyle.ForeColor = Color.White
            Chart1.ChartAreas("ChartArea1").AxisY2.Enabled = DataVisualization.Charting.AxisEnabled.True
            Chart1.ChartAreas("ChartArea1").AxisY2.LabelStyle.Enabled = True
            tempy2axistitle = Chart1.ChartAreas("ChartArea1").AxisY2.Title
            'End If

        Catch ex As Exception
            ErrorMessage(ex, 20103)
        End Try

    End Sub

    Public Sub PlotStaticPVCurve()
        Try
            Dim i As Integer

            ReDim plotvol(Num_Readings)
            ReDim plotfsp(Num_Readings)
            ReDim plotftp(Num_Readings)
            ReDim plotpow(Num_Readings)

            If tempyaxistitle.Length > 0 Then
                Chart1.ChartAreas("ChartArea1").AxisY.Title = tempyaxistitle
                tempyaxistitle = ""
            End If

            legend = ChkStaticPressureCurve.Text

            Chart1.Series.Add(legend)
            Chart1.Series(legend).Color = Color.Blue
            Chart1.Series(legend).ChartType = DataVisualization.Charting.SeriesChartType.Spline
            Chart1.Series(legend).ChartArea = "ChartArea1"

            ConvertPVtoChart()

            For i = 0 To Num_Readings - 1
                Chart1.Series(legend).Points.AddXY(plotvol(i), plotfsp(i))
            Next

            Chart1.ChartAreas(0).AxisX.Minimum = 0.0
            Chart1.Series.Add("Duty Point FSP")
            Chart1.Series("Duty Point FSP").IsVisibleInLegend = False
            Chart1.Series("Duty Point FSP").Color = Color.Green
            Chart1.Series("Duty Point FSP").ChartType = DataVisualization.Charting.SeriesChartType.Point
            Chart1.Series("Duty Point FSP").ChartArea = "ChartArea1"
            Chart1.Series("Duty Point FSP").Points.AddXY(selected(fan2plot).vol, selected(fan2plot).fsp)

            Chart1.ChartAreas("ChartArea1").AxisY.LabelStyle.Enabled = True
            Chart1.ChartAreas("ChartArea1").AxisY.MajorGrid.Enabled = True
            Chart1.ChartAreas("ChartArea1").AxisY.MinorGrid.Enabled = True
            tempyaxistitle = Chart1.ChartAreas("ChartArea1").AxisY.Title

        Catch ex As Exception
            ErrorMessage(ex, 20104)
        End Try

    End Sub

    Public Sub PlotTotalPVCurve()
        Try
            Dim i As Integer

            ReDim plotvol(Num_Readings)
            ReDim plotfsp(Num_Readings)
            ReDim plotftp(Num_Readings)
            ReDim plotpow(Num_Readings)

            If tempyaxistitle.Length > 0 Then
                Chart1.ChartAreas("ChartArea1").AxisY.Title = tempyaxistitle
                tempyaxistitle = ""
            End If

            legend = ChkTotalPressureCurve.Text

            Chart1.Series.Add(legend)
            Chart1.Series(legend).Color = Color.Red
            Chart1.Series(legend).ChartType = DataVisualization.Charting.SeriesChartType.Spline
            Chart1.Series(legend).ChartArea = "ChartArea1"

            ConvertPVtoChart()

            For i = 0 To Num_Readings - 1
                Chart1.Series(legend).Points.AddXY(plotvol(i), plotftp(i))
            Next

            Chart1.ChartAreas(0).AxisX.Minimum = 0.0
            Chart1.Series.Add("Duty Point FTP")
            Chart1.Series("Duty Point FTP").IsVisibleInLegend = False
            Chart1.Series("Duty Point FTP").Color = Color.Green
            Chart1.Series("Duty Point FTP").ChartType = DataVisualization.Charting.SeriesChartType.Point
            Chart1.Series("Duty Point FTP").ChartArea = "ChartArea1"
            Chart1.Series("Duty Point FTP").Points.AddXY(selected(fan2plot).vol, selected(fan2plot).ftp)

            Chart1.ChartAreas("ChartArea1").AxisY.LabelStyle.Enabled = True
            Chart1.ChartAreas("ChartArea1").AxisY.MajorGrid.Enabled = True
            Chart1.ChartAreas("ChartArea1").AxisY.MinorGrid.Enabled = True
            tempyaxistitle = Chart1.ChartAreas("ChartArea1").AxisY.Title

        Catch ex As Exception
            ErrorMessage(ex, 20105)
        End Try

    End Sub

    Public Sub PlotPowerCurve()
        Try
            Dim i As Integer

            ReDim plotvol(Num_Readings)
            ReDim plotfsp(Num_Readings)
            ReDim plotftp(Num_Readings)
            ReDim plotpow(Num_Readings)

            If tempy2axistitle.Length > 0 Then
                Chart1.ChartAreas("ChartArea1").AxisY2.Title = tempy2axistitle
                tempy2axistitle = ""
            End If

            legend = ChkFanPower.Text

            Chart1.Series.Add(legend)
            Chart1.Series(legend).YAxisType = DataVisualization.Charting.AxisType.Secondary

            Chart1.Series(legend).Color = Color.Green
            Chart1.Series(legend).ChartType = DataVisualization.Charting.SeriesChartType.Spline
            Chart1.Series(legend).ChartArea = "ChartArea1"

            ConvertPVtoChart()

            For i = 0 To Num_Readings - 1
                Chart1.Series(legend).Points.AddXY(plotvol(i), plotpow(i))
            Next

            Chart1.ChartAreas(0).AxisX.Minimum = 0.0

            Chart1.Series.Add("Duty Point Power")
            Chart1.Series("Duty Point Power").IsVisibleInLegend = False
            Chart1.Series("Duty Point Power").Color = Color.Green
            Chart1.Series("Duty Point Power").ChartType = DataVisualization.Charting.SeriesChartType.Point
            Chart1.Series("Duty Point Power").ChartArea = "ChartArea1"
            Chart1.Series("Duty Point Power").YAxisType = DataVisualization.Charting.AxisType.Secondary
            If optDisplaykW.Checked = True Then
                Chart1.Series("Duty Point Power").Points.AddXY(selected(fan2plot).vol, selected(fan2plot).pow)
            ElseIf optDisplayhp.Checked = True Then
                Chart1.Series("Duty Point Power").Points.AddXY(selected(fan2plot).vol, selected(fan2plot).pow2)
            Else
                Chart1.Series("Duty Point Power").Points.AddXY(selected(fan2plot).vol, selected(fan2plot).pow)
            End If

            Chart1.ChartAreas("ChartArea1").AxisY2.LabelStyle.Enabled = True
            Chart1.ChartAreas("ChartArea1").AxisY2.MajorGrid.Enabled = True
            Chart1.ChartAreas("ChartArea1").AxisY2.MinorGrid.Enabled = True
        Catch ex As Exception
            ErrorMessage(ex, 20106)
        End Try

    End Sub

    Public Sub plotFanSystemCurve()
        Try
            Dim i As Integer

            ReDim plotvol(Num_Readings)
            ReDim plotfsp(Num_Readings)
            ReDim plotftp(Num_Readings)
            ReDim plotpow(Num_Readings)

            legend = ChkFanSystemCurve.Text

            Chart1.Series.Add(legend)
            Chart1.Series(legend).Color = Color.Black
            Chart1.Series(legend).ChartType = DataVisualization.Charting.SeriesChartType.Spline
            Chart1.Series(legend).BorderDashStyle = DataVisualization.Charting.ChartDashStyle.Dash
            Chart1.Series(legend).ChartArea = "ChartArea1"

            ConvertPVtoChart()

            Dim temppres(105) As Double
            Chart1.Series(legend).Points.AddXY(0.0, 0.0)
            Dim tempvol(105) As Double
            Dim voltemp As Double
            voltemp = (selected(fan2plot).vol * 1.0) / 100
            For i = 0 To 105
                tempvol(i) = voltemp * i
                If PresType = 0 Then
                    temppres(i) = Math.Pow(tempvol(i) / selected(fan2plot).vol, 2) * selected(fan2plot).fsp
                Else
                    temppres(i) = Math.Pow(tempvol(i) / selected(fan2plot).vol, 2) * selected(fan2plot).ftp
                End If
                Chart1.Series(legend).Points.AddXY(tempvol(i), temppres(i))
                i = i + 1
            Next
            Chart1.ChartAreas(0).AxisX.Minimum = 0.0

        Catch ex As Exception
            ErrorMessage(ex, 20107)
        End Try

    End Sub

    Public Sub ConvertPVtoChart(Optional printout As Boolean = False)
        Try
            ReDim plotvol(Num_Readings)
            ReDim plotfsp(Num_Readings)
            ReDim plotftp(Num_Readings)
            ReDim plotpow(Num_Readings)
            ReDim plotfse(Num_Readings)
            ReDim plotfte(Num_Readings)
            ReDim plotov(Num_Readings)

            Dim temp_kp As Double = kp
            If Frmselectfan.chkKP.Checked = True Then temp_kp = 1.0
            Dim tempprconv As Double = 1.0
            Dim tempvlconv As Double = 1.0
            Dim temppwconv As Double = 1.0
            Dim tempoaconv As Double = 1.0
            If Units(5).UnitSelected = 1 Then
                tempoaconv = 0.09290304
            End If

            If Units(1).UnitSelected = 0 Then kpatmos = 101325
            If Units(1).UnitSelected = 1 Then kpatmos = 408.782
            If Units(1).UnitSelected = 2 Then kpatmos = 10332.275
            If Units(1).UnitSelected = 3 Then kpatmos = 1013.25
            If Units(1).UnitSelected = 4 Then kpatmos = 101.325


            For i = 0 To Num_Readings - 1
                Select Case Units(1).UnitSelected
                    Case 0
                        plotfsp(i) = FSP_pa(i)
                        plotftp(i) = FTP_pa(i)
                        tempprconv = 1 / 1000
                    Case 1
                        plotfsp(i) = FSP_insWG(i)
                        plotftp(i) = FTP_insWG(i)
                        tempprconv = 1 / 249.0891
                    Case 2
                        plotfsp(i) = FSP_mmwg(i)
                        plotftp(i) = FTP_mmWG(i)
                        tempprconv = 1 / 9.80665
                    Case 3
                        plotfsp(i) = FSP_mbar(i)
                        plotftp(i) = FTP_mbar(i)
                        tempprconv = 100.0 / 1000
                    Case 4
                        plotfsp(i) = FSP_kpa(i)
                        plotftp(i) = FTP_kpa(i)
                End Select
                plotfsp(i) = plotfsp(i) * getscalefactor()
                plotftp(i) = plotftp(i) * getscalefactor()

                Select Case Units(0).UnitSelected
                    Case 0
                        plotvol(i) = Vol_m3hr(i)
                        tempvlconv = 1 / 3600
                    Case 1
                        plotvol(i) = Vol_m3min(i)
                        tempvlconv = 1 / 60
                    Case 2
                        plotvol(i) = Vol_m3sec(i)
                    Case 3
                        plotvol(i) = Vol_cfm(i)
                        tempvlconv = 1 / 0.58857777021102 / 3600
                    Case 4
                        plotvol(i) = Vol_m3hr(i) * knowndensity
                        tempvlconv = 1 / 3600
                    Case 5
                        plotvol(i) = Vol_cfm(i) * knowndensity
                        tempvlconv = 1 / (3600 * 0.58857777021102)
                End Select

                Select Case Units(4).UnitSelected
                    Case 0
                        plotpow(i) = Pow_kw(i)
                    Case 1
                        plotpow(i) = Pow_hp(i)
                        temppwconv = 1 / 1.34102209
                End Select
                If optDisplaykW.Checked = True Then plotpow(i) = Pow_kw(i)
                If optDisplayhp.Checked = True Then plotpow(i) = Pow_hp(i)
                plotpow(i) = plotpow(i) * getscalefactor()
            Next

            Dim tempsize As Double = selected(fan2plot).fansize ' was integer
            Dim tempspeed As Double = selected(fan2plot).speed ' was integer
            Dim tempoutletarea As Double = selected(fan2plot).outletarea
            If printout = True Then tempsize = final.fansize
            If printout = True Then tempspeed = final.speed
            If printout = True Then tempoutletarea = final.outletarea
            tempoutletarea = tempoutletarea * ((tempsize / FanSize1) ^ 2)

            For i = 0 To Num_Readings - 1
                '-scaling for fan size
                plotvol(i) = ScaleVFSize(plotvol(i), FanSize1, tempsize)
                plotfsp(i) = ScalePFSize(plotfsp(i), FanSize1, tempsize)
                plotftp(i) = ScalePFSize(plotftp(i), FanSize1, tempsize)
                plotpow(i) = ScalePowFSize(plotpow(i), FanSize1, tempsize)

                '-scaling for fan speed
                plotvol(i) = ScaleVFSpeed(plotvol(i), FanSpeed1, tempspeed)
                plotfsp(i) = ScalePFSpeed(plotfsp(i), FanSpeed1, tempspeed)
                plotftp(i) = ScalePFSpeed(plotftp(i), FanSpeed1, tempspeed)
                plotpow(i) = ScalePowFSpeed(plotpow(i), FanSpeed1, tempspeed)

                Dim tempkp As Double = 1.0
                tempkp = CalculateKP(1.4, kpatmos, plotfsp(i), 0)
                If Frmselectfan.chkKP.Checked = False Then
                    plotfsp(i) = plotfsp(i) * tempkp '1.0 / tempkp
                    plotftp(i) = plotftp(i) * tempkp '1.0 / tempkp
                    plotpow(i) = plotpow(i) * tempkp '1.0 / tempkp
                End If

                plotfse(i) = 100.0 * plotvol(i) * tempvlconv * plotfsp(i) * tempprconv / (plotpow(i) * temppwconv)
                plotfte(i) = 100.0 * plotvol(i) * tempvlconv * plotftp(i) * tempprconv / (plotpow(i) * temppwconv)
                plotov(i) = plotvol(i) * tempvlconv / (tempoutletarea * tempoaconv)

                'If StandAlone = True Then
                plotvol(i) = plotvol(i) * final.widthfactor
                plotpow(i) = plotpow(i) * final.widthfactor
                'End If
            Next
            plotoutletarea = tempoutletarea
            plotoutletlength = final.outletlen
            plotoutletwidth = final.outletwid
            plotinletdia = final.inletdia
        Catch ex As Exception
            ErrorMessage(ex, 20108)
        End Try

    End Sub

    Public Sub PlotDutyPoint()
        Try
            'Chart1.Series("Duty Point").Points.AddXY(selectedvol(fan2plot), selectedfsp(fan2plot))
            'Chart1.Series("Duty Point").Points.AddXY(selectedvol(fan2plot), selectedftp(fan2plot))
            'Chart1.Series("Duty Point").Points.AddXY(selectedvol(fan2plot), selectedpow(fan2plot))
        Catch ex As Exception
            ErrorMessage(ex, 20109)
        End Try
    End Sub

    Public Sub RemoveStaticPVCurve()
        Try
            Dim series1 As DataVisualization.Charting.Series = Chart1.Series(ChkStaticPressureCurve.Text)
            Chart1.Series.Remove(series1)
            Dim series2 As DataVisualization.Charting.Series = Chart1.Series("Duty Point FSP")
            Chart1.Series.Remove(series2)
            If ChkStaticPressureCurve.Checked = False And ChkTotalPressureCurve.Checked = False Then
                Chart1.ChartAreas("ChartArea1").AxisY.LabelStyle.Enabled = False
                Chart1.ChartAreas("ChartArea1").AxisY.MajorGrid.Enabled = False
                Chart1.ChartAreas("ChartArea1").AxisY.MinorGrid.Enabled = False
                tempyaxistitle = Chart1.ChartAreas("ChartArea1").AxisY.Title
                Chart1.ChartAreas("ChartArea1").AxisY.Title = ""
            End If
            If ChkStaticPressureCurve.Checked = False And PresType = 0 Then
                If ChkFanSystemCurve.Checked = True Then RemoveFanSystemCurve()
                ChkFanSystemCurve.Checked = False
            End If
        Catch ex As Exception
            ErrorMessage(ex, 20110)
        End Try
    End Sub

    Public Sub RemoveTotalPVCurve()
        Try
            Dim series1 As DataVisualization.Charting.Series = Chart1.Series(ChkTotalPressureCurve.Text)
            Chart1.Series.Remove(series1)
            Dim series2 As DataVisualization.Charting.Series = Chart1.Series("Duty Point FTP")
            Chart1.Series.Remove(series2)
            If ChkStaticPressureCurve.Checked = False And ChkTotalPressureCurve.Checked = False Then
                Chart1.ChartAreas("ChartArea1").AxisY.LabelStyle.Enabled = False
                Chart1.ChartAreas("ChartArea1").AxisY.MajorGrid.Enabled = False
                Chart1.ChartAreas("ChartArea1").AxisY.MinorGrid.Enabled = False
                tempyaxistitle = Chart1.ChartAreas("ChartArea1").AxisY.Title
                Chart1.ChartAreas("ChartArea1").AxisY.Title = ""
            End If
            If ChkTotalPressureCurve.Checked = False And PresType = 1 Then
                If ChkFanSystemCurve.Checked = True Then RemoveFanSystemCurve()
                ChkFanSystemCurve.Checked = False
            End If
        Catch ex As Exception
            ErrorMessage(ex, 20111)
        End Try
    End Sub

    Public Sub RemovePowerCurve()
        Try
            Dim series1 As DataVisualization.Charting.Series = Chart1.Series(ChkFanPower.Text)
            Chart1.Series.Remove(series1)
            Dim series2 As DataVisualization.Charting.Series = Chart1.Series("Duty Point Power")
            Chart1.Series.Remove(series2)
            Chart1.ChartAreas("ChartArea1").AxisY2.LabelStyle.Enabled = False
            Chart1.ChartAreas("ChartArea1").AxisY2.MajorGrid.Enabled = False
            Chart1.ChartAreas("ChartArea1").AxisY2.MinorGrid.Enabled = False
            tempy2axistitle = Chart1.ChartAreas("ChartArea1").AxisY2.Title
            Chart1.ChartAreas("ChartArea1").AxisY2.Title = ""
        Catch ex As Exception
            ErrorMessage(ex, 20112)
        End Try
    End Sub

    Public Sub RemoveFanSystemCurve()
        Try
            Dim series1 As DataVisualization.Charting.Series = Chart1.Series(ChkFanSystemCurve.Text)
            Chart1.Series.Remove(series1)
        Catch ex As Exception
            ErrorMessage(ex, 20113)
        End Try
    End Sub

    Private Sub ChkStaticPressureCurve_Click(sender As Object, e As EventArgs) Handles ChkStaticPressureCurve.Click
        Try
            If ChkStaticPressureCurve.Checked = True Then
                PlotStaticPVCurve()
            Else
                RemoveStaticPVCurve()
            End If
        Catch ex As Exception
            ErrorMessage(ex, 20114)
        End Try
    End Sub

    Private Sub ChkTotalPressureCurve_Click(sender As Object, e As EventArgs) Handles ChkTotalPressureCurve.Click
        Try
            If ChkTotalPressureCurve.Checked = True Then
                PlotTotalPVCurve()
            Else
                RemoveTotalPVCurve()
            End If
        Catch ex As Exception
            ErrorMessage(ex, 20115)
        End Try
    End Sub

    Private Sub ChkFanPower_Click(sender As Object, e As EventArgs) Handles ChkFanPower.Click
        Try
            If ChkFanPower.Checked = True Then
                PlotPowerCurve()
            Else
                RemovePowerCurve()
            End If
            If Units(4).UnitSelected >= 2 Then
                optDisplayhp.Enabled = ChkFanPower.Checked
                optDisplaykW.Enabled = ChkFanPower.Checked
            End If
        Catch ex As Exception
            ErrorMessage(ex, 20116)
        End Try
    End Sub

    Private Sub ChkFanSystemCurve_Click(sender As Object, e As EventArgs) Handles ChkFanSystemCurve.Click
        Try
            If ChkFanSystemCurve.Checked = True Then
                plotFanSystemCurve()
            Else
                RemoveFanSystemCurve()
            End If
        Catch ex As Exception
            ErrorMessage(ex, 20117)
        End Try
    End Sub

    '#################### Button functions
    Private Sub btnPrintDocument_Click(sender As Object, e As EventArgs) Handles btnPrintDocument.Click
        Try
            PrintDocument1.Print()
            'PageSetupDialog1.PageSettings.PaperSize(210, 297)

        Catch ex As Exception
            ErrorMessage(ex, 20118)
        End Try
    End Sub

    Private Sub btnPrintPreview_Click(sender As Object, e As EventArgs) Handles btnPrintPreview.Click
        Try
            'PageSetupDialog1.PageSettings.PaperSize("A4", 297, 211)
            PrintPreviewDialog1.ShowDialog()
            'Dim Printer As New printer
            'Printer.PrintAction = Printing.PrintAction.PrintToPreview
            'Printer.PaperSize = vbPRPSA4
            'Printer.Print("Using A4 size paper")
            'Printer.EndDoc()
            'Try
            '    PrintTextControl.DefaultPageSettings = PrintPageSettings
            '    PrintString = TextToPrint.Text
            '    PreviewPrint.Document = PrintTextControl
            '    PreviewPrint.ShowDialog()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try
        Catch ex As Exception
            ErrorMessage(ex, 20119)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Try
            Close()
        Catch ex As Exception
            ErrorMessage(ex, 20120)
        End Try

    End Sub

    Private Sub btnWritePointsToFile_Click(sender As Object, e As EventArgs) Handles btnWritePointsToFile.Click
        Try
            Dim FullFilePathtxt As String
            '        FullFilePathtxt = "C:\Halifax\Performance Data new\" + filename + ".txt"
            FullFilePathtxt = OutputPathDefault + "Fan Output.txt"
            Dim objStreamWriter As New StreamWriter(FullFilePathtxt)
            Dim i As Integer
            For i = 0 To Num_Readings - 1
                objStreamWriter.Write(plotvol(i))
                objStreamWriter.Write(",")
                objStreamWriter.Write(plotfsp(i))
                objStreamWriter.Write(",")
                objStreamWriter.Write(plotftp(i))
                objStreamWriter.Write(",")
                objStreamWriter.Write(plotpow(i))
                objStreamWriter.Write(vbNewLine)
            Next
            objStreamWriter.Close() 'Close 
        Catch ex As Exception
            ErrorMessage(ex, 20121)
        End Try
    End Sub

    Private Sub optDisplaykW_Click(sender As Object, e As EventArgs) Handles optDisplaykW.Click
        Try
            Chart1.Series.Clear()
            getaxislabels()
            PlotTheCurve()
            If ChkFanSystemCurve.Checked = False Then RemoveFanSystemCurve()
            If ChkTotalPressureCurve.Checked = False Then RemoveTotalPVCurve()
            If ChkStaticPressureCurve.Checked = False Then RemoveStaticPVCurve()
            If ChkFanPower.Checked = False Then RemovePowerCurve()
        Catch ex As Exception
            ErrorMessage(ex, 20122)
        End Try
    End Sub

    Private Sub optDisplayhp_Click(sender As Object, e As EventArgs) Handles optDisplayhp.Click
        Try
            Chart1.Series.Clear()
            getaxislabels()
            PlotTheCurve()
            If ChkFanSystemCurve.Checked = False Then RemoveFanSystemCurve()
            If ChkTotalPressureCurve.Checked = False Then RemoveTotalPVCurve()
            If ChkStaticPressureCurve.Checked = False Then RemoveStaticPVCurve()
            If ChkFanPower.Checked = False Then RemovePowerCurve()
        Catch ex As Exception
            ErrorMessage(ex, 20123)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim bm As New Bitmap(1037, 568)
        'Dim g As Graphics = Graphics.FromImage(bm)
        'g.CopyFromScreen(Me.Location, New Point(0, 0), New Size(1037, 568))
        'bm.Save("C:\Halifax\Output Files\formgrab.bmp", Drawing.Imaging.ImageFormat.Bmp)


        'Dim r As New RECT
        'GetWindowRect(GetActiveWindow, r)
        ''Dim img As New Bitmap(r.Right - r.Left, r.Bottom - r.Top)
        'Dim img As New Bitmap(1037, 568)
        'Dim gr As Graphics = Graphics.FromImage(img)
        'gr.CopyFromScreen(New Point(r.Left, r.Top), Point.Empty, img.Size)
        'img.Save("test.png")
        'Process.Start("test.png")

        'SendKeys.Send("%{PRTSC}")
        'SendKeys.Send("%(PRTSC)") 'for Ctrl-C
        'Then continue the normal way
        'Dim Screenshot As Image = Clipboard.GetImage()

        SendKeys.Send("%{PRTSC}")
        Dim Screenshot As Image = Clipboard.GetImage()
        Screenshot.Save("c:\Halifax\Output Files\ScreenShot.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
    End Sub
End Class