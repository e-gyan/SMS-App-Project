Public Class frmStaff_PersonalRecord
    Dim staRecord As New Student_Management_SystemDataSetTableAdapters.Personnel_InfoTableAdapter
    Dim sqlDataTable As New Student_Management_SystemDataSet

    Private SQL As New SQLTemplate

    Private Sub frmStaff_PersonalRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = frmStaffPage
        SQL.HasConnected()
        GetLoginUser()
        txtHometown.Focus()
    End Sub

    Private Sub txtHometown_TextChanged(sender As Object, e As EventArgs) Handles txtHometown.TextChanged
        If txtHometown.Text = "" Then
            btnStaffPersonalUpdate.Enabled = False
            txtHometown.Focus()
        Else
            btnStaffPersonalUpdate.Enabled = True
        End If
    End Sub

    Private Sub txtPostalAddress_TextChanged(sender As Object, e As EventArgs) Handles txtPostalAddress.TextChanged
        If txtPostalAddress.Text = "" Then
            btnStaffPersonalUpdate.Enabled = False
            txtPostalAddress.Focus()
        Else
            btnStaffPersonalUpdate.Enabled = True
        End If
    End Sub

    Private Sub mtxtMobile_TextChanged(sender As Object, e As EventArgs) Handles mtxtMobile.TextChanged
        If mtxtMobile.Text = "" Then
            btnStaffPersonalUpdate.Enabled = False
            mtxtMobile.Focus()
        Else
            btnStaffPersonalUpdate.Enabled = True
        End If
    End Sub

    Private Sub btnStaffPersonalUpdate_Click(sender As Object, e As EventArgs) Handles btnStaffPersonalUpdate.Click
        Dim Result As DialogResult
        Dim role As String
        Result = MsgBox("Do you want to update this record?",
                          MsgBoxStyle.YesNo, "Newman College - Staff (Personal Record Page)")
        If Result = DialogResult.No Then
            clearSave()
            Me.Show()
            Exit Sub

        Else
            If cmbStatus.SelectedItem = "Administrative Staff" Then
                role = "Admin"
            Else
                role = "Staff"
            End If

            staRecord.PersonalUpdateQuery(txtHometown.Text, txtPostalAddress.Text, mtxtMobile.Text, txtStaffID.Text, role)

            MsgBox("Record were updated successfully", MsgBoxStyle.Information, "Newman College - Staff (Personal Record Page)")
            clearSave()

        End If
    End Sub

    Private Sub GetLoginUser()
        Dim picture As Byte()
        Dim rows As Student_Management_SystemDataSet.Personnel_InfoRow

        Try
            staRecord.Fill(sqlDataTable.Personnel_Info, frmStaffPage.getStaffID.Text)

            If sqlDataTable.Personnel_Info.Rows.Count > 0 Then
                rows = sqlDataTable.Personnel_Info.Rows(0)

                picture = rows.Picture
                Dim img As New System.IO.MemoryStream(picture)
                pbImage.Image = Image.FromStream(img)
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage
                img.Close()

                cbTitle.SelectedItem = rows.Title
                txtStaffID.Text = rows.Staff_ID
                txtFirstName.Text = rows.First_Name
                txtMiddleName.Text = rows.Middle_Name
                txtLastName.Text = rows.Last_Name
                dateBirthday.Text = rows.DateOfBirth
                cmbGender.SelectedItem = rows.Gender
                cmbStatus.SelectedItem = rows.Status
                cmbPosition.SelectedItem = rows.Position
                txtHometown.Text = rows.HomeTown
                cmbRegion.SelectedItem = rows._Region
                txtPostalAddress.Text = rows.PostalAddress
                mtxtMobile.Text = rows.MobileNumber
                cmbDepartment.SelectedItem = rows.Department
                cmbSchool.SelectedItem = rows.School
                txtEmail.Text = rows.Email

            Else
                MsgBox("No record is avilable for the Staff", MsgBoxStyle.Information, "Newman College - Staff (Personal Record Page)")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Newman College - Staff (Personal Record Page)")
            clearSave()
        End Try
    End Sub

    Private Sub clearSave()
        pbImage.Image = Nothing
        txtStaffID.Clear()
        cbTitle.SelectedIndex = -1
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
        dateBirthday.Text = Date.Now
        cmbGender.SelectedIndex = -1
        cmbStatus.SelectedIndex = -1
        cmbPosition.SelectedIndex = -1
        txtHometown.Clear()
        cmbRegion.SelectedIndex = -1
        txtPostalAddress.Clear()
        mtxtMobile.Clear()
        cmbDepartment.SelectedIndex = -1
        cmbSchool.SelectedIndex = -1
        txtEmail.Clear()
    End Sub


End Class