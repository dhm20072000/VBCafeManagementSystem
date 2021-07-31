Imports System.Data.SqlClient

Public Class Items
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dhm20\Documents\CafeVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim Obj = New Login
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CatTb.Text = "" Then
            MessageBox.Show("Enter a category")
        Else
            Con.Open()
            Dim query = "insert into CategoryTbl values('" & CatTb.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Category Added")
            Con.Close()
            CatTb.Text = ""
            FillCategory()
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub Reset()
        ItNameTb.Text = ""
        CatCb.SelectedIndex = 0
        QuantityTb.Text = ""
        ItPriceTb.Text = ""
    End Sub
    Private Sub FillCategory()
        Con.Open()
        Dim cmd = New SqlCommand("select * from CategoryTbl", Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim Tbl = New DataTable()
        adapter.Fill(Tbl)
        CatCb.DataSource = Tbl
        CatCb.DisplayMember = "CatName"
        CatCb.ValueMember = "CatName"
        Con.Close()
    End Sub
    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub

    Private Sub Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCategory()
        DisplayItem()
    End Sub
    Private Sub DisplayItem()
        Con.Open()
        Dim query = "select * from ItemTbl"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        If CatCb.SelectedIndex = -1 Or ItNameTb.Text = "" Or ItPriceTb.Text = "" Or QuantityTb.Text = "" Then
            MessageBox.Show("Missing Information")
        Else
            Con.Open()
            Dim query = "insert into ItemTbl values('" & ItNameTb.Text & "','" & CatCb.SelectedValue.ToString() & "','" & ItPriceTb.Text & "','" & QuantityTb.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item Added")
            Con.Close()
            Reset()
            DisplayItem()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CatTb.Text = "" Then
            MessageBox.Show("Enter a category")
        Else
            Con.Open()
            Dim query = "delete from CategoryTbl where CatName = '" & CatTb.Text & "'"
            Dim cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Category deleted!")
            Con.Close()
            FillCategory()
        End If
    End Sub
    Dim key = 0
    Private Sub ItemDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick
        Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
        ItNameTb.Text = row.Cells(1).Value.ToString()
        CatCb.SelectedValue = row.Cells(2).Value.ToString()
        ItPriceTb.Text = row.Cells(3).Value.ToString()
        QuantityTb.Text = row.Cells(4).Value.ToString()
        If ItNameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If key = 0 Then
            MessageBox.Show("Select an item to delete")
        Else
            Con.Open()
            Dim query = "delete from ItemTbl where ItId = " & key & ""
            Dim cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item Deleted!")
            Con.Close()
            Reset()
            DisplayItem()
        End If
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If CatCb.SelectedIndex = -1 Or ItNameTb.Text = "" Or ItPriceTb.Text = "" Or QuantityTb.Text = "" Then
            MessageBox.Show("Select an item to edit")
        Else
            Con.Open()
            Dim query = "update ItemTbl set ItName = '" & ItNameTb.Text & "', ItCat = '" & CatCb.SelectedValue.ToString() & "', ItPrice = '" & ItPriceTb.Text & "', ItQty = '" & QuantityTb.Text & "' where ItId = " & key & ""
            Dim cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item Edited!")
            Con.Close()
            Reset()
            DisplayItem()
        End If
    End Sub
End Class

