Public Class frmStandaloneCurve
    Public fanclasstemp(50) As String
    Private Sub frmStandaloneCurve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
        cmbFlowUnits.SelectedIndex = 0
        cmbPressureUnits.SelectedIndex = 0
        cmbDensityUnits.SelectedIndex = 0
        cmbPowerUnits.SelectedIndex = 0
        cmbLengthUnits.SelectedIndex = 0
        PopulateFanListBox()
    End Sub

    Public Sub PopulateFanListBox()
        Dim filenameref As String = "FILENAME REF DATA"
        Try
            'lstFanDesigns.Columns.Add("Design", 100, HorizontalAlignment.Left)
            'lstFanDesigns.Columns.Add("Description", 300, HorizontalAlignment.Left)
            'Dim str(1) As String
            Dim k As Integer = 0

            FullFilePath = DataPath + filenameref + ".bin"
            fs = New System.IO.FileStream(FullFilePath, IO.FileMode.Open)
            br = New System.IO.BinaryReader(fs)
            Dim j As Integer
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

                    'j = j - 1
                    If Not lstFanDesigns.Items.Contains(fantypename(j)) Then
                        lstFanDesigns.Items.Add(fantypename(j)) 'akm
                        fanclasstemp(k) = fanclass(j)
                        k = k + 1
                    End If
                Next
                k = k - 1
            Catch ex As Exception
            Finally
                br.Close()
            End Try
        Catch ex As Exception
            ErrorMessage(ex, 5301)
        End Try
    End Sub

    Private Sub lstFanDesigns_Click(sender As Object, e As EventArgs) Handles lstFanDesigns.Click
        txtFanDesign.Text = fanclasstemp(lstFanDesigns.SelectedIndex)
    End Sub

    Private Sub lstFanDesigns_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFanDesigns.SelectedIndexChanged
        txtFanDesign.Text = fanclasstemp(lstFanDesigns.SelectedIndex)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Try
            getLanguageDictionary()
            SetUnitStructure()
            move_on = True
            Yellow(txtFanSpeed)
            Yellow(txtDensity)
            Yellow(txtFanSize)
            'Yellow(txtFanDesign)
            YellowLst(lstFanDesigns)


            If move_on = True Then
                final.speed = CDbl(txtFanSpeed.Text)
                knowndensity = CDbl(txtDensity.Text)
                final.fansize = CDbl(txtFanSize.Text)
                final.fantype = txtFanDesign.Text
                final.fantypename = lstFanDesigns.SelectedItem

                Units(0).UnitSelected = cmbFlowUnits.SelectedIndex
                Units(1).UnitSelected = cmbPressureUnits.SelectedIndex
                Units(3).UnitSelected = cmbDensityUnits.SelectedIndex
                Units(4).UnitSelected = cmbPowerUnits.SelectedIndex
                Units(5).UnitSelected = cmbLengthUnits.SelectedIndex
                'For i = 0 To 2
                '    Flag(i) = True
                'Next

                PrintLanguage = 1
                'OpenFileName = "Standalone Curve"
                'Flag(4) = True
                SaveProjectFile(False)
                'If OpenFileName = "" And SaveFileName = "" Then
                '    'MsgBox(lblSaveProject.Text, vbOKOnly + vbInformation, "")
                '    MsgBox("Save project please", vbOKOnly + vbInformation, "")
                '    Exit Sub
                'End If
                Me.Hide()
                CreateFile(3)
            End If
        Catch ex As Exception
            ErrorMessage(ex, 20391)
        End Try
    End Sub

    Private Sub cmbDensityUnits_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDensityUnits.SelectedIndexChanged
        lblDensityUnit.Text = cmbDensityUnits.SelectedItem
    End Sub

    Private Sub cmbLengthUnits_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLengthUnits.SelectedIndexChanged
        lblSizeUnit.Text = cmbLengthUnits.SelectedItem
    End Sub
End Class