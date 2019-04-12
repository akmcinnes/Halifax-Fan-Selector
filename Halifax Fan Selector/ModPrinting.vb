Imports Word = Microsoft.Office.Interop.Word
Imports Excel = Microsoft.Office.Interop.Excel
'Imports Microsoft.Office.Interop.Excel.Constants

Imports Microsoft.Office
'Imports System.IO
'Imports System.Resources
Imports System.Xml
'Imports System.Windows.Forms
Imports System.Drawing.Printing

Module ModPrinting
    Public Sub CreateFile(filename_read As String, filename_write As String, previewonly As Boolean, charfind As Char, Optional filename_excel As String = "")
        Try
            getLanguageDictionary()
            PopulatePrintout()
            Exit Sub


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

    Public Sub getLanguageDictionary()
        Try
            ' read language dictionary
            Dim xlsApp As Excel.Application = Nothing
        Dim xlsWorkBooks As Excel.Workbooks = Nothing
        Dim xlsWB As Excel.Workbook = Nothing

        Dim filename_lang_dict As String = TemplatesPathDefault + "Halifax Output Dictionary.xlsx"

        xlsApp = New Microsoft.Office.Interop.Excel.Application
        xlsApp.Visible = False
        xlsWorkBooks = xlsApp.Workbooks
        xlsWB = xlsWorkBooks.Open(filename_lang_dict)

        Dim ii As Integer
        For ii = 1 To 150
            lang_dict(ii) = xlsWB.Worksheets(ChosenLanguage).Cells(ii, 1).Value
            'lang_dict(ii - 1) = xlsWB.Worksheets(ChosenLanguage).Cells(ii + 2, 2).Value
        Next
        xlsWB.Close(SaveChanges:=False)
        xlsWB = Nothing
        xlsWorkBooks.Close()
        xlsWorkBooks = Nothing
        xlsApp.Quit()
        xlsApp = Nothing

        Catch ex As Exception
            ErrorMessage(ex, 64021)

        End Try
    End Sub

    Sub PopulatePrintout()
        Try
            Dim xlsApp As Excel.Application = Nothing
            Dim xlsWorkBooks As Excel.Workbooks = Nothing
            Dim xlsWB As Excel.Workbook = Nothing

            Dim filename_printout As String = TemplatesPathDefault + "Output Template.xlsx"
            'Dim ContactDetails, Address As String

            'ContactDetails = "Tel:- " & "+44(0)1484 475123" & "       email:- " & "sales@halifax-fan.com"
            'Address = "Brookfoot Business Park, Brighouse" & ", " & "West Yorks, United Kingdom, HD6 2SD"

            xlsApp = New Microsoft.Office.Interop.Excel.Application
            xlsApp.Visible = False
            xlsWorkBooks = xlsApp.Workbooks
            xlsWB = xlsWorkBooks.Open(filename_printout)

            xlsWB.ActiveSheet.Name = "Sound"
            With xlsWB.ActiveSheet
                .Activate
                .Range("A1:Z250").Font.Name = "Arial"
                .Range("A1:Z250").Font.size = 10
                .Range("A1:Z250").WrapText = False
                .Columns("A:Z").ColumnWidth = 5
                '.Shapes.AddShape(msoTextOrientationHorizontal, 315, 5, 174, 48).Fill.UserPicture(headerlocation)
                '.Shapes(1).Line.Visible = False
                '.Cells(1, 1).Value = "Halifax Fan Ltd."
                '.Cells(1, 1).Font.size = 11
                '.Cells(1, 1).Font.Bold = True
                '.Cells(2, 1).Value = Address
                '.Cells(2, 1).Font.size = 8
                '.Cells(2, 1).Font.Italic = True
                '.Cells(3, 1).Value = "www.halifax-fan.co.uk"
                '.Cells(3, 1).Font.size = 8
                '.Cells(4, 1).Value = ContactDetails
                '.Cells(4, 1).Font.size = 8
                '.Cells(4, 1).WrapText = False
                .Cells(6, 1).Value = lang_dict(24) & " " & final.fansize.ToString & " " & final.fantype 'fantitles(FanSave)
                .Cells(6, 1).Font.size = 11
                .Cells(6, 1).Font.Bold = True
                .Cells(6, 1).Font.Underline = True
                .Range("a6:p6").Merge
                .Cells(6, 1).HorizontalAlignment = Excel.Constants.xlCenter

                .Cells(7, 1).Value = lang_dict(4)
                .Cells(7, 1).Font.Bold = True

                .Cells(8, 3).Value = lang_dict(5)
                .Cells(8, 7).Value = final.vol.ToString
                .Cells(8, 8).Value = Units(0).UnitName(Units(0).UnitSelected)

                .Cells(8, 11).Value = lang_dict(9)
                .Cells(8, 14).Value = knowndensity.ToString
                .Cells(8, 15).Value = Units(3).UnitName(Units(3).UnitSelected)

                If PresType = 0 Then
                    .Cells(9, 3).Value = lang_dict(6)
                    .Cells(9, 7).Value = final.fsp.ToString
                    .Cells(9, 8).Value = Units(1).UnitName(Units(1).UnitSelected)
                Else
                    .Cells(9, 3).Value = lang_dict(7)
                    .Cells(9, 7).Value = final.ftp.ToString
                    .Cells(9, 8).Value = Units(1).UnitName(Units(1).UnitSelected)
                End If

                .Cells(9, 11).Value = lang_dict(8)
                .Cells(9, 14).Value = final.speed
                .Cells(9, 15).Value = "RPM"

                .Cells(12, 1).Value = lang_dict(25)
                .Cells(12, 1).Font.Bold = True
                .Cells(12, 1).Font.size = 11
                .Range("A12:P12").Merge
                .Cells(12, 1).HorizontalAlignment = Excel.Constants.xlCenter

                .Cells(13, 1).Value = lang_dict(26)
                .Range("A13:H13").Merge
                .Cells(13, 9).Value = 63
                .Cells(13, 10).Value = 125
                .Cells(13, 11).Value = 250
                .Cells(13, 12).Value = 500
                .Cells(13, 13).Value = 1000
                .Cells(13, 14).Value = 2000
                .Cells(13, 15).Value = 4000
                .Cells(13, 16).Value = 8000

                .Cells(14, 1).Value = lang_dict(27)
                .Range("A14:H14").Merge
                'count = 1
                For count = 0 To 7
                    .Cells(14, (count + 9)).Value = IDSPL(count)
                Next count

                .Cells(15, 1).Value = lang_dict(28) & " " & spl2 & " " & lang_dict(29)
                .Cells(15, 1).Font.size = 11
                .Range("A15:P15").Merge


                '.Range("a12:p15").Borders.LineStyle = .xlContinuous

                .Cells(45, 1).Value = lang_dict(14) & " " & Engineer
                .Cells(45, 1).Font.size = 9
                .Cells(45, 10).Value = lang_dict(15) & " " '&  & Format(Of Date, "dd/mm/yy")()
                .Cells(45, 1).Font.size = 9

                .Cells(47, 1).Value = lang_dict(16)
                .Cells(47, 1).Font.size = 7
                .Range(.Cells(45, 1), .Cells(47, 1)).HorizontalAlignment = Excel.Constants.xlLeft
                outputductPO(xlsWB, 18)
                outputopeninletPO(xlsWB, 25)
                outputopenoutletPO(xlsWB, 32)
                outputbrgPO(xlsWB, 39)
                outputmotorPO(xlsWB, 41)
                outputbpfPO(xlsWB, 43)
            End With

            'do something here
            xlsWB.Close(SaveChanges:=True)
            xlsWB = Nothing
            xlsWorkBooks.Close()
            xlsWorkBooks = Nothing
            xlsApp.Quit()
            xlsApp = Nothing

        Catch ex As Exception
            ErrorMessage(ex, 64031)

        End Try
    End Sub

    Public Sub outputbrgPO(xlsWB, brgrow)
        xlsWB.ActiveSheet.Name = "Sound"
        With xlsWB.ActiveSheet
            .Cells(brgrow, 1).Value = lang_dict(45) & " " & BRGnoise & " dBA"
            .Cells(brgrow, 1).Font.Bold = True
            .Cells(brgrow, 1).Font.Italic = True
            .Range(.Cells(brgrow, 1), .Cells(brgrow, 6)).Merge
            '.Range(.Cells(brgrow, 1), .Cells(brgrow, 6)).Borders.LineStyle = .xlContinuous
        End With
    End Sub
    Public Sub outputmotorPO(xlsWB, Motorrow)
        xlsWB.ActiveSheet.Name = "Sound"
        With xlsWB.ActiveSheet
            .Cells(Motorrow, 1).Value = lang_dict(46) & " " '& frmNoisemain.txtmotor.Value & " dBA"
            .Cells(Motorrow, 1).Font.Bold = True
            .Cells(Motorrow, 1).Font.Italic = True
            .Range(.Cells(Motorrow, 1), .Cells(Motorrow, 6)).Merge
            '.Range(.Cells(Motorrow, 1), .Cells(Motorrow, 6)).Borders.LineStyle = .xlContinuous
        End With
    End Sub
    Public Sub outputbpfPO(xlsWB, bpfroW)
        xlsWB.ActiveSheet.Name = "Sound"
        With xlsWB.ActiveSheet
            .Cells(bpfroW, 1).Value = lang_dict(44) & " " & BPfreq & " Hz"
            .Cells(bpfroW, 1).Font.Bold = True
            .Cells(bpfroW, 1).Font.Italic = True
            .Range(.Cells(bpfroW, 1), .Cells(bpfroW, 8)).Merge
            '.Range(.Cells(bpfroW, 1), .Cells(bpfroW, 8)).Borders.LineStyle = .xlContinuous
        End With
    End Sub

    Public Sub outputductPO(xlsWB, Drow)
        xlsWB.ActiveSheet.Name = "Sound"
        With xlsWB.ActiveSheet

            .Cells(Drow + 3, 1).Value = lang_dict(32)
            .Cells(Drow + 3, 1).Font.size = 11
            .Cells(Drow + 3, 1).Font.Bold = True
            .Cells(Drow + 3, 1).HorizontalAlignment = Excel.Constants.xlCenter

            .Cells(Drow, 1).Value = lang_dict(30) & " " & bospl2 & " " & lang_dict(29)
            .Cells(Drow + 1, 1).Value = lang_dict(31) & " " & bospl1M2 & " " & lang_dict(29)

            .Cells(Drow + 4, 1).Value = lang_dict(33)
            .Cells(Drow + 4, 1).Font.Bold = True
            .Cells(Drow + 4, 1).Font.size = 10


            .Cells(Drow + 5, 1).Value = lang_dict(26)
            .Cells(Drow + 5, 9).Value = 63
            .Cells(Drow + 5, 10).Value = 125
            .Cells(Drow + 5, 11).Value = 250
            .Cells(Drow + 5, 12).Value = 500
            .Cells(Drow + 5, 13).Value = 1000
            .Cells(Drow + 5, 14).Value = 2000
            .Cells(Drow + 5, 15).Value = 4000
            .Cells(Drow + 5, 16).Value = 8000

            .Cells(Drow + 6, 1).Value = lang_dict(34)
            'count = 1
            For count = 0 To 7
                .Cells(Drow + 6, (count + 9)).Value = Ascale(count)
            Next count

            .Cells(Drow + 7, 1).Value = lang_dict(35) & " " & NCoverall & " " & lang_dict(36)
            .Cells(Drow + 7, 1).Font.Bold = True
            .Cells(Drow + 7, 1).Font.Italic = True
            '.Range(.Cells(Drow, 1), .Cells(Drow + 1, 16)).Borders.LineStyle = .xlContinuous
            '.Range(.Cells(Drow + 3, 1), .Cells(Drow + 7, 16)).Borders.LineStyle = .xlContinuous

            .Range(.Cells(Drow, 1), .Cells(Drow, 16)).Merge
            .Range(.Cells(Drow + 1, 1), .Cells(Drow + 1, 16)).Merge
            .Range(.Cells(Drow + 3, 1), .Cells(Drow + 3, 16)).Merge
            .Range(.Cells(Drow + 4, 1), .Cells(Drow + 4, 16)).Merge
            .Range(.Cells(Drow + 5, 1), .Cells(Drow + 5, 8)).Merge
            .Range(.Cells(Drow + 6, 1), .Cells(Drow + 6, 8)).Merge
            .Range(.Cells(Drow + 7, 1), .Cells(Drow + 7, 16)).Merge
        End With

    End Sub

    Public Sub outputopeninletPO(xlsWB, OIrow)

        xlsWB.ActiveSheet.Name = "Sound"
        With xlsWB.ActiveSheet
            .Cells(OIrow, 1).Value = lang_dict(37)
            .Cells(OIrow, 1).Font.size = 11
            .Cells(OIrow, 1).Font.Bold = True
            .Cells(OIrow, 1).HorizontalAlignment = Excel.Constants.xlCenter

            .Cells(OIrow + 1, 1).Value = lang_dict(38) & " " & final.inletdia.ToString & Units(5).UnitName(Units(5).UnitSelected)

            .Cells(OIrow + 2, 1).Value = lang_dict(33)
            .Cells(OIrow + 2, 1).Font.Bold = True
            .Cells(OIrow + 2, 1).Font.size = 10


            .Cells(OIrow + 3, 1).Value = lang_dict(26)
            .Cells(OIrow + 3, 9).Value = 63
            .Cells(OIrow + 3, 10).Value = 125
            .Cells(OIrow + 3, 11).Value = 250
            .Cells(OIrow + 3, 12).Value = 500
            .Cells(OIrow + 3, 13).Value = 1000
            .Cells(OIrow + 3, 14).Value = 2000
            .Cells(OIrow + 3, 15).Value = 4000
            .Cells(OIrow + 3, 16).Value = 8000

            .Cells(OIrow + 4, 1).Value = lang_dict(39)
            'count = 1
            For count = 0 To 7
                .Cells(OIrow + 4, (count + 9)).Value = INascale(count)
            Next count

            .Cells(OIrow + 5, 1).Value = lang_dict(40) & " " & Math.Round(inNCoverall) & " " & lang_dict(36)
            .Cells(OIrow + 5, 1).Font.Bold = True
            .Cells(OIrow + 5, 1).Font.Italic = True
            '.Range(.Cells(OIrow, 1), .Cells(OIrow + 5, 16)).Borders.LineStyle = .xlContinuous

            .Range(.Cells(OIrow, 1), .Cells(OIrow, 16)).Merge
            .Range(.Cells(OIrow + 1, 1), .Cells(OIrow + 1, 16)).Merge
            .Range(.Cells(OIrow + 2, 1), .Cells(OIrow + 2, 16)).Merge
            .Range(.Cells(OIrow + 3, 1), .Cells(OIrow + 3, 8)).Merge
            .Range(.Cells(OIrow + 4, 1), .Cells(OIrow + 4, 8)).Merge
            .Range(.Cells(OIrow + 5, 1), .Cells(OIrow + 5, 16)).Merge
        End With

    End Sub

    Public Sub outputopenoutletPO(xlsWB, OOrow)

        xlsWB.ActiveSheet.Name = "Sound"
        With xlsWB.ActiveSheet
            .Cells(OOrow, 1).Value = lang_dict(41)
            .Cells(OOrow, 1).Font.size = 11
            .Cells(OOrow, 1).Font.Bold = True
            .Cells(OOrow, 1).HorizontalAlignment = Excel.Constants.xlCenter
            'If frmNoisemain.Optsquare.Value = True Then
            If final.outletlen > 0 And final.outletwid > 0 Then
                .Cells(OOrow + 1, 1).Value = lang_dict(42) & " " & final.outletlen.ToString & " x " & final.outletwid.ToString & Units(5).UnitName(Units(5).UnitSelected)
            Else
                .Cells(OOrow + 1, 1).Value = lang_dict(47) & " " & final.outletdia.ToString & Units(5).UnitName(Units(5).UnitSelected)
            End If

            .Cells(OOrow + 2, 1).Value = lang_dict(33)
            .Cells(OOrow + 2, 1).Font.Bold = True
            .Cells(OOrow + 2, 1).Font.size = 10


            .Cells(OOrow + 3, 1).Value = lang_dict(26)
            .Cells(OOrow + 3, 9).Value = 63
            .Cells(OOrow + 3, 10).Value = 125
            .Cells(OOrow + 3, 11).Value = 250
            .Cells(OOrow + 3, 12).Value = 500
            .Cells(OOrow + 3, 13).Value = 1000
            .Cells(OOrow + 3, 14).Value = 2000
            .Cells(OOrow + 3, 15).Value = 4000
            .Cells(OOrow + 3, 16).Value = 8000

            .Cells(OOrow + 4, 1).Value = lang_dict(39)
            'count = 1
            For count = 0 To 7
                .Cells(OOrow + 4, (count + 9)).Value = OUTascale(count)
            Next count

            .Cells(OOrow + 5, 1).Value = lang_dict(43) & " " & Math.Round(OUTNCoverall) & " " & lang_dict(36)
            .Cells(OOrow + 5, 1).Font.Bold = True
            .Cells(OOrow + 5, 1).Font.Italic = True
            '.Range(.Cells(OOrow, 1), .Cells(OOrow + 5, 16)).Borders.LineStyle = .xlContinuous

            .Range(.Cells(OOrow, 1), .Cells(OOrow, 16)).Merge
            .Range(.Cells(OOrow + 1, 1), .Cells(OOrow + 1, 16)).Merge
            .Range(.Cells(OOrow + 2, 1), .Cells(OOrow + 2, 16)).Merge
            .Range(.Cells(OOrow + 3, 1), .Cells(OOrow + 3, 8)).Merge
            .Range(.Cells(OOrow + 4, 1), .Cells(OOrow + 4, 8)).Merge
            .Range(.Cells(OOrow + 5, 1), .Cells(OOrow + 5, 16)).Merge
        End With

    End Sub


    'Private Function xlCenter() As Object
    '    Try
    '        Throw New NotImplementedException()

    '    Catch ex As Exception
    '        ErrorMessage(ex, 64041)
    '    End Try
    'End Function

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
