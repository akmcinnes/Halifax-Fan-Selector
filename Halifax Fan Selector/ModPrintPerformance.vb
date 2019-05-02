Module ModPrintPerformance
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
                'OutputopeninletPO(xlsWB, 26)
                'OutputopenoutletPO(xlsWB, 33)
                'OutputbrgPO(xlsWB, 42)
                'OutputmotorPO(xlsWB, 44)
                'OutputbpfPO(xlsWB, 40)
                OutputFooterPO(xlsWB) 'ok
            End With
        Catch ex As Exception
            ErrorMessage(ex, 64031)
        End Try
    End Sub

	    Public Sub PopulatePrintoutDatapoints(xlsWB)
        Try
            sheet = "Datapoints"
            xlsWB.ActiveSheet.Name = sheet
            With xlsWB.ActiveSheet
                .Activate
                SetupPagePO(xlsWB, 10)
                'OutputHeaderPO(xlsWB) 'ok
                'OutputFanDetailsPO(xlsWB, 1)
                'OutputDataTableHeaderPO(xlsWB) 'ok
                OutputDutyPointsPO(xlsWB)
                OutputDataDutyPO(xlsWB)
                If IncludeDampers = True Then
                    OutputDataTableDamperVolPowPO(xlsWB, "BLADES 60º", 0.9, 6, 14)
                    OutputDataTableDamperVolPowPO(xlsWB, "BLADES 50º", 0.8, 7, 15)
                    OutputDataTableDamperVolPowPO(xlsWB, "BLADES 40º", 0.67, 8, 16)
                    OutputDataTableDamperVolPowPO(xlsWB, "BLADES 30º", 0.5, 9, 17)
                End If
                'OutputopeninletPO(xlsWB, 26)
                'OutputopenoutletPO(xlsWB, 33)
                'OutputbrgPO(xlsWB, 42)
                'OutputmotorPO(xlsWB, 44)
                'OutputbpfPO(xlsWB, 40)
                'OutputFooterPO(xlsWB) 'ok
            End With
        Catch ex As Exception
        ErrorMessage(ex, 64031)
        End Try
    End Sub

End Module
