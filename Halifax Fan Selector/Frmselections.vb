Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel


Public Class FrmSelections
    Public totalcolumnwidth As Integer
    Public ColumnHeader(20) As String
    '    Public chkadded As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
        '' Set the selection background color for all the cells.
        'DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Red 'White
        'DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White 'Black

        '' Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
        '' value won't override DataGridView.DefaultCellStyle.SelectionBackColor.
        'DataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty

        '' Set the background color for all rows and for alternating rows. 
        '' The value for alternating rows overrides the value for all rows. 
        'DataGridView1.RowsDefaultCellStyle.BackColor = Color.Magenta 'LightGray
        'DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkMagenta 'DarkGrey

        '' Set the row and column header styles.
        'DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Yellow 'white
        'DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Green 'black
        'DataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.Blue 'black

        'DataGridView1.GridColor = Color.White 'Red
        'DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single

        'new data colors
        DataGridView1.GridColor = Color.Red
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single

        DataGridView1.BackgroundColor = Color.LightGray

        DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Cyan
        DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black

        DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]

        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.AllowUserToResizeColumns = False

        DataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige

        Dim i As Integer

        DataGridView1.ColumnCount = 50
        i = 0

        Column_Header(i, "SIZE", "Colsize", ColumnHeader(0))
        i = i + 1
        Column_Header(i, "TYPE", "Coltype", "empty")
        i = i + 1
        Column_Header(i, "SPEED", "Colspeed", ColumnHeader(2))
        i = i + 1
        Column_Header(i, "VOLUME", "Colvolume", ColumnHeader(3))
        i = i + 1
        Column_Header(i, "FSP", "Colfsp", ColumnHeader(4))
        i = i + 1
        Column_Header(i, "FTP", "Colftp", ColumnHeader(5))
        i = i + 1
        Column_Header(i, "POWER", "Colpower", ColumnHeader(6))
        i = i + 1
        Column_Header(i, "MOTOR", "Colmotor", ColumnHeader(7))
        i = i + 1
        Column_Header(i, "FSE", "Colfse", ColumnHeader(8))
        i = i + 1
        Column_Header(i, "FTE", "Colfte", ColumnHeader(9))
        i = i + 1
        Column_Header(i, "OUTLET VELOCITY", "Coloutletvel", ColumnHeader(10))
        i = i + 1
        Column_Header(i, "RESERVE HEAD", "Colrhead", ColumnHeader(11))
        i = i + 1
        Column_Header(i, "VOL TD", "Colvoltd", ColumnHeader(12))

        DataGridView1.ColumnCount = i + 1
        DataGridView1.Width = DataGridView1.Width * 1.1

        Dim filename As String

        filename = "FILENAME REF DATA" 'okay

        FullFilePath = "C:\Halifax\Performance Data new\" + filename + ".txt"
        Dim objStreamReader As New StreamReader(FullFilePath)

        Dim j As Integer

        Dim line As String
        'count = 0
        Dim TestArray() As String

        Try
            For j = 0 To 100
                line = objStreamReader.ReadLine()
                TestArray = Split(line, ",")
                fantypename(j) = TestArray(0)
                fanclass(j) = TestArray(1)
                fantypefilename(j) = TestArray(2)
                fansizelimit(j) = CDbl(TestArray(3))
                fantypesecfilename(j) = TestArray(4)
                fanunits(j) = TestArray(5)
                fanwidthing(j) = CBool(TestArray(6))
            Next
        Catch ex As Exception
            ' MsgBox(ex.ToString)
        Finally
            objStreamReader.Close() 'Close 
        End Try
        fantypesQTY = j - 1

        Dim m, n As Integer
        DataGridView1.Width = 0

        DataGridView1.RowCount = fantypesQTY + 1
        For m = 0 To DataGridView1.RowCount - 1
            DataGridView1.Rows(m).Height = 24
        Next
        Dim len As Integer
        Dim k As Integer
        For k = 0 To fantypesQTY
            If fanclass(k) IsNot Nothing Then Call loadfandata(fantypefilename(k), k)
        Next
        For n = 0 To DataGridView1.RowCount - 1

            For m = 0 To DataGridView1.ColumnCount - 1
                If n = 0 Then DataGridView1.Width = DataGridView1.Width + DataGridView1.Columns(m).Width
                Select Case m
                    Case 1
                        If fanclass(n) IsNot Nothing Then
                            '                            DataGridView1.Rows(n).Cells(m).Value = fanclass(n)
                            len = If(fanclass(n).Length < DataGridView1.Columns(m).Width / 8, DataGridView1.Columns(m).Width / 8, fanclass(n).Length)
                            DataGridView1.Columns(m).Width = len * 8
                            DataGridView1.Width = DataGridView1.Width + DataGridView1.Columns(m).Width
                        End If
                    Case 3
                        DataGridView1.Rows(n).Cells(m).Value = Math.Round(vol(1, n), voldecplaces).ToString
                    Case 4
                        DataGridView1.Rows(n).Cells(m).Value = Math.Round(fsp(1, n), pressplaceRise).ToString
                    Case 5
                        DataGridView1.Rows(n).Cells(m).Value = Math.Round(ftp(1, n), pressplaceRise).ToString
                    Case 6
                        DataGridView1.Rows(n).Cells(m).Value = Math.Round(Pow(1, n), 2).ToString
                    Case 8
                        DataGridView1.Rows(n).Cells(m).Value = Math.Round(fse(1, n), 3).ToString
                    Case 9
                        DataGridView1.Rows(n).Cells(m).Value = Math.Round(fte(1, n), 3).ToString
                    Case 10
                        DataGridView1.Rows(n).Cells(m).Value = Math.Round(ovel(1, n), 3).ToString
                End Select
                'DataGridView1.Rows(n).Cells(m).Value = "test" + (i * j).ToString
            Next
        Next
        DataGridView1.Height = (DataGridView1.RowCount * 24 + DataGridView1.ColumnHeadersHeight) * 1.1

        DataGridView1.Width = 0
        For i = 0 To DataGridView1.ColumnCount - 1
            DataGridView1.Width = DataGridView1.Width + DataGridView1.Columns(i).Width
        Next
        DataGridView1.Width = DataGridView1.Width * 1.05
        '        Me.Width = DataGridView1.Width * 1.1
        Width = DataGridView1.Width + 5 * DataGridView1.Location.X
        Height = DataGridView1.Height * 1.1 + DataGridView1.Location.Y
        If Height < 325 Then Height = 325
        CenterToScreen()

        Dim tempsize As Double = CDbl(Frmselectfan.Txtfansize.Text)
        Dim tempspeed As Double = CDbl(Frmselectfan.Txtfanspeed.Text)
        Dim tempflow As Double = CDbl(Frmselectfan.Txtflow.Text)
        Dim tempfsp As Double = CDbl(Frmselectfan.Txtfsp.Text)


        For k = 0 To fantypesQTY
            '-----------------------------------------------------------------------------
            '----- FOR KNOWN DUTY BUT NO SPEED OR FAN SIZE GIVEN -------------------------
            '------------------------------------------------------------------------------

            'Dim size As Double = CDbl(Frmselectfan.Txtfansize.Text)
            If tempsize = 0 And tempspeed = 0 And tempflow <> 0 And tempfsp <> 0 Then
                Call NoSpeedNosize(k)
            End If

            '----------------------------------------------------------------------------------------
            '---------------start of selecting fan size based on a given speed and duty point--------
            '-----------------------------------------------------------------------------------------
            If tempspeed <> 0 And tempflow <> 0 And tempfsp <> 0 And tempsize = 0 Then
                Call WithSpeedNoSize(k)
            End If

            '----------------------------------------------------------------------------------------
            '-----------------------Start of listing duty of known fan size and speed
            '---------------------------------------------------------------------------------------------
            If tempsize <> 0 And tempspeed <> 0 And tempflow = 0 And tempfsp = 0 Then
                Call WithSpeedWithSize(k)
            End If

            '-----------------------------------------------------------------------------------------------
            '-----------------------------start of selecting fan with size and volume & pressure------------
            '-----------------------------------------------------------------------------------------------
            If tempsize <> 0 And tempflow <> 0 And tempfsp <> 0 And tempspeed = 0 Then
                Call WithSizeVolPressure(k)
            End If

            '-------------------------------------------------------------------------------------------------
            '-------------------------start of finding pressure for selected fan speed size and volume--------
            '-------------------------------------------------------------------------------------------------
            If tempsize <> 0 And tempflow <> 0 And tempspeed <> 0 Then
                Call WithSpeedSizeVolume(k)
            End If

            '--------------------------------------------------------------------------------------
            '-----------------------start of finding volume for given pressure and fan speed------
            '-------------------------------------------------------------------------------------
            If tempsize <> 0 And tempflow = 0 And tempfsp <> 0 And tempspeed <> 0 Then
                Call WithSpeedPressure(k)
            End If
            'If selectedfansize(k) > 0 Then
            'End If
            Call ResHDandVolTD(k)
        Next

        Call PopulateGrid()
    End Sub

    Sub Column_Header(ByVal i As Integer, ByVal headertext As String, ByVal headername As String, Optional ByVal column_value As String = "empty")
        Dim len As Integer
        DataGridView1.Columns(i).HeaderText = headertext

        DataGridView1.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

        len = If(DataGridView1.Columns(i).HeaderText.Length < 8, 8, DataGridView1.Columns(i).HeaderText.Length)
        If (column_value IsNot "empty") Then
            DataGridView1.Columns(i).HeaderText = DataGridView1.Columns(i).HeaderText + vbCr + " (" + column_value + ")"
        Else
            DataGridView1.Columns(i).HeaderText = DataGridView1.Columns(i).HeaderText
        End If

        DataGridView1.Columns(i).Width = len * 8
        DataGridView1.Width = DataGridView1.Width + DataGridView1.Columns(i).Width

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        '        If e.ColumnIndex = 3 Then
        If (e.RowIndex < 0) Or (e.RowIndex < 0 And e.ColumnIndex < 0) Then
            'MsgBox("Invalid selection")
            Exit Sub
        End If
        MsgBox(DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString)
        'MsgBox(("Row : " + e.RowIndex.ToString & "  Col : ") + e.ColumnIndex.ToString)

        '  If e.RowIndex = 5 Then End
        '       End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Sub NoSpeedNosize(k)
        Call loadfandata(fantypefilename(k), k)
        Call scaledensity(k, getscalefactor)

        '-----repeating if the fansize falls into the secondary data range
        '                MsgBox("fansizelimit(k) = " + fansizelimit(k).ToString)
        If Getfansize(k) >= fansizelimit(k) And Val(fansizelimit(k)) <> 0 Then
            Call loadfandata(fantypesecfilename(k), k)
            Call scaledensity(k, getscalefactor)
        End If
        If Getfansize(k) = 0 Then
            '                    MsgBox("The duty is outside the selected fantype duty range")
            ' akm temp commented out  MsgBox("The duty is outside the " + fanclass(k) + " duty range")
        Else
            Call getfanspeed(Getfansize(k), k)

            'fansuccess = fansuccess + 1
        End If
        '-----end of checking for secondary range
    End Sub

    Sub WithSpeedNoSize(k)
        Call loadfandata(fantypefilename(k), k)
        '---running the suction correction to get the new density at the inlet
        Call scaledensity(k, getscalefactor)
        runonce = "no"
        Call Getsizeatfixedspeed(k)
    End Sub

    Sub WithSpeedWithSize(k)
        If Val(Frmselectfan.Txtfansize.Text) >= fansizelimit(k) And fansizelimit(k) <> 0 Then
            Call loadfandata(fantypesecfilename(k), k)
        Else
            Call loadfandata(fantypefilename(k), k)
        End If
        Call scaledensity(k, getscalefactor)
        Call scalesizespeed(Frmselectfan.Txtfansize.Text, Frmselectfan.Txtfanspeed.Text, k)
    End Sub

    Sub WithSizeVolPressure(k)
        If Val(Frmselectfan.Txtfansize.Text) >= fansizelimit(k) And fansizelimit(k) <> 0 Then
            Call loadfandata(fantypesecfilename(k), k)
        Else
            Call loadfandata(fantypefilename(k), k)
        End If
        Call scaledensity(k, getscalefactor)
        Call getfanspeed(Val(Frmselectfan.Txtfansize.Text), k)
    End Sub

    Sub WithSpeedSizeVolume(k)
        If Val(Frmselectfan.Txtfansize.Text) >= fansizelimit(k) And fansizelimit(k) <> 0 Then
            Call loadfandata(fantypesecfilename(k), k)
        Else
            Call loadfandata(fantypefilename(k), k)
        End If
        If Val(Frmselectfan.Txtfsp.Text) <> 0 Then
            Frmselectfan.Txtdens.Text = originaldensity
            'akmMsgBox("Fan Type " + k.ToString + ": " & fanclass(k) & ", A new value for Pressure has been calculated!", vbInformation)
        End If
        Call scaledensity(k, getscalefactor)
        Call getpressure(CDbl(Frmselectfan.Txtfansize.Text), CDbl(Frmselectfan.Txtfanspeed.Text), CDbl(Frmselectfan.Txtflow.Text), k)
    End Sub

    Sub WithSpeedPressure(k)
        If Val(Frmselectfan.Txtfansize.Text) >= fansizelimit(k) And fansizelimit(k) <> 0 Then
            Call loadfandata(fantypesecfilename(k), k)
        Else
            Call loadfandata(fantypefilename(k), k)
        End If
        Call scaledensity(k, getscalefactor)
        Call getvol(Val(Frmselectfan.Txtfansize.Text), Val(Frmselectfan.Txtfanspeed.Text), Val(Frmselectfan.Txtfsp.Text), k)
    End Sub

    Sub PopulateGrid()
        Dim fansuccess As Integer = 0

        Dim lowest_power As Double = 99999.99
        Dim highlight As Integer = -1

        For k = 0 To fantypesQTY
            If selectedfansize(k) > 0 Then
                DataGridView1.Rows(fansuccess).Cells(0).Value = selectedfansize(k).ToString
                DataGridView1.Rows(fansuccess).Cells(1).Value = fanclass(k)
                DataGridView1.Rows(fansuccess).Cells(2).Value = selectedspeed(k).ToString
                DataGridView1.Rows(fansuccess).Cells(3).Value = selectedvol(k).ToString
                DataGridView1.Rows(fansuccess).Cells(4).Value = selectedfsp(k).ToString
                DataGridView1.Rows(fansuccess).Cells(5).Value = selectedftp(k).ToString
                DataGridView1.Rows(fansuccess).Cells(6).Value = selectedpow(k).ToString
                If selectedmot(k) > 0 Then
                    DataGridView1.Rows(fansuccess).Cells(7).Value = selectedmot(k).ToString
                Else
                    DataGridView1.Rows(fansuccess).Cells(7).Value = "Non Std"
                End If
                DataGridView1.Rows(fansuccess).Cells(8).Value = selectedfse(k).ToString
                DataGridView1.Rows(fansuccess).Cells(9).Value = selectedfte(k).ToString
                DataGridView1.Rows(fansuccess).Cells(10).Value = selectedov(k).ToString
                DataGridView1.Rows(fansuccess).Cells(11).Value = selectedresHD(k).ToString

                If selectedVD(k) < 0 Then
                    DataGridView1.Rows(fansuccess).Cells(12).Value = "Stall"
                    DataGridView1.Rows(fansuccess).Cells(12).Style.BackColor = Color.Yellow
                    DataGridView1.Rows(fansuccess).Cells(12).Style.ForeColor = Color.Red
                Else
                    DataGridView1.Rows(fansuccess).Cells(12).Value = selectedVD(k).ToString
                End If

                If selectedresHD(k) < 5 Then
                    DataGridView1.Rows(fansuccess).Cells(11).Style.BackColor = Color.Yellow
                    DataGridView1.Rows(fansuccess).Cells(11).Style.ForeColor = Color.Red
                End If

                If selectedpow(k) < lowest_power And selectedpow(k) > 0 Then
                    lowest_power = selectedpow(k)
                    highlight = fansuccess
                End If
                fansuccess = fansuccess + 1
            End If
        Next
        DataGridView1.RowCount = fansuccess
        DataGridView1.Height = (DataGridView1.RowCount * 24 + DataGridView1.ColumnHeadersHeight) * 1.1
        Height = DataGridView1.Height * 1.1 + DataGridView1.Location.Y
        If highlight >= 0 Then
            DataGridView1.Rows(highlight).Cells(6).Style.BackColor = Color.LightGreen
            DataGridView1.CurrentCell = DataGridView1.Rows(highlight).Cells(0)
        End If
    End Sub

    Sub ResHDandVolTD(fanno)
        fspmax = scalePFSize(fsp(fanno, FanMaxCount(fanno)), datafansize(fanno), selectedfansize(fanno))
        ftpmax = scalePFSize(ftp(fanno, FanMaxCount(fanno)), datafansize(fanno), selectedfansize(fanno))
        volmax = scaleVFSize(vol(fanno, FanMaxCount(fanno)), datafansize(fanno), selectedfansize(fanno))
        '-scales for speed
        volmax = scaleVFSpeed(volmax, datafanspeed(fanno), selectedspeed(fanno))
        fspmax = scalePFSpeed(fspmax, datafanspeed(fanno), selectedspeed(fanno))
        ftpmax = scalePFSpeed(ftpmax, datafanspeed(fanno), selectedspeed(fanno))
        selectedVD(fanno) = Math.Round((1 - volmax / selectedvol(fanno)) * 100, 1)
        If PType = 1 Then
            selectedresHD(fanno) = Math.Round((1 - selectedftp(fanno) / ftpmax) * 100, 1)
        Else
            selectedresHD(fanno) = Math.Round((1 - selectedfsp(fanno) / fspmax) * 100, 1)
        End If

        'FrmSelections.txtpow1.BackColor = &H80FF80
        'PowMin = Val(FrmSelections.txtpow1.Value)

        'End If

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class
