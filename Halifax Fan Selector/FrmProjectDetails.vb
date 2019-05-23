Public Class FrmProjectDetails
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Try
            Close()

        Catch ex As Exception
            ErrorMessage(ex, 20201)
        End Try
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Try
            If (TxtCustomer.TextLength > 0) Then
                Frmselectfan.Text = Frmselectfan.Text + " - " + TxtCustomer.Text
                DefaultHeader = Frmselectfan.Text
            End If
            Customer = TxtCustomer.Text
            Engineer = TxtEngineer.Text
            Close()
        Catch ex As Exception
            ErrorMessage(ex, 20202)
        End Try
    End Sub

    Private Sub FrmProjectDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            TxtCustomer.Text = Customer
            TxtEngineer.Text = Engineer
            CenterToScreen()

        Catch ex As Exception
            ErrorMessage(ex, 20203)
        End Try
    End Sub

End Class