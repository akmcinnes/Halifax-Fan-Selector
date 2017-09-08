Public Class Start
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Frmselectfan.ShowDialog()
    End Sub

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles Me.Load
        CenterToScreen()
        TextBox1.Text = Environment.UserName
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        end
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            System.Diagnostics.Process.Start("http://www.halifax-fan.co.uk/")
        Catch
            'Code to handle the error.
        End Try
    End Sub
End Class