Public Class Costumer_Details
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Costumer_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RealProjectDataSet2.Costumer_entry' table. You can move, or remove it, as needed.
        Me.Costumer_entryTableAdapter.Fill(Me.RealProjectDataSet2.Costumer_entry)

    End Sub
End Class