﻿Imports System.Globalization
Imports System.ComponentModel
Imports System.Resources
Imports System.Threading

Public Class FrmStart
    Private Sub Start_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim Path As String
            Dim exists As Boolean
            UserProfile = System.Environment.ExpandEnvironmentVariables("%userprofile%")
            Path = UserProfile + "\Halifax.ini"
            exists = System.IO.File.Exists(Path)
            If exists = True Then
                btnSettings.Visible = True 'False
            Else
                btnSettings.Visible = True
            End If
            ReadWriteINI()
            For i = 0 To 9
                Flag(i) = False
            Next

            If ChosenLanguage = "zh-CN" Then optChinese.Checked = True
            If ChosenLanguage = "en-GB" Then optEnglish.Checked = True
            Dim todaydate As String
            todaydate = Date.Today.ToString("dd/MM/yyyy")
            lblDate.Text = todaydate
            Dim strArg() As String
            strArg = Command().Split(" ")
            DataPath = Nothing
            chkAdvancedUser.Checked = False
            chkAdvancedUser.Visible = False
            btnContinue.Visible = True
            StartArg = strArg(0)
            'If AccessCode = "" Then
            '    MsgBox("No license is present to run this software" + vbCrLf + vbCrLf + "Please contact Halifax Fan Limited, quoting " + GetUserCode().ToString + " to obtain a license.")
            '    End

            'End If
            If CalculateUserCode() < 1 Then
                FrmSettings.ShowDialog()
                End
            End If
            'Kill_Excel()
#If DEBUG Then
            DataPathMain = "C:\Halifax\"
#Else
            DataPathMain = ".\"
#End If
            DataPathDefault = DataPathMain + "Performance Data\"
            OutputPathDefault = DataPathMain + "Output Files\"
            ProjectPathDefault = DataPathMain + "Projects\"
            TemplatesPathDefault = DataPathMain + "Templates\"

            'read file here
            Dim userarg As String = ""
            Dim FILE_NAME As String = DataPathMain + "HFS_User.txt"
            Dim TextLine As String = ""
            If System.IO.File.Exists(FILE_NAME) = True Then
                Dim objReader As New System.IO.StreamReader(FILE_NAME)
                Do While objReader.Peek() <> -1
                    TextLine = TextLine & objReader.ReadLine() & vbNewLine
                    If TextLine.ToLower.Contains(Environment.UserName) Then
                        userarg = "-a"
                    End If
                Loop
            Else
                MessageBox.Show("File Does Not Exist")
            End If

            'If StartArg.ToLower.Contains("-a") Or StartArg.ToLower.Contains("-dev") Then
            If StartArg.ToLower.Contains("-a") Or userarg.ToLower.Contains("-a") Then
                DataPath = DataPathDefault
                chkAdvancedUser.Checked = True
                'chkAdvancedUser.Visible = True
                grpLanguage.Visible = True
            ElseIf StartArg.ToLower.Contains("-b") Then
                DataPath = DataPathDefault
            Else
                DataPath = DataPathDefault
            End If

            SystemDrive = System.Environment.ExpandEnvironmentVariables("%SystemDrive%")
            UserProfile = System.Environment.ExpandEnvironmentVariables("%userprofile%")
            DataPath_main = DataPathMain '"C:\Halifax\"
            Language = "English"
            User_Type = False
            SuppressErrorMessages = False

            CenterToScreen()
            If ChosenLanguage Is Nothing Then ChosenLanguage = "en-GB"
            ApplyLocale(ChosenLanguage)

            getLanguageDictionary()

        Catch ex As Exception
            ErrorMessage(ex, 20501)
        End Try
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Try
            Flag(0) = True
            Hide()
            AdvancedUser = chkAdvancedUser.Checked
            Frmselectfan.ShowDialog()

        Catch ex As Exception
            ErrorMessage(ex, 20502)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Try
            End

        Catch ex As Exception
            ErrorMessage(ex, 20503)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            System.Diagnostics.Process.Start("http://www.halifax-fan.co.uk/")
        Catch ex As Exception
            'Code to handle the error.
            ErrorMessage(ex, 20504)
        End Try
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        Try
            Cursor = Cursors.Hand
        Catch ex As Exception
            ErrorMessage(ex, 20505)
        End Try
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        Try
            Cursor = Cursors.Default
        Catch ex As Exception
            ErrorMessage(ex, 20506)
        End Try
    End Sub

    Private Sub btnContinue_MouseHover(sender As Object, e As EventArgs) Handles btnContinue.MouseHover
        Try
            Cursor = Cursors.Hand
        Catch ex As Exception
            ErrorMessage(ex, 20507)
        End Try
    End Sub

    Private Sub btnExit_MouseHover(sender As Object, e As EventArgs) Handles btnExit.MouseHover
        Try
            Cursor = Cursors.Hand
        Catch ex As Exception
            ErrorMessage(ex, 20508)
        End Try
    End Sub

    Private Sub btnContinue_MouseLeave(sender As Object, e As EventArgs) Handles btnContinue.MouseLeave
        Try
            Cursor = Cursors.Default
        Catch ex As Exception
            ErrorMessage(ex, 20509)
        End Try
    End Sub

    Private Sub btnExit_MouseLeave(sender As Object, e As EventArgs) Handles btnExit.MouseLeave
        Try
            Cursor = Cursors.Default
        Catch ex As Exception
            ErrorMessage(ex, 20510)
        End Try
    End Sub

    Private Sub txtUsername_MouseHover(sender As Object, e As EventArgs) Handles txtUsername.MouseHover
        Try
            Cursor = Cursors.Hand
        Catch ex As Exception
            ErrorMessage(ex, 20511)
        End Try
    End Sub

    Private Sub txtUsername_MouseLeave(sender As Object, e As EventArgs) Handles txtUsername.MouseLeave
        Try
            Cursor = Cursors.Default
        Catch ex As Exception
            ErrorMessage(ex, 20512)
        End Try
    End Sub

    'Private Sub btnContinue_DoubleClick(sender As Object, e As EventArgs) Handles btnContinue.DoubleClick
    '    'FrmGeneralInfo.ShowDialog()
    'End Sub

    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Try
            FrmSettings.ShowDialog()
            If FrmSettings.Language_has_changed = True Then
                lblLanguageMessage.Visible = True
                getLanguageDictionary()
                lblLanguageMessage.Visible = False
            End If
        Catch ex As Exception
            ErrorMessage(ex, 20513)
        End Try
    End Sub

    Private Sub optEnglish_CheckedChanged(sender As Object, e As EventArgs) Handles optEnglish.CheckedChanged
        Try
            If optEnglish.Checked Then
                ChosenLanguage = "en-GB"
                ApplyLocale(ChosenLanguage)
            End If
        Catch ex As Exception
            ErrorMessage(ex, 20514)
        End Try
    End Sub

    Private Sub optChinese_CheckedChanged(sender As Object, e As EventArgs) Handles optChinese.CheckedChanged
        Try
            If optChinese.Checked Then
                ChosenLanguage = "zh-CN"
                ApplyLocale(ChosenLanguage)
            End If
        Catch ex As Exception
            ErrorMessage(ex, 20515)
        End Try
    End Sub

    Private Sub ApplyLocale(ByVal locale_name As String)
        Try
            ' Make a CultureInfo and ComponentResourceManager.
            Dim culture_info As New CultureInfo(locale_name)
            Dim component_resource_manager As New ComponentResourceManager(Me.GetType)

            ' Make the thread use this locale. This doesn't change
            ' existing controls but will apply to those loaded later
            ' and to messages we get for Help About (see below).
            Thread.CurrentThread.CurrentUICulture = culture_info
            Thread.CurrentThread.CurrentCulture = culture_info

            ' Apply the locale to the form itself.
            component_resource_manager.ApplyResources(Me, "$this", culture_info)
            'If grpLanguage.Visible = False Then MsgBox("invisible")
            ' Apply the locale to the form's controls.
            For Each ctl As Control In Me.Controls
                ApplyLocaleToControl(ctl, component_resource_manager, culture_info)
            Next ctl

            ' Perform manual localizations.
            ' These resources are stored in the Form1 resource files.
            Dim resource_manager As New ResourceManager("Localized.FrmStart", Me.GetType.Assembly)
        Catch ex As Exception
            ErrorMessage(ex, 20516)
        End Try
    End Sub

    Private Sub ApplyLocaleToControl(ByVal ctl As Control, ByVal component_resource_manager As ComponentResourceManager, ByVal culture_info As CultureInfo)
        Try
            component_resource_manager.ApplyResources(ctl, ctl.Name, culture_info)

            ' See what kind of control this is.
            'If TypeOf ctl Is MenuStrip Then
            '    ' Apply the new locale to the MenuStrip's items.
            '    Dim menu_strip As MenuStrip = DirectCast(ctl, MenuStrip)
            '    For Each child As ToolStripMenuItem In menu_strip.Items
            '        'ApplyLocaleToToolStripItem(child, component_resource_manager, culture_info)
            '    Next child
            'Else
            ' Apply the new locale to the control's children.
            For Each child As Control In ctl.Controls
                ApplyLocaleToControl(child, component_resource_manager, culture_info)
            Next child
            'End If

        Catch ex As Exception
            ErrorMessage(ex, 20517)
        End Try
    End Sub

    Private Sub FrmStart_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        Try
            MsgBox("Software developed by:" + vbCrLf + "Kerr Software Solutions Limited", vbOKOnly + vbInformation, "")

        Catch ex As Exception
            ErrorMessage(ex, 20518)
        End Try
    End Sub

    Private Sub lblWelcome_DoubleClick(sender As Object, e As EventArgs) Handles lblWelcome.DoubleClick
        Try
            OpenSettings()
        Catch ex As Exception
            ErrorMessage(ex, 20519)
        End Try
    End Sub

    Private Sub lblToThe_DoubleClick(sender As Object, e As EventArgs) Handles lblToThe.DoubleClick
        Try
            OpenSettings()
        Catch ex As Exception
            ErrorMessage(ex, 20520)
        End Try
    End Sub

    Private Sub lblHalifaxFanSelector_DoubleClick(sender As Object, e As EventArgs) Handles lblHalifaxFanSelector.DoubleClick
        Try
            OpenSettings()
        Catch ex As Exception
            ErrorMessage(ex, 20521)
        End Try
    End Sub

    Private Sub OpenSettings()
        Try
            FrmSettings.ShowDialog()
        Catch ex As Exception
            ErrorMessage(ex, 20522)
        End Try
    End Sub

End Class