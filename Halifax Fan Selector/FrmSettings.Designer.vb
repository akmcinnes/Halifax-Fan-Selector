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
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optXian = New System.Windows.Forms.RadioButton()
        Me.optShenzhen = New System.Windows.Forms.RadioButton()
        Me.optShangai = New System.Windows.Forms.RadioButton()
        Me.optUK = New System.Windows.Forms.RadioButton()
        Me.grpLanguage.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        resources.ApplyResources(Me.grpLanguage, "grpLanguage")
        Me.grpLanguage.Controls.Add(Me.optChinese)
        Me.grpLanguage.Controls.Add(Me.optEnglish)
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
        'FolderBrowserDialog1
        '
        resources.ApplyResources(Me.FolderBrowserDialog1, "FolderBrowserDialog1")
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
        'txtEmail
        '
        resources.ApplyResources(Me.txtEmail, "txtEmail")
        Me.txtEmail.Name = "txtEmail"
        '
        'lblEmail
        '
        resources.ApplyResources(Me.lblEmail, "lblEmail")
        Me.lblEmail.Name = "lblEmail"
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.optXian)
        Me.GroupBox1.Controls.Add(Me.optShenzhen)
        Me.GroupBox1.Controls.Add(Me.optShangai)
        Me.GroupBox1.Controls.Add(Me.optUK)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'optXian
        '
        resources.ApplyResources(Me.optXian, "optXian")
        Me.optXian.Name = "optXian"
        Me.optXian.UseVisualStyleBackColor = True
        '
        'optShenzhen
        '
        resources.ApplyResources(Me.optShenzhen, "optShenzhen")
        Me.optShenzhen.Name = "optShenzhen"
        Me.optShenzhen.UseVisualStyleBackColor = True
        '
        'optShangai
        '
        resources.ApplyResources(Me.optShangai, "optShangai")
        Me.optShangai.Name = "optShangai"
        Me.optShangai.UseVisualStyleBackColor = True
        '
        'optUK
        '
        resources.ApplyResources(Me.optUK, "optUK")
        Me.optUK.Checked = True
        Me.optUK.Name = "optUK"
        Me.optUK.TabStop = True
        Me.optUK.UseVisualStyleBackColor = True
        '
        'FrmSettings
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.btnPageSetup)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDataFolder)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.grpLanguage)
        Me.Controls.Add(Me.chkAdvancedUser)
        Me.Controls.Add(Me.btnEnd)
        Me.Name = "FrmSettings"
        Me.grpLanguage.ResumeLayout(False)
        Me.grpLanguage.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ColorDialog1 As ColorDialog
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
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optXian As RadioButton
    Friend WithEvents optShenzhen As RadioButton
    Friend WithEvents optShangai As RadioButton
    Friend WithEvents optUK As RadioButton
End Class
