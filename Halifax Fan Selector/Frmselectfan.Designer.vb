<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmselectfan
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageDuty = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GrpFrequency = New System.Windows.Forms.GroupBox()
        Me.Opt50Hz = New System.Windows.Forms.RadioButton()
        Me.Opt60Hz = New System.Windows.Forms.RadioButton()
        Me.GrpFanSize = New System.Windows.Forms.GroupBox()
        Me.LblLengthUnits = New System.Windows.Forms.Label()
        Me.Txtfansize = New System.Windows.Forms.TextBox()
        Me.Lblfansize = New System.Windows.Forms.Label()
        Me.OptAnySize = New System.Windows.Forms.RadioButton()
        Me.OptFixedSize = New System.Windows.Forms.RadioButton()
        Me.GrpFanSpeed = New System.Windows.Forms.GroupBox()
        Me.Txtfanspeed = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtspeedlimit = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.OptFixedSpeed = New System.Windows.Forms.RadioButton()
        Me.OptAnySpeed = New System.Windows.Forms.RadioButton()
        Me.OptPoleSpeed = New System.Windows.Forms.RadioButton()
        Me.GrpFanTypes = New System.Windows.Forms.GroupBox()
        Me.ChkOldDesignFans = New System.Windows.Forms.CheckBox()
        Me.ChkAxialFans = New System.Windows.Forms.CheckBox()
        Me.ChkPlenumFans = New System.Windows.Forms.CheckBox()
        Me.ChkPlasticFan = New System.Windows.Forms.CheckBox()
        Me.ChkOtherFanType = New System.Windows.Forms.CheckBox()
        Me.ChkInclineBlade = New System.Windows.Forms.CheckBox()
        Me.ChkCurveBlade = New System.Windows.Forms.CheckBox()
        Me.GrpDesignPressure = New System.Windows.Forms.GroupBox()
        Me.Optsucy = New System.Windows.Forms.CheckBox()
        Me.CmbReserveHead = New System.Windows.Forms.ComboBox()
        Me.Txtfsp = New System.Windows.Forms.TextBox()
        Me.TxtDischargePressure = New System.Windows.Forms.TextBox()
        Me.TxtInletPressure = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.OptStaticPressure = New System.Windows.Forms.RadioButton()
        Me.OptTotalPressure = New System.Windows.Forms.RadioButton()
        Me.GrpFlowRate = New System.Windows.Forms.GroupBox()
        Me.LblFlowRateUnits = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OptFlowDischarge = New System.Windows.Forms.RadioButton()
        Me.OptFlowNominal = New System.Windows.Forms.RadioButton()
        Me.OpFlowInlet = New System.Windows.Forms.RadioButton()
        Me.Txtflow = New System.Windows.Forms.TextBox()
        Me.OptMassFlow = New System.Windows.Forms.RadioButton()
        Me.OptVolumeFlow = New System.Windows.Forms.RadioButton()
        Me.GrpInletDensity = New System.Windows.Forms.GroupBox()
        Me.OptDensityCalculated = New System.Windows.Forms.RadioButton()
        Me.OptDensityKnown = New System.Windows.Forms.RadioButton()
        Me.Txtdens = New System.Windows.Forms.TextBox()
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GrpInletTemperature = New System.Windows.Forms.GroupBox()
        Me.TxtMaximumTemperature = New System.Windows.Forms.TextBox()
        Me.LblMaximumTemperature = New System.Windows.Forms.Label()
        Me.LblDesignTemperature = New System.Windows.Forms.Label()
        Me.TxtDesignTemperature = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPageSelection = New System.Windows.Forms.TabPage()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LblGasDensityUnit = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDensity = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPageNoise = New System.Windows.Forms.TabPage()
        Me.TabPageImpeller = New System.Windows.Forms.TabPage()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnitsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OptTXT = New System.Windows.Forms.RadioButton()
        Me.OptXLS = New System.Windows.Forms.RadioButton()
        Me.TabControl1.SuspendLayout()
        Me.TabPageDuty.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GrpFrequency.SuspendLayout()
        Me.GrpFanSize.SuspendLayout()
        Me.GrpFanSpeed.SuspendLayout()
        Me.GrpFanTypes.SuspendLayout()
        Me.GrpDesignPressure.SuspendLayout()
        Me.GrpFlowRate.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GrpInletDensity.SuspendLayout()
        Me.GrpEnvironment.SuspendLayout()
        Me.GrpInletTemperature.SuspendLayout()
        Me.TabPageSelection.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageDuty)
        Me.TabControl1.Controls.Add(Me.TabPageSelection)
        Me.TabControl1.Controls.Add(Me.TabPageNoise)
        Me.TabControl1.Controls.Add(Me.TabPageImpeller)
        Me.TabControl1.Location = New System.Drawing.Point(-4, 37)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1223, 616)
        Me.TabControl1.TabIndex = 0
        '
        'TabPageDuty
        '
        Me.TabPageDuty.BackgroundImage = Global.Halifax_Fan_Selector.My.Resources.Resources.image1
        Me.TabPageDuty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPageDuty.Controls.Add(Me.GroupBox2)
        Me.TabPageDuty.Controls.Add(Me.GroupBox1)
        Me.TabPageDuty.Controls.Add(Me.GrpFrequency)
        Me.TabPageDuty.Controls.Add(Me.GrpFanSize)
        Me.TabPageDuty.Controls.Add(Me.GrpFanSpeed)
        Me.TabPageDuty.Controls.Add(Me.GrpFanTypes)
        Me.TabPageDuty.Controls.Add(Me.GrpDesignPressure)
        Me.TabPageDuty.Controls.Add(Me.GrpFlowRate)
        Me.TabPageDuty.Controls.Add(Me.GrpInletDensity)
        Me.TabPageDuty.Controls.Add(Me.GrpEnvironment)
        Me.TabPageDuty.Controls.Add(Me.Button2)
        Me.TabPageDuty.Controls.Add(Me.GrpInletTemperature)
        Me.TabPageDuty.Controls.Add(Me.Button1)
        Me.TabPageDuty.Location = New System.Drawing.Point(4, 25)
        Me.TabPageDuty.Name = "TabPageDuty"
        Me.TabPageDuty.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDuty.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabPageDuty.Size = New System.Drawing.Size(1215, 587)
        Me.TabPageDuty.TabIndex = 2
        Me.TabPageDuty.Text = "Duty"
        Me.TabPageDuty.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Location = New System.Drawing.Point(746, 376)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(228, 57)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Discharge Duct"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(12, 21)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(53, 21)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Any"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(116, 21)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(62, 21)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.Text = "Fixed"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'GrpFrequency
        '
        Me.GrpFrequency.BackColor = System.Drawing.Color.Maroon
        Me.GrpFrequency.Controls.Add(Me.Opt50Hz)
        Me.GrpFrequency.Controls.Add(Me.Opt60Hz)
        Me.GrpFrequency.ForeColor = System.Drawing.SystemColors.Window
        Me.GrpFrequency.Location = New System.Drawing.Point(746, 181)
        Me.GrpFrequency.Name = "GrpFrequency"
        Me.GrpFrequency.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpFrequency.Size = New System.Drawing.Size(228, 57)
        Me.GrpFrequency.TabIndex = 10
        Me.GrpFrequency.TabStop = False
        Me.GrpFrequency.Text = "Frequency (Hz)"
        '
        'Opt50Hz
        '
        Me.Opt50Hz.AutoSize = True
        Me.Opt50Hz.Checked = True
        Me.Opt50Hz.Location = New System.Drawing.Point(12, 21)
        Me.Opt50Hz.Name = "Opt50Hz"
        Me.Opt50Hz.Size = New System.Drawing.Size(92, 21)
        Me.Opt50Hz.TabIndex = 5
        Me.Opt50Hz.TabStop = True
        Me.Opt50Hz.Text = "50(Nema)"
        Me.Opt50Hz.UseVisualStyleBackColor = True
        '
        'Opt60Hz
        '
        Me.Opt60Hz.AutoSize = True
        Me.Opt60Hz.Location = New System.Drawing.Point(116, 21)
        Me.Opt60Hz.Name = "Opt60Hz"
        Me.Opt60Hz.Size = New System.Drawing.Size(45, 21)
        Me.Opt60Hz.TabIndex = 4
        Me.Opt60Hz.Text = "60"
        Me.Opt60Hz.UseVisualStyleBackColor = True
        '
        'GrpFanSize
        '
        Me.GrpFanSize.BackColor = System.Drawing.Color.Maroon
        Me.GrpFanSize.Controls.Add(Me.LblLengthUnits)
        Me.GrpFanSize.Controls.Add(Me.Txtfansize)
        Me.GrpFanSize.Controls.Add(Me.Lblfansize)
        Me.GrpFanSize.Controls.Add(Me.OptAnySize)
        Me.GrpFanSize.Controls.Add(Me.OptFixedSize)
        Me.GrpFanSize.ForeColor = System.Drawing.SystemColors.Window
        Me.GrpFanSize.Location = New System.Drawing.Point(746, 255)
        Me.GrpFanSize.Name = "GrpFanSize"
        Me.GrpFanSize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpFanSize.Size = New System.Drawing.Size(228, 105)
        Me.GrpFanSize.TabIndex = 9
        Me.GrpFanSize.TabStop = False
        Me.GrpFanSize.Text = "Fan Size"
        '
        'LblLengthUnits
        '
        Me.LblLengthUnits.AutoSize = True
        Me.LblLengthUnits.Location = New System.Drawing.Point(179, 73)
        Me.LblLengthUnits.Name = "LblLengthUnits"
        Me.LblLengthUnits.Size = New System.Drawing.Size(30, 17)
        Me.LblLengthUnits.TabIndex = 8
        Me.LblLengthUnits.Text = "mm"
        '
        'Txtfansize
        '
        Me.Txtfansize.Location = New System.Drawing.Point(118, 69)
        Me.Txtfansize.Name = "Txtfansize"
        Me.Txtfansize.Size = New System.Drawing.Size(55, 22)
        Me.Txtfansize.TabIndex = 7
        '
        'Lblfansize
        '
        Me.Lblfansize.AutoSize = True
        Me.Lblfansize.Location = New System.Drawing.Point(18, 74)
        Me.Lblfansize.Name = "Lblfansize"
        Me.Lblfansize.Size = New System.Drawing.Size(63, 17)
        Me.Lblfansize.TabIndex = 6
        Me.Lblfansize.Text = "Fan Size"
        '
        'OptAnySize
        '
        Me.OptAnySize.AutoSize = True
        Me.OptAnySize.Checked = True
        Me.OptAnySize.Location = New System.Drawing.Point(12, 21)
        Me.OptAnySize.Name = "OptAnySize"
        Me.OptAnySize.Size = New System.Drawing.Size(84, 21)
        Me.OptAnySize.TabIndex = 5
        Me.OptAnySize.TabStop = True
        Me.OptAnySize.Text = "Any Size"
        Me.OptAnySize.UseVisualStyleBackColor = True
        '
        'OptFixedSize
        '
        Me.OptFixedSize.AutoSize = True
        Me.OptFixedSize.Location = New System.Drawing.Point(116, 21)
        Me.OptFixedSize.Name = "OptFixedSize"
        Me.OptFixedSize.Size = New System.Drawing.Size(93, 21)
        Me.OptFixedSize.TabIndex = 4
        Me.OptFixedSize.Text = "Fixed Size"
        Me.OptFixedSize.UseVisualStyleBackColor = True
        '
        'GrpFanSpeed
        '
        Me.GrpFanSpeed.BackColor = System.Drawing.Color.Maroon
        Me.GrpFanSpeed.Controls.Add(Me.Txtfanspeed)
        Me.GrpFanSpeed.Controls.Add(Me.Label1)
        Me.GrpFanSpeed.Controls.Add(Me.Txtspeedlimit)
        Me.GrpFanSpeed.Controls.Add(Me.Label11)
        Me.GrpFanSpeed.Controls.Add(Me.OptFixedSpeed)
        Me.GrpFanSpeed.Controls.Add(Me.OptAnySpeed)
        Me.GrpFanSpeed.Controls.Add(Me.OptPoleSpeed)
        Me.GrpFanSpeed.ForeColor = System.Drawing.SystemColors.Window
        Me.GrpFanSpeed.Location = New System.Drawing.Point(742, 17)
        Me.GrpFanSpeed.Name = "GrpFanSpeed"
        Me.GrpFanSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpFanSpeed.Size = New System.Drawing.Size(232, 155)
        Me.GrpFanSpeed.TabIndex = 8
        Me.GrpFanSpeed.TabStop = False
        Me.GrpFanSpeed.Text = "Fan Speed"
        '
        'Txtfanspeed
        '
        Me.Txtfanspeed.Location = New System.Drawing.Point(150, 119)
        Me.Txtfanspeed.Name = "Txtfanspeed"
        Me.Txtfanspeed.Size = New System.Drawing.Size(55, 22)
        Me.Txtfanspeed.TabIndex = 10
        Me.Txtfanspeed.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Fan Speed (RPM)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txtspeedlimit
        '
        Me.Txtspeedlimit.Location = New System.Drawing.Point(150, 86)
        Me.Txtspeedlimit.Name = "Txtspeedlimit"
        Me.Txtspeedlimit.Size = New System.Drawing.Size(55, 22)
        Me.Txtspeedlimit.TabIndex = 8
        Me.Txtspeedlimit.Text = "4000"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 17)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Max Speed (RPM)"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OptFixedSpeed
        '
        Me.OptFixedSpeed.AutoSize = True
        Me.OptFixedSpeed.Location = New System.Drawing.Point(12, 58)
        Me.OptFixedSpeed.Name = "OptFixedSpeed"
        Me.OptFixedSpeed.Size = New System.Drawing.Size(107, 21)
        Me.OptFixedSpeed.TabIndex = 6
        Me.OptFixedSpeed.Text = "Fixed Speed"
        Me.OptFixedSpeed.UseVisualStyleBackColor = True
        '
        'OptAnySpeed
        '
        Me.OptAnySpeed.AutoSize = True
        Me.OptAnySpeed.Checked = True
        Me.OptAnySpeed.Location = New System.Drawing.Point(12, 32)
        Me.OptAnySpeed.Name = "OptAnySpeed"
        Me.OptAnySpeed.Size = New System.Drawing.Size(98, 21)
        Me.OptAnySpeed.TabIndex = 5
        Me.OptAnySpeed.TabStop = True
        Me.OptAnySpeed.Text = "Any Speed"
        Me.OptAnySpeed.UseVisualStyleBackColor = True
        '
        'OptPoleSpeed
        '
        Me.OptPoleSpeed.AutoSize = True
        Me.OptPoleSpeed.Location = New System.Drawing.Point(116, 32)
        Me.OptPoleSpeed.Name = "OptPoleSpeed"
        Me.OptPoleSpeed.Size = New System.Drawing.Size(102, 21)
        Me.OptPoleSpeed.TabIndex = 4
        Me.OptPoleSpeed.Text = "Pole Speed"
        Me.OptPoleSpeed.UseVisualStyleBackColor = True
        '
        'GrpFanTypes
        '
        Me.GrpFanTypes.BackColor = System.Drawing.Color.Maroon
        Me.GrpFanTypes.Controls.Add(Me.ChkOldDesignFans)
        Me.GrpFanTypes.Controls.Add(Me.ChkAxialFans)
        Me.GrpFanTypes.Controls.Add(Me.ChkPlenumFans)
        Me.GrpFanTypes.Controls.Add(Me.ChkPlasticFan)
        Me.GrpFanTypes.Controls.Add(Me.ChkOtherFanType)
        Me.GrpFanTypes.Controls.Add(Me.ChkInclineBlade)
        Me.GrpFanTypes.Controls.Add(Me.ChkCurveBlade)
        Me.GrpFanTypes.ForeColor = System.Drawing.SystemColors.Window
        Me.GrpFanTypes.Location = New System.Drawing.Point(993, 17)
        Me.GrpFanTypes.Name = "GrpFanTypes"
        Me.GrpFanTypes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpFanTypes.Size = New System.Drawing.Size(200, 227)
        Me.GrpFanTypes.TabIndex = 7
        Me.GrpFanTypes.TabStop = False
        Me.GrpFanTypes.Text = "Fan Types"
        '
        'ChkOldDesignFans
        '
        Me.ChkOldDesignFans.AutoSize = True
        Me.ChkOldDesignFans.Location = New System.Drawing.Point(22, 188)
        Me.ChkOldDesignFans.Name = "ChkOldDesignFans"
        Me.ChkOldDesignFans.Size = New System.Drawing.Size(100, 21)
        Me.ChkOldDesignFans.TabIndex = 6
        Me.ChkOldDesignFans.Text = "Old Design"
        Me.ChkOldDesignFans.UseVisualStyleBackColor = True
        '
        'ChkAxialFans
        '
        Me.ChkAxialFans.AutoSize = True
        Me.ChkAxialFans.Location = New System.Drawing.Point(22, 161)
        Me.ChkAxialFans.Name = "ChkAxialFans"
        Me.ChkAxialFans.Size = New System.Drawing.Size(59, 21)
        Me.ChkAxialFans.TabIndex = 5
        Me.ChkAxialFans.Text = "Axial"
        Me.ChkAxialFans.UseVisualStyleBackColor = True
        '
        'ChkPlenumFans
        '
        Me.ChkPlenumFans.AutoSize = True
        Me.ChkPlenumFans.Location = New System.Drawing.Point(22, 134)
        Me.ChkPlenumFans.Name = "ChkPlenumFans"
        Me.ChkPlenumFans.Size = New System.Drawing.Size(112, 21)
        Me.ChkPlenumFans.TabIndex = 4
        Me.ChkPlenumFans.Text = "Plenum Fans"
        Me.ChkPlenumFans.UseVisualStyleBackColor = True
        '
        'ChkPlasticFan
        '
        Me.ChkPlasticFan.AutoSize = True
        Me.ChkPlasticFan.Location = New System.Drawing.Point(22, 109)
        Me.ChkPlasticFan.Name = "ChkPlasticFan"
        Me.ChkPlasticFan.Size = New System.Drawing.Size(71, 21)
        Me.ChkPlasticFan.TabIndex = 3
        Me.ChkPlasticFan.Text = "Plastic"
        Me.ChkPlasticFan.UseVisualStyleBackColor = True
        '
        'ChkOtherFanType
        '
        Me.ChkOtherFanType.AutoSize = True
        Me.ChkOtherFanType.Location = New System.Drawing.Point(22, 82)
        Me.ChkOtherFanType.Name = "ChkOtherFanType"
        Me.ChkOtherFanType.Size = New System.Drawing.Size(66, 21)
        Me.ChkOtherFanType.TabIndex = 2
        Me.ChkOtherFanType.Text = "Other"
        Me.ChkOtherFanType.UseVisualStyleBackColor = True
        '
        'ChkInclineBlade
        '
        Me.ChkInclineBlade.AutoSize = True
        Me.ChkInclineBlade.Checked = True
        Me.ChkInclineBlade.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkInclineBlade.Location = New System.Drawing.Point(22, 55)
        Me.ChkInclineBlade.Name = "ChkInclineBlade"
        Me.ChkInclineBlade.Size = New System.Drawing.Size(110, 21)
        Me.ChkInclineBlade.TabIndex = 1
        Me.ChkInclineBlade.Text = "Incline Blade"
        Me.ChkInclineBlade.UseVisualStyleBackColor = True
        '
        'ChkCurveBlade
        '
        Me.ChkCurveBlade.AutoSize = True
        Me.ChkCurveBlade.Checked = True
        Me.ChkCurveBlade.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkCurveBlade.Location = New System.Drawing.Point(22, 28)
        Me.ChkCurveBlade.Name = "ChkCurveBlade"
        Me.ChkCurveBlade.Size = New System.Drawing.Size(107, 21)
        Me.ChkCurveBlade.TabIndex = 0
        Me.ChkCurveBlade.Text = "Curve Blade"
        Me.ChkCurveBlade.UseVisualStyleBackColor = True
        '
        'GrpDesignPressure
        '
        Me.GrpDesignPressure.BackColor = System.Drawing.Color.Maroon
        Me.GrpDesignPressure.Controls.Add(Me.Optsucy)
        Me.GrpDesignPressure.Controls.Add(Me.CmbReserveHead)
        Me.GrpDesignPressure.Controls.Add(Me.Txtfsp)
        Me.GrpDesignPressure.Controls.Add(Me.TxtDischargePressure)
        Me.GrpDesignPressure.Controls.Add(Me.TxtInletPressure)
        Me.GrpDesignPressure.Controls.Add(Me.Label7)
        Me.GrpDesignPressure.Controls.Add(Me.Label8)
        Me.GrpDesignPressure.Controls.Add(Me.Label9)
        Me.GrpDesignPressure.Controls.Add(Me.Label10)
        Me.GrpDesignPressure.Controls.Add(Me.OptStaticPressure)
        Me.GrpDesignPressure.Controls.Add(Me.OptTotalPressure)
        Me.GrpDesignPressure.ForeColor = System.Drawing.SystemColors.Window
        Me.GrpDesignPressure.Location = New System.Drawing.Point(536, 17)
        Me.GrpDesignPressure.Name = "GrpDesignPressure"
        Me.GrpDesignPressure.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpDesignPressure.Size = New System.Drawing.Size(200, 223)
        Me.GrpDesignPressure.TabIndex = 6
        Me.GrpDesignPressure.TabStop = False
        Me.GrpDesignPressure.Text = "Design Pressure (Pa)"
        '
        'Optsucy
        '
        Me.Optsucy.AutoSize = True
        Me.Optsucy.Location = New System.Drawing.Point(22, 185)
        Me.Optsucy.Name = "Optsucy"
        Me.Optsucy.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Optsucy.Size = New System.Drawing.Size(138, 21)
        Me.Optsucy.TabIndex = 16
        Me.Optsucy.Text = "Suction Pressure"
        Me.Optsucy.UseVisualStyleBackColor = True
        '
        'CmbReserveHead
        '
        Me.CmbReserveHead.FormattingEnabled = True
        Me.CmbReserveHead.Items.AddRange(New Object() {"5%", "10%", "15%", "20%"})
        Me.CmbReserveHead.Location = New System.Drawing.Point(128, 144)
        Me.CmbReserveHead.Name = "CmbReserveHead"
        Me.CmbReserveHead.Size = New System.Drawing.Size(55, 24)
        Me.CmbReserveHead.TabIndex = 15
        Me.CmbReserveHead.Text = "5%"
        '
        'Txtfsp
        '
        Me.Txtfsp.Location = New System.Drawing.Point(128, 116)
        Me.Txtfsp.Name = "Txtfsp"
        Me.Txtfsp.Size = New System.Drawing.Size(55, 22)
        Me.Txtfsp.TabIndex = 14
        Me.Txtfsp.Text = "0"
        '
        'TxtDischargePressure
        '
        Me.TxtDischargePressure.Location = New System.Drawing.Point(128, 86)
        Me.TxtDischargePressure.Name = "TxtDischargePressure"
        Me.TxtDischargePressure.Size = New System.Drawing.Size(55, 22)
        Me.TxtDischargePressure.TabIndex = 13
        Me.TxtDischargePressure.Text = "0"
        '
        'TxtInletPressure
        '
        Me.TxtInletPressure.Location = New System.Drawing.Point(128, 58)
        Me.TxtInletPressure.Name = "TxtInletPressure"
        Me.TxtInletPressure.Size = New System.Drawing.Size(55, 22)
        Me.TxtInletPressure.TabIndex = 12
        Me.TxtInletPressure.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Reserve Head"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 17)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Pressure Rise"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(50, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Discharge"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(88, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 17)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Inlet"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OptStaticPressure
        '
        Me.OptStaticPressure.AutoSize = True
        Me.OptStaticPressure.Checked = True
        Me.OptStaticPressure.Location = New System.Drawing.Point(22, 34)
        Me.OptStaticPressure.Name = "OptStaticPressure"
        Me.OptStaticPressure.Size = New System.Drawing.Size(64, 21)
        Me.OptStaticPressure.TabIndex = 3
        Me.OptStaticPressure.TabStop = True
        Me.OptStaticPressure.Text = "Static"
        Me.OptStaticPressure.UseVisualStyleBackColor = True
        '
        'OptTotalPressure
        '
        Me.OptTotalPressure.AutoSize = True
        Me.OptTotalPressure.Location = New System.Drawing.Point(118, 34)
        Me.OptTotalPressure.Name = "OptTotalPressure"
        Me.OptTotalPressure.Size = New System.Drawing.Size(61, 21)
        Me.OptTotalPressure.TabIndex = 2
        Me.OptTotalPressure.Text = "Total"
        Me.OptTotalPressure.UseVisualStyleBackColor = True
        '
        'GrpFlowRate
        '
        Me.GrpFlowRate.BackColor = System.Drawing.Color.Maroon
        Me.GrpFlowRate.Controls.Add(Me.LblFlowRateUnits)
        Me.GrpFlowRate.Controls.Add(Me.Panel1)
        Me.GrpFlowRate.Controls.Add(Me.Txtflow)
        Me.GrpFlowRate.Controls.Add(Me.OptMassFlow)
        Me.GrpFlowRate.Controls.Add(Me.OptVolumeFlow)
        Me.GrpFlowRate.ForeColor = System.Drawing.SystemColors.Window
        Me.GrpFlowRate.Location = New System.Drawing.Point(312, 17)
        Me.GrpFlowRate.Name = "GrpFlowRate"
        Me.GrpFlowRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpFlowRate.Size = New System.Drawing.Size(216, 190)
        Me.GrpFlowRate.TabIndex = 5
        Me.GrpFlowRate.TabStop = False
        Me.GrpFlowRate.Text = "Flow Rate"
        '
        'LblFlowRateUnits
        '
        Me.LblFlowRateUnits.AutoSize = True
        Me.LblFlowRateUnits.Location = New System.Drawing.Point(123, 62)
        Me.LblFlowRateUnits.Name = "LblFlowRateUnits"
        Me.LblFlowRateUnits.Size = New System.Drawing.Size(41, 17)
        Me.LblFlowRateUnits.TabIndex = 4
        Me.LblFlowRateUnits.Text = "m³/hr"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Tomato
        Me.Panel1.Controls.Add(Me.OptFlowDischarge)
        Me.Panel1.Controls.Add(Me.OptFlowNominal)
        Me.Panel1.Controls.Add(Me.OpFlowInlet)
        Me.Panel1.Location = New System.Drawing.Point(2, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 90)
        Me.Panel1.TabIndex = 3
        '
        'OptFlowDischarge
        '
        Me.OptFlowDischarge.AutoSize = True
        Me.OptFlowDischarge.Location = New System.Drawing.Point(17, 40)
        Me.OptFlowDischarge.Name = "OptFlowDischarge"
        Me.OptFlowDischarge.Size = New System.Drawing.Size(93, 21)
        Me.OptFlowDischarge.TabIndex = 5
        Me.OptFlowDischarge.Text = "Discharge"
        Me.OptFlowDischarge.UseVisualStyleBackColor = True
        '
        'OptFlowNominal
        '
        Me.OptFlowNominal.AutoSize = True
        Me.OptFlowNominal.Location = New System.Drawing.Point(128, 12)
        Me.OptFlowNominal.Name = "OptFlowNominal"
        Me.OptFlowNominal.Size = New System.Drawing.Size(80, 21)
        Me.OptFlowNominal.TabIndex = 4
        Me.OptFlowNominal.Text = "Nominal"
        Me.OptFlowNominal.UseVisualStyleBackColor = True
        '
        'OpFlowInlet
        '
        Me.OpFlowInlet.AutoSize = True
        Me.OpFlowInlet.Checked = True
        Me.OpFlowInlet.Location = New System.Drawing.Point(17, 12)
        Me.OpFlowInlet.Name = "OpFlowInlet"
        Me.OpFlowInlet.Size = New System.Drawing.Size(55, 21)
        Me.OpFlowInlet.TabIndex = 3
        Me.OpFlowInlet.TabStop = True
        Me.OpFlowInlet.Text = "Inlet"
        Me.OpFlowInlet.UseVisualStyleBackColor = True
        '
        'Txtflow
        '
        Me.Txtflow.Location = New System.Drawing.Point(17, 61)
        Me.Txtflow.Name = "Txtflow"
        Me.Txtflow.Size = New System.Drawing.Size(100, 22)
        Me.Txtflow.TabIndex = 2
        Me.Txtflow.Text = "0"
        '
        'OptMassFlow
        '
        Me.OptMassFlow.AutoSize = True
        Me.OptMassFlow.Location = New System.Drawing.Point(130, 32)
        Me.OptMassFlow.Name = "OptMassFlow"
        Me.OptMassFlow.Size = New System.Drawing.Size(62, 21)
        Me.OptMassFlow.TabIndex = 1
        Me.OptMassFlow.Text = "Mass"
        Me.OptMassFlow.UseVisualStyleBackColor = True
        '
        'OptVolumeFlow
        '
        Me.OptVolumeFlow.AutoSize = True
        Me.OptVolumeFlow.Checked = True
        Me.OptVolumeFlow.Location = New System.Drawing.Point(17, 32)
        Me.OptVolumeFlow.Name = "OptVolumeFlow"
        Me.OptVolumeFlow.Size = New System.Drawing.Size(76, 21)
        Me.OptVolumeFlow.TabIndex = 0
        Me.OptVolumeFlow.TabStop = True
        Me.OptVolumeFlow.Text = "Volume"
        Me.OptVolumeFlow.UseVisualStyleBackColor = True
        '
        'GrpInletDensity
        '
        Me.GrpInletDensity.BackColor = System.Drawing.Color.Maroon
        Me.GrpInletDensity.Controls.Add(Me.OptDensityCalculated)
        Me.GrpInletDensity.Controls.Add(Me.OptDensityKnown)
        Me.GrpInletDensity.Controls.Add(Me.Txtdens)
        Me.GrpInletDensity.ForeColor = System.Drawing.SystemColors.Window
        Me.GrpInletDensity.Location = New System.Drawing.Point(12, 267)
        Me.GrpInletDensity.Name = "GrpInletDensity"
        Me.GrpInletDensity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpInletDensity.Size = New System.Drawing.Size(294, 83)
        Me.GrpInletDensity.TabIndex = 4
        Me.GrpInletDensity.TabStop = False
        Me.GrpInletDensity.Text = "Inlet Density (kg/m³)"
        '
        'OptDensityCalculated
        '
        Me.OptDensityCalculated.AutoSize = True
        Me.OptDensityCalculated.Location = New System.Drawing.Point(165, 34)
        Me.OptDensityCalculated.Name = "OptDensityCalculated"
        Me.OptDensityCalculated.Size = New System.Drawing.Size(95, 21)
        Me.OptDensityCalculated.TabIndex = 2
        Me.OptDensityCalculated.Text = "Calculated"
        Me.OptDensityCalculated.UseVisualStyleBackColor = True
        '
        'OptDensityKnown
        '
        Me.OptDensityKnown.AutoSize = True
        Me.OptDensityKnown.Checked = True
        Me.OptDensityKnown.Location = New System.Drawing.Point(88, 34)
        Me.OptDensityKnown.Name = "OptDensityKnown"
        Me.OptDensityKnown.Size = New System.Drawing.Size(71, 21)
        Me.OptDensityKnown.TabIndex = 1
        Me.OptDensityKnown.TabStop = True
        Me.OptDensityKnown.Text = "Known"
        Me.OptDensityKnown.UseVisualStyleBackColor = True
        '
        'Txtdens
        '
        Me.Txtdens.Location = New System.Drawing.Point(14, 33)
        Me.Txtdens.Name = "Txtdens"
        Me.Txtdens.Size = New System.Drawing.Size(70, 22)
        Me.Txtdens.TabIndex = 0
        Me.Txtdens.Text = "1.205"
        '
        'GrpEnvironment
        '
        Me.GrpEnvironment.BackColor = System.Drawing.Color.Maroon
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
        Me.GrpEnvironment.ForeColor = System.Drawing.SystemColors.Window
        Me.GrpEnvironment.Location = New System.Drawing.Point(12, 106)
        Me.GrpEnvironment.Name = "GrpEnvironment"
        Me.GrpEnvironment.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpEnvironment.Size = New System.Drawing.Size(294, 155)
        Me.GrpEnvironment.TabIndex = 3
        Me.GrpEnvironment.TabStop = False
        Me.GrpEnvironment.Text = "Environment"
        '
        'LblAtmosphericPressureUnits
        '
        Me.LblAtmosphericPressureUnits.AutoSize = True
        Me.LblAtmosphericPressureUnits.Location = New System.Drawing.Point(233, 112)
        Me.LblAtmosphericPressureUnits.Name = "LblAtmosphericPressureUnits"
        Me.LblAtmosphericPressureUnits.Size = New System.Drawing.Size(25, 17)
        Me.LblAtmosphericPressureUnits.TabIndex = 11
        Me.LblAtmosphericPressureUnits.Text = "Pa"
        Me.LblAtmosphericPressureUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblHumidityUnits
        '
        Me.LblHumidityUnits.AutoSize = True
        Me.LblHumidityUnits.Location = New System.Drawing.Point(233, 87)
        Me.LblHumidityUnits.Name = "LblHumidityUnits"
        Me.LblHumidityUnits.Size = New System.Drawing.Size(20, 17)
        Me.LblHumidityUnits.TabIndex = 10
        Me.LblHumidityUnits.Text = "%"
        Me.LblHumidityUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblAltitudeUnits
        '
        Me.LblAltitudeUnits.AutoSize = True
        Me.LblAltitudeUnits.Location = New System.Drawing.Point(233, 58)
        Me.LblAltitudeUnits.Name = "LblAltitudeUnits"
        Me.LblAltitudeUnits.Size = New System.Drawing.Size(19, 17)
        Me.LblAltitudeUnits.TabIndex = 9
        Me.LblAltitudeUnits.Text = "m"
        Me.LblAltitudeUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblAmbientTemperatureUnits
        '
        Me.LblAmbientTemperatureUnits.AutoSize = True
        Me.LblAmbientTemperatureUnits.Location = New System.Drawing.Point(233, 29)
        Me.LblAmbientTemperatureUnits.Name = "LblAmbientTemperatureUnits"
        Me.LblAmbientTemperatureUnits.Size = New System.Drawing.Size(23, 17)
        Me.LblAmbientTemperatureUnits.TabIndex = 8
        Me.LblAmbientTemperatureUnits.Text = "°C"
        Me.LblAmbientTemperatureUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtAtmosphericPressure
        '
        Me.TxtAtmosphericPressure.Location = New System.Drawing.Point(168, 112)
        Me.TxtAtmosphericPressure.Name = "TxtAtmosphericPressure"
        Me.TxtAtmosphericPressure.Size = New System.Drawing.Size(66, 22)
        Me.TxtAtmosphericPressure.TabIndex = 7
        Me.TxtAtmosphericPressure.Text = "101325"
        '
        'TxtHumidity
        '
        Me.TxtHumidity.Location = New System.Drawing.Point(168, 84)
        Me.TxtHumidity.Name = "TxtHumidity"
        Me.TxtHumidity.Size = New System.Drawing.Size(66, 22)
        Me.TxtHumidity.TabIndex = 6
        Me.TxtHumidity.Text = "0"
        '
        'TxtAltitude
        '
        Me.TxtAltitude.Location = New System.Drawing.Point(168, 56)
        Me.TxtAltitude.Name = "TxtAltitude"
        Me.TxtAltitude.Size = New System.Drawing.Size(66, 22)
        Me.TxtAltitude.TabIndex = 5
        Me.TxtAltitude.Text = "0"
        '
        'TxtAmbientTemperature
        '
        Me.TxtAmbientTemperature.Location = New System.Drawing.Point(168, 28)
        Me.TxtAmbientTemperature.Name = "TxtAmbientTemperature"
        Me.TxtAmbientTemperature.Size = New System.Drawing.Size(66, 22)
        Me.TxtAmbientTemperature.TabIndex = 4
        Me.TxtAmbientTemperature.Text = "20"
        '
        'LblAtmosphericPressure
        '
        Me.LblAtmosphericPressure.AutoSize = True
        Me.LblAtmosphericPressure.Location = New System.Drawing.Point(17, 112)
        Me.LblAtmosphericPressure.Name = "LblAtmosphericPressure"
        Me.LblAtmosphericPressure.Size = New System.Drawing.Size(147, 17)
        Me.LblAtmosphericPressure.TabIndex = 3
        Me.LblAtmosphericPressure.Text = "Atmospheric Pressure"
        Me.LblAtmosphericPressure.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblHumidity
        '
        Me.LblHumidity.AutoSize = True
        Me.LblHumidity.Location = New System.Drawing.Point(102, 84)
        Me.LblHumidity.Name = "LblHumidity"
        Me.LblHumidity.Size = New System.Drawing.Size(62, 17)
        Me.LblHumidity.TabIndex = 2
        Me.LblHumidity.Text = "Humidity"
        Me.LblHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblAltitude
        '
        Me.LblAltitude.AutoSize = True
        Me.LblAltitude.Location = New System.Drawing.Point(6, 58)
        Me.LblAltitude.Name = "LblAltitude"
        Me.LblAltitude.Size = New System.Drawing.Size(158, 17)
        Me.LblAltitude.TabIndex = 1
        Me.LblAltitude.Text = "Altitude above sea level"
        Me.LblAltitude.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblAmbientTemperature
        '
        Me.LblAmbientTemperature.AutoSize = True
        Me.LblAmbientTemperature.Location = New System.Drawing.Point(19, 29)
        Me.LblAmbientTemperature.Name = "LblAmbientTemperature"
        Me.LblAmbientTemperature.Size = New System.Drawing.Size(145, 17)
        Me.LblAmbientTemperature.TabIndex = 0
        Me.LblAmbientTemperature.Text = "Ambient Temperature"
        Me.LblAmbientTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(12, 532)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 36)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "EXIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GrpInletTemperature
        '
        Me.GrpInletTemperature.BackColor = System.Drawing.Color.Maroon
        Me.GrpInletTemperature.Controls.Add(Me.TxtMaximumTemperature)
        Me.GrpInletTemperature.Controls.Add(Me.LblMaximumTemperature)
        Me.GrpInletTemperature.Controls.Add(Me.LblDesignTemperature)
        Me.GrpInletTemperature.Controls.Add(Me.TxtDesignTemperature)
        Me.GrpInletTemperature.ForeColor = System.Drawing.SystemColors.Window
        Me.GrpInletTemperature.Location = New System.Drawing.Point(12, 17)
        Me.GrpInletTemperature.Name = "GrpInletTemperature"
        Me.GrpInletTemperature.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpInletTemperature.Size = New System.Drawing.Size(294, 83)
        Me.GrpInletTemperature.TabIndex = 1
        Me.GrpInletTemperature.TabStop = False
        Me.GrpInletTemperature.Text = "Inlet Temperature (°C)"
        '
        'TxtMaximumTemperature
        '
        Me.TxtMaximumTemperature.Location = New System.Drawing.Point(187, 33)
        Me.TxtMaximumTemperature.Name = "TxtMaximumTemperature"
        Me.TxtMaximumTemperature.Size = New System.Drawing.Size(36, 22)
        Me.TxtMaximumTemperature.TabIndex = 3
        Me.TxtMaximumTemperature.Text = "20"
        '
        'LblMaximumTemperature
        '
        Me.LblMaximumTemperature.AutoSize = True
        Me.LblMaximumTemperature.Location = New System.Drawing.Point(117, 36)
        Me.LblMaximumTemperature.Name = "LblMaximumTemperature"
        Me.LblMaximumTemperature.Size = New System.Drawing.Size(66, 17)
        Me.LblMaximumTemperature.TabIndex = 2
        Me.LblMaximumTemperature.Text = "Maximum"
        '
        'LblDesignTemperature
        '
        Me.LblDesignTemperature.AutoSize = True
        Me.LblDesignTemperature.Location = New System.Drawing.Point(6, 36)
        Me.LblDesignTemperature.Name = "LblDesignTemperature"
        Me.LblDesignTemperature.Size = New System.Drawing.Size(52, 17)
        Me.LblDesignTemperature.TabIndex = 1
        Me.LblDesignTemperature.Text = "Design"
        '
        'TxtDesignTemperature
        '
        Me.TxtDesignTemperature.Location = New System.Drawing.Point(64, 33)
        Me.TxtDesignTemperature.Name = "TxtDesignTemperature"
        Me.TxtDesignTemperature.Size = New System.Drawing.Size(36, 22)
        Me.TxtDesignTemperature.TabIndex = 0
        Me.TxtDesignTemperature.Text = "20"
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(1101, 532)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 36)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Select"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'TabPageSelection
        '
        Me.TabPageSelection.Controls.Add(Me.BtnClose)
        Me.TabPageSelection.Controls.Add(Me.LblGasDensityUnit)
        Me.TabPageSelection.Controls.Add(Me.Label2)
        Me.TabPageSelection.Controls.Add(Me.TxtDensity)
        Me.TabPageSelection.Controls.Add(Me.Button3)
        Me.TabPageSelection.Controls.Add(Me.Button4)
        Me.TabPageSelection.Controls.Add(Me.DataGridView1)
        Me.TabPageSelection.Location = New System.Drawing.Point(4, 25)
        Me.TabPageSelection.Name = "TabPageSelection"
        Me.TabPageSelection.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSelection.Size = New System.Drawing.Size(1215, 587)
        Me.TabPageSelection.TabIndex = 1
        Me.TabPageSelection.Text = "Selection"
        Me.TabPageSelection.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(431, 17)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(89, 34)
        Me.BtnClose.TabIndex = 14
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'LblGasDensityUnit
        '
        Me.LblGasDensityUnit.AutoSize = True
        Me.LblGasDensityUnit.Location = New System.Drawing.Point(998, 29)
        Me.LblGasDensityUnit.Name = "LblGasDensityUnit"
        Me.LblGasDensityUnit.Size = New System.Drawing.Size(43, 17)
        Me.LblGasDensityUnit.TabIndex = 13
        Me.LblGasDensityUnit.Text = "kg/m³"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(801, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Gas Density"
        '
        'TxtDensity
        '
        Me.TxtDensity.Location = New System.Drawing.Point(892, 26)
        Me.TxtDensity.Name = "TxtDensity"
        Me.TxtDensity.Size = New System.Drawing.Size(100, 22)
        Me.TxtDensity.TabIndex = 11
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(685, 17)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 34)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "txt Files"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(321, 17)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(89, 34)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "End"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(20, 75)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1159, 152)
        Me.DataGridView1.TabIndex = 8
        '
        'TabPageNoise
        '
        Me.TabPageNoise.Location = New System.Drawing.Point(4, 25)
        Me.TabPageNoise.Name = "TabPageNoise"
        Me.TabPageNoise.Size = New System.Drawing.Size(1215, 587)
        Me.TabPageNoise.TabIndex = 3
        Me.TabPageNoise.Text = "Noise"
        Me.TabPageNoise.UseVisualStyleBackColor = True
        '
        'TabPageImpeller
        '
        Me.TabPageImpeller.Location = New System.Drawing.Point(4, 25)
        Me.TabPageImpeller.Name = "TabPageImpeller"
        Me.TabPageImpeller.Size = New System.Drawing.Size(1215, 587)
        Me.TabPageImpeller.TabIndex = 4
        Me.TabPageImpeller.Text = "Impeller"
        Me.TabPageImpeller.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ProjectDetailsToolStripMenuItem, Me.UnitsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1205, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.OpenProjectToolStripMenuItem, Me.SaveProjectToolStripMenuItem, Me.ExitProjectToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(170, 26)
        Me.OpenToolStripMenuItem.Text = "New Project"
        '
        'OpenProjectToolStripMenuItem
        '
        Me.OpenProjectToolStripMenuItem.Name = "OpenProjectToolStripMenuItem"
        Me.OpenProjectToolStripMenuItem.Size = New System.Drawing.Size(170, 26)
        Me.OpenProjectToolStripMenuItem.Text = "Open Project"
        '
        'SaveProjectToolStripMenuItem
        '
        Me.SaveProjectToolStripMenuItem.Name = "SaveProjectToolStripMenuItem"
        Me.SaveProjectToolStripMenuItem.Size = New System.Drawing.Size(170, 26)
        Me.SaveProjectToolStripMenuItem.Text = "Save Project"
        '
        'ExitProjectToolStripMenuItem
        '
        Me.ExitProjectToolStripMenuItem.Name = "ExitProjectToolStripMenuItem"
        Me.ExitProjectToolStripMenuItem.Size = New System.Drawing.Size(170, 26)
        Me.ExitProjectToolStripMenuItem.Text = "Exit Project"
        '
        'ProjectDetailsToolStripMenuItem
        '
        Me.ProjectDetailsToolStripMenuItem.Name = "ProjectDetailsToolStripMenuItem"
        Me.ProjectDetailsToolStripMenuItem.Size = New System.Drawing.Size(117, 24)
        Me.ProjectDetailsToolStripMenuItem.Text = "Project Details"
        '
        'UnitsToolStripMenuItem
        '
        Me.UnitsToolStripMenuItem.Name = "UnitsToolStripMenuItem"
        Me.UnitsToolStripMenuItem.ShortcutKeyDisplayString = "Alt+U"
        Me.UnitsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UnitsToolStripMenuItem.Size = New System.Drawing.Size(54, 24)
        Me.UnitsToolStripMenuItem.Text = "Units"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Halifax_Fan_Selector.My.Resources.Resources.header2015
        Me.PictureBox1.Location = New System.Drawing.Point(941, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(277, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Red
        Me.GroupBox2.Controls.Add(Me.OptXLS)
        Me.GroupBox2.Controls.Add(Me.OptTXT)
        Me.GroupBox2.Location = New System.Drawing.Point(473, 286)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'OptTXT
        '
        Me.OptTXT.AutoSize = True
        Me.OptTXT.Checked = True
        Me.OptTXT.Location = New System.Drawing.Point(29, 25)
        Me.OptTXT.Name = "OptTXT"
        Me.OptTXT.Size = New System.Drawing.Size(118, 21)
        Me.OptTXT.TabIndex = 0
        Me.OptTXT.TabStop = True
        Me.OptTXT.Text = "Use TXT Files"
        Me.OptTXT.UseVisualStyleBackColor = True
        '
        'OptXLS
        '
        Me.OptXLS.AutoSize = True
        Me.OptXLS.Location = New System.Drawing.Point(29, 64)
        Me.OptXLS.Name = "OptXLS"
        Me.OptXLS.Size = New System.Drawing.Size(117, 21)
        Me.OptXLS.TabIndex = 1
        Me.OptXLS.TabStop = True
        Me.OptXLS.Text = "Use XLS Files"
        Me.OptXLS.UseVisualStyleBackColor = True
        '
        'Frmselectfan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(1205, 671)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1223, 718)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1223, 718)
        Me.Name = "Frmselectfan"
        Me.Text = "Halifax Fan Selection Software"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageDuty.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GrpFrequency.ResumeLayout(False)
        Me.GrpFrequency.PerformLayout()
        Me.GrpFanSize.ResumeLayout(False)
        Me.GrpFanSize.PerformLayout()
        Me.GrpFanSpeed.ResumeLayout(False)
        Me.GrpFanSpeed.PerformLayout()
        Me.GrpFanTypes.ResumeLayout(False)
        Me.GrpFanTypes.PerformLayout()
        Me.GrpDesignPressure.ResumeLayout(False)
        Me.GrpDesignPressure.PerformLayout()
        Me.GrpFlowRate.ResumeLayout(False)
        Me.GrpFlowRate.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GrpInletDensity.ResumeLayout(False)
        Me.GrpInletDensity.PerformLayout()
        Me.GrpEnvironment.ResumeLayout(False)
        Me.GrpEnvironment.PerformLayout()
        Me.GrpInletTemperature.ResumeLayout(False)
        Me.GrpInletTemperature.PerformLayout()
        Me.TabPageSelection.ResumeLayout(False)
        Me.TabPageSelection.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPageDuty As TabPage
    Friend WithEvents GrpInletTemperature As GroupBox
    Friend WithEvents LblDesignTemperature As Label
    Friend WithEvents TxtDesignTemperature As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TabPageSelection As TabPage
    Friend WithEvents TabPageNoise As TabPage
    Friend WithEvents TabPageImpeller As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents TxtMaximumTemperature As TextBox
    Friend WithEvents LblMaximumTemperature As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GrpFrequency As GroupBox
    Friend WithEvents GrpFanSize As GroupBox
    Friend WithEvents GrpFanSpeed As GroupBox
    Friend WithEvents GrpFanTypes As GroupBox
    Friend WithEvents GrpDesignPressure As GroupBox
    Friend WithEvents Txtfsp As TextBox
    Friend WithEvents TxtDischargePressure As TextBox
    Friend WithEvents TxtInletPressure As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents OptStaticPressure As RadioButton
    Friend WithEvents OptTotalPressure As RadioButton
    Friend WithEvents GrpFlowRate As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents OptFlowDischarge As RadioButton
    Friend WithEvents OptFlowNominal As RadioButton
    Friend WithEvents OpFlowInlet As RadioButton
    Friend WithEvents Txtflow As TextBox
    Friend WithEvents OptMassFlow As RadioButton
    Friend WithEvents OptVolumeFlow As RadioButton
    Friend WithEvents GrpInletDensity As GroupBox
    Friend WithEvents OptDensityCalculated As RadioButton
    Friend WithEvents OptDensityKnown As RadioButton
    Friend WithEvents Txtdens As TextBox
    Friend WithEvents GrpEnvironment As GroupBox
    Friend WithEvents TxtAtmosphericPressure As TextBox
    Friend WithEvents TxtHumidity As TextBox
    Friend WithEvents TxtAltitude As TextBox
    Friend WithEvents TxtAmbientTemperature As TextBox
    Friend WithEvents LblAtmosphericPressure As Label
    Friend WithEvents LblHumidity As Label
    Friend WithEvents LblAltitude As Label
    Friend WithEvents LblAmbientTemperature As Label
    Friend WithEvents CmbReserveHead As ComboBox
    Friend WithEvents ChkOldDesignFans As CheckBox
    Friend WithEvents ChkAxialFans As CheckBox
    Friend WithEvents ChkPlenumFans As CheckBox
    Friend WithEvents ChkPlasticFan As CheckBox
    Friend WithEvents ChkOtherFanType As CheckBox
    Friend WithEvents ChkInclineBlade As CheckBox
    Friend WithEvents ChkCurveBlade As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Opt50Hz As RadioButton
    Friend WithEvents Opt60Hz As RadioButton
    Friend WithEvents OptAnySize As RadioButton
    Friend WithEvents OptFixedSize As RadioButton
    Friend WithEvents Txtspeedlimit As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents OptFixedSpeed As RadioButton
    Friend WithEvents OptAnySpeed As RadioButton
    Friend WithEvents OptPoleSpeed As RadioButton
    Friend WithEvents LblFlowRateUnits As Label
    Friend WithEvents ProjectDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnitsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LblAltitudeUnits As Label
    Friend WithEvents LblAmbientTemperatureUnits As Label
    Friend WithEvents LblAtmosphericPressureUnits As Label
    Friend WithEvents LblHumidityUnits As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Optsucy As CheckBox
    Friend WithEvents Txtfansize As TextBox
    Friend WithEvents Lblfansize As Label
    Friend WithEvents Txtfanspeed As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblLengthUnits As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents LblGasDensityUnit As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtDensity As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents OptXLS As RadioButton
    Friend WithEvents OptTXT As RadioButton
End Class
