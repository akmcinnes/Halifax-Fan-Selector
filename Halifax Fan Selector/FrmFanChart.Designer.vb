<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFanChart
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFanChart))
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ChkStaticPressureCurve = New System.Windows.Forms.CheckBox()
        Me.ChkTotalPressureCurve = New System.Windows.Forms.CheckBox()
        Me.ChkFanPower = New System.Windows.Forms.CheckBox()
        Me.btnWritePointsToFile = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.btnPrintPreview = New System.Windows.Forms.Button()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.ChkFanSystemCurve = New System.Windows.Forms.CheckBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.btnPrintDocument = New System.Windows.Forms.Button()
        Me.optDisplaykW = New System.Windows.Forms.RadioButton()
        Me.optDisplayhp = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblVolumeHidden = New System.Windows.Forms.Label()
        Me.lblPressureHidden = New System.Windows.Forms.Label()
        Me.lblPowerHidden = New System.Windows.Forms.Label()
        Me.lblTitleHidden = New System.Windows.Forms.Label()
        Me.lblRunningAtHidden = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.SystemColors.MenuHighlight
        ChartArea1.AxisX.Title = "VOLUME"
        ChartArea1.AxisY.Title = "PRESSURE"
        ChartArea1.AxisY2.Title = "POWER"
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        resources.ApplyResources(Me.Chart1, "Chart1")
        Me.Chart1.Name = "Chart1"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.MenuHighlight
        resources.ApplyResources(Me.btnClose, "btnClose")
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Name = "btnClose"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'ChkStaticPressureCurve
        '
        resources.ApplyResources(Me.ChkStaticPressureCurve, "ChkStaticPressureCurve")
        Me.ChkStaticPressureCurve.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ChkStaticPressureCurve.Checked = True
        Me.ChkStaticPressureCurve.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkStaticPressureCurve.ForeColor = System.Drawing.Color.White
        Me.ChkStaticPressureCurve.Name = "ChkStaticPressureCurve"
        Me.ChkStaticPressureCurve.UseVisualStyleBackColor = False
        '
        'ChkTotalPressureCurve
        '
        resources.ApplyResources(Me.ChkTotalPressureCurve, "ChkTotalPressureCurve")
        Me.ChkTotalPressureCurve.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ChkTotalPressureCurve.Checked = True
        Me.ChkTotalPressureCurve.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkTotalPressureCurve.ForeColor = System.Drawing.Color.White
        Me.ChkTotalPressureCurve.Name = "ChkTotalPressureCurve"
        Me.ChkTotalPressureCurve.UseVisualStyleBackColor = False
        '
        'ChkFanPower
        '
        resources.ApplyResources(Me.ChkFanPower, "ChkFanPower")
        Me.ChkFanPower.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ChkFanPower.Checked = True
        Me.ChkFanPower.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkFanPower.ForeColor = System.Drawing.Color.White
        Me.ChkFanPower.Name = "ChkFanPower"
        Me.ChkFanPower.UseVisualStyleBackColor = False
        '
        'btnWritePointsToFile
        '
        Me.btnWritePointsToFile.BackColor = System.Drawing.SystemColors.MenuHighlight
        resources.ApplyResources(Me.btnWritePointsToFile, "btnWritePointsToFile")
        Me.btnWritePointsToFile.ForeColor = System.Drawing.Color.White
        Me.btnWritePointsToFile.Name = "btnWritePointsToFile"
        Me.btnWritePointsToFile.UseVisualStyleBackColor = False
        '
        'PrintPreviewDialog1
        '
        resources.ApplyResources(Me.PrintPreviewDialog1, "PrintPreviewDialog1")
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'btnPrintPreview
        '
        resources.ApplyResources(Me.btnPrintPreview, "btnPrintPreview")
        Me.btnPrintPreview.Name = "btnPrintPreview"
        Me.btnPrintPreview.UseVisualStyleBackColor = True
        '
        'ChkFanSystemCurve
        '
        resources.ApplyResources(Me.ChkFanSystemCurve, "ChkFanSystemCurve")
        Me.ChkFanSystemCurve.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ChkFanSystemCurve.Checked = True
        Me.ChkFanSystemCurve.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkFanSystemCurve.ForeColor = System.Drawing.Color.White
        Me.ChkFanSystemCurve.Name = "ChkFanSystemCurve"
        Me.ChkFanSystemCurve.UseVisualStyleBackColor = False
        '
        'btnPrintDocument
        '
        resources.ApplyResources(Me.btnPrintDocument, "btnPrintDocument")
        Me.btnPrintDocument.Name = "btnPrintDocument"
        Me.btnPrintDocument.UseVisualStyleBackColor = True
        '
        'optDisplaykW
        '
        resources.ApplyResources(Me.optDisplaykW, "optDisplaykW")
        Me.optDisplaykW.BackColor = System.Drawing.SystemColors.Highlight
        Me.optDisplaykW.ForeColor = System.Drawing.Color.White
        Me.optDisplaykW.Name = "optDisplaykW"
        Me.optDisplaykW.UseVisualStyleBackColor = False
        '
        'optDisplayhp
        '
        resources.ApplyResources(Me.optDisplayhp, "optDisplayhp")
        Me.optDisplayhp.BackColor = System.Drawing.SystemColors.Highlight
        Me.optDisplayhp.ForeColor = System.Drawing.Color.White
        Me.optDisplayhp.Name = "optDisplayhp"
        Me.optDisplayhp.TabStop = True
        Me.optDisplayhp.UseVisualStyleBackColor = False
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblVolumeHidden
        '
        resources.ApplyResources(Me.lblVolumeHidden, "lblVolumeHidden")
        Me.lblVolumeHidden.Name = "lblVolumeHidden"
        '
        'lblPressureHidden
        '
        resources.ApplyResources(Me.lblPressureHidden, "lblPressureHidden")
        Me.lblPressureHidden.Name = "lblPressureHidden"
        '
        'lblPowerHidden
        '
        resources.ApplyResources(Me.lblPowerHidden, "lblPowerHidden")
        Me.lblPowerHidden.Name = "lblPowerHidden"
        '
        'lblTitleHidden
        '
        resources.ApplyResources(Me.lblTitleHidden, "lblTitleHidden")
        Me.lblTitleHidden.Name = "lblTitleHidden"
        '
        'lblRunningAtHidden
        '
        resources.ApplyResources(Me.lblRunningAtHidden, "lblRunningAtHidden")
        Me.lblRunningAtHidden.Name = "lblRunningAtHidden"
        '
        'FrmFanChart
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Halifax_Fan_Selector.My.Resources.Resources._0_faded1
        Me.Controls.Add(Me.lblRunningAtHidden)
        Me.Controls.Add(Me.lblTitleHidden)
        Me.Controls.Add(Me.lblPowerHidden)
        Me.Controls.Add(Me.lblPressureHidden)
        Me.Controls.Add(Me.lblVolumeHidden)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.optDisplayhp)
        Me.Controls.Add(Me.optDisplaykW)
        Me.Controls.Add(Me.btnPrintDocument)
        Me.Controls.Add(Me.ChkFanSystemCurve)
        Me.Controls.Add(Me.btnPrintPreview)
        Me.Controls.Add(Me.btnWritePointsToFile)
        Me.Controls.Add(Me.ChkFanPower)
        Me.Controls.Add(Me.ChkTotalPressureCurve)
        Me.Controls.Add(Me.ChkStaticPressureCurve)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "FrmFanChart"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents btnClose As Button
    Friend WithEvents ChkStaticPressureCurve As CheckBox
    Friend WithEvents ChkTotalPressureCurve As CheckBox
    Friend WithEvents ChkFanPower As CheckBox
    Friend WithEvents btnWritePointsToFile As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents btnPrintPreview As Button
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents ChkFanSystemCurve As CheckBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents btnPrintDocument As Button
    Friend WithEvents optDisplaykW As RadioButton
    Friend WithEvents optDisplayhp As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents lblVolumeHidden As Label
    Friend WithEvents lblPressureHidden As Label
    Friend WithEvents lblPowerHidden As Label
    Friend WithEvents lblTitleHidden As Label
    Friend WithEvents lblRunningAtHidden As Label
End Class
