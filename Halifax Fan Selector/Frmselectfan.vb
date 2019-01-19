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
            If StartArg.ToLower.Contains("-dev") Then
                Me.Text = Me.Text.ToUpper()
            End If
            'If StartArg Is Nothing Then
            'If StartArg.ToLower.Contains("-a") Or StartArg.ToLower.Contains("-b") Or UserName.ToLower.Contains("akmci") Then
            If StartArg.ToLower.Contains("-a") Or StartArg.ToLower.Contains("-b") Or StartArg.ToLower.Contains("-dev") Then
            Else
                TabControl1.Controls.Remove(TabPageNoise)
                'TabControl1.Controls.Remove(TabPageSelection)
                btnNoiseDataForward.Visible = False
            End If
            If version_number = "V 1.0.0 Beta" Then
                TabControl1.Controls.Remove(TabPageNoise)
                TabControl1.Controls.Remove(TabPageSelection)
                'btnCalculateDensity.Visible = False
                'btnDutyInputForward.Visible = False
                'btnFanParametersForward.Visible = False
                'btnGeneralInformationBack.Visible = False
                'btnDutyInputBack.Visible = False
                btnFanSelectionsForward.Visible = False
            End If
            If AdvancedUser = False Then
                btnCalculateDensity.Visible = False
                OptDensityCalculated.Visible = False
                OptDensityKnown.Visible = False
            End If
            If StartArg.ToLower.Contains("-dev") Then
                optDDUserDefined.Enabled = True
                optDDRatio.Enabled = True
                txtUserDefinedDD.Enabled = True
                txtRatioDD.Enabled = True

            End If
            Initialize(True)
        Catch ex As Exception
            MsgBox("load")
        End Try
    End Sub

    Private Sub TabControl1_DrawItem(sender As System.Object, e As System.Windows.Forms.DrawItemEventArgs) Handles TabControl1.DrawItem
        Try
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

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDutyExit_Click(sender As Object, e As EventArgs) Handles btnDutyExit.Click
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
        '    MsgBox("btnDutyExit_click")
        'End Try
        Try
            End

        Catch ex As Exception

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

    'Private Sub UnitsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles UnitsToolStripMenuItem.Click
    '    'Try
    '    '    atmos = TxtAtmosphericPressure.Text
    '    '    FrmUnits.ShowDialog()

    '    'Catch ex As Exception
    '    '    MsgBox("UnitsToolStripMenuItem_Click_1")
    '    'End Try
    'End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Try
            NewProject = True
            Initialize(True)

        Catch ex As Exception
            MsgBox("OpenToolStripMenuItem_Click")
        End Try
    End Sub

    Private Sub SaveProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveProjectToolStripMenuItem.Click
        Try
            SaveToFile()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub OpenProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenProjectToolStripMenuItem.Click
        Try
            ReadFromProjectFile = False
            Dim OpenFileDialog1 As OpenFileDialog = New OpenFileDialog()
            OpenFileDialog1.InitialDirectory = "c:\Halifax\Projects\"
            OpenFileDialog1.Filter = "Halifax files (*.hfs)|*.hfs|All files (*.*)|*.*"
            OpenFileDialog1.ShowDialog()
            OpenFileName = OpenFileDialog1.FileName
            If OpenFileName = "" Then Exit Sub
            ReadProjectFile(OpenFileName)

            'Dim textReader As XmlTextReader = New XmlTextReader(OpenFileName)
            'textReader.MoveToFirstAttribute()

            ''While (document.Read())

            ''    Dim type = document.NodeType

            ''    'if node type was element
            ''    If (type = XmlNodeType.Element) Then

            ''        'if the loop found a <FirstName> tag
            ''        If (document.Name = "FirstName") Then

            ''            TextBox1.Text = document.ReadInnerXml.ToString()

            ''        End If

            ''        'if the loop found a <LastName tag
            ''        If (document.Name = "LastName") Then

            ''            TextBox2.Text = document.ReadInnerXml.ToString()

            ''        End If

            ''    End If

            ''End While

            'While (textReader.Read())
            '    Dim type = textReader.NodeType
            '    'ReadGeneralInfo(textReader)
            '    'ReadSelectionInputInfo(textReader)
            '    'MsgBox("textReader.NameOf = ", textReader.Name)
            '    If (type = XmlNodeType.Element) Then
            '        If textReader.Name = "Customer" Then Customer = textReader.ReadString
            '        If textReader.Name = "Engineer" Then Engineer = textReader.ReadString
            '        If textReader.Name = "Flow_Units" Then Units(0).UnitSelected = textReader.ReadString
            '        If textReader.Name = "Pressure_Units" Then Units(1).UnitSelected = textReader.ReadString
            '        If textReader.Name = "Temperature_Units" Then Units(2).UnitSelected = textReader.ReadString
            '        If textReader.Name = "Density_Units" Then Units(3).UnitSelected = textReader.ReadString
            '        If textReader.Name = "Power_Units" Then Units(4).UnitSelected = textReader.ReadString
            '        If textReader.Name = "Size_Units" Then Units(5).UnitSelected = textReader.ReadString
            '        If textReader.Name = "Altitude_Units" Then Units(6).UnitSelected = textReader.ReadString
            '        If textReader.Name = "Design_Temperature" Then designtemp = textReader.ReadString
            '        If textReader.Name = "Maximum_Temperature" Then maximumtemp = textReader.ReadString
            '        If textReader.Name = "Ambient_Temperature" Then ambienttemp = textReader.ReadString
            '        If textReader.Name = "Altitude" Then altitude = textReader.ReadString
            '        If textReader.Name = "Relative_Humidity" Then humidity = textReader.ReadString
            '        If textReader.Name = "Atmospheric_Pressure" Then atmospress = textReader.ReadString
            '        If textReader.Name = "Known_Density" Then knowndensity = textReader.ReadString
            '        If textReader.Name = "Flow_Rate" Then flowrate = textReader.ReadString
            '        If textReader.Name = "Inlet_Pressure" Then inletpress = textReader.ReadString
            '        If textReader.Name = "Discharge_Pressure" Then dischpress = textReader.ReadString
            '        If textReader.Name = "Pressure_Rise" Then pressrise = textReader.ReadString
            '        If textReader.Name = "Reserve_Head" Then reshead = textReader.ReadString
            '        If textReader.Name = "Maximum_Speed" Then maxspeed = textReader.ReadString
            '    End If

            'End While
            '' ### Close the load text file ###
            'textReader.Close()

            'TxtAtmosphericPressure.Text = atmos.ToString
            'TxtDesignTemperature.Text = designtemp.ToString
            'TxtMaximumTemperature.Text = maximumtemp.ToString
            'TxtAmbientTemperature.Text = ambienttemp.ToString
            'TxtAltitude.Text = altitude.ToString
            'TxtHumidity.Text = humidity.ToString
            'TxtAtmosphericPressure.Text = atmospress.ToString
            'Txtdens.Text = knowndensity.ToString
            'Txtflow.Text = flowrate.ToString
            'TxtInletPressure.Text = inletpress.ToString
            'TxtDischargePressure.Text = dischpress.ToString
            'Txtfsp.Text = pressrise.ToString
            'CmbReserveHead.Text = reshead.ToString + "%"
            'Txtspeedlimit.Text = maxspeed.ToString
            'ReadFromProjectFile = True

            ''Catch ex As Exception
            ''    'MsgBox("OpenProjectToolStripMenuItem_Click")
            ''    'Resume
            ''End Try

        Catch ex As Exception

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

    ' ############################################################################################
    ' Duty Page
    ' ############################################################################################

    Private Sub TabPageDuty_Enter(sender As Object, e As EventArgs) Handles TabPageDuty.Enter
        'TabPageDuty.BackColor = Background_Color
        Try
            SetupDutyPage()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TabPageDuty_Leave(sender As Object, e As EventArgs) Handles TabPageDuty.Leave
        Try
            Dim str_temp As String = CmbReserveHead.Items(CmbReserveHead.SelectedIndex)

            reshead = CDbl(str_temp.Remove(str_temp.Length - 1))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OptDensityCalculated_CheckedChanged(sender As Object, e As EventArgs) Handles OptDensityCalculated.CheckedChanged
        Try
            If (OptDensityCalculated.Checked = True) Then
                RunTemp = Val(TxtDesignTemperature.Text)
                If Units(2).UnitSelected = 1 Then RunTemp = Math.Round(((RunTemp - 32) * 5 / 9), 1)
                Txtdens.Text = Math.Round((293 / (RunTemp + 273)) * 1.2, 3)
                Txtdens.ReadOnly = True
                btnCalculateDensity.Enabled = True
            Else
                Txtdens.ReadOnly = False
                btnCalculateDensity.Enabled = False
            End If

        Catch ex As Exception
            MsgBox("OptDensityCalculated_CheckedChanged")
        End Try
    End Sub

    ' ############################################################################################
    ' Selection Page
    ' ############################################################################################

    Private Sub TabPageSelection_Leave(sender As Object, e As EventArgs) Handles TabPageSelection.Leave
        Try
            If finalfantype = "" Then
                'e.Cancel = True
                'MsgBox("No fan has been selected 2")
            Else
                'e.Cancel = False
                LblFanDetails.Text = ""
                Label3.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TabPageSelection_Enter(sender As Object, e As EventArgs) Handles TabPageSelection.Enter
        Try
            SetupSelectionPage()
            CenterToScreen()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Close()
            End
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If (e.RowIndex < 0) Or (e.RowIndex < 0 And e.ColumnIndex < 0) Then
                Exit Sub
            End If
            'btnNoiseDataForward.Enabled = True
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

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            If StartArg.ToLower.Contains("-dev") Then

                If (e.RowIndex < 0) Or (e.RowIndex < 0 And e.ColumnIndex < 0) Then
                    Exit Sub
                End If
                btnNoiseDataForward.Enabled = True
                TabPageNoise.Enabled = True
                FrmFanChart.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                'If Units(4).UnitSelected = 2 Then FrmFanChart.optDisplaykW.Checked = True

                If AdvancedUser = True And Units(4).UnitSelected = 2 Then
                    FrmFanChart.optDisplayhp.Visible = True
                    FrmFanChart.optDisplaykW.Visible = True
                    FrmFanChart.optDisplaykW.Checked = True
                End If
                FrmFanChart.Show()
            Else
                MsgBox("Coding in Progress")
                Exit Sub
            End If

        Catch ex As Exception

        End Try

    End Sub

    ' ############################################################################################
    ' Noise Page
    ' ############################################################################################

    Private Sub TabPageNoise_Enter(sender As Object, e As EventArgs) Handles TabPageNoise.Enter
        Try
            'Dim TableLayoutPanel2 = New TableLayoutPanel()
            'TabPageNoise.BackColor = Background_Color
            'TableLayoutPanel1.Controls.Clear()

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

            SetAcousticsGrid()

            'DataGridView2.Controls.Clear()
            'DataGridView2.ColumnCount = 9
            'DataGridView2.RowCount = 9
            ''DataGridView2.Width = 0
            'DataGridView2.Columns(0).Width = 175

            'For i = 1 To 8
            '    DataGridView2.Columns(i).Width = 45
            'Next
            'DataGridView2.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 9, FontStyle.Bold)
            'DataGridView2.DefaultCellStyle.Font = New Font("Tahoma", 9)
            'OctaveBands()

            ConvUnits()
            'CalcSPL()
            'Output()

            OpenDuctCalcs()


            'If chkDuct.Checked = True And chkOpenInlet.Checked = True And chkOpenOutlet.Checked = True Then
            '    'Drow = 17
            '    'OIrow = 26
            '    'OOrow = 33
            '    'bpfroW = 40
            '    'brgrow = 42
            '    'Motorrow = 44

            '    Call DuctCalcs()
            '    Call OutputDuct()

            '    Call OpenInletCalcs()
            '    Call OutputOpenInlet()

            '    Call OpenOutletCalcs()
            '    Call OutputOpenOutlet()
            'End If

            'If chkDuct.Checked = True And chkOpenInlet.Checked = True And chkOpenOutlet.Checked = False Then
            '    'Drow = 17
            '    'OIrow = 26
            '    'bpfroW = 34
            '    'brgrow = 36
            '    'Motorrow = 38

            '    Call DuctCalcs()
            '    Call OutputDuct()

            '    Call OpenInletCalcs()
            '    Call OutputOpenInlet()
            'End If
            'If chkDuct.Checked = True And chkOpenInlet.Checked = False And chkOpenOutlet.Checked = True Then
            '    'Drow = 17
            '    'OOrow = 26
            '    'bpfroW = 34
            '    'brgrow = 36
            '    'Motorrow = 38

            '    Call DuctCalcs()
            '    Call OutputDuct()

            '    Call OpenOutletCalcs()
            '    Call OutputOpenOutlet()
            'End If
            'If chkDuct.Checked = True And chkOpenInlet.Checked = False And chkOpenOutlet.Checked = False Then
            '    'Drow = 17
            '    'bpfroW = 26
            '    'brgrow = 28
            '    'Motorrow = 30

            '    Call DuctCalcs()
            '    Call OutputDuct()
            'End If

            'If chkDuct.Checked = False And chkOpenInlet.Checked = True And chkOpenOutlet.Checked = True Then
            '    'OIrow = 17
            '    'OOrow = 24
            '    'bpfroW = 31
            '    'brgrow = 33
            '    'Motorrow = 35

            '    Call OpenInletCalcs()
            '    Call OutputOpenInlet()

            '    Call OpenOutletCalcs()
            '    Call OutputOpenOutlet()
            'End If

            'If chkDuct.Checked = False And chkOpenInlet.Checked = False And chkOpenOutlet.Checked = True Then
            '    OOrow = 17
            '    bpfroW = 24
            '    brgrow = 26
            '    Motorrow = 28

            '    Call OpenOutletCalcs()
            '    Call OutputOpenOutlet()
            'End If
            'If chkDuct.Checked = False And chkOpenInlet.Checked = True And chkOpenOutlet.Checked = False Then
            '    OIrow = 17
            '    bpfroW = 24
            '    brgrow = 26
            '    Motorrow = 28

            '    Call OpenInletCalcs()
            '    Call OutputOpenInlet()
            'End If

            'Call CalcBPFreq()
            'Call OutputBPF()

            'If chkBrg.Checked = True Then
            '    Call CalcBrg()
            '    Call OutputBrg()
            'End If

            'If chkMotor.Checked = True Then
            '    Call OutputMotor()
            'End If

        Catch ex As Exception

        End Try


    End Sub

    'Private Sub OptPoleSpeed_CheckedChanged(sender As Object, e As EventArgs)
    '    'If OptPoleSpeed.Checked = True Then
    '    '    GrpPoleBox.Enabled = True
    '    'Else
    '    '    Opt2Pole.Checked = False
    '    '    Opt4Pole.Checked = False
    '    '    Opt6Pole.Checked = False
    '    '    Opt8Pole.Checked = False
    '    '    Opt10Pole.Checked = False
    '    '    Opt12Pole.Checked = False
    '    '    GrpPoleBox.Enabled = False
    '    'End If
    'End Sub

    'Private Sub Opt2Pole_CheckedChanged(sender As Object, e As EventArgs)
    '    Txtspeedlimit.Text = 2970
    '    Txtfanspeed.Text = 2970
    'End Sub

    'Private Sub Opt4Pole_CheckedChanged(sender As Object, e As EventArgs)
    '    Txtspeedlimit.Text = 1490
    '    Txtfanspeed.Text = 1490
    'End Sub

    'Private Sub Opt6Pole_CheckedChanged(sender As Object, e As EventArgs)
    '    Txtspeedlimit.Text = 990
    '    Txtfanspeed.Text = 990
    'End Sub

    'Private Sub Opt8Pole_CheckedChanged(sender As Object, e As EventArgs)
    '    Txtspeedlimit.Text = 743
    '    Txtfanspeed.Text = 743
    'End Sub

    'Private Sub Opt10Pole_CheckedChanged(sender As Object, e As EventArgs)
    '    Txtspeedlimit.Text = 590
    '    Txtfanspeed.Text = 590
    'End Sub

    'Private Sub Opt12Pole_CheckedChanged(sender As Object, e As EventArgs)
    '    Txtspeedlimit.Text = 493
    '    Txtfanspeed.Text = 493
    'End Sub

    'Private Sub ChkPlenumFans_CheckedChanged(sender As Object, e As EventArgs)

    'End Sub

    'Private Sub ChkAxialFans_CheckedChanged(sender As Object, e As EventArgs)

    'End Sub

    'Private Sub ChkOldDesignFans_CheckedChanged(sender As Object, e As EventArgs)

    'End Sub

    Private Sub TabPageGeneral_Enter(sender As Object, e As EventArgs) Handles TabPageGeneral.Enter
        'TabPageGeneral.BackColor = Background_Color
    End Sub

    Private Sub TabPageImpeller_Enter(sender As Object, e As EventArgs) Handles TabPageImpeller.Enter
        'TabPageImpeller.BackColor = Background_Color
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            End
        Catch ex As Exception

        End Try
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

    Private Sub btnCalculateDensity_Click(sender As Object, e As EventArgs) Handles btnCalculateDensity.Click
        Try
            FrmDensityCalcs.TextBox1.Text = TxtDesignTemperature.Text
            FrmDensityCalcs.TextBox4.Text = TxtAltitude.Text
            FrmDensityCalcs.TextBox2.Text = TxtInletPressure.Text
            FrmDensityCalcs.TextBox3.Text = TxtHumidity.Text
            FrmDensityCalcs.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TabPageDuty_Click(sender As Object, e As EventArgs) Handles TabPageDuty.Click

    End Sub

    Private Sub btnGeneralInformationBack_Click(sender As Object, e As EventArgs) Handles btnGeneralInformationBack.Click
        'open general information tab
        Try
            Txtflow.BackColor = Color.White
            Txtdens.BackColor = Color.White
            Txtfsp.BackColor = Color.White
            txtUserDefinedDD.BackColor = Color.White
            txtRatioDD.BackColor = Color.White
            TabControl1.SelectTab(TabPageGeneral)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnFanParametersForward_Click(sender As Object, e As EventArgs) Handles btnFanParametersForward.Click
        'open fan parameters tab
        Try
            'Dim move_on As Boolean = True
            move_on = True
            ''Yellow()

            'If Not Txtflow.Text.All(AddressOf Char.IsDigit) Then
            '    Txtflow.BackColor = Color.LightYellow
            '    Txtflow.Text = ""
            '    move_on = False
            'ElseIf CDbl(Txtflow.Text) <= 0.0 Then
            '    Txtflow.BackColor = Color.LightYellow
            '    Txtflow.Text = ""
            '    move_on = False
            'Else
            '    Txtflow.BackColor = Color.White
            'End If
            'If Not Txtdens.Text.All(AddressOf Char.IsDigit) Then
            '    Txtdens.BackColor = Color.LightYellow
            '    Txtdens.Text = ""
            '    move_on = False
            'ElseIf CDbl(Txtdens.Text) <= 0.0 Then
            '    Txtdens.BackColor = Color.LightYellow
            '    Txtdens.Text = ""
            '    move_on = False
            'Else
            '    Txtdens.BackColor = Color.White
            'End If
            'If Not Txtfsp.Text.All(AddressOf Char.IsDigit) Then
            '    Txtfsp.BackColor = Color.LightYellow
            '    Txtfsp.Text = ""
            '    move_on = False
            'ElseIf CDbl(Txtfsp.Text) <= 0.0 Then
            '    Txtfsp.BackColor = Color.LightYellow
            '    Txtfsp.Text = ""
            '    move_on = False
            'Else
            '    Txtfsp.BackColor = Color.White
            'End If
            Yellow(Txtflow)
            Yellow(Txtdens)
            Yellow(Txtfsp)
            Yellow(TxtInletPressure, -9999.99)
            Yellow(TxtDesignTemperature, -50.0)
            'Yellow(TxtDischargePressure)
            'Yellow(CmbReserveHead)
            If optDDUserDefined.Checked = True Then
                Yellow(txtUserDefinedDD)
            Else
                txtUserDefinedDD.BackColor = Color.White
            End If
            If optDDRatio.Checked = True Then
                Yellow(txtRatioDD)
            Else
                txtRatioDD.BackColor = Color.White
            End If

            If move_on = True Then SetupFanParametersPage()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDutyInputBack_Click(sender As Object, e As EventArgs) Handles btnDutyInputBack.Click
        'open duty input tab
        Try
            TabControl1.SelectTab(TabPageDuty)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnFanSelectionsForward_Click(sender As Object, e As EventArgs) Handles btnFanSelectionsForward.Click
        Try
            maxspeed = CDbl(Txtspeedlimit.Text)
            If Opt2Pole.Checked = True Or Opt4Pole.Checked = True Or Opt6Pole.Checked = True Or Opt8Pole.Checked = True Or Opt10Pole.Checked = True Or Opt12Pole.Checked = True Then maxspeed = CDbl(Txtfanspeed.Text)
            Txtspeedlimit.Text = maxspeed.ToString

            ShowCurvedFanTypes = ChkCurveBlade.Checked
            ShowInclinedFanTypes = ChkInclineBlade.Checked
            ShowOtherFanTypes = ChkOtherFanType.Checked
            ShowPlasticFanTypes = ChkPlasticFan.Checked
            ShowAxialFanTypes = ChkAxialFans.Checked
            ShowPlenumFanTypes = ChkPlenumFans.Checked
            ShowOldFanTypes = ChkOldDesignFans.Checked

            TabControl1.SelectTab(TabPageSelection)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnFanParametersBack_Click(sender As Object, e As EventArgs) Handles btnFanParametersBack.Click
        'open fan parameters tab
        Try
            TabControl1.SelectTab(TabPageFanParameters)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNoiseDataForward_Click(sender As Object, e As EventArgs) Handles btnNoiseDataForward.Click
        'open noise data tab
        Try
            TabControl1.SelectTab(TabPageNoise)
            If OptStaticPressure.Checked Then
                Label14.Text = "Fan Static Pressure"
            Else
                Label14.Text = "Fan Total Pressure"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnFanSelectionsBack_Click(sender As Object, e As EventArgs) Handles btnFanSelectionsBack.Click
        'open fan selections tab
        Try
            TabControl1.SelectTab(TabPageSelection)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSaveProjectForward_Click(sender As Object, e As EventArgs) Handles btnSaveProjectForward.Click
        'open save projects
        Try
            SaveToFile()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GrpFrequency_Enter(sender As Object, e As EventArgs) Handles GrpFrequency.Enter

    End Sub

    Private Sub Opt2Pole_CheckedChanged_1(sender As Object, e As EventArgs) Handles Opt2Pole.CheckedChanged
        Try
            SetSpeeds(0)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Opt4Pole_CheckedChanged_1(sender As Object, e As EventArgs) Handles Opt4Pole.CheckedChanged
        Try
            SetSpeeds(1)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Opt6Pole_CheckedChanged_1(sender As Object, e As EventArgs) Handles Opt6Pole.CheckedChanged
        Try
            SetSpeeds(2)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Opt8Pole_CheckedChanged_1(sender As Object, e As EventArgs) Handles Opt8Pole.CheckedChanged
        Try
            SetSpeeds(3)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Opt10Pole_CheckedChanged_1(sender As Object, e As EventArgs) Handles Opt10Pole.CheckedChanged
        Try
            SetSpeeds(4)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Opt12Pole_CheckedChanged_1(sender As Object, e As EventArgs) Handles Opt12Pole.CheckedChanged
        Try
            SetSpeeds(5)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub OptAnySpeed_CheckedChanged(sender As Object, e As EventArgs) Handles OptAnySpeed.CheckedChanged
        Try
            Txtfanspeed.Text = "0"
            If freqHz = 50 Then Txtspeedlimit.Text = "3000"
            If freqHz = 60 Then Txtspeedlimit.Text = "3600"
        Catch ex As Exception

        End Try
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
        Try
            LblAmbientTemperatureUnits.Text = OptTemperatureC.Text

        Catch ex As Exception

        End Try
    End Sub

    Private Sub OptTemperatureF_CheckedChanged(sender As Object, e As EventArgs) Handles OptTemperatureF.CheckedChanged
        Try
            LblAmbientTemperatureUnits.Text = OptTemperatureF.Text

        Catch ex As Exception

        End Try
    End Sub

    Private Sub OptAltitudeM_CheckedChanged(sender As Object, e As EventArgs) Handles OptAltitudeM.CheckedChanged
        Try
            LblAltitudeUnits.Text = OptAltitudeM.Text

        Catch ex As Exception

        End Try
    End Sub

    Private Sub OptAltitudeFt_CheckedChanged(sender As Object, e As EventArgs) Handles OptAltitudeFt.CheckedChanged
        Try
            LblAltitudeUnits.Text = OptAltitudeFt.Text

        Catch ex As Exception

        End Try
    End Sub

    Private Sub OptPressurePa_CheckedChanged(sender As Object, e As EventArgs) Handles OptPressurePa.CheckedChanged
        Try
            LblAtmosphericPressureUnits.Text = OptPressurePa.Text

        Catch ex As Exception

        End Try
    End Sub

    Private Sub OptPressuremBar_CheckedChanged(sender As Object, e As EventArgs) Handles OptPressuremBar.CheckedChanged
        Try
            LblAtmosphericPressureUnits.Text = OptPressuremBar.Text
        Catch ex As Exception

        End Try

    End Sub

    Private Sub OptPressureinWG_CheckedChanged(sender As Object, e As EventArgs) Handles OptPressureinWG.CheckedChanged
        Try
            LblAtmosphericPressureUnits.Text = OptPressureinWG.Text

        Catch ex As Exception

        End Try
    End Sub

    Private Sub OptPressuremmWG_CheckedChanged(sender As Object, e As EventArgs) Handles OptPressuremmWG.CheckedChanged
        Try
            LblAtmosphericPressureUnits.Text = OptPressuremmWG.Text

        Catch ex As Exception

        End Try
    End Sub

    Private Sub OptPressurekPa_CheckedChanged(sender As Object, e As EventArgs) Handles OptPressurekPa.CheckedChanged
        Try
            LblAtmosphericPressureUnits.Text = OptPressurekPa.Text

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnMetricUnits_Click(sender As Object, e As EventArgs) Handles btnMetricUnits.Click
        Try
            MetricUnits()
        Catch ex As Exception
            ErrorMessage(ex, 20300)
        End Try
    End Sub

    Private Sub btnImperialUnits_Click(sender As Object, e As EventArgs) Handles btnImperialUnits.Click
        Try
            ImperialUnits()
        Catch ex As Exception
            ErrorMessage(ex, 20301)
        End Try
    End Sub

    Private Sub btnDutyInputForward_Click(sender As Object, e As EventArgs) Handles btnDutyInputForward.Click
        'open duty input tab
        'Dim asdf As String = "test"
        Try
            'aa = 0 / asdf
            SetUnitValues()
            If Opt50Hz.Checked = True Then freqHz = 50
            If Opt60Hz.Checked = True Then freqHz = 60
            Opt2Pole.Visible = True
            Opt4Pole.Visible = True
            Opt6Pole.Visible = True
            Opt8Pole.Visible = True
            Opt10Pole.Visible = True
            Opt12Pole.Visible = True
            If StartArg.ToLower.Contains("-dev") Then
            Else
                Opt2Pole.Enabled = False
                Opt4Pole.Enabled = False
                Opt6Pole.Enabled = False
                Opt8Pole.Enabled = False
                Opt10Pole.Enabled = False
                Opt12Pole.Enabled = False
                OptFixedSize.Enabled = False
                Txtfanspeed.Enabled = False
                Txtfansize.Enabled = False
            End If
            TabControl1.SelectTab(TabPageDuty)
        Catch ex As Exception
            'ErrorMessage(ex, 2000)
            ErrorMessage(ex, 20302)
        End Try
    End Sub

    Private Sub btnNoiseExit_Click(sender As Object, e As EventArgs) Handles btnNoiseExit.Click
        Try
            'objStreamWriterDebug.Close()
            End
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSelectionsExit_Click(sender As Object, e As EventArgs) Handles btnSelectionsExit.Click
        Try
            'objStreamWriterDebug.Close()
            End
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnParametersExit_Click(sender As Object, e As EventArgs) Handles btnParametersExit.Click
        Try
            End
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGeneralExit_Click(sender As Object, e As EventArgs) Handles btnGeneralExit.Click
        Try
            End
        Catch ex As Exception

        End Try
    End Sub

    Private Sub optDDStandard_CheckedChanged(sender As Object, e As EventArgs) Handles optDDStandard.CheckedChanged
        Try
            'DischargeDuct(False, False, False)
            txtUserDefinedDD.Enabled = False
            txtRatioDD.Enabled = False
            lblUserDefinedUnits.Enabled = False
            lblpercent.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub optDDUserDefined_CheckedChanged(sender As Object, e As EventArgs) Handles optDDUserDefined.CheckedChanged
        Try
            'DischargeDuct(True, False, False)
            txtUserDefinedDD.Enabled = True
            txtRatioDD.Enabled = False
            lblUserDefinedUnits.Enabled = True
            lblpercent.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub optDDRatio_CheckedChanged(sender As Object, e As EventArgs) Handles optDDRatio.CheckedChanged
        Try
            'DischargeDuct(False, True, True)
            txtUserDefinedDD.Enabled = False
            txtRatioDD.Enabled = True
            lblUserDefinedUnits.Enabled = False
            lblpercent.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkDisplayAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkDisplayAll.CheckedChanged
        Try
            TabPageSelection_Enter(sender, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkDisplayLowerEff_CheckedChanged(sender As Object, e As EventArgs) Handles chkDisplayLowerEff.CheckedChanged
        Try
            TabPageSelection_Enter(sender, e)
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click
    '    'If TabControl1.SelectedTab("aaaa") = True Then

    '    'End If
    '    MsgBox("wwww")
    'End Sub

    'Private Sub TabControl1_Enter(sender As Object, e As EventArgs) Handles TabControl1.Enter
    '    MsgBox("me the selected tab")
    'End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is TabPageFanParameters Then

            'open fan parameters tab
            Try
                'Dim move_on As Boolean = True
                move_on = True
                ''Yellow()

                'If Not Txtflow.Text.All(AddressOf Char.IsDigit) Then
                '    Txtflow.BackColor = Color.LightYellow
                '    Txtflow.Text = ""
                '    move_on = False
                'ElseIf CDbl(Txtflow.Text) <= 0.0 Then
                '    Txtflow.BackColor = Color.LightYellow
                '    Txtflow.Text = ""
                '    move_on = False
                'Else
                '    Txtflow.BackColor = Color.White
                'End If
                'If Not Txtdens.Text.All(AddressOf Char.IsDigit) Then
                '    Txtdens.BackColor = Color.LightYellow
                '    Txtdens.Text = ""
                '    move_on = False
                'ElseIf CDbl(Txtdens.Text) <= 0.0 Then
                '    Txtdens.BackColor = Color.LightYellow
                '    Txtdens.Text = ""
                '    move_on = False
                'Else
                '    Txtdens.BackColor = Color.White
                'End If
                'If Not Txtfsp.Text.All(AddressOf Char.IsDigit) Then
                '    Txtfsp.BackColor = Color.LightYellow
                '    Txtfsp.Text = ""
                '    move_on = False
                'ElseIf CDbl(Txtfsp.Text) <= 0.0 Then
                '    Txtfsp.BackColor = Color.LightYellow
                '    Txtfsp.Text = ""
                '    move_on = False
                'Else
                '    Txtfsp.BackColor = Color.White
                'End If
                Yellow(Txtflow)
                Yellow(Txtdens)
                Yellow(Txtfsp)
                Yellow(TxtInletPressure, -9999.99)
                Yellow(TxtDesignTemperature, -50.0)
                'Yellow(TxtDischargePressure)
                'Yellow(CmbReserveHead)
                If optDDUserDefined.Checked = True Then
                    Yellow(txtUserDefinedDD)
                Else
                    txtUserDefinedDD.BackColor = Color.White
                End If
                If optDDRatio.Checked = True Then
                    Yellow(txtRatioDD)
                Else
                    txtRatioDD.BackColor = Color.White
                End If

                If move_on = True Then SetupFanParametersPage()

            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub OptStaticPressure_CheckedChanged(sender As Object, e As EventArgs) Handles OptStaticPressure.CheckedChanged
        PresType = 0
    End Sub

    Private Sub OptTotalPressure_CheckedChanged(sender As Object, e As EventArgs) Handles OptTotalPressure.CheckedChanged
        PresType = 1
    End Sub

    Private Sub chkDuct_CheckedChanged(sender As Object, e As EventArgs) Handles chkDuct.CheckedChanged
        'OpenDuctCalcs()
    End Sub


    Private Sub chkOpenInlet_CheckedChanged(sender As Object, e As EventArgs) Handles chkOpenInlet.CheckedChanged
        'OpenDuctCalcs()
    End Sub

    Private Sub chkOpenOutlet_CheckedChanged(sender As Object, e As EventArgs) Handles chkOpenOutlet.CheckedChanged
        'OpenDuctCalcs()
    End Sub


    Private Sub chkDuct_Click(sender As Object, e As EventArgs) Handles chkDuct.Click
        OpenDuctCalcs()

    End Sub

    Private Sub chkOpenInlet_Click(sender As Object, e As EventArgs) Handles chkOpenInlet.Click
        OpenDuctCalcs()
    End Sub

    Private Sub chkOpenOutlet_Click(sender As Object, e As EventArgs) Handles chkOpenOutlet.Click
        OpenDuctCalcs()
    End Sub

    Private Sub chkBrg_Click(sender As Object, e As EventArgs) Handles chkBrg.Click
        OpenDuctCalcs()
    End Sub

    Private Sub chkMotor_Click(sender As Object, e As EventArgs) Handles chkMotor.Click
        OpenDuctCalcs()
    End Sub

    Private Sub txtMotordba_TextChanged(sender As Object, e As EventArgs) Handles txtMotordba.TextChanged
        Dim val As Double
        'If Ctrl.Text.All(AddressOf Char.IsLetter) Then
        If Integer.TryParse(txtMotordba.Text, val) = False Then
            chkMotor.Enabled = False
        ElseIf CInt(txtMotordba.Text) < 0 Then
            chkMotor.Enabled = False
        Else
            chkMotor.Enabled = True
        End If
    End Sub

    Private Sub chkKP_CheckedChanged(sender As Object, e As EventArgs) Handles chkKP.CheckedChanged
        Try
            TabPageSelection_Enter(sender, e)
        Catch ex As Exception

        End Try
    End Sub
End Class

