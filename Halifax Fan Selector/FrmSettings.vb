Public Class FrmSettings
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Background_Color = ColorDialog1.Color

        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ColorDialog1.ShowDialog()
    End Sub
End Class