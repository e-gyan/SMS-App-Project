<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdmin_Account
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
        Me.tabAdminAccount = New System.Windows.Forms.TabControl()
        Me.tabSchoolFees = New System.Windows.Forms.TabPage()
        Me.dgvSchoolFees = New System.Windows.Forms.DataGridView()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tabAdminAccount.SuspendLayout()
        Me.tabSchoolFees.SuspendLayout()
        CType(Me.dgvSchoolFees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabAdminAccount
        '
        Me.tabAdminAccount.Controls.Add(Me.tabSchoolFees)
        Me.tabAdminAccount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabAdminAccount.Location = New System.Drawing.Point(0, 0)
        Me.tabAdminAccount.Name = "tabAdminAccount"
        Me.tabAdminAccount.SelectedIndex = 0
        Me.tabAdminAccount.Size = New System.Drawing.Size(933, 641)
        Me.tabAdminAccount.TabIndex = 0
        '
        'tabSchoolFees
        '
        Me.tabSchoolFees.Controls.Add(Me.dgvSchoolFees)
        Me.tabSchoolFees.Controls.Add(Me.Label16)
        Me.tabSchoolFees.Location = New System.Drawing.Point(4, 26)
        Me.tabSchoolFees.Name = "tabSchoolFees"
        Me.tabSchoolFees.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSchoolFees.Size = New System.Drawing.Size(925, 611)
        Me.tabSchoolFees.TabIndex = 0
        Me.tabSchoolFees.Text = "School Fees"
        Me.tabSchoolFees.UseVisualStyleBackColor = True
        '
        'dgvSchoolFees
        '
        Me.dgvSchoolFees.AllowUserToAddRows = False
        Me.dgvSchoolFees.AllowUserToDeleteRows = False
        Me.dgvSchoolFees.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvSchoolFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSchoolFees.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvSchoolFees.GridColor = System.Drawing.SystemColors.Control
        Me.dgvSchoolFees.Location = New System.Drawing.Point(3, 131)
        Me.dgvSchoolFees.Name = "dgvSchoolFees"
        Me.dgvSchoolFees.ReadOnly = True
        Me.dgvSchoolFees.Size = New System.Drawing.Size(919, 477)
        Me.dgvSchoolFees.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label16.Location = New System.Drawing.Point(311, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(355, 32)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "School Fees Payment Account"
        '
        'frmAdmin_Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 641)
        Me.Controls.Add(Me.tabAdminAccount)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmAdmin_Account"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Newman College - Administrator (Account Page)"
        Me.tabAdminAccount.ResumeLayout(False)
        Me.tabSchoolFees.ResumeLayout(False)
        Me.tabSchoolFees.PerformLayout()
        CType(Me.dgvSchoolFees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabAdminAccount As TabControl
    Friend WithEvents tabSchoolFees As TabPage
    Friend WithEvents Label16 As Label
    Friend WithEvents dgvSchoolFees As DataGridView
End Class
