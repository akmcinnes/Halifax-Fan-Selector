Public Class FrmCurveOptions
    Private Sub chkDamper_CheckedChanged(sender As Object, e As EventArgs) Handles chkDamper.CheckedChanged
        Try
            IncludeDampers = chkDamper.Checked
        Catch ex As Exception
            ErrorMessage(ex, 20701)
        End Try
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Try
            Close()
        Catch ex As Exception
            ErrorMessage(ex, 20702)
        End Try
    End Sub

    Private Sub FrmCurveOptions_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
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
        Catch ex As Exception
            ErrorMessage(ex, 20703)
        End Try
    End Sub

    Private Sub chkSystem_CheckedChanged(sender As Object, e As EventArgs) Handles chkSystem.CheckedChanged
        Try
            IncludeSystem = chkSystem.Checked
        Catch ex As Exception
            ErrorMessage(ex, 20704)
        End Try
    End Sub
    Private Sub optNoSpeeds1_CheckedChanged(sender As Object, e As EventArgs) Handles optNoSpeeds1.CheckedChanged
        Try
            grpMultipleDensities.Enabled = True
            txtSpeed2.Visible = False
            txtSpeed3.Visible = False
            txtSpeed4.Visible = False
            txtSpeed5.Visible = False
            txtSpeed6.Visible = False
            txtSpeed7.Visible = False
            txtSpeed8.Visible = False
        Catch ex As Exception
            ErrorMessage(ex, 20705)
        End Try
    End Sub
    Private Sub optNoSpeeds2_CheckedChanged(sender As Object, e As EventArgs) Handles optNoSpeeds2.CheckedChanged
        Try
            grpMultipleDensities.Enabled = False
            optNoDensities1.Checked = True
            txtSpeed2.Visible = True
            txtSpeed3.Visible = False
            txtSpeed4.Visible = False
            txtSpeed5.Visible = False
            txtSpeed6.Visible = False
            txtSpeed7.Visible = False
            txtSpeed8.Visible = False
        Catch ex As Exception
            ErrorMessage(ex, 20706)
        End Try
    End Sub
    Private Sub optNoSpeeds3_CheckedChanged(sender As Object, e As EventArgs) Handles optNoSpeeds3.CheckedChanged
        Try
            grpMultipleDensities.Enabled = False
            optNoDensities1.Checked = True
            txtSpeed2.Visible = True
            txtSpeed3.Visible = True
            txtSpeed4.Visible = False
            txtSpeed5.Visible = False
            txtSpeed6.Visible = False
            txtSpeed7.Visible = False
            txtSpeed8.Visible = False
        Catch ex As Exception
            ErrorMessage(ex, 20707)
        End Try
    End Sub
    Private Sub optNoSpeeds4_CheckedChanged(sender As Object, e As EventArgs) Handles optNoSpeeds4.CheckedChanged
        Try
            grpMultipleDensities.Enabled = False
            optNoDensities1.Checked = True
            txtSpeed2.Visible = True
            txtSpeed3.Visible = True
            txtSpeed4.Visible = True
            txtSpeed5.Visible = False
            txtSpeed6.Visible = False
            txtSpeed7.Visible = False
            txtSpeed8.Visible = False
        Catch ex As Exception
            ErrorMessage(ex, 20708)
        End Try
    End Sub
    Private Sub optNoSpeeds5_CheckedChanged(sender As Object, e As EventArgs) Handles optNoSpeeds5.CheckedChanged
        Try
            grpMultipleDensities.Enabled = False
            optNoDensities1.Checked = True
            txtSpeed2.Visible = True
            txtSpeed3.Visible = True
            txtSpeed4.Visible = True
            txtSpeed5.Visible = True
            txtSpeed6.Visible = False
            txtSpeed7.Visible = False
            txtSpeed8.Visible = False
        Catch ex As Exception
            ErrorMessage(ex, 20709)
        End Try
    End Sub
    Private Sub optNoSpeeds6_CheckedChanged(sender As Object, e As EventArgs) Handles optNoSpeeds6.CheckedChanged
        Try
            grpMultipleDensities.Enabled = False
            optNoDensities1.Checked = True
            txtSpeed2.Visible = True
            txtSpeed3.Visible = True
            txtSpeed4.Visible = True
            txtSpeed5.Visible = True
            txtSpeed6.Visible = True
            txtSpeed7.Visible = False
            txtSpeed8.Visible = False
        Catch ex As Exception
            ErrorMessage(ex, 20710)
        End Try
    End Sub
    Private Sub optNoSpeeds7_CheckedChanged(sender As Object, e As EventArgs) Handles optNoSpeeds7.CheckedChanged
        Try
            grpMultipleDensities.Enabled = False
            optNoDensities1.Checked = True
            txtSpeed2.Visible = True
            txtSpeed3.Visible = True
            txtSpeed4.Visible = True
            txtSpeed5.Visible = True
            txtSpeed6.Visible = True
            txtSpeed7.Visible = True
            txtSpeed8.Visible = False
        Catch ex As Exception
            ErrorMessage(ex, 20711)
        End Try
    End Sub
    Private Sub optNoSpeeds8_CheckedChanged(sender As Object, e As EventArgs) Handles optNoSpeeds8.CheckedChanged
        Try
            grpMultipleDensities.Enabled = False
            optNoDensities1.Checked = True
            txtSpeed2.Visible = True
            txtSpeed3.Visible = True
            txtSpeed4.Visible = True
            txtSpeed5.Visible = True
            txtSpeed6.Visible = True
            txtSpeed7.Visible = True
            txtSpeed8.Visible = True
        Catch ex As Exception
            ErrorMessage(ex, 20712)
        End Try
    End Sub
    Private Sub optNoDensities1_CheckedChanged(sender As Object, e As EventArgs) Handles optNoDensities1.CheckedChanged
        Try
            grpMultipleSpeeds.Enabled = True
            txtDensity2.Visible = False
            txtDensity3.Visible = False
            txtDensity4.Visible = False
            txtDensity5.Visible = False
            txtDensity6.Visible = False
            txtDensity7.Visible = False
            txtDensity8.Visible = False
        Catch ex As Exception
            ErrorMessage(ex, 20713)
        End Try
    End Sub
    Private Sub optNoDensities2_CheckedChanged(sender As Object, e As EventArgs) Handles optNoDensities2.CheckedChanged
        Try
            grpMultipleSpeeds.Enabled = False
            optNoSpeeds1.Checked = True
            txtDensity2.Visible = True
            txtDensity3.Visible = False
            txtDensity4.Visible = False
            txtDensity5.Visible = False
            txtDensity6.Visible = False
            txtDensity7.Visible = False
            txtDensity8.Visible = False
        Catch ex As Exception
            ErrorMessage(ex, 20714)
        End Try
    End Sub
    Private Sub optNoDensities3_CheckedChanged(sender As Object, e As EventArgs) Handles optNoDensities3.CheckedChanged
        Try
            grpMultipleSpeeds.Enabled = False
            optNoSpeeds1.Checked = True
            txtDensity2.Visible = True
            txtDensity3.Visible = True
            txtDensity4.Visible = False
            txtDensity5.Visible = False
            txtDensity6.Visible = False
            txtDensity7.Visible = False
            txtDensity8.Visible = False
        Catch ex As Exception
            ErrorMessage(ex, 20715)
        End Try
    End Sub
    Private Sub optNoDensities4_CheckedChanged(sender As Object, e As EventArgs) Handles optNoDensities4.CheckedChanged
        Try
            grpMultipleSpeeds.Enabled = False
            optNoSpeeds1.Checked = True
            txtDensity2.Visible = True
            txtDensity3.Visible = True
            txtDensity4.Visible = True
            txtDensity5.Visible = False
            txtDensity6.Visible = False
            txtDensity7.Visible = False
            txtDensity8.Visible = False
        Catch ex As Exception
            ErrorMessage(ex, 20716)
        End Try
    End Sub
    Private Sub optNoDensities5_CheckedChanged(sender As Object, e As EventArgs) Handles optNoDensities5.CheckedChanged
        Try
            grpMultipleSpeeds.Enabled = False
            optNoSpeeds1.Checked = True
            txtDensity2.Visible = True
            txtDensity3.Visible = True
            txtDensity4.Visible = True
            txtDensity5.Visible = True
            txtDensity6.Visible = False
            txtDensity7.Visible = False
            txtDensity8.Visible = False
        Catch ex As Exception
            ErrorMessage(ex, 20717)
        End Try
    End Sub
    Private Sub optNoDensities6_CheckedChanged(sender As Object, e As EventArgs) Handles optNoDensities6.CheckedChanged
        Try
            grpMultipleSpeeds.Enabled = False
            optNoSpeeds1.Checked = True
            txtDensity2.Visible = True
            txtDensity3.Visible = True
            txtDensity4.Visible = True
            txtDensity5.Visible = True
            txtDensity6.Visible = True
            txtDensity7.Visible = False
            txtDensity8.Visible = False
        Catch ex As Exception
            ErrorMessage(ex, 20718)
        End Try
    End Sub
    Private Sub optNoDensities7_CheckedChanged(sender As Object, e As EventArgs) Handles optNoDensities7.CheckedChanged
        Try
            grpMultipleSpeeds.Enabled = False
            optNoSpeeds1.Checked = True
            txtDensity2.Visible = True
            txtDensity3.Visible = True
            txtDensity4.Visible = True
            txtDensity5.Visible = True
            txtDensity6.Visible = True
            txtDensity7.Visible = True
            txtDensity8.Visible = False
        Catch ex As Exception
            ErrorMessage(ex, 20719)
        End Try
    End Sub
    Private Sub optNoDensities8_CheckedChanged(sender As Object, e As EventArgs) Handles optNoDensities8.CheckedChanged
        Try
            grpMultipleSpeeds.Enabled = False
            optNoSpeeds1.Checked = True
            txtDensity2.Visible = True
            txtDensity3.Visible = True
            txtDensity4.Visible = True
            txtDensity5.Visible = True
            txtDensity6.Visible = True
            txtDensity7.Visible = True
            txtDensity8.Visible = True
        Catch ex As Exception
            ErrorMessage(ex, 20720)
        End Try
    End Sub
End Class