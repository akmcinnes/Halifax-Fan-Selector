<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDisplayRejects
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDisplayRejects))
        Me.lsvFailedFans = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblDesign = New System.Windows.Forms.Label()
        Me.lblReason = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lsvFailedFans
        '
        Me.lsvFailedFans.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        resources.ApplyResources(Me.lsvFailedFans, "lsvFailedFans")
        Me.lsvFailedFans.ForeColor = System.Drawing.Color.Red
        Me.lsvFailedFans.GridLines = True
        Me.lsvFailedFans.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsvFailedFans.MultiSelect = False
        Me.lsvFailedFans.Name = "lsvFailedFans"
        Me.lsvFailedFans.UseCompatibleStateImageBehavior = False
        Me.lsvFailedFans.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        resources.ApplyResources(Me.ColumnHeader1, "ColumnHeader1")
        '
        'ColumnHeader2
        '
        resources.ApplyResources(Me.ColumnHeader2, "ColumnHeader2")
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblDesign
        '
        resources.ApplyResources(Me.lblDesign, "lblDesign")
        Me.lblDesign.Name = "lblDesign"
        '
        'lblReason
        '
        resources.ApplyResources(Me.lblReason, "lblReason")
        Me.lblReason.Name = "lblReason"
        '
        'FrmDisplayRejects
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Halifax_Fan_Selector.My.Resources.Resources._0_faded1
        Me.Controls.Add(Me.lblReason)
        Me.Controls.Add(Me.lblDesign)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lsvFailedFans)
        Me.Name = "FrmDisplayRejects"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lsvFailedFans As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Button1 As Button
    Friend WithEvents lblDesign As Label
    Friend WithEvents lblReason As Label
End Class
