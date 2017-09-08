'Imports System.Xml
Module Variables

    '    Public Widthratio As Single
    Public Widthratios(50) As Single

    '    Public ResultsFileName, ResultFile(50) As String
    '    Public DataSheets(50), NoiseSheets(50), DataSheetOut As Boolean
    '    Public FileStore As Integer

    Public PType, FlowType, DensType As Integer

    '    Public fantitles(50) As String
    Public Customer As String
    Public FanNameSave, FanSizeSave, FanVol, FanSP, FanTP, FanSpeed, FanPower, FanMotor, FanSE, FanTE, FanOutVel As String

    'Public headerlocation As String
    'Public noisesheetname As String
    'Public reportNo As Integer
    Public correctedforSUCTIONS(50) As String
    'Public curvefanname As String

    Public NextSpeed As String
    Public RunTemp As Single


    Public datapoints1 As Integer
    'Public newdata
    'Public fantyperefrow(50) As Integer
    Public Const casethickness = 6 '-twice the thickness of the case
    'Public units1 As String
    'Public units2 As String
    'Public units3 As String
    'Public units4 As String
    'Public units5 As String

    Public fspcol As Integer
    Public ftpcol As Integer
    Public colvol As Integer
    Public colpow As Integer
    Public coleff As Integer
    '-------------------------------------------fan type 1 ONLY variables
    'Public SIV(50, 50) As Double 'system inlet volume on suction
    'Public FID(50, 50) As Double 'desity of the air at the fan inlet
    Public fansizelimit(50) As Double
    Public fantypesecfilename(50) As String
    Public dataoutletareaftsq(50) As Double
    Public fanunits(50) As String
    Public fanwidthing(50) As Boolean
    Public fantypesQTY As Integer

    Public fsp(,) As Double
    Public ftp(,) As Double
    Public vol(,) As Double
    Public eff(50, 50) As Double
    Public Pow(,) As Double
    Public fse(,) As Double
    Public fte(,) As Double
    Public ovel(,) As Double

    Public fansize As Double
    Public stepsize As Double
    Public speed As Double
    Public fsps(50, 50) As Double
    Public ftps(50, 50) As Double
    Public vols(50, 50) As Double
    Public effs(50, 50) As Double
    Public Pows(50, 50) As Double
    Public fses(50, 50) As Double
    Public ftes(50, 50) As Double
    Public ovs(50, 50) As Double
    Public fsizes(50, 500) As Double

    Public datafansize(50) As Single
    Public datafanspeed(50) As Integer
    Public dataoutletsize(50) As Integer
    Public dataoutletarea(50) As Double
    Public ftspeed(50, 50) As Double
    Public medpoint(50) As Integer

    Public volI(50, 10000) As Double
    Public fspI(50, 10000) As Double
    Public ftpI(50, 10000) As Double
    Public powI(50, 10000) As Double
    Public fseI(50, 10000) As Double
    Public fteI(50, 10000) As Double



    Public fanspeedI(50, 10000) As Double
    Public datapointI(50, 10000) As Double

    'Public prevvolI(50, 10000) As Double
    'Public prevfspI(50, 10000) As Double
    'Public prevftpI(50, 10000) As Double
    'Public prevpowI(50, 10000) As Double
    'Public prevfanspeedI(50, 10000) As Double
    'Public prevdatapointI(50, 10000) As Double
    'Public nxtvolI(50, 10000) As Double
    'Public nxtfspI(50, 10000) As Double
    'Public nxtftpI(50, 10000) As Double
    'Public nxtpowI(50, 10000) As Double
    'Public nxtfanspeedI(50, 10000) As Double
    'Public nxtdatapointI(50, 10000) As Double
    'Public volm3hrI(50, 10000) As Double

    Public originaldensity As Double

    '--------------START OF OTHER VARIABLES

    Public fantypefilename(50) As String
    Public fantypename(50) As String
    Public fanclass(50) As String
    Public FanSave, FanMaxCount(50) As Integer

    '    Public motorsize(200) As Double

    Public NEWpressure As Double
    Public NEWpower As Double
    Public NEWdensity As Double
    Public runonce As String

    Public voldecplaces, pressplaceIn, pressplaceOut, pressplaceRise, pressplaceAtmos, FanPick As Integer

    Public temppressurE As Object

    'Public DrawnBy As String
    'Public NoisePress As Single




    ' Attribute VB_Name = "variables"
    'Public Widthratio As Single
    'Public Widthratios(5) As Single

    'Public ResultsFileName, ResultFile(5) As String
    'Public DataSheets(5), NoiseSheets(5), DataSheetOut As Boolean
    'Public FileStore As Integer

    'Public PType, FlowType, DensType As Integer

    '' akm    Public fantitles(5), Customer As String
    'Public fantitles(5) As String
    'Public FanNameSave, FanSizeSave, FanVol, FanSP, FanTP, FanSpeed, FanPower, FanMotor, FanSE, FanTE, FanOutVel As String

    'Public headerlocation As String
    'Public noisesheetname As String
    'Public reportNo As Integer
    'Public correctedforSUCTIONS(5) As String
    'Public curvefanname As String

    'Public NextSpeed As String
    'Public RunTemp As Single

    'Public datapoints1 As Integer
    'Public newdata
    'Public fantyperefrow(5) As Integer
    'Public Const casethickness = 6 '-twice the thickness of the case
    'Public units1 As String
    'Public units2 As String
    'Public units3 As String
    'Public units4 As String
    'Public units5 As String

    'Public fspcol As Integer
    'Public ftpcol As Integer
    'Public colvol As Integer
    'Public colpow As Integer
    'Public coleff As Integer
    ''-------------------------------------------fan type 1 ONLY variables
    'Public SIV(5, 50) As Double 'system inlet volume on suction
    'Public FID(5, 50) As Double 'desity of the air at the fan inlet
    'Public fansizelimit(5) As Double
    'Public fantypesecfilename(5) As String
    'Public dataoutletareaftsq(5) As Double

    'Public fsp(5, 50) As Double
    'Public ftp(5, 50) As Double
    'Public vol(5, 50) As Double
    'Public eff(5, 50) As Double
    'Public Pow(5, 50) As Double
    'Public fse(5, 50) As Double
    'Public fte(5, 50) As Double

    'Public fsps(5, 50) As Double
    'Public ftps(5, 50) As Double
    'Public vols(5, 50) As Double
    'Public effs(5, 50) As Double
    'Public Pows(5, 50) As Double
    'Public fses(5, 50) As Double
    'Public ftes(5, 50) As Double
    'Public ovs(5, 50) As Double
    'Public fsizes(5, 500) As Double

    'Public datafansize(5) As Single
    'Public datafanspeed(5) As Integer
    'Public dataoutletsize(5) As Integer
    'Public dataoutletarea(5) As Double
    'Public ftspeed(5, 50) As Double
    'Public medpoint(5) As Integer

    'Public volI(5, 10000) As Double
    'Public fspI(5, 10000) As Double
    'Public ftpI(5, 10000) As Double
    'Public powI(5, 10000) As Double
    'Public fseI(5, 10000) As Double
    'Public fteI(5, 10000) As Double

    'Public fanspeedI(5, 10000) As Double
    'Public datapointI(5, 10000) As Double

    'Public prevvolI(5, 10000) As Double
    'Public prevfspI(5, 10000) As Double
    'Public prevftpI(5, 10000) As Double
    'Public prevpowI(5, 10000) As Double
    'Public prevfanspeedI(5, 10000) As Double
    'Public prevdatapointI(5, 10000) As Double
    'Public nxtvolI(5, 10000) As Double
    'Public nxtfspI(5, 10000) As Double
    'Public nxtftpI(5, 10000) As Double
    'Public nxtpowI(5, 10000) As Double
    'Public nxtfanspeedI(5, 10000) As Double
    'Public nxtdatapointI(5, 10000) As Double
    'Public volm3hrI(5, 10000) As Double

    'Public originaldensity As Double

    ''--------------START OF OTHER VARIABLES

    'Public fantypefilename(5) As String
    'Public fantypename(5) As String
    'Public fanclass(5) As String
    'Public FanSave, FanMaxCount(5) As Integer

    'Public motorsize(200) As Double

    'Public NEWpressure As Double
    'Public NEWpower As Double
    'Public NEWdensity As Double
    'Public runonce As String

    'Public voldecplaces, pressplace, FanPick As Integer

    'Public temppressurE As Object

    'Public DrawnBy As String
    'Public NoisePress As Single

    ''--- used by AKM
    'Public Customer As String
    Public Engineer As String

    Public atmos As Double


    '    Structure UnitsStruct
    '    Public UnitName() As String
    '    Dim UnitDefault As Integer
    '    Public UnitConversion() As Double
    '    Dim UnitSelected As Integer

    '    Public Sub initArray()
    '    ReDim UnitName(8)
    '    ReDim UnitConversion(8)
    '    End Sub
    '    End Structure

    Public Structure UnitsStruct
        Private m_UnitName() As String

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

        Dim UnitDefault As Integer
        Private m_UnitConversion() As String
        Private m_UnitPlaces() As String

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

    End Structure

    Public Units(8) As UnitsStruct

    'flow = 0
    'pressure = 1
    'temperature = 2
    'density = 3
    'power = 4
    'length = 5
    'altitude = 6
    'velocity = 7

    Public No_of_units As Integer = 8

    Public NewProject As Boolean
    Public SaveFileName As String
    Public OpenFileName As String
    Public FileSaved As Boolean

    Public designtemp, maximumtemp, ambienttemp As Double
    Public altitude As Double
    Public humidity As Double
    Public atmospress, inletpress, dischpress, pressrise As Double
    Public knowndensity, calcdensity As Double
    Public flowrate As Double
    Public reshead As Double
    Public maxspeed As Double
    Public convflow As Double
    Public convpres As Double
    Public convtemp As Double
    Public convdens As Double
    Public convalt As Double
    Public convatmo As Double
    Public convpow As Double
    Public convlen As Double
    Public convvel As Double

    Public fspmax As Double
    Public ftpmax As Double
    Public volmax As Double

    'added 
    Public colfsp As Integer
    Public colftp As Integer
    Public colfse As Integer
    Public colfte As Integer
    Public colstdfansizes As Integer
    Public coloutletvel As Integer
    Public count As Integer
    Public counteff As Integer
    Public row As Integer



    Public filename(50) As String
    Public filepath1 As String = "C:\Halifax\Performance Data\"
    Public filepath2 As String = "C:\Halifax\Performance Data New\"
    Public extension1 As String = ".xls"
    Public extension2 As String = ".txt"

    'excel values
    Public FanSize1 As Double
    Public FanSpeed1 As Double
    Public FanSize2 As Double
    Public Num_Readings As Integer
    Public Most_Eff_Pt As Integer
    Public OutLen_mm As Double
    Public OutWid_mm As Double
    Public OutArea_m2 As Double
    Public OutLen_ft As Double
    Public OutWid_ft As Double
    Public OutArea_ft2 As Double
    Public In_Dia_mm As Double
    Public Eye_Area_m2 As Double
    Public Blade_Type As String
    Public Num_Blades As Integer
    Public FSP_insWG(30) As Double
    Public Pow_hp(30) As Double
    Public Vol_cfm(30) As Double
    Public FTP_insWG(30) As Double
    Public FSP_mmwg(30) As Double
    Public Pow_kw(30) As Double
    Public Vol_m3hr(30) As Double
    Public FTP_mmWG(30) As Double
    Public Vol_m3min(30) As Double
    Public Vol_m3sec(30) As Double
    Public FSP_pa(30) As Double
    Public FTP_pa(30) As Double
    Public FSP_mbar(30) As Double
    Public FTP_mbar(30) As Double
    Public OV_msec(30) As Double
    Public OV_fmin(30) As Double
    Public FSE1(30) As Double
    Public FTE1(30) As Double
    Public OVEL1(30) As Double
    Public STD_Fan_Size(30) As Double

    Public count1 As Integer
    Public count2 As Integer
    Public aa As Double

    Public datapoint2 As Integer
    Public datapoint3 As Integer

    Public difference1 As Double
    Public difference2 As Double

    Public grad As Double
    Public gradfse As Double
    Public gradfsp As Double
    Public gradfte As Double
    Public gradftp As Double
    Public gradpow As Double
    Public outletsize As Double
    Public PressCheck1 As Double
    Public PressCheck2 As Double
    Public PressCheck3 As Double
    Public uptospeed As Double
    Public TempPress As Double
    Public a3 As Double
    Public density1 As Double
    Public gradvol As Double
    Public newpressure1 As Double

    Public selectedfansize(30) As Double
    Public selectedfantype(30) As String
    Public selectedfse(30) As Double
    Public selectedspeed(30) As Double
    Public selectedpow(30) As Double
    Public selectedfsp(30) As Double
    Public selectedfte(30) As Double
    Public selectedftp(30) As Double
    Public selectedov(30) As Double
    Public selectedvol(30) As Double
    Public selectedmot(30) As Double
    Public selectedresHD(30) As Double
    Public selectedVD(30) As Double

    '    Public atmos As Double

    Public FullFilePath As String

    Public motorsize(2, 100) As Double
End Module
