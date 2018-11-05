<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProjectDetails
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
        Me.LblCustomer = New System.Windows.Forms.Label()
        Me.LblSalesEngineer = New System.Windows.Forms.Label()
        Me.TxtCustomer = New System.Windows.Forms.TextBox()
        Me.TxtEngineer = New System.Windows.Forms.TextBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblCustomer
        '
        Me.LblCustomer.AutoSize = True
        Me.LblCustomer.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.LblCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCustomer.ForeColor = System.Drawing.Color.White
        Me.LblCustomer.Location = New System.Drawing.Point(28, 30)
        Me.LblCustomer.Name = "LblCustomer"
        Me.LblCustomer.Size = New System.Drawing.Size(152, 18)
        Me.LblCustomer.TabIndex = 0
        Me.LblCustomer.Text = "Customer/Contract"
        '
        'LblSalesEngineer
        '
        Me.LblSalesEngineer.AutoSize = True
        Me.LblSalesEngineer.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.LblSalesEngineer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSalesEngineer.ForeColor = System.Drawing.Color.White
        Me.LblSalesEngineer.Location = New System.Drawing.Point(28, 64)
        Me.LblSalesEngineer.Name = "LblSalesEngineer"
        Me.LblSalesEngineer.Size = New System.Drawing.Size(121, 18)
        Me.LblSalesEngineer.TabIndex = 1
        Me.LblSalesEngineer.Text = "Sales Engineer"
        '
        'TxtCustomer
        '
        Me.TxtCustomer.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomer.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TxtCustomer.Location = New System.Drawing.Point(231, 24)
        Me.TxtCustomer.Name = "TxtCustomer"
        Me.TxtCustomer.Size = New System.Drawing.Size(203, 24)
        Me.TxtCustomer.TabIndex = 2
        '
        'TxtEngineer
        '
        Me.TxtEngineer.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtEngineer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEngineer.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TxtEngineer.Location = New System.Drawing.Point(231, 61)
        Me.TxtEngineer.Name = "TxtEngineer"
        Me.TxtEngineer.Size = New System.Drawing.Size(203, 24)
        Me.TxtEngineer.TabIndex = 3
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(31, 127)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(109, 46)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.White
        Me.BtnExit.Location = New System.Drawing.Point(325, 127)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(109, 46)
        Me.BtnExit.TabIndex = 5
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'FrmProjectDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(470, 185)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.TxtEngineer)
        Me.Controls.Add(Me.TxtCustomer)
        Me.Controls.Add(Me.LblSalesEngineer)
        Me.Controls.Add(Me.LblCustomer)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(400, 175)
        Me.Name = "FrmProjectDetails"
        Me.Text = "Project Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblCustomer As Label
    Friend WithEvents LblSalesEngineer As Label
    Friend WithEvents TxtCustomer As TextBox
    Friend WithEvents TxtEngineer As TextBox
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnExit As Button
End Class
