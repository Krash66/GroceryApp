Public Class GroceryItemForm

    Friend basket As New GroceryBasket

    Private Sub GroceryItemForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'hide this window until a successful login
        Me.Hide()
        'create a new login form
        Dim frmLogin As New LoginForm
        'Open the new login form as a modal form, so it must be used first before the Main App opens
        'Get the User from the return from the Login Form
        basket.UserName = frmLogin.doLogin()
        ' Set a welcome message to the User (Or no Useer)
        If basket.UserName = "" Then
            lblUser.Text = "You closed login form without logging in"
        Else
            lblUser.Text = "Welcome, " + basket.UserName + "! Start filling your cart!"
        End If
        ' Now show this Main form
        Me.Show()
        'Give the first text box focus to enter a value
        txtBrandName.Focus()
    End Sub

    Private Sub btnAddToBasket_Click(sender As Object, e As EventArgs) Handles btnAddToBasket.Click, ToolStripMenuItemAdd.Click
        'Make sure all necessary values are filled, If these values are blank or zero then don't save Item. 
        'Chr(10) is ACII code for Carriage Return
        If txtBrandName.Text.Trim.Length < 3 Or numPrice.Value <= 0 Or _
            cboAisle.Text.Trim = "" Or txtDescription.Text.Trim = "" Then
            MessageBox.Show("Price, Aisle and Description must contain values" + Chr(10) + _
                            "Name must be at least 3 Chracters Long", _
                            "Warning: Empty Values", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Warning)
            Exit Sub
        End If
        'set the scan number
        txtScanNumber.Text = txtBrandName.Text.Substring(0, 3) & "1019"
        'create a new GroceryItem object and populate it
        Dim newItem As New GroceryItem
        With newItem
            .Aisle = [Enum].Parse(GetType(Aisle), cboAisle.Text)
            .Description = txtDescription.Text.Trim
            .Name = txtBrandName.Text.Trim
            .Price = numPrice.Value.ToString
            .Scan = txtScanNumber.Text
        End With
        'Add the Item to the Grocery Basket
        basket.Add(newItem)
        'Let user know new item was added
        MessageBox.Show("Item added to Grocery Basket: " + _
                        [Enum].GetName(GetType(Aisle), newItem.Aisle) + "," _
                        + newItem.Scan + "," + newItem.Name, "Item Added", _
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Clear the form for the next Item
        txtBrandName.Clear()
        txtDescription.Clear()
        txtScanNumber.Clear()
        cboAisle.ResetText()
        numPrice.Value = Decimal.Zero
    End Sub

    Private Sub ToolStripMenuItemExit_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemExit.Click
        Application.Exit()
    End Sub

    Private Sub ToolStripMenuItemView_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemView.Click
        'Set output string from basket Object Method
        Dim OutString As String = basket.View()
        'Show MessageBox with the list
        MessageBox.Show(OutString, "Grocery List", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class