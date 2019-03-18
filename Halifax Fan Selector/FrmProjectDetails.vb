Public Class FrmProjectDetails
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Try
            Close()

        Catch ex As Exception
            ErrorMessage(ex, 20200)
        End Try
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Try
            If (TxtCustomer.TextLength > 0) Then
                'Frmselectfan.Text = "Halifax Fan Selection Software - " + TxtCustomer.Text
                Frmselectfan.Text = Frmselectfan.Text + " - " + TxtCustomer.Text
                'Else
                '    Frmselectfan.Text = "Halifax Fan Selection Software"
            End If
        Customer = TxtCustomer.Text
        Engineer = TxtEngineer.Text
        Close()

        Catch ex As Exception
            ErrorMessage(ex, 20201)
        End Try
    End Sub

    Private Sub FrmProjectDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            TxtCustomer.Text = Customer
            TxtEngineer.Text = Engineer
        CenterToScreen()

        Catch ex As Exception
            ErrorMessage(ex, 20202)
        End Try
    End Sub

    Private Sub LblCustomer_Click(sender As Object, e As EventArgs) Handles LblCustomer.Click

    End Sub

    Private Sub LblSalesEngineer_Click(sender As Object, e As EventArgs) Handles LblSalesEngineer.Click

    End Sub
End Class