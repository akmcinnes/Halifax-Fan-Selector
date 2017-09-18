Public Class FrmStart
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Frmselectfan.ShowDialog()
    End Sub

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles Me.Load
        objStreamWriterDebug.WriteLine("start")

        CenterToScreen()
        TextBox1.Text = Environment.UserName
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            System.Diagnostics.Process.Start("http://www.halifax-fan.co.uk/")
        Catch
            'Code to handle the error.
        End Try
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub TextBox1_MouseHover(sender As Object, e As EventArgs) Handles TextBox1.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub TextBox1_MouseLeave(sender As Object, e As EventArgs) Handles TextBox1.MouseLeave
        Cursor = Cursors.Default
    End Sub
End Class