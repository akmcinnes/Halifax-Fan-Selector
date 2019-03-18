Module Sub_Acoustics
    Public Sub SetAcousticsGrid()
        Try
            With Frmselectfan
                .DataGridView2.Rows.Clear()
                .DataGridView2.Controls.Clear()
                .DataGridView2.ColumnCount = 10
                .DataGridView2.RowCount = 14 - 5 - 1
                .DataGridView2.Width = 0
                .DataGridView2.Columns(0).Width = 280

                For i = 1 To 8
                    .DataGridView2.Columns(i).Width = 35 '42
                Next
                .DataGridView2.Columns(9).Width = 55

                For i = 0 To .DataGridView2.ColumnCount - 1
                    .DataGridView2.Width = .DataGridView2.Width + .DataGridView2.Columns(i).Width
                Next
                'MsgBox(.DataGridView2.Width.ToString)

                .DataGridView2.Width = .DataGridView2.Width * 1.01
                'MsgBox(.DataGridView2.Width.ToString)


                .DataGridView2.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 9, FontStyle.Bold)
                .DataGridView2.DefaultCellStyle.Font = New Font("Tahoma", 9)
                .DataGridView2.GridColor = Color.Red
                .DataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.Single

                .DataGridView2.BackgroundColor = Color.LightGray

                .DataGridView2.DefaultCellStyle.SelectionBackColor = Color.Bisque
                .DataGridView2.DefaultCellStyle.SelectionForeColor = Color.Black

                .DataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]

                .DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .DataGridView2.AllowUserToResizeColumns = False

                .DataGridView2.RowsDefaultCellStyle.BackColor = Color.Bisque
                .DataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
                'Column_Header2(0, "Octave Mid-Band Frequency (Hz)", "OctComment")
                Column_Header2(0, Frmselectfan.lblBand.Text + " (Hz)", "OctComment")
                Column_Header2(1, "63", "Oct63")
                Column_Header2(2, "125", "Oct125")
                Column_Header2(3, "250", "Oct250")
                Column_Header2(4, "500", "Oct500")
                Column_Header2(5, "1k", "Oct1k")
                Column_Header2(6, "2k", "Oct2k")
                Column_Header2(7, "4k", "Oct4k")
                Column_Header2(8, "8k", "Oct8k")
                'Column_Header2(9, "Overall", "Overall")
                Column_Header2(9, Frmselectfan.lblOverall.Text, "Overall")

                For i = 0 To .DataGridView2.Columns.Count - 1
                    .DataGridView2.Columns.Item(i).SortMode = DataGridViewColumnSortMode.Programmatic
                Next i
                .DataGridView2.Height = (.DataGridView2.RowCount * 22 + .DataGridView2.ColumnHeadersHeight) * 1.1
                .lblFreeFieldComment.Location = New Point(.lblFreeFieldComment.Left, .DataGridView2.Bottom + 5)
            End With


        Catch ex As Exception
            ErrorMessage(ex, 1400)
        End Try
    End Sub

    Sub Column_Header2(ByVal i As Integer, ByVal headertext As String, ByVal headername As String, Optional ByVal column_value As String = "empty")
        Try
            With Frmselectfan
                .DataGridView2.Columns(i).HeaderText = headertext
            End With
        Catch ex As Exception
            ErrorMessage(ex, 1401)
        End Try
    End Sub

    Public Sub OctaveBands()
        Try

            Dim txt(8) As Label
        For q As Integer = 0 To 7
            txt(q) = New Label()
        Next q

        For q = 0 To 7
            txt(q).BackColor = Color.Red
        Next

        Catch ex As Exception
            ErrorMessage(ex, 1402)
        End Try
    End Sub

    Public Sub OpenDuctCalcs()
        Try
            SetAcousticsGrid()
            OctaveBands()

            CalcSPL()
            Call DuctCalcs()
            OutputSPL()

            Dim ipos As Integer = 0
            Dim lenconv As Double = 1.0
            If Units(5).UnitSelected = 1 Then lenconv = 1.0 / 25.4
            With Frmselectfan

                .lblInDia.Text = Math.Round(final.inletdia * lenconv, lengthdecplaces).ToString + " " + Units(5).UnitName(Units(5).UnitSelected)
                If final.outletlen > 0 And final.outletwid > 0 Then
                    .lblOutDims.Text = Math.Round(final.outletlen * lenconv, lengthdecplaces).ToString + " x " + Math.Round(final.outletwid * lenconv, lengthdecplaces).ToString + " " + Units(5).UnitName(Units(5).UnitSelected)
                Else
                    .lblOutDims.Text = Math.Round(final.outletdia * lenconv).ToString + " " + Units(5).UnitName(Units(5).UnitSelected) + " dia."
                End If
                '.lblOutDims.Text = final.outletlen.ToString + " x " + final.outletwid.ToString + " mm"
                .lblInletDiameter.Visible = False
                .lblInDia.Visible = False

                .lblOutletDimensions.Visible = False
                .lblOutDims.Visible = False
                .lblFreeFieldComment.Visible = False
                ipos = 3
                If .chkDuct.Checked = True And .chkOpenInlet.Checked = True And .chkOpenOutlet.Checked = True Then
                    'Drow = 17
                    'OIrow = 26
                    'OOrow = 33
                    'bpfroW = 40
                    'brgrow = 42
                    'Motorrow = 44

                    Call DuctCalcs()
                    Call OutputDuct(ipos)

                    Call EntryandExitLoss()
                    Call OpenInletCalcs()
                    Call OutputOpenInlet(ipos + 1)
                    .lblInletDiameter.Visible = True
                    .lblInDia.Visible = True

                    Call OpenOutletCalcs()
                    Call OutputOpenOutlet(ipos + 2)
                    .lblOutletDimensions.Visible = True
                    .lblOutDims.Visible = True
                    .lblFreeFieldComment.Visible = True

                    ipos = ipos + 2
                End If

                If .chkDuct.Checked = True And .chkOpenInlet.Checked = True And .chkOpenOutlet.Checked = False Then
                    'Drow = 17
                    'OIrow = 26
                    'bpfroW = 34
                    'brgrow = 36
                    'Motorrow = 38

                    Call DuctCalcs()
                    Call OutputDuct(ipos)

                    Call EntryandExitLoss()
                    Call OpenInletCalcs()
                    Call OutputOpenInlet(ipos + 1)
                    .lblInletDiameter.Visible = True
                    .lblInDia.Visible = True
                    .lblFreeFieldComment.Visible = True

                    ipos = ipos + 1
                End If
                If .chkDuct.Checked = True And .chkOpenInlet.Checked = False And .chkOpenOutlet.Checked = True Then
                    'Drow = 17
                    'OOrow = 26
                    'bpfroW = 34
                    'brgrow = 36
                    'Motorrow = 38

                    Call DuctCalcs()
                    Call OutputDuct(ipos)

                    Call OpenOutletCalcs()
                    Call OutputOpenOutlet(ipos + 1)
                    .lblOutletDimensions.Visible = True
                    .lblOutDims.Visible = True
                    .lblFreeFieldComment.Visible = True

                    ipos = ipos + 1
                End If
                If .chkDuct.Checked = False And .chkOpenInlet.Checked = True And .chkOpenOutlet.Checked = True Then
                    'OIrow = 17
                    'OOrow = 24
                    'bpfroW = 31
                    'brgrow = 33
                    'Motorrow = 35

                    Call EntryandExitLoss()
                    Call OpenInletCalcs()
                    Call OutputOpenInlet(ipos)
                    .lblInletDiameter.Visible = True
                    .lblInDia.Visible = True

                    Call OpenOutletCalcs()
                    Call OutputOpenOutlet(ipos + 1)
                    .lblOutletDimensions.Visible = True
                    .lblOutDims.Visible = True
                    .lblFreeFieldComment.Visible = True

                    ipos = ipos + 1
                End If

                If .chkDuct.Checked = True And .chkOpenInlet.Checked = False And .chkOpenOutlet.Checked = False Then
                    'Drow = 17
                    'bpfroW = 26
                    'brgrow = 28
                    'Motorrow = 30

                    Call DuctCalcs()
                    Call OutputDuct(ipos)
                    .lblFreeFieldComment.Visible = True

                    'ipos = 4
                End If
                If .chkDuct.Checked = False And .chkOpenInlet.Checked = True And .chkOpenOutlet.Checked = False Then
                    'OIrow = 17
                    'bpfroW = 24
                    'brgrow = 26
                    'Motorrow = 28

                    Call OpenInletCalcs()
                    Call OutputOpenInlet(ipos)
                    .lblInletDiameter.Visible = True
                    .lblInDia.Visible = True
                    .lblFreeFieldComment.Visible = True

                    'ipos = 4
                End If
                If .chkDuct.Checked = False And .chkOpenInlet.Checked = False And .chkOpenOutlet.Checked = True Then
                    'OOrow = 17
                    'bpfroW = 24
                    'brgrow = 26
                    'Motorrow = 28

                    Call OpenOutletCalcs()
                    Call OutputOpenOutlet(ipos)
                    .lblOutletDimensions.Visible = True
                    .lblOutDims.Visible = True
                    .lblFreeFieldComment.Visible = True

                    'ipos = 4
                End If
                If .chkDuct.Checked = False And .chkOpenInlet.Checked = False And .chkOpenOutlet.Checked = False Then
                    'OOrow = 17
                    'bpfroW = 24
                    'brgrow = 26
                    'Motorrow = 28
                    .lblFreeFieldComment.Visible = False

                    'ipos = 2
                    ipos = ipos - 1
                End If
                If .chkBrg.Checked = True Then
                    Call CalcBrg()
                    ipos = ipos + 1
                    Call OutputBrg(ipos)
                End If
                If .chkMotor.Checked = True Then
                    ipos = ipos + 1
                    OutputMotor(ipos)
                End If
                Call CalcBPFreq()
                Call OutputBPF(ipos + 1)
                .DataGridView2.RowCount = ipos + 1
                .DataGridView2.Height = (.DataGridView2.RowCount * 22 + .DataGridView2.ColumnHeadersHeight) * 1.1
                .lblFreeFieldComment.Location = New Point(.lblFreeFieldComment.Left, .DataGridView2.Bottom + 5)

            End With
        Catch ex As Exception
            ErrorMessage(ex, 1403)
        End Try

    End Sub
End Module
