Imports Word = Microsoft.Office.Interop.Word
Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office
'Imports System.IO
'Imports System.Resources
Imports System.Xml
'Imports System.Windows.Forms
Imports System.Drawing.Printing

Module ModPrinting
    Public Sub CreateFile(filename_read As String, filename_write As String, previewonly As Boolean, charfind As Char, Optional filename_excel As String = "")
        Try
            count = 0
            Dim found_one As Boolean = False
            Dim i As Integer

            For i = 0 To 500
                Found(i).labelstring = ""
            Next

            Dim charcount As Integer = 0
            Dim j As Integer = 0

            Using reader As New System.IO.StreamReader(filename_read)
                While Not reader.EndOfStream
                    Dim buffer(1) As Char
                    reader.Read(buffer, 0, 1)
                    outfile(charcount) = buffer(0)
                    charcount = charcount + 1
                    If buffer(0) = charfind And found_one = False Then
                        found_one = True
                        Found(count).startpoint = charcount - 1
                    ElseIf buffer(0) = charfind And found_one = True Then
                        found_one = False
                        Found(count).labelstring = Found(count).labelstring + buffer(0)
                        Found(count).endpoint = charcount - 1
                        count = count + 1
                    End If
                    If found_one = True Then
                        Found(count).labelstring = Found(count).labelstring + buffer(0)
                    End If
                End While
            End Using

            Dim objWriter As New System.IO.StreamWriter(filename_write)
            Dim startpoint As Integer
            Dim endpoint As Integer
            For j = 0 To count - 1
                If j = 0 Then
                    startpoint = 0
                    endpoint = Found(j).startpoint - 1
                    For i = startpoint To endpoint
                        objWriter.Write(outfile(i))
                    Next
                    objWriter.Write(bookmark(Found(j).labelstring))
                    'objWriter.Write(bookmark2(Found(j).labelstring))
                Else
                    startpoint = Found(j - 1).endpoint + 1
                    endpoint = Found(j).startpoint - 1
                    For i = startpoint To endpoint
                        objWriter.Write(outfile(i))
                    Next
                    objWriter.Write(bookmark(Found(j).labelstring))
                    'objWriter.Write(bookmark2(Found(j).labelstring))
                End If
            Next
            startpoint = Found(count - 1).endpoint + 1
            endpoint = charcount - 1
            For i = startpoint To endpoint
                objWriter.Write(outfile(i))
            Next
            'If filename_excel.Length > 0 Then
            '    curvetoexcel(filename_excel)
            'End If
            objWriter.Close()

            'Cursor = Cursors.WaitCursor
            Dim oWord As Word.Application
            Dim oDoc As Word.Document
            oWord = CreateObject("Word.Application")
            oWord.Visible = previewonly
            oDoc = oWord.Documents.Add(filename_write)
            'Cursor = Cursors.Default
            If previewonly = False Then
                Dim printDlg As New PrintDialog()
                Dim printDoc As New PrintDocument()
                printDoc.DocumentName = filename
                printDlg.Document = printDoc
                printDlg.PrinterSettings = printDoc.PrinterSettings
                printDlg.AllowSomePages = True
                If printDlg.ShowDialog = DialogResult.OK Then
                    printDoc.PrinterSettings = printDlg.PrinterSettings
                    printDoc.Print()
                End If
            End If
        Catch ex As Exception
            ErrorMessage(ex, 6401)
            'MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub curvetoexcel(filename_excel As String)

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


    End Sub


    Public Function bookmark(label As String) As String
        Dim templabel As String
        Dim lenconv As Double = 1.0
        If Units(5).UnitSelected = 1 Then lenconv = 1.0 / 25.4
        Try
            If label = "#size#" Then Return label.Replace("#size#", final.fansize.ToString)
            If label = "#design#" Then Return label.Replace("#design#", final.fantype.ToString)
            If label = "#flow#" Then Return label.Replace("#flow#", flowrate.ToString)
            If label = "#flow_units#" Then Return label.Replace("#flow_units#", Units(0).UnitName(Units(0).UnitSelected))
            If label = "#density#" Then Return label.Replace("#density#", knowndensity.ToString)
            If label = "#density_units#" Then Return label.Replace("#density_units#", Units(3).UnitName(Units(3).UnitSelected))
            If label = "#ftp#" Then Return label.Replace("#ftp#", final.ftp.ToString)
            If label = "#fsp#" Then Return label.Replace("#fsp#", final.fsp.ToString)
            If label = "#pressure_units#" Then Return label.Replace("#pressure_units#", Units(1).UnitName(Units(1).UnitSelected))
            If label = "#rpm#" Then Return label.Replace("#rpm#", final.speed.ToString)
            If label = "#pwr#" Then Return label.Replace("#pwr#", final.pow.ToString)
            If label = "#pwr_u#" Then Return label.Replace("#pwr_u#", Units(4).UnitName(Units(4).UnitSelected))
            If label = "#ov#" Then Return label.Replace("#ov#", final.ov.ToString)
            If label = "#ov_units#" Then Return label.Replace("#ov_units#", Units(7).UnitName(Units(7).UnitSelected))
            If label = "#motor#" Then Return label.Replace("#motor#", final.mot.ToString)
            If label = "#fse#" Then Return label.Replace("#fse#", final.fse.ToString)
            If label = "#fte#" Then Return label.Replace("#fte#", final.fte.ToString)
            If label.Contains("#swl_1_") Then
                For i = 1 To 8
                    templabel = "#swl_1_" + i.ToString + "#"
                    If label = templabel Then Return templabel.Replace(templabel, IDSPL(i - 1).ToString)
                Next
            End If
            If label = "#swl_oa#" Then Return label.Replace("#swl_oa#", spl2.ToString)
            If label = "#swl_bo#" Then Return label.Replace("#swl_bo#", bospl2.ToString)
            If label = "#spl_bo#" Then Return label.Replace("#spl_bo#", bospl1M2.ToString)
            If label.Contains("#spl_1_") Then
                For i = 1 To 8
                    templabel = "#spl_1_" + i.ToString + "#"
                    If label = templabel Then Return templabel.Replace(templabel, Ascale(i - 1).ToString)
                Next
            End If
            If label = "#spl_bo_oa#" Then Return label.Replace("#spl_bo_oa#", NCoverall.ToString)
            If label = "#india#" Then Return label.Replace("#india#", Math.Round(final.inletdia * lenconv, lengthdecplaces).ToString)
            If label = "#in_units#" Then Return label.Replace("#in_units#", Units(5).UnitName(Units(5).UnitSelected))
            If label.Contains("#spl_2_") Then
                For i = 1 To 8
                    templabel = "#spl_2_" + i.ToString + "#"
                    If label = templabel Then Return templabel.Replace(templabel, INascale(i - 1).ToString)
                Next
            End If
            If label = "#spl_oi_oa#" Then Return label.Replace("#spl_oi_oa#", Math.Round(inNCoverall).ToString)
            If label = "#outlen#" Then Return label.Replace("#outlen#", Math.Round(final.outletlen * lenconv, lengthdecplaces).ToString)
            If label = "#outwid#" Then Return label.Replace("#outwid#", Math.Round(final.outletwid * lenconv, lengthdecplaces).ToString)
            If label = "#out_units#" Then Return label.Replace("#out_units#", Units(5).UnitName(Units(5).UnitSelected))
            If label.Contains("#spl_3_") Then
                For i = 1 To 8
                    templabel = "#spl_3_" + i.ToString + "#"
                    If label = templabel Then Return templabel.Replace(templabel, OUTascale(i - 1).ToString)
                Next
            End If
            If label = "#spl_oo_oa#" Then Return label.Replace("#spl_oo_oa#", Math.Round(OUTNCoverall).ToString)
            If label = "#bpf#" Then Return label.Replace("#bpf#", BPfreq.ToString)
            If label = "#brg_noise#" Then Return label.Replace("#brg_noise#", BRGnoise.ToString)
            Dim tempmt As Double = 0
            If Frmselectfan.txtMotordba.Text IsNot "" Then tempmt = CDbl(Frmselectfan.txtMotordba.Text)
            If label = "#motor_noise#" Then Return label.Replace("#motor_noise#", tempmt.ToString)
            '"Motor_Noise", tempmt.ToString)
            'Return tempmt.ToString
            If label = "#engineer#" Then Return "A K McInnes"
            If label = "#date#" Then Return Today.ToString("dd-MM-yyyy")
            'Return TableEntry(label, "#1_", 1)
            If label.Contains("#1_") Then
                For i = 1 To Num_Readings
                    templabel = "#1_" + i.ToString + "#"
                    If label = templabel Then
                        If plotvol(i - 1) > 0.0 Then
                            Return templabel.Replace(templabel, Math.Round(plotvol(i - 1), 1).ToString)
                        Else
                            Return templabel.Replace(templabel, "")
                        End If
                    End If
                Next
                For i = Num_Readings To 30
                    templabel = "#1_" + i.ToString + "#"
                    If label = templabel Then
                        Return templabel.Replace(templabel, "")
                    End If
                Next
            End If
            If label.Contains("#2_") Then
                For i = 1 To Num_Readings
                    templabel = "#2_" + i.ToString + "#"
                    If label = templabel Then
                        If plotfsp(i - 1) > 0.0 Then
                            Return templabel.Replace(templabel, Math.Round(plotfsp(i - 1), 1).ToString)
                        Else
                            Return templabel.Replace(templabel, "")
                        End If
                    End If
                Next
                For i = Num_Readings To 30
                    templabel = "#2_" + i.ToString + "#"
                    If label = templabel Then
                        Return templabel.Replace(templabel, "")
                    End If
                Next
            End If
            If label.Contains("#3_") Then
                For i = 1 To Num_Readings
                    templabel = "#3_" + i.ToString + "#"
                    If label = templabel Then
                        If plotftp(i - 1) > 0.0 Then
                            Return templabel.Replace(templabel, Math.Round(plotftp(i - 1), 1).ToString)
                        Else
                            Return templabel.Replace(templabel, "")
                        End If
                    End If
                Next
                For i = Num_Readings To 30
                    templabel = "#3_" + i.ToString + "#"
                    If label = templabel Then
                        Return templabel.Replace(templabel, "")
                    End If
                Next
            End If
            If label.Contains("#4_") Then
                For i = 1 To Num_Readings
                    templabel = "#4_" + i.ToString + "#"
                    If label = templabel Then
                        If plotpow(i - 1) > 0.0 Then
                            Return templabel.Replace(templabel, Math.Round(plotpow(i - 1), 1).ToString)
                        Else
                            Return templabel.Replace(templabel, "")
                        End If
                    End If
                Next
                For i = Num_Readings To 30
                    templabel = "#4_" + i.ToString + "#"
                    If label = templabel Then
                        Return templabel.Replace(templabel, "")
                    End If
                Next
            End If
            If label.Contains("#5_") Then
                For i = 1 To Num_Readings
                    templabel = "#5_" + i.ToString + "#"
                    If label = templabel Then
                        If plotfse(i - 1) > 0.0 Then
                            Return templabel.Replace(templabel, Math.Round(plotfse(i - 1), 2).ToString)
                        Else
                            Return templabel.Replace(templabel, "")
                        End If
                    End If
                Next
                For i = Num_Readings To 30
                    templabel = "#5_" + i.ToString + "#"
                    If label = templabel Then
                        Return templabel.Replace(templabel, "")
                    End If
                Next
            End If
            If label.Contains("#6_") Then
                For i = 1 To Num_Readings
                    templabel = "#6_" + i.ToString + "#"
                    If label = templabel Then
                        If plotfte(i - 1) > 0.0 Then
                            Return templabel.Replace(templabel, Math.Round(plotfte(i - 1), 2).ToString)
                        Else
                            Return templabel.Replace(templabel, "")
                        End If
                    End If
                Next
                For i = Num_Readings To 30
                    templabel = "#6_" + i.ToString + "#"
                    If label = templabel Then
                        Return templabel.Replace(templabel, "")
                    End If
                Next
            End If
            If label.Contains("#7_") Then
                For i = 1 To Num_Readings
                    templabel = "#7_" + i.ToString + "#"
                    If label = templabel Then
                        If plotov(i - 1) > 0.0 Then
                            Return templabel.Replace(templabel, Math.Round(plotov(i - 1), 2).ToString)
                        Else
                            Return templabel.Replace(templabel, "")
                        End If
                    End If
                Next
                For i = Num_Readings To 30
                    templabel = "#7_" + i.ToString + "#"
                    If label = templabel Then
                        Return templabel.Replace(templabel, "")
                    End If
                Next
            End If
        Catch ex As Exception
            ErrorMessage(ex, 6402)
        End Try
        If StartArg.Contains("-dev") Then
            Return "hello"
        Else
            Return ""
        End If
    End Function


    Public Function TableEntry(label As String, labelbit As String, info As String)
        Dim templabel As String
        Dim infovalues(Num_Readings) As Double
        Try
            infovalues = plotvol
            If label.Contains(labelbit) Then
                For i = 1 To Num_Readings
                    templabel = labelbit + i.ToString + "#"
                    If label = templabel Then
                        If plotvol(i - 1) > 0.0 Then
                            Return templabel.Replace(templabel, Math.Round(plotvol(i - 1), 1).ToString)
                        Else
                            Return templabel.Replace(templabel, "")
                        End If
                    End If
                Next
                For i = Num_Readings To 30
                    templabel = label + i.ToString + "#"
                    If label = templabel Then
                        Return templabel.Replace(templabel, "")
                    End If
                Next
            End If
        Catch ex As Exception
            ErrorMessage(ex, 6403)
        End Try
        If StartArg.Contains("-dev") Then
            Return "hello"
        Else
            Return ""
        End If
    End Function
End Module
