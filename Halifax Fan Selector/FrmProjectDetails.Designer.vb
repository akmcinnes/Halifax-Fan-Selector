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
        Me.LblCustomer.Location = New System.Drawing.Point(12, 24)
        Me.LblCustomer.Name = "LblCustomer"
        Me.LblCustomer.Size = New System.Drawing.Size(125, 17)
        Me.LblCustomer.TabIndex = 0
        Me.LblCustomer.Text = "Customer/Contract"
        '
        'LblSalesEngineer
        '
        Me.LblSalesEngineer.AutoSize = True
        Me.LblSalesEngineer.Location = New System.Drawing.Point(12, 53)
        Me.LblSalesEngineer.Name = "LblSalesEngineer"
        Me.LblSalesEngineer.Size = New System.Drawing.Size(104, 17)
        Me.LblSalesEngineer.TabIndex = 1
        Me.LblSalesEngineer.Text = "Sales Engineer"
        '
        'TxtCustomer
        '
        Me.TxtCustomer.Location = New System.Drawing.Point(143, 24)
        Me.TxtCustomer.Name = "TxtCustomer"
        Me.TxtCustomer.Size = New System.Drawing.Size(203, 22)
        Me.TxtCustomer.TabIndex = 2
        '
        'TxtEngineer
        '
        Me.TxtEngineer.Location = New System.Drawing.Point(143, 59)
        Me.TxtEngineer.Name = "TxtEngineer"
        Me.TxtEngineer.Size = New System.Drawing.Size(203, 22)
        Me.TxtEngineer.TabIndex = 3
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(15, 91)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(271, 91)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 5
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'FrmProjectDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 128)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.TxtEngineer)
        Me.Controls.Add(Me.TxtCustomer)
        Me.Controls.Add(Me.LblSalesEngineer)
        Me.Controls.Add(Me.LblCustomer)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 175)
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
