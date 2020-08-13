Imports System.IO
Imports System.Data.SqlClient

Public Class frmAdmin_Staff
    Dim staffRecord As New Student_Management_SystemDataSetTableAdapters.Personnel_InfoTableAdapter
    Dim sqlDataTable As New Student_Management_SystemDataSet

    Private SQL As New SQLTemplate

    Private Sub frmAdmin_Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = frmAdminPage
        SQL.HasConnected()
        LoadStaffIDPin()
        btnDeleteRecord.Enabled = False
        btnUpdateRecord.Enabled = False
        btnSearch.Enabled = False
    End Sub

    Private Sub clearSave()
        pbImage.Image = Nothing
        pbEditImage.Image = Nothing
        txtStaffID.Clear()
        mtxtStaffID.Clear()
        cbTitle.SelectedIndex = -1
        CmbTitle.SelectedIndex = -1
        txtFirstName.Clear()
        txtFirst_Name.Clear()
        txtMiddleName.Clear()
        txtMiddle_Name.Clear()
        txtLastName.Clear()
        txtLast_Name.Clear()
        dateBirthday.Text = Date.Now
        dtpBirthday.Text = Date.Now
        cmbGender.SelectedIndex = -1
        cbGender.SelectedIndex = -1
        cmbStatus.SelectedIndex = -1
        cbStatus.SelectedIndex = -1
        cmbPosition.SelectedIndex = -1
        cbPosition.SelectedIndex = -1
        txtHometown.Clear()
        txtHome.Clear()
        cmbRegion.SelectedIndex = -1
        cbRegion.SelectedIndex = -1
        txtPostalAddress.Clear()
        txtPostal_Address.Clear()
        mtxtMobile.Clear()
        mtxtNumber.Clear()
        cmbDepartment.SelectedIndex = -1
        cbDepartment.SelectedIndex = -1
        cmbSchool.SelectedIndex = -1
        cbSchool.SelectedIndex = -1
        txtPin.Clear()
        txtStaffPin.Clear()
        txtEmail.Clear()
    End Sub

    Private Sub btnAdminSave_Click(sender As Object, e As EventArgs) Handles btnAdminSave.Click
        Dim result As DialogResult

        If txtStaffID.Text = "" Then
            MsgBox("Staff ID field is required", MsgBoxStyle.Information, "Newman College - Administrator (Staff Page)")
            txtStaffID.Focus()
            Exit Sub
        ElseIf cbTitle.Text = "" Then
            MsgBox("Title field is required", MsgBoxStyle.Information, "Newman College - Administrator (Staff Page)")
            cbTitle.Focus()
            Exit Sub
        ElseIf txtFirstName.Text = "" Then
            MsgBox("First name field is required", MsgBoxStyle.Information, "Newman College - Administrator (Staff Page)")
            txtFirstName.Focus()
            Exit Sub
        ElseIf txtLastName.Text = "" Then
            MsgBox("Last name field is required", MsgBoxStyle.Information, "Newman College - Administrator (Staff Page)")
            txtLastName.Focus()
            Exit Sub
        ElseIf cmbGender.Text = "" Then
            MsgBox("Gender field is required", MsgBoxStyle.Information, "Newman College - Administrator (Staff Page)")
            cmbGender.Focus()
            Exit Sub
        ElseIf cmbStatus.Text = "" Then
            MsgBox("Status field is required", MsgBoxStyle.Information, "Newman College - Administrator (Staff Page)")
            cmbStatus.Focus()
            Exit Sub
        ElseIf cmbPosition.Text = "" Then
            MsgBox("Postion field is required", MsgBoxStyle.Information, "Newman College - Administrator (Staff Page)")
            cmbPosition.Focus()
            Exit Sub
        ElseIf txtHometown.Text = "" Then
            MsgBox("Hometown field is required", MsgBoxStyle.Information, "Newman College - Administrator (Staff Page)")
            txtHometown.Focus()
            Exit Sub
        ElseIf cmbRegion.Text = "" Then
            MsgBox("Region field is required", MsgBoxStyle.Information, "Newman College - Administrator (Staff Page)")
            cmbRegion.Focus()
            Exit Sub
        ElseIf txtPostalAddress.Text = "" Then
            MsgBox("Postal / GPS Address field is required", MsgBoxStyle.Information, "Newman College - Administrator (Staff Page)")
            txtPostalAddress.Focus()
            Exit Sub
        ElseIf cmbDepartment.Text = "" Then
            MsgBox("Department field is required", MsgBoxStyle.Information, "Newman College - Administrator (Staff Page)")
            cmbDepartment.Focus()
            Exit Sub
        ElseIf cmbSchool.Text = "" Then
            MsgBox("School field is required", MsgBoxStyle.Information, "Newman College - Administrator (Staff Page)")
            cmbSchool.Focus()
            Exit Sub
        ElseIf txtPin.Text = "" Then
            MsgBox("Pin field is required", MsgBoxStyle.Information, "Newman College - Administrator (Staff Page)")
            txtPin.Focus()
            Exit Sub

        Else
            Try
                Dim Bimage As Byte() = GetUploadImage()
                result = MsgBox("Do you want to continue and save the record?",
                           MsgBoxStyle.YesNo, "Newman College - Administrator (Staff Page)")
                If result = DialogResult.No Then
                    clearSave()
                    LoadStaffIDPin()
                    Me.Show()
                    Exit Sub

                Else
                    Dim GetEmail As String = GenerateEmail()
                    'Dim staffRecord As New Student_Management_SystemDataSetTableAdapters.Personnel_InfoTableAdapter
                    Dim role As String

                    If cmbStatus.SelectedItem = "Administrative Staff" Then
                        role = "Admin"
                    Else
                        role = "Staff"
                    End If

                    staffRecord.InsertQuery(Bimage, cbTitle.SelectedItem, txtStaffID.Text, txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, dateBirthday.Value, cmbGender.SelectedItem, cmbStatus.SelectedItem, cmbPosition.SelectedItem, txtHometown.Text,
                            cmbRegion.SelectedItem, txtPostalAddress.Text, mtxtMobile.Text, cmbDepartment.SelectedItem, cmbSchool.SelectedItem, role, txtPin.Text, GetEmail)

                    MsgBox("Operation saved successfully.", MsgBoxStyle.Information, "Newman College - Administrator (Staff Page)")
                    UpdateStaffIDPin()
                    clearSave()
                    SQL.HasConnected()
                    LoadStaffIDPin()
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Newman College - Administrator (Staff Page)")
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
        getEmail = (first + middle + last + "@nw.edu.gh").ToLower

        Return getEmail
    End Function

    Private Function GetUploadImage() As Byte()
        Dim mSave As New System.IO.MemoryStream
        Dim fileDialog As New OpenFileDialog
        Dim uploadImage As Byte() = Nothing

        fileDialog.Filter = "JPG Files (*.jpg)|*.jpg|All Files(*.*)|*.*"
        fileDialog.Title = "Upload your image"
        If (fileDialog.ShowDialog() = DialogResult.OK) Then
            pbImage.Image = Image.FromFile(fileDialog.FileName)
            pbImage.Image.Save(mSave, pbImage.Image.RawFormat)
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage
            uploadImage = mSave.ToArray()
            'Else
            '    pbImage.Image = Image.FromFile(".\SMS-App-Project\Resources\profilePicture.ico")
            '    pbImage.Image.Save(mSave, pbImage.Image.RawFormat)
            '    uploadImage = mSave.ToArray()
            'mSave.Close()

        End If
        Return uploadImage
    End Function

    Private Sub LoadStaffIDPin()
        Dim cmdString1, cmdString2, cmdString As String
        Dim paramUserID As New SqlParameter
        Dim paramPin As New SqlParameter
        Dim paramAvailable As New SqlParameter
        Dim Sds As New SqlDataAdapter
        Dim sqlDataTable As New DataTable
        Dim sqlCommand As New SqlCommand
        Dim sqlDataReader As SqlDataReader

        cmdString1 = "SELECT TOP 1 StaffID, Pin FROM GenerateStaffAccess "
        cmdString2 = "WHERE (Available = @role)"
        cmdString = cmdString1 & cmdString2
        paramAvailable.ParameterName = "@role"
        paramAvailable.Value = "Not Assigned"
        sqlCommand.Connection = SQL.SqlCon
        sqlCommand.CommandType = CommandType.Text
        sqlCommand.CommandText = cmdString
        sqlCommand.Parameters.Add(paramAvailable)
        sqlDataReader = sqlCommand.ExecuteReader

        If sqlDataReader.HasRows = True Then
            sqlDataReader.Read()
            txtStaffID.Text = sqlDataReader("StaffID")
            txtPin.Text = sqlDataReader("Pin")

        Else
            MsgBox("Records have been exhausted, create new ones", MsgBoxStyle.Information, "Newman College - Administrator (Staff Page)")
        End If

        sqlCommand.Dispose()
        sqlCommand = Nothing
        sqlDataReader.Close()
        sqlDataReader = Nothing

    End Sub

    Private Sub UpdateStaffIDPin()
        Dim cmdString1, cmdString2, cmdString As String
        Dim paramUserID As New SqlParameter
        Dim paramPin As New SqlParameter
        Dim paramAvailable As New SqlParameter
        Dim Sds As New SqlDataAdapter
        Dim sqlDataTable As New DataTable
        Dim sqlCommand As New SqlCommand

        cmdString1 = "UPDATE GenerateStaffAccess SET Available = @available "
        cmdString2 = "WHERE (StaffID = @id) AND (Pin = @pin)"
        cmdString = cmdString1 & cmdString2
        paramUserID.ParameterName = "@id"
        paramUserID.Value = txtStaffID.Text
        paramPin.ParameterName = "@pin"
        paramPin.Value = txtPin.Text
        paramAvailable.ParameterName = "@available"
        paramAvailable.Value = "Assigned"
        sqlCommand.Connection = SQL.SqlCon
        sqlCommand.CommandType = CommandType.Text
        sqlCommand.CommandText = cmdString
        sqlCommand.Parameters.Add(paramUserID)
        sqlCommand.Parameters.Add(paramPin)
        sqlCommand.Parameters.Add(paramAvailable)
        Sds.SelectCommand = sqlCommand
        Sds.Fill(sqlDataTable)

        sqlDataTable.Dispose()
        sqlDataTable = Nothing
        sqlCommand.Dispose()
        sqlCommand = Nothing
        Sds.Dispose()
        Sds = Nothing
    End Sub

    Private Sub cmbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartment.SelectedIndexChanged
        If cmbDepartment.SelectedItem = "Agricultural Engineering" Or cmbDepartment.SelectedItem = "Computer Engineering" Then
            cmbSchool.SelectedIndex = 0

        Else
            cmbSchool.SelectedIndex = 1
        End If
    End Sub

    Private Sub radUpdate_CheckedChanged(sender As Object, e As EventArgs) Handles radUpdate.CheckedChanged
        If radUpdate.Checked = False Then
            btnUpdateRecord.Enabled = False

        Else
            mtxtStaffID.Focus()
            btnUpdateRecord.Enabled = True
            CmbTitle.Enabled = True
            cbStatus.Enabled = True
            cbPosition.Enabled = True
            cbDepartment.Enabled = True
            cbSchool.Enabled = True
            btnSearch.Enabled = True
            clearSave()
            LoadStaffIDPin()
        End If
    End Sub

    Private Sub radDelete_CheckedChanged(sender As Object, e As EventArgs) Handles radDelete.CheckedChanged
        If radDelete.Checked = False Then
            btnDeleteRecord.Enabled = False

        Else
            mtxtStaffID.Focus()
            btnDeleteRecord.Enabled = True
            btnSearch.Enabled = True
            CmbTitle.Enabled = False
            cbStatus.Enabled = False
            cbPosition.Enabled = False
            cbDepartment.Enabled = False
            cbSchool.Enabled = False
            clearSave()
            LoadStaffIDPin()
        End If
    End Sub

    Private Sub btnDeleteRecord_Click(sender As Object, e As EventArgs) Handles btnDeleteRecord.Click
        Dim Result As DialogResult
        Result = MsgBox("Do you want to delete this record?",
                          MsgBoxStyle.YesNo, "Newman College - Administrator (Staff Page)")

        If Result = DialogResult.No Then
            clearSave()
            Me.Show()
            Exit Sub

        Else
            staffRecord.StaffDeleteQuery(mtxtStaffID.Text)
            MsgBox("Record were deleted successfully", MsgBoxStyle.Information, "Newman College - Administrator (Staff Page)")
            clearSave()
            radDelete.Checked = False
            btnSearch.Enabled = False

        End If
    End Sub

    Private Sub btnUpdateRecord_Click_1(sender As Object, e As EventArgs) Handles btnUpdateRecord.Click
        Dim Result As DialogResult
        Dim role As String
        Result = MsgBox("Do you want to update this record?",
                          MsgBoxStyle.YesNo, "Newman College - Administrator (Staff Page)")
        If Result = DialogResult.No Then
            clearSave()
            Me.Show()
            Exit Sub

        Else
            If cbStatus.SelectedItem = "Administrative Staff" Then
                role = "Admin"
            Else
                role = "Staff"
            End If
            staffRecord.StaffUpdateQuery(CmbTitle.SelectedItem, cbStatus.SelectedItem, cbPosition.SelectedItem,
                                         cbDepartment.SelectedItem, cbSchool.SelectedItem, role, mtxtStaffID.Text)
            MsgBox("Record were updated successfully", MsgBoxStyle.Information, "Newman College - Administrator (Staff Page)")
            clearSave()
            radUpdate.Checked = False
            btnSearch.Enabled = False

        End If
    End Sub

    Private Sub cbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDepartment.SelectedIndexChanged
        If cbDepartment.SelectedItem = "Agricultural Engineering" Or cbDepartment.SelectedItem = "Computer Engineering" Then
            cbSchool.SelectedIndex = 0

        Else
            cbSchool.SelectedIndex = 1
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim picture As Byte()
        Dim rows As Student_Management_SystemDataSet.Personnel_InfoRow

        Try
            staffRecord.Fill(sqlDataTable.Personnel_Info, mtxtStaffID.Text)

            If sqlDataTable.Personnel_Info.Rows.Count > 0 Then
                rows = sqlDataTable.Personnel_Info.Rows(0)
                picture = rows.Picture
                CmbTitle.SelectedItem = rows.Title
                txtFirst_Name.Text = rows.First_Name
                txtMiddle_Name.Text = rows.Middle_Name
                txtLast_Name.Text = rows.Last_Name
                dtpBirthday.Text = rows.DateOfBirth
                cbGender.SelectedItem = rows.Gender
                cbStatus.SelectedItem = rows.Status
                cbPosition.SelectedItem = rows.Position
                txtEmail.Text = rows.Email
                txtHome.Text = rows.HomeTown
                cbRegion.SelectedItem = rows._Region
                txtPostal_Address.Text = rows.PostalAddress
                mtxtNumber.Text = rows.MobileNumber
                cbDepartment.SelectedItem = rows.Department
                cbSchool.SelectedItem = rows.School
                txtStaffPin.Text = rows.StaffPin

                Dim img As New System.IO.MemoryStream(picture)
                pbEditImage.Image = Image.FromStream(img)
                pbEditImage.SizeMode = PictureBoxSizeMode.StretchImage

                img.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Newman College - Administrator (Staff Page)")
            clearSave()
        End Try
    End Sub
End Class