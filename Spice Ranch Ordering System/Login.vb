Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "TestUser" And TextBox2.Text = "TestPass123456" Then 'if the text entered matches these set useranmes and passwords it will allow user to login
            Me.Hide() 'hide the login form
            Order.Show() ' show order form
        Else MsgBox("Sorry, The Username or Password was incorrect.", MsgBoxStyle.Critical, "Information") 'if anyything else is entered it wont let you login and show error
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class