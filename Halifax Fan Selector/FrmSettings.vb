﻿Imports System.Globalization
Imports System.ComponentModel
Imports System.Resources
Imports System.Threading
Imports System.Drawing.Printing
Public Class FrmSettings
    Private PrintPageSettings As New PageSettings
    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        Try
            'Background_Color = ColorDialog1.Color
            Dim Path As String
            Path = UserProfile + "\Halifax.ini"

            ChosenSite = 0
            If optShangai.Checked = True Then ChosenSite = 1
            If optShenzhen.Checked = True Then ChosenSite = 2
            If optXian.Checked = True Then ChosenSite = 3

            Dim str As String
            str = SystemDrive + "\Halifax\"
            writeIni(Path, "Settings", "Halifax Root Folder", str)
            writeIni(Path, "Settings", "Language", ChosenLanguage)
            writeIni(Path, "Settings", "Site", ChosenSite.ToString)
            If username.Length < 1 Then username = "HFL Sales"
            writeIni(Path, "Settings", "User", username)
            ReadWriteINI()
            'FrmStart.Hide()
            'FrmStart.Show()
            FrmStart.optEnglish.Checked = optEnglish.Checked
            FrmStart.optChinese.Checked = optChinese.Checked

            If DataPath IsNot Nothing Then
                FrmStart.btnContinue.Visible = True
            End If
            'FrmStart.Refresh()
            Me.Close()

        Catch ex As Exception
            ErrorMessage(ex, 20400)
        End Try
    End Sub

    Private Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture
            CenterToScreen()
            txtUsername.Text = Environment.UserName
            'UserName = Environment.UserName'300119
            DataPath_main = GetFromINI("Settings", "Halifax Root Folder", SystemDrive + "\Halifax\", ini_path)
            ChosenLanguage = GetFromINI("Settings", "Language", "en-GB", ini_path)
            ChosenSite = GetFromINI("Settings", "Site", "0", ini_path)
            username = GetFromINI("Settings", "User", "HFL Sales", ini_path)
            If txtUsername.Text.ToLower.Contains("akm") Then
                grpLanguage.Visible = True
                optEnglish.Visible = True
                optChinese.Visible = True
                'chkAdvancedUser.Visible = True
                If ChosenLanguage = "zh-CN" Then optChinese.Checked = True
                If ChosenLanguage = "en-GB" Then optEnglish.Checked = True
            End If

            chkAdvancedUser.Checked = False

            Select Case ChosenSite
                Case 0
                    optUK.Checked = True
                Case 1
                    optShangai.Checked = True
                Case 2
                    optShenzhen.Checked = True
                Case 3
                    optXian.Checked = True
                Case Else
                    optUK.Checked = True
            End Select


        Catch ex As Exception
            ErrorMessage(ex, 20402)
        End Try
    End Sub

    Private Sub optEnglish_CheckedChanged(sender As Object, e As EventArgs) Handles optEnglish.CheckedChanged
        Try
            Dim lans As String = CultureInfo.CurrentCulture.ThreeLetterISOLanguageName
            ChosenLanguage = "en-GB"
            If optEnglish.Checked Then ApplyLocale(ChosenLanguage)
            'If optEnglish.Checked Then ApplyLocale()

        Catch ex As Exception
            ErrorMessage(ex, 20403)
        End Try
    End Sub

    Private Sub optChinese_CheckedChanged(sender As Object, e As EventArgs) Handles optChinese.CheckedChanged
        Try
            ChosenLanguage = "zh-CN"
            If optChinese.Checked Then ApplyLocale(ChosenLanguage)
            'If optChinese.Checked Then ApplyLocale()

        Catch ex As Exception
            ErrorMessage(ex, 20404)
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
            ' Debug.WriteLine("$this")
            component_resource_manager.ApplyResources(Me, "$this", culture_info)
            'If grpLanguage.Visible = False Then MsgBox("invisible")
            ' Apply the locale to the form's controls.
            For Each ctl As Control In Me.Controls
                ApplyLocaleToControl(ctl, component_resource_manager, culture_info)
            Next ctl
            'Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)) ',                        FontStyle.Bold Or FontStyle.Italic)

            ' Perform manual localizations.
            ' These resources are stored in the Form1 resource files.
            'Dim resource_manager As New ResourceManager("Localized.Form1", Me.GetType.Assembly)
            Dim resource_manager As New ResourceManager("Localized.FrmSettings", Me.GetType.Assembly)
            If txtUsername.Text.ToLower.Contains("akm") Then
                grpLanguage.Visible = True
                optEnglish.Visible = True
                optChinese.Visible = True
                'chkAdvancedUser.Visible = True
            End If
            'btnContinue.Text = resource_manager.GetString("btnContinue.Text")
            'btnExit.Text = resource_manager.GetString("btnExit.Text")
            'btnSettings.Text = resource_manager.GetString("btnSettings.Text")
            'chkAdvancedUser.Text = resource_manager.GetString("chkAdvancedUser.Text")
            'grpLanguage.Text = resource_manager.GetString("grpLanguage.Text")
            'lblHalifaxFanSelector.Text = resource_manager.GetString("lblHalifaxFanSelector.Text")
            'lblToThe.Text = resource_manager.GetString("lblToThe.Text")
            'lblUsername.Text = resource_manager.GetString("lblUsername.Text")
            'lblWelcome.Text = resource_manager.GetString("lblWelcome.Text")
            'optChinese.Text = resource_manager.GetString("optChinese.Text")
            'optEnglish.Text = resource_manager.GetString("optEnglish.Text")

            '' Tooltips.
            'ToolTip1.SetToolTip(picFlag, resource_manager.GetString("picFlag.ToolTip"))

        Catch ex As Exception
            ErrorMessage(ex, 20405)
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
            ErrorMessage(ex, 20406)
        End Try
    End Sub

    Private Sub btnDataFolder_Click(sender As Object, e As EventArgs) Handles btnDataFolder.Click
        Try
            'ComboBox1.Items.Clear()
            FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop
            FolderBrowserDialog1.SelectedPath = DataPathDefault
            FolderBrowserDialog1.Description = "Select Application Configuration Files Path"
            FolderBrowserDialog1.ShowNewFolderButton = False
            FolderBrowserDialog1.ShowDialog()
            DataPath = FolderBrowserDialog1.SelectedPath ' + "\"
            Label1.Text = "Data Path - " + DataPath
            Label1.ForeColor = Color.White

        Catch ex As Exception
            ErrorMessage(ex, 20407)
        End Try
    End Sub

    Private Sub btnPageSetup_Click(sender As Object, e As EventArgs) Handles btnPageSetup.Click
        Dim pagesize As String
        Try
            SetupPage.PageSettings = PrintPageSettings
            SetupPage.ShowDialog()
            pagesize = SetupPage.PageSettings.PaperSize.PaperName
        Catch ex As Exception
            ErrorMessage(ex, 20408)
        End Try
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        username = txtUsername.Text
    End Sub
End Class