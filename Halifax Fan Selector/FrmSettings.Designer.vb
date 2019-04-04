<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSettings))
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.btnBackgroundColour = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.chkAdvancedUser = New System.Windows.Forms.CheckBox()
        Me.grpLanguage = New System.Windows.Forms.GroupBox()
        Me.optChinese = New System.Windows.Forms.RadioButton()
        Me.optEnglish = New System.Windows.Forms.RadioButton()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnDataFolder = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPageSetup = New System.Windows.Forms.Button()
        Me.SetupPage = New System.Windows.Forms.PageSetupDialog()
        Me.grpLanguage.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBackgroundColour
        '
        resources.ApplyResources(Me.btnBackgroundColour, "btnBackgroundColour")
        Me.btnBackgroundColour.Name = "btnBackgroundColour"
        Me.btnBackgroundColour.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        resources.ApplyResources(Me.btnEnd, "btnEnd")
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'chkAdvancedUser
        '
        resources.ApplyResources(Me.chkAdvancedUser, "chkAdvancedUser")
        Me.chkAdvancedUser.Name = "chkAdvancedUser"
        Me.chkAdvancedUser.UseVisualStyleBackColor = True
        '
        'grpLanguage
        '
        Me.grpLanguage.Controls.Add(Me.optChinese)
        Me.grpLanguage.Controls.Add(Me.optEnglish)
        resources.ApplyResources(Me.grpLanguage, "grpLanguage")
        Me.grpLanguage.Name = "grpLanguage"
        Me.grpLanguage.TabStop = False
        '
        'optChinese
        '
        resources.ApplyResources(Me.optChinese, "optChinese")
        Me.optChinese.Name = "optChinese"
        Me.optChinese.UseVisualStyleBackColor = True
        '
        'optEnglish
        '
        resources.ApplyResources(Me.optEnglish, "optEnglish")
        Me.optEnglish.Checked = True
        Me.optEnglish.Name = "optEnglish"
        Me.optEnglish.TabStop = True
        Me.optEnglish.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        resources.ApplyResources(Me.txtUsername, "txtUsername")
        Me.txtUsername.Name = "txtUsername"
        '
        'lblUsername
        '
        resources.ApplyResources(Me.lblUsername, "lblUsername")
        Me.lblUsername.Name = "lblUsername"
        '
        'btnDataFolder
        '
        resources.ApplyResources(Me.btnDataFolder, "btnDataFolder")
        Me.btnDataFolder.Name = "btnDataFolder"
        Me.btnDataFolder.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'btnPageSetup
        '
        resources.ApplyResources(Me.btnPageSetup, "btnPageSetup")
        Me.btnPageSetup.Name = "btnPageSetup"
        Me.btnPageSetup.UseVisualStyleBackColor = True
        '
        'FrmSettings
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Controls.Add(Me.btnPageSetup)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDataFolder)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.grpLanguage)
        Me.Controls.Add(Me.chkAdvancedUser)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnBackgroundColour)
        Me.Name = "FrmSettings"
        Me.grpLanguage.ResumeLayout(False)
        Me.grpLanguage.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents btnBackgroundColour As Button
    Friend WithEvents btnEnd As Button
    Friend WithEvents chkAdvancedUser As CheckBox
    Friend WithEvents grpLanguage As GroupBox
    Friend WithEvents optChinese As RadioButton
    Friend WithEvents optEnglish As RadioButton
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents btnDataFolder As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPageSetup As Button
    Friend WithEvents SetupPage As PageSetupDialog
End Class
