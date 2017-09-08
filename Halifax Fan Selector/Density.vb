Module Density
    Public Function getscalefactor()
        If DensType = 2 Then
            getscalefactor = Val(FrmSelectFan.Txtdens.Text) / 0.075
        Else
            getscalefactor = Val(FrmSelectFan.Txtdens.Text) / 1.2
        End If
    End Function
    Public Function densityfactor(density)
        If DensType = 2 Then
            densityfactor = density / 0.075
        Else
            densityfactor = density / 1.2
        End If
    End Function

    Public Sub scaledensity(fanno, scalefactor)
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
    End Sub

End Module
