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
        Me.optOhio = New System.Windows.Forms.RadioButton()
        Me.optXian = New System.Windows.Forms.RadioButton()
        Me.optShenzhen = New System.Windows.Forms.RadioButton()
        Me.optShangai = New System.Windows.Forms.RadioButton()
        Me.optUK = New System.Windows.Forms.RadioButton()
        Me.lblUserCode = New System.Windows.Forms.Label()
        Me.lblAccessCode = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.GroupBox1.Controls.Add(Me.optOhio)
        Me.GroupBox1.Controls.Add(Me.optXian)
        Me.GroupBox1.Controls.Add(Me.optShenzhen)
        Me.GroupBox1.Controls.Add(Me.optShangai)
        Me.GroupBox1.Controls.Add(Me.optUK)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'optOhio
        '
        resources.ApplyResources(Me.optOhio, "optOhio")
        Me.optOhio.Name = "optOhio"
        Me.optOhio.UseVisualStyleBackColor = True
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
        'lblUserCode
        '
        resources.ApplyResources(Me.lblUserCode, "lblUserCode")
        Me.lblUserCode.ForeColor = System.Drawing.Color.White
        Me.lblUserCode.Name = "lblUserCode"
        '
        'lblAccessCode
        '
        resources.ApplyResources(Me.lblAccessCode, "lblAccessCode")
        Me.lblAccessCode.ForeColor = System.Drawing.Color.White
        Me.lblAccessCode.Name = "lblAccessCode"
        '
        'lblCode
        '
        resources.ApplyResources(Me.lblCode, "lblCode")
        Me.lblCode.ForeColor = System.Drawing.Color.White
        Me.lblCode.Name = "lblCode"
        '
        'txtCode
        '
        resources.ApplyResources(Me.txtCode, "txtCode")
        Me.txtCode.Name = "txtCode"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Name = "Label2"
        Me.Label2.Tag = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'FrmSettings
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.lblAccessCode)
        Me.Controls.Add(Me.lblUserCode)
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
    Friend WithEvents lblUserCode As Label
    Friend WithEvents lblAccessCode As Label
    Friend WithEvents lblCode As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents optOhio As RadioButton
End Class
