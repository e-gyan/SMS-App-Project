<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudent_PersonalRecord
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
        Me.tabStudentPersonal = New System.Windows.Forms.TabControl()
        Me.tabViewEditRecord = New System.Windows.Forms.TabPage()
        Me.txtPin = New System.Windows.Forms.TextBox()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmbSchool = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnStudentPersonalUpdate = New System.Windows.Forms.Button()
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.mtxtMobile = New System.Windows.Forms.MaskedTextBox()
        Me.cmbRegion = New System.Windows.Forms.ComboBox()
        Me.cmbResidence = New System.Windows.Forms.ComboBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.dateBirthday = New System.Windows.Forms.DateTimePicker()
        Me.txtHometown = New System.Windows.Forms.TextBox()
        Me.txtPostalAddress = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.cbTitle = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabStudentPersonal.SuspendLayout()
        Me.tabViewEditRecord.SuspendLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabStudentPersonal
        '
        Me.tabStudentPersonal.Controls.Add(Me.tabViewEditRecord)
        Me.tabStudentPersonal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabStudentPersonal.Location = New System.Drawing.Point(0, 0)
        Me.tabStudentPersonal.Name = "tabStudentPersonal"
        Me.tabStudentPersonal.SelectedIndex = 0
        Me.tabStudentPersonal.Size = New System.Drawing.Size(933, 715)
        Me.tabStudentPersonal.TabIndex = 0
        '
        'tabViewEditRecord
        '
        Me.tabViewEditRecord.Controls.Add(Me.txtPin)
        Me.tabViewEditRecord.Controls.Add(Me.txtStudentID)
        Me.tabViewEditRecord.Controls.Add(Me.Label13)
        Me.tabViewEditRecord.Controls.Add(Me.Label22)
        Me.tabViewEditRecord.Controls.Add(Me.cmbSchool)
        Me.tabViewEditRecord.Controls.Add(Me.Label21)
        Me.tabViewEditRecord.Controls.Add(Me.Label17)
        Me.tabViewEditRecord.Controls.Add(Me.Label16)
        Me.tabViewEditRecord.Controls.Add(Me.btnStudentPersonalUpdate)
        Me.tabViewEditRecord.Controls.Add(Me.pbImage)
        Me.tabViewEditRecord.Controls.Add(Me.cmbDepartment)
        Me.tabViewEditRecord.Controls.Add(Me.mtxtMobile)
        Me.tabViewEditRecord.Controls.Add(Me.cmbRegion)
        Me.tabViewEditRecord.Controls.Add(Me.cmbResidence)
        Me.tabViewEditRecord.Controls.Add(Me.cmbStatus)
        Me.tabViewEditRecord.Controls.Add(Me.cmbGender)
        Me.tabViewEditRecord.Controls.Add(Me.dateBirthday)
        Me.tabViewEditRecord.Controls.Add(Me.txtHometown)
        Me.tabViewEditRecord.Controls.Add(Me.txtPostalAddress)
        Me.tabViewEditRecord.Controls.Add(Me.txtLastName)
        Me.tabViewEditRecord.Controls.Add(Me.txtMiddleName)
        Me.tabViewEditRecord.Controls.Add(Me.txtFirstName)
        Me.tabViewEditRecord.Controls.Add(Me.cbTitle)
        Me.tabViewEditRecord.Controls.Add(Me.Label8)
        Me.tabViewEditRecord.Controls.Add(Me.Label14)
        Me.tabViewEditRecord.Controls.Add(Me.Label7)
        Me.tabViewEditRecord.Controls.Add(Me.Label4)
        Me.tabViewEditRecord.Controls.Add(Me.Label12)
        Me.tabViewEditRecord.Controls.Add(Me.Label6)
        Me.tabViewEditRecord.Controls.Add(Me.Label11)
        Me.tabViewEditRecord.Controls.Add(Me.Label3)
        Me.tabViewEditRecord.Controls.Add(Me.Label10)
        Me.tabViewEditRecord.Controls.Add(Me.Label5)
        Me.tabViewEditRecord.Controls.Add(Me.Label9)
        Me.tabViewEditRecord.Controls.Add(Me.Label2)
        Me.tabViewEditRecord.Controls.Add(Me.Label1)
        Me.tabViewEditRecord.Location = New System.Drawing.Point(4, 26)
        Me.tabViewEditRecord.Name = "tabViewEditRecord"
        Me.tabViewEditRecord.Padding = New System.Windows.Forms.Padding(3)
        Me.tabViewEditRecord.Size = New System.Drawing.Size(925, 685)
        Me.tabViewEditRecord.TabIndex = 0
        Me.tabViewEditRecord.Text = "View and Edit Record"
        Me.tabViewEditRecord.UseVisualStyleBackColor = True
        '
        'txtPin
        '
        Me.txtPin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPin.Enabled = False
        Me.txtPin.Location = New System.Drawing.Point(635, 530)
        Me.txtPin.Name = "txtPin"
        Me.txtPin.Size = New System.Drawing.Size(201, 25)
        Me.txtPin.TabIndex = 14
        '
        'txtStudentID
        '
        Me.txtStudentID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtStudentID.Enabled = False
        Me.txtStudentID.Location = New System.Drawing.Point(186, 228)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(201, 25)
        Me.txtStudentID.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(526, 533)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(91, 17)
        Me.Label13.TabIndex = 78
        Me.Label13.Text = "Email Address"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(92, 231)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(68, 17)
        Me.Label22.TabIndex = 79
        Me.Label22.Text = "Student ID"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmbSchool
        '
        Me.cmbSchool.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbSchool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSchool.Enabled = False
        Me.cmbSchool.FormattingEnabled = True
        Me.cmbSchool.Location = New System.Drawing.Point(635, 488)
        Me.cmbSchool.Name = "cmbSchool"
        Me.cmbSchool.Size = New System.Drawing.Size(201, 25)
        Me.cmbSchool.Sorted = True
        Me.cmbSchool.TabIndex = 13
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(565, 491)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(47, 17)
        Me.Label21.TabIndex = 75
        Me.Label21.Text = "School"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label17.Location = New System.Drawing.Point(376, 45)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(226, 21)
        Me.Label17.TabIndex = 74
        Me.Label17.Text = "Record Form (*required field)"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label16.Location = New System.Drawing.Point(318, 13)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(363, 32)
        Me.Label16.TabIndex = 73
        Me.Label16.Text = "View and Edit Personal Record"
        '
        'btnStudentPersonalUpdate
        '
        Me.btnStudentPersonalUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnStudentPersonalUpdate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnStudentPersonalUpdate.Location = New System.Drawing.Point(720, 612)
        Me.btnStudentPersonalUpdate.Name = "btnStudentPersonalUpdate"
        Me.btnStudentPersonalUpdate.Size = New System.Drawing.Size(116, 36)
        Me.btnStudentPersonalUpdate.TabIndex = 15
        Me.btnStudentPersonalUpdate.Text = "Update"
        Me.btnStudentPersonalUpdate.UseVisualStyleBackColor = True
        '
        'pbImage
        '
        Me.pbImage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbImage.Location = New System.Drawing.Point(439, 89)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(100, 100)
        Me.pbImage.TabIndex = 72
        Me.pbImage.TabStop = False
        '
        'cmbDepartment
        '
        Me.cmbDepartment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartment.Enabled = False
        Me.cmbDepartment.FormattingEnabled = True
        Me.cmbDepartment.Location = New System.Drawing.Point(635, 447)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(201, 25)
        Me.cmbDepartment.Sorted = True
        Me.cmbDepartment.TabIndex = 12
        '
        'mtxtMobile
        '
        Me.mtxtMobile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mtxtMobile.Location = New System.Drawing.Point(635, 404)
        Me.mtxtMobile.Mask = "000 000 0000"
        Me.mtxtMobile.Name = "mtxtMobile"
        Me.mtxtMobile.Size = New System.Drawing.Size(201, 25)
        Me.mtxtMobile.TabIndex = 11
        '
        'cmbRegion
        '
        Me.cmbRegion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRegion.Enabled = False
        Me.cmbRegion.FormattingEnabled = True
        Me.cmbRegion.Items.AddRange(New Object() {"Central", "Eastern", "Greater Accra", "Western"})
        Me.cmbRegion.Location = New System.Drawing.Point(635, 267)
        Me.cmbRegion.Name = "cmbRegion"
        Me.cmbRegion.Size = New System.Drawing.Size(201, 25)
        Me.cmbRegion.Sorted = True
        Me.cmbRegion.TabIndex = 9
        '
        'cmbResidence
        '
        Me.cmbResidence.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbResidence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbResidence.Enabled = False
        Me.cmbResidence.FormattingEnabled = True
        Me.cmbResidence.Items.AddRange(New Object() {"Administrative", "Assistant Lecturer", "College Secretary", "Department Secretary", "Lecturer", "Part-Time Lecturer", "Provost", "School Secretary", "Senior Lecturer", "Vice Chancellor"})
        Me.cmbResidence.Location = New System.Drawing.Point(185, 542)
        Me.cmbResidence.Name = "cmbResidence"
        Me.cmbResidence.Size = New System.Drawing.Size(174, 25)
        Me.cmbResidence.Sorted = True
        Me.cmbResidence.TabIndex = 7
        '
        'cmbStatus
        '
        Me.cmbStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.Enabled = False
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Administrative Staff", "Teaching Staff"})
        Me.cmbStatus.Location = New System.Drawing.Point(185, 504)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(174, 25)
        Me.cmbStatus.Sorted = True
        Me.cmbStatus.TabIndex = 6
        '
        'cmbGender
        '
        Me.cmbGender.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.Enabled = False
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Female", "Male"})
        Me.cmbGender.Location = New System.Drawing.Point(185, 465)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(123, 25)
        Me.cmbGender.Sorted = True
        Me.cmbGender.TabIndex = 5
        '
        'dateBirthday
        '
        Me.dateBirthday.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dateBirthday.CustomFormat = ""
        Me.dateBirthday.Enabled = False
        Me.dateBirthday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateBirthday.Location = New System.Drawing.Point(185, 425)
        Me.dateBirthday.Name = "dateBirthday"
        Me.dateBirthday.Size = New System.Drawing.Size(123, 25)
        Me.dateBirthday.TabIndex = 4
        '
        'txtHometown
        '
        Me.txtHometown.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtHometown.Location = New System.Drawing.Point(635, 228)
        Me.txtHometown.Name = "txtHometown"
        Me.txtHometown.Size = New System.Drawing.Size(201, 25)
        Me.txtHometown.TabIndex = 8
        '
        'txtPostalAddress
        '
        Me.txtPostalAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPostalAddress.Location = New System.Drawing.Point(635, 306)
        Me.txtPostalAddress.Multiline = True
        Me.txtPostalAddress.Name = "txtPostalAddress"
        Me.txtPostalAddress.Size = New System.Drawing.Size(201, 79)
        Me.txtPostalAddress.TabIndex = 10
        '
        'txtLastName
        '
        Me.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtLastName.Enabled = False
        Me.txtLastName.Location = New System.Drawing.Point(185, 387)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(202, 25)
        Me.txtLastName.TabIndex = 3
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMiddleName.Enabled = False
        Me.txtMiddleName.Location = New System.Drawing.Point(186, 348)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(201, 25)
        Me.txtMiddleName.TabIndex = 2
        '
        'txtFirstName
        '
        Me.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFirstName.Enabled = False
        Me.txtFirstName.Location = New System.Drawing.Point(185, 309)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(201, 25)
        Me.txtFirstName.TabIndex = 1
        '
        'cbTitle
        '
        Me.cbTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTitle.Enabled = False
        Me.cbTitle.FormattingEnabled = True
        Me.cbTitle.Items.AddRange(New Object() {"Dr", "Ing", "Miss", "Mr", "Mrs", "Prof"})
        Me.cbTitle.Location = New System.Drawing.Point(185, 270)
        Me.cbTitle.Name = "cbTitle"
        Me.cbTitle.Size = New System.Drawing.Size(80, 25)
        Me.cbTitle.Sorted = True
        Me.cbTitle.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(64, 545)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(106, 17)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Residence Status"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(511, 407)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(106, 17)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "Mobile Number*"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(122, 507)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(43, 17)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Status"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(95, 390)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(70, 17)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Last Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(481, 309)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(136, 17)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Postal / GPS Address*"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(114, 468)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(51, 17)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Gender"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(535, 450)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(77, 17)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "Programme"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 351)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 17)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Middle Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(563, 270)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(49, 17)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "Region"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(84, 428)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(81, 17)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Date of Birth"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(539, 231)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(78, 17)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "HomeTown*"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(94, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "First Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(133, 273)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(32, 17)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Title"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmStudent_PersonalRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 715)
        Me.Controls.Add(Me.tabStudentPersonal)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmStudent_PersonalRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Newman College - Student (Personal Record Page)"
        Me.tabStudentPersonal.ResumeLayout(False)
        Me.tabViewEditRecord.ResumeLayout(False)
        Me.tabViewEditRecord.PerformLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabStudentPersonal As TabControl
    Friend WithEvents tabViewEditRecord As TabPage
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnStudentPersonalUpdate As Button
    Friend WithEvents pbImage As PictureBox
    Friend WithEvents cmbDepartment As ComboBox
    Friend WithEvents mtxtMobile As MaskedTextBox
    Friend WithEvents cmbRegion As ComboBox
    Friend WithEvents cmbResidence As ComboBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents dateBirthday As DateTimePicker
    Friend WithEvents txtHometown As TextBox
    Friend WithEvents txtPostalAddress As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents cbTitle As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbSchool As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtPin As TextBox
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label22 As Label
End Class
