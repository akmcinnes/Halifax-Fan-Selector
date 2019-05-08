Public Class FrmCurveOptions
    Private Sub chkDamper_CheckedChanged(sender As Object, e As EventArgs) Handles chkDamper.CheckedChanged
        IncludeDampers = chkDamper.Checked
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Close()
    End Sub

    Private Sub FrmCurveOptions_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToScreen()

        If PresType = 0 Then
            optFSPonly.Checked = True
        Else
            optFTPonly.Checked = True
        End If
    End Sub

    Private Sub chkSystem_CheckedChanged(sender As Object, e As EventArgs) Handles chkSystem.CheckedChanged
        IncludeSystem = chkSystem.Checked
    End Sub
End Class