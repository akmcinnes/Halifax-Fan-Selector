Imports System.IO
Imports System.Xml
Module Getfiledata
    Sub ReadReffromTextfile(filename)
        Try
            'FullFilePath = "C:\Halifax\Performance Data new\" + filename + ".txt"
            FullFilePath = DataPath + filename + ".txt"
            Dim objStreamReader As New StreamReader(FullFilePath)

            Dim j As Integer

            Dim line As String
            'count = 0
            Dim TestArray() As String

            Try
                For j = 0 To 100
                    line = objStreamReader.ReadLine()
                    If line.Contains(",") Then
                        TestArray = Split(line, ",")
                        fantypename(j) = TestArray(0)
                        fanclass(j) = TestArray(1)
                        fantypefilename(j) = TestArray(2)
                        fansizelimit(j) = CDbl(TestArray(3))
                        fantypesecfilename(j) = TestArray(4)
                        fanunits(j) = TestArray(5)
                        fanwidthing(j) = CBool(TestArray(6))
                        fanselectioncode(j) = IntToByteArray(CInt(TestArray(7)))
                        Dim asdf As String = Mid(fanselectioncode(j), 4, 1)
                        If Not (Frmselectfan.ChkCurveBlade.Checked = True And Mid(fanselectioncode(j), 4, 1) = "1" Or
                            Frmselectfan.ChkInclineBlade.Checked = True And Mid(fanselectioncode(j), 3, 1) = "1" Or
                            Frmselectfan.ChkPlasticFan.Checked = True And Mid(fanselectioncode(j), 2, 1) = "1" Or
                            Frmselectfan.ChkOtherFanType.Checked = True And Mid(fanselectioncode(j), 1, 1) = "1") Then
                            j = j - 1
                        End If
                    End If
                Next
            Catch ex As Exception
                ' MsgBox(ex.ToString)
            Finally
                objStreamReader.Close() 'Close 
            End Try
            fantypesQTY = j - 1

        Catch ex As Exception
            MsgBox("ReadReffromTextfile")
        End Try
    End Sub

    Sub ReadReffromBinaryfile(filename)
        Try
            'FullFilePath = "C:\Halifax\Performance Data new\" + filename + ".bin"
            FullFilePath = DataPath + filename + ".bin"
            fs = New System.IO.FileStream(FullFilePath, IO.FileMode.Open)
            br = New System.IO.BinaryReader(fs)

            Dim j As Integer
            br.BaseStream.Seek(0, IO.SeekOrigin.Begin)
            Try
                For j = 0 To 100
                    fantypename(j) = br.ReadString()
                    fanclass(j) = br.ReadString()
                    fantypefilename(j) = br.ReadString()
                    fansizelimit(j) = br.ReadInt32()
                    fantypesecfilename(j) = br.ReadString()
                    fanunits(j) = br.ReadString()
                    fanwidthing(j) = br.ReadBoolean()
                    fancurved(j) = br.ReadBoolean()
                    faninclined(j) = br.ReadBoolean()
                    fanplastic(j) = br.ReadBoolean()
                    fanother(j) = br.ReadBoolean()
                    If Not (Frmselectfan.ChkCurveBlade.Checked = True And fancurved(j) = True Or
                        Frmselectfan.ChkInclineBlade.Checked = True And faninclined(j) = True Or
                        Frmselectfan.ChkPlasticFan.Checked = True And fanplastic(j) = True Or
                        Frmselectfan.ChkOtherFanType.Checked = True And fanother(j) = True) Then
                        j = j - 1
                    End If
                    'End If
                Next
            Catch ex As Exception
            Finally
                br.Close()
            End Try
            'fantypesQTY = j - 1
            fantypesQTY = j

        Catch ex As Exception
            MsgBox("ReadReffromBinaryfile")
        End Try
    End Sub
End Module
