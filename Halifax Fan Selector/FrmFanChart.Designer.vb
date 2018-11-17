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
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFanChart))
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ChkStaticPressureCurve = New System.Windows.Forms.CheckBox()
        Me.ChkTotalPressureCurve = New System.Windows.Forms.CheckBox()
        Me.ChkFanPower = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.ChkFanSystemCurve = New System.Windows.Forms.CheckBox()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.SystemColors.MenuHighlight
        ChartArea4.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend4)
        Me.Chart1.Location = New System.Drawing.Point(12, 12)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Size = New System.Drawing.Size(975, 431)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(739, 449)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 50)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ChkStaticPressureCurve
        '
        Me.ChkStaticPressureCurve.AutoSize = True
        Me.ChkStaticPressureCurve.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ChkStaticPressureCurve.Checked = True
        Me.ChkStaticPressureCurve.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkStaticPressureCurve.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.ChkTotalPressureCurve.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.ChkFanPower.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkFanPower.ForeColor = System.Drawing.Color.White
        Me.ChkFanPower.Location = New System.Drawing.Point(789, 411)
        Me.ChkFanPower.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChkFanPower.Name = "ChkFanPower"
        Me.ChkFanPower.Size = New System.Drawing.Size(111, 22)
        Me.ChkFanPower.TabIndex = 4
        Me.ChkFanPower.Text = "Fan Power"
        Me.ChkFanPower.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(820, 449)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(167, 50)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Write points to file"
        Me.Button2.UseVisualStyleBackColor = False
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
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(16, 462)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 44)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Print Preview"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ChkFanSystemCurve
        '
        Me.ChkFanSystemCurve.AutoSize = True
        Me.ChkFanSystemCurve.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ChkFanSystemCurve.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkFanSystemCurve.ForeColor = System.Drawing.Color.White
        Me.ChkFanSystemCurve.Location = New System.Drawing.Point(789, 299)
        Me.ChkFanSystemCurve.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChkFanSystemCurve.Name = "ChkFanSystemCurve"
        Me.ChkFanSystemCurve.Size = New System.Drawing.Size(119, 22)
        Me.ChkFanSystemCurve.TabIndex = 7
        Me.ChkFanSystemCurve.Text = "Fan System"
        Me.ChkFanSystemCurve.UseVisualStyleBackColor = False
        '
        'FrmFanChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Halifax_Fan_Selector.My.Resources.Resources._0_faded1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1019, 521)
        Me.Controls.Add(Me.ChkFanSystemCurve)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ChkFanPower)
        Me.Controls.Add(Me.ChkTotalPressureCurve)
        Me.Controls.Add(Me.ChkStaticPressureCurve)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Chart1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmFanChart"
        Me.Text = "FanChart"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Button1 As Button
    Friend WithEvents ChkStaticPressureCurve As CheckBox
    Friend WithEvents ChkTotalPressureCurve As CheckBox
    Friend WithEvents ChkFanPower As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Button3 As Button
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents ChkFanSystemCurve As CheckBox
End Class
