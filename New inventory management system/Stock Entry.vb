Public Class Stock_Entry
    Private Sub Stock_Entry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RealProjectDataSet3.Stock_entry' table. You can move, or remove it, as needed.
        Me.Stock_entryTableAdapter.Fill(Me.RealProjectDataSet3.Stock_entry)

    End Sub
End Class