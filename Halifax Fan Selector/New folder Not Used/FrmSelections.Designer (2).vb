<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelections
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
        Me.LblFanDetails = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
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
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpFanSize.SuspendLayout()
        Me.GrpFanSpeed.SuspendLayout()
        Me.GrpPoleBox.SuspendLayout()
        Me.GrpFanTypes.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblFanDetails
        '
        Me.LblFanDetails.AutoSize = True
        Me.LblFanDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFanDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblFanDetails.Location = New System.Drawing.Point(237, -34)
        Me.LblFanDetails.Name = "LblFanDetails"
        Me.LblFanDetails.Size = New System.Drawing.Size(138, 29)
        Me.LblFanDetails.TabIndex = 10
        Me.LblFanDetails.Text = "FanDetails"
        Me.LblFanDetails.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(32, -34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 29)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Selected Fan"
        Me.Label3.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1159, 152)
        Me.DataGridView1.TabIndex = 11
        '
        'GrpFanSize
        '
        Me.GrpFanSize.BackColor = System.Drawing.Color.White
        Me.GrpFanSize.Controls.Add(Me.LblLengthUnits)
        Me.GrpFanSize.Controls.Add(Me.Txtfansize)
        Me.GrpFanSize.Controls.Add(Me.Lblfansize)
        Me.GrpFanSize.Controls.Add(Me.OptAnySize)
        Me.GrpFanSize.Controls.Add(Me.OptFixedSize)
        Me.GrpFanSize.ForeColor = System.Drawing.Color.Black
        Me.GrpFanSize.Location = New System.Drawing.Point(12, 449)
        Me.GrpFanSize.Name = "GrpFanSize"
        Me.GrpFanSize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpFanSize.Size = New System.Drawing.Size(528, 61)
        Me.GrpFanSize.TabIndex = 22
        Me.GrpFanSize.TabStop = False
        Me.GrpFanSize.Text = "Fan Size"
        '
        'LblLengthUnits
        '
        Me.LblLengthUnits.AutoSize = True
        Me.LblLengthUnits.Location = New System.Drawing.Point(451, 21)
        Me.LblLengthUnits.Name = "LblLengthUnits"
        Me.LblLengthUnits.Size = New System.Drawing.Size(30, 17)
        Me.LblLengthUnits.TabIndex = 8
        Me.LblLengthUnits.Text = "mm"
        '
        'Txtfansize
        '
        Me.Txtfansize.Location = New System.Drawing.Point(390, 17)
        Me.Txtfansize.Name = "Txtfansize"
        Me.Txtfansize.Size = New System.Drawing.Size(55, 22)
        Me.Txtfansize.TabIndex = 7
        '
        'Lblfansize
        '
        Me.Lblfansize.AutoSize = True
        Me.Lblfansize.Location = New System.Drawing.Point(290, 22)
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
        Me.OptFixedSize.Location = New System.Drawing.Point(156, 21)
        Me.OptFixedSize.Name = "OptFixedSize"
        Me.OptFixedSize.Size = New System.Drawing.Size(93, 21)
        Me.OptFixedSize.TabIndex = 4
        Me.OptFixedSize.Text = "Fixed Size"
        Me.OptFixedSize.UseVisualStyleBackColor = True
        '
        'GrpFanSpeed
        '
        Me.GrpFanSpeed.BackColor = System.Drawing.Color.White
        Me.GrpFanSpeed.Controls.Add(Me.GrpPoleBox)
        Me.GrpFanSpeed.Controls.Add(Me.Txtfanspeed)
        Me.GrpFanSpeed.Controls.Add(Me.Label1)
        Me.GrpFanSpeed.Controls.Add(Me.Txtspeedlimit)
        Me.GrpFanSpeed.Controls.Add(Me.Label11)
        Me.GrpFanSpeed.Controls.Add(Me.OptFixedSpeed)
        Me.GrpFanSpeed.Controls.Add(Me.OptAnySpeed)
        Me.GrpFanSpeed.Controls.Add(Me.OptPoleSpeed)
        Me.GrpFanSpeed.ForeColor = System.Drawing.Color.Black
        Me.GrpFanSpeed.Location = New System.Drawing.Point(546, 351)
        Me.GrpFanSpeed.Name = "GrpFanSpeed"
        Me.GrpFanSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpFanSpeed.Size = New System.Drawing.Size(600, 134)
        Me.GrpFanSpeed.TabIndex = 21
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
        Me.GrpPoleBox.Location = New System.Drawing.Point(153, 11)
        Me.GrpPoleBox.Name = "GrpPoleBox"
        Me.GrpPoleBox.Size = New System.Drawing.Size(207, 109)
        Me.GrpPoleBox.TabIndex = 11
        Me.GrpPoleBox.TabStop = False
        '
        'Opt12Pole
        '
        Me.Opt12Pole.AutoSize = True
        Me.Opt12Pole.Location = New System.Drawing.Point(104, 71)
        Me.Opt12Pole.Name = "Opt12Pole"
        Me.Opt12Pole.Size = New System.Drawing.Size(77, 21)
        Me.Opt12Pole.TabIndex = 5
        Me.Opt12Pole.TabStop = True
        Me.Opt12Pole.Text = "12 Pole"
        Me.Opt12Pole.UseVisualStyleBackColor = True
        '
        'Opt10Pole
        '
        Me.Opt10Pole.AutoSize = True
        Me.Opt10Pole.Location = New System.Drawing.Point(104, 44)
        Me.Opt10Pole.Name = "Opt10Pole"
        Me.Opt10Pole.Size = New System.Drawing.Size(77, 21)
        Me.Opt10Pole.TabIndex = 4
        Me.Opt10Pole.TabStop = True
        Me.Opt10Pole.Text = "10 Pole"
        Me.Opt10Pole.UseVisualStyleBackColor = True
        '
        'Opt8Pole
        '
        Me.Opt8Pole.AutoSize = True
        Me.Opt8Pole.Location = New System.Drawing.Point(104, 17)
        Me.Opt8Pole.Name = "Opt8Pole"
        Me.Opt8Pole.Size = New System.Drawing.Size(69, 21)
        Me.Opt8Pole.TabIndex = 3
        Me.Opt8Pole.TabStop = True
        Me.Opt8Pole.Text = "8 Pole"
        Me.Opt8Pole.UseVisualStyleBackColor = True
        '
        'Opt6Pole
        '
        Me.Opt6Pole.AutoSize = True
        Me.Opt6Pole.Location = New System.Drawing.Point(23, 71)
        Me.Opt6Pole.Name = "Opt6Pole"
        Me.Opt6Pole.Size = New System.Drawing.Size(69, 21)
        Me.Opt6Pole.TabIndex = 2
        Me.Opt6Pole.TabStop = True
        Me.Opt6Pole.Text = "6 Pole"
        Me.Opt6Pole.UseVisualStyleBackColor = True
        '
        'Opt4Pole
        '
        Me.Opt4Pole.AutoSize = True
        Me.Opt4Pole.Location = New System.Drawing.Point(23, 44)
        Me.Opt4Pole.Name = "Opt4Pole"
        Me.Opt4Pole.Size = New System.Drawing.Size(69, 21)
        Me.Opt4Pole.TabIndex = 1
        Me.Opt4Pole.TabStop = True
        Me.Opt4Pole.Text = "4 Pole"
        Me.Opt4Pole.UseVisualStyleBackColor = True
        '
        'Opt2Pole
        '
        Me.Opt2Pole.AutoSize = True
        Me.Opt2Pole.Location = New System.Drawing.Point(23, 17)
        Me.Opt2Pole.Name = "Opt2Pole"
        Me.Opt2Pole.Size = New System.Drawing.Size(69, 21)
        Me.Opt2Pole.TabIndex = 0
        Me.Opt2Pole.TabStop = True
        Me.Opt2Pole.Text = "2 Pole"
        Me.Opt2Pole.UseVisualStyleBackColor = True
        '
        'Txtfanspeed
        '
        Me.Txtfanspeed.Location = New System.Drawing.Point(527, 60)
        Me.Txtfanspeed.Name = "Txtfanspeed"
        Me.Txtfanspeed.Size = New System.Drawing.Size(55, 22)
        Me.Txtfanspeed.TabIndex = 10
        Me.Txtfanspeed.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(366, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Fan Speed (RPM)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txtspeedlimit
        '
        Me.Txtspeedlimit.Location = New System.Drawing.Point(527, 27)
        Me.Txtspeedlimit.Name = "Txtspeedlimit"
        Me.Txtspeedlimit.Size = New System.Drawing.Size(55, 22)
        Me.Txtspeedlimit.TabIndex = 8
        Me.Txtspeedlimit.Text = "4000"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(366, 30)
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
        Me.OptPoleSpeed.Location = New System.Drawing.Point(12, 87)
        Me.OptPoleSpeed.Name = "OptPoleSpeed"
        Me.OptPoleSpeed.Size = New System.Drawing.Size(102, 21)
        Me.OptPoleSpeed.TabIndex = 4
        Me.OptPoleSpeed.Text = "Pole Speed"
        Me.OptPoleSpeed.UseVisualStyleBackColor = True
        '
        'GrpFanTypes
        '
        Me.GrpFanTypes.BackColor = System.Drawing.Color.White
        Me.GrpFanTypes.Controls.Add(Me.ChkOldDesignFans)
        Me.GrpFanTypes.Controls.Add(Me.ChkAxialFans)
        Me.GrpFanTypes.Controls.Add(Me.ChkPlenumFans)
        Me.GrpFanTypes.Controls.Add(Me.ChkPlasticFan)
        Me.GrpFanTypes.Controls.Add(Me.ChkOtherFanType)
        Me.GrpFanTypes.Controls.Add(Me.ChkInclineBlade)
        Me.GrpFanTypes.Controls.Add(Me.ChkCurveBlade)
        Me.GrpFanTypes.ForeColor = System.Drawing.Color.Black
        Me.GrpFanTypes.Location = New System.Drawing.Point(12, 351)
        Me.GrpFanTypes.Name = "GrpFanTypes"
        Me.GrpFanTypes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpFanTypes.Size = New System.Drawing.Size(528, 92)
        Me.GrpFanTypes.TabIndex = 20
        Me.GrpFanTypes.TabStop = False
        Me.GrpFanTypes.Text = "Fan Types"
        '
        'ChkOldDesignFans
        '
        Me.ChkOldDesignFans.AutoSize = True
        Me.ChkOldDesignFans.Location = New System.Drawing.Point(391, 28)
        Me.ChkOldDesignFans.Name = "ChkOldDesignFans"
        Me.ChkOldDesignFans.Size = New System.Drawing.Size(100, 21)
        Me.ChkOldDesignFans.TabIndex = 6
        Me.ChkOldDesignFans.Text = "Old Design"
        Me.ChkOldDesignFans.UseVisualStyleBackColor = True
        '
        'ChkAxialFans
        '
        Me.ChkAxialFans.AutoSize = True
        Me.ChkAxialFans.Location = New System.Drawing.Point(250, 55)
        Me.ChkAxialFans.Name = "ChkAxialFans"
        Me.ChkAxialFans.Size = New System.Drawing.Size(59, 21)
        Me.ChkAxialFans.TabIndex = 5
        Me.ChkAxialFans.Text = "Axial"
        Me.ChkAxialFans.UseVisualStyleBackColor = True
        '
        'ChkPlenumFans
        '
        Me.ChkPlenumFans.AutoSize = True
        Me.ChkPlenumFans.Location = New System.Drawing.Point(250, 28)
        Me.ChkPlenumFans.Name = "ChkPlenumFans"
        Me.ChkPlenumFans.Size = New System.Drawing.Size(112, 21)
        Me.ChkPlenumFans.TabIndex = 4
        Me.ChkPlenumFans.Text = "Plenum Fans"
        Me.ChkPlenumFans.UseVisualStyleBackColor = True
        '
        'ChkPlasticFan
        '
        Me.ChkPlasticFan.AutoSize = True
        Me.ChkPlasticFan.Location = New System.Drawing.Point(160, 55)
        Me.ChkPlasticFan.Name = "ChkPlasticFan"
        Me.ChkPlasticFan.Size = New System.Drawing.Size(71, 21)
        Me.ChkPlasticFan.TabIndex = 3
        Me.ChkPlasticFan.Text = "Plastic"
        Me.ChkPlasticFan.UseVisualStyleBackColor = True
        '
        'ChkOtherFanType
        '
        Me.ChkOtherFanType.AutoSize = True
        Me.ChkOtherFanType.Location = New System.Drawing.Point(160, 28)
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
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(1082, 491)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(89, 34)
        Me.BtnClose.TabIndex = 19
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(987, 491)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(89, 34)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "End"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'FrmSelections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 530)
        Me.Controls.Add(Me.GrpFanSize)
        Me.Controls.Add(Me.GrpFanSpeed)
        Me.Controls.Add(Me.GrpFanTypes)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.LblFanDetails)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmSelections"
        Me.Text = "FrmSelections"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpFanSize.ResumeLayout(False)
        Me.GrpFanSize.PerformLayout()
        Me.GrpFanSpeed.ResumeLayout(False)
        Me.GrpFanSpeed.PerformLayout()
        Me.GrpPoleBox.ResumeLayout(False)
        Me.GrpPoleBox.PerformLayout()
        Me.GrpFanTypes.ResumeLayout(False)
        Me.GrpFanTypes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblFanDetails As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
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
    Friend WithEvents GrpFanTypes As GroupBox
    Friend WithEvents ChkOldDesignFans As CheckBox
    Friend WithEvents ChkAxialFans As CheckBox
    Friend WithEvents ChkPlenumFans As CheckBox
    Friend WithEvents ChkPlasticFan As CheckBox
    Friend WithEvents ChkOtherFanType As CheckBox
    Friend WithEvents ChkInclineBlade As CheckBox
    Friend WithEvents ChkCurveBlade As CheckBox
    Friend WithEvents BtnClose As Button
    Friend WithEvents Button4 As Button
End Class
