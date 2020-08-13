<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudentPage
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
        Me.studentMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcdemicsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.getStudentID = New System.Windows.Forms.Label()
        Me.studentMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'studentMenu
        '
        Me.studentMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PersonalRecordToolStripMenuItem, Me.AcdemicsToolStripMenuItem, Me.PaymentToolStripMenuItem})
        Me.studentMenu.Location = New System.Drawing.Point(0, 0)
        Me.studentMenu.Name = "studentMenu"
        Me.studentMenu.Size = New System.Drawing.Size(933, 24)
        Me.studentMenu.TabIndex = 1
        Me.studentMenu.Text = "StudentMenu"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PersonalRecordToolStripMenuItem
        '
        Me.PersonalRecordToolStripMenuItem.Name = "PersonalRecordToolStripMenuItem"
        Me.PersonalRecordToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.PersonalRecordToolStripMenuItem.Text = "Personal Record"
        '
        'AcdemicsToolStripMenuItem
        '
        Me.AcdemicsToolStripMenuItem.Name = "AcdemicsToolStripMenuItem"
        Me.AcdemicsToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.AcdemicsToolStripMenuItem.Text = "Academics"
        '
        'PaymentToolStripMenuItem
        '
        Me.PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem"
        Me.PaymentToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.PaymentToolStripMenuItem.Text = "Payment"
        '
        'getStudentID
        '
        Me.getStudentID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.getStudentID.AutoSize = True
        Me.getStudentID.Location = New System.Drawing.Point(875, 7)
        Me.getStudentID.Name = "getStudentID"
        Me.getStudentID.Size = New System.Drawing.Size(0, 17)
        Me.getStudentID.TabIndex = 3
        Me.getStudentID.Visible = False
        '
        'frmStudentPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 588)
        Me.Controls.Add(Me.getStudentID)
        Me.Controls.Add(Me.studentMenu)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.studentMenu
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmStudentPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Newman College - Student"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.studentMenu.ResumeLayout(False)
        Me.studentMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents studentMenu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonalRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcdemicsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents getStudentID As Label
End Class
