Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Module loaddata
    'Public Function loaddata1(filename) As String
    '    Dim App As Excel.Application = Nothing
    '    Dim WorkBooks As Excel.Workbooks = Nothing
    '    Dim ActiveWorkbook As Excel.Workbook = Nothing

    '    Erase fsp, ftp, vol, Pow, fsizes
    '    Erase fsps, ftps, fses, ftes, Pows, ovs, vols
    '    Erase fspI, ftpI, fseI, fteI, powI, volI

    '    'If Frmselectfan.Comfspunits.Value = "InsWG" Then
    '    '    colfsp = FSP_insWG '2
    '    '    colftp = FTP_insWG '5
    '    'End If
    '    'If Frmselectfan.Comfspunits.Value = "Pa" Then
    '    colfsp = 13 'FSP_pa
    '    colftp = 14 'FTP_pa
    '    'End If
    '    'If Frmselectfan.Comfspunits.Value = "mmWG" Then
    '    '    colfsp = FSP_mmWG '7
    '    '    colftp = FTP_mmWG '10
    '    'End If
    '    'If Frmselectfan.Comfspunits.Value = "mbar" Then
    '    '    colfsp = FSP_mbar '15
    '    '    colftp = FTP_mbar '16
    '    'End If

    '    '        If FlowType = 1 Then
    '    colvol = 9 'm3hr
    '    'End If
    '    'If FlowType = 2 Then
    '    '    colvol = 11
    '    'End If
    '    'If FlowType = 3 Then
    '    '    colvol = 12
    '    'End If
    '    'If FlowType = 4 Then
    '    '    colvol = 4
    '    'End If

    '    'If Frmselectfan.Compowunits.Value = "KW" Then
    '    colpow = 8
    '    'Else
    '    '    colpow = 3
    '    'End If
    '    '----setting the number of decimal places-------------------------------------------
    '    '        If FlowType = 3 Then
    '    voldecplaces = 3
    '    'Else
    '    '    voldecplaces = 0
    '    'End If
    '    'If FlowType = 2 Then
    '    '    voldecplaces = 2
    '    'End If
    '    'If Val(Frmselectfan.Txtflow.Value) > 10000 Then
    '    'voldecplaces = 0
    '    'ElseIf Val(Frmselectfan.Txtflow.Value) > 1000 Then
    '    '    voldecplaces = 1
    '    'ElseIf Val(Frmselectfan.Txtflow.Value) > 100 Then
    '    '    voldecplaces = 2
    '    'ElseIf Val(Frmselectfan.Txtflow.Value) > 10 Then
    '    '    voldecplaces = 3
    '    'End If

    '    pressplace = 2
    '    '        If Val(Frmselectfan.TXTFSP.Value) > 10000 Then
    '    'pressplace = 0
    '    'ElseIf Val(Frmselectfan.TXTFSP.Value) > 1000 Then
    '    '    pressplace = 1
    '    'ElseIf Val(Frmselectfan.TXTFSP.Value) > 100 Then
    '    '    pressplace = 2
    '    'ElseIf Val(Frmselectfan.TXTFSP.Value) > 10 Then
    '    '    pressplace = 3
    '    'End If

    '    colfte = 20
    '    colfse = 19
    '    coloutletvel = 17

    '    colstdfansizes = 21 '-column number for the fan size

    '    App = New Microsoft.Office.Interop.Excel.Application
    '    App.Visible = False
    '    WorkBooks = App.Workbooks
    '    'WB = WorkBooks.Open(FullFilePath)


    '    ActiveWorkbook = WorkBooks.Open(filename)
    '    count = 1

    '    counteff = 1
    '    row = 9



    '    ReDim ftp(30, 50)
    '    ReDim vol(30, 50)
    '    ReDim Pow(30, 50)
    '    ReDim fte(30, 50)
    '    ReDim fsp(30, 50)
    '    ReDim fse(30, 50)
    '    ReDim ovel(30, 50)

    '    Do While count <= ActiveWorkbook.Worksheets(1).Cells(50, 2).Value
    '        fsp(1, count) = Val(ActiveWorkbook.Worksheets(1).Cells(row, colfsp).Value)
    '        ftp(1, count) = Val(ActiveWorkbook.Worksheets(1).Cells(row, colftp).Value)
    '        vol(1, count) = Val(ActiveWorkbook.Worksheets(1).Cells(row, colvol).Value)
    '        Pow(1, count) = Val(ActiveWorkbook.Worksheets(1).Cells(row, colpow).Value)
    '        fte(1, count) = Val(ActiveWorkbook.Worksheets(1).Cells(row, colfte).Value)
    '        fse(1, count) = Val(ActiveWorkbook.Worksheets(1).Cells(row, colfse).Value)
    '        ovel(1, count) = Val(ActiveWorkbook.Worksheets(1).cells(row, coloutletvel).value)
    '        If fte(1, count) > fte(1, counteff) Then counteff = count
    '        count = count + 1
    '        row = row + 1
    '    Loop
    '    datafansize(1) = ActiveWorkbook.Worksheets(1).Cells(4, 2).Value
    '    datafanspeed(1) = ActiveWorkbook.Worksheets(1).Cells(3, 2).Value
    '    dataoutletarea(1) = ActiveWorkbook.Worksheets(1).Cells(5, 12).Value
    '    dataoutletareaftsq(1) = ActiveWorkbook.Worksheets(1).Cells(5, 14).Value
    '    datapoints1 = ActiveWorkbook.Worksheets(1).Cells(5, 2).Value
    '    medpoint(1) = ActiveWorkbook.Worksheets(1).Cells(5, 10).Value
    '    If PType = 1 Then medpoint(1) = counteff

    '    FanMaxCount(1) = datapoints1
    '    If PType = 1 Then
    '        For II = datapoints1 To 1 Step -1
    '            If ftp(1, II) > ftp(1, FanMaxCount(1)) Then FanMaxCount(1) = II
    '        Next II
    '    Else
    '        For II = datapoints1 To 1 Step -1
    '            If fsp(1, II) > fsp(1, FanMaxCount(1)) Then FanMaxCount(1) = II
    '        Next II
    '    End If

    '    count = 1
    '    row = 9
    '    'Do While ActiveWorkbook.Worksheets(1).Cells(row, colstdfansizes).Value <> ""
    '    '    fsizes(1, count) = Val(ActiveWorkbook.Worksheets(1).Cells(row, colstdfansizes).Value)
    '    '    count = count + 1
    '    '    row = row + 1
    '    'Loop
    '    ActiveWorkbook.Close(False)
    '    Return "Complete"
    'End Function
    Public Sub ReadfromExcelfile(filename, fanno)
        Dim xlsApp As Excel.Application = Nothing
        Dim xlsWorkBooks As Excel.Workbooks = Nothing
        Dim ActiveWorkbook As Excel.Workbook = Nothing
        FullFilePath = "C:\Halifax" + filename
        xlsApp = New Microsoft.Office.Interop.Excel.Application
        xlsApp.Visible = False
        xlsWorkBooks = xlsApp.Workbooks
        ActiveWorkbook = xlsWorkBooks.Open(FullFilePath)

        FanSize1 = Val(ActiveWorkbook.Worksheets(1).Cells(4, 2).Value)
        FanSpeed1 = Val(ActiveWorkbook.Worksheets(1).Cells(3, 2).Value)
        FanSize2 = Val(ActiveWorkbook.Worksheets(1).Cells(2, 2).Value)
        Num_Readings = Val(ActiveWorkbook.Worksheets(1).Cells(5, 2).Value)
        Most_Eff_Pt = Val(ActiveWorkbook.Worksheets(1).Cells(5, 10).Value)
        '        medpoint(1) = Most_Eff_Pt
        OutLen_mm = Val(ActiveWorkbook.Worksheets(1).Cells(3, 12).Value)
        OutWid_mm = Val(ActiveWorkbook.Worksheets(1).Cells(4, 12).Value)
        OutArea_m2 = Val(ActiveWorkbook.Worksheets(1).Cells(5, 12).Value)

        OutLen_ft = Val(ActiveWorkbook.Worksheets(1).Cells(3, 14).Value)
        OutWid_ft = Val(ActiveWorkbook.Worksheets(1).Cells(4, 14).Value)
        OutArea_ft2 = Val(ActiveWorkbook.Worksheets(1).Cells(5, 14).Value)

        In_Dia_mm = Val(ActiveWorkbook.Worksheets(1).Cells(2, 19).Value)
        Eye_Area_m2 = Val(ActiveWorkbook.Worksheets(1).Cells(3, 19).Value)
        Blade_Type = ActiveWorkbook.Worksheets(1).Cells(4, 19).Value
        Num_Blades = Val(ActiveWorkbook.Worksheets(1).Cells(5, 19).Value)

        'Do While count <= ActiveWorkbook.Worksheets(1).Cells(50, 2).Value
        '    fsp(1, count) = Val(ActiveWorkbook.Worksheets(1).Cells(row, colfsp).Value)
        '    ftp(1, count) = Val(ActiveWorkbook.Worksheets(1).Cells(row, colftp).Value)
        '    vol(1, count) = Val(ActiveWorkbook.Worksheets(1).Cells(row, colvol).Value)
        '    Pow(1, count) = Val(ActiveWorkbook.Worksheets(1).Cells(row, colpow).Value)
        '    fte(1, count) = Val(ActiveWorkbook.Worksheets(1).Cells(row, colfte).Value)
        '    fse(1, count) = Val(ActiveWorkbook.Worksheets(1).Cells(row, colfse).Value)
        '    ovel(1, count) = Val(ActiveWorkbook.Worksheets(1).cells(row, coloutletvel).value)
        '    If fte(1, count) > fte(1, counteff) Then counteff = count
        '    count = count + 1
        '    row = row + 1
        row = 9
        For i = 0 To Num_Readings - 1
            FSP_insWG(i) = Val(ActiveWorkbook.Worksheets(1).Cells(row, 2).Value)
            row = row + 1
        Next
        row = 9
        For i = 0 To Num_Readings - 1
            Pow_hp(i) = Val(ActiveWorkbook.Worksheets(1).Cells(row, 3).Value)
            row = row + 1
        Next
        row = 9
        For i = 0 To Num_Readings - 1
            Vol_cfm(i) = Val(ActiveWorkbook.Worksheets(1).Cells(row, 4).Value)
            row = row + 1
        Next
        row = 9
        For i = 0 To Num_Readings - 1
            FTP_insWG(i) = Val(ActiveWorkbook.Worksheets(1).Cells(row, 5).Value)
            row = row + 1
        Next
        row = 9
        For i = 0 To Num_Readings - 1
            FSP_mmwg(i) = Val(ActiveWorkbook.Worksheets(1).Cells(row, 7).Value)
            row = row + 1
        Next
        row = 9
        For i = 0 To Num_Readings - 1
            Pow_kw(i) = Val(ActiveWorkbook.Worksheets(1).Cells(row, 8).Value)
            row = row + 1
        Next
        row = 9
        For i = 0 To Num_Readings - 1
            Vol_m3hr(i) = Val(ActiveWorkbook.Worksheets(1).Cells(row, 9).Value)
            row = row + 1
        Next
        row = 9
        For i = 0 To Num_Readings - 1
            FTP_mmWG(i) = Val(ActiveWorkbook.Worksheets(1).Cells(row, 10).Value)
            row = row + 1
        Next
        row = 9
        For i = 0 To Num_Readings - 1
            Vol_m3min(i) = Val(ActiveWorkbook.Worksheets(1).Cells(row, 11).Value)
            row = row + 1
        Next
        row = 9
        For i = 0 To Num_Readings - 1
            Vol_m3sec(i) = Val(ActiveWorkbook.Worksheets(1).Cells(row, 12).Value)
            row = row + 1
        Next
        row = 9
        For i = 0 To Num_Readings - 1
            FSP_pa(i) = Val(ActiveWorkbook.Worksheets(1).Cells(row, 13).Value)
            row = row + 1
        Next
        row = 9
        For i = 0 To Num_Readings - 1
            FTP_pa(i) = Val(ActiveWorkbook.Worksheets(1).Cells(row, 14).Value)
            row = row + 1
        Next
        row = 9
        For i = 0 To Num_Readings - 1
            FSP_mbar(i) = Val(ActiveWorkbook.Worksheets(1).Cells(row, 15).Value)
            row = row + 1
        Next
        row = 9
        For i = 0 To Num_Readings - 1
            FTP_mbar(i) = Val(ActiveWorkbook.Worksheets(1).Cells(row, 16).Value)
            row = row + 1
        Next
        row = 9
        For i = 0 To Num_Readings - 1
            OV_msec(i) = Val(ActiveWorkbook.Worksheets(1).Cells(row, 17).Value)
            row = row + 1
        Next
        row = 9
        For i = 0 To Num_Readings - 1
            OV_fmin(i) = Val(ActiveWorkbook.Worksheets(1).Cells(row, 18).Value)
            row = row + 1
        Next
        row = 9
        For i = 0 To Num_Readings - 1
            FSE1(i) = Val(ActiveWorkbook.Worksheets(1).Cells(row, 19).Value)
            row = row + 1
        Next
        row = 9
        For i = 0 To Num_Readings - 1
            FTE1(i) = Val(ActiveWorkbook.Worksheets(1).Cells(row, 20).Value)
            row = row + 1
        Next
        row = 9
        For i = 0 To 29
            STD_Fan_Size(i) = Val(ActiveWorkbook.Worksheets(1).Cells(row, 21).Value)
            fsizes(fanno, i) = STD_Fan_Size(i)
            row = row + 1
        Next

        'Loop
        '????        If PType = 1 Then medpoint(1) = counteff

        FanMaxCount(1) = datapoints1
        If PType = 1 Then
            For II = datapoints1 To 1 Step -1
                If ftp(1, II) > ftp(1, FanMaxCount(1)) Then FanMaxCount(1) = II
            Next II
        Else
            For II = datapoints1 To 1 Step -1
                If fsp(1, II) > fsp(1, FanMaxCount(1)) Then FanMaxCount(1) = II
            Next II
        End If

        count = 1
        row = 9
        'Do While ActiveWorkbook.Worksheets(1).Cells(row, colstdfansizes).Value <> ""
        '    fsizes(1, count) = Val(ActiveWorkbook.Worksheets(1).Cells(row, colstdfansizes).Value)
        '    count = count + 1
        '    row = row + 1
        'Loop
        ActiveWorkbook.Close(False)
        '        MsgBox(filename + " read " + fanno.ToString)
    End Sub

    Public Sub ReadfromTextfile(filename, fanno)
        Dim FullFilePathtxt As String
        '        FullFilePathtxt = "C:\Halifax\Performance Data new\" + filename + ".txt"
        FullFilePathtxt = "C:\Halifax" + filename
        Dim objStreamReader As New StreamReader(FullFilePathtxt)
        FanSize1 = objStreamReader.ReadLine()
        FanSpeed1 = objStreamReader.ReadLine()
        FanSize2 = objStreamReader.ReadLine()
        Num_Readings = objStreamReader.ReadLine()
        Most_Eff_Pt = objStreamReader.ReadLine()
        '        medpoint(1) = Most_Eff_Pt
        OutLen_mm = objStreamReader.ReadLine()
        OutWid_mm = objStreamReader.ReadLine()
        OutArea_m2 = objStreamReader.ReadLine()
        OutLen_ft = objStreamReader.ReadLine()
        OutWid_ft = objStreamReader.ReadLine()
        OutArea_ft2 = objStreamReader.ReadLine()
        In_Dia_mm = objStreamReader.ReadLine()
        Eye_Area_m2 = objStreamReader.ReadLine()
        Blade_Type = objStreamReader.ReadLine()
        Num_Blades = objStreamReader.ReadLine()

        For i = 0 To Num_Readings - 1
            FSP_insWG(i) = objStreamReader.ReadLine()
        Next
        For i = 0 To Num_Readings - 1
            Pow_hp(i) = objStreamReader.ReadLine()
        Next
        For i = 0 To Num_Readings - 1
            Vol_cfm(i) = objStreamReader.ReadLine()
        Next
        For i = 0 To Num_Readings - 1
            FTP_insWG(i) = objStreamReader.ReadLine()
        Next
        For i = 0 To Num_Readings - 1
            FSP_mmwg(i) = objStreamReader.ReadLine()
        Next
        For i = 0 To Num_Readings - 1
            Pow_kw(i) = objStreamReader.ReadLine()
        Next
        For i = 0 To Num_Readings - 1
            Vol_m3hr(i) = objStreamReader.ReadLine()
        Next
        For i = 0 To Num_Readings - 1
            FTP_mmWG(i) = objStreamReader.ReadLine()
        Next
        For i = 0 To Num_Readings - 1
            Vol_m3min(i) = objStreamReader.ReadLine()
        Next
        For i = 0 To Num_Readings - 1
            Vol_m3sec(i) = objStreamReader.ReadLine()
        Next
        For i = 0 To Num_Readings - 1
            FSP_pa(i) = objStreamReader.ReadLine()
        Next
        For i = 0 To Num_Readings - 1
            FTP_pa(i) = objStreamReader.ReadLine()
        Next
        For i = 0 To Num_Readings - 1
            FSP_mbar(i) = objStreamReader.ReadLine()
        Next
        For i = 0 To Num_Readings - 1
            FTP_mbar(i) = objStreamReader.ReadLine()
        Next
        For i = 0 To Num_Readings - 1
            OV_msec(i) = objStreamReader.ReadLine()
        Next
        For i = 0 To Num_Readings - 1
            OV_fmin(i) = objStreamReader.ReadLine()
        Next
        For i = 0 To Num_Readings - 1
            FSE1(i) = objStreamReader.ReadLine()
        Next
        For i = 0 To Num_Readings - 1
            FTE1(i) = objStreamReader.ReadLine()
        Next
        For i = 0 To 29
            STD_Fan_Size(i) = objStreamReader.ReadLine()
            fsizes(fanno, i) = STD_Fan_Size(i)
        Next
        objStreamReader.Close() 'Close 
        'MsgBox(filename + " read " + fanno.ToString)
    End Sub

    Public Function loadfandata(filename, fanno) As String
        'Dim FullFilePathtxt As String`  
        ''        FullFilePathtxt = "C:\Halifax\Performance Data new\" + filename + ".txt"
        'FullFilePathtxt = "C:\Halifax" + filename
        'Dim objStreamReader As New StreamReader(FullFilePathtxt)
        'ReadfromTextfile(filename, fanno)

        If Frmselectfan.OptXLS.Checked = True Then ReadfromExcelfile(filename, fanno)
        If Frmselectfan.OptTXT.Checked = True Then ReadfromTextfile(filename, fanno)


        ''If Frmselectfan.Comfspunits.Value = "InsWG" Then
        ''    colfsp = 2
        ''    colftp = 5
        ''End If
        ''If Frmselectfan.Comfspunits.Value = "Pa" Then
        'colfsp = 13 'Pa
        'colftp = 14 'Pa
        ''End If
        ''If Frmselectfan.Comfspunits.Value = "mmWG" Then
        ''    colfsp = 7'mmWG
        ''    colftp = 10'mmWG
        ''End If
        ''If Frmselectfan.Comfspunits.Value = "mbar" Then
        ''    colfsp = 15'mBar
        ''    colftp = 16'mBar
        ''End If

        ''        If FlowType = 1 Then
        'colvol = 9 'm3/hr
        ''End If
        ''If FlowType = 2 Then
        ''    colvol = 11'm3/min
        ''End If
        ''If FlowType = 3 Then
        ''    colvol = 12'm3/sec
        ''End If
        ''If FlowType = 4 Then
        ''    colvol = 4'cfm
        ''End If

        ''If Frmselectfan.Compowunits.Value = "KW" Then
        'colpow = 8 'kW
        ''Else
        ''    colpow = 3'HP
        ''End If
        ''----setting the number of decimal places-------------------------------------------
        If FlowType = 3 Then
            voldecplaces = 3
        Else
            voldecplaces = 0
        End If
        If FlowType = 2 Then
            voldecplaces = 2
        End If
        If Val(Frmselectfan.Txtflow.Text) > 10000 Then
            voldecplaces = 0
        ElseIf Val(Frmselectfan.Txtflow.Text) > 1000 Then
            voldecplaces = 1
        ElseIf Val(Frmselectfan.Txtflow.Text) > 100 Then
            voldecplaces = 2
        ElseIf Val(Frmselectfan.Txtflow.Text) > 10 Then
            voldecplaces = 3
        End If

        pressplaceRise = 2
        If Val(Frmselectfan.Txtfsp.Text) > 10000 Then
            pressplaceRise = 0
        ElseIf Val(Frmselectfan.Txtfsp.Text) > 1000 Then
            pressplaceRise = 1
        ElseIf Val(Frmselectfan.Txtfsp.Text) > 100 Then
            pressplaceRise = 2
        ElseIf Val(Frmselectfan.Txtfsp.Text) > 10 Then
            pressplaceRise = 3
        End If

        colfte = 20
        colfse = 19

        coloutletvel = 17
        colstdfansizes = 21 '-column number for the fan size

        Dim i As Integer

        count = 0

        counteff = 1
        row = 9

        'FanSize1 = objStreamReader.ReadLine()
        'FanSpeed1 = objStreamReader.ReadLine()
        'FanSize2 = objStreamReader.ReadLine()
        'Num_Readings = objStreamReader.ReadLine()
        'Most_Eff_Pt = objStreamReader.ReadLine()
        ''        medpoint(1) = Most_Eff_Pt
        'OutLen_mm = objStreamReader.ReadLine()
        'OutWid_mm = objStreamReader.ReadLine()
        'OutArea_m2 = objStreamReader.ReadLine()
        'OutLen_ft = objStreamReader.ReadLine()
        'OutWid_ft = objStreamReader.ReadLine()
        'OutArea_ft2 = objStreamReader.ReadLine()
        'In_Dia_mm = objStreamReader.ReadLine()
        'Eye_Area_m2 = objStreamReader.ReadLine()
        'Blade_Type = objStreamReader.ReadLine()
        'Num_Blades = objStreamReader.ReadLine()

        'For i = 0 To Num_Readings - 1
        '    FSP_insWG(i) = objStreamReader.ReadLine()
        'Next
        'For i = 0 To Num_Readings - 1
        '    Pow_hp(i) = objStreamReader.ReadLine()
        'Next
        'For i = 0 To Num_Readings - 1
        '    Vol_cfm(i) = objStreamReader.ReadLine()
        'Next
        'For i = 0 To Num_Readings - 1
        '    FTP_insWG(i) = objStreamReader.ReadLine()
        'Next
        'For i = 0 To Num_Readings - 1
        '    FSP_mmwg(i) = objStreamReader.ReadLine()
        'Next
        'For i = 0 To Num_Readings - 1
        '    Pow_kw(i) = objStreamReader.ReadLine()
        'Next
        'For i = 0 To Num_Readings - 1
        '    Vol_m3hr(i) = objStreamReader.ReadLine()
        'Next
        'For i = 0 To Num_Readings - 1
        '    FTP_mmWG(i) = objStreamReader.ReadLine()
        'Next
        'For i = 0 To Num_Readings - 1
        '    Vol_m3min(i) = objStreamReader.ReadLine()
        'Next
        'For i = 0 To Num_Readings - 1
        '    Vol_m3sec(i) = objStreamReader.ReadLine()
        'Next
        'For i = 0 To Num_Readings - 1
        '    FSP_pa(i) = objStreamReader.ReadLine()
        'Next
        'For i = 0 To Num_Readings - 1
        '    FTP_pa(i) = objStreamReader.ReadLine()
        'Next
        'For i = 0 To Num_Readings - 1
        '    FSP_mbar(i) = objStreamReader.ReadLine()
        'Next
        'For i = 0 To Num_Readings - 1
        '    FTP_mbar(i) = objStreamReader.ReadLine()
        'Next
        'For i = 0 To Num_Readings - 1
        '    OV_msec(i) = objStreamReader.ReadLine()
        'Next
        'For i = 0 To Num_Readings - 1
        '    OV_fmin(i) = objStreamReader.ReadLine()
        'Next
        'For i = 0 To Num_Readings - 1
        '    FSE1(i) = objStreamReader.ReadLine()
        'Next
        'For i = 0 To Num_Readings - 1
        '    FTE1(i) = objStreamReader.ReadLine()
        'Next
        'For i = 0 To 29
        '    STD_Fan_Size(i) = objStreamReader.ReadLine()
        '    fsizes(fanno, i) = STD_Fan_Size(i)
        'Next
        ''                MsgBox("all read")

        ReDim ftp(30, 50)
        ReDim vol(30, 50)
        ReDim Pow(30, 50)
        ReDim fte(30, 50)
        ReDim fsp(30, 50)
        ReDim fse(30, 50)
        ReDim ovel(30, 50)

        '        Do While count <= Num_Readings - 1
        For count = 0 To Num_Readings - 1
            If Units(1).UnitSelected = 0 Then
                fsp(fanno, count) = FSP_pa(count)
                ftp(fanno, count) = FTP_pa(count)
            ElseIf Units(1).UnitSelected = 1 Then
                fsp(fanno, count) = FSP_insWG(count)
                ftp(fanno, count) = FTP_insWG(count)
            ElseIf Units(1).UnitSelected = 2 Then
                fsp(fanno, count) = FSP_mmwg(count)
                ftp(fanno, count) = FTP_mmWG(count)
            ElseIf Units(1).UnitSelected = 3 Then
                fsp(fanno, count) = FSP_mbar(count)
                ftp(fanno, count) = FTP_mbar(count)
            End If
            If Units(0).UnitSelected = 0 Then
                vol(fanno, count) = Vol_m3hr(count)
            ElseIf Units(0).UnitSelected = 1 Then
                vol(fanno, count) = Vol_m3min(count)
            ElseIf Units(0).UnitSelected = 2 Then
                vol(fanno, count) = Vol_m3sec(count)
            ElseIf Units(0).UnitSelected = 3 Then
                vol(fanno, count) = Vol_cfm(count)
            End If
            If Units(4).UnitSelected = 0 Then
                Pow(fanno, count) = Pow_kw(count)
            ElseIf Units(4).UnitSelected = 1 Then
                Pow(fanno, count) = Pow_hp(count)
            End If
            fte(fanno, count) = FTE1(count)
            fse(fanno, count) = FSE1(count)
            If Units(7).UnitSelected = 0 Then
                ovel(fanno, count) = OV_msec(count)
            ElseIf Units(7).UnitSelected = 1 Then
                ovel(fanno, count) = OV_fmin(count)
            End If
            If fte(fanno, count) > fte(fanno, counteff) Then counteff = count
            '            count = count + 1
            '            row = row + 1
        Next
        '       Loop
        datafansize(fanno) = FanSize1
        datafanspeed(fanno) = FanSpeed1
        dataoutletarea(fanno) = OutArea_m2
        dataoutletareaftsq(fanno) = OutArea_ft2
        datapoints1 = Num_Readings
        medpoint(fanno) = Most_Eff_Pt
        If PType = 1 Then medpoint(fanno) = counteff

        FanMaxCount(fanno) = datapoints1
        If PType = 1 Then
            For II = datapoints1 To 1 Step -1
                If ftp(fanno, II) > ftp(fanno, FanMaxCount(fanno)) Then FanMaxCount(fanno) = II
            Next II
        Else
            For II = datapoints1 To 1 Step -1
                If fsp(fanno, II) > fsp(fanno, FanMaxCount(fanno)) Then FanMaxCount(fanno) = II
            Next II
        End If

        count = 1
        row = 9
        'Do While ActiveWorkbook.Worksheets(fanno).Cells(row, colstdfansizes).Value <> ""
        '    fsizes(fanno, count) = Val(ActiveWorkbook.Worksheets(fanno).Cells(row, colstdfansizes).Value)
        '    count = count + 1
        '    row = row + 1
        'Loop
        'objStreamReader.Close() 'Close 
        Return "Complete"
    End Function

    'Private Sub Fast(arr As String(,))

    '    Dim App As Excel.Application = Nothing
    '    Dim WorkBooks As Excel.Workbooks = Nothing
    '    Dim ActiveWorkbook As Excel.Workbook = Nothing

    '    Dim sheet As Excel._Worksheet = TryCast(App.ActiveSheet, Excel._Worksheet)
    '    Dim sheetCells As Excel.Range = sheet.Cells
    '    Dim cellFirst As Excel.Range = TryCast(sheetCells(1, 1), Excel.Range)
    '    Dim cellLast As Excel.Range = TryCast(sheetCells(40, 21), Excel.Range)
    '    Dim theRange As Excel.Range = sheet.Range(cellFirst, cellLast)
    '    theRange.Value = arr
    'End Sub

    Public Function getmotorsize(abspower)
        Dim col As Integer
        If (Units(4).UnitSelected = 0) Then
            col = 0
        Else
            col = 1
        End If
        Dim FullFilePathtxt As String
        FullFilePathtxt = "C:\Halifax\Performance Data new\motors.txt"
        Dim objStreamReader As New StreamReader(FullFilePathtxt)

        For count1 = 0 To 1
            For count2 = 0 To 99
                motorsize(count1, count2) = objStreamReader.ReadLine()
            Next
        Next



        '    Do While Cells(count, col) <> 0
        '        motorsize(count) = Val(Cells(count, col).Value)
        '        count = count + 1
        '    Loop
        'End With
        count = 0
        Do While (abspower * 1.1) > motorsize(col, count)
            count = count + 1
            If count = 100 Then
                'akm temp removed                MsgBox("A Larger Non-Standard Motor is required for selected Fan!", vbInformation)
                getmotorsize = "Out Of Range"
                Exit Do
            End If
        Loop
        getmotorsize = motorsize(col, count)
        'getmotorsize = abspower * 1.1 'temp entry
    End Function

End Module
