Imports System.IO
Imports System.Xml
Imports System.ComponentModel
Public Class Frmselectfan
    Public totalcolumnwidth As Integer
    Public ColumnHeader(20) As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.CenterToScreen()
            NewProject = True
            TabControl1.Controls.Remove(TabPageImpeller)
            Me.Text = "Halifax Fan Selection Software" + " - " + version_number
            If version_number = "V 1.0.0 Beta" Then
                TabControl1.Controls.Remove(TabPageNoise)
                TabControl1.Controls.Remove(TabPageSelection)
                'Button7.Visible = False
                'Button8.Visible = False
                'Button9.Visible = False
                'Button10.Visible = False
                'Button11.Visible = False
                Button12.Visible = False
            End If
            If AdvancedUser = False Then
                Button7.Visible = False
                OptDensityCalculated.Visible = False
                OptDensityKnown.Visible = False
            End If
            Initialize(True)
        Catch ex As Exception
            MsgBox("load")
        End Try
    End Sub

    Private Sub TabControl1_DrawItem(sender As System.Object, e As System.Windows.Forms.DrawItemEventArgs) Handles TabControl1.DrawItem

        'colours the tab controls

        Dim g As Graphics = e.Graphics
        Dim tp As TabPage = TabControl1.TabPages(e.Index)
        Dim br As Brush
        Dim sf As New StringFormat

        Dim r As New RectangleF(e.Bounds.X, e.Bounds.Y + 2, e.Bounds.Width, e.Bounds.Height - 2)

        sf.Alignment = StringAlignment.Center

        Dim strTitle As String = tp.Text

        If TabControl1.SelectedIndex = e.Index Then

            'this is the background color of the tabpage header
            br = New SolidBrush(Color.LightSteelBlue) ' chnge to your choice
            g.FillRectangle(br, e.Bounds)

            'this is the foreground color of the text in the tab header
            br = New SolidBrush(Color.Black) ' change to your choice
            g.DrawString(strTitle, TabControl1.Font, br, r, sf)

        Else

            'these are the colors for the unselected tab pages 
            'br = New SolidBrush(Color.DarkSlateBlue) ' Change this to your preference
            br = New SolidBrush(Color.Transparent) ' Change this to your preference
            g.FillRectangle(br, e.Bounds)
            'br = New SolidBrush(Color.White)
            br = New SolidBrush(Color.Black)
            g.DrawString(strTitle, TabControl1.Font, br, r, sf)

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Try
        '    If FileSaved = False Then
        '        If MsgBox("Project not saved - do you wish to save your project now?", vbYesNo, "Warning") = vbNo Then
        '            End
        '        Else
        '            SaveToFile()
        '            End
        '        End If
        '    End If
        'Catch ex As Exception
        '    MsgBox("Button2_click")
        'End Try
        End
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

        Catch ex As Exception
            MsgBox("UnitsToolStripMenuItem_Click_1")
        End Try
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Try
            NewProject = True
            Initialize(True)

        Catch ex As Exception
            MsgBox("OpenToolStripMenuItem_Click")
        End Try
    End Sub

    Private Sub SaveProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveProjectToolStripMenuItem.Click
        SaveToFile()

    End Sub

    Private Sub OpenProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenProjectToolStripMenuItem.Click
        'Try
        ReadFromProjectFile = False
        Dim OpenFileDialog1 As OpenFileDialog = New OpenFileDialog()
        OpenFileDialog1.InitialDirectory = "c:\Halifax\Projects\"
        OpenFileDialog1.Filter = "Halifax files (*.hfs)|*.hfs|All files (*.*)|*.*"
        OpenFileDialog1.ShowDialog()
        OpenFileName = OpenFileDialog1.FileName
        If OpenFileName = "" Then Exit Sub

        Dim textReader As XmlTextReader = New XmlTextReader(OpenFileName)
        textReader.MoveToFirstAttribute()

        'While (document.Read())

        '    Dim type = document.NodeType

        '    'if node type was element
        '    If (type = XmlNodeType.Element) Then

        '        'if the loop found a <FirstName> tag
        '        If (document.Name = "FirstName") Then

        '            TextBox1.Text = document.ReadInnerXml.ToString()

        '        End If

        '        'if the loop found a <LastName tag
        '        If (document.Name = "LastName") Then

        '            TextBox2.Text = document.ReadInnerXml.ToString()

        '        End If

        '    End If

        'End While





        While (textReader.Read())
            Dim type = textReader.NodeType
            'ReadGeneralInfo(textReader)
            'ReadSelectionInputInfo(textReader)
            'MsgBox("textReader.NameOf = ", textReader.Name)
            If (type = XmlNodeType.Element) Then
                If textReader.Name = "Customer" Then Customer = textReader.ReadString
                If textReader.Name = "Engineer" Then Engineer = textReader.ReadString
                If textReader.Name = "Flow_Units" Then Units(0).UnitSelected = textReader.ReadString
                If textReader.Name = "Pressure_Units" Then Units(1).UnitSelected = textReader.ReadString
                If textReader.Name = "Temperature_Units" Then Units(2).UnitSelected = textReader.ReadString
                If textReader.Name = "Density_Units" Then Units(3).UnitSelected = textReader.ReadString
                If textReader.Name = "Power_Units" Then Units(4).UnitSelected = textReader.ReadString
                If textReader.Name = "Size_Units" Then Units(5).UnitSelected = textReader.ReadString
                If textReader.Name = "Altitude_Units" Then Units(6).UnitSelected = textReader.ReadString
                If textReader.Name = "Design_Temperature" Then designtemp = textReader.ReadString
                If textReader.Name = "Maximum_Temperature" Then maximumtemp = textReader.ReadString
                If textReader.Name = "Ambient_Temperature" Then ambienttemp = textReader.ReadString
                If textReader.Name = "Altitude" Then altitude = textReader.ReadString
                If textReader.Name = "Relative_Humidity" Then humidity = textReader.ReadString
                If textReader.Name = "Atmospheric_Pressure" Then atmospress = textReader.ReadString
                If textReader.Name = "Known_Density" Then knowndensity = textReader.ReadString
                If textReader.Name = "Flow_Rate" Then flowrate = textReader.ReadString
                If textReader.Name = "Inlet_Pressure" Then inletpress = textReader.ReadString
                If textReader.Name = "Discharge_Pressure" Then dischpress = textReader.ReadString
                If textReader.Name = "Pressure_Rise" Then pressrise = textReader.ReadString
                If textReader.Name = "Reserve_Head" Then reshead = textReader.ReadString
                If textReader.Name = "Maximum_Speed" Then maxspeed = textReader.ReadString
            End If

        End While
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
        ReadFromProjectFile = True

        'Catch ex As Exception
        '    'MsgBox("OpenProjectToolStripMenuItem_Click")
        '    'Resume
        'End Try


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

    ' ############################################################################################
    ' Duty Page
    ' ############################################################################################

    Private Sub TabPageDuty_Enter(sender As Object, e As EventArgs) Handles TabPageDuty.Enter
        'TabPageDuty.BackColor = Background_Color
        If ReadFromProjectFile = False Then Initialize(False)
        TxtAtmosphericPressure.Text = atmos.ToString
        TxtDesignTemperature.Text = designtemp.ToString
        TxtMaximumTemperature.Text = maximumtemp.ToString
        TxtAmbientTemperature.Text = ambienttemp.ToString
        'TxtAltitude.Text = altitude.ToString
        'TxtHumidity.Text = humidity.ToString
        TxtAtmosphericPressure.Text = atmospress.ToString
        Txtdens.Text = knowndensity.ToString
        Txtflow.Text = flowrate.ToString
        TxtInletPressure.Text = inletpress.ToString
        TxtDischargePressure.Text = dischpress.ToString
        Txtfsp.Text = pressrise.ToString
        CmbReserveHead.Text = reshead.ToString + "%"
        If freqHz = 50 Then maxspeed = 3000
        'If freqHz = 50 And OptPoleSpeed.Checked = True Then
        '    If Opt2Pole.Checked = True Then maxspeed = 3000
        '    If Opt4Pole.Checked = True Then maxspeed = 1500
        '    If Opt6Pole.Checked = True Then maxspeed = 1000
        '    If Opt8Pole.Checked = True Then maxspeed = 750
        '    If Opt10Pole.Checked = True Then maxspeed = 600
        '    If Opt12Pole.Checked = True Then maxspeed = 500
        'End If
        If freqHz = 60 Then maxspeed = 3600
        'If freqHz = 60 And OptPoleSpeed.Checked = True Then
        '    If Opt2Pole.Checked = True Then maxspeed = 3600
        '    If Opt4Pole.Checked = True Then maxspeed = 1800
        '    If Opt6Pole.Checked = True Then maxspeed = 1200
        '    If Opt8Pole.Checked = True Then maxspeed = 900
        '    If Opt10Pole.Checked = True Then maxspeed = 720
        '    If Opt12Pole.Checked = True Then maxspeed = 600
        'End If

        Txtspeedlimit.Text = maxspeed.ToString
        Txtfansize.Text = fansize.ToString
        Button8.Focus()
        'Me.AcceptButton = Button9
        'FlowType = 1
    End Sub

    Private Sub TabPageDuty_Leave(sender As Object, e As EventArgs) Handles TabPageDuty.Leave
        Dim str_temp As String = CmbReserveHead.Items(CmbReserveHead.SelectedIndex)

        reshead = CDbl(str_temp.Remove(str_temp.Length - 1))
    End Sub

    Private Sub OptDensityCalculated_CheckedChanged(sender As Object, e As EventArgs) Handles OptDensityCalculated.CheckedChanged
        Try
            If (OptDensityCalculated.Checked = True) Then
                RunTemp = Val(TxtDesignTemperature.Text)
                If Units(2).UnitSelected = 1 Then RunTemp = Math.Round(((RunTemp - 32) * 5 / 9), 1)
                Txtdens.Text = Math.Round((293 / (RunTemp + 273)) * 1.2, 3)
                Txtdens.ReadOnly = True
                Button7.Enabled = True
            Else
                Txtdens.ReadOnly = False
                Button7.Enabled = False
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
            'MsgBox("No fan has been selected 2")
        Else
            'e.Cancel = False
            LblFanDetails.Text = ""
            Label3.Text = ""
        End If
    End Sub

    Private Sub TabPageSelection_Enter(sender As Object, e As EventArgs) Handles TabPageSelection.Enter
        SetupSelectionPage()
        CenterToScreen()

        ''TabPageSelection.BackColor = Background_Color
        ''If OptPoleSpeed.Checked = True And Opt2Pole.Checked = False And
        ''    Opt4Pole.Checked = False And Opt6Pole.Checked = False And
        ''    Opt8Pole.Checked = False And Opt10Pole.Checked = False And Opt12Pole.Checked = False Then
        ''    MsgBox("Please select a pole speed before continuing")
        ''    TabPageDuty.Select()
        ''    Exit Sub
        ''End If

        'Try
        '    If TabControl1.SelectedTab.Text.Contains("Selection") Then
        '        Call initializeSelections()
        '        ColumnHeader(0) = Units(5).UnitName(Units(5).UnitSelected) '"mm" 'Frmselectfan.Comimpunits.Text
        '        ColumnHeader(1) = " "
        '        ColumnHeader(2) = "RPM"
        '        ColumnHeader(3) = Units(0).UnitName(Units(0).UnitSelected) '"m³/hr" 'Frmselectfan.Comflowunits.Text
        '        ColumnHeader(4) = Units(1).UnitName(Units(1).UnitSelected) '"Pa" 'Frmselectfan.Comfspunits.Text
        '        ColumnHeader(5) = Units(1).UnitName(Units(1).UnitSelected) '"Pa" 'Frmselectfan.Comfspunits.Text
        '        If Units(4).UnitSelected < 2 Then
        '            ColumnHeader(6) = Units(4).UnitName(Units(4).UnitSelected) ' "kW" 'Frmselectfan.Compowunits.Text
        '            ColumnHeader(7) = Units(4).UnitName(Units(4).UnitSelected) ' "kW" 'Frmselectfan.Compowunits.Text
        '            ColumnHeader(8) = "%"
        '            ColumnHeader(9) = "%"
        '            ColumnHeader(10) = Units(7).UnitName(Units(7).UnitSelected) '"m/s"
        '            ColumnHeader(11) = "%"
        '            ColumnHeader(12) = "%"
        '        ElseIf Units(4).UnitSelected = 2 Then
        '            'separate columns
        '            'ColumnHeader(6) = Units(4).UnitName(0) ' "kW" 'Frmselectfan.Compowunits.Text
        '            'ColumnHeader(7) = Units(4).UnitName(0) ' "hp" 'Frmselectfan.Compowunits.Text
        '            'ColumnHeader(8) = Units(4).UnitName(1) ' "kW" 'Frmselectfan.Compowunits.Text
        '            'ColumnHeader(9) = Units(4).UnitName(1) ' "hp" 'Frmselectfan.Compowunits.Text
        '            'ColumnHeader(10) = "%"
        '            'ColumnHeader(11) = "%"
        '            'ColumnHeader(12) = Units(7).UnitName(Units(7).UnitSelected) '"m/s"
        '            'ColumnHeader(13) = "%"
        '            'ColumnHeader(14) = "%"
        '            'combined columns
        '            ColumnHeader(6) = Units(4).UnitName(0) + " / " + Units(4).UnitName(1) ' "kW" 'Frmselectfan.Compowunits.Text
        '            ColumnHeader(7) = Units(4).UnitName(0) + " / " + Units(4).UnitName(1) ' "kW" 'Frmselectfan.Compowunits.Text
        '            ColumnHeader(8) = "%"
        '            ColumnHeader(9) = "%"
        '            ColumnHeader(10) = Units(7).UnitName(Units(7).UnitSelected) '"m/s"
        '            ColumnHeader(11) = "%"
        '            ColumnHeader(12) = "%"
        '        End If
        '        LblGasDensityUnit.Text = Units(3).UnitName(Units(3).UnitSelected) '"kg/m³" 'Frmselectfan.Comairdenunits.Text
        '        TxtDensity.Text = Txtdens.Text 'Round(originaldensity, 3)
        '        originaldensity = Val(Txtdens.Text)

        '        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 9, FontStyle.Bold)
        '        DataGridView1.DefaultCellStyle.Font = New Font("Tahoma", 9)

        '        DataGridView1.GridColor = Color.Red
        '        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single

        '        DataGridView1.BackgroundColor = Color.LightGray

        '        DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Cyan
        '        DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black

        '        DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]

        '        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        '        DataGridView1.AllowUserToResizeColumns = False

        '        DataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque
        '        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige

        '        'If Units(4).UnitSelected = 2 Then DataGridView1.ScrollBars = ScrollBars.Horizontal

        '        Dim i As Integer
        '        DataGridView1.RowCount = 10
        '        DataGridView1.ColumnCount = 50
        '        i = 0

        '        Column_Header(i, "SIZE", "Colsize", ColumnHeader(0))
        '        Column_Header(i, "Size", "Colsize", "empty")
        '        i = i + 1
        '        Column_Header(i, "Type", "Coltype", "empty")
        '        i = i + 1
        '        Column_Header(i, "Speed", "Colspeed", ColumnHeader(2))
        '        i = i + 1
        '        Column_Header(i, "Flow", "Colvolume", ColumnHeader(3))
        '        i = i + 1
        '        Column_Header(i, "Fan Static Pressure", "Colfsp", ColumnHeader(4))
        '        i = i + 1
        '        Column_Header(i, "Fan Total Pressure", "Colftp", ColumnHeader(5))
        '        i = i + 1
        '        If Units(4).UnitSelected < 2 Then
        '            Column_Header(i, "Fan Power", "Colpower", ColumnHeader(6))
        '            i = i + 1
        '            Column_Header(i, "Motor Power", "Colmotor", ColumnHeader(7))
        '            i = i + 1
        '            Column_Header(i, "Fan Static Efficiency", "Colfse", ColumnHeader(8))
        '            i = i + 1
        '            Column_Header(i, "Fan Total Efficiency", "Colfte", ColumnHeader(9))
        '            i = i + 1
        '            Column_Header(i, "Outlet Velocity", "Coloutletvel", ColumnHeader(10))
        '            i = i + 1
        '            Column_Header(i, "Reserve Head", "Colrhead", ColumnHeader(11))
        '            i = i + 1
        '            Column_Header(i, "Volume TD", "Colvoltd", ColumnHeader(12))
        '        ElseIf Units(4).UnitSelected = 2 Then
        '            'separate columns
        '            'Column_Header(i, "Fan Power", "Colpower", ColumnHeader(6))
        '            'i = i + 1
        '            'Column_Header(i, "Motor Power", "Colmotor", ColumnHeader(7))
        '            'i = i + 1
        '            'Column_Header(i, "Fan Power", "Colpower", ColumnHeader(8))
        '            'i = i + 1
        '            'Column_Header(i, "Motor Power", "Colmotor", ColumnHeader(9))
        '            'i = i + 1
        '            'Column_Header(i, "Fan Static Efficiency", "Colfse", ColumnHeader(10))
        '            'i = i + 1
        '            'Column_Header(i, "Fan Total Efficiency", "Colfte", ColumnHeader(11))
        '            'i = i + 1
        '            'Column_Header(i, "Outlet Velocity", "Coloutletvel", ColumnHeader(12))
        '            'i = i + 1
        '            'Column_Header(i, "Reserve Head", "Colrhead", ColumnHeader(13))
        '            'i = i + 1
        '            'Column_Header(i, "Volume TD", "Colvoltd", ColumnHeader(14))
        '            'combined columns
        '            Column_Header(i, "Fan Power", "Colpower", ColumnHeader(6))
        '            i = i + 1
        '            Column_Header(i, "Motor Power", "Colmotor", ColumnHeader(7))
        '            i = i + 1
        '            Column_Header(i, "Fan Static Efficiency", "Colfse", ColumnHeader(8))
        '            i = i + 1
        '            Column_Header(i, "Fan Total Efficiency", "Colfte", ColumnHeader(9))
        '            i = i + 1
        '            Column_Header(i, "Outlet Velocity", "Coloutletvel", ColumnHeader(10))
        '            i = i + 1
        '            Column_Header(i, "Reserve Head", "Colrhead", ColumnHeader(11))
        '            i = i + 1
        '            Column_Header(i, "Volume TD", "Colvoltd", ColumnHeader(12))
        '        End If
        '        DataGridView1.ColumnCount = i + 1
        '        DataGridView1.Width = DataGridView1.Width * 1.1
        '        'DataGridView1.ColumnHeadersHeight = DataGridView1.ColumnHeadersHeight * 1.1


        '        Dim filenameref As String = "FILENAME REF DATA"
        '        ReadReffromBinaryfile(filenameref)

        '        Dim m, n As Integer
        '        DataGridView1.Width = 0

        '        DataGridView1.RowCount = fantypesQTY + 1
        '        For m = 0 To DataGridView1.RowCount - 1
        '            DataGridView1.Rows(m).Height = 24
        '        Next
        '        Dim len As Integer
        '        Dim fanint As Integer = 0
        '        Dim k As Integer
        '        For k = 0 To fantypesQTY - 1
        '            Dim FullFilePathtxt As String
        '            'FullFilePathtxt = "C:\Halifax" + fantypefilename(k)
        '            FullFilePathtxt = DataPath + fantypefilename(k)
        '            If Not File.Exists(FullFilePathtxt) Then
        '                fanclass(k) = Nothing
        '            End If
        '            If fanclass(k) IsNot Nothing Then
        '                Call LoadFanData(fantypefilename(k), fanint)
        '                fanint = fanint + 1
        '            End If
        '        Next


        '        If Units(4).UnitSelected < 2 Then
        '            For n = 0 To DataGridView1.RowCount - 1
        '                For m = 0 To DataGridView1.ColumnCount - 1
        '                    If n = 0 Then DataGridView1.Width = DataGridView1.Width + DataGridView1.Columns(m).Width
        '                    Select Case m
        '                        Case 1
        '                            If fanclass(n) IsNot Nothing Then
        '                                '                            DataGridView1.Rows(n).Cells(m).Value = fanclass(n)
        '                                len = If(fanclass(n).Length < DataGridView1.Columns(m).Width / 8, DataGridView1.Columns(m).Width / 8, fanclass(n).Length)
        '                                DataGridView1.Columns(m).Width = len * 8
        '                                DataGridView1.Width = DataGridView1.Width + DataGridView1.Columns(m).Width
        '                            Else
        '                                DataGridView1.Rows(n).Cells(m).Value = "empty"
        '                            End If
        '                        Case 3
        '                            DataGridView1.Rows(n).Cells(m).Value = Math.Round(vol(1, n), voldecplaces).ToString
        '                        Case 4
        '                            DataGridView1.Rows(n).Cells(m).Value = Math.Round(fsp(1, n), pressplaceRise).ToString
        '                        Case 5
        '                            DataGridView1.Rows(n).Cells(m).Value = Math.Round(ftp(1, n), pressplaceRise).ToString
        '                        Case 6
        '                            DataGridView1.Rows(n).Cells(m).Value = Math.Round(Powr(1, n), 2).ToString
        '                        Case 8
        '                            DataGridView1.Rows(n).Cells(m).Value = Math.Round(fse(1, n), 3).ToString
        '                        Case 9
        '                            DataGridView1.Rows(n).Cells(m).Value = Math.Round(fte(1, n), 3).ToString
        '                        Case 10
        '                            DataGridView1.Rows(n).Cells(m).Value = Math.Round(ovel(1, n), 3).ToString
        '                    End Select
        '                    'DataGridView1.Rows(n).Cells(m).Value = "test" + (i * j).ToString
        '                Next
        '            Next
        '        ElseIf Units(4).UnitSelected = 2 Then
        '            'For n = 0 To DataGridView1.RowCount - 1
        '            '    For m = 0 To DataGridView1.ColumnCount - 1
        '            '        If n = 0 Then DataGridView1.Width = DataGridView1.Width + DataGridView1.Columns(m).Width
        '            '        Select Case m
        '            '            Case 1
        '            '                If fanclass(n) IsNot Nothing Then
        '            '                    '                            DataGridView1.Rows(n).Cells(m).Value = fanclass(n)
        '            '                    len = If(fanclass(n).Length < DataGridView1.Columns(m).Width / 8, DataGridView1.Columns(m).Width / 8, fanclass(n).Length)
        '            '                    DataGridView1.Columns(m).Width = len * 8
        '            '                    DataGridView1.Width = DataGridView1.Width + DataGridView1.Columns(m).Width
        '            '                Else
        '            '                    DataGridView1.Rows(n).Cells(m).Value = "empty"
        '            '                End If
        '            '            Case 3
        '            '                DataGridView1.Rows(n).Cells(m).Value = Math.Round(vol(1, n), voldecplaces).ToString
        '            '            Case 4
        '            '                DataGridView1.Rows(n).Cells(m).Value = Math.Round(fsp(1, n), pressplaceRise).ToString
        '            '            Case 5
        '            '                DataGridView1.Rows(n).Cells(m).Value = Math.Round(ftp(1, n), pressplaceRise).ToString
        '            '            Case 6
        '            '                DataGridView1.Rows(n).Cells(m).Value = Math.Round(Powr(1, n), 2).ToString
        '            '            Case 8
        '            '                DataGridView1.Rows(n).Cells(m).Value = Math.Round(Powr(1, n) / 0.746, 2).ToString
        '            '            Case 10
        '            '                DataGridView1.Rows(n).Cells(m).Value = Math.Round(fse(1, n), 3).ToString
        '            '            Case 11
        '            '                DataGridView1.Rows(n).Cells(m).Value = Math.Round(fte(1, n), 3).ToString
        '            '            Case 12
        '            '                DataGridView1.Rows(n).Cells(m).Value = Math.Round(ovel(1, n), 3).ToString
        '            '        End Select
        '            '        'DataGridView1.Rows(n).Cells(m).Value = "test" + (i * j).ToString
        '            '    Next
        '            'Next
        '            For n = 0 To DataGridView1.RowCount - 1
        '                For m = 0 To DataGridView1.ColumnCount - 1
        '                    If n = 0 Then DataGridView1.Width = DataGridView1.Width + DataGridView1.Columns(m).Width
        '                    Select Case m
        '                        Case 1
        '                            If fanclass(n) IsNot Nothing Then
        '                                '                            DataGridView1.Rows(n).Cells(m).Value = fanclass(n)
        '                                len = If(fanclass(n).Length < DataGridView1.Columns(m).Width / 8, DataGridView1.Columns(m).Width / 8, fanclass(n).Length)
        '                                DataGridView1.Columns(m).Width = len * 8
        '                                DataGridView1.Width = DataGridView1.Width + DataGridView1.Columns(m).Width
        '                            Else
        '                                DataGridView1.Rows(n).Cells(m).Value = "empty"
        '                            End If
        '                        Case 3
        '                            DataGridView1.Rows(n).Cells(m).Value = Math.Round(vol(1, n), voldecplaces).ToString
        '                        Case 4
        '                            DataGridView1.Rows(n).Cells(m).Value = Math.Round(fsp(1, n), pressplaceRise).ToString
        '                        Case 5
        '                            DataGridView1.Rows(n).Cells(m).Value = Math.Round(ftp(1, n), pressplaceRise).ToString
        '                        Case 6
        '                            DataGridView1.Rows(n).Cells(m).Value = Math.Round(Powr(1, n), 2).ToString + " / " + Math.Round(Powr(1, n) / 0.746, 2).ToString
        '                            'If Units(4).UnitSelected = 2 Then
        '                            '    DataGridView1.Columns(m).Width = DataGridView1.Columns(m).Width * 2
        '                            'End If

        '                        Case 8
        '                            DataGridView1.Rows(n).Cells(m).Value = Math.Round(fse(1, n), 3).ToString
        '                        Case 9
        '                            DataGridView1.Rows(n).Cells(m).Value = Math.Round(fte(1, n), 3).ToString
        '                        Case 10
        '                            DataGridView1.Rows(n).Cells(m).Value = Math.Round(ovel(1, n), 3).ToString
        '                    End Select
        '                    'DataGridView1.Rows(n).Cells(m).Value = "test" + (i * j).ToString
        '                Next
        '            Next

        '        End If



        '        'If DataGridView1.RowCount > 10 Then
        '        '    DataGridView1.Height = (240 + DataGridView1.ColumnHeadersHeight) * 1.1
        '        '    DataGridView1.ScrollBars = ScrollBars.Vertical
        '        'Else
        '        DataGridView1.Height = (DataGridView1.RowCount * 24 + DataGridView1.ColumnHeadersHeight) * 1.1
        '        DataGridView1.ColumnHeadersHeight = 400
        '        'End If

        '        DataGridView1.Width = 0
        '        DataGridView1.Columns(0).Width = DataGridView1.Columns(0).Width * 0.8
        '        If Units(4).UnitSelected = 2 Then
        '            DataGridView1.Columns(6).Width = DataGridView1.Columns(6).Width * 1.5
        '        End If
        '        For i = 0 To DataGridView1.ColumnCount - 1
        '            DataGridView1.Width = DataGridView1.Width + DataGridView1.Columns(i).Width
        '        Next
        '        DataGridView1.Width = DataGridView1.Width * 1.03
        '        '        Me.Width = DataGridView1.Width * 1.1
        '        Width = DataGridView1.Width + 5 * DataGridView1.Location.X
        '        DataGridView1.Height = DataGridView1.Height * 1.1 + DataGridView1.Location.Y
        '        If DataGridView1.Height < 350 Then DataGridView1.Height = 350
        '        CenterToScreen()

        '        chkDisplayAll.Visible = AdvancedUser
        '        chkDisplayAll.Text = "Include fans <=" + reshead.ToString + "% Reserve Head"
        '        chkDisplayLowerEff.Visible = AdvancedUser
        '        chkDisplayLowerEff.Text = "Include fans < 60% Fan Efficiency"
        '        'chkDisplayLowerEff.Right.Equals(chkDisplayAll.Right)
        '        Dim nRight As Integer
        '        nRight = chkDisplayAll.Right
        '        chkDisplayLowerEff.Right.Equals(nRight)

        '        Dim tempsize As Double = CDbl(Txtfansize.Text)
        '        Dim tempspeed As Double = CDbl(Txtfanspeed.Text)
        '        Dim tempflow As Double = CDbl(Txtflow.Text)
        '        Dim tempfsp As Double = CDbl(Txtfsp.Text)

        '        For k = 0 To fantypesQTY - 1 'akm200118
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
        '        objStreamWriterDebug.WriteLine("Grid populated")
        '    End If

        'Catch ex As Exception
        '    MsgBox("Click")
        'End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
        End
    End Sub

    'Sub initializeSelections()
    '    Try
    '        For i = 0 To 49
    '            selectedfansize(i) = 0.0
    '            selectedfantype(i) = ""
    '            selectedfse(i) = 0.0
    '            selectedspeed(i) = 0.0
    '            selectedpow(i) = 0.0
    '            selectedfsp(i) = 0.0
    '            selectedfte(i) = 0.0
    '            selectedftp(i) = 0.0
    '            selectedov(i) = 0.0
    '            selectedvol(i) = 0.0
    '            selectedmot(i) = 0.0
    '            selectedresHD(i) = 0.0
    '            selectedVD(i) = 0.0
    '            selectedBladeType(i) = ""
    '            selectedBladeNumber(i) = 0
    '            selectedfanfile(i) = ""
    '        Next
    '        fantypesQTY = 0

    '    Catch ex As Exception
    '        MsgBox("Initializeselections")
    '    End Try
    'End Sub

    'Sub Column_Header(ByVal i As Integer, ByVal headertext As String, ByVal headername As String, Optional ByVal column_value As String = "empty")
    '    Try
    '        Dim HeaderArray() As String
    '        'Dim textlen1(10) As Integer
    '        Dim textlen As Integer
    '        Dim textlenunit As Integer
    '        Dim count As Integer
    '        Try
    '            If (column_value IsNot "empty") Then
    '                headertext = headertext + " (" + column_value + ")"
    '            End If

    '            headertext = Trim(headertext)
    '            textlen = 0
    '            If headertext.Contains(" ") Then
    '                HeaderArray = Split(headertext, " ")
    '                For count = 0 To HeaderArray.Length - 1
    '                    'textlen = If(HeaderArray(0).Length > HeaderArray(1).Length, HeaderArray(0).Length, HeaderArray(1).Length)
    '                    'textlen1(count) = HeaderArray(count).Length
    '                    If HeaderArray(count).Length > textlen Then
    '                        textlen = HeaderArray(count).Length
    '                    End If
    '                Next
    '            Else
    '                textlen = headertext.Length
    '            End If
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '        'Dim HeaderArray = Split(headertext, " ")
    '        'Dim textlen = If(HeaderArray(0).Length > HeaderArray(1).Length, HeaderArray(0).Length, HeaderArray(1).Length)
    '        Dim len As Integer
    '        'Dim len2 As Integer
    '        DataGridView1.Columns(i).HeaderText = headertext

    '        '        len = If(DataGridView1.Columns(i).HeaderText.Length < 8, 8, DataGridView1.Columns(i).HeaderText.Length)
    '        textlenunit = column_value.Length
    '        len = If(textlen < 8, 8, textlen)
    '        len = If(textlenunit < len, len, textlenunit)

    '        'If (column_value IsNot "empty") Then
    '        '    'DataGridView1.Columns(i).HeaderText = DataGridView1.Columns(i).HeaderText + vbCr + " (" + column_value + ")"
    '        '    'DataGridView1.Columns(i).HeaderText = DataGridView1.Columns(i).HeaderText + " (" + column_value + ")"
    '        '    DataGridView1.Columns(i).HeaderText = headertext + " (" + column_value + ")"
    '        'Else
    '        '    'DataGridView1.Columns(i).HeaderText = DataGridView1.Columns(i).HeaderText
    '        '    DataGridView1.Columns(i).HeaderText = headertext
    '        'End If

    '        DataGridView1.Columns(i).Width = len * 8
    '        DataGridView1.Width = DataGridView1.Width + DataGridView1.Columns(i).Width

    '        'DataGridView1.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
    '        DataGridView1.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

    '    Catch ex As Exception
    '        MsgBox("Column_header")
    '    End Try

    'End Sub

    'Sub PopulateGrid()
    '    Try
    '        Dim fansuccess As Integer = 0

    '        Dim lowest_power As Double = 99999.99
    '        Dim highlight As Integer = -1

    '        SetupGrid()

    '        'DataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque
    '        'DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige

    '        Dim minresHD As Double
    '        minresHD = reshead
    '        Dim minefft As Double
    '        Dim mineffs As Double

    '        mineffs = 60.0
    '        minefft = 60.0
    '        If AdvancedUser And chkDisplayAll.Checked = True Then minresHD = 0.0
    '        If AdvancedUser And chkDisplayLowerEff.Checked = True Then mineffs = 0.0
    '        If AdvancedUser And chkDisplayLowerEff.Checked = True Then minefft = 0.0


    '        For k = 0 To fantypesQTY - 1 'akm 201018
    '            'If selectedfansize(k) > 0 And selectedresHD(k) >= minresHD And fanclass(k) IsNot Nothing Then
    '            If selectedfansize(k) > 0 And selectedresHD(k) >= minresHD And selectedfse(k) > mineffs And selectedfte(k) > minefft And fanclass(k) IsNot Nothing Then
    '                DataGridView1.Rows(fansuccess).Cells(0).Value = selectedfansize(k).ToString
    '                DataGridView1.Rows(fansuccess).Cells(1).Value = fanclass(k)
    '                DataGridView1.Rows(fansuccess).Cells(2).Value = selectedspeed(k).ToString
    '                DataGridView1.Rows(fansuccess).Cells(3).Value = selectedvol(k).ToString
    '                DataGridView1.Rows(fansuccess).Cells(4).Value = selectedfsp(k).ToString
    '                DataGridView1.Rows(fansuccess).Cells(5).Value = selectedftp(k).ToString
    '                DataGridView1.Rows(fansuccess).Cells(6).Style.BackColor = DataGridView1.Rows(fansuccess).Cells(0).Style.BackColor
    '                If Units(4).UnitSelected < 2 Then
    '                    DataGridView1.Rows(fansuccess).Cells(6).Value = selectedpow(k).ToString
    '                    If selectedmot(k) > 0 Then
    '                        DataGridView1.Rows(fansuccess).Cells(7).Value = selectedmot(k).ToString
    '                    Else
    '                        DataGridView1.Rows(fansuccess).Cells(7).Value = "Non Std"
    '                    End If
    '                    DataGridView1.Rows(fansuccess).Cells(8).Value = selectedfse(k).ToString
    '                    DataGridView1.Rows(fansuccess).Cells(9).Value = selectedfte(k).ToString
    '                    DataGridView1.Rows(fansuccess).Cells(10).Value = selectedov(k).ToString
    '                    DataGridView1.Rows(fansuccess).Cells(11).Value = selectedresHD(k).ToString

    '                    If selectedVD(k) < 0 Then
    '                        DataGridView1.Rows(fansuccess).Cells(12).Value = "Stall"
    '                        DataGridView1.Rows(fansuccess).Cells(12).Style.BackColor = Color.White
    '                        DataGridView1.Rows(fansuccess).Cells(12).Style.ForeColor = Color.Red
    '                    Else
    '                        DataGridView1.Rows(fansuccess).Cells(12).Value = selectedVD(k).ToString
    '                        DataGridView1.Rows(fansuccess).Cells(12).Style.BackColor = DataGridView1.Rows(fansuccess).Cells(0).Style.BackColor
    '                        DataGridView1.Rows(fansuccess).Cells(12).Style.ForeColor = DataGridView1.Rows(fansuccess).Cells(0).Style.ForeColor
    '                    End If

    '                    'If selectedresHD(k) < 5 Then
    '                    If selectedresHD(k) < reshead Then
    '                        DataGridView1.Rows(fansuccess).Cells(11).Style.BackColor = Color.White
    '                        DataGridView1.Rows(fansuccess).Cells(11).Style.ForeColor = Color.Red
    '                    Else
    '                        DataGridView1.Rows(fansuccess).Cells(11).Style.BackColor = DataGridView1.Rows(fansuccess).Cells(0).Style.BackColor
    '                        DataGridView1.Rows(fansuccess).Cells(11).Style.ForeColor = DataGridView1.Rows(fansuccess).Cells(0).Style.ForeColor
    '                    End If

    '                    If selectedpow(k) < lowest_power And selectedpow(k) > 0 And selectedresHD(k) >= reshead Then
    '                        lowest_power = selectedpow(k)
    '                        highlight = fansuccess
    '                    End If
    '                ElseIf Units(4).UnitSelected = 2 Then
    '                    'DataGridView1.Rows(fansuccess).Cells(6).Value = selectedpow(k).ToString
    '                    'If selectedmot(k) > 0 Then
    '                    '    DataGridView1.Rows(fansuccess).Cells(7).Value = selectedmot(k).ToString
    '                    'Else
    '                    '    DataGridView1.Rows(fansuccess).Cells(7).Value = "Non Std"
    '                    'End If
    '                    'DataGridView1.Rows(fansuccess).Cells(8).Value = selectedpow2(k).ToString
    '                    'If selectedmot2(k) > 0 Then
    '                    '    DataGridView1.Rows(fansuccess).Cells(9).Value = selectedmot2(k).ToString
    '                    'Else
    '                    '    DataGridView1.Rows(fansuccess).Cells(9).Value = "Non Std"
    '                    'End If
    '                    'DataGridView1.Rows(fansuccess).Cells(10).Value = selectedfse(k).ToString
    '                    'DataGridView1.Rows(fansuccess).Cells(11).Value = selectedfte(k).ToString
    '                    'DataGridView1.Rows(fansuccess).Cells(12).Value = selectedov(k).ToString
    '                    'DataGridView1.Rows(fansuccess).Cells(13).Value = selectedresHD(k).ToString

    '                    'If selectedVD(k) < 0 Then
    '                    '    DataGridView1.Rows(fansuccess).Cells(14).Value = "Stall"
    '                    '    DataGridView1.Rows(fansuccess).Cells(14).Style.BackColor = Color.White
    '                    '    DataGridView1.Rows(fansuccess).Cells(14).Style.ForeColor = Color.Red
    '                    'Else
    '                    '    DataGridView1.Rows(fansuccess).Cells(14).Value = selectedVD(k).ToString
    '                    'End If

    '                    'If selectedresHD(k) < 5 Then
    '                    '    DataGridView1.Rows(fansuccess).Cells(13).Style.BackColor = Color.White
    '                    '    DataGridView1.Rows(fansuccess).Cells(13).Style.ForeColor = Color.Red
    '                    'End If

    '                    'If selectedpow(k) < lowest_power And selectedpow(k) > 0 Then
    '                    '    lowest_power = selectedpow(k)
    '                    '    highlight = fansuccess
    '                    'End If
    '                    DataGridView1.Rows(fansuccess).Cells(6).Value = selectedpow(k).ToString + " / " + selectedpow2(k).ToString
    '                    If selectedmot(k) > 0 Then
    '                        DataGridView1.Rows(fansuccess).Cells(7).Value = selectedmot(k).ToString
    '                    Else
    '                        DataGridView1.Rows(fansuccess).Cells(7).Value = "Non Std"
    '                    End If
    '                    DataGridView1.Rows(fansuccess).Cells(7).Value = DataGridView1.Rows(fansuccess).Cells(7).Value + " / "

    '                    If selectedmot2(k) > 0 Then
    '                        DataGridView1.Rows(fansuccess).Cells(7).Value = DataGridView1.Rows(fansuccess).Cells(7).Value + selectedmot2(k).ToString
    '                    Else
    '                        DataGridView1.Rows(fansuccess).Cells(7).Value = DataGridView1.Rows(fansuccess).Cells(7).Value + "Non Std"
    '                    End If
    '                    DataGridView1.Rows(fansuccess).Cells(8).Value = selectedfse(k).ToString
    '                    DataGridView1.Rows(fansuccess).Cells(9).Value = selectedfte(k).ToString
    '                    DataGridView1.Rows(fansuccess).Cells(10).Value = selectedov(k).ToString
    '                    DataGridView1.Rows(fansuccess).Cells(11).Value = selectedresHD(k).ToString

    '                    If selectedVD(k) < 0 Then
    '                        DataGridView1.Rows(fansuccess).Cells(12).Value = "Stall"
    '                        DataGridView1.Rows(fansuccess).Cells(12).Style.BackColor = Color.White
    '                        DataGridView1.Rows(fansuccess).Cells(12).Style.ForeColor = Color.Red
    '                    Else
    '                        DataGridView1.Rows(fansuccess).Cells(12).Value = selectedVD(k).ToString
    '                        DataGridView1.Rows(fansuccess).Cells(12).Style.BackColor = DataGridView1.Rows(fansuccess).Cells(0).Style.BackColor
    '                        DataGridView1.Rows(fansuccess).Cells(12).Style.ForeColor = DataGridView1.Rows(fansuccess).Cells(0).Style.ForeColor
    '                    End If

    '                    'If selectedresHD(k) < 5 Then
    '                    If selectedresHD(k) < reshead Then
    '                        DataGridView1.Rows(fansuccess).Cells(11).Style.BackColor = Color.White
    '                        DataGridView1.Rows(fansuccess).Cells(11).Style.ForeColor = Color.Red
    '                    Else
    '                        DataGridView1.Rows(fansuccess).Cells(11).Style.BackColor = DataGridView1.Rows(fansuccess).Cells(0).Style.BackColor
    '                        DataGridView1.Rows(fansuccess).Cells(11).Style.ForeColor = DataGridView1.Rows(fansuccess).Cells(0).Style.ForeColor
    '                    End If

    '                    If selectedpow(k) < lowest_power And selectedpow(k) > 0 And selectedresHD(k) >= reshead Then

    '                        lowest_power = selectedpow(k)
    '                        highlight = fansuccess
    '                    End If

    '                End If

    '                fansuccess = fansuccess + 1
    '            End If
    '        Next
    '        DataGridView1.RowCount = fansuccess
    '        DataGridView1.Height = (DataGridView1.RowCount * 24 + DataGridView1.ColumnHeadersHeight) * 1.1
    '        If DataGridView1.Height < 100 Then DataGridView1.Height = 100
    '        'DataGridView1.Height = DataGridView1.Height * 1.1 + DataGridView1.Location.Y
    '        '++++++++++++++++++++++++++++++
    '        'If DataGridView1.RowCount > 9 Then
    '        '    DataGridView1.Height = (9 * 24 + DataGridView1.ColumnHeadersHeight) * 1.1
    '        '    DataGridView1.ScrollBars = ScrollBars.Vertical
    '        'Else
    '        '    DataGridView1.Height = (DataGridView1.RowCount * 24 + DataGridView1.ColumnHeadersHeight) * 1.1
    '        'End If
    '        'Dim mm, nn, zz As Double
    '        'mm = CDbl(DataGridView1.Height) * 1.1
    '        'nn = CDbl(DataGridView1.Location.Y)
    '        'zz = mm + nn
    '        'DataGridView1.Height = CInt(zz)
    '        ''Height = CInt(CDbl(DataGridView1.Height) * 1.1 + CDbl(DataGridView1.Location.Y))

    '        '++++++++++++++++++++++++++++++


    '        If DataGridView1.Height > 350 Then DataGridView1.Height = 350 ' was <
    '        'DataGridView1.Height = 350
    '        If highlight >= 0 Then
    '            DataGridView1.Rows(highlight).Cells(6).Style.BackColor = Color.LightGreen
    '            DataGridView1.CurrentCell = DataGridView1.Rows(highlight).Cells(0)
    '            'Dim irow As Integer
    '            'irow = DataGridView1.Rows(highlight).Cells(6).Selected
    '            'SelectRow(DataGridView1.CurrentCell.RowIndex)
    '            'Else
    '            'DataGridView1.Rows(highlight).Cells(6).Style.BackColor = DataGridView1.Rows(highlight).Cells(0).Style.BackColor
    '            'DataGridView1.Rows(fansuccess).Cells(11).Style.ForeColor = DataGridView1.Rows(fansuccess).Cells(0).Style.ForeColor
    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message + " PopulateGrid")
    '    End Try
    'End Sub

    'Private Sub SelectRow(ii As Integer)
    '    Button13.Enabled = True
    '    Label3.Visible = True
    '    Label3.Text = "Selected Fan: "
    '    LblFanDetails.Visible = True

    '    ' TabPageNoise.Show()
    '    ' TabControl1.Controls.Add(TabPageNoise)

    '    LblFanDetails.Text = selectedfantype(ii) + " " + selectedfansize(ii).ToString + " running at " + selectedspeed(ii).ToString + " rpm"
    '    'Label19.Text = "File used = " + selectedfanfile(ii)
    '    'Label19.Visible = True

    '    finalfansize = selectedfansize(ii)
    '    finalfantype = selectedfantype(ii) 'string
    '    finalfse = selectedfse(ii)
    '    finalspeed = selectedspeed(ii)
    '    finalpow = selectedpow(ii)
    '    finalfsp = selectedfsp(ii)
    '    finalfte = selectedfte(ii)
    '    finalftp = selectedftp(ii)
    '    finalov = selectedov(ii)
    '    finalvol = selectedvol(ii)
    '    finalmot = selectedmot(ii)
    '    finalresHD = selectedresHD(ii)
    '    finalVD = selectedVD(ii)
    '    finalBladeType = selectedBladeType(ii)
    '    finalBladeNumber = selectedBladeNumber(ii)
    '    finalfanfile = selectedfanfile(ii)

    '    'TabPageNoise.Enabled = True
    '    TabControl1.TabPages(3).Enabled = True

    'End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If (e.RowIndex < 0) Or (e.RowIndex < 0 And e.ColumnIndex < 0) Then
            Exit Sub
        End If
        'Button13.Enabled = True
        'Label3.Visible = True
        'Label3.Text = "Selected Fan: "
        'LblFanDetails.Visible = True

        '' TabPageNoise.Show()
        '' TabControl1.Controls.Add(TabPageNoise)

        Dim ii As Integer
        ii = 0
        Do While DataGridView1.Rows(e.RowIndex).Cells(1).Value <> selectedfantype(ii)
            ii = ii + 1
        Loop
        SelectRow(ii)
        'LblFanDetails.Text = selectedfantype(ii) + " " + selectedfansize(ii).ToString + " running at " + selectedspeed(ii).ToString + " rpm"
        ''Label19.Text = "File used = " + selectedfanfile(ii)
        ''Label19.Visible = True

        'finalfansize = selectedfansize(ii)
        'finalfantype = selectedfantype(ii) 'string
        'finalfse = selectedfse(ii)
        'finalspeed = selectedspeed(ii)
        'finalpow = selectedpow(ii)
        'finalfsp = selectedfsp(ii)
        'finalfte = selectedfte(ii)
        'finalftp = selectedftp(ii)
        'finalov = selectedov(ii)
        'finalvol = selectedvol(ii)
        'finalmot = selectedmot(ii)
        'finalresHD = selectedresHD(ii)
        'finalVD = selectedVD(ii)
        'finalBladeType = selectedBladeType(ii)
        'finalBladeNumber = selectedBladeNumber(ii)
        'finalfanfile = selectedfanfile(ii)

        ''TabPageNoise.Enabled = True
        'TabControl1.TabPages(3).Enabled = True
    End Sub

    'Public Sub SetupGrid()
    '    Try
    '        'Dim DataGridView1 = New DataGridView()

    '        DataGridView1.GridColor = Color.Red
    '        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single

    '        DataGridView1.BackgroundColor = Color.LightGray

    '        DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Cyan
    '        DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black

    '        DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]

    '        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    '        DataGridView1.AllowUserToResizeColumns = False

    '        DataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque
    '        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige

    '    Catch ex As Exception
    '        MsgBox("setupgrid")
    '    End Try
    'End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If (e.RowIndex < 0) Or (e.RowIndex < 0 And e.ColumnIndex < 0) Then
            Exit Sub
        End If
        Button13.Enabled = True
        TabPageNoise.Enabled = True
        FrmFanChart.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
        'If Units(4).UnitSelected = 2 Then FrmFanChart.optDisplaykW.Checked = True

        If AdvancedUser = True And Units(4).UnitSelected = 2 Then
            FrmFanChart.optDisplayhp.Visible = True
            FrmFanChart.optDisplaykW.Visible = True
            FrmFanChart.optDisplaykW.Checked = True
        End If
        FrmFanChart.Show()

    End Sub

    ' ############################################################################################
    ' Noise Page
    ' ############################################################################################

    Private Sub TabPageNoise_Enter(sender As Object, e As EventArgs) Handles TabPageNoise.Enter
        'Dim TableLayoutPanel2 = New TableLayoutPanel()
        'TabPageNoise.BackColor = Background_Color
        TableLayoutPanel1.Controls.Clear()
        TxtFlownoise.Text = finalvol.ToString
        TxtPressurenoise.Text = finalfsp.ToString
        TxtSizenoise.Text = finalfansize.ToString
        TxtSpeednoise.Text = finalspeed.ToString
        TxtTypenoise.Text = finalfantype

        For i = 0 To 8
            For j = 0 To 8
                'TableLayoutPanel1.su
            Next
        Next
        DataGridView2.ColumnCount = 9
        DataGridView2.RowCount = 4
        DataGridView2.Columns(0).Width = 200
        For i = 1 To 8
            DataGridView2.Columns(i).Width = 35
        Next


        Dim txt(8) As Label
        For q As Integer = 0 To 7
            txt(q) = New Label()
        Next q

        For q = 0 To 7
            txt(q).BackColor = Color.Transparent
        Next
        'txt.Location = New Point(0, 0)
        txt(0).Text = "63"
        TableLayoutPanel1.Controls.Add(txt(0), 1, 0) '; //start it In cell 0,0
        DataGridView2.Rows(0).Cells(1).Value = txt(0).Text
        txt(1).Text = "125"
        TableLayoutPanel1.Controls.Add(txt(1), 2, 0) '; //start it In cell 0,0
        DataGridView2.Rows(0).Cells(2).Value = txt(1).Text
        txt(2).Text = "250"
        TableLayoutPanel1.Controls.Add(txt(2), 3, 0) '; //start it In cell 0,0
        DataGridView2.Rows(0).Cells(3).Value = txt(2).Text
        txt(3).Text = "500"
        TableLayoutPanel1.Controls.Add(txt(3), 4, 0) '; //start it In cell 0,0
        DataGridView2.Rows(0).Cells(4).Value = txt(3).Text
        txt(4).Text = "1000"
        TableLayoutPanel1.Controls.Add(txt(4), 5, 0) '; //start it In cell 0,0
        DataGridView2.Rows(0).Cells(5).Value = txt(4).Text
        txt(5).Text = "2000"
        TableLayoutPanel1.Controls.Add(txt(5), 6, 0) '; //start it In cell 0,0
        DataGridView2.Rows(0).Cells(6).Value = txt(5).Text
        txt(6).Text = "4000"
        TableLayoutPanel1.Controls.Add(txt(6), 7, 0) '; //start it In cell 0,0
        DataGridView2.Rows(0).Cells(7).Value = txt(6).Text
        txt(7).Text = "8000"
        TableLayoutPanel1.Controls.Add(txt(7), 8, 0) '; //start it In cell 0,0
        DataGridView2.Rows(0).Cells(8).Value = txt(7).Text
        'TableLayoutPanel1.SetColumnSpan(txt, 9) '; //merge 3 columns
        'TableLayoutPanel1.SetColumnSpan(9)

        convunits()
        calcSPL()
        output()

        If OptDuct.Checked = True And OptOpenInlet.Checked = True And OptOpenOutlet.Checked = True Then
            Drow = 17
            OIrow = 26
            OOrow = 33
            bpfroW = 40
            brgrow = 42
            Motorrow = 44

            Call ductcalcs()
            Call outputduct()

            Call openinletcalcs()
            Call outputopeninlet()

            Call openoutletcalcs()
            Call outputopenoutlet()
        End If

        If OptDuct.Checked = True And OptOpenInlet.Checked = True And OptOpenOutlet.Checked = False Then
            Drow = 17
            OIrow = 26
            bpfroW = 34
            brgrow = 36
            Motorrow = 38

            Call ductcalcs()
            Call outputduct()

            Call openinletcalcs()
            Call outputopeninlet()
        End If
        If OptDuct.Checked = True And OptOpenInlet.Checked = False And OptOpenOutlet.Checked = True Then
            Drow = 17
            OOrow = 26
            bpfroW = 34
            brgrow = 36
            Motorrow = 38

            Call ductcalcs()
            Call outputduct()

            Call openoutletcalcs()
            Call outputopenoutlet()
        End If
        If OptDuct.Checked = True And OptOpenInlet.Checked = False And OptOpenOutlet.Checked = False Then
            Drow = 17
            bpfroW = 26
            brgrow = 28
            Motorrow = 30

            Call ductcalcs()
            Call outputduct()
        End If

        If OptDuct.Checked = False And OptOpenInlet.Checked = True And OptOpenOutlet.Checked = True Then
            OIrow = 17
            OOrow = 24
            bpfroW = 31
            brgrow = 33
            Motorrow = 35

            Call openinletcalcs()
            Call outputopeninlet()

            Call openoutletcalcs()
            Call outputopenoutlet()
        End If

        If OptDuct.Checked = False And OptOpenInlet.Checked = False And OptOpenOutlet.Checked = True Then
            OOrow = 17
            bpfroW = 24
            brgrow = 26
            Motorrow = 28

            Call openoutletcalcs()
            Call outputopenoutlet()
        End If
        If OptDuct.Checked = False And OptOpenInlet.Checked = True And OptOpenOutlet.Checked = False Then
            OIrow = 17
            bpfroW = 24
            brgrow = 26
            Motorrow = 28

            Call openinletcalcs()
            Call outputopeninlet()
        End If

        Call calcBPfreq()
        Call outputbpf()

        If optbrg.Checked = True Then
            Call calcbrg()
            Call outputbrg()
        End If

        If optmotor.Checked = True Then
            Call outputmotor()
        End If


    End Sub

    Private Sub OptPoleSpeed_CheckedChanged(sender As Object, e As EventArgs)
        'If OptPoleSpeed.Checked = True Then
        '    GrpPoleBox.Enabled = True
        'Else
        '    Opt2Pole.Checked = False
        '    Opt4Pole.Checked = False
        '    Opt6Pole.Checked = False
        '    Opt8Pole.Checked = False
        '    Opt10Pole.Checked = False
        '    Opt12Pole.Checked = False
        '    GrpPoleBox.Enabled = False
        'End If
    End Sub

    Private Sub Opt2Pole_CheckedChanged(sender As Object, e As EventArgs)
        Txtspeedlimit.Text = 2970
        Txtfanspeed.Text = 2970
    End Sub

    Private Sub Opt4Pole_CheckedChanged(sender As Object, e As EventArgs)
        Txtspeedlimit.Text = 1490
        Txtfanspeed.Text = 1490
    End Sub

    Private Sub Opt6Pole_CheckedChanged(sender As Object, e As EventArgs)
        Txtspeedlimit.Text = 990
        Txtfanspeed.Text = 990
    End Sub

    Private Sub Opt8Pole_CheckedChanged(sender As Object, e As EventArgs)
        Txtspeedlimit.Text = 743
        Txtfanspeed.Text = 743
    End Sub

    Private Sub Opt10Pole_CheckedChanged(sender As Object, e As EventArgs)
        Txtspeedlimit.Text = 590
        Txtfanspeed.Text = 590
    End Sub

    Private Sub Opt12Pole_CheckedChanged(sender As Object, e As EventArgs)
        Txtspeedlimit.Text = 493
        Txtfanspeed.Text = 493
    End Sub

    Private Sub ChkPlenumFans_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ChkAxialFans_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ChkOldDesignFans_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    'Private Sub TabPageSelection_Validating(sender As Object, e As CancelEventArgs) Handles TabPageSelection.Validating
    '    If finalfantype = "" Then
    '        e.Cancel = True
    '        MsgBox("No fan has been selected 1")
    '    Else
    '        'e.Cancel = False
    '        LblFanDetails.Text = ""
    '        Label3.Text = ""
    '    End If
    'End Sub

    Private Sub TabPageEnvironment_Enter(sender As Object, e As EventArgs) Handles TabPageEnvironment.Enter
        'TabPageEnvironment.BackColor = Background_Color
    End Sub

    Private Sub TabPageImpeller_Enter(sender As Object, e As EventArgs) Handles TabPageImpeller.Enter
        'TabPageImpeller.BackColor = Background_Color
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        End
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        Dim PrintPreviewDialog1 As PrintPreviewDialog = New PrintPreviewDialog()
        'PrintPreviewDialog1.InitialDirectory = "c:\Halifax\Projects\"
        'PrintPreviewDialog1.Filter = "Halifax Selection|*.hfs"
        'PrintPreviewDialog1.Title = "Save a Halifax Selection File"
        PrintPreviewDialog1.ShowDialog()
        'SaveFileName = PrintPreviewDialog1.FileName

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        Dim PrintDialog1 As PrintDialog = New PrintDialog()
        'PrintPreviewDialog1.InitialDirectory = "c:\Halifax\Projects\"
        'PrintPreviewDialog1.Filter = "Halifax Selection|*.hfs"
        'PrintPreviewDialog1.Title = "Save a Halifax Selection File"
        PrintDialog1.ShowDialog()
        'SaveFileName = PrintPreviewDialog1.FileName

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        FrmDensityCalcs.TextBox1.Text = TxtDesignTemperature.Text
        FrmDensityCalcs.TextBox4.Text = TxtAltitude.Text
        FrmDensityCalcs.TextBox2.Text = TxtInletPressure.Text
        FrmDensityCalcs.TextBox3.Text = TxtHumidity.Text
        FrmDensityCalcs.ShowDialog()
    End Sub

    Private Sub TabPageDuty_Click(sender As Object, e As EventArgs) Handles TabPageDuty.Click

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'open environment tab
        TabControl1.SelectTab(TabPageEnvironment)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'open fan parameters tab
        'SetUnitValues()
        Dim temppower As Double
        Dim v As Double
        Dim p As Double
        v = CDbl(Txtflow.Text) / convflow / 3600.0
        p = CDbl(Txtfsp.Text) / convpres / 1000.0
        temppower = v * p / 0.7
        'temppower = 1.1 * CDbl(Txtflow.Text) * CDbl(Txtfsp.Text) / (convflow * convpres * 0.7)
        ReadMotorFromBinaryFile()

        count = 0
        Do While (temppower * 1.1) > Motor_Information(count).PowerKW
            count = count + 1
            If count = 100 Then
                'akm temp removed                MsgBox("A Larger Non-Standard Motor is required for selected Fan!", vbInformation)
                'GetMotorSize = "Out Of Range"
                Exit Do
            End If
        Loop
        Motor_Pole_Speeds = Motor_Information(count)
        Select Case freqHz
            Case 50
                If Motor_Pole_Speeds.Speed50(0) = 0 Then Opt2Pole.Visible = False
                If Motor_Pole_Speeds.Speed50(1) = 0 Then Opt4Pole.Visible = False
                If Motor_Pole_Speeds.Speed50(2) = 0 Then Opt6Pole.Visible = False
                If Motor_Pole_Speeds.Speed50(3) = 0 Then Opt8Pole.Visible = False
                If Motor_Pole_Speeds.Speed50(4) = 0 Then Opt10Pole.Visible = False
                If Motor_Pole_Speeds.Speed50(5) = 0 Then Opt12Pole.Visible = False
            Case 60
                If Motor_Pole_Speeds.Speed60(0) = 0 Then Opt2Pole.Visible = False
                If Motor_Pole_Speeds.Speed60(1) = 0 Then Opt4Pole.Visible = False
                If Motor_Pole_Speeds.Speed60(2) = 0 Then Opt6Pole.Visible = False
                If Motor_Pole_Speeds.Speed60(3) = 0 Then Opt8Pole.Visible = False
                If Motor_Pole_Speeds.Speed60(4) = 0 Then Opt10Pole.Visible = False
                If Motor_Pole_Speeds.Speed60(5) = 0 Then Opt12Pole.Visible = False
        End Select
        If Opt2Pole.Visible = False And Opt2Pole.Checked = True Then OptAnySpeed.Checked = True
        If Opt4Pole.Visible = False And Opt4Pole.Checked = True Then Opt2Pole.Checked = True
        If Opt6Pole.Visible = False And Opt6Pole.Checked = True Then Opt2Pole.Checked = True
        If Opt8Pole.Visible = False And Opt8Pole.Checked = True Then Opt2Pole.Checked = True
        If Opt10Pole.Visible = False And Opt10Pole.Checked = True Then Opt2Pole.Checked = True
        If Opt10Pole.Visible = False And Opt12Pole.Checked = True Then Opt2Pole.Checked = True

        Select Case freqHz
            Case 50
                If Opt2Pole.Checked = True Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed50(0).ToString
                If Opt4Pole.Checked = True Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed50(1).ToString
                If Opt6Pole.Checked = True Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed50(2).ToString
                If Opt8Pole.Checked = True Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed50(3).ToString
                If Opt10Pole.Checked = True Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed50(4).ToString
                If Opt12Pole.Checked = True Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed50(5).ToString
            Case 60
                If Opt2Pole.Checked = True Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed60(0).ToString
                If Opt4Pole.Checked = True Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed60(1).ToString
                If Opt6Pole.Checked = True Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed60(2).ToString
                If Opt8Pole.Checked = True Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed60(3).ToString
                If Opt10Pole.Checked = True Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed60(4).ToString
                If Opt12Pole.Checked = True Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed60(5).ToString
        End Select

        'If Opt2Pole.Checked = True Then
        '    If freqHz = 50 Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed50(0).ToString
        '    If freqHz = 60 Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed60(0).ToString
        'End If

        'If Opt4Pole.Checked = True Then
        '    If freqHz = 50 Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed50(1).ToString
        '    If freqHz = 60 Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed60(1).ToString
        'End If

        'If Opt6Pole.Checked = True Then
        '    If freqHz = 50 Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed50(2).ToString
        '    If freqHz = 60 Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed60(2).ToString
        'End If
        'If Opt8Pole.Checked = True Then
        '    If freqHz = 50 Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed50(3).ToString
        '    If freqHz = 60 Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed60(3).ToString
        'End If
        'If Opt10Pole.Checked = True Then
        '    If freqHz = 50 Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed50(4).ToString
        '    If freqHz = 60 Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed60(4).ToString
        'End If
        'If Opt12Pole.Checked = True Then
        '    If freqHz = 50 Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed50(5).ToString
        '    If freqHz = 60 Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed60(5).ToString
        'End If



        TabControl1.SelectTab(TabPageFanParameters)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'open duty input tab
        TabControl1.SelectTab(TabPageDuty)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        maxspeed = CDbl(Txtspeedlimit.Text)
        'Txtspeedlimit
        'open fan selection tab
        'If freqHz = 50 Then maxspeed = 3000
        'If freqHz = 50 And OptPoleSpeed.Checked = True Then
        If Opt2Pole.Checked = True Or Opt4Pole.Checked = True Or Opt6Pole.Checked = True Or Opt8Pole.Checked = True Or Opt10Pole.Checked = True Or Opt12Pole.Checked = True Then maxspeed = CDbl(Txtfanspeed.Text)
        'If freqHz = 50 Then
        '    If Opt2Pole.Checked = True Then maxspeed = 3000
        '    If Opt4Pole.Checked = True Then maxspeed = 1500
        '    If Opt6Pole.Checked = True Then maxspeed = 1000
        '    If Opt8Pole.Checked = True Then maxspeed = 750
        '    If Opt10Pole.Checked = True Then maxspeed = 600
        '    If Opt12Pole.Checked = True Then maxspeed = 500
        'End If
        ''If freqHz = 60 Then maxspeed = 3600
        ''If freqHz = 60 And OptPoleSpeed.Checked = True Then
        'If freqHz = 60 Then
        '    If Opt2Pole.Checked = True Then maxspeed = 3600
        '    If Opt4Pole.Checked = True Then maxspeed = 1800
        '    If Opt6Pole.Checked = True Then maxspeed = 1200
        '    If Opt8Pole.Checked = True Then maxspeed = 900
        '    If Opt10Pole.Checked = True Then maxspeed = 720
        '    If Opt12Pole.Checked = True Then maxspeed = 600
        'End If
        Txtspeedlimit.Text = maxspeed.ToString

        ShowCurvedFanTypes = ChkCurveBlade.Checked
        ShowInclinedFanTypes = ChkInclineBlade.Checked
        ShowOtherFanTypes = ChkOtherFanType.Checked
        ShowPlasticFanTypes = ChkPlasticFan.Checked
        ShowAxialFanTypes = ChkAxialFans.Checked
        ShowPlenumFanTypes = ChkPlenumFans.Checked
        ShowOldFanTypes = ChkOldDesignFans.Checked

        TabControl1.SelectTab(TabPageSelection)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        'open fan parameters tab
        TabControl1.SelectTab(TabPageFanParameters)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        'open noise data tab
        TabControl1.SelectTab(TabPageNoise)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        'open fan selections tab
        TabControl1.SelectTab(TabPageSelection)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        'open save projects
        SaveToFile()
    End Sub

    Private Sub GrpFrequency_Enter(sender As Object, e As EventArgs) Handles GrpFrequency.Enter

    End Sub

    Private Sub Opt2Pole_CheckedChanged_1(sender As Object, e As EventArgs) Handles Opt2Pole.CheckedChanged
        SetSpeeds(0)
        'If freqHz = 50 Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed50(0).ToString
        'If freqHz = 60 Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed60(0).ToString
        'Txtspeedlimit.Text = Txtfanspeed.Text
    End Sub

    Private Sub Opt4Pole_CheckedChanged_1(sender As Object, e As EventArgs) Handles Opt4Pole.CheckedChanged
        SetSpeeds(1)
        'If freqHz = 50 Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed50(1).ToString
        'If freqHz = 60 Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed60(1).ToString
        'Txtspeedlimit.Text = Txtfanspeed.Text
    End Sub

    Private Sub Opt6Pole_CheckedChanged_1(sender As Object, e As EventArgs) Handles Opt6Pole.CheckedChanged
        SetSpeeds(2)
        'If freqHz = 50 Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed50(2).ToString
        'If freqHz = 60 Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed60(2).ToString
        'Txtspeedlimit.Text = Txtfanspeed.Text
    End Sub

    Private Sub Opt8Pole_CheckedChanged_1(sender As Object, e As EventArgs) Handles Opt8Pole.CheckedChanged
        SetSpeeds(3)
        'If freqHz = 50 Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed50(3).ToString
        'If freqHz = 60 Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed60(3).ToString
        'Txtspeedlimit.Text = Txtfanspeed.Text
    End Sub

    Private Sub Opt10Pole_CheckedChanged_1(sender As Object, e As EventArgs) Handles Opt10Pole.CheckedChanged
        SetSpeeds(4)
        'If freqHz = 50 Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed50(4).ToString
        'If freqHz = 60 Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed60(4).ToString
        'Txtspeedlimit.Text = Txtfanspeed.Text
    End Sub

    Private Sub Opt12Pole_CheckedChanged_1(sender As Object, e As EventArgs) Handles Opt12Pole.CheckedChanged
        SetSpeeds(5)
        'If freqHz = 50 Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed50(5).ToString
        'If freqHz = 60 Then Txtfanspeed.Text = Motor_Pole_Speeds.Speed60(5).ToString
        'Txtspeedlimit.Text = Txtfanspeed.Text
    End Sub

    Private Sub OptAnySpeed_CheckedChanged(sender As Object, e As EventArgs) Handles OptAnySpeed.CheckedChanged
        'SetSpeeds(-1)
        Txtfanspeed.Text = "0"
        If freqHz = 50 Then Txtspeedlimit.Text = "3000"
        If freqHz = 60 Then Txtspeedlimit.Text = "3600"
    End Sub



    '###############################################################################################################
    '######################################### General Details and Units Selection #################################
    '###############################################################################################################

    'Private Sub OptDefaultMetric_CheckedChanged(sender As Object, e As EventArgs) Handles OptDefaultMetric.CheckedChanged
    '    Try
    '        OptFlowM3PerHr.Checked = True
    '        OptPressurePa.Checked = True
    '        OptTemperatureC.Checked = True
    '        OptDensityKgPerM3.Checked = True
    '        OptPowerKW.Checked = True
    '        OptLengthMm.Checked = True
    '        OptAltitudeM.Checked = True
    '        OptVelocityMpers.Checked = True
    '        'OptVelocityFtpermin.Checked = False
    '        TxtAltitude.Text = Math.Round(Val(TxtAltitude.Text) * convalt, 0).ToString
    '    Catch ex As Exception
    '        MsgBox("checkedchanged")
    '    End Try

    'End Sub

    'Private Sub OptDefaultImperial_CheckedChanged(sender As Object, e As EventArgs) Handles OptDefaultImperial.CheckedChanged
    '    Try
    '        OptFlowCfm.Checked = True
    '        OptPressureinWG.Checked = True
    '        OptTemperatureF.Checked = True
    '        OptDensityLbPerFt3.Checked = True
    '        OptPowerHp.Checked = True
    '        OptLengthIn.Checked = True
    '        OptAltitudeFt.Checked = True
    '        OptVelocityFtpermin.Checked = True
    '        TxtAltitude.Text = Math.Round(Val(TxtAltitude.Text) * convalt, 0).ToString
    '    Catch ex As Exception
    '        MsgBox("checkedchanged2")
    '    End Try

    'End Sub

    'Private Sub OptDefaultImperial_Click(sender As Object, e As EventArgs) Handles OptDefaultImperial.Click

    'End Sub

    Private Sub OptTemperatureC_CheckedChanged(sender As Object, e As EventArgs) Handles OptTemperatureC.CheckedChanged
        LblAmbientTemperatureUnits.Text = OptTemperatureC.Text
    End Sub

    Private Sub OptTemperatureF_CheckedChanged(sender As Object, e As EventArgs) Handles OptTemperatureF.CheckedChanged
        LblAmbientTemperatureUnits.Text = OptTemperatureF.Text
    End Sub

    Private Sub OptAltitudeM_CheckedChanged(sender As Object, e As EventArgs) Handles OptAltitudeM.CheckedChanged
        LblAltitudeUnits.Text = OptAltitudeM.Text
    End Sub

    Private Sub OptAltitudeFt_CheckedChanged(sender As Object, e As EventArgs) Handles OptAltitudeFt.CheckedChanged
        LblAltitudeUnits.Text = OptAltitudeFt.Text
    End Sub

    Private Sub OptPressurePa_CheckedChanged(sender As Object, e As EventArgs) Handles OptPressurePa.CheckedChanged
        LblAtmosphericPressureUnits.Text = OptPressurePa.Text
    End Sub

    Private Sub OptPressuremBar_CheckedChanged(sender As Object, e As EventArgs) Handles OptPressuremBar.CheckedChanged
        LblAtmosphericPressureUnits.Text = OptPressuremBar.Text
    End Sub

    Private Sub OptPressureinWG_CheckedChanged(sender As Object, e As EventArgs) Handles OptPressureinWG.CheckedChanged
        LblAtmosphericPressureUnits.Text = OptPressureinWG.Text
    End Sub

    Private Sub OptPressuremmWG_CheckedChanged(sender As Object, e As EventArgs) Handles OptPressuremmWG.CheckedChanged
        LblAtmosphericPressureUnits.Text = OptPressuremmWG.Text
    End Sub

    Private Sub OptPressurekPa_CheckedChanged(sender As Object, e As EventArgs) Handles OptPressurekPa.CheckedChanged
        LblAtmosphericPressureUnits.Text = OptPressurekPa.Text
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Try
            'OptFlowM3PerHr.Checked = True
            'OptPressurePa.Checked = True
            'OptTemperatureC.Checked = True
            'OptDensityKgPerM3.Checked = True
            'OptPowerKW.Checked = True
            'OptLengthMm.Checked = True
            'OptAltitudeM.Checked = True
            'OptVelocityMpers.Checked = True
            ''OptVelocityFtpermin.Checked = False
            'TxtAltitude.Text = Math.Round(Val(TxtAltitude.Text) * convalt, 0).ToString
            MetricUnits()
        Catch ex As Exception
            ErrorMessage(ex, 1003)
            'MsgBox("checkedchanged")
        End Try
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Try
            'OptFlowCfm.Checked = True
            'OptPressureinWG.Checked = True
            'OptTemperatureF.Checked = True
            'OptDensityLbPerFt3.Checked = True
            'OptPowerHp.Checked = True
            'OptLengthIn.Checked = True
            'OptAltitudeFt.Checked = True
            'OptVelocityFtpermin.Checked = True
            'TxtAltitude.Text = Math.Round(Val(TxtAltitude.Text) * convalt, 0).ToString
            ImperialUnits()
        Catch ex As Exception
            ErrorMessage(ex, 1002)
            'MsgBox("checkedchanged2")
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'open duty input tab
        Try
            SetUnitValues()
            If Opt50Hz.Checked = True Then freqHz = 50
            If Opt60Hz.Checked = True Then freqHz = 60
            Opt2Pole.Visible = True
            Opt4Pole.Visible = True
            Opt6Pole.Visible = True
            Opt8Pole.Visible = True
            Opt10Pole.Visible = True
            Opt12Pole.Visible = True
            TabControl1.SelectTab(TabPageDuty)
        Catch ex As Exception
            ErrorMessage(ex, 1001)
            'MsgBox("click")
        End Try
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        objStreamWriterDebug.Close()
        End
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        objStreamWriterDebug.Close()
        End
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        End
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        End
    End Sub

    Private Sub optDDStandard_CheckedChanged(sender As Object, e As EventArgs) Handles optDDStandard.CheckedChanged
        'DischargeDuct(False, False, False)
        txtUserDefinedDD.Enabled = False
        txtRatioDD.Enabled = False
        lblUserDefinedUnits.Enabled = False
        lblpercent.Enabled = False
    End Sub

    Private Sub optDDUserDefined_CheckedChanged(sender As Object, e As EventArgs) Handles optDDUserDefined.CheckedChanged
        'DischargeDuct(True, False, False)
        txtUserDefinedDD.Enabled = True
        txtRatioDD.Enabled = False
        lblUserDefinedUnits.Enabled = True
        lblpercent.Enabled = False
    End Sub

    Private Sub optDDRatio_CheckedChanged(sender As Object, e As EventArgs) Handles optDDRatio.CheckedChanged
        'DischargeDuct(False, True, True)
        txtUserDefinedDD.Enabled = False
        txtRatioDD.Enabled = True
        lblUserDefinedUnits.Enabled = False
        lblpercent.Enabled = True
    End Sub

    Private Sub chkDisplayAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkDisplayAll.CheckedChanged
        TabPageSelection_Enter(sender, e)
        'DataGridView1.ClearSelection()
        'PopulateGrid()

    End Sub

    Private Sub chkDisplayLowerEff_CheckedChanged(sender As Object, e As EventArgs) Handles chkDisplayLowerEff.CheckedChanged
        TabPageSelection_Enter(sender, e)
    End Sub
End Class
