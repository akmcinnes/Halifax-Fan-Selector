Imports System.IO
Imports System.Drawing.Printing
Public Class FrmFanChart
    Public SeriesAdded As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub FanChart_Load(sender As Object, e As EventArgs) Handles Me.Load
        SeriesAdded = False
        fan2plot = 0
        Do While fanclass(fan2plot) <> Me.Text
            fan2plot = fan2plot + 1
        Loop

        getaxislabels()
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
        'plotFanSystem()
        Chart1.ChartAreas("ChartArea1").AxisX.MinorGrid.Interval = Chart1.ChartAreas("ChartArea1").AxisX.MajorGrid.Interval / 10.0
        Chart1.ChartAreas("ChartArea1").AxisX.MinorGrid.Enabled = True
        Chart1.ChartAreas("ChartArea1").AxisY.MinorGrid.Interval = Chart1.ChartAreas("ChartArea1").AxisY.MajorGrid.Interval / 10.0
        Chart1.ChartAreas("ChartArea1").AxisY.MinorGrid.Enabled = True

    End Sub

    Function getaxislabels()
        getaxislabels = ""
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
        y2axistitle = "POWER (" + Units(4).UnitName(Units(4).UnitSelected) + ")"
        powunits = "(" + Units(4).UnitName(Units(4).UnitSelected) + ")"

        'Chart1.Series.RemoveAt(0)

        'Chart1.Series("Series1").ChartArea = "Pressure v Volume"
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

        Chart1.ChartAreas("ChartArea1").AxisY2.Title = y2axistitle
        Chart1.ChartAreas("ChartArea1").AxisY2.MajorGrid.LineColor = Color.Green
        Chart1.ChartAreas("ChartArea1").AxisY2.MinorGrid.LineColor = Color.LightGreen
        Chart1.ChartAreas("ChartArea1").AxisY2.TitleForeColor = Color.White
        Chart1.ChartAreas("ChartArea1").AxisY2.LabelStyle.ForeColor = Color.White
        'Chart1.ChartAreas("ChartArea1").AxisY2.Enabled = True
        Chart1.ChartAreas("ChartArea1").AxisY2.Enabled = DataVisualization.Charting.AxisEnabled.True
        Chart1.ChartAreas("ChartArea1").AxisY2.LabelStyle.Enabled = True

        'Dim xaxis_label As String

    End Function

    Public Sub plotStaticPV()
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

        'If SeriesAdded = False Then
        Chart1.Series.Add("Duty Point FSP")
        'Chart1.Series("Duty Point FSP").Legend = "Duty Point FSP"
        Chart1.Series("Duty Point FSP").IsVisibleInLegend = False
        Chart1.Series("Duty Point FSP").Color = Color.Green
        Chart1.Series("Duty Point FSP").ChartType = DataVisualization.Charting.SeriesChartType.Point
        Chart1.Series("Duty Point FSP").ChartArea = "ChartArea1"
        '    SeriesAdded = True
        'End If
        Chart1.Series("Duty Point FSP").Points.AddXY(selectedvol(fan2plot), selectedfsp(fan2plot))

        'PlotDutyPoint()
    End Sub

    Public Sub plotTotalPV()
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

        'Chart1.Series("Duty Point FTP").Points.AddXY(selectedvol(fan2plot), selectedfsp(fan2plot))

        'If SeriesAdded = False Then
        Chart1.Series.Add("Duty Point FTP")
        'Chart1.Series("Duty Point FTP").Legend = "Duty Point FTP"
        Chart1.Series("Duty Point FTP").IsVisibleInLegend = False
        Chart1.Series("Duty Point FTP").Color = Color.Green
        Chart1.Series("Duty Point FTP").ChartType = DataVisualization.Charting.SeriesChartType.Point
        Chart1.Series("Duty Point FTP").ChartArea = "ChartArea1"
        '    SeriesAdded = True
        'End If

        Chart1.Series("Duty Point FTP").Points.AddXY(selectedvol(fan2plot), selectedftp(fan2plot))

        'PlotDutyPoint()


    End Sub

    Public Sub plotPower()
        Dim i As Integer

        ReDim plotvol(Num_Readings)
        ReDim plotfsp(Num_Readings)
        ReDim plotftp(Num_Readings)
        ReDim plotpow(Num_Readings)

        Chart1.Series.Add("Fan Power")
        Chart1.Series("Fan Power").YAxisType = DataVisualization.Charting.AxisType.Secondary

        Chart1.Series("Fan Power").Color = Color.Green
        'Chart1.Series("Fan Power").
        Chart1.Series("Fan Power").ChartType = DataVisualization.Charting.SeriesChartType.Spline
        Chart1.Series("Fan Power").ChartArea = "ChartArea1"

        ConvertPVtoChart()

        For i = 0 To Num_Readings - 1
            Chart1.Series("Fan Power").Points.AddXY(plotvol(i), plotpow(i))
        Next

        Chart1.ChartAreas(0).AxisX.Minimum = 0.0

        'If SeriesAdded = False Then
        Chart1.Series.Add("Duty Point Power")
        'Chart1.Series("Duty Point Power").Legend = "Duty Point Power"
        Chart1.Series("Duty Point Power").IsVisibleInLegend = False
        Chart1.Series("Duty Point Power").Color = Color.Green
        Chart1.Series("Duty Point Power").ChartType = DataVisualization.Charting.SeriesChartType.Point
        Chart1.Series("Duty Point Power").ChartArea = "ChartArea1"
        '    SeriesAdded = True
        'End If
        Chart1.Series("Duty Point Power").YAxisType = DataVisualization.Charting.AxisType.Secondary
        Chart1.Series("Duty Point Power").Points.AddXY(selectedvol(fan2plot), selectedpow(fan2plot))
        'PlotDutyPoint()

    End Sub

    Public Sub plotFanSystem()
        Dim i As Integer

        ReDim plotvol(Num_Readings)
        ReDim plotfsp(Num_Readings)
        ReDim plotftp(Num_Readings)
        ReDim plotpow(Num_Readings)

        Chart1.Series.Add("Fan System")
        Chart1.Series("Fan System").Color = Color.Black
        Chart1.Series("Fan System").ChartType = DataVisualization.Charting.SeriesChartType.Spline
        Chart1.Series("Fan System").BorderDashStyle = DataVisualization.Charting.ChartDashStyle.DashDotDot
        Chart1.Series("Fan System").ChartArea = "ChartArea1"

        ConvertPVtoChart()

        Dim temppres As Double
        For i = 0 To Num_Readings - 1
            If plotvol(i) * 0.9 <= selectedvol(fan2plot) Then
                temppres = Math.Pow(plotvol(i) / selectedvol(fan2plot), 2) * selectedftp(fan2plot)
                Chart1.Series("Fan System").Points.AddXY(plotvol(i), temppres)
            End If
        Next

        Chart1.ChartAreas(0).AxisX.Minimum = 0.0

        'Chart1.Series("Duty Point FTP").Points.AddXY(selectedvol(fan2plot), selectedfsp(fan2plot))

        ''If SeriesAdded = False Then
        'Chart1.Series.Add("Fan System TP")
        ''Chart1.Series("Fan System TP").Legend = "Fan System TP"
        'Chart1.Series("Fan System TP").IsVisibleInLegend = False
        'Chart1.Series("Fan System TP").Color = Color.Black
        'Chart1.Series("Fan System TP").ChartType = DataVisualization.Charting.SeriesChartType.Point
        'Chart1.Series("Fan System TP").ChartArea = "ChartArea1"
        ''    SeriesAdded = True
        ''End If

        'Chart1.Series("Fan System TP").Points.AddXY(selectedvol(fan2plot), selectedftp(fan2plot))

        ''PlotDutyPoint()


    End Sub

    Public Sub ConvertPVtoChart()

        ReDim plotvol(Num_Readings)
        ReDim plotfsp(Num_Readings)
        ReDim plotftp(Num_Readings)
        ReDim plotpow(Num_Readings)

        For i = 0 To Num_Readings - 1
            If Units(1).UnitSelected = 0 Then plotfsp(i) = FSP_pa(i)
            If Units(1).UnitSelected = 1 Then plotfsp(i) = FSP_insWG(i)
            If Units(1).UnitSelected = 2 Then plotfsp(i) = FSP_mmwg(i)
            If Units(1).UnitSelected = 3 Then plotfsp(i) = FSP_mbar(i)

            If Units(1).UnitSelected = 0 Then plotftp(i) = FTP_pa(i)
            If Units(1).UnitSelected = 1 Then plotftp(i) = FTP_insWG(i)
            If Units(1).UnitSelected = 2 Then plotftp(i) = FTP_mmWG(i)
            If Units(1).UnitSelected = 3 Then plotftp(i) = FTP_mbar(i)

            If Units(0).UnitSelected = 0 Then plotvol(i) = Vol_m3hr(i)
            If Units(0).UnitSelected = 1 Then plotvol(i) = Vol_m3min(i)
            If Units(0).UnitSelected = 2 Then plotvol(i) = Vol_m3sec(i)
            If Units(0).UnitSelected = 3 Then plotvol(i) = Vol_cfm(i)

            If Units(4).UnitSelected = 0 Then plotpow(i) = Pow_kw(i)
            If Units(4).UnitSelected = 1 Then plotpow(i) = Pow_hp(i)

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
            plotpow(i) = scalePowFSpeed(plotpow(i), FanSpeed1, selectedspeed(fan2plot))
        Next
    End Sub

    Public Sub PlotDutyPoint()

        'Chart1.Series("Duty Point").Points.AddXY(selectedvol(fan2plot), selectedfsp(fan2plot))
        'Chart1.Series("Duty Point").Points.AddXY(selectedvol(fan2plot), selectedftp(fan2plot))
        'Chart1.Series("Duty Point").Points.AddXY(selectedvol(fan2plot), selectedpow(fan2plot))

    End Sub

    Public Sub RemoveStaticCurve()
        Dim series1 As DataVisualization.Charting.Series = Chart1.Series("Static Pressure")
        Chart1.Series.Remove(series1)
        'Chart1.Series("Static Pressure").Enabled = False
        Dim series2 As DataVisualization.Charting.Series = Chart1.Series("Duty Point FSP")
        Chart1.Series.Remove(series2)
        'SeriesAdded = False
    End Sub

    Public Sub RemoveTotalCurve()
        Dim series1 As DataVisualization.Charting.Series = Chart1.Series("Total Pressure")
        Chart1.Series.Remove(series1)
        'Chart1.Series("Total Pressure").Enabled = False
        Dim series2 As DataVisualization.Charting.Series = Chart1.Series("Duty Point FTP")
        Chart1.Series.Remove(series2)
        'SeriesAdded = False
    End Sub

    Public Sub RemoveFanSystemCurve()
        Dim series1 As DataVisualization.Charting.Series = Chart1.Series("Fan System")
        Chart1.Series.Remove(series1)
        ''Chart1.Series("Total Pressure").Enabled = False
        'Dim series2 As DataVisualization.Charting.Series = Chart1.Series("Duty Point FTP")
        'Chart1.Series.Remove(series2)
        ''SeriesAdded = False
    End Sub

    Public Sub RemovePowerCurve()
        Dim series1 As DataVisualization.Charting.Series = Chart1.Series("Fan Power")
        Chart1.Series.Remove(series1)
        'Chart1.Series("Total Pressure").Enabled = False
        Dim series2 As DataVisualization.Charting.Series = Chart1.Series("Duty Point Power")
        Chart1.Series.Remove(series2)
        'SeriesAdded = False
    End Sub

    Private Sub ChkStaticPressureCurve_Click(sender As Object, e As EventArgs) Handles ChkStaticPressureCurve.Click
        If ChkStaticPressureCurve.Checked = True Then
            plotStaticPV()
        Else
            RemoveStaticCurve()
        End If
    End Sub

    Private Sub ChkTotalPressureCurve_Click(sender As Object, e As EventArgs) Handles ChkTotalPressureCurve.Click
        If ChkTotalPressureCurve.Checked = True Then
            plotTotalPV()
        Else
            RemoveTotalCurve()
        End If
    End Sub

    Private Sub ChkFanPower_Click(sender As Object, e As EventArgs) Handles ChkFanPower.Click
        If ChkFanPower.Checked = True Then
            plotPower()
        Else
            RemovePowerCurve()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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
    End Sub

    Private Sub ChkFanSystemCurve_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFanSystemCurve.CheckedChanged
        If ChkFanSystemCurve.Checked = True Then
            plotFanSystem()
        Else
            RemoveFanSystemCurve()
        End If

    End Sub
    'Private Class printer
    '    Friend Function PaperSize() As Object
    '        Throw New NotImplementedException
    '    End Function
    'End Class
End Class