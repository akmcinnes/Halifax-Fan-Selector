Module ModMisc
    Public Sub Initialize(Set1stTime As Boolean)
        Try
            If Set1stTime = True Then
                SetUnitStructure()

                SetUnits()
                'populating Pressure Type
                '        Frmselectfan.cmbPressType.AddItem "Fan Static"
                '        Frmselectfan.cmbPressType.AddItem "Fan Total"
                '        DensMult = 1

                'NextSpeed = "2 Pole"'300119
                RunTemp = 20
                For II = 0 To 50 - 1
                    Widthratios(II) = 1
                Next II
                'Customer = ""
                FileSaved = False
                designtemp = 20.0
                maximumtemp = 0.0
                ambienttemp = 0.0
                altitude = 0.0
                humidity = 0.0
                atmospress = 0.0
                knowndensity = 0.0
                'calcdensity = 0.0'300119
                flowrate = 0.0
                reshead = 5.0
                inletpress = 0.0
                dischpress = 0.0
                pressrise = 0.0
                maxspeed = 0.0
                fansize = 0.0
                'If UserName.ToLower.Contains("akm") = True Then
                If StartArg.ToLower.Contains("-dev") = True Then
                    designtemp = 20.0
                    maximumtemp = 20.0
                    ambienttemp = 20.0
                    atmospress = 101325.0
                    'knowndensity = 1.2
                    'flowrate = 10000.0
                    'pressrise = 4000.0
                    knowndensity = 1.2
                    flowrate = 10000.0
                    pressrise = 4000.0
                    maxspeed = 3600.0
                    'Frmselectfan.Txtflow.Text = flowrate.ToString 'akm 080219
                    'Frmselectfan.Txtfsp.Text = pressrise.ToString 'akm 080219
                End If
            End If

        Catch ex As Exception
            '            MsgBox("Initialize")
            ErrorMessage(ex, 5501)
        End Try
    End Sub

    Public Function IntToByteArray(toBeConverted As Integer) As String
        Dim result As Integer = 0
        Try
            If (toBeConverted >= 16 And toBeConverted < 32) Then
                result = result + 10000
                toBeConverted = toBeConverted - 16
            End If
            If (toBeConverted >= 8 And toBeConverted < 16) Then
                result = result + 1000
                toBeConverted = toBeConverted - 8
            End If
            If (toBeConverted >= 4 And toBeConverted < 8) Then
                result = result + 100
                toBeConverted = toBeConverted - 4
            End If
            If (toBeConverted >= 2 And toBeConverted < 4) Then
                result = result + 10
                toBeConverted = toBeConverted - 2
            End If
            If (toBeConverted >= 1 And toBeConverted < 2) Then
                result = result + 1
                toBeConverted = toBeConverted - 1
            End If
            Return result.ToString("0000")

        Catch ex As Exception
            ErrorMessage(ex, 5513)
            Return result.ToString
        End Try
    End Function

    Public Sub Yellow(Ctrl As System.Windows.Forms.TextBox, Optional MinValue As Double = 0.0)
        Try
            Dim val As Double
            If Double.TryParse(Ctrl.Text, val) = False Then
                Ctrl.BackColor = Color.LightYellow
                Ctrl.Text = ""
                move_on = False
            ElseIf CDbl(Ctrl.Text) <= MinValue Then
                Ctrl.BackColor = Color.LightYellow
                Ctrl.Text = ""
                move_on = False
            Else
                Ctrl.BackColor = Color.White
            End If
        Catch ex As Exception
            ErrorMessage(ex, 5514)
        End Try
    End Sub

    'Sub RedBorder(Ctrl As System.Windows.Forms.TextBox)
    '    Try
    '        Dim g As System.Windows.Forms.PaintEventArgs
    '        Dim pen As New Pen(Color.Red, 2.0)
    '        g.Graphics.DrawRectangle(pen, New Rectangle(Ctrl.Location, Ctrl.Size))
    '        pen.Dispose()

    '    Catch ex As Exception
    '        ErrorMessage(ex, 5515)
    '    End Try
    'End Sub
    'Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles FrmSelectFan.Paint
    '    Dim g As Graphics = e.Graphics
    '    Dim p As New Pen(Color.Red, 2)
    '    g.DrawRectangle(p, TextBox1.Left, TextBox1.Top, TextBox1.Width, TextBox1.Height)

    'End Sub
End Module
