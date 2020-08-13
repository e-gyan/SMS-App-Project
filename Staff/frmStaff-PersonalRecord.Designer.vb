<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStaff_PersonalRecord
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
        Me.tabStaffPersonalRecord = New System.Windows.Forms.TabControl()
        Me.tabPersonalRecord = New System.Windows.Forms.TabPage()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtStaffID = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmbSchool = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnStaffPersonalUpdate = New System.Windows.Forms.Button()
        Me.pbImage = New System.Windows.Forms.PictureBox()
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
        Me.tabStaffPersonalRecord.SuspendLayout()
        Me.tabPersonalRecord.SuspendLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabStaffPersonalRecord
        '
        Me.tabStaffPersonalRecord.Controls.Add(Me.tabPersonalRecord)
        Me.tabStaffPersonalRecord.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabStaffPersonalRecord.Location = New System.Drawing.Point(0, 0)
        Me.tabStaffPersonalRecord.Name = "tabStaffPersonalRecord"
        Me.tabStaffPersonalRecord.SelectedIndex = 0
        Me.tabStaffPersonalRecord.Size = New System.Drawing.Size(933, 715)
        Me.tabStaffPersonalRecord.TabIndex = 0
        '
        'tabPersonalRecord
        '
        Me.tabPersonalRecord.Controls.Add(Me.txtEmail)
        Me.tabPersonalRecord.Controls.Add(Me.txtStaffID)
        Me.tabPersonalRecord.Controls.Add(Me.Label13)
        Me.tabPersonalRecord.Controls.Add(Me.Label22)
        Me.tabPersonalRecord.Controls.Add(Me.cmbSchool)
        Me.tabPersonalRecord.Controls.Add(Me.Label21)
        Me.tabPersonalRecord.Controls.Add(Me.Label17)
        Me.tabPersonalRecord.Controls.Add(Me.Label16)
        Me.tabPersonalRecord.Controls.Add(Me.btnStaffPersonalUpdate)
        Me.tabPersonalRecord.Controls.Add(Me.pbImage)
        Me.tabPersonalRecord.Controls.Add(Me.cmbDepartment)
        Me.tabPersonalRecord.Controls.Add(Me.mtxtMobile)
        Me.tabPersonalRecord.Controls.Add(Me.cmbRegion)
        Me.tabPersonalRecord.Controls.Add(Me.cmbPosition)
        Me.tabPersonalRecord.Controls.Add(Me.cmbStatus)
        Me.tabPersonalRecord.Controls.Add(Me.cmbGender)
        Me.tabPersonalRecord.Controls.Add(Me.dateBirthday)
        Me.tabPersonalRecord.Controls.Add(Me.txtHometown)
        Me.tabPersonalRecord.Controls.Add(Me.txtPostalAddress)
        Me.tabPersonalRecord.Controls.Add(Me.txtLastName)
        Me.tabPersonalRecord.Controls.Add(Me.txtMiddleName)
        Me.tabPersonalRecord.Controls.Add(Me.txtFirstName)
        Me.tabPersonalRecord.Controls.Add(Me.cbTitle)
        Me.tabPersonalRecord.Controls.Add(Me.Label8)
        Me.tabPersonalRecord.Controls.Add(Me.Label14)
        Me.tabPersonalRecord.Controls.Add(Me.Label7)
        Me.tabPersonalRecord.Controls.Add(Me.Label4)
        Me.tabPersonalRecord.Controls.Add(Me.Label12)
        Me.tabPersonalRecord.Controls.Add(Me.Label6)
        Me.tabPersonalRecord.Controls.Add(Me.Label11)
        Me.tabPersonalRecord.Controls.Add(Me.Label3)
        Me.tabPersonalRecord.Controls.Add(Me.Label10)
        Me.tabPersonalRecord.Controls.Add(Me.Label5)
        Me.tabPersonalRecord.Controls.Add(Me.Label9)
        Me.tabPersonalRecord.Controls.Add(Me.Label2)
        Me.tabPersonalRecord.Controls.Add(Me.Label1)
        Me.tabPersonalRecord.Location = New System.Drawing.Point(4, 26)
        Me.tabPersonalRecord.Name = "tabPersonalRecord"
        Me.tabPersonalRecord.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPersonalRecord.Size = New System.Drawing.Size(925, 685)
        Me.tabPersonalRecord.TabIndex = 0
        Me.tabPersonalRecord.Text = "Personal Record"
        Me.tabPersonalRecord.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(643, 517)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(201, 25)
        Me.txtEmail.TabIndex = 14
        '
        'txtStaffID
        '
        Me.txtStaffID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtStaffID.Enabled = False
        Me.txtStaffID.Location = New System.Drawing.Point(190, 209)
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.Size = New System.Drawing.Size(201, 25)
        Me.txtStaffID.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(534, 520)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(91, 17)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Email Address"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(120, 212)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(50, 17)
        Me.Label22.TabIndex = 49
        Me.Label22.Text = "Staff ID"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmbSchool
        '
        Me.cmbSchool.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbSchool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSchool.Enabled = False
        Me.cmbSchool.FormattingEnabled = True
        Me.cmbSchool.Location = New System.Drawing.Point(643, 476)
        Me.cmbSchool.Name = "cmbSchool"
        Me.cmbSchool.Size = New System.Drawing.Size(201, 25)
        Me.cmbSchool.Sorted = True
        Me.cmbSchool.TabIndex = 13
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(578, 479)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(47, 17)
        Me.Label21.TabIndex = 45
        Me.Label21.Text = "School"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label17.Location = New System.Drawing.Point(353, 46)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(226, 21)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "Record Form (*required field)"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label16.Location = New System.Drawing.Point(326, 14)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(289, 32)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "Update Personal Record"
        '
        'btnStaffPersonalUpdate
        '
        Me.btnStaffPersonalUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnStaffPersonalUpdate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnStaffPersonalUpdate.Location = New System.Drawing.Point(728, 596)
        Me.btnStaffPersonalUpdate.Name = "btnStaffPersonalUpdate"
        Me.btnStaffPersonalUpdate.Size = New System.Drawing.Size(116, 36)
        Me.btnStaffPersonalUpdate.TabIndex = 15
        Me.btnStaffPersonalUpdate.Text = "Update"
        Me.btnStaffPersonalUpdate.UseVisualStyleBackColor = True
        '
        'pbImage
        '
        Me.pbImage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbImage.Location = New System.Drawing.Point(425, 78)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(100, 100)
        Me.pbImage.TabIndex = 39
        Me.pbImage.TabStop = False
        '
        'cmbDepartment
        '
        Me.cmbDepartment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartment.Enabled = False
        Me.cmbDepartment.FormattingEnabled = True
        Me.cmbDepartment.Location = New System.Drawing.Point(643, 435)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(201, 25)
        Me.cmbDepartment.Sorted = True
        Me.cmbDepartment.TabIndex = 12
        '
        'mtxtMobile
        '
        Me.mtxtMobile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mtxtMobile.Location = New System.Drawing.Point(643, 385)
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
        Me.cmbRegion.Location = New System.Drawing.Point(643, 248)
        Me.cmbRegion.Name = "cmbRegion"
        Me.cmbRegion.Size = New System.Drawing.Size(201, 25)
        Me.cmbRegion.Sorted = True
        Me.cmbRegion.TabIndex = 9
        '
        'cmbPosition
        '
        Me.cmbPosition.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPosition.Enabled = False
        Me.cmbPosition.FormattingEnabled = True
        Me.cmbPosition.Items.AddRange(New Object() {"Administrative", "Assistant Lecturer", "College Secretary", "Department Secretary", "Lecturer", "Part-Time Lecturer", "Provost", "School Secretary", "Senior Lecturer", "Vice Chancellor"})
        Me.cmbPosition.Location = New System.Drawing.Point(190, 517)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.Size = New System.Drawing.Size(174, 25)
        Me.cmbPosition.Sorted = True
        Me.cmbPosition.TabIndex = 7
        '
        'cmbStatus
        '
        Me.cmbStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.Enabled = False
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Administrative Staff", "Teaching Staff"})
        Me.cmbStatus.Location = New System.Drawing.Point(190, 479)
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
        Me.cmbGender.Location = New System.Drawing.Point(190, 440)
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
        Me.dateBirthday.Location = New System.Drawing.Point(190, 400)
        Me.dateBirthday.Name = "dateBirthday"
        Me.dateBirthday.Size = New System.Drawing.Size(123, 25)
        Me.dateBirthday.TabIndex = 4
        '
        'txtHometown
        '
        Me.txtHometown.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtHometown.Location = New System.Drawing.Point(643, 209)
        Me.txtHometown.Name = "txtHometown"
        Me.txtHometown.Size = New System.Drawing.Size(201, 25)
        Me.txtHometown.TabIndex = 8
        '
        'txtPostalAddress
        '
        Me.txtPostalAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPostalAddress.Location = New System.Drawing.Point(643, 287)
        Me.txtPostalAddress.Multiline = True
        Me.txtPostalAddress.Name = "txtPostalAddress"
        Me.txtPostalAddress.Size = New System.Drawing.Size(201, 79)
        Me.txtPostalAddress.TabIndex = 10
        '
        'txtLastName
        '
        Me.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtLastName.Enabled = False
        Me.txtLastName.Location = New System.Drawing.Point(190, 362)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(202, 25)
        Me.txtLastName.TabIndex = 3
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMiddleName.Enabled = False
        Me.txtMiddleName.Location = New System.Drawing.Point(191, 323)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(201, 25)
        Me.txtMiddleName.TabIndex = 2
        '
        'txtFirstName
        '
        Me.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFirstName.Enabled = False
        Me.txtFirstName.Location = New System.Drawing.Point(190, 284)
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
        Me.cbTitle.Location = New System.Drawing.Point(190, 245)
        Me.cbTitle.Name = "cbTitle"
        Me.cbTitle.Size = New System.Drawing.Size(80, 25)
        Me.cbTitle.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(116, 520)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(54, 17)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Position"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(519, 388)
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
        Me.Label7.Location = New System.Drawing.Point(127, 482)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(43, 17)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Status"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(100, 365)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(70, 17)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Last Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(489, 290)
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
        Me.Label6.Location = New System.Drawing.Point(119, 443)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(51, 17)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Gender"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(548, 438)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(77, 17)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Department"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 326)
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
        Me.Label10.Location = New System.Drawing.Point(571, 251)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(49, 17)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Region"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(89, 403)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(81, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Date of Birth"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(547, 212)
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
        Me.Label2.Location = New System.Drawing.Point(99, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "First Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(32, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Title"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmStaff_PersonalRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 715)
        Me.Controls.Add(Me.tabStaffPersonalRecord)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmStaff_PersonalRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Newman College - Staff (Personal Record Page)"
        Me.tabStaffPersonalRecord.ResumeLayout(False)
        Me.tabPersonalRecord.ResumeLayout(False)
        Me.tabPersonalRecord.PerformLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabStaffPersonalRecord As TabControl
    Friend WithEvents tabPersonalRecord As TabPage
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnStaffPersonalUpdate As Button
    Friend WithEvents pbImage As PictureBox
    Friend WithEvents cmbDepartment As ComboBox
    Friend WithEvents mtxtMobile As MaskedTextBox
    Friend WithEvents cmbRegion As ComboBox
    Friend WithEvents cmbPosition As ComboBox
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
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtStaffID As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label22 As Label
End Class
