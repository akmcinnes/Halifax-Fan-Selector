Imports Excel = Microsoft.Office.Interop.Excel
Module ModPrintCurve
    Public Sub PopulatePrintoutChart(xlsWB)
        Try

            sheet = "Chart"
            xlsWB.ActiveChart.Name = sheet
            With xlsWB.ActiveChart
                .SeriesCollection(1).Name = "FSP " & "" 'snme(1)
                .SeriesCollection(2).Name = "FTP " & "" ' snme(1)
                .SeriesCollection(3).Name = "Power " & "" 'snme(1)
                'check for fan type frm dictionary
                Dim i As Integer
                Dim found As Boolean = False
                For i = 141 To 170
                    If final.fantypename = lang_dictEN(i) Then
                        found = True
                        Exit For
                    End If
                Next
                Dim didw As String = ""
                If SelectDIDW = True Then didw = " (DIDW)"
                'title
                If found = False Then
                    .ChartTitle.text = lang_dict(106) & " " & final.fansize.ToString & " " & final.fantypename & " " & lang_dict(3) & didw
                Else
                    .ChartTitle.text = lang_dict(106) & " " & final.fansize.ToString & " " & lang_dict(i) & " " & lang_dict(3) & didw
                End If

                .ChartTitle.Font.Name = "Arial"
                .ChartTitle.Font.size = 12
                .ChartTitle.Font.Bold = True
                .ChartTitle.Font.Underline = True
                .ChartTitle.Top = 20
                .HasLegend = False
                '.Axes(.xlCategory, .xlPrimary).AxisTitle.Caption = "abcdefg"
                '.Axes(.XlAxisType.xlValue, .XlAxisType.Primary).AxisTitle.Caption = "abcdefg" 'yaxistitle
                Dim LastString As String
                Dim LastPosn As Integer
                Dim lastheight As Integer

                Dim NN As Integer = 37
                Dim MM As Integer = 27
                ' shape 1 is the logo
                'textbox 2 - copyright
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 80, 415, 600, 30).TextFrame.Characters.Text = lang_dict(16) '"All copyright in this document is vested in Halifax Fan Ltd. It contains proprietary information and may not be disclosed to any third party or reproduced in any form without the written permission of Halifax Fan Ltd."
                .Shapes(2).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(2).TextFrame.Characters.Font.size = 6

                'textbox 3 - engineer, etc
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 0, 460, 500, 14).TextFrame.Characters.Text = lang_dict(108) + Engineer + " " + lang_dict(15) + Date.Now.ToString("dd/MM/yyyy") + " " + lang_dict(109) 'DrawnBy
                .Shapes(3).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(3).TextFrame.Characters.Font.size = 7

                'textbox 4 - company
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 580, MM, 120, 15).TextFrame.Characters.Text = lang_dict(17)
                .Shapes(4).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(4).TextFrame.Characters.Font.size = 7

                'textbox 5 - address
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 580, MM + 8, 150, 25).TextFrame.Characters.Text = lang_dict(18) 'Address(1) & Chr(13) & Address(2)
                .Shapes(5).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(5).TextFrame.Characters.Font.size = 6
                .Shapes(5).TextFrame.Characters.Font.Italic = True

                'textbox 6 - email
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 580, MM + 23, 150, 45).TextFrame.Characters.Text = lang_dict(20) + vbCr + lang_dict(19) '"eemm" 'EmailName & TelNo
                .Shapes(6).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(6).TextFrame.Characters.Font.size = 7

                'textbox 7 - operating conditions
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 170, NN, 150, 20).TextFrame.Characters.Text = lang_dict(107)
                .Shapes(7).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(7).TextFrame.Characters.Font.size = 9 '9
                .Shapes(7).TextFrame.Characters.Font.Bold = True
                '.Shapes(7).TextFrame.Characters.Font.Underline = True

                'textbox 8 - speed
                'If frmcurveoptions.Optsingle.Value = True Then
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 310, NN, 150, 20).TextFrame.Characters.Text = lang_dict(123) & vbTab & final.speed.ToString & " " & "RPM"
                .Shapes(8).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(8).TextFrame.Characters.Font.size = 9

                'textbox 9 - density
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 440, NN, 150, 20).TextFrame.Characters.Text = lang_dict(121) & vbTab & knowndensity.ToString & " " & Units(3).UnitName(Units(3).UnitSelected)
                .Shapes(9).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(9).TextFrame.Characters.Font.size = 9

                'textbox 10 - duty title
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 140, NN + 12, 150, 20).TextFrame.Characters.Text = lang_dict(122)
                .Shapes(10).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(10).TextFrame.Characters.Font.size = 9
                .Shapes(10).TextFrame.Characters.Font.bold = True

                'textbox 11 - flow
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 170, NN + 12, 150, 20).TextFrame.Characters.Text = lang_dict(117) & vbTab & final.vol.ToString & " " & Units(0).UnitName(Units(0).UnitSelected)
                .Shapes(11).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(11).TextFrame.Characters.Font.size = 9

                'textbox 12 - pressure

                If PresType = 0 Then
                    .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 310, NN + 12, 150, 20).TextFrame.Characters.Text = lang_dict(118) & vbTab & final.fsp.ToString & " " & Units(1).UnitName(Units(1).UnitSelected)
                End If
                If PresType = 1 Then
                    .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 310, NN + 12, 150, 20).TextFrame.Characters.Text = lang_dict(119) & vbTab & final.fsp.ToString & " " & Units(1).UnitName(Units(1).UnitSelected)
                End If

                .Shapes(12).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(12).TextFrame.Characters.Font.size = 9

                'TextBox 13 - power
                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 440, NN + 12, 150, 20).TextFrame.Characters.Text = lang_dict(120) & vbTab & final.pow.ToString & " " & Units(4).UnitName(Units(4).UnitSelected)
                .Shapes(13).TextFrame.Characters.Font.Name = "Arial"
                .Shapes(13).TextFrame.Characters.Font.size = 9

                LastString = ""
                LastPosn = 372
                lastheight = 0

                .Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 425, NN + 36, 250, lastheight).TextFrame.Characters.Text = LastString
                '.Shapes.AddShape(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 580, 0, 145, 30).Fill.UserPicture(headerlocation)
                .Shapes(.Shapes.count).Line.Visible = False
            End With
            If FrmCurveOptions.optFSPonly.Checked = True Or FrmCurveOptions.optFTPonly.Checked = True Then
                deletecurveftp(xlsWB)
            End If

            With xlsWB.ActiveChart
                Dim axis As Excel.Axis
                axis = CType(.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary), Excel.Axis)
                axis.HasTitle = True

                If FrmCurveOptions.optFSPonly.Checked = True Then
                    axis.AxisTitle.Text = lang_dict(118) + " (" + Units(1).UnitName(Units(1).UnitSelected) + ")"
                End If
                If FrmCurveOptions.optFTPonly.Checked = True Then
                    axis.AxisTitle.Text = lang_dict(119) + " (" + Units(1).UnitName(Units(1).UnitSelected) + ")"
                End If
                If FrmCurveOptions.optFSPandFTP.Checked = True Then
                    axis.AxisTitle.Text = lang_dict(124) + " (" + Units(1).UnitName(Units(1).UnitSelected) + ")"
                End If


                axis = CType(.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlSecondary), Excel.Axis)
                axis.HasTitle = True
                axis.AxisTitle.Text = lang_dict(120) + " (" + Units(4).UnitName(Units(4).UnitSelected) + ")"

                axis = CType(.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary), Excel.Axis)
                axis.HasTitle = True
                axis.AxisTitle.Text = lang_dict(117) + " (" + Units(0).UnitName(Units(0).UnitSelected) + ")"
            End With
        Catch ex As Exception
            ErrorMessage(ex, 64031)
        End Try

    End Sub


    Public Sub deletecurveftp(xlsWB)
        Try
            sheet = "Chart"
            xlsWB.ActiveChart.Name = sheet
            With xlsWB.activechart
                Dim NN As Integer
                'If FrmCurveOptions.optFSPonly.Checked = True Or FrmCurveOptions.optFTPonly.Checked = True Then
                NN = PresType
                'If FrmCurveOptions.txtfanspd8.Visible = True Or FrmCurveOptions.txtgd8.Visible = True Then
                '    ActiveChart.SeriesCollection(23 - NN).Delete
                'End If
                'If FrmCurveOptions.txtfanspd7.Visible = True Or FrmCurveOptions.txtgd7.Visible = True Then
                '    ActiveChart.SeriesCollection(20 - NN).Delete
                'End If
                'If FrmCurveOptions.txtfanspd6.Visible = True Or FrmCurveOptions.txtgd6.Visible = True Then
                '    ActiveChart.SeriesCollection(17 - NN).Delete
                'End If
                'If FrmCurveOptions.txtfanspd5.Visible = True Or FrmCurveOptions.txtgd5.Visible = True Then
                '    ActiveChart.SeriesCollection(14 - NN).Delete
                'End If
                'If FrmCurveOptions.txtfanspd4.Visible = True Or FrmCurveOptions.txtgd4.Visible = True Then
                '    ActiveChart.SeriesCollection(11 - NN).Delete
                'End If
                'If FrmCurveOptions.txtfanspd3.Visible = True Or FrmCurveOptions.txtgd3.Visible = True Then
                '    ActiveChart.SeriesCollection(8 - NN).Delete
                'End If
                'If FrmCurveOptions.txtfanspd2.Visible = True Or FrmCurveOptions.txtgd2.Visible = True Then
                '    ActiveChart.SeriesCollection(5 - NN).Delete
                'End If
                .SeriesCollection(2 - NN).Delete
                'End If

            End With

        Catch ex As Exception
            ErrorMessage(ex, 64031)
        End Try

    End Sub


End Module
