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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProjectDetails))
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
        resources.ApplyResources(Me.LblCustomer, "LblCustomer")
        Me.LblCustomer.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.LblCustomer.ForeColor = System.Drawing.Color.White
        Me.LblCustomer.Name = "LblCustomer"
        '
        'LblSalesEngineer
        '
        resources.ApplyResources(Me.LblSalesEngineer, "LblSalesEngineer")
        Me.LblSalesEngineer.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.LblSalesEngineer.ForeColor = System.Drawing.Color.White
        Me.LblSalesEngineer.Name = "LblSalesEngineer"
        '
        'TxtCustomer
        '
        Me.TxtCustomer.BackColor = System.Drawing.SystemColors.HighlightText
        resources.ApplyResources(Me.TxtCustomer, "TxtCustomer")
        Me.TxtCustomer.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TxtCustomer.Name = "TxtCustomer"
        '
        'TxtEngineer
        '
        Me.TxtEngineer.BackColor = System.Drawing.SystemColors.HighlightText
        resources.ApplyResources(Me.TxtEngineer, "TxtEngineer")
        Me.TxtEngineer.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TxtEngineer.Name = "TxtEngineer"
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.SystemColors.MenuHighlight
        resources.ApplyResources(Me.BtnCancel, "BtnCancel")
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.SystemColors.MenuHighlight
        resources.ApplyResources(Me.BtnExit, "BtnExit")
        Me.BtnExit.ForeColor = System.Drawing.Color.White
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'FrmProjectDetails
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.TxtEngineer)
        Me.Controls.Add(Me.TxtCustomer)
        Me.Controls.Add(Me.LblSalesEngineer)
        Me.Controls.Add(Me.LblCustomer)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmProjectDetails"
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
