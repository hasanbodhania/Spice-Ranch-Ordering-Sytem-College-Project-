Imports Spice_Ranch_Ordering_System.globals 'imports all arrays etc from global so can be used in all forms
Public Class basket
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close() ' close the form so it updates each time new product added
        Order.Show() 'show order form
    End Sub
    Private Sub basket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TotalPriceb As Decimal 'make variable to show total price 
        For i As Integer = 0 To FoodItem.Count - 1
            Food_Item.Items.Add(FoodItem(i))
            Food_Quantity.Items.Add(Quantity(i))
            Food_Price.Items.Add(Price(i))
            'get the diffrent things like food items, food quanity and price stored in the global array and display as list
        Next
        For i As Integer = 0 To FoodItem.Count - 1
            TotalPriceb = TotalPriceb + Price(i)
            'add up all the totals
        Next
        Label2.Text = Format((TotalPriceb), "currency")
        'display as a currenct
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close() ' close the form so it updates each time new product added
        checkout.Show() 'show checkout form
    End Sub

End Class