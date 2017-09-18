Imports System.Data.OleDb

Public Class Login
    Dim connection As OleDbConnection
    Dim command As OleDbCommand
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connection = New OleDbConnection
        command = New OleDbCommand


        connection.ConnectionString = "Provider= Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB\Project\RealProject.accdb"
        command.Connection = connection
        Try
            connection.Open()
            connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtusername.Clear()
        txtpassword.Clear()
    End Sub

    Private Sub btxExit_Click(sender As Object, e As EventArgs) Handles btxExit.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim mm As Main_Menu
        mm = New Main_Menu


        If (txtusername.Text = "admin" And txtpassword.Text = "admin") Then

            Me.Hide()
            mm.Show()
        Else
            MessageBox.Show("Try again ")

        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
