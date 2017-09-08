Imports System.Xml
Public Class Frmselectfan
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        NewProject = True
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If FileSaved = False Then
            If MsgBox("Project not saved - do you wish to save your project now?", vbYesNo, "Warning") = vbNo Then
                End
            End If
        End If
        '        End
    End Sub

    Private Sub ProjectDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectDetailsToolStripMenuItem.Click
        FrmProjectDetails.ShowDialog()
    End Sub

    Private Sub UnitsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles UnitsToolStripMenuItem.Click
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
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        NewProject = True
        Initialize()
    End Sub

    Private Sub SaveProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveProjectToolStripMenuItem.Click
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

    End Sub

    Private Sub OpenProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenProjectToolStripMenuItem.Click
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


    End Sub

    Private Sub ExitProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitProjectToolStripMenuItem.Click
        If FileSaved = False Then
            If MsgBox("Project not saved - do you wish to save your project now?", vbYesNo, "Warning") = vbNo Then
                End
            End If
        End If
        '        End

    End Sub

    Private Sub OptDensityCalculated_CheckedChanged(sender As Object, e As EventArgs) Handles OptDensityCalculated.CheckedChanged
        If (OptDensityCalculated.Checked = True) Then
            RunTemp = Val(TxtDesignTemperature.Text)
            If Units(2).UnitSelected = 1 Then RunTemp = Math.Round(((RunTemp - 32) * 5 / 9), 1)
            Txtdens.Text = Math.Round((293 / (RunTemp + 273)) * 1.2, 3)
            Txtdens.ReadOnly = True
        Else
            Txtdens.ReadOnly = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call initializeSelections()
        FrmSelections.ColumnHeader(0) = Units(6).UnitName(Units(5).UnitSelected) '"mm" 'Frmselectfan.Comimpunits.Text
        FrmSelections.ColumnHeader(1) = " "
        FrmSelections.ColumnHeader(2) = "RPM"
        FrmSelections.ColumnHeader(3) = Units(0).UnitName(Units(0).UnitSelected) '"m³/hr" 'Frmselectfan.Comflowunits.Text
        FrmSelections.ColumnHeader(4) = Units(1).UnitName(Units(1).UnitSelected) '"Pa" 'Frmselectfan.Comfspunits.Text
        FrmSelections.ColumnHeader(5) = Units(1).UnitName(Units(1).UnitSelected) '"Pa" 'Frmselectfan.Comfspunits.Text
        FrmSelections.ColumnHeader(6) = Units(4).UnitName(Units(4).UnitSelected) ' "kW" 'Frmselectfan.Compowunits.Text
        FrmSelections.ColumnHeader(7) = Units(4).UnitName(Units(4).UnitSelected) ' "kW" 'Frmselectfan.Compowunits.Text
        FrmSelections.ColumnHeader(8) = "%"
        FrmSelections.ColumnHeader(9) = "%"
        FrmSelections.ColumnHeader(10) = Units(7).UnitName(Units(7).UnitSelected) '"m/s"
        FrmSelections.ColumnHeader(11) = "%"
        FrmSelections.ColumnHeader(12) = "%"
        FrmSelections.LblGasDensityUnit.Text = Units(3).UnitName(Units(3).UnitSelected) '"kg/m³" 'Frmselectfan.Comairdenunits.Text
        FrmSelections.TxtDensity.Text = Txtdens.Text 'Round(originaldensity, 3)
        originaldensity = Val(Txtdens.Text)
        FrmSelections.ShowDialog()
    End Sub
    Sub initializeSelections()
        For i = 0 To 29
            selectedfansize(0) = 0.0
            selectedfantype(0) = ""
            selectedfse(0) = 0.0
            selectedspeed(0) = 0.0
            selectedpow(0) = 0.0
            selectedfsp(0) = 0.0
            selectedfte(0) = 0.0
            selectedftp(0) = 0.0
            selectedov(0) = 0.0
            selectedvol(0) = 0.0
            selectedmot(0) = 0.0
            selectedresHD(0) = 0.0
            selectedVD(0) = 0.0
        Next
        fantypesQTY = 0
    End Sub
End Class
