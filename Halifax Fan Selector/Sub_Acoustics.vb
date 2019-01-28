Module Sub_Acoustics
    Public Sub SetAcousticsGrid()
        Try
            With Frmselectfan
                .DataGridView2.Rows.Clear()
                .DataGridView2.Controls.Clear()
                .DataGridView2.ColumnCount = 9
                .DataGridView2.RowCount = 14
                'DataGridView2.Width = 0
                .DataGridView2.Columns(0).Width = 280

                For i = 1 To 8
                    .DataGridView2.Columns(i).Width = 42
                Next
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
                Column_Header2(0, "Octave Mid-Band Frequency (Hz)", "OctComment")
                Column_Header2(1, "63", "Oct63")
                Column_Header2(2, "125", "Oct125")
                Column_Header2(3, "250", "Oct250")
                Column_Header2(4, "500", "Oct500")
                Column_Header2(5, "1000", "Oct1000")
                Column_Header2(6, "2000", "Oct2000")
                Column_Header2(7, "4000", "Oct4000")
                Column_Header2(8, "8000", "Oct8000")

                For i = 0 To .DataGridView2.Columns.Count - 1
                    .DataGridView2.Columns.Item(i).SortMode = DataGridViewColumnSortMode.Programmatic
                Next i
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
            With Frmselectfan
                .lblInDia.Text = finalinletdia.ToString + " mm"
                .lblOutDims.Text = finaloutletlen.ToString + " x " + finaloutletwid.ToString + " mm"
                .lblInletDiameter.Visible = False
                .lblInDia.Visible = False

                .lblOutletDimensions.Visible = False
                .lblOutDims.Visible = False

                If .chkDuct.Checked = True And .chkOpenInlet.Checked = True And .chkOpenOutlet.Checked = True Then
                    'Drow = 17
                    'OIrow = 26
                    'OOrow = 33
                    'bpfroW = 40
                    'brgrow = 42
                    'Motorrow = 44

                    Call DuctCalcs()
                    Call OutputDuct(4)

                    Call EntryandExitLoss()
                    Call OpenInletCalcs()
                    Call OutputOpenInlet(6)
                    .lblInletDiameter.Visible = True
                    .lblInDia.Visible = True

                    Call OpenOutletCalcs()
                    Call OutputOpenOutlet(8)
                    .lblOutletDimensions.Visible = True
                    .lblOutDims.Visible = True

                    ipos = 9
                End If

                If .chkDuct.Checked = True And .chkOpenInlet.Checked = True And .chkOpenOutlet.Checked = False Then
                    'Drow = 17
                    'OIrow = 26
                    'bpfroW = 34
                    'brgrow = 36
                    'Motorrow = 38

                    Call DuctCalcs()
                    Call OutputDuct(4)

                    Call EntryandExitLoss()
                    Call OpenInletCalcs()
                    Call OutputOpenInlet(6)
                    .lblInletDiameter.Visible = True
                    .lblInDia.Visible = True

                    ipos = 7
                End If
                If .chkDuct.Checked = True And .chkOpenInlet.Checked = False And .chkOpenOutlet.Checked = True Then
                    'Drow = 17
                    'OOrow = 26
                    'bpfroW = 34
                    'brgrow = 36
                    'Motorrow = 38

                    Call DuctCalcs()
                    Call OutputDuct(4)

                    Call OpenOutletCalcs()
                    Call OutputOpenOutlet(6)
                    .lblOutletDimensions.Visible = True
                    .lblOutDims.Visible = True

                    ipos = 7
                End If
                If .chkDuct.Checked = False And .chkOpenInlet.Checked = True And .chkOpenOutlet.Checked = True Then
                    'OIrow = 17
                    'OOrow = 24
                    'bpfroW = 31
                    'brgrow = 33
                    'Motorrow = 35

                    Call EntryandExitLoss()
                    Call OpenInletCalcs()
                    Call OutputOpenInlet(4)
                    .lblInletDiameter.Visible = True
                    .lblInDia.Visible = True

                    Call OpenOutletCalcs()
                    Call OutputOpenOutlet(6)
                    .lblOutletDimensions.Visible = True
                    .lblOutDims.Visible = True

                    ipos = 7
                End If

                If .chkDuct.Checked = True And .chkOpenInlet.Checked = False And .chkOpenOutlet.Checked = False Then
                    'Drow = 17
                    'bpfroW = 26
                    'brgrow = 28
                    'Motorrow = 30

                    Call DuctCalcs()
                    Call OutputDuct(4)
                    ipos = 5
                End If
                If .chkDuct.Checked = False And .chkOpenInlet.Checked = True And .chkOpenOutlet.Checked = False Then
                    'OIrow = 17
                    'bpfroW = 24
                    'brgrow = 26
                    'Motorrow = 28

                    Call OpenInletCalcs()
                    Call OutputOpenInlet(4)
                    .lblInletDiameter.Visible = True
                    .lblInDia.Visible = True

                    ipos = 5
                End If
                If .chkDuct.Checked = False And .chkOpenInlet.Checked = False And .chkOpenOutlet.Checked = True Then
                    'OOrow = 17
                    'bpfroW = 24
                    'brgrow = 26
                    'Motorrow = 28

                    Call OpenOutletCalcs()
                    Call OutputOpenOutlet(4)
                    .lblOutletDimensions.Visible = True
                    .lblOutDims.Visible = True

                    ipos = 5
                End If
                If .chkDuct.Checked = False And .chkOpenInlet.Checked = False And .chkOpenOutlet.Checked = False Then
                    'OOrow = 17
                    'bpfroW = 24
                    'brgrow = 26
                    'Motorrow = 28

                    ipos = 2
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

            End With

        Catch ex As Exception
            ErrorMessage(ex, 1403)
        End Try

    End Sub
End Module
