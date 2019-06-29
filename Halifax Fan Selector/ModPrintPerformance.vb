Module ModPrintPerformance
    'subroutines
    'PopulatePrintoutPerformance
    'script to populate performance excel sheet

    'PopulatePrintoutDatapoints
    'script to populate curve excel points

    Sub PopulatePrintoutPerformance(xlsWB)
        Try
            sheet = "Performance"
            xlsWB.ActiveSheet.Name = sheet
            With xlsWB.ActiveSheet
                .Activate
                SetupPagePO(xlsWB)
                OutputHeaderPO(xlsWB) 'ok
                OutputFanDetailsPO(xlsWB, 1)
                OutputDataTableHeaderPO(xlsWB) 'ok
                OutputDataTablePO(xlsWB)
                OutputFooterPO(xlsWB) 'ok
            End With
        Catch ex As Exception
            ErrorMessage(ex, 7001)
        End Try
    End Sub

    Public Sub PopulatePrintoutDatapoints(xlsWB)
        Try
            sheet = "Datapoints"
            xlsWB.ActiveSheet.Name = sheet
            With xlsWB.ActiveSheet
                .Activate
                SetupPagePO(xlsWB, 10)
                OutputDutyPointsPO(xlsWB)
                OutputDataDutyPO(xlsWB)
                If IncludeDampers = True Then
                    OutputDataTableDamperVolPowPO(xlsWB, "BLADES 60º", 0.9, 6, 14)
                    OutputDataTableDamperVolPowPO(xlsWB, "BLADES 50º", 0.8, 7, 15)
                    OutputDataTableDamperVolPowPO(xlsWB, "BLADES 40º", 0.67, 8, 16)
                    OutputDataTableDamperVolPowPO(xlsWB, "BLADES 30º", 0.5, 9, 17)
                End If
                If IncludeSystem = True Then
                    OutputDataTableSystemPO(xlsWB, "System CURVE", "curvevol", "Pressure", 11, 12)
                End If
                If numspeeds > 1 Then
                    For i = 1 To numspeeds
                        If i = 2 Then OutputDataTableAddSpeedsPO(xlsWB, 7, 6, i - 1)
                        If i = 3 Then OutputDataTableAddSpeedsPO(xlsWB, 42, 1, i - 1)
                        If i = 4 Then OutputDataTableAddSpeedsPO(xlsWB, 42, 6, i - 1)
                        If i = 5 Then OutputDataTableAddSpeedsPO(xlsWB, 77, 1, i - 1)
                        If i = 6 Then OutputDataTableAddSpeedsPO(xlsWB, 77, 6, i - 1)
                        If i = 7 Then OutputDataTableAddSpeedsPO(xlsWB, 112, 1, i - 1)
                        If i = 8 Then OutputDataTableAddSpeedsPO(xlsWB, 112, 6, i - 1)
                    Next
                End If
                If numdensities > 1 Then
                    For i = 1 To numdensities
                        If i = 2 Then OutputDataTableAddDensitiesPO(xlsWB, 7, 6, i - 1)
                        If i = 3 Then OutputDataTableAddDensitiesPO(xlsWB, 42, 1, i - 1)
                        If i = 4 Then OutputDataTableAddDensitiesPO(xlsWB, 42, 6, i - 1)
                        If i = 5 Then OutputDataTableAddDensitiesPO(xlsWB, 77, 1, i - 1)
                        If i = 6 Then OutputDataTableAddDensitiesPO(xlsWB, 77, 6, i - 1)
                        If i = 7 Then OutputDataTableAddDensitiesPO(xlsWB, 112, 1, i - 1)
                        If i = 8 Then OutputDataTableAddDensitiesPO(xlsWB, 112, 6, i - 1)
                    Next
                End If
            End With
        Catch ex As Exception
            ErrorMessage(ex, 7002)
        End Try
    End Sub
End Module
