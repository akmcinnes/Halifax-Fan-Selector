Imports System.Globalization
Imports System.ComponentModel
Imports System.Resources
Imports System.Threading
Public Class FrmStart
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Hide()
        AdvancedUser = chkAdvancedUser.Checked
        If chkByDialogs.Checked = False Then
            Frmselectfan.ShowDialog()
        Else
            FrmEnvironmentInfo.ShowDialog()
        End If
    End Sub

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblVersion.Text = version_number
        ''ReadUserDetails()
        'Me.Show()
        'objStreamWriterDebug.WriteLine("start")
        'Background_Color = Color.White
        CenterToScreen()
        txtUsername.Text = Environment.UserName
        'If ChosenLanguage Is Nothing Then ChosenLanguage = "en-US"
        'ApplyLocale(ChosenLanguage)
        UserName = Environment.UserName
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
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            System.Diagnostics.Process.Start("http://www.halifax-fan.co.uk/")
        Catch
            'Code to handle the error.
        End Try
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles btnContinue.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles btnExit.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles btnContinue.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles btnExit.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub TextBox1_MouseHover(sender As Object, e As EventArgs) Handles txtUsername.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub TextBox1_MouseLeave(sender As Object, e As EventArgs) Handles txtUsername.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub Button1_DoubleClick(sender As Object, e As EventArgs) Handles btnContinue.DoubleClick
        FrmEnvironmentInfo.ShowDialog()
    End Sub

    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        FrmSettings.ShowDialog()
    End Sub

    Private Sub optEnglish_CheckedChanged(sender As Object, e As EventArgs) Handles optEnglish.CheckedChanged
        'MsgBox("before")
        If optEnglish.Checked Then ApplyLocale("en-US")
        'Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 6, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)) ',                        FontStyle.Bold Or FontStyle.Italic)
        'Microsoft Sans Serif, 7.8p7

        'Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'MsgBox("after")
    End Sub

    Private Sub optChinese_CheckedChanged(sender As Object, e As EventArgs) Handles optChinese.CheckedChanged
        If optChinese.Checked Then ApplyLocale("zh-CN")
        'Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 6, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)) ',                        FontStyle.Bold Or FontStyle.Italic)
    End Sub


    Private Sub ApplyLocale(ByVal locale_name As String)
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

        '' ComboBox items.
        'ComboBox1.Items.Clear()
        'ComboBox1.Items.Add(resource_manager.GetString("ComboBox1.Items"))
        'ComboBox1.Items.Add(resource_manager.GetString("ComboBox1.Items1"))
        'ComboBox1.Items.Add(resource_manager.GetString("ComboBox1.Items2"))

        '' ListBox items.
        'ListBox1.Items.Clear()
        'ListBox1.Items.Add(resource_manager.GetString("ListBox1.Items"))
        'ListBox1.Items.Add(resource_manager.GetString("ListBox1.Items1"))
        'ListBox1.Items.Add(resource_manager.GetString("ListBox1.Items2"))
        'ListBox1.Items.Add(resource_manager.GetString("ListBox1.Items3"))

        '' ToolStripComboBox items.
        'ToolStripComboBox1.Items.Clear()
        'ToolStripComboBox1.Items.Add(resource_manager.GetString("ToolStripComboBox1.Items"))
        'ToolStripComboBox1.Items.Add(resource_manager.GetString("ToolStripComboBox1.Items1"))
        'ToolStripComboBox1.Items.Add(resource_manager.GetString("ToolStripComboBox1.Items2"))
    End Sub

    Private Sub ApplyLocaleToControl(ByVal ctl As Control, ByVal component_resource_manager As ComponentResourceManager, ByVal culture_info As CultureInfo)
        ' Debug.WriteLine(ctl.Name)
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