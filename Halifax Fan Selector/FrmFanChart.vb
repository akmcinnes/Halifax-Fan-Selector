Imports System.IO
Imports System.Drawing.Printing
Public Class FrmFanChart
    Public SeriesAdded As Boolean
    Private Sub FanChart_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            SeriesAdded = False
            fan2plot = 0
            Do While fanclass(fan2plot) <> Me.Text
                fan2plot = fan2plot + 1
            Loop
            'Chart1.BackColor = Color.Bisque
            getaxislabels()
            PlotTheCurve()
            SeriesAdded = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PlotTheCurve()
        Try
            Dim i As Integer
            Dim filenameref As String = "FILENAME REF DATA"
            ReadReffromBinaryfile(filenameref)
            Do While fanclass(i) <> Me.Text
                i = i + 1
            Loop
            ReadfromBinaryfile(fantypefilename(i), 0)
            plotStaticPV()
            plotTotalPV()
            plotPower()
            plotFanSystem()
            Chart1.ChartAreas("ChartArea1").AxisX.MinorGrid.Interval = Chart1.ChartAreas("ChartArea1").AxisX.MajorGrid.Interval / 10.0
            Chart1.ChartAreas("ChartArea1").AxisX.MinorGrid.Enabled = True
            Chart1.ChartAreas("ChartArea1").AxisY.MinorGrid.Interval = Chart1.ChartAreas("ChartArea1").AxisY.MajorGrid.Interval / 10.0
            Chart1.ChartAreas("ChartArea1").AxisY.MinorGrid.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Public Sub getaxislabels()
        Try
            'getaxislabels = ""
            If Frmselectfan.OptStaticPressure.Checked = True Then
                If PresType = 0 Then
                    Chart1.ChartAreas("ChartArea1").AxisY.Title = "STATIC PRESSURE "
                Else
                    Chart1.ChartAreas("ChartArea1").AxisY.Title = "TOTAL PRESSURE "
                End If
            Else
                Chart1.ChartAreas("ChartArea1").AxisY.Title = "PRESSURE "
            End If

            yaxistitle = "PRESSURE (" + Units(1).UnitName(Units(1).UnitSelected) + ")"
            presunits = "(" + Units(1).UnitName(Units(1).UnitSelected) + ")"
            xaxistitle = "VOLUME (" + Units(0).UnitName(Units(0).UnitSelected) + ")"
            curvevolunits = "(" + Units(0).UnitName(Units(0).UnitSelected) + ")"

            'Chart1.ChartAreas("ChartArea1").BackColor = Color.FromArgb(245, 255, 245)
            Chart1.ChartAreas("ChartArea1").BackColor = Color.Bisque

            Chart1.ChartAreas("ChartArea1").AxisX.Title = xaxistitle
            Chart1.ChartAreas("ChartArea1").AxisX.MajorGrid.LineColor = Color.Gray
            Chart1.ChartAreas("ChartArea1").AxisX.MinorGrid.LineColor = Color.LightGray
            Chart1.ChartAreas("ChartArea1").AxisX.TitleForeColor = Color.White
            Chart1.ChartAreas("ChartArea1").AxisX.LabelStyle.ForeColor = Color.White

            Chart1.ChartAreas("ChartArea1").AxisY.Title = yaxistitle
            Chart1.ChartAreas("ChartArea1").AxisY.MajorGrid.LineColor = Color.Gray
            Chart1.ChartAreas("ChartArea1").AxisY.MinorGrid.LineColor = Color.LightGray
            Chart1.ChartAreas("ChartArea1").AxisY.TitleForeColor = Color.White
            Chart1.ChartAreas("ChartArea1").AxisY.LabelStyle.ForeColor = Color.White

            'If ChkFanPower.Checked = True Then
            If Units(4).UnitSelected < 2 Then
                    y2axistitle = "POWER (" + Units(4).UnitName(Units(4).UnitSelected) + ")"
                    powunits = "(" + Units(4).UnitName(Units(4).UnitSelected) + ")"
                Else
                    If optDisplaykW.Checked = True Then
                        y2axistitle = "POWER (" + Units(4).UnitName(0) + ")"
                        powunits = "(" + Units(4).UnitName(0) + ")"
                    Else
                        y2axistitle = "POWER (" + Units(4).UnitName(1) + ")"
                        powunits = "(" + Units(4).UnitName(1) + ")"
                    End If
                End If
                powunits = Units(4).UnitName(1)
                Chart1.ChartAreas("ChartArea1").AxisY2.Title = y2axistitle
                Chart1.ChartAreas("ChartArea1").AxisY2.MajorGrid.LineColor = Color.Green
                Chart1.ChartAreas("ChartArea1").AxisY2.MinorGrid.LineColor = Color.LightGreen
                Chart1.ChartAreas("ChartArea1").AxisY2.TitleForeColor = Color.White
                Chart1.ChartAreas("ChartArea1").AxisY2.LabelStyle.ForeColor = Color.White
                Chart1.ChartAreas("ChartArea1").AxisY2.Enabled = DataVisualization.Charting.AxisEnabled.True
                Chart1.ChartAreas("ChartArea1").AxisY2.LabelStyle.Enabled = True
            'End If

        Catch ex As Exception

        End Try

    End Sub

    Public Sub plotStaticPV()
        Try
            Dim i As Integer

        ReDim plotvol(Num_Readings)
        ReDim plotfsp(Num_Readings)
        ReDim plotftp(Num_Readings)
        ReDim plotpow(Num_Readings)

        Chart1.Series.Add("Static Pressure")
        Chart1.Series("Static Pressure").Color = Color.Blue
        Chart1.Series("Static Pressure").ChartType = DataVisualization.Charting.SeriesChartType.Spline
        Chart1.Series("Static Pressure").ChartArea = "ChartArea1"

        ConvertPVtoChart()

        For i = 0 To Num_Readings - 1
            Chart1.Series("Static Pressure").Points.AddXY(plotvol(i), plotfsp(i))
        Next

        Chart1.ChartAreas(0).AxisX.Minimum = 0.0
        Chart1.Series.Add("Duty Point FSP")
        Chart1.Series("Duty Point FSP").IsVisibleInLegend = False
        Chart1.Series("Duty Point FSP").Color = Color.Green
        Chart1.Series("Duty Point FSP").ChartType = DataVisualization.Charting.SeriesChartType.Point
        Chart1.Series("Duty Point FSP").ChartArea = "ChartArea1"
            Chart1.Series("Duty Point FSP").Points.AddXY(selectedvol(fan2plot), selectedfsp(fan2plot))

        Catch ex As Exception

        End Try

    End Sub

    Public Sub plotTotalPV()
        Try
            Dim i As Integer

        ReDim plotvol(Num_Readings)
        ReDim plotfsp(Num_Readings)
        ReDim plotftp(Num_Readings)
        ReDim plotpow(Num_Readings)

        Chart1.Series.Add("Total Pressure")
        Chart1.Series("Total Pressure").Color = Color.Red
        Chart1.Series("Total Pressure").ChartType = DataVisualization.Charting.SeriesChartType.Spline
        Chart1.Series("Total Pressure").ChartArea = "ChartArea1"

        ConvertPVtoChart()

        For i = 0 To Num_Readings - 1
            Chart1.Series("Total Pressure").Points.AddXY(plotvol(i), plotftp(i))
        Next

        Chart1.ChartAreas(0).AxisX.Minimum = 0.0
        Chart1.Series.Add("Duty Point FTP")
        Chart1.Series("Duty Point FTP").IsVisibleInLegend = False
        Chart1.Series("Duty Point FTP").Color = Color.Green
        Chart1.Series("Duty Point FTP").ChartType = DataVisualization.Charting.SeriesChartType.Point
        Chart1.Series("Duty Point FTP").ChartArea = "ChartArea1"
            Chart1.Series("Duty Point FTP").Points.AddXY(selectedvol(fan2plot), selectedftp(fan2plot))

        Catch ex As Exception

        End Try

    End Sub

    Public Sub plotPower()
        Try
            Dim i As Integer

        ReDim plotvol(Num_Readings)
        ReDim plotfsp(Num_Readings)
        ReDim plotftp(Num_Readings)
        ReDim plotpow(Num_Readings)

        Chart1.Series.Add("Fan Power")
        Chart1.Series("Fan Power").YAxisType = DataVisualization.Charting.AxisType.Secondary

        Chart1.Series("Fan Power").Color = Color.Green
        Chart1.Series("Fan Power").ChartType = DataVisualization.Charting.SeriesChartType.Spline
        Chart1.Series("Fan Power").ChartArea = "ChartArea1"

        ConvertPVtoChart()

        For i = 0 To Num_Readings - 1
            Chart1.Series("Fan Power").Points.AddXY(plotvol(i), plotpow(i))
        Next

        Chart1.ChartAreas(0).AxisX.Minimum = 0.0

        Chart1.Series.Add("Duty Point Power")
        Chart1.Series("Duty Point Power").IsVisibleInLegend = False
        Chart1.Series("Duty Point Power").Color = Color.Green
        Chart1.Series("Duty Point Power").ChartType = DataVisualization.Charting.SeriesChartType.Point
        Chart1.Series("Duty Point Power").ChartArea = "ChartArea1"
        Chart1.Series("Duty Point Power").YAxisType = DataVisualization.Charting.AxisType.Secondary
            If optDisplaykW.Checked = True Then
                Chart1.Series("Duty Point Power").Points.AddXY(selectedvol(fan2plot), selectedpow(fan2plot))
            ElseIf optDisplayhp.Checked = True Then
                Chart1.Series("Duty Point Power").Points.AddXY(selectedvol(fan2plot), selectedpow2(fan2plot))
            Else
                Chart1.Series("Duty Point Power").Points.AddXY(selectedvol(fan2plot), selectedpow(fan2plot))
            End If

            If Units(4).UnitSelected < 2 Then
                y2axistitle = "POWER (" + Units(4).UnitName(Units(4).UnitSelected) + ")"
                powunits = "(" + Units(4).UnitName(Units(4).UnitSelected) + ")"
            Else
                If optDisplaykW.Checked = True Then
                    y2axistitle = "POWER (" + Units(4).UnitName(0) + ")"
                    powunits = "(" + Units(4).UnitName(0) + ")"
                Else
                    y2axistitle = "POWER (" + Units(4).UnitName(1) + ")"
                    powunits = "(" + Units(4).UnitName(1) + ")"
                End If
            End If
            Chart1.ChartAreas("ChartArea1").AxisY2.Title = y2axistitle
            Chart1.ChartAreas("ChartArea1").AxisY2.LabelStyle.Enabled = True
            Chart1.ChartAreas("ChartArea1").AxisY2.MajorGrid.Enabled = True
            Chart1.ChartAreas("ChartArea1").AxisY2.MinorGrid.Enabled = True

        Catch ex As Exception

        End Try

    End Sub

    Public Sub plotFanSystem()
        Try
            Dim i As Integer

        ReDim plotvol(Num_Readings)
        ReDim plotfsp(Num_Readings)
        ReDim plotftp(Num_Readings)
        ReDim plotpow(Num_Readings)

        Chart1.Series.Add("Fan System")
        Chart1.Series("Fan System").Color = Color.Black
        Chart1.Series("Fan System").ChartType = DataVisualization.Charting.SeriesChartType.Spline
        Chart1.Series("Fan System").BorderDashStyle = DataVisualization.Charting.ChartDashStyle.Dash
        Chart1.Series("Fan System").ChartArea = "ChartArea1"

        ConvertPVtoChart()

        Dim temppres(105) As Double
        Chart1.Series("Fan System").Points.AddXY(0.0, 0.0)
        Dim tempvol(105) As Double
        Dim voltemp As Double
        voltemp = (selectedvol(fan2plot) * 1.0) / 100
        For i = 0 To 105
                tempvol(i) = voltemp * i
                If PresType = 0 Then
                    temppres(i) = Math.Pow(tempvol(i) / selectedvol(fan2plot), 2) * selectedfsp(fan2plot)
                Else
                    temppres(i) = Math.Pow(tempvol(i) / selectedvol(fan2plot), 2) * selectedftp(fan2plot)
                End If
                'temppres(i) = Math.Pow(tempvol(i) / selectedvol(fan2plot), 2) * selectedftp(fan2plot)
                'temppres(i) = Math.Pow(tempvol(i) / selectedvol(fan2plot), 2) * selectedfsp(fan2plot)
                Chart1.Series("Fan System").Points.AddXY(tempvol(i), temppres(i))
            i = i + 1
        Next
            Chart1.ChartAreas(0).AxisX.Minimum = 0.0

        Catch ex As Exception

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

            If Units(4).UnitSelected = 0 Then plotpow(i) = Pow_kw(i)
            If Units(4).UnitSelected = 1 Then plotpow(i) = Pow_hp(i)
            If optDisplaykW.Checked = True Then plotpow(i) = Pow_kw(i)
            If optDisplayhp.Checked = True Then plotpow(i) = Pow_hp(i)
            plotpow(i) = plotpow(i) * getscalefactor()

        Next

            For i = 0 To Num_Readings - 1
                '-scaling for fan size
                plotvol(i) = scaleVFSize(plotvol(i), FanSize1, selectedfansize(fan2plot))
                plotfsp(i) = scalePFSize(plotfsp(i), FanSize1, selectedfansize(fan2plot))
                plotftp(i) = scalePFSize(plotftp(i), FanSize1, selectedfansize(fan2plot))
                plotpow(i) = scalePowFSize(plotpow(i), FanSize1, selectedfansize(fan2plot))
                '-scaling for fan speed
                plotvol(i) = scaleVFSpeed(plotvol(i), FanSpeed1, selectedspeed(fan2plot))
                plotfsp(i) = scalePFSpeed(plotfsp(i), FanSpeed1, selectedspeed(fan2plot))
                plotftp(i) = scalePFSpeed(plotftp(i), FanSpeed1, selectedspeed(fan2plot))
                plotpow(i) = ScalePowFSpeed(plotpow(i), FanSpeed1, selectedspeed(fan2plot))

                plotpow(i) = plotpow(i) / temp_kp
            Next

        Catch ex As Exception

        End Try

    End Sub

    Public Sub PlotDutyPoint()
        Try

            'Chart1.Series("Duty Point").Points.AddXY(selectedvol(fan2plot), selectedfsp(fan2plot))
            'Chart1.Series("Duty Point").Points.AddXY(selectedvol(fan2plot), selectedftp(fan2plot))
            'Chart1.Series("Duty Point").Points.AddXY(selectedvol(fan2plot), selectedpow(fan2plot))

        Catch ex As Exception

        End Try

    End Sub

    Public Sub RemoveStaticCurve()
        Try
            Dim series1 As DataVisualization.Charting.Series = Chart1.Series("Static Pressure")
        Chart1.Series.Remove(series1)
        Dim series2 As DataVisualization.Charting.Series = Chart1.Series("Duty Point FSP")
        Chart1.Series.Remove(series2)

        Catch ex As Exception

        End Try
    End Sub

    Public Sub RemoveTotalCurve()
        Try
            Dim series1 As DataVisualization.Charting.Series = Chart1.Series("Total Pressure")
        Chart1.Series.Remove(series1)
        'Chart1.Series("Total Pressure").Enabled = False
        Dim series2 As DataVisualization.Charting.Series = Chart1.Series("Duty Point FTP")
        Chart1.Series.Remove(series2)
            'SeriesAdded = False

        Catch ex As Exception

        End Try

    End Sub

    Public Sub RemoveFanSystemCurve()
        Try
            Dim series1 As DataVisualization.Charting.Series = Chart1.Series("Fan System")
        Chart1.Series.Remove(series1)
            ''Chart1.Series("Total Pressure").Enabled = False
            'Dim series2 As DataVisualization.Charting.Series = Chart1.Series("Duty Point FTP")
            'Chart1.Series.Remove(series2)
            ''SeriesAdded = False

        Catch ex As Exception

        End Try

    End Sub

    Public Sub RemovePowerCurve()
        Try
            Dim series1 As DataVisualization.Charting.Series = Chart1.Series("Fan Power")
        Chart1.Series.Remove(series1)
        'Chart1.Series("Total Pressure").Enabled = False
        Dim series2 As DataVisualization.Charting.Series = Chart1.Series("Duty Point Power")
            Chart1.Series.Remove(series2)
            'SeriesAdded = False
            Chart1.ChartAreas("ChartArea1").AxisY2.LabelStyle.Enabled = False
            Chart1.ChartAreas("ChartArea1").AxisY2.MajorGrid.Enabled = False
            Chart1.ChartAreas("ChartArea1").AxisY2.MinorGrid.Enabled = False
            Chart1.ChartAreas("ChartArea1").AxisY2.Title = ""


        Catch ex As Exception

        End Try

    End Sub

    Private Sub ChkStaticPressureCurve_Click(sender As Object, e As EventArgs) Handles ChkStaticPressureCurve.Click
        Try
            If ChkStaticPressureCurve.Checked = True Then
                plotStaticPV()
            Else
                RemoveStaticCurve()
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ChkTotalPressureCurve_Click(sender As Object, e As EventArgs) Handles ChkTotalPressureCurve.Click
        Try
            If ChkTotalPressureCurve.Checked = True Then
                plotTotalPV()
            Else
                RemoveTotalCurve()
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ChkFanPower_Click(sender As Object, e As EventArgs) Handles ChkFanPower.Click
        Try
            If ChkFanPower.Checked = True Then
                plotPower()
            Else
                RemovePowerCurve()
            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub ChkFanSystemCurve_Click(sender As Object, e As EventArgs) Handles ChkFanSystemCurve.Click
        Try
            If ChkFanSystemCurve.Checked = True Then
                plotFanSystem()
            Else
                RemoveFanSystemCurve()
            End If

        Catch ex As Exception

        End Try

    End Sub

    '#################### Button functions
    Private Sub btnPrintDocument_Click(sender As Object, e As EventArgs) Handles btnPrintDocument.Click
        Try
            PrintDocument1.Print()
            'PageSetupDialog1.PageSettings.PaperSize(210, 297)

        Catch ex As Exception

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

        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Try
            Close()

        Catch ex As Exception

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
            'MsgBox(filename + " read " + fanno.ToString)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub optDisplaykW_Click(sender As Object, e As EventArgs) Handles optDisplaykW.Click
        Try
            Chart1.Series.Clear()
            getaxislabels()
            PlotTheCurve()
            If ChkFanSystemCurve.Checked = False Then RemoveFanSystemCurve()
            If ChkTotalPressureCurve.Checked = False Then RemoveTotalCurve()
            If ChkStaticPressureCurve.Checked = False Then RemoveStaticCurve()
            If ChkFanPower.Checked = False Then RemovePowerCurve()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub optDisplayhp_Click(sender As Object, e As EventArgs) Handles optDisplayhp.Click
        Try
            Chart1.Series.Clear()
        getaxislabels()
        PlotTheCurve()
        If ChkFanSystemCurve.Checked = False Then RemoveFanSystemCurve()
        If ChkTotalPressureCurve.Checked = False Then RemoveTotalCurve()
        If ChkStaticPressureCurve.Checked = False Then RemoveStaticCurve()
            If ChkFanPower.Checked = False Then RemovePowerCurve()

        Catch ex As Exception

        End Try

    End Sub


    'Private Class printer
    '    Friend Function PaperSize() As Object
    '        Throw New NotImplementedException
    '    End Function
    'End Class
End Class