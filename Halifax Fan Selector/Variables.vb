Module Variables

    Public br As System.IO.BinaryReader
    Public fs As System.IO.FileStream

    Public AdvancedUser As Boolean
    'Public version_number As String = "V 1.0.2 Beta"
    Public version_number As String = "V 1.0.6b" '130919
    Public DataPathMain As String ' = "C:\Halifax\"

    Public DataPathDefault As String ' = DataPathMain + "Performance Data\"
    Public OutputPathDefault As String ' = DataPathMain + "Output Files\"
    Public ProjectPathDefault As String ' = DataPathMain + "Projects\"
    Public TemplatesPathDefault As String ' = DataPathMain + "Templates\"
    Public DataPath As String
    Public lang_dict(2, 250) As String
    'Public lang_dictEN(250) As String
    Public PrintLanguage As Integer

    Public FullFilePathtxt As String

    Public OpenFromToolStrip As Boolean

    Public PagesOutput As Integer

    Public username As String
    Public emailaddress As String
    Public phonenumber As String
    Public address As String

    Public site_label(10) As String
    Public site_name(10) As String
    Public site_company(2, 10) As String
    Public site_address(2, 10) As String
    Public site_phone(10) As String
    Public site_email(10) As String
    Public site_website(10) As String


    Public headercompany As String
    Public headeraddress As String
    Public headeremail As String
    Public headerphone As String
    Public headerweb As String

    Public StartArg As String

    Public Flag(9) As Boolean
    Public countflag As Integer

    Public ChosenLanguage As String

    Public ChosenSite As Integer ' 1 = uk, 2 = Shanghai, 3 = Shenzen, 4 = Xian

    Public estring As String
    Public tstring As String
    Public cstring As String
    Public astring As String
    Public wstring As String

    Public SelectDIDW As Boolean
    Public AccessCode As String

    Public IncludeAcoustics As Boolean

    Public move_on As Boolean

    Public Widthratios(50) As Single

    Public PresType, DensType As Integer

    Public Customer As String
    Public RunTemp As Single

    Public datapoints1 As Integer
    Public Const casethickness = 6 '-twice the thickness of the case

    Public fansizelimit(50) As Double
    Public fantypesecfilename(50) As String
    Public dataoutletareaftsq(50) As Double
    Public fanunits(50) As String 'not used
    Public fanwidthing(50) As Boolean 'not used
    Public fanselectioncode(50) As String
    Public fanwide(50) As Boolean
    Public fanmedium(50) As Boolean
    Public fannarrow(50) As Boolean
    Public fanhighpressure(50) As Boolean
    Public fancurved(50) As Boolean
    Public faninclined(50) As Boolean
    Public fanplastic(50) As Boolean
    Public fanpaddle(50) As Boolean
    Public fanradial(50) As Boolean
    Public fanother(50) As Boolean
    Public fantypesQTY As Integer

    Public ReadFromProjectFile As Boolean

    Public fsp(,) As Double '1
    Public ftp(,) As Double '2
    Public vol(,) As Double '3
    Public Powr(,) As Double '4
    Public fse(,) As Double '5
    Public fte(,) As Double '6
    Public ovel(,) As Double '7

    Public fansize As Double
    Public stepsize As Double
    Public speed As Double
    Public fsps(50, 1000) As Double '1'500
    Public ftps(50, 1000) As Double '2'500 
    Public vols(50, 1000) As Double '3'500
    Public Pows(50, 1000) As Double '4'500
    Public fsizes(50, 1000) As Double '500

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
    Public fspI(50, 1000) As Double '1'10000
    Public ftpI(50, 1000) As Double '2'10000
    Public fanspeedI(50, 1000) As Double '10000
    Public datapointI(50, 1000) As Double '10000

    Public fanfailures(50, 1) As String
    Public failurevalue(50) As String
    Public failindex As Integer

    Public originaldensity As Double

    '--------------START OF OTHER VARIABLES

    Public fantypefilename(50) As String
    Public fantypename(50) As String
    Public fanclass(50) As String
    Public FanMaxCount(50) As Integer
    Public SizeAtFixedSpeed As Double

    Public NEWpressure As Double
    Public NEWpower As Double
    Public NEWdensity As Double
    Public runonce As String

    Public voldecplaces, pressplaceIn, pressplaceOut, pressplaceRise, pressplaceAtmos As Integer
    Public powerdecplaces, lengthdecplaces As Integer

    Public temppressure As Object

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
    Public knowndensity As Double
    Public flowrate As Double
    Public reshead As Double
    Public maxspeed As Double
    Public convflow As Double
    Public convpres As Double
    Public convdens As Double
    Public convalt As Double
    Public convpow As Double
    Public convlen As Double
    Public convvel As Double

    Public Motor_Margin As Double = 1.15
    Public CalcAtmos As Boolean

    Public DDInputArea As Double
    Public DDInputRatio As Double

    Public fspmax As Double
    Public ftpmax As Double
    Public volmax As Double

    Public count As Integer
    Public countefft As Integer
    Public counteffs As Integer
    Public row As Integer

    Public kp As Double

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

    Public FullFilePath As String

    Public freqHz As Integer

    'curve variables
    Public curvedesign As String
    Public yaxistitle As String
    Public y2axistitle As String
    Public xaxistitle As String
    Public tempyaxistitle As String
    Public tempy2axistitle As String

    Public plotvol() As Double
    Public plotfsp() As Double
    Public plotftp() As Double
    Public plotpow() As Double
    Public plotfse() As Double
    Public plotfte() As Double
    Public plotov() As Double
    Public plotoutletarea, plotoutletwidth, plotoutletlength As Double
    Public plotinletdia As Double

    Public fan2plot As Integer

    'noise variables
    Public SPL As Single
    Public boSPL As Single
    Public bospl1M As Single
    Public NCQ As Single
    Public NCFSP As Single
    Public NCN As Single
    Public NCINdia As Single
    Public CF(8) As Integer
    Public IDSPL(8) As Integer
    Public Ascale(8) As Integer
    Public ductCF As Integer

    Public diameters(22) As Integer
    Public sounddata(22, 9) As Integer

    Public spl2 As Integer
    Public bospl2 As Integer
    Public bospl1M2 As Integer
    Public NCoverall As Integer
    Public inX As Single ' constant for each size of duct diameter
    Public INascale(8) As Integer ' variable of inlet duct scale
    Public Octaves(8) As Single
    Public inNCoverall As Single
    Public OUTascale(8) As Integer
    Public OUTdia As Single
    Public OUTNCoverall As Single
    Public outX As Single
    Public BRGnoise As Integer
    Public MTRnoise As Integer
    Public BPfreq As Integer
    Public inletdia As Integer
    Public outletlength As Integer
    Public outletwidth As Integer
    Public outletdiameter As Integer
    Public WScale(8) As Single

    Public InclDuctNoise As Boolean
    Public InclOpenInletNoise As Boolean
    Public InclOpenOutletNoise As Boolean
    Public InclBrgNoise As Boolean
    Public InclMotorNoise As Boolean

    Public Background_Color As Color

    Public outfile(10000000) As Char
    Public filename As String

    Public kpatmos As Double

    Public DefaultHeader As String

    Public sheet As String

    Public IncludeDampers As Boolean
    Public IncludeSystem As Boolean
    Public IncludeDutyPoint As Boolean

    Public AddedDensities(8) As Double
    Public AddedSpeeds(8) As Double
    Public numspeeds As Integer
    Public numdensities As Integer

    'Public MostEffFlow, MosetEffFSP, MostEffFTP, MostEffPower As Double
    Public StandAlone As Boolean

    'Public WidthPerCent As Double
End Module
