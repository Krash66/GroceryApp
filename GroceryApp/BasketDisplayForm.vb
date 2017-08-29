Public Class BasketDisplayForm

    Private Sub BasketDisplayForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Set the source of the DataGridView to the Grocery List Collection
        'A little different than the instructions because I made a 
        'Basket Object instead of just the collection as the Basket Object
        viewBasket.DataSource = GroceryItemForm.basket.listArray
        'That's it!! The DataGridView will automatically fill in it's data
        'from the collection object "basket.listArray"
    End Sub

End Class