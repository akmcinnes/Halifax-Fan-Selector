Public Class FrmCurveOptions
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

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Try
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
            Close()
        Catch ex As Exception
            ErrorMessage(ex, 20702)
        End Try
    End Sub

    Private Sub optNoSpeeds1_CheckedChanged(sender As Object, e As EventArgs) Handles optNoSpeeds1.CheckedChanged
        Try
            numspeeds = 1
            SpeedFill()
        Catch ex As Exception
            ErrorMessage(ex, 20705)
        End Try
    End Sub
    Private Sub optNoSpeeds2_CheckedChanged(sender As Object, e As EventArgs) Handles optNoSpeeds2.CheckedChanged
        Try
            numspeeds = 2
            SpeedFill()
        Catch ex As Exception
            ErrorMessage(ex, 20706)
        End Try
    End Sub
    Private Sub optNoSpeeds3_CheckedChanged(sender As Object, e As EventArgs) Handles optNoSpeeds3.CheckedChanged
        Try
            numspeeds = 3
            SpeedFill()
        Catch ex As Exception
            ErrorMessage(ex, 20707)
        End Try
    End Sub
    Private Sub optNoSpeeds4_CheckedChanged(sender As Object, e As EventArgs) Handles optNoSpeeds4.CheckedChanged
        Try
            numspeeds = 4
            SpeedFill()
        Catch ex As Exception
            ErrorMessage(ex, 20708)
        End Try
    End Sub
    Private Sub optNoSpeeds5_CheckedChanged(sender As Object, e As EventArgs) Handles optNoSpeeds5.CheckedChanged
        Try
            numspeeds = 5
            SpeedFill()
        Catch ex As Exception
            ErrorMessage(ex, 20709)
        End Try
    End Sub
    Private Sub optNoSpeeds6_CheckedChanged(sender As Object, e As EventArgs) Handles optNoSpeeds6.CheckedChanged
        Try
            numspeeds = 6
            SpeedFill()
        Catch ex As Exception
            ErrorMessage(ex, 20710)
        End Try
    End Sub
    Private Sub optNoSpeeds7_CheckedChanged(sender As Object, e As EventArgs) Handles optNoSpeeds7.CheckedChanged
        Try
            numspeeds = 7
            SpeedFill()
        Catch ex As Exception
            ErrorMessage(ex, 20711)
        End Try
    End Sub
    Private Sub optNoSpeeds8_CheckedChanged(sender As Object, e As EventArgs) Handles optNoSpeeds8.CheckedChanged
        Try
            numspeeds = 8
            SpeedFill()
        Catch ex As Exception
            ErrorMessage(ex, 20712)
        End Try
    End Sub
    Private Sub optNoDensities1_CheckedChanged(sender As Object, e As EventArgs) Handles optNoDensities1.CheckedChanged
        Try
            numdensities = 1
            DensityFill()
        Catch ex As Exception
            ErrorMessage(ex, 20713)
        End Try
    End Sub
    Private Sub optNoDensities2_CheckedChanged(sender As Object, e As EventArgs) Handles optNoDensities2.CheckedChanged
        Try
            numdensities = 2
            DensityFill()
        Catch ex As Exception
            ErrorMessage(ex, 20714)
        End Try
    End Sub
    Private Sub optNoDensities3_CheckedChanged(sender As Object, e As EventArgs) Handles optNoDensities3.CheckedChanged
        Try
            numdensities = 3
            DensityFill()
        Catch ex As Exception
            ErrorMessage(ex, 20715)
        End Try
    End Sub
    Private Sub optNoDensities4_CheckedChanged(sender As Object, e As EventArgs) Handles optNoDensities4.CheckedChanged
        Try
            numdensities = 4
            DensityFill()
        Catch ex As Exception
            ErrorMessage(ex, 20716)
        End Try
    End Sub
    Private Sub optNoDensities5_CheckedChanged(sender As Object, e As EventArgs) Handles optNoDensities5.CheckedChanged
        Try
            numdensities = 5
            DensityFill()
        Catch ex As Exception
            ErrorMessage(ex, 20717)
        End Try
    End Sub
    Private Sub optNoDensities6_CheckedChanged(sender As Object, e As EventArgs) Handles optNoDensities6.CheckedChanged
        Try
            numdensities = 6
            DensityFill()
        Catch ex As Exception
            ErrorMessage(ex, 20718)
        End Try
    End Sub
    Private Sub optNoDensities7_CheckedChanged(sender As Object, e As EventArgs) Handles optNoDensities7.CheckedChanged
        Try
            numdensities = 7
            DensityFill()
        Catch ex As Exception
            ErrorMessage(ex, 20719)
        End Try
    End Sub
    Private Sub optNoDensities8_CheckedChanged(sender As Object, e As EventArgs) Handles optNoDensities8.CheckedChanged
        Try
            numdensities = 8
            DensityFill()
        Catch ex As Exception
            ErrorMessage(ex, 20720)
        End Try
    End Sub

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
            ErrorMessage(ex, 20721)
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
            ErrorMessage(ex, 20722)
        End Try
    End Sub

    Private Sub chkDamper_Click(sender As Object, e As EventArgs) Handles chkDamper.Click
        Try
            IncludeDampers = chkDamper.Checked
            If chkDamper.Checked = True Then
                optNoSpeeds1.Checked = True
                optNoDensities1.Checked = True
            End If
            chkDamper.Checked = IncludeDampers
        Catch ex As Exception
            ErrorMessage(ex, 20701)
        End Try
    End Sub

    Private Sub chkSystem_Click(sender As Object, e As EventArgs) Handles chkSystem.Click
        Try
            IncludeSystem = chkSystem.Checked
            If chkSystem.Checked = True Then
                optNoSpeeds1.Checked = True
                optNoDensities1.Checked = True
            End If
            chkSystem.Checked = IncludeSystem
        Catch ex As Exception
            ErrorMessage(ex, 20704)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

End Class