Public Class FrmEnvironmentInfo
    Private Sub FrmEnvironmentInfo_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.CenterToScreen()
            NewProject = True
            'TabPageNoise.Visible = False
            ''TabControl1.TabPages.Remove(TabPageSelection)
            ''TabControl1.TabPages.Remove(TabPageNoise)
            ''TabControl1.TabPages.Remove(TabPageImpeller)
            'TabControl1.TabPages(3).Enabled = False
            Initialize(False)
            TxtAtmosphericPressure.Text = atmos.ToString
            TxtAmbientTemperature.Text = ambienttemp.ToString
            TxtAltitude.Text = altitude.ToString
            TxtHumidity.Text = humidity.ToString
            TxtAtmosphericPressure.Text = atmospress.ToString
            Opt50Hz.Checked = True
            Opt60Hz.Checked = False
        Catch ex As Exception
            MsgBox("load")
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        FrmDutyInput.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class