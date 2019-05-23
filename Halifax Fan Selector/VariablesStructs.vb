Module Variable_Structs
    Public Structure UnitsStruct
        '0 = flow        '1 = pressure        '2 = temperature        '3 = density
        '4 = power       '5 = length          '6 = altitude           '7 = velocity
        '8 = area

        Private m_UnitName() As String
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
        Private Sub initArray3()
            ReDim m_UnitPlaces(8)
        End Sub

        Dim UnitSelected As Integer
        Dim UnitDefault As Integer

    End Structure

    Public Units(8) As UnitsStruct

    Public Structure fanstruct
        Public fanindex As Integer
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
        Public outletdia As Double
        Public fantypename As String
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

    Structure Label_struct
        Dim labelstring As String
        Dim startpoint As Integer
        Dim endpoint As Integer
    End Structure

    Public Found(500) As Label_struct

    Structure Failures_Structure
        Dim IndexLan As Integer
        Private m_Languages() As String
        Public Property Languages(Index As Integer) As String
            Get
                If m_Languages Is Nothing Then initLanguages()
                Return m_Languages(Index)
            End Get
            Set(value As String)
                If m_Languages Is Nothing Then initLanguages()
                m_Languages(Index) = value
            End Set
        End Property

        Private Sub initLanguages()
            ReDim m_Languages(5)
        End Sub
    End Structure

    Public FailuresList(50) As Failures_Structure

    ' ### TEMPORARY INFORMATION ###
    Structure Temporary_Structure
        Dim A, B, C, D, E As Integer
        ' Dim Pt1Coord, Pt2Coord As Inventor.Point2d
        Dim Value1, Value2, Value3, Value4, Value5 As Double
        Dim String1, String2, String3, String4, String5 As String
    End Structure

    Public Temporary As Temporary_Structure


    ' ### GENERAL INFORMATION ###
    Structure General_Information_Structure
        Dim Initials As String
        Dim Time As String
        Dim Contract_number As String
        Dim Client_reference As String
        Dim Project_name As String
        Dim Country_template As String
        Dim Fan_type As String
        Dim Units As String
        Dim State As Integer
        Dim State_Message As String
    End Structure

    Public General_Information As General_Information_Structure

End Module
