<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNoiseoutofrange
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNoiseoutofrange))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAboveFlow = New System.Windows.Forms.Label()
        Me.lblAboveFSP = New System.Windows.Forms.Label()
        Me.lblAboveSpeed = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDuctCF = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'lblAboveFlow
        '
        resources.ApplyResources(Me.lblAboveFlow, "lblAboveFlow")
        Me.lblAboveFlow.Name = "lblAboveFlow"
        '
        'lblAboveFSP
        '
        resources.ApplyResources(Me.lblAboveFSP, "lblAboveFSP")
        Me.lblAboveFSP.Name = "lblAboveFSP"
        '
        'lblAboveSpeed
        '
        resources.ApplyResources(Me.lblAboveSpeed, "lblAboveSpeed")
        Me.lblAboveSpeed.Name = "lblAboveSpeed"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Name = "Label6"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'txtDuctCF
        '
        resources.ApplyResources(Me.txtDuctCF, "txtDuctCF")
        Me.txtDuctCF.Name = "txtDuctCF"
        '
        'btnCancel
        '
        resources.ApplyResources(Me.btnCancel, "btnCancel")
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnContinue
        '
        resources.ApplyResources(Me.btnContinue, "btnContinue")
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'FrmNoiseoutofrange
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtDuctCF)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblAboveSpeed)
        Me.Controls.Add(Me.lblAboveFSP)
        Me.Controls.Add(Me.lblAboveFlow)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmNoiseoutofrange"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblAboveFlow As Label
    Friend WithEvents lblAboveFSP As Label
    Friend WithEvents lblAboveSpeed As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDuctCF As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnContinue As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
