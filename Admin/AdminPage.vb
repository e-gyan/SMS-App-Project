Public Class frmAdminPage
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
        frmLogin.Close()
    End Sub

    Private Sub StaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffToolStripMenuItem.Click
        Try
            frmAdmin_Staff.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub StudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentToolStripMenuItem.Click
        frmAdmin_Student.Show()
    End Sub

    Private Sub AcademicsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcademicsToolStripMenuItem.Click
        frmAdmin_Academics.Show()
    End Sub

    Private Sub AccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountToolStripMenuItem.Click
        frmAdmin_Account.Show()
    End Sub

    Private Sub frmAdminPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class