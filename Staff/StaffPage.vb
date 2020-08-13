Public Class frmStaffPage

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub PersonalRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonalRecordToolStripMenuItem.Click
        frmStaff_PersonalRecord.Show()
    End Sub

    Private Sub CourseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CourseToolStripMenuItem.Click
        frmStaff_Course.Show()
    End Sub


End Class