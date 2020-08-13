<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStaffPage
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
        Me.staffMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.getStaffID = New System.Windows.Forms.Label()
        Me.staffMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'staffMenu
        '
        Me.staffMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PersonalRecordToolStripMenuItem, Me.CourseToolStripMenuItem})
        Me.staffMenu.Location = New System.Drawing.Point(0, 0)
        Me.staffMenu.Name = "staffMenu"
        Me.staffMenu.Size = New System.Drawing.Size(800, 24)
        Me.staffMenu.TabIndex = 0
        Me.staffMenu.Text = "StaffMenu"
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
        'CourseToolStripMenuItem
        '
        Me.CourseToolStripMenuItem.Name = "CourseToolStripMenuItem"
        Me.CourseToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.CourseToolStripMenuItem.Text = "Course"
        '
        'getStaffID
        '
        Me.getStaffID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.getStaffID.AutoSize = True
        Me.getStaffID.Location = New System.Drawing.Point(749, 9)
        Me.getStaffID.Name = "getStaffID"
        Me.getStaffID.Size = New System.Drawing.Size(0, 13)
        Me.getStaffID.TabIndex = 2
        Me.getStaffID.Visible = False
        '
        'frmStaffPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.getStaffID)
        Me.Controls.Add(Me.staffMenu)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.staffMenu
        Me.Name = "frmStaffPage"
        Me.Text = "Newman College - Staff"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.staffMenu.ResumeLayout(False)
        Me.staffMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents staffMenu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonalRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CourseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents getStaffID As Label
End Class
