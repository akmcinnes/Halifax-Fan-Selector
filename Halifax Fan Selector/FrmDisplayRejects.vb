﻿Public Class FrmDisplayRejects
    Private Sub FrmDisplayRejects_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim i As Integer
            Dim str(3) As String
            Dim itm As ListViewItem
            For i = 0 To failindex
                str(0) = i.ToString
                str(0) = fanfailures(i, 0)
                str(1) = fanfailures(i, 1)
                itm = New ListViewItem(str)
                lsvFailedFans.Items.Add(itm)
            Next
        Catch ex As Exception
            ErrorMessage(ex, 20600)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Close()
        Catch ex As Exception
            ErrorMessage(ex, 20601)
        End Try
    End Sub
End Class