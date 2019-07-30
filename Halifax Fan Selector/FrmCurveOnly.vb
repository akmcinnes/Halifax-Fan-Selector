Public Class FrmCurveOnly
    Private Sub cmbDensityUnits_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lstFanDesigns_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lstFanDesigns_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbLengthUnits_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SplitContainer1.Panel1Collapsed = True
        Me.Width = 400
        CenterToScreen()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SplitContainer1.Panel1Collapsed = False
        Me.Width = 900
        CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub FrmCurveOnly_Load(sender As Object, e As EventArgs) Handles Me.Load
        'SplitContainer1.Panel1. = 623
        'SplitContainer1.Panel2.Width = 421
        Me.Width = 900
        CenterToScreen()
    End Sub
End Class