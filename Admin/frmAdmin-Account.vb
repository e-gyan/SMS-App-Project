Public Class frmAdmin_Account
    Dim AccRecord As New Student_Management_SystemDataSetTableAdapters.StudentAccountTableAdapter
    Dim sqlDataTable As New Student_Management_SystemDataSet

    Private SQL As New SQLTemplate

    Private Sub frmAdmin_Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = frmAdminPage
        SQL.HasConnected()
        dgvSchoolFees.DataSource = AccRecord.Fill(sqlDataTable.StudentAccount)
    End Sub

End Class