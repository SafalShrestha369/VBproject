Public Class Main_Menu
    Private Sub ProductEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductEntryToolStripMenuItem.Click
        Dim pe As Product_Entry = New Product_Entry
        pe.MdiParent = Me
        pe.Show()

    End Sub

    Private Sub CostumerDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CostumerDetailsToolStripMenuItem.Click
        Dim cd As Costumer_Details = New Costumer_Details
        cd.MdiParent = Me
        cd.Show()



    End Sub

    Private Sub StockEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockEntryToolStripMenuItem.Click
        Dim se As Stock_Entry = New Stock_Entry
        se.MdiParent = Me
        se.Show()


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

    End Sub
End Class