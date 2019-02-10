Imports System.ComponentModel
Imports System.IO
Public Class FrmDensityCalcs
    Public FullFilePath As String
    Private Sub DensityCalcs_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            CenterToScreen()
            GasInitialise()
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
        Dim dip As Double
            'dip = CDbl(Frmselectfan.TxtInletPressure.Text)
            dip = inletpress
            If Frmselectfan.Optsucy.Checked Then
                dip = dip * (-1)
            End If
            TextBox1.Text = Frmselectfan.TxtDesignTemperature.Text
        TextBox2.Text = dip.ToString
        TextBox3.Text = Frmselectfan.TxtHumidity.Text
        TextBox4.Text = Frmselectfan.TxtAltitude.Text
        TextBox5.Text = (CDbl(TextBox1.Text) * 9 / 5 + 32).ToString
        TextBox6.Text = Nothing
        TextBox7.Text = Nothing

        Catch ex As Exception
            ErrorMessage(ex, 20000)
        End Try
    End Sub

    Sub ReadGasfromTextfile(filename)
        Try
            'FullFilePath = "C:\Halifax\Performance Data new\" + filename + ".bin"
            FullFilePath = DataPath + filename + ".bin"
            Dim j As Integer

            fs = New System.IO.FileStream(FullFilePath, IO.FileMode.Open)
            br = New System.IO.BinaryReader(fs)

            br.BaseStream.Seek(0, IO.SeekOrigin.Begin)
            Try
                For j = 0 To 100
                    GasesIn(j).GasName = br.ReadString()
                    GasesIn(j).GasFormula = br.ReadString()
                    GasesIn(j).GasMW = br.ReadDouble()
                    GasesIn(j).GasDensity = br.ReadDouble()
                    GasesIn(j).GasMassFraction = 0.0
                    GasesIn(j).GasVolumeFraction = 0.0
                    GasesIn(j).GasMoleFraction = 0.0
                    'GasesIn(j).GasDensity = 0.0
                    ListBox1.Items.Add((j + 1).ToString + ". " + GasesIn(j).GasName)
                Next

            Catch ex As Exception
            Finally
                br.Close()
            End Try
        Catch ex As Exception
            'MsgBox("ReadGasfromTextfile")
            ErrorMessage(ex, 20001)
        End Try
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        Try
            Dim selectedItems = (From i In ListBox1.SelectedItems).ToArray()
            gridrow = gridrow + 1
        Dim j As Integer
        For Each selectedItem In selectedItems
            ListBox1.Items.Remove(selectedItem)
            DataGridView1.Rows(gasnum).Cells(0).Value = selectedItem
            j = selectedItem.IndexOf(".")
            gaspicked(gasnum) = CInt(selectedItem.substring(0, j)) - 1
            DataGridView1.Rows(gasnum).Cells(0).ReadOnly = True
            For i = 1 To 1 '3
                DataGridView1.Rows(gasnum).Cells(i).ReadOnly = False
            Next i

            If gasnum = maxgasnum - 1 Then
                ListBox1.Enabled = False
            End If
            If RadioButton2.Checked = True And DataGridView1.Rows(gasnum).Cells(0).Value.contains("Air") = True And gasnum = 0 Then
                DataGridView1.Rows(gasnum).Cells(1).Value = "1.0"
                DataGridView1.Rows(maxgasnum).Cells(1).Value = "1.0"
                    DataGridView1.Rows(0).Cells(1).Value = ""
                End If
            gasnum = gasnum + 1
        Next

        Catch ex As Exception
            ErrorMessage(ex, 20002)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            ListBox1.Items.Clear()
            Dim i As Integer
            For i = 0 To gasnum
                DataGridView1.Rows.Clear()
            Next
            TextBox7.Text = Nothing
            TextBox6.Text = Nothing
            btnCalculate.Enabled = False
            GasInitialise()

        Catch ex As Exception
            ErrorMessage(ex, 20004)

        End Try
    End Sub

    Private Sub GasInitialise()
        Try
            Dim filenameref As String = "Gas Data " + ChosenLanguage
            'Dim filenameref As String = "Gas Data " + "en-US"
            If RadioButton1.Checked Then DataGridView1.Columns(1).HeaderCell.Value = "Mass Factor"
            If RadioButton2.Checked Then DataGridView1.Columns(1).HeaderCell.Value = "Volume Factor"
            If RadioButton3.Checked Then DataGridView1.Columns(1).HeaderCell.Value = "Mole Factor"
            ListBox1.Items.Clear()
            Dim i, j As Integer
            For i = 0 To gasnum
                DataGridView1.Rows.Clear()
            Next
            TextBox7.Text = Nothing
            TextBox6.Text = Nothing
            btnCalculate.Enabled = False

            ReadGasfromTextfile(filenameref)
            gasnum = 0
            gridrow = 0
            maxgasnum = 5
            DataGridView1.RowCount = maxgasnum + 1
            DataGridView1.Width = DataGridView1.RowHeadersWidth

            For i = 0 To 1 '3
                DataGridView1.Width = DataGridView1.Width + DataGridView1.Columns(i).Width
                DataGridView1.Rows(maxgasnum).Cells(i).Style.BackColor = Color.Beige
                DataGridView1.Rows(maxgasnum).Cells(i).ReadOnly = True
            Next i
            DataGridView1.Height = 20 + DataGridView1.Rows(0).Height * DataGridView1.RowCount + DataGridView1.ColumnHeadersHeight

            For i = 0 To 1 '3
                For j = 0 To maxgasnum
                    DataGridView1.Rows(j).Cells(i).ReadOnly = True
                Next j
            Next i

            DataGridView1.Columns(0).ReadOnly = True
            DataGridView1.Rows(maxgasnum).ReadOnly = True
            DataGridView1.Rows(maxgasnum).Cells(0).Value = "TOTAL"
            ListBox1.Enabled = True

        Catch ex As Exception
            ErrorMessage(ex, 20005)
        End Try
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim i As Integer
        Dim k As Double = 0.0
        'MsgBox("DataGridView1_CellEndEdit")
        Try
            If IsNumeric(DataGridView1.CurrentCell.Value) = False Or IsNothing(DataGridView1.CurrentCell) = True Then
                DataGridView1.CurrentCell.Value = ""
                For i = 0 To maxgasnum - 1
                    k = k + CDbl(DataGridView1.Rows(i).Cells(1).Value)
                    If k > 1.0 Then
                        MsgBox("total must be less than 1.0")
                        k = k - CDbl(DataGridView1.Rows(i).Cells(1).Value)
                        DataGridView1.Rows(i).Cells(1).Value = ""
                        Exit For
                    End If
                Next
                DataGridView1.Rows(maxgasnum).Cells(1).Value = k.ToString
                Exit Sub
            End If
            'DataGridView1.Rows(i).Cells(1)
            For i = 0 To maxgasnum - 1
                k = k + CDbl(DataGridView1.Rows(i).Cells(1).Value)
                If k > 1.0 Then
                    MsgBox("total must be less than 1.0")
                    k = k - CDbl(DataGridView1.Rows(i).Cells(1).Value)
                    DataGridView1.Rows(i).Cells(1).Value = ""
                    Exit For
                End If
            Next
            DataGridView1.Rows(maxgasnum).Cells(1).Value = k.ToString
            btnCalculate.Enabled = False
            If k > 0.999 And k < 1.0001 Then
                btnCalculate.Enabled = True
            End If

        Catch ex As Exception
            'MsgBox("DataGridView1_CellEndEdit")
            ErrorMessage(ex, 20006)
        End Try
    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        Try
            DataGridView1.Columns(1).HeaderCell.Value = "Mass Factor"

        Catch ex As Exception
            ErrorMessage(ex, 20007)
        End Try
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        Try
            DataGridView1.Columns(1).HeaderCell.Value = "Volume Factor"

        Catch ex As Exception
            ErrorMessage(ex, 20008)
        End Try
    End Sub

    Private Sub RadioButton3_Click(sender As Object, e As EventArgs) Handles RadioButton3.Click
        Try
            DataGridView1.Columns(1).HeaderCell.Value = "Mole Factor"

        Catch ex As Exception
            ErrorMessage(ex, 20009)
        End Try
    End Sub

    Private Sub btnReturnToSelection_Click(sender As Object, e As EventArgs) Handles btnReturnToSelection.Click
        Try
            'If Units(3).UnitSelected = 0 And TextBox7.Text IsNot "" Then Frmselectfan.Txtdens.Text = TextBox7.Text
            'If Units(3).UnitSelected = 1 And TextBox6.Text IsNot "" Then Frmselectfan.Txtdens.Text = TextBox6.Text
            If Units(3).UnitSelected = 0 And TextBox7.Text IsNot "" Then Frmselectfan.Txtdens.Text = TextBox7.Text
            If Units(3).UnitSelected = 1 And TextBox6.Text IsNot "" Then Frmselectfan.Txtdens.Text = TextBox6.Text
            Me.Close()

        Catch ex As Exception
            ErrorMessage(ex, 20010)
        End Try
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try
            Dim i As Integer
            altitude2 = CDbl(TextBox4.Text)
        AtmosphericPressure()
        pressure2 = CDbl(TextBox2.Text)
        InletPressure()
        temperature2 = CDbl(TextBox1.Text)
        humidity2 = CDbl(TextBox3.Text)
        CalculatedDensity = 0.0
        Dim calcsum As Double = 0.0
        For i = 0 To gasnum - 1
            GasesOut(i) = GasesIn(gaspicked(i))
            GasesOut(i).GasMassFraction = 0.0
            GasesOut(i).GasVolumeFraction = 0.0
            GasesOut(i).GasMoleFraction = 0.0
            If GasesOut(i).GasName.ToLower = "air" Then
                GasesOut(i).GasDensity = 1.2929 * (1 - (0.3783 * (humidity2 / 100) * WVSP) / (101325))
            End If
            If RadioButton1.Checked = True Then
                GasesOut(i).GasMassFraction = CDbl(DataGridView1.Rows(i).Cells(1).Value)
                GasesOut(i).GasDensity = GasesOut(i).GasMassFraction / GasesOut(i).GasDensity
                calcsum = calcsum + GasesOut(i).GasDensity
            ElseIf RadioButton2.Checked = True Then
                GasesOut(i).GasVolumeFraction = CDbl(DataGridView1.Rows(i).Cells(1).Value)
                GasesOut(i).GasDensity = InletPressure() * GasesOut(i).GasMW * GasesOut(i).GasVolumeFraction / ((8.3144621 * (273.15 + temperature2)))
                calcsum = calcsum + GasesOut(i).GasDensity
            ElseIf RadioButton3.Checked = True Then
                GasesOut(i).GasMoleFraction = CDbl(DataGridView1.Rows(i).Cells(1).Value)
                GasesOut(i).GasDensity = GasesOut(i).GasMoleFraction * GasesOut(i).GasMW
                calcsum = calcsum + GasesOut(i).GasDensity
            End If
        Next
        If RadioButton1.Checked = True Then
            CalculatedDensity = (273.15 / (temperature2 + 273)) * (InletPressure() / 101.325) / calcsum
        ElseIf RadioButton2.Checked = True Then
            CalculatedDensity = calcsum
        ElseIf RadioButton3.Checked = True Then
            CalculatedDensity = (273.15 / (temperature2 + 273)) * (InletPressure() / 101.325) * calcsum / 22.414
        End If
        TextBox7.Text = CalculatedDensity.ToString("0.000")
        TextBox6.Text = (CalculatedDensity * 0.0624).ToString("0.0000")

        Catch ex As Exception
            ErrorMessage(ex, 20011)
        End Try
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        Try
            TextBox5.Text = (CDbl(TextBox1.Text) * 9 / 5 + 32).ToString

        Catch ex As Exception
            ErrorMessage(ex, 20012)
        End Try
    End Sub

    Public Function AtmosphericPressure() As Double
        Try
            AtmosphericPressure = 101.325 * (1 - altitude2 * 0.000022557) ^ 5.2558
            Return AtmosphericPressure

        Catch ex As Exception
            ErrorMessage(ex, 20013)
            Return AtmosphericPressure
        End Try
    End Function

    Public Function InletPressure() As Double
        Try
            InletPressure = AtmosphericPressure() + pressure2
            Return InletPressure

        Catch ex As Exception
            ErrorMessage(ex, 20014)
            Return InletPressure
        End Try
    End Function


    'Private Sub DataGridView1_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DataGridView1.CellBeginEdit
    '    MsgBox("wwww")
    'End Sub


    'Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged

    'End Sub

    'Private Sub DataGridView1_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DataGridView1.CurrentCellDirtyStateChanged
    '    Try
    '        MsgBox("DataGridView1_CurrentCellDirtyStateChanged")
    '        Dim i As Integer
    '        Dim k As Double = 0.0
    '        For i = 0 To maxgasnum - 1
    '            k = k + CDbl(DataGridView1.Rows(i).Cells(1).Value)
    '            If k > 1.0 Then
    '                MsgBox("total must be less than 1.0")
    '                k = k - CDbl(DataGridView1.Rows(i).Cells(1).Value)
    '                DataGridView1.Rows(i).Cells(1).Value = ""
    '                Exit For
    '            End If
    '        Next
    '        DataGridView1.Rows(maxgasnum).Cells(1).Value = k.ToString
    '        btnCalculate.Enabled = False
    '        If k > 0.999 And k < 1.0001 Then
    '            btnCalculate.Enabled = True
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
    '    Try
    '        MsgBox("DataGridView1_CellValueChanged")
    '        Dim i As Integer
    '        Dim k As Double = 0.0
    '        For i = 0 To maxgasnum - 1
    '            k = k + CDbl(DataGridView1.Rows(i).Cells(1).Value)
    '            If k > 1.0 Then
    '                MsgBox("total must be less than 1.0")
    '                k = k - CDbl(DataGridView1.Rows(i).Cells(1).Value)
    '                DataGridView1.Rows(i).Cells(1).Value = ""
    '                Exit For
    '            End If
    '        Next
    '        DataGridView1.Rows(maxgasnum).Cells(1).Value = k.ToString
    '        btnCalculate.Enabled = False
    '        If k > 0.999 And k < 1.0001 Then
    '            btnCalculate.Enabled = True
    '        End If
    '    Catch ex As Exception

    '    End Try

    'End Sub

    'Private Sub DataGridView1_TextChanged(sender As Object, e As EventArgs) Handles DataGridView1.TextChanged
    '    'Try
    '    '    MsgBox("DataGridView1_TextChanged")
    '    '    Dim i As Integer
    '    '    Dim k As Double = 0.0
    '    '    For i = 0 To maxgasnum - 1
    '    '        k = k + CDbl(DataGridView1.Rows(i).Cells(1).Value)
    '    '        If k > 1.0 Then
    '    '            MsgBox("total must be less than 1.0")
    '    '            k = k - CDbl(DataGridView1.Rows(i).Cells(1).Value)
    '    '            DataGridView1.Rows(i).Cells(1).Value = ""
    '    '            Exit For
    '    '        End If
    '    '    Next
    '    '    DataGridView1.Rows(maxgasnum).Cells(1).Value = k.ToString
    '    '    btnCalculate.Enabled = False
    '    '    If k > 0.999 And k < 1.0001 Then
    '    '        btnCalculate.Enabled = True
    '    '    End If
    '    'Catch ex As Exception

    '    'End Try

    'End Sub

    'Private Sub DataGridView1_Validating(sender As Object, e As CancelEventArgs) Handles DataGridView1.Validating
    '    'Try
    '    '    MsgBox("DataGridView1_Validating")
    '    '    Dim i As Integer
    '    '    Dim k As Double = 0.0
    '    '    For i = 0 To maxgasnum - 1
    '    '        k = k + CDbl(DataGridView1.Rows(i).Cells(1).Value)
    '    '        If k > 1.0 Then
    '    '            MsgBox("total must be less than 1.0")
    '    '            k = k - CDbl(DataGridView1.Rows(i).Cells(1).Value)
    '    '            DataGridView1.Rows(i).Cells(1).Value = ""
    '    '            Exit For
    '    '        End If
    '    '    Next
    '    '    DataGridView1.Rows(maxgasnum).Cells(1).Value = k.ToString
    '    '    btnCalculate.Enabled = False
    '    '    If k > 0.999 And k < 1.0001 Then
    '    '        btnCalculate.Enabled = True
    '    '    End If
    '    'Catch ex As Exception

    '    'End Try

    'End Sub

    'Private Sub DataGridView1_CellStateChanged(sender As Object, e As DataGridViewCellStateChangedEventArgs) Handles DataGridView1.CellStateChanged
    '    'Try
    '    '    MsgBox("DataGridView1_CellStateChanged")
    '    '    Dim i As Integer
    '    '    Dim k As Double = 0.0
    '    '    For i = 0 To maxgasnum - 1
    '    '        k = k + CDbl(DataGridView1.Rows(i).Cells(1).Value)
    '    '        If k > 1.0 Then
    '    '            MsgBox("total must be less than 1.0")
    '    '            k = k - CDbl(DataGridView1.Rows(i).Cells(1).Value)
    '    '            DataGridView1.Rows(i).Cells(1).Value = ""
    '    '            Exit For
    '    '        End If
    '    '    Next
    '    '    DataGridView1.Rows(maxgasnum).Cells(1).Value = k.ToString
    '    '    btnCalculate.Enabled = False
    '    '    If k > 0.999 And k < 1.0001 Then
    '    '        btnCalculate.Enabled = True
    '    '    End If
    '    'Catch ex As Exception

    '    'End Try

    'End Sub

    'Private Sub DataGridView1_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
    '    'Try
    '    '    MsgBox("DataGridView1_RowEnter")
    '    '    Dim i As Integer
    '    '    Dim k As Double = 0.0
    '    '    For i = 0 To maxgasnum - 1
    '    '        k = k + CDbl(DataGridView1.Rows(i).Cells(1).Value)
    '    '        If k > 1.0 Then
    '    '            MsgBox("total must be less than 1.0")
    '    '            k = k - CDbl(DataGridView1.Rows(i).Cells(1).Value)
    '    '            DataGridView1.Rows(i).Cells(1).Value = ""
    '    '            Exit For
    '    '        End If
    '    '    Next
    '    '    DataGridView1.Rows(maxgasnum).Cells(1).Value = k.ToString
    '    '    btnCalculate.Enabled = False
    '    '    If k > 0.999 And k < 1.0001 Then
    '    '        btnCalculate.Enabled = True
    '    '    End If
    '    'Catch ex As Exception

    '    'End Try

    'End Sub

    'Private Sub DataGridView1_MouseCaptureChanged(sender As Object, e As EventArgs) Handles DataGridView1.MouseCaptureChanged
    '    'Try
    '    '    MsgBox("DataGridView1_MouseCaptureChanged")
    '    '    Dim i As Integer
    '    '    Dim k As Double = 0.0
    '    '    For i = 0 To maxgasnum - 1
    '    '        k = k + CDbl(DataGridView1.Rows(i).Cells(1).Value)
    '    '        If k > 1.0 Then
    '    '            MsgBox("total must be less than 1.0")
    '    '            k = k - CDbl(DataGridView1.Rows(i).Cells(1).Value)
    '    '            DataGridView1.Rows(i).Cells(1).Value = ""
    '    '            Exit For
    '    '        End If
    '    '    Next
    '    '    DataGridView1.Rows(maxgasnum).Cells(1).Value = k.ToString
    '    '    btnCalculate.Enabled = False
    '    '    If k > 0.999 And k < 1.0001 Then
    '    '        btnCalculate.Enabled = True
    '    '    End If
    '    'Catch ex As Exception

    '    'End Try

    'End Sub
End Class
