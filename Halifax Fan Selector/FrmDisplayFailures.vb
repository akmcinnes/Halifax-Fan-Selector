Public Class FrmDisplayFailures
    Private Sub FrmDisplayFailures_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim i As Integer
        'If lsvFailedFans.Items.Count > 0 Then
        '    For i = 0 To lsvFailedFans.Items.Count - 1
        '        lsvFailedFans.Items.RemoveAt(i)
        '    Next
        'End If

        'Dim ListItem1 As ListViewItem
        'ListItem1 = New ListViewItem
        'ListItem1.Text = ("column0")
        Dim str(3) As String
        Dim itm As ListViewItem
        For i = 0 To failindex
            str(0) = i.ToString
            str(0) = fanfailures(i, 0)
            str(1) = fanfailures(i, 1)
            itm = New ListViewItem(str)
            lsvFailedFans.Items.Add(itm)
            'lsvFailedFans.Items.Add(New ListViewItem({i.ToString, fanfailures(i, 0), fanfailures(i, 1)}))
            'ListItem1 = lsvFailedFans.Items.Add(fanfailures(i, 0))
            'ListItem1 = lsvFailedFans.Items.Add(fanfailures(i, 1))

            'ListItem1.SubItems.Add(fanfailures(i, 0))    ' maybe .ToString?
            'ListItem1.SubItems.Add(fanfailures(i, 1))

            ' add completed LVI to the LV
            'lsvFailedFans.Items.Add(ListItem1)


        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class