Imports System.Data.SqlClient

Public Class frmLogin
    Public SQL As New SQLTemplate

    Private AuthAdmin As String
    Dim assignAdmin As String = "Assigned"

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SQL.HasConnected()
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If radAdmin.Checked = True Then
            If mtxtUsername.Text Is "" Then
                MsgBox(systemLabel.Text + " field is required", MsgBoxStyle.Information, "Newman College - Login")
                mtxtUsername.Focus()
                Exit Sub

            ElseIf mtxtPassword.Text Is "" Then
                MsgBox(Label2.Text + " field is required", MsgBoxStyle.Information, "Newman College - Login")
                mtxtPassword.Focus()
                Exit Sub

            Else
                GetLogin()
            End If

        ElseIf radStaff.Checked = True Then
            If mtxtUsername.Text Is "" Then
                MsgBox(systemLabel.Text + " field is required", MsgBoxStyle.Information, "Newman College - Login")
                mtxtUsername.Focus()
                Exit Sub

            ElseIf mtxtPassword.Text Is "" Then
                MsgBox(Label2.Text + " field is required", MsgBoxStyle.Information, "Newman College - Login")
                mtxtPassword.Focus()
                Exit Sub

            Else
                GetLogin()
            End If

        ElseIf radStudent.Checked = True Then
            If mtxtUsername.Text Is "" Then
                MsgBox(systemLabel.Text + " field is required", MsgBoxStyle.Information, "Newman College - Login")
                mtxtUsername.Focus()
                Exit Sub

            ElseIf mtxtPassword.Text Is "" Then
                MsgBox(Label2.Text + " field is required", MsgBoxStyle.Information, "Newman College - Login")
                mtxtPassword.Focus()
                Exit Sub

            Else
                GetLogin()
            End If

        Else
            MsgBox("System status (Admin, Staff, Student) field is required", MsgBoxStyle.Information, "Newman College - Login")
            Exit Sub

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Dim result As DialogResult
        result = MsgBox("Do you want to cancel the operation and exit the application?",
                        MsgBoxStyle.YesNo, "Newman College - Login")

        Select Case result
            Case Windows.Forms.DialogResult.Yes
                Me.Close()

            Case Windows.Forms.DialogResult.No
                Me.Show()
        End Select

    End Sub

    Private Sub radAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles radAdmin.CheckedChanged
        systemLabel.Text = "Admin ID:"
        clearTabSystem()
        mtxtUsername.Focus()
    End Sub

    Private Sub radStaff_CheckedChanged(sender As Object, e As EventArgs) Handles radStaff.CheckedChanged
        systemLabel.Text = "Staff ID:"
        clearTabSystem()
        mtxtUsername.Focus()
    End Sub

    Private Sub radStudent_CheckedChanged(sender As Object, e As EventArgs) Handles radStudent.CheckedChanged
        systemLabel.Text = "Student ID:"
        clearTabSystem()
        mtxtUsername.Focus()
    End Sub

    Private Sub checkShow_CheckedChanged(sender As Object, e As EventArgs) Handles checkShow.CheckedChanged
        If checkShow.CheckState = CheckState.Checked Then
            mtxtOldPass.UseSystemPasswordChar = False
            mtxtNewPass.UseSystemPasswordChar = False

        Else
            mtxtOldPass.UseSystemPasswordChar = True
            mtxtNewPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub radAdmin1_CheckedChanged(sender As Object, e As EventArgs) Handles radAdmin1.CheckedChanged
        Label6.Text = "Admin ID:"
        clearTabChange()
        mtxtUsername1.Focus()
    End Sub

    Private Sub radStaff1_CheckedChanged(sender As Object, e As EventArgs) Handles radStaff1.CheckedChanged
        Label6.Text = "Staff ID:"
        clearTabChange()
        mtxtUsername1.Focus()
    End Sub

    Private Sub radStudent1_CheckedChanged(sender As Object, e As EventArgs) Handles radStudent1.CheckedChanged
        Label6.Text = "Student ID:"
        clearTabChange()
        mtxtUsername1.Focus()
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        If radAdmin1.Checked = True Then
            If mtxtUsername1.Text Is "" Then
                MsgBox(Label6.Text + " field is required",
                       MsgBoxStyle.Information, "Newman College - Change Pin")
                mtxtUsername1.Focus()
                Exit Sub

            ElseIf mtxtOldPass.Text = "" Then
                MsgBox(Label5.Text + " field is required",
                           MsgBoxStyle.Information, "Newman College - Change Pin")
                mtxtOldPass.Focus()
                Exit Sub

            ElseIf mtxtNewPass.Text = "" Then
                MsgBox(Label7.Text + " field is required",
                           MsgBoxStyle.Information, "Newman College - Change Pin")
                mtxtNewPass.Focus()
                Exit Sub

            ElseIf mtxtOldPass.Text.Equals(mtxtNewPass.Text) = False Then
                MsgBox("Pin mismatch, please enter again", MsgBoxStyle.Exclamation, "Newman College - Change Pin")
                mtxtOldPass.Clear()
                mtxtNewPass.Clear()
                mtxtOldPass.Focus()
                Exit Sub

            Else
                GetChangePinPage()

            End If

        ElseIf radStaff1.Checked = True Then
            If mtxtUsername1.Text Is "" Then
                MsgBox(Label6.Text + " field is required",
                       MsgBoxStyle.Information, "Newman College - Change Pin")
                mtxtUsername1.Focus()
                Exit Sub

            ElseIf mtxtOldPass.Text = "" Then
                MsgBox(Label5.Text + " field is required",
                           MsgBoxStyle.Information, "Newman College - Change Pin")
                mtxtOldPass.Focus()
                Exit Sub

            ElseIf mtxtNewPass.Text = "" Then
                MsgBox(Label7.Text + " field is required",
                           MsgBoxStyle.Information, "Newman College - Change Pin")
                mtxtNewPass.Focus()
                Exit Sub

            ElseIf mtxtOldPass.Text.Equals(mtxtNewPass.Text) = False Then
                MsgBox("Pin mismatch, please enter again", MsgBoxStyle.Exclamation, "Newman College - Change Pin")
                mtxtOldPass.Clear()
                mtxtNewPass.Clear()
                mtxtOldPass.Focus()
                Exit Sub

            Else
                GetChangePinPage()

            End If


        ElseIf radStudent1.Checked = True Then
            If mtxtUsername1.Text Is "" Then
                MsgBox(Label6.Text + " field is required",
                       MsgBoxStyle.Information, "Newman College - Change Pin")
                mtxtUsername1.Focus()
                Exit Sub

            ElseIf mtxtOldPass.Text = "" Then
                MsgBox(Label5.Text + " field is required",
                           MsgBoxStyle.Information, "Newman College - Change Pin")
                mtxtOldPass.Focus()
                Exit Sub

            ElseIf mtxtNewPass.Text = "" Then
                MsgBox(Label7.Text + " field is required",
                           MsgBoxStyle.Information, "Newman College - Change Pin")
                mtxtNewPass.Focus()
                Exit Sub

            ElseIf mtxtOldPass.Text.Equals(mtxtNewPass.Text) = False Then
                MsgBox("Pin mismatch, please enter again", MsgBoxStyle.Exclamation, "Newman College - Change Pin")
                mtxtOldPass.Clear()
                mtxtNewPass.Clear()
                mtxtOldPass.Focus()
                Exit Sub

            Else
                GetChangePinPage()
            End If

        Else
            MsgBox("System status (Admin, Staff, Student) field is required", MsgBoxStyle.Information, "Newman College - Change Pin")
            Exit Sub

        End If
    End Sub

    Private Sub checkField()

        If mtxtUsername.Text Is "" Then
            MsgBox(systemLabel.Text + " field is required", MsgBoxStyle.Information, "Newman College - Login")
            mtxtUsername.Focus()
            Exit Sub

        ElseIf mtxtPassword.Text Is "" Then
            MsgBox(Label2.Text + " field is required", MsgBoxStyle.Information, "Newman College - Login")
            mtxtPassword.Focus()
            Exit Sub

        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        Dim result As DialogResult
        result = MsgBox("Do you want to cancel the operation and go back?",
                        MsgBoxStyle.YesNo, "Newman College - Change Pin")

        Select Case result
            Case Windows.Forms.DialogResult.Yes
                tabLogin.SelectTab(tabSystem)
                clearTabChange()
                radAdmin1.Checked = False
                radStaff1.Checked = False
                radStudent1.Checked = False
                Label6.Text = "User ID:"

            Case Windows.Forms.DialogResult.No
                tabLogin.SelectTab(tabChange)
        End Select

    End Sub

    Private Sub clearTabSystem()
        mtxtUsername.Clear()
        mtxtPassword.Clear()
        checkShowPass.Checked = False
    End Sub

    Private Sub clearTabChange()
        mtxtUsername1.Clear()
        mtxtOldPass.Clear()
        mtxtNewPass.Clear()
    End Sub

    Private Sub clearForgottenPin()
        mtxtUserID.Clear()
        txtForgetEmail.Clear()
    End Sub

    Private Sub linkForget_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkForget.LinkClicked
        tabLogin.SelectTab(tabForget)
        clearForgottenPin()
        radAdmin.Checked = False
        radStaff.Checked = False
        radStudent.Checked = False
        systemLabel.Text = "User ID:"
    End Sub

    Private Sub linkPin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkPin.LinkClicked
        tabLogin.SelectTab(tabChange)
        clearTabSystem()
        radAdmin.Checked = False
        radStaff.Checked = False
        radStudent.Checked = False
        systemLabel.Text = "User ID:"
    End Sub


    Private Sub btnRedeem_Click(sender As Object, e As EventArgs) Handles btnRedeem.Click
        If radForgetAdmin.Checked = True Then
            If mtxtUserID.Text Is "" Then
                MsgBox(Label10.Text + " field is required",
                       MsgBoxStyle.Information, "Newman College - Forgotten Pin")
                mtxtUserID.Focus()
                Exit Sub

            ElseIf txtForgetEmail.Text Is "" Then
                MsgBox(Label12.Text + " field is required",
                           MsgBoxStyle.Information, "Newman College - Forgotten Pin")
                txtForgetEmail.Focus()
                Exit Sub

            ElseIf txtForgetEmail.Text.Contains("@nw.edu.gh") = False Then
                MsgBox("Email Address field format is user@nw.edu.gh",
                           MsgBoxStyle.Information, "Newman College - Forgotten Pin")
                txtForgetEmail.Focus()
                Exit Sub

            Else
                GetRedeemPinPage()
            End If

        ElseIf radForgetStaff.Checked = True Then
            If mtxtUserID.Text Is "" Then
                MsgBox(Label10.Text + " field is required",
                       MsgBoxStyle.Information, "Newman College - Forgotten Pin")
                mtxtUserID.Focus()
                Exit Sub

            ElseIf txtForgetEmail.Text Is "" Then
                MsgBox(Label12.Text + " field is required",
                           MsgBoxStyle.Information, "Newman College - Forgotten Pin")
                txtForgetEmail.Focus()
                Exit Sub

            ElseIf txtForgetEmail.Text.Contains("@nw.edu.gh") = False Then
                MsgBox("Email Address field format is user@nw.edu.gh",
                           MsgBoxStyle.Information, "Newman College - Forgotten Pin")
                txtForgetEmail.Focus()
                Exit Sub

            Else
                GetRedeemPinPage()
            End If


        ElseIf radForgetStudent.Checked = True Then
            If mtxtUserID.Text Is "" Then
                MsgBox(Label10.Text + " field is required",
                       MsgBoxStyle.Information, "Newman College - Forgotten Pin")
                mtxtUserID.Focus()
                Exit Sub

            ElseIf txtForgetEmail.Text Is "" Then
                MsgBox(Label12.Text + " field is required",
                           MsgBoxStyle.Information, "Newman College - Forgotten Pin")
                txtForgetEmail.Focus()
                Exit Sub

            ElseIf txtForgetEmail.Text.Contains("@stu.nw.edu.gh") = False Then
                MsgBox("Email Address field format is username@stu.nw.edu.gh",
                           MsgBoxStyle.Information, "Newman College - Forgotten Pin")
                txtForgetEmail.Focus()
                Exit Sub

            Else
                GetRedeemPinPage()

            End If

        Else
            MsgBox("System status (Admin, Staff, Student) field is required", MsgBoxStyle.Information, "Newman College - Forgotten Pin")
            Exit Sub

        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim result1 As DialogResult
        result1 = MsgBox("Do you want to cancel the operation and go back?",
                        MsgBoxStyle.YesNo, "Newman College - Forgotten Pin")

        Select Case result1
            Case Windows.Forms.DialogResult.Yes
                tabLogin.SelectTab(tabSystem)
                clearForgottenPin()
                radForgetAdmin.Checked = False
                radForgetStaff.Checked = False
                radForgetStudent.Checked = False
                Label10.Text = "User ID:"

            Case Windows.Forms.DialogResult.No
                tabLogin.SelectTab(tabForget)
        End Select
    End Sub

    Private Sub radForgetAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles radForgetAdmin.CheckedChanged
        Label10.Text = "Admin ID:"
        clearForgottenPin()
        mtxtUserID.Focus()
    End Sub

    Private Sub radForgetStaff_CheckedChanged(sender As Object, e As EventArgs) Handles radForgetStaff.CheckedChanged
        Label10.Text = "Staff ID:"
        clearForgottenPin()
        mtxtUserID.Focus()
    End Sub

    Private Sub radForgetStudent_CheckedChanged(sender As Object, e As EventArgs) Handles radForgetStudent.CheckedChanged
        Label10.Text = "Student ID:"
        clearForgottenPin()
        mtxtUserID.Focus()
    End Sub

   
    Private Sub GetLogin()
        Dim cmdString1, cmdString2, cmdString As String
        Dim paramUserID As New SqlParameter
        Dim paramPin As New SqlParameter
        Dim paramAvailable As New SqlParameter
        Dim Sds As New SqlDataAdapter
        Dim sqlDataTable As New DataTable
        Dim sqlCommand As New SqlCommand

        If radAdmin.Checked = True Then
            cmdString1 = "SELECT Staff_ID, StaffPin FROM Personnel_Info "
            cmdString2 = "WHERE (Staff_ID = @Param1 ) AND (StaffPin = @Param2) AND (SystemRole = @Param3)"
            cmdString = cmdString1 & cmdString2
            paramUserID.ParameterName = "@Param1"
            paramUserID.Value = mtxtUsername.Text
            paramPin.ParameterName = "@Param2"
            paramPin.Value = mtxtPassword.Text
            paramAvailable.ParameterName = "@Param3"
            paramAvailable.Value = "Admin"
            sqlCommand.Connection = SQL.SqlCon
            sqlCommand.CommandType = CommandType.Text
            sqlCommand.CommandText = cmdString
            sqlCommand.Parameters.Add(paramUserID)
            sqlCommand.Parameters.Add(paramPin)
            sqlCommand.Parameters.Add(paramAvailable)
            Sds.SelectCommand = sqlCommand
            Sds.Fill(sqlDataTable)

            If sqlDataTable.Rows.Count > 0 Then
                frmAdminPage.Show()
                Me.Hide()
                clearTabSystem()
                radAdmin.Checked = False
                systemLabel.Text = "User ID:"
            Else
                MsgBox("Login failed, contact your Administrator", MsgBoxStyle.Exclamation, "Newman College - Login")
            End If

        ElseIf radStaff.Checked = True Then
            cmdString1 = "SELECT Staff_ID, StaffPin FROM Personnel_Info "
            cmdString2 = "WHERE (Staff_ID = @Param1 ) AND (StaffPin = @Param2) AND (SystemRole = @Param3)"
            cmdString = cmdString1 & cmdString2
            paramUserID.ParameterName = "@Param1"
            paramUserID.Value = mtxtUsername.Text
            paramPin.ParameterName = "@Param2"
            paramPin.Value = mtxtPassword.Text
            paramAvailable.ParameterName = "@Param3"
            paramAvailable.Value = "Staff"
            sqlCommand.Connection = SQL.SqlCon
            sqlCommand.CommandType = CommandType.Text
            sqlCommand.CommandText = cmdString
            sqlCommand.Parameters.Add(paramUserID)
            sqlCommand.Parameters.Add(paramPin)
            sqlCommand.Parameters.Add(paramAvailable)
            Sds.SelectCommand = sqlCommand
            Sds.Fill(sqlDataTable)

            If sqlDataTable.Rows.Count > 0 Then
                frmStaffPage.Show()
                frmStaffPage.getStaffID.Text = mtxtUsername.Text
                Me.Hide()
                clearTabSystem()
                radStaff.Checked = False
                systemLabel.Text = "User ID:"
            Else
                MsgBox("Login failed, contact your Administrator", MsgBoxStyle.Exclamation, "Newman College - Login")
            End If

        Else
            cmdString1 = "SELECT Student_ID, StudentPin FROM StudentInfo "
            cmdString2 = "WHERE (Student_ID = @Param1 ) AND (StudentPin = @Param2)"
            cmdString = cmdString1 & cmdString2
            paramUserID.ParameterName = "@Param1"
            paramUserID.Value = mtxtUsername.Text
            paramPin.ParameterName = "@Param2"
            paramPin.Value = mtxtPassword.Text
            sqlCommand.Connection = SQL.SqlCon
            sqlCommand.CommandType = CommandType.Text
            sqlCommand.CommandText = cmdString
            sqlCommand.Parameters.Add(paramUserID)
            sqlCommand.Parameters.Add(paramPin)
            Sds.SelectCommand = sqlCommand
            Sds.Fill(sqlDataTable)

            If sqlDataTable.Rows.Count > 0 Then
                frmStudentPage.Show()
                frmStudentPage.getStudentID.Text = mtxtUsername.Text
                Me.Hide()
                clearTabSystem()
                radStudent.Checked = False
                systemLabel.Text = "User ID:"
            Else
                MsgBox("Login failed, contact your Administrator", MsgBoxStyle.Exclamation, "Newman College - Login")
            End If


            sqlDataTable.Dispose()
            sqlDataTable = Nothing
            sqlCommand.Dispose()
            sqlCommand = Nothing
            Sds.Dispose()
            Sds = Nothing
        End If
    End Sub

    Private Sub GetChangePinPage()
        Dim cmdString1, cmdString2, cmdString As String
        Dim paramUserID As New SqlParameter
        Dim paramPin As New SqlParameter
        Dim paramAvailable As New SqlParameter
        Dim Sds As New SqlDataAdapter
        Dim sqlDataTable As New DataTable
        Dim sqlCommand As New SqlCommand

        If radAdmin1.Checked = True Then
            cmdString1 = "UPDATE Personnel_Info SET StaffPin = @Param1 "
            cmdString2 = "WHERE (Staff_ID = @Param2) AND (SytemRole = @Param3)"
            cmdString = cmdString1 & cmdString2
            paramPin.ParameterName = "@Param1"
            paramPin.Value = mtxtNewPass.Text
            paramUserID.ParameterName = "@Param2"
            paramUserID.Value = mtxtUsername1.Text
            paramAvailable.ParameterName = "@Param3"
            paramAvailable.Value = "Admin"
            sqlCommand.Connection = SQL.SqlCon
            sqlCommand.CommandType = CommandType.Text
            sqlCommand.CommandText = cmdString
            sqlCommand.Parameters.Add(paramPin)
            sqlCommand.Parameters.Add(paramUserID)
            sqlCommand.Parameters.Add(paramAvailable)
            Sds.SelectCommand = sqlCommand
            Sds.Fill(sqlDataTable)

            If sqlDataTable.Rows.Count > 0 Then
                MsgBox("Your Pin is successfully Changed", MsgBoxStyle.Information, "Newman College - Change Pin")
                clearTabChange()
                radAdmin1.Checked = False
                Label6.Text = "User ID:"
            Else
                MsgBox("Pin failed to be changed, check it again Sir", MsgBoxStyle.Exclamation, "Newman College - Change Pin")
            End If

        ElseIf radStaff1.Checked = True Then
            cmdString1 = "UPDATE Personnel_Info SET StaffPin = @Param1 "
            cmdString2 = "WHERE (Staff_ID = @Param2 ) AND (SytemRole = @Param3)"
            cmdString = cmdString1 & cmdString2
            paramPin.ParameterName = "@Param1"
            paramPin.Value = mtxtNewPass.Text
            paramUserID.ParameterName = "@Param2"
            paramUserID.Value = mtxtUsername1.Text
            paramAvailable.ParameterName = "@Param3"
            paramAvailable.Value = "Staff"
            sqlCommand.Connection = SQL.SqlCon
            sqlCommand.CommandType = CommandType.Text
            sqlCommand.CommandText = cmdString
            sqlCommand.Parameters.Add(paramPin)
            sqlCommand.Parameters.Add(paramUserID)
            sqlCommand.Parameters.Add(paramAvailable)
            Sds.SelectCommand = sqlCommand
            Sds.Fill(sqlDataTable)

            If sqlDataTable.Rows.Count > 0 Then
                MsgBox("Your Pin is successfully Changed", MsgBoxStyle.Information, "Newman College - Change Pin")
                clearTabChange()
                radStaff1.Checked = False
                Label6.Text = "User ID:"
            Else
                MsgBox("Pin failed to be changed, contact your Administrator", MsgBoxStyle.Exclamation, "Newman College - Change Pin")
            End If

        Else
            cmdString1 = "UPDATE StudentInfo SET StudentPin = @Param1 "
            cmdString2 = "WHERE (Student_ID = @Param2)"
            cmdString = cmdString1 & cmdString2
            paramPin.ParameterName = "@Param1"
            paramPin.Value = mtxtNewPass.Text
            paramUserID.ParameterName = "@Param2"
            paramUserID.Value = mtxtUsername1.Text
            sqlCommand.Connection = SQL.SqlCon
            sqlCommand.CommandType = CommandType.Text
            sqlCommand.CommandText = cmdString
            sqlCommand.Parameters.Add(paramPin)
            sqlCommand.Parameters.Add(paramUserID)
            Sds.SelectCommand = sqlCommand
            Sds.Fill(sqlDataTable)

            If sqlDataTable.Rows.Count > 0 Then
                MsgBox("Your Pin is successfully Changed", MsgBoxStyle.Information, "Newman College - Change Pin")
                clearTabChange()
                radStudent1.Checked = False
                Label6.Text = "User ID:"
            Else
                MsgBox("Pin failed to be changed, contact your Administrator", MsgBoxStyle.Exclamation, "Newman College - Change Pin")
            End If


            sqlDataTable.Dispose()
            sqlDataTable = Nothing
            sqlCommand.Dispose()
            sqlCommand = Nothing
            Sds.Dispose()
            Sds = Nothing
        End If
    End Sub

    Private Sub GetRedeemPinPage()
        Dim cmdString1, cmdString2, cmdString, getRedeem As String
        Dim paramUserID As New SqlParameter
        Dim paramPin As New SqlParameter
        Dim paramAvailable As New SqlParameter
        Dim Sds As New SqlDataAdapter
        Dim sqlDataTable As New DataTable
        Dim sqlCommand As New SqlCommand
        Dim sqlDataReader As SqlDataReader

        If radForgetAdmin.Checked = True Then
            cmdString1 = "SELECT StaffPin FROM Personnel_Info "
            cmdString2 = "WHERE (Staff_ID = @Param1) AND (Email = @Param2) AND (SystemRole = @role)"
            cmdString = cmdString1 & cmdString2
            paramUserID.ParameterName = "@Param1"
            paramUserID.Value = mtxtUserID.Text
            paramPin.ParameterName = "@Param2"
            paramPin.Value = txtForgetEmail.Text
            paramAvailable.ParameterName = "@role"
            paramAvailable.Value = "Admin"
            sqlCommand.Connection = SQL.SqlCon
            sqlCommand.CommandType = CommandType.Text
            sqlCommand.CommandText = cmdString
            sqlCommand.Parameters.Add(paramUserID)
            sqlCommand.Parameters.Add(paramPin)
            sqlCommand.Parameters.Add(paramAvailable)
            sqlDataReader = sqlCommand.ExecuteReader

            If sqlDataReader.HasRows = True Then
                sqlDataReader.Read()
                getRedeem = sqlDataReader("StaffPin")
                MsgBox("Your pin is: " + getRedeem, MsgBoxStyle.Information, "Newman College - Forgotten Pin")
                clearForgottenPin()
                radForgetAdmin.Checked = False
                Label10.Text = "User ID:"
            Else
                MsgBox("Please check your Admin ID again", MsgBoxStyle.Exclamation, "Newman College - Forgotten Pin")
            End If

        ElseIf radForgetStaff.Checked = True Then
            cmdString1 = "SELECT StaffPin FROM Personnel_Info "
            cmdString2 = "WHERE (Staff_ID = @Param1) AND (Email = @Param2) AND (SystemRole = @role)"
            cmdString = cmdString1 & cmdString2
            paramUserID.ParameterName = "@Param1"
            paramUserID.Value = mtxtUserID.Text
            paramPin.ParameterName = "@Param2"
            paramPin.Value = txtForgetEmail.Text
            paramAvailable.ParameterName = "@role"
            paramAvailable.Value = "Staff"
            sqlCommand.Connection = SQL.SqlCon
            sqlCommand.CommandType = CommandType.Text
            sqlCommand.CommandText = cmdString
            sqlCommand.Parameters.Add(paramUserID)
            sqlCommand.Parameters.Add(paramPin)
            sqlCommand.Parameters.Add(paramAvailable)
            sqlDataReader = sqlCommand.ExecuteReader

            If sqlDataReader.HasRows = True Then
                sqlDataReader.Read()
                getRedeem = sqlDataReader("StaffPin")
                MsgBox("Your pin is: " + getRedeem, MsgBoxStyle.Information, "Newman College - Forgotten Pin")
                clearForgottenPin()
                radForgetStaff.Checked = False
                Label10.Text = "User ID:"
            Else
                MsgBox("Your pin was not redeemed, contact your Administrator", MsgBoxStyle.Exclamation, "Newman College - Forgotten Pin")
            End If

        Else
            cmdString1 = "SELECT StudentPin FROM StudentInfo "
            cmdString2 = "WHERE (Student_ID = @Param1) AND (Email = @Param2)"
            cmdString = cmdString1 & cmdString2
            paramUserID.ParameterName = "@Param1"
            paramUserID.Value = mtxtUserID.Text
            paramPin.ParameterName = "@Param2"
            paramPin.Value = txtForgetEmail.Text
            sqlCommand.Connection = SQL.SqlCon
            sqlCommand.CommandType = CommandType.Text
            sqlCommand.CommandText = cmdString
            sqlCommand.Parameters.Add(paramUserID)
            sqlCommand.Parameters.Add(paramPin)
            sqlDataReader = sqlCommand.ExecuteReader

            If sqlDataReader.HasRows = True Then
                sqlDataReader.Read()
                getRedeem = sqlDataReader("StudentPin")
                MsgBox("Your pin is: " + getRedeem, MsgBoxStyle.Information, "Newman College - Forgotten Pin")
                clearForgottenPin()
                radForgetStudent.Checked = False
                Label10.Text = "User ID:"
            Else
                MsgBox("Your pin was not redeemed, contact your Administrator", MsgBoxStyle.Exclamation, "Newman College - Forgotten Pin")
            End If

        End If
        sqlCommand.Dispose()
        sqlCommand = Nothing
        sqlDataReader.Close()
        sqlDataReader = Nothing
    End Sub

    Private Sub checkShowPass_CheckedChanged_1(sender As Object, e As EventArgs) Handles checkShowPass.CheckedChanged
        If checkShowPass.CheckState = CheckState.Checked Then
            mtxtPassword.UseSystemPasswordChar = False

        Else
            mtxtPassword.UseSystemPasswordChar = True
        End If
    End Sub


End Class
