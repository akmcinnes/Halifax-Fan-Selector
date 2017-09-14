Module Density
    Public Function getscalefactor()
        Try
            If DensType = 2 Then
                getscalefactor = Val(Frmselectfan.Txtdens.Text) / 0.075
            Else
                getscalefactor = Val(Frmselectfan.Txtdens.Text) / 1.2
        End If

        Catch ex As Exception
            MsgBox("getscalefactor")
        End Try
    End Function
    Public Function densityfactor(density)
        Try
            If DensType = 2 Then
                densityfactor = density / 0.075
            Else
                densityfactor = density / 1.2
        End If

        Catch ex As Exception
            MsgBox("densityfactor")
        End Try
    End Function

    Public Sub scaledensity(fanno, scalefactor)
        Try
            'If fantypesQTY = 1 Then
            count = 0
        Do While count <= 50
            vol(fanno, count) = vol(fanno, count) * Widthratios(fanno)
            fsp(fanno, count) = fsp(fanno, count) * scalefactor
            ftp(fanno, count) = ftp(fanno, count) * scalefactor
            Pow(fanno, count) = Pow(fanno, count) * scalefactor * Widthratios(fanno)
            count = count + 1
        Loop
            'End If

        Catch ex As Exception
            MsgBox("scaledensity")
        End Try
    End Sub

End Module
