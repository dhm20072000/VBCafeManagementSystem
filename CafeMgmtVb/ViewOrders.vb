Imports System.Data.SqlClient

Public Class ViewOrders
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dhm20\Documents\CafeVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub DisplayItem()
        Con.Open()
        Dim query = "select * from OrderTbl"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub ViewOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayItem()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Obj = New Orders
        Obj.Show()
        Me.Hide()
    End Sub
End Class