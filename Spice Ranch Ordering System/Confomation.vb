Imports Spice_Ranch_Ordering_System.globals 'imports all arrays etc from global so can be used in all forms
Public Class Confomation
    Private Sub Conformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TotalPriceb As Decimal 'make variable to show total price 
        For i As Integer = 0 To Details.Count - 1
            ListBox1.Items.Add(Details(i))
            'displays the details stored in array as a list
        Next
        For i As Integer = 0 To FoodItem.Count - 1
            Food_Item.Items.Add(FoodItem(i))
            Food_Quantity.Items.Add(Quantity(i))
            Food_Price.Items.Add(Price(i))
            'displays the food items, quantity and price stored in arrays as a lists
        Next
        Label5.Text = (Type) 'outputs the string from the globals from earlier displaying weather it was delivery or collection and how long
        For i As Integer = 0 To FoodItem.Count - 1
            TotalPriceb = TotalPriceb + Price(i)
            'add up all the totals

        Next
        If Type = ("Your Order will be delivered in 30 minutes.") Then
            TotalPriceb = TotalPriceb + 1.99
            'adds 1.99 if delivery was selected in the other form
        End If
        Label4.Text = Format((TotalPriceb), "currency")
        'displays price variable as a currency
    End Sub

End Class