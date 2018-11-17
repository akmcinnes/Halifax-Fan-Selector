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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.chkAdvancedUser = New System.Windows.Forms.CheckBox()
        Me.grpLanguage = New System.Windows.Forms.GroupBox()
        Me.optChinese = New System.Windows.Forms.RadioButton()
        Me.optEnglish = New System.Windows.Forms.RadioButton()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.grpLanguage.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
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
        Me.optEnglish.Name = "optEnglish"
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
        'FrmSettings
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.grpLanguage)
        Me.Controls.Add(Me.chkAdvancedUser)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FrmSettings"
        Me.grpLanguage.ResumeLayout(False)
        Me.grpLanguage.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents chkAdvancedUser As CheckBox
    Friend WithEvents grpLanguage As GroupBox
    Friend WithEvents optChinese As RadioButton
    Friend WithEvents optEnglish As RadioButton
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUsername As Label
End Class
