Imports System.Xml
Module Sub_ProjectFile
    Sub SaveProjectFile()
        Try
            'set values for saving
            Dim SaveFileDialog1 As SaveFileDialog = New SaveFileDialog()
            SaveFileDialog1.InitialDirectory = ProjectPathDefault '"c:\Halifax\Projects\"
            SaveFileDialog1.Filter = "Halifax Selection|*.hfs"
            SaveFileDialog1.Title = "Save a Halifax Selection File"
            SaveFileDialog1.ShowDialog()
            SaveFileName = SaveFileDialog1.FileName

            If (SaveFileName.Length > 0) Then
                WriteAllFile(SaveFileName)
                MsgBox("File has been saved")
            End If
        Catch ex As Exception
            ErrorMessage(ex, 1501)
        End Try
    End Sub

    Sub ReadProjectFile(OpenFileName As String)
        Try
            ReadAllFile(OpenFileName)

            With Frmselectfan
                .TxtAtmosphericPressure.Text = atmos.ToString
                .TxtDesignTemperature.Text = designtemp.ToString
                .TxtMaximumTemperature.Text = maximumtemp.ToString
                .TxtAmbientTemperature.Text = ambienttemp.ToString
                .TxtAltitude.Text = altitude.ToString
                .TxtHumidity.Text = humidity.ToString
                .TxtAtmosphericPressure.Text = atmospress.ToString
                .Txtdens.Text = knowndensity.ToString
                .Txtflow.Text = flowrate.ToString
                .TxtInletPressure.Text = inletpress.ToString
                .TxtDischargePressure.Text = dischpress.ToString
                .Txtfsp.Text = pressrise.ToString
                .CmbReserveHead.Text = reshead.ToString + "%"
                .Txtspeedlimit.Text = maxspeed.ToString
                ReadFromProjectFile = True
            End With
        Catch ex As Exception
            ErrorMessage(ex, 1502)
        End Try
    End Sub
End Module
