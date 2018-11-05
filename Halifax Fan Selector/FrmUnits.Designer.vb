<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUnits
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OptTemperatureF = New System.Windows.Forms.RadioButton()
        Me.OptTemperatureC = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OptFlowLbPerHr = New System.Windows.Forms.RadioButton()
        Me.OptFlowKgPerHr = New System.Windows.Forms.RadioButton()
        Me.OptFlowCfm = New System.Windows.Forms.RadioButton()
        Me.OptFlowM3PerHr = New System.Windows.Forms.RadioButton()
        Me.OptFlowM3PerMin = New System.Windows.Forms.RadioButton()
        Me.OptFlowM3PerSec = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.OptPressuremmWG = New System.Windows.Forms.RadioButton()
        Me.OptPressureinWG = New System.Windows.Forms.RadioButton()
        Me.OptPressuremBar = New System.Windows.Forms.RadioButton()
        Me.OptPressurePa = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.OptDensityLbPerFt3 = New System.Windows.Forms.RadioButton()
        Me.OptDensityKgPerM3 = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.OptLengthIn = New System.Windows.Forms.RadioButton()
        Me.OptLengthMm = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.OptDefaultNone = New System.Windows.Forms.RadioButton()
        Me.OptDefaultImperial = New System.Windows.Forms.RadioButton()
        Me.OptDefaultMetric = New System.Windows.Forms.RadioButton()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.OptAltitudeFt = New System.Windows.Forms.RadioButton()
        Me.OptAltitudeM = New System.Windows.Forms.RadioButton()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.OptPowerHp = New System.Windows.Forms.RadioButton()
        Me.OptPowerKW = New System.Windows.Forms.RadioButton()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.OptVelocityFtpermin = New System.Windows.Forms.RadioButton()
        Me.OptVelocityMpers = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox1.Controls.Add(Me.OptTemperatureF)
        Me.GroupBox1.Controls.Add(Me.OptTemperatureC)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(15, 373)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 90)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Temperature"
        '
        'OptTemperatureF
        '
        Me.OptTemperatureF.AutoSize = True
        Me.OptTemperatureF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptTemperatureF.ForeColor = System.Drawing.Color.White
        Me.OptTemperatureF.Location = New System.Drawing.Point(32, 60)
        Me.OptTemperatureF.Name = "OptTemperatureF"
        Me.OptTemperatureF.Size = New System.Drawing.Size(46, 22)
        Me.OptTemperatureF.TabIndex = 1
        Me.OptTemperatureF.TabStop = True
        Me.OptTemperatureF.Text = "°F"
        Me.OptTemperatureF.UseVisualStyleBackColor = True
        '
        'OptTemperatureC
        '
        Me.OptTemperatureC.AutoSize = True
        Me.OptTemperatureC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptTemperatureC.ForeColor = System.Drawing.Color.White
        Me.OptTemperatureC.Location = New System.Drawing.Point(32, 33)
        Me.OptTemperatureC.Name = "OptTemperatureC"
        Me.OptTemperatureC.Size = New System.Drawing.Size(48, 22)
        Me.OptTemperatureC.TabIndex = 0
        Me.OptTemperatureC.TabStop = True
        Me.OptTemperatureC.Text = "°C"
        Me.OptTemperatureC.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox2.Controls.Add(Me.OptFlowLbPerHr)
        Me.GroupBox2.Controls.Add(Me.OptFlowKgPerHr)
        Me.GroupBox2.Controls.Add(Me.OptFlowCfm)
        Me.GroupBox2.Controls.Add(Me.OptFlowM3PerHr)
        Me.GroupBox2.Controls.Add(Me.OptFlowM3PerMin)
        Me.GroupBox2.Controls.Add(Me.OptFlowM3PerSec)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 189)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Flow"
        '
        'OptFlowLbPerHr
        '
        Me.OptFlowLbPerHr.AutoSize = True
        Me.OptFlowLbPerHr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptFlowLbPerHr.ForeColor = System.Drawing.Color.White
        Me.OptFlowLbPerHr.Location = New System.Drawing.Point(29, 157)
        Me.OptFlowLbPerHr.Name = "OptFlowLbPerHr"
        Me.OptFlowLbPerHr.Size = New System.Drawing.Size(62, 22)
        Me.OptFlowLbPerHr.TabIndex = 5
        Me.OptFlowLbPerHr.TabStop = True
        Me.OptFlowLbPerHr.Text = "lb/hr"
        Me.OptFlowLbPerHr.UseVisualStyleBackColor = True
        '
        'OptFlowKgPerHr
        '
        Me.OptFlowKgPerHr.AutoSize = True
        Me.OptFlowKgPerHr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptFlowKgPerHr.ForeColor = System.Drawing.Color.White
        Me.OptFlowKgPerHr.Location = New System.Drawing.Point(29, 129)
        Me.OptFlowKgPerHr.Name = "OptFlowKgPerHr"
        Me.OptFlowKgPerHr.Size = New System.Drawing.Size(67, 22)
        Me.OptFlowKgPerHr.TabIndex = 4
        Me.OptFlowKgPerHr.TabStop = True
        Me.OptFlowKgPerHr.Text = "kg/hr"
        Me.OptFlowKgPerHr.UseVisualStyleBackColor = True
        '
        'OptFlowCfm
        '
        Me.OptFlowCfm.AutoSize = True
        Me.OptFlowCfm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptFlowCfm.ForeColor = System.Drawing.Color.White
        Me.OptFlowCfm.Location = New System.Drawing.Point(29, 102)
        Me.OptFlowCfm.Name = "OptFlowCfm"
        Me.OptFlowCfm.Size = New System.Drawing.Size(57, 22)
        Me.OptFlowCfm.TabIndex = 3
        Me.OptFlowCfm.TabStop = True
        Me.OptFlowCfm.Text = "cfm"
        Me.OptFlowCfm.UseVisualStyleBackColor = True
        '
        'OptFlowM3PerHr
        '
        Me.OptFlowM3PerHr.AutoSize = True
        Me.OptFlowM3PerHr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptFlowM3PerHr.ForeColor = System.Drawing.Color.White
        Me.OptFlowM3PerHr.Location = New System.Drawing.Point(30, 21)
        Me.OptFlowM3PerHr.Name = "OptFlowM3PerHr"
        Me.OptFlowM3PerHr.Size = New System.Drawing.Size(69, 22)
        Me.OptFlowM3PerHr.TabIndex = 0
        Me.OptFlowM3PerHr.TabStop = True
        Me.OptFlowM3PerHr.Text = "m³/hr"
        Me.OptFlowM3PerHr.UseVisualStyleBackColor = True
        '
        'OptFlowM3PerMin
        '
        Me.OptFlowM3PerMin.AutoSize = True
        Me.OptFlowM3PerMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptFlowM3PerMin.ForeColor = System.Drawing.Color.White
        Me.OptFlowM3PerMin.Location = New System.Drawing.Point(29, 48)
        Me.OptFlowM3PerMin.Name = "OptFlowM3PerMin"
        Me.OptFlowM3PerMin.Size = New System.Drawing.Size(81, 22)
        Me.OptFlowM3PerMin.TabIndex = 1
        Me.OptFlowM3PerMin.TabStop = True
        Me.OptFlowM3PerMin.Text = "m³/min"
        Me.OptFlowM3PerMin.UseVisualStyleBackColor = True
        '
        'OptFlowM3PerSec
        '
        Me.OptFlowM3PerSec.AutoSize = True
        Me.OptFlowM3PerSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptFlowM3PerSec.ForeColor = System.Drawing.Color.White
        Me.OptFlowM3PerSec.Location = New System.Drawing.Point(29, 75)
        Me.OptFlowM3PerSec.Name = "OptFlowM3PerSec"
        Me.OptFlowM3PerSec.Size = New System.Drawing.Size(81, 22)
        Me.OptFlowM3PerSec.TabIndex = 2
        Me.OptFlowM3PerSec.TabStop = True
        Me.OptFlowM3PerSec.Text = "m³/sec"
        Me.OptFlowM3PerSec.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox3.Controls.Add(Me.OptPressuremmWG)
        Me.GroupBox3.Controls.Add(Me.OptPressureinWG)
        Me.GroupBox3.Controls.Add(Me.OptPressuremBar)
        Me.GroupBox3.Controls.Add(Me.OptPressurePa)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(15, 207)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 152)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pressure"
        '
        'OptPressuremmWG
        '
        Me.OptPressuremmWG.AutoSize = True
        Me.OptPressuremmWG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptPressuremmWG.ForeColor = System.Drawing.Color.White
        Me.OptPressuremmWG.Location = New System.Drawing.Point(23, 114)
        Me.OptPressuremmWG.Name = "OptPressuremmWG"
        Me.OptPressuremmWG.Size = New System.Drawing.Size(86, 22)
        Me.OptPressuremmWG.TabIndex = 3
        Me.OptPressuremmWG.TabStop = True
        Me.OptPressuremmWG.Text = "mmWG"
        Me.OptPressuremmWG.UseVisualStyleBackColor = True
        '
        'OptPressureinWG
        '
        Me.OptPressureinWG.AutoSize = True
        Me.OptPressureinWG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptPressureinWG.ForeColor = System.Drawing.Color.White
        Me.OptPressureinWG.Location = New System.Drawing.Point(23, 87)
        Me.OptPressureinWG.Name = "OptPressureinWG"
        Me.OptPressureinWG.Size = New System.Drawing.Size(71, 22)
        Me.OptPressureinWG.TabIndex = 2
        Me.OptPressureinWG.TabStop = True
        Me.OptPressureinWG.Text = "inWG"
        Me.OptPressureinWG.UseVisualStyleBackColor = True
        '
        'OptPressuremBar
        '
        Me.OptPressuremBar.AutoSize = True
        Me.OptPressuremBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptPressuremBar.ForeColor = System.Drawing.Color.White
        Me.OptPressuremBar.Location = New System.Drawing.Point(23, 60)
        Me.OptPressuremBar.Name = "OptPressuremBar"
        Me.OptPressuremBar.Size = New System.Drawing.Size(69, 22)
        Me.OptPressuremBar.TabIndex = 1
        Me.OptPressuremBar.TabStop = True
        Me.OptPressuremBar.Text = "mBar"
        Me.OptPressuremBar.UseVisualStyleBackColor = True
        '
        'OptPressurePa
        '
        Me.OptPressurePa.AutoSize = True
        Me.OptPressurePa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptPressurePa.ForeColor = System.Drawing.Color.White
        Me.OptPressurePa.Location = New System.Drawing.Point(23, 33)
        Me.OptPressurePa.Name = "OptPressurePa"
        Me.OptPressurePa.Size = New System.Drawing.Size(49, 22)
        Me.OptPressurePa.TabIndex = 0
        Me.OptPressurePa.TabStop = True
        Me.OptPressurePa.Text = "Pa"
        Me.OptPressurePa.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox4.Controls.Add(Me.OptDensityLbPerFt3)
        Me.GroupBox4.Controls.Add(Me.OptDensityKgPerM3)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(234, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Density"
        '
        'OptDensityLbPerFt3
        '
        Me.OptDensityLbPerFt3.AutoSize = True
        Me.OptDensityLbPerFt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptDensityLbPerFt3.ForeColor = System.Drawing.Color.White
        Me.OptDensityLbPerFt3.Location = New System.Drawing.Point(23, 54)
        Me.OptDensityLbPerFt3.Name = "OptDensityLbPerFt3"
        Me.OptDensityLbPerFt3.Size = New System.Drawing.Size(63, 22)
        Me.OptDensityLbPerFt3.TabIndex = 1
        Me.OptDensityLbPerFt3.TabStop = True
        Me.OptDensityLbPerFt3.Text = "lb/ft³"
        Me.OptDensityLbPerFt3.UseVisualStyleBackColor = True
        '
        'OptDensityKgPerM3
        '
        Me.OptDensityKgPerM3.AutoSize = True
        Me.OptDensityKgPerM3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptDensityKgPerM3.ForeColor = System.Drawing.Color.White
        Me.OptDensityKgPerM3.Location = New System.Drawing.Point(23, 27)
        Me.OptDensityKgPerM3.Name = "OptDensityKgPerM3"
        Me.OptDensityKgPerM3.Size = New System.Drawing.Size(72, 22)
        Me.OptDensityKgPerM3.TabIndex = 0
        Me.OptDensityKgPerM3.TabStop = True
        Me.OptDensityKgPerM3.Text = "kg/m³"
        Me.OptDensityKgPerM3.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox5.Controls.Add(Me.OptLengthIn)
        Me.GroupBox5.Controls.Add(Me.OptLengthMm)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(234, 247)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 94)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Length"
        '
        'OptLengthIn
        '
        Me.OptLengthIn.AutoSize = True
        Me.OptLengthIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptLengthIn.ForeColor = System.Drawing.Color.White
        Me.OptLengthIn.Location = New System.Drawing.Point(23, 55)
        Me.OptLengthIn.Name = "OptLengthIn"
        Me.OptLengthIn.Size = New System.Drawing.Size(51, 22)
        Me.OptLengthIn.TabIndex = 1
        Me.OptLengthIn.TabStop = True
        Me.OptLengthIn.Text = "ins"
        Me.OptLengthIn.UseVisualStyleBackColor = True
        '
        'OptLengthMm
        '
        Me.OptLengthMm.AutoSize = True
        Me.OptLengthMm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptLengthMm.ForeColor = System.Drawing.Color.White
        Me.OptLengthMm.Location = New System.Drawing.Point(23, 28)
        Me.OptLengthMm.Name = "OptLengthMm"
        Me.OptLengthMm.Size = New System.Drawing.Size(57, 22)
        Me.OptLengthMm.TabIndex = 0
        Me.OptLengthMm.TabStop = True
        Me.OptLengthMm.Text = "mm"
        Me.OptLengthMm.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox6.Controls.Add(Me.OptDefaultNone)
        Me.GroupBox6.Controls.Add(Me.OptDefaultImperial)
        Me.GroupBox6.Controls.Add(Me.OptDefaultMetric)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Location = New System.Drawing.Point(461, 128)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(200, 123)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Select defaults"
        '
        'OptDefaultNone
        '
        Me.OptDefaultNone.AutoSize = True
        Me.OptDefaultNone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptDefaultNone.ForeColor = System.Drawing.Color.White
        Me.OptDefaultNone.Location = New System.Drawing.Point(19, 84)
        Me.OptDefaultNone.Name = "OptDefaultNone"
        Me.OptDefaultNone.Size = New System.Drawing.Size(69, 22)
        Me.OptDefaultNone.TabIndex = 2
        Me.OptDefaultNone.TabStop = True
        Me.OptDefaultNone.Text = "None"
        Me.OptDefaultNone.UseVisualStyleBackColor = True
        Me.OptDefaultNone.Visible = False
        '
        'OptDefaultImperial
        '
        Me.OptDefaultImperial.AutoSize = True
        Me.OptDefaultImperial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptDefaultImperial.ForeColor = System.Drawing.Color.White
        Me.OptDefaultImperial.Location = New System.Drawing.Point(19, 57)
        Me.OptDefaultImperial.Name = "OptDefaultImperial"
        Me.OptDefaultImperial.Size = New System.Drawing.Size(155, 22)
        Me.OptDefaultImperial.TabIndex = 1
        Me.OptDefaultImperial.TabStop = True
        Me.OptDefaultImperial.Text = "Imperial Defaults"
        Me.OptDefaultImperial.UseVisualStyleBackColor = True
        '
        'OptDefaultMetric
        '
        Me.OptDefaultMetric.AutoSize = True
        Me.OptDefaultMetric.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptDefaultMetric.ForeColor = System.Drawing.Color.White
        Me.OptDefaultMetric.Location = New System.Drawing.Point(19, 30)
        Me.OptDefaultMetric.Name = "OptDefaultMetric"
        Me.OptDefaultMetric.Size = New System.Drawing.Size(143, 22)
        Me.OptDefaultMetric.TabIndex = 0
        Me.OptDefaultMetric.TabStop = True
        Me.OptDefaultMetric.Text = "Metric Defaults"
        Me.OptDefaultMetric.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(461, 388)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(90, 75)
        Me.BtnCancel.TabIndex = 6
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.White
        Me.BtnExit.Location = New System.Drawing.Point(571, 388)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(90, 75)
        Me.BtnExit.TabIndex = 7
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox7.Controls.Add(Me.OptAltitudeFt)
        Me.GroupBox7.Controls.Add(Me.OptAltitudeM)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.White
        Me.GroupBox7.Location = New System.Drawing.Point(234, 373)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(200, 94)
        Me.GroupBox7.TabIndex = 5
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Altitude"
        '
        'OptAltitudeFt
        '
        Me.OptAltitudeFt.AutoSize = True
        Me.OptAltitudeFt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptAltitudeFt.ForeColor = System.Drawing.Color.White
        Me.OptAltitudeFt.Location = New System.Drawing.Point(23, 55)
        Me.OptAltitudeFt.Name = "OptAltitudeFt"
        Me.OptAltitudeFt.Size = New System.Drawing.Size(39, 22)
        Me.OptAltitudeFt.TabIndex = 1
        Me.OptAltitudeFt.TabStop = True
        Me.OptAltitudeFt.Text = "ft"
        Me.OptAltitudeFt.UseVisualStyleBackColor = True
        '
        'OptAltitudeM
        '
        Me.OptAltitudeM.AutoSize = True
        Me.OptAltitudeM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptAltitudeM.ForeColor = System.Drawing.Color.White
        Me.OptAltitudeM.Location = New System.Drawing.Point(23, 28)
        Me.OptAltitudeM.Name = "OptAltitudeM"
        Me.OptAltitudeM.Size = New System.Drawing.Size(43, 22)
        Me.OptAltitudeM.TabIndex = 0
        Me.OptAltitudeM.TabStop = True
        Me.OptAltitudeM.Text = "m"
        Me.OptAltitudeM.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox8.Controls.Add(Me.OptPowerHp)
        Me.GroupBox8.Controls.Add(Me.OptPowerKW)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.White
        Me.GroupBox8.Location = New System.Drawing.Point(234, 126)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox8.TabIndex = 4
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Power"
        '
        'OptPowerHp
        '
        Me.OptPowerHp.AutoSize = True
        Me.OptPowerHp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptPowerHp.ForeColor = System.Drawing.Color.White
        Me.OptPowerHp.Location = New System.Drawing.Point(23, 54)
        Me.OptPowerHp.Name = "OptPowerHp"
        Me.OptPowerHp.Size = New System.Drawing.Size(47, 22)
        Me.OptPowerHp.TabIndex = 1
        Me.OptPowerHp.TabStop = True
        Me.OptPowerHp.Text = "hp"
        Me.OptPowerHp.UseVisualStyleBackColor = True
        '
        'OptPowerKW
        '
        Me.OptPowerKW.AutoSize = True
        Me.OptPowerKW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptPowerKW.ForeColor = System.Drawing.Color.White
        Me.OptPowerKW.Location = New System.Drawing.Point(23, 27)
        Me.OptPowerKW.Name = "OptPowerKW"
        Me.OptPowerKW.Size = New System.Drawing.Size(54, 22)
        Me.OptPowerKW.TabIndex = 0
        Me.OptPowerKW.TabStop = True
        Me.OptPowerKW.Text = "kW"
        Me.OptPowerKW.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox9.Controls.Add(Me.OptVelocityFtpermin)
        Me.GroupBox9.Controls.Add(Me.OptVelocityMpers)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.ForeColor = System.Drawing.Color.White
        Me.GroupBox9.Location = New System.Drawing.Point(461, 12)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox9.TabIndex = 8
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Velocity"
        '
        'OptVelocityFtpermin
        '
        Me.OptVelocityFtpermin.AutoSize = True
        Me.OptVelocityFtpermin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptVelocityFtpermin.ForeColor = System.Drawing.Color.White
        Me.OptVelocityFtpermin.Location = New System.Drawing.Point(19, 54)
        Me.OptVelocityFtpermin.Name = "OptVelocityFtpermin"
        Me.OptVelocityFtpermin.Size = New System.Drawing.Size(71, 22)
        Me.OptVelocityFtpermin.TabIndex = 1
        Me.OptVelocityFtpermin.TabStop = True
        Me.OptVelocityFtpermin.Text = "ft/min"
        Me.OptVelocityFtpermin.UseVisualStyleBackColor = True
        '
        'OptVelocityMpers
        '
        Me.OptVelocityMpers.AutoSize = True
        Me.OptVelocityMpers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptVelocityMpers.ForeColor = System.Drawing.Color.White
        Me.OptVelocityMpers.Location = New System.Drawing.Point(19, 27)
        Me.OptVelocityMpers.Name = "OptVelocityMpers"
        Me.OptVelocityMpers.Size = New System.Drawing.Size(57, 22)
        Me.OptVelocityMpers.TabIndex = 0
        Me.OptVelocityMpers.TabStop = True
        Me.OptVelocityMpers.Text = "m/s"
        Me.OptVelocityMpers.UseVisualStyleBackColor = True
        '
        'FrmUnits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(682, 475)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(700, 522)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(488, 522)
        Me.Name = "FrmUnits"
        Me.Text = "Units"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents OptTemperatureF As RadioButton
    Friend WithEvents OptTemperatureC As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents OptFlowCfm As RadioButton
    Friend WithEvents OptFlowM3PerHr As RadioButton
    Friend WithEvents OptFlowM3PerMin As RadioButton
    Friend WithEvents OptFlowM3PerSec As RadioButton
    Friend WithEvents OptFlowLbPerHr As RadioButton
    Friend WithEvents OptFlowKgPerHr As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents OptPressuremBar As RadioButton
    Friend WithEvents OptPressurePa As RadioButton
    Friend WithEvents OptPressureinWG As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents OptDensityLbPerFt3 As RadioButton
    Friend WithEvents OptDensityKgPerM3 As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents OptLengthIn As RadioButton
    Friend WithEvents OptLengthMm As RadioButton
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents OptDefaultImperial As RadioButton
    Friend WithEvents OptDefaultMetric As RadioButton
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents OptDefaultNone As RadioButton
    Friend WithEvents OptPressuremmWG As RadioButton
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents OptAltitudeFt As RadioButton
    Friend WithEvents OptAltitudeM As RadioButton
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents OptPowerHp As RadioButton
    Friend WithEvents OptPowerKW As RadioButton
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents OptVelocityFtpermin As RadioButton
    Friend WithEvents OptVelocityMpers As RadioButton
End Class
