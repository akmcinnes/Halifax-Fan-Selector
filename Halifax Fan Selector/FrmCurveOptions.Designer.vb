<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCurveOptions
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
        Me.chkDamper = New System.Windows.Forms.CheckBox()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.optFSPonly = New System.Windows.Forms.RadioButton()
        Me.optFTPonly = New System.Windows.Forms.RadioButton()
        Me.optFSPandFTP = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'chkDamper
        '
        Me.chkDamper.AutoSize = True
        Me.chkDamper.Location = New System.Drawing.Point(297, 97)
        Me.chkDamper.Name = "chkDamper"
        Me.chkDamper.Size = New System.Drawing.Size(136, 21)
        Me.chkDamper.TabIndex = 0
        Me.chkDamper.Text = "Include Dampers"
        Me.chkDamper.UseVisualStyleBackColor = True
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(297, 345)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(133, 51)
        Me.btnContinue.TabIndex = 1
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'optFSPonly
        '
        Me.optFSPonly.AutoSize = True
        Me.optFSPonly.Location = New System.Drawing.Point(74, 39)
        Me.optFSPonly.Name = "optFSPonly"
        Me.optFSPonly.Size = New System.Drawing.Size(88, 21)
        Me.optFSPonly.TabIndex = 2
        Me.optFSPonly.TabStop = True
        Me.optFSPonly.Text = "FSP Only"
        Me.optFSPonly.UseVisualStyleBackColor = True
        '
        'optFTPonly
        '
        Me.optFTPonly.AutoSize = True
        Me.optFTPonly.Location = New System.Drawing.Point(74, 66)
        Me.optFTPonly.Name = "optFTPonly"
        Me.optFTPonly.Size = New System.Drawing.Size(88, 21)
        Me.optFTPonly.TabIndex = 3
        Me.optFTPonly.TabStop = True
        Me.optFTPonly.Text = "FTP Only"
        Me.optFTPonly.UseVisualStyleBackColor = True
        '
        'optFSPandFTP
        '
        Me.optFSPandFTP.AutoSize = True
        Me.optFSPandFTP.Location = New System.Drawing.Point(74, 97)
        Me.optFSPandFTP.Name = "optFSPandFTP"
        Me.optFSPandFTP.Size = New System.Drawing.Size(98, 21)
        Me.optFSPandFTP.TabIndex = 4
        Me.optFSPandFTP.TabStop = True
        Me.optFSPandFTP.Text = "FSP && FTP"
        Me.optFSPandFTP.UseVisualStyleBackColor = True
        '
        'FrmCurveOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 425)
        Me.Controls.Add(Me.optFSPandFTP)
        Me.Controls.Add(Me.optFTPonly)
        Me.Controls.Add(Me.optFSPonly)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.chkDamper)
        Me.Name = "FrmCurveOptions"
        Me.Text = "FrmCurveOptions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkDamper As CheckBox
    Friend WithEvents btnContinue As Button
    Friend WithEvents optFSPonly As RadioButton
    Friend WithEvents optFTPonly As RadioButton
    Friend WithEvents optFSPandFTP As RadioButton
End Class
