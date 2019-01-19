Imports System.IO
Imports System.Xml
Imports System.ComponentModel
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Frmselectfan
    Public totalcolumnwidth As Integer
    Public ColumnHeader(20) As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.CenterToScreen()
            NewProject = True
            TabPageNoise.Visible = False
            'TabControl1.TabPages.Remove(TabPageSelection)
            'TabControl1.TabPages.Remove(TabPageNoise)
            'TabControl1.TabPages.Remove(TabPageImpeller)

        Catch ex As Exception
            MsgBox("load")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If FileSaved = False Then
                If MsgBox("Project not saved - do you wish to save your project now?", vbYesNo, "Warning") = vbNo Then
                    End
                End If
            End If
            '        End

        Catch ex As Exception
            MsgBox("click")
        End Try
    End Sub

    ' ############################################################################################
    ' Tool Strip Section
    ' ############################################################################################

    Private Sub ProjectDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectDetailsToolStripMenuItem.Click
        Try
            FrmProjectDetails.ShowDialog()

        Catch ex As Exception
            MsgBox("ProjectDetailsToolStripMenuItem_Click")
        End Try
    End Sub

    Private Sub UnitsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles UnitsToolStripMenuItem.Click
        Try
            atmos = TxtAtmosphericPressure.Text
            FrmUnits.ShowDialog()

            'Txtflow.Text = Math.Round(Val(Txtflow.Text) * convflow, 3).ToString
            'TxtAtmosphericPressure.Text = Math.Round(Val(TxtAtmosphericPressure.Text) * convpres, 3).ToString
            'TxtInletPressure.Text = Math.Round(Val(TxtInletPressure.Text) * convpres, 3).ToString
            'TxtDischargePressure.Text = Math.Round(Val(TxtDischargePressure.Text) * convpres, 3).ToString
            'Txtfsp.Text = Math.Round(Val(Txtfsp.Text) * convpres, 3).ToString
            'Txtdens.Text = Math.Round(Val(Txtdens.Text) * convdens, 3).ToString
            'TxtAltitude.Text = Math.Round(Val(TxtAltitude.Text) * convalt, 3).ToString

            Units(2).UnitSelected = 1

        Catch ex As Exception
            MsgBox("UnitsToolStripMenuItem_Click_1")
        End Try
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Try
            NewProject = True
            Initialize()

        Catch ex As Exception
            MsgBox("OpenToolStripMenuItem_Click")
        End Try
    End Sub

    Private Sub SaveProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveProjectToolStripMenuItem.Click
        Try
            'set values for saving
            Dim SaveFileDialog1 As SaveFileDialog = New SaveFileDialog()
            SaveFileDialog1.InitialDirectory = "c:\Halifax\Projects\"
            SaveFileDialog1.Filter = "Halifax Selection|*.hfs"
            SaveFileDialog1.Title = "Save a Halifax Selection File"
            SaveFileDialog1.ShowDialog()
            SaveFileName = SaveFileDialog1.FileName

            If (SaveFileName.Length > 0) Then

                ' ### Open the save text file ###
                Dim textwriter As XmlTextWriter = New XmlTextWriter(SaveFileName, Nothing)

                ' ### Prepare the save text file ###
                textwriter.Formatting = Formatting.Indented
                textwriter.Indentation = 3
                textwriter.IndentChar = Char.Parse(" ")

                ' ### Write the data ###
                textwriter.WriteStartDocument()
                Write_to_XML(textwriter, "HFS File")
                WriteGeneralInfo(textwriter)
                WriteSelectionInputInfo(textwriter)

                ' ### Close the save text file ###
                textwriter.WriteEndDocument()
                textwriter.Close()

                MsgBox("File has been saved")

            End If

        Catch ex As Exception
            MsgBox("SaveProjectToolStripMenuItem_Click")
        End Try

    End Sub

    Private Sub OpenProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenProjectToolStripMenuItem.Click
        Try
            Dim OpenFileDialog1 As OpenFileDialog = New OpenFileDialog()
            OpenFileDialog1.InitialDirectory = "c:\Halifax\Projects\"
            OpenFileDialog1.Filter = "Halifax files (*.hfs)|*.hfs|All files (*.*)|*.*"
            OpenFileDialog1.ShowDialog()
            OpenFileName = OpenFileDialog1.FileName
            If OpenFileName = "" Then Exit Sub

            Dim textReader As XmlTextReader = New XmlTextReader(OpenFileName)
            textReader.MoveToFirstAttribute()
            Do While textReader.Read
                ReadGeneralInfo(textReader)
                ReadSelectionInputInfo(textReader)
            Loop
            ' ### Close the load text file ###
            textReader.Close()

            TxtAtmosphericPressure.Text = atmos.ToString
            TxtDesignTemperature.Text = designtemp.ToString
            TxtMaximumTemperature.Text = maximumtemp.ToString
            TxtAmbientTemperature.Text = ambienttemp.ToString
            TxtAltitude.Text = altitude.ToString
            TxtHumidity.Text = humidity.ToString
            TxtAtmosphericPressure.Text = atmospress.ToString
            Txtdens.Text = knowndensity.ToString
            Txtflow.Text = flowrate.ToString
            TxtInletPressure.Text = inletpress.ToString
            TxtDischargePressure.Text = dischpress.ToString
            Txtfsp.Text = pressrise.ToString
            CmbReserveHead.Text = reshead.ToString + "%"
            Txtspeedlimit.Text = maxspeed.ToString

        Catch ex As Exception
            MsgBox("OpenProjectToolStripMenuItem_Click")
        End Try


    End Sub

    Private Sub ExitProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitProjectToolStripMenuItem.Click
        Try
            If FileSaved = False Then
                If MsgBox("Project not saved - do you wish to save your project now?", vbYesNo, "Warning") = vbNo Then
                    End
                End If
            End If
            '        End

        Catch ex As Exception
            MsgBox("ExitProjectToolStripMenuItem_Click")
        End Try

    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Try
    '        'TabControl1.TabPages.Insert(1, TabPageSelection)
    '        'TabControl1.TabPages(1).Focus()
    '        'Call initializeSelections()
    '        '        TabControl1.SelectTab(1)
    '        SetupGrid()

    '        Dim i As Integer

    '        DataGridView1.ColumnCount = 50
    '        i = 0

    '        Column_Header(i, "SIZE", "Colsize", ColumnHeader(0))
    '        i = i + 1
    '        Column_Header(i, "TYPE", "Coltype", "empty")
    '        i = i + 1
    '        Column_Header(i, "SPEED", "Colspeed", ColumnHeader(2))
    '        i = i + 1
    '        Column_Header(i, "VOLUME", "Colvolume", ColumnHeader(3))
    '        i = i + 1
    '        Column_Header(i, "FSP", "Colfsp", ColumnHeader(4))
    '        i = i + 1
    '        Column_Header(i, "FTP", "Colftp", ColumnHeader(5))
    '        i = i + 1
    '        Column_Header(i, "POWER", "Colpower", ColumnHeader(6))
    '        i = i + 1
    '        Column_Header(i, "MOTOR", "Colmotor", ColumnHeader(7))
    '        i = i + 1
    '        Column_Header(i, "FSE", "Colfse", ColumnHeader(8))
    '        i = i + 1
    '        Column_Header(i, "FTE", "Colfte", ColumnHeader(9))
    '        i = i + 1
    '        Column_Header(i, "OUTLET VELOCITY", "Coloutletvel", ColumnHeader(10))
    '        i = i + 1
    '        Column_Header(i, "RESERVE HEAD", "Colrhead", ColumnHeader(11))
    '        i = i + 1
    '        Column_Header(i, "VOL TD", "Colvoltd", ColumnHeader(12))

    '        DataGridView1.ColumnCount = i + 1
    '        DataGridView1.Width = DataGridView1.Width * 1.1


    '        'Dim filename As String
    '        'ReadReffromTextfile("FILENAME REF DATA")
    '        'ReadReffromExcelfile("FILENAME REF DATA")
    '        Dim filenameref As String = "FILENAME REF DATA"
    '        If OptXLS.Checked = True Then ReadReffromExcelfile(filenameref)
    '        If OptTXT.Checked = True Then ReadReffromTextfile(filenameref)


    '        'filename = "FILENAME REF DATA" 'okay

    '        'FullFilePath = "C:\Halifax\Performance Data new\" + filename + ".txt"
    '        'Dim objStreamReader As New StreamReader(FullFilePath)

    '        'Dim j As Integer

    '        'Dim line As String
    '        ''count = 0
    '        'Dim TestArray() As String

    '        'Try
    '        '    For j = 0 To 100
    '        '        line = objStreamReader.ReadLine()
    '        '        TestArray = Split(line, ",")
    '        '        fantypename(j) = TestArray(0)
    '        '        fanclass(j) = TestArray(1)
    '        '        fantypefilename(j) = TestArray(2)
    '        '        fansizelimit(j) = CDbl(TestArray(3))
    '        '        fantypesecfilename(j) = TestArray(4)
    '        '        fanunits(j) = TestArray(5)
    '        '        fanwidthing(j) = CBool(TestArray(6))
    '        '    Next
    '        'Catch ex As Exception
    '        '    ' MsgBox(ex.ToString)
    '        'Finally
    '        '    objStreamReader.Close() 'Close 
    '        'End Try
    '        'fantypesQTY = j - 1

    '        Dim m, n As Integer
    '        DataGridView1.Width = 0

    '        DataGridView1.RowCount = fantypesQTY + 1
    '        For m = 0 To DataGridView1.RowCount - 1
    '            DataGridView1.Rows(m).Height = 24
    '        Next
    '        Dim len As Integer
    '        Dim k As Integer
    '        For k = 0 To fantypesQTY
    '            If fanclass(k) IsNot Nothing Then Call loadfandata(fantypefilename(k), k)
    '        Next
    '        For n = 0 To DataGridView1.RowCount - 1

    '            For m = 0 To DataGridView1.ColumnCount - 1
    '                If n = 0 Then DataGridView1.Width = DataGridView1.Width + DataGridView1.Columns(m).Width
    '                Select Case m
    '                    Case 1
    '                        If fanclass(n) IsNot Nothing Then
    '                            '                            DataGridView1.Rows(n).Cells(m).Value = fanclass(n)
    '                            len = If(fanclass(n).Length < DataGridView1.Columns(m).Width / 8, DataGridView1.Columns(m).Width / 8, fanclass(n).Length)
    '                            DataGridView1.Columns(m).Width = len * 8
    '                            DataGridView1.Width = DataGridView1.Width + DataGridView1.Columns(m).Width
    '                        End If
    '                    Case 3
    '                        DataGridView1.Rows(n).Cells(m).Value = Math.Round(vol(1, n), voldecplaces).ToString
    '                    Case 4
    '                        DataGridView1.Rows(n).Cells(m).Value = Math.Round(fsp(1, n), pressplaceRise).ToString
    '                    Case 5
    '                        DataGridView1.Rows(n).Cells(m).Value = Math.Round(ftp(1, n), pressplaceRise).ToString
    '                    Case 6
    '                        DataGridView1.Rows(n).Cells(m).Value = Math.Round(Powr(1, n), 2).ToString
    '                    Case 8
    '                        DataGridView1.Rows(n).Cells(m).Value = Math.Round(fse(1, n), 3).ToString
    '                    Case 9
    '                        DataGridView1.Rows(n).Cells(m).Value = Math.Round(fte(1, n), 3).ToString
    '                    Case 10
    '                        DataGridView1.Rows(n).Cells(m).Value = Math.Round(ovel(1, n), 3).ToString
    '                End Select
    '                'DataGridView1.Rows(n).Cells(m).Value = "test" + (i * j).ToString
    '            Next
    '        Next
    '        DataGridView1.Height = (DataGridView1.RowCount * 24 + DataGridView1.ColumnHeadersHeight) * 1.1

    '        DataGridView1.Width = 0
    '        For i = 0 To DataGridView1.ColumnCount - 1
    '            DataGridView1.Width = DataGridView1.Width + DataGridView1.Columns(i).Width
    '        Next
    '        DataGridView1.Width = DataGridView1.Width * 1.05
    '        '        Me.Width = DataGridView1.Width * 1.1
    '        Width = DataGridView1.Width + 5 * DataGridView1.Location.X
    '        Height = DataGridView1.Height * 1.1 + DataGridView1.Location.Y
    '        If Height < 325 Then Height = 325
    '        CenterToScreen()

    '        Dim tempsize As Double = CDbl(Txtfansize.Text)
    '        Dim tempspeed As Double = CDbl(Txtfanspeed.Text)
    '        Dim tempflow As Double = CDbl(Txtflow.Text)
    '        Dim tempfsp As Double = CDbl(Txtfsp.Text)


    '        For k = 0 To fantypesQTY
    '            '-----------------------------------------------------------------------------
    '            '----- FOR KNOWN DUTY BUT NO SPEED OR FAN SIZE GIVEN -------------------------
    '            '------------------------------------------------------------------------------

    '            'Dim size As Double = CDbl(Frmselectfan.Txtfansize.Text)
    '            If tempsize = 0 And tempspeed = 0 And tempflow <> 0 And tempfsp <> 0 Then
    '                Call NoSpeedNosize(k)
    '            End If

    '            '----------------------------------------------------------------------------------------
    '            '---------------start of selecting fan size based on a given speed and duty point--------
    '            '-----------------------------------------------------------------------------------------
    '            If tempspeed <> 0 And tempflow <> 0 And tempfsp <> 0 And tempsize = 0 Then
    '                Call WithSpeedNoSize(k)
    '            End If

    '            '----------------------------------------------------------------------------------------
    '            '-----------------------Start of listing duty of known fan size and speed
    '            '---------------------------------------------------------------------------------------------
    '            If tempsize <> 0 And tempspeed <> 0 And tempflow = 0 And tempfsp = 0 Then
    '                Call WithSpeedWithSize(k)
    '            End If

    '            '-----------------------------------------------------------------------------------------------
    '            '-----------------------------start of selecting fan with size and volume & pressure------------
    '            '-----------------------------------------------------------------------------------------------
    '            If tempsize <> 0 And tempflow <> 0 And tempfsp <> 0 And tempspeed = 0 Then
    '                Call WithSizeVolPressure(k)
    '            End If

    '            '-------------------------------------------------------------------------------------------------
    '            '-------------------------start of finding pressure for selected fan speed size and volume--------
    '            '-------------------------------------------------------------------------------------------------
    '            If tempsize <> 0 And tempflow <> 0 And tempspeed <> 0 Then
    '                Call WithSpeedSizeVolume(k)
    '            End If

    '            '--------------------------------------------------------------------------------------
    '            '-----------------------start of finding volume for given pressure and fan speed------
    '            '-------------------------------------------------------------------------------------
    '            If tempsize <> 0 And tempflow = 0 And tempfsp <> 0 And tempspeed <> 0 Then
    '                Call WithSpeedPressure(k)
    '            End If
    '            'If selectedfansize(k) > 0 Then
    '            'End If
    '            Call ResHDandVolTD(k)
    '        Next

    '        Call PopulateGrid()

    '    Catch ex As Exception
    '        MsgBox("Click")
    '    End Try
    'End Sub

    'Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click
    '    Dim i As Integer
    '    If TabControl1.SelectedTab.Text = "Selection" Then
    '        MsgBox("selections")
    '    End If
    'End Sub

    ' ############################################################################################
    ' Duty Page
    ' ############################################################################################

    Private Sub TabPageDuty_Enter(sender As Object, e As EventArgs) Handles TabPageDuty.Enter
        Initialize()
        TxtAtmosphericPressure.Text = atmos.ToString
        TxtDesignTemperature.Text = designtemp.ToString
        TxtMaximumTemperature.Text = maximumtemp.ToString
        TxtAmbientTemperature.Text = ambienttemp.ToString
        TxtAltitude.Text = altitude.ToString
        TxtHumidity.Text = humidity.ToString
        TxtAtmosphericPressure.Text = atmospress.ToString
        Txtdens.Text = knowndensity.ToString
        Txtflow.Text = flowrate.ToString
        TxtInletPressure.Text = inletpress.ToString
        TxtDischargePressure.Text = dischpress.ToString
        Txtfsp.Text = pressrise.ToString
        CmbReserveHead.Text = reshead.ToString + "%"
        Txtspeedlimit.Text = maxspeed.ToString
        Txtfansize.Text = fansize.ToString
        FlowType = 1
    End Sub

    Private Sub TabPageDuty_Leave(sender As Object, e As EventArgs) Handles TabPageDuty.Leave

    End Sub

    Private Sub OptDensityCalculated_CheckedChanged(sender As Object, e As EventArgs) Handles OptDensityCalculated.CheckedChanged
        Try
            If (OptDensityCalculated.Checked = True) Then
                RunTemp = Val(TxtDesignTemperature.Text)
                If Units(2).UnitSelected = 1 Then RunTemp = Math.Round(((RunTemp - 32) * 5 / 9), 1)
                Txtdens.Text = Math.Round((293 / (RunTemp + 273)) * 1.2, 3)
                Txtdens.ReadOnly = True
            Else
                Txtdens.ReadOnly = False
            End If

        Catch ex As Exception
            MsgBox("OptDensityCalculated_CheckedChanged")
        End Try
    End Sub

    ' ############################################################################################
    ' Selection Page
    ' ############################################################################################

    Private Sub TabPageSelection_Leave(sender As Object, e As EventArgs) Handles TabPageSelection.Leave
        If finalfantype = "" Then
            'e.Cancel = True
            MsgBox("No fan has been selected")
        Else
            'e.Cancel = False
            LblFanDetails.Text = ""
            Label3.Text = ""
        End If
    End Sub

    Private Sub TabPageSelection_Enter(sender As Object, e As EventArgs) Handles TabPageSelection.Enter
        Try
            If TabControl1.SelectedTab.Text.Contains("Selection") Then
                Call initializeSelections()
                ColumnHeader(0) = Units(6).UnitName(Units(5).UnitSelected) '"mm" 'Frmselectfan.Comimpunits.Text
                ColumnHeader(1) = " "
                ColumnHeader(2) = "RPM"
                ColumnHeader(3) = Units(0).UnitName(Units(0).UnitSelected) '"m³/hr" 'Frmselectfan.Comflowunits.Text
                ColumnHeader(4) = Units(1).UnitName(Units(1).UnitSelected) '"Pa" 'Frmselectfan.Comfspunits.Text
                ColumnHeader(5) = Units(1).UnitName(Units(1).UnitSelected) '"Pa" 'Frmselectfan.Comfspunits.Text
                ColumnHeader(6) = Units(4).UnitName(Units(4).UnitSelected) ' "kW" 'Frmselectfan.Compowunits.Text
                ColumnHeader(7) = Units(4).UnitName(Units(4).UnitSelected) ' "kW" 'Frmselectfan.Compowunits.Text
                ColumnHeader(8) = "%"
                ColumnHeader(9) = "%"
                ColumnHeader(10) = Units(7).UnitName(Units(7).UnitSelected) '"m/s"
                ColumnHeader(11) = "%"
                ColumnHeader(12) = "%"
                LblGasDensityUnit.Text = Units(3).UnitName(Units(3).UnitSelected) '"kg/m³" 'Frmselectfan.Comairdenunits.Text
                TxtDensity.Text = Txtdens.Text 'Round(originaldensity, 3)
                originaldensity = Val(Txtdens.Text)

                DataGridView1.GridColor = Color.Red
                DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single

                DataGridView1.BackgroundColor = Color.LightGray

                DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Cyan
                DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black

                DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]

                DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                DataGridView1.AllowUserToResizeColumns = False

                DataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque
                DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige

                Dim i As Integer

                DataGridView1.ColumnCount = 50
                i = 0

                Column_Header(i, "SIZE", "Colsize", ColumnHeader(0))
                i = i + 1
                Column_Header(i, "TYPE", "Coltype", "empty")
                i = i + 1
                Column_Header(i, "SPEED", "Colspeed", ColumnHeader(2))
                i = i + 1
                Column_Header(i, "VOLUME", "Colvolume", ColumnHeader(3))
                i = i + 1
                Column_Header(i, "FSP", "Colfsp", ColumnHeader(4))
                i = i + 1
                Column_Header(i, "FTP", "Colftp", ColumnHeader(5))
                i = i + 1
                Column_Header(i, "POWER", "Colpower", ColumnHeader(6))
                i = i + 1
                Column_Header(i, "MOTOR", "Colmotor", ColumnHeader(7))
                i = i + 1
                Column_Header(i, "FSE", "Colfse", ColumnHeader(8))
                i = i + 1
                Column_Header(i, "FTE", "Colfte", ColumnHeader(9))
                i = i + 1
                Column_Header(i, "OUTLET VELOCITY", "Coloutletvel", ColumnHeader(10))
                i = i + 1
                Column_Header(i, "RESERVE HEAD", "Colrhead", ColumnHeader(11))
                i = i + 1
                Column_Header(i, "VOL TD", "Colvoltd", ColumnHeader(12))

                DataGridView1.ColumnCount = i + 1
                DataGridView1.Width = DataGridView1.Width * 1.1

                Dim filenameref As String = "FILENAME REF DATA"
                If OptXLS.Checked = True Then ReadReffromExcelfile(filenameref)
                If OptTXT.Checked = True Then ReadReffromTextfile(filenameref)
                'Dim filename As String

                'FullFilePath = "C:\Halifax\Performance Data new\" + filename + ".txt"
                'Dim objStreamReader As New StreamReader(FullFilePath)

                'Dim j As Integer

                'Dim line As String
                ''count = 0
                'Dim TestArray() As String

                'Try
                '    For j = 0 To 100
                '        line = objStreamReader.ReadLine()
                '        TestArray = Split(line, ",")
                '        fantypename(j) = TestArray(0)
                '        fanclass(j) = TestArray(1)
                '        fantypefilename(j) = TestArray(2)
                '        fansizelimit(j) = CDbl(TestArray(3))
                '        fantypesecfilename(j) = TestArray(4)
                '        fanunits(j) = TestArray(5)
                '        fanwidthing(j) = CBool(TestArray(6))
                '    Next
                'Catch ex As Exception
                '    ' MsgBox(ex.ToString)
                'Finally
                '    objStreamReader.Close() 'Close 
                'End Try
                'fantypesQTY = j - 1

                Dim m, n As Integer
                DataGridView1.Width = 0

                DataGridView1.RowCount = fantypesQTY + 1
                For m = 0 To DataGridView1.RowCount - 1
                    DataGridView1.Rows(m).Height = 24
                Next
                Dim len As Integer
                Dim k As Integer
                For k = 0 To fantypesQTY
                    If fanclass(k) IsNot Nothing Then Call loadfandata(fantypefilename(k), k)
                Next
                For n = 0 To DataGridView1.RowCount - 1

                    For m = 0 To DataGridView1.ColumnCount - 1
                        If n = 0 Then DataGridView1.Width = DataGridView1.Width + DataGridView1.Columns(m).Width
                        Select Case m
                            Case 1
                                If fanclass(n) IsNot Nothing Then
                                    '                            DataGridView1.Rows(n).Cells(m).Value = fanclass(n)
                                    len = If(fanclass(n).Length < DataGridView1.Columns(m).Width / 8, DataGridView1.Columns(m).Width / 8, fanclass(n).Length)
                                    DataGridView1.Columns(m).Width = len * 8
                                    DataGridView1.Width = DataGridView1.Width + DataGridView1.Columns(m).Width
                                End If
                            Case 3
                                DataGridView1.Rows(n).Cells(m).Value = Math.Round(vol(1, n), voldecplaces).ToString
                            Case 4
                                DataGridView1.Rows(n).Cells(m).Value = Math.Round(fsp(1, n), pressplaceRise).ToString
                            Case 5
                                DataGridView1.Rows(n).Cells(m).Value = Math.Round(ftp(1, n), pressplaceRise).ToString
                            Case 6
                                DataGridView1.Rows(n).Cells(m).Value = Math.Round(Powr(1, n), 2).ToString
                            Case 8
                                DataGridView1.Rows(n).Cells(m).Value = Math.Round(fse(1, n), 3).ToString
                            Case 9
                                DataGridView1.Rows(n).Cells(m).Value = Math.Round(fte(1, n), 3).ToString
                            Case 10
                                DataGridView1.Rows(n).Cells(m).Value = Math.Round(ovel(1, n), 3).ToString
                        End Select
                        'DataGridView1.Rows(n).Cells(m).Value = "test" + (i * j).ToString
                    Next
                Next
                DataGridView1.Height = (DataGridView1.RowCount * 24 + DataGridView1.ColumnHeadersHeight) * 1.1

                DataGridView1.Width = 0
                For i = 0 To DataGridView1.ColumnCount - 1
                    DataGridView1.Width = DataGridView1.Width + DataGridView1.Columns(i).Width
                Next
                DataGridView1.Width = DataGridView1.Width * 1.05
                '        Me.Width = DataGridView1.Width * 1.1
                Width = DataGridView1.Width + 5 * DataGridView1.Location.X
                Height = DataGridView1.Height * 1.1 + DataGridView1.Location.Y
                If Height < 325 Then Height = 325
                CenterToScreen()

                Dim tempsize As Double = CDbl(Txtfansize.Text)
                Dim tempspeed As Double = CDbl(Txtfanspeed.Text)
                Dim tempflow As Double = CDbl(Txtflow.Text)
                Dim tempfsp As Double = CDbl(Txtfsp.Text)

                For k = 0 To fantypesQTY
                    '-----------------------------------------------------------------------------
                    '----- FOR KNOWN DUTY BUT NO SPEED OR FAN SIZE GIVEN -------------------------
                    '------------------------------------------------------------------------------

                    'Dim size As Double = CDbl(Frmselectfan.Txtfansize.Text)
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
                objStreamWriterDebug.WriteLine("Grid populated")
            End If

        Catch ex As Exception
            MsgBox("Click")
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
        End
    End Sub

    Sub initializeSelections()
        Try
            For i = 0 To 29
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
            Next
            fantypesQTY = 0

        Catch ex As Exception
            MsgBox("Initializeselections")
        End Try
    End Sub

    Sub Column_Header(ByVal i As Integer, ByVal headertext As String, ByVal headername As String, Optional ByVal column_value As String = "empty")
        Try
            Dim HeaderArray() As String
            Dim textlen As Integer
            Dim textlenunit As Integer
            Try
                headertext = Trim(headertext)
                If headertext.Contains(" ") Then
                    HeaderArray = Split(headertext, " ")
                    textlen = If(HeaderArray(0).Length > HeaderArray(1).Length, HeaderArray(0).Length, HeaderArray(1).Length)
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
            DataGridView1.Columns(i).HeaderText = headertext

            DataGridView1.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

            '        len = If(DataGridView1.Columns(i).HeaderText.Length < 8, 8, DataGridView1.Columns(i).HeaderText.Length)
            textlenunit = column_value.Length
            len = If(textlen < 8, 8, textlen)
            len = If(textlenunit < len, len, textlenunit)

            If (column_value IsNot "empty") Then
                DataGridView1.Columns(i).HeaderText = DataGridView1.Columns(i).HeaderText + vbNewLine + " (" + column_value + ")"
            Else
                DataGridView1.Columns(i).HeaderText = DataGridView1.Columns(i).HeaderText
            End If

            DataGridView1.Columns(i).Width = len * 8
            DataGridView1.Width = DataGridView1.Width + DataGridView1.Columns(i).Width

        Catch ex As Exception
            MsgBox("Column_header")
        End Try

    End Sub

    Sub PopulateGrid()
        Try
            Dim fansuccess As Integer = 0

            Dim lowest_power As Double = 99999.99
            Dim highlight As Integer = -1

            SetupGrid()

            'DataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque
            'DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige

            For k = 0 To fantypesQTY
                If selectedfansize(k) > 0 Then
                    DataGridView1.Rows(fansuccess).Cells(0).Value = selectedfansize(k).ToString
                    DataGridView1.Rows(fansuccess).Cells(1).Value = fanclass(k)
                    DataGridView1.Rows(fansuccess).Cells(2).Value = selectedspeed(k).ToString
                    DataGridView1.Rows(fansuccess).Cells(3).Value = selectedvol(k).ToString
                    DataGridView1.Rows(fansuccess).Cells(4).Value = selectedfsp(k).ToString
                    DataGridView1.Rows(fansuccess).Cells(5).Value = selectedftp(k).ToString
                    DataGridView1.Rows(fansuccess).Cells(6).Value = selectedpow(k).ToString
                    If selectedmot(k) > 0 Then
                        DataGridView1.Rows(fansuccess).Cells(7).Value = selectedmot(k).ToString
                    Else
                        DataGridView1.Rows(fansuccess).Cells(7).Value = "Non Std"
                    End If
                    DataGridView1.Rows(fansuccess).Cells(8).Value = selectedfse(k).ToString
                    DataGridView1.Rows(fansuccess).Cells(9).Value = selectedfte(k).ToString
                    DataGridView1.Rows(fansuccess).Cells(10).Value = selectedov(k).ToString
                    DataGridView1.Rows(fansuccess).Cells(11).Value = selectedresHD(k).ToString

                    If selectedVD(k) < 0 Then
                        DataGridView1.Rows(fansuccess).Cells(12).Value = "Stall"
                        DataGridView1.Rows(fansuccess).Cells(12).Style.BackColor = Color.Yellow
                        DataGridView1.Rows(fansuccess).Cells(12).Style.ForeColor = Color.Red
                    Else
                        DataGridView1.Rows(fansuccess).Cells(12).Value = selectedVD(k).ToString
                    End If

                    If selectedresHD(k) < 5 Then
                        DataGridView1.Rows(fansuccess).Cells(11).Style.BackColor = Color.Yellow
                        DataGridView1.Rows(fansuccess).Cells(11).Style.ForeColor = Color.Red
                    End If

                    If selectedpow(k) < lowest_power And selectedpow(k) > 0 Then
                        lowest_power = selectedpow(k)
                        highlight = fansuccess
                    End If
                    fansuccess = fansuccess + 1
                End If
            Next
            DataGridView1.RowCount = fansuccess
            DataGridView1.Height = (DataGridView1.RowCount * 24 + DataGridView1.ColumnHeadersHeight) * 1.1
            If DataGridView1.Height < 100 Then DataGridView1.Height = 100
            Height = DataGridView1.Height * 1.1 + DataGridView1.Location.Y
            If Height < 325 Then Height = 325

            If highlight >= 0 Then
                DataGridView1.Rows(highlight).Cells(6).Style.BackColor = Color.LightGreen
                DataGridView1.CurrentCell = DataGridView1.Rows(highlight).Cells(0)
            End If

        Catch ex As Exception
            MsgBox("PopulateGrid")
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        '        If e.ColumnIndex = 3 Then
        If (e.RowIndex < 0) Or (e.RowIndex < 0 And e.ColumnIndex < 0) Then
            'MsgBox("Invalid selection")
            Exit Sub
        End If
        '   MsgBox(DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString)
        'MsgBox(("Row : " + e.RowIndex.ToString & "  Col : ") + e.ColumnIndex.ToString)

        '  If e.RowIndex = 5 Then End
        '       End If
        Label3.Visible = True
        Label3.Text = "Selected Fan: "
        LblFanDetails.Visible = True

        Dim ii As Integer
        ii = 0
        Do While DataGridView1.Rows(e.RowIndex).Cells(1).Value <> selectedfantype(ii)
            ii = ii + 1
        Loop
        'LblFanDetails.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString + " " + DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString + " running at " + DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString + " rpm"
        LblFanDetails.Text = selectedfantype(ii) + " " + selectedfansize(ii).ToString + " running at " + selectedspeed(ii).ToString + " rpm"

        'finalfansize = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        'finalfantype = DataGridView1.Rows(e.RowIndex).Cells(1).Value 'string
        'finalfse = DataGridView1.Rows(e.RowIndex).Cells(8).Value
        'finalspeed = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        'finalpow = DataGridView1.Rows(e.RowIndex).Cells(6).Value
        'finalfsp = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        'finalfte = DataGridView1.Rows(e.RowIndex).Cells(9).Value
        'finalftp = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        'finalov = DataGridView1.Rows(e.RowIndex).Cells(10).Value
        'finalvol = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        'finalmot = DataGridView1.Rows(e.RowIndex).Cells(7).Value
        'finalresHD = DataGridView1.Rows(e.RowIndex).Cells(11).Value
        'finalVD = DataGridView1.Rows(e.RowIndex).Cells(12).Value

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

        TabPageNoise.Enabled = True
    End Sub

    Public Sub SetupGrid()
        Try
            'Dim DataGridView1 = New DataGridView()

            DataGridView1.GridColor = Color.Red
            DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single

            DataGridView1.BackgroundColor = Color.LightGray

            DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Cyan
            DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black

            DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]

            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView1.AllowUserToResizeColumns = False

            DataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque
            DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige

        Catch ex As Exception
            MsgBox("setupgrid")
        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If (e.RowIndex < 0) Or (e.RowIndex < 0 And e.ColumnIndex < 0) Then
            Exit Sub
        End If
        TabPageNoise.Enabled = True
        FrmFanChart.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
        FrmFanChart.Show()

    End Sub

    ' ############################################################################################
    ' Noise Page
    ' ############################################################################################

    Private Sub TabPageNoise_Enter(sender As Object, e As EventArgs) Handles TabPageNoise.Enter
        TxtFlownoise.Text = finalvol.ToString
        TxtPressurenoise.Text = finalfsp.ToString
        TxtSizenoise.Text = finalfansize.ToString
        TxtSpeednoise.Text = finalspeed.ToString
        TxtTypenoise.Text = finalfantype

        Dim txt = New TextBox()
        txt.Location = New Point(0, 0)
        txt.Text = "This is a test label"
        TableLayoutPanel1.Controls.Add(txt, 0, 0) '; //start it In cell 0,0
        TableLayoutPanel1.SetColumnSpan(txt, 9) '; //merge 3 columns
        'TableLayoutPanel1.SetColumnSpan(9)
    End Sub
End Class
