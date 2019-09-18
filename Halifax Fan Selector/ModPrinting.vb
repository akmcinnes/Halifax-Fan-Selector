Imports Excel = Microsoft.Office.Interop.Excel
'Imports System.IO
Module ModPrinting
    Public Thread As Threading.Thread
    'subroutines
    'server
    'thread to show progress - not activated

    'CreateFile
    'script to crate worksheets and output to pdf file

    'getLanguageDictionary
    'read language dictionary for outputs

    'SetupPagePO
    'set up excel worksheet ready to populate

    'OutputHeaderPO
    'populate header

    'OutputFooterPO
    'populate footer

    'OutputFanDetailsPO
    'populate fan details 

    'PlaceData
    'populate cells in worksheet, merge, font size, etc

    'ExporttoPDFPO
    'exports excel worksheets to pdf file

    'ConvertData
    'convert data for chart

    'SetPlaces
    'reset places for output values

    'State_Link
    'info on progress of worksheets - thread not activited

    'SiteDetails
    'set site details for language option

    Public xlsApp As Excel.Application = Nothing
    Public xlsWorkBooks As Excel.Workbooks = Nothing
    Public xlsWB As Excel.Workbook = Nothing

    Public Sub Server()
        Dim Process1() As Process
        Dim Process2 As New Process
        Try
            Process1 = Process.GetProcessesByName("Halifax Fan Selector")
        Catch ex As Exception
            ErrorMessage(ex, 6401)
        End Try
    End Sub

    Sub CreateFile(PagesToPrint As Integer)
        Try
            If (PagesToPrint = 3 Or PagesToPrint = 0) And StandAlone = False Then
                'If PagesToPrint = 3 Or PagesToPrint = 0 Then
                FrmCurveOptions.ShowDialog()
                If FrmCurveOptions.retval = 0 Then Exit Sub
            End If

            ' ### Prepare the thread Server ###
            Thread = New System.Threading.Thread(AddressOf Server)
            Thread.Start()
            'While Temporary.A = 0
            frmDocumentProgress.Show()
            'frmDocumentProgress.Refresh()
            frmDocumentProgress.BringToFront()
            'set cursor
            Frmselectfan.Cursor = Cursors.WaitCursor
            Dim MasterFile As String = TemplatesPathDefault + "Output Template v1.0.xlsx"
            Dim NewFileName As String
            'Dim File2Change As String = OpenFileName
            If OpenFileName = Nothing Then OpenFileName = SaveFileName
            NewFileName = OpenFileName.Replace(".hfs", ".xlsx")
            My.Computer.FileSystem.CopyFile(MasterFile, NewFileName, overwrite:=True)
            Dim filename_printout As String = NewFileName
            'get details for address block
            SiteDetails()
            'open the excel file
            Frmselectfan.Cursor = Cursors.WaitCursor
            xlsApp = New Microsoft.Office.Interop.Excel.Application
            xlsApp.Visible = False
            xlsWorkBooks = xlsApp.Workbooks
            xlsWB = xlsWorkBooks.Open(filename_printout)
            'make the sheets visible/hidden
            Dim isheet As Integer
            For isheet = 1 To xlsWB.Sheets.Count
                xlsWB.Sheets(isheet).Visible = Excel.XlSheetVisibility.xlSheetVisible
            Next
            Select Case PagesToPrint
                Case 0 'all pages
                    xlsWB.Worksheets("Datapoints").Activate
                    PopulatePrintoutDatapoints(xlsWB)
                    xlsWB.Charts("Chart").Activate
                    PopulatePrintoutChart(xlsWB)
                    xlsWB.Worksheets("Performance").Activate
                    PopulatePrintoutPerformance(xlsWB)
                    If PagesToPrint = 0 And StandAlone = True Then
                        ConvUnits()
                        OpenDuctCalcsManual()
                    End If
                    xlsWB.Worksheets("Sound").Activate
                    PopulatePrintoutSound(xlsWB)
                Case 1 'performance details
                    xlsWB.Worksheets("Performance").Activate
                    PopulatePrintoutPerformance(xlsWB)
                Case 2 'acoustic details
                    xlsWB.Worksheets("Sound").Activate
                    PopulatePrintoutSound(xlsWB)
                Case 3
                    xlsWB.Worksheets("Datapoints").Activate
                    PopulatePrintoutDatapoints(xlsWB)
                    xlsWB.Charts("Chart").Activate
                    PopulatePrintoutChart(xlsWB)
            End Select

            Dim pagestemp As Integer = PagesToPrint
            If StandAlone = True Then
                pagestemp = PagesOutput
            End If

            Select Case pagestemp'PagesToPrint
                Case 0, 10
                    xlsWB.Sheets("Datapoints").Visible = Excel.XlSheetVisibility.xlSheetHidden
                Case 1, 11
                    xlsWB.Sheets("Datapoints").Visible = Excel.XlSheetVisibility.xlSheetHidden
                    xlsWB.Sheets("Chart").Visible = Excel.XlSheetVisibility.xlSheetHidden
                    xlsWB.Sheets("Sound").Visible = Excel.XlSheetVisibility.xlSheetHidden
                Case 2, 12
                    xlsWB.Sheets("Datapoints").Visible = Excel.XlSheetVisibility.xlSheetHidden
                    xlsWB.Sheets("Chart").Visible = Excel.XlSheetVisibility.xlSheetHidden
                    xlsWB.Sheets("Performance").Visible = Excel.XlSheetVisibility.xlSheetHidden
                Case 3, 13
                    xlsWB.Sheets("Datapoints").Visible = Excel.XlSheetVisibility.xlSheetHidden
                    xlsWB.Sheets("Performance").Visible = Excel.XlSheetVisibility.xlSheetHidden
                    xlsWB.Sheets("Sound").Visible = Excel.XlSheetVisibility.xlSheetHidden
                Case Else
            End Select
            'export the excel file
            ExporttoPDFPO(xlsWB, pagestemp) 'PagesToPrint)
            'close the excel file
            xlsWB.Close(SaveChanges:=True)
            xlsWB = Nothing
            xlsWorkBooks.Close()
            xlsWorkBooks = Nothing
            xlsApp.Quit()
            xlsApp = Nothing

            Frmselectfan.Cursor = Cursors.Default
            frmDocumentProgress.Close()


            Thread.Join()
            Thread.Abort()
            If StandAlone = True Then End
        Catch ex As Exception
            'ErrorMessage(ex, 6402)
        End Try
    End Sub

    'Public Sub getLanguageDictionaryXLS()
    '    Try
    '        ' read language dictionary
    '        Dim filename_lang_dict As String = TemplatesPathDefault + "Halifax Output Dictionary.xlsx"
    '        xlsApp = New Microsoft.Office.Interop.Excel.Application
    '        xlsApp.Visible = False
    '        xlsWorkBooks = xlsApp.Workbooks
    '        xlsWB = xlsWorkBooks.Open(filename_lang_dict)
    '        Dim ii As Integer
    '        For ii = 1 To 250
    '            lang_dict(1,ii) = xlsWB.Worksheets(ChosenLanguage).Cells(ii, 1).Value
    '            lang_dict(2,ii) = xlsWB.Worksheets(ChosenLanguage).Cells(ii, 2).Value
    '        Next
    '        xlsWB.Close(SaveChanges:=False)
    '    Catch ex As Exception
    '        ErrorMessage(ex, 640399)
    '    End Try
    'End Sub
    Public Sub GetSites()
        Try
            Dim filename_sites As String = DataPathDefault + "Site Addresses.bin"
            Dim jj As Integer = 1
            fs = New System.IO.FileStream(filename_sites, IO.FileMode.Open)
            br = New System.IO.BinaryReader(fs)

            br.BaseStream.Seek(0, IO.SeekOrigin.Begin)
            For jj = 1 To 5 'count
                site_label(jj) = br.ReadString()
                site_name(jj) = br.ReadString()
                site_company(1, jj) = br.ReadString()
                site_company(2, jj) = br.ReadString()
                site_address(1, jj) = br.ReadString()
                site_address(2, jj) = br.ReadString()
                site_phone(jj) = br.ReadString()
                site_email(jj) = br.ReadString()
                site_website(jj) = br.ReadString()
                'Loop
            Next
            br.Close()
        Catch ex As Exception
        ErrorMessage(ex, 6403)
        End Try

    End Sub

    Public Sub getLanguageDictionary()
        Try
            ' read language dictionary
            Dim filename_lang_dict As String = DataPathDefault + "Halifax Output Dictionary_" + ChosenLanguage + ".bin"
            Dim ii As Integer
            fs = New System.IO.FileStream(filename_lang_dict, IO.FileMode.Open)
            br = New System.IO.BinaryReader(fs)

            br.BaseStream.Seek(0, IO.SeekOrigin.Begin)
            For ii = 1 To 250
                lang_dict(1, ii) = br.ReadString()
                lang_dict(2, ii) = br.ReadString()
            Next
            br.Close()
        Catch ex As Exception
            ErrorMessage(ex, 6404)
        End Try
    End Sub

    Public Sub SetupPagePO(xlsWB As Excel.Workbook, Optional cellwidth As Integer = 5)
        Try
            General_Information.State = 8
            General_Information.State_Message = "Set up Page"
            'Call State_link()

            xlsWB.ActiveSheet.Name = sheet
            With xlsWB.ActiveSheet
                .Range("A1:Z250").Font.Name = "Arial"
                .Range("A1:Z250").Font.size = 10
                .Range("A1:Z250").WrapText = False
                .Columns("A:Z").ColumnWidth = cellwidth
            End With
        Catch ex As Exception
            ErrorMessage(ex, 6405)
        End Try
    End Sub

    Public Sub OutputHeaderPO(xlsWB)
        Try
            xlsWB.ActiveSheet.Name = sheet
            PlaceData(xlsWB, sheet, cstring, 1, 1, True,,,,,,, 11) 'company name
            PlaceData(xlsWB, sheet, astring, 2, 1,, True,,,,,, 8) 'company address
            PlaceData(xlsWB, sheet, wstring, 3, 1,,,,,,,, 8) 'company
            PlaceData(xlsWB, sheet, estring, 4, 1,,,,,,,, 8, False) 'company email
            PlaceData(xlsWB, sheet, tstring, 4, 5,,,,,,,, 8, False) 'company phone
        Catch ex As Exception
            ErrorMessage(ex, 6406)
        End Try
    End Sub

    Public Sub OutputFooterPO(xlsWB)
        Try
            xlsWB.ActiveSheet.Name = sheet
            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 14) & " " & Engineer, 46, 1, ,,,,,,, 9) 'engineer
            If StandAlone = False Then
                PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 15) & " " & Date.Now.ToString("dd/MM/yyyy HH:mm"), 46, 10, ,,,,,,, 9) 'date
            Else
                PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 15) & " " & Date.Now.ToString("dd-MMM-yyyy HH:mm"), 46, 10, ,,,,,,, 9) 'date
            End If
            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 16), 47, 1, ,,,,,,, 7,, 1) 'legal bit
        Catch ex As Exception
            ErrorMessage(ex, 6407)
        End Try
    End Sub

    Public Sub OutputFanDetailsPO(xlsWB, sheetnum)
        'check for fan type from dictionary
        Dim i As Integer
        Dim found As Boolean = False
        Try
            For i = 141 To 170
                If final.fantypename = lang_dict(2, i) Then
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
                            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 75) & " " & final.fansize.ToString & " " & final.fantypename & " " & lang_dict(PrintLanguage, 3) & didw, 7, 1, True,, True, 7, 1, 7, 16, 11,, 3) 'company name
                        Else
                            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 75) & " " & final.fansize.ToString & " " & lang_dict(PrintLanguage, i) & " " & lang_dict(PrintLanguage, 3) & didw, 7, 1, True,, True, 7, 1, 7, 16, 11,, 3) 'company name
                        End If
                        'duty point
                        PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 4), 8, 1, True)
                        'volume flow rate
                        PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 5), 9, 3)
                        PlaceData(xlsWB, sheet, final.vol, 9, 7,,, True, 9, 6, 9, 7,,, 2)
                        PlaceData(xlsWB, sheet, Units(0).UnitName(Units(0).UnitSelected), 9, 8)
                        'fsp
                        PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 6), 10, 3)
                        PlaceData(xlsWB, sheet, final.fsp, 10, 7)
                        PlaceData(xlsWB, sheet, Units(1).UnitName(Units(1).UnitSelected), 10, 8)
                        'ftp
                        PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 7), 11, 3)
                        PlaceData(xlsWB, sheet, final.ftp, 11, 7)
                        PlaceData(xlsWB, sheet, Units(1).UnitName(Units(1).UnitSelected), 11, 8)
                        'fan speed
                        PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 8), 12, 3)
                        PlaceData(xlsWB, sheet, final.speed, 12, 7)
                        PlaceData(xlsWB, sheet, "RPM", 12, 8)
                        'gas density
                        PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 9), 13, 3)
                        PlaceData(xlsWB, sheet, knowndensity, 13, 7)
                        PlaceData(xlsWB, sheet, Units(3).UnitName(Units(3).UnitSelected), 13, 8)
                        'fan power
                        PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 10), 14, 3)
                        PlaceData(xlsWB, sheet, final.pow, 14, 7)
                        PlaceData(xlsWB, sheet, Units(4).UnitName(Units(4).UnitSelected), 14, 8)
                        'outlet velocity
                        PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 11), 9, 11)
                        PlaceData(xlsWB, sheet, final.ov, 9, 14)
                        PlaceData(xlsWB, sheet, Units(7).UnitName(Units(7).UnitSelected), 9, 15)
                        'fse
                        PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 12), 10, 11)
                        PlaceData(xlsWB, sheet, final.fse, 10, 14)
                        PlaceData(xlsWB, sheet, "%", 10, 15)
                        'fte
                        PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 13), 11, 11)
                        PlaceData(xlsWB, sheet, final.fte, 11, 14)
                        PlaceData(xlsWB, sheet, "%", 11, 15)
                        'inlet dimensions
                        PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 48), 12, 11)
                        PlaceData(xlsWB, sheet, Math.Round(final.inletdia).ToString, 12, 14)
                        PlaceData(xlsWB, sheet, Units(5).UnitName(Units(5).UnitSelected), 12, 15)
                        ''outlet dimensions
                        If final.outletlen > 0 And final.outletwid > 0 Then
                            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 84), 13, 11)
                            PlaceData(xlsWB, sheet, Math.Round(final.outletlen).ToString & " x " & Math.Round(final.outletwid).ToString, 13, 13,,, True, 13, 13, 13, 14,,, 2)
                            PlaceData(xlsWB, sheet, Units(5).UnitName(Units(5).UnitSelected), 13, 15)
                        Else
                            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 57), 13, 11)
                            PlaceData(xlsWB, sheet, Math.Round(final.outletdia).ToString, 13, 14)
                            PlaceData(xlsWB, sheet, Units(5).UnitName(Units(5).UnitSelected), 13, 15)
                        End If
                        'outlet area
                        'PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 83), 13, 11)
                        'PlaceData(xlsWB, sheet, Math.Round(final.outletarea, 3).ToString, 13, 14)
                        'PlaceData(xlsWB, sheet, Units(8).UnitName(Units(8).UnitSelected), 13, 15)
                        'motor power
                        PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 82), 14, 11)
                        PlaceData(xlsWB, sheet, final.mot, 14, 14)
                        PlaceData(xlsWB, sheet, Units(4).UnitName(Units(4).UnitSelected), 14, 15)
                    End With
                Case 2
                    xlsWB.ActiveSheet.Name = sheet
                    With xlsWB.ActiveSheet
                        'title
                        If found = False Then
                            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 34) & " " & final.fansize.ToString & " " & final.fantypename & " " & lang_dict(PrintLanguage, 3) & didw, 7, 1, True,, True, 7, 1, 7, 16, 11,, 3) 'company name
                        Else
                            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 34) & " " & final.fansize.ToString & " " & lang_dict(PrintLanguage, i) & " " & lang_dict(PrintLanguage, 3) & didw, 7, 1, True,, True, 7, 1, 7, 16, 11,, 3) 'company name
                        End If
                        'duty point
                        PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 4), 8, 1, True)
                        'volume flow rate
                        PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 5), 9, 3)
                        PlaceData(xlsWB, sheet, final.vol, 9, 7,,, True, 9, 6, 9, 7,,, 2)
                        PlaceData(xlsWB, sheet, Units(0).UnitName(Units(0).UnitSelected), 9, 8)
                        'fsp
                        If PresType = 0 Then
                            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 6), 10, 3)
                            PlaceData(xlsWB, sheet, final.fsp, 10, 7)
                            PlaceData(xlsWB, sheet, Units(1).UnitName(Units(1).UnitSelected), 10, 8)
                        Else
                            PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 7), 10, 3)
                            PlaceData(xlsWB, sheet, final.ftp, 10, 7)
                            PlaceData(xlsWB, sheet, Units(1).UnitName(Units(1).UnitSelected), 10, 8)
                        End If
                        'gas density
                        PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 9), 9, 11)
                        PlaceData(xlsWB, sheet, knowndensity, 9, 14)
                        PlaceData(xlsWB, sheet, Units(3).UnitName(Units(3).UnitSelected), 9, 15)
                        'fan speed
                        PlaceData(xlsWB, sheet, lang_dict(PrintLanguage, 8), 10, 11)
                        PlaceData(xlsWB, sheet, final.speed, 10, 14)
                        PlaceData(xlsWB, sheet, "RPM", 10, 15)
                    End With
            End Select
        Catch ex As Exception
            ErrorMessage(ex, 6408)
        End Try

    End Sub

    Public Sub PlaceData(xlsWB As Excel.Workbook, Sheetname As String, text As Object, row As Integer, col As Integer, Optional bold As Boolean = False, Optional italics As Boolean = False, Optional merge As Boolean = False, Optional mrow1 As Integer = 0, Optional mcol1 As Integer = 0, Optional mrow2 As Integer = 0, Optional mcol2 As Integer = 0, Optional fontsize As Integer = 10, Optional wrap As Boolean = False, Optional position As Integer = 99)
        Try
            If IsNumeric(text) = True Then
                text = CDbl(text)
                Dim numplaces As Integer = 4
                If text > 10000 Then
                    numplaces = 0
                ElseIf text > 1000 Then
                    numplaces = 1
                ElseIf text > 100 Then
                    numplaces = 2
                ElseIf text > 10 Then
                    numplaces = 3
                End If
                text = Math.Round(text, numplaces)
            End If

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
            End With
        Catch ex As Exception
            ErrorMessage(ex, 6409)
        End Try
    End Sub

    Private Sub ExporttoPDFPO(xlsWB, PagesToPrint)
        Try
            Dim ExportName As String
            Select Case PagesToPrint
                Case 1
                    ExportName = OpenFileName.Replace(".hfs", "(1).pdf")
                Case 2
                    ExportName = OpenFileName.Replace(".hfs", "(2).pdf")
                Case 3
                    ExportName = OpenFileName.Replace(".hfs", "(3).pdf")
                Case Else
                    ExportName = OpenFileName.Replace(".hfs", ".pdf")
            End Select
            xlsWB.ExportAsFixedFormat(Excel.XlFixedFormatType.xlTypePDF, Filename:=ExportName)
            System.Diagnostics.Process.Start(ExportName)
        Catch ex As Exception
            ErrorMessage(ex, 6410)
        End Try
    End Sub

    Public Sub ConvertData()
        Dim i As Integer
        Try
            Dim filenameref As String = "FILENAME REF DATA"
            ReadReffromBinaryfile(filenameref)
            Dim sizecon As Double
            For i = 0 To fantypesQTY - 1
                sizecon = 1.0
                If fanunits(i) = "mm" Then sizecon = 25.4
                If fanclass(i) = final.fantype And final.fansize / sizecon <= fansizelimit(i) Then Exit For
            Next
            'i = i + 1
            'Loop
            ReadfromBinaryfile(fantypefilename(i), 0)

            'final.BladeNumber = blade_number(i)
            final.BladeNumber = Num_Blades
            final.inletdia = In_Dia_mm * (final.fansize / FanSize2)
            final.inletdia = final.inletdia - (casethickness * 2)
            final.outletlen = OutLen_mm * (final.fansize / FanSize2)
            final.outletwid = OutWid_mm * (final.fansize / FanSize2)
            final.outletdia = OutDia_mm * (final.fansize / FanSize2)
            final.outletdia = final.outletdia - (casethickness * 2)
            final.outletarea = OutArea_m2 * (final.fansize / FanSize2) ^ 2
            FrmFanChart.ConvertPVtoChart(True)
        Catch ex As Exception
            ErrorMessage(ex, 6411)
        End Try
    End Sub

    Public Sub SetPlaces(q As Double, Optional h As Double = 0.0, Optional k As Double = 0.0)
        Try
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
        Catch ex As Exception
            ErrorMessage(ex, 6412)
        End Try
    End Sub

    'Public Sub State_link()
    '    Try
    '        ' ### Write the state value in the state file ###
    '        Dim Write_savefile As StreamWriter = New StreamWriter(DataPathDefault + "\State.txt")
    '        Write_savefile.WriteLine(General_Information.State)
    '        Write_savefile.WriteLine(General_Information.State_Message)
    '        Write_savefile.Close()
    '    Catch ex As Exception
    '        ErrorMessage(ex, 6412) ', ex.Message, General_Information.State_Message)
    '    End Try
    'End Sub

    Public Sub SiteDetails()
        Try
            GetSites()
            'Select Case ChosenSite
            '    Case 0
            '        cstring = lang_dict(PrintLanguage,17)
            '        astring = lang_dict(PrintLanguage,18)
            '        tstring = lang_dict(PrintLanguage,19)
            '        estring = lang_dict(PrintLanguage,20)
            '    Case 1
            '        cstring = lang_dict(PrintLanguage,22)
            '        astring = lang_dict(PrintLanguage,23)
            '        tstring = lang_dict(PrintLanguage,24)
            '        estring = lang_dict(PrintLanguage,29)
            '    Case 2
            '        cstring = lang_dict(PrintLanguage,22)
            '        astring = lang_dict(PrintLanguage,25)
            '        tstring = lang_dict(PrintLanguage,26)
            '        estring = lang_dict(PrintLanguage,29)
            '    Case 3
            '        cstring = lang_dict(PrintLanguage,22)
            '        astring = lang_dict(PrintLanguage,27)
            '        tstring = lang_dict(PrintLanguage,28)
            '        estring = lang_dict(PrintLanguage,29)
            '    Case 4
            '        cstring = lang_dict(PrintLanguage,22)
            '        astring = lang_dict(PrintLanguage,27)
            '        tstring = lang_dict(PrintLanguage,28)
            '        estring = lang_dict(PrintLanguage,29)
            '    Case Else
            '        cstring = lang_dict(PrintLanguage,17)
            '        astring = lang_dict(PrintLanguage,18)
            '        tstring = lang_dict(PrintLanguage,19)
            '        estring = lang_dict(PrintLanguage,20)
            'End Select
            'wstring = lang_dict(PrintLanguage,21)
            Dim jj As Integer = ChosenSite + 1
            Dim ii As Integer = PrintLanguage
            If PrintLanguage = 1 And ChosenLanguage = "en-GB" Then ii = 2
            cstring = site_company(ii, jj)
            astring = site_address(ii, jj)
            tstring = site_phone(jj)
            estring = site_email(jj)
            wstring = site_website(jj)
        Catch ex As Exception
            ErrorMessage(ex, 6413)
        End Try
    End Sub
End Module
