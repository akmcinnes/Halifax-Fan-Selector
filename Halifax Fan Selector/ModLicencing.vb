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

    Public Function GetUserCode()
        Try
            Dim mos As New ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia")
            Dim serial As String = ""
            For Each mo As ManagementObject In mos.Get()
                serial = mo("SerialNumber").ToString()
            Next
            serial = serial.Replace(".", "")

            Dim wordss As String() = serial.Split(New Char() {"_"})
            Dim stot As Integer = Convert.ToInt32(wordss(0), 16) * 1 + Convert.ToInt32(wordss(1), 16) * 2 + Convert.ToInt32(wordss(2), 16) * 3 + Convert.ToInt32(wordss(3), 16) * 4
            Return stot
        Catch ex As Exception
            ErrorMessage(ex, 6702)
            Return -1
        End Try
    End Function
End Module
