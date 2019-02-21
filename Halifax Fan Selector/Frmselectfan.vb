Imports System.IO
Imports System.Xml
Imports System.ComponentModel
Imports System.Globalization
'Imports System.ComponentModel
Imports System.Resources
Imports System.Threading
Public Class Frmselectfan
    Public totalcolumnwidth As Integer
    Public ColumnHeader(20) As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.CenterToScreen()
            NewProject = True
            'TabControl1.Controls.Remove(TabPageDuty)
            If StartArg.ToLower.Contains("-b") Then TabControl1.Controls.Remove(TabPageImpeller)
            Me.Text = "Halifax Fan Selection Software" + " - " + version_number
            If StartArg.ToLower.Contains("-dev") Then
                Me.Text = Me.Text.ToUpper()
            End If
            'If StartArg Is Nothing Then
            'If StartArg.ToLower.Contains("-a") Or StartArg.ToLower.Contains("-b") Or UserName.ToLower.Contains("akmci") Then
            'If StartArg.ToLower.Contains("-a") Or StartArg.ToLower.Contains("-b") Or StartArg.ToLower.Contains("-dev") Then
            'Else
            '    TabControl1.Controls.Remove(TabPageNoise)
            '    'TabControl1.Controls.Remove(TabPageSelection)
            '    btnNoiseDataForward.Visible = False
            'End If
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
            ErrorMessage(ex, 20300)
            'MsgBox("load")
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
            ErrorMessage(ex, 20302)
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
            ErrorMessage(ex, 20303)
        End Try
    End Sub

    ' ############################################################################################
    ' Tool Strip Section
    ' ############################################################################################

    Private Sub ProjectDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectDetailsToolStripMenuItem.Click
        Try
            FrmProjectDetails.ShowDialog()
        Catch ex As Exception
            ErrorMessage(ex, 20304)
        End Try
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Try
            NewProject = True
            Initialize(True)
        Catch ex As Exception
            ErrorMessage(ex, 20306)
        End Try
    End Sub

    Private Sub SaveProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveProjectToolStripMenuItem.Click
        Try
            SaveProjectFile()
        Catch ex As Exception
            ErrorMessage(ex, 20307)
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
        Catch ex As Exception
            ErrorMessage(ex, 20308)
        End Try
    End Sub

    Private Sub ExitProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitProjectToolStripMenuItem.Click
        Try
            If FileSaved = False Then
                If MsgBox("Project not saved - do you wish to save your project now?", vbYesNo, "Warning") = vbNo Then
                    End
                End If
            End If
        Catch ex As Exception
            ErrorMessage(ex, 20309)
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
            ErrorMessage(ex, 20310)
        End Try
    End Sub

    Private Sub TabPageDuty_Leave(sender As Object, e As EventArgs) Handles TabPageDuty.Leave
        Try
            Dim str_temp As String
            If CmbReserveHead.SelectedIndex < 0 Then CmbReserveHead.SelectedIndex = 0
            str_temp = CmbReserveHead.Items(CmbReserveHead.SelectedIndex)
            reshead = CDbl(str_temp.Remove(str_temp.Length - 1))
        Catch ex As Exception
            ErrorMessage(ex, 20311)
        End Try
    End Sub

    Private Sub OptDensityCalculated_CheckedChanged(sender As Object, e As EventArgs) Handles OptDensityCalculated.CheckedChanged
        Try
            DensityCalculate()
        Catch ex As Exception
            ErrorMessage(ex, 20312)
        End Try
    End Sub

    ' ############################################################################################
    ' Selection Page
    ' ############################################################################################

    Private Sub TabPageSelection_Leave(sender As Object, e As EventArgs) Handles TabPageSelection.Leave
        Try
            If final.fantype = "" Then
                'e.Cancel = True
                'MsgBox("No fan has been selected 2")
            Else
                'e.Cancel = False
                LblFanDetails.Text = ""
                Label3.Text = ""
            End If
        Catch ex As Exception
            ErrorMessage(ex, 20313)
        End Try
    End Sub

    Private Sub TabPageSelection_Enter(sender As Object, e As EventArgs) Handles TabPageSelection.Enter
        Try
            SetupSelectionPage()
            CenterToScreen()
        Catch ex As Exception
            ErrorMessage(ex, 20314)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Close()
            End
        Catch ex As Exception
            ErrorMessage(ex, 20315)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If (e.RowIndex < 0) Or (e.RowIndex < 0 And e.ColumnIndex < 0) Then
                Exit Sub
            End If
            SelectionClick(e)
        Catch ex As Exception
            ErrorMessage(ex, 20316)
        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try

            If (e.RowIndex < 0) Or (e.RowIndex < 0 And e.ColumnIndex < 0) Then
                    Exit Sub
                End If
                SelectionDoubleClick(e)
        Catch ex As Exception
            ErrorMessage(ex, 20317)
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
            'Dim eg As New System.Windows.Forms.PaintEventArgs
            Dim fnt As Font
            fnt = TxtTypenoise.Font
            Dim myFont As New Font(fnt, fnt.Size)

            Dim textSize As Size

            TxtFlownoise.Text = final.vol.ToString
            TxtPressurenoise.Text = final.fsp.ToString
            TxtSizenoise.Text = final.fansize.ToString
            TxtSpeednoise.Text = final.speed.ToString
            TxtTypenoise.Text = final.fantype
            TxtTypenoise.Width = TxtSpeednoise.Width
            If SelectDIDW = True Then
                TxtTypenoise.Text = TxtTypenoise.Text + " (DIDW)"
                textSize = TextRenderer.MeasureText(TxtTypenoise.Text, myFont)
                TxtTypenoise.Width = textSize.Width
            End If

            For i = 0 To 8
                For j = 0 To 8
                    'TableLayoutPanel1.su
                Next
            Next

            'SetAcousticsGrid()'akm

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
            ErrorMessage(ex, 20318)
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
        Try
            'TabPageGeneral.BackColor = Background_Color
            chkCalcAtmos.Text = "Calculate Atmospheric" + vbCrLf + "Pressure from Altitude"

        Catch ex As Exception
            ErrorMessage(ex, 20319)
        End Try
    End Sub

    Private Sub TabPageImpeller_Enter(sender As Object, e As EventArgs) Handles TabPageImpeller.Enter
        Try
            'TabPageImpeller.BackColor = Background_Color
            TabControl1.Controls.Remove(TabPageGeneral)
            TabControl1.Controls.Remove(TabPageNoise)
            TabControl1.Controls.Remove(TabPageSelection)
            TabControl1.Controls.Remove(TabPageDuty)
            TabControl1.Controls.Remove(TabPageFanParameters)



        Catch ex As Exception
            ErrorMessage(ex, 20320)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            End
        Catch ex As Exception
            ErrorMessage(ex, 20321)
        End Try
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        Try
            Dim PrintPreviewDialog1 As PrintPreviewDialog = New PrintPreviewDialog()
            'PrintPreviewDialog1.InitialDirectory = "c:\Halifax\Projects\"
            'PrintPreviewDialog1.Filter = "Halifax Selection|*.hfs"
            'PrintPreviewDialog1.Title = "Save a Halifax Selection File"
            PrintPreviewDialog1.ShowDialog()
            'SaveFileName = PrintPreviewDialog1.FileName

        Catch ex As Exception
            ErrorMessage(ex, 20322)
        End Try

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        Try
            Dim PrintDialog1 As PrintDialog = New PrintDialog()
            'PrintPreviewDialog1.InitialDirectory = "c:\Halifax\Projects\"
            'PrintPreviewDialog1.Filter = "Halifax Selection|*.hfs"
            'PrintPreviewDialog1.Title = "Save a Halifax Selection File"
            PrintDialog1.ShowDialog()
            'SaveFileName = PrintPreviewDialog1.FileName

        Catch ex As Exception
            ErrorMessage(ex, 20323)
        End Try

    End Sub

    Private Sub btnCalculateDensity_Click(sender As Object, e As EventArgs) Handles btnCalculateDensity.Click
        Try
            FrmDensityCalcs.TextBox1.Text = TxtDesignTemperature.Text
            FrmDensityCalcs.TextBox4.Text = TxtAltitude.Text
            'FrmDensityCalcs.TextBox2.Text = TxtInletPressure.Text
            FrmDensityCalcs.TextBox2.Text = inletpress
            FrmDensityCalcs.TextBox3.Text = TxtHumidity.Text
            FrmDensityCalcs.ShowDialog()
        Catch ex As Exception
            ErrorMessage(ex, 20324)
        End Try
    End Sub

    Private Sub TabPageDuty_Click(sender As Object, e As EventArgs) Handles TabPageDuty.Click
        Try

        Catch ex As Exception
            ErrorMessage(ex, 20325)
        End Try
    End Sub

    Private Sub btnGeneralInformationBack_Click(sender As Object, e As EventArgs) Handles btnGeneralInformationBack.Click
        'open general information tab
        Try
            Flag(1) = False
            Txtflow.BackColor = Color.White
            Txtdens.BackColor = Color.White
            Txtfsp.BackColor = Color.White
            txtUserDefinedDD.BackColor = Color.White
            txtRatioDD.BackColor = Color.White
            TabControl1.SelectTab(TabPageGeneral)
        Catch ex As Exception
            ErrorMessage(ex, 20326)
        End Try
    End Sub

    Private Sub btnFanParametersForward_Click(sender As Object, e As EventArgs) Handles btnFanParametersForward.Click
        'open fan parameters tab
        Try
            Flag(2) = True
            move_on = True
            Yellow(Txtflow)
            'RedBorder(Txtflow)
            Yellow(Txtdens)
            Yellow(Txtfsp)
            Yellow(TxtInletPressure, -9999.99)
            Yellow(TxtDesignTemperature, -50.0)
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

            If move_on = True Then

                flowrate = CDbl(Txtflow.Text)
                If Units(0).UnitSelected = 4 Then
                    flowrate = CDbl(Txtflow.Text) / CDbl(Txtdens.Text)
                End If
                If Units(0).UnitSelected = 5 Then
                    flowrate = CDbl(Txtflow.Text) / (CDbl(Txtdens.Text) * 60)
                End If
                knowndensity = CDbl(Txtdens.Text)
                pressrise = CDbl(Txtfsp.Text)
                inletpress = CDbl(TxtInletPressure.Text)

                dischpress = CDbl(TxtDischargePressure.Text)
                Dim str_temp As String
                If CmbReserveHead.SelectedIndex < 0 Then CmbReserveHead.SelectedIndex = 0
                str_temp = CmbReserveHead.Items(CmbReserveHead.SelectedIndex)

                reshead = CDbl(str_temp.Remove(str_temp.Length - 1))
                SetupFanParametersPage()
            End If

        Catch ex As Exception
            ErrorMessage(ex, 20327)
        End Try
    End Sub

    Private Sub btnDutyInputBack_Click(sender As Object, e As EventArgs) Handles btnDutyInputBack.Click
        'open duty input tab
        Try
            Flag(2) = False
            TabControl1.SelectTab(TabPageDuty)
        Catch ex As Exception
            ErrorMessage(ex, 20328)
        End Try
    End Sub

    Private Sub btnFanSelectionsForward_Click(sender As Object, e As EventArgs) Handles btnFanSelectionsForward.Click
        Try
            Flag(3) = True
            If ChkCurveBlade.Checked = False And ChkInclineBlade.Checked = False And ChkOtherFanType.Checked = False And ChkPlasticFan.Checked = False Then
                MsgBox("Please select at least one fan blade design", vbOKOnly + vbInformation)
                Exit Sub
            End If
            failindex = -1
            'pressrise = CDbl(Txtfsp.Text)
            maxspeed = CDbl(Txtspeedlimit.Text)
            'If Opt2Pole.Checked = True Or Opt4Pole.Checked = True Or Opt6Pole.Checked = True Or Opt8Pole.Checked = True Or Opt10Pole.Checked = True Or Opt12Pole.Checked = True Or OptFixedSpeed.Checked = True Then maxspeed = CDbl(Txtfanspeed.Text)
            If Opt2Pole.Checked = True Or Opt4Pole.Checked = True Or Opt6Pole.Checked = True Or Opt8Pole.Checked = True Or Opt10Pole.Checked = True Or Opt12Pole.Checked = True Then maxspeed = CDbl(Txtfanspeed.Text)
            Txtspeedlimit.Text = maxspeed.ToString

            SelectDIDW = chkDIDW.Checked
            btnNoiseDataForward.Enabled = False

            'ShowCurvedFanTypes = ChkCurveBlade.Checked '300119
            'ShowInclinedFanTypes = ChkInclineBlade.Checked '300119
            'ShowOtherFanTypes = ChkOtherFanType.Checked '300119
            'ShowPlasticFanTypes = ChkPlasticFan.Checked '300119
            'ShowAxialFanTypes = ChkAxialFans.Checked '300119
            'ShowPlenumFanTypes = ChkPlenumFans.Checked '300119
            'ShowOldFanTypes = ChkOldDesignFans.Checked '300119

            TabControl1.SelectTab(TabPageSelection)

        Catch ex As Exception
            ErrorMessage(ex, 20329)
        End Try
    End Sub

    Private Sub btnFanParametersBack_Click(sender As Object, e As EventArgs) Handles btnFanParametersBack.Click
        'open fan parameters tab
        Try
            Flag(3) = False
            TabControl1.SelectTab(TabPageFanParameters)
        Catch ex As Exception
            ErrorMessage(ex, 20330)
        End Try
    End Sub

    Private Sub btnNoiseDataForward_Click(sender As Object, e As EventArgs) Handles btnNoiseDataForward.Click
        'open noise data tab
        Try
            Flag(4) = True
            TabControl1.SelectTab(TabPageNoise)
            If OptStaticPressure.Checked Then
                Label14.Text = "Fan Static Pressure"
            Else
                Label14.Text = "Fan Total Pressure"
            End If
        Catch ex As Exception
            ErrorMessage(ex, 20331)
        End Try
    End Sub

    Private Sub btnFanSelectionsBack_Click(sender As Object, e As EventArgs) Handles btnFanSelectionsBack.Click
        'open fan selections tab
        Try
            Flag(3) = False
            TabControl1.SelectTab(TabPageSelection)

        Catch ex As Exception
            ErrorMessage(ex, 20332)
        End Try
    End Sub

    Private Sub btnSaveProjectForward_Click(sender As Object, e As EventArgs) Handles btnSaveProjectForward.Click
        'open save projects
        Try
            Flag(4) = True
            SaveProjectFile()
        Catch ex As Exception
            ErrorMessage(ex, 20333)
        End Try
    End Sub

    Private Sub GrpFrequency_Enter(sender As Object, e As EventArgs) Handles GrpFrequency.Enter
        Try

        Catch ex As Exception
            ErrorMessage(ex, 20334)
        End Try
    End Sub

    Private Sub Opt2Pole_CheckedChanged_1(sender As Object, e As EventArgs) Handles Opt2Pole.CheckedChanged
        Try
            SetSpeeds(0)

        Catch ex As Exception
            ErrorMessage(ex, 20335)
        End Try
    End Sub

    Private Sub Opt4Pole_CheckedChanged_1(sender As Object, e As EventArgs) Handles Opt4Pole.CheckedChanged
        Try
            SetSpeeds(1)

        Catch ex As Exception
            ErrorMessage(ex, 20336)
        End Try
    End Sub

    Private Sub Opt6Pole_CheckedChanged_1(sender As Object, e As EventArgs) Handles Opt6Pole.CheckedChanged
        Try
            SetSpeeds(2)

        Catch ex As Exception
            ErrorMessage(ex, 20337)
        End Try
    End Sub

    Private Sub Opt8Pole_CheckedChanged_1(sender As Object, e As EventArgs) Handles Opt8Pole.CheckedChanged
        Try
            SetSpeeds(3)

        Catch ex As Exception
            ErrorMessage(ex, 20338)
        End Try
    End Sub

    Private Sub Opt10Pole_CheckedChanged_1(sender As Object, e As EventArgs) Handles Opt10Pole.CheckedChanged
        Try
            SetSpeeds(4)

        Catch ex As Exception
            ErrorMessage(ex, 20339)
        End Try
    End Sub

    Private Sub Opt12Pole_CheckedChanged_1(sender As Object, e As EventArgs) Handles Opt12Pole.CheckedChanged
        Try
            SetSpeeds(5)

        Catch ex As Exception
            ErrorMessage(ex, 20340)
        End Try
    End Sub

    Private Sub OptAnySpeed_CheckedChanged(sender As Object, e As EventArgs) Handles OptAnySpeed.CheckedChanged
        Try
            Txtfanspeed.Text = "0"
            If freqHz = 50 Then Txtspeedlimit.Text = "3000"
            If freqHz = 60 Then Txtspeedlimit.Text = "3600"
        Catch ex As Exception
            ErrorMessage(ex, 20341)
        End Try
    End Sub

    Private Sub OptFixedSpeed_CheckedChanged(sender As Object, e As EventArgs) Handles OptFixedSpeed.CheckedChanged

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
            ErrorMessage(ex, 20342)
        End Try
    End Sub

    Private Sub OptTemperatureF_CheckedChanged(sender As Object, e As EventArgs) Handles OptTemperatureF.CheckedChanged
        Try
            LblAmbientTemperatureUnits.Text = OptTemperatureF.Text

        Catch ex As Exception
            ErrorMessage(ex, 20343)
        End Try
    End Sub

    Private Sub OptAltitudeM_CheckedChanged(sender As Object, e As EventArgs) Handles OptAltitudeM.CheckedChanged
        Try
            LblAltitudeUnits.Text = OptAltitudeM.Text

        Catch ex As Exception
            ErrorMessage(ex, 20344)
        End Try
    End Sub

    Private Sub OptAltitudeFt_CheckedChanged(sender As Object, e As EventArgs) Handles OptAltitudeFt.CheckedChanged
        Try
            LblAltitudeUnits.Text = OptAltitudeFt.Text

        Catch ex As Exception
            ErrorMessage(ex, 20345)
        End Try
    End Sub

    Private Sub OptPressurePa_CheckedChanged(sender As Object, e As EventArgs) Handles OptPressurePa.CheckedChanged
        Try
            LblAtmosphericPressureUnits.Text = OptPressurePa.Text

        Catch ex As Exception
            ErrorMessage(ex, 20346)
        End Try
    End Sub

    Private Sub OptPressuremBar_CheckedChanged(sender As Object, e As EventArgs) Handles OptPressuremBar.CheckedChanged
        Try
            LblAtmosphericPressureUnits.Text = OptPressuremBar.Text
        Catch ex As Exception
            ErrorMessage(ex, 20347)
        End Try

    End Sub

    Private Sub OptPressureinWG_CheckedChanged(sender As Object, e As EventArgs) Handles OptPressureinWG.CheckedChanged
        Try
            LblAtmosphericPressureUnits.Text = OptPressureinWG.Text

        Catch ex As Exception
            ErrorMessage(ex, 20348)
        End Try
    End Sub

    Private Sub OptPressuremmWG_CheckedChanged(sender As Object, e As EventArgs) Handles OptPressuremmWG.CheckedChanged
        Try
            LblAtmosphericPressureUnits.Text = OptPressuremmWG.Text

        Catch ex As Exception
            ErrorMessage(ex, 20349)
        End Try
    End Sub

    Private Sub OptPressurekPa_CheckedChanged(sender As Object, e As EventArgs) Handles OptPressurekPa.CheckedChanged
        Try
            LblAtmosphericPressureUnits.Text = OptPressurekPa.Text

        Catch ex As Exception
            ErrorMessage(ex, 20350)
        End Try
    End Sub

    Private Sub btnMetricUnits_Click(sender As Object, e As EventArgs) Handles btnMetricUnits.Click
        Try
            MetricUnits()
        Catch ex As Exception
            ErrorMessage(ex, 20351)
        End Try
    End Sub

    Private Sub btnImperialUnits_Click(sender As Object, e As EventArgs) Handles btnImperialUnits.Click
        Try
            ImperialUnits()
        Catch ex As Exception
            ErrorMessage(ex, 20352)
        End Try
    End Sub

    Private Sub btnDutyInputForward_Click(sender As Object, e As EventArgs) Handles btnDutyInputForward.Click
        'open duty input tab
        'Dim asdf As String = "test"
        Try
            move_on = True
            Flag(1) = True
            Yellow(TxtAmbientTemperature, -20)
            Yellow(TxtAltitude, -100)
            Yellow(TxtHumidity, -0.01)
            Yellow(TxtAtmosphericPressure)

            If move_on = True Then
                'aa = 0 / asdf
                SetUnitValues()
                If Opt50Hz.Checked = True Then freqHz = 50
                If Opt60Hz.Checked = True Then freqHz = 60
                CalcAtmos = chkCalcAtmos.Checked
                Opt2Pole.Visible = True
                Opt4Pole.Visible = True
                Opt6Pole.Visible = True
                Opt8Pole.Visible = True
                Opt10Pole.Visible = True
                Opt12Pole.Visible = True
                'If StartArg.ToLower.Contains("-dev") Then
                'Else
                '    Opt2Pole.Enabled = False
                '    Opt4Pole.Enabled = False
                '    Opt6Pole.Enabled = False
                '    Opt8Pole.Enabled = False
                '    Opt10Pole.Enabled = False
                '    Opt12Pole.Enabled = False
                '    OptFixedSize.Enabled = False
                '    Txtfanspeed.Enabled = False
                '    Txtfansize.Enabled = False
                'End If

                'TabControl1.Controls.Add(TabPageDuty)

                TabControl1.SelectTab(TabPageDuty)
            End If

        Catch ex As Exception
            'ErrorMessage(ex, 2000)
            ErrorMessage(ex, 20353)
        End Try
    End Sub

    Private Sub btnNoiseExit_Click(sender As Object, e As EventArgs) Handles btnNoiseExit.Click
        Try
            'objStreamWriterDebug.Close()
            End
        Catch ex As Exception
            ErrorMessage(ex, 20354)
        End Try
    End Sub

    Private Sub btnSelectionsExit_Click(sender As Object, e As EventArgs) Handles btnSelectionsExit.Click
        Try
            'objStreamWriterDebug.Close()
            End
        Catch ex As Exception
            ErrorMessage(ex, 20355)
        End Try
    End Sub

    Private Sub btnParametersExit_Click(sender As Object, e As EventArgs) Handles btnParametersExit.Click
        Try
            End
        Catch ex As Exception
            ErrorMessage(ex, 20356)
        End Try
    End Sub

    Private Sub btnGeneralExit_Click(sender As Object, e As EventArgs) Handles btnGeneralExit.Click
        Try
            End
        Catch ex As Exception
            ErrorMessage(ex, 20357)
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
            ErrorMessage(ex, 20358)
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
            ErrorMessage(ex, 20359)
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
            ErrorMessage(ex, 20360)
        End Try
    End Sub

    Private Sub chkDisplayAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkDisplayAll.CheckedChanged
        Try
            failindex = -1
            TabPageSelection_Enter(sender, e)
        Catch ex As Exception
            ErrorMessage(ex, 20361)
        End Try
    End Sub

    Private Sub chkDisplayLowerEff_CheckedChanged(sender As Object, e As EventArgs) Handles chkDisplayLowerEff.CheckedChanged
        Try
            failindex = -1
            TabPageSelection_Enter(sender, e)
        Catch ex As Exception
            ErrorMessage(ex, 20362)
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
                ErrorMessage(ex, 20363)
            End Try

        End If

    End Sub

    Private Sub OptStaticPressure_CheckedChanged(sender As Object, e As EventArgs) Handles OptStaticPressure.CheckedChanged
        Try
            PresType = 0

        Catch ex As Exception
            ErrorMessage(ex, 20364)
        End Try
    End Sub

    Private Sub OptTotalPressure_CheckedChanged(sender As Object, e As EventArgs) Handles OptTotalPressure.CheckedChanged
        Try
            PresType = 1

        Catch ex As Exception
            ErrorMessage(ex, 20365)
        End Try
    End Sub

    Private Sub chkDuct_CheckedChanged(sender As Object, e As EventArgs) Handles chkDuct.CheckedChanged
        Try
            'OpenDuctCalcs()

        Catch ex As Exception
            ErrorMessage(ex, 20366)
        End Try
    End Sub


    Private Sub chkOpenInlet_CheckedChanged(sender As Object, e As EventArgs) Handles chkOpenInlet.CheckedChanged
        Try
            'OpenDuctCalcs()

        Catch ex As Exception
            ErrorMessage(ex, 20367)
        End Try
    End Sub

    Private Sub chkOpenOutlet_CheckedChanged(sender As Object, e As EventArgs) Handles chkOpenOutlet.CheckedChanged
        Try
            'OpenDuctCalcs()

        Catch ex As Exception
            ErrorMessage(ex, 20368)
        End Try
    End Sub


    Private Sub chkDuct_Click(sender As Object, e As EventArgs) Handles chkDuct.Click
        Try
            OpenDuctCalcs()

        Catch ex As Exception
            ErrorMessage(ex, 20369)
        End Try


    End Sub

    Private Sub chkOpenInlet_Click(sender As Object, e As EventArgs) Handles chkOpenInlet.Click
        Try
            OpenDuctCalcs()

        Catch ex As Exception
            ErrorMessage(ex, 20370)
        End Try
    End Sub

    Private Sub chkOpenOutlet_Click(sender As Object, e As EventArgs) Handles chkOpenOutlet.Click
        Try
            OpenDuctCalcs()

        Catch ex As Exception
            ErrorMessage(ex, 20371)
        End Try

    End Sub

    Private Sub chkBrg_Click(sender As Object, e As EventArgs) Handles chkBrg.Click
        Try
            OpenDuctCalcs()

        Catch ex As Exception
            ErrorMessage(ex, 20372)
        End Try

    End Sub

    Private Sub chkMotor_Click(sender As Object, e As EventArgs) Handles chkMotor.Click
        Try
            OpenDuctCalcs()

        Catch ex As Exception
            ErrorMessage(ex, 20373)
        End Try

    End Sub

    Private Sub txtMotordba_TextChanged(sender As Object, e As EventArgs) Handles txtMotordba.TextChanged
        Try
            Dim val As Double
            'If Ctrl.Text.All(AddressOf Char.IsLetter) Then
            If Integer.TryParse(txtMotordba.Text, val) = False Then
                chkMotor.Enabled = False
                chkMotor.Checked = False
            ElseIf CInt(txtMotordba.Text) < 0 Then
                chkMotor.Enabled = False
                chkMotor.Checked = False
            Else
                chkMotor.Enabled = True
                chkMotor.Checked = True
            End If
            OpenDuctCalcs()
        Catch ex As Exception
            ErrorMessage(ex, 20374)
        End Try
    End Sub

    Private Sub chkKP_CheckedChanged(sender As Object, e As EventArgs) Handles chkKP.CheckedChanged
        Try
            TabPageSelection_Enter(sender, e)
        Catch ex As Exception
            ErrorMessage(ex, 20375)
        End Try
    End Sub

    'Private Sub TxtAltitude_LostFocus(sender As Object, e As EventArgs) Handles TxtAltitude.LostFocus
    '    Dim p As Double
    '    Dim h As Double = CDbl(TxtAltitude.Text)
    '    p = 101325 * (1 - (h * 2.25577 * 10 ^ -5)) ^ 5.25588
    '    TxtAtmosphericPressure.Text = Math.Round(p).ToString
    'End Sub

    Private Sub TxtAltitude_TextChanged(sender As Object, e As EventArgs) Handles TxtAltitude.TextChanged
        Dim p As Double
        Dim h As Double
        Try
            If chkCalcAtmos.Checked = True Then
                h = CDbl(TxtAltitude.Text)
                p = 101325 * (1 - (h * 2.25577 * 10 ^ -5)) ^ 5.25588
                TxtAtmosphericPressure.Text = Math.Round(p).ToString
                Yellow(TxtAltitude, -100)
            End If
        Catch ex As Exception
            Yellow(TxtAltitude, -100)
        End Try
    End Sub

    Private Sub chkCalcAtmos_Click(sender As Object, e As EventArgs) Handles chkCalcAtmos.Click
        Dim p As Double
        Dim h As Double
        If chkCalcAtmos.Checked = True Then
            h = CDbl(TxtAltitude.Text)
            p = 101325 * (1 - (h * 2.25577 * 10 ^ -5)) ^ 5.25588
            TxtAtmosphericPressure.Text = Math.Round(p).ToString
            TxtAtmosphericPressure.Enabled = False
        Else
            TxtAtmosphericPressure.Enabled = True
        End If
    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick

        'Select Right Clicked Row if its not the header row
        Try
            If e.Button = MouseButtons.Right And failindex > -1 Then
                FrmDisplayRejects.Show()
            End If

        Catch ex As Exception
            ErrorMessage(ex, 20376)
        End Try
    End Sub

    Private Sub chkAllBlades_CheckedChanged(sender As Object, e As EventArgs) Handles chkAllBlades.CheckedChanged
        Try
            If chkAllBlades.Checked = True Then
                ChkCurveBlade.Checked = True
                ChkInclineBlade.Checked = True
                ChkOtherFanType.Checked = True
                ChkPlasticFan.Checked = True
            Else
                ChkCurveBlade.Checked = False
            ChkInclineBlade.Checked = False
            ChkOtherFanType.Checked = False
            ChkPlasticFan.Checked = False
        End If

        Catch ex As Exception
            ErrorMessage(ex, 20377)
        End Try
    End Sub

    Private Sub EnglishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnglishToolStripMenuItem.Click
        Try
            ChosenLanguage = "en-US"
            ApplyLocale(ChosenLanguage)

            'reload()
            'Form1_Load(Me, Nothing)
            'Me.Refresh()

        Catch ex As Exception
            ErrorMessage(ex, 20378)
        End Try
    End Sub

    Private Sub ChineseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChineseToolStripMenuItem.Click
        Try
            ChosenLanguage = "zh-CN"
            ApplyLocale(ChosenLanguage)
            'reload()
            'Form1_Load(Me, Nothing)
            'Me.Refresh()

        Catch ex As Exception
            ErrorMessage(ex, 20379)
        End Try
    End Sub
    Private Sub ApplyLocale(ByVal locale_name As String)
        Try
            Dim culture_info As New CultureInfo(locale_name)
            Dim component_resource_manager As New ComponentResourceManager(Me.GetType)

            Thread.CurrentThread.CurrentUICulture = culture_info
            Thread.CurrentThread.CurrentCulture = culture_info

            component_resource_manager.ApplyResources(Me, "$this", culture_info)
            For Each ctl As Control In Me.Controls
                ApplyLocaleToControl(ctl, component_resource_manager, culture_info)
            Next ctl
            Dim resource_manager As New ResourceManager("Localized.FrmSelectFan", Me.GetType.Assembly)
        Catch ex As Exception
            ErrorMessage(ex, 20380)
        End Try
    End Sub

    Private Sub ApplyLocaleToControl(ByVal ctl As Control, ByVal component_resource_manager As ComponentResourceManager, ByVal culture_info As CultureInfo)
        Try
            component_resource_manager.ApplyResources(ctl, ctl.Name, culture_info)
            For Each child As Control In ctl.Controls
                ApplyLocaleToControl(child, component_resource_manager, culture_info)
            Next child
        Catch ex As Exception
            ErrorMessage(ex, 20381)
        End Try
    End Sub

    'Private Sub LblAmbientTemperature_Click(sender As Object, e As EventArgs) Handles LblAmbientTemperature.Click

    'End Sub

    'Private Sub OptAnySize_CheckedChanged(sender As Object, e As EventArgs) Handles OptAnySize.CheckedChanged

    'End Sub

    Private Sub OptAnySize_Click(sender As Object, e As EventArgs) Handles OptAnySize.Click
        Try
            Txtfansize.Text = "0"
        Catch ex As Exception
            ErrorMessage(ex, 20391)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    'Private Sub Frmselectfan_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

    '    Dim g As Graphics = e.Graphics
    '    Dim p As New Pen(Color.Green, 20)
    '    g.DrawRectangle(p, TxtAltitude.Left, TxtAltitude.Top, TxtAltitude.Width, TxtAltitude.Height)

    'End Sub

    'Private Sub TxtAmbientTemperature_TextChanged(sender As Object, e As EventArgs) Handles TxtAmbientTemperature.TextChanged
    '    Yellow(TxtAmbientTemperature, -20)
    'End Sub

    ''Private Sub TxtHumidity_TextChanged(sender As Object, e As EventArgs) Handles TxtHumidity.TextChanged
    ''    Yellow(TxtHumidity, 0)
    ''End Sub

    'Private Sub TxtAtmosphericPressure_TextChanged(sender As Object, e As EventArgs) Handles TxtAtmosphericPressure.TextChanged
    '    Yellow(TxtAtmosphericPressure, 0)
    'End Sub
End Class

