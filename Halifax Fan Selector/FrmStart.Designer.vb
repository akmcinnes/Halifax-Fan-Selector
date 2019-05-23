<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmStart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStart))
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblToThe = New System.Windows.Forms.Label()
        Me.lblHalifaxFanSelector = New System.Windows.Forms.Label()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.chkAdvancedUser = New System.Windows.Forms.CheckBox()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.grpLanguage = New System.Windows.Forms.GroupBox()
        Me.optChinese = New System.Windows.Forms.RadioButton()
        Me.optEnglish = New System.Windows.Forms.RadioButton()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblLanguageMessage = New System.Windows.Forms.Label()
        Me.grpLanguage.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        resources.ApplyResources(Me.lblWelcome, "lblWelcome")
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Name = "lblWelcome"
        '
        'lblToThe
        '
        resources.ApplyResources(Me.lblToThe, "lblToThe")
        Me.lblToThe.ForeColor = System.Drawing.Color.White
        Me.lblToThe.Name = "lblToThe"
        '
        'lblHalifaxFanSelector
        '
        resources.ApplyResources(Me.lblHalifaxFanSelector, "lblHalifaxFanSelector")
        Me.lblHalifaxFanSelector.ForeColor = System.Drawing.Color.White
        Me.lblHalifaxFanSelector.Name = "lblHalifaxFanSelector"
        '
        'btnContinue
        '
        resources.ApplyResources(Me.btnContinue, "btnContinue")
        Me.btnContinue.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnContinue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Name = "btnExit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        resources.ApplyResources(Me.lblUsername, "lblUsername")
        Me.lblUsername.Name = "lblUsername"
        '
        'txtUsername
        '
        resources.ApplyResources(Me.txtUsername, "txtUsername")
        Me.txtUsername.Name = "txtUsername"
        '
        'btnSettings
        '
        resources.ApplyResources(Me.btnSettings, "btnSettings")
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'chkAdvancedUser
        '
        resources.ApplyResources(Me.chkAdvancedUser, "chkAdvancedUser")
        Me.chkAdvancedUser.Checked = True
        Me.chkAdvancedUser.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAdvancedUser.Name = "chkAdvancedUser"
        Me.chkAdvancedUser.UseVisualStyleBackColor = True
        '
        'lblVersion
        '
        resources.ApplyResources(Me.lblVersion, "lblVersion")
        Me.lblVersion.Name = "lblVersion"
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
        Me.optEnglish.Name = "optEnglish"
        Me.optEnglish.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        resources.ApplyResources(Me.lblDate, "lblDate")
        Me.lblDate.Name = "lblDate"
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.PictureBox1.Image = Global.Halifax_Fan_Selector.My.Resources.Resources.logo_2016
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        resources.ApplyResources(Me.OpenFileDialog1, "OpenFileDialog1")
        '
        'lblLanguageMessage
        '
        resources.ApplyResources(Me.lblLanguageMessage, "lblLanguageMessage")
        Me.lblLanguageMessage.ForeColor = System.Drawing.Color.White
        Me.lblLanguageMessage.Name = "lblLanguageMessage"
        '
        'FrmStart
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ControlBox = False
        Me.Controls.Add(Me.lblLanguageMessage)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.grpLanguage)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.chkAdvancedUser)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblHalifaxFanSelector)
        Me.Controls.Add(Me.lblToThe)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnContinue)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmStart"
        Me.grpLanguage.ResumeLayout(False)
        Me.grpLanguage.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblToThe As Label
    Friend WithEvents lblHalifaxFanSelector As Label
    Friend WithEvents btnContinue As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnSettings As Button
    Friend WithEvents chkAdvancedUser As CheckBox
    Friend WithEvents lblVersion As Label
    Friend WithEvents grpLanguage As GroupBox
    Friend WithEvents optChinese As RadioButton
    Friend WithEvents optEnglish As RadioButton
    Friend WithEvents lblDate As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lblLanguageMessage As Label
    'Friend WithEvents lblDate As Label
    'Friend WithEvents Label1 As Label
End Class
