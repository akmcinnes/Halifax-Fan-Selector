Imports System.Collections
Imports System.Management
Module ModLicencing
    Public Function CalculateUserCode() As Integer
        Try
            Dim stot As Integer = GetUserCode()
            Dim newstring(1) As String
            Dim ab(1) As Integer
            ab(0) = 0
            ab(1) = 65
            For i = 0 To 1
                newstring(i) = Oct(CInt(stot) + Oct(ab(i))).ToString
                newstring(i) = newstring(i).PadLeft(8, "0")
                Dim a1 As String = StrReverse(Microsoft.VisualBasic.Left(newstring(i), 4))
                Dim a2 As String = StrReverse(Microsoft.VisualBasic.Right(newstring(i), 4))
                newstring(i) = Oct(CInt(a1) + ab(i)).ToString + "-" + CDec(CInt(a2)).ToString
                If newstring(i) = AccessCode And i = 0 Then
                    StartArg = "-b"
                    Return 1
                End If
                If newstring(i) = AccessCode And i = 1 Then
                    StartArg = "-a"
                    Return 2
                End If
            Next
            If Not AccessCode = "" Then
                Return 0
            End If
            If AccessCode = "" Then
                Return -1
            End If
            'End
        Catch ex As Exception
            ErrorMessage(ex, 6701)
            Return -1
        End Try
        Return -1
    End Function

    'Public Function GetUserCode99()
    '    Try
    '        'Dim WindowsApplication1 As System.STAThreadAttribute()
    '        'Dim hdCollection As New ArrayList()
    '        'Dim searcher As New ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive")
    '        'Dim wmi_HD As New ManagementObject()
    '        'For Each wmi_HD In searcher.Get

    '        '    Dim hd As New Class1.HardDrive()

    '        '    hd.Model = wmi_HD("Model").ToString()
    '        '    hd.Type = wmi_HD("InterfaceType").ToString()
    '        '    hdCollection.Add(hd)
    '        'Next
    '        'For Each wmi_HD In searcher.Get

    '        '    Dim hd As New Class1.HardDrive()

    '        '    hd.Model = wmi_HD("Model").ToString()
    '        '    hd.Type = wmi_HD("InterfaceType").ToString()
    '        '    hdCollection.Add(hd)
    '        'Next

    '        'Dim searcher1 As New ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia")


    '        'Dim i As Integer = 0
    '        'For Each wmi_HD In searcher1.Get()

    '        '    '// get the hard drive from collection
    '        '    '// using index

    '        '    Dim hd As Class1.HardDrive
    '        '    hd = hdCollection(i)


    '        '    '// get the hardware serial no.
    '        '    If wmi_HD("SerialNumber") = "" Then
    '        '        hd.serialNo = "None"
    '        '    Else
    '        '        hd.serialNo = wmi_HD("SerialNumber").ToString()
    '        '        i += 1
    '        '    End If
    '        'Next

    '        'Dim hd1 As Class1.HardDrive
    '        'Dim ii As Integer = 0

    '        'For Each hd1 In hdCollection
    '        '    ii += 1

    '        '    'TextBox1.Text = TextBox1.Text + "Serial No: " + hd1.serialNo + Chr(13) + Chr(10) + Chr(13) + Chr(10)
    '        'Next
    '        ''Dim mos99 As New ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia")
    '        'Dim mos99 As New ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia.MediaType") 'Select * from Win32_LogicalDisk
    '        'i = 0
    '        'For Each wmi_HD In mos99.Get()

    '        '    '// get the hard drive from collection
    '        '    '// using index

    '        '    Dim hd As Class1.HardDrive
    '        '    hd = hdCollection(i)


    '        '    '// get the hardware serial no.
    '        '    If wmi_HD("SerialNumber") = "" Then
    '        '        hd.serialNo = "None"
    '        '    Else
    '        '        hd.serialNo = wmi_HD("SerialNumber").ToString()
    '        '        i += 1
    '        '    End If
    '        'Next
    '        ''Dim serial99 As String = ""
    '        ''For Each mo99 As ManagementObject In mos99.Get()
    '        ''    serial99 = mo99("SerialNumber").ToString()
    '        ''    'serial99 = mo99("MediaDescription").ToString()
    '        ''Next
    '        ''If StartArg.ToLower.Contains("-dev") Then
    '        ''    MsgBox(serial99)
    '        ''End If
    '        'Dim strDrive As String = "C"
    '        'Dim moHD As New ManagementObject("Win32_LogicalDisk.DeviceID=""" + strDrive + ":""")
    '        'moHD.[Get]()
    '        'Dim asdf As String = moHD("VolumeSerialNumber").ToString()
    '        'If StartArg.ToLower.Contains("-dev") Then
    '        '    MsgBox(asdf)
    '        'End If
    '        Dim serial As String = ""
    '        'Dim mos As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_DiskDrive")
    '        'Dim mos As New ManagementObjectSearcher("SELECT * FROM Win32_Volume")
    '        Dim mos As New ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive")

    '        For Each mo As ManagementObject In mos.Get()
    '            'Dim sDriveType As Integer = CInt(mo("DriveType"))
    '            'If sDriveType = 3 Then
    '            If mo("SerialNumber") <> "" Then serial = mo("SerialNumber")
    '            'End If
    '        Next
    '        serial = serial.Replace(".", "")
    '        If StartArg.ToLower.Contains("-dev") Then
    '            MsgBox("serial number = " + serial)
    '        End If
    '        If Not serial.Contains("_") Then
    '            serial = serial.PadLeft(16, "0"c)
    '            Dim newserial As String
    '            newserial = Mid(serial, 1, 4) + "_" + Mid(serial, 5, 4) + "_" + Mid(serial, 9, 4) + "_" + Mid(serial, 13, 4)
    '            serial = newserial
    '        End If

    '        Dim wordss As String() = serial.Split(New Char() {"_"})
    '        Dim stot As Integer = Convert.ToInt32(wordss(0), 16) * 1 + Convert.ToInt32(wordss(1), 16) * 2 + Convert.ToInt32(wordss(2), 16) * 3 + Convert.ToInt32(wordss(3), 16) * 4
    '        Return stot
    '    Catch ex As Exception
    '        ErrorMessage(ex, 6702)
    '        Return -1
    '    End Try
    'End Function

    Public Function GetUserCode()
        Try
            Dim serial As String = ""
            serial = GetDriveSerialNumber()
            If serial = "-1" Then Return -1
            serial = serial.Replace(".", "")

            Dim wordss As String() = serial.Split(New Char() {"_"})
            Dim stot As Integer = Convert.ToInt32(wordss(0), 16) * 1 + Convert.ToInt32(wordss(1), 16) * 2 + Convert.ToInt32(wordss(2), 16) * 3 + Convert.ToInt32(wordss(3), 16) * 4
            Return stot
        Catch ex As Exception
            ErrorMessage(ex, 6702)
            Return -1
        End Try
    End Function

    Public Function GetDriveSerialNumber() As String
        Try
            Dim hdCollection As New ArrayList()
            Dim searcher As New ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive")
            Dim wmi_HD As New ManagementObject()

            For Each wmi_HD In searcher.Get
                Dim hd As New Class1.HardDrive()
                hd.Type = wmi_HD("InterfaceType").ToString()
                hdCollection.Add(hd)
            Next
            Dim searcher1 As New ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia")
            Dim i As Integer = 0
            For Each wmi_HD In searcher1.Get()
                Dim hd As Class1.HardDrive
                hd = hdCollection(i)
                If wmi_HD("SerialNumber") = "" Then
                    hd.serialNo = "None"
                Else
                    hd.serialNo = wmi_HD("SerialNumber").ToString()
                    i += 1
                End If
            Next
            Dim hd1 As Class1.HardDrive
            Dim ii As Integer = 0
            Dim serialno As String = ""
            For Each hd1 In hdCollection
                ii += 1
                If Not hd1.Type = "USB" Then
                    serialno = hd1.serialNo
                End If
            Next
            Return serialno
        Catch ex As Exception
            ErrorMessage(ex, 6704)
        End Try
        Return "-1"
    End Function
End Module
