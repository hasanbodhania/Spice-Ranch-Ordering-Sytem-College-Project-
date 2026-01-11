Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Spice_Ranch_Ordering_System.globals 'imports all arrays etc from global so can be used in all forms

Public Class Order
    Private Sub Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Chicken Korma") 'adds item to combo box
        ComboBox1.Items.Add("Chicken Tikka") 'adds item to combo box
        ComboBox1.Items.Add("King Prawn") 'adds item to combo box
        ComboBox1.Items.Add("Margherita Pizza") 'adds item to combo box
        ComboBox1.Items.Add("Pepperoni Pizza") 'adds item to combo box
        ComboBox1.Items.Add("Vegetarian Pizza") 'adds item to combo box
        ComboBox1.Items.Add("¼ Cheeseburger w/Fries") 'adds item to combo box
        ComboBox1.Items.Add("½ Cheeseburger w/Fries") 'adds item to combo box
        ComboBox1.Items.Add("Chicken Burger w/Fries") 'adds item to combo box
        Veg.Visible = False
        Tikka.Visible = False
        Pep.Visible = False
        Korma.Visible = False
        prawn.Visible = False
        brg1.Visible = False
        bgr3.Visible = False
        bgr2.Visible = False
        Mag.Visible = False
        main.Visible = True
        'hides the image if false and shows if true which is the cover one
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Price1 As Decimal 'variable to store the total price for the item
        If ComboBox1.Text = "Select A Food Item" Or HScrollBar1.Value = 0 Then
            MsgBox("You must select a food Item and or a quantity!")
            'if nothing is selected it will show the message box
        End If
        If HScrollBar1.Value >= 1 Then
            'only adds things to basket if above 1 and dont add food item with no quantity
            If ComboBox1.Text = "Chicken Korma" Then
                Price1 = 3.99 * HScrollBar1.Value
                FoodItem.Add(ComboBox1.Text)
                Quantity.Add(HScrollBar1.Value)
                Price.Add(Price1)
                'times the price of item by the quantity and store in the variable created and then add food item selected
                'to the array and quantity and price variable to price array
                Veg.Visible = False
                Tikka.Visible = False
                Pep.Visible = False
                Korma.Visible = True
                prawn.Visible = False
                brg1.Visible = False
                bgr3.Visible = False
                bgr2.Visible = False
                Mag.Visible = False
                main.Visible = False
                'hides the image if false and shows if true
            End If
            If ComboBox1.Text = "Chicken Tikka" Then
                Price1 = 4.99 * HScrollBar1.Value
                FoodItem.Add(ComboBox1.Text)
                Quantity.Add(HScrollBar1.Value)
                Price.Add(Price1)
                'times the price of item by the quantity and store in the variable created and then add food item selected
                'to the array and quantity and price variable to price array
                Veg.Visible = False
                Tikka.Visible = True
                Pep.Visible = False
                Korma.Visible = False
                prawn.Visible = False
                brg1.Visible = False
                bgr3.Visible = False
                bgr2.Visible = False
                Mag.Visible = False
                main.Visible = False
                'hides the image if false and shows if true
            End If
            If ComboBox1.Text = "King Prawn" Then
                Price1 = 5.99 * HScrollBar1.Value
                FoodItem.Add(ComboBox1.Text)
                Quantity.Add(HScrollBar1.Value)
                Price.Add(Price1)
                'times the price of item by the quantity and store in the variable created and then add food item selected
                'to the array and quantity and price variable to price array
                Veg.Visible = False
                Tikka.Visible = False
                Pep.Visible = False
                Korma.Visible = False
                prawn.Visible = True
                brg1.Visible = False
                bgr3.Visible = False
                bgr2.Visible = False
                Mag.Visible = False
                main.Visible = False
                'hides the image if false and shows if true
            End If
            If ComboBox1.Text = "Margherita Pizza" Then
                Price1 = 6.99 * HScrollBar1.Value
                FoodItem.Add(ComboBox1.Text)
                Quantity.Add(HScrollBar1.Value)
                Price.Add(Price1)
                'times the price of item by the quantity and store in the variable created and then add food item selected
                'to the array and quantity and price variable to price array
                Veg.Visible = False
                Tikka.Visible = False
                Pep.Visible = False
                Korma.Visible = False
                prawn.Visible = False
                brg1.Visible = False
                bgr3.Visible = False
                bgr2.Visible = False
                Mag.Visible = True
                main.Visible = False
                'hides the image if false and shows if true
            End If
            If ComboBox1.Text = "Pepperoni Pizza" Then
                Price1 = 7.99 * HScrollBar1.Value
                FoodItem.Add(ComboBox1.Text)
                Quantity.Add(HScrollBar1.Value)
                Price.Add(Price1)
                'times the price of item by the quantity and store in the variable created and then add food item selected
                'to the array and quantity and price variable to price array
                Veg.Visible = False
                Tikka.Visible = False
                Pep.Visible = True
                Korma.Visible = False
                prawn.Visible = False
                brg1.Visible = False
                bgr3.Visible = False
                bgr2.Visible = False
                Mag.Visible = False
                main.Visible = False
                'hides the image if false and shows if true
            End If
            If ComboBox1.Text = "Vegetarian Pizza" Then
                Price1 = 5.99 * HScrollBar1.Value
                FoodItem.Add(ComboBox1.Text)
                Quantity.Add(HScrollBar1.Value)
                Price.Add(Price1)
                'times the price of item by the quantity and store in the variable created and then add food item selected
                'to the array and quantity and price variable to price array
                Veg.Visible = True
                Tikka.Visible = False
                Pep.Visible = False
                Korma.Visible = False
                prawn.Visible = False
                brg1.Visible = False
                bgr3.Visible = False
                bgr2.Visible = False
                Mag.Visible = False
                main.Visible = False
                'hides the image if false and shows if true
            End If
            If ComboBox1.Text = "¼ Cheeseburger w/Fries" Then
                Price1 = 3.99 * HScrollBar1.Value
                FoodItem.Add(ComboBox1.Text)
                Quantity.Add(HScrollBar1.Value)
                Price.Add(Price1)
                'times the price of item by the quantity and store in the variable created and then add food item selected
                'to the array and quantity and price variable to price array
                Veg.Visible = False
                Tikka.Visible = False
                Pep.Visible = False
                Korma.Visible = False
                prawn.Visible = False
                brg1.Visible = True
                bgr3.Visible = False
                bgr2.Visible = False
                Mag.Visible = False
                main.Visible = False
                'hides the image if false and shows if true
            End If
            If ComboBox1.Text = "½ Cheeseburger w/Fries" Then
                Price1 = 4.59 * HScrollBar1.Value
                FoodItem.Add(ComboBox1.Text)
                Quantity.Add(HScrollBar1.Value)
                Price.Add(Price1)
                'times the price of item by the quantity and store in the variable created and then add food item selected
                'to the array and quantity and price variable to price array
                Veg.Visible = False
                Tikka.Visible = False
                Pep.Visible = False
                Korma.Visible = False
                prawn.Visible = False
                brg1.Visible = False
                bgr3.Visible = False
                bgr2.Visible = True
                Mag.Visible = False
                main.Visible = False
                'hides the image if false and shows if true
            End If
            If ComboBox1.Text = "Chicken Burger w/Fries" Then
                Price1 = 4.69 * HScrollBar1.Value
                FoodItem.Add(ComboBox1.Text)
                Quantity.Add(HScrollBar1.Value)
                Price.Add(Price1)
                'times the price of item by the quantity and store in the variable created and then add food item selected
                'to the array and quantity and price variable to price array
                Veg.Visible = False
                Tikka.Visible = False
                Pep.Visible = False
                Korma.Visible = False
                prawn.Visible = False
                brg1.Visible = False
                bgr3.Visible = True
                bgr2.Visible = False
                Mag.Visible = False
                main.Visible = False
                'hides the image if false and shows if true
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox1.Text = "Select A Food Item"
        HScrollBar1.Value = 0
        quantitylbl.Text = "0"
        Veg.Visible = False
        Tikka.Visible = False
        Pep.Visible = False
        Korma.Visible = False
        prawn.Visible = False
        brg1.Visible = False
        bgr3.Visible = False
        bgr2.Visible = False
        Mag.Visible = False
        main.Visible = True
        'hides the image if false and shows if true which is the cover one

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ComboBox1.Text = "Select A Food Item" 'set the text shown back to how it was at the start of program
        HScrollBar1.Value = 0 'set scroll bar back to 0
        quantitylbl.Text = "0" 'set the label text too back to 0
        Veg.Visible = False
        Tikka.Visible = False
        Pep.Visible = False
        Korma.Visible = False
        prawn.Visible = False
        brg1.Visible = False
        bgr3.Visible = False
        bgr2.Visible = False
        Mag.Visible = False
        main.Visible = True
        'hides the image if false and shows if true which is the cover one
    End Sub
    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        quantitylbl.Text = HScrollBar1.Value 'make the label text output the value of the scroll bar
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide() 'hide order form
        basket.Show() 'show basket form
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide() 'hide order form
        basket.Show() 'show basket form
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide() 'hide order form
        help.Show() 'show help form
    End Sub
End Class
