Public Class frmAdmin_Academics

    Dim AcadYear As New Student_Management_SystemDataSetTableAdapters.InitialEndAcademicsTableAdapter

    Dim sqlDataTable As New Student_Management_SystemDataSet

    Private SQL As New SQLTemplate

    Private Sub frmAdmin_Academics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = frmAdminPage
        radInitial.Checked = False
        radEnd.Checked = False
        mtxtAcademicYear.Enabled = False
        cmbTermBlock.Enabled = False
        chkYear1.Enabled = False
        chkYear2.Enabled = False
        chkYear3.Enabled = False

    End Sub

    Private Sub clearPage()
        mtxtAcademicYear.Clear()
        cmbTermBlock.SelectedIndex = -1
        chkYear1.Checked = False
        chkYear2.Checked = False
        chkYear3.Checked = False

    End Sub


    Private Sub radInitial_CheckedChanged(sender As Object, e As EventArgs) Handles radInitial.CheckedChanged
        If radInitial.Checked = False Then
            mtxtAcademicYear.Enabled = False
            cmbTermBlock.Enabled = False
            chkYear1.Enabled = False
            chkYear2.Enabled = False
            chkYear3.Enabled = False

        Else
            mtxtAcademicYear.Focus()
            mtxtAcademicYear.Enabled = True
            cmbTermBlock.Enabled = True
            chkYear1.Enabled = True
            chkYear2.Enabled = True
            chkYear3.Enabled = True
            clearPage()

        End If
    End Sub

    Private Sub radEnd_CheckedChanged(sender As Object, e As EventArgs) Handles radEnd.CheckedChanged
        If radEnd.Checked = True Then
            Dim rows As Student_Management_SystemDataSet.InitialEndAcademicsRow
            Dim Value As Integer

            AcadYear.Fill(sqlDataTable.InitialEndAcademics)

            If sqlDataTable.InitialEndAcademics.Rows.Count > 0 Then
                rows = sqlDataTable.InitialEndAcademics.Rows(0)
                mtxtAcademicYear.Text = rows.AcademicYear
                cmbTermBlock.SelectedItem = rows.TermBlock
                If rows.Group1.ToString = "Year 1" And rows.Group2.ToString = "Year 2" And rows.Group3.ToString = "Year 3" Then
                    Value = 1
                End If
                chkYear1.Checked = Value
                chkYear2.Checked = Value
                chkYear3.Checked = Value

            End If
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim result1 As DialogResult

        If radInitial.Checked = True Then
            If mtxtAcademicYear.Text = "" Then
                MsgBox(Label18.Text + " field is required", MsgBoxStyle.Information, "Newman College - Administrator (Academics Page)")
                mtxtAcademicYear.Focus()
                Exit Sub

            ElseIf cmbTermBlock.Text = "" Then
                MsgBox(Label1.Text + " field is required", MsgBoxStyle.Information, "Newman College - Administrator (Academics Page)")
                cmbTermBlock.Focus()
                Exit Sub

            ElseIf chkYear1.CheckState = CheckState.Unchecked Then
                MsgBox("Year 1 field is required", MsgBoxStyle.Information, "Newman College - Administrator (Academics Page)")
                chkYear1.Focus()
                Exit Sub

            ElseIf chkYear2.CheckState = CheckState.Unchecked Then
                MsgBox("Year 2 field is required", MsgBoxStyle.Information, "Newman College - Administrator (Academics Page)")
                chkYear2.Focus()
                Exit Sub

            ElseIf chkYear3.CheckState = CheckState.Unchecked Then
                MsgBox("Year 3 field is required", MsgBoxStyle.Information, "Newman College - Administrator (Academics Page)")
                chkYear3.Focus()
                Exit Sub

            Else
                result1 = MsgBox("Do you want to Initialise Academic Year and Term?",
                            MsgBoxStyle.YesNo, "Newman College - Administrator (Academics Page)")
                If result1 = DialogResult.No Then
                    clearPage()
                    Me.Show()
                    Exit Sub

                Else
                    AcadYear.StartInsertQuery(mtxtAcademicYear.Text, cmbTermBlock.SelectedItem, chkYear1.Text, chkYear2.Text, chkYear3.Text)
                    MsgBox("Operation saved successfully.", MsgBoxStyle.Information, "Newman College - Administrator (Academics Page)")
                    clearPage()
                    radEnd.Checked = False
                    radInitial.Checked = False
                End If

            End If

        ElseIf radEnd.Checked = True Then
            If mtxtAcademicYear.Text = "" Then
                MsgBox(Label18.Text + " field is required", MsgBoxStyle.Information, "Newman College - Administrator (Academics Page)")
                mtxtAcademicYear.Focus()
                Exit Sub

            ElseIf cmbTermBlock.Text = "" Then
                MsgBox(Label1.Text + " field is required", MsgBoxStyle.Information, "Newman College - Administrator (Academics Page)")
                cmbTermBlock.Focus()
                Exit Sub

            ElseIf chkYear1.CheckState = CheckState.Unchecked Then
                MsgBox("Year 1 field is required", MsgBoxStyle.Information, "Newman College - Administrator (Academics Page)")
                chkYear1.Focus()
                Exit Sub

            ElseIf chkYear2.CheckState = CheckState.Unchecked Then
                MsgBox("Year 2 field is required", MsgBoxStyle.Information, "Newman College - Administrator (Academics Page)")
                chkYear2.Focus()
                Exit Sub

            ElseIf chkYear3.CheckState = CheckState.Unchecked Then
                MsgBox("Year 3 field is required", MsgBoxStyle.Information, "Newman College - Administrator (Academics Page)")
                chkYear3.Focus()
                Exit Sub

            Else
                result1 = MsgBox("Do you want to End the Academic Year and Term?",
                            MsgBoxStyle.YesNo, "Newman College - Administrator (Academics Page)")
                If result1 = DialogResult.No Then
                    Me.Show()
                    Exit Sub

                Else

                    AcadYear.EndUpdateQuery(mtxtAcademicYear.Text)
                    MsgBox("Operation saved successfully.", MsgBoxStyle.Information, "Newman College - Administrator (Academics Page)")
                    clearPage()
                    radEnd.Checked = False
                    radInitial.Checked = False
                End If

            End If

        Else
            MsgBox("Please select an option before you can submit", MsgBoxStyle.Information, "Newman College - Administrator (Academics Page)")
        End If
    End Sub


End Class