Imports System.Data.OleDb

Public Class Product_Entry
    Dim connection As OleDbConnection = New OleDbConnection
    Dim command As OleDbCommand = New OleDbCommand
    Private Sub Product_Entry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RealProjectDataSet7.Product_entry' table. You can move, or remove it, as needed.
        Me.Product_entryTableAdapter2.Fill(Me.RealProjectDataSet7.Product_entry)
        'TODO: This line of code loads data into the 'RealProjectDataSet5.Product_entry' table. You can move, or remove it, as needed.
        Me.Product_entryTableAdapter1.Fill(Me.RealProjectDataSet5.Product_entry)
        'TODO: This line of code loads data into the 'RealProjectDataSet1.Product_entry' table. You can move, or remove it, as needed.
        Me.Product_entryTableAdapter.Fill(Me.RealProjectDataSet1.Product_entry)

        connection.ConnectionString = "Provider= Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB\Project\RealProject.accdb"
        command.Connection = connection

    End Sub
    Public Sub Connect()

        If (connection.State = ConnectionState.Closed) Then

            Try

                connection.Open()
            Catch e As OleDbException

                MessageBox.Show(e.ToString)

            End Try
        End If
    End Sub
    Public Sub Disconnect()

        If (connection.State = ConnectionState.Open) Then

            Try

                connection.Close()

            Catch e As OleDbException

                MessageBox.Show(e.ToString)
            End Try
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnPNew.Click

        clearData()

    End Sub
    Private Sub clearData()
        Me.txtPid.Text = ""
        Me.txtPname.Text = ""
        Me.txtBlock.Text = ""
        Me.txtQuantity.Text = ""
        Me.txtWeight.Text = ""
        Me.txtPrice.Text = ""

        Me.txtPid.Focus()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPSave.Click

        Dim i As Integer = -1
        Connect()
        command.CommandText = "INSERT INTO Product_entry(PId, PName, Block, Quantity, Weight, 
        Price, EntryDate, ExpireDate) Values('" & Me.txtPid.Text & "', '" & Me.txtPname.Text & "',
        '" & Me.txtBlock.Text & "','" & Me.txtQuantity.Text & "','" & Me.txtWeight.Text & "',
        '" & Me.txtPrice.Text & "','" & Me.DateTimePickerEntry.Text & "',
        '" & Me.DateTimePickerExpire.Text & "')"


        command.ExecuteNonQuery()
        Dim query As String
        query = "Select * from Product_entry"
        Dim ad As OleDbDataAdapter = New OleDbDataAdapter(query, connection)
        Dim ds As DataSet = New DataSet
        ad.Fill(ds, "Product_entry")
        DataGridView1.DataSource = ds.Tables(0)
        Try
            i = command.ExecuteNonQuery
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            i = -1
            Disconnect()
        End Try

    End Sub
    Private Function InsertData(ByVal productid, ByVal productname, ByVal block, ByVal quantity,
                               ByVal weight, ByVal price, ByVal entrydate, ByVal expirydate) As DataSet

    End Function
End Class