
Imports System.Globalization
Imports System.ComponentModel
Imports System.Resources
Imports System.Threading
Public Class FrmCurveOptions
    Public retval As Integer = 1
    Public fanclasstemp(50) As String
    Private Sub FrmCurveOptions_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            DensityEmpty()
            SpeedEmpty()
            If StandAlone = False Then
                Me.CenterToScreen()

                If PresType = 0 Then
                    optFSPonly.Checked = True
                Else
                    optFTPonly.Checked = True
                End If
                optNoDensities1.Checked = True
                optNoSpeeds1.Checked = True
                grpMultipleDensities.Enabled = True
                grpMultipleSpeeds.Enabled = True
                txtSpeed1.Text = final.speed.ToString
                txtDensity1.Text = knowndensity.ToString
                SplitContainer1.Panel1Collapsed = True
                IncludeDutyPoint = True
                chkDutyPoint.Checked = True
                chkDutyPoint.Visible = False
                Me.Width = 400
            Else
                ApplyLocale(ChosenLanguage)
                CenterToScreen()
                If ChosenLanguage = "zh-CN" Then
                    grpOutputLanguage.Visible = True
                    optChineseLanguageOutput.Checked = True
                    PrintLanguage = 1
                Else
                    grpOutputLanguage.Visible = False
                    optEnglishLanguageOutput.Checked = True
                    PrintLanguage = 2
                End If
                txtFanSize.Text = ""
                txtFanSpeed.Text = ""
                txtFanDesign.Text = ""
                chkDoubleInlet.Checked = False
                txtDensity1.Text = txtDensity.Text
                cmbFlowUnits.SelectedIndex = 0
                cmbPressureUnits.SelectedIndex = 0
                cmbDensityUnits.SelectedIndex = 0
                cmbPowerUnits.SelectedIndex = 0
                cmbLengthUnits.SelectedIndex = 0
                chkDutyPoint.Visible = True
                lstFanDesigns.Items.Clear()
                PopulateFanListBox()
            End If
        Catch ex As Exception
            ErrorMessage(ex, 20701)
        End Try
    End Sub

    'Private Sub optNoSpeeds1_CheckedChanged(sender As Object, e As EventArgs)
    '    Try
    '        numspeeds = 1
    '        SpeedFill()
    '    Catch ex As Exception
    '        ErrorMessage(ex, 20705)
    '    End Try
    'End Sub
    'Private Sub optNoSpeeds2_CheckedChanged(sender As Object, e As EventArgs)
    '    Try
    '        numspeeds = 2
    '        SpeedFill()
    '    Catch ex As Exception
    '        ErrorMessage(ex, 20706)
    '    End Try
    'End Sub
    'Private Sub optNoSpeeds3_CheckedChanged(sender As Object, e As EventArgs)
    '    Try
    '        numspeeds = 3
    '        SpeedFill()
    '    Catch ex As Exception
    '        ErrorMessage(ex, 20707)
    '    End Try
    'End Sub
    'Private Sub optNoSpeeds4_CheckedChanged(sender As Object, e As EventArgs)
    '    Try
    '        numspeeds = 4
    '        SpeedFill()
    '    Catch ex As Exception
    '        ErrorMessage(ex, 20708)
    '    End Try
    'End Sub
    'Private Sub optNoSpeeds5_CheckedChanged(sender As Object, e As EventArgs)
    '    Try
    '        numspeeds = 5
    '        SpeedFill()
    '    Catch ex As Exception
    '        ErrorMessage(ex, 20709)
    '    End Try
    'End Sub
    'Private Sub optNoSpeeds6_CheckedChanged(sender As Object, e As EventArgs)
    '    Try
    '        numspeeds = 6
    '        SpeedFill()
    '    Catch ex As Exception
    '        ErrorMessage(ex, 20710)
    '    End Try
    'End Sub
    'Private Sub optNoSpeeds7_CheckedChanged(sender As Object, e As EventArgs)
    '    Try
    '        numspeeds = 7
    '        SpeedFill()
    '    Catch ex As Exception
    '        ErrorMessage(ex, 20711)
    '    End Try
    'End Sub
    'Private Sub optNoSpeeds8_CheckedChanged(sender As Object, e As EventArgs)
    '    Try
    '        numspeeds = 8
    '        SpeedFill()
    '    Catch ex As Exception
    '        ErrorMessage(ex, 20712)
    '    End Try
    'End Sub
    'Private Sub optNoDensities1_CheckedChanged(sender As Object, e As EventArgs)
    '    Try
    '        numdensities = 1
    '        DensityFill()
    '    Catch ex As Exception
    '        ErrorMessage(ex, 20713)
    '    End Try
    'End Sub
    'Private Sub optNoDensities2_CheckedChanged(sender As Object, e As EventArgs)
    '    Try
    '        numdensities = 2
    '        DensityFill()
    '    Catch ex As Exception
    '        ErrorMessage(ex, 20714)
    '    End Try
    'End Sub
    'Private Sub optNoDensities3_CheckedChanged(sender As Object, e As EventArgs)
    '    Try
    '        numdensities = 3
    '        DensityFill()
    '    Catch ex As Exception
    '        ErrorMessage(ex, 20715)
    '    End Try
    'End Sub
    'Private Sub optNoDensities4_CheckedChanged(sender As Object, e As EventArgs)
    '    Try
    '        numdensities = 4
    '        DensityFill()
    '    Catch ex As Exception
    '        ErrorMessage(ex, 20716)
    '    End Try
    'End Sub
    'Private Sub optNoDensities5_CheckedChanged(sender As Object, e As EventArgs)
    '    Try
    '        numdensities = 5
    '        DensityFill()
    '    Catch ex As Exception
    '        ErrorMessage(ex, 20717)
    '    End Try
    'End Sub
    'Private Sub optNoDensities6_CheckedChanged(sender As Object, e As EventArgs)
    '    Try
    '        numdensities = 6
    '        DensityFill()
    '    Catch ex As Exception
    '        ErrorMessage(ex, 20718)
    '    End Try
    'End Sub
    'Private Sub optNoDensities7_CheckedChanged(sender As Object, e As EventArgs)
    '    Try
    '        numdensities = 7
    '        DensityFill()
    '    Catch ex As Exception
    '        ErrorMessage(ex, 20719)
    '    End Try
    'End Sub
    'Private Sub optNoDensities8_CheckedChanged(sender As Object, e As EventArgs)
    '    Try
    '        numdensities = 8
    '        DensityFill()
    '    Catch ex As Exception
    '        ErrorMessage(ex, 20720)
    '    End Try
    'End Sub

    Private Sub DensityFill()
        Try
            grpMultipleSpeeds.Enabled = False
            chkDamper.Checked = False
            chkSystem.Checked = False
            optNoSpeeds1.Checked = True
            txtDensity1.Visible = False
            txtDensity2.Visible = False
            txtDensity3.Visible = False
            txtDensity4.Visible = False
            txtDensity5.Visible = False
            txtDensity6.Visible = False
            txtDensity7.Visible = False
            txtDensity8.Visible = False
            For i = 1 To numdensities
                If i = 1 Then txtDensity1.Visible = True
                If i = 2 Then txtDensity2.Visible = True
                If i = 3 Then txtDensity3.Visible = True
                If i = 4 Then txtDensity4.Visible = True
                If i = 5 Then txtDensity5.Visible = True
                If i = 6 Then txtDensity6.Visible = True
                If i = 7 Then txtDensity7.Visible = True
                If i = 8 Then txtDensity8.Visible = True
            Next
            If numdensities = 1 Then grpMultipleSpeeds.Enabled = True
        Catch ex As Exception
            ErrorMessage(ex, 20702)
        End Try
    End Sub

    Private Sub SpeedFill()
        Try
            grpMultipleDensities.Enabled = False
            chkDamper.Checked = False
            chkSystem.Checked = False
            optNoDensities1.Checked = True
            txtSpeed1.Visible = False
            txtSpeed2.Visible = False
            txtSpeed3.Visible = False
            txtSpeed4.Visible = False
            txtSpeed5.Visible = False
            txtSpeed6.Visible = False
            txtSpeed7.Visible = False
            txtSpeed8.Visible = False
            For i = 1 To numspeeds
                If i = 1 Then txtSpeed1.Visible = True
                If i = 2 Then txtSpeed2.Visible = True
                If i = 3 Then txtSpeed3.Visible = True
                If i = 4 Then txtSpeed4.Visible = True
                If i = 5 Then txtSpeed5.Visible = True
                If i = 6 Then txtSpeed6.Visible = True
                If i = 7 Then txtSpeed7.Visible = True
                If i = 8 Then txtSpeed8.Visible = True
            Next
            If numspeeds = 1 Then grpMultipleDensities.Enabled = True
        Catch ex As Exception
            ErrorMessage(ex, 20703)
        End Try
    End Sub

    'Private Sub chkDamper_Click(sender As Object, e As EventArgs)
    '    Try
    '        IncludeDampers = chkDamper.Checked
    '        If chkDamper.Checked = True Then
    '            optNoSpeeds1.Checked = True
    '            optNoDensities1.Checked = True
    '        End If
    '        chkDamper.Checked = IncludeDampers
    '    Catch ex As Exception
    '        ErrorMessage(ex, 20701)
    '    End Try
    'End Sub

    'Private Sub chkSystem_Click(sender As Object, e As EventArgs)
    '    Try
    '        IncludeSystem = chkSystem.Checked
    '        If chkSystem.Checked = True Then
    '            optNoSpeeds1.Checked = True
    '            optNoDensities1.Checked = True
    '        End If
    '        chkSystem.Checked = IncludeSystem
    '    Catch ex As Exception
    '        ErrorMessage(ex, 20704)
    '    End Try

    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            retval = 0
            Close()

        Catch ex As Exception
            ErrorMessage(ex, 20704)
        End Try        'End
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        'Try
        '##############################################
        Try
            If StandAlone = True Then
                SelectDIDW = chkDoubleInlet.Checked
                getLanguageDictionary()
                SetUnitStructure()
                move_on = True
                Yellow(txtFanSpeed)
                Yellow(txtDensity)
                Yellow(txtFanSize)
                'Yellow(txtFanDesign)
                YellowLst(lstFanDesigns)
                If txtWidthing.Enabled = True Then
                    If CDbl(txtWidthing.Text) < 50.0 Or CDbl(txtWidthing.Text) > 100.0 Then
                        txtWidthing.Text = ""
                        Yellow(txtWidthing)
                    End If
                End If
                If move_on = True Then
                    final.speed = CDbl(txtFanSpeed.Text)
                    knowndensity = CDbl(txtDensity.Text)
                    final.fansize = CDbl(txtFanSize.Text)
                    final.fantype = txtFanDesign.Text
                    final.fantypename = lstFanDesigns.SelectedItem
                    final.widthfactor = 1.0
                    If txtWidthing.Enabled = True Then final.widthfactor = CDbl(txtWidthing.Text) / 100.0
                    Units(0).UnitSelected = cmbFlowUnits.SelectedIndex
                    Units(1).UnitSelected = cmbPressureUnits.SelectedIndex
                    Units(3).UnitSelected = cmbDensityUnits.SelectedIndex
                    Units(4).UnitSelected = cmbPowerUnits.SelectedIndex
                    Units(5).UnitSelected = cmbLengthUnits.SelectedIndex
                    'For i = 0 To 2
                    '    Flag(i) = True
                    'Next
                Else
                    Exit Sub

                End If
                'Catch ex As Exception
                '    ErrorMessage(ex, 20391)
                'End Try

            End If

            '##############################################
            If optFTPonly.Checked = True And StandAlone = True Then PresType = 1
            If (optFSPonly.Checked = True Or optFSPandFTP.Checked = True) And StandAlone = True Then PresType = 0

            If Not txtDensity1.Text = "" And numdensities > 0 Then AddedDensities(0) = CDbl(txtDensity1.Text)
            If Not txtDensity2.Text = "" And numdensities > 1 Then AddedDensities(1) = CDbl(txtDensity2.Text)
            If Not txtDensity3.Text = "" And numdensities > 2 Then AddedDensities(2) = CDbl(txtDensity3.Text)
            If Not txtDensity4.Text = "" And numdensities > 3 Then AddedDensities(3) = CDbl(txtDensity4.Text)
            If Not txtDensity5.Text = "" And numdensities > 4 Then AddedDensities(4) = CDbl(txtDensity5.Text)
            If Not txtDensity6.Text = "" And numdensities > 5 Then AddedDensities(5) = CDbl(txtDensity6.Text)
            If Not txtDensity7.Text = "" And numdensities > 6 Then AddedDensities(6) = CDbl(txtDensity7.Text)
            If Not txtDensity8.Text = "" And numdensities > 7 Then AddedDensities(7) = CDbl(txtDensity8.Text)

            If Not txtSpeed1.Text = "" And numspeeds > 0 Then AddedSpeeds(0) = CDbl(txtSpeed1.Text)
            If Not txtSpeed2.Text = "" And numspeeds > 1 Then AddedSpeeds(1) = CDbl(txtSpeed2.Text)
            If Not txtSpeed3.Text = "" And numspeeds > 2 Then AddedSpeeds(2) = CDbl(txtSpeed3.Text)
            If Not txtSpeed4.Text = "" And numspeeds > 3 Then AddedSpeeds(3) = CDbl(txtSpeed4.Text)
            If Not txtSpeed5.Text = "" And numspeeds > 4 Then AddedSpeeds(4) = CDbl(txtSpeed5.Text)
            If Not txtSpeed6.Text = "" And numspeeds > 5 Then AddedSpeeds(5) = CDbl(txtSpeed6.Text)
            If Not txtSpeed7.Text = "" And numspeeds > 6 Then AddedSpeeds(6) = CDbl(txtSpeed7.Text)
            If Not txtSpeed8.Text = "" And numspeeds > 7 Then AddedSpeeds(7) = CDbl(txtSpeed8.Text)
            retval = 1
            'Close()
            'PrintLanguage = 1'####################################
            'OpenFileName = "Standalone Curve"
            'Flag(4) = True
            If OpenFileName = "" And SaveFileName = "" Then
                SaveProjectFile(False)
            End If
            'If OpenFileName = "" And SaveFileName = "" Then
            '    'MsgBox(lblSaveProject.Text, vbOKOnly + vbInformation, "")
            '    MsgBox("Save project please", vbOKOnly + vbInformation, "")
            '    Exit Sub
            'End If
            Me.Hide()
            CreateFile(3)
        Catch ex As Exception
            ErrorMessage(ex, 20705)
        End Try
    End Sub

    Private Sub optNoSpeeds1_CheckedChanged(sender As Object, e As EventArgs) Handles optNoSpeeds1.CheckedChanged
        Try
            numspeeds = 1
            SpeedFill()
        Catch ex As Exception
            ErrorMessage(ex, 20706)
        End Try
    End Sub

    Private Sub optNoSpeeds2_CheckedChanged(sender As Object, e As EventArgs) Handles optNoSpeeds2.CheckedChanged
        Try
            numspeeds = 2
            SpeedFill()
        Catch ex As Exception
            ErrorMessage(ex, 20707)
        End Try
    End Sub

    Private Sub optNoSpeeds3_CheckedChanged(sender As Object, e As EventArgs) Handles optNoSpeeds3.CheckedChanged
        Try
            numspeeds = 3
            SpeedFill()
        Catch ex As Exception
            ErrorMessage(ex, 20708)
        End Try
    End Sub

    Private Sub optNoSpeeds4_CheckedChanged(sender As Object, e As EventArgs) Handles optNoSpeeds4.CheckedChanged
        Try
            numspeeds = 4
            SpeedFill()
        Catch ex As Exception
            ErrorMessage(ex, 20709)
        End Try
    End Sub

    Private Sub optNoSpeeds5_CheckedChanged(sender As Object, e As EventArgs) Handles optNoSpeeds5.CheckedChanged
        Try
            numspeeds = 5
            SpeedFill()
        Catch ex As Exception
            ErrorMessage(ex, 20710)
        End Try
    End Sub

    Private Sub optNoSpeeds6_CheckedChanged(sender As Object, e As EventArgs) Handles optNoSpeeds6.CheckedChanged
        Try
            numspeeds = 6
            SpeedFill()
        Catch ex As Exception
            ErrorMessage(ex, 20711)
        End Try
    End Sub

    Private Sub optNoSpeeds7_CheckedChanged(sender As Object, e As EventArgs) Handles optNoSpeeds7.CheckedChanged
        Try
            numspeeds = 7
            SpeedFill()
        Catch ex As Exception
            ErrorMessage(ex, 20712)
        End Try
    End Sub

    Private Sub optNoSpeeds8_CheckedChanged(sender As Object, e As EventArgs) Handles optNoSpeeds8.CheckedChanged
        Try
            numspeeds = 8
            SpeedFill()
        Catch ex As Exception
            ErrorMessage(ex, 20713)
        End Try
    End Sub

    Private Sub optNoDensities1_CheckedChanged(sender As Object, e As EventArgs) Handles optNoDensities1.CheckedChanged
        Try
            numdensities = 1
            DensityFill()
        Catch ex As Exception
            ErrorMessage(ex, 20714)
        End Try
    End Sub

    Private Sub optNoDensities2_CheckedChanged(sender As Object, e As EventArgs) Handles optNoDensities2.CheckedChanged
        Try
            numdensities = 2
            DensityFill()
        Catch ex As Exception
            ErrorMessage(ex, 20715)
        End Try
    End Sub

    Private Sub optNoDensities3_CheckedChanged(sender As Object, e As EventArgs) Handles optNoDensities3.CheckedChanged
        Try
            numdensities = 3
            DensityFill()
        Catch ex As Exception
            ErrorMessage(ex, 20716)
        End Try
    End Sub

    Private Sub optNoDensities4_CheckedChanged(sender As Object, e As EventArgs) Handles optNoDensities4.CheckedChanged
        Try
            numdensities = 4
            DensityFill()
        Catch ex As Exception
            ErrorMessage(ex, 20717)
        End Try
    End Sub

    Private Sub optNoDensities5_CheckedChanged(sender As Object, e As EventArgs) Handles optNoDensities5.CheckedChanged
        Try
            numdensities = 5
            DensityFill()
        Catch ex As Exception
            ErrorMessage(ex, 20718)
        End Try
    End Sub

    Private Sub optNoDensities6_CheckedChanged(sender As Object, e As EventArgs) Handles optNoDensities6.CheckedChanged
        Try
            numdensities = 6
            DensityFill()
        Catch ex As Exception
            ErrorMessage(ex, 20719)
        End Try
    End Sub

    Private Sub optNoDensities7_CheckedChanged(sender As Object, e As EventArgs) Handles optNoDensities7.CheckedChanged
        Try
            numdensities = 7
            DensityFill()
        Catch ex As Exception
            ErrorMessage(ex, 20720)
        End Try
    End Sub

    Private Sub optNoDensities8_CheckedChanged(sender As Object, e As EventArgs) Handles optNoDensities8.CheckedChanged
        Try
            numdensities = 8
            DensityFill()
        Catch ex As Exception
            ErrorMessage(ex, 20721)
        End Try
    End Sub

    Private Sub chkDamper_CheckedChanged(sender As Object, e As EventArgs) Handles chkDamper.CheckedChanged
        Try
            IncludeDampers = chkDamper.Checked
            If chkDamper.Checked = True Then
                optNoSpeeds1.Checked = True
                optNoDensities1.Checked = True
            End If
            chkDamper.Checked = IncludeDampers
        Catch ex As Exception
            ErrorMessage(ex, 20722)
        End Try
    End Sub

    Private Sub chkSystem_CheckedChanged(sender As Object, e As EventArgs) Handles chkSystem.CheckedChanged
        Try
            IncludeSystem = chkSystem.Checked
            If chkSystem.Checked = True Then
                optNoSpeeds1.Checked = True
                optNoDensities1.Checked = True
            End If
            chkSystem.Checked = IncludeSystem
        Catch ex As Exception
            ErrorMessage(ex, 20723)
        End Try
    End Sub

    '#######################################################################################

    Public Sub PopulateFanListBox()
        Dim filenameref As String = "FILENAME REF DATA"
        Try
            'lstFanDesigns.Columns.Add("Design", 100, HorizontalAlignment.Left)
            'lstFanDesigns.Columns.Add("Description", 300, HorizontalAlignment.Left)
            'Dim str(1) As String
            Dim k As Integer = 0
            Dim ih As Integer = 0

            FullFilePath = DataPath + filenameref + ".bin"
            fs = New System.IO.FileStream(FullFilePath, IO.FileMode.Open)
            br = New System.IO.BinaryReader(fs)
            Dim j As Integer
            Dim index As Integer
            br.BaseStream.Seek(0, IO.SeekOrigin.Begin)
            Try
                For j = 0 To 100
                    fantypename(j) = br.ReadString()
                    fanclass(j) = br.ReadString()
                    fantypefilename(j) = br.ReadString()
                    fansizelimit(j) = br.ReadInt32()
                    If fansizelimit(j) = 0 Then fansizelimit(j) = 102
                    fantypesecfilename(j) = br.ReadString()
                    fanunits(j) = br.ReadString()
                    fanwidthing(j) = br.ReadBoolean()

                    fanwide(j) = br.ReadBoolean()
                    fanmedium(j) = br.ReadBoolean()
                    fannarrow(j) = br.ReadBoolean()
                    fanhighpressure(j) = br.ReadBoolean()
                    faninclined(j) = br.ReadBoolean()
                    fancurved(j) = br.ReadBoolean()
                    fanpaddle(j) = br.ReadBoolean()
                    fanradial(j) = br.ReadBoolean()
                    fanplastic(j) = br.ReadBoolean()
                    fanother(j) = br.ReadBoolean()

                    For index = 141 To 170
                        If lang_dict(2, index) = fantypename(j) Then
                            fantypename(j) = lang_dict(1, index)
                            Exit For
                        End If
                    Next


                    'j = j - 1
                    If Not lstFanDesigns.Items.Contains(fantypename(j)) Then
                        lstFanDesigns.Items.Add(fantypename(j)) 'akm
                        fanclasstemp(k) = fanclass(j)
                        k = k + 1
                    End If
                    'ih = lstFanDesigns.GetItemHeight(k) + ih
                Next
                k = k - 1
                'lstFanDesigns.Height = ih

                'Dim arr As String() = {"aa", "bb", "cc"}

            Catch ex As Exception
            Finally
                br.Close()
            End Try
        Catch ex As Exception
            ErrorMessage(ex, 20724)
        End Try
    End Sub

    Private Sub lstFanDesigns_Click(sender As Object, e As EventArgs) Handles lstFanDesigns.Click
        Try
            txtFanDesign.Text = fanclasstemp(lstFanDesigns.SelectedIndex)
            If txtFanDesign.Text.ToLower.Contains("nwpb") Then
                lblWidthing.Enabled = True
                txtWidthing.Enabled = True
                lblPerCent.Enabled = True
            Else
                lblWidthing.Enabled = False
                txtWidthing.Enabled = False
                lblPerCent.Enabled = False
            End If
        Catch ex As Exception
            ErrorMessage(ex, 20725)
        End Try
    End Sub

    Private Sub lstFanDesigns_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFanDesigns.SelectedIndexChanged
        Try
            txtFanDesign.Text = fanclasstemp(lstFanDesigns.SelectedIndex)
            If txtFanDesign.Text.ToLower.Contains("nwpb") Then
                lblWidthing.Enabled = True
                txtWidthing.Enabled = True
                lblPerCent.Enabled = True
            Else
                lblWidthing.Enabled = False
                txtWidthing.Enabled = False
                lblPerCent.Enabled = False
            End If
        Catch ex As Exception
            ErrorMessage(ex, 20726)
        End Try
    End Sub

    'Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    '    Close()
    'End Sub

    'Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
    '    Try
    '        getLanguageDictionary()
    '        SetUnitStructure()
    '        move_on = True
    '        Yellow(txtFanSpeed)
    '        Yellow(txtDensity)
    '        Yellow(txtFanSize)
    '        'Yellow(txtFanDesign)
    '        YellowLst(lstFanDesigns)


    '        If move_on = True Then
    '            final.speed = CDbl(txtFanSpeed.Text)
    '            knowndensity = CDbl(txtDensity.Text)
    '            final.fansize = CDbl(txtFanSize.Text)
    '            final.fantype = txtFanDesign.Text
    '            final.fantypename = lstFanDesigns.SelectedItem

    '            Units(0).UnitSelected = cmbFlowUnits.SelectedIndex
    '            Units(1).UnitSelected = cmbPressureUnits.SelectedIndex
    '            Units(3).UnitSelected = cmbDensityUnits.SelectedIndex
    '            Units(4).UnitSelected = cmbPowerUnits.SelectedIndex
    '            Units(5).UnitSelected = cmbLengthUnits.SelectedIndex
    '            'For i = 0 To 2
    '            '    Flag(i) = True
    '            'Next

    '            PrintLanguage = 1
    '            'OpenFileName = "Standalone Curve"
    '            'Flag(4) = True
    '            SaveProjectFile(False)
    '            'If OpenFileName = "" And SaveFileName = "" Then
    '            '    'MsgBox(lblSaveProject.Text, vbOKOnly + vbInformation, "")
    '            '    MsgBox("Save project please", vbOKOnly + vbInformation, "")
    '            '    Exit Sub
    '            'End If
    '            Me.Hide()
    '            CreateFile(3)
    '        End If
    '    Catch ex As Exception
    '        ErrorMessage(ex, 20391)
    '    End Try
    'End Sub

    Private Sub cmbDensityUnits_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDensityUnits.SelectedIndexChanged
        Try
            lblDensityUnit.Text = cmbDensityUnits.SelectedItem
        Catch ex As Exception
            ErrorMessage(ex, 20727)
        End Try
    End Sub

    Private Sub cmbLengthUnits_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLengthUnits.SelectedIndexChanged
        Try
            lblSizeUnit.Text = cmbLengthUnits.SelectedItem
        Catch ex As Exception
            ErrorMessage(ex, 20728)
        End Try
    End Sub

    Private Sub txtFanSpeed_TextChanged(sender As Object, e As EventArgs) Handles txtFanSpeed.TextChanged
        Try
            txtSpeed1.Text = txtFanSpeed.Text
        Catch ex As Exception
            ErrorMessage(ex, 20729)
        End Try

    End Sub

    Private Sub txtDensity_TextChanged(sender As Object, e As EventArgs) Handles txtDensity.TextChanged
        Try
            txtDensity1.Text = txtDensity.Text
        Catch ex As Exception
            ErrorMessage(ex, 20730)
        End Try
    End Sub

    Private Sub ApplyLocale(ByVal locale_name As String)
        Try
            ' Make a CultureInfo and ComponentResourceManager.
            Dim culture_info As New CultureInfo(locale_name)
            Dim component_resource_manager As New ComponentResourceManager(Me.GetType)

            ' Make the thread use this locale. This doesn't change
            ' existing controls but will apply to those loaded later
            ' and to messages we get for Help About (see below).
            Thread.CurrentThread.CurrentUICulture = culture_info
            Thread.CurrentThread.CurrentCulture = culture_info

            ' Apply the locale to the form itself.
            component_resource_manager.ApplyResources(Me, "$this", culture_info)
            'If grpLanguage.Visible = False Then MsgBox("invisible")
            ' Apply the locale to the form's controls.
            For Each ctl As Control In Me.Controls
                ApplyLocaleToControl(ctl, component_resource_manager, culture_info)
            Next ctl

            ' Perform manual localizations.
            ' These resources are stored in the Form1 resource files.
            Dim resource_manager As New ResourceManager("Localized.FrmStart", Me.GetType.Assembly)
        Catch ex As Exception
            ErrorMessage(ex, 20731)
        End Try
    End Sub

    Private Sub ApplyLocaleToControl(ByVal ctl As Control, ByVal component_resource_manager As ComponentResourceManager, ByVal culture_info As CultureInfo)
        Try
            component_resource_manager.ApplyResources(ctl, ctl.Name, culture_info)

            ' See what kind of control this is.
            'If TypeOf ctl Is MenuStrip Then
            '    ' Apply the new locale to the MenuStrip's items.
            '    Dim menu_strip As MenuStrip = DirectCast(ctl, MenuStrip)
            '    For Each child As ToolStripMenuItem In menu_strip.Items
            '        'ApplyLocaleToToolStripItem(child, component_resource_manager, culture_info)
            '    Next child
            'Else
            ' Apply the new locale to the control's children.
            For Each child As Control In ctl.Controls
                ApplyLocaleToControl(child, component_resource_manager, culture_info)
            Next child
            'End If

        Catch ex As Exception
            ErrorMessage(ex, 20732)
        End Try
    End Sub

    Private Sub optChineseLanguageOutput_Click(sender As Object, e As EventArgs) Handles optChineseLanguageOutput.Click
        Try
            PrintLanguage = 1
        Catch ex As Exception
            ErrorMessage(ex, 20733)
        End Try
    End Sub

    Private Sub optEnglishLanguageOutput_Click(sender As Object, e As EventArgs) Handles optEnglishLanguageOutput.Click
        Try
            PrintLanguage = 2
        Catch ex As Exception
            ErrorMessage(ex, 20734)
        End Try
    End Sub

    Private Sub DensityEmpty()
        Try
            txtDensity1.Text = ""
            txtDensity2.Text = ""
            txtDensity3.Text = ""
            txtDensity4.Text = ""
            txtDensity5.Text = ""
            txtDensity6.Text = ""
            txtDensity7.Text = ""
            txtDensity8.Text = ""
            numdensities = 1
            optNoDensities1.Checked = True
        Catch ex As Exception
            ErrorMessage(ex, 20735)
        End Try
    End Sub

    Private Sub SpeedEmpty()
        Try
            txtSpeed1.Text = ""
            txtSpeed2.Text = ""
            txtSpeed3.Text = ""
            txtSpeed4.Text = ""
            txtSpeed5.Text = ""
            txtSpeed6.Text = ""
            txtSpeed7.Text = ""
            txtSpeed8.Text = ""
            numspeeds = 1
            optNoSpeeds1.Checked = True
        Catch ex As Exception
            ErrorMessage(ex, 20736)
        End Try
    End Sub

    Private Sub chkDutyPoint_CheckedChanged(sender As Object, e As EventArgs) Handles chkDutyPoint.CheckedChanged
        Try
            IncludeDutyPoint = chkDutyPoint.Checked
        Catch ex As Exception
            ErrorMessage(ex, 20737)
        End Try
    End Sub
End Class