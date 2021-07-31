Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UnameTb.Text = "" Or PasswordTb.Text = "" Then
            MessageBox.Show("Enter UserName and Password")
        ElseIf UnameTb.Text = "Admin" And PasswordTb.Text = "Password" Then
            Dim Obj = New Items
            Obj.Show()
            Me.Hide()
        Else
            MessageBox.Show("Wrong Username or Password")
            UnameTb.Text = ""
            PasswordTb.Text = ""
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim Obj = New Orders
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub
End Class
