Module VariablesDensity
    Public Structure Gas_Structure
        Dim GasName As String
        Dim GasFormula As String
        Dim GasMW As Double
        Dim GasDensity As Double
        Dim GasMassFraction As Double
        Dim GasVolumeFraction As Double
        Dim GasMoleFraction As Double
        Dim GasDensityFraction As Double
    End Structure

    Public GasesIn(100) As Gas_Structure
    Public GasesOut(10) As Gas_Structure

    Public focuseditem As Integer
    Public gridrow As Integer
    Public gasnum As Integer
    Public maxgasnum As Integer
    Public gaspicked(10) As Integer

    Public altitude2 As Double
    Public pressure2 As Double
    Public temperature2 As Double
    Public humidity2 As Double
    Public CalculatedDensity As Double
    Public WVSP As Double = 610.7 'Water Vapour Saturated Pressure

End Module
