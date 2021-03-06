﻿Module ModGetFileData
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
                    If fansizelimit(j) = 0 Then fansizelimit(j) = 102
                    fantypesecfilename(j) = br.ReadString()
                    fanunits(j) = br.ReadString()
                    fanwidthing(j) = br.ReadBoolean()
                    'fancurved(j) = br.ReadBoolean()
                    'faninclined(j) = br.ReadBoolean()
                    'fanplastic(j) = br.ReadBoolean()
                    'fanother(j) = br.ReadBoolean()

                    fanwide(j) = br.ReadBoolean()
                    fanmedium(j) = br.ReadBoolean()
                    fannarrow(j) = br.ReadBoolean()
                    fanhighpressure(j) = br.ReadBoolean()
                    faninclined(j) = br.ReadBoolean()
                    fancurved(j) = br.ReadBoolean()
                    fanpaddle(j) = br.ReadBoolean()
                    fanradial(j) = br.ReadBoolean()
                    fanplastic(j) = br.ReadBoolean()
                    fanother(j) = br.ReadBoolean()

                    'If Not (Frmselectfan.ChkCurveBlade.Checked = True And fancurved(j) = True Or
                    '    Frmselectfan.ChkInclineBlade.Checked = True And faninclined(j) = True Or
                    '    Frmselectfan.ChkPlasticFan.Checked = True And fanplastic(j) = True Or
                    '    Frmselectfan.ChkOtherFanType.Checked = True And fanother(j) = True) Then
                    '    j = j - 1
                    'End If

                    For index = 141 To 170
                        If lang_dict(2, index) = fantypename(j) Then
                            fantypename(j) = lang_dict(1, index)
                            Exit For
                        End If
                    Next

                    If OpenFromToolStrip = False And StandAlone = False Then
                        If Not (Frmselectfan.chkWide.Checked = True And fanwide(j) = True Or
                        Frmselectfan.chkMedium.Checked = True And fanmedium(j) = True Or
                        Frmselectfan.chkNarrow.Checked = True And fannarrow(j) = True Or
                        Frmselectfan.chkHighPressure.Checked = True And fanhighpressure(j) = True Or
                        Frmselectfan.ChkCurveBlade.Checked = True And fancurved(j) = True Or
                        Frmselectfan.ChkInclineBlade.Checked = True And faninclined(j) = True Or
                        Frmselectfan.ChkPlasticFan.Checked = True And fanplastic(j) = True Or
                        Frmselectfan.chkPaddleBlade.Checked = True And fanpaddle(j) = True Or
                        Frmselectfan.chkRadialBlade.Checked = True And fanradial(j) = True Or
                        Frmselectfan.ChkOtherFanType.Checked = True And fanother(j) = True Or
                            Frmselectfan.lstFanDesigns.SelectedItem = fantypename(j)) Then
                            j = j - 1
                        End If
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
