<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudent_Academics
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
        Me.tabStudentAcademics = New System.Windows.Forms.TabControl()
        Me.tabAcadResRegister = New System.Windows.Forms.TabPage()
        Me.checkListCourses = New System.Windows.Forms.CheckedListBox()
        Me.txtTermBlock = New System.Windows.Forms.TextBox()
        Me.txtStudentYear = New System.Windows.Forms.TextBox()
        Me.cmbHallResidence = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnStudentRegister = New System.Windows.Forms.Button()
        Me.mtxtStudentRegister = New System.Windows.Forms.MaskedTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tabAddCancelRegister = New System.Windows.Forms.TabPage()
        Me.radCancelCourse = New System.Windows.Forms.RadioButton()
        Me.radAddCourse = New System.Windows.Forms.RadioButton()
        Me.checkListCourse = New System.Windows.Forms.CheckedListBox()
        Me.txtTerm = New System.Windows.Forms.TextBox()
        Me.txtYearBlock = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnModifyCourse = New System.Windows.Forms.Button()
        Me.mstxtAcaYear = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tabProofRegister = New System.Windows.Forms.TabPage()
        Me.tabStudentAcademics.SuspendLayout()
        Me.tabAcadResRegister.SuspendLayout()
        Me.tabAddCancelRegister.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabStudentAcademics
        '
        Me.tabStudentAcademics.Controls.Add(Me.tabAcadResRegister)
        Me.tabStudentAcademics.Controls.Add(Me.tabAddCancelRegister)
        Me.tabStudentAcademics.Controls.Add(Me.tabProofRegister)
        Me.tabStudentAcademics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabStudentAcademics.Location = New System.Drawing.Point(0, 0)
        Me.tabStudentAcademics.Name = "tabStudentAcademics"
        Me.tabStudentAcademics.SelectedIndex = 0
        Me.tabStudentAcademics.Size = New System.Drawing.Size(933, 641)
        Me.tabStudentAcademics.TabIndex = 0
        '
        'tabAcadResRegister
        '
        Me.tabAcadResRegister.Controls.Add(Me.checkListCourses)
        Me.tabAcadResRegister.Controls.Add(Me.txtTermBlock)
        Me.tabAcadResRegister.Controls.Add(Me.txtStudentYear)
        Me.tabAcadResRegister.Controls.Add(Me.cmbHallResidence)
        Me.tabAcadResRegister.Controls.Add(Me.Label2)
        Me.tabAcadResRegister.Controls.Add(Me.Label4)
        Me.tabAcadResRegister.Controls.Add(Me.Label3)
        Me.tabAcadResRegister.Controls.Add(Me.Label1)
        Me.tabAcadResRegister.Controls.Add(Me.Label18)
        Me.tabAcadResRegister.Controls.Add(Me.btnStudentRegister)
        Me.tabAcadResRegister.Controls.Add(Me.mtxtStudentRegister)
        Me.tabAcadResRegister.Controls.Add(Me.Label16)
        Me.tabAcadResRegister.Location = New System.Drawing.Point(4, 26)
        Me.tabAcadResRegister.Name = "tabAcadResRegister"
        Me.tabAcadResRegister.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAcadResRegister.Size = New System.Drawing.Size(925, 611)
        Me.tabAcadResRegister.TabIndex = 0
        Me.tabAcadResRegister.Text = "Registration"
        Me.tabAcadResRegister.UseVisualStyleBackColor = True
        '
        'checkListCourses
        '
        Me.checkListCourses.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.checkListCourses.CheckOnClick = True
        Me.checkListCourses.FormattingEnabled = True
        Me.checkListCourses.Location = New System.Drawing.Point(174, 256)
        Me.checkListCourses.Name = "checkListCourses"
        Me.checkListCourses.Size = New System.Drawing.Size(311, 184)
        Me.checkListCourses.Sorted = True
        Me.checkListCourses.TabIndex = 1
        '
        'txtTermBlock
        '
        Me.txtTermBlock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTermBlock.Enabled = False
        Me.txtTermBlock.Location = New System.Drawing.Point(614, 157)
        Me.txtTermBlock.Name = "txtTermBlock"
        Me.txtTermBlock.Size = New System.Drawing.Size(185, 25)
        Me.txtTermBlock.TabIndex = 0
        '
        'txtStudentYear
        '
        Me.txtStudentYear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtStudentYear.Enabled = False
        Me.txtStudentYear.Location = New System.Drawing.Point(398, 157)
        Me.txtStudentYear.Name = "txtStudentYear"
        Me.txtStudentYear.Size = New System.Drawing.Size(185, 25)
        Me.txtStudentYear.TabIndex = 0
        '
        'cmbHallResidence
        '
        Me.cmbHallResidence.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbHallResidence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHallResidence.FormattingEnabled = True
        Me.cmbHallResidence.Items.AddRange(New Object() {"Akuafo Hall", "Commonwealth Hall", "Elizabeth Frances Sey Hall", "Hilla Limann Hall", "Jean Nelson Hall", "Jubilee Hall", "Legon Hall", "Mensah Sarbah Hall", "Volta Hall"})
        Me.cmbHallResidence.Location = New System.Drawing.Point(555, 256)
        Me.cmbHallResidence.Name = "cmbHallResidence"
        Me.cmbHallResidence.Size = New System.Drawing.Size(277, 25)
        Me.cmbHallResidence.Sorted = True
        Me.cmbHallResidence.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(395, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Year Block"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(552, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 17)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Select Hall of Residence:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(171, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 17)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Select your Course(s):"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(611, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Term Block"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(171, 127)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(158, 17)
        Me.Label18.TabIndex = 64
        Me.Label18.Text = "Academic Year (yyyy-yyyy)"
        '
        'btnStudentRegister
        '
        Me.btnStudentRegister.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnStudentRegister.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnStudentRegister.Location = New System.Drawing.Point(661, 527)
        Me.btnStudentRegister.Name = "btnStudentRegister"
        Me.btnStudentRegister.Size = New System.Drawing.Size(171, 34)
        Me.btnStudentRegister.TabIndex = 3
        Me.btnStudentRegister.Text = "Register"
        Me.btnStudentRegister.UseVisualStyleBackColor = True
        '
        'mtxtStudentRegister
        '
        Me.mtxtStudentRegister.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mtxtStudentRegister.Enabled = False
        Me.mtxtStudentRegister.Location = New System.Drawing.Point(174, 157)
        Me.mtxtStudentRegister.Mask = "0000-0000"
        Me.mtxtStudentRegister.Name = "mtxtStudentRegister"
        Me.mtxtStudentRegister.Size = New System.Drawing.Size(185, 25)
        Me.mtxtStudentRegister.TabIndex = 0
        Me.mtxtStudentRegister.ValidatingType = GetType(Integer)
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label16.Location = New System.Drawing.Point(277, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(446, 32)
        Me.Label16.TabIndex = 60
        Me.Label16.Text = "Register for a Course and a Residence"
        '
        'tabAddCancelRegister
        '
        Me.tabAddCancelRegister.Controls.Add(Me.radCancelCourse)
        Me.tabAddCancelRegister.Controls.Add(Me.radAddCourse)
        Me.tabAddCancelRegister.Controls.Add(Me.checkListCourse)
        Me.tabAddCancelRegister.Controls.Add(Me.txtTerm)
        Me.tabAddCancelRegister.Controls.Add(Me.txtYearBlock)
        Me.tabAddCancelRegister.Controls.Add(Me.Label5)
        Me.tabAddCancelRegister.Controls.Add(Me.Label10)
        Me.tabAddCancelRegister.Controls.Add(Me.Label6)
        Me.tabAddCancelRegister.Controls.Add(Me.Label7)
        Me.tabAddCancelRegister.Controls.Add(Me.Label8)
        Me.tabAddCancelRegister.Controls.Add(Me.btnModifyCourse)
        Me.tabAddCancelRegister.Controls.Add(Me.mstxtAcaYear)
        Me.tabAddCancelRegister.Controls.Add(Me.Label9)
        Me.tabAddCancelRegister.Location = New System.Drawing.Point(4, 26)
        Me.tabAddCancelRegister.Name = "tabAddCancelRegister"
        Me.tabAddCancelRegister.Size = New System.Drawing.Size(925, 611)
        Me.tabAddCancelRegister.TabIndex = 2
        Me.tabAddCancelRegister.Text = "Modify Registration"
        Me.tabAddCancelRegister.UseVisualStyleBackColor = True
        '
        'radCancelCourse
        '
        Me.radCancelCourse.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radCancelCourse.AutoSize = True
        Me.radCancelCourse.Location = New System.Drawing.Point(587, 220)
        Me.radCancelCourse.Name = "radCancelCourse"
        Me.radCancelCourse.Size = New System.Drawing.Size(109, 21)
        Me.radCancelCourse.TabIndex = 1
        Me.radCancelCourse.TabStop = True
        Me.radCancelCourse.Text = "Cancel Course"
        Me.radCancelCourse.UseVisualStyleBackColor = True
        '
        'radAddCourse
        '
        Me.radAddCourse.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radAddCourse.AutoSize = True
        Me.radAddCourse.Location = New System.Drawing.Point(470, 220)
        Me.radAddCourse.Name = "radAddCourse"
        Me.radAddCourse.Size = New System.Drawing.Size(95, 21)
        Me.radAddCourse.TabIndex = 0
        Me.radAddCourse.TabStop = True
        Me.radAddCourse.Text = "Add Course"
        Me.radAddCourse.UseVisualStyleBackColor = True
        '
        'checkListCourse
        '
        Me.checkListCourse.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.checkListCourse.CheckOnClick = True
        Me.checkListCourse.FormattingEnabled = True
        Me.checkListCourse.Location = New System.Drawing.Point(283, 307)
        Me.checkListCourse.Name = "checkListCourse"
        Me.checkListCourse.Size = New System.Drawing.Size(413, 184)
        Me.checkListCourse.Sorted = True
        Me.checkListCourse.TabIndex = 2
        '
        'txtTerm
        '
        Me.txtTerm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTerm.Enabled = False
        Me.txtTerm.Location = New System.Drawing.Point(614, 157)
        Me.txtTerm.Name = "txtTerm"
        Me.txtTerm.Size = New System.Drawing.Size(185, 25)
        Me.txtTerm.TabIndex = 0
        '
        'txtYearBlock
        '
        Me.txtYearBlock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtYearBlock.Enabled = False
        Me.txtYearBlock.Location = New System.Drawing.Point(398, 157)
        Me.txtYearBlock.Name = "txtYearBlock"
        Me.txtYearBlock.Size = New System.Drawing.Size(185, 25)
        Me.txtYearBlock.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(395, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Year Block"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(280, 277)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(134, 17)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "Select your Course(s):"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(235, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(226, 17)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Select what to modify to Registration:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(611, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 17)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Term Block"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(171, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(158, 17)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Academic Year (yyyy-yyyy)"
        '
        'btnModifyCourse
        '
        Me.btnModifyCourse.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnModifyCourse.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnModifyCourse.Location = New System.Drawing.Point(617, 545)
        Me.btnModifyCourse.Name = "btnModifyCourse"
        Me.btnModifyCourse.Size = New System.Drawing.Size(171, 34)
        Me.btnModifyCourse.TabIndex = 3
        Me.btnModifyCourse.Text = "Modify Registration"
        Me.btnModifyCourse.UseVisualStyleBackColor = True
        '
        'mstxtAcaYear
        '
        Me.mstxtAcaYear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mstxtAcaYear.Enabled = False
        Me.mstxtAcaYear.Location = New System.Drawing.Point(174, 157)
        Me.mstxtAcaYear.Mask = "0000-0000"
        Me.mstxtAcaYear.Name = "mstxtAcaYear"
        Me.mstxtAcaYear.Size = New System.Drawing.Size(185, 25)
        Me.mstxtAcaYear.TabIndex = 0
        Me.mstxtAcaYear.ValidatingType = GetType(Integer)
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label9.Location = New System.Drawing.Point(277, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(459, 32)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "Add or Cancel a Course to Registration"
        '
        'tabProofRegister
        '
        Me.tabProofRegister.Location = New System.Drawing.Point(4, 26)
        Me.tabProofRegister.Name = "tabProofRegister"
        Me.tabProofRegister.Size = New System.Drawing.Size(925, 611)
        Me.tabProofRegister.TabIndex = 1
        Me.tabProofRegister.Text = "Proof of Registration"
        Me.tabProofRegister.UseVisualStyleBackColor = True
        '
        'frmStudent_Academics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 641)
        Me.Controls.Add(Me.tabStudentAcademics)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmStudent_Academics"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Newman College - Student (Academic Page)"
        Me.tabStudentAcademics.ResumeLayout(False)
        Me.tabAcadResRegister.ResumeLayout(False)
        Me.tabAcadResRegister.PerformLayout()
        Me.tabAddCancelRegister.ResumeLayout(False)
        Me.tabAddCancelRegister.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabStudentAcademics As TabControl
    Friend WithEvents tabAcadResRegister As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents btnStudentRegister As Button
    Friend WithEvents mtxtStudentRegister As MaskedTextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtStudentYear As TextBox
    Friend WithEvents checkListCourses As CheckedListBox
    Friend WithEvents cmbHallResidence As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tabProofRegister As TabPage
    Friend WithEvents tabAddCancelRegister As TabPage
    Friend WithEvents txtYearBlock As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnModifyCourse As Button
    Friend WithEvents mstxtAcaYear As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents checkListCourse As CheckedListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents radCancelCourse As RadioButton
    Friend WithEvents radAddCourse As RadioButton
    Friend WithEvents txtTermBlock As TextBox
    Friend WithEvents txtTerm As TextBox
End Class
