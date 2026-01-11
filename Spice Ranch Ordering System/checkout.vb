Imports Spice_Ranch_Ordering_System.globals 'imports all arrays etc from global so can be used in all forms
Public Class checkout
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide() 'hide checout form
        basket.Show() ' show basket form
    End Sub
        
    Private Sub checkout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TotalPriceb As Decimal 'make a total price variable used to display it

        For i As Integer = 0 To FoodItem.Count - 1
            TotalPriceb = TotalPriceb + Price(i)
        Next
        'add up the prices of each item and save them in the variable
        Label2.Text = Format((TotalPriceb), "currency")
        'display in label as currency
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Dim TotalPricec As Decimal 'make a total price variable used to display it
        Dim TotalPriceb As Decimal 'make a total price variable used to add the value 
        Type = ("Your Order will be delivered in 30 minutes.") 'global string so it can be used later on
        For i As Integer = 0 To FoodItem.Count - 1
            TotalPriceb = TotalPriceb + Price(i)
            'add up the prices of each item and save them in the variable
        Next
        If RadioButton1.Checked Then 'if delivery checked
            TotalPricec = TotalPriceb + 1.99
            'add the delivery fee to the total price variable in another variable
        End If
        Label2.Text = Format((TotalPricec), "currency")
        'display in label as currency
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim TotalPriceb As Decimal 'make a total price variable used to display it
        Type = ("Your Order must be collected Please arrive in 20 minutes.") 'global string so it can be used later on
        For i As Integer = 0 To FoodItem.Count - 1
            TotalPriceb = TotalPriceb + Price(i)
            'add up the prices of each item and save them in the variable
            Label2.Text = Format((TotalPriceb), "currency")
            'display in label as currency
        Next
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Please fill in your details")
            'makes sure that the user can't checkout unnless inputed there details
        Else
            Details.Add(TextBox1.Text)
            Details.Add(TextBox2.Text)
            Details.Add(TextBox3.Text)
            Details.Add(TextBox4.Text)
            Details.Add(TextBox5.Text)
            'save all details in array if filled in
            Me.Hide() 'hide checout form
            Confomation.Show() 'show confomation form
        End If
    End Sub

End Class