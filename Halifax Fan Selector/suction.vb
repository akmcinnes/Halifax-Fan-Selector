Module suction
    'Public atmos As Double

    Public Sub suctioncorrection(fsp, power, density)
        '---iterative method for calculating suction pressure and density
        Dim py, b3, b4, a4, k2, k3, k7, k8, k1, py2 As Double
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

    End Sub
    Public Function Inletdensity(fsp, density)
        '---returns the inlet density for a known inlet pressure
        Dim py, b3, b4, a4, k2, k3, k7, k8, k1, py2 As Double
        Dim atmos As Double
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
        Inletdensity = GetDensity1(k8)
    End Function

    Public Function suckvol(Volume, pressure)
        Dim atmos As Double
        If Volume = 0 Then
            Volume = 0.001
        End If

        atmos = Getatmos()

        Dim a, b As Double
        a = ((atmos - pressure) * (Volume ^ 1.4)) / atmos
        b = (Math.Log(a)) / 1.4
        suckvol = Math.Exp(b)
    End Function

    Function GetAtmos() As Double
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
    End Function
    Function GetDensity1(ByVal density As Double) As Double
        If DensType = 2 Then
            density1 = density * 16
        Else
            density1 = density
        End If
        Return density1
    End Function

    Function GetDensity2(ByVal k8 As Double)
        If DensType = 2 Then
            NEWdensity = k8 / 16
        Else
            NEWdensity = k8
        End If
        Return NEWdensity
    End Function
End Module
