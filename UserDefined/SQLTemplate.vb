Imports System.Data.SqlClient
Imports System.Data

Public Class SQLTemplate

    Public SqlCon As New SqlConnection
    Private SqlCmd As SqlCommand

    Public Sub HasConnected()
        Dim sqlString As String = "Server=workspace-pc\egyansqlserver; Initial Catalog=Student Management System;Integrated Security=True"

        SqlCon = New SqlConnection(sqlString)
        Try
            SqlCon.Open()
        Catch OleDbExceptionErr As SqlException
            MessageBox.Show(OleDbExceptionErr.Message, "Newman College Server Connection - Access Exception")
        Catch InvalidOperationExceptionErr As InvalidOperationException
            MessageBox.Show(InvalidOperationExceptionErr.Message, "Newman College Server Connection - Access Denied")
        End Try

        If SqlCon.State <> ConnectionState.Open Then
            MessageBox.Show("Database is not connected")
            Exit Sub
        End If
    End Sub

    'Database Data
    Public Sqlda As SqlDataAdapter
    Public Sqldt As DataTable
    Public Sqlds As DataSet

    'Query Parameters
    Public params As New List(Of SqlParameter)

    Public RecordCount As Integer
    Public Exception As String

    Public Sub RunQuery(Query As String)
        Try
            SqlCon.Open()

            SqlCmd = New SqlCommand(Query, SqlCon)
            Sqlda = New SqlDataAdapter(SqlCmd)
            Sqlds = New DataSet
            Sqlda.Fill(Sqlds)

            SqlCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

            If SqlCon.State = ConnectionState.Open Then
                SqlCon.Close()
            End If
        End Try
    End Sub

    Public Sub ExecQuery(Query As String)
        RecordCount = 0
        Exception = ""

        Try
            SqlCon.Open()

            'Create Database Command
            SqlCmd = New SqlCommand(Query, SqlCon)

            'Load Params into Database Command
            params.ForEach(Sub(p) SqlCmd.Parameters.Add(p))
            SqlCmd.ExecuteNonQuery()

            'Clear Param List
            params.Clear()

            'Execute Command and Fill Dataset
            Sqldt = New DataTable
            Sqlda = New SqlDataAdapter(SqlCmd)
            RecordCount = Sqlda.Fill(Sqldt)

        Catch ex As Exception
            'Capture Error
            Exception = "ExecQuery Error: " & vbNewLine & ex.Message

        Finally
            If SqlCon.State = ConnectionState.Open Then SqlCon.Close()

        End Try

    End Sub

    'Adding Params
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParams As New SqlParameter(Name, Value)
        params.Add(NewParams)
    End Sub

    'Error Checking
    'Public Function HasException(Optional Report As Boolean = False) As Boolean
    '    If String.IsNullOrEmpty(Exception) Then Return False
    '    If Report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Exception:")
    '    Return True

    'End Function

End Class
