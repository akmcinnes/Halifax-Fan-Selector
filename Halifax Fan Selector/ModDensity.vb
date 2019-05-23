Module ModDensity
    Public Function getscalefactor()
        'scaling factor for density
        getscalefactor = 0.0
        Try
            If Units(3).UnitSelected = 1 Then
                getscalefactor = knowndensity / 0.075
            Else
                getscalefactor = knowndensity / 1.2
            End If
            Return getscalefactor
        Catch ex As Exception
            ErrorMessage(ex, 5001)
        End Try
    End Function

    Public Sub scaledensity(fanno, scalefactor)
        'modify curve points for density & width
        Try
            count = 0
            Do While count <= 50
                vol(fanno, count) = vol(fanno, count) * Widthratios(fanno)
                fsp(fanno, count) = fsp(fanno, count) * scalefactor
                ftp(fanno, count) = ftp(fanno, count) * scalefactor
                Powr(fanno, count) = Powr(fanno, count) * scalefactor * Widthratios(fanno)
                count = count + 1
            Loop
        Catch ex As Exception
            ErrorMessage(ex, 5002)
        End Try
    End Sub
End Module
