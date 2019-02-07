Module Variable_Structs
    Public Structure UnitsStruct
        '0 = flow        '1 = pressure        '2 = temperature        '3 = density
        '4 = power       '5 = length          '6 = altitude           '7 = velocity

        Private m_UnitName() As String
        Private m_UnitConversion() As String
        Private m_UnitPlaces() As String

        Public Property UnitName(Index As Integer) As String
            Get
                If m_UnitName Is Nothing Then initArray1()
                Return m_UnitName(Index)
            End Get
            Set(value As String)
                If m_UnitName Is Nothing Then initArray1()
                m_UnitName(Index) = value
            End Set
        End Property

        Public Property UnitConversion(Index As Integer) As Double
            Get
                If m_UnitConversion Is Nothing Then initArray2()
                Return m_UnitConversion(Index)
            End Get
            Set(value As Double)
                If m_UnitConversion Is Nothing Then initArray2()
                m_UnitConversion(Index) = value
            End Set
        End Property

        Public Property UnitPlaces(Index As Integer) As Integer
            Get
                If m_UnitPlaces Is Nothing Then initArray3()
                Return m_UnitPlaces(Index)
            End Get
            Set(value As Integer)
                If m_UnitPlaces Is Nothing Then initArray3()
                m_UnitPlaces(Index) = value
            End Set
        End Property

        Private Sub initArray1()
            ReDim m_UnitName(8)
        End Sub
        Private Sub initArray2()
            ReDim m_UnitConversion(8)
        End Sub
        Private Sub initArray3()
            ReDim m_UnitPlaces(8)
        End Sub

        Dim UnitSelected As Integer
        Dim UnitDefault As Integer

    End Structure

    Public Units(8) As UnitsStruct

    Public Structure fanstruct
        Public fansize As Double
        Public fantype As String
        Public fse As Double
        Public speed As Double
        Public pow As Double
        Public pow2 As Double
        Public fsp As Double
        Public fte As Double
        Public ftp As Double
        Public ov As Double
        Public vol As Double
        Public mot As Double
        Public mot2 As Double
        Public resHD As Double
        Public VD As Double
        'Public BladeType As String
        Public BladeNumber As Integer
        'Public fanfile As String
        Public inletdia As Double
        Public outletarea As Double
        Public outletlen As Double
        Public outletwid As Double
    End Structure

    Public selected(50) As fanstruct
    Public final As fanstruct

    Structure Motor_Structure
        Dim PowerKW As Double
        Dim PowerHP As Double 'not used
        'Private Speed50() As Double

        Private m_Speed50() As String
        Public Property Speed50(Index As Integer) As Double
            Get
                If m_Speed50 Is Nothing Then initArray50()
                Return m_Speed50(Index)
            End Get
            Set(value As Double)
                If m_Speed50 Is Nothing Then initArray50()
                m_Speed50(Index) = value
            End Set
        End Property

        Private m_Speed60() As String
        Public Property Speed60(Index As Integer) As Double
            Get
                If m_Speed60 Is Nothing Then initArray60()
                Return m_Speed60(Index)
            End Get
            Set(value As Double)
                If m_Speed60 Is Nothing Then initArray60()
                m_Speed60(Index) = value
            End Set
        End Property

        Private Sub initArray50()
            ReDim m_Speed50(6)
        End Sub
        Private Sub initArray60()
            ReDim m_Speed60(6)
        End Sub
    End Structure

    Public Motor_Information(100) As Motor_Structure
    Public Motor_Pole_Speeds As Motor_Structure

End Module
