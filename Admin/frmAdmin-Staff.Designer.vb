<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdmin_Staff
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
        Me.components = New System.ComponentModel.Container()
        Me.tabAdminStaff = New System.Windows.Forms.TabControl()
        Me.tabNewStaff = New System.Windows.Forms.TabPage()
        Me.txtPin = New System.Windows.Forms.TextBox()
        Me.txtStaffID = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnAdminSave = New System.Windows.Forms.Button()
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.cmbSchool = New System.Windows.Forms.ComboBox()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.mtxtMobile = New System.Windows.Forms.MaskedTextBox()
        Me.cmbRegion = New System.Windows.Forms.ComboBox()
        Me.cmbPosition = New System.Windows.Forms.ComboBox()
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabEditDeleteStaff = New System.Windows.Forms.TabPage()
        Me.mtxtStaffID = New System.Windows.Forms.MaskedTextBox()
        Me.radDelete = New System.Windows.Forms.RadioButton()
        Me.radUpdate = New System.Windows.Forms.RadioButton()
        Me.txtStaffPin = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.pbEditImage = New System.Windows.Forms.PictureBox()
        Me.cbSchool = New System.Windows.Forms.ComboBox()
        Me.cbDepartment = New System.Windows.Forms.ComboBox()
        Me.mtxtNumber = New System.Windows.Forms.MaskedTextBox()
        Me.cbRegion = New System.Windows.Forms.ComboBox()
        Me.cbPosition = New System.Windows.Forms.ComboBox()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.dtpBirthday = New System.Windows.Forms.DateTimePicker()
        Me.txtHome = New System.Windows.Forms.TextBox()
        Me.txtPostal_Address = New System.Windows.Forms.TextBox()
        Me.txtLast_Name = New System.Windows.Forms.TextBox()
        Me.txtMiddle_Name = New System.Windows.Forms.TextBox()
        Me.txtFirst_Name = New System.Windows.Forms.TextBox()
        Me.CmbTitle = New System.Windows.Forms.ComboBox()
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
        Me.btnUploadDialog = New System.Windows.Forms.OpenFileDialog()
        Me.PersonnelInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentManagementSystemDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_Management_SystemDataSet = New SMS_App_Project.Student_Management_SystemDataSet()
        Me.Personnel_InfoTableAdapter = New SMS_App_Project.Student_Management_SystemDataSetTableAdapters.Personnel_InfoTableAdapter()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.tabAdminStaff.SuspendLayout()
        Me.tabNewStaff.SuspendLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEditDeleteStaff.SuspendLayout()
        CType(Me.pbEditImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonnelInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentManagementSystemDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabAdminStaff
        '
        Me.tabAdminStaff.Controls.Add(Me.tabNewStaff)
        Me.tabAdminStaff.Controls.Add(Me.tabEditDeleteStaff)
        Me.tabAdminStaff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabAdminStaff.Location = New System.Drawing.Point(0, 0)
        Me.tabAdminStaff.Name = "tabAdminStaff"
        Me.tabAdminStaff.SelectedIndex = 0
        Me.tabAdminStaff.Size = New System.Drawing.Size(933, 687)
        Me.tabAdminStaff.TabIndex = 0
        '
        'tabNewStaff
        '
        Me.tabNewStaff.Controls.Add(Me.txtPin)
        Me.tabNewStaff.Controls.Add(Me.txtStaffID)
        Me.tabNewStaff.Controls.Add(Me.Label22)
        Me.tabNewStaff.Controls.Add(Me.Label23)
        Me.tabNewStaff.Controls.Add(Me.Label17)
        Me.tabNewStaff.Controls.Add(Me.Label16)
        Me.tabNewStaff.Controls.Add(Me.btnAdminSave)
        Me.tabNewStaff.Controls.Add(Me.pbImage)
        Me.tabNewStaff.Controls.Add(Me.cmbSchool)
        Me.tabNewStaff.Controls.Add(Me.cmbDepartment)
        Me.tabNewStaff.Controls.Add(Me.mtxtMobile)
        Me.tabNewStaff.Controls.Add(Me.cmbRegion)
        Me.tabNewStaff.Controls.Add(Me.cmbPosition)
        Me.tabNewStaff.Controls.Add(Me.cmbStatus)
        Me.tabNewStaff.Controls.Add(Me.cmbGender)
        Me.tabNewStaff.Controls.Add(Me.dateBirthday)
        Me.tabNewStaff.Controls.Add(Me.txtHometown)
        Me.tabNewStaff.Controls.Add(Me.txtPostalAddress)
        Me.tabNewStaff.Controls.Add(Me.txtLastName)
        Me.tabNewStaff.Controls.Add(Me.txtMiddleName)
        Me.tabNewStaff.Controls.Add(Me.txtFirstName)
        Me.tabNewStaff.Controls.Add(Me.cbTitle)
        Me.tabNewStaff.Controls.Add(Me.Label8)
        Me.tabNewStaff.Controls.Add(Me.Label14)
        Me.tabNewStaff.Controls.Add(Me.Label7)
        Me.tabNewStaff.Controls.Add(Me.Label13)
        Me.tabNewStaff.Controls.Add(Me.Label4)
        Me.tabNewStaff.Controls.Add(Me.Label12)
        Me.tabNewStaff.Controls.Add(Me.Label21)
        Me.tabNewStaff.Controls.Add(Me.Label6)
        Me.tabNewStaff.Controls.Add(Me.Label11)
        Me.tabNewStaff.Controls.Add(Me.Label3)
        Me.tabNewStaff.Controls.Add(Me.Label10)
        Me.tabNewStaff.Controls.Add(Me.Label5)
        Me.tabNewStaff.Controls.Add(Me.Label9)
        Me.tabNewStaff.Controls.Add(Me.Label2)
        Me.tabNewStaff.Controls.Add(Me.Label1)
        Me.tabNewStaff.Location = New System.Drawing.Point(4, 26)
        Me.tabNewStaff.Name = "tabNewStaff"
        Me.tabNewStaff.Padding = New System.Windows.Forms.Padding(3)
        Me.tabNewStaff.Size = New System.Drawing.Size(925, 657)
        Me.tabNewStaff.TabIndex = 0
        Me.tabNewStaff.Text = "New Staff Record"
        Me.tabNewStaff.UseVisualStyleBackColor = True
        '
        'txtPin
        '
        Me.txtPin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPin.Enabled = False
        Me.txtPin.Location = New System.Drawing.Point(631, 482)
        Me.txtPin.Name = "txtPin"
        Me.txtPin.Size = New System.Drawing.Size(201, 25)
        Me.txtPin.TabIndex = 14
        Me.txtPin.UseSystemPasswordChar = True
        '
        'txtStaffID
        '
        Me.txtStaffID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtStaffID.Enabled = False
        Me.txtStaffID.Location = New System.Drawing.Point(176, 180)
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.Size = New System.Drawing.Size(201, 25)
        Me.txtStaffID.TabIndex = 0
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(583, 485)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(30, 17)
        Me.Label22.TabIndex = 19
        Me.Label22.Text = "Pin*"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(105, 183)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(55, 17)
        Me.Label23.TabIndex = 20
        Me.Label23.Text = "Staff ID*"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label17.Location = New System.Drawing.Point(338, 29)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(257, 21)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Application Form (*required field)"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label16.Location = New System.Drawing.Point(311, -3)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(302, 32)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "Registration of New Staff"
        '
        'btnAdminSave
        '
        Me.btnAdminSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdminSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnAdminSave.Location = New System.Drawing.Point(716, 577)
        Me.btnAdminSave.Name = "btnAdminSave"
        Me.btnAdminSave.Size = New System.Drawing.Size(116, 36)
        Me.btnAdminSave.TabIndex = 15
        Me.btnAdminSave.Text = "Save"
        Me.btnAdminSave.UseVisualStyleBackColor = True
        '
        'pbImage
        '
        Me.pbImage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbImage.ErrorImage = Nothing
        Me.pbImage.InitialImage = Global.SMS_App_Project.My.Resources.Resources.profilePicture
        Me.pbImage.Location = New System.Drawing.Point(419, 62)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(100, 100)
        Me.pbImage.TabIndex = 10
        Me.pbImage.TabStop = False
        '
        'cmbSchool
        '
        Me.cmbSchool.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbSchool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSchool.FormattingEnabled = True
        Me.cmbSchool.Items.AddRange(New Object() {"School of Engineering", "School of Physical and Mathematical Sciences"})
        Me.cmbSchool.Location = New System.Drawing.Point(631, 441)
        Me.cmbSchool.Name = "cmbSchool"
        Me.cmbSchool.Size = New System.Drawing.Size(201, 25)
        Me.cmbSchool.Sorted = True
        Me.cmbSchool.TabIndex = 13
        '
        'cmbDepartment
        '
        Me.cmbDepartment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartment.FormattingEnabled = True
        Me.cmbDepartment.Items.AddRange(New Object() {"Agricultural Engineering", "Computer Engineering", "Computer Science", "Information Technology "})
        Me.cmbDepartment.Location = New System.Drawing.Point(631, 400)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(201, 25)
        Me.cmbDepartment.Sorted = True
        Me.cmbDepartment.TabIndex = 12
        '
        'mtxtMobile
        '
        Me.mtxtMobile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mtxtMobile.HidePromptOnLeave = True
        Me.mtxtMobile.Location = New System.Drawing.Point(631, 356)
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
        Me.cmbRegion.Items.AddRange(New Object() {"Ahafo", "Ashanti", "Bono", "Bono-East", "Central", "Eastern", "Greater Accra", "North East", "Northern", "Oti", "Savannah", "Upper East", "Upper West", "Volta", "Western", "Western-North"})
        Me.cmbRegion.Location = New System.Drawing.Point(631, 219)
        Me.cmbRegion.Name = "cmbRegion"
        Me.cmbRegion.Size = New System.Drawing.Size(201, 25)
        Me.cmbRegion.Sorted = True
        Me.cmbRegion.TabIndex = 9
        '
        'cmbPosition
        '
        Me.cmbPosition.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPosition.FormattingEnabled = True
        Me.cmbPosition.Items.AddRange(New Object() {"Administrative Officer", "Assistant Lecturer", "College Secretary ", "Department Secretary", "Lecturer", "Part-Time Lecturer", "Provost", "School Secretary ", "Senior Lecturer", "Vice Chancellor"})
        Me.cmbPosition.Location = New System.Drawing.Point(175, 493)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.Size = New System.Drawing.Size(174, 25)
        Me.cmbPosition.Sorted = True
        Me.cmbPosition.TabIndex = 7
        '
        'cmbStatus
        '
        Me.cmbStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Administrative Staff", "Teaching Staff"})
        Me.cmbStatus.Location = New System.Drawing.Point(175, 455)
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
        Me.cmbGender.Location = New System.Drawing.Point(175, 416)
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
        Me.dateBirthday.Location = New System.Drawing.Point(175, 376)
        Me.dateBirthday.Name = "dateBirthday"
        Me.dateBirthday.Size = New System.Drawing.Size(123, 25)
        Me.dateBirthday.TabIndex = 4
        '
        'txtHometown
        '
        Me.txtHometown.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtHometown.Location = New System.Drawing.Point(631, 180)
        Me.txtHometown.Name = "txtHometown"
        Me.txtHometown.Size = New System.Drawing.Size(201, 25)
        Me.txtHometown.TabIndex = 8
        '
        'txtPostalAddress
        '
        Me.txtPostalAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPostalAddress.Location = New System.Drawing.Point(631, 258)
        Me.txtPostalAddress.Multiline = True
        Me.txtPostalAddress.Name = "txtPostalAddress"
        Me.txtPostalAddress.Size = New System.Drawing.Size(201, 79)
        Me.txtPostalAddress.TabIndex = 10
        '
        'txtLastName
        '
        Me.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtLastName.Location = New System.Drawing.Point(175, 338)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(202, 25)
        Me.txtLastName.TabIndex = 3
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMiddleName.Location = New System.Drawing.Point(176, 299)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(201, 25)
        Me.txtMiddleName.TabIndex = 2
        '
        'txtFirstName
        '
        Me.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFirstName.Location = New System.Drawing.Point(175, 260)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(201, 25)
        Me.txtFirstName.TabIndex = 1
        '
        'cbTitle
        '
        Me.cbTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTitle.FormattingEnabled = True
        Me.cbTitle.Items.AddRange(New Object() {"Dr", "Ing", "Miss", "Mr", "Mrs", "Prof"})
        Me.cbTitle.Location = New System.Drawing.Point(175, 221)
        Me.cbTitle.Name = "cbTitle"
        Me.cbTitle.Size = New System.Drawing.Size(80, 25)
        Me.cbTitle.Sorted = True
        Me.cbTitle.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(101, 496)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(59, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Position*"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(507, 359)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(106, 17)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Mobile Number*"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(112, 458)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(48, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Status*"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(349, 299)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(0, 17)
        Me.Label13.TabIndex = 0
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(85, 341)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(75, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Last Name*"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(477, 261)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(136, 17)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Postal / GPS Address*"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(561, 444)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(52, 17)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "School*"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(104, 419)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(56, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Gender*"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(531, 403)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(82, 17)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Department*"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 302)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Middle Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(559, 222)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(54, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Region*"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(74, 379)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(86, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Date of Birth*"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(535, 183)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(78, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "HomeTown*"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 263)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "First Name*"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(123, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(37, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Title*"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tabEditDeleteStaff
        '
        Me.tabEditDeleteStaff.Controls.Add(Me.btnSearch)
        Me.tabEditDeleteStaff.Controls.Add(Me.mtxtStaffID)
        Me.tabEditDeleteStaff.Controls.Add(Me.radDelete)
        Me.tabEditDeleteStaff.Controls.Add(Me.radUpdate)
        Me.tabEditDeleteStaff.Controls.Add(Me.txtStaffPin)
        Me.tabEditDeleteStaff.Controls.Add(Me.txtEmail)
        Me.tabEditDeleteStaff.Controls.Add(Me.Label15)
        Me.tabEditDeleteStaff.Controls.Add(Me.Label38)
        Me.tabEditDeleteStaff.Controls.Add(Me.Label18)
        Me.tabEditDeleteStaff.Controls.Add(Me.pbEditImage)
        Me.tabEditDeleteStaff.Controls.Add(Me.cbSchool)
        Me.tabEditDeleteStaff.Controls.Add(Me.cbDepartment)
        Me.tabEditDeleteStaff.Controls.Add(Me.mtxtNumber)
        Me.tabEditDeleteStaff.Controls.Add(Me.cbRegion)
        Me.tabEditDeleteStaff.Controls.Add(Me.cbPosition)
        Me.tabEditDeleteStaff.Controls.Add(Me.cbStatus)
        Me.tabEditDeleteStaff.Controls.Add(Me.cbGender)
        Me.tabEditDeleteStaff.Controls.Add(Me.dtpBirthday)
        Me.tabEditDeleteStaff.Controls.Add(Me.txtHome)
        Me.tabEditDeleteStaff.Controls.Add(Me.txtPostal_Address)
        Me.tabEditDeleteStaff.Controls.Add(Me.txtLast_Name)
        Me.tabEditDeleteStaff.Controls.Add(Me.txtMiddle_Name)
        Me.tabEditDeleteStaff.Controls.Add(Me.txtFirst_Name)
        Me.tabEditDeleteStaff.Controls.Add(Me.CmbTitle)
        Me.tabEditDeleteStaff.Controls.Add(Me.Label24)
        Me.tabEditDeleteStaff.Controls.Add(Me.Label25)
        Me.tabEditDeleteStaff.Controls.Add(Me.Label26)
        Me.tabEditDeleteStaff.Controls.Add(Me.Label27)
        Me.tabEditDeleteStaff.Controls.Add(Me.Label28)
        Me.tabEditDeleteStaff.Controls.Add(Me.Label29)
        Me.tabEditDeleteStaff.Controls.Add(Me.Label30)
        Me.tabEditDeleteStaff.Controls.Add(Me.Label31)
        Me.tabEditDeleteStaff.Controls.Add(Me.Label32)
        Me.tabEditDeleteStaff.Controls.Add(Me.Label33)
        Me.tabEditDeleteStaff.Controls.Add(Me.Label34)
        Me.tabEditDeleteStaff.Controls.Add(Me.Label35)
        Me.tabEditDeleteStaff.Controls.Add(Me.Label36)
        Me.tabEditDeleteStaff.Controls.Add(Me.Label37)
        Me.tabEditDeleteStaff.Controls.Add(Me.Label19)
        Me.tabEditDeleteStaff.Controls.Add(Me.btnUpdateRecord)
        Me.tabEditDeleteStaff.Controls.Add(Me.btnDeleteRecord)
        Me.tabEditDeleteStaff.Location = New System.Drawing.Point(4, 26)
        Me.tabEditDeleteStaff.Name = "tabEditDeleteStaff"
        Me.tabEditDeleteStaff.Size = New System.Drawing.Size(925, 657)
        Me.tabEditDeleteStaff.TabIndex = 2
        Me.tabEditDeleteStaff.Text = "Modify Staff Record"
        Me.tabEditDeleteStaff.UseVisualStyleBackColor = True
        '
        'mtxtStaffID
        '
        Me.mtxtStaffID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mtxtStaffID.HidePromptOnLeave = True
        Me.mtxtStaffID.Location = New System.Drawing.Point(585, 102)
        Me.mtxtStaffID.Mask = "00000000"
        Me.mtxtStaffID.Name = "mtxtStaffID"
        Me.mtxtStaffID.Size = New System.Drawing.Size(174, 25)
        Me.mtxtStaffID.TabIndex = 2
        Me.mtxtStaffID.ValidatingType = GetType(Integer)
        '
        'radDelete
        '
        Me.radDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radDelete.AutoSize = True
        Me.radDelete.Location = New System.Drawing.Point(596, 36)
        Me.radDelete.Name = "radDelete"
        Me.radDelete.Size = New System.Drawing.Size(139, 21)
        Me.radDelete.TabIndex = 1
        Me.radDelete.Text = "Delete Staff Record"
        Me.radDelete.UseVisualStyleBackColor = True
        '
        'radUpdate
        '
        Me.radUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radUpdate.AutoSize = True
        Me.radUpdate.Location = New System.Drawing.Point(437, 36)
        Me.radUpdate.Name = "radUpdate"
        Me.radUpdate.Size = New System.Drawing.Size(145, 21)
        Me.radUpdate.TabIndex = 0
        Me.radUpdate.Text = "Update Staff Record"
        Me.radUpdate.UseVisualStyleBackColor = True
        '
        'txtStaffPin
        '
        Me.txtStaffPin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtStaffPin.Enabled = False
        Me.txtStaffPin.Location = New System.Drawing.Point(641, 501)
        Me.txtStaffPin.Name = "txtStaffPin"
        Me.txtStaffPin.Size = New System.Drawing.Size(201, 25)
        Me.txtStaffPin.TabIndex = 18
        Me.txtStaffPin.UseSystemPasswordChar = True
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(185, 553)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(201, 25)
        Me.txtEmail.TabIndex = 11
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(593, 504)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(30, 17)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "Pin*"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label38
        '
        Me.Label38.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label38.Location = New System.Drawing.Point(205, 36)
        Me.Label38.Name = "Label38"
        Me.Label38.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label38.Size = New System.Drawing.Size(216, 21)
        Me.Label38.TabIndex = 56
        Me.Label38.Text = "Select modification option:*"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(481, 105)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(89, 17)
        Me.Label18.TabIndex = 56
        Me.Label18.Text = "Enter Staff ID*"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pbEditImage
        '
        Me.pbEditImage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbEditImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbEditImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbEditImage.ErrorImage = Nothing
        Me.pbEditImage.InitialImage = Nothing
        Me.pbEditImage.Location = New System.Drawing.Point(185, 124)
        Me.pbEditImage.Name = "pbEditImage"
        Me.pbEditImage.Size = New System.Drawing.Size(100, 100)
        Me.pbEditImage.TabIndex = 50
        Me.pbEditImage.TabStop = False
        '
        'cbSchool
        '
        Me.cbSchool.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbSchool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSchool.FormattingEnabled = True
        Me.cbSchool.Items.AddRange(New Object() {"School of Engineering", "School of Physical and Mathematical Sciences"})
        Me.cbSchool.Location = New System.Drawing.Point(641, 460)
        Me.cbSchool.Name = "cbSchool"
        Me.cbSchool.Size = New System.Drawing.Size(201, 25)
        Me.cbSchool.Sorted = True
        Me.cbSchool.TabIndex = 17
        '
        'cbDepartment
        '
        Me.cbDepartment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDepartment.FormattingEnabled = True
        Me.cbDepartment.Items.AddRange(New Object() {"Agricultural Engineering", "Computer Engineering", "Computer Science", "Information Technology "})
        Me.cbDepartment.Location = New System.Drawing.Point(641, 419)
        Me.cbDepartment.Name = "cbDepartment"
        Me.cbDepartment.Size = New System.Drawing.Size(201, 25)
        Me.cbDepartment.Sorted = True
        Me.cbDepartment.TabIndex = 16
        '
        'mtxtNumber
        '
        Me.mtxtNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mtxtNumber.Enabled = False
        Me.mtxtNumber.HidePromptOnLeave = True
        Me.mtxtNumber.Location = New System.Drawing.Point(641, 375)
        Me.mtxtNumber.Mask = "000 000 0000"
        Me.mtxtNumber.Name = "mtxtNumber"
        Me.mtxtNumber.Size = New System.Drawing.Size(201, 25)
        Me.mtxtNumber.TabIndex = 15
        '
        'cbRegion
        '
        Me.cbRegion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRegion.Enabled = False
        Me.cbRegion.FormattingEnabled = True
        Me.cbRegion.Items.AddRange(New Object() {"Ahafo", "Ashanti", "Bono", "Bono-East", "Central", "Eastern", "Greater Accra", "North East", "Northern", "Oti", "Savannah", "Upper East", "Upper West", "Volta", "Western", "Western-North"})
        Me.cbRegion.Location = New System.Drawing.Point(641, 238)
        Me.cbRegion.Name = "cbRegion"
        Me.cbRegion.Size = New System.Drawing.Size(201, 25)
        Me.cbRegion.Sorted = True
        Me.cbRegion.TabIndex = 13
        '
        'cbPosition
        '
        Me.cbPosition.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPosition.FormattingEnabled = True
        Me.cbPosition.Items.AddRange(New Object() {"Administrative Officer", "Assistant Lecturer", "College Secretary", "Department Secretary", "Lecturer", "Part-Time Lecturer", "Provost", "School Secretary", "Senior Lecturer", "Vice Chancellor"})
        Me.cbPosition.Location = New System.Drawing.Point(185, 512)
        Me.cbPosition.Name = "cbPosition"
        Me.cbPosition.Size = New System.Drawing.Size(202, 25)
        Me.cbPosition.Sorted = True
        Me.cbPosition.TabIndex = 10
        '
        'cbStatus
        '
        Me.cbStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Administrative Staff", "Teaching Staff"})
        Me.cbStatus.Location = New System.Drawing.Point(185, 474)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(202, 25)
        Me.cbStatus.Sorted = True
        Me.cbStatus.TabIndex = 9
        '
        'cbGender
        '
        Me.cbGender.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGender.Enabled = False
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"Female", "Male"})
        Me.cbGender.Location = New System.Drawing.Point(185, 435)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(123, 25)
        Me.cbGender.Sorted = True
        Me.cbGender.TabIndex = 8
        '
        'dtpBirthday
        '
        Me.dtpBirthday.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpBirthday.CustomFormat = ""
        Me.dtpBirthday.Enabled = False
        Me.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBirthday.Location = New System.Drawing.Point(185, 395)
        Me.dtpBirthday.Name = "dtpBirthday"
        Me.dtpBirthday.Size = New System.Drawing.Size(123, 25)
        Me.dtpBirthday.TabIndex = 7
        '
        'txtHome
        '
        Me.txtHome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtHome.Enabled = False
        Me.txtHome.Location = New System.Drawing.Point(641, 199)
        Me.txtHome.Name = "txtHome"
        Me.txtHome.Size = New System.Drawing.Size(201, 25)
        Me.txtHome.TabIndex = 12
        '
        'txtPostal_Address
        '
        Me.txtPostal_Address.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPostal_Address.Enabled = False
        Me.txtPostal_Address.Location = New System.Drawing.Point(641, 277)
        Me.txtPostal_Address.Multiline = True
        Me.txtPostal_Address.Name = "txtPostal_Address"
        Me.txtPostal_Address.Size = New System.Drawing.Size(201, 79)
        Me.txtPostal_Address.TabIndex = 14
        '
        'txtLast_Name
        '
        Me.txtLast_Name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtLast_Name.Enabled = False
        Me.txtLast_Name.Location = New System.Drawing.Point(185, 357)
        Me.txtLast_Name.Name = "txtLast_Name"
        Me.txtLast_Name.Size = New System.Drawing.Size(202, 25)
        Me.txtLast_Name.TabIndex = 6
        '
        'txtMiddle_Name
        '
        Me.txtMiddle_Name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMiddle_Name.Enabled = False
        Me.txtMiddle_Name.Location = New System.Drawing.Point(186, 318)
        Me.txtMiddle_Name.Name = "txtMiddle_Name"
        Me.txtMiddle_Name.Size = New System.Drawing.Size(201, 25)
        Me.txtMiddle_Name.TabIndex = 5
        '
        'txtFirst_Name
        '
        Me.txtFirst_Name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFirst_Name.Enabled = False
        Me.txtFirst_Name.Location = New System.Drawing.Point(185, 279)
        Me.txtFirst_Name.Name = "txtFirst_Name"
        Me.txtFirst_Name.Size = New System.Drawing.Size(201, 25)
        Me.txtFirst_Name.TabIndex = 4
        '
        'CmbTitle
        '
        Me.CmbTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTitle.FormattingEnabled = True
        Me.CmbTitle.Items.AddRange(New Object() {"Dr", "Ing", "Miss", "Mr", "Mrs", "Prof"})
        Me.CmbTitle.Location = New System.Drawing.Point(185, 240)
        Me.CmbTitle.Name = "CmbTitle"
        Me.CmbTitle.Size = New System.Drawing.Size(80, 25)
        Me.CmbTitle.Sorted = True
        Me.CmbTitle.TabIndex = 3
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(111, 515)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(59, 17)
        Me.Label24.TabIndex = 26
        Me.Label24.Text = "Position*"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label25
        '
        Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(517, 378)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(106, 17)
        Me.Label25.TabIndex = 27
        Me.Label25.Text = "Mobile Number*"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(122, 477)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(48, 17)
        Me.Label26.TabIndex = 28
        Me.Label26.Text = "Status*"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(95, 360)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label27.Size = New System.Drawing.Size(75, 17)
        Me.Label27.TabIndex = 29
        Me.Label27.Text = "Last Name*"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(487, 280)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label28.Size = New System.Drawing.Size(136, 17)
        Me.Label28.TabIndex = 30
        Me.Label28.Text = "Postal / GPS Address*"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label29
        '
        Me.Label29.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(571, 463)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label29.Size = New System.Drawing.Size(52, 17)
        Me.Label29.TabIndex = 31
        Me.Label29.Text = "School*"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label30
        '
        Me.Label30.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(114, 438)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(56, 17)
        Me.Label30.TabIndex = 38
        Me.Label30.Text = "Gender*"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label31
        '
        Me.Label31.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(541, 422)
        Me.Label31.Name = "Label31"
        Me.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label31.Size = New System.Drawing.Size(82, 17)
        Me.Label31.TabIndex = 32
        Me.Label31.Text = "Department*"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label32
        '
        Me.Label32.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(82, 321)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(88, 17)
        Me.Label32.TabIndex = 33
        Me.Label32.Text = "Middle Name"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label33
        '
        Me.Label33.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(569, 241)
        Me.Label33.Name = "Label33"
        Me.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label33.Size = New System.Drawing.Size(54, 17)
        Me.Label33.TabIndex = 34
        Me.Label33.Text = "Region*"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label34
        '
        Me.Label34.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(84, 398)
        Me.Label34.Name = "Label34"
        Me.Label34.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label34.Size = New System.Drawing.Size(86, 17)
        Me.Label34.TabIndex = 35
        Me.Label34.Text = "Date of Birth*"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label35
        '
        Me.Label35.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(545, 202)
        Me.Label35.Name = "Label35"
        Me.Label35.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label35.Size = New System.Drawing.Size(78, 17)
        Me.Label35.TabIndex = 36
        Me.Label35.Text = "HomeTown*"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label36
        '
        Me.Label36.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(94, 282)
        Me.Label36.Name = "Label36"
        Me.Label36.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label36.Size = New System.Drawing.Size(76, 17)
        Me.Label36.TabIndex = 39
        Me.Label36.Text = "First Name*"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label37
        '
        Me.Label37.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(133, 243)
        Me.Label37.Name = "Label37"
        Me.Label37.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label37.Size = New System.Drawing.Size(37, 17)
        Me.Label37.TabIndex = 24
        Me.Label37.Text = "Title*"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(128, 556)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 17)
        Me.Label19.TabIndex = 23
        Me.Label19.Text = "Email"
        '
        'btnUpdateRecord
        '
        Me.btnUpdateRecord.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdateRecord.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnUpdateRecord.Location = New System.Drawing.Point(585, 602)
        Me.btnUpdateRecord.Name = "btnUpdateRecord"
        Me.btnUpdateRecord.Size = New System.Drawing.Size(116, 34)
        Me.btnUpdateRecord.TabIndex = 19
        Me.btnUpdateRecord.Text = "Update Record"
        Me.btnUpdateRecord.UseVisualStyleBackColor = True
        '
        'btnDeleteRecord
        '
        Me.btnDeleteRecord.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDeleteRecord.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnDeleteRecord.Location = New System.Drawing.Point(726, 602)
        Me.btnDeleteRecord.Name = "btnDeleteRecord"
        Me.btnDeleteRecord.Size = New System.Drawing.Size(116, 34)
        Me.btnDeleteRecord.TabIndex = 20
        Me.btnDeleteRecord.Text = "Delete Record"
        Me.btnDeleteRecord.UseVisualStyleBackColor = True
        '
        'btnUploadDialog
        '
        Me.btnUploadDialog.FileName = "OpenFileDialog1"
        '
        'PersonnelInfoBindingSource
        '
        Me.PersonnelInfoBindingSource.DataMember = "Personnel_Info"
        Me.PersonnelInfoBindingSource.DataSource = Me.StudentManagementSystemDataSetBindingSource
        '
        'StudentManagementSystemDataSetBindingSource
        '
        Me.StudentManagementSystemDataSetBindingSource.DataSource = Me.Student_Management_SystemDataSet
        Me.StudentManagementSystemDataSetBindingSource.Position = 0
        '
        'Student_Management_SystemDataSet
        '
        Me.Student_Management_SystemDataSet.DataSetName = "Student_Management_SystemDataSet"
        Me.Student_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Personnel_InfoTableAdapter
        '
        Me.Personnel_InfoTableAdapter.ClearBeforeFill = True
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearch.Location = New System.Drawing.Point(765, 97)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(77, 33)
        Me.btnSearch.TabIndex = 57
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'frmAdmin_Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(933, 687)
        Me.Controls.Add(Me.tabAdminStaff)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmAdmin_Staff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Newman College - Administrator (Staff Page)"
        Me.tabAdminStaff.ResumeLayout(False)
        Me.tabNewStaff.ResumeLayout(False)
        Me.tabNewStaff.PerformLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEditDeleteStaff.ResumeLayout(False)
        Me.tabEditDeleteStaff.PerformLayout()
        CType(Me.pbEditImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonnelInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentManagementSystemDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabAdminStaff As TabControl
    Friend WithEvents tabNewStaff As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents tabEditDeleteStaff As TabPage
    Friend WithEvents Label8 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHometown As TextBox
    Friend WithEvents txtPostalAddress As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents cbTitle As ComboBox
    Friend WithEvents dateBirthday As DateTimePicker
    Friend WithEvents cmbPosition As ComboBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents cmbDepartment As ComboBox
    Friend WithEvents mtxtMobile As MaskedTextBox
    Friend WithEvents cmbRegion As ComboBox
    Friend WithEvents pbImage As PictureBox
    Friend WithEvents btnAdminSave As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btnDeleteRecord As Button
    Friend WithEvents cmbSchool As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtPin As TextBox
    Friend WithEvents txtStaffID As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents btnUpload As Button
    Friend WithEvents btnUploadDialog As OpenFileDialog
    Friend WithEvents StudentManagementSystemDataSetBindingSource As BindingSource
    Friend WithEvents Student_Management_SystemDataSet As Student_Management_SystemDataSet
    Friend WithEvents PersonnelInfoBindingSource As BindingSource
    Friend WithEvents Personnel_InfoTableAdapter As Student_Management_SystemDataSetTableAdapters.Personnel_InfoTableAdapter
    Friend WithEvents txtStaffPin As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents pbEditImage As PictureBox
    Friend WithEvents cbSchool As ComboBox
    Friend WithEvents cbDepartment As ComboBox
    Friend WithEvents mtxtNumber As MaskedTextBox
    Friend WithEvents cbRegion As ComboBox
    Friend WithEvents cbPosition As ComboBox
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents txtHome As TextBox
    Friend WithEvents txtPostal_Address As TextBox
    Friend WithEvents txtLast_Name As TextBox
    Friend WithEvents txtMiddle_Name As TextBox
    Friend WithEvents txtFirst_Name As TextBox
    Friend WithEvents CmbTitle As ComboBox
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
    Friend WithEvents radDelete As RadioButton
    Friend WithEvents radUpdate As RadioButton
    Friend WithEvents Label38 As Label
    Friend WithEvents mtxtStaffID As MaskedTextBox
    Friend WithEvents btnSearch As Button
End Class
