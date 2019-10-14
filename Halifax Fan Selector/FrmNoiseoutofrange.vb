Public Class FrmNoiseoutofrange
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Yellow(txtDuctCF, 0)
        Close()
    End Sub

    Private Sub FrmNoiseoutofrange_Load(sender As Object, e As EventArgs) Handles Me.Load
        CenterToScreen()
        lblAboveFlow.Text = Label2.Text + NCQ_Max.ToString + " " + Units(0).UnitName(Units(0).UnitSelected)
        lblAboveFSP.Text = Label3.Text + NCFSP_Max.ToString + " " + Units(1).UnitName(Units(1).UnitSelected)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Frmselectfan.btnFanSelectionsBack_Click(sender, e)
    End Sub
End Class