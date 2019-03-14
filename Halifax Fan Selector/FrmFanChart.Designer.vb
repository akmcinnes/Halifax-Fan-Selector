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
        Me.PrintPreviewDialog2 = New System.Windows.Forms.PrintPreviewDialog()
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
        Me.Chart1.Location = New System.Drawing.Point(12, 12)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Size = New System.Drawing.Size(975, 431)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(739, 449)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 50)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'ChkStaticPressureCurve
        '
        Me.ChkStaticPressureCurve.AutoSize = True
        Me.ChkStaticPressureCurve.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ChkStaticPressureCurve.Checked = True
        Me.ChkStaticPressureCurve.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkStaticPressureCurve.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ChkStaticPressureCurve.ForeColor = System.Drawing.Color.White
        Me.ChkStaticPressureCurve.Location = New System.Drawing.Point(789, 336)
        Me.ChkStaticPressureCurve.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChkStaticPressureCurve.Name = "ChkStaticPressureCurve"
        Me.ChkStaticPressureCurve.Size = New System.Drawing.Size(146, 22)
        Me.ChkStaticPressureCurve.TabIndex = 2
        Me.ChkStaticPressureCurve.Text = "Static Pressure"
        Me.ChkStaticPressureCurve.UseVisualStyleBackColor = False
        '
        'ChkTotalPressureCurve
        '
        Me.ChkTotalPressureCurve.AutoSize = True
        Me.ChkTotalPressureCurve.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ChkTotalPressureCurve.Checked = True
        Me.ChkTotalPressureCurve.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkTotalPressureCurve.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ChkTotalPressureCurve.ForeColor = System.Drawing.Color.White
        Me.ChkTotalPressureCurve.Location = New System.Drawing.Point(789, 372)
        Me.ChkTotalPressureCurve.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChkTotalPressureCurve.Name = "ChkTotalPressureCurve"
        Me.ChkTotalPressureCurve.Size = New System.Drawing.Size(141, 22)
        Me.ChkTotalPressureCurve.TabIndex = 3
        Me.ChkTotalPressureCurve.Text = "Total Pressure"
        Me.ChkTotalPressureCurve.UseVisualStyleBackColor = False
        '
        'ChkFanPower
        '
        Me.ChkFanPower.AutoSize = True
        Me.ChkFanPower.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ChkFanPower.Checked = True
        Me.ChkFanPower.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkFanPower.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ChkFanPower.ForeColor = System.Drawing.Color.White
        Me.ChkFanPower.Location = New System.Drawing.Point(789, 411)
        Me.ChkFanPower.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChkFanPower.Name = "ChkFanPower"
        Me.ChkFanPower.Size = New System.Drawing.Size(111, 22)
        Me.ChkFanPower.TabIndex = 4
        Me.ChkFanPower.Text = "Fan Power"
        Me.ChkFanPower.UseVisualStyleBackColor = False
        '
        'btnWritePointsToFile
        '
        Me.btnWritePointsToFile.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnWritePointsToFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnWritePointsToFile.ForeColor = System.Drawing.Color.White
        Me.btnWritePointsToFile.Location = New System.Drawing.Point(820, 449)
        Me.btnWritePointsToFile.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnWritePointsToFile.Name = "btnWritePointsToFile"
        Me.btnWritePointsToFile.Size = New System.Drawing.Size(167, 50)
        Me.btnWritePointsToFile.TabIndex = 5
        Me.btnWritePointsToFile.Text = "Write points to file"
        Me.btnWritePointsToFile.UseVisualStyleBackColor = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'btnPrintPreview
        '
        Me.btnPrintPreview.Location = New System.Drawing.Point(16, 462)
        Me.btnPrintPreview.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrintPreview.Name = "btnPrintPreview"
        Me.btnPrintPreview.Size = New System.Drawing.Size(100, 44)
        Me.btnPrintPreview.TabIndex = 6
        Me.btnPrintPreview.Text = "Print Preview"
        Me.btnPrintPreview.UseVisualStyleBackColor = True
        Me.btnPrintPreview.Visible = False
        '
        'ChkFanSystemCurve
        '
        Me.ChkFanSystemCurve.AutoSize = True
        Me.ChkFanSystemCurve.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ChkFanSystemCurve.Checked = True
        Me.ChkFanSystemCurve.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkFanSystemCurve.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ChkFanSystemCurve.ForeColor = System.Drawing.Color.White
        Me.ChkFanSystemCurve.Location = New System.Drawing.Point(789, 299)
        Me.ChkFanSystemCurve.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChkFanSystemCurve.Name = "ChkFanSystemCurve"
        Me.ChkFanSystemCurve.Size = New System.Drawing.Size(119, 22)
        Me.ChkFanSystemCurve.TabIndex = 7
        Me.ChkFanSystemCurve.Text = "Fan System"
        Me.ChkFanSystemCurve.UseVisualStyleBackColor = False
        '
        'btnPrintDocument
        '
        Me.btnPrintDocument.Location = New System.Drawing.Point(148, 462)
        Me.btnPrintDocument.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrintDocument.Name = "btnPrintDocument"
        Me.btnPrintDocument.Size = New System.Drawing.Size(100, 44)
        Me.btnPrintDocument.TabIndex = 8
        Me.btnPrintDocument.Text = "Print Document"
        Me.btnPrintDocument.UseVisualStyleBackColor = True
        Me.btnPrintDocument.Visible = False
        '
        'optDisplaykW
        '
        Me.optDisplaykW.AutoSize = True
        Me.optDisplaykW.BackColor = System.Drawing.SystemColors.Highlight
        Me.optDisplaykW.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.optDisplaykW.ForeColor = System.Drawing.Color.White
        Me.optDisplaykW.Location = New System.Drawing.Point(789, 236)
        Me.optDisplaykW.Margin = New System.Windows.Forms.Padding(4)
        Me.optDisplaykW.Name = "optDisplaykW"
        Me.optDisplaykW.Size = New System.Drawing.Size(109, 21)
        Me.optDisplaykW.TabIndex = 9
        Me.optDisplaykW.Text = "Display kW"
        Me.optDisplaykW.UseVisualStyleBackColor = False
        Me.optDisplaykW.Visible = False
        '
        'optDisplayhp
        '
        Me.optDisplayhp.AutoSize = True
        Me.optDisplayhp.BackColor = System.Drawing.SystemColors.Highlight
        Me.optDisplayhp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.optDisplayhp.ForeColor = System.Drawing.Color.White
        Me.optDisplayhp.Location = New System.Drawing.Point(789, 265)
        Me.optDisplayhp.Margin = New System.Windows.Forms.Padding(4)
        Me.optDisplayhp.Name = "optDisplayhp"
        Me.optDisplayhp.Size = New System.Drawing.Size(105, 21)
        Me.optDisplayhp.TabIndex = 10
        Me.optDisplayhp.TabStop = True
        Me.optDisplayhp.Text = "Display hp"
        Me.optDisplayhp.UseVisualStyleBackColor = False
        Me.optDisplayhp.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(283, 462)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 44)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "View as Excel Chart"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'lblVolumeHidden
        '
        Me.lblVolumeHidden.AutoSize = True
        Me.lblVolumeHidden.Location = New System.Drawing.Point(838, 90)
        Me.lblVolumeHidden.Name = "lblVolumeHidden"
        Me.lblVolumeHidden.Size = New System.Drawing.Size(66, 17)
        Me.lblVolumeHidden.TabIndex = 12
        Me.lblVolumeHidden.Text = "VOLUME"
        Me.lblVolumeHidden.Visible = False
        '
        'lblPressureHidden
        '
        Me.lblPressureHidden.AutoSize = True
        Me.lblPressureHidden.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPressureHidden.Location = New System.Drawing.Point(838, 116)
        Me.lblPressureHidden.Name = "lblPressureHidden"
        Me.lblPressureHidden.Size = New System.Drawing.Size(83, 17)
        Me.lblPressureHidden.TabIndex = 13
        Me.lblPressureHidden.Text = "PRESSURE"
        Me.lblPressureHidden.Visible = False
        '
        'lblPowerHidden
        '
        Me.lblPowerHidden.AutoSize = True
        Me.lblPowerHidden.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPowerHidden.Location = New System.Drawing.Point(838, 142)
        Me.lblPowerHidden.Name = "lblPowerHidden"
        Me.lblPowerHidden.Size = New System.Drawing.Size(60, 17)
        Me.lblPowerHidden.TabIndex = 14
        Me.lblPowerHidden.Text = "POWER"
        Me.lblPowerHidden.Visible = False
        '
        'lblTitleHidden
        '
        Me.lblTitleHidden.AutoSize = True
        Me.lblTitleHidden.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitleHidden.Location = New System.Drawing.Point(834, 180)
        Me.lblTitleHidden.Name = "lblTitleHidden"
        Me.lblTitleHidden.Size = New System.Drawing.Size(141, 17)
        Me.lblTitleHidden.TabIndex = 15
        Me.lblTitleHidden.Text = "Halifax Fan Company"
        Me.lblTitleHidden.Visible = False
        '
        'lblRunningAtHidden
        '
        Me.lblRunningAtHidden.AutoSize = True
        Me.lblRunningAtHidden.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRunningAtHidden.Location = New System.Drawing.Point(834, 215)
        Me.lblRunningAtHidden.Name = "lblRunningAtHidden"
        Me.lblRunningAtHidden.Size = New System.Drawing.Size(72, 17)
        Me.lblRunningAtHidden.TabIndex = 16
        Me.lblRunningAtHidden.Text = "running at"
        Me.lblRunningAtHidden.Visible = False
        '
        'PrintPreviewDialog2
        '
        Me.PrintPreviewDialog2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog2.Enabled = True
        Me.PrintPreviewDialog2.Icon = CType(resources.GetObject("PrintPreviewDialog2.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog2.Name = "PrintPreviewDialog2"
        Me.PrintPreviewDialog2.Visible = False
        '
        'FrmFanChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Halifax_Fan_Selector.My.Resources.Resources._0_faded1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1019, 521)
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
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmFanChart"
        Me.Text = "FanChart"
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
    Friend WithEvents PrintPreviewDialog2 As PrintPreviewDialog
End Class
