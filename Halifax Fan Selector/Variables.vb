Imports System.IO

Module Variables

    Public br As System.IO.BinaryReader
    Public fs As System.IO.FileStream

    Public AdvancedUser As Boolean
    'Public Developer As Boolean
    Public version_number As String = "V 1.0.2 Beta"
    Public DataPathMain As String ' = "C:\Halifax\"

    Public DataPathDefault As String ' = DataPathMain + "Performance Data\"
    Public OutputPathDefault As String ' = DataPathMain + "Output Files\"
    Public ProjectPathDefault As String ' = DataPathMain + "Projects\"
    Public TemplatesPathDefault As String ' = DataPathMain + "Templates\"
    'Public DataPathDefault As String = ".\Performance Data\"
    Public DataPath As String

    Public FullFilePathtxt As String

    Public username As String

    Public StartArg As String

    Public Flag(9) As Boolean
    'Public UserName As String = Environment.UserName
    Public countflag As Integer

    Public ChosenLanguage As String

    Public SelectDIDW As Boolean

    Public move_on As Boolean

    'Public UserType As Integer
    'Public locale_name As String

    Public Widthratios(50) As Single

    'Public PresType, FlowType, DensType, VelType As Integer
    Public PresType, DensType As Integer

    Public Customer As String
    'Public FanNameSave, FanSizeSave, FanVol, FanSP, FanTP, FanSpeed, FanPower, FanMotor, FanSE, FanTE, FanOutVel As String

    'Public correctedforSUCTIONS(50) As String

    'Public NextSpeed As String
    Public RunTemp As Single


    Public datapoints1 As Integer
    Public Const casethickness = 6 '-twice the thickness of the case

    'Public fspcol As Integer
    'Public ftpcol As Integer
    'Public colvol As Integer
    'Public colpow As Integer
    'Public coleff As Integer
    '-------------------------------------------fan type 1 ONLY variables
    Public fansizelimit(50) As Double
    Public fantypesecfilename(50) As String
    Public dataoutletareaftsq(50) As Double
    Public fanunits(50) As String 'not used
    Public fanwidthing(50) As Boolean 'not used
    Public fanselectioncode(50) As String
    Public fancurved(50) As Boolean
    Public faninclined(50) As Boolean
    Public fanplastic(50) As Boolean
    Public fanother(50) As Boolean
    Public fantypesQTY As Integer

    Public ReadFromProjectFile As Boolean

    'Public ShowCurvedFanTypes As Boolean
    'Public ShowInclinedFanTypes As Boolean
    'Public ShowOtherFanTypes As Boolean
    'Public ShowPlasticFanTypes As Boolean
    'Public ShowPlenumFanTypes As Boolean
    'Public ShowAxialFanTypes As Boolean
    'Public ShowOldFanTypes As Boolean

    Public fsp(,) As Double '1
    Public ftp(,) As Double '2
    Public vol(,) As Double '3
    Public Powr(,) As Double '4
    Public fse(,) As Double '5
    Public fte(,) As Double '6
    Public ovel(,) As Double '7
    'Public eff(50, 50) As Double

    Public fansize As Double
    Public stepsize As Double
    Public speed As Double
    Public fsps(50, 500) As Double '1
    Public ftps(50, 500) As Double '2 
    Public vols(50, 500) As Double '3
    Public Pows(50, 500) As Double '4
    'Public fses(50, 500) As Double '5
    'Public ftes(50, 500) As Double '6
    'Public ovs(50, 500) As Double '7
    Public fsizes(50, 500) As Double
    'Public effs(50, 500) As Double

    Public datafanindex(50) As Integer

    Public datafansize(50) As Single
    Public datafanspeed(50) As Integer
    Public dataoutletlen(50) As Double
    Public dataoutletwid(50) As Double
    Public dataoutletdia(50) As Double
    Public dataoutletsize(50) As Integer
    Public dataoutletarea(50) As Double
    Public datainletdia(50) As Double
    Public ftspeed(50, 500) As Double
    Public medpoint(50) As Integer
    Public blade_type(50) As String
    Public blade_number(50) As Integer
    Public fspI(50, 10000) As Double '1
    Public ftpI(50, 10000) As Double '2
    'Public volI(50, 10000) As Double '3
    'Public powI(50, 10000) As Double '4
    'Public fseI(50, 10000) As Double '5
    'Public fteI(50, 10000) As Double '6
    Public fanspeedI(50, 10000) As Double
    Public datapointI(50, 10000) As Double

    Public fanfailures(50, 1) As String
    Public failurevalue(50) As String
    Public failindex As Integer

    Public originaldensity As Double

    '--------------START OF OTHER VARIABLES

    Public fantypefilename(50) As String
    Public fantypename(50) As String
    Public fanclass(50) As String
    'Public FanSave, FanMaxCount(50) As Integer
    Public FanMaxCount(50) As Integer
    Public SizeAtFixedSpeed As Double

    Public NEWpressure As Double
    Public NEWpower As Double
    Public NEWdensity As Double
    Public runonce As String

    'Public voldecplaces, pressplaceIn, pressplaceOut, pressplaceRise, pressplaceAtmos, FanPick As Integer
    Public voldecplaces, pressplaceIn, pressplaceOut, pressplaceRise, pressplaceAtmos As Integer
    Public powerdecplaces, lengthdecplaces As Integer

    Public temppressure As Object

    ''--- used by AKM
    Public Engineer As String

    Public atmos As Double

    Public No_of_units As Integer = 8

    Public NewProject As Boolean
    Public SaveFileName As String
    Public OpenFileName As String
    Public FileSaved As Boolean

    Public designtemp, maximumtemp, ambienttemp As Double
    Public altitude As Double
    Public humidity As Double
    Public atmospress, inletpress, dischpress, pressrise As Double
    'Public knowndensity, calcdensity As Double
    Public knowndensity As Double
    Public flowrate As Double
    Public reshead As Double
    Public maxspeed As Double
    'Public minspeed As Double
    Public convflow As Double
    Public convpres As Double
    'Public convtemp As Double
    Public convdens As Double
    Public convalt As Double
    'Public convatmo As Double
    Public convpow As Double
    Public convlen As Double
    Public convvel As Double

    Public CalcAtmos As Boolean

    Public fspmax As Double
    Public ftpmax As Double
    Public volmax As Double

    'added 
    'Public colfsp As Integer
    'Public colftp As Integer
    'Public colfse As Integer
    'Public colfte As Integer
    'Public colstdfansizes As Integer
    'Public coloutletvel As Integer
    Public count As Integer
    Public countefft As Integer
    Public counteffs As Integer
    Public row As Integer

    Public kp As Double

    'Public filename(50) As String
    'Public filepath1 As String = "C:\Halifax\Performance Data\"
    'Public filepath2 As String = "C:\Halifax\Performance Data New\"
    'Public filepath1 As String = DataPath
    'Public filepath2 As String = DataPath
    'Public extension1 As String = ".xls"
    'Public extension2 As String = ".txt"

    'excel values
    Public FanSize1 As Double
    Public FanSpeed1 As Double
    Public FanSize2 As Double 'not used
    Public Num_Readings As Integer
    Public Most_Eff_Pt As Integer
    Public OutLen_mm As Double
    Public OutWid_mm As Double
    Public OutDia_mm As Double
    Public OutArea_m2 As Double
    Public OutLen_ft As Double 'not used
    Public OutWid_ft As Double 'not used
    Public OutDia_ft As Double
    Public OutArea_ft2 As Double
    Public In_Dia_mm As Double
    Public Eye_Area_m2 As Double 'not used
    Public Type_Blade As String
    Public Num_Blades As Integer

    Public Vol_m3hr(30) As Double
    Public Vol_m3min(30) As Double
    Public Vol_m3sec(30) As Double
    Public Vol_cfm(30) As Double

    Public FSP_pa(30) As Double
    Public FTP_pa(30) As Double
    Public FSP_mbar(30) As Double
    Public FTP_mbar(30) As Double
    Public FSP_insWG(30) As Double
    Public FTP_insWG(30) As Double
    Public FSP_mmwg(30) As Double
    Public FTP_mmWG(30) As Double
    Public FSP_kpa(30) As Double
    Public FTP_kpa(30) As Double

    Public Pow_kw(30) As Double
    Public Pow_hp(30) As Double

    Public OV_msec(30) As Double
    Public OV_fmin(30) As Double

    Public FSE1(30) As Double
    Public FTE1(30) As Double

    'Public OVEL1(30) As Double

    Public STD_Fan_Size(50) As Double '30

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

    Public legend As String

    '    Public atmos As Double

    Public FullFilePath As String


    'Public motorsize(2, 100) As Double

    Public freqHz As Integer

    'curve variables
    Public curvedesign As String
    Public yaxistitle As String
    Public y2axistitle As String
    Public xaxistitle As String
    Public tempyaxistitle As String
    Public tempy2axistitle As String
    'Public curvevolunits As String
    'Public presunits As String
    'Public powunits As String

    Public plotvol() As Double
    Public plotfsp() As Double
    Public plotftp() As Double
    Public plotpow() As Double
    Public plotfse() As Double
    Public plotfte() As Double
    Public plotov() As Double

    'Public NewCurve As Boolean

    Public fan2plot As Integer
    'Public objStreamWriter As New StreamWriter("c:\Halifax\output.txt")

    'noise variables
    Public SPL As Single
    Public boSPL As Single
    Public bospl1M As Single
    Public NCQ As Single
    Public NCFSP As Single
    Public NCN As Single
    'Public NCimpdia As Single
    'Public oboSPL As Single
    Public NCINdia As Single
    Public CF(8) As Integer
    Public IDSPL(8) As Integer
    Public Ascale(8) As Integer
    Public ductCF As Integer

    Public diameters(22) As Integer
    Public sounddata(22, 9) As Integer

    'Public count As Integer
    Public spl2 As Integer
    Public bospl2 As Integer
    Public bospl1M2 As Integer
    'Public oboSPL2 As Integer
    Public NCoverall As Integer
    'Public stopprogram As Integer
    'Public T2col, T2row As Integer
    'Public bladetype As String '1=bc 2=bi 3=fc 4=radial 5=axial
    'Public bladecount As Integer
    'Public OPcond As String
    Public inX As Single ' constant for each size of duct diameter
    Public INascale(8) As Integer ' variable of inlet duct scale
    Public Octaves(8) As Single
    'Public Last As Integer
    'Public sort As Integer
    Public inNCoverall As Single
    'Public indiff As Single
    'Public addindiff As Single
    Public OUTascale(8) As Integer
    Public OUTdia As Single
    'Public OUTdiff As Single
    'Public addOUTdiff As Single
    Public OUTNCoverall As Single
    'Public Drow As Integer
    'Public OOrow As Integer
    'Public OIrow As Integer
    Public outX As Single
    'Public OUTarea As Single
    Public BRGnoise As Integer
    Public MTRnoise As Integer
    'Public brgrow As Integer
    'Public Motorrow As Integer
    Public BPfreq As Integer
    'Public bpfroW As Integer
    'Public NCscalefactor As Single
    Public inletdia As Integer
    'Public outletdia As Integer
    Public outletlength As Integer
    Public outletwidth As Integer
    Public outletdiameter As Integer
    Public WScale(8) As Single


    Public Background_Color As Color

    'Public count As Integer

    Public outfile(10000000) As Char
    Public filename As String

    Public kpatmos As Double

End Module
