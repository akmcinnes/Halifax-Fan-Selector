Imports System.Globalization
Imports System.ComponentModel
Imports System.Resources
Imports System.Threading
Imports System.Drawing.Printing
Public Class FrmSettings
    Private PrintPageSettings As New PageSettings
    Public changed As Boolean = True
    Public codecheck As Integer = 1
    Public Language_has_changed As Boolean = False
    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        Try
            Dim Path As String
            Path = UserProfile + "\Halifax.ini"

            ChosenSite = 0
            If optShangai.Checked = True Then ChosenSite = 1
            If optShenzhen.Checked = True Then ChosenSite = 2
            If optXian.Checked = True Then ChosenSite = 3
            If optOhio.Checked = True Then ChosenSite = 4
            If txtCode.Text = AccessCode Then
                changed = False
            Else
                changed = True
            End If
            AccessCode = txtCode.Text

            Dim str As String
            str = SystemDrive + "\Halifax\"
            writeIni(Path, "Settings", "Halifax Root Folder", str)
            writeIni(Path, "Settings", "Language", ChosenLanguage)
            writeIni(Path, "Settings", "Site", ChosenSite.ToString)
            writeIni(Path, "Settings", "Access Code", AccessCode)
            If username.Length < 1 Then username = "HFL Sales"
            writeIni(Path, "Settings", "User", username)
            ReadWriteINI()
            FrmStart.optEnglish.Checked = optEnglish.Checked
            FrmStart.optChinese.Checked = optChinese.Checked

            If DataPath IsNot Nothing Then
                FrmStart.btnContinue.Visible = True
            End If
            '#########################################################
            codecheck = CalculateUserCode()
            If codecheck >= 1 Then
                FrmStart.Show()
                Me.Close()
            Else
                End
            End If
        Catch ex As Exception
            ErrorMessage(ex, 20401)
        End Try
    End Sub

    Private Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Label2.Text = ""
            changed = False
            CenterToScreen()
            'get site info
            GetSites()
            Me.optUK.Text = site_name(1)
            Me.optShangai.Text = site_name(2)
            Me.optShenzhen.Text = site_name(3)
            Me.optXian.Text = site_name(4)
            Me.optOhio.Text = site_name(5)
            txtUsername.Text = Environment.UserName
            lblCode.Text = GetUserCode()
            txtCode.Text = AccessCode
            codecheck = CalculateUserCode()
            Label2.Text = ""
            If codecheck = -1 Then
                Label2.Text = Label3.Text + " " + lblCode.Text + " " + Label5.Text
            ElseIf codecheck = 0 Then
                Label2.Text = Label4.Text + " " + lblCode.Text + " " + Label5.Text
                Label2.ForeColor = Color.Red
            Else
            End If
            DataPath_main = GetFromINI("Settings", "Halifax Root Folder", SystemDrive + "\Halifax\", ini_path)
            ChosenLanguage = GetFromINI("Settings", "Language", "en-GB", ini_path)
            ChosenSite = GetFromINI("Settings", "Site", "0", ini_path)
            username = GetFromINI("Settings", "User", "HFL Sales", ini_path)
            grpLanguage.Visible = True
            If ChosenLanguage = "zh-CN" Then optChinese.Checked = True
            If ChosenLanguage = "en-GB" Then optEnglish.Checked = True
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
                Case 4
                    optOhio.Checked = True
                Case Else
                    optUK.Checked = True
            End Select
        Catch ex As Exception
            ErrorMessage(ex, 20402)
        End Try
    End Sub

    Private Sub optEnglish_CheckedChanged(sender As Object, e As EventArgs) Handles optEnglish.CheckedChanged
        Try
            If Not ChosenLanguage = "en-GB" Then
                Language_has_changed = True
                ChosenLanguage = "en-GB"
            Else
                Language_has_changed = False
            End If
            If optEnglish.Checked Then ApplyLocale(ChosenLanguage)
            CodeMessage()
        Catch ex As Exception
            ErrorMessage(ex, 20403)
        End Try
    End Sub

    Private Sub optChinese_CheckedChanged(sender As Object, e As EventArgs) Handles optChinese.CheckedChanged
        Try
            If Not ChosenLanguage = "zh-CN" Then
                Language_has_changed = True
                ChosenLanguage = "zh-CN"
            Else
                Language_has_changed = False
            End If
            If optChinese.Checked Then ApplyLocale(ChosenLanguage)
            CodeMessage()
        Catch ex As Exception
            ErrorMessage(ex, 20404)
        End Try
    End Sub

    Private Sub ApplyLocale(ByVal locale_name As String)
        Try
            ' Make a CultureInfo and ComponentResourceManager.
            Dim culture_info As New CultureInfo(locale_name)
            Dim component_resource_manager As New ComponentResourceManager(Me.GetType)
            Thread.CurrentThread.CurrentUICulture = culture_info
            Thread.CurrentThread.CurrentCulture = culture_info
            component_resource_manager.ApplyResources(Me, "$this", culture_info)
            For Each ctl As Control In Me.Controls
                ApplyLocaleToControl(ctl, component_resource_manager, culture_info)
            Next ctl
            Dim resource_manager As New ResourceManager("Localized.FrmSettings", Me.GetType.Assembly)
            grpLanguage.Visible = True
        Catch ex As Exception
            ErrorMessage(ex, 20405)
        End Try
    End Sub

    Private Sub ApplyLocaleToControl(ByVal ctl As Control, ByVal component_resource_manager As ComponentResourceManager, ByVal culture_info As CultureInfo)
        Try
            component_resource_manager.ApplyResources(ctl, ctl.Name, culture_info)
            For Each child As Control In ctl.Controls
                ApplyLocaleToControl(child, component_resource_manager, culture_info)
            Next child
        Catch ex As Exception
            ErrorMessage(ex, 20406)
        End Try
    End Sub

    Private Sub btnDataFolder_Click(sender As Object, e As EventArgs) Handles btnDataFolder.Click
        Try
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
        Try
            username = txtUsername.Text
        Catch ex As Exception
            ErrorMessage(ex, 20409)
        End Try
    End Sub

    Private Sub txtCode_TextChanged(sender As Object, e As EventArgs) Handles txtCode.TextChanged
        AccessCode = txtCode.Text
        CodeMessage()
    End Sub

    Private Sub CodeMessage()
        codecheck = CalculateUserCode()
        Dim codemessage As String = GetUserCode().ToString
        If codecheck = -1 Then
            Label2.Text = Label3.Text + " " + codemessage + " " + Label5.Text
            Label2.ForeColor = Color.Yellow
        ElseIf codecheck = 0 Then
            Label2.Text = Label4.Text + " " + codemessage + " " + Label5.Text
            Label2.ForeColor = Color.Red
        Else
            Label2.Text = Label6.Text
            Label2.ForeColor = Color.White
        End If
    End Sub
End Class