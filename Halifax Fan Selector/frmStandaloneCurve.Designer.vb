<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStandaloneCurve
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStandaloneCurve))
        Me.lblFanSize = New System.Windows.Forms.Label()
        Me.lblFanSpeed = New System.Windows.Forms.Label()
        Me.txtFanSize = New System.Windows.Forms.TextBox()
        Me.txtFanSpeed = New System.Windows.Forms.TextBox()
        Me.txtDensity = New System.Windows.Forms.TextBox()
        Me.lblDensity = New System.Windows.Forms.Label()
        Me.lstFanDesigns = New System.Windows.Forms.ListBox()
        Me.lblFanDesign = New System.Windows.Forms.Label()
        Me.txtFanDesign = New System.Windows.Forms.TextBox()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbLengthUnits = New System.Windows.Forms.ComboBox()
        Me.cmbPowerUnits = New System.Windows.Forms.ComboBox()
        Me.cmbDensityUnits = New System.Windows.Forms.ComboBox()
        Me.cmbPressureUnits = New System.Windows.Forms.ComboBox()
        Me.cmbFlowUnits = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSizeUnit = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblDensityUnit = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFanSize
        '
        resources.ApplyResources(Me.lblFanSize, "lblFanSize")
        Me.lblFanSize.Name = "lblFanSize"
        '
        'lblFanSpeed
        '
        resources.ApplyResources(Me.lblFanSpeed, "lblFanSpeed")
        Me.lblFanSpeed.Name = "lblFanSpeed"
        '
        'txtFanSize
        '
        resources.ApplyResources(Me.txtFanSize, "txtFanSize")
        Me.txtFanSize.Name = "txtFanSize"
        '
        'txtFanSpeed
        '
        resources.ApplyResources(Me.txtFanSpeed, "txtFanSpeed")
        Me.txtFanSpeed.Name = "txtFanSpeed"
        '
        'txtDensity
        '
        resources.ApplyResources(Me.txtDensity, "txtDensity")
        Me.txtDensity.Name = "txtDensity"
        '
        'lblDensity
        '
        resources.ApplyResources(Me.lblDensity, "lblDensity")
        Me.lblDensity.Name = "lblDensity"
        '
        'lstFanDesigns
        '
        Me.lstFanDesigns.FormattingEnabled = True
        resources.ApplyResources(Me.lstFanDesigns, "lstFanDesigns")
        Me.lstFanDesigns.Name = "lstFanDesigns"
        '
        'lblFanDesign
        '
        resources.ApplyResources(Me.lblFanDesign, "lblFanDesign")
        Me.lblFanDesign.Name = "lblFanDesign"
        '
        'txtFanDesign
        '
        resources.ApplyResources(Me.txtFanDesign, "txtFanDesign")
        Me.txtFanDesign.Name = "txtFanDesign"
        Me.txtFanDesign.ReadOnly = True
        '
        'btnContinue
        '
        resources.ApplyResources(Me.btnContinue, "btnContinue")
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        resources.ApplyResources(Me.btnCancel, "btnCancel")
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbLengthUnits)
        Me.GroupBox1.Controls.Add(Me.cmbPowerUnits)
        Me.GroupBox1.Controls.Add(Me.cmbDensityUnits)
        Me.GroupBox1.Controls.Add(Me.cmbPressureUnits)
        Me.GroupBox1.Controls.Add(Me.cmbFlowUnits)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'cmbLengthUnits
        '
        Me.cmbLengthUnits.FormattingEnabled = True
        Me.cmbLengthUnits.Items.AddRange(New Object() {resources.GetString("cmbLengthUnits.Items"), resources.GetString("cmbLengthUnits.Items1")})
        resources.ApplyResources(Me.cmbLengthUnits, "cmbLengthUnits")
        Me.cmbLengthUnits.Name = "cmbLengthUnits"
        '
        'cmbPowerUnits
        '
        Me.cmbPowerUnits.FormattingEnabled = True
        Me.cmbPowerUnits.Items.AddRange(New Object() {resources.GetString("cmbPowerUnits.Items"), resources.GetString("cmbPowerUnits.Items1")})
        resources.ApplyResources(Me.cmbPowerUnits, "cmbPowerUnits")
        Me.cmbPowerUnits.Name = "cmbPowerUnits"
        '
        'cmbDensityUnits
        '
        Me.cmbDensityUnits.FormattingEnabled = True
        Me.cmbDensityUnits.Items.AddRange(New Object() {resources.GetString("cmbDensityUnits.Items"), resources.GetString("cmbDensityUnits.Items1")})
        resources.ApplyResources(Me.cmbDensityUnits, "cmbDensityUnits")
        Me.cmbDensityUnits.Name = "cmbDensityUnits"
        '
        'cmbPressureUnits
        '
        Me.cmbPressureUnits.FormattingEnabled = True
        Me.cmbPressureUnits.Items.AddRange(New Object() {resources.GetString("cmbPressureUnits.Items"), resources.GetString("cmbPressureUnits.Items1"), resources.GetString("cmbPressureUnits.Items2"), resources.GetString("cmbPressureUnits.Items3"), resources.GetString("cmbPressureUnits.Items4")})
        resources.ApplyResources(Me.cmbPressureUnits, "cmbPressureUnits")
        Me.cmbPressureUnits.Name = "cmbPressureUnits"
        '
        'cmbFlowUnits
        '
        Me.cmbFlowUnits.FormattingEnabled = True
        Me.cmbFlowUnits.Items.AddRange(New Object() {resources.GetString("cmbFlowUnits.Items"), resources.GetString("cmbFlowUnits.Items1"), resources.GetString("cmbFlowUnits.Items2"), resources.GetString("cmbFlowUnits.Items3")})
        resources.ApplyResources(Me.cmbFlowUnits, "cmbFlowUnits")
        Me.cmbFlowUnits.Name = "cmbFlowUnits"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'lblSizeUnit
        '
        resources.ApplyResources(Me.lblSizeUnit, "lblSizeUnit")
        Me.lblSizeUnit.Name = "lblSizeUnit"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'lblDensityUnit
        '
        resources.ApplyResources(Me.lblDensityUnit, "lblDensityUnit")
        Me.lblDensityUnit.Name = "lblDensityUnit"
        '
        'frmStandaloneCurve
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblDensityUnit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblSizeUnit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.txtFanDesign)
        Me.Controls.Add(Me.lblFanDesign)
        Me.Controls.Add(Me.lstFanDesigns)
        Me.Controls.Add(Me.txtDensity)
        Me.Controls.Add(Me.lblDensity)
        Me.Controls.Add(Me.txtFanSpeed)
        Me.Controls.Add(Me.txtFanSize)
        Me.Controls.Add(Me.lblFanSpeed)
        Me.Controls.Add(Me.lblFanSize)
        Me.Name = "frmStandaloneCurve"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFanSize As Label
    Friend WithEvents lblFanSpeed As Label
    Friend WithEvents txtFanSize As TextBox
    Friend WithEvents txtFanSpeed As TextBox
    Friend WithEvents txtDensity As TextBox
    Friend WithEvents lblDensity As Label
    Friend WithEvents lstFanDesigns As ListBox
    Friend WithEvents lblFanDesign As Label
    Friend WithEvents txtFanDesign As TextBox
    Friend WithEvents btnContinue As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbLengthUnits As ComboBox
    Friend WithEvents cmbPowerUnits As ComboBox
    Friend WithEvents cmbDensityUnits As ComboBox
    Friend WithEvents cmbPressureUnits As ComboBox
    Friend WithEvents cmbFlowUnits As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSizeUnit As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblDensityUnit As Label
End Class
