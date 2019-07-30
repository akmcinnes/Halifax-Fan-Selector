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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmselectfan))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageGeneral = New System.Windows.Forms.TabPage()
        Me.lblSaveProject = New System.Windows.Forms.Label()
        Me.lblDisplayBoth = New System.Windows.Forms.Label()
        Me.lblChkAtmosAlt = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnGeneralExit = New System.Windows.Forms.Button()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.OptVelocityFtpermin = New System.Windows.Forms.RadioButton()
        Me.OptVelocityMpers = New System.Windows.Forms.RadioButton()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.OptPowerBoth = New System.Windows.Forms.RadioButton()
        Me.OptPowerHp = New System.Windows.Forms.RadioButton()
        Me.OptPowerKW = New System.Windows.Forms.RadioButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btnImperialUnits = New System.Windows.Forms.Button()
        Me.btnMetricUnits = New System.Windows.Forms.Button()
        Me.OptDefaultNone = New System.Windows.Forms.RadioButton()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.OptAltitudeFt = New System.Windows.Forms.RadioButton()
        Me.OptAltitudeM = New System.Windows.Forms.RadioButton()
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
        Me.OptPressurekPa = New System.Windows.Forms.RadioButton()
        Me.OptPressuremmWG = New System.Windows.Forms.RadioButton()
        Me.OptPressureinWG = New System.Windows.Forms.RadioButton()
        Me.OptPressuremBar = New System.Windows.Forms.RadioButton()
        Me.OptPressurePa = New System.Windows.Forms.RadioButton()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.OptDensityLbPerFt3 = New System.Windows.Forms.RadioButton()
        Me.OptDensityKgPerM3 = New System.Windows.Forms.RadioButton()
        Me.btnDutyInputForward = New System.Windows.Forms.Button()
        Me.GrpFrequency = New System.Windows.Forms.GroupBox()
        Me.Opt50Hz = New System.Windows.Forms.RadioButton()
        Me.Opt60Hz = New System.Windows.Forms.RadioButton()
        Me.GrpGeneral = New System.Windows.Forms.GroupBox()
        Me.chkCalcAtmos = New System.Windows.Forms.CheckBox()
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
        Me.lblMassFlow = New System.Windows.Forms.Label()
        Me.lblVolumeFlow = New System.Windows.Forms.Label()
        Me.btnGeneralInformationBack = New System.Windows.Forms.Button()
        Me.LblFlowRateUnits = New System.Windows.Forms.Label()
        Me.btnFanParametersForward = New System.Windows.Forms.Button()
        Me.btnCalculateDensity = New System.Windows.Forms.Button()
        Me.GrpFlowRate = New System.Windows.Forms.GroupBox()
        Me.lblFlowType = New System.Windows.Forms.Label()
        Me.Txtflow = New System.Windows.Forms.TextBox()
        Me.OptMassFlow = New System.Windows.Forms.RadioButton()
        Me.OptVolumeFlow = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.OptFlowDischarge = New System.Windows.Forms.RadioButton()
        Me.OptFlowNominal = New System.Windows.Forms.RadioButton()
        Me.OpFlowInlet = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblpercent = New System.Windows.Forms.Label()
        Me.lblUserDefinedUnits = New System.Windows.Forms.Label()
        Me.txtRatioDD = New System.Windows.Forms.TextBox()
        Me.txtUserDefinedDD = New System.Windows.Forms.TextBox()
        Me.optDDUserDefined = New System.Windows.Forms.RadioButton()
        Me.optDDStandard = New System.Windows.Forms.RadioButton()
        Me.optDDRatio = New System.Windows.Forms.RadioButton()
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
        Me.btnDutyExit = New System.Windows.Forms.Button()
        Me.GrpInletTemperature = New System.Windows.Forms.GroupBox()
        Me.TxtMaximumTemperature = New System.Windows.Forms.TextBox()
        Me.LblMaximumTemperature = New System.Windows.Forms.Label()
        Me.LblDesignTemperature = New System.Windows.Forms.Label()
        Me.TxtDesignTemperature = New System.Windows.Forms.TextBox()
        Me.TabPageFanParameters = New System.Windows.Forms.TabPage()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.chkDIDW = New System.Windows.Forms.CheckBox()
        Me.btnDutyInputBack = New System.Windows.Forms.Button()
        Me.btnParametersExit = New System.Windows.Forms.Button()
        Me.btnFanSelectionsForward = New System.Windows.Forms.Button()
        Me.GrpFanSize = New System.Windows.Forms.GroupBox()
        Me.LblLengthUnits = New System.Windows.Forms.Label()
        Me.Txtfansize = New System.Windows.Forms.TextBox()
        Me.Lblfansize = New System.Windows.Forms.Label()
        Me.OptAnySize = New System.Windows.Forms.RadioButton()
        Me.OptFixedSize = New System.Windows.Forms.RadioButton()
        Me.GrpFanSpeed = New System.Windows.Forms.GroupBox()
        Me.OptFixedSpeed = New System.Windows.Forms.RadioButton()
        Me.Opt12Pole = New System.Windows.Forms.RadioButton()
        Me.Txtfanspeed = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Opt10Pole = New System.Windows.Forms.RadioButton()
        Me.Txtspeedlimit = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Opt8Pole = New System.Windows.Forms.RadioButton()
        Me.Opt2Pole = New System.Windows.Forms.RadioButton()
        Me.Opt6Pole = New System.Windows.Forms.RadioButton()
        Me.OptAnySpeed = New System.Windows.Forms.RadioButton()
        Me.Opt4Pole = New System.Windows.Forms.RadioButton()
        Me.GrpFanTypes = New System.Windows.Forms.GroupBox()
        Me.lblOutVelUnit = New System.Windows.Forms.Label()
        Me.chkRadialBlade = New System.Windows.Forms.CheckBox()
        Me.txtOutVel = New System.Windows.Forms.TextBox()
        Me.chkPaddleBlade = New System.Windows.Forms.CheckBox()
        Me.lblOutVel = New System.Windows.Forms.Label()
        Me.chkHighPressure = New System.Windows.Forms.CheckBox()
        Me.chkNarrow = New System.Windows.Forms.CheckBox()
        Me.chkMedium = New System.Windows.Forms.CheckBox()
        Me.chkWide = New System.Windows.Forms.CheckBox()
        Me.chkAllBlades = New System.Windows.Forms.CheckBox()
        Me.ChkOldDesignFans = New System.Windows.Forms.CheckBox()
        Me.ChkAxialFans = New System.Windows.Forms.CheckBox()
        Me.ChkPlenumFans = New System.Windows.Forms.CheckBox()
        Me.ChkPlasticFan = New System.Windows.Forms.CheckBox()
        Me.ChkOtherFanType = New System.Windows.Forms.CheckBox()
        Me.ChkInclineBlade = New System.Windows.Forms.CheckBox()
        Me.ChkCurveBlade = New System.Windows.Forms.CheckBox()
        Me.TabPageSelection = New System.Windows.Forms.TabPage()
        Me.chkOriginalData = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblRunningAt = New System.Windows.Forms.Label()
        Me.lblIncludeAllFanEfficiency = New System.Windows.Forms.Label()
        Me.lblIncludeReserveHead = New System.Windows.Forms.Label()
        Me.lblFanIndex = New System.Windows.Forms.Label()
        Me.lblVolumeTD = New System.Windows.Forms.Label()
        Me.lblReserveHead = New System.Windows.Forms.Label()
        Me.lblOutletVelocity = New System.Windows.Forms.Label()
        Me.lblFanTotalEfficiency = New System.Windows.Forms.Label()
        Me.lblFanStaticEfficiency = New System.Windows.Forms.Label()
        Me.lblMotorPower = New System.Windows.Forms.Label()
        Me.lblFanPower = New System.Windows.Forms.Label()
        Me.lblFanTotalPressure = New System.Windows.Forms.Label()
        Me.lblFanStaticPressure = New System.Windows.Forms.Label()
        Me.lblFlow = New System.Windows.Forms.Label()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.chkKP = New System.Windows.Forms.CheckBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.chkDisplayLowerEff = New System.Windows.Forms.CheckBox()
        Me.chkDisplayAllResHead = New System.Windows.Forms.CheckBox()
        Me.btnSelectionsExit = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnFanParametersBack = New System.Windows.Forms.Button()
        Me.btnNoiseDataForward = New System.Windows.Forms.Button()
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
        Me.lblOverall = New System.Windows.Forms.Label()
        Me.lblBand = New System.Windows.Forms.Label()
        Me.lblSWL1m = New System.Windows.Forms.Label()
        Me.lblSPL1m = New System.Windows.Forms.Label()
        Me.lblSoundPowerLevel = New System.Windows.Forms.Label()
        Me.lblBreakOut = New System.Windows.Forms.Label()
        Me.lblBPF2 = New System.Windows.Forms.Label()
        Me.lblBPF = New System.Windows.Forms.Label()
        Me.lblFreeFieldComment = New System.Windows.Forms.Label()
        Me.lblOutDims = New System.Windows.Forms.Label()
        Me.lblInDia = New System.Windows.Forms.Label()
        Me.lblOutletDimensions = New System.Windows.Forms.Label()
        Me.lblInletDiameter = New System.Windows.Forms.Label()
        Me.btnFanSelectionsBack = New System.Windows.Forms.Button()
        Me.btnImpellerDetailsForward = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtMotordba = New System.Windows.Forms.TextBox()
        Me.chkMotor = New System.Windows.Forms.CheckBox()
        Me.chkBrg = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkOpenOutlet = New System.Windows.Forms.CheckBox()
        Me.chkOpenInlet = New System.Windows.Forms.CheckBox()
        Me.chkDuct = New System.Windows.Forms.CheckBox()
        Me.TxtTypenoise = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtSizenoise = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblAcousticFSPUnits = New System.Windows.Forms.Label()
        Me.TxtStaticPressurenoise = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtSpeednoise = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblAcousticFlowUnits = New System.Windows.Forms.Label()
        Me.TxtFlownoise = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblAcousticFTPUnits = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtTotalPressurenoise = New System.Windows.Forms.TextBox()
        Me.btnNoiseExit = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TabPageImpeller = New System.Windows.Forms.TabPage()
        Me.lblPhase2 = New System.Windows.Forms.Label()
        Me.btnNoiseDataBack = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllPagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerformanceDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcousticsDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerformanceCurveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AllPages2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerformanceDetails2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcousticDetails2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FanCurve2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnitsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdditionalFunctionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StandaloneCurveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPageGeneral.SuspendLayout()
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
        Me.GrpGeneral.SuspendLayout()
        Me.TabPageDuty.SuspendLayout()
        Me.GrpFlowRate.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GrpDesignPressure.SuspendLayout()
        Me.GrpInletDensity.SuspendLayout()
        Me.GrpInletTemperature.SuspendLayout()
        Me.TabPageFanParameters.SuspendLayout()
        Me.GrpFanSize.SuspendLayout()
        Me.GrpFanSpeed.SuspendLayout()
        Me.GrpFanTypes.SuspendLayout()
        Me.TabPageSelection.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageNoise.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageImpeller.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Controls.Add(Me.TabPageGeneral)
        Me.TabControl1.Controls.Add(Me.TabPageDuty)
        Me.TabControl1.Controls.Add(Me.TabPageFanParameters)
        Me.TabControl1.Controls.Add(Me.TabPageSelection)
        Me.TabControl1.Controls.Add(Me.TabPageNoise)
        Me.TabControl1.Controls.Add(Me.TabPageImpeller)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        '
        'TabPageGeneral
        '
        resources.ApplyResources(Me.TabPageGeneral, "TabPageGeneral")
        Me.TabPageGeneral.BackColor = System.Drawing.Color.Transparent
        Me.TabPageGeneral.BackgroundImage = Global.Halifax_Fan_Selector.My.Resources.Resources._0_faded1
        Me.TabPageGeneral.Controls.Add(Me.lblSaveProject)
        Me.TabPageGeneral.Controls.Add(Me.lblDisplayBoth)
        Me.TabPageGeneral.Controls.Add(Me.lblChkAtmosAlt)
        Me.TabPageGeneral.Controls.Add(Me.Label5)
        Me.TabPageGeneral.Controls.Add(Me.btnGeneralExit)
        Me.TabPageGeneral.Controls.Add(Me.GroupBox9)
        Me.TabPageGeneral.Controls.Add(Me.GroupBox8)
        Me.TabPageGeneral.Controls.Add(Me.GroupBox7)
        Me.TabPageGeneral.Controls.Add(Me.GroupBox10)
        Me.TabPageGeneral.Controls.Add(Me.GroupBox11)
        Me.TabPageGeneral.Controls.Add(Me.GroupBox12)
        Me.TabPageGeneral.Controls.Add(Me.GroupBox13)
        Me.TabPageGeneral.Controls.Add(Me.GroupBox14)
        Me.TabPageGeneral.Controls.Add(Me.GroupBox15)
        Me.TabPageGeneral.Controls.Add(Me.btnDutyInputForward)
        Me.TabPageGeneral.Controls.Add(Me.GrpFrequency)
        Me.TabPageGeneral.Controls.Add(Me.GrpGeneral)
        Me.TabPageGeneral.Name = "TabPageGeneral"
        '
        'lblSaveProject
        '
        resources.ApplyResources(Me.lblSaveProject, "lblSaveProject")
        Me.lblSaveProject.Name = "lblSaveProject"
        '
        'lblDisplayBoth
        '
        resources.ApplyResources(Me.lblDisplayBoth, "lblDisplayBoth")
        Me.lblDisplayBoth.Name = "lblDisplayBoth"
        '
        'lblChkAtmosAlt
        '
        resources.ApplyResources(Me.lblChkAtmosAlt, "lblChkAtmosAlt")
        Me.lblChkAtmosAlt.Name = "lblChkAtmosAlt"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'btnGeneralExit
        '
        resources.ApplyResources(Me.btnGeneralExit, "btnGeneralExit")
        Me.btnGeneralExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnGeneralExit.Name = "btnGeneralExit"
        Me.btnGeneralExit.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        resources.ApplyResources(Me.GroupBox9, "GroupBox9")
        Me.GroupBox9.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox9.Controls.Add(Me.OptVelocityFtpermin)
        Me.GroupBox9.Controls.Add(Me.OptVelocityMpers)
        Me.GroupBox9.ForeColor = System.Drawing.Color.Black
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.TabStop = False
        '
        'OptVelocityFtpermin
        '
        resources.ApplyResources(Me.OptVelocityFtpermin, "OptVelocityFtpermin")
        Me.OptVelocityFtpermin.ForeColor = System.Drawing.Color.Black
        Me.OptVelocityFtpermin.Name = "OptVelocityFtpermin"
        Me.OptVelocityFtpermin.TabStop = True
        Me.OptVelocityFtpermin.UseVisualStyleBackColor = True
        '
        'OptVelocityMpers
        '
        resources.ApplyResources(Me.OptVelocityMpers, "OptVelocityMpers")
        Me.OptVelocityMpers.ForeColor = System.Drawing.Color.Black
        Me.OptVelocityMpers.Name = "OptVelocityMpers"
        Me.OptVelocityMpers.TabStop = True
        Me.OptVelocityMpers.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        resources.ApplyResources(Me.GroupBox8, "GroupBox8")
        Me.GroupBox8.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox8.Controls.Add(Me.OptPowerBoth)
        Me.GroupBox8.Controls.Add(Me.OptPowerHp)
        Me.GroupBox8.Controls.Add(Me.OptPowerKW)
        Me.GroupBox8.ForeColor = System.Drawing.Color.Black
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.TabStop = False
        '
        'OptPowerBoth
        '
        resources.ApplyResources(Me.OptPowerBoth, "OptPowerBoth")
        Me.OptPowerBoth.ForeColor = System.Drawing.Color.Black
        Me.OptPowerBoth.Name = "OptPowerBoth"
        Me.OptPowerBoth.TabStop = True
        Me.OptPowerBoth.UseVisualStyleBackColor = True
        '
        'OptPowerHp
        '
        resources.ApplyResources(Me.OptPowerHp, "OptPowerHp")
        Me.OptPowerHp.ForeColor = System.Drawing.Color.Black
        Me.OptPowerHp.Name = "OptPowerHp"
        Me.OptPowerHp.TabStop = True
        Me.OptPowerHp.UseVisualStyleBackColor = True
        '
        'OptPowerKW
        '
        resources.ApplyResources(Me.OptPowerKW, "OptPowerKW")
        Me.OptPowerKW.ForeColor = System.Drawing.Color.Black
        Me.OptPowerKW.Name = "OptPowerKW"
        Me.OptPowerKW.TabStop = True
        Me.OptPowerKW.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        resources.ApplyResources(Me.GroupBox7, "GroupBox7")
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.btnImperialUnits)
        Me.GroupBox7.Controls.Add(Me.btnMetricUnits)
        Me.GroupBox7.Controls.Add(Me.OptDefaultNone)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Black
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.TabStop = False
        '
        'btnImperialUnits
        '
        resources.ApplyResources(Me.btnImperialUnits, "btnImperialUnits")
        Me.btnImperialUnits.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnImperialUnits.Name = "btnImperialUnits"
        Me.btnImperialUnits.UseVisualStyleBackColor = True
        '
        'btnMetricUnits
        '
        resources.ApplyResources(Me.btnMetricUnits, "btnMetricUnits")
        Me.btnMetricUnits.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnMetricUnits.Name = "btnMetricUnits"
        Me.btnMetricUnits.UseVisualStyleBackColor = True
        '
        'OptDefaultNone
        '
        resources.ApplyResources(Me.OptDefaultNone, "OptDefaultNone")
        Me.OptDefaultNone.ForeColor = System.Drawing.Color.White
        Me.OptDefaultNone.Name = "OptDefaultNone"
        Me.OptDefaultNone.TabStop = True
        Me.OptDefaultNone.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        resources.ApplyResources(Me.GroupBox10, "GroupBox10")
        Me.GroupBox10.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox10.Controls.Add(Me.OptAltitudeFt)
        Me.GroupBox10.Controls.Add(Me.OptAltitudeM)
        Me.GroupBox10.ForeColor = System.Drawing.Color.Black
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.TabStop = False
        '
        'OptAltitudeFt
        '
        resources.ApplyResources(Me.OptAltitudeFt, "OptAltitudeFt")
        Me.OptAltitudeFt.ForeColor = System.Drawing.Color.Black
        Me.OptAltitudeFt.Name = "OptAltitudeFt"
        Me.OptAltitudeFt.TabStop = True
        Me.OptAltitudeFt.UseVisualStyleBackColor = True
        '
        'OptAltitudeM
        '
        resources.ApplyResources(Me.OptAltitudeM, "OptAltitudeM")
        Me.OptAltitudeM.ForeColor = System.Drawing.Color.Black
        Me.OptAltitudeM.Name = "OptAltitudeM"
        Me.OptAltitudeM.TabStop = True
        Me.OptAltitudeM.UseVisualStyleBackColor = True
        '
        'GroupBox11
        '
        resources.ApplyResources(Me.GroupBox11, "GroupBox11")
        Me.GroupBox11.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox11.Controls.Add(Me.OptLengthIn)
        Me.GroupBox11.Controls.Add(Me.OptLengthMm)
        Me.GroupBox11.ForeColor = System.Drawing.Color.Black
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.TabStop = False
        '
        'OptLengthIn
        '
        resources.ApplyResources(Me.OptLengthIn, "OptLengthIn")
        Me.OptLengthIn.ForeColor = System.Drawing.Color.Black
        Me.OptLengthIn.Name = "OptLengthIn"
        Me.OptLengthIn.TabStop = True
        Me.OptLengthIn.UseVisualStyleBackColor = True
        '
        'OptLengthMm
        '
        resources.ApplyResources(Me.OptLengthMm, "OptLengthMm")
        Me.OptLengthMm.ForeColor = System.Drawing.Color.Black
        Me.OptLengthMm.Name = "OptLengthMm"
        Me.OptLengthMm.TabStop = True
        Me.OptLengthMm.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        resources.ApplyResources(Me.GroupBox12, "GroupBox12")
        Me.GroupBox12.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox12.Controls.Add(Me.OptTemperatureF)
        Me.GroupBox12.Controls.Add(Me.OptTemperatureC)
        Me.GroupBox12.ForeColor = System.Drawing.Color.Black
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.TabStop = False
        '
        'OptTemperatureF
        '
        resources.ApplyResources(Me.OptTemperatureF, "OptTemperatureF")
        Me.OptTemperatureF.ForeColor = System.Drawing.Color.Black
        Me.OptTemperatureF.Name = "OptTemperatureF"
        Me.OptTemperatureF.TabStop = True
        Me.OptTemperatureF.UseVisualStyleBackColor = True
        '
        'OptTemperatureC
        '
        resources.ApplyResources(Me.OptTemperatureC, "OptTemperatureC")
        Me.OptTemperatureC.ForeColor = System.Drawing.Color.Black
        Me.OptTemperatureC.Name = "OptTemperatureC"
        Me.OptTemperatureC.TabStop = True
        Me.OptTemperatureC.UseVisualStyleBackColor = True
        '
        'GroupBox13
        '
        resources.ApplyResources(Me.GroupBox13, "GroupBox13")
        Me.GroupBox13.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox13.Controls.Add(Me.OptFlowLbPerHr)
        Me.GroupBox13.Controls.Add(Me.OptFlowKgPerHr)
        Me.GroupBox13.Controls.Add(Me.OptFlowCfm)
        Me.GroupBox13.Controls.Add(Me.OptFlowM3PerHr)
        Me.GroupBox13.Controls.Add(Me.OptFlowM3PerMin)
        Me.GroupBox13.Controls.Add(Me.OptFlowM3PerSec)
        Me.GroupBox13.ForeColor = System.Drawing.Color.Black
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.TabStop = False
        '
        'OptFlowLbPerHr
        '
        resources.ApplyResources(Me.OptFlowLbPerHr, "OptFlowLbPerHr")
        Me.OptFlowLbPerHr.ForeColor = System.Drawing.Color.Black
        Me.OptFlowLbPerHr.Name = "OptFlowLbPerHr"
        Me.OptFlowLbPerHr.TabStop = True
        Me.OptFlowLbPerHr.UseVisualStyleBackColor = True
        '
        'OptFlowKgPerHr
        '
        resources.ApplyResources(Me.OptFlowKgPerHr, "OptFlowKgPerHr")
        Me.OptFlowKgPerHr.ForeColor = System.Drawing.Color.Black
        Me.OptFlowKgPerHr.Name = "OptFlowKgPerHr"
        Me.OptFlowKgPerHr.TabStop = True
        Me.OptFlowKgPerHr.UseVisualStyleBackColor = True
        '
        'OptFlowCfm
        '
        resources.ApplyResources(Me.OptFlowCfm, "OptFlowCfm")
        Me.OptFlowCfm.ForeColor = System.Drawing.Color.Black
        Me.OptFlowCfm.Name = "OptFlowCfm"
        Me.OptFlowCfm.TabStop = True
        Me.OptFlowCfm.UseVisualStyleBackColor = True
        '
        'OptFlowM3PerHr
        '
        resources.ApplyResources(Me.OptFlowM3PerHr, "OptFlowM3PerHr")
        Me.OptFlowM3PerHr.ForeColor = System.Drawing.Color.Black
        Me.OptFlowM3PerHr.Name = "OptFlowM3PerHr"
        Me.OptFlowM3PerHr.TabStop = True
        Me.OptFlowM3PerHr.UseVisualStyleBackColor = True
        '
        'OptFlowM3PerMin
        '
        resources.ApplyResources(Me.OptFlowM3PerMin, "OptFlowM3PerMin")
        Me.OptFlowM3PerMin.ForeColor = System.Drawing.Color.Black
        Me.OptFlowM3PerMin.Name = "OptFlowM3PerMin"
        Me.OptFlowM3PerMin.TabStop = True
        Me.OptFlowM3PerMin.UseVisualStyleBackColor = True
        '
        'OptFlowM3PerSec
        '
        resources.ApplyResources(Me.OptFlowM3PerSec, "OptFlowM3PerSec")
        Me.OptFlowM3PerSec.ForeColor = System.Drawing.Color.Black
        Me.OptFlowM3PerSec.Name = "OptFlowM3PerSec"
        Me.OptFlowM3PerSec.TabStop = True
        Me.OptFlowM3PerSec.UseVisualStyleBackColor = True
        '
        'GroupBox14
        '
        resources.ApplyResources(Me.GroupBox14, "GroupBox14")
        Me.GroupBox14.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox14.Controls.Add(Me.OptPressurekPa)
        Me.GroupBox14.Controls.Add(Me.OptPressuremmWG)
        Me.GroupBox14.Controls.Add(Me.OptPressureinWG)
        Me.GroupBox14.Controls.Add(Me.OptPressuremBar)
        Me.GroupBox14.Controls.Add(Me.OptPressurePa)
        Me.GroupBox14.ForeColor = System.Drawing.Color.Black
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.TabStop = False
        '
        'OptPressurekPa
        '
        resources.ApplyResources(Me.OptPressurekPa, "OptPressurekPa")
        Me.OptPressurekPa.ForeColor = System.Drawing.Color.Black
        Me.OptPressurekPa.Name = "OptPressurekPa"
        Me.OptPressurekPa.TabStop = True
        Me.OptPressurekPa.UseVisualStyleBackColor = True
        '
        'OptPressuremmWG
        '
        resources.ApplyResources(Me.OptPressuremmWG, "OptPressuremmWG")
        Me.OptPressuremmWG.ForeColor = System.Drawing.Color.Black
        Me.OptPressuremmWG.Name = "OptPressuremmWG"
        Me.OptPressuremmWG.TabStop = True
        Me.OptPressuremmWG.UseVisualStyleBackColor = True
        '
        'OptPressureinWG
        '
        resources.ApplyResources(Me.OptPressureinWG, "OptPressureinWG")
        Me.OptPressureinWG.ForeColor = System.Drawing.Color.Black
        Me.OptPressureinWG.Name = "OptPressureinWG"
        Me.OptPressureinWG.TabStop = True
        Me.OptPressureinWG.UseVisualStyleBackColor = True
        '
        'OptPressuremBar
        '
        resources.ApplyResources(Me.OptPressuremBar, "OptPressuremBar")
        Me.OptPressuremBar.ForeColor = System.Drawing.Color.Black
        Me.OptPressuremBar.Name = "OptPressuremBar"
        Me.OptPressuremBar.TabStop = True
        Me.OptPressuremBar.UseVisualStyleBackColor = True
        '
        'OptPressurePa
        '
        resources.ApplyResources(Me.OptPressurePa, "OptPressurePa")
        Me.OptPressurePa.ForeColor = System.Drawing.Color.Black
        Me.OptPressurePa.Name = "OptPressurePa"
        Me.OptPressurePa.TabStop = True
        Me.OptPressurePa.UseVisualStyleBackColor = True
        '
        'GroupBox15
        '
        resources.ApplyResources(Me.GroupBox15, "GroupBox15")
        Me.GroupBox15.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox15.Controls.Add(Me.OptDensityLbPerFt3)
        Me.GroupBox15.Controls.Add(Me.OptDensityKgPerM3)
        Me.GroupBox15.ForeColor = System.Drawing.Color.Black
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.TabStop = False
        '
        'OptDensityLbPerFt3
        '
        resources.ApplyResources(Me.OptDensityLbPerFt3, "OptDensityLbPerFt3")
        Me.OptDensityLbPerFt3.ForeColor = System.Drawing.Color.Black
        Me.OptDensityLbPerFt3.Name = "OptDensityLbPerFt3"
        Me.OptDensityLbPerFt3.TabStop = True
        Me.OptDensityLbPerFt3.UseVisualStyleBackColor = True
        '
        'OptDensityKgPerM3
        '
        resources.ApplyResources(Me.OptDensityKgPerM3, "OptDensityKgPerM3")
        Me.OptDensityKgPerM3.ForeColor = System.Drawing.Color.Black
        Me.OptDensityKgPerM3.Name = "OptDensityKgPerM3"
        Me.OptDensityKgPerM3.TabStop = True
        Me.OptDensityKgPerM3.UseVisualStyleBackColor = True
        '
        'btnDutyInputForward
        '
        resources.ApplyResources(Me.btnDutyInputForward, "btnDutyInputForward")
        Me.btnDutyInputForward.Name = "btnDutyInputForward"
        Me.btnDutyInputForward.UseVisualStyleBackColor = True
        '
        'GrpFrequency
        '
        resources.ApplyResources(Me.GrpFrequency, "GrpFrequency")
        Me.GrpFrequency.BackColor = System.Drawing.Color.Transparent
        Me.GrpFrequency.Controls.Add(Me.Opt50Hz)
        Me.GrpFrequency.Controls.Add(Me.Opt60Hz)
        Me.GrpFrequency.ForeColor = System.Drawing.Color.Black
        Me.GrpFrequency.Name = "GrpFrequency"
        Me.GrpFrequency.TabStop = False
        '
        'Opt50Hz
        '
        resources.ApplyResources(Me.Opt50Hz, "Opt50Hz")
        Me.Opt50Hz.Checked = True
        Me.Opt50Hz.Name = "Opt50Hz"
        Me.Opt50Hz.TabStop = True
        Me.Opt50Hz.UseVisualStyleBackColor = True
        '
        'Opt60Hz
        '
        resources.ApplyResources(Me.Opt60Hz, "Opt60Hz")
        Me.Opt60Hz.Name = "Opt60Hz"
        Me.Opt60Hz.UseVisualStyleBackColor = True
        '
        'GrpGeneral
        '
        resources.ApplyResources(Me.GrpGeneral, "GrpGeneral")
        Me.GrpGeneral.BackColor = System.Drawing.Color.Transparent
        Me.GrpGeneral.Controls.Add(Me.chkCalcAtmos)
        Me.GrpGeneral.Controls.Add(Me.LblAtmosphericPressureUnits)
        Me.GrpGeneral.Controls.Add(Me.LblHumidityUnits)
        Me.GrpGeneral.Controls.Add(Me.LblAltitudeUnits)
        Me.GrpGeneral.Controls.Add(Me.LblAmbientTemperatureUnits)
        Me.GrpGeneral.Controls.Add(Me.TxtAtmosphericPressure)
        Me.GrpGeneral.Controls.Add(Me.TxtHumidity)
        Me.GrpGeneral.Controls.Add(Me.TxtAltitude)
        Me.GrpGeneral.Controls.Add(Me.TxtAmbientTemperature)
        Me.GrpGeneral.Controls.Add(Me.LblAtmosphericPressure)
        Me.GrpGeneral.Controls.Add(Me.LblHumidity)
        Me.GrpGeneral.Controls.Add(Me.LblAltitude)
        Me.GrpGeneral.Controls.Add(Me.LblAmbientTemperature)
        Me.GrpGeneral.ForeColor = System.Drawing.Color.Black
        Me.GrpGeneral.Name = "GrpGeneral"
        Me.GrpGeneral.TabStop = False
        '
        'chkCalcAtmos
        '
        resources.ApplyResources(Me.chkCalcAtmos, "chkCalcAtmos")
        Me.chkCalcAtmos.Name = "chkCalcAtmos"
        Me.chkCalcAtmos.UseVisualStyleBackColor = True
        '
        'LblAtmosphericPressureUnits
        '
        resources.ApplyResources(Me.LblAtmosphericPressureUnits, "LblAtmosphericPressureUnits")
        Me.LblAtmosphericPressureUnits.Name = "LblAtmosphericPressureUnits"
        '
        'LblHumidityUnits
        '
        resources.ApplyResources(Me.LblHumidityUnits, "LblHumidityUnits")
        Me.LblHumidityUnits.Name = "LblHumidityUnits"
        '
        'LblAltitudeUnits
        '
        resources.ApplyResources(Me.LblAltitudeUnits, "LblAltitudeUnits")
        Me.LblAltitudeUnits.Name = "LblAltitudeUnits"
        '
        'LblAmbientTemperatureUnits
        '
        resources.ApplyResources(Me.LblAmbientTemperatureUnits, "LblAmbientTemperatureUnits")
        Me.LblAmbientTemperatureUnits.Name = "LblAmbientTemperatureUnits"
        '
        'TxtAtmosphericPressure
        '
        resources.ApplyResources(Me.TxtAtmosphericPressure, "TxtAtmosphericPressure")
        Me.TxtAtmosphericPressure.Name = "TxtAtmosphericPressure"
        '
        'TxtHumidity
        '
        resources.ApplyResources(Me.TxtHumidity, "TxtHumidity")
        Me.TxtHumidity.Name = "TxtHumidity"
        '
        'TxtAltitude
        '
        resources.ApplyResources(Me.TxtAltitude, "TxtAltitude")
        Me.TxtAltitude.Name = "TxtAltitude"
        '
        'TxtAmbientTemperature
        '
        resources.ApplyResources(Me.TxtAmbientTemperature, "TxtAmbientTemperature")
        Me.TxtAmbientTemperature.Name = "TxtAmbientTemperature"
        '
        'LblAtmosphericPressure
        '
        resources.ApplyResources(Me.LblAtmosphericPressure, "LblAtmosphericPressure")
        Me.LblAtmosphericPressure.Name = "LblAtmosphericPressure"
        '
        'LblHumidity
        '
        resources.ApplyResources(Me.LblHumidity, "LblHumidity")
        Me.LblHumidity.Name = "LblHumidity"
        '
        'LblAltitude
        '
        resources.ApplyResources(Me.LblAltitude, "LblAltitude")
        Me.LblAltitude.Name = "LblAltitude"
        '
        'LblAmbientTemperature
        '
        resources.ApplyResources(Me.LblAmbientTemperature, "LblAmbientTemperature")
        Me.LblAmbientTemperature.Name = "LblAmbientTemperature"
        '
        'TabPageDuty
        '
        resources.ApplyResources(Me.TabPageDuty, "TabPageDuty")
        Me.TabPageDuty.BackColor = System.Drawing.Color.Transparent
        Me.TabPageDuty.BackgroundImage = Global.Halifax_Fan_Selector.My.Resources.Resources._0_faded1
        Me.TabPageDuty.Controls.Add(Me.lblMassFlow)
        Me.TabPageDuty.Controls.Add(Me.lblVolumeFlow)
        Me.TabPageDuty.Controls.Add(Me.btnGeneralInformationBack)
        Me.TabPageDuty.Controls.Add(Me.LblFlowRateUnits)
        Me.TabPageDuty.Controls.Add(Me.btnFanParametersForward)
        Me.TabPageDuty.Controls.Add(Me.btnCalculateDensity)
        Me.TabPageDuty.Controls.Add(Me.GrpFlowRate)
        Me.TabPageDuty.Controls.Add(Me.GroupBox6)
        Me.TabPageDuty.Controls.Add(Me.GroupBox1)
        Me.TabPageDuty.Controls.Add(Me.GrpDesignPressure)
        Me.TabPageDuty.Controls.Add(Me.GrpInletDensity)
        Me.TabPageDuty.Controls.Add(Me.btnDutyExit)
        Me.TabPageDuty.Controls.Add(Me.GrpInletTemperature)
        Me.TabPageDuty.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabPageDuty.Name = "TabPageDuty"
        '
        'lblMassFlow
        '
        resources.ApplyResources(Me.lblMassFlow, "lblMassFlow")
        Me.lblMassFlow.Name = "lblMassFlow"
        '
        'lblVolumeFlow
        '
        resources.ApplyResources(Me.lblVolumeFlow, "lblVolumeFlow")
        Me.lblVolumeFlow.Name = "lblVolumeFlow"
        '
        'btnGeneralInformationBack
        '
        resources.ApplyResources(Me.btnGeneralInformationBack, "btnGeneralInformationBack")
        Me.btnGeneralInformationBack.Name = "btnGeneralInformationBack"
        Me.btnGeneralInformationBack.UseVisualStyleBackColor = True
        '
        'LblFlowRateUnits
        '
        resources.ApplyResources(Me.LblFlowRateUnits, "LblFlowRateUnits")
        Me.LblFlowRateUnits.Name = "LblFlowRateUnits"
        '
        'btnFanParametersForward
        '
        resources.ApplyResources(Me.btnFanParametersForward, "btnFanParametersForward")
        Me.btnFanParametersForward.Name = "btnFanParametersForward"
        Me.btnFanParametersForward.UseVisualStyleBackColor = True
        '
        'btnCalculateDensity
        '
        resources.ApplyResources(Me.btnCalculateDensity, "btnCalculateDensity")
        Me.btnCalculateDensity.Name = "btnCalculateDensity"
        Me.btnCalculateDensity.UseVisualStyleBackColor = True
        '
        'GrpFlowRate
        '
        resources.ApplyResources(Me.GrpFlowRate, "GrpFlowRate")
        Me.GrpFlowRate.BackColor = System.Drawing.Color.Transparent
        Me.GrpFlowRate.Controls.Add(Me.lblFlowType)
        Me.GrpFlowRate.Controls.Add(Me.Txtflow)
        Me.GrpFlowRate.Controls.Add(Me.OptMassFlow)
        Me.GrpFlowRate.Controls.Add(Me.OptVolumeFlow)
        Me.GrpFlowRate.ForeColor = System.Drawing.Color.Black
        Me.GrpFlowRate.Name = "GrpFlowRate"
        Me.GrpFlowRate.TabStop = False
        '
        'lblFlowType
        '
        resources.ApplyResources(Me.lblFlowType, "lblFlowType")
        Me.lblFlowType.Name = "lblFlowType"
        '
        'Txtflow
        '
        resources.ApplyResources(Me.Txtflow, "Txtflow")
        Me.Txtflow.Name = "Txtflow"
        '
        'OptMassFlow
        '
        resources.ApplyResources(Me.OptMassFlow, "OptMassFlow")
        Me.OptMassFlow.Name = "OptMassFlow"
        Me.OptMassFlow.UseVisualStyleBackColor = True
        '
        'OptVolumeFlow
        '
        resources.ApplyResources(Me.OptVolumeFlow, "OptVolumeFlow")
        Me.OptVolumeFlow.Checked = True
        Me.OptVolumeFlow.Name = "OptVolumeFlow"
        Me.OptVolumeFlow.TabStop = True
        Me.OptVolumeFlow.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        resources.ApplyResources(Me.GroupBox6, "GroupBox6")
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.OptFlowDischarge)
        Me.GroupBox6.Controls.Add(Me.OptFlowNominal)
        Me.GroupBox6.Controls.Add(Me.OpFlowInlet)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Black
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.TabStop = False
        '
        'OptFlowDischarge
        '
        resources.ApplyResources(Me.OptFlowDischarge, "OptFlowDischarge")
        Me.OptFlowDischarge.Name = "OptFlowDischarge"
        Me.OptFlowDischarge.UseVisualStyleBackColor = True
        '
        'OptFlowNominal
        '
        resources.ApplyResources(Me.OptFlowNominal, "OptFlowNominal")
        Me.OptFlowNominal.Name = "OptFlowNominal"
        Me.OptFlowNominal.UseVisualStyleBackColor = True
        '
        'OpFlowInlet
        '
        resources.ApplyResources(Me.OpFlowInlet, "OpFlowInlet")
        Me.OpFlowInlet.Checked = True
        Me.OpFlowInlet.Name = "OpFlowInlet"
        Me.OpFlowInlet.TabStop = True
        Me.OpFlowInlet.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblpercent)
        Me.GroupBox1.Controls.Add(Me.lblUserDefinedUnits)
        Me.GroupBox1.Controls.Add(Me.txtRatioDD)
        Me.GroupBox1.Controls.Add(Me.txtUserDefinedDD)
        Me.GroupBox1.Controls.Add(Me.optDDUserDefined)
        Me.GroupBox1.Controls.Add(Me.optDDStandard)
        Me.GroupBox1.Controls.Add(Me.optDDRatio)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'lblpercent
        '
        resources.ApplyResources(Me.lblpercent, "lblpercent")
        Me.lblpercent.Name = "lblpercent"
        '
        'lblUserDefinedUnits
        '
        resources.ApplyResources(Me.lblUserDefinedUnits, "lblUserDefinedUnits")
        Me.lblUserDefinedUnits.Name = "lblUserDefinedUnits"
        '
        'txtRatioDD
        '
        resources.ApplyResources(Me.txtRatioDD, "txtRatioDD")
        Me.txtRatioDD.Name = "txtRatioDD"
        '
        'txtUserDefinedDD
        '
        resources.ApplyResources(Me.txtUserDefinedDD, "txtUserDefinedDD")
        Me.txtUserDefinedDD.Name = "txtUserDefinedDD"
        '
        'optDDUserDefined
        '
        resources.ApplyResources(Me.optDDUserDefined, "optDDUserDefined")
        Me.optDDUserDefined.Name = "optDDUserDefined"
        Me.optDDUserDefined.UseVisualStyleBackColor = True
        '
        'optDDStandard
        '
        resources.ApplyResources(Me.optDDStandard, "optDDStandard")
        Me.optDDStandard.Checked = True
        Me.optDDStandard.Name = "optDDStandard"
        Me.optDDStandard.TabStop = True
        Me.optDDStandard.UseVisualStyleBackColor = True
        '
        'optDDRatio
        '
        resources.ApplyResources(Me.optDDRatio, "optDDRatio")
        Me.optDDRatio.Name = "optDDRatio"
        Me.optDDRatio.UseVisualStyleBackColor = True
        '
        'GrpDesignPressure
        '
        resources.ApplyResources(Me.GrpDesignPressure, "GrpDesignPressure")
        Me.GrpDesignPressure.BackColor = System.Drawing.Color.Transparent
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
        Me.GrpDesignPressure.ForeColor = System.Drawing.Color.Black
        Me.GrpDesignPressure.Name = "GrpDesignPressure"
        Me.GrpDesignPressure.TabStop = False
        '
        'Optsucy
        '
        resources.ApplyResources(Me.Optsucy, "Optsucy")
        Me.Optsucy.Name = "Optsucy"
        Me.Optsucy.UseVisualStyleBackColor = True
        '
        'CmbReserveHead
        '
        resources.ApplyResources(Me.CmbReserveHead, "CmbReserveHead")
        Me.CmbReserveHead.FormattingEnabled = True
        Me.CmbReserveHead.Items.AddRange(New Object() {resources.GetString("CmbReserveHead.Items"), resources.GetString("CmbReserveHead.Items1"), resources.GetString("CmbReserveHead.Items2"), resources.GetString("CmbReserveHead.Items3")})
        Me.CmbReserveHead.Name = "CmbReserveHead"
        '
        'Txtfsp
        '
        resources.ApplyResources(Me.Txtfsp, "Txtfsp")
        Me.Txtfsp.Name = "Txtfsp"
        '
        'TxtDischargePressure
        '
        resources.ApplyResources(Me.TxtDischargePressure, "TxtDischargePressure")
        Me.TxtDischargePressure.Name = "TxtDischargePressure"
        '
        'TxtInletPressure
        '
        resources.ApplyResources(Me.TxtInletPressure, "TxtInletPressure")
        Me.TxtInletPressure.Name = "TxtInletPressure"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'OptStaticPressure
        '
        resources.ApplyResources(Me.OptStaticPressure, "OptStaticPressure")
        Me.OptStaticPressure.Checked = True
        Me.OptStaticPressure.Name = "OptStaticPressure"
        Me.OptStaticPressure.TabStop = True
        Me.OptStaticPressure.UseVisualStyleBackColor = True
        '
        'OptTotalPressure
        '
        resources.ApplyResources(Me.OptTotalPressure, "OptTotalPressure")
        Me.OptTotalPressure.Name = "OptTotalPressure"
        Me.OptTotalPressure.UseVisualStyleBackColor = True
        '
        'GrpInletDensity
        '
        resources.ApplyResources(Me.GrpInletDensity, "GrpInletDensity")
        Me.GrpInletDensity.BackColor = System.Drawing.Color.Transparent
        Me.GrpInletDensity.Controls.Add(Me.OptDensityCalculated)
        Me.GrpInletDensity.Controls.Add(Me.OptDensityKnown)
        Me.GrpInletDensity.Controls.Add(Me.Txtdens)
        Me.GrpInletDensity.ForeColor = System.Drawing.Color.Black
        Me.GrpInletDensity.Name = "GrpInletDensity"
        Me.GrpInletDensity.TabStop = False
        '
        'OptDensityCalculated
        '
        resources.ApplyResources(Me.OptDensityCalculated, "OptDensityCalculated")
        Me.OptDensityCalculated.Name = "OptDensityCalculated"
        Me.OptDensityCalculated.UseVisualStyleBackColor = True
        '
        'OptDensityKnown
        '
        resources.ApplyResources(Me.OptDensityKnown, "OptDensityKnown")
        Me.OptDensityKnown.Checked = True
        Me.OptDensityKnown.Name = "OptDensityKnown"
        Me.OptDensityKnown.TabStop = True
        Me.OptDensityKnown.UseVisualStyleBackColor = True
        '
        'Txtdens
        '
        resources.ApplyResources(Me.Txtdens, "Txtdens")
        Me.Txtdens.Name = "Txtdens"
        '
        'btnDutyExit
        '
        resources.ApplyResources(Me.btnDutyExit, "btnDutyExit")
        Me.btnDutyExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDutyExit.Name = "btnDutyExit"
        Me.btnDutyExit.UseVisualStyleBackColor = True
        '
        'GrpInletTemperature
        '
        resources.ApplyResources(Me.GrpInletTemperature, "GrpInletTemperature")
        Me.GrpInletTemperature.BackColor = System.Drawing.Color.Transparent
        Me.GrpInletTemperature.Controls.Add(Me.TxtMaximumTemperature)
        Me.GrpInletTemperature.Controls.Add(Me.LblMaximumTemperature)
        Me.GrpInletTemperature.Controls.Add(Me.LblDesignTemperature)
        Me.GrpInletTemperature.Controls.Add(Me.TxtDesignTemperature)
        Me.GrpInletTemperature.ForeColor = System.Drawing.Color.Black
        Me.GrpInletTemperature.Name = "GrpInletTemperature"
        Me.GrpInletTemperature.TabStop = False
        '
        'TxtMaximumTemperature
        '
        resources.ApplyResources(Me.TxtMaximumTemperature, "TxtMaximumTemperature")
        Me.TxtMaximumTemperature.Name = "TxtMaximumTemperature"
        '
        'LblMaximumTemperature
        '
        resources.ApplyResources(Me.LblMaximumTemperature, "LblMaximumTemperature")
        Me.LblMaximumTemperature.Name = "LblMaximumTemperature"
        '
        'LblDesignTemperature
        '
        resources.ApplyResources(Me.LblDesignTemperature, "LblDesignTemperature")
        Me.LblDesignTemperature.Name = "LblDesignTemperature"
        '
        'TxtDesignTemperature
        '
        resources.ApplyResources(Me.TxtDesignTemperature, "TxtDesignTemperature")
        Me.TxtDesignTemperature.Name = "TxtDesignTemperature"
        '
        'TabPageFanParameters
        '
        resources.ApplyResources(Me.TabPageFanParameters, "TabPageFanParameters")
        Me.TabPageFanParameters.BackColor = System.Drawing.Color.Transparent
        Me.TabPageFanParameters.BackgroundImage = Global.Halifax_Fan_Selector.My.Resources.Resources._0_faded1
        Me.TabPageFanParameters.Controls.Add(Me.Label21)
        Me.TabPageFanParameters.Controls.Add(Me.chkDIDW)
        Me.TabPageFanParameters.Controls.Add(Me.btnDutyInputBack)
        Me.TabPageFanParameters.Controls.Add(Me.btnParametersExit)
        Me.TabPageFanParameters.Controls.Add(Me.btnFanSelectionsForward)
        Me.TabPageFanParameters.Controls.Add(Me.GrpFanSize)
        Me.TabPageFanParameters.Controls.Add(Me.GrpFanSpeed)
        Me.TabPageFanParameters.Controls.Add(Me.GrpFanTypes)
        Me.TabPageFanParameters.Name = "TabPageFanParameters"
        '
        'Label21
        '
        resources.ApplyResources(Me.Label21, "Label21")
        Me.Label21.Name = "Label21"
        '
        'chkDIDW
        '
        resources.ApplyResources(Me.chkDIDW, "chkDIDW")
        Me.chkDIDW.ForeColor = System.Drawing.Color.Black
        Me.chkDIDW.Name = "chkDIDW"
        Me.chkDIDW.UseVisualStyleBackColor = True
        '
        'btnDutyInputBack
        '
        resources.ApplyResources(Me.btnDutyInputBack, "btnDutyInputBack")
        Me.btnDutyInputBack.Name = "btnDutyInputBack"
        Me.btnDutyInputBack.UseVisualStyleBackColor = True
        '
        'btnParametersExit
        '
        resources.ApplyResources(Me.btnParametersExit, "btnParametersExit")
        Me.btnParametersExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnParametersExit.Name = "btnParametersExit"
        Me.btnParametersExit.UseVisualStyleBackColor = True
        '
        'btnFanSelectionsForward
        '
        resources.ApplyResources(Me.btnFanSelectionsForward, "btnFanSelectionsForward")
        Me.btnFanSelectionsForward.Name = "btnFanSelectionsForward"
        Me.btnFanSelectionsForward.UseVisualStyleBackColor = True
        '
        'GrpFanSize
        '
        resources.ApplyResources(Me.GrpFanSize, "GrpFanSize")
        Me.GrpFanSize.BackColor = System.Drawing.Color.Transparent
        Me.GrpFanSize.Controls.Add(Me.LblLengthUnits)
        Me.GrpFanSize.Controls.Add(Me.Txtfansize)
        Me.GrpFanSize.Controls.Add(Me.Lblfansize)
        Me.GrpFanSize.Controls.Add(Me.OptAnySize)
        Me.GrpFanSize.Controls.Add(Me.OptFixedSize)
        Me.GrpFanSize.ForeColor = System.Drawing.Color.Black
        Me.GrpFanSize.Name = "GrpFanSize"
        Me.GrpFanSize.TabStop = False
        '
        'LblLengthUnits
        '
        resources.ApplyResources(Me.LblLengthUnits, "LblLengthUnits")
        Me.LblLengthUnits.Name = "LblLengthUnits"
        '
        'Txtfansize
        '
        resources.ApplyResources(Me.Txtfansize, "Txtfansize")
        Me.Txtfansize.Name = "Txtfansize"
        '
        'Lblfansize
        '
        resources.ApplyResources(Me.Lblfansize, "Lblfansize")
        Me.Lblfansize.Name = "Lblfansize"
        '
        'OptAnySize
        '
        resources.ApplyResources(Me.OptAnySize, "OptAnySize")
        Me.OptAnySize.Checked = True
        Me.OptAnySize.Name = "OptAnySize"
        Me.OptAnySize.TabStop = True
        Me.OptAnySize.UseVisualStyleBackColor = True
        '
        'OptFixedSize
        '
        resources.ApplyResources(Me.OptFixedSize, "OptFixedSize")
        Me.OptFixedSize.Name = "OptFixedSize"
        Me.OptFixedSize.UseVisualStyleBackColor = True
        '
        'GrpFanSpeed
        '
        resources.ApplyResources(Me.GrpFanSpeed, "GrpFanSpeed")
        Me.GrpFanSpeed.BackColor = System.Drawing.Color.Transparent
        Me.GrpFanSpeed.Controls.Add(Me.OptFixedSpeed)
        Me.GrpFanSpeed.Controls.Add(Me.Opt12Pole)
        Me.GrpFanSpeed.Controls.Add(Me.Txtfanspeed)
        Me.GrpFanSpeed.Controls.Add(Me.Label1)
        Me.GrpFanSpeed.Controls.Add(Me.Opt10Pole)
        Me.GrpFanSpeed.Controls.Add(Me.Txtspeedlimit)
        Me.GrpFanSpeed.Controls.Add(Me.Label11)
        Me.GrpFanSpeed.Controls.Add(Me.Opt8Pole)
        Me.GrpFanSpeed.Controls.Add(Me.Opt2Pole)
        Me.GrpFanSpeed.Controls.Add(Me.Opt6Pole)
        Me.GrpFanSpeed.Controls.Add(Me.OptAnySpeed)
        Me.GrpFanSpeed.Controls.Add(Me.Opt4Pole)
        Me.GrpFanSpeed.ForeColor = System.Drawing.Color.Black
        Me.GrpFanSpeed.Name = "GrpFanSpeed"
        Me.GrpFanSpeed.TabStop = False
        '
        'OptFixedSpeed
        '
        resources.ApplyResources(Me.OptFixedSpeed, "OptFixedSpeed")
        Me.OptFixedSpeed.Name = "OptFixedSpeed"
        Me.OptFixedSpeed.UseVisualStyleBackColor = True
        '
        'Opt12Pole
        '
        resources.ApplyResources(Me.Opt12Pole, "Opt12Pole")
        Me.Opt12Pole.Name = "Opt12Pole"
        Me.Opt12Pole.UseVisualStyleBackColor = True
        '
        'Txtfanspeed
        '
        resources.ApplyResources(Me.Txtfanspeed, "Txtfanspeed")
        Me.Txtfanspeed.Name = "Txtfanspeed"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Opt10Pole
        '
        resources.ApplyResources(Me.Opt10Pole, "Opt10Pole")
        Me.Opt10Pole.Name = "Opt10Pole"
        Me.Opt10Pole.UseVisualStyleBackColor = True
        '
        'Txtspeedlimit
        '
        resources.ApplyResources(Me.Txtspeedlimit, "Txtspeedlimit")
        Me.Txtspeedlimit.Name = "Txtspeedlimit"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'Opt8Pole
        '
        resources.ApplyResources(Me.Opt8Pole, "Opt8Pole")
        Me.Opt8Pole.Name = "Opt8Pole"
        Me.Opt8Pole.UseVisualStyleBackColor = True
        '
        'Opt2Pole
        '
        resources.ApplyResources(Me.Opt2Pole, "Opt2Pole")
        Me.Opt2Pole.Name = "Opt2Pole"
        Me.Opt2Pole.UseVisualStyleBackColor = True
        '
        'Opt6Pole
        '
        resources.ApplyResources(Me.Opt6Pole, "Opt6Pole")
        Me.Opt6Pole.Name = "Opt6Pole"
        Me.Opt6Pole.UseVisualStyleBackColor = True
        '
        'OptAnySpeed
        '
        resources.ApplyResources(Me.OptAnySpeed, "OptAnySpeed")
        Me.OptAnySpeed.Checked = True
        Me.OptAnySpeed.Name = "OptAnySpeed"
        Me.OptAnySpeed.TabStop = True
        Me.OptAnySpeed.UseVisualStyleBackColor = True
        '
        'Opt4Pole
        '
        resources.ApplyResources(Me.Opt4Pole, "Opt4Pole")
        Me.Opt4Pole.Name = "Opt4Pole"
        Me.Opt4Pole.UseVisualStyleBackColor = True
        '
        'GrpFanTypes
        '
        resources.ApplyResources(Me.GrpFanTypes, "GrpFanTypes")
        Me.GrpFanTypes.BackColor = System.Drawing.Color.Transparent
        Me.GrpFanTypes.Controls.Add(Me.lblOutVelUnit)
        Me.GrpFanTypes.Controls.Add(Me.chkRadialBlade)
        Me.GrpFanTypes.Controls.Add(Me.txtOutVel)
        Me.GrpFanTypes.Controls.Add(Me.chkPaddleBlade)
        Me.GrpFanTypes.Controls.Add(Me.lblOutVel)
        Me.GrpFanTypes.Controls.Add(Me.chkHighPressure)
        Me.GrpFanTypes.Controls.Add(Me.chkNarrow)
        Me.GrpFanTypes.Controls.Add(Me.chkMedium)
        Me.GrpFanTypes.Controls.Add(Me.chkWide)
        Me.GrpFanTypes.Controls.Add(Me.chkAllBlades)
        Me.GrpFanTypes.Controls.Add(Me.ChkOldDesignFans)
        Me.GrpFanTypes.Controls.Add(Me.ChkAxialFans)
        Me.GrpFanTypes.Controls.Add(Me.ChkPlenumFans)
        Me.GrpFanTypes.Controls.Add(Me.ChkPlasticFan)
        Me.GrpFanTypes.Controls.Add(Me.ChkOtherFanType)
        Me.GrpFanTypes.Controls.Add(Me.ChkInclineBlade)
        Me.GrpFanTypes.Controls.Add(Me.ChkCurveBlade)
        Me.GrpFanTypes.ForeColor = System.Drawing.Color.Black
        Me.GrpFanTypes.Name = "GrpFanTypes"
        Me.GrpFanTypes.TabStop = False
        '
        'lblOutVelUnit
        '
        resources.ApplyResources(Me.lblOutVelUnit, "lblOutVelUnit")
        Me.lblOutVelUnit.ForeColor = System.Drawing.Color.Black
        Me.lblOutVelUnit.Name = "lblOutVelUnit"
        '
        'chkRadialBlade
        '
        resources.ApplyResources(Me.chkRadialBlade, "chkRadialBlade")
        Me.chkRadialBlade.Name = "chkRadialBlade"
        Me.chkRadialBlade.UseVisualStyleBackColor = True
        '
        'txtOutVel
        '
        resources.ApplyResources(Me.txtOutVel, "txtOutVel")
        Me.txtOutVel.Name = "txtOutVel"
        '
        'chkPaddleBlade
        '
        resources.ApplyResources(Me.chkPaddleBlade, "chkPaddleBlade")
        Me.chkPaddleBlade.Name = "chkPaddleBlade"
        Me.chkPaddleBlade.UseVisualStyleBackColor = True
        '
        'lblOutVel
        '
        resources.ApplyResources(Me.lblOutVel, "lblOutVel")
        Me.lblOutVel.ForeColor = System.Drawing.Color.Black
        Me.lblOutVel.Name = "lblOutVel"
        '
        'chkHighPressure
        '
        resources.ApplyResources(Me.chkHighPressure, "chkHighPressure")
        Me.chkHighPressure.Name = "chkHighPressure"
        Me.chkHighPressure.UseVisualStyleBackColor = True
        '
        'chkNarrow
        '
        resources.ApplyResources(Me.chkNarrow, "chkNarrow")
        Me.chkNarrow.Name = "chkNarrow"
        Me.chkNarrow.UseVisualStyleBackColor = True
        '
        'chkMedium
        '
        resources.ApplyResources(Me.chkMedium, "chkMedium")
        Me.chkMedium.Name = "chkMedium"
        Me.chkMedium.UseVisualStyleBackColor = True
        '
        'chkWide
        '
        resources.ApplyResources(Me.chkWide, "chkWide")
        Me.chkWide.Name = "chkWide"
        Me.chkWide.UseVisualStyleBackColor = True
        '
        'chkAllBlades
        '
        resources.ApplyResources(Me.chkAllBlades, "chkAllBlades")
        Me.chkAllBlades.Name = "chkAllBlades"
        Me.chkAllBlades.UseVisualStyleBackColor = True
        '
        'ChkOldDesignFans
        '
        resources.ApplyResources(Me.ChkOldDesignFans, "ChkOldDesignFans")
        Me.ChkOldDesignFans.Name = "ChkOldDesignFans"
        Me.ChkOldDesignFans.UseVisualStyleBackColor = True
        '
        'ChkAxialFans
        '
        resources.ApplyResources(Me.ChkAxialFans, "ChkAxialFans")
        Me.ChkAxialFans.Name = "ChkAxialFans"
        Me.ChkAxialFans.UseVisualStyleBackColor = True
        '
        'ChkPlenumFans
        '
        resources.ApplyResources(Me.ChkPlenumFans, "ChkPlenumFans")
        Me.ChkPlenumFans.Name = "ChkPlenumFans"
        Me.ChkPlenumFans.UseVisualStyleBackColor = True
        '
        'ChkPlasticFan
        '
        resources.ApplyResources(Me.ChkPlasticFan, "ChkPlasticFan")
        Me.ChkPlasticFan.Name = "ChkPlasticFan"
        Me.ChkPlasticFan.UseVisualStyleBackColor = True
        '
        'ChkOtherFanType
        '
        resources.ApplyResources(Me.ChkOtherFanType, "ChkOtherFanType")
        Me.ChkOtherFanType.Name = "ChkOtherFanType"
        Me.ChkOtherFanType.UseVisualStyleBackColor = True
        '
        'ChkInclineBlade
        '
        resources.ApplyResources(Me.ChkInclineBlade, "ChkInclineBlade")
        Me.ChkInclineBlade.Name = "ChkInclineBlade"
        Me.ChkInclineBlade.UseVisualStyleBackColor = True
        '
        'ChkCurveBlade
        '
        resources.ApplyResources(Me.ChkCurveBlade, "ChkCurveBlade")
        Me.ChkCurveBlade.Name = "ChkCurveBlade"
        Me.ChkCurveBlade.UseVisualStyleBackColor = True
        '
        'TabPageSelection
        '
        resources.ApplyResources(Me.TabPageSelection, "TabPageSelection")
        Me.TabPageSelection.BackColor = System.Drawing.Color.Transparent
        Me.TabPageSelection.BackgroundImage = Global.Halifax_Fan_Selector.My.Resources.Resources._0_faded1
        Me.TabPageSelection.Controls.Add(Me.chkOriginalData)
        Me.TabPageSelection.Controls.Add(Me.Label13)
        Me.TabPageSelection.Controls.Add(Me.lblRunningAt)
        Me.TabPageSelection.Controls.Add(Me.lblIncludeAllFanEfficiency)
        Me.TabPageSelection.Controls.Add(Me.lblIncludeReserveHead)
        Me.TabPageSelection.Controls.Add(Me.lblFanIndex)
        Me.TabPageSelection.Controls.Add(Me.lblVolumeTD)
        Me.TabPageSelection.Controls.Add(Me.lblReserveHead)
        Me.TabPageSelection.Controls.Add(Me.lblOutletVelocity)
        Me.TabPageSelection.Controls.Add(Me.lblFanTotalEfficiency)
        Me.TabPageSelection.Controls.Add(Me.lblFanStaticEfficiency)
        Me.TabPageSelection.Controls.Add(Me.lblMotorPower)
        Me.TabPageSelection.Controls.Add(Me.lblFanPower)
        Me.TabPageSelection.Controls.Add(Me.lblFanTotalPressure)
        Me.TabPageSelection.Controls.Add(Me.lblFanStaticPressure)
        Me.TabPageSelection.Controls.Add(Me.lblFlow)
        Me.TabPageSelection.Controls.Add(Me.lblSpeed)
        Me.TabPageSelection.Controls.Add(Me.lblType)
        Me.TabPageSelection.Controls.Add(Me.lblSize)
        Me.TabPageSelection.Controls.Add(Me.chkKP)
        Me.TabPageSelection.Controls.Add(Me.lblInstructions)
        Me.TabPageSelection.Controls.Add(Me.chkDisplayLowerEff)
        Me.TabPageSelection.Controls.Add(Me.chkDisplayAllResHead)
        Me.TabPageSelection.Controls.Add(Me.btnSelectionsExit)
        Me.TabPageSelection.Controls.Add(Me.Label19)
        Me.TabPageSelection.Controls.Add(Me.btnFanParametersBack)
        Me.TabPageSelection.Controls.Add(Me.btnNoiseDataForward)
        Me.TabPageSelection.Controls.Add(Me.LblFanDetails)
        Me.TabPageSelection.Controls.Add(Me.Label3)
        Me.TabPageSelection.Controls.Add(Me.BtnClose)
        Me.TabPageSelection.Controls.Add(Me.Button4)
        Me.TabPageSelection.Controls.Add(Me.LblGasDensityUnit)
        Me.TabPageSelection.Controls.Add(Me.Label2)
        Me.TabPageSelection.Controls.Add(Me.TxtDensity)
        Me.TabPageSelection.Controls.Add(Me.Button3)
        Me.TabPageSelection.Controls.Add(Me.DataGridView1)
        Me.TabPageSelection.Name = "TabPageSelection"
        '
        'chkOriginalData
        '
        resources.ApplyResources(Me.chkOriginalData, "chkOriginalData")
        Me.chkOriginalData.ForeColor = System.Drawing.Color.Black
        Me.chkOriginalData.Name = "chkOriginalData"
        Me.chkOriginalData.UseVisualStyleBackColor = True
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'lblRunningAt
        '
        resources.ApplyResources(Me.lblRunningAt, "lblRunningAt")
        Me.lblRunningAt.Name = "lblRunningAt"
        '
        'lblIncludeAllFanEfficiency
        '
        resources.ApplyResources(Me.lblIncludeAllFanEfficiency, "lblIncludeAllFanEfficiency")
        Me.lblIncludeAllFanEfficiency.Name = "lblIncludeAllFanEfficiency"
        '
        'lblIncludeReserveHead
        '
        resources.ApplyResources(Me.lblIncludeReserveHead, "lblIncludeReserveHead")
        Me.lblIncludeReserveHead.Name = "lblIncludeReserveHead"
        '
        'lblFanIndex
        '
        resources.ApplyResources(Me.lblFanIndex, "lblFanIndex")
        Me.lblFanIndex.Name = "lblFanIndex"
        '
        'lblVolumeTD
        '
        resources.ApplyResources(Me.lblVolumeTD, "lblVolumeTD")
        Me.lblVolumeTD.Name = "lblVolumeTD"
        '
        'lblReserveHead
        '
        resources.ApplyResources(Me.lblReserveHead, "lblReserveHead")
        Me.lblReserveHead.Name = "lblReserveHead"
        '
        'lblOutletVelocity
        '
        resources.ApplyResources(Me.lblOutletVelocity, "lblOutletVelocity")
        Me.lblOutletVelocity.Name = "lblOutletVelocity"
        '
        'lblFanTotalEfficiency
        '
        resources.ApplyResources(Me.lblFanTotalEfficiency, "lblFanTotalEfficiency")
        Me.lblFanTotalEfficiency.Name = "lblFanTotalEfficiency"
        '
        'lblFanStaticEfficiency
        '
        resources.ApplyResources(Me.lblFanStaticEfficiency, "lblFanStaticEfficiency")
        Me.lblFanStaticEfficiency.Name = "lblFanStaticEfficiency"
        '
        'lblMotorPower
        '
        resources.ApplyResources(Me.lblMotorPower, "lblMotorPower")
        Me.lblMotorPower.Name = "lblMotorPower"
        '
        'lblFanPower
        '
        resources.ApplyResources(Me.lblFanPower, "lblFanPower")
        Me.lblFanPower.Name = "lblFanPower"
        '
        'lblFanTotalPressure
        '
        resources.ApplyResources(Me.lblFanTotalPressure, "lblFanTotalPressure")
        Me.lblFanTotalPressure.Name = "lblFanTotalPressure"
        '
        'lblFanStaticPressure
        '
        resources.ApplyResources(Me.lblFanStaticPressure, "lblFanStaticPressure")
        Me.lblFanStaticPressure.Name = "lblFanStaticPressure"
        '
        'lblFlow
        '
        resources.ApplyResources(Me.lblFlow, "lblFlow")
        Me.lblFlow.Name = "lblFlow"
        '
        'lblSpeed
        '
        resources.ApplyResources(Me.lblSpeed, "lblSpeed")
        Me.lblSpeed.Name = "lblSpeed"
        '
        'lblType
        '
        resources.ApplyResources(Me.lblType, "lblType")
        Me.lblType.Name = "lblType"
        '
        'lblSize
        '
        resources.ApplyResources(Me.lblSize, "lblSize")
        Me.lblSize.Name = "lblSize"
        '
        'chkKP
        '
        resources.ApplyResources(Me.chkKP, "chkKP")
        Me.chkKP.ForeColor = System.Drawing.Color.Black
        Me.chkKP.Name = "chkKP"
        Me.chkKP.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        resources.ApplyResources(Me.lblInstructions, "lblInstructions")
        Me.lblInstructions.ForeColor = System.Drawing.Color.Red
        Me.lblInstructions.Name = "lblInstructions"
        '
        'chkDisplayLowerEff
        '
        resources.ApplyResources(Me.chkDisplayLowerEff, "chkDisplayLowerEff")
        Me.chkDisplayLowerEff.ForeColor = System.Drawing.Color.Black
        Me.chkDisplayLowerEff.Name = "chkDisplayLowerEff"
        Me.chkDisplayLowerEff.UseVisualStyleBackColor = True
        '
        'chkDisplayAllResHead
        '
        resources.ApplyResources(Me.chkDisplayAllResHead, "chkDisplayAllResHead")
        Me.chkDisplayAllResHead.ForeColor = System.Drawing.Color.Black
        Me.chkDisplayAllResHead.Name = "chkDisplayAllResHead"
        Me.chkDisplayAllResHead.UseVisualStyleBackColor = True
        '
        'btnSelectionsExit
        '
        resources.ApplyResources(Me.btnSelectionsExit, "btnSelectionsExit")
        Me.btnSelectionsExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSelectionsExit.Name = "btnSelectionsExit"
        Me.btnSelectionsExit.UseVisualStyleBackColor = True
        '
        'Label19
        '
        resources.ApplyResources(Me.Label19, "Label19")
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Name = "Label19"
        '
        'btnFanParametersBack
        '
        resources.ApplyResources(Me.btnFanParametersBack, "btnFanParametersBack")
        Me.btnFanParametersBack.Name = "btnFanParametersBack"
        Me.btnFanParametersBack.UseVisualStyleBackColor = True
        '
        'btnNoiseDataForward
        '
        resources.ApplyResources(Me.btnNoiseDataForward, "btnNoiseDataForward")
        Me.btnNoiseDataForward.Name = "btnNoiseDataForward"
        Me.btnNoiseDataForward.UseVisualStyleBackColor = True
        '
        'LblFanDetails
        '
        resources.ApplyResources(Me.LblFanDetails, "LblFanDetails")
        Me.LblFanDetails.BackColor = System.Drawing.Color.Transparent
        Me.LblFanDetails.ForeColor = System.Drawing.Color.Black
        Me.LblFanDetails.Name = "LblFanDetails"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Name = "Label3"
        '
        'BtnClose
        '
        resources.ApplyResources(Me.BtnClose, "BtnClose")
        Me.BtnClose.ForeColor = System.Drawing.Color.Black
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'Button4
        '
        resources.ApplyResources(Me.Button4, "Button4")
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Name = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'LblGasDensityUnit
        '
        resources.ApplyResources(Me.LblGasDensityUnit, "LblGasDensityUnit")
        Me.LblGasDensityUnit.BackColor = System.Drawing.Color.Transparent
        Me.LblGasDensityUnit.ForeColor = System.Drawing.Color.Black
        Me.LblGasDensityUnit.Name = "LblGasDensityUnit"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Name = "Label2"
        '
        'TxtDensity
        '
        resources.ApplyResources(Me.TxtDensity, "TxtDensity")
        Me.TxtDensity.BackColor = System.Drawing.Color.White
        Me.TxtDensity.ForeColor = System.Drawing.Color.Black
        Me.TxtDensity.Name = "TxtDensity"
        '
        'Button3
        '
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        resources.ApplyResources(Me.DataGridView1, "DataGridView1")
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        '
        'TabPageNoise
        '
        resources.ApplyResources(Me.TabPageNoise, "TabPageNoise")
        Me.TabPageNoise.BackColor = System.Drawing.Color.Transparent
        Me.TabPageNoise.BackgroundImage = Global.Halifax_Fan_Selector.My.Resources.Resources._0_faded1
        Me.TabPageNoise.Controls.Add(Me.lblOverall)
        Me.TabPageNoise.Controls.Add(Me.lblBand)
        Me.TabPageNoise.Controls.Add(Me.lblSWL1m)
        Me.TabPageNoise.Controls.Add(Me.lblSPL1m)
        Me.TabPageNoise.Controls.Add(Me.lblSoundPowerLevel)
        Me.TabPageNoise.Controls.Add(Me.lblBreakOut)
        Me.TabPageNoise.Controls.Add(Me.lblBPF2)
        Me.TabPageNoise.Controls.Add(Me.lblBPF)
        Me.TabPageNoise.Controls.Add(Me.lblFreeFieldComment)
        Me.TabPageNoise.Controls.Add(Me.lblOutDims)
        Me.TabPageNoise.Controls.Add(Me.lblInDia)
        Me.TabPageNoise.Controls.Add(Me.lblOutletDimensions)
        Me.TabPageNoise.Controls.Add(Me.lblInletDiameter)
        Me.TabPageNoise.Controls.Add(Me.btnFanSelectionsBack)
        Me.TabPageNoise.Controls.Add(Me.btnImpellerDetailsForward)
        Me.TabPageNoise.Controls.Add(Me.GroupBox4)
        Me.TabPageNoise.Controls.Add(Me.GroupBox3)
        Me.TabPageNoise.Controls.Add(Me.TxtTypenoise)
        Me.TabPageNoise.Controls.Add(Me.Label18)
        Me.TabPageNoise.Controls.Add(Me.Label15)
        Me.TabPageNoise.Controls.Add(Me.TxtSizenoise)
        Me.TabPageNoise.Controls.Add(Me.Label16)
        Me.TabPageNoise.Controls.Add(Me.lblAcousticFSPUnits)
        Me.TabPageNoise.Controls.Add(Me.TxtStaticPressurenoise)
        Me.TabPageNoise.Controls.Add(Me.Label14)
        Me.TabPageNoise.Controls.Add(Me.Label6)
        Me.TabPageNoise.Controls.Add(Me.TxtSpeednoise)
        Me.TabPageNoise.Controls.Add(Me.Label12)
        Me.TabPageNoise.Controls.Add(Me.lblAcousticFlowUnits)
        Me.TabPageNoise.Controls.Add(Me.TxtFlownoise)
        Me.TabPageNoise.Controls.Add(Me.Label4)
        Me.TabPageNoise.Controls.Add(Me.GroupBox5)
        Me.TabPageNoise.Controls.Add(Me.btnNoiseExit)
        Me.TabPageNoise.Controls.Add(Me.Button5)
        Me.TabPageNoise.Controls.Add(Me.Button6)
        Me.TabPageNoise.Controls.Add(Me.DataGridView2)
        Me.TabPageNoise.Name = "TabPageNoise"
        '
        'lblOverall
        '
        resources.ApplyResources(Me.lblOverall, "lblOverall")
        Me.lblOverall.Name = "lblOverall"
        '
        'lblBand
        '
        resources.ApplyResources(Me.lblBand, "lblBand")
        Me.lblBand.Name = "lblBand"
        '
        'lblSWL1m
        '
        resources.ApplyResources(Me.lblSWL1m, "lblSWL1m")
        Me.lblSWL1m.Name = "lblSWL1m"
        '
        'lblSPL1m
        '
        resources.ApplyResources(Me.lblSPL1m, "lblSPL1m")
        Me.lblSPL1m.Name = "lblSPL1m"
        '
        'lblSoundPowerLevel
        '
        resources.ApplyResources(Me.lblSoundPowerLevel, "lblSoundPowerLevel")
        Me.lblSoundPowerLevel.Name = "lblSoundPowerLevel"
        '
        'lblBreakOut
        '
        resources.ApplyResources(Me.lblBreakOut, "lblBreakOut")
        Me.lblBreakOut.Name = "lblBreakOut"
        '
        'lblBPF2
        '
        resources.ApplyResources(Me.lblBPF2, "lblBPF2")
        Me.lblBPF2.Name = "lblBPF2"
        '
        'lblBPF
        '
        resources.ApplyResources(Me.lblBPF, "lblBPF")
        Me.lblBPF.Name = "lblBPF"
        '
        'lblFreeFieldComment
        '
        resources.ApplyResources(Me.lblFreeFieldComment, "lblFreeFieldComment")
        Me.lblFreeFieldComment.ForeColor = System.Drawing.Color.Blue
        Me.lblFreeFieldComment.Name = "lblFreeFieldComment"
        '
        'lblOutDims
        '
        resources.ApplyResources(Me.lblOutDims, "lblOutDims")
        Me.lblOutDims.Name = "lblOutDims"
        '
        'lblInDia
        '
        resources.ApplyResources(Me.lblInDia, "lblInDia")
        Me.lblInDia.Name = "lblInDia"
        '
        'lblOutletDimensions
        '
        resources.ApplyResources(Me.lblOutletDimensions, "lblOutletDimensions")
        Me.lblOutletDimensions.Name = "lblOutletDimensions"
        '
        'lblInletDiameter
        '
        resources.ApplyResources(Me.lblInletDiameter, "lblInletDiameter")
        Me.lblInletDiameter.Name = "lblInletDiameter"
        '
        'btnFanSelectionsBack
        '
        resources.ApplyResources(Me.btnFanSelectionsBack, "btnFanSelectionsBack")
        Me.btnFanSelectionsBack.Name = "btnFanSelectionsBack"
        Me.btnFanSelectionsBack.UseVisualStyleBackColor = True
        '
        'btnImpellerDetailsForward
        '
        resources.ApplyResources(Me.btnImpellerDetailsForward, "btnImpellerDetailsForward")
        Me.btnImpellerDetailsForward.Name = "btnImpellerDetailsForward"
        Me.btnImpellerDetailsForward.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        resources.ApplyResources(Me.GroupBox4, "GroupBox4")
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.txtMotordba)
        Me.GroupBox4.Controls.Add(Me.chkMotor)
        Me.GroupBox4.Controls.Add(Me.chkBrg)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.TabStop = False
        '
        'Label17
        '
        resources.ApplyResources(Me.Label17, "Label17")
        Me.Label17.Name = "Label17"
        '
        'txtMotordba
        '
        resources.ApplyResources(Me.txtMotordba, "txtMotordba")
        Me.txtMotordba.Name = "txtMotordba"
        '
        'chkMotor
        '
        resources.ApplyResources(Me.chkMotor, "chkMotor")
        Me.chkMotor.Name = "chkMotor"
        Me.chkMotor.UseVisualStyleBackColor = True
        '
        'chkBrg
        '
        resources.ApplyResources(Me.chkBrg, "chkBrg")
        Me.chkBrg.Checked = True
        Me.chkBrg.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBrg.Name = "chkBrg"
        Me.chkBrg.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.chkOpenOutlet)
        Me.GroupBox3.Controls.Add(Me.chkOpenInlet)
        Me.GroupBox3.Controls.Add(Me.chkDuct)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'chkOpenOutlet
        '
        resources.ApplyResources(Me.chkOpenOutlet, "chkOpenOutlet")
        Me.chkOpenOutlet.Checked = True
        Me.chkOpenOutlet.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkOpenOutlet.Name = "chkOpenOutlet"
        Me.chkOpenOutlet.UseVisualStyleBackColor = True
        '
        'chkOpenInlet
        '
        resources.ApplyResources(Me.chkOpenInlet, "chkOpenInlet")
        Me.chkOpenInlet.Checked = True
        Me.chkOpenInlet.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkOpenInlet.Name = "chkOpenInlet"
        Me.chkOpenInlet.UseVisualStyleBackColor = True
        '
        'chkDuct
        '
        resources.ApplyResources(Me.chkDuct, "chkDuct")
        Me.chkDuct.Checked = True
        Me.chkDuct.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDuct.Name = "chkDuct"
        Me.chkDuct.UseVisualStyleBackColor = True
        '
        'TxtTypenoise
        '
        resources.ApplyResources(Me.TxtTypenoise, "TxtTypenoise")
        Me.TxtTypenoise.BackColor = System.Drawing.Color.White
        Me.TxtTypenoise.ForeColor = System.Drawing.Color.Black
        Me.TxtTypenoise.Name = "TxtTypenoise"
        Me.TxtTypenoise.ReadOnly = True
        '
        'Label18
        '
        resources.ApplyResources(Me.Label18, "Label18")
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Name = "Label18"
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Name = "Label15"
        '
        'TxtSizenoise
        '
        resources.ApplyResources(Me.TxtSizenoise, "TxtSizenoise")
        Me.TxtSizenoise.BackColor = System.Drawing.Color.White
        Me.TxtSizenoise.ForeColor = System.Drawing.Color.Black
        Me.TxtSizenoise.Name = "TxtSizenoise"
        Me.TxtSizenoise.ReadOnly = True
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Name = "Label16"
        '
        'lblAcousticFSPUnits
        '
        resources.ApplyResources(Me.lblAcousticFSPUnits, "lblAcousticFSPUnits")
        Me.lblAcousticFSPUnits.BackColor = System.Drawing.Color.Transparent
        Me.lblAcousticFSPUnits.ForeColor = System.Drawing.Color.Black
        Me.lblAcousticFSPUnits.Name = "lblAcousticFSPUnits"
        '
        'TxtStaticPressurenoise
        '
        resources.ApplyResources(Me.TxtStaticPressurenoise, "TxtStaticPressurenoise")
        Me.TxtStaticPressurenoise.BackColor = System.Drawing.Color.White
        Me.TxtStaticPressurenoise.ForeColor = System.Drawing.Color.Black
        Me.TxtStaticPressurenoise.Name = "TxtStaticPressurenoise"
        Me.TxtStaticPressurenoise.ReadOnly = True
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Name = "Label14"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Name = "Label6"
        '
        'TxtSpeednoise
        '
        resources.ApplyResources(Me.TxtSpeednoise, "TxtSpeednoise")
        Me.TxtSpeednoise.BackColor = System.Drawing.Color.White
        Me.TxtSpeednoise.ForeColor = System.Drawing.Color.Black
        Me.TxtSpeednoise.Name = "TxtSpeednoise"
        Me.TxtSpeednoise.ReadOnly = True
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Name = "Label12"
        '
        'lblAcousticFlowUnits
        '
        resources.ApplyResources(Me.lblAcousticFlowUnits, "lblAcousticFlowUnits")
        Me.lblAcousticFlowUnits.BackColor = System.Drawing.Color.Transparent
        Me.lblAcousticFlowUnits.ForeColor = System.Drawing.Color.Black
        Me.lblAcousticFlowUnits.Name = "lblAcousticFlowUnits"
        '
        'TxtFlownoise
        '
        resources.ApplyResources(Me.TxtFlownoise, "TxtFlownoise")
        Me.TxtFlownoise.BackColor = System.Drawing.Color.White
        Me.TxtFlownoise.ForeColor = System.Drawing.Color.Black
        Me.TxtFlownoise.Name = "TxtFlownoise"
        Me.TxtFlownoise.ReadOnly = True
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Name = "Label4"
        '
        'GroupBox5
        '
        resources.ApplyResources(Me.GroupBox5, "GroupBox5")
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.lblAcousticFTPUnits)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.TxtTotalPressurenoise)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.TabStop = False
        '
        'lblAcousticFTPUnits
        '
        resources.ApplyResources(Me.lblAcousticFTPUnits, "lblAcousticFTPUnits")
        Me.lblAcousticFTPUnits.BackColor = System.Drawing.Color.Transparent
        Me.lblAcousticFTPUnits.ForeColor = System.Drawing.Color.Black
        Me.lblAcousticFTPUnits.Name = "lblAcousticFTPUnits"
        '
        'Label20
        '
        resources.ApplyResources(Me.Label20, "Label20")
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Name = "Label20"
        '
        'TxtTotalPressurenoise
        '
        resources.ApplyResources(Me.TxtTotalPressurenoise, "TxtTotalPressurenoise")
        Me.TxtTotalPressurenoise.BackColor = System.Drawing.Color.White
        Me.TxtTotalPressurenoise.ForeColor = System.Drawing.Color.Black
        Me.TxtTotalPressurenoise.Name = "TxtTotalPressurenoise"
        Me.TxtTotalPressurenoise.ReadOnly = True
        '
        'btnNoiseExit
        '
        resources.ApplyResources(Me.btnNoiseExit, "btnNoiseExit")
        Me.btnNoiseExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNoiseExit.Name = "btnNoiseExit"
        Me.btnNoiseExit.UseVisualStyleBackColor = True
        '
        'Button5
        '
        resources.ApplyResources(Me.Button5, "Button5")
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Name = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        resources.ApplyResources(Me.Button6, "Button6")
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Name = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        resources.ApplyResources(Me.DataGridView2, "DataGridView2")
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowTemplate.Height = 24
        '
        'TabPageImpeller
        '
        resources.ApplyResources(Me.TabPageImpeller, "TabPageImpeller")
        Me.TabPageImpeller.BackgroundImage = Global.Halifax_Fan_Selector.My.Resources.Resources._0_faded1
        Me.TabPageImpeller.Controls.Add(Me.lblPhase2)
        Me.TabPageImpeller.Controls.Add(Me.btnNoiseDataBack)
        Me.TabPageImpeller.Controls.Add(Me.Button2)
        Me.TabPageImpeller.Name = "TabPageImpeller"
        Me.TabPageImpeller.UseVisualStyleBackColor = True
        '
        'lblPhase2
        '
        resources.ApplyResources(Me.lblPhase2, "lblPhase2")
        Me.lblPhase2.Name = "lblPhase2"
        '
        'btnNoiseDataBack
        '
        resources.ApplyResources(Me.btnNoiseDataBack, "btnNoiseDataBack")
        Me.btnNoiseDataBack.Name = "btnNoiseDataBack"
        Me.btnNoiseDataBack.UseVisualStyleBackColor = True
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ProjectDetailsToolStripMenuItem, Me.UnitsToolStripMenuItem, Me.AdditionalFunctionsToolStripMenuItem})
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        resources.ApplyResources(Me.FileToolStripMenuItem, "FileToolStripMenuItem")
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.OpenProjectToolStripMenuItem, Me.SaveProjectToolStripMenuItem, Me.PrintToolStripMenuItem, Me.ExitProjectToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        '
        'OpenToolStripMenuItem
        '
        resources.ApplyResources(Me.OpenToolStripMenuItem, "OpenToolStripMenuItem")
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        '
        'OpenProjectToolStripMenuItem
        '
        resources.ApplyResources(Me.OpenProjectToolStripMenuItem, "OpenProjectToolStripMenuItem")
        Me.OpenProjectToolStripMenuItem.Name = "OpenProjectToolStripMenuItem"
        '
        'SaveProjectToolStripMenuItem
        '
        resources.ApplyResources(Me.SaveProjectToolStripMenuItem, "SaveProjectToolStripMenuItem")
        Me.SaveProjectToolStripMenuItem.Name = "SaveProjectToolStripMenuItem"
        '
        'PrintToolStripMenuItem
        '
        resources.ApplyResources(Me.PrintToolStripMenuItem, "PrintToolStripMenuItem")
        Me.PrintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllPagesToolStripMenuItem, Me.PerformanceDetailsToolStripMenuItem, Me.AcousticsDetailsToolStripMenuItem, Me.PerformanceCurveToolStripMenuItem, Me.ToolStripSeparator1, Me.AllPages2ToolStripMenuItem, Me.PerformanceDetails2ToolStripMenuItem, Me.AcousticDetails2ToolStripMenuItem, Me.FanCurve2ToolStripMenuItem})
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        '
        'AllPagesToolStripMenuItem
        '
        resources.ApplyResources(Me.AllPagesToolStripMenuItem, "AllPagesToolStripMenuItem")
        Me.AllPagesToolStripMenuItem.Name = "AllPagesToolStripMenuItem"
        '
        'PerformanceDetailsToolStripMenuItem
        '
        resources.ApplyResources(Me.PerformanceDetailsToolStripMenuItem, "PerformanceDetailsToolStripMenuItem")
        Me.PerformanceDetailsToolStripMenuItem.Name = "PerformanceDetailsToolStripMenuItem"
        '
        'AcousticsDetailsToolStripMenuItem
        '
        resources.ApplyResources(Me.AcousticsDetailsToolStripMenuItem, "AcousticsDetailsToolStripMenuItem")
        Me.AcousticsDetailsToolStripMenuItem.Name = "AcousticsDetailsToolStripMenuItem"
        '
        'PerformanceCurveToolStripMenuItem
        '
        resources.ApplyResources(Me.PerformanceCurveToolStripMenuItem, "PerformanceCurveToolStripMenuItem")
        Me.PerformanceCurveToolStripMenuItem.Name = "PerformanceCurveToolStripMenuItem"
        '
        'ToolStripSeparator1
        '
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        '
        'AllPages2ToolStripMenuItem
        '
        resources.ApplyResources(Me.AllPages2ToolStripMenuItem, "AllPages2ToolStripMenuItem")
        Me.AllPages2ToolStripMenuItem.Name = "AllPages2ToolStripMenuItem"
        '
        'PerformanceDetails2ToolStripMenuItem
        '
        resources.ApplyResources(Me.PerformanceDetails2ToolStripMenuItem, "PerformanceDetails2ToolStripMenuItem")
        Me.PerformanceDetails2ToolStripMenuItem.Name = "PerformanceDetails2ToolStripMenuItem"
        '
        'AcousticDetails2ToolStripMenuItem
        '
        resources.ApplyResources(Me.AcousticDetails2ToolStripMenuItem, "AcousticDetails2ToolStripMenuItem")
        Me.AcousticDetails2ToolStripMenuItem.Name = "AcousticDetails2ToolStripMenuItem"
        '
        'FanCurve2ToolStripMenuItem
        '
        resources.ApplyResources(Me.FanCurve2ToolStripMenuItem, "FanCurve2ToolStripMenuItem")
        Me.FanCurve2ToolStripMenuItem.Name = "FanCurve2ToolStripMenuItem"
        '
        'ExitProjectToolStripMenuItem
        '
        resources.ApplyResources(Me.ExitProjectToolStripMenuItem, "ExitProjectToolStripMenuItem")
        Me.ExitProjectToolStripMenuItem.Name = "ExitProjectToolStripMenuItem"
        '
        'ProjectDetailsToolStripMenuItem
        '
        resources.ApplyResources(Me.ProjectDetailsToolStripMenuItem, "ProjectDetailsToolStripMenuItem")
        Me.ProjectDetailsToolStripMenuItem.Name = "ProjectDetailsToolStripMenuItem"
        '
        'UnitsToolStripMenuItem
        '
        resources.ApplyResources(Me.UnitsToolStripMenuItem, "UnitsToolStripMenuItem")
        Me.UnitsToolStripMenuItem.Name = "UnitsToolStripMenuItem"
        '
        'AdditionalFunctionsToolStripMenuItem
        '
        resources.ApplyResources(Me.AdditionalFunctionsToolStripMenuItem, "AdditionalFunctionsToolStripMenuItem")
        Me.AdditionalFunctionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StandaloneCurveToolStripMenuItem})
        Me.AdditionalFunctionsToolStripMenuItem.Name = "AdditionalFunctionsToolStripMenuItem"
        '
        'StandaloneCurveToolStripMenuItem
        '
        resources.ApplyResources(Me.StandaloneCurveToolStripMenuItem, "StandaloneCurveToolStripMenuItem")
        Me.StandaloneCurveToolStripMenuItem.Name = "StandaloneCurveToolStripMenuItem"
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.Halifax_Fan_Selector.My.Resources.Resources.Logo_2019a
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'Frmselectfan
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnDutyExit
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frmselectfan"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageGeneral.ResumeLayout(False)
        Me.TabPageGeneral.PerformLayout()
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
        Me.GrpGeneral.ResumeLayout(False)
        Me.GrpGeneral.PerformLayout()
        Me.TabPageDuty.ResumeLayout(False)
        Me.TabPageDuty.PerformLayout()
        Me.GrpFlowRate.ResumeLayout(False)
        Me.GrpFlowRate.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GrpDesignPressure.ResumeLayout(False)
        Me.GrpDesignPressure.PerformLayout()
        Me.GrpInletDensity.ResumeLayout(False)
        Me.GrpInletDensity.PerformLayout()
        Me.GrpInletTemperature.ResumeLayout(False)
        Me.GrpInletTemperature.PerformLayout()
        Me.TabPageFanParameters.ResumeLayout(False)
        Me.TabPageFanParameters.PerformLayout()
        Me.GrpFanSize.ResumeLayout(False)
        Me.GrpFanSize.PerformLayout()
        Me.GrpFanSpeed.ResumeLayout(False)
        Me.GrpFanSpeed.PerformLayout()
        Me.GrpFanTypes.ResumeLayout(False)
        Me.GrpFanTypes.PerformLayout()
        Me.TabPageSelection.ResumeLayout(False)
        Me.TabPageSelection.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageNoise.ResumeLayout(False)
        Me.TabPageNoise.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageImpeller.ResumeLayout(False)
        Me.TabPageImpeller.PerformLayout()
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
    Friend WithEvents TabPageSelection As TabPage
    Friend WithEvents TabPageNoise As TabPage
    Friend WithEvents btnDutyExit As Button
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
    Friend WithEvents optDDStandard As RadioButton
    Friend WithEvents optDDRatio As RadioButton
    Friend WithEvents Optsucy As CheckBox
    Friend WithEvents BtnClose As Button
    Friend WithEvents LblGasDensityUnit As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtDensity As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents LblFanDetails As Label
    Friend WithEvents TxtTypenoise As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtSizenoise As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents lblAcousticFSPUnits As Label
    Friend WithEvents TxtStaticPressurenoise As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtSpeednoise As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lblAcousticFlowUnits As Label
    Friend WithEvents TxtFlownoise As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtMotordba As TextBox
    Friend WithEvents chkMotor As CheckBox
    Friend WithEvents chkBrg As CheckBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TabPageGeneral As TabPage
    Friend WithEvents GrpFrequency As GroupBox
    Friend WithEvents Opt50Hz As RadioButton
    Friend WithEvents Opt60Hz As RadioButton
    Friend WithEvents GrpGeneral As GroupBox
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
    Friend WithEvents OptAnySpeed As RadioButton
    Friend WithEvents btnCalculateDensity As Button
    Friend WithEvents btnDutyInputForward As Button
    Friend WithEvents btnGeneralInformationBack As Button
    Friend WithEvents btnFanParametersForward As Button
    Friend WithEvents btnFanSelectionsForward As Button
    Friend WithEvents btnFanParametersBack As Button
    Friend WithEvents btnNoiseDataForward As Button
    Friend WithEvents btnFanSelectionsBack As Button
    Friend WithEvents btnImpellerDetailsForward As Button
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents OptVelocityFtpermin As RadioButton
    Friend WithEvents OptVelocityMpers As RadioButton
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents OptPowerHp As RadioButton
    Friend WithEvents OptPowerKW As RadioButton
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents OptAltitudeFt As RadioButton
    Friend WithEvents OptAltitudeM As RadioButton
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
    Friend WithEvents btnImperialUnits As Button
    Friend WithEvents btnMetricUnits As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents btnGeneralExit As Button
    Friend WithEvents btnParametersExit As Button
    Friend WithEvents btnSelectionsExit As Button
    Friend WithEvents btnNoiseExit As Button
    Friend WithEvents btnDutyInputBack As Button
    Friend WithEvents OptPowerBoth As RadioButton
    Friend WithEvents OptPressurekPa As RadioButton
    Friend WithEvents lblpercent As Label
    Friend WithEvents lblUserDefinedUnits As Label
    Friend WithEvents txtRatioDD As TextBox
    Friend WithEvents txtUserDefinedDD As TextBox
    Friend WithEvents optDDUserDefined As RadioButton
    Friend WithEvents chkDisplayAllResHead As CheckBox
    Friend WithEvents chkDisplayLowerEff As CheckBox
    Friend WithEvents lblInstructions As Label
    Friend WithEvents chkOpenOutlet As CheckBox
    Friend WithEvents chkOpenInlet As CheckBox
    Friend WithEvents chkDuct As CheckBox
    Friend WithEvents lblOutDims As Label
    Friend WithEvents lblInDia As Label
    Friend WithEvents lblOutletDimensions As Label
    Friend WithEvents lblInletDiameter As Label
    Friend WithEvents chkKP As CheckBox
    Friend WithEvents chkDIDW As CheckBox
    Friend WithEvents chkCalcAtmos As CheckBox
    Friend WithEvents chkAllBlades As CheckBox
    Friend WithEvents lblFreeFieldComment As Label
    Friend WithEvents lblFlowType As Label
    Friend WithEvents OptFixedSpeed As RadioButton
    Friend WithEvents lblBPF2 As Label
    Friend WithEvents lblBPF As Label
    Friend WithEvents PerformanceDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcousticsDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllPagesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblDisplayBoth As Label
    Friend WithEvents lblChkAtmosAlt As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblAcousticFTPUnits As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtTotalPressurenoise As TextBox
    Friend WithEvents lblBreakOut As Label
    Friend WithEvents lblSoundPowerLevel As Label
    Friend WithEvents lblSWL1m As Label
    Friend WithEvents lblSPL1m As Label
    Friend WithEvents lblOverall As Label
    Friend WithEvents lblBand As Label
    Friend WithEvents lblFanIndex As Label
    Friend WithEvents lblVolumeTD As Label
    Friend WithEvents lblReserveHead As Label
    Friend WithEvents lblOutletVelocity As Label
    Friend WithEvents lblFanTotalEfficiency As Label
    Friend WithEvents lblFanStaticEfficiency As Label
    Friend WithEvents lblMotorPower As Label
    Friend WithEvents lblFanPower As Label
    Friend WithEvents lblFanTotalPressure As Label
    Friend WithEvents lblFanStaticPressure As Label
    Friend WithEvents lblFlow As Label
    Friend WithEvents lblSpeed As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblSize As Label
    Friend WithEvents lblIncludeReserveHead As Label
    Friend WithEvents lblIncludeAllFanEfficiency As Label
    Friend WithEvents lblMassFlow As Label
    Friend WithEvents lblVolumeFlow As Label
    Friend WithEvents lblRunningAt As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TabPageImpeller As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents btnNoiseDataBack As Button
    Friend WithEvents lblPhase2 As Label
    Friend WithEvents PerformanceCurveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AllPages2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PerformanceDetails2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcousticDetails2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FanCurve2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents chkOriginalData As CheckBox
    Friend WithEvents lblSaveProject As Label
    Friend WithEvents chkNarrow As CheckBox
    Friend WithEvents chkMedium As CheckBox
    Friend WithEvents chkWide As CheckBox
    Friend WithEvents chkPaddleBlade As CheckBox
    Friend WithEvents chkHighPressure As CheckBox
    Friend WithEvents chkRadialBlade As CheckBox
    Friend WithEvents Label21 As Label
    Friend WithEvents lblOutVelUnit As Label
    Friend WithEvents txtOutVel As TextBox
    Friend WithEvents lblOutVel As Label
    Friend WithEvents AdditionalFunctionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StandaloneCurveToolStripMenuItem As ToolStripMenuItem
End Class
