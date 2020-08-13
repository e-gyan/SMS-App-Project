Public Class frmStaff_Course

    Dim AcadRecord As New Student_Management_SystemDataSetTableAdapters.InitialEndAcademicsTableAdapter
    Dim CourseReg As New Student_Management_SystemDataSetTableAdapters.StaffCourseRegistrationTableAdapter
    Dim GetCourses As New Student_Management_SystemDataSetTableAdapters.CourseCatalogueTableAdapter
    Dim sqlDataTable As New Student_Management_SystemDataSet

    Private SQL As New SQLTemplate

    Private Sub frmStaff_Course_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = frmStaffPage
        SQL.HasConnected()
        getAcademic()
        btnRegisterCourse.Enabled = False
    End Sub

    Private Sub getAcademic()

        Dim rows As Student_Management_SystemDataSet.InitialEndAcademicsRow

        AcadRecord.Fill(sqlDataTable.InitialEndAcademics)

        If sqlDataTable.InitialEndAcademics.Rows.Count > 0 Then
            rows = sqlDataTable.InitialEndAcademics.Rows(0)
            mtxtCourse.Text = rows.AcademicYear
            txtTermBlock.Text = rows.TermBlock

        Else
            MsgBox("No record for an ongoing academic year and term", MsgBoxStyle.Information, "Newman College - Staff (Course Page)")
        End If
    End Sub

    Private Sub btnEndAcademic_Click(sender As Object, e As EventArgs) Handles btnRegisterCourse.Click
        Dim result As DialogResult
        Dim value As String

        If (radYear1.Checked = True Or radYear2.Checked = True Or radYear3.Checked = True) And cmbCourse.SelectedItem = True Then

            result = MsgBox("Do you want to continue and register for the course?",
                           MsgBoxStyle.YesNo, "Newman College - Staff (Course Page)")
            If result = DialogResult.No Then
                clearCourse()
                Me.Show()
                Exit Sub

            Else
                If radYear1.Checked = True Then
                    value = radYear1.Text

                ElseIf radYear2.Checked = True Then
                    value = radYear2.Text

                Else
                    value = radYear3.Text
                End If

                CourseReg.CourseInsertQuery(frmStaffPage.getStaffID.Text, mtxtCourse.Text, value, txtTermBlock.Text, cmbCourse.SelectedItem)

                MsgBox("Registered course saved successfully", MsgBoxStyle.Information, "Newman College - Staff (Course Page)")
                getAcademic()
                clearCourse()
            End If

        Else
            MsgBox("Please select from the year block and course you want to register first, and try again", MsgBoxStyle.Information, "Newman College - Staff (Course Page)")
            Exit Sub
        End If
    End Sub

    Private Sub clearCourse()
        radYear1.Checked = False
        radYear2.Checked = False
        radYear3.Checked = False
        cmbCourse.SelectedItem = -1
        btnRegisterCourse.Enabled = False
    End Sub


    Private Sub radYear1_CheckedChanged(sender As Object, e As EventArgs) Handles radYear1.CheckedChanged
        Dim rows As Student_Management_SystemDataSet.CourseCatalogueRow

        btnRegisterCourse.Enabled = True
        If radYear1.Checked = True Then
            GetCourses.Fill(sqlDataTable.CourseCatalogue, radYear1.Text, txtTermBlock.Text)

            If sqlDataTable.CourseCatalogue.Rows.Count > 0 Then
                rows = sqlDataTable.CourseCatalogue.Rows(0)
                For Each rows In sqlDataTable.CourseCatalogue.Rows
                    cmbCourse.Items.Add(rows.Course_Code + " " + rows.Name)
                Next

            Else
                MsgBox("No record for an ongoing academic year and term", MsgBoxStyle.Information, "Newman College - Staff (Course Page)")
            End If

        Else
            cmbCourse.SelectedItem = -1
            cmbCourse.Items.Clear()
        End If
    End Sub

    Private Sub radYear2_CheckedChanged(sender As Object, e As EventArgs) Handles radYear2.CheckedChanged
        Dim rows As Student_Management_SystemDataSet.CourseCatalogueRow
        btnRegisterCourse.Enabled = True

        If radYear2.Checked = True Then
            GetCourses.Fill(sqlDataTable.CourseCatalogue, radYear2.Text, txtTermBlock.Text)

            If sqlDataTable.CourseCatalogue.Rows.Count > 0 Then
                rows = sqlDataTable.CourseCatalogue.Rows(0)
                For Each rows In sqlDataTable.CourseCatalogue.Rows
                    cmbCourse.Items.Add(rows.Course_Code + " " + rows.Name)
                Next

            Else
                MsgBox("No record for an ongoing academic year and term", MsgBoxStyle.Information, "Newman College - Staff (Course Page)")
            End If

        Else
            cmbCourse.SelectedItem = -1
            cmbCourse.Items.Clear()
        End If
    End Sub

    Private Sub radYear3_CheckedChanged(sender As Object, e As EventArgs) Handles radYear3.CheckedChanged
        Dim rows As Student_Management_SystemDataSet.CourseCatalogueRow
        btnRegisterCourse.Enabled = True

        If radYear3.Checked = True Then
            GetCourses.Fill(sqlDataTable.CourseCatalogue, radYear3.Text, txtTermBlock.Text)

            If sqlDataTable.CourseCatalogue.Rows.Count > 0 Then
                rows = sqlDataTable.CourseCatalogue.Rows(0)
                For Each rows In sqlDataTable.CourseCatalogue.Rows
                    cmbCourse.Items.Add(rows.Course_Code + " " + rows.Name)
                Next

            Else
                MsgBox("No record for an ongoing academic year and term", MsgBoxStyle.Information, "Newman College - Staff (Course Page)")
            End If

        Else
            cmbCourse.SelectedItem = -1
            cmbCourse.Items.Clear()
        End If
    End Sub


End Class