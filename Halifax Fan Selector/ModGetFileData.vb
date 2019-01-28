Imports System.IO
Imports System.Xml
Module ModGetFileData
    Sub ReadReffromBinaryfile(filename)
        Try
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
            fantypesQTY = j
        Catch ex As Exception
            ErrorMessage(ex, 5301)
        End Try
    End Sub
End Module
