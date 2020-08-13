<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdmin_Academics
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
        Me.tabAdminAcademics = New System.Windows.Forms.TabControl()
        Me.tabInitialiseAcademics = New System.Windows.Forms.TabPage()
        Me.radEnd = New System.Windows.Forms.RadioButton()
        Me.radInitial = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkYear3 = New System.Windows.Forms.CheckBox()
        Me.chkYear2 = New System.Windows.Forms.CheckBox()
        Me.chkYear1 = New System.Windows.Forms.CheckBox()
        Me.cmbTermBlock = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.mtxtAcademicYear = New System.Windows.Forms.MaskedTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tabAdminAcademics.SuspendLayout()
        Me.tabInitialiseAcademics.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabAdminAcademics
        '
        Me.tabAdminAcademics.Controls.Add(Me.tabInitialiseAcademics)
        Me.tabAdminAcademics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabAdminAcademics.Location = New System.Drawing.Point(0, 0)
        Me.tabAdminAcademics.Name = "tabAdminAcademics"
        Me.tabAdminAcademics.SelectedIndex = 0
        Me.tabAdminAcademics.Size = New System.Drawing.Size(713, 430)
        Me.tabAdminAcademics.TabIndex = 0
        '
        'tabInitialiseAcademics
        '
        Me.tabInitialiseAcademics.Controls.Add(Me.radEnd)
        Me.tabInitialiseAcademics.Controls.Add(Me.radInitial)
        Me.tabInitialiseAcademics.Controls.Add(Me.Label3)
        Me.tabInitialiseAcademics.Controls.Add(Me.chkYear3)
        Me.tabInitialiseAcademics.Controls.Add(Me.chkYear2)
        Me.tabInitialiseAcademics.Controls.Add(Me.chkYear1)
        Me.tabInitialiseAcademics.Controls.Add(Me.cmbTermBlock)
        Me.tabInitialiseAcademics.Controls.Add(Me.Label2)
        Me.tabInitialiseAcademics.Controls.Add(Me.Label1)
        Me.tabInitialiseAcademics.Controls.Add(Me.Label18)
        Me.tabInitialiseAcademics.Controls.Add(Me.btnSubmit)
        Me.tabInitialiseAcademics.Controls.Add(Me.mtxtAcademicYear)
        Me.tabInitialiseAcademics.Controls.Add(Me.Label16)
        Me.tabInitialiseAcademics.Location = New System.Drawing.Point(4, 26)
        Me.tabInitialiseAcademics.Name = "tabInitialiseAcademics"
        Me.tabInitialiseAcademics.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInitialiseAcademics.Size = New System.Drawing.Size(705, 400)
        Me.tabInitialiseAcademics.TabIndex = 0
        Me.tabInitialiseAcademics.Text = "Initialise Academic Year"
        Me.tabInitialiseAcademics.UseVisualStyleBackColor = True
        '
        'radEnd
        '
        Me.radEnd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radEnd.AutoSize = True
        Me.radEnd.Location = New System.Drawing.Point(397, 87)
        Me.radEnd.Name = "radEnd"
        Me.radEnd.Size = New System.Drawing.Size(137, 21)
        Me.radEnd.TabIndex = 0
        Me.radEnd.TabStop = True
        Me.radEnd.Text = "End Academic Year"
        Me.radEnd.UseVisualStyleBackColor = True
        '
        'radInitial
        '
        Me.radInitial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radInitial.AutoSize = True
        Me.radInitial.Location = New System.Drawing.Point(230, 87)
        Me.radInitial.Name = "radInitial"
        Me.radInitial.Size = New System.Drawing.Size(161, 21)
        Me.radInitial.TabIndex = 0
        Me.radInitial.TabStop = True
        Me.radInitial.Text = "Initialise Academic Year"
        Me.radInitial.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(105, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Select an option:*"
        '
        'chkYear3
        '
        Me.chkYear3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkYear3.AutoSize = True
        Me.chkYear3.Location = New System.Drawing.Point(571, 242)
        Me.chkYear3.Name = "chkYear3"
        Me.chkYear3.Size = New System.Drawing.Size(63, 21)
        Me.chkYear3.TabIndex = 4
        Me.chkYear3.Text = "Year 3"
        Me.chkYear3.UseVisualStyleBackColor = True
        '
        'chkYear2
        '
        Me.chkYear2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkYear2.AutoSize = True
        Me.chkYear2.Location = New System.Drawing.Point(571, 215)
        Me.chkYear2.Name = "chkYear2"
        Me.chkYear2.Size = New System.Drawing.Size(63, 21)
        Me.chkYear2.TabIndex = 3
        Me.chkYear2.Text = "Year 2"
        Me.chkYear2.UseVisualStyleBackColor = True
        '
        'chkYear1
        '
        Me.chkYear1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkYear1.AutoSize = True
        Me.chkYear1.Location = New System.Drawing.Point(571, 188)
        Me.chkYear1.Name = "chkYear1"
        Me.chkYear1.Size = New System.Drawing.Size(63, 21)
        Me.chkYear1.TabIndex = 2
        Me.chkYear1.Text = "Year 1"
        Me.chkYear1.UseVisualStyleBackColor = True
        '
        'cmbTermBlock
        '
        Me.cmbTermBlock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbTermBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTermBlock.FormattingEnabled = True
        Me.cmbTermBlock.Items.AddRange(New Object() {"Term 1", "Term 2"})
        Me.cmbTermBlock.Location = New System.Drawing.Point(332, 188)
        Me.cmbTermBlock.Name = "cmbTermBlock"
        Me.cmbTermBlock.Size = New System.Drawing.Size(174, 25)
        Me.cmbTermBlock.Sorted = True
        Me.cmbTermBlock.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(568, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 17)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Year"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(329, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Term Block"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(63, 158)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(192, 17)
        Me.Label18.TabIndex = 47
        Me.Label18.Text = "Enter Academic Year (yyyy-yyyy)"
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(534, 315)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(100, 32)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'mtxtAcademicYear
        '
        Me.mtxtAcademicYear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mtxtAcademicYear.HideSelection = False
        Me.mtxtAcademicYear.Location = New System.Drawing.Point(66, 188)
        Me.mtxtAcademicYear.Mask = "0000-0000"
        Me.mtxtAcademicYear.Name = "mtxtAcademicYear"
        Me.mtxtAcademicYear.Size = New System.Drawing.Size(185, 25)
        Me.mtxtAcademicYear.TabIndex = 0
        Me.mtxtAcademicYear.ValidatingType = GetType(Integer)
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label16.Location = New System.Drawing.Point(134, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(400, 32)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Initialise Academic Year and Term"
        '
        'frmAdmin_Academics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 430)
        Me.Controls.Add(Me.tabAdminAcademics)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmAdmin_Academics"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Newman College - Administrator (Academics Page)"
        Me.tabAdminAcademics.ResumeLayout(False)
        Me.tabInitialiseAcademics.ResumeLayout(False)
        Me.tabInitialiseAcademics.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabAdminAcademics As TabControl
    Friend WithEvents tabInitialiseAcademics As TabPage
    Friend WithEvents Label16 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents mtxtAcademicYear As MaskedTextBox
    Friend WithEvents cmbTermBlock As ComboBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents chkYear3 As CheckBox
    Friend WithEvents chkYear2 As CheckBox
    Friend WithEvents chkYear1 As CheckBox
    Friend WithEvents radEnd As RadioButton
    Friend WithEvents radInitial As RadioButton
    Friend WithEvents Label3 As Label
End Class
