Module ErrorMessages
    Sub ErrorMessage(ex As Exception, ErrNo As Integer)
        Dim ErrMsg As String = "Error Number 9909"
        Select Case ErrNo
            '1000 series Environment errors
            Case 1001
            Case 1002
            Case 1003
                ErrMsg = "Environment Input Error " + ErrNo.ToString + vbCrLf + ex.Message
        End Select
        MsgBox(ErrMsg, vbOKCancel, "Error Message")
    End Sub
End Module
