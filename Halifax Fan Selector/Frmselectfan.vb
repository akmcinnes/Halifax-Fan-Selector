Imports System.ComponentModel
Imports System.Globalization
Imports System.Resources
Imports System.Threading
Public Class Frmselectfan
    Public Thread As Threading.Thread

    Public totalcolumnwidth As Integer
    Public ColumnHeader(20) As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.CenterToScreen()
            FullFilePathtxt = OutputPathDefault + "Fan Output.txt"
            NewProject = True
            Me.Text = Me.Text + " - " + version_number
            If StartArg.ToLower.Contains("-dev") Then
                PrintToolStripMenuItem.Enabled = True
                Me.Text = Me.Text.ToUpper()
            End If
            DefaultHeader = Me.Text

            If version_number = "V 1.0.0 Beta" Then
                TabControl1.Controls.Remove(TabPageNoise)
                TabControl1.Controls.Remove(TabPageSelection)
                btnFanSelectionsForward.Visible = False
            End If
            If AdvancedUser = False Then
                btnCalculateDensity.Visible = False
                OptDensityCalculated.Visible = False
                OptDensityKnown.Visible = False
                GroupBox1.Visible = False
            End If
            If StartArg.ToLower.Contains("-dev") Then
                optDDUserDefined.Enabled = True
                optDDRatio.Enabled = True
                txtUserDefinedDD.Enabled = True
                txtRatioDD.Enabled = True
            End If
            txtUserDefinedDD.Enabled = False
            txtRatioDD.Enabled = False
            lblUserDefinedUnits.Enabled = False
            lblpercent.Enabled = False
            txtUserDefinedDD.Text = ""
            txtRatioDD.Text = ""
            Initialize(True)
            chkCalcAtmos.Text = lblChkAtmosAlt.Text
            OptPowerBoth.Text = lblDisplayBoth.Text
            If ChosenLanguage.Contains("zh") Then
                ToolStripSeparator1.Visible = True
                AllPages2ToolStripMenuItem.Visible = True
                PerformanceDetails2ToolStripMenuItem.Visible = True
                AcousticDetails2ToolStripMenuItem.Visible = True
                FanCurve2ToolStripMenuItem.Visible = True
            End If
        Catch ex As Exception
            ErrorMessage(ex, 20301)
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
                br = New SolidBrush(Color.Transparent) ' Change this to your preference
                g.FillRectangle(br, e.Bounds)
                br = New SolidBrush(Color.Black)
                g.DrawString(strTitle, TabControl1.Font, br, r, sf)
            End If
        Catch ex As Exception
            ErrorMessage(ex, 20302)
        End Try
    End Sub

    Private Sub btnDutyExit_Click(sender As Object, e As EventArgs) Handles btnDutyExit.Click
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
            ErrorMessage(ex, 20305)
        End Try
    End Sub

    Private Sub SaveProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveProjectToolStripMenuItem.Click
        Try
            SaveProjectFile(True)
        Catch ex As Exception
            ErrorMessage(ex, 20306)
        End Try
    End Sub

    Private Sub OpenProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenProjectToolStripMenuItem.Click
        Try
            ReadFromProjectFile = False
            Dim OpenFileDialog1 As OpenFileDialog = New OpenFileDialog()
            OpenFileDialog1.InitialDirectory = ProjectPathDefault
            OpenFileDialog1.Filter = "Halifax files (*.hfs)|*.hfs|All files (*.*)|*.*"
            OpenFileDialog1.ShowDialog()
            OpenFileName = OpenFileDialog1.FileName
            If OpenFileName = "" Then Exit Sub
            ReadProjectFile(OpenFileName)
            OpenFromToolStrip = True

            'Me.Text = DefaultHeader + " (" + OpenFileDialog1.SafeFileName + " Selected)"
            Me.Text = DefaultHeader + " (" + OpenFileDialog1.SafeFileName + " " + lang_dict(1, 31) + ")"
        Catch ex As Exception
            ErrorMessage(ex, 20307)
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
            ErrorMessage(ex, 20308)
        End Try
    End Sub

    ' ############################################################################################
    ' Duty Page
    ' ############################################################################################

    Private Sub TabPageDuty_Enter(sender As Object, e As EventArgs) Handles TabPageDuty.Enter
        Try
            SetupDutyPage()
        Catch ex As Exception
            ErrorMessage(ex, 20309)
        End Try
    End Sub

    Private Sub TabPageDuty_Leave(sender As Object, e As EventArgs) Handles TabPageDuty.Leave
        Try
            Dim str_temp As String
            If CmbReserveHead.SelectedIndex < 0 Then CmbReserveHead.SelectedIndex = 0
            str_temp = CmbReserveHead.Items(CmbReserveHead.SelectedIndex)
            reshead = CDbl(str_temp.Remove(str_temp.Length - 1))
        Catch ex As Exception
            ErrorMessage(ex, 20310)
        End Try
    End Sub

    Private Sub OptDensityCalculated_CheckedChanged(sender As Object, e As EventArgs) Handles OptDensityCalculated.CheckedChanged
        Try
            DensityCalculate()
        Catch ex As Exception
            ErrorMessage(ex, 20311)
        End Try
    End Sub

    ' ############################################################################################
    ' Selection Page
    ' ############################################################################################

    Private Sub TabPageSelection_Leave(sender As Object, e As EventArgs) Handles TabPageSelection.Leave
        Try
            If Not final.fantype = "" Then
                LblFanDetails.Text = ""
                Label3.Visible = False
            End If
        Catch ex As Exception
            ErrorMessage(ex, 20312)
        End Try
    End Sub

    Private Sub TabPageSelection_Enter(sender As Object, e As EventArgs) Handles TabPageSelection.Enter
        Try
            Flag(3) = True
            'If StartArg.ToLower.Contains("-dev") Or StartArg.ToLower.Contains("-b1") Then Label13.Visible = True
            '#If DEBUG Then
            '            Label13.Visible = True
            '#End If
            If chkWide.Checked = False And
                chkMedium.Checked = False And
                chkNarrow.Checked = False And
                chkHighPressure.Checked = False And
                ChkCurveBlade.Checked = False And
                ChkInclineBlade.Checked = False And
                ChkOtherFanType.Checked = False And
                ChkPlasticFan.Checked = False And
                chkPaddleBlade.Checked = False And
                chkRadialBlade.Checked = False Then
                MsgBox(Label21.Text, vbOKOnly + vbInformation, "")
                Exit Sub
            End If
            failindex = -1
            maxspeed = CDbl(Txtspeedlimit.Text)
            If Opt2Pole.Checked = True Or Opt4Pole.Checked = True Or Opt6Pole.Checked = True Or Opt8Pole.Checked = True Or Opt10Pole.Checked = True Or Opt12Pole.Checked = True Then maxspeed = CDbl(Txtfanspeed.Text)
            Txtspeedlimit.Text = maxspeed.ToString

            SelectDIDW = chkDIDW.Checked
            btnNoiseDataForward.Enabled = False
            SetupSelectionPage()
            CenterToScreen()
        Catch ex As Exception
            ErrorMessage(ex, 20313)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Close()
            End
        Catch ex As Exception
            ErrorMessage(ex, 20314)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If (e.RowIndex < 0) Or (e.RowIndex < 0 And e.ColumnIndex < 0) Then
                Exit Sub
            End If
            SelectionClick(e)
        Catch ex As Exception
            ErrorMessage(ex, 20315)
        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try

            If (e.RowIndex < 0) Or (e.RowIndex < 0 And e.ColumnIndex < 0) Then
                Exit Sub
            End If
            SelectionDoubleClick(e)
        Catch ex As Exception
            ErrorMessage(ex, 20316)
        End Try

    End Sub

    ' ############################################################################################
    ' Noise Page
    ' ############################################################################################

    Private Sub TabPageNoise_Enter(sender As Object, e As EventArgs) Handles TabPageNoise.Enter
        Try
            Dim fnt As Font
            fnt = TxtTypenoise.Font
            Dim myFont As New Font(fnt, fnt.Size)

            Dim textSize As Size

            TxtFlownoise.Text = final.vol.ToString
            TxtStaticPressurenoise.Text = final.fsp.ToString
            TxtTotalPressurenoise.Text = final.ftp.ToString
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
                Next
            Next
            ConvUnits()
            OpenDuctCalcs()
        Catch ex As Exception
            ErrorMessage(ex, 20317)
        End Try
    End Sub

    Private Sub TabPageGeneral_Enter(sender As Object, e As EventArgs) Handles TabPageGeneral.Enter
        Try
            If ChosenLanguage.Contains("zh") Then
                chkCalcAtmos.Text = lblChkAtmosAlt.Text
            Else
                chkCalcAtmos.Text = "Calculate Atmospheric" + vbCrLf + "Pressure from Altitude"
            End If
        Catch ex As Exception
            ErrorMessage(ex, 20318)
        End Try
    End Sub

    Private Sub TabPageImpeller_Enter(sender As Object, e As EventArgs) Handles TabPageImpeller.Enter
        Try
            'TabPageImpeller.BackColor = Background_Color
            'TabControl1.Controls.Remove(TabPageGeneral)
            'TabControl1.Controls.Remove(TabPageNoise)
            'TabControl1.Controls.Remove(TabPageSelection)
            'TabControl1.Controls.Remove(TabPageDuty)
            'TabControl1.Controls.Remove(TabPageFanParameters)
        Catch ex As Exception
            ErrorMessage(ex, 20319)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            End
        Catch ex As Exception
            ErrorMessage(ex, 20320)
        End Try
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            Dim PrintPreviewDialog1 As PrintPreviewDialog = New PrintPreviewDialog()
            PrintPreviewDialog1.ShowDialog()
        Catch ex As Exception
            ErrorMessage(ex, 20321)
        End Try
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        'Try
        '    If OpenFileName = "" And SaveFileName = "" Then
        '        MsgBox(lblSaveProject.Text, vbOKOnly + vbInformation, "")
        '        Exit Sub
        '    End If
        '    Dim PrintDialog1 As PrintDialog = New PrintDialog()
        '    PrintDialog1.ShowDialog()
        'Catch ex As Exception
        '    ErrorMessage(ex, 20322)
        'End Try
    End Sub

    Private Sub btnCalculateDensity_Click(sender As Object, e As EventArgs) Handles btnCalculateDensity.Click
        Try
            FrmDensityCalcs.TextBox1.Text = TxtDesignTemperature.Text
            FrmDensityCalcs.TextBox4.Text = TxtAltitude.Text
            FrmDensityCalcs.TextBox2.Text = inletpress
            FrmDensityCalcs.TextBox3.Text = TxtHumidity.Text
            FrmDensityCalcs.ShowDialog()
        Catch ex As Exception
            ErrorMessage(ex, 20323)
        End Try
    End Sub

    Private Sub TabPageDuty_Click(sender As Object, e As EventArgs) Handles TabPageDuty.Click
        Try
        Catch ex As Exception
            ErrorMessage(ex, 20324)
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
            TxtAmbientTemperature.Text = ambienttemp.ToString
            TxtAltitude.Text = altitude.ToString
            TxtHumidity.Text = humidity.ToString
            TxtAtmosphericPressure.Text = atmospress.ToString
            If freqHz = 50 Then Opt50Hz.Checked = True
            If freqHz = 60 Then Opt60Hz.Checked = True
            chkCalcAtmos.Checked = CalcAtmos
            TabControl1.SelectTab(TabPageGeneral)
        Catch ex As Exception
            ErrorMessage(ex, 20325)
        End Try
    End Sub

    Private Sub btnFanParametersForward_Click(sender As Object, e As EventArgs) Handles btnFanParametersForward.Click
        'open fan parameters tab
        Try
            Flag(2) = True
            move_on = True
            Yellow(Txtflow)
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

                designtemp = CDbl(TxtDesignTemperature.Text)
                knowndensity = CDbl(Txtdens.Text)
                pressrise = CDbl(Txtfsp.Text)
                inletpress = CDbl(TxtInletPressure.Text)
                DDInputArea = 0.0
                DDInputRatio = 0.0
                If Not txtRatioDD.Text = "" Then DDInputRatio = CDbl(txtRatioDD.Text)
                If Not txtUserDefinedDD.Text = "" Then DDInputArea = CDbl(txtUserDefinedDD.Text)
                dischpress = CDbl(TxtDischargePressure.Text)
                Dim str_temp As String
                If CmbReserveHead.SelectedIndex < 0 Then CmbReserveHead.SelectedIndex = 0
                str_temp = CmbReserveHead.Items(CmbReserveHead.SelectedIndex)

                reshead = CDbl(str_temp.Remove(str_temp.Length - 1))
                SetupFanParametersPage()
            End If

        Catch ex As Exception
            ErrorMessage(ex, 20326)
        End Try
    End Sub

    Private Sub btnDutyInputBack_Click(sender As Object, e As EventArgs) Handles btnDutyInputBack.Click
        'open duty input tab
        Try
            Flag(2) = False
            TabControl1.SelectTab(TabPageDuty)
        Catch ex As Exception
            ErrorMessage(ex, 20327)
        End Try
    End Sub

    Private Sub btnFanSelectionsForward_Click(sender As Object, e As EventArgs) Handles btnFanSelectionsForward.Click
        Try
            Flag(3) = True
            If chkWide.Checked = False And
                chkMedium.Checked = False And
                chkNarrow.Checked = False And
                chkHighPressure.Checked = False And
                ChkCurveBlade.Checked = False And
                ChkInclineBlade.Checked = False And
                ChkOtherFanType.Checked = False And
                ChkPlasticFan.Checked = False And
                chkPaddleBlade.Checked = False And
                chkRadialBlade.Checked = False Then
                MsgBox(Label21.Text, vbOKOnly + vbInformation, "")
                Exit Sub
            End If
            If AdvancedUser = True Then
                chkDisplayAllResHead.Checked = True
                chkDisplayLowerEff.Checked = True
            End If
            failindex = -1
            maxspeed = CDbl(Txtspeedlimit.Text)
            If Opt2Pole.Checked = True Or Opt4Pole.Checked = True Or Opt6Pole.Checked = True Or Opt8Pole.Checked = True Or Opt10Pole.Checked = True Or Opt12Pole.Checked = True Then maxspeed = CDbl(Txtfanspeed.Text)
            Txtspeedlimit.Text = maxspeed.ToString

            SelectDIDW = chkDIDW.Checked
            btnNoiseDataForward.Enabled = False

            TabControl1.SelectTab(TabPageSelection)

        Catch ex As Exception
            ErrorMessage(ex, 20328)
        End Try
    End Sub

    Private Sub btnFanParametersBack_Click(sender As Object, e As EventArgs) Handles btnFanParametersBack.Click
        'open fan parameters tab
        Try
            Flag(3) = False
            TabControl1.SelectTab(TabPageFanParameters)
        Catch ex As Exception
            ErrorMessage(ex, 20329)
        End Try
    End Sub

    Private Sub btnNoiseDataForward_Click(sender As Object, e As EventArgs) Handles btnNoiseDataForward.Click
        'open noise data tab
        Try
            Flag(4) = True
            TabControl1.SelectTab(TabPageNoise)
        Catch ex As Exception
            ErrorMessage(ex, 20330)
        End Try
    End Sub

    Private Sub btnFanSelectionsBack_Click(sender As Object, e As EventArgs) Handles btnFanSelectionsBack.Click
        'open fan selections tab
        Try
            Flag(3) = False
            failindex = -1
            TabControl1.SelectTab(TabPageSelection)
        Catch ex As Exception
            ErrorMessage(ex, 20331)
        End Try
    End Sub

    Private Sub btnImpellerDetailsForward_Click(sender As Object, e As EventArgs) Handles btnImpellerDetailsForward.Click
        Try
            Flag(5) = True
            TabControl1.SelectTab(TabPageImpeller)
        Catch ex As Exception
            ErrorMessage(ex, 20332)
        End Try
    End Sub

    Private Sub GrpFrequency_Enter(sender As Object, e As EventArgs) Handles GrpFrequency.Enter
        Try
        Catch ex As Exception
            ErrorMessage(ex, 20333)
        End Try
    End Sub

    Private Sub Opt2Pole_CheckedChanged_1(sender As Object, e As EventArgs) Handles Opt2Pole.CheckedChanged
        Try
            SetSpeeds(0)
            Txtspeedlimit.Enabled = False
            Txtfanspeed.Enabled = False
        Catch ex As Exception
            ErrorMessage(ex, 20334)
        End Try
    End Sub

    Private Sub Opt4Pole_CheckedChanged_1(sender As Object, e As EventArgs) Handles Opt4Pole.CheckedChanged
        Try
            SetSpeeds(1)
            Txtspeedlimit.Enabled = False
            Txtfanspeed.Enabled = False
        Catch ex As Exception
            ErrorMessage(ex, 20335)
        End Try
    End Sub

    Private Sub Opt6Pole_CheckedChanged_1(sender As Object, e As EventArgs) Handles Opt6Pole.CheckedChanged
        Try
            SetSpeeds(2)
            Txtspeedlimit.Enabled = False
            Txtfanspeed.Enabled = False
        Catch ex As Exception
            ErrorMessage(ex, 20336)
        End Try
    End Sub

    Private Sub Opt8Pole_CheckedChanged_1(sender As Object, e As EventArgs) Handles Opt8Pole.CheckedChanged
        Try
            SetSpeeds(3)
            Txtspeedlimit.Enabled = False
            Txtfanspeed.Enabled = False
        Catch ex As Exception
            ErrorMessage(ex, 20337)
        End Try
    End Sub

    Private Sub Opt10Pole_CheckedChanged_1(sender As Object, e As EventArgs) Handles Opt10Pole.CheckedChanged
        Try
            SetSpeeds(4)
            Txtspeedlimit.Enabled = False
            Txtfanspeed.Enabled = False
        Catch ex As Exception
            ErrorMessage(ex, 20338)
        End Try
    End Sub

    Private Sub Opt12Pole_CheckedChanged_1(sender As Object, e As EventArgs) Handles Opt12Pole.CheckedChanged
        Try
            SetSpeeds(5)
            Txtspeedlimit.Enabled = False
            Txtfanspeed.Enabled = False
        Catch ex As Exception
            ErrorMessage(ex, 20339)
        End Try
    End Sub

    Private Sub OptAnySpeed_CheckedChanged(sender As Object, e As EventArgs) Handles OptAnySpeed.CheckedChanged
        Try
            Txtfanspeed.Text = "0"
            If freqHz = 50 Then Txtspeedlimit.Text = "3600" '"3000"
            If freqHz = 60 Then Txtspeedlimit.Text = "4320" '"3600"
            Txtspeedlimit.Enabled = False
            Txtfanspeed.Enabled = False
        Catch ex As Exception
            ErrorMessage(ex, 20340)
        End Try
    End Sub

    Private Sub OptFixedSpeed_CheckedChanged(sender As Object, e As EventArgs) Handles OptFixedSpeed.CheckedChanged
        Try
            Txtspeedlimit.Enabled = False
            Txtfanspeed.Enabled = True
        Catch ex As Exception
            ErrorMessage(ex, 20341)
        End Try
    End Sub

    '###############################################################################################################
    '######################################### General Details and Units Selection #################################
    '###############################################################################################################

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
            CalcAtmosFromAlt()
        Catch ex As Exception
            ErrorMessage(ex, 20346)
        End Try
    End Sub

    Private Sub OptPressuremBar_CheckedChanged(sender As Object, e As EventArgs) Handles OptPressuremBar.CheckedChanged
        Try
            LblAtmosphericPressureUnits.Text = OptPressuremBar.Text
            CalcAtmosFromAlt()
        Catch ex As Exception
            ErrorMessage(ex, 20347)
        End Try

    End Sub

    Private Sub OptPressureinWG_CheckedChanged(sender As Object, e As EventArgs) Handles OptPressureinWG.CheckedChanged
        Try
            LblAtmosphericPressureUnits.Text = OptPressureinWG.Text
            CalcAtmosFromAlt()
        Catch ex As Exception
            ErrorMessage(ex, 20348)
        End Try
    End Sub

    Private Sub OptPressuremmWG_CheckedChanged(sender As Object, e As EventArgs) Handles OptPressuremmWG.CheckedChanged
        Try
            LblAtmosphericPressureUnits.Text = OptPressuremmWG.Text
            CalcAtmosFromAlt()
        Catch ex As Exception
            ErrorMessage(ex, 20349)
        End Try
    End Sub

    Private Sub OptPressurekPa_CheckedChanged(sender As Object, e As EventArgs) Handles OptPressurekPa.CheckedChanged
        Try
            LblAtmosphericPressureUnits.Text = OptPressurekPa.Text
            CalcAtmosFromAlt()
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
        Try
            move_on = True
            Flag(1) = True
            Yellow(TxtAmbientTemperature, -20)
            Yellow(TxtAltitude, -100)
            Yellow(TxtHumidity, -0.01)
            Yellow(TxtAtmosphericPressure)

            If move_on = True Then
                'SetUnitValues()
                ambienttemp = CDbl(TxtAmbientTemperature.Text)
                altitude = CDbl(TxtAltitude.Text)
                humidity = CDbl(TxtHumidity.Text)
                atmospress = CDbl(TxtAtmosphericPressure.Text)
                If Opt50Hz.Checked = True Then freqHz = 50
                If Opt60Hz.Checked = True Then freqHz = 60
                CalcAtmos = chkCalcAtmos.Checked
                Opt2Pole.Visible = True
                Opt4Pole.Visible = True
                Opt6Pole.Visible = True
                Opt8Pole.Visible = True
                Opt10Pole.Visible = True
                Opt12Pole.Visible = True
                TabControl1.SelectTab(TabPageDuty)
                If CDbl(Txtdens.Text) > 0.0 Then

                End If
                OpenFromToolStrip = False
            End If
        Catch ex As Exception
            ErrorMessage(ex, 20353)
        End Try
    End Sub

    Private Sub btnNoiseExit_Click(sender As Object, e As EventArgs) Handles btnNoiseExit.Click
        Try
            End
        Catch ex As Exception
            ErrorMessage(ex, 20354)
        End Try
    End Sub

    Private Sub btnSelectionsExit_Click(sender As Object, e As EventArgs) Handles btnSelectionsExit.Click
        Try
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
            txtUserDefinedDD.Enabled = False
            txtRatioDD.Enabled = False
            lblUserDefinedUnits.Enabled = False
            lblpercent.Enabled = False
            txtUserDefinedDD.Text = ""
            txtRatioDD.Text = ""
        Catch ex As Exception
            ErrorMessage(ex, 20358)
        End Try
    End Sub

    Private Sub optDDUserDefined_CheckedChanged(sender As Object, e As EventArgs) Handles optDDUserDefined.CheckedChanged
        Try
            txtUserDefinedDD.Enabled = True
            txtRatioDD.Enabled = False
            lblUserDefinedUnits.Enabled = True
            lblpercent.Enabled = False
            txtRatioDD.Text = ""
        Catch ex As Exception
            ErrorMessage(ex, 20359)
        End Try
    End Sub

    Private Sub optDDRatio_CheckedChanged(sender As Object, e As EventArgs) Handles optDDRatio.CheckedChanged
        Try
            txtUserDefinedDD.Enabled = False
            txtRatioDD.Enabled = True
            lblUserDefinedUnits.Enabled = False
            lblpercent.Enabled = True
            txtUserDefinedDD.Text = ""
        Catch ex As Exception
            ErrorMessage(ex, 20360)
        End Try
    End Sub

    Private Sub chkDisplayAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkDisplayAllResHead.CheckedChanged
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

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is TabPageFanParameters Then
            'open fan parameters tab
            Try
                move_on = True
                Yellow(Txtflow)
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

                If move_on = True Then SetupFanParametersPage()
            Catch ex As Exception
                ErrorMessage(ex, 20363)
            End Try
        End If
    End Sub

    Private Sub OptStaticPressure_CheckedChanged(sender As Object, e As EventArgs) Handles OptStaticPressure.CheckedChanged
        Try
            PresType = 0
            optDDRatio.Checked = False
            optDDUserDefined.Checked = False
            txtRatioDD.Enabled = True
            txtUserDefinedDD.Enabled = True
            optDDRatio.Enabled = True
            optDDUserDefined.Enabled = True
            optDDStandard.Checked = True
            lblUserDefinedUnits.Enabled = True
            lblpercent.Enabled = True
        Catch ex As Exception
            ErrorMessage(ex, 20364)
        End Try
    End Sub

    Private Sub OptTotalPressure_CheckedChanged(sender As Object, e As EventArgs) Handles OptTotalPressure.CheckedChanged
        Try
            PresType = 1
            optDDRatio.Checked = False
            optDDUserDefined.Checked = False
            txtRatioDD.Enabled = False
            txtUserDefinedDD.Enabled = False
            optDDRatio.Enabled = False
            optDDUserDefined.Enabled = False
            optDDStandard.Checked = True
            lblUserDefinedUnits.Enabled = False
            lblpercent.Enabled = False
            txtUserDefinedDD.Text = ""
            txtRatioDD.Text = ""
        Catch ex As Exception
            ErrorMessage(ex, 20365)
        End Try
    End Sub

    Private Sub chkDuct_CheckedChanged(sender As Object, e As EventArgs) Handles chkDuct.CheckedChanged
        Try
        Catch ex As Exception
            ErrorMessage(ex, 20366)
        End Try
    End Sub


    Private Sub chkOpenInlet_CheckedChanged(sender As Object, e As EventArgs) Handles chkOpenInlet.CheckedChanged
        Try
        Catch ex As Exception
            ErrorMessage(ex, 20367)
        End Try
    End Sub

    Private Sub chkOpenOutlet_CheckedChanged(sender As Object, e As EventArgs) Handles chkOpenOutlet.CheckedChanged
        Try
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

    Private Sub TxtAltitude_TextChanged(sender As Object, e As EventArgs) Handles TxtAltitude.TextChanged
        Try
            If chkCalcAtmos.Checked = True Then
                CalcAtmosFromAlt()
                Yellow(TxtAltitude, -100)
            End If
        Catch ex As Exception
            Yellow(TxtAltitude, -100)
        End Try
    End Sub

    Private Sub chkCalcAtmos_Click(sender As Object, e As EventArgs) Handles chkCalcAtmos.Click
        Try
            If chkCalcAtmos.Checked = True Then
                CalcAtmosFromAlt()
                TxtAtmosphericPressure.Enabled = False
            Else
                TxtAtmosphericPressure.Enabled = True
            End If
        Catch ex As Exception
            ErrorMessage(ex, 20376)
        End Try
    End Sub

    Private Sub CalcAtmosFromAlt()
        Try
            Dim p As Double
            Dim h As Double
            h = CDbl(TxtAltitude.Text)
            p = 101325 * (1 - (h * 2.25577 * 10 ^ -5)) ^ 5.25588 ' in Pa
            'convert to user units
            If OptPressurePa.Checked Then p = p
            If OptPressuremBar.Checked Then p = p / 100.0 'okay
            If OptPressureinWG.Checked Then p = p / 249.0891 'okay
            If OptPressuremmWG.Checked Then p = p / 9.80665 'okay
            If OptPressurekPa.Checked Then p = p / 1000.0 'okay

            If p > 10 Then pressplaceAtmos = 3
            If p > 100 Then pressplaceAtmos = 2
            If p > 1000 Then pressplaceAtmos = 1
            If p > 10000 Then pressplaceAtmos = 0

            TxtAtmosphericPressure.Text = Math.Round(p, pressplaceAtmos, MidpointRounding.AwayFromZero).ToString
        Catch ex As Exception
            ErrorMessage(ex, 20377)
        End Try
    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        'Select Right Clicked Row if its not the header row
        Try
            If e.Button = MouseButtons.Right And failindex > -1 Then
                FrmDisplayRejects.Show()
            End If
        Catch ex As Exception
            ErrorMessage(ex, 20378)
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

    Private Sub OptAnySize_Click(sender As Object, e As EventArgs) Handles OptAnySize.Click
        Try
            Txtfansize.Text = "0"
        Catch ex As Exception
            ErrorMessage(ex, 20382)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            End
        Catch ex As Exception
            ErrorMessage(ex, 20383)
        End Try
    End Sub

    ' Print Preview 
    Private Sub AllPagesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllPagesToolStripMenuItem.Click
        Try
            PrintLanguage = 1
            If OpenFileName = "" And SaveFileName = "" Then
                MsgBox(lblSaveProject.Text, vbOKOnly + vbInformation, "")
                Exit Sub
            End If
            CreateFile(0)
        Catch ex As Exception
            ErrorMessage(ex, 20384)
        End Try
    End Sub

    Private Sub PerformanceDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerformanceDetailsToolStripMenuItem.Click
        Try
            PrintLanguage = 1
            If OpenFileName = "" And SaveFileName = "" Then
                MsgBox(lblSaveProject.Text, vbOKOnly + vbInformation, "")
                Exit Sub
            End If
            CreateFile(1)
        Catch ex As Exception
            ErrorMessage(ex, 20385)
        End Try
    End Sub

    Private Sub AcousticsDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcousticsDetailsToolStripMenuItem.Click
        Try
            PrintLanguage = 1
            If OpenFileName = "" And SaveFileName = "" Then
                MsgBox(lblSaveProject.Text, vbOKOnly + vbInformation, "")
                Exit Sub
            End If
            CreateFile(2)
        Catch ex As Exception
            ErrorMessage(ex, 20386)
        End Try
    End Sub

    Private Sub PerformanceCurveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerformanceCurveToolStripMenuItem.Click
        Try
            PrintLanguage = 1
            If OpenFileName = "" And SaveFileName = "" Then
                MsgBox(lblSaveProject.Text, vbOKOnly + vbInformation, "")
                Exit Sub
            End If
            CreateFile(3)
        Catch ex As Exception
            ErrorMessage(ex, 20387)
        End Try
    End Sub

    Private Sub AllPages2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllPages2ToolStripMenuItem.Click
        Try
            PrintLanguage = 1
            If OpenFileName = "" And SaveFileName = "" Then
                MsgBox(lblSaveProject.Text, vbOKOnly + vbInformation, "")
                Exit Sub
            End If
            CreateFile(0)
        Catch ex As Exception
            ErrorMessage(ex, 20388)
        End Try
    End Sub

    Private Sub PerformanceDetails2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerformanceDetails2ToolStripMenuItem.Click
        Try
            PrintLanguage = 2
            If OpenFileName = "" And SaveFileName = "" Then
                MsgBox(lblSaveProject.Text, vbOKOnly + vbInformation, "")
                Exit Sub
            End If
            CreateFile(1)
        Catch ex As Exception
            ErrorMessage(ex, 20389)
        End Try
    End Sub

    Private Sub AcousticDetails2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcousticDetails2ToolStripMenuItem.Click
        Try
            PrintLanguage = 2
            If OpenFileName = "" And SaveFileName = "" Then
                MsgBox(lblSaveProject.Text, vbOKOnly + vbInformation, "")
                Exit Sub
            End If
            CreateFile(2)
        Catch ex As Exception
            ErrorMessage(ex, 20390)
        End Try
    End Sub

    Private Sub FanCurve2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FanCurve2ToolStripMenuItem.Click
        Try
            PrintLanguage = 2
            If OpenFileName = "" And SaveFileName = "" Then
                MsgBox(lblSaveProject.Text, vbOKOnly + vbInformation, "")
                Exit Sub
            End If
            CreateFile(3)
        Catch ex As Exception
            ErrorMessage(ex, 20391)
        End Try
    End Sub
    Private Sub TabPageFanParameters_Enter(sender As Object, e As EventArgs) Handles TabPageFanParameters.Enter
        Try
            Check_Leave_Duty()
            If move_on = False Then TabControl1.SelectedTab = TabPageDuty
        Catch ex As Exception
            ErrorMessage(ex, 20392)
        End Try
    End Sub

    Private Sub Txtfansize_TextChanged(sender As Object, e As EventArgs) Handles Txtfansize.TextChanged
    End Sub

    Private Sub OptFixedSize_CheckedChanged(sender As Object, e As EventArgs) Handles OptFixedSize.CheckedChanged
        Try
            Txtfansize.Enabled = True
        Catch ex As Exception
            ErrorMessage(ex, 20393)
        End Try
    End Sub

    Private Sub OptAnySize_CheckedChanged(sender As Object, e As EventArgs) Handles OptAnySize.CheckedChanged
        Try
            Txtfansize.Enabled = False
            Txtfansize.Text = 0
        Catch ex As Exception
            ErrorMessage(ex, 20394)
        End Try
    End Sub

    Private Sub btnNoiseDataBack_Click(sender As Object, e As EventArgs) Handles btnNoiseDataBack.Click
        'open noise data tab
        Try
            Flag(4) = True
            TabControl1.SelectTab(TabPageNoise)
        Catch ex As Exception
            ErrorMessage(ex, 20395)
        End Try
    End Sub

    Private Sub Optsucy_Click(sender As Object, e As EventArgs) Handles Optsucy.Click
        Try
            If Optsucy.Checked = True Then
                TxtInletPressure.Text = (-1.0 * Math.Abs(CDbl(TxtInletPressure.Text))).ToString
            Else
                TxtInletPressure.Text = Math.Abs(CDbl(TxtInletPressure.Text)).ToString
            End If
        Catch ex As Exception
            ErrorMessage(ex, 20396)
        End Try
    End Sub

    Private Sub chkOriginalData_CheckedChanged(sender As Object, e As EventArgs) Handles chkOriginalData.CheckedChanged
        Try
            failindex = -1
            TabPageSelection_Enter(sender, e)
        Catch ex As Exception
            ErrorMessage(ex, 20397)
        End Try
    End Sub

    Private Sub chkAllBlades_CheckedChanged(sender As Object, e As EventArgs) Handles chkAllBlades.CheckedChanged
        Try
            If chkAllBlades.Checked = True Then
                chkWide.Checked = True
                chkMedium.Checked = True
                chkNarrow.Checked = True
                chkHighPressure.Checked = True
                ChkCurveBlade.Checked = True
                ChkInclineBlade.Checked = True
                ChkOtherFanType.Checked = True
                ChkPlasticFan.Checked = True
                chkPaddleBlade.Checked = True
                chkRadialBlade.Checked = True
                ChkPlenumFans.Checked = True
                ChkAxialFans.Checked = True
                ChkOldDesignFans.Checked = True
            Else
                chkWide.Checked = False
                chkMedium.Checked = False
                chkNarrow.Checked = False
                chkHighPressure.Checked = False
                ChkCurveBlade.Checked = False
                ChkInclineBlade.Checked = False
                ChkOtherFanType.Checked = False
                ChkPlasticFan.Checked = False
                chkPaddleBlade.Checked = False
                chkRadialBlade.Checked = False
                ChkPlenumFans.Checked = False
                ChkAxialFans.Checked = False
                ChkOldDesignFans.Checked = False
            End If
            lblOutVel.Enabled = False 'chkPaddleBlade.Checked
            lblOutVelUnit.Enabled = False 'chkPaddleBlade.Checked
            txtOutVel.Enabled = False 'chkPaddleBlade.Checked
        Catch ex As Exception
            ErrorMessage(ex, 20398)
        End Try
    End Sub

    Private Sub ChkWide_Click(sender As Object, e As EventArgs) Handles chkWide.Click
        Try
            If chkWide.Checked = True Then
                chkMedium.Checked = False
                chkNarrow.Checked = False
                chkHighPressure.Checked = False
                ChkInclineBlade.Checked = False
                ChkCurveBlade.Checked = False
                chkPaddleBlade.Checked = False
                chkRadialBlade.Checked = False
                ChkPlasticFan.Checked = False
                ChkOtherFanType.Checked = False
                ChkPlenumFans.Checked = False
                ChkAxialFans.Checked = False
                ChkOldDesignFans.Checked = False
            End If
            lblOutVel.Enabled = chkPaddleBlade.Checked
            lblOutVelUnit.Enabled = chkPaddleBlade.Checked
            txtOutVel.Enabled = chkPaddleBlade.Checked
        Catch ex As Exception
            ErrorMessage(ex, 20399)
        End Try
    End Sub
    Private Sub ChkMedium_Click(sender As Object, e As EventArgs) Handles chkMedium.Click
        Try
            If chkMedium.Checked = True Then
                chkWide.Checked = False
                chkNarrow.Checked = False
                chkHighPressure.Checked = False
                ChkInclineBlade.Checked = False
                ChkCurveBlade.Checked = False
                chkPaddleBlade.Checked = False
                chkRadialBlade.Checked = False
                ChkPlasticFan.Checked = False
                ChkOtherFanType.Checked = False
                ChkPlenumFans.Checked = False
                ChkAxialFans.Checked = False
                ChkOldDesignFans.Checked = False
            End If
            lblOutVel.Enabled = chkPaddleBlade.Checked
            lblOutVelUnit.Enabled = chkPaddleBlade.Checked
            txtOutVel.Enabled = chkPaddleBlade.Checked
        Catch ex As Exception
            ErrorMessage(ex, 20400)
        End Try
    End Sub
    Private Sub ChkNarrow_Click(sender As Object, e As EventArgs) Handles chkNarrow.Click
        Try
            If chkNarrow.Checked = True Then
                chkMedium.Checked = False
                chkWide.Checked = False
                chkHighPressure.Checked = False
                ChkInclineBlade.Checked = False
                ChkCurveBlade.Checked = False
                chkPaddleBlade.Checked = False
                chkRadialBlade.Checked = False
                ChkPlasticFan.Checked = False
                ChkOtherFanType.Checked = False
                ChkPlenumFans.Checked = False
                ChkAxialFans.Checked = False
                ChkOldDesignFans.Checked = False
            End If
            lblOutVel.Enabled = chkPaddleBlade.Checked
            lblOutVelUnit.Enabled = chkPaddleBlade.Checked
            txtOutVel.Enabled = chkPaddleBlade.Checked
        Catch ex As Exception
            ErrorMessage(ex, 20401)
        End Try
    End Sub
    Private Sub ChkHighPressure_Click(sender As Object, e As EventArgs) Handles chkHighPressure.Click
        Try
            If chkHighPressure.Checked = True Then
                chkMedium.Checked = False
                chkNarrow.Checked = False
                chkWide.Checked = False
                ChkInclineBlade.Checked = False
                ChkCurveBlade.Checked = False
                chkPaddleBlade.Checked = False
                chkRadialBlade.Checked = False
                ChkPlasticFan.Checked = False
                ChkOtherFanType.Checked = False
                ChkPlenumFans.Checked = False
                ChkAxialFans.Checked = False
                ChkOldDesignFans.Checked = False
            End If
            lblOutVel.Enabled = chkPaddleBlade.Checked
            lblOutVelUnit.Enabled = chkPaddleBlade.Checked
            txtOutVel.Enabled = chkPaddleBlade.Checked
        Catch ex As Exception
            ErrorMessage(ex, 20402)
        End Try
    End Sub
    Private Sub ChkInclineBlade_Click(sender As Object, e As EventArgs) Handles ChkInclineBlade.Click
        Try
            If ChkInclineBlade.Checked = True Then
                chkMedium.Checked = False
                chkNarrow.Checked = False
                chkHighPressure.Checked = False
                chkWide.Checked = False
                ChkCurveBlade.Checked = False
                chkPaddleBlade.Checked = False
                chkRadialBlade.Checked = False
                ChkPlasticFan.Checked = False
                ChkOtherFanType.Checked = False
                ChkPlenumFans.Checked = False
                ChkAxialFans.Checked = False
                ChkOldDesignFans.Checked = False
            End If
            lblOutVel.Enabled = chkPaddleBlade.Checked
            lblOutVelUnit.Enabled = chkPaddleBlade.Checked
            txtOutVel.Enabled = chkPaddleBlade.Checked
        Catch ex As Exception
            ErrorMessage(ex, 20403)
        End Try
    End Sub
    Private Sub ChkCurveBlade_Click(sender As Object, e As EventArgs) Handles ChkCurveBlade.Click
        Try
            If ChkCurveBlade.Checked = True Then
                chkMedium.Checked = False
                chkNarrow.Checked = False
                chkHighPressure.Checked = False
                ChkInclineBlade.Checked = False
                chkWide.Checked = False
                chkPaddleBlade.Checked = False
                chkRadialBlade.Checked = False
                ChkPlasticFan.Checked = False
                ChkOtherFanType.Checked = False
                ChkPlenumFans.Checked = False
                ChkAxialFans.Checked = False
                ChkOldDesignFans.Checked = False
            End If
            lblOutVel.Enabled = chkPaddleBlade.Checked
            lblOutVelUnit.Enabled = chkPaddleBlade.Checked
            txtOutVel.Enabled = chkPaddleBlade.Checked
        Catch ex As Exception
            ErrorMessage(ex, 20404)
        End Try
    End Sub
    Private Sub ChkPaddleBlade_Click(sender As Object, e As EventArgs) Handles chkPaddleBlade.Click
        Try
            If chkPaddleBlade.Checked = True Then
                chkMedium.Checked = False
                chkNarrow.Checked = False
                chkHighPressure.Checked = False
                ChkInclineBlade.Checked = False
                ChkCurveBlade.Checked = False
                chkRadialBlade.Checked = False
                chkWide.Checked = False
                ChkPlasticFan.Checked = False
                ChkOtherFanType.Checked = False
                ChkPlenumFans.Checked = False
                ChkAxialFans.Checked = False
                ChkOldDesignFans.Checked = False
            End If
            lblOutVel.Enabled = False 'chkPaddleBlade.Checked
            lblOutVelUnit.Enabled = False 'chkPaddleBlade.Checked
            txtOutVel.Enabled = False 'chkPaddleBlade.Checked
        Catch ex As Exception
            ErrorMessage(ex, 20405)
        End Try
    End Sub
    Private Sub ChkRadialBlade_Click(sender As Object, e As EventArgs) Handles chkRadialBlade.Click
        Try
            If chkRadialBlade.Checked = True Then
                chkMedium.Checked = False
                chkNarrow.Checked = False
                chkHighPressure.Checked = False
                ChkInclineBlade.Checked = False
                ChkCurveBlade.Checked = False
                chkPaddleBlade.Checked = False
                chkWide.Checked = False
                ChkPlasticFan.Checked = False
                ChkOtherFanType.Checked = False
                ChkPlenumFans.Checked = False
                ChkAxialFans.Checked = False
                ChkOldDesignFans.Checked = False
            End If
            lblOutVel.Enabled = chkPaddleBlade.Checked
            lblOutVelUnit.Enabled = chkPaddleBlade.Checked
            txtOutVel.Enabled = chkPaddleBlade.Checked
        Catch ex As Exception
            ErrorMessage(ex, 20406)
        End Try
    End Sub
    Private Sub ChkPlasticFan_Click(sender As Object, e As EventArgs) Handles ChkPlasticFan.Click
        Try
            If ChkPlasticFan.Checked = True Then
                chkMedium.Checked = False
                chkNarrow.Checked = False
                chkHighPressure.Checked = False
                ChkInclineBlade.Checked = False
                ChkCurveBlade.Checked = False
                chkPaddleBlade.Checked = False
                chkRadialBlade.Checked = False
                chkWide.Checked = False
                ChkOtherFanType.Checked = False
                ChkPlenumFans.Checked = False
                ChkAxialFans.Checked = False
                ChkOldDesignFans.Checked = False
            End If
            lblOutVel.Enabled = chkPaddleBlade.Checked
            lblOutVelUnit.Enabled = chkPaddleBlade.Checked
            txtOutVel.Enabled = chkPaddleBlade.Checked
        Catch ex As Exception
            ErrorMessage(ex, 20407)
        End Try
    End Sub
    Private Sub ChkOtherFanType_Click(sender As Object, e As EventArgs) Handles ChkOtherFanType.Click
        Try
            If ChkOtherFanType.Checked = True Then
                chkMedium.Checked = False
                chkNarrow.Checked = False
                chkHighPressure.Checked = False
                ChkInclineBlade.Checked = False
                ChkCurveBlade.Checked = False
                chkPaddleBlade.Checked = False
                chkRadialBlade.Checked = False
                ChkPlasticFan.Checked = False
                chkWide.Checked = False
                ChkPlenumFans.Checked = False
                ChkAxialFans.Checked = False
                ChkOldDesignFans.Checked = False
            End If
            lblOutVel.Enabled = chkPaddleBlade.Checked
            lblOutVelUnit.Enabled = chkPaddleBlade.Checked
            txtOutVel.Enabled = chkPaddleBlade.Checked
        Catch ex As Exception
            ErrorMessage(ex, 20408)
        End Try
    End Sub
    Private Sub ChkPlenumFans_Click(sender As Object, e As EventArgs) Handles ChkPlenumFans.Click
        Try
            If ChkPlenumFans.Checked = True Then
                chkMedium.Checked = False
                chkNarrow.Checked = False
                chkHighPressure.Checked = False
                ChkInclineBlade.Checked = False
                ChkCurveBlade.Checked = False
                chkPaddleBlade.Checked = False
                chkRadialBlade.Checked = False
                ChkPlasticFan.Checked = False
                ChkOtherFanType.Checked = False
                chkWide.Checked = False
                ChkAxialFans.Checked = False
                ChkOldDesignFans.Checked = False
            End If
            lblOutVel.Enabled = chkPaddleBlade.Checked
            lblOutVelUnit.Enabled = chkPaddleBlade.Checked
            txtOutVel.Enabled = chkPaddleBlade.Checked
        Catch ex As Exception
            ErrorMessage(ex, 20409)
        End Try
    End Sub
    Private Sub ChkAxialFans_Click(sender As Object, e As EventArgs) Handles ChkAxialFans.Click
        Try
            If ChkAxialFans.Checked = True Then
                chkMedium.Checked = False
                chkNarrow.Checked = False
                chkHighPressure.Checked = False
                ChkInclineBlade.Checked = False
                ChkCurveBlade.Checked = False
                chkPaddleBlade.Checked = False
                chkRadialBlade.Checked = False
                ChkPlasticFan.Checked = False
                ChkOtherFanType.Checked = False
                ChkPlenumFans.Checked = False
                chkWide.Checked = False
                ChkOldDesignFans.Checked = False
            End If
            lblOutVel.Enabled = chkPaddleBlade.Checked
            lblOutVelUnit.Enabled = chkPaddleBlade.Checked
            txtOutVel.Enabled = chkPaddleBlade.Checked
        Catch ex As Exception
            ErrorMessage(ex, 20410)
        End Try
    End Sub
    Private Sub ChkOldDesignFans_Click(sender As Object, e As EventArgs) Handles ChkOldDesignFans.Click
        Try
            If ChkOldDesignFans.Checked = True Then
                chkMedium.Checked = False
                chkNarrow.Checked = False
                chkHighPressure.Checked = False
                ChkInclineBlade.Checked = False
                ChkCurveBlade.Checked = False
                chkPaddleBlade.Checked = False
                chkRadialBlade.Checked = False
                ChkPlasticFan.Checked = False
                ChkOtherFanType.Checked = False
                ChkPlenumFans.Checked = False
                ChkAxialFans.Checked = False
                chkWide.Checked = False
            End If
            lblOutVel.Enabled = chkPaddleBlade.Checked
            lblOutVelUnit.Enabled = chkPaddleBlade.Checked
            txtOutVel.Enabled = chkPaddleBlade.Checked
        Catch ex As Exception
            ErrorMessage(ex, 20411)
        End Try
    End Sub

    'Private Sub StandaloneCurveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StandaloneCurveToolStripMenuItem.Click
    '    frmStandaloneCurve.ShowDialog()
    'End Sub
End Class