<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdmin_Student
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
        Me.tabAdminStudent = New System.Windows.Forms.TabControl()
        Me.tabNewStudent = New System.Windows.Forms.TabPage()
        Me.cmbSchool = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnAdminSave = New System.Windows.Forms.Button()
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.cmbProgram = New System.Windows.Forms.ComboBox()
        Me.mtxtMobile = New System.Windows.Forms.MaskedTextBox()
        Me.cmbRegion = New System.Windows.Forms.ComboBox()
        Me.cmbResidence = New System.Windows.Forms.ComboBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.dateBirthday = New System.Windows.Forms.DateTimePicker()
        Me.txtPin = New System.Windows.Forms.TextBox()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabEditStudent = New System.Windows.Forms.TabPage()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.mtxtStudentID = New System.Windows.Forms.MaskedTextBox()
        Me.radDelete = New System.Windows.Forms.RadioButton()
        Me.radUpdate = New System.Windows.Forms.RadioButton()
        Me.txtStudentPin = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.pbEditImage = New System.Windows.Forms.PictureBox()
        Me.cbSchool = New System.Windows.Forms.ComboBox()
        Me.cbProgramme = New System.Windows.Forms.ComboBox()
        Me.mtxtNumber = New System.Windows.Forms.MaskedTextBox()
        Me.cbRegion = New System.Windows.Forms.ComboBox()
        Me.cbResidence = New System.Windows.Forms.ComboBox()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.dtpBirthday = New System.Windows.Forms.DateTimePicker()
        Me.txtHome = New System.Windows.Forms.TextBox()
        Me.txtPostal_Address = New System.Windows.Forms.TextBox()
        Me.txtLast_Name = New System.Windows.Forms.TextBox()
        Me.txtMiddle_Name = New System.Windows.Forms.TextBox()
        Me.txtFirst_Name = New System.Windows.Forms.TextBox()
        Me.CmbDeed = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnUpdateRecord = New System.Windows.Forms.Button()
        Me.btnDeleteRecord = New System.Windows.Forms.Button()
        Me.tabAdminStudent.SuspendLayout()
        Me.tabNewStudent.SuspendLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEditStudent.SuspendLayout()
        CType(Me.pbEditImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabAdminStudent
        '
        Me.tabAdminStudent.Controls.Add(Me.tabNewStudent)
        Me.tabAdminStudent.Controls.Add(Me.tabEditStudent)
        Me.tabAdminStudent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabAdminStudent.Location = New System.Drawing.Point(0, 0)
        Me.tabAdminStudent.Name = "tabAdminStudent"
        Me.tabAdminStudent.SelectedIndex = 0
        Me.tabAdminStudent.Size = New System.Drawing.Size(933, 715)
        Me.tabAdminStudent.TabIndex = 0
        '
        'tabNewStudent
        '
        Me.tabNewStudent.Controls.Add(Me.cmbSchool)
        Me.tabNewStudent.Controls.Add(Me.Label21)
        Me.tabNewStudent.Controls.Add(Me.Label17)
        Me.tabNewStudent.Controls.Add(Me.Label16)
        Me.tabNewStudent.Controls.Add(Me.btnAdminSave)
        Me.tabNewStudent.Controls.Add(Me.pbImage)
        Me.tabNewStudent.Controls.Add(Me.cmbProgram)
        Me.tabNewStudent.Controls.Add(Me.mtxtMobile)
        Me.tabNewStudent.Controls.Add(Me.cmbRegion)
        Me.tabNewStudent.Controls.Add(Me.cmbResidence)
        Me.tabNewStudent.Controls.Add(Me.cmbStatus)
        Me.tabNewStudent.Controls.Add(Me.cmbGender)
        Me.tabNewStudent.Controls.Add(Me.dateBirthday)
        Me.tabNewStudent.Controls.Add(Me.txtPin)
        Me.tabNewStudent.Controls.Add(Me.txtStudentID)
        Me.tabNewStudent.Controls.Add(Me.txtHometown)
        Me.tabNewStudent.Controls.Add(Me.txtPostalAddress)
        Me.tabNewStudent.Controls.Add(Me.txtLastName)
        Me.tabNewStudent.Controls.Add(Me.txtMiddleName)
        Me.tabNewStudent.Controls.Add(Me.txtFirstName)
        Me.tabNewStudent.Controls.Add(Me.cbTitle)
        Me.tabNewStudent.Controls.Add(Me.Label8)
        Me.tabNewStudent.Controls.Add(Me.Label14)
        Me.tabNewStudent.Controls.Add(Me.Label7)
        Me.tabNewStudent.Controls.Add(Me.Label4)
        Me.tabNewStudent.Controls.Add(Me.Label12)
        Me.tabNewStudent.Controls.Add(Me.Label6)
        Me.tabNewStudent.Controls.Add(Me.Label11)
        Me.tabNewStudent.Controls.Add(Me.Label3)
        Me.tabNewStudent.Controls.Add(Me.Label10)
        Me.tabNewStudent.Controls.Add(Me.Label13)
        Me.tabNewStudent.Controls.Add(Me.Label5)
        Me.tabNewStudent.Controls.Add(Me.Label22)
        Me.tabNewStudent.Controls.Add(Me.Label9)
        Me.tabNewStudent.Controls.Add(Me.Label2)
        Me.tabNewStudent.Controls.Add(Me.Label1)
        Me.tabNewStudent.Location = New System.Drawing.Point(4, 26)
        Me.tabNewStudent.Name = "tabNewStudent"
        Me.tabNewStudent.Padding = New System.Windows.Forms.Padding(3)
        Me.tabNewStudent.Size = New System.Drawing.Size(925, 685)
        Me.tabNewStudent.TabIndex = 0
        Me.tabNewStudent.Text = "New Student Record"
        Me.tabNewStudent.UseVisualStyleBackColor = True
        '
        'cmbSchool
        '
        Me.cmbSchool.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbSchool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSchool.FormattingEnabled = True
        Me.cmbSchool.Items.AddRange(New Object() {"School of Engineering", "School of Physical and Mathematical Sciences"})
        Me.cmbSchool.Location = New System.Drawing.Point(636, 476)
        Me.cmbSchool.Name = "cmbSchool"
        Me.cmbSchool.Size = New System.Drawing.Size(201, 25)
        Me.cmbSchool.Sorted = True
        Me.cmbSchool.TabIndex = 13
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(566, 479)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(52, 17)
        Me.Label21.TabIndex = 45
        Me.Label21.Text = "School*"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label17.Location = New System.Drawing.Point(355, 39)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(257, 21)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "Application Form (*required field)"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label16.Location = New System.Drawing.Point(311, 7)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(338, 32)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "Registration of New Student"
        '
        'btnAdminSave
        '
        Me.btnAdminSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdminSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnAdminSave.Location = New System.Drawing.Point(721, 610)
        Me.btnAdminSave.Name = "btnAdminSave"
        Me.btnAdminSave.Size = New System.Drawing.Size(116, 36)
        Me.btnAdminSave.TabIndex = 15
        Me.btnAdminSave.Text = "Save"
        Me.btnAdminSave.UseVisualStyleBackColor = True
        '
        'pbImage
        '
        Me.pbImage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbImage.Location = New System.Drawing.Point(429, 86)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(100, 100)
        Me.pbImage.TabIndex = 39
        Me.pbImage.TabStop = False
        '
        'cmbProgram
        '
        Me.cmbProgram.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProgram.FormattingEnabled = True
        Me.cmbProgram.Items.AddRange(New Object() {"BSc. Agricultural Engineering", "BSc. Computer Engineering", "BSc. Computer Science", "BSc. Information Technology"})
        Me.cmbProgram.Location = New System.Drawing.Point(636, 435)
        Me.cmbProgram.Name = "cmbProgram"
        Me.cmbProgram.Size = New System.Drawing.Size(201, 25)
        Me.cmbProgram.Sorted = True
        Me.cmbProgram.TabIndex = 12
        '
        'mtxtMobile
        '
        Me.mtxtMobile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mtxtMobile.Location = New System.Drawing.Point(636, 392)
        Me.mtxtMobile.Mask = "000 000 0000"
        Me.mtxtMobile.Name = "mtxtMobile"
        Me.mtxtMobile.Size = New System.Drawing.Size(201, 25)
        Me.mtxtMobile.TabIndex = 11
        '
        'cmbRegion
        '
        Me.cmbRegion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRegion.FormattingEnabled = True
        Me.cmbRegion.Items.AddRange(New Object() {"Ahafo", "Ashanti", "Bono", "Bono-East", "Central", "Eastern", "North East", "Northern", "Oti", "Savannah", "Upper East", "Upper West", "Volta", "Western", "Western-North"})
        Me.cmbRegion.Location = New System.Drawing.Point(636, 255)
        Me.cmbRegion.Name = "cmbRegion"
        Me.cmbRegion.Size = New System.Drawing.Size(201, 25)
        Me.cmbRegion.Sorted = True
        Me.cmbRegion.TabIndex = 9
        '
        'cmbResidence
        '
        Me.cmbResidence.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbResidence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbResidence.FormattingEnabled = True
        Me.cmbResidence.Items.AddRange(New Object() {"Non-Residence", "Residence"})
        Me.cmbResidence.Location = New System.Drawing.Point(188, 528)
        Me.cmbResidence.Name = "cmbResidence"
        Me.cmbResidence.Size = New System.Drawing.Size(174, 25)
        Me.cmbResidence.Sorted = True
        Me.cmbResidence.TabIndex = 7
        '
        'cmbStatus
        '
        Me.cmbStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Full-Time Student", "Part-Time Student"})
        Me.cmbStatus.Location = New System.Drawing.Point(188, 490)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(174, 25)
        Me.cmbStatus.Sorted = True
        Me.cmbStatus.TabIndex = 6
        '
        'cmbGender
        '
        Me.cmbGender.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Female", "Male"})
        Me.cmbGender.Location = New System.Drawing.Point(188, 451)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(123, 25)
        Me.cmbGender.Sorted = True
        Me.cmbGender.TabIndex = 5
        '
        'dateBirthday
        '
        Me.dateBirthday.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dateBirthday.CustomFormat = ""
        Me.dateBirthday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateBirthday.Location = New System.Drawing.Point(188, 411)
        Me.dateBirthday.Name = "dateBirthday"
        Me.dateBirthday.Size = New System.Drawing.Size(123, 25)
        Me.dateBirthday.TabIndex = 4
        '
        'txtPin
        '
        Me.txtPin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPin.Enabled = False
        Me.txtPin.Location = New System.Drawing.Point(636, 518)
        Me.txtPin.Name = "txtPin"
        Me.txtPin.Size = New System.Drawing.Size(201, 25)
        Me.txtPin.TabIndex = 14
        Me.txtPin.UseSystemPasswordChar = True
        '
        'txtStudentID
        '
        Me.txtStudentID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtStudentID.Enabled = False
        Me.txtStudentID.Location = New System.Drawing.Point(188, 216)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(201, 25)
        Me.txtStudentID.TabIndex = 0
        '
        'txtHometown
        '
        Me.txtHometown.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtHometown.Location = New System.Drawing.Point(636, 216)
        Me.txtHometown.Name = "txtHometown"
        Me.txtHometown.Size = New System.Drawing.Size(201, 25)
        Me.txtHometown.TabIndex = 8
        '
        'txtPostalAddress
        '
        Me.txtPostalAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPostalAddress.Location = New System.Drawing.Point(636, 294)
        Me.txtPostalAddress.Multiline = True
        Me.txtPostalAddress.Name = "txtPostalAddress"
        Me.txtPostalAddress.Size = New System.Drawing.Size(201, 79)
        Me.txtPostalAddress.TabIndex = 10
        '
        'txtLastName
        '
        Me.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtLastName.Location = New System.Drawing.Point(188, 373)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(202, 25)
        Me.txtLastName.TabIndex = 3
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMiddleName.Location = New System.Drawing.Point(189, 334)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(201, 25)
        Me.txtMiddleName.TabIndex = 2
        '
        'txtFirstName
        '
        Me.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFirstName.Location = New System.Drawing.Point(188, 295)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(201, 25)
        Me.txtFirstName.TabIndex = 1
        '
        'cbTitle
        '
        Me.cbTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTitle.FormattingEnabled = True
        Me.cbTitle.Items.AddRange(New Object() {"Miss", "Mr", "Mrs"})
        Me.cbTitle.Location = New System.Drawing.Point(188, 256)
        Me.cbTitle.Name = "cbTitle"
        Me.cbTitle.Size = New System.Drawing.Size(80, 25)
        Me.cbTitle.Sorted = True
        Me.cbTitle.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(62, 531)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(111, 17)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Residence Status*"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(512, 395)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(106, 17)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Mobile Number*"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(125, 493)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(48, 17)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Status*"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(98, 376)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(75, 17)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Last Name*"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(482, 297)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(136, 17)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Postal / GPS Address*"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(117, 454)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(56, 17)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Gender*"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(536, 438)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(82, 17)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Programme*"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 337)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Middle Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(564, 258)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(54, 17)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Region*"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(588, 521)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(30, 17)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Pin*"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(87, 414)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(86, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Date of Birth*"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(95, 219)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(73, 17)
        Me.Label22.TabIndex = 16
        Me.Label22.Text = "Student ID*"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(540, 219)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(78, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "HomeTown*"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 298)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "First Name*"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(136, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(37, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Title*"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tabEditStudent
        '
        Me.tabEditStudent.Controls.Add(Me.btnSearch)
        Me.tabEditStudent.Controls.Add(Me.mtxtStudentID)
        Me.tabEditStudent.Controls.Add(Me.radDelete)
        Me.tabEditStudent.Controls.Add(Me.radUpdate)
        Me.tabEditStudent.Controls.Add(Me.txtStudentPin)
        Me.tabEditStudent.Controls.Add(Me.txtEmail)
        Me.tabEditStudent.Controls.Add(Me.Label15)
        Me.tabEditStudent.Controls.Add(Me.Label38)
        Me.tabEditStudent.Controls.Add(Me.Label18)
        Me.tabEditStudent.Controls.Add(Me.pbEditImage)
        Me.tabEditStudent.Controls.Add(Me.cbSchool)
        Me.tabEditStudent.Controls.Add(Me.cbProgramme)
        Me.tabEditStudent.Controls.Add(Me.mtxtNumber)
        Me.tabEditStudent.Controls.Add(Me.cbRegion)
        Me.tabEditStudent.Controls.Add(Me.cbResidence)
        Me.tabEditStudent.Controls.Add(Me.cbStatus)
        Me.tabEditStudent.Controls.Add(Me.cbGender)
        Me.tabEditStudent.Controls.Add(Me.dtpBirthday)
        Me.tabEditStudent.Controls.Add(Me.txtHome)
        Me.tabEditStudent.Controls.Add(Me.txtPostal_Address)
        Me.tabEditStudent.Controls.Add(Me.txtLast_Name)
        Me.tabEditStudent.Controls.Add(Me.txtMiddle_Name)
        Me.tabEditStudent.Controls.Add(Me.txtFirst_Name)
        Me.tabEditStudent.Controls.Add(Me.CmbDeed)
        Me.tabEditStudent.Controls.Add(Me.Label24)
        Me.tabEditStudent.Controls.Add(Me.Label25)
        Me.tabEditStudent.Controls.Add(Me.Label26)
        Me.tabEditStudent.Controls.Add(Me.Label27)
        Me.tabEditStudent.Controls.Add(Me.Label28)
        Me.tabEditStudent.Controls.Add(Me.Label29)
        Me.tabEditStudent.Controls.Add(Me.Label30)
        Me.tabEditStudent.Controls.Add(Me.Label31)
        Me.tabEditStudent.Controls.Add(Me.Label32)
        Me.tabEditStudent.Controls.Add(Me.Label33)
        Me.tabEditStudent.Controls.Add(Me.Label34)
        Me.tabEditStudent.Controls.Add(Me.Label35)
        Me.tabEditStudent.Controls.Add(Me.Label36)
        Me.tabEditStudent.Controls.Add(Me.Label37)
        Me.tabEditStudent.Controls.Add(Me.Label19)
        Me.tabEditStudent.Controls.Add(Me.btnUpdateRecord)
        Me.tabEditStudent.Controls.Add(Me.btnDeleteRecord)
        Me.tabEditStudent.Location = New System.Drawing.Point(4, 26)
        Me.tabEditStudent.Name = "tabEditStudent"
        Me.tabEditStudent.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEditStudent.Size = New System.Drawing.Size(925, 685)
        Me.tabEditStudent.TabIndex = 1
        Me.tabEditStudent.Text = "Modify Student Record"
        Me.tabEditStudent.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearch.Location = New System.Drawing.Point(770, 103)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(72, 34)
        Me.btnSearch.TabIndex = 97
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'mtxtStudentID
        '
        Me.mtxtStudentID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mtxtStudentID.HidePromptOnLeave = True
        Me.mtxtStudentID.Location = New System.Drawing.Point(607, 109)
        Me.mtxtStudentID.Mask = "00000000"
        Me.mtxtStudentID.Name = "mtxtStudentID"
        Me.mtxtStudentID.Size = New System.Drawing.Size(157, 25)
        Me.mtxtStudentID.TabIndex = 1
        Me.mtxtStudentID.ValidatingType = GetType(Integer)
        '
        'radDelete
        '
        Me.radDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radDelete.AutoSize = True
        Me.radDelete.Location = New System.Drawing.Point(596, 43)
        Me.radDelete.Name = "radDelete"
        Me.radDelete.Size = New System.Drawing.Size(157, 21)
        Me.radDelete.TabIndex = 0
        Me.radDelete.Text = "Delete Student Record"
        Me.radDelete.UseVisualStyleBackColor = True
        '
        'radUpdate
        '
        Me.radUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radUpdate.AutoSize = True
        Me.radUpdate.Location = New System.Drawing.Point(427, 43)
        Me.radUpdate.Name = "radUpdate"
        Me.radUpdate.Size = New System.Drawing.Size(163, 21)
        Me.radUpdate.TabIndex = 0
        Me.radUpdate.Text = "Update Student Record"
        Me.radUpdate.UseVisualStyleBackColor = True
        '
        'txtStudentPin
        '
        Me.txtStudentPin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtStudentPin.Enabled = False
        Me.txtStudentPin.Location = New System.Drawing.Point(641, 507)
        Me.txtStudentPin.Name = "txtStudentPin"
        Me.txtStudentPin.Size = New System.Drawing.Size(201, 25)
        Me.txtStudentPin.TabIndex = 16
        Me.txtStudentPin.UseSystemPasswordChar = True
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(185, 559)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(201, 25)
        Me.txtEmail.TabIndex = 9
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(593, 510)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(30, 17)
        Me.Label15.TabIndex = 94
        Me.Label15.Text = "Pin*"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label38
        '
        Me.Label38.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label38.Location = New System.Drawing.Point(205, 42)
        Me.Label38.Name = "Label38"
        Me.Label38.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label38.Size = New System.Drawing.Size(216, 21)
        Me.Label38.TabIndex = 95
        Me.Label38.Text = "Select modification option:*"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(494, 112)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(107, 17)
        Me.Label18.TabIndex = 96
        Me.Label18.Text = "Enter Student ID*"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pbEditImage
        '
        Me.pbEditImage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbEditImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbEditImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbEditImage.ErrorImage = Nothing
        Me.pbEditImage.InitialImage = Nothing
        Me.pbEditImage.Location = New System.Drawing.Point(185, 130)
        Me.pbEditImage.Name = "pbEditImage"
        Me.pbEditImage.Size = New System.Drawing.Size(100, 100)
        Me.pbEditImage.TabIndex = 93
        Me.pbEditImage.TabStop = False
        '
        'cbSchool
        '
        Me.cbSchool.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbSchool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSchool.FormattingEnabled = True
        Me.cbSchool.Items.AddRange(New Object() {"School of Engineering", "School of Physical and Mathematical Sciences"})
        Me.cbSchool.Location = New System.Drawing.Point(641, 466)
        Me.cbSchool.Name = "cbSchool"
        Me.cbSchool.Size = New System.Drawing.Size(201, 25)
        Me.cbSchool.Sorted = True
        Me.cbSchool.TabIndex = 15
        '
        'cbProgramme
        '
        Me.cbProgramme.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbProgramme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProgramme.FormattingEnabled = True
        Me.cbProgramme.Items.AddRange(New Object() {"BSc. Agricultural Engineering", "BSc. Computer Engineering", "BSc. Computer Science", "BSc. Information Technology "})
        Me.cbProgramme.Location = New System.Drawing.Point(641, 425)
        Me.cbProgramme.Name = "cbProgramme"
        Me.cbProgramme.Size = New System.Drawing.Size(201, 25)
        Me.cbProgramme.Sorted = True
        Me.cbProgramme.TabIndex = 14
        '
        'mtxtNumber
        '
        Me.mtxtNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mtxtNumber.Enabled = False
        Me.mtxtNumber.HidePromptOnLeave = True
        Me.mtxtNumber.Location = New System.Drawing.Point(641, 381)
        Me.mtxtNumber.Mask = "000 000 0000"
        Me.mtxtNumber.Name = "mtxtNumber"
        Me.mtxtNumber.Size = New System.Drawing.Size(201, 25)
        Me.mtxtNumber.TabIndex = 13
        '
        'cbRegion
        '
        Me.cbRegion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRegion.Enabled = False
        Me.cbRegion.FormattingEnabled = True
        Me.cbRegion.Items.AddRange(New Object() {"Ahafo", "Ashanti", "Bono", "Bono-East", "Central", "Eastern", "Greater Accra", "North East", "Northern", "Oti", "Savannah", "Upper East", "Upper West", "Volta", "Western", "Western-North"})
        Me.cbRegion.Location = New System.Drawing.Point(641, 244)
        Me.cbRegion.Name = "cbRegion"
        Me.cbRegion.Size = New System.Drawing.Size(201, 25)
        Me.cbRegion.Sorted = True
        Me.cbRegion.TabIndex = 11
        '
        'cbResidence
        '
        Me.cbResidence.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbResidence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbResidence.Enabled = False
        Me.cbResidence.FormattingEnabled = True
        Me.cbResidence.Items.AddRange(New Object() {"Non-Residence", "Residence"})
        Me.cbResidence.Location = New System.Drawing.Point(185, 518)
        Me.cbResidence.Name = "cbResidence"
        Me.cbResidence.Size = New System.Drawing.Size(202, 25)
        Me.cbResidence.Sorted = True
        Me.cbResidence.TabIndex = 8
        '
        'cbStatus
        '
        Me.cbStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Full-Time Student", "Part-Time Student"})
        Me.cbStatus.Location = New System.Drawing.Point(185, 480)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(202, 25)
        Me.cbStatus.Sorted = True
        Me.cbStatus.TabIndex = 7
        '
        'cbGender
        '
        Me.cbGender.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGender.Enabled = False
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"Female", "Male"})
        Me.cbGender.Location = New System.Drawing.Point(185, 441)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(123, 25)
        Me.cbGender.Sorted = True
        Me.cbGender.TabIndex = 6
        '
        'dtpBirthday
        '
        Me.dtpBirthday.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpBirthday.CustomFormat = ""
        Me.dtpBirthday.Enabled = False
        Me.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBirthday.Location = New System.Drawing.Point(185, 401)
        Me.dtpBirthday.Name = "dtpBirthday"
        Me.dtpBirthday.Size = New System.Drawing.Size(123, 25)
        Me.dtpBirthday.TabIndex = 5
        '
        'txtHome
        '
        Me.txtHome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtHome.Enabled = False
        Me.txtHome.Location = New System.Drawing.Point(641, 205)
        Me.txtHome.Name = "txtHome"
        Me.txtHome.Size = New System.Drawing.Size(201, 25)
        Me.txtHome.TabIndex = 10
        '
        'txtPostal_Address
        '
        Me.txtPostal_Address.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPostal_Address.Enabled = False
        Me.txtPostal_Address.Location = New System.Drawing.Point(641, 283)
        Me.txtPostal_Address.Multiline = True
        Me.txtPostal_Address.Name = "txtPostal_Address"
        Me.txtPostal_Address.Size = New System.Drawing.Size(201, 79)
        Me.txtPostal_Address.TabIndex = 12
        '
        'txtLast_Name
        '
        Me.txtLast_Name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtLast_Name.Enabled = False
        Me.txtLast_Name.Location = New System.Drawing.Point(185, 363)
        Me.txtLast_Name.Name = "txtLast_Name"
        Me.txtLast_Name.Size = New System.Drawing.Size(202, 25)
        Me.txtLast_Name.TabIndex = 4
        '
        'txtMiddle_Name
        '
        Me.txtMiddle_Name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMiddle_Name.Enabled = False
        Me.txtMiddle_Name.Location = New System.Drawing.Point(186, 324)
        Me.txtMiddle_Name.Name = "txtMiddle_Name"
        Me.txtMiddle_Name.Size = New System.Drawing.Size(201, 25)
        Me.txtMiddle_Name.TabIndex = 3
        '
        'txtFirst_Name
        '
        Me.txtFirst_Name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFirst_Name.Enabled = False
        Me.txtFirst_Name.Location = New System.Drawing.Point(185, 285)
        Me.txtFirst_Name.Name = "txtFirst_Name"
        Me.txtFirst_Name.Size = New System.Drawing.Size(201, 25)
        Me.txtFirst_Name.TabIndex = 2
        '
        'CmbDeed
        '
        Me.CmbDeed.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbDeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDeed.Enabled = False
        Me.CmbDeed.FormattingEnabled = True
        Me.CmbDeed.Items.AddRange(New Object() {"Miss  ", "Mr  ", "Mrs  "})
        Me.CmbDeed.Location = New System.Drawing.Point(185, 246)
        Me.CmbDeed.Name = "CmbDeed"
        Me.CmbDeed.Size = New System.Drawing.Size(80, 25)
        Me.CmbDeed.TabIndex = 1
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(59, 521)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(111, 17)
        Me.Label24.TabIndex = 80
        Me.Label24.Text = "Residence Status*"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label25
        '
        Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(517, 384)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(106, 17)
        Me.Label25.TabIndex = 81
        Me.Label25.Text = "Mobile Number*"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(122, 483)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(48, 17)
        Me.Label26.TabIndex = 82
        Me.Label26.Text = "Status*"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(95, 366)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label27.Size = New System.Drawing.Size(75, 17)
        Me.Label27.TabIndex = 83
        Me.Label27.Text = "Last Name*"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(487, 286)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label28.Size = New System.Drawing.Size(136, 17)
        Me.Label28.TabIndex = 84
        Me.Label28.Text = "Postal / GPS Address*"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label29
        '
        Me.Label29.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(571, 469)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label29.Size = New System.Drawing.Size(52, 17)
        Me.Label29.TabIndex = 85
        Me.Label29.Text = "School*"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label30
        '
        Me.Label30.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(114, 444)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(56, 17)
        Me.Label30.TabIndex = 91
        Me.Label30.Text = "Gender*"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label31
        '
        Me.Label31.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(541, 428)
        Me.Label31.Name = "Label31"
        Me.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label31.Size = New System.Drawing.Size(82, 17)
        Me.Label31.TabIndex = 86
        Me.Label31.Text = "Programme*"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label32
        '
        Me.Label32.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(82, 327)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(88, 17)
        Me.Label32.TabIndex = 87
        Me.Label32.Text = "Middle Name"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label33
        '
        Me.Label33.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(569, 247)
        Me.Label33.Name = "Label33"
        Me.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label33.Size = New System.Drawing.Size(54, 17)
        Me.Label33.TabIndex = 88
        Me.Label33.Text = "Region*"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label34
        '
        Me.Label34.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(84, 404)
        Me.Label34.Name = "Label34"
        Me.Label34.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label34.Size = New System.Drawing.Size(86, 17)
        Me.Label34.TabIndex = 89
        Me.Label34.Text = "Date of Birth*"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label35
        '
        Me.Label35.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(545, 208)
        Me.Label35.Name = "Label35"
        Me.Label35.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label35.Size = New System.Drawing.Size(78, 17)
        Me.Label35.TabIndex = 90
        Me.Label35.Text = "HomeTown*"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label36
        '
        Me.Label36.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(94, 288)
        Me.Label36.Name = "Label36"
        Me.Label36.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label36.Size = New System.Drawing.Size(76, 17)
        Me.Label36.TabIndex = 92
        Me.Label36.Text = "First Name*"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label37
        '
        Me.Label37.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(133, 249)
        Me.Label37.Name = "Label37"
        Me.Label37.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label37.Size = New System.Drawing.Size(37, 17)
        Me.Label37.TabIndex = 79
        Me.Label37.Text = "Title*"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(128, 562)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 17)
        Me.Label19.TabIndex = 78
        Me.Label19.Text = "Email"
        '
        'btnUpdateRecord
        '
        Me.btnUpdateRecord.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdateRecord.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnUpdateRecord.Location = New System.Drawing.Point(585, 608)
        Me.btnUpdateRecord.Name = "btnUpdateRecord"
        Me.btnUpdateRecord.Size = New System.Drawing.Size(116, 34)
        Me.btnUpdateRecord.TabIndex = 17
        Me.btnUpdateRecord.Text = "Update Record"
        Me.btnUpdateRecord.UseVisualStyleBackColor = True
        '
        'btnDeleteRecord
        '
        Me.btnDeleteRecord.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDeleteRecord.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnDeleteRecord.Location = New System.Drawing.Point(726, 608)
        Me.btnDeleteRecord.Name = "btnDeleteRecord"
        Me.btnDeleteRecord.Size = New System.Drawing.Size(116, 34)
        Me.btnDeleteRecord.TabIndex = 18
        Me.btnDeleteRecord.Text = "Delete Record"
        Me.btnDeleteRecord.UseVisualStyleBackColor = True
        '
        'frmAdmin_Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(933, 715)
        Me.Controls.Add(Me.tabAdminStudent)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmAdmin_Student"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Newman College - Administrator (Student Page)"
        Me.tabAdminStudent.ResumeLayout(False)
        Me.tabNewStudent.ResumeLayout(False)
        Me.tabNewStudent.PerformLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEditStudent.ResumeLayout(False)
        Me.tabEditStudent.PerformLayout()
        CType(Me.pbEditImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabAdminStudent As TabControl
    Friend WithEvents tabNewStudent As TabPage
    Friend WithEvents tabEditStudent As TabPage
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnAdminSave As Button
    Friend WithEvents pbImage As PictureBox
    Friend WithEvents cmbProgram As ComboBox
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
    Friend WithEvents Label13 As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents mtxtStudentID As MaskedTextBox
    Friend WithEvents radDelete As RadioButton
    Friend WithEvents radUpdate As RadioButton
    Friend WithEvents txtStudentPin As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents pbEditImage As PictureBox
    Friend WithEvents cbSchool As ComboBox
    Friend WithEvents cbProgramme As ComboBox
    Friend WithEvents mtxtNumber As MaskedTextBox
    Friend WithEvents cbRegion As ComboBox
    Friend WithEvents cbResidence As ComboBox
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents txtHome As TextBox
    Friend WithEvents txtPostal_Address As TextBox
    Friend WithEvents txtLast_Name As TextBox
    Friend WithEvents txtMiddle_Name As TextBox
    Friend WithEvents txtFirst_Name As TextBox
    Friend WithEvents CmbDeed As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents btnUpdateRecord As Button
    Friend WithEvents btnDeleteRecord As Button
    Friend WithEvents btnSearch As Button
End Class
