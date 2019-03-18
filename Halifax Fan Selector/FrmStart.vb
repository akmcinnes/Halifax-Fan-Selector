Imports System.Globalization
Imports System.ComponentModel
Imports System.Resources
Imports System.Threading
Public Class FrmStart
    Private Sub Start_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            For i = 0 To 9
                Flag(i) = False
            Next
            Dim lng As String
            lng = CultureInfo.CurrentCulture.ThreeLetterISOLanguageName.ToString
            If lng.ToLower.Contains("chi") Then
                ChosenLanguage = "zh-CN"
                optChinese.Checked = True
            Else
                ChosenLanguage = "en-US"
                optEnglish.Checked = True
            End If
            Dim todaydate As String
            todaydate = Date.Today.ToString("dd MMMM yyyy")
            lblDate.Text = todaydate
            Dim strArg() As String
            strArg = Command().Split(" ")
            DataPath = Nothing
            chkAdvancedUser.Checked = False
            chkAdvancedUser.Visible = False
            btnContinue.Visible = True
            StartArg = strArg(0)
#If DEBUG Then
            DataPathMain = "C:\Halifax\"
#Else
            DataPathMain = ".\"
#End If
            DataPathDefault = DataPathMain + "Performance Data\"
            OutputPathDefault = DataPathMain + "Output Files\"
            ProjectPathDefault = DataPathMain + "Projects\"
            TemplatesPathDefault = DataPathMain + "Templates\"

            If StartArg.ToLower.Contains("-a") Or StartArg.ToLower.Contains("-dev") Then
                DataPath = DataPathDefault
                chkAdvancedUser.Checked = True
                chkAdvancedUser.Visible = True
                grpLanguage.Visible = True
            ElseIf StartArg.ToLower.Contains("-b") Then
                DataPath = DataPathDefault
            Else
                DataPath = DataPathDefault
            End If

            SystemDrive = System.Environment.ExpandEnvironmentVariables("%SystemDrive%")
            UserProfile = System.Environment.ExpandEnvironmentVariables("%userprofile%")
            'Dim Path As String
            'Path = UserProfile + "\Halifax.ini"
            'exists = System.IO.File.Exists(Path)
            'If exists = False Then
            '    FrmSettings.ShowDialog()
            '    btnContinue.Visible = False
            '    chkAdvancedUser.Visible = False
            'Else
            '    ini_path = GetINIPath()
            '    ' ### Get the Halifax path with the ini file ###

            '    DataPath_main = GetFromINI("Settings", "Halifax Root Folder", SystemDrive + "\temp\", ini_path)
            '    Language = GetFromINI("Settings", "Language", "English", ini_path)
            '    User_Type = GetFromINI("Settings", "User", "False", ini_path)
            '    SuppressErrorMessages = GetFromINI("Settings", "Suppress Error Messages", "False", ini_path)

            'End If
            If Not StartArg.ToLower.Contains("-dev") Then btnSettings.Visible = False
            DataPath_main = DataPathMain '"C:\Halifax\"
            Language = "English"
            User_Type = False
            SuppressErrorMessages = False

            'lblVersion.Text = version_number
            'If DataPath Is Nothing Then
            '    btnContinue.Visible = True 'False 'temp
            '    DataPath = "c:\Halifax\Performance Data\" 'temp
            'Else
            '    DataPath = True
            'End If
            ''ReadUserDetails()
            'Me.Show()
            'objStreamWriterDebug.WriteLine("start")
            'Background_Color = Color.White
            CenterToScreen()
            If ChosenLanguage Is Nothing Then ChosenLanguage = "en-US"
            ApplyLocale(ChosenLanguage)

            ''If txtUsername.Text.ToLower.Contains("akm") Then
            ''    grpLanguage.Visible = True
            ''    optEnglish.Visible = True
            ''    optChinese.Visible = True
            ''    chkAdvancedUser.Visible = True
            ''End If
            'chkAdvancedUser.Checked = False
            'Dim screenWidth1 As Integer = Screen.PrimaryScreen.Bounds.Width
            'Dim screenHeight1 As Integer = Screen.PrimaryScreen.Bounds.Height

            'ApplyLocale("zh-CN")
            'Dim screenWidth2 As Integer = Screen.PrimaryScreen.Bounds.Width
            'Dim screenHeight2 As Integer = Screen.PrimaryScreen.Bounds.Height
            'Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 6, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)) ',                        FontStyle.Bold Or FontStyle.Italic)

            'MsgBox("1 - " + screenWidth1.ToString + "x" + screenHeight1.ToString + vbCrLf + "2 - " + screenWidth2.ToString + "x" + screenHeight2.ToString)

        Catch ex As Exception
            ErrorMessage(ex, 20500)
        End Try
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Try
            Flag(0) = True
            Hide()
            AdvancedUser = chkAdvancedUser.Checked
            Frmselectfan.ShowDialog()

        Catch ex As Exception
            ErrorMessage(ex, 20501)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Try
            End

        Catch ex As Exception
            ErrorMessage(ex, 20502)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            System.Diagnostics.Process.Start("http://www.halifax-fan.co.uk/")
        Catch ex As Exception
            'Code to handle the error.
            ErrorMessage(ex, 20503)
        End Try
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        Try
            Cursor = Cursors.Hand
        Catch ex As Exception
            ErrorMessage(ex, 20504)
        End Try
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        Try
            Cursor = Cursors.Default
        Catch ex As Exception
            ErrorMessage(ex, 20505)
        End Try
    End Sub

    Private Sub btnContinue_MouseHover(sender As Object, e As EventArgs) Handles btnContinue.MouseHover
        Try
            Cursor = Cursors.Hand
        Catch ex As Exception
            ErrorMessage(ex, 20506)
        End Try
    End Sub

    Private Sub btnExit_MouseHover(sender As Object, e As EventArgs) Handles btnExit.MouseHover
        Try
            Cursor = Cursors.Hand
        Catch ex As Exception
            ErrorMessage(ex, 20507)
        End Try
    End Sub

    Private Sub btnContinue_MouseLeave(sender As Object, e As EventArgs) Handles btnContinue.MouseLeave
        Try
            Cursor = Cursors.Default
        Catch ex As Exception
            ErrorMessage(ex, 20508)
        End Try
    End Sub

    Private Sub btnExit_MouseLeave(sender As Object, e As EventArgs) Handles btnExit.MouseLeave
        Try
            Cursor = Cursors.Default
        Catch ex As Exception
            ErrorMessage(ex, 20509)
        End Try
    End Sub

    Private Sub txtUsername_MouseHover(sender As Object, e As EventArgs) Handles txtUsername.MouseHover
        Try
            Cursor = Cursors.Hand
        Catch ex As Exception
            ErrorMessage(ex, 20510)
        End Try
    End Sub

    Private Sub txtUsername_MouseLeave(sender As Object, e As EventArgs) Handles txtUsername.MouseLeave
        Try
            Cursor = Cursors.Default
        Catch ex As Exception
            ErrorMessage(ex, 20511)
        End Try
    End Sub

    'Private Sub btnContinue_DoubleClick(sender As Object, e As EventArgs) Handles btnContinue.DoubleClick
    '    'FrmGeneralInfo.ShowDialog()
    'End Sub

    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Try
            FrmSettings.ShowDialog()
        Catch ex As Exception
            ErrorMessage(ex, 20512)
        End Try
    End Sub

    Private Sub optEnglish_CheckedChanged(sender As Object, e As EventArgs) Handles optEnglish.CheckedChanged
        Try
            If optEnglish.Checked Then
                ChosenLanguage = "en-US"
                ApplyLocale(ChosenLanguage)
            End If
        Catch ex As Exception
            ErrorMessage(ex, 20513)
        End Try
    End Sub

    Private Sub optChinese_CheckedChanged(sender As Object, e As EventArgs) Handles optChinese.CheckedChanged
        Try
            If optChinese.Checked Then
                ChosenLanguage = "zh-CN"
                ApplyLocale(ChosenLanguage)
            End If
        Catch ex As Exception
            ErrorMessage(ex, 20514)
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
            Dim resource_manager As New ResourceManager("Localized.FrmStart", Me.GetType.Assembly)
            'If txtUsername.Text.ToLower.Contains("akm") Then
            '    grpLanguage.Visible = True
            '    optEnglish.Visible = True
            '    optChinese.Visible = True
            '    chkAdvancedUser.Visible = True
            'End If
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
            ErrorMessage(ex, 20515)
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
            ErrorMessage(ex, 20516)
        End Try
    End Sub

    Private Sub FrmStart_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        Try
            MsgBox("Software developed by:" + vbCrLf + "Kerr Software Solutions Limited", vbOKOnly + vbInformation, "")

        Catch ex As Exception
            ErrorMessage(ex, 20517)
        End Try
    End Sub

    'Private Sub ApplyLocaleToToolStripItem(ByVal item As ToolStripItem, ByVal component_resource_manager As ComponentResourceManager, ByVal culture_info As CultureInfo)
    '    ' Debug.WriteLine(menu_item.Name)
    '    component_resource_manager.ApplyResources(item, item.Name, culture_info)

    '    ' Apply the new locale to items contained in it.
    '    If TypeOf item Is ToolStripMenuItem Then
    '        Dim menu_item As ToolStripMenuItem = DirectCast(item, ToolStripMenuItem)
    '        For Each child As ToolStripItem In menu_item.DropDownItems
    '            ApplyLocaleToToolStripItem(child, component_resource_manager, culture_info)
    '        Next child
    '    End If
    'End Sub
End Class