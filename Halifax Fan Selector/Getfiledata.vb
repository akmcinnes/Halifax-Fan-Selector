Imports System.IO
Imports System.Xml
Imports Excel = Microsoft.Office.Interop.Excel
Module Getfiledata
    Sub ReadReffromExcelfile(filename)
        Try
            FullFilePath = "C:\Halifax\Performance Data\" + filename + ".xls"

            Dim xlsApp As Excel.Application = Nothing
            Dim xlsWorkBooks As Excel.Workbooks = Nothing
            Dim xlsWB As Excel.Workbook = Nothing
            Dim i As Integer
            Try
                xlsApp = New Microsoft.Office.Interop.Excel.Application
                xlsApp.Visible = False
                xlsWorkBooks = xlsApp.Workbooks
                xlsWB = xlsWorkBooks.Open(FullFilePath)


                i = 0
                Do While xlsWB.Worksheets(1).Cells(i + 2, 1).value <> ""
                    fantypename(i) = xlsWB.Worksheets(1).Cells(i + 2, 1).Value
                    fanclass(i) = xlsWB.Worksheets(1).Cells(i + 2, 2).Value
                    fantypefilename(i) = xlsWB.Worksheets(1).Cells(i + 2, 3).Value
                    fansizelimit(i) = xlsWB.Worksheets(1).Cells(i + 2, 4).Value
                    fantypesecfilename(i) = xlsWB.Worksheets(1).Cells(i + 2, 5).Value
                    fanunits(i) = xlsWB.Worksheets(1).Cells(i + 2, 6).Value
                    fanwidthing(i) = False
                    If UCase(xlsWB.Worksheets(1).Cells(i + 2, 7).Value) = "YES" Then
                        fanwidthing(i) = True
                    End If
                    i = i + 1
                Loop
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                xlsWB.Close(SaveChanges:=False)
                xlsWB = Nothing
                xlsWorkBooks.Close()
                xlsWorkBooks = Nothing
                xlsApp.Quit()
                xlsApp = Nothing
            End Try
            fantypesQTY = i - 1

        Catch ex As Exception
            MsgBox("ReadReffromExcelfile")
        End Try
    End Sub

    Sub ReadReffromTextfile(filename)
        Try
            FullFilePath = "C:\Halifax\Performance Data new\" + filename + ".txt"
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



End Module
