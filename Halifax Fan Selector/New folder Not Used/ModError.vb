Module ModError
    Public Function errorcheck1()
        errorcheck1 = 0
        '    If Frmselectfan.TxtPBwidth1.Visible = True And Val(Frmselectfan.Txtfansize) = 0 Then
        '        MsgBox("Error in Fan 1: You must select a fan size when specifying a blade width!"), vbQuestion
        'errorcheck1 = 1
        '        Exit Function
        '    End If
        '    If Frmselectfan.TxtPBwidth2.Visible = True And Val(Frmselectfan.Txtfansize2) = 0 Then
        '        MsgBox("Error in fan 2: You must select a fan size when specifying a blade width!"), vbQuestion
        'errorcheck1 = 1
        '        Exit Function
        '    End If
        '    If Frmselectfan.TxtPBwidth3.Visible = True And Val(Frmselectfan.txtfansize3) = 0 Then
        '        MsgBox("Error in fan 3: You must select a fan size when specifying a blade width!"), vbQuestion
        'errorcheck1 = 1
        '        Exit Function
        '    End If
        '    If Frmselectfan.TxtPBwidth4.Visible = True And Val(Frmselectfan.txtfansize4) = 0 Then
        '        MsgBox("Error in fan 4: You must select a fan size when specifying a blade width!"), vbQuestion
        'errorcheck1 = 1
        '        Exit Function
        '    End If
        '    If Frmselectfan.TxtPBwidth5.Visible = True And Val(Frmselectfan.txtfansize5) = 0 Then
        '        MsgBox("Error in fan 5: You must select a fan size when specifying a blade width!"), vbQuestion
        'errorcheck1 = 1
        '        Exit Function
        '    End If
        '    If Frmselectfan.Comfantype1.ListIndex = -1 Then
        '        MsgBox("Select A Fan Type To Continue!"), vbQuestion
        'errorcheck1 = 1
        '        Exit Function
        '    End If
        '    If Frmselectfan.Comfantype2.ListIndex = -1 And Frmselectfan.Comfantype2.Visible = True Then
        '        MsgBox("Select Fan Type 2 To Continue!"), vbQuestion
        'errorcheck1 = 1
        '        Exit Function
        '    End If
        '    If Frmselectfan.Comfantype3.ListIndex = -1 And Frmselectfan.Comfantype3.Visible = True Then
        '        MsgBox("Select Fan Type 3 To Continue!"), vbQuestion
        'errorcheck1 = 1
        '        Exit Function
        '    End If
        '    If Frmselectfan.Comfantype4.ListIndex = -1 And Frmselectfan.Comfantype4.Visible = True Then
        '        MsgBox("Select Fan Type 4 To Continue!"), vbQuestion
        'errorcheck1 = 1
        '        Exit Function
        '    End If
        '    If Frmselectfan.Comfantype5.ListIndex = -1 And Frmselectfan.Comfantype5.Visible = True Then
        '        MsgBox("Select Fan Type 5 To Continue!"), vbQuestion
        'errorcheck1 = 1
        '        Exit Function
        '    End If
        '    '-end of checking fantypes now checking other inputs
        '    '-checking for density input
        '    If Frmselectfan.Txtdens.Value <= 0 Or Frmselectfan.Txtdens.Value = "" Then
        '        MsgBox("Please enter a valid density to continue!"), vbInformation
        'errorcheck1 = 1
        '        Exit Function
        '    End If
        '    If Frmselectfan.Txtfansize.Value = 0 And Frmselectfan.Txtfanspeed.Value = 0 Then
        '        If Frmselectfan.Txtflow.Value = 0 Or Frmselectfan.TXTFSP.Value = 0 Then
        '            MsgBox("More information please?"), vbInformation
        '    errorcheck1 = 1
        '            Exit Function
        '        End If
        '    End If
        '    If Frmselectfan.Txtfansize.Value > 0 Then
        '        If Frmselectfan.Txtfanspeed.Value = 0 Then
        '            If Frmselectfan.Txtflow.Value = 0 Or Frmselectfan.TXTFSP.Value = 0 Then
        '                MsgBox("More information Please?"), vbInformation
        '        errorcheck1 = 1
        '                Exit Function
        '            End If
        '        End If
        '    End If
    End Function

    Function IsFileOpen(filename As String)
        Dim filenum As Integer, errnum As Integer

        On Error Resume Next   ' Turn error checking off.
        filenum = FreeFile()   ' Get a free file number.
        ' Attempt to open the file and lock it.
        '        Open filename For Input Lock Read As #filenum
        '       Close filenum          ' Close the file.
        errnum = Err()           ' Save the error number that occurred.
        On Error GoTo 0        ' Turn error checking back on.

        ' Check to see which error occurred.
        Select Case errnum

        ' No error occurred.
        ' File is NOT already open by another user.
            Case 0
                IsFileOpen = False

        ' Error number for "File does not exist."
            Case 53
                IsFileOpen = False

        ' Error number for "Permission Denied."
        ' File is already opened by another user.
            Case 70
                IsFileOpen = True

                ' Another error occurred.
            Case Else
                Error errnum
        End Select

    End Function


End Module
