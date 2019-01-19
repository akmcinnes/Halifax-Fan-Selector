<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEnvironmentInfo
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
        Me.GrpFrequency = New System.Windows.Forms.GroupBox()
        Me.Opt50Hz = New System.Windows.Forms.RadioButton()
        Me.Opt60Hz = New System.Windows.Forms.RadioButton()
        Me.GrpEnvironment = New System.Windows.Forms.GroupBox()
        Me.LblAtmosphericPressureUnits = New System.Windows.Forms.Label()
        Me.LblHumidityUnits = New System.Windows.Forms.Label()
        Me.LblAltitudeUnits = New System.Windows.Forms.Label()
        Me.LblAmbientTemperatureUnits = New System.Windows.Forms.Label()
        Me.TxtAtmosphericPressure = New System.Windows.Forms.TextBox()
        Me.TxtHumidity = New System.Windows.Forms.TextBox()
        Me.TxtAltitude = New System.Windows.Forms.TextBox()
        Me.TxtAmbientTemperature = New System.Windows.Forms.TextBox()
        Me.LblAtmosphericPressure = New System.Windows.Forms.Label()
        Me.LblHumidity = New System.Windows.Forms.Label()
        Me.LblAltitude = New System.Windows.Forms.Label()
        Me.LblAmbientTemperature = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GrpFrequency.SuspendLayout()
        Me.GrpEnvironment.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpFrequency
        '
        Me.GrpFrequency.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GrpFrequency.Controls.Add(Me.Opt50Hz)
        Me.GrpFrequency.Controls.Add(Me.Opt60Hz)
        Me.GrpFrequency.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpFrequency.ForeColor = System.Drawing.Color.White
        Me.GrpFrequency.Location = New System.Drawing.Point(28, 219)
        Me.GrpFrequency.Name = "GrpFrequency"
        Me.GrpFrequency.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpFrequency.Size = New System.Drawing.Size(358, 57)
        Me.GrpFrequency.TabIndex = 13
        Me.GrpFrequency.TabStop = False
        Me.GrpFrequency.Text = "Frequency (Hz)"
        '
        'Opt50Hz
        '
        Me.Opt50Hz.AutoSize = True
        Me.Opt50Hz.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Opt50Hz.Checked = True
        Me.Opt50Hz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opt50Hz.ForeColor = System.Drawing.Color.White
        Me.Opt50Hz.Location = New System.Drawing.Point(12, 21)
        Me.Opt50Hz.Name = "Opt50Hz"
        Me.Opt50Hz.Size = New System.Drawing.Size(134, 22)
        Me.Opt50Hz.TabIndex = 5
        Me.Opt50Hz.TabStop = True
        Me.Opt50Hz.Text = "50 Hz (Nema)"
        Me.Opt50Hz.UseVisualStyleBackColor = False
        '
        'Opt60Hz
        '
        Me.Opt60Hz.AutoSize = True
        Me.Opt60Hz.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Opt60Hz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opt60Hz.ForeColor = System.Drawing.Color.White
        Me.Opt60Hz.Location = New System.Drawing.Point(213, 21)
        Me.Opt60Hz.Name = "Opt60Hz"
        Me.Opt60Hz.Size = New System.Drawing.Size(73, 22)
        Me.Opt60Hz.TabIndex = 4
        Me.Opt60Hz.Text = "60 Hz"
        Me.Opt60Hz.UseVisualStyleBackColor = False
        '
        'GrpEnvironment
        '
        Me.GrpEnvironment.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GrpEnvironment.Controls.Add(Me.LblAtmosphericPressureUnits)
        Me.GrpEnvironment.Controls.Add(Me.LblHumidityUnits)
        Me.GrpEnvironment.Controls.Add(Me.LblAltitudeUnits)
        Me.GrpEnvironment.Controls.Add(Me.LblAmbientTemperatureUnits)
        Me.GrpEnvironment.Controls.Add(Me.TxtAtmosphericPressure)
        Me.GrpEnvironment.Controls.Add(Me.TxtHumidity)
        Me.GrpEnvironment.Controls.Add(Me.TxtAltitude)
        Me.GrpEnvironment.Controls.Add(Me.TxtAmbientTemperature)
        Me.GrpEnvironment.Controls.Add(Me.LblAtmosphericPressure)
        Me.GrpEnvironment.Controls.Add(Me.LblHumidity)
        Me.GrpEnvironment.Controls.Add(Me.LblAltitude)
        Me.GrpEnvironment.Controls.Add(Me.LblAmbientTemperature)
        Me.GrpEnvironment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpEnvironment.ForeColor = System.Drawing.Color.White
        Me.GrpEnvironment.Location = New System.Drawing.Point(28, 41)
        Me.GrpEnvironment.Name = "GrpEnvironment"
        Me.GrpEnvironment.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpEnvironment.Size = New System.Drawing.Size(358, 155)
        Me.GrpEnvironment.TabIndex = 12
        Me.GrpEnvironment.TabStop = False
        Me.GrpEnvironment.Text = "Environment"
        '
        'LblAtmosphericPressureUnits
        '
        Me.LblAtmosphericPressureUnits.AutoSize = True
        Me.LblAtmosphericPressureUnits.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.LblAtmosphericPressureUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAtmosphericPressureUnits.ForeColor = System.Drawing.Color.White
        Me.LblAtmosphericPressureUnits.Location = New System.Drawing.Point(310, 112)
        Me.LblAtmosphericPressureUnits.Name = "LblAtmosphericPressureUnits"
        Me.LblAtmosphericPressureUnits.Size = New System.Drawing.Size(28, 18)
        Me.LblAtmosphericPressureUnits.TabIndex = 11
        Me.LblAtmosphericPressureUnits.Text = "Pa"
        Me.LblAtmosphericPressureUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblHumidityUnits
        '
        Me.LblHumidityUnits.AutoSize = True
        Me.LblHumidityUnits.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.LblHumidityUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHumidityUnits.ForeColor = System.Drawing.Color.White
        Me.LblHumidityUnits.Location = New System.Drawing.Point(310, 87)
        Me.LblHumidityUnits.Name = "LblHumidityUnits"
        Me.LblHumidityUnits.Size = New System.Drawing.Size(22, 18)
        Me.LblHumidityUnits.TabIndex = 10
        Me.LblHumidityUnits.Text = "%"
        Me.LblHumidityUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblAltitudeUnits
        '
        Me.LblAltitudeUnits.AutoSize = True
        Me.LblAltitudeUnits.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.LblAltitudeUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAltitudeUnits.ForeColor = System.Drawing.Color.White
        Me.LblAltitudeUnits.Location = New System.Drawing.Point(310, 58)
        Me.LblAltitudeUnits.Name = "LblAltitudeUnits"
        Me.LblAltitudeUnits.Size = New System.Drawing.Size(22, 18)
        Me.LblAltitudeUnits.TabIndex = 9
        Me.LblAltitudeUnits.Text = "m"
        Me.LblAltitudeUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblAmbientTemperatureUnits
        '
        Me.LblAmbientTemperatureUnits.AutoSize = True
        Me.LblAmbientTemperatureUnits.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.LblAmbientTemperatureUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAmbientTemperatureUnits.ForeColor = System.Drawing.Color.White
        Me.LblAmbientTemperatureUnits.Location = New System.Drawing.Point(310, 29)
        Me.LblAmbientTemperatureUnits.Name = "LblAmbientTemperatureUnits"
        Me.LblAmbientTemperatureUnits.Size = New System.Drawing.Size(27, 18)
        Me.LblAmbientTemperatureUnits.TabIndex = 8
        Me.LblAmbientTemperatureUnits.Text = "°C"
        Me.LblAmbientTemperatureUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtAtmosphericPressure
        '
        Me.TxtAtmosphericPressure.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TxtAtmosphericPressure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAtmosphericPressure.ForeColor = System.Drawing.Color.White
        Me.TxtAtmosphericPressure.Location = New System.Drawing.Point(213, 112)
        Me.TxtAtmosphericPressure.Name = "TxtAtmosphericPressure"
        Me.TxtAtmosphericPressure.Size = New System.Drawing.Size(83, 24)
        Me.TxtAtmosphericPressure.TabIndex = 7
        Me.TxtAtmosphericPressure.Text = "101325"
        '
        'TxtHumidity
        '
        Me.TxtHumidity.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TxtHumidity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHumidity.ForeColor = System.Drawing.Color.White
        Me.TxtHumidity.Location = New System.Drawing.Point(213, 84)
        Me.TxtHumidity.Name = "TxtHumidity"
        Me.TxtHumidity.Size = New System.Drawing.Size(83, 24)
        Me.TxtHumidity.TabIndex = 6
        Me.TxtHumidity.Text = "0"
        '
        'TxtAltitude
        '
        Me.TxtAltitude.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TxtAltitude.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAltitude.ForeColor = System.Drawing.Color.White
        Me.TxtAltitude.Location = New System.Drawing.Point(213, 56)
        Me.TxtAltitude.Name = "TxtAltitude"
        Me.TxtAltitude.Size = New System.Drawing.Size(83, 24)
        Me.TxtAltitude.TabIndex = 5
        Me.TxtAltitude.Text = "0"
        '
        'TxtAmbientTemperature
        '
        Me.TxtAmbientTemperature.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TxtAmbientTemperature.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAmbientTemperature.ForeColor = System.Drawing.Color.White
        Me.TxtAmbientTemperature.Location = New System.Drawing.Point(213, 28)
        Me.TxtAmbientTemperature.Name = "TxtAmbientTemperature"
        Me.TxtAmbientTemperature.Size = New System.Drawing.Size(83, 24)
        Me.TxtAmbientTemperature.TabIndex = 4
        Me.TxtAmbientTemperature.Text = "20"
        '
        'LblAtmosphericPressure
        '
        Me.LblAtmosphericPressure.AutoSize = True
        Me.LblAtmosphericPressure.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.LblAtmosphericPressure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAtmosphericPressure.ForeColor = System.Drawing.Color.White
        Me.LblAtmosphericPressure.Location = New System.Drawing.Point(17, 112)
        Me.LblAtmosphericPressure.Name = "LblAtmosphericPressure"
        Me.LblAtmosphericPressure.Size = New System.Drawing.Size(175, 18)
        Me.LblAtmosphericPressure.TabIndex = 3
        Me.LblAtmosphericPressure.Text = "Atmospheric Pressure"
        Me.LblAtmosphericPressure.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblHumidity
        '
        Me.LblHumidity.AutoSize = True
        Me.LblHumidity.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.LblHumidity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHumidity.ForeColor = System.Drawing.Color.White
        Me.LblHumidity.Location = New System.Drawing.Point(115, 84)
        Me.LblHumidity.Name = "LblHumidity"
        Me.LblHumidity.Size = New System.Drawing.Size(73, 18)
        Me.LblHumidity.TabIndex = 2
        Me.LblHumidity.Text = "Humidity"
        Me.LblHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblAltitude
        '
        Me.LblAltitude.AutoSize = True
        Me.LblAltitude.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.LblAltitude.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAltitude.ForeColor = System.Drawing.Color.White
        Me.LblAltitude.Location = New System.Drawing.Point(6, 58)
        Me.LblAltitude.Name = "LblAltitude"
        Me.LblAltitude.Size = New System.Drawing.Size(184, 18)
        Me.LblAltitude.TabIndex = 1
        Me.LblAltitude.Text = "Altitude above sea level"
        Me.LblAltitude.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblAmbientTemperature
        '
        Me.LblAmbientTemperature.AutoSize = True
        Me.LblAmbientTemperature.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.LblAmbientTemperature.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAmbientTemperature.ForeColor = System.Drawing.Color.White
        Me.LblAmbientTemperature.Location = New System.Drawing.Point(19, 29)
        Me.LblAmbientTemperature.Name = "LblAmbientTemperature"
        Me.LblAmbientTemperature.Size = New System.Drawing.Size(168, 18)
        Me.LblAmbientTemperature.TabIndex = 0
        Me.LblAmbientTemperature.Text = "Ambient Temperature"
        Me.LblAmbientTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(28, 335)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(328, 335)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Duty >>"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(181, 335)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'FrmEnvironmentInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(415, 370)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GrpFrequency)
        Me.Controls.Add(Me.GrpEnvironment)
        Me.Name = "FrmEnvironmentInfo"
        Me.Text = "FrmEnvironmentInfo"
        Me.GrpFrequency.ResumeLayout(False)
        Me.GrpFrequency.PerformLayout()
        Me.GrpEnvironment.ResumeLayout(False)
        Me.GrpEnvironment.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrpFrequency As GroupBox
    Friend WithEvents Opt50Hz As RadioButton
    Friend WithEvents Opt60Hz As RadioButton
    Friend WithEvents GrpEnvironment As GroupBox
    Friend WithEvents LblAtmosphericPressureUnits As Label
    Friend WithEvents LblHumidityUnits As Label
    Friend WithEvents LblAltitudeUnits As Label
    Friend WithEvents LblAmbientTemperatureUnits As Label
    Friend WithEvents TxtAtmosphericPressure As TextBox
    Friend WithEvents TxtHumidity As TextBox
    Friend WithEvents TxtAltitude As TextBox
    Friend WithEvents TxtAmbientTemperature As TextBox
    Friend WithEvents LblAtmosphericPressure As Label
    Friend WithEvents LblHumidity As Label
    Friend WithEvents LblAltitude As Label
    Friend WithEvents LblAmbientTemperature As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
