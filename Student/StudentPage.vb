Public Class frmStudentPage
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub PersonalRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonalRecordToolStripMenuItem.Click
        frmStudent_PersonalRecord.Show()
    End Sub

    Private Sub AcdemicsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcdemicsToolStripMenuItem.Click
        frmStudent_Academics.Show()
    End Sub

    Private Sub PaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentToolStripMenuItem.Click
        frmStudent_Payment.Show()
    End Sub
End Class