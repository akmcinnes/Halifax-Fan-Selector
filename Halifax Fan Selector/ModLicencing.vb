Imports System.IO
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

    Public Function GetUserCode()
        Try
            Dim serial As String = ""
            Dim drive As String = GetHDDrive()
            serial = GetDriveSerialNumber(drive)
            If serial = "-1" Then Return -1
            serial = serial.Replace(".", "")
            If Not serial.Contains("_") Then
                serial = serial.PadLeft(16, "0"c)
                Dim newserial As String
                newserial = Mid(serial, 1, 4) + "_" + Mid(serial, 5, 4) + "_" + Mid(serial, 9, 4) + "_" + Mid(serial, 13, 4)
                serial = newserial
            End If

            Dim wordss As String() = serial.Split(New Char() {"_"})
            Dim stot As Integer = Convert.ToInt32(wordss(0), 16) * 1 + Convert.ToInt32(wordss(1), 16) * 2 + Convert.ToInt32(wordss(2), 16) * 3 + Convert.ToInt32(wordss(3), 16) * 4
            Return stot
        Catch ex As Exception
            ErrorMessage(ex, 6702)
            Return -1
        End Try
    End Function

    Public Function GetDriveSerialNumber(drive) As String
        Try
            Dim DriveSerial As Integer
            Dim fso As Object = CreateObject("Scripting.FileSystemObject")
            'Dim Drv As Object = fso.GetDrive(fso.GetDriveName(Application.StartupPath))
            Dim Drv As Object = fso.GetDrive(drive)
            With Drv
                If .IsReady Then
                    DriveSerial = .SerialNumber
                Else    '"Drive Not Ready!"
                    DriveSerial = -1
                End If
            End With
            Return DriveSerial.ToString("X2")
        Catch ex As Exception
            ErrorMessage(ex, 6703)
            Return -1
        End Try
    End Function

    Public Function GetHDDrive() As String
        Try
            Dim drive As String = GetDriveLetter()
            Return drive
        Catch ex As Exception
            ErrorMessage(ex, 6704)
            Return "C:\"
        End Try
    End Function

    Private Function GetDriveLetter() As String
        Try
            For Each drive As DriveInfo In My.Computer.FileSystem.Drives
                If drive.DriveType = DriveType.Fixed Then 'AndAlso drive.VolumeLabel.ToLower = Volume.ToLower Then
                    Return drive.RootDirectory.Name
                End If
            Next
            Return Nothing
        Catch ex As Exception
            ErrorMessage(ex, 6705)
            Return Nothing
        End Try
    End Function
End Module
