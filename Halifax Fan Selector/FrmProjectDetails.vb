Public Class FrmProjectDetails
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Close()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        If (TxtCustomer.TextLength > 0) Then
            Frmselectfan.Text = "Halifax Fan Selection Software - " + TxtCustomer.Text
        Else
            Frmselectfan.Text = "Halifax Fan Selection Software"
        End If
        Customer = TxtCustomer.Text
        engineer = TxtEngineer.Text
        Close()
    End Sub

    Private Sub FrmProjectDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        TxtCustomer.Text = Customer
        TxtEngineer.Text = Engineer
        CenterToScreen()
    End Sub
End Class