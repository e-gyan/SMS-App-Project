<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaff_Course
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
        Me.tabStaffCourse = New System.Windows.Forms.TabControl()
        Me.tabRegister = New System.Windows.Forms.TabPage()
        Me.txtTermBlock = New System.Windows.Forms.TextBox()
        Me.radYear3 = New System.Windows.Forms.RadioButton()
        Me.radYear2 = New System.Windows.Forms.RadioButton()
        Me.radYear1 = New System.Windows.Forms.RadioButton()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnRegisterCourse = New System.Windows.Forms.Button()
        Me.mtxtCourse = New System.Windows.Forms.MaskedTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tabPerformance = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCourseSearch = New System.Windows.Forms.Button()
        Me.mtxtCourseStudent = New System.Windows.Forms.MaskedTextBox()
        Me.dgvCourseStudent = New System.Windows.Forms.DataGridView()
        Me.radCourseYear3 = New System.Windows.Forms.RadioButton()
        Me.radCourseYear2 = New System.Windows.Forms.RadioButton()
        Me.radCourseYear1 = New System.Windows.Forms.RadioButton()
        Me.cmbCourseTerm = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCourseSubmit = New System.Windows.Forms.Button()
        Me.mstxtCourseYear = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tabStaffCourse.SuspendLayout()
        Me.tabRegister.SuspendLayout()
        Me.tabPerformance.SuspendLayout()
        CType(Me.dgvCourseStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabStaffCourse
        '
        Me.tabStaffCourse.Controls.Add(Me.tabRegister)
        Me.tabStaffCourse.Controls.Add(Me.tabPerformance)
        Me.tabStaffCourse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabStaffCourse.Location = New System.Drawing.Point(0, 0)
        Me.tabStaffCourse.Name = "tabStaffCourse"
        Me.tabStaffCourse.SelectedIndex = 0
        Me.tabStaffCourse.Size = New System.Drawing.Size(933, 652)
        Me.tabStaffCourse.TabIndex = 0
        '
        'tabRegister
        '
        Me.tabRegister.Controls.Add(Me.txtTermBlock)
        Me.tabRegister.Controls.Add(Me.radYear3)
        Me.tabRegister.Controls.Add(Me.radYear2)
        Me.tabRegister.Controls.Add(Me.radYear1)
        Me.tabRegister.Controls.Add(Me.cmbCourse)
        Me.tabRegister.Controls.Add(Me.Label2)
        Me.tabRegister.Controls.Add(Me.Label3)
        Me.tabRegister.Controls.Add(Me.Label1)
        Me.tabRegister.Controls.Add(Me.Label18)
        Me.tabRegister.Controls.Add(Me.btnRegisterCourse)
        Me.tabRegister.Controls.Add(Me.mtxtCourse)
        Me.tabRegister.Controls.Add(Me.Label16)
        Me.tabRegister.Location = New System.Drawing.Point(4, 26)
        Me.tabRegister.Name = "tabRegister"
        Me.tabRegister.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRegister.Size = New System.Drawing.Size(925, 622)
        Me.tabRegister.TabIndex = 0
        Me.tabRegister.Text = "Register"
        Me.tabRegister.UseVisualStyleBackColor = True
        '
        'txtTermBlock
        '
        Me.txtTermBlock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTermBlock.Enabled = False
        Me.txtTermBlock.Location = New System.Drawing.Point(174, 264)
        Me.txtTermBlock.Name = "txtTermBlock"
        Me.txtTermBlock.Size = New System.Drawing.Size(185, 25)
        Me.txtTermBlock.TabIndex = 57
        '
        'radYear3
        '
        Me.radYear3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radYear3.AutoSize = True
        Me.radYear3.Location = New System.Drawing.Point(599, 158)
        Me.radYear3.Name = "radYear3"
        Me.radYear3.Size = New System.Drawing.Size(62, 21)
        Me.radYear3.TabIndex = 56
        Me.radYear3.TabStop = True
        Me.radYear3.Text = "Year 3"
        Me.radYear3.UseVisualStyleBackColor = True
        '
        'radYear2
        '
        Me.radYear2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radYear2.AutoSize = True
        Me.radYear2.Location = New System.Drawing.Point(520, 158)
        Me.radYear2.Name = "radYear2"
        Me.radYear2.Size = New System.Drawing.Size(62, 21)
        Me.radYear2.TabIndex = 56
        Me.radYear2.TabStop = True
        Me.radYear2.Text = "Year 2"
        Me.radYear2.UseVisualStyleBackColor = True
        '
        'radYear1
        '
        Me.radYear1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radYear1.AutoSize = True
        Me.radYear1.Location = New System.Drawing.Point(443, 159)
        Me.radYear1.Name = "radYear1"
        Me.radYear1.Size = New System.Drawing.Size(62, 21)
        Me.radYear1.TabIndex = 0
        Me.radYear1.TabStop = True
        Me.radYear1.Text = "Year 1"
        Me.radYear1.UseVisualStyleBackColor = True
        '
        'cmbCourse
        '
        Me.cmbCourse.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.ItemHeight = 17
        Me.cmbCourse.Location = New System.Drawing.Point(444, 264)
        Me.cmbCourse.MaxDropDownItems = 15
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(378, 25)
        Me.cmbCourse.Sorted = True
        Me.cmbCourse.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(441, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 17)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Select Year Block:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(441, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Select Course:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(171, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Term Block"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(171, 127)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(93, 17)
        Me.Label18.TabIndex = 55
        Me.Label18.Text = "Academic Year"
        '
        'btnRegisterCourse
        '
        Me.btnRegisterCourse.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRegisterCourse.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnRegisterCourse.Location = New System.Drawing.Point(651, 436)
        Me.btnRegisterCourse.Name = "btnRegisterCourse"
        Me.btnRegisterCourse.Size = New System.Drawing.Size(171, 34)
        Me.btnRegisterCourse.TabIndex = 2
        Me.btnRegisterCourse.Text = "Register Course"
        Me.btnRegisterCourse.UseVisualStyleBackColor = True
        '
        'mtxtCourse
        '
        Me.mtxtCourse.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mtxtCourse.Enabled = False
        Me.mtxtCourse.Location = New System.Drawing.Point(174, 157)
        Me.mtxtCourse.Mask = "0000-0000"
        Me.mtxtCourse.Name = "mtxtCourse"
        Me.mtxtCourse.Size = New System.Drawing.Size(185, 25)
        Me.mtxtCourse.TabIndex = 0
        Me.mtxtCourse.ValidatingType = GetType(Integer)
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label16.Location = New System.Drawing.Point(319, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(323, 32)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "Register To Teach A Course"
        '
        'tabPerformance
        '
        Me.tabPerformance.Controls.Add(Me.Label8)
        Me.tabPerformance.Controls.Add(Me.btnCourseSearch)
        Me.tabPerformance.Controls.Add(Me.mtxtCourseStudent)
        Me.tabPerformance.Controls.Add(Me.dgvCourseStudent)
        Me.tabPerformance.Controls.Add(Me.radCourseYear3)
        Me.tabPerformance.Controls.Add(Me.radCourseYear2)
        Me.tabPerformance.Controls.Add(Me.radCourseYear1)
        Me.tabPerformance.Controls.Add(Me.cmbCourseTerm)
        Me.tabPerformance.Controls.Add(Me.Label4)
        Me.tabPerformance.Controls.Add(Me.Label5)
        Me.tabPerformance.Controls.Add(Me.Label6)
        Me.tabPerformance.Controls.Add(Me.btnCourseSubmit)
        Me.tabPerformance.Controls.Add(Me.mstxtCourseYear)
        Me.tabPerformance.Controls.Add(Me.Label7)
        Me.tabPerformance.Location = New System.Drawing.Point(4, 26)
        Me.tabPerformance.Name = "tabPerformance"
        Me.tabPerformance.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPerformance.Size = New System.Drawing.Size(925, 622)
        Me.tabPerformance.TabIndex = 1
        Me.tabPerformance.Text = "Student Perfomance"
        Me.tabPerformance.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(473, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 17)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Student ID:"
        '
        'btnCourseSearch
        '
        Me.btnCourseSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCourseSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnCourseSearch.Location = New System.Drawing.Point(741, 233)
        Me.btnCourseSearch.Name = "btnCourseSearch"
        Me.btnCourseSearch.Size = New System.Drawing.Size(116, 34)
        Me.btnCourseSearch.TabIndex = 4
        Me.btnCourseSearch.Text = "Search"
        Me.btnCourseSearch.UseVisualStyleBackColor = True
        '
        'mtxtCourseStudent
        '
        Me.mtxtCourseStudent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mtxtCourseStudent.Location = New System.Drawing.Point(550, 239)
        Me.mtxtCourseStudent.Mask = "00000000"
        Me.mtxtCourseStudent.Name = "mtxtCourseStudent"
        Me.mtxtCourseStudent.Size = New System.Drawing.Size(185, 25)
        Me.mtxtCourseStudent.TabIndex = 3
        Me.mtxtCourseStudent.ValidatingType = GetType(Integer)
        '
        'dgvCourseStudent
        '
        Me.dgvCourseStudent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvCourseStudent.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvCourseStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCourseStudent.Location = New System.Drawing.Point(79, 282)
        Me.dgvCourseStudent.Name = "dgvCourseStudent"
        Me.dgvCourseStudent.Size = New System.Drawing.Size(778, 255)
        Me.dgvCourseStudent.TabIndex = 5
        '
        'radCourseYear3
        '
        Me.radCourseYear3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radCourseYear3.AutoSize = True
        Me.radCourseYear3.Location = New System.Drawing.Point(771, 155)
        Me.radCourseYear3.Name = "radCourseYear3"
        Me.radCourseYear3.Size = New System.Drawing.Size(62, 21)
        Me.radCourseYear3.TabIndex = 3
        Me.radCourseYear3.Text = "Year 3"
        Me.radCourseYear3.UseVisualStyleBackColor = True
        '
        'radCourseYear2
        '
        Me.radCourseYear2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radCourseYear2.AutoSize = True
        Me.radCourseYear2.Location = New System.Drawing.Point(692, 155)
        Me.radCourseYear2.Name = "radCourseYear2"
        Me.radCourseYear2.Size = New System.Drawing.Size(62, 21)
        Me.radCourseYear2.TabIndex = 2
        Me.radCourseYear2.Text = "Year 2"
        Me.radCourseYear2.UseVisualStyleBackColor = True
        '
        'radCourseYear1
        '
        Me.radCourseYear1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radCourseYear1.AutoSize = True
        Me.radCourseYear1.Location = New System.Drawing.Point(615, 156)
        Me.radCourseYear1.Name = "radCourseYear1"
        Me.radCourseYear1.Size = New System.Drawing.Size(62, 21)
        Me.radCourseYear1.TabIndex = 1
        Me.radCourseYear1.Text = "Year 1"
        Me.radCourseYear1.UseVisualStyleBackColor = True
        '
        'cmbCourseTerm
        '
        Me.cmbCourseTerm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbCourseTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCourseTerm.Enabled = False
        Me.cmbCourseTerm.FormattingEnabled = True
        Me.cmbCourseTerm.Location = New System.Drawing.Point(403, 154)
        Me.cmbCourseTerm.Name = "cmbCourseTerm"
        Me.cmbCourseTerm.Size = New System.Drawing.Size(174, 25)
        Me.cmbCourseTerm.Sorted = True
        Me.cmbCourseTerm.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(613, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 17)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Select Year Block:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(400, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Term Block"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(171, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 17)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Academic Year"
        '
        'btnCourseSubmit
        '
        Me.btnCourseSubmit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCourseSubmit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnCourseSubmit.Location = New System.Drawing.Point(686, 563)
        Me.btnCourseSubmit.Name = "btnCourseSubmit"
        Me.btnCourseSubmit.Size = New System.Drawing.Size(171, 34)
        Me.btnCourseSubmit.TabIndex = 6
        Me.btnCourseSubmit.Text = "Submit "
        Me.btnCourseSubmit.UseVisualStyleBackColor = True
        '
        'mstxtCourseYear
        '
        Me.mstxtCourseYear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mstxtCourseYear.Enabled = False
        Me.mstxtCourseYear.Location = New System.Drawing.Point(174, 154)
        Me.mstxtCourseYear.Mask = "0000-0000"
        Me.mstxtCourseYear.Name = "mstxtCourseYear"
        Me.mstxtCourseYear.Size = New System.Drawing.Size(185, 25)
        Me.mstxtCourseYear.TabIndex = 0
        Me.mstxtCourseYear.ValidatingType = GetType(Integer)
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.Location = New System.Drawing.Point(319, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(344, 32)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Record Student Performance"
        '
        'frmStaff_Course
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 652)
        Me.Controls.Add(Me.tabStaffCourse)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmStaff_Course"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Newman College - Staff (Course Page)"
        Me.tabStaffCourse.ResumeLayout(False)
        Me.tabRegister.ResumeLayout(False)
        Me.tabRegister.PerformLayout()
        Me.tabPerformance.ResumeLayout(False)
        Me.tabPerformance.PerformLayout()
        CType(Me.dgvCourseStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabStaffCourse As TabControl
    Friend WithEvents tabRegister As TabPage
    Friend WithEvents tabPerformance As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents btnRegisterCourse As Button
    Friend WithEvents mtxtCourse As MaskedTextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents radYear1 As RadioButton
    Friend WithEvents radYear3 As RadioButton
    Friend WithEvents radYear2 As RadioButton
    Friend WithEvents cmbCourse As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents radCourseYear3 As RadioButton
    Friend WithEvents radCourseYear2 As RadioButton
    Friend WithEvents radCourseYear1 As RadioButton
    Friend WithEvents cmbCourseTerm As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCourseSubmit As Button
    Friend WithEvents mstxtCourseYear As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvCourseStudent As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCourseSearch As Button
    Friend WithEvents mtxtCourseStudent As MaskedTextBox
    Friend WithEvents txtTermBlock As TextBox
End Class
