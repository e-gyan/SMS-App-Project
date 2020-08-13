Public Class frmAdmin_Student
    Dim studRecord As New Student_Management_SystemDataSetTableAdapters.StudentInfoTableAdapter
    Dim GenIDRecord As New Student_Management_SystemDataSetTableAdapters.GenerateStudentAccessTableAdapter
    Dim EmerRecord As New Student_Management_SystemDataSetTableAdapters.StudentEmergencyTableAdapter
    Dim StaRecord As New Student_Management_SystemDataSetTableAdapters.StudentStatusTableAdapter
    Dim sqlDataTable As New Student_Management_SystemDataSet

    Private SQL As New SQLTemplate

    Private Sub frmAdmin_Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = frmAdminPage
        SQL.HasConnected()
        LoadStudentIDPin()
        btnDeleteRecord.Enabled = False
        btnUpdateRecord.Enabled = False
        btnSearch.Enabled = False
    End Sub

    Private Sub clearSave()
        pbImage.Image = Nothing
        txtStudentID.Clear()
        cbTitle.SelectedIndex = -1
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
        dateBirthday.Text = Date.Now
        cmbGender.SelectedIndex = -1
        cmbStatus.SelectedIndex = -1
        cmbResidence.SelectedIndex = -1
        txtHometown.Clear()
        cmbRegion.SelectedIndex = -1
        txtPostalAddress.Clear()
        mtxtMobile.Clear()
        cmbProgram.SelectedIndex = -1
        cmbSchool.SelectedIndex = -1
        txtPin.Clear()

        pbEditImage.Image = Nothing
        mtxtStudentID.Clear()
        CmbDeed.SelectedIndex = -1
        txtFirst_Name.Clear()
        txtMiddle_Name.Clear()
        txtLast_Name.Clear()
        dtpBirthday.Text = Date.Now
        cbGender.SelectedIndex = -1
        cbStatus.SelectedIndex = -1
        cbResidence.SelectedItem = -1
        txtHome.Clear()
        cbRegion.SelectedIndex = -1
        txtPostal_Address.Clear()
        mtxtNumber.Clear()
        cbProgramme.SelectedIndex = -1
        cbSchool.SelectedIndex = -1
        txtStudentPin.Clear()
        txtEmail.Clear()
    End Sub

    Private Sub btnAdminSave_Click(sender As Object, e As EventArgs) Handles btnAdminSave.Click
        Dim result As DialogResult

        If txtStudentID.Text = "" Then
            MsgBox("Student ID field is required", MsgBoxStyle.Information, "Newman College - Administrator (Student Page)")
            txtStudentID.Focus()
            Exit Sub
        ElseIf cbTitle.Text = "" Then
            MsgBox("Title field is required", MsgBoxStyle.Information, "Newman College - Administrator (Student Page)")
            cbTitle.Focus()
            Exit Sub
        ElseIf txtFirstName.Text = "" Then
            MsgBox("First name field is required", MsgBoxStyle.Information, "Newman College - Administrator (Student Page)")
            txtFirstName.Focus()
            Exit Sub
        ElseIf txtLastName.Text = "" Then
            MsgBox("Last name field is required", MsgBoxStyle.Information, "Newman College - Administrator (Student Page)")
            txtLastName.Focus()
            Exit Sub
        ElseIf cmbGender.Text = "" Then
            MsgBox("Gender field is required", MsgBoxStyle.Information, "Newman College - Administrator (Student Page)")
            cmbGender.Focus()
            Exit Sub
        ElseIf cmbStatus.Text = "" Then
            MsgBox("Status field is required", MsgBoxStyle.Information, "Newman College - Administrator (Student Page)")
            cmbStatus.Focus()
            Exit Sub
        ElseIf cmbResidence.Text = "" Then
            MsgBox("Residence field is required", MsgBoxStyle.Information, "Newman College - Administrator (Student Page)")
            cmbResidence.Focus()
            Exit Sub
        ElseIf txtHometown.Text = "" Then
            MsgBox("Hometown field is required", MsgBoxStyle.Information, "Newman College - Administrator (Student Page)")
            txtHometown.Focus()
            Exit Sub
        ElseIf cmbRegion.Text = "" Then
            MsgBox("Region field is required", MsgBoxStyle.Information, "Newman College - Administrator (Student Page)")
            cmbRegion.Focus()
            Exit Sub
        ElseIf txtPostalAddress.Text = "" Then
            MsgBox("Postal / GPS Address field is required", MsgBoxStyle.Information, "Newman College - Administrator (Student Page)")
            txtPostalAddress.Focus()
            Exit Sub
        ElseIf cmbProgram.Text = "" Then
            MsgBox("Programme field is required", MsgBoxStyle.Information, "Newman College - Administrator (Student Page)")
            cmbProgram.Focus()
            Exit Sub
        ElseIf cmbSchool.Text = "" Then
            MsgBox("School field is required", MsgBoxStyle.Information, "Newman College - Administrator (Student Page)")
            cmbSchool.Focus()
            Exit Sub
        ElseIf txtPin.Text = "" Then
            MsgBox("Pin field is required", MsgBoxStyle.Information, "Newman College - Administrator (Student Page)")
            txtPin.Focus()
            Exit Sub

        Else
            Try
                Dim Bimage As Byte() = GetUploadImage()
                result = MsgBox("Do you want to continue and save the record?",
                       MsgBoxStyle.YesNo, "Newman College - Administrator (Student Page)")
                If result = DialogResult.No Then
                    clearSave()
                    LoadStudentIDPin()
                    Me.Show()
                    Exit Sub

                Else
                    Dim GetEmail As String = GenerateEmail()
                    studRecord.InsertStudentQuery(cbTitle.Text, txtStudentID.Text, txtFirstName.Text, txtMiddleName.Text, txtLastName.Text,
                                                 dateBirthday.Value, cmbGender.SelectedItem, Bimage, cmbProgram.SelectedItem, cmbSchool.SelectedItem, cmbStatus.SelectedItem, txtPin.Text, GetEmail)

                    EmerRecord.InsertEmerQuery(txtHometown.Text, cmbRegion.SelectedItem, txtPostalAddress.Text, mtxtMobile.Text, txtStudentID.Text)
                    StaRecord.InsertStaQuery(cmbResidence.SelectedItem, txtStudentID.Text, "Null")

                    MsgBox("Operation saved successfully.", MsgBoxStyle.Information, "Newman College - Administrator (Student Page)")
                    UpdateStudentIDPin()
                    clearSave()
                    SQL.HasConnected()
                    LoadStudentIDPin()
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Newman College - Administrator (Student Page)")
            End Try

        End If

    End Sub

    Function GenerateEmail()
        Dim getEmail, first, middle, last As String
        first = txtFirstName.Text.Remove(1)
        If txtMiddleName.Text = "" Then
            middle = ""
        Else
            middle = txtMiddleName.Text.Remove(1)
        End If
        last = txtLastName.Text
        getEmail = (first + middle + last + "@stu.nw.edu.gh").ToLower
        Return getEmail

    End Function

    Private Function GetUploadImage() As Byte()
        Dim mSave As New System.IO.MemoryStream
        Dim fileDialog As New OpenFileDialog
        Dim uploadImage1 As Byte() = Nothing

        fileDialog.Filter = "JPG Files (*.jpg)|*.jpg|All Files(*.*)|*.*"
        fileDialog.Title = "Upload your profile image"
        If (fileDialog.ShowDialog() = DialogResult.OK) Then
            pbImage.Image = Image.FromFile(fileDialog.FileName)
            pbImage.Image.Save(mSave, pbImage.Image.RawFormat)
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage
            uploadImage1 = mSave.ToArray()

        End If
        Return uploadImage1

    End Function

    Private Sub LoadStudentIDPin()
        Dim r As Student_Management_SystemDataSet.GenerateStudentAccessRow
        GenIDRecord.Fill(sqlDataTable.GenerateStudentAccess)

        If sqlDataTable.GenerateStudentAccess.Rows.Count > 0 Then
            r = sqlDataTable.GenerateStudentAccess.Rows(0)
            txtStudentID.Text = r.StudentID
            txtPin.Text = r.Pin

        Else
            MsgBox("Records are exhausted, create new ones", MsgBoxStyle.Information, "Newman College - Administrator (Student Page)")
        End If
    End Sub

    Private Sub UpdateStudentIDPin()
        GenIDRecord.UpdateAccessQuery(txtStudentID.Text)
    End Sub

    Private Sub cmbProgram_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProgram.SelectedIndexChanged
        If cmbProgram.SelectedItem = "Bsc. Agricultural Engineering" Or cmbProgram.SelectedItem = "BSc. Computer Engineering" Then
            cmbSchool.SelectedIndex = 0

        Else
            cmbSchool.SelectedIndex = 1
        End If
    End Sub

    Private Sub radUpdate_CheckedChanged(sender As Object, e As EventArgs) Handles radUpdate.CheckedChanged
        If radUpdate.Checked = False Then
            btnUpdateRecord.Enabled = False

        Else
            mtxtStudentID.Focus()
            btnUpdateRecord.Enabled = True
            cbStatus.Enabled = True
            cbProgramme.Enabled = True
            cbSchool.Enabled = True
            btnSearch.Enabled = True
            clearSave()
            LoadStudentIDPin()
        End If
    End Sub

    Private Sub radDelete_CheckedChanged(sender As Object, e As EventArgs) Handles radDelete.CheckedChanged
        If radDelete.Checked = False Then
            btnDeleteRecord.Enabled = False

        Else
            mtxtStudentID.Focus()
            btnDeleteRecord.Enabled = True
            btnSearch.Enabled = True
            cbStatus.Enabled = False
            cbResidence.Enabled = False
            cbProgramme.Enabled = False
            cbSchool.Enabled = False
            clearSave()
            LoadStudentIDPin()
        End If
    End Sub

    Private Sub btnUpdateRecord_Click(sender As Object, e As EventArgs) Handles btnUpdateRecord.Click
        Dim Result As DialogResult
        Result = MsgBox("Do you want to update this record?",
                          MsgBoxStyle.YesNo, "Newman College - Administrator (Student Page)")
        If Result = DialogResult.No Then
            clearSave()
            Me.Show()
            Exit Sub

        Else

            studRecord.studentUpdateQuery(cbProgramme.SelectedItem, cbSchool.SelectedItem, cbStatus.SelectedItem, mtxtStudentID.Text)
            MsgBox("Record were updated successfully", MsgBoxStyle.Information, "Newman College - Administrator (Student Page)")
            clearSave()
            radUpdate.Checked = False
            btnSearch.Enabled = False

        End If
    End Sub

    Private Sub btnDeleteRecord_Click(sender As Object, e As EventArgs) Handles btnDeleteRecord.Click
        Dim Result As DialogResult
        Result = MsgBox("Do you want to delete this record?",
                          MsgBoxStyle.YesNo, "Newman College - Administrator (Student Page)")

        If Result = DialogResult.No Then
            clearSave()
            Me.Show()
            Exit Sub

        Else
            studRecord.studentDeleteQuery(mtxtStudentID.Text)
            EmerRecord.EmerDeleteQuery(mtxtStudentID.Text)
            StaRecord.StaDeleteQuery(mtxtStudentID.Text)
            MsgBox("Record were deleted successfully", MsgBoxStyle.Information, "Newman College - Administrator (Student Page)")
            clearSave()
            radDelete.Checked = False
            btnSearch.Enabled = False

        End If
    End Sub

    Private Sub cbProgramme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProgramme.SelectedIndexChanged
        If cbProgramme.SelectedItem = "Bsc. Agricultural Engineering" Or cbProgramme.SelectedItem = "BSc. Computer Engineering" Then
            cbSchool.SelectedIndex = 0

        Else
            cbSchool.SelectedIndex = 1
        End If
    End Sub

    Private Sub radSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim picture As Byte()
        Dim rows As Student_Management_SystemDataSet.StudentInfoRow
        Dim rows1 As Student_Management_SystemDataSet.StudentEmergencyRow
        Dim rows2 As Student_Management_SystemDataSet.StudentStatusRow

        Try
            studRecord.Fill(sqlDataTable.StudentInfo, mtxtStudentID.Text)
            EmerRecord.Fill(sqlDataTable.StudentEmergency, mtxtStudentID.Text)
            StaRecord.Fill(sqlDataTable.StudentStatus, mtxtStudentID.Text)


            If sqlDataTable.StudentInfo.Rows.Count > 0 Then
                rows = sqlDataTable.StudentInfo.Rows(0)
                CmbDeed.SelectedItem = rows.Title
                txtFirst_Name.Text = rows.First_Name
                txtMiddle_Name.Text = rows.Middle_Name
                txtLast_Name.Text = rows.Last_Name
                dtpBirthday.Value = rows.DateOfBirth
                cbGender.SelectedItem = rows.Gender
                picture = rows.Picture
                cbProgramme.SelectedItem = rows.Programme
                cbSchool.SelectedItem = rows.School
                cbStatus.SelectedItem = rows.Status
                txtStudentPin.Text = rows.StudentPin
                txtEmail.Text = rows.Email

                Dim img As New System.IO.MemoryStream(picture)
                pbEditImage.Image = Image.FromStream(img)
                pbEditImage.SizeMode = PictureBoxSizeMode.StretchImage
                img.Close()

                If sqlDataTable.StudentEmergency.Rows.Count > 0 Then
                    rows1 = sqlDataTable.StudentEmergency.Rows(0)
                    txtHome.Text = rows1.HomeTown
                    cbRegion.SelectedItem = rows1._Region
                    txtPostal_Address.Text = rows1.PostalAddress
                    mtxtNumber.Text = rows1.MobileNumber
                End If

                If sqlDataTable.StudentStatus.Rows.Count > 0 Then
                    rows2 = sqlDataTable.StudentStatus.Rows(0)
                    cbResidence.SelectedItem = rows2.ResidenceStatus

                End If
            Else
                MsgBox("No records found for the Student ID", MsgBoxStyle.Information, "Newman College - Administrator (Student Page)")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Newman College - Administrator (Student Page)")
            clearSave()
        End Try
    End Sub
End Class