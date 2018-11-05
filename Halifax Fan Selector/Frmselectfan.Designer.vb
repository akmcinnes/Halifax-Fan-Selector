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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageEnvironment = New System.Windows.Forms.TabPage()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.OptVelocityFtpermin = New System.Windows.Forms.RadioButton()
        Me.OptVelocityMpers = New System.Windows.Forms.RadioButton()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.OptPowerHp = New System.Windows.Forms.RadioButton()
        Me.OptPowerKW = New System.Windows.Forms.RadioButton()
        Me.OptDefaultMetric = New System.Windows.Forms.RadioButton()
        Me.OptDefaultImperial = New System.Windows.Forms.RadioButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.OptDefaultNone = New System.Windows.Forms.RadioButton()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.OptAltitudeFt = New System.Windows.Forms.RadioButton()
        Me.OptAltitudeM = New System.Windows.Forms.RadioButton()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.OptLengthIn = New System.Windows.Forms.RadioButton()
        Me.OptLengthMm = New System.Windows.Forms.RadioButton()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.OptTemperatureF = New System.Windows.Forms.RadioButton()
        Me.OptTemperatureC = New System.Windows.Forms.RadioButton()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.OptFlowLbPerHr = New System.Windows.Forms.RadioButton()
        Me.OptFlowKgPerHr = New System.Windows.Forms.RadioButton()
        Me.OptFlowCfm = New System.Windows.Forms.RadioButton()
        Me.OptFlowM3PerHr = New System.Windows.Forms.RadioButton()
        Me.OptFlowM3PerMin = New System.Windows.Forms.RadioButton()
        Me.OptFlowM3PerSec = New System.Windows.Forms.RadioButton()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.OptPressuremmWG = New System.Windows.Forms.RadioButton()
        Me.OptPressureinWG = New System.Windows.Forms.RadioButton()
        Me.OptPressuremBar = New System.Windows.Forms.RadioButton()
        Me.OptPressurePa = New System.Windows.Forms.RadioButton()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.OptDensityLbPerFt3 = New System.Windows.Forms.RadioButton()
        Me.OptDensityKgPerM3 = New System.Windows.Forms.RadioButton()
        Me.Button8 = New System.Windows.Forms.Button()
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
        Me.TabPageDuty = New System.Windows.Forms.TabPage()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.GrpFlowRate = New System.Windows.Forms.GroupBox()
        Me.LblFlowRateUnits = New System.Windows.Forms.Label()
        Me.Txtflow = New System.Windows.Forms.TextBox()
        Me.OptMassFlow = New System.Windows.Forms.RadioButton()
        Me.OptVolumeFlow = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.OptFlowDischarge = New System.Windows.Forms.RadioButton()
        Me.OptFlowNominal = New System.Windows.Forms.RadioButton()
        Me.OpFlowInlet = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OptXLS = New System.Windows.Forms.RadioButton()
        Me.OptTXT = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
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
        Me.GrpInletDensity = New System.Windows.Forms.GroupBox()
        Me.OptDensityCalculated = New System.Windows.Forms.RadioButton()
        Me.OptDensityKnown = New System.Windows.Forms.RadioButton()
        Me.Txtdens = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GrpInletTemperature = New System.Windows.Forms.GroupBox()
        Me.TxtMaximumTemperature = New System.Windows.Forms.TextBox()
        Me.LblMaximumTemperature = New System.Windows.Forms.Label()
        Me.LblDesignTemperature = New System.Windows.Forms.Label()
        Me.TxtDesignTemperature = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPageFanParameters = New System.Windows.Forms.TabPage()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.GrpFanSize = New System.Windows.Forms.GroupBox()
        Me.LblLengthUnits = New System.Windows.Forms.Label()
        Me.Txtfansize = New System.Windows.Forms.TextBox()
        Me.Lblfansize = New System.Windows.Forms.Label()
        Me.OptAnySize = New System.Windows.Forms.RadioButton()
        Me.OptFixedSize = New System.Windows.Forms.RadioButton()
        Me.GrpFanSpeed = New System.Windows.Forms.GroupBox()
        Me.GrpPoleBox = New System.Windows.Forms.GroupBox()
        Me.Opt12Pole = New System.Windows.Forms.RadioButton()
        Me.Opt10Pole = New System.Windows.Forms.RadioButton()
        Me.Opt8Pole = New System.Windows.Forms.RadioButton()
        Me.Opt6Pole = New System.Windows.Forms.RadioButton()
        Me.Opt4Pole = New System.Windows.Forms.RadioButton()
        Me.Opt2Pole = New System.Windows.Forms.RadioButton()
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
        Me.TabPageSelection = New System.Windows.Forms.TabPage()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.LblFanDetails = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.LblGasDensityUnit = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDensity = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPageNoise = New System.Windows.Forms.TabPage()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.OptMotor = New System.Windows.Forms.CheckBox()
        Me.OptBrg = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.OptOpenOutlet = New System.Windows.Forms.RadioButton()
        Me.OptOpenInlet = New System.Windows.Forms.RadioButton()
        Me.OptDuct = New System.Windows.Forms.RadioButton()
        Me.TxtTypenoise = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtSizenoise = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtPressurenoise = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtSpeednoise = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtFlownoise = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TabPageImpeller = New System.Windows.Forms.TabPage()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnitsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPageEnvironment.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GrpFrequency.SuspendLayout()
        Me.GrpEnvironment.SuspendLayout()
        Me.TabPageDuty.SuspendLayout()
        Me.GrpFlowRate.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GrpDesignPressure.SuspendLayout()
        Me.GrpInletDensity.SuspendLayout()
        Me.GrpInletTemperature.SuspendLayout()
        Me.TabPageFanParameters.SuspendLayout()
        Me.GrpFanSize.SuspendLayout()
        Me.GrpFanSpeed.SuspendLayout()
        Me.GrpPoleBox.SuspendLayout()
        Me.GrpFanTypes.SuspendLayout()
        Me.TabPageSelection.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageNoise.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageEnvironment)
        Me.TabControl1.Controls.Add(Me.TabPageDuty)
        Me.TabControl1.Controls.Add(Me.TabPageFanParameters)
        Me.TabControl1.Controls.Add(Me.TabPageSelection)
        Me.TabControl1.Controls.Add(Me.TabPageNoise)
        Me.TabControl1.Controls.Add(Me.TabPageImpeller)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 28)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1255, 640)
        Me.TabControl1.TabIndex = 0
        '
        'TabPageEnvironment
        '
        Me.TabPageEnvironment.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TabPageEnvironment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPageEnvironment.Controls.Add(Me.GroupBox9)
        Me.TabPageEnvironment.Controls.Add(Me.BtnExit)
        Me.TabPageEnvironment.Controls.Add(Me.GroupBox8)
        Me.TabPageEnvironment.Controls.Add(Me.OptDefaultMetric)
        Me.TabPageEnvironment.Controls.Add(Me.OptDefaultImperial)
        Me.TabPageEnvironment.Controls.Add(Me.GroupBox7)
        Me.TabPageEnvironment.Controls.Add(Me.GroupBox10)
        Me.TabPageEnvironment.Controls.Add(Me.BtnCancel)
        Me.TabPageEnvironment.Controls.Add(Me.GroupBox11)
        Me.TabPageEnvironment.Controls.Add(Me.GroupBox12)
        Me.TabPageEnvironment.Controls.Add(Me.GroupBox13)
        Me.TabPageEnvironment.Controls.Add(Me.GroupBox14)
        Me.TabPageEnvironment.Controls.Add(Me.GroupBox15)
        Me.TabPageEnvironment.Controls.Add(Me.Button8)
        Me.TabPageEnvironment.Controls.Add(Me.GrpFrequency)
        Me.TabPageEnvironment.Controls.Add(Me.GrpEnvironment)
        Me.TabPageEnvironment.Location = New System.Drawing.Point(4, 34)
        Me.TabPageEnvironment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageEnvironment.Name = "TabPageEnvironment"
        Me.TabPageEnvironment.Size = New System.Drawing.Size(1247, 602)
        Me.TabPageEnvironment.TabIndex = 5
        Me.TabPageEnvironment.Text = "Environmental Info"
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox9.Controls.Add(Me.OptVelocityFtpermin)
        Me.GroupBox9.Controls.Add(Me.OptVelocityMpers)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.ForeColor = System.Drawing.Color.White
        Me.GroupBox9.Location = New System.Drawing.Point(995, 30)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox9.Size = New System.Drawing.Size(200, 110)
        Me.GroupBox9.TabIndex = 23
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Velocity"
        '
        'OptVelocityFtpermin
        '
        Me.OptVelocityFtpermin.AutoSize = True
        Me.OptVelocityFtpermin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptVelocityFtpermin.ForeColor = System.Drawing.Color.White
        Me.OptVelocityFtpermin.Location = New System.Drawing.Point(19, 54)
        Me.OptVelocityFtpermin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptVelocityFtpermin.Name = "OptVelocityFtpermin"
        Me.OptVelocityFtpermin.Size = New System.Drawing.Size(86, 29)
        Me.OptVelocityFtpermin.TabIndex = 1
        Me.OptVelocityFtpermin.TabStop = True
        Me.OptVelocityFtpermin.Text = "ft/min"
        Me.OptVelocityFtpermin.UseVisualStyleBackColor = True
        '
        'OptVelocityMpers
        '
        Me.OptVelocityMpers.AutoSize = True
        Me.OptVelocityMpers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptVelocityMpers.ForeColor = System.Drawing.Color.White
        Me.OptVelocityMpers.Location = New System.Drawing.Point(19, 28)
        Me.OptVelocityMpers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptVelocityMpers.Name = "OptVelocityMpers"
        Me.OptVelocityMpers.Size = New System.Drawing.Size(68, 29)
        Me.OptVelocityMpers.TabIndex = 0
        Me.OptVelocityMpers.TabStop = True
        Me.OptVelocityMpers.Text = "m/s"
        Me.OptVelocityMpers.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.White
        Me.BtnExit.Location = New System.Drawing.Point(153, 500)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(91, 74)
        Me.BtnExit.TabIndex = 22
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        Me.BtnExit.Visible = False
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox8.Controls.Add(Me.OptPowerHp)
        Me.GroupBox8.Controls.Add(Me.OptPowerKW)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.White
        Me.GroupBox8.Location = New System.Drawing.Point(995, 174)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox8.Size = New System.Drawing.Size(200, 110)
        Me.GroupBox8.TabIndex = 17
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Power"
        '
        'OptPowerHp
        '
        Me.OptPowerHp.AutoSize = True
        Me.OptPowerHp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptPowerHp.ForeColor = System.Drawing.Color.White
        Me.OptPowerHp.Location = New System.Drawing.Point(23, 54)
        Me.OptPowerHp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptPowerHp.Name = "OptPowerHp"
        Me.OptPowerHp.Size = New System.Drawing.Size(57, 29)
        Me.OptPowerHp.TabIndex = 1
        Me.OptPowerHp.TabStop = True
        Me.OptPowerHp.Text = "hp"
        Me.OptPowerHp.UseVisualStyleBackColor = True
        '
        'OptPowerKW
        '
        Me.OptPowerKW.AutoSize = True
        Me.OptPowerKW.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptPowerKW.ForeColor = System.Drawing.Color.White
        Me.OptPowerKW.Location = New System.Drawing.Point(23, 28)
        Me.OptPowerKW.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptPowerKW.Name = "OptPowerKW"
        Me.OptPowerKW.Size = New System.Drawing.Size(65, 29)
        Me.OptPowerKW.TabIndex = 0
        Me.OptPowerKW.TabStop = True
        Me.OptPowerKW.Text = "kW"
        Me.OptPowerKW.UseVisualStyleBackColor = True
        '
        'OptDefaultMetric
        '
        Me.OptDefaultMetric.AutoSize = True
        Me.OptDefaultMetric.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptDefaultMetric.ForeColor = System.Drawing.Color.White
        Me.OptDefaultMetric.Location = New System.Drawing.Point(435, 540)
        Me.OptDefaultMetric.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptDefaultMetric.Name = "OptDefaultMetric"
        Me.OptDefaultMetric.Size = New System.Drawing.Size(177, 29)
        Me.OptDefaultMetric.TabIndex = 0
        Me.OptDefaultMetric.TabStop = True
        Me.OptDefaultMetric.Text = "Metric Defaults"
        Me.OptDefaultMetric.UseVisualStyleBackColor = True
        Me.OptDefaultMetric.Visible = False
        '
        'OptDefaultImperial
        '
        Me.OptDefaultImperial.AutoSize = True
        Me.OptDefaultImperial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptDefaultImperial.ForeColor = System.Drawing.Color.White
        Me.OptDefaultImperial.Location = New System.Drawing.Point(695, 561)
        Me.OptDefaultImperial.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptDefaultImperial.Name = "OptDefaultImperial"
        Me.OptDefaultImperial.Size = New System.Drawing.Size(194, 29)
        Me.OptDefaultImperial.TabIndex = 1
        Me.OptDefaultImperial.TabStop = True
        Me.OptDefaultImperial.Text = "Imperial Defaults"
        Me.OptDefaultImperial.UseVisualStyleBackColor = True
        Me.OptDefaultImperial.Visible = False
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox7.Controls.Add(Me.Button18)
        Me.GroupBox7.Controls.Add(Me.Button17)
        Me.GroupBox7.Controls.Add(Me.OptDefaultNone)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.White
        Me.GroupBox7.Location = New System.Drawing.Point(547, 423)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox7.Size = New System.Drawing.Size(645, 98)
        Me.GroupBox7.TabIndex = 19
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Select defaults"
        '
        'Button18
        '
        Me.Button18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button18.Location = New System.Drawing.Point(220, 41)
        Me.Button18.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(200, 38)
        Me.Button18.TabIndex = 4
        Me.Button18.Text = "Imperial Units"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button17.Location = New System.Drawing.Point(23, 41)
        Me.Button17.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(177, 38)
        Me.Button17.TabIndex = 3
        Me.Button17.Text = "Metric Units"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'OptDefaultNone
        '
        Me.OptDefaultNone.AutoSize = True
        Me.OptDefaultNone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptDefaultNone.ForeColor = System.Drawing.Color.White
        Me.OptDefaultNone.Location = New System.Drawing.Point(467, 39)
        Me.OptDefaultNone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptDefaultNone.Name = "OptDefaultNone"
        Me.OptDefaultNone.Size = New System.Drawing.Size(84, 29)
        Me.OptDefaultNone.TabIndex = 2
        Me.OptDefaultNone.TabStop = True
        Me.OptDefaultNone.Text = "None"
        Me.OptDefaultNone.UseVisualStyleBackColor = True
        Me.OptDefaultNone.Visible = False
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox10.Controls.Add(Me.OptAltitudeFt)
        Me.GroupBox10.Controls.Add(Me.OptAltitudeM)
        Me.GroupBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.ForeColor = System.Drawing.Color.White
        Me.GroupBox10.Location = New System.Drawing.Point(767, 310)
        Me.GroupBox10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox10.Size = New System.Drawing.Size(200, 110)
        Me.GroupBox10.TabIndex = 20
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Altitude"
        '
        'OptAltitudeFt
        '
        Me.OptAltitudeFt.AutoSize = True
        Me.OptAltitudeFt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptAltitudeFt.ForeColor = System.Drawing.Color.White
        Me.OptAltitudeFt.Location = New System.Drawing.Point(23, 55)
        Me.OptAltitudeFt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptAltitudeFt.Name = "OptAltitudeFt"
        Me.OptAltitudeFt.Size = New System.Drawing.Size(45, 29)
        Me.OptAltitudeFt.TabIndex = 1
        Me.OptAltitudeFt.TabStop = True
        Me.OptAltitudeFt.Text = "ft"
        Me.OptAltitudeFt.UseVisualStyleBackColor = True
        '
        'OptAltitudeM
        '
        Me.OptAltitudeM.AutoSize = True
        Me.OptAltitudeM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptAltitudeM.ForeColor = System.Drawing.Color.White
        Me.OptAltitudeM.Location = New System.Drawing.Point(23, 28)
        Me.OptAltitudeM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptAltitudeM.Name = "OptAltitudeM"
        Me.OptAltitudeM.Size = New System.Drawing.Size(50, 29)
        Me.OptAltitudeM.TabIndex = 0
        Me.OptAltitudeM.TabStop = True
        Me.OptAltitudeM.Text = "m"
        Me.OptAltitudeM.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(43, 500)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(91, 74)
        Me.BtnCancel.TabIndex = 21
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        Me.BtnCancel.Visible = False
        '
        'GroupBox11
        '
        Me.GroupBox11.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox11.Controls.Add(Me.OptLengthIn)
        Me.GroupBox11.Controls.Add(Me.OptLengthMm)
        Me.GroupBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox11.ForeColor = System.Drawing.Color.White
        Me.GroupBox11.Location = New System.Drawing.Point(995, 310)
        Me.GroupBox11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox11.Size = New System.Drawing.Size(200, 110)
        Me.GroupBox11.TabIndex = 18
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Length"
        '
        'OptLengthIn
        '
        Me.OptLengthIn.AutoSize = True
        Me.OptLengthIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptLengthIn.ForeColor = System.Drawing.Color.White
        Me.OptLengthIn.Location = New System.Drawing.Point(23, 55)
        Me.OptLengthIn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptLengthIn.Name = "OptLengthIn"
        Me.OptLengthIn.Size = New System.Drawing.Size(61, 29)
        Me.OptLengthIn.TabIndex = 1
        Me.OptLengthIn.TabStop = True
        Me.OptLengthIn.Text = "ins"
        Me.OptLengthIn.UseVisualStyleBackColor = True
        '
        'OptLengthMm
        '
        Me.OptLengthMm.AutoSize = True
        Me.OptLengthMm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptLengthMm.ForeColor = System.Drawing.Color.White
        Me.OptLengthMm.Location = New System.Drawing.Point(23, 28)
        Me.OptLengthMm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptLengthMm.Name = "OptLengthMm"
        Me.OptLengthMm.Size = New System.Drawing.Size(67, 29)
        Me.OptLengthMm.TabIndex = 0
        Me.OptLengthMm.TabStop = True
        Me.OptLengthMm.Text = "mm"
        Me.OptLengthMm.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox12.Controls.Add(Me.OptTemperatureF)
        Me.GroupBox12.Controls.Add(Me.OptTemperatureC)
        Me.GroupBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox12.ForeColor = System.Drawing.Color.White
        Me.GroupBox12.Location = New System.Drawing.Point(767, 174)
        Me.GroupBox12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox12.Size = New System.Drawing.Size(200, 110)
        Me.GroupBox12.TabIndex = 13
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Temperature"
        '
        'OptTemperatureF
        '
        Me.OptTemperatureF.AutoSize = True
        Me.OptTemperatureF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptTemperatureF.ForeColor = System.Drawing.Color.White
        Me.OptTemperatureF.Location = New System.Drawing.Point(32, 60)
        Me.OptTemperatureF.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptTemperatureF.Name = "OptTemperatureF"
        Me.OptTemperatureF.Size = New System.Drawing.Size(55, 29)
        Me.OptTemperatureF.TabIndex = 1
        Me.OptTemperatureF.TabStop = True
        Me.OptTemperatureF.Text = "°F"
        Me.OptTemperatureF.UseVisualStyleBackColor = True
        '
        'OptTemperatureC
        '
        Me.OptTemperatureC.AutoSize = True
        Me.OptTemperatureC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptTemperatureC.ForeColor = System.Drawing.Color.White
        Me.OptTemperatureC.Location = New System.Drawing.Point(32, 34)
        Me.OptTemperatureC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptTemperatureC.Name = "OptTemperatureC"
        Me.OptTemperatureC.Size = New System.Drawing.Size(58, 29)
        Me.OptTemperatureC.TabIndex = 0
        Me.OptTemperatureC.TabStop = True
        Me.OptTemperatureC.Text = "°C"
        Me.OptTemperatureC.UseVisualStyleBackColor = True
        '
        'GroupBox13
        '
        Me.GroupBox13.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox13.Controls.Add(Me.OptFlowLbPerHr)
        Me.GroupBox13.Controls.Add(Me.OptFlowKgPerHr)
        Me.GroupBox13.Controls.Add(Me.OptFlowCfm)
        Me.GroupBox13.Controls.Add(Me.OptFlowM3PerHr)
        Me.GroupBox13.Controls.Add(Me.OptFlowM3PerMin)
        Me.GroupBox13.Controls.Add(Me.OptFlowM3PerSec)
        Me.GroupBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox13.ForeColor = System.Drawing.Color.White
        Me.GroupBox13.Location = New System.Drawing.Point(547, 30)
        Me.GroupBox13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox13.Size = New System.Drawing.Size(200, 199)
        Me.GroupBox13.TabIndex = 14
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Flow"
        '
        'OptFlowLbPerHr
        '
        Me.OptFlowLbPerHr.AutoSize = True
        Me.OptFlowLbPerHr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptFlowLbPerHr.ForeColor = System.Drawing.Color.White
        Me.OptFlowLbPerHr.Location = New System.Drawing.Point(29, 158)
        Me.OptFlowLbPerHr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptFlowLbPerHr.Name = "OptFlowLbPerHr"
        Me.OptFlowLbPerHr.Size = New System.Drawing.Size(76, 29)
        Me.OptFlowLbPerHr.TabIndex = 5
        Me.OptFlowLbPerHr.TabStop = True
        Me.OptFlowLbPerHr.Text = "lb/hr"
        Me.OptFlowLbPerHr.UseVisualStyleBackColor = True
        '
        'OptFlowKgPerHr
        '
        Me.OptFlowKgPerHr.AutoSize = True
        Me.OptFlowKgPerHr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptFlowKgPerHr.ForeColor = System.Drawing.Color.White
        Me.OptFlowKgPerHr.Location = New System.Drawing.Point(29, 130)
        Me.OptFlowKgPerHr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptFlowKgPerHr.Name = "OptFlowKgPerHr"
        Me.OptFlowKgPerHr.Size = New System.Drawing.Size(82, 29)
        Me.OptFlowKgPerHr.TabIndex = 4
        Me.OptFlowKgPerHr.TabStop = True
        Me.OptFlowKgPerHr.Text = "kg/hr"
        Me.OptFlowKgPerHr.UseVisualStyleBackColor = True
        '
        'OptFlowCfm
        '
        Me.OptFlowCfm.AutoSize = True
        Me.OptFlowCfm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptFlowCfm.ForeColor = System.Drawing.Color.White
        Me.OptFlowCfm.Location = New System.Drawing.Point(29, 102)
        Me.OptFlowCfm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptFlowCfm.Name = "OptFlowCfm"
        Me.OptFlowCfm.Size = New System.Drawing.Size(67, 29)
        Me.OptFlowCfm.TabIndex = 3
        Me.OptFlowCfm.TabStop = True
        Me.OptFlowCfm.Text = "cfm"
        Me.OptFlowCfm.UseVisualStyleBackColor = True
        '
        'OptFlowM3PerHr
        '
        Me.OptFlowM3PerHr.AutoSize = True
        Me.OptFlowM3PerHr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptFlowM3PerHr.ForeColor = System.Drawing.Color.White
        Me.OptFlowM3PerHr.Location = New System.Drawing.Point(29, 22)
        Me.OptFlowM3PerHr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptFlowM3PerHr.Name = "OptFlowM3PerHr"
        Me.OptFlowM3PerHr.Size = New System.Drawing.Size(84, 29)
        Me.OptFlowM3PerHr.TabIndex = 0
        Me.OptFlowM3PerHr.TabStop = True
        Me.OptFlowM3PerHr.Text = "m³/hr"
        Me.OptFlowM3PerHr.UseVisualStyleBackColor = True
        '
        'OptFlowM3PerMin
        '
        Me.OptFlowM3PerMin.AutoSize = True
        Me.OptFlowM3PerMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptFlowM3PerMin.ForeColor = System.Drawing.Color.White
        Me.OptFlowM3PerMin.Location = New System.Drawing.Point(29, 48)
        Me.OptFlowM3PerMin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptFlowM3PerMin.Name = "OptFlowM3PerMin"
        Me.OptFlowM3PerMin.Size = New System.Drawing.Size(99, 29)
        Me.OptFlowM3PerMin.TabIndex = 1
        Me.OptFlowM3PerMin.TabStop = True
        Me.OptFlowM3PerMin.Text = "m³/min"
        Me.OptFlowM3PerMin.UseVisualStyleBackColor = True
        '
        'OptFlowM3PerSec
        '
        Me.OptFlowM3PerSec.AutoSize = True
        Me.OptFlowM3PerSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptFlowM3PerSec.ForeColor = System.Drawing.Color.White
        Me.OptFlowM3PerSec.Location = New System.Drawing.Point(29, 74)
        Me.OptFlowM3PerSec.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptFlowM3PerSec.Name = "OptFlowM3PerSec"
        Me.OptFlowM3PerSec.Size = New System.Drawing.Size(99, 29)
        Me.OptFlowM3PerSec.TabIndex = 2
        Me.OptFlowM3PerSec.TabStop = True
        Me.OptFlowM3PerSec.Text = "m³/sec"
        Me.OptFlowM3PerSec.UseVisualStyleBackColor = True
        '
        'GroupBox14
        '
        Me.GroupBox14.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox14.Controls.Add(Me.OptPressuremmWG)
        Me.GroupBox14.Controls.Add(Me.OptPressureinWG)
        Me.GroupBox14.Controls.Add(Me.OptPressuremBar)
        Me.GroupBox14.Controls.Add(Me.OptPressurePa)
        Me.GroupBox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox14.ForeColor = System.Drawing.Color.White
        Me.GroupBox14.Location = New System.Drawing.Point(547, 249)
        Me.GroupBox14.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox14.Size = New System.Drawing.Size(200, 169)
        Me.GroupBox14.TabIndex = 15
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Pressure"
        '
        'OptPressuremmWG
        '
        Me.OptPressuremmWG.AutoSize = True
        Me.OptPressuremmWG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptPressuremmWG.ForeColor = System.Drawing.Color.White
        Me.OptPressuremmWG.Location = New System.Drawing.Point(23, 114)
        Me.OptPressuremmWG.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptPressuremmWG.Name = "OptPressuremmWG"
        Me.OptPressuremmWG.Size = New System.Drawing.Size(104, 29)
        Me.OptPressuremmWG.TabIndex = 3
        Me.OptPressuremmWG.TabStop = True
        Me.OptPressuremmWG.Text = "mmWG"
        Me.OptPressuremmWG.UseVisualStyleBackColor = True
        '
        'OptPressureinWG
        '
        Me.OptPressureinWG.AutoSize = True
        Me.OptPressureinWG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptPressureinWG.ForeColor = System.Drawing.Color.White
        Me.OptPressureinWG.Location = New System.Drawing.Point(23, 87)
        Me.OptPressureinWG.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptPressureinWG.Name = "OptPressureinWG"
        Me.OptPressureinWG.Size = New System.Drawing.Size(87, 29)
        Me.OptPressureinWG.TabIndex = 2
        Me.OptPressureinWG.TabStop = True
        Me.OptPressureinWG.Text = "inWG"
        Me.OptPressureinWG.UseVisualStyleBackColor = True
        '
        'OptPressuremBar
        '
        Me.OptPressuremBar.AutoSize = True
        Me.OptPressuremBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptPressuremBar.ForeColor = System.Drawing.Color.White
        Me.OptPressuremBar.Location = New System.Drawing.Point(23, 60)
        Me.OptPressuremBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptPressuremBar.Name = "OptPressuremBar"
        Me.OptPressuremBar.Size = New System.Drawing.Size(83, 29)
        Me.OptPressuremBar.TabIndex = 1
        Me.OptPressuremBar.TabStop = True
        Me.OptPressuremBar.Text = "mBar"
        Me.OptPressuremBar.UseVisualStyleBackColor = True
        '
        'OptPressurePa
        '
        Me.OptPressurePa.AutoSize = True
        Me.OptPressurePa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptPressurePa.ForeColor = System.Drawing.Color.White
        Me.OptPressurePa.Location = New System.Drawing.Point(23, 34)
        Me.OptPressurePa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptPressurePa.Name = "OptPressurePa"
        Me.OptPressurePa.Size = New System.Drawing.Size(59, 29)
        Me.OptPressurePa.TabIndex = 0
        Me.OptPressurePa.TabStop = True
        Me.OptPressurePa.Text = "Pa"
        Me.OptPressurePa.UseVisualStyleBackColor = True
        '
        'GroupBox15
        '
        Me.GroupBox15.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox15.Controls.Add(Me.OptDensityLbPerFt3)
        Me.GroupBox15.Controls.Add(Me.OptDensityKgPerM3)
        Me.GroupBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox15.ForeColor = System.Drawing.Color.White
        Me.GroupBox15.Location = New System.Drawing.Point(767, 30)
        Me.GroupBox15.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox15.Size = New System.Drawing.Size(200, 110)
        Me.GroupBox15.TabIndex = 16
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Density"
        '
        'OptDensityLbPerFt3
        '
        Me.OptDensityLbPerFt3.AutoSize = True
        Me.OptDensityLbPerFt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptDensityLbPerFt3.ForeColor = System.Drawing.Color.White
        Me.OptDensityLbPerFt3.Location = New System.Drawing.Point(23, 54)
        Me.OptDensityLbPerFt3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptDensityLbPerFt3.Name = "OptDensityLbPerFt3"
        Me.OptDensityLbPerFt3.Size = New System.Drawing.Size(77, 29)
        Me.OptDensityLbPerFt3.TabIndex = 1
        Me.OptDensityLbPerFt3.TabStop = True
        Me.OptDensityLbPerFt3.Text = "lb/ft³"
        Me.OptDensityLbPerFt3.UseVisualStyleBackColor = True
        '
        'OptDensityKgPerM3
        '
        Me.OptDensityKgPerM3.AutoSize = True
        Me.OptDensityKgPerM3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptDensityKgPerM3.ForeColor = System.Drawing.Color.White
        Me.OptDensityKgPerM3.Location = New System.Drawing.Point(23, 28)
        Me.OptDensityKgPerM3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptDensityKgPerM3.Name = "OptDensityKgPerM3"
        Me.OptDensityKgPerM3.Size = New System.Drawing.Size(88, 29)
        Me.OptDensityKgPerM3.TabIndex = 0
        Me.OptDensityKgPerM3.TabStop = True
        Me.OptDensityKgPerM3.Text = "kg/m³"
        Me.OptDensityKgPerM3.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(949, 540)
        Me.Button8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(251, 50)
        Me.Button8.TabIndex = 12
        Me.Button8.Text = "Duty Input >>"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'GrpFrequency
        '
        Me.GrpFrequency.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GrpFrequency.Controls.Add(Me.Opt50Hz)
        Me.GrpFrequency.Controls.Add(Me.Opt60Hz)
        Me.GrpFrequency.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpFrequency.ForeColor = System.Drawing.Color.White
        Me.GrpFrequency.Location = New System.Drawing.Point(35, 231)
        Me.GrpFrequency.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpFrequency.Name = "GrpFrequency"
        Me.GrpFrequency.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpFrequency.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpFrequency.Size = New System.Drawing.Size(439, 78)
        Me.GrpFrequency.TabIndex = 11
        Me.GrpFrequency.TabStop = False
        Me.GrpFrequency.Text = "Frequency (Hz)"
        '
        'Opt50Hz
        '
        Me.Opt50Hz.AutoSize = True
        Me.Opt50Hz.Checked = True
        Me.Opt50Hz.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opt50Hz.Location = New System.Drawing.Point(39, 30)
        Me.Opt50Hz.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Opt50Hz.Name = "Opt50Hz"
        Me.Opt50Hz.Size = New System.Drawing.Size(155, 29)
        Me.Opt50Hz.TabIndex = 5
        Me.Opt50Hz.TabStop = True
        Me.Opt50Hz.Text = "50 Hz (Nema)"
        Me.Opt50Hz.UseVisualStyleBackColor = True
        '
        'Opt60Hz
        '
        Me.Opt60Hz.AutoSize = True
        Me.Opt60Hz.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opt60Hz.Location = New System.Drawing.Point(240, 30)
        Me.Opt60Hz.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Opt60Hz.Name = "Opt60Hz"
        Me.Opt60Hz.Size = New System.Drawing.Size(84, 29)
        Me.Opt60Hz.TabIndex = 4
        Me.Opt60Hz.Text = "60 Hz"
        Me.Opt60Hz.UseVisualStyleBackColor = True
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
        Me.GrpEnvironment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpEnvironment.ForeColor = System.Drawing.Color.White
        Me.GrpEnvironment.Location = New System.Drawing.Point(35, 22)
        Me.GrpEnvironment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpEnvironment.Name = "GrpEnvironment"
        Me.GrpEnvironment.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpEnvironment.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpEnvironment.Size = New System.Drawing.Size(439, 177)
        Me.GrpEnvironment.TabIndex = 4
        Me.GrpEnvironment.TabStop = False
        Me.GrpEnvironment.Text = "Environment"
        '
        'LblAtmosphericPressureUnits
        '
        Me.LblAtmosphericPressureUnits.AutoSize = True
        Me.LblAtmosphericPressureUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAtmosphericPressureUnits.Location = New System.Drawing.Point(349, 112)
        Me.LblAtmosphericPressureUnits.Name = "LblAtmosphericPressureUnits"
        Me.LblAtmosphericPressureUnits.Size = New System.Drawing.Size(36, 25)
        Me.LblAtmosphericPressureUnits.TabIndex = 11
        Me.LblAtmosphericPressureUnits.Text = "Pa"
        Me.LblAtmosphericPressureUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblHumidityUnits
        '
        Me.LblHumidityUnits.AutoSize = True
        Me.LblHumidityUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHumidityUnits.Location = New System.Drawing.Point(349, 87)
        Me.LblHumidityUnits.Name = "LblHumidityUnits"
        Me.LblHumidityUnits.Size = New System.Drawing.Size(30, 25)
        Me.LblHumidityUnits.TabIndex = 10
        Me.LblHumidityUnits.Text = "%"
        Me.LblHumidityUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblAltitudeUnits
        '
        Me.LblAltitudeUnits.AutoSize = True
        Me.LblAltitudeUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAltitudeUnits.Location = New System.Drawing.Point(349, 58)
        Me.LblAltitudeUnits.Name = "LblAltitudeUnits"
        Me.LblAltitudeUnits.Size = New System.Drawing.Size(28, 25)
        Me.LblAltitudeUnits.TabIndex = 9
        Me.LblAltitudeUnits.Text = "m"
        Me.LblAltitudeUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblAmbientTemperatureUnits
        '
        Me.LblAmbientTemperatureUnits.AutoSize = True
        Me.LblAmbientTemperatureUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAmbientTemperatureUnits.Location = New System.Drawing.Point(349, 30)
        Me.LblAmbientTemperatureUnits.Name = "LblAmbientTemperatureUnits"
        Me.LblAmbientTemperatureUnits.Size = New System.Drawing.Size(35, 25)
        Me.LblAmbientTemperatureUnits.TabIndex = 8
        Me.LblAmbientTemperatureUnits.Text = "°C"
        Me.LblAmbientTemperatureUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtAtmosphericPressure
        '
        Me.TxtAtmosphericPressure.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAtmosphericPressure.Location = New System.Drawing.Point(251, 112)
        Me.TxtAtmosphericPressure.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtAtmosphericPressure.Name = "TxtAtmosphericPressure"
        Me.TxtAtmosphericPressure.Size = New System.Drawing.Size(83, 30)
        Me.TxtAtmosphericPressure.TabIndex = 7
        Me.TxtAtmosphericPressure.Text = "101325"
        '
        'TxtHumidity
        '
        Me.TxtHumidity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHumidity.Location = New System.Drawing.Point(251, 84)
        Me.TxtHumidity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtHumidity.Name = "TxtHumidity"
        Me.TxtHumidity.Size = New System.Drawing.Size(83, 30)
        Me.TxtHumidity.TabIndex = 6
        Me.TxtHumidity.Text = "0"
        '
        'TxtAltitude
        '
        Me.TxtAltitude.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAltitude.Location = New System.Drawing.Point(251, 57)
        Me.TxtAltitude.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtAltitude.Name = "TxtAltitude"
        Me.TxtAltitude.Size = New System.Drawing.Size(83, 30)
        Me.TxtAltitude.TabIndex = 5
        Me.TxtAltitude.Text = "0"
        '
        'TxtAmbientTemperature
        '
        Me.TxtAmbientTemperature.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAmbientTemperature.Location = New System.Drawing.Point(251, 28)
        Me.TxtAmbientTemperature.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtAmbientTemperature.Name = "TxtAmbientTemperature"
        Me.TxtAmbientTemperature.Size = New System.Drawing.Size(83, 30)
        Me.TxtAmbientTemperature.TabIndex = 4
        Me.TxtAmbientTemperature.Text = "20"
        '
        'LblAtmosphericPressure
        '
        Me.LblAtmosphericPressure.AutoSize = True
        Me.LblAtmosphericPressure.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAtmosphericPressure.Location = New System.Drawing.Point(27, 112)
        Me.LblAtmosphericPressure.Name = "LblAtmosphericPressure"
        Me.LblAtmosphericPressure.Size = New System.Drawing.Size(204, 25)
        Me.LblAtmosphericPressure.TabIndex = 3
        Me.LblAtmosphericPressure.Text = "Atmospheric Pressure"
        Me.LblAtmosphericPressure.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblHumidity
        '
        Me.LblHumidity.AutoSize = True
        Me.LblHumidity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHumidity.Location = New System.Drawing.Point(145, 84)
        Me.LblHumidity.Name = "LblHumidity"
        Me.LblHumidity.Size = New System.Drawing.Size(87, 25)
        Me.LblHumidity.TabIndex = 2
        Me.LblHumidity.Text = "Humidity"
        Me.LblHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblAltitude
        '
        Me.LblAltitude.AutoSize = True
        Me.LblAltitude.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAltitude.Location = New System.Drawing.Point(13, 58)
        Me.LblAltitude.Name = "LblAltitude"
        Me.LblAltitude.Size = New System.Drawing.Size(218, 25)
        Me.LblAltitude.TabIndex = 1
        Me.LblAltitude.Text = "Altitude above sea level"
        Me.LblAltitude.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblAmbientTemperature
        '
        Me.LblAmbientTemperature.AutoSize = True
        Me.LblAmbientTemperature.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAmbientTemperature.Location = New System.Drawing.Point(31, 30)
        Me.LblAmbientTemperature.Name = "LblAmbientTemperature"
        Me.LblAmbientTemperature.Size = New System.Drawing.Size(201, 25)
        Me.LblAmbientTemperature.TabIndex = 0
        Me.LblAmbientTemperature.Text = "Ambient Temperature"
        Me.LblAmbientTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPageDuty
        '
        Me.TabPageDuty.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TabPageDuty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPageDuty.Controls.Add(Me.Button10)
        Me.TabPageDuty.Controls.Add(Me.Button9)
        Me.TabPageDuty.Controls.Add(Me.Button7)
        Me.TabPageDuty.Controls.Add(Me.GrpFlowRate)
        Me.TabPageDuty.Controls.Add(Me.GroupBox2)
        Me.TabPageDuty.Controls.Add(Me.GroupBox1)
        Me.TabPageDuty.Controls.Add(Me.GrpDesignPressure)
        Me.TabPageDuty.Controls.Add(Me.GrpInletDensity)
        Me.TabPageDuty.Controls.Add(Me.Button2)
        Me.TabPageDuty.Controls.Add(Me.GrpInletTemperature)
        Me.TabPageDuty.Controls.Add(Me.Button1)
        Me.TabPageDuty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageDuty.Location = New System.Drawing.Point(4, 34)
        Me.TabPageDuty.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageDuty.Name = "TabPageDuty"
        Me.TabPageDuty.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageDuty.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabPageDuty.Size = New System.Drawing.Size(1247, 611)
        Me.TabPageDuty.TabIndex = 2
        Me.TabPageDuty.Text = "Duty Input"
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(691, 540)
        Me.Button10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(251, 50)
        Me.Button10.TabIndex = 15
        Me.Button10.Text = "Environment Info >>"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(949, 540)
        Me.Button9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(251, 50)
        Me.Button9.TabIndex = 14
        Me.Button9.Text = "<< Fan Parameters" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Enabled = False
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(836, 159)
        Me.Button7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(200, 50)
        Me.Button7.TabIndex = 13
        Me.Button7.Text = "Calculate Density"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'GrpFlowRate
        '
        Me.GrpFlowRate.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GrpFlowRate.Controls.Add(Me.LblFlowRateUnits)
        Me.GrpFlowRate.Controls.Add(Me.Txtflow)
        Me.GrpFlowRate.Controls.Add(Me.OptMassFlow)
        Me.GrpFlowRate.Controls.Add(Me.OptVolumeFlow)
        Me.GrpFlowRate.Controls.Add(Me.GroupBox6)
        Me.GrpFlowRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpFlowRate.ForeColor = System.Drawing.Color.White
        Me.GrpFlowRate.Location = New System.Drawing.Point(11, 22)
        Me.GrpFlowRate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpFlowRate.Name = "GrpFlowRate"
        Me.GrpFlowRate.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpFlowRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpFlowRate.Size = New System.Drawing.Size(341, 194)
        Me.GrpFlowRate.TabIndex = 5
        Me.GrpFlowRate.TabStop = False
        Me.GrpFlowRate.Text = "Flow Rate"
        '
        'LblFlowRateUnits
        '
        Me.LblFlowRateUnits.AutoSize = True
        Me.LblFlowRateUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFlowRateUnits.Location = New System.Drawing.Point(123, 62)
        Me.LblFlowRateUnits.Name = "LblFlowRateUnits"
        Me.LblFlowRateUnits.Size = New System.Drawing.Size(58, 25)
        Me.LblFlowRateUnits.TabIndex = 4
        Me.LblFlowRateUnits.Text = "m³/hr"
        '
        'Txtflow
        '
        Me.Txtflow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtflow.Location = New System.Drawing.Point(17, 62)
        Me.Txtflow.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txtflow.Name = "Txtflow"
        Me.Txtflow.Size = New System.Drawing.Size(100, 30)
        Me.Txtflow.TabIndex = 2
        Me.Txtflow.Text = "0"
        '
        'OptMassFlow
        '
        Me.OptMassFlow.AutoSize = True
        Me.OptMassFlow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptMassFlow.Location = New System.Drawing.Point(131, 32)
        Me.OptMassFlow.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptMassFlow.Name = "OptMassFlow"
        Me.OptMassFlow.Size = New System.Drawing.Size(81, 29)
        Me.OptMassFlow.TabIndex = 1
        Me.OptMassFlow.Text = "Mass"
        Me.OptMassFlow.UseVisualStyleBackColor = True
        '
        'OptVolumeFlow
        '
        Me.OptVolumeFlow.AutoSize = True
        Me.OptVolumeFlow.Checked = True
        Me.OptVolumeFlow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptVolumeFlow.Location = New System.Drawing.Point(17, 32)
        Me.OptVolumeFlow.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptVolumeFlow.Name = "OptVolumeFlow"
        Me.OptVolumeFlow.Size = New System.Drawing.Size(100, 29)
        Me.OptVolumeFlow.TabIndex = 0
        Me.OptVolumeFlow.TabStop = True
        Me.OptVolumeFlow.Text = "Volume"
        Me.OptVolumeFlow.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.OptFlowDischarge)
        Me.GroupBox6.Controls.Add(Me.OptFlowNominal)
        Me.GroupBox6.Controls.Add(Me.OpFlowInlet)
        Me.GroupBox6.Location = New System.Drawing.Point(0, 92)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox6.Size = New System.Drawing.Size(341, 100)
        Me.GroupBox6.TabIndex = 13
        Me.GroupBox6.TabStop = False
        '
        'OptFlowDischarge
        '
        Me.OptFlowDischarge.AutoSize = True
        Me.OptFlowDischarge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptFlowDischarge.Location = New System.Drawing.Point(17, 54)
        Me.OptFlowDischarge.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptFlowDischarge.Name = "OptFlowDischarge"
        Me.OptFlowDischarge.Size = New System.Drawing.Size(121, 29)
        Me.OptFlowDischarge.TabIndex = 5
        Me.OptFlowDischarge.Text = "Discharge"
        Me.OptFlowDischarge.UseVisualStyleBackColor = True
        '
        'OptFlowNominal
        '
        Me.OptFlowNominal.AutoSize = True
        Me.OptFlowNominal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptFlowNominal.Location = New System.Drawing.Point(131, 23)
        Me.OptFlowNominal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptFlowNominal.Name = "OptFlowNominal"
        Me.OptFlowNominal.Size = New System.Drawing.Size(104, 29)
        Me.OptFlowNominal.TabIndex = 4
        Me.OptFlowNominal.Text = "Nominal"
        Me.OptFlowNominal.UseVisualStyleBackColor = True
        '
        'OpFlowInlet
        '
        Me.OpFlowInlet.AutoSize = True
        Me.OpFlowInlet.Checked = True
        Me.OpFlowInlet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpFlowInlet.Location = New System.Drawing.Point(17, 23)
        Me.OpFlowInlet.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OpFlowInlet.Name = "OpFlowInlet"
        Me.OpFlowInlet.Size = New System.Drawing.Size(69, 29)
        Me.OpFlowInlet.TabIndex = 3
        Me.OpFlowInlet.TabStop = True
        Me.OpFlowInlet.Text = "Inlet"
        Me.OpFlowInlet.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Red
        Me.GroupBox2.Controls.Add(Me.OptXLS)
        Me.GroupBox2.Controls.Add(Me.OptTXT)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(419, 342)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Source"
        Me.GroupBox2.Visible = False
        '
        'OptXLS
        '
        Me.OptXLS.AutoSize = True
        Me.OptXLS.Location = New System.Drawing.Point(29, 64)
        Me.OptXLS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptXLS.Name = "OptXLS"
        Me.OptXLS.Size = New System.Drawing.Size(158, 29)
        Me.OptXLS.TabIndex = 1
        Me.OptXLS.TabStop = True
        Me.OptXLS.Text = "Use XLS Files"
        Me.OptXLS.UseVisualStyleBackColor = True
        '
        'OptTXT
        '
        Me.OptTXT.AutoSize = True
        Me.OptTXT.Checked = True
        Me.OptTXT.Location = New System.Drawing.Point(29, 25)
        Me.OptTXT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptTXT.Name = "OptTXT"
        Me.OptTXT.Size = New System.Drawing.Size(159, 29)
        Me.OptTXT.TabIndex = 0
        Me.OptTXT.TabStop = True
        Me.OptTXT.Text = "Use TXT Files"
        Me.OptTXT.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(419, 252)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(395, 71)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Discharge Duct"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(109, 30)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(68, 29)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Any"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(205, 30)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(81, 29)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.Text = "Fixed"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'GrpDesignPressure
        '
        Me.GrpDesignPressure.BackColor = System.Drawing.SystemColors.MenuHighlight
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
        Me.GrpDesignPressure.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpDesignPressure.ForeColor = System.Drawing.Color.White
        Me.GrpDesignPressure.Location = New System.Drawing.Point(11, 241)
        Me.GrpDesignPressure.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpDesignPressure.Name = "GrpDesignPressure"
        Me.GrpDesignPressure.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpDesignPressure.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpDesignPressure.Size = New System.Drawing.Size(341, 254)
        Me.GrpDesignPressure.TabIndex = 6
        Me.GrpDesignPressure.TabStop = False
        Me.GrpDesignPressure.Text = "Design Pressure (Pa)"
        '
        'Optsucy
        '
        Me.Optsucy.AutoSize = True
        Me.Optsucy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Optsucy.Location = New System.Drawing.Point(43, 202)
        Me.Optsucy.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Optsucy.Name = "Optsucy"
        Me.Optsucy.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Optsucy.Size = New System.Drawing.Size(183, 29)
        Me.Optsucy.TabIndex = 16
        Me.Optsucy.Text = "Suction Pressure"
        Me.Optsucy.UseVisualStyleBackColor = True
        Me.Optsucy.Visible = False
        '
        'CmbReserveHead
        '
        Me.CmbReserveHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbReserveHead.FormattingEnabled = True
        Me.CmbReserveHead.Items.AddRange(New Object() {"5%", "10%", "15%", "20%"})
        Me.CmbReserveHead.Location = New System.Drawing.Point(208, 162)
        Me.CmbReserveHead.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbReserveHead.Name = "CmbReserveHead"
        Me.CmbReserveHead.Size = New System.Drawing.Size(79, 33)
        Me.CmbReserveHead.TabIndex = 15
        Me.CmbReserveHead.Text = "5%"
        '
        'Txtfsp
        '
        Me.Txtfsp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtfsp.Location = New System.Drawing.Point(208, 132)
        Me.Txtfsp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txtfsp.Name = "Txtfsp"
        Me.Txtfsp.Size = New System.Drawing.Size(79, 30)
        Me.Txtfsp.TabIndex = 14
        Me.Txtfsp.Text = "0"
        '
        'TxtDischargePressure
        '
        Me.TxtDischargePressure.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDischargePressure.Location = New System.Drawing.Point(208, 103)
        Me.TxtDischargePressure.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDischargePressure.Name = "TxtDischargePressure"
        Me.TxtDischargePressure.Size = New System.Drawing.Size(79, 30)
        Me.TxtDischargePressure.TabIndex = 13
        Me.TxtDischargePressure.Text = "0"
        Me.TxtDischargePressure.Visible = False
        '
        'TxtInletPressure
        '
        Me.TxtInletPressure.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInletPressure.Location = New System.Drawing.Point(208, 74)
        Me.TxtInletPressure.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtInletPressure.Name = "TxtInletPressure"
        Me.TxtInletPressure.Size = New System.Drawing.Size(79, 30)
        Me.TxtInletPressure.TabIndex = 12
        Me.TxtInletPressure.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(53, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 25)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Reserve Head"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(57, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 25)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Pressure Rise"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(91, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 25)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Discharge"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(47, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 59)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Inlet Pressure (Gauge)"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OptStaticPressure
        '
        Me.OptStaticPressure.AutoSize = True
        Me.OptStaticPressure.Checked = True
        Me.OptStaticPressure.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptStaticPressure.Location = New System.Drawing.Point(21, 34)
        Me.OptStaticPressure.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptStaticPressure.Name = "OptStaticPressure"
        Me.OptStaticPressure.Size = New System.Drawing.Size(82, 29)
        Me.OptStaticPressure.TabIndex = 3
        Me.OptStaticPressure.TabStop = True
        Me.OptStaticPressure.Text = "Static"
        Me.OptStaticPressure.UseVisualStyleBackColor = True
        '
        'OptTotalPressure
        '
        Me.OptTotalPressure.AutoSize = True
        Me.OptTotalPressure.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptTotalPressure.Location = New System.Drawing.Point(149, 34)
        Me.OptTotalPressure.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptTotalPressure.Name = "OptTotalPressure"
        Me.OptTotalPressure.Size = New System.Drawing.Size(77, 29)
        Me.OptTotalPressure.TabIndex = 2
        Me.OptTotalPressure.Text = "Total"
        Me.OptTotalPressure.UseVisualStyleBackColor = True
        '
        'GrpInletDensity
        '
        Me.GrpInletDensity.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GrpInletDensity.Controls.Add(Me.OptDensityCalculated)
        Me.GrpInletDensity.Controls.Add(Me.OptDensityKnown)
        Me.GrpInletDensity.Controls.Add(Me.Txtdens)
        Me.GrpInletDensity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpInletDensity.ForeColor = System.Drawing.Color.White
        Me.GrpInletDensity.Location = New System.Drawing.Point(419, 134)
        Me.GrpInletDensity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpInletDensity.Name = "GrpInletDensity"
        Me.GrpInletDensity.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpInletDensity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpInletDensity.Size = New System.Drawing.Size(395, 82)
        Me.GrpInletDensity.TabIndex = 4
        Me.GrpInletDensity.TabStop = False
        Me.GrpInletDensity.Text = "Inlet Density (kg/m³)"
        '
        'OptDensityCalculated
        '
        Me.OptDensityCalculated.AutoSize = True
        Me.OptDensityCalculated.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptDensityCalculated.Location = New System.Drawing.Point(205, 34)
        Me.OptDensityCalculated.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptDensityCalculated.Name = "OptDensityCalculated"
        Me.OptDensityCalculated.Size = New System.Drawing.Size(126, 29)
        Me.OptDensityCalculated.TabIndex = 2
        Me.OptDensityCalculated.Text = "Calculated"
        Me.OptDensityCalculated.UseVisualStyleBackColor = True
        '
        'OptDensityKnown
        '
        Me.OptDensityKnown.AutoSize = True
        Me.OptDensityKnown.Checked = True
        Me.OptDensityKnown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptDensityKnown.Location = New System.Drawing.Point(109, 34)
        Me.OptDensityKnown.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptDensityKnown.Name = "OptDensityKnown"
        Me.OptDensityKnown.Size = New System.Drawing.Size(94, 29)
        Me.OptDensityKnown.TabIndex = 1
        Me.OptDensityKnown.TabStop = True
        Me.OptDensityKnown.Text = "Known"
        Me.OptDensityKnown.UseVisualStyleBackColor = True
        '
        'Txtdens
        '
        Me.Txtdens.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtdens.Location = New System.Drawing.Point(13, 34)
        Me.Txtdens.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txtdens.Name = "Txtdens"
        Me.Txtdens.Size = New System.Drawing.Size(75, 30)
        Me.Txtdens.TabIndex = 0
        Me.Txtdens.Text = "1.205"
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(11, 532)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 36)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "EXIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GrpInletTemperature
        '
        Me.GrpInletTemperature.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GrpInletTemperature.Controls.Add(Me.TxtMaximumTemperature)
        Me.GrpInletTemperature.Controls.Add(Me.LblMaximumTemperature)
        Me.GrpInletTemperature.Controls.Add(Me.LblDesignTemperature)
        Me.GrpInletTemperature.Controls.Add(Me.TxtDesignTemperature)
        Me.GrpInletTemperature.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpInletTemperature.ForeColor = System.Drawing.Color.White
        Me.GrpInletTemperature.Location = New System.Drawing.Point(419, 22)
        Me.GrpInletTemperature.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpInletTemperature.Name = "GrpInletTemperature"
        Me.GrpInletTemperature.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpInletTemperature.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpInletTemperature.Size = New System.Drawing.Size(395, 82)
        Me.GrpInletTemperature.TabIndex = 1
        Me.GrpInletTemperature.TabStop = False
        Me.GrpInletTemperature.Text = "Inlet Temperature (°C)"
        '
        'TxtMaximumTemperature
        '
        Me.TxtMaximumTemperature.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMaximumTemperature.Location = New System.Drawing.Point(261, 34)
        Me.TxtMaximumTemperature.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtMaximumTemperature.Name = "TxtMaximumTemperature"
        Me.TxtMaximumTemperature.Size = New System.Drawing.Size(53, 30)
        Me.TxtMaximumTemperature.TabIndex = 3
        Me.TxtMaximumTemperature.Text = "20"
        '
        'LblMaximumTemperature
        '
        Me.LblMaximumTemperature.AutoSize = True
        Me.LblMaximumTemperature.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMaximumTemperature.Location = New System.Drawing.Point(155, 36)
        Me.LblMaximumTemperature.Name = "LblMaximumTemperature"
        Me.LblMaximumTemperature.Size = New System.Drawing.Size(97, 25)
        Me.LblMaximumTemperature.TabIndex = 2
        Me.LblMaximumTemperature.Text = "Maximum"
        '
        'LblDesignTemperature
        '
        Me.LblDesignTemperature.AutoSize = True
        Me.LblDesignTemperature.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDesignTemperature.Location = New System.Drawing.Point(11, 36)
        Me.LblDesignTemperature.Name = "LblDesignTemperature"
        Me.LblDesignTemperature.Size = New System.Drawing.Size(73, 25)
        Me.LblDesignTemperature.TabIndex = 1
        Me.LblDesignTemperature.Text = "Design"
        '
        'TxtDesignTemperature
        '
        Me.TxtDesignTemperature.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDesignTemperature.Location = New System.Drawing.Point(93, 34)
        Me.TxtDesignTemperature.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDesignTemperature.Name = "TxtDesignTemperature"
        Me.TxtDesignTemperature.Size = New System.Drawing.Size(53, 30)
        Me.TxtDesignTemperature.TabIndex = 0
        Me.TxtDesignTemperature.Text = "20"
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(739, 506)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 36)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Select"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'TabPageFanParameters
        '
        Me.TabPageFanParameters.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TabPageFanParameters.Controls.Add(Me.Button12)
        Me.TabPageFanParameters.Controls.Add(Me.Button11)
        Me.TabPageFanParameters.Controls.Add(Me.GrpFanSize)
        Me.TabPageFanParameters.Controls.Add(Me.GrpFanSpeed)
        Me.TabPageFanParameters.Controls.Add(Me.GrpFanTypes)
        Me.TabPageFanParameters.Location = New System.Drawing.Point(4, 34)
        Me.TabPageFanParameters.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageFanParameters.Name = "TabPageFanParameters"
        Me.TabPageFanParameters.Size = New System.Drawing.Size(1247, 611)
        Me.TabPageFanParameters.TabIndex = 6
        Me.TabPageFanParameters.Text = "Fan Parameters"
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(949, 540)
        Me.Button12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(251, 50)
        Me.Button12.TabIndex = 20
        Me.Button12.Text = "Fan Selections >>"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(691, 540)
        Me.Button11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(251, 50)
        Me.Button11.TabIndex = 19
        Me.Button11.Text = "<< Duty Input"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'GrpFanSize
        '
        Me.GrpFanSize.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GrpFanSize.Controls.Add(Me.LblLengthUnits)
        Me.GrpFanSize.Controls.Add(Me.Txtfansize)
        Me.GrpFanSize.Controls.Add(Me.Lblfansize)
        Me.GrpFanSize.Controls.Add(Me.OptAnySize)
        Me.GrpFanSize.Controls.Add(Me.OptFixedSize)
        Me.GrpFanSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpFanSize.ForeColor = System.Drawing.Color.White
        Me.GrpFanSize.Location = New System.Drawing.Point(33, 183)
        Me.GrpFanSize.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpFanSize.Name = "GrpFanSize"
        Me.GrpFanSize.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpFanSize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpFanSize.Size = New System.Drawing.Size(963, 62)
        Me.GrpFanSize.TabIndex = 18
        Me.GrpFanSize.TabStop = False
        Me.GrpFanSize.Text = "Fan Size"
        '
        'LblLengthUnits
        '
        Me.LblLengthUnits.AutoSize = True
        Me.LblLengthUnits.Location = New System.Drawing.Point(819, 22)
        Me.LblLengthUnits.Name = "LblLengthUnits"
        Me.LblLengthUnits.Size = New System.Drawing.Size(46, 25)
        Me.LblLengthUnits.TabIndex = 8
        Me.LblLengthUnits.Text = "mm"
        '
        'Txtfansize
        '
        Me.Txtfansize.Location = New System.Drawing.Point(725, 17)
        Me.Txtfansize.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txtfansize.Name = "Txtfansize"
        Me.Txtfansize.Size = New System.Drawing.Size(81, 30)
        Me.Txtfansize.TabIndex = 7
        '
        'Lblfansize
        '
        Me.Lblfansize.AutoSize = True
        Me.Lblfansize.Location = New System.Drawing.Point(625, 22)
        Me.Lblfansize.Name = "Lblfansize"
        Me.Lblfansize.Size = New System.Drawing.Size(98, 25)
        Me.Lblfansize.TabIndex = 6
        Me.Lblfansize.Text = "Fan Size"
        '
        'OptAnySize
        '
        Me.OptAnySize.AutoSize = True
        Me.OptAnySize.Checked = True
        Me.OptAnySize.Location = New System.Drawing.Point(11, 22)
        Me.OptAnySize.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptAnySize.Name = "OptAnySize"
        Me.OptAnySize.Size = New System.Drawing.Size(120, 29)
        Me.OptAnySize.TabIndex = 5
        Me.OptAnySize.TabStop = True
        Me.OptAnySize.Text = "Any Size"
        Me.OptAnySize.UseVisualStyleBackColor = True
        '
        'OptFixedSize
        '
        Me.OptFixedSize.AutoSize = True
        Me.OptFixedSize.Location = New System.Drawing.Point(261, 22)
        Me.OptFixedSize.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptFixedSize.Name = "OptFixedSize"
        Me.OptFixedSize.Size = New System.Drawing.Size(135, 29)
        Me.OptFixedSize.TabIndex = 4
        Me.OptFixedSize.Text = "Fixed Size"
        Me.OptFixedSize.UseVisualStyleBackColor = True
        '
        'GrpFanSpeed
        '
        Me.GrpFanSpeed.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GrpFanSpeed.Controls.Add(Me.GrpPoleBox)
        Me.GrpFanSpeed.Controls.Add(Me.Txtfanspeed)
        Me.GrpFanSpeed.Controls.Add(Me.Label1)
        Me.GrpFanSpeed.Controls.Add(Me.Txtspeedlimit)
        Me.GrpFanSpeed.Controls.Add(Me.Label11)
        Me.GrpFanSpeed.Controls.Add(Me.OptFixedSpeed)
        Me.GrpFanSpeed.Controls.Add(Me.OptAnySpeed)
        Me.GrpFanSpeed.Controls.Add(Me.OptPoleSpeed)
        Me.GrpFanSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpFanSpeed.ForeColor = System.Drawing.Color.White
        Me.GrpFanSpeed.Location = New System.Drawing.Point(33, 28)
        Me.GrpFanSpeed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpFanSpeed.Name = "GrpFanSpeed"
        Me.GrpFanSpeed.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpFanSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpFanSpeed.Size = New System.Drawing.Size(963, 134)
        Me.GrpFanSpeed.TabIndex = 17
        Me.GrpFanSpeed.TabStop = False
        Me.GrpFanSpeed.Text = "Fan Speed"
        '
        'GrpPoleBox
        '
        Me.GrpPoleBox.Controls.Add(Me.Opt12Pole)
        Me.GrpPoleBox.Controls.Add(Me.Opt10Pole)
        Me.GrpPoleBox.Controls.Add(Me.Opt8Pole)
        Me.GrpPoleBox.Controls.Add(Me.Opt6Pole)
        Me.GrpPoleBox.Controls.Add(Me.Opt4Pole)
        Me.GrpPoleBox.Controls.Add(Me.Opt2Pole)
        Me.GrpPoleBox.Enabled = False
        Me.GrpPoleBox.Location = New System.Drawing.Point(245, 18)
        Me.GrpPoleBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpPoleBox.Name = "GrpPoleBox"
        Me.GrpPoleBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpPoleBox.Size = New System.Drawing.Size(315, 110)
        Me.GrpPoleBox.TabIndex = 11
        Me.GrpPoleBox.TabStop = False
        '
        'Opt12Pole
        '
        Me.Opt12Pole.AutoSize = True
        Me.Opt12Pole.Location = New System.Drawing.Point(167, 71)
        Me.Opt12Pole.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Opt12Pole.Name = "Opt12Pole"
        Me.Opt12Pole.Size = New System.Drawing.Size(106, 29)
        Me.Opt12Pole.TabIndex = 5
        Me.Opt12Pole.TabStop = True
        Me.Opt12Pole.Text = "12 Pole"
        Me.Opt12Pole.UseVisualStyleBackColor = True
        '
        'Opt10Pole
        '
        Me.Opt10Pole.AutoSize = True
        Me.Opt10Pole.Location = New System.Drawing.Point(167, 44)
        Me.Opt10Pole.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Opt10Pole.Name = "Opt10Pole"
        Me.Opt10Pole.Size = New System.Drawing.Size(106, 29)
        Me.Opt10Pole.TabIndex = 4
        Me.Opt10Pole.TabStop = True
        Me.Opt10Pole.Text = "10 Pole"
        Me.Opt10Pole.UseVisualStyleBackColor = True
        '
        'Opt8Pole
        '
        Me.Opt8Pole.AutoSize = True
        Me.Opt8Pole.Location = New System.Drawing.Point(167, 17)
        Me.Opt8Pole.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Opt8Pole.Name = "Opt8Pole"
        Me.Opt8Pole.Size = New System.Drawing.Size(94, 29)
        Me.Opt8Pole.TabIndex = 3
        Me.Opt8Pole.TabStop = True
        Me.Opt8Pole.Text = "8 Pole"
        Me.Opt8Pole.UseVisualStyleBackColor = True
        '
        'Opt6Pole
        '
        Me.Opt6Pole.AutoSize = True
        Me.Opt6Pole.Location = New System.Drawing.Point(13, 71)
        Me.Opt6Pole.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Opt6Pole.Name = "Opt6Pole"
        Me.Opt6Pole.Size = New System.Drawing.Size(94, 29)
        Me.Opt6Pole.TabIndex = 2
        Me.Opt6Pole.TabStop = True
        Me.Opt6Pole.Text = "6 Pole"
        Me.Opt6Pole.UseVisualStyleBackColor = True
        '
        'Opt4Pole
        '
        Me.Opt4Pole.AutoSize = True
        Me.Opt4Pole.Location = New System.Drawing.Point(13, 44)
        Me.Opt4Pole.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Opt4Pole.Name = "Opt4Pole"
        Me.Opt4Pole.Size = New System.Drawing.Size(94, 29)
        Me.Opt4Pole.TabIndex = 1
        Me.Opt4Pole.TabStop = True
        Me.Opt4Pole.Text = "4 Pole"
        Me.Opt4Pole.UseVisualStyleBackColor = True
        '
        'Opt2Pole
        '
        Me.Opt2Pole.AutoSize = True
        Me.Opt2Pole.Location = New System.Drawing.Point(13, 17)
        Me.Opt2Pole.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Opt2Pole.Name = "Opt2Pole"
        Me.Opt2Pole.Size = New System.Drawing.Size(94, 29)
        Me.Opt2Pole.TabIndex = 0
        Me.Opt2Pole.TabStop = True
        Me.Opt2Pole.Text = "2 Pole"
        Me.Opt2Pole.UseVisualStyleBackColor = True
        '
        'Txtfanspeed
        '
        Me.Txtfanspeed.Location = New System.Drawing.Point(817, 60)
        Me.Txtfanspeed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txtfanspeed.Name = "Txtfanspeed"
        Me.Txtfanspeed.Size = New System.Drawing.Size(89, 30)
        Me.Txtfanspeed.TabIndex = 10
        Me.Txtfanspeed.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(603, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Fan Speed (RPM)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txtspeedlimit
        '
        Me.Txtspeedlimit.Location = New System.Drawing.Point(817, 28)
        Me.Txtspeedlimit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txtspeedlimit.Name = "Txtspeedlimit"
        Me.Txtspeedlimit.Size = New System.Drawing.Size(89, 30)
        Me.Txtspeedlimit.TabIndex = 8
        Me.Txtspeedlimit.Text = "4000"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(603, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(190, 25)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Max Speed (RPM)"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OptFixedSpeed
        '
        Me.OptFixedSpeed.AutoSize = True
        Me.OptFixedSpeed.Location = New System.Drawing.Point(11, 58)
        Me.OptFixedSpeed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptFixedSpeed.Name = "OptFixedSpeed"
        Me.OptFixedSpeed.Size = New System.Drawing.Size(155, 29)
        Me.OptFixedSpeed.TabIndex = 6
        Me.OptFixedSpeed.Text = "Fixed Speed"
        Me.OptFixedSpeed.UseVisualStyleBackColor = True
        '
        'OptAnySpeed
        '
        Me.OptAnySpeed.AutoSize = True
        Me.OptAnySpeed.Checked = True
        Me.OptAnySpeed.Location = New System.Drawing.Point(11, 32)
        Me.OptAnySpeed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptAnySpeed.Name = "OptAnySpeed"
        Me.OptAnySpeed.Size = New System.Drawing.Size(140, 29)
        Me.OptAnySpeed.TabIndex = 5
        Me.OptAnySpeed.TabStop = True
        Me.OptAnySpeed.Text = "Any Speed"
        Me.OptAnySpeed.UseVisualStyleBackColor = True
        '
        'OptPoleSpeed
        '
        Me.OptPoleSpeed.AutoSize = True
        Me.OptPoleSpeed.Location = New System.Drawing.Point(11, 87)
        Me.OptPoleSpeed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptPoleSpeed.Name = "OptPoleSpeed"
        Me.OptPoleSpeed.Size = New System.Drawing.Size(145, 29)
        Me.OptPoleSpeed.TabIndex = 4
        Me.OptPoleSpeed.Text = "Pole Speed"
        Me.OptPoleSpeed.UseVisualStyleBackColor = True
        '
        'GrpFanTypes
        '
        Me.GrpFanTypes.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GrpFanTypes.Controls.Add(Me.ChkOldDesignFans)
        Me.GrpFanTypes.Controls.Add(Me.ChkAxialFans)
        Me.GrpFanTypes.Controls.Add(Me.ChkPlenumFans)
        Me.GrpFanTypes.Controls.Add(Me.ChkPlasticFan)
        Me.GrpFanTypes.Controls.Add(Me.ChkOtherFanType)
        Me.GrpFanTypes.Controls.Add(Me.ChkInclineBlade)
        Me.GrpFanTypes.Controls.Add(Me.ChkCurveBlade)
        Me.GrpFanTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpFanTypes.ForeColor = System.Drawing.Color.White
        Me.GrpFanTypes.Location = New System.Drawing.Point(33, 278)
        Me.GrpFanTypes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpFanTypes.Name = "GrpFanTypes"
        Me.GrpFanTypes.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpFanTypes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpFanTypes.Size = New System.Drawing.Size(963, 126)
        Me.GrpFanTypes.TabIndex = 16
        Me.GrpFanTypes.TabStop = False
        Me.GrpFanTypes.Text = "Fan Types"
        '
        'ChkOldDesignFans
        '
        Me.ChkOldDesignFans.AutoSize = True
        Me.ChkOldDesignFans.Location = New System.Drawing.Point(699, 28)
        Me.ChkOldDesignFans.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChkOldDesignFans.Name = "ChkOldDesignFans"
        Me.ChkOldDesignFans.Size = New System.Drawing.Size(141, 29)
        Me.ChkOldDesignFans.TabIndex = 6
        Me.ChkOldDesignFans.Text = "Old Design"
        Me.ChkOldDesignFans.UseVisualStyleBackColor = True
        Me.ChkOldDesignFans.Visible = False
        '
        'ChkAxialFans
        '
        Me.ChkAxialFans.AutoSize = True
        Me.ChkAxialFans.Location = New System.Drawing.Point(451, 71)
        Me.ChkAxialFans.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChkAxialFans.Name = "ChkAxialFans"
        Me.ChkAxialFans.Size = New System.Drawing.Size(82, 29)
        Me.ChkAxialFans.TabIndex = 5
        Me.ChkAxialFans.Text = "Axial"
        Me.ChkAxialFans.UseVisualStyleBackColor = True
        Me.ChkAxialFans.Visible = False
        '
        'ChkPlenumFans
        '
        Me.ChkPlenumFans.AutoSize = True
        Me.ChkPlenumFans.Location = New System.Drawing.Point(451, 28)
        Me.ChkPlenumFans.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChkPlenumFans.Name = "ChkPlenumFans"
        Me.ChkPlenumFans.Size = New System.Drawing.Size(160, 29)
        Me.ChkPlenumFans.TabIndex = 4
        Me.ChkPlenumFans.Text = "Plenum Fans"
        Me.ChkPlenumFans.UseVisualStyleBackColor = True
        Me.ChkPlenumFans.Visible = False
        '
        'ChkPlasticFan
        '
        Me.ChkPlasticFan.AutoSize = True
        Me.ChkPlasticFan.Location = New System.Drawing.Point(251, 71)
        Me.ChkPlasticFan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChkPlasticFan.Name = "ChkPlasticFan"
        Me.ChkPlasticFan.Size = New System.Drawing.Size(98, 29)
        Me.ChkPlasticFan.TabIndex = 3
        Me.ChkPlasticFan.Text = "Plastic"
        Me.ChkPlasticFan.UseVisualStyleBackColor = True
        '
        'ChkOtherFanType
        '
        Me.ChkOtherFanType.AutoSize = True
        Me.ChkOtherFanType.Location = New System.Drawing.Point(253, 28)
        Me.ChkOtherFanType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChkOtherFanType.Name = "ChkOtherFanType"
        Me.ChkOtherFanType.Size = New System.Drawing.Size(88, 29)
        Me.ChkOtherFanType.TabIndex = 2
        Me.ChkOtherFanType.Text = "Other"
        Me.ChkOtherFanType.UseVisualStyleBackColor = True
        '
        'ChkInclineBlade
        '
        Me.ChkInclineBlade.AutoSize = True
        Me.ChkInclineBlade.Checked = True
        Me.ChkInclineBlade.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkInclineBlade.Location = New System.Drawing.Point(21, 71)
        Me.ChkInclineBlade.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChkInclineBlade.Name = "ChkInclineBlade"
        Me.ChkInclineBlade.Size = New System.Drawing.Size(158, 29)
        Me.ChkInclineBlade.TabIndex = 1
        Me.ChkInclineBlade.Text = "Incline Blade"
        Me.ChkInclineBlade.UseVisualStyleBackColor = True
        '
        'ChkCurveBlade
        '
        Me.ChkCurveBlade.AutoSize = True
        Me.ChkCurveBlade.Checked = True
        Me.ChkCurveBlade.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkCurveBlade.Location = New System.Drawing.Point(21, 28)
        Me.ChkCurveBlade.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChkCurveBlade.Name = "ChkCurveBlade"
        Me.ChkCurveBlade.Size = New System.Drawing.Size(153, 29)
        Me.ChkCurveBlade.TabIndex = 0
        Me.ChkCurveBlade.Text = "Curve Blade"
        Me.ChkCurveBlade.UseVisualStyleBackColor = True
        '
        'TabPageSelection
        '
        Me.TabPageSelection.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TabPageSelection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPageSelection.Controls.Add(Me.Label19)
        Me.TabPageSelection.Controls.Add(Me.Button14)
        Me.TabPageSelection.Controls.Add(Me.Button13)
        Me.TabPageSelection.Controls.Add(Me.LblFanDetails)
        Me.TabPageSelection.Controls.Add(Me.Label3)
        Me.TabPageSelection.Controls.Add(Me.BtnClose)
        Me.TabPageSelection.Controls.Add(Me.Button4)
        Me.TabPageSelection.Controls.Add(Me.LblGasDensityUnit)
        Me.TabPageSelection.Controls.Add(Me.Label2)
        Me.TabPageSelection.Controls.Add(Me.TxtDensity)
        Me.TabPageSelection.Controls.Add(Me.Button3)
        Me.TabPageSelection.Controls.Add(Me.DataGridView1)
        Me.TabPageSelection.Location = New System.Drawing.Point(4, 34)
        Me.TabPageSelection.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageSelection.Name = "TabPageSelection"
        Me.TabPageSelection.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageSelection.Size = New System.Drawing.Size(1247, 602)
        Me.TabPageSelection.TabIndex = 1
        Me.TabPageSelection.Text = "Selections"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(56, 514)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(115, 25)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "FanDetails"
        Me.Label19.Visible = False
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(691, 540)
        Me.Button14.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(251, 50)
        Me.Button14.TabIndex = 16
        Me.Button14.Text = "<< Fan Parameters"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Enabled = False
        Me.Button13.Location = New System.Drawing.Point(949, 540)
        Me.Button13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(251, 50)
        Me.Button13.TabIndex = 15
        Me.Button13.Text = "Noise Data >>"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'LblFanDetails
        '
        Me.LblFanDetails.AutoSize = True
        Me.LblFanDetails.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.LblFanDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFanDetails.ForeColor = System.Drawing.Color.White
        Me.LblFanDetails.Location = New System.Drawing.Point(243, 30)
        Me.LblFanDetails.Name = "LblFanDetails"
        Me.LblFanDetails.Size = New System.Drawing.Size(115, 25)
        Me.LblFanDetails.TabIndex = 4
        Me.LblFanDetails.Text = "FanDetails"
        Me.LblFanDetails.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(29, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Selected Fan"
        Me.Label3.Visible = False
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.Black
        Me.BtnClose.Location = New System.Drawing.Point(299, 559)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(89, 34)
        Me.BtnClose.TabIndex = 14
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(191, 559)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(89, 34)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "End"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'LblGasDensityUnit
        '
        Me.LblGasDensityUnit.AutoSize = True
        Me.LblGasDensityUnit.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.LblGasDensityUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGasDensityUnit.ForeColor = System.Drawing.Color.White
        Me.LblGasDensityUnit.Location = New System.Drawing.Point(997, 30)
        Me.LblGasDensityUnit.Name = "LblGasDensityUnit"
        Me.LblGasDensityUnit.Size = New System.Drawing.Size(51, 18)
        Me.LblGasDensityUnit.TabIndex = 13
        Me.LblGasDensityUnit.Text = "kg/m³"
        Me.LblGasDensityUnit.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(771, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 18)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Gas Density"
        Me.Label2.Visible = False
        '
        'TxtDensity
        '
        Me.TxtDensity.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TxtDensity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDensity.ForeColor = System.Drawing.Color.White
        Me.TxtDensity.Location = New System.Drawing.Point(891, 26)
        Me.TxtDensity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDensity.Name = "TxtDensity"
        Me.TxtDensity.Size = New System.Drawing.Size(100, 24)
        Me.TxtDensity.TabIndex = 11
        Me.TxtDensity.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(611, 22)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 34)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "txt Files"
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(19, 74)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1159, 153)
        Me.DataGridView1.TabIndex = 8
        '
        'TabPageNoise
        '
        Me.TabPageNoise.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TabPageNoise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPageNoise.Controls.Add(Me.Button16)
        Me.TabPageNoise.Controls.Add(Me.Button15)
        Me.TabPageNoise.Controls.Add(Me.Button5)
        Me.TabPageNoise.Controls.Add(Me.Button6)
        Me.TabPageNoise.Controls.Add(Me.DataGridView2)
        Me.TabPageNoise.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPageNoise.Controls.Add(Me.GroupBox4)
        Me.TabPageNoise.Controls.Add(Me.GroupBox3)
        Me.TabPageNoise.Controls.Add(Me.TxtTypenoise)
        Me.TabPageNoise.Controls.Add(Me.Label18)
        Me.TabPageNoise.Controls.Add(Me.Label15)
        Me.TabPageNoise.Controls.Add(Me.TxtSizenoise)
        Me.TabPageNoise.Controls.Add(Me.Label16)
        Me.TabPageNoise.Controls.Add(Me.Label13)
        Me.TabPageNoise.Controls.Add(Me.TxtPressurenoise)
        Me.TabPageNoise.Controls.Add(Me.Label14)
        Me.TabPageNoise.Controls.Add(Me.Label6)
        Me.TabPageNoise.Controls.Add(Me.TxtSpeednoise)
        Me.TabPageNoise.Controls.Add(Me.Label12)
        Me.TabPageNoise.Controls.Add(Me.Label5)
        Me.TabPageNoise.Controls.Add(Me.TxtFlownoise)
        Me.TabPageNoise.Controls.Add(Me.Label4)
        Me.TabPageNoise.Controls.Add(Me.GroupBox5)
        Me.TabPageNoise.Location = New System.Drawing.Point(4, 34)
        Me.TabPageNoise.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageNoise.Name = "TabPageNoise"
        Me.TabPageNoise.Size = New System.Drawing.Size(1247, 611)
        Me.TabPageNoise.TabIndex = 3
        Me.TabPageNoise.Text = "Noise"
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(691, 540)
        Me.Button16.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(251, 50)
        Me.Button16.TabIndex = 22
        Me.Button16.Text = "<< Fan Selections"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(949, 540)
        Me.Button15.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(251, 50)
        Me.Button15.TabIndex = 21
        Me.Button15.Text = "Save Project >>"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(147, 559)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(89, 34)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "Close"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(51, 559)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(89, 34)
        Me.Button6.TabIndex = 19
        Me.Button6.Text = "End"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(428, 352)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(744, 172)
        Me.DataGridView2.TabIndex = 17
        Me.DataGridView2.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 9
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(428, 14)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 13
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(744, 324)
        Me.TableLayoutPanel1.TabIndex = 16
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.TextBox6)
        Me.GroupBox4.Controls.Add(Me.OptMotor)
        Me.GroupBox4.Controls.Add(Me.OptBrg)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(11, 292)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(371, 100)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Extra Data"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(229, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 18)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "db(A)"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(159, 60)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(63, 24)
        Me.TextBox6.TabIndex = 2
        '
        'OptMotor
        '
        Me.OptMotor.AutoSize = True
        Me.OptMotor.Location = New System.Drawing.Point(19, 62)
        Me.OptMotor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptMotor.Name = "OptMotor"
        Me.OptMotor.Size = New System.Drawing.Size(124, 22)
        Me.OptMotor.TabIndex = 1
        Me.OptMotor.Text = "Motor Noise"
        Me.OptMotor.UseVisualStyleBackColor = True
        '
        'OptBrg
        '
        Me.OptBrg.AutoSize = True
        Me.OptBrg.Location = New System.Drawing.Point(19, 30)
        Me.OptBrg.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptBrg.Name = "OptBrg"
        Me.OptBrg.Size = New System.Drawing.Size(136, 22)
        Me.OptBrg.TabIndex = 0
        Me.OptBrg.Text = "Bearing Noise"
        Me.OptBrg.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox3.Controls.Add(Me.OptOpenOutlet)
        Me.GroupBox3.Controls.Add(Me.OptOpenInlet)
        Me.GroupBox3.Controls.Add(Me.OptDuct)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(11, 162)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(371, 124)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Operating Conditions"
        '
        'OptOpenOutlet
        '
        Me.OptOpenOutlet.AutoSize = True
        Me.OptOpenOutlet.Location = New System.Drawing.Point(19, 86)
        Me.OptOpenOutlet.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptOpenOutlet.Name = "OptOpenOutlet"
        Me.OptOpenOutlet.Size = New System.Drawing.Size(223, 22)
        Me.OptOpenOutlet.TabIndex = 2
        Me.OptOpenOutlet.Text = "Ducted inlet && open outlet"
        Me.OptOpenOutlet.UseVisualStyleBackColor = True
        '
        'OptOpenInlet
        '
        Me.OptOpenInlet.AutoSize = True
        Me.OptOpenInlet.Location = New System.Drawing.Point(19, 60)
        Me.OptOpenInlet.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptOpenInlet.Name = "OptOpenInlet"
        Me.OptOpenInlet.Size = New System.Drawing.Size(223, 22)
        Me.OptOpenInlet.TabIndex = 1
        Me.OptOpenInlet.Text = "Open inlet && ducted outlet"
        Me.OptOpenInlet.UseVisualStyleBackColor = True
        '
        'OptDuct
        '
        Me.OptDuct.AutoSize = True
        Me.OptDuct.Checked = True
        Me.OptDuct.Location = New System.Drawing.Point(19, 32)
        Me.OptDuct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptDuct.Name = "OptDuct"
        Me.OptDuct.Size = New System.Drawing.Size(181, 22)
        Me.OptDuct.TabIndex = 0
        Me.OptDuct.TabStop = True
        Me.OptDuct.Text = "Ducted inlet && outlet"
        Me.OptDuct.UseVisualStyleBackColor = True
        '
        'TxtTypenoise
        '
        Me.TxtTypenoise.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TxtTypenoise.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTypenoise.ForeColor = System.Drawing.Color.White
        Me.TxtTypenoise.Location = New System.Drawing.Point(201, 118)
        Me.TxtTypenoise.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTypenoise.Name = "TxtTypenoise"
        Me.TxtTypenoise.ReadOnly = True
        Me.TxtTypenoise.Size = New System.Drawing.Size(93, 24)
        Me.TxtTypenoise.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(25, 122)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(77, 18)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "Fan Type"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(304, 98)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 18)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "ins"
        '
        'TxtSizenoise
        '
        Me.TxtSizenoise.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TxtSizenoise.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSizenoise.ForeColor = System.Drawing.Color.White
        Me.TxtSizenoise.Location = New System.Drawing.Point(201, 94)
        Me.TxtSizenoise.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtSizenoise.Name = "TxtSizenoise"
        Me.TxtSizenoise.ReadOnly = True
        Me.TxtSizenoise.Size = New System.Drawing.Size(93, 24)
        Me.TxtSizenoise.TabIndex = 10
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(25, 98)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 18)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Fan Size"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(304, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 18)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Pa"
        '
        'TxtPressurenoise
        '
        Me.TxtPressurenoise.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TxtPressurenoise.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPressurenoise.ForeColor = System.Drawing.Color.White
        Me.TxtPressurenoise.Location = New System.Drawing.Point(201, 46)
        Me.TxtPressurenoise.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtPressurenoise.Name = "TxtPressurenoise"
        Me.TxtPressurenoise.ReadOnly = True
        Me.TxtPressurenoise.Size = New System.Drawing.Size(93, 24)
        Me.TxtPressurenoise.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(25, 50)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(157, 18)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Fan Static Pressure"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(304, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "RPM"
        '
        'TxtSpeednoise
        '
        Me.TxtSpeednoise.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TxtSpeednoise.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSpeednoise.ForeColor = System.Drawing.Color.White
        Me.TxtSpeednoise.Location = New System.Drawing.Point(201, 68)
        Me.TxtSpeednoise.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtSpeednoise.Name = "TxtSpeednoise"
        Me.TxtSpeednoise.ReadOnly = True
        Me.TxtSpeednoise.Size = New System.Drawing.Size(93, 24)
        Me.TxtSpeednoise.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(25, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 18)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Fan Speed"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(304, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 18)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "m³/hr"
        '
        'TxtFlownoise
        '
        Me.TxtFlownoise.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TxtFlownoise.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFlownoise.ForeColor = System.Drawing.Color.White
        Me.TxtFlownoise.Location = New System.Drawing.Point(201, 22)
        Me.TxtFlownoise.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtFlownoise.Name = "TxtFlownoise"
        Me.TxtFlownoise.ReadOnly = True
        Me.TxtFlownoise.Size = New System.Drawing.Size(93, 24)
        Me.TxtFlownoise.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(25, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Volume Flow"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(11, 9)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(371, 146)
        Me.GroupBox5.TabIndex = 18
        Me.GroupBox5.TabStop = False
        '
        'TabPageImpeller
        '
        Me.TabPageImpeller.Location = New System.Drawing.Point(4, 34)
        Me.TabPageImpeller.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageImpeller.Name = "TabPageImpeller"
        Me.TabPageImpeller.Size = New System.Drawing.Size(1247, 611)
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
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1255, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.OpenProjectToolStripMenuItem, Me.SaveProjectToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.PrintToolStripMenuItem, Me.ExitProjectToolStripMenuItem})
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
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(170, 26)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Preview"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(170, 26)
        Me.PrintToolStripMenuItem.Text = "Print"
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
        Me.PictureBox1.Location = New System.Drawing.Point(991, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(277, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Frmselectfan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(1255, 668)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1273, 715)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1221, 715)
        Me.Name = "Frmselectfan"
        Me.Text = "Halifax Fan Selection Software"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageEnvironment.ResumeLayout(False)
        Me.TabPageEnvironment.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.GrpFrequency.ResumeLayout(False)
        Me.GrpFrequency.PerformLayout()
        Me.GrpEnvironment.ResumeLayout(False)
        Me.GrpEnvironment.PerformLayout()
        Me.TabPageDuty.ResumeLayout(False)
        Me.GrpFlowRate.ResumeLayout(False)
        Me.GrpFlowRate.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GrpDesignPressure.ResumeLayout(False)
        Me.GrpDesignPressure.PerformLayout()
        Me.GrpInletDensity.ResumeLayout(False)
        Me.GrpInletDensity.PerformLayout()
        Me.GrpInletTemperature.ResumeLayout(False)
        Me.GrpInletTemperature.PerformLayout()
        Me.TabPageFanParameters.ResumeLayout(False)
        Me.GrpFanSize.ResumeLayout(False)
        Me.GrpFanSize.PerformLayout()
        Me.GrpFanSpeed.ResumeLayout(False)
        Me.GrpFanSpeed.PerformLayout()
        Me.GrpPoleBox.ResumeLayout(False)
        Me.GrpPoleBox.PerformLayout()
        Me.GrpFanTypes.ResumeLayout(False)
        Me.GrpFanTypes.PerformLayout()
        Me.TabPageSelection.ResumeLayout(False)
        Me.TabPageSelection.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageNoise.ResumeLayout(False)
        Me.TabPageNoise.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CmbReserveHead As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblFlowRateUnits As Label
    Friend WithEvents ProjectDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnitsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Optsucy As CheckBox
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
    Friend WithEvents Label3 As Label
    Friend WithEvents LblFanDetails As Label
    Friend WithEvents TxtTypenoise As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtSizenoise As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtPressurenoise As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtSpeednoise As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtFlownoise As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents OptOpenOutlet As RadioButton
    Friend WithEvents OptOpenInlet As RadioButton
    Friend WithEvents OptDuct As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents OptMotor As CheckBox
    Friend WithEvents OptBrg As CheckBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TabPageEnvironment As TabPage
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
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents PrintPreviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TabPageFanParameters As TabPage
    Friend WithEvents GrpFanTypes As GroupBox
    Friend WithEvents ChkOldDesignFans As CheckBox
    Friend WithEvents ChkAxialFans As CheckBox
    Friend WithEvents ChkPlenumFans As CheckBox
    Friend WithEvents ChkPlasticFan As CheckBox
    Friend WithEvents ChkOtherFanType As CheckBox
    Friend WithEvents ChkInclineBlade As CheckBox
    Friend WithEvents ChkCurveBlade As CheckBox
    Friend WithEvents GrpFanSize As GroupBox
    Friend WithEvents LblLengthUnits As Label
    Friend WithEvents Txtfansize As TextBox
    Friend WithEvents Lblfansize As Label
    Friend WithEvents OptAnySize As RadioButton
    Friend WithEvents OptFixedSize As RadioButton
    Friend WithEvents GrpFanSpeed As GroupBox
    Friend WithEvents GrpPoleBox As GroupBox
    Friend WithEvents Opt12Pole As RadioButton
    Friend WithEvents Opt10Pole As RadioButton
    Friend WithEvents Opt8Pole As RadioButton
    Friend WithEvents Opt6Pole As RadioButton
    Friend WithEvents Opt4Pole As RadioButton
    Friend WithEvents Opt2Pole As RadioButton
    Friend WithEvents Txtfanspeed As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txtspeedlimit As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents OptFixedSpeed As RadioButton
    Friend WithEvents OptAnySpeed As RadioButton
    Friend WithEvents OptPoleSpeed As RadioButton
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents OptVelocityFtpermin As RadioButton
    Friend WithEvents OptVelocityMpers As RadioButton
    Friend WithEvents BtnExit As Button
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents OptPowerHp As RadioButton
    Friend WithEvents OptPowerKW As RadioButton
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents OptDefaultImperial As RadioButton
    Friend WithEvents OptDefaultMetric As RadioButton
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents OptAltitudeFt As RadioButton
    Friend WithEvents OptAltitudeM As RadioButton
    Friend WithEvents BtnCancel As Button
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents OptLengthIn As RadioButton
    Friend WithEvents OptLengthMm As RadioButton
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents OptTemperatureF As RadioButton
    Friend WithEvents OptTemperatureC As RadioButton
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents OptFlowLbPerHr As RadioButton
    Friend WithEvents OptFlowKgPerHr As RadioButton
    Friend WithEvents OptFlowCfm As RadioButton
    Friend WithEvents OptFlowM3PerHr As RadioButton
    Friend WithEvents OptFlowM3PerMin As RadioButton
    Friend WithEvents OptFlowM3PerSec As RadioButton
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents OptPressuremmWG As RadioButton
    Friend WithEvents OptPressureinWG As RadioButton
    Friend WithEvents OptPressuremBar As RadioButton
    Friend WithEvents OptPressurePa As RadioButton
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents OptDensityLbPerFt3 As RadioButton
    Friend WithEvents OptDensityKgPerM3 As RadioButton
    Friend WithEvents OptDefaultNone As RadioButton
    Friend WithEvents Button18 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Label19 As Label
End Class
