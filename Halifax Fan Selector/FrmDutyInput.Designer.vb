<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDutyInput
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
        Me.GrpInletTemperature = New System.Windows.Forms.GroupBox()
        Me.TxtMaximumTemperature = New System.Windows.Forms.TextBox()
        Me.LblMaximumTemperature = New System.Windows.Forms.Label()
        Me.LblDesignTemperature = New System.Windows.Forms.Label()
        Me.TxtDesignTemperature = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OptXLS = New System.Windows.Forms.RadioButton()
        Me.OptTXT = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GrpDesignPressure.SuspendLayout()
        Me.GrpFlowRate.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GrpInletDensity.SuspendLayout()
        Me.GrpInletTemperature.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(325, 256)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(216, 57)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Discharge Duct"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.White
        Me.RadioButton1.Location = New System.Drawing.Point(12, 21)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(56, 22)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Any"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.White
        Me.RadioButton2.Location = New System.Drawing.Point(132, 21)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(69, 22)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.Text = "Fixed"
        Me.RadioButton2.UseVisualStyleBackColor = False
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
        Me.GrpDesignPressure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpDesignPressure.ForeColor = System.Drawing.Color.White
        Me.GrpDesignPressure.Location = New System.Drawing.Point(17, 222)
        Me.GrpDesignPressure.Name = "GrpDesignPressure"
        Me.GrpDesignPressure.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpDesignPressure.Size = New System.Drawing.Size(258, 223)
        Me.GrpDesignPressure.TabIndex = 15
        Me.GrpDesignPressure.TabStop = False
        Me.GrpDesignPressure.Text = "Design Pressure (Pa)"
        '
        'Optsucy
        '
        Me.Optsucy.AutoSize = True
        Me.Optsucy.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Optsucy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Optsucy.ForeColor = System.Drawing.Color.White
        Me.Optsucy.Location = New System.Drawing.Point(22, 185)
        Me.Optsucy.Name = "Optsucy"
        Me.Optsucy.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Optsucy.Size = New System.Drawing.Size(160, 22)
        Me.Optsucy.TabIndex = 16
        Me.Optsucy.Text = "Suction Pressure"
        Me.Optsucy.UseVisualStyleBackColor = False
        '
        'CmbReserveHead
        '
        Me.CmbReserveHead.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.CmbReserveHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbReserveHead.ForeColor = System.Drawing.Color.White
        Me.CmbReserveHead.FormattingEnabled = True
        Me.CmbReserveHead.Items.AddRange(New Object() {"5%", "10%", "15%", "20%"})
        Me.CmbReserveHead.Location = New System.Drawing.Point(165, 144)
        Me.CmbReserveHead.Name = "CmbReserveHead"
        Me.CmbReserveHead.Size = New System.Drawing.Size(55, 26)
        Me.CmbReserveHead.TabIndex = 15
        Me.CmbReserveHead.Text = "5%"
        '
        'Txtfsp
        '
        Me.Txtfsp.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Txtfsp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtfsp.ForeColor = System.Drawing.Color.White
        Me.Txtfsp.Location = New System.Drawing.Point(165, 116)
        Me.Txtfsp.Name = "Txtfsp"
        Me.Txtfsp.Size = New System.Drawing.Size(55, 24)
        Me.Txtfsp.TabIndex = 14
        Me.Txtfsp.Text = "0"
        '
        'TxtDischargePressure
        '
        Me.TxtDischargePressure.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TxtDischargePressure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDischargePressure.ForeColor = System.Drawing.Color.White
        Me.TxtDischargePressure.Location = New System.Drawing.Point(165, 86)
        Me.TxtDischargePressure.Name = "TxtDischargePressure"
        Me.TxtDischargePressure.Size = New System.Drawing.Size(55, 24)
        Me.TxtDischargePressure.TabIndex = 13
        Me.TxtDischargePressure.Text = "0"
        '
        'TxtInletPressure
        '
        Me.TxtInletPressure.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TxtInletPressure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInletPressure.ForeColor = System.Drawing.Color.White
        Me.TxtInletPressure.Location = New System.Drawing.Point(165, 58)
        Me.TxtInletPressure.Name = "TxtInletPressure"
        Me.TxtInletPressure.Size = New System.Drawing.Size(55, 24)
        Me.TxtInletPressure.TabIndex = 12
        Me.TxtInletPressure.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(23, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Reserve Head"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(25, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 18)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Pressure Rise"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(50, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 18)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Discharge"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(88, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 18)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Inlet"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OptStaticPressure
        '
        Me.OptStaticPressure.AutoSize = True
        Me.OptStaticPressure.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.OptStaticPressure.Checked = True
        Me.OptStaticPressure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptStaticPressure.ForeColor = System.Drawing.Color.White
        Me.OptStaticPressure.Location = New System.Drawing.Point(22, 34)
        Me.OptStaticPressure.Name = "OptStaticPressure"
        Me.OptStaticPressure.Size = New System.Drawing.Size(72, 22)
        Me.OptStaticPressure.TabIndex = 3
        Me.OptStaticPressure.TabStop = True
        Me.OptStaticPressure.Text = "Static"
        Me.OptStaticPressure.UseVisualStyleBackColor = False
        '
        'OptTotalPressure
        '
        Me.OptTotalPressure.AutoSize = True
        Me.OptTotalPressure.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.OptTotalPressure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptTotalPressure.ForeColor = System.Drawing.Color.White
        Me.OptTotalPressure.Location = New System.Drawing.Point(149, 34)
        Me.OptTotalPressure.Name = "OptTotalPressure"
        Me.OptTotalPressure.Size = New System.Drawing.Size(67, 22)
        Me.OptTotalPressure.TabIndex = 2
        Me.OptTotalPressure.Text = "Total"
        Me.OptTotalPressure.UseVisualStyleBackColor = False
        '
        'GrpFlowRate
        '
        Me.GrpFlowRate.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GrpFlowRate.Controls.Add(Me.LblFlowRateUnits)
        Me.GrpFlowRate.Controls.Add(Me.Panel1)
        Me.GrpFlowRate.Controls.Add(Me.Txtflow)
        Me.GrpFlowRate.Controls.Add(Me.OptMassFlow)
        Me.GrpFlowRate.Controls.Add(Me.OptVolumeFlow)
        Me.GrpFlowRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpFlowRate.ForeColor = System.Drawing.Color.White
        Me.GrpFlowRate.Location = New System.Drawing.Point(17, 26)
        Me.GrpFlowRate.Name = "GrpFlowRate"
        Me.GrpFlowRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpFlowRate.Size = New System.Drawing.Size(258, 190)
        Me.GrpFlowRate.TabIndex = 14
        Me.GrpFlowRate.TabStop = False
        Me.GrpFlowRate.Text = "Flow Rate"
        '
        'LblFlowRateUnits
        '
        Me.LblFlowRateUnits.AutoSize = True
        Me.LblFlowRateUnits.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.LblFlowRateUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFlowRateUnits.ForeColor = System.Drawing.Color.White
        Me.LblFlowRateUnits.Location = New System.Drawing.Point(123, 62)
        Me.LblFlowRateUnits.Name = "LblFlowRateUnits"
        Me.LblFlowRateUnits.Size = New System.Drawing.Size(48, 18)
        Me.LblFlowRateUnits.TabIndex = 4
        Me.LblFlowRateUnits.Text = "m³/hr"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.OptFlowDischarge)
        Me.Panel1.Controls.Add(Me.OptFlowNominal)
        Me.Panel1.Controls.Add(Me.OpFlowInlet)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(2, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 90)
        Me.Panel1.TabIndex = 3
        '
        'OptFlowDischarge
        '
        Me.OptFlowDischarge.AutoSize = True
        Me.OptFlowDischarge.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.OptFlowDischarge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptFlowDischarge.ForeColor = System.Drawing.Color.White
        Me.OptFlowDischarge.Location = New System.Drawing.Point(17, 40)
        Me.OptFlowDischarge.Name = "OptFlowDischarge"
        Me.OptFlowDischarge.Size = New System.Drawing.Size(105, 22)
        Me.OptFlowDischarge.TabIndex = 5
        Me.OptFlowDischarge.Text = "Discharge"
        Me.OptFlowDischarge.UseVisualStyleBackColor = False
        '
        'OptFlowNominal
        '
        Me.OptFlowNominal.AutoSize = True
        Me.OptFlowNominal.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.OptFlowNominal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptFlowNominal.ForeColor = System.Drawing.Color.White
        Me.OptFlowNominal.Location = New System.Drawing.Point(128, 12)
        Me.OptFlowNominal.Name = "OptFlowNominal"
        Me.OptFlowNominal.Size = New System.Drawing.Size(91, 22)
        Me.OptFlowNominal.TabIndex = 4
        Me.OptFlowNominal.Text = "Nominal"
        Me.OptFlowNominal.UseVisualStyleBackColor = False
        '
        'OpFlowInlet
        '
        Me.OpFlowInlet.AutoSize = True
        Me.OpFlowInlet.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.OpFlowInlet.Checked = True
        Me.OpFlowInlet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpFlowInlet.ForeColor = System.Drawing.Color.White
        Me.OpFlowInlet.Location = New System.Drawing.Point(17, 12)
        Me.OpFlowInlet.Name = "OpFlowInlet"
        Me.OpFlowInlet.Size = New System.Drawing.Size(60, 22)
        Me.OpFlowInlet.TabIndex = 3
        Me.OpFlowInlet.TabStop = True
        Me.OpFlowInlet.Text = "Inlet"
        Me.OpFlowInlet.UseVisualStyleBackColor = False
        '
        'Txtflow
        '
        Me.Txtflow.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Txtflow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtflow.ForeColor = System.Drawing.Color.White
        Me.Txtflow.Location = New System.Drawing.Point(17, 61)
        Me.Txtflow.Name = "Txtflow"
        Me.Txtflow.Size = New System.Drawing.Size(100, 24)
        Me.Txtflow.TabIndex = 2
        Me.Txtflow.Text = "0"
        '
        'OptMassFlow
        '
        Me.OptMassFlow.AutoSize = True
        Me.OptMassFlow.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.OptMassFlow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptMassFlow.ForeColor = System.Drawing.Color.White
        Me.OptMassFlow.Location = New System.Drawing.Point(130, 32)
        Me.OptMassFlow.Name = "OptMassFlow"
        Me.OptMassFlow.Size = New System.Drawing.Size(70, 22)
        Me.OptMassFlow.TabIndex = 1
        Me.OptMassFlow.Text = "Mass"
        Me.OptMassFlow.UseVisualStyleBackColor = False
        '
        'OptVolumeFlow
        '
        Me.OptVolumeFlow.AutoSize = True
        Me.OptVolumeFlow.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.OptVolumeFlow.Checked = True
        Me.OptVolumeFlow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptVolumeFlow.ForeColor = System.Drawing.Color.White
        Me.OptVolumeFlow.Location = New System.Drawing.Point(17, 32)
        Me.OptVolumeFlow.Name = "OptVolumeFlow"
        Me.OptVolumeFlow.Size = New System.Drawing.Size(85, 22)
        Me.OptVolumeFlow.TabIndex = 0
        Me.OptVolumeFlow.TabStop = True
        Me.OptVolumeFlow.Text = "Volume"
        Me.OptVolumeFlow.UseVisualStyleBackColor = False
        '
        'GrpInletDensity
        '
        Me.GrpInletDensity.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GrpInletDensity.Controls.Add(Me.OptDensityCalculated)
        Me.GrpInletDensity.Controls.Add(Me.OptDensityKnown)
        Me.GrpInletDensity.Controls.Add(Me.Txtdens)
        Me.GrpInletDensity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpInletDensity.ForeColor = System.Drawing.Color.White
        Me.GrpInletDensity.Location = New System.Drawing.Point(325, 138)
        Me.GrpInletDensity.Name = "GrpInletDensity"
        Me.GrpInletDensity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpInletDensity.Size = New System.Drawing.Size(313, 83)
        Me.GrpInletDensity.TabIndex = 13
        Me.GrpInletDensity.TabStop = False
        Me.GrpInletDensity.Text = "Inlet Density (kg/m³)"
        '
        'OptDensityCalculated
        '
        Me.OptDensityCalculated.AutoSize = True
        Me.OptDensityCalculated.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.OptDensityCalculated.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptDensityCalculated.ForeColor = System.Drawing.Color.White
        Me.OptDensityCalculated.Location = New System.Drawing.Point(170, 34)
        Me.OptDensityCalculated.Name = "OptDensityCalculated"
        Me.OptDensityCalculated.Size = New System.Drawing.Size(108, 22)
        Me.OptDensityCalculated.TabIndex = 2
        Me.OptDensityCalculated.Text = "Calculated"
        Me.OptDensityCalculated.UseVisualStyleBackColor = False
        '
        'OptDensityKnown
        '
        Me.OptDensityKnown.AutoSize = True
        Me.OptDensityKnown.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.OptDensityKnown.Checked = True
        Me.OptDensityKnown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptDensityKnown.ForeColor = System.Drawing.Color.White
        Me.OptDensityKnown.Location = New System.Drawing.Point(86, 34)
        Me.OptDensityKnown.Name = "OptDensityKnown"
        Me.OptDensityKnown.Size = New System.Drawing.Size(80, 22)
        Me.OptDensityKnown.TabIndex = 1
        Me.OptDensityKnown.TabStop = True
        Me.OptDensityKnown.Text = "Known"
        Me.OptDensityKnown.UseVisualStyleBackColor = False
        '
        'Txtdens
        '
        Me.Txtdens.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Txtdens.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtdens.ForeColor = System.Drawing.Color.White
        Me.Txtdens.Location = New System.Drawing.Point(14, 33)
        Me.Txtdens.Name = "Txtdens"
        Me.Txtdens.Size = New System.Drawing.Size(56, 24)
        Me.Txtdens.TabIndex = 0
        Me.Txtdens.Text = "1.205"
        '
        'GrpInletTemperature
        '
        Me.GrpInletTemperature.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GrpInletTemperature.Controls.Add(Me.TxtMaximumTemperature)
        Me.GrpInletTemperature.Controls.Add(Me.LblMaximumTemperature)
        Me.GrpInletTemperature.Controls.Add(Me.LblDesignTemperature)
        Me.GrpInletTemperature.Controls.Add(Me.TxtDesignTemperature)
        Me.GrpInletTemperature.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpInletTemperature.ForeColor = System.Drawing.Color.White
        Me.GrpInletTemperature.Location = New System.Drawing.Point(325, 26)
        Me.GrpInletTemperature.Name = "GrpInletTemperature"
        Me.GrpInletTemperature.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpInletTemperature.Size = New System.Drawing.Size(313, 83)
        Me.GrpInletTemperature.TabIndex = 12
        Me.GrpInletTemperature.TabStop = False
        Me.GrpInletTemperature.Text = "Inlet Temperature (°C)"
        '
        'TxtMaximumTemperature
        '
        Me.TxtMaximumTemperature.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TxtMaximumTemperature.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMaximumTemperature.ForeColor = System.Drawing.Color.White
        Me.TxtMaximumTemperature.Location = New System.Drawing.Point(219, 33)
        Me.TxtMaximumTemperature.Name = "TxtMaximumTemperature"
        Me.TxtMaximumTemperature.Size = New System.Drawing.Size(36, 24)
        Me.TxtMaximumTemperature.TabIndex = 3
        Me.TxtMaximumTemperature.Text = "20"
        '
        'LblMaximumTemperature
        '
        Me.LblMaximumTemperature.AutoSize = True
        Me.LblMaximumTemperature.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.LblMaximumTemperature.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMaximumTemperature.ForeColor = System.Drawing.Color.White
        Me.LblMaximumTemperature.Location = New System.Drawing.Point(130, 36)
        Me.LblMaximumTemperature.Name = "LblMaximumTemperature"
        Me.LblMaximumTemperature.Size = New System.Drawing.Size(80, 18)
        Me.LblMaximumTemperature.TabIndex = 2
        Me.LblMaximumTemperature.Text = "Maximum"
        '
        'LblDesignTemperature
        '
        Me.LblDesignTemperature.AutoSize = True
        Me.LblDesignTemperature.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.LblDesignTemperature.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDesignTemperature.ForeColor = System.Drawing.Color.White
        Me.LblDesignTemperature.Location = New System.Drawing.Point(6, 36)
        Me.LblDesignTemperature.Name = "LblDesignTemperature"
        Me.LblDesignTemperature.Size = New System.Drawing.Size(60, 18)
        Me.LblDesignTemperature.TabIndex = 1
        Me.LblDesignTemperature.Text = "Design"
        '
        'TxtDesignTemperature
        '
        Me.TxtDesignTemperature.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TxtDesignTemperature.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDesignTemperature.ForeColor = System.Drawing.Color.White
        Me.TxtDesignTemperature.Location = New System.Drawing.Point(77, 33)
        Me.TxtDesignTemperature.Name = "TxtDesignTemperature"
        Me.TxtDesignTemperature.Size = New System.Drawing.Size(36, 24)
        Me.TxtDesignTemperature.TabIndex = 0
        Me.TxtDesignTemperature.Text = "20"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox2.Controls.Add(Me.OptXLS)
        Me.GroupBox2.Controls.Add(Me.OptTXT)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(325, 338)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'OptXLS
        '
        Me.OptXLS.AutoSize = True
        Me.OptXLS.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.OptXLS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptXLS.ForeColor = System.Drawing.Color.White
        Me.OptXLS.Location = New System.Drawing.Point(29, 64)
        Me.OptXLS.Name = "OptXLS"
        Me.OptXLS.Size = New System.Drawing.Size(136, 22)
        Me.OptXLS.TabIndex = 1
        Me.OptXLS.TabStop = True
        Me.OptXLS.Text = "Use XLS Files"
        Me.OptXLS.UseVisualStyleBackColor = False
        '
        'OptTXT
        '
        Me.OptTXT.AutoSize = True
        Me.OptTXT.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.OptTXT.Checked = True
        Me.OptTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptTXT.ForeColor = System.Drawing.Color.White
        Me.OptTXT.Location = New System.Drawing.Point(29, 25)
        Me.OptTXT.Name = "OptTXT"
        Me.OptTXT.Size = New System.Drawing.Size(136, 22)
        Me.OptTXT.TabIndex = 0
        Me.OptTXT.TabStop = True
        Me.OptTXT.Text = "Use TXT Files"
        Me.OptTXT.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(17, 468)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(179, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "<< Environmental Info"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(495, 468)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Selections >>"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(306, 468)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'FrmDutyInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 508)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrpDesignPressure)
        Me.Controls.Add(Me.GrpFlowRate)
        Me.Controls.Add(Me.GrpInletDensity)
        Me.Controls.Add(Me.GrpInletTemperature)
        Me.Name = "FrmDutyInput"
        Me.Text = "FrmDutyInput"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GrpDesignPressure.ResumeLayout(False)
        Me.GrpDesignPressure.PerformLayout()
        Me.GrpFlowRate.ResumeLayout(False)
        Me.GrpFlowRate.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GrpInletDensity.ResumeLayout(False)
        Me.GrpInletDensity.PerformLayout()
        Me.GrpInletTemperature.ResumeLayout(False)
        Me.GrpInletTemperature.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents GrpDesignPressure As GroupBox
    Friend WithEvents Optsucy As CheckBox
    Friend WithEvents CmbReserveHead As ComboBox
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
    Friend WithEvents LblFlowRateUnits As Label
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
    Friend WithEvents GrpInletTemperature As GroupBox
    Friend WithEvents TxtMaximumTemperature As TextBox
    Friend WithEvents LblMaximumTemperature As Label
    Friend WithEvents LblDesignTemperature As Label
    Friend WithEvents TxtDesignTemperature As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents OptXLS As RadioButton
    Friend WithEvents OptTXT As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
