Imports System.Globalization
'Imports System.ComponentModel
'Imports System.Resources
'Imports System.Threading
'Imports System.Drawing.Printing
Module modINI
    Public Declare Unicode Function WritePrivateProfileString Lib "kernel32" _
    Alias "WritePrivateProfileStringW" (ByVal lpApplicationName As String,
    ByVal lpKeyName As String, ByVal lpString As String,
    ByVal lpFileName As String) As Int32
    Public Declare Function GetprivateProfileString Lib "Kernel32" Alias "GetPrivateProfileStringA" (ByVal IpApplicationName As String, ByVal IpKeyName As String, ByVal IpDefault As String, ByVal IpReturnedString As String, ByVal nSize As Integer, ByVal IpFileName As String) As Integer
    Public ini_path As String
    Public UserProfile As String
    Public SystemDrive As String
    Public DataPath_main As String
    Public Language As String
    Public User_Type As Boolean
    Public SuppressErrorMessages As Boolean
    Public Sub ReadWriteINI()
        Try
            Dim exists As Boolean
            SystemDrive = System.Environment.ExpandEnvironmentVariables("%SystemDrive%")
            UserProfile = System.Environment.ExpandEnvironmentVariables("%userprofile%")
            Dim Path As String

            Dim lans As String = CultureInfo.CurrentUICulture.Name
            If lans.ToLower.Contains("en-") Then lans = "en-GB"

            Path = UserProfile + "\Halifax.ini"
            exists = System.IO.File.Exists(Path)
            If exists = False Then
                username = Environment.UserName
                Dim str As String
                str = SystemDrive + "\Halifax\"
                writeIni(Path, "Settings", "Halifax Root Folder", str)
                writeIni(Path, "Settings", "Language", lans)
                If username.Length < 1 Then username = "HFL Sales"
                writeIni(Path, "Settings", "User", username)
            End If
            ' ### Get the ini file path ###
            ini_path = GetINIPath()
            ' ### Get the Halifax path with the ini file ###
            Dim DataPath_main As String
            'Dim Language As String
            'Dim User_Type As Boolean
            'Dim SuppressErrorMessages As Boolean
            DataPath_main = GetFromINI("Settings", "Halifax Root Folder", SystemDrive + "\Halifax\", ini_path)
            ChosenLanguage = GetFromINI("Settings", "Language", "en-GB", ini_path)
            ChosenSite = GetFromINI("Settings", "Site", "0", ini_path)
            username = GetFromINI("Settings", "User", "HFL Sales", ini_path)
            'SuppressErrorMessages = GetFromINI("Settings", "Suppress Error Messages", "False", ini_path)
            'Form1.Text = DataPath_main + " " + Language + " " + User_Type.ToString + " " + SuppressErrorMessages.ToString

        Catch ex As Exception
            ErrorMessage(ex, 6601)
        End Try

    End Sub
    Function GetFromINI(ByRef sSection As String, ByRef sKey As String, ByRef sDefault As String, ByRef sIniFile As String) As Object
        Dim sBuffer As String = Space(255)
        Dim lRet As Integer = Len(sBuffer)
        Dim Path As String = ""
        Try
            '### SEARCH IN THE INI FILE AND GET THE PATH IN IT ###
            lRet = GetprivateProfileString(sSection, sKey, sDefault, sBuffer, Len(sBuffer), sIniFile)
            '### IF INI FILE FOUND THEN USE THE PATH ELSE SEND A MESSAGE AND USE THE DEFAULT PATH ###
            If lRet = 0 Then
                MsgBox("Could not find Halifax.ini file")
                Path = sDefault
            Else
                Path = Microsoft.VisualBasic.Left(sBuffer, InStr(sBuffer, Chr(0)) - 1)
            End If
        Catch ex As Exception
            '### IF HAVING AN ERROR THEN SEND A MESSAGE AND USE THE DEFAULT PATH ###
            '            MsgBox("The following error has occurred in GetFromINI : " & ex.Message)
            ''DisplayErrorMessage(109, ex.Message)
            '            MsgBox("#HF0009 " + ex.Message + vbNewLine + vbNewLine + "Please email this message to alistair.mcinnes@howden.com.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "HDFA_Client INI file problem.")
            Path = sDefault
        End Try
        Return Path
    End Function

    Function GetINIPath()
        Try
            Dim Path As String = ""
            Path = UserProfile + "\Halifax.ini"
            Return Path

        Catch ex As Exception
            ErrorMessage(ex, 6602)
        End Try
    End Function

    Public Sub writeIni(ByVal iniFileName As String, ByVal Section As String, ByVal ParamName As String, ByVal ParamVal As String)
        Try
            Dim Result As Integer
            Result = WritePrivateProfileString(Section, ParamName, ParamVal, iniFileName)

        Catch ex As Exception
            ErrorMessage(ex, 6603)
        End Try
    End Sub
End Module
