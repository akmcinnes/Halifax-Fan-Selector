Imports System.IO
Module Sub_Selections
    Sub SetupSelectionPage()
        Try
            With Frmselectfan
                'TabPageSelection.BackColor = Background_Color
                'If OptPoleSpeed.Checked = True And Opt2Pole.Checked = False And
                '    Opt4Pole.Checked = False And Opt6Pole.Checked = False And
                '    Opt8Pole.Checked = False And Opt10Pole.Checked = False And Opt12Pole.Checked = False Then
                '    MsgBox("Please select a pole speed before continuing")
                '    TabPageDuty.Select()
                '    Exit Sub
                'End If


                If .TabControl1.SelectedTab.Text.Contains("Selection") Then
                    Call initializeSelections()
                    .ColumnHeader(0) = Units(5).UnitName(Units(5).UnitSelected) '"mm" '.Comimpunits.Text
                    .ColumnHeader(1) = " "
                    .ColumnHeader(2) = "RPM"
                    .ColumnHeader(3) = Units(0).UnitName(Units(0).UnitSelected) '"m³/hr" '.Comflowunits.Text
                    .ColumnHeader(4) = Units(1).UnitName(Units(1).UnitSelected) '"Pa" '.Comfspunits.Text
                    .ColumnHeader(5) = Units(1).UnitName(Units(1).UnitSelected) '"Pa" '.Comfspunits.Text
                    If Units(4).UnitSelected < 2 Then
                        .ColumnHeader(6) = Units(4).UnitName(Units(4).UnitSelected) ' "kW" '.Compowunits.Text
                        .ColumnHeader(7) = Units(4).UnitName(Units(4).UnitSelected) ' "kW" '.Compowunits.Text
                        .ColumnHeader(8) = "%"
                        .ColumnHeader(9) = "%"
                        .ColumnHeader(10) = Units(7).UnitName(Units(7).UnitSelected) '"m/s"
                        .ColumnHeader(11) = "%"
                        .ColumnHeader(12) = "%"
                    ElseIf Units(4).UnitSelected = 2 Then
                        'separate columns
                        'ColumnHeader(6) = Units(4).UnitName(0) ' "kW" '.Compowunits.Text
                        'ColumnHeader(7) = Units(4).UnitName(0) ' "hp" '.Compowunits.Text
                        'ColumnHeader(8) = Units(4).UnitName(1) ' "kW" '.Compowunits.Text
                        'ColumnHeader(9) = Units(4).UnitName(1) ' "hp" '.Compowunits.Text
                        'ColumnHeader(10) = "%"
                        'ColumnHeader(11) = "%"
                        'ColumnHeader(12) = Units(7).UnitName(Units(7).UnitSelected) '"m/s"
                        'ColumnHeader(13) = "%"
                        'ColumnHeader(14) = "%"
                        'combined columns
                        .ColumnHeader(6) = Units(4).UnitName(0) + " / " + Units(4).UnitName(1) ' "kW" '.Compowunits.Text
                        .ColumnHeader(7) = Units(4).UnitName(0) + " / " + Units(4).UnitName(1) ' "kW" '.Compowunits.Text
                        .ColumnHeader(8) = "%"
                        .ColumnHeader(9) = "%"
                        .ColumnHeader(10) = Units(7).UnitName(Units(7).UnitSelected) '"m/s"
                        .ColumnHeader(11) = "%"
                        .ColumnHeader(12) = "%"
                    End If
                    .LblGasDensityUnit.Text = Units(3).UnitName(Units(3).UnitSelected) '"kg/m³" '.Comairdenunits.Text
                    .TxtDensity.Text = .Txtdens.Text 'Round(originaldensity, 3)
                    originaldensity = Val(.Txtdens.Text)

                    .DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 9, FontStyle.Bold)
                    .DataGridView1.DefaultCellStyle.Font = New Font("Tahoma", 9)

                    .DataGridView1.GridColor = Color.Red
                    .DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single

                    .DataGridView1.BackgroundColor = Color.LightGray

                    .DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Cyan
                    .DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black

                    .DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]

                    .DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .DataGridView1.AllowUserToResizeColumns = False

                    .DataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque
                    .DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige

                    'If Units(4).UnitSelected = 2 Then .DataGridView1.ScrollBars = ScrollBars.Horizontal

                    Dim i As Integer
                    .DataGridView1.RowCount = 10
                    .DataGridView1.ColumnCount = 50
                    i = 0

                    Column_Header1(i, "SIZE", "Colsize", .ColumnHeader(0))
                    Column_Header1(i, "Size", "Colsize", "empty")
                    i = i + 1
                    Column_Header1(i, "Type", "Coltype", "empty")
                    i = i + 1
                    Column_Header1(i, "Speed", "Colspeed", .ColumnHeader(2))
                    i = i + 1
                    Column_Header1(i, "Flow", "Colvolume", .ColumnHeader(3))
                    i = i + 1
                    Column_Header1(i, "Fan Static Pressure", "Colfsp", .ColumnHeader(4))
                    i = i + 1
                    Column_Header1(i, "Fan Total Pressure", "Colftp", .ColumnHeader(5))
                    i = i + 1
                    If Units(4).UnitSelected < 2 Then
                        Column_Header1(i, "Fan Power", "Colpower", .ColumnHeader(6))
                        i = i + 1
                        Column_Header1(i, "Motor Power", "Colmotor", .ColumnHeader(7))
                        i = i + 1
                        Column_Header1(i, "Fan Static Efficiency", "Colfse", .ColumnHeader(8))
                        i = i + 1
                        Column_Header1(i, "Fan Total Efficiency", "Colfte", .ColumnHeader(9))
                        i = i + 1
                        Column_Header1(i, "Outlet Velocity", "Coloutletvel", .ColumnHeader(10))
                        i = i + 1
                        Column_Header1(i, "Reserve Head", "Colrhead", .ColumnHeader(11))
                        i = i + 1
                        Column_Header1(i, "Volume TD", "Colvoltd", .ColumnHeader(12))
                    ElseIf Units(4).UnitSelected = 2 Then
                        'separate columns
                        'Column_Header1(i, "Fan Power", "Colpower", ColumnHeader(6))
                        'i = i + 1
                        'Column_Header1(i, "Motor Power", "Colmotor", ColumnHeader(7))
                        'i = i + 1
                        'Column_Header1(i, "Fan Power", "Colpower", ColumnHeader(8))
                        'i = i + 1
                        'Column_Header1(i, "Motor Power", "Colmotor", ColumnHeader(9))
                        'i = i + 1
                        'Column_Header1(i, "Fan Static Efficiency", "Colfse", ColumnHeader(10))
                        'i = i + 1
                        'Column_Header1(i, "Fan Total Efficiency", "Colfte", ColumnHeader(11))
                        'i = i + 1
                        'Column_Header1(i, "Outlet Velocity", "Coloutletvel", ColumnHeader(12))
                        'i = i + 1
                        'Column_Header1(i, "Reserve Head", "Colrhead", ColumnHeader(13))
                        'i = i + 1
                        'Column_Header1(i, "Volume TD", "Colvoltd", ColumnHeader(14))
                        'combined columns
                        Column_Header1(i, "Fan Power", "Colpower", .ColumnHeader(6))
                        i = i + 1
                        Column_Header1(i, "Motor Power", "Colmotor", .ColumnHeader(7))
                        i = i + 1
                        Column_Header1(i, "Fan Static Efficiency", "Colfse", .ColumnHeader(8))
                        i = i + 1
                        Column_Header1(i, "Fan Total Efficiency", "Colfte", .ColumnHeader(9))
                        i = i + 1
                        Column_Header1(i, "Outlet Velocity", "Coloutletvel", .ColumnHeader(10))
                        i = i + 1
                        Column_Header1(i, "Reserve Head", "Colrhead", .ColumnHeader(11))
                        i = i + 1
                        Column_Header1(i, "Volume TD", "Colvoltd", .ColumnHeader(12))
                    End If
                    .DataGridView1.ColumnCount = i + 1
                    .DataGridView1.Width = .DataGridView1.Width * 1.1
                    '.DataGridView1.ColumnHeadersHeight = .DataGridView1.ColumnHeadersHeight * 1.1


                    Dim filenameref As String = "FILENAME REF DATA"
                    ReadReffromBinaryfile(filenameref)

                    Dim m, n As Integer
                    .DataGridView1.Width = 0

                    .DataGridView1.RowCount = fantypesQTY + 1
                    For m = 0 To .DataGridView1.RowCount - 1
                        .DataGridView1.Rows(m).Height = 24
                    Next
                    Dim len As Integer
                    Dim fanint As Integer = 0
                    Dim k As Integer
                    For k = 0 To fantypesQTY - 1
                        Dim FullFilePathtxt As String
                        'FullFilePathtxt = "C:\Halifax" + fantypefilename(k)
                        FullFilePathtxt = DataPath + fantypefilename(k)
                        If Not File.Exists(FullFilePathtxt) Then
                            fanclass(k) = Nothing
                        End If
                        If fanclass(k) IsNot Nothing Then
                            Call LoadFanData(fantypefilename(k), fanint)
                            fanint = fanint + 1
                        End If
                    Next


                    If Units(4).UnitSelected < 2 Then
                        For n = 0 To .DataGridView1.RowCount - 1
                            For m = 0 To .DataGridView1.ColumnCount - 1
                                If n = 0 Then .DataGridView1.Width = .DataGridView1.Width + .DataGridView1.Columns(m).Width
                                Select Case m
                                    Case 1
                                        If fanclass(n) IsNot Nothing Then
                                            '                            .DataGridView1.Rows(n).Cells(m).Value = fanclass(n)
                                            len = If(fanclass(n).Length < .DataGridView1.Columns(m).Width / 8, .DataGridView1.Columns(m).Width / 8, fanclass(n).Length)
                                            .DataGridView1.Columns(m).Width = len * 8
                                            .DataGridView1.Width = .DataGridView1.Width + .DataGridView1.Columns(m).Width
                                        Else
                                            .DataGridView1.Rows(n).Cells(m).Value = "empty"
                                        End If
                                    Case 3
                                        .DataGridView1.Rows(n).Cells(m).Value = Math.Round(vol(1, n), voldecplaces).ToString
                                    Case 4
                                        .DataGridView1.Rows(n).Cells(m).Value = Math.Round(fsp(1, n), pressplaceRise).ToString
                                    Case 5
                                        .DataGridView1.Rows(n).Cells(m).Value = Math.Round(ftp(1, n), pressplaceRise).ToString
                                    Case 6
                                        .DataGridView1.Rows(n).Cells(m).Value = Math.Round(Powr(1, n), 2).ToString
                                    Case 8
                                        .DataGridView1.Rows(n).Cells(m).Value = Math.Round(fse(1, n), 3).ToString
                                    Case 9
                                        .DataGridView1.Rows(n).Cells(m).Value = Math.Round(fte(1, n), 3).ToString
                                    Case 10
                                        .DataGridView1.Rows(n).Cells(m).Value = Math.Round(ovel(1, n), 3).ToString
                                End Select
                                '.DataGridView1.Rows(n).Cells(m).Value = "test" + (i * j).ToString
                            Next
                        Next
                    ElseIf Units(4).UnitSelected = 2 Then
                        'For n = 0 To DataGridView1.RowCount - 1
                        '    For m = 0 To DataGridView1.ColumnCount - 1
                        '        If n = 0 Then DataGridView1.Width = DataGridView1.Width + DataGridView1.Columns(m).Width
                        '        Select Case m
                        '            Case 1
                        '                If fanclass(n) IsNot Nothing Then
                        '                    '                            DataGridView1.Rows(n).Cells(m).Value = fanclass(n)
                        '                    len = If(fanclass(n).Length < DataGridView1.Columns(m).Width / 8, DataGridView1.Columns(m).Width / 8, fanclass(n).Length)
                        '                    DataGridView1.Columns(m).Width = len * 8
                        '                    DataGridView1.Width = DataGridView1.Width + DataGridView1.Columns(m).Width
                        '                Else
                        '                    DataGridView1.Rows(n).Cells(m).Value = "empty"
                        '                End If
                        '            Case 3
                        '                DataGridView1.Rows(n).Cells(m).Value = Math.Round(vol(1, n), voldecplaces).ToString
                        '            Case 4
                        '                DataGridView1.Rows(n).Cells(m).Value = Math.Round(fsp(1, n), pressplaceRise).ToString
                        '            Case 5
                        '                DataGridView1.Rows(n).Cells(m).Value = Math.Round(ftp(1, n), pressplaceRise).ToString
                        '            Case 6
                        '                DataGridView1.Rows(n).Cells(m).Value = Math.Round(Powr(1, n), 2).ToString
                        '            Case 8
                        '                DataGridView1.Rows(n).Cells(m).Value = Math.Round(Powr(1, n) / 0.746, 2).ToString
                        '            Case 10
                        '                DataGridView1.Rows(n).Cells(m).Value = Math.Round(fse(1, n), 3).ToString
                        '            Case 11
                        '                DataGridView1.Rows(n).Cells(m).Value = Math.Round(fte(1, n), 3).ToString
                        '            Case 12
                        '                DataGridView1.Rows(n).Cells(m).Value = Math.Round(ovel(1, n), 3).ToString
                        '        End Select
                        '        'DataGridView1.Rows(n).Cells(m).Value = "test" + (i * j).ToString
                        '    Next
                        'Next
                        For n = 0 To .DataGridView1.RowCount - 1
                            For m = 0 To .DataGridView1.ColumnCount - 1
                                If n = 0 Then .DataGridView1.Width = .DataGridView1.Width + .DataGridView1.Columns(m).Width
                                Select Case m
                                    Case 1
                                        If fanclass(n) IsNot Nothing Then
                                            '                            .DataGridView1.Rows(n).Cells(m).Value = fanclass(n)
                                            len = If(fanclass(n).Length < .DataGridView1.Columns(m).Width / 8, .DataGridView1.Columns(m).Width / 8, fanclass(n).Length)
                                            .DataGridView1.Columns(m).Width = len * 8
                                            .DataGridView1.Width = .DataGridView1.Width + .DataGridView1.Columns(m).Width
                                        Else
                                            .DataGridView1.Rows(n).Cells(m).Value = "empty"
                                        End If
                                    Case 3
                                        .DataGridView1.Rows(n).Cells(m).Value = Math.Round(vol(1, n), voldecplaces).ToString
                                    Case 4
                                        .DataGridView1.Rows(n).Cells(m).Value = Math.Round(fsp(1, n), pressplaceRise).ToString
                                    Case 5
                                        .DataGridView1.Rows(n).Cells(m).Value = Math.Round(ftp(1, n), pressplaceRise).ToString
                                    Case 6
                                        .DataGridView1.Rows(n).Cells(m).Value = Math.Round(Powr(1, n), 2).ToString + " / " + Math.Round(Powr(1, n) / 0.746, 2).ToString
                                    'If Units(4).UnitSelected = 2 Then
                                    '    .DataGridView1.Columns(m).Width = .DataGridView1.Columns(m).Width * 2
                                    'End If

                                    Case 8
                                        .DataGridView1.Rows(n).Cells(m).Value = Math.Round(fse(1, n), 3).ToString
                                    Case 9
                                        .DataGridView1.Rows(n).Cells(m).Value = Math.Round(fte(1, n), 3).ToString
                                    Case 10
                                        .DataGridView1.Rows(n).Cells(m).Value = Math.Round(ovel(1, n), 3).ToString
                                End Select
                                '.DataGridView1.Rows(n).Cells(m).Value = "test" + (i * j).ToString
                            Next
                        Next

                    End If



                    'If .DataGridView1.RowCount > 10 Then
                    '    .DataGridView1.Height = (240 + .DataGridView1.ColumnHeadersHeight) * 1.1
                    '    .DataGridView1.ScrollBars = ScrollBars.Vertical
                    'Else
                    .DataGridView1.Height = (.DataGridView1.RowCount * 24 + .DataGridView1.ColumnHeadersHeight) * 1.1
                    .DataGridView1.ColumnHeadersHeight = 400
                    'End If

                    .DataGridView1.Width = 0
                    .DataGridView1.Columns(0).Width = .DataGridView1.Columns(0).Width * 0.8
                    If Units(4).UnitSelected = 2 Then
                        .DataGridView1.Columns(6).Width = .DataGridView1.Columns(6).Width * 1.5
                    End If
                    For i = 0 To .DataGridView1.ColumnCount - 1
                        .DataGridView1.Width = .DataGridView1.Width + .DataGridView1.Columns(i).Width
                    Next
                    .DataGridView1.Width = .DataGridView1.Width * 1.03
                    '        Me.Width = .DataGridView1.Width * 1.1
                    .Width = .DataGridView1.Width + 5 * .DataGridView1.Location.X
                    .DataGridView1.Height = .DataGridView1.Height * 1.1 + .DataGridView1.Location.Y
                    If .DataGridView1.Height < 350 Then .DataGridView1.Height = 350
                    '.CenterToScreen()
                    .chkKP.Visible = StartArg.ToLower.Contains("-dev")

                    .chkDisplayAll.Visible = AdvancedUser
                    .chkDisplayAll.Text = "Include fans < " + reshead.ToString + "% Reserve Head"

                    .chkDisplayLowerEff.Visible = AdvancedUser
                    .chkDisplayLowerEff.Text = "Include fans < 60% Fan Efficiency"

                    'chkDisplayLowerEff.Right.Equals(chkDisplayAll.Right)
                    Dim nRight As Integer
                    nRight = .chkDisplayAll.Right
                    .chkDisplayLowerEff.Right.Equals(nRight)

                    Dim tempsize As Double = CDbl(.Txtfansize.Text)
                    Dim tempspeed As Double = CDbl(.Txtfanspeed.Text)
                    Dim tempflow As Double = CDbl(.Txtflow.Text)
                    Dim tempfsp As Double = CDbl(.Txtfsp.Text)

                    If .OptAnySpeed.Checked = True Then
                        tempspeed = 0.0
                    End If

                    If .OptAnySize.Checked = True Then
                        tempsize = 0.0
                    End If

                    For k = 0 To fantypesQTY - 1 'akm200118
                        '-----------------------------------------------------------------------------
                        '----- FOR KNOWN DUTY BUT NO SPEED OR FAN SIZE GIVEN -------------------------
                        '------------------------------------------------------------------------------

                        'Dim size As Double = CDbl(.Txtfansize.Text)
                        If tempsize = 0 And tempspeed = 0 And tempflow <> 0 And tempfsp <> 0 Then
                            Call NoSpeedNosize(k)
                        End If

                        '----------------------------------------------------------------------------------------
                        '---------------start of selecting fan size based on a given speed and duty point--------
                        '-----------------------------------------------------------------------------------------
                        If tempspeed <> 0 And tempflow <> 0 And tempfsp <> 0 And tempsize = 0 Then
                            Call WithSpeedNoSize(k)
                        End If

                        '----------------------------------------------------------------------------------------
                        '-----------------------Start of listing duty of known fan size and speed
                        '---------------------------------------------------------------------------------------------
                        If tempsize <> 0 And tempspeed <> 0 And tempflow = 0 And tempfsp = 0 Then
                            Call WithSpeedWithSize(k)
                        End If

                        '-----------------------------------------------------------------------------------------------
                        '-----------------------------start of selecting fan with size and volume & pressure------------
                        '-----------------------------------------------------------------------------------------------
                        If tempsize <> 0 And tempflow <> 0 And tempfsp <> 0 And tempspeed = 0 Then
                            Call WithSizeVolPressure(k)
                        End If

                        '-------------------------------------------------------------------------------------------------
                        '-------------------------start of finding pressure for selected fan speed size and volume--------
                        '-------------------------------------------------------------------------------------------------
                        If tempsize <> 0 And tempflow <> 0 And tempspeed <> 0 Then
                            Call WithSpeedSizeVolume(k)
                        End If

                        '--------------------------------------------------------------------------------------
                        '-----------------------start of finding volume for given pressure and fan speed------
                        '-------------------------------------------------------------------------------------
                        If tempsize <> 0 And tempflow = 0 And tempfsp <> 0 And tempspeed <> 0 Then
                            Call WithSpeedPressure(k)
                        End If
                        'If selectedfansize(k) > 0 Then
                        'End If
                        Call ResHDandVolTD(k)
                    Next

                    Call PopulateGrid()
                    'objStreamWriterDebug.WriteLine("Grid populated")
                End If

            End With
        Catch ex As Exception
            MsgBox("SetupSelectionPage")
            ErrorMessage(ex, 1301)
        End Try
    End Sub
    Sub initializeSelections()
        Try
            For i = 0 To 49
                selectedfansize(i) = 0.0
                selectedfantype(i) = ""
                selectedfse(i) = 0.0
                selectedspeed(i) = 0.0
                selectedpow(i) = 0.0
                selectedfsp(i) = 0.0
                selectedfte(i) = 0.0
                selectedftp(i) = 0.0
                selectedov(i) = 0.0
                selectedvol(i) = 0.0
                selectedmot(i) = 0.0
                selectedresHD(i) = 0.0
                selectedVD(i) = 0.0
                selectedBladeType(i) = ""
                selectedBladeNumber(i) = 0
                selectedfanfile(i) = ""
            Next
            fantypesQTY = 0

        Catch ex As Exception
            MsgBox("Initializeselections")
            ErrorMessage(ex, 1302)
        End Try
    End Sub

    Sub Column_Header1(ByVal i As Integer, ByVal headertext As String, ByVal headername As String, Optional ByVal column_value As String = "empty")
        Try
            With Frmselectfan
                Dim HeaderArray() As String
                'Dim textlen1(10) As Integer
                Dim textlen As Integer
                Dim textlenunit As Integer
                Dim count As Integer
                Try
                    If (column_value IsNot "empty") Then
                        headertext = headertext + " (" + column_value + ")"
                    End If

                    headertext = Trim(headertext)
                    textlen = 0
                    If headertext.Contains(" ") Then
                        HeaderArray = Split(headertext, " ")
                        For count = 0 To HeaderArray.Length - 1
                            'textlen = If(HeaderArray(0).Length > HeaderArray(1).Length, HeaderArray(0).Length, HeaderArray(1).Length)
                            'textlen1(count) = HeaderArray(count).Length
                            If HeaderArray(count).Length > textlen Then
                                textlen = HeaderArray(count).Length
                            End If
                        Next
                    Else
                        textlen = headertext.Length
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                'Dim HeaderArray = Split(headertext, " ")
                'Dim textlen = If(HeaderArray(0).Length > HeaderArray(1).Length, HeaderArray(0).Length, HeaderArray(1).Length)
                Dim len As Integer
                'Dim len2 As Integer
                .DataGridView1.Columns(i).HeaderText = headertext

                '        len = If(DataGridView1.Columns(i).HeaderText.Length < 8, 8, DataGridView1.Columns(i).HeaderText.Length)
                textlenunit = column_value.Length
                len = If(textlen < 8, 8, textlen)
                len = If(textlenunit < len, len, textlenunit)

                'If (column_value IsNot "empty") Then
                '    'DataGridView1.Columns(i).HeaderText = DataGridView1.Columns(i).HeaderText + vbCr + " (" + column_value + ")"
                '    'DataGridView1.Columns(i).HeaderText = DataGridView1.Columns(i).HeaderText + " (" + column_value + ")"
                '    DataGridView1.Columns(i).HeaderText = headertext + " (" + column_value + ")"
                'Else
                '    'DataGridView1.Columns(i).HeaderText = DataGridView1.Columns(i).HeaderText
                '    DataGridView1.Columns(i).HeaderText = headertext
                'End If

                .DataGridView1.Columns(i).Width = len * 8
                .DataGridView1.Width = .DataGridView1.Width + .DataGridView1.Columns(i).Width

                'DataGridView1.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
                .DataGridView1.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            End With
        Catch ex As Exception
            'MsgBox("Column_header")
            ErrorMessage(ex, 1303)
        End Try

    End Sub

    Sub PopulateGrid()
        Try
            With Frmselectfan

                Dim fansuccess As Integer = 0

                Dim lowest_power As Double = 99999.99
                Dim highlight As Integer = -1

                SetupGrid()

                'DataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque
                'DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige

                Dim minresHD As Double
                minresHD = reshead
                Dim maxresHD As Double
                maxresHD = 90.0
                Dim minefft As Double
                Dim mineffs As Double

                mineffs = 60.0
                minefft = 60.0
                If AdvancedUser And .chkDisplayAll.Checked = True Then minresHD = 0.0
                If AdvancedUser And .chkDisplayLowerEff.Checked = True Then mineffs = 0.0
                If AdvancedUser And .chkDisplayLowerEff.Checked = True Then minefft = 0.0

                Dim temppower, temppower2 As Double

                'pressure check
                Dim temppressS, temppressT As Double
                Dim pressrangemin As Double = 0.99
                Dim pressrangemax As Double = 1.01
                Dim pressok As Boolean


                For k = 0 To fantypesQTY - 1 'akm 201018
                    pressok = False
                    temppressS = selectedfsp(k) / pressrise
                    temppressT = selectedftp(k) / pressrise
                    If PresType = 0 And temppressS >= pressrangemin And temppressS <= pressrangemax Then
                        pressok = True
                    ElseIf PresType = 1 And temppressT >= pressrangemin And temppressT <= pressrangemax Then
                        pressok = True
                    End If

                    'If selectedfansize(k) > 0 And selectedresHD(k) >= minresHD And fanclass(k) IsNot Nothing Then
                    If selectedfansize(k) > 0 And
                        selectedresHD(k) >= minresHD And
                        (PresType = 0 And selectedfse(k) > mineffs Or PresType = 1 And selectedfte(k) > minefft) And
                        selectedresHD(k) < maxresHD And
                        pressok = True And
                        fanclass(k) IsNot Nothing Then
                        .DataGridView1.Rows(fansuccess).Cells(0).Value = selectedfansize(k).ToString
                        .DataGridView1.Rows(fansuccess).Cells(1).Value = fanclass(k)
                        .DataGridView1.Rows(fansuccess).Cells(2).Value = selectedspeed(k).ToString
                        .DataGridView1.Rows(fansuccess).Cells(3).Value = selectedvol(k).ToString
                        .DataGridView1.Rows(fansuccess).Cells(4).Value = selectedfsp(k).ToString
                        .DataGridView1.Rows(fansuccess).Cells(5).Value = selectedftp(k).ToString
                        .DataGridView1.Rows(fansuccess).Cells(6).Style.BackColor = .DataGridView1.Rows(fansuccess).Cells(0).Style.BackColor
                        'decimal places 2 for < 100, 1 for >= 100 < 1000, 0 for >= 1000
                        powerdecplaces = 2
                        If selectedpow(k) >= 100 Then powerdecplaces = 1
                        If selectedpow(k) >= 1000 Then powerdecplaces = 0
                        temppower = Math.Round(selectedpow(k), powerdecplaces)
                        temppower2 = Math.Round(selectedpow2(k), powerdecplaces)

                        If Units(4).UnitSelected < 2 Then
                            '.DataGridView1.Rows(fansuccess).Cells(6).Value = selectedpow(k).ToString
                            .DataGridView1.Rows(fansuccess).Cells(6).Value = temppower.ToString
                            If selectedmot(k) > 0 Then
                                .DataGridView1.Rows(fansuccess).Cells(7).Value = selectedmot(k).ToString
                            Else
                                .DataGridView1.Rows(fansuccess).Cells(7).Value = "Non Std"
                            End If
                            .DataGridView1.Rows(fansuccess).Cells(8).Value = selectedfse(k).ToString
                            .DataGridView1.Rows(fansuccess).Cells(9).Value = selectedfte(k).ToString
                            .DataGridView1.Rows(fansuccess).Cells(10).Value = selectedov(k).ToString
                            .DataGridView1.Rows(fansuccess).Cells(11).Value = selectedresHD(k).ToString

                            If selectedVD(k) < 0 Then
                                .DataGridView1.Rows(fansuccess).Cells(12).Value = "Stall"
                                .DataGridView1.Rows(fansuccess).Cells(12).Style.BackColor = Color.White
                                .DataGridView1.Rows(fansuccess).Cells(12).Style.ForeColor = Color.Red
                            Else
                                .DataGridView1.Rows(fansuccess).Cells(12).Value = selectedVD(k).ToString
                                .DataGridView1.Rows(fansuccess).Cells(12).Style.BackColor = .DataGridView1.Rows(fansuccess).Cells(0).Style.BackColor
                                .DataGridView1.Rows(fansuccess).Cells(12).Style.ForeColor = .DataGridView1.Rows(fansuccess).Cells(0).Style.ForeColor
                            End If

                            'If selectedresHD(k) < 5 Then
                            If selectedresHD(k) < reshead Then
                                .DataGridView1.Rows(fansuccess).Cells(11).Style.BackColor = Color.White
                                .DataGridView1.Rows(fansuccess).Cells(11).Style.ForeColor = Color.Red
                            Else
                                .DataGridView1.Rows(fansuccess).Cells(11).Style.BackColor = .DataGridView1.Rows(fansuccess).Cells(0).Style.BackColor
                                .DataGridView1.Rows(fansuccess).Cells(11).Style.ForeColor = .DataGridView1.Rows(fansuccess).Cells(0).Style.ForeColor
                            End If

                            If selectedpow(k) < lowest_power And selectedpow(k) > 0 And selectedresHD(k) >= reshead Then
                                lowest_power = selectedpow(k)
                                highlight = fansuccess
                            End If
                        ElseIf Units(4).UnitSelected = 2 Then
                            'DataGridView1.Rows(fansuccess).Cells(6).Value = selectedpow(k).ToString
                            'If selectedmot(k) > 0 Then
                            '    DataGridView1.Rows(fansuccess).Cells(7).Value = selectedmot(k).ToString
                            'Else
                            '    DataGridView1.Rows(fansuccess).Cells(7).Value = "Non Std"
                            'End If
                            'DataGridView1.Rows(fansuccess).Cells(8).Value = selectedpow2(k).ToString
                            'If selectedmot2(k) > 0 Then
                            '    DataGridView1.Rows(fansuccess).Cells(9).Value = selectedmot2(k).ToString
                            'Else
                            '    DataGridView1.Rows(fansuccess).Cells(9).Value = "Non Std"
                            'End If
                            'DataGridView1.Rows(fansuccess).Cells(10).Value = selectedfse(k).ToString
                            'DataGridView1.Rows(fansuccess).Cells(11).Value = selectedfte(k).ToString
                            'DataGridView1.Rows(fansuccess).Cells(12).Value = selectedov(k).ToString
                            'DataGridView1.Rows(fansuccess).Cells(13).Value = selectedresHD(k).ToString

                            'If selectedVD(k) < 0 Then
                            '    DataGridView1.Rows(fansuccess).Cells(14).Value = "Stall"
                            '    DataGridView1.Rows(fansuccess).Cells(14).Style.BackColor = Color.White
                            '    DataGridView1.Rows(fansuccess).Cells(14).Style.ForeColor = Color.Red
                            'Else
                            '    DataGridView1.Rows(fansuccess).Cells(14).Value = selectedVD(k).ToString
                            'End If

                            'If selectedresHD(k) < 5 Then
                            '    DataGridView1.Rows(fansuccess).Cells(13).Style.BackColor = Color.White
                            '    DataGridView1.Rows(fansuccess).Cells(13).Style.ForeColor = Color.Red
                            'End If

                            'If selectedpow(k) < lowest_power And selectedpow(k) > 0 Then
                            '    lowest_power = selectedpow(k)
                            '    highlight = fansuccess
                            'End If

                            '.DataGridView1.Rows(fansuccess).Cells(6).Value = selectedpow(k).ToString + " / " + selectedpow2(k).ToString
                            .DataGridView1.Rows(fansuccess).Cells(6).Value = temppower.ToString + " / " + temppower2.ToString
                            If selectedmot(k) > 0 Then
                                .DataGridView1.Rows(fansuccess).Cells(7).Value = selectedmot(k).ToString
                            Else
                                .DataGridView1.Rows(fansuccess).Cells(7).Value = "Non Std"
                            End If
                            .DataGridView1.Rows(fansuccess).Cells(7).Value = .DataGridView1.Rows(fansuccess).Cells(7).Value + " / "

                            If selectedmot2(k) > 0 Then
                                .DataGridView1.Rows(fansuccess).Cells(7).Value = .DataGridView1.Rows(fansuccess).Cells(7).Value + selectedmot2(k).ToString
                            Else
                                .DataGridView1.Rows(fansuccess).Cells(7).Value = .DataGridView1.Rows(fansuccess).Cells(7).Value + "Non Std"
                            End If
                            .DataGridView1.Rows(fansuccess).Cells(8).Value = selectedfse(k).ToString
                            .DataGridView1.Rows(fansuccess).Cells(9).Value = selectedfte(k).ToString
                            .DataGridView1.Rows(fansuccess).Cells(10).Value = selectedov(k).ToString
                            .DataGridView1.Rows(fansuccess).Cells(11).Value = selectedresHD(k).ToString

                            If selectedVD(k) < 0 Then
                                .DataGridView1.Rows(fansuccess).Cells(12).Value = "Stall"
                                .DataGridView1.Rows(fansuccess).Cells(12).Style.BackColor = Color.White
                                .DataGridView1.Rows(fansuccess).Cells(12).Style.ForeColor = Color.Red
                            Else
                                .DataGridView1.Rows(fansuccess).Cells(12).Value = selectedVD(k).ToString
                                .DataGridView1.Rows(fansuccess).Cells(12).Style.BackColor = .DataGridView1.Rows(fansuccess).Cells(0).Style.BackColor
                                .DataGridView1.Rows(fansuccess).Cells(12).Style.ForeColor = .DataGridView1.Rows(fansuccess).Cells(0).Style.ForeColor
                            End If

                            'If selectedresHD(k) < 5 Then
                            If selectedresHD(k) < reshead Then
                                .DataGridView1.Rows(fansuccess).Cells(11).Style.BackColor = Color.White
                                .DataGridView1.Rows(fansuccess).Cells(11).Style.ForeColor = Color.Red
                            Else
                                .DataGridView1.Rows(fansuccess).Cells(11).Style.BackColor = .DataGridView1.Rows(fansuccess).Cells(0).Style.BackColor
                                .DataGridView1.Rows(fansuccess).Cells(11).Style.ForeColor = .DataGridView1.Rows(fansuccess).Cells(0).Style.ForeColor
                            End If

                            If selectedpow(k) < lowest_power And selectedpow(k) > 0 And selectedresHD(k) >= reshead Then

                                lowest_power = selectedpow(k)
                                highlight = fansuccess
                            End If

                        End If

                        fansuccess = fansuccess + 1
                    End If
                Next
                .DataGridView1.RowCount = fansuccess
                .DataGridView1.Height = (.DataGridView1.RowCount * 24 + .DataGridView1.ColumnHeadersHeight) * 1.1
                If .DataGridView1.Height < 100 Then .DataGridView1.Height = 100
                'DataGridView1.Height = DataGridView1.Height * 1.1 + DataGridView1.Location.Y
                '++++++++++++++++++++++++++++++
                'If DataGridView1.RowCount > 9 Then
                '    DataGridView1.Height = (9 * 24 + DataGridView1.ColumnHeadersHeight) * 1.1
                '    DataGridView1.ScrollBars = ScrollBars.Vertical
                'Else
                '    DataGridView1.Height = (DataGridView1.RowCount * 24 + DataGridView1.ColumnHeadersHeight) * 1.1
                'End If
                'Dim mm, nn, zz As Double
                'mm = CDbl(DataGridView1.Height) * 1.1
                'nn = CDbl(DataGridView1.Location.Y)
                'zz = mm + nn
                'DataGridView1.Height = CInt(zz)
                ''Height = CInt(CDbl(DataGridView1.Height) * 1.1 + CDbl(DataGridView1.Location.Y))

                '++++++++++++++++++++++++++++++


                If .DataGridView1.Height > 350 Then .DataGridView1.Height = 350 ' was <
                'DataGridView1.Height = 350
                If highlight >= 0 Then
                    .DataGridView1.Rows(highlight).Cells(6).Style.BackColor = Color.LightGreen
                    .DataGridView1.CurrentCell = .DataGridView1.Rows(highlight).Cells(0)
                    'Dim irow As Integer
                    'irow = DataGridView1.Rows(highlight).Cells(6).Selected
                    'SelectRow(DataGridView1.CurrentCell.RowIndex)
                    'Else
                    'DataGridView1.Rows(highlight).Cells(6).Style.BackColor = DataGridView1.Rows(highlight).Cells(0).Style.BackColor
                    'DataGridView1.Rows(fansuccess).Cells(11).Style.ForeColor = DataGridView1.Rows(fansuccess).Cells(0).Style.ForeColor
                End If
            End With
        Catch ex As Exception
            'MsgBox(ex.Message + " PopulateGrid")
            ErrorMessage(ex, 1304)
        End Try

    End Sub

    Sub SetupGrid()
        Try
            With Frmselectfan

                'Dim DataGridView1 = New DataGridView()

                .DataGridView1.GridColor = Color.Red
                .DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single

                .DataGridView1.BackgroundColor = Color.LightGray

                .DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Cyan
                .DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black

                .DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]

                .DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .DataGridView1.AllowUserToResizeColumns = False

                .DataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque
                .DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
            End With
        Catch ex As Exception
            'MsgBox("setupgrid")
            ErrorMessage(ex, 1305)
        End Try

    End Sub

    Sub SelectRow(ii As Integer)
        Try
            With Frmselectfan
                .btnNoiseDataForward.Enabled = True
                .Label3.Visible = True
                .Label3.Text = "Selected Fan: "
                .LblFanDetails.Visible = True

                ' TabPageNoise.Show()
                ' TabControl1.Controls.Add(TabPageNoise)

                .LblFanDetails.Text = selectedfantype(ii) + " " + selectedfansize(ii).ToString + " running at " + selectedspeed(ii).ToString + " rpm"
                'Label19.Text = "File used = " + selectedfanfile(ii)
                'Label19.Visible = True

                finalfansize = selectedfansize(ii)
                finalfantype = selectedfantype(ii) 'string
                finalfse = selectedfse(ii)
                finalspeed = selectedspeed(ii)
                finalpow = selectedpow(ii)
                finalfsp = selectedfsp(ii)
                finalfte = selectedfte(ii)
                finalftp = selectedftp(ii)
                finalov = selectedov(ii)
                finalvol = selectedvol(ii)
                finalmot = selectedmot(ii)
                finalresHD = selectedresHD(ii)
                finalVD = selectedVD(ii)
                finalBladeType = selectedBladeType(ii)
                finalBladeNumber = selectedBladeNumber(ii)
                finalfanfile = selectedfanfile(ii)
                finalinletdia = selectedinletdia(ii)
                finaloutletarea = selectedoutletarea(ii)
                finaloutletlen = selectedoutletlen(ii)
                finaloutletwid = selectedoutletwid(ii)

                'TabPageNoise.Enabled = True
                .TabControl1.TabPages(3).Enabled = True
            End With

        Catch ex As Exception
            ErrorMessage(ex, 1306)
        End Try
    End Sub
End Module
