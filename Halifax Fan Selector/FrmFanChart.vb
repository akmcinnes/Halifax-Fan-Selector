﻿Imports System.IO
Imports System.Drawing.Printing
Public Class FrmFanChart
    Public SeriesAdded As Boolean
    Private Sub FanChart_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            SeriesAdded = False
            'fan2plot = 0
            'Do While fanclass(fan2plot) <> Me.Text
            '    fan2plot = fan2plot + 1
            'Loop
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

    Private Sub PlotTheCurve()
        Try
            Dim i As Integer
            Dim filenameref As String = "FILENAME REF DATA"
            ReadReffromBinaryfile(filenameref)
            Do While fanclass(i) <> curvedesign
                i = i + 1
            Loop
            ReadfromBinaryfile(fantypefilename(i), 0)
            PlotStaticPVCurve()
            PlotTotalPVCurve()
            PlotPowerCurve()
            PlotFanSystemCurve()
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
                'temppres(i) = Math.Pow(tempvol(i) / selected(fan2plot).vol, 2) * selected(fan2plot).ftp
                'temppres(i) = Math.Pow(tempvol(i) / selected(fan2plot).vol, 2) * selected(fan2plot).fsp
                Chart1.Series(legend).Points.AddXY(tempvol(i), temppres(i))
                i = i + 1
            Next
            Chart1.ChartAreas(0).AxisX.Minimum = 0.0

        Catch ex As Exception
            ErrorMessage(ex, 20107)
        End Try

    End Sub

    Public Sub ConvertPVtoChart()
        Try
            ReDim plotvol(Num_Readings)
            ReDim plotfsp(Num_Readings)
            ReDim plotftp(Num_Readings)
            ReDim plotpow(Num_Readings)

            Dim temp_kp As Double = kp
            If Frmselectfan.chkKP.Checked = True Then temp_kp = 1.0

            For i = 0 To Num_Readings - 1
                If Units(1).UnitSelected = 0 Then plotfsp(i) = FSP_pa(i)
                If Units(1).UnitSelected = 1 Then plotfsp(i) = FSP_insWG(i)
                If Units(1).UnitSelected = 2 Then plotfsp(i) = FSP_mmwg(i)
                If Units(1).UnitSelected = 3 Then plotfsp(i) = FSP_mbar(i)
                If Units(1).UnitSelected = 4 Then plotfsp(i) = FSP_kpa(i)
                plotfsp(i) = plotfsp(i) * getscalefactor()

                If Units(1).UnitSelected = 0 Then plotftp(i) = FTP_pa(i)
                If Units(1).UnitSelected = 1 Then plotftp(i) = FTP_insWG(i)
                If Units(1).UnitSelected = 2 Then plotftp(i) = FTP_mmWG(i)
                If Units(1).UnitSelected = 3 Then plotftp(i) = FTP_mbar(i)
                If Units(1).UnitSelected = 4 Then plotftp(i) = FTP_kpa(i)
                plotftp(i) = plotftp(i) * getscalefactor()

                If Units(0).UnitSelected = 0 Then plotvol(i) = Vol_m3hr(i)
                If Units(0).UnitSelected = 1 Then plotvol(i) = Vol_m3min(i)
                If Units(0).UnitSelected = 2 Then plotvol(i) = Vol_m3sec(i)
                If Units(0).UnitSelected = 3 Then plotvol(i) = Vol_cfm(i)
                If Units(0).UnitSelected = 4 Then plotvol(i) = Vol_m3hr(i) * knowndensity
                If Units(0).UnitSelected = 5 Then plotvol(i) = Vol_cfm(i) * knowndensity

                If Units(4).UnitSelected = 0 Then plotpow(i) = Pow_kw(i)
                If Units(4).UnitSelected = 1 Then plotpow(i) = Pow_hp(i)
                If optDisplaykW.Checked = True Then plotpow(i) = Pow_kw(i)
                If optDisplayhp.Checked = True Then plotpow(i) = Pow_hp(i)
                plotpow(i) = plotpow(i) * getscalefactor()
            Next

            For i = 0 To Num_Readings - 1
                '-scaling for fan size
                plotvol(i) = ScaleVFSize(plotvol(i), FanSize1, selected(fan2plot).fansize)
                plotfsp(i) = ScalePFSize(plotfsp(i), FanSize1, selected(fan2plot).fansize)
                plotftp(i) = ScalePFSize(plotftp(i), FanSize1, selected(fan2plot).fansize)
                plotpow(i) = ScalePowFSize(plotpow(i), FanSize1, selected(fan2plot).fansize)
                '-scaling for fan speed
                plotvol(i) = ScaleVFSpeed(plotvol(i), FanSpeed1, selected(fan2plot).speed)
                plotfsp(i) = ScalePFSpeed(plotfsp(i), FanSpeed1, selected(fan2plot).speed)
                plotftp(i) = ScalePFSpeed(plotftp(i), FanSpeed1, selected(fan2plot).speed)
                plotpow(i) = ScalePowFSpeed(plotpow(i), FanSpeed1, selected(fan2plot).speed)

                plotpow(i) = plotpow(i) / temp_kp
            Next

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
                RemoveFanSystemCurve()
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
                RemoveFanSystemCurve()
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
            ErrorMessage(ex, 20113)
        End Try
    End Sub

    Public Sub RemoveFanSystemCurve()
        Try
            Dim series1 As DataVisualization.Charting.Series = Chart1.Series(ChkFanSystemCurve.Text)
            Chart1.Series.Remove(series1)
        Catch ex As Exception
            ErrorMessage(ex, 20112)
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
            FullFilePathtxt = "C:\Halifax\Output Files\Fan Output.txt"
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

    'Private Class printer
    '    Friend Function PaperSize() As Object
    '        Throw New NotImplementedException
    '    End Function
    'End Class
End Class