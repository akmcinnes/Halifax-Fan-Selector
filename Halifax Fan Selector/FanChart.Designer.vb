<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FanChart
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
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ChkStaticPressureCurve = New System.Windows.Forms.CheckBox()
        Me.ChkTotalPressureCurve = New System.Windows.Forms.CheckBox()
        Me.ChkFanPower = New System.Windows.Forms.CheckBox()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(12, 12)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(975, 431)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(243, 462)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ChkStaticPressureCurve
        '
        Me.ChkStaticPressureCurve.AutoSize = True
        Me.ChkStaticPressureCurve.Checked = True
        Me.ChkStaticPressureCurve.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkStaticPressureCurve.Location = New System.Drawing.Point(841, 336)
        Me.ChkStaticPressureCurve.Name = "ChkStaticPressureCurve"
        Me.ChkStaticPressureCurve.Size = New System.Drawing.Size(126, 21)
        Me.ChkStaticPressureCurve.TabIndex = 2
        Me.ChkStaticPressureCurve.Text = "Static Pressure"
        Me.ChkStaticPressureCurve.UseVisualStyleBackColor = True
        '
        'ChkTotalPressureCurve
        '
        Me.ChkTotalPressureCurve.AutoSize = True
        Me.ChkTotalPressureCurve.Checked = True
        Me.ChkTotalPressureCurve.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkTotalPressureCurve.Location = New System.Drawing.Point(841, 372)
        Me.ChkTotalPressureCurve.Name = "ChkTotalPressureCurve"
        Me.ChkTotalPressureCurve.Size = New System.Drawing.Size(123, 21)
        Me.ChkTotalPressureCurve.TabIndex = 3
        Me.ChkTotalPressureCurve.Text = "Total Pressure"
        Me.ChkTotalPressureCurve.UseVisualStyleBackColor = True
        '
        'ChkFanPower
        '
        Me.ChkFanPower.AutoSize = True
        Me.ChkFanPower.Checked = True
        Me.ChkFanPower.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkFanPower.Location = New System.Drawing.Point(841, 411)
        Me.ChkFanPower.Name = "ChkFanPower"
        Me.ChkFanPower.Size = New System.Drawing.Size(97, 21)
        Me.ChkFanPower.TabIndex = 4
        Me.ChkFanPower.Text = "Fan Power"
        Me.ChkFanPower.UseVisualStyleBackColor = True
        '
        'FanChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 497)
        Me.Controls.Add(Me.ChkFanPower)
        Me.Controls.Add(Me.ChkTotalPressureCurve)
        Me.Controls.Add(Me.ChkStaticPressureCurve)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "FanChart"
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
End Class
