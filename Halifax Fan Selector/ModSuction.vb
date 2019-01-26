Module ModSuction
    'Public atmos As Double

    Public Sub SuctionCorrection(fsp, power, density)
        '---iterative method for calculating suction pressure and density
        Try
            'Dim py, b3, b4, a4, k2, k3, k7, k8, k1, py2 As Double
            Dim py, b3, a4, k2, k3, k7, k8, k1, py2 As Double
            density1 = GetDensity1(density)
            atmos = GetAtmos()

            a3 = density1
            py = fsp
            b3 = py
            k1 = 2
            Do While k1 <> 1 '---loops unitll the ratio of densities is negligable - iterative solution
                a4 = 1 / a3
                k2 = atmos * (a4 ^ 1.4)
                k3 = atmos - py
                k7 = Math.Exp(Math.Log(k2 / k3) / 1.4)
                k8 = 1 / k7 'new density
                k1 = k8 / a3 ' ratio of densities
                py2 = b3 * k1
                If (py2 - py) ^ 2 <= 0.0001 Then
                    Exit Do
                Else
                    py = py2
                End If
            Loop
            NEWdensity = GetDensity2(k8)
            NEWpower = power * (NEWdensity / density)
            NEWpressure = fsp * (NEWdensity / density)
        Catch ex As Exception
            ErrorMessage(ex, 6101)
        End Try
    End Sub

    Public Function InletDensity(fsp, density)
        InletDensity = 0.0
        '---returns the inlet density for a known inlet pressure
        'Dim py, b3, b4, a4, k2, k3, k7, k8, k1, py2 As Double
        Dim py, b3, a4, k2, k3, k7, k8, k1 As Double
        Dim atmos As Double
        Try
            density1 = GetDensity1(density)
            atmos = GetAtmos()

            a3 = density1
            py = fsp
            b3 = py
            k1 = 2
            Do While newpressure1 <> fsp
                a4 = 1 / a3
                k2 = atmos * (a4 ^ 1.4)
                k3 = atmos - py
                k7 = Math.Exp(Math.Log(k2 / k3) / 1.4)
                k8 = 1 / k7 'new density
                NEWpressure = py * k8 / a3 'calculating new pressure
                If (NEWpressure - fsp) ^ 2 < (0.01 * fsp) Or NEWpressure > fsp Then
                    Exit Do
                Else
                    py = py + ((py - NEWpressure) * (fsp * 0.00001))
                End If
            Loop
            InletDensity = GetDensity1(k8)
        Catch ex As Exception
            ErrorMessage(ex, 6102)
        End Try
    End Function

    Public Function SuckVol(Volume, pressure)
        SuckVol = 0.0
        Try
            Dim atmos As Double
            If Volume = 0 Then
                Volume = 0.001
            End If

            atmos = GetAtmos()

            Dim a, b As Double
            a = ((atmos - pressure) * (Volume ^ 1.4)) / atmos
            b = (Math.Log(a)) / 1.4
            SuckVol = Math.Exp(b)
        Catch ex As Exception
            ErrorMessage(ex, 6103)
        End Try
    End Function

    Function GetAtmos() As Double
        GetAtmos = 0.0
        Try
            atmos = 407.45
            If Frmselectfan.ColumnHeader(4) = "InsWG" Then
                atmos = 407.45
            End If
            If Frmselectfan.ColumnHeader(4) = "mmWG" Then
                atmos = 10349.1
            End If
            If Frmselectfan.ColumnHeader(4) = "Pa" Then
                atmos = 101389
            End If
            If Frmselectfan.ColumnHeader(4) = "mbar" Then
                atmos = 1013.89
            End If
            Return atmos
        Catch ex As Exception
            ErrorMessage(ex, 6104)
        End Try
    End Function

    Function GetDensity1(ByVal density As Double) As Double
        GetDensity1 = 0.0
        Try
            If DensType = 2 Then
                density1 = density * 16
            Else
                density1 = density
            End If
            Return density1
        Catch ex As Exception
            ErrorMessage(ex, 6105)
        End Try
    End Function

    Function GetDensity2(ByVal k8 As Double)
        GetDensity2 = 0.0
        Try
            If DensType = 2 Then
                NEWdensity = k8 / 16
            Else
                NEWdensity = k8
            End If
            Return NEWdensity
        Catch ex As Exception
            ErrorMessage(ex, 6106)
        End Try
    End Function
End Module
