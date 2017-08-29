Public Class GroceryItemForm

    'define a New Empty GroceryBasket Object when form opens so it can be populated with data
    Friend basket As New GroceryBasket

    Private Sub GroceryItemForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'hide this window until a successful login
        Me.Hide()

        'create a new login form
        Dim frmLogin As New LoginForm

        'Open the new login form as a modal form, so it must be used first before the Main App opens
        'Get the User from the return from the Login Form doLogin() method. "ShowDialog()" is used there
        'not here so we can define what we want as a return value instead of just "Dialogresult.OK"
        'because we want the user name they entered.
        basket.UserName = frmLogin.doLogin()

        ' Set a welcome message to the User (Or no User)
        If basket.UserName = "" Then
            lblUser.Text = "You closed login form without logging in"
            'Set the FileName property of the basket Object with a shoppinglist name for the specific user
            basket.GroceryListFileName = "AnonUserGroceryList.csv"
        Else
            lblUser.Text = "Welcome, " + basket.UserName + "! Start filling your cart!"
            'Set the FileName property of the basket Object with a shoppinglist name for the specific user
            basket.GroceryListFileName = basket.UserName & "GroceryList.csv"
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
        'with just let's you easily set all the properties of the new groceryItem Object,
        'without having to say "newItem.Aisle = [Enum].Parse(GetType(Aisle), cboAisle.Text)",
        '"newItem.Description = txtDescription.Text.Trim", etc.
        '***NOTE, Always "Trim" user entered text values, in case user add spaces 
        'to beginning or ending of the textbox text. Just good practice, so your Object values are "clean"
        With newItem
            .Aisle = [Enum].Parse(GetType(Aisle), cboAisle.Text)
            .Description = txtDescription.Text.Trim
            .Name = txtBrandName.Text.Trim
            .Price = numPrice.Value.ToString
            .Scan = txtScanNumber.Text
        End With
        'Add the Item to the Grocery Basket
        basket.Add(newItem)
        'Let user know new item was added, because we will now clear the form for the next entry
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

    '*** This Event is changed from the last Assignment
    Private Sub ToolStripMenuItemView_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemView.Click
        'Dim the form variable
        Dim viewForm As BasketDisplayForm
        'Set Variable to a NEW instance of the BasketDisplayForm 
        viewForm = New BasketDisplayForm
        'Open the form Modally, "Me" makes this form the "owner" of the "BasketDisplayForm"
        viewForm.ShowDialog(Me)

    End Sub

    '*** Additions to original Program for Assignment 
    Private Sub ToolStripMenuItemLoad_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItemLoad.Click
        'We will set the FileName property of the OpenFileDialog1, Based the userName
        'that the user logged on with, from the basket.FileName property we set in
        'the GroceryItemForm_Load event above. If the user used all of our default values
        'the previous time they saved the Grocery List, this will be the correct fileName 
        'already set. but we don't know the Directory path.
        OpenFileDialog1.FileName = basket.GroceryListFileName

        'Open the OpenFileDialog to get the Grocery List CSV file 
        '...once user locates file and clicks "open", OpenFileDialog1_FileOk event is triggered
        'and this event waits for the dialogResult from the OpenFileDialog1_FileOk event
        If OpenFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            'When OpenFileDialog1_FileOk event is finished and Dialog Result is OK, 
            'then show user a message to let them know the list was loaded
            MessageBox.Show("Grocery List was loaded with " & basket.listArray.Count.ToString & _
                            " items in it.", "Grocery List Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub ToolStripMenuItemSave_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItemSave.Click

        'Set the Path and File name in the SaveFileDialog1 to the same value we set when loading the list
        'This sets the file name in the SaveFileDialog1 to either the same list name they loaded or the 
        'file name created when the user logged in, So it's either the same as their existing file list
        'or the name assigned in "GroceryItemForm_Load" based on their User Name when they logged in
        SaveFileDialog1.FileName = basket.GroceryListFileName

        'Now set the path to the initial directory in SaveFileDialog1 to the directory path of the Grocery list the user Loaded
        'If this is a new Grocery List, this will be blank, and the user will have to browse to the directory to save their list
        SaveFileDialog1.InitialDirectory = basket.GroceryListFilePath

        'Open the SaveFileDialog1 Modally to allow user to save their Shopping list
        '"me" inthe ShowDialog method, just sets the "owner" of the SaveFileDialog1 dialog to this GroceryItemForm
        If SaveFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            'Dialog result came back as "OK", so let the user know their list was saved
            'and how many items are in the list. You could even add total cost here if you wanted.
            MessageBox.Show("Grocery List was Saved with " & basket.listArray.Count.ToString & " items in it.", "Grocery List Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        ' When this event is triggered, it means the user Specified a file in the OpenFileDialog1 dialog 
        'and clicked the "open" button, so we know it is an existing file (and hopefully a valid grocery list)

        '/// open the Grocerylist file for reading, and create a reader to read the file contents
        Dim ObjFS As System.IO.FileStream = CType(OpenFileDialog1.OpenFile, System.IO.FileStream)
        Dim ObjReader As New System.IO.StreamReader(ObjFS)

        ' clear the basket.listArray so that the list can be read in from the file
        basket.listArray.Clear()

        '/// set the GroceryListFilePath path to the Directory just opened
        basket.GroceryListFilePath = OpenFileDialog1.InitialDirectory

        '/// set the GroceryListFileName path to the Name of the file just opened
        basket.GroceryListFileName = OpenFileDialog1.FileName

        'new string array to load the comma separated lines of data into
        Dim strArr As String()

        '// now read in the basket.listArray collection from the file. 
        'Peek is used to look at the NEXT line in the file to see if one exists or if you at the end of the file
        While (ObjReader.Peek() > -1)
            'split each line at the commas to read each Grocery Item property in to the string Array, strArr
            strArr = Strings.Split(ObjReader.ReadLine(), ",")
            'check to see if a string array exists, or if it is a blank line before setting the properties of the GroceryItem Object
            If strArr IsNot Nothing Then
                'Create a new instance of an empty GroceryItem Object
                Dim TempGroceryItem As New GroceryItem
                'Fill the Object properties with the line of Item data read in and put into the strArr Array
                'All the items in strArr are string values, so Price and Aisle must be converted to their proper types
                'If not using "with" you must do the following
                'TempGroceryItem.Scan = strArr(0)
                'TempGroceryItem.Name = strArr(1)
                'TempGroceryItem.Price = CType(strArr(2), Double)
                'TempGroceryItem.Aisle = CType([Enum].Parse(GetType(Aisle), strArr(3)), Aisle)
                'TempGroceryItem.Description = strArr(4)
                'very tedious
                With TempGroceryItem
                    .Scan = strArr(0)
                    .Name = strArr(1)
                    .Price = CType(strArr(2), Double)
                    'Aisle was saved as a text string (not the number value in the Enumeration) 
                    'and must be converted into and Aisle Object using "parse"
                    'BUT, Parse only converts the string value into a generic Object, 
                    'so, "Ctype" is used to convert it into an Aisle class Object
                    .Aisle = CType([Enum].Parse(GetType(Aisle), strArr(3)), Aisle)
                    .Description = strArr(4)
                End With
                'Now add each new GroceryItem into the basket object's grocery listarray collection
                basket.listArray.Add(TempGroceryItem)
            End If
        End While
        'When all the data is read in, close the reader, then close the file stream
        ObjReader.Close()
        ObjFS.Close()
        'Now code returns to ToolStripMenuItemLoad_Click event where it left off 
        'at "OpenFileDialog1.ShowDialog(Me)" with a result of "OK"

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        'If this event is triggered it means that the user chose a path and a file nmae for their list and clicked "Save"
        'in the "SaveFileDialog1" dialog. 

        'The Directory Path and File Name were preset in the "SaveFileDialog1" dialog in the "ToolStripMenuItemSave_Click"
        'event after they clicked "Save", so the "SaveFileDialog1.FileName" property should already be set when 
        'the "SaveFileDialog1" Opens. So if the file name is blank, it's because the user erased it. So check to be safe.
        If SaveFileDialog1.FileName <> "" Then
            'Now check to see if the file exists. If the user is creating a new list, there will be no file yet,
            'so create a new file to save the list to.
            If System.IO.File.Exists(SaveFileDialog1.InitialDirectory & SaveFileDialog1.FileName) = False Then
                '/// Create a new Grocerylist file by Dimming a filestream
                Dim newfs As System.IO.FileStream
                'Now use the filestream to create a new file
                newfs = System.IO.File.Create(SaveFileDialog1.InitialDirectory & SaveFileDialog1.FileName)
                'Now close the file, because we open the, just now created, or the already existing file in the next step
                newfs.Close()
            End If

            '*******************************************************************************************
            '**** Special NOTE: Keep in mind that these values could also be written in XML format
            '**** to an XML file, then it would be easy to write a Web application to read and write
            '**** to the same XML files so you could have the same shopping list in a browser or 
            '**** phone application. All you would need is to write an AJAX call to get the data
            '**** from the XML file. Pretty COOL right?
            '*******************************************************************************************

            'Now create a new filestream and set it to the file that the user just specified in the "SaveFileDialog1"
            Dim fs As System.IO.FileStream = CType(SaveFileDialog1.OpenFile(), System.IO.FileStream)
            'Now create a SteeamWriter to write to this fileStream
            Dim sw As New System.IO.StreamWriter(fs)

            'Now go through each GroceryItem in the basket.listArray and write them to the file
            For Each item In basket.listArray
                'First check to see that the Item in the list is, 1)a GroceryItem Object 
                'and 2)that the Object value is not nothing
                If CType(item, GroceryItem) IsNot Nothing Then
                    'Now use the "GroceryItemToString" function (below) to create a comma separated string
                    'and write it to the file as a separate line in the file with the "WriteLine" method
                    sw.WriteLine(GroceryItemToString(item))
                End If
            Next
            'All Items have now been written to the file, so close the streamWriter, then close the FileStream (close the file)
            sw.Close()
            fs.Close()
        End If
        'Now code returns to ToolStripMenuItemSave_Click event where it left off 
        'at "SaveFileDialog1.ShowDialog(Me)" with a result of "OK"  

    End Sub

    Friend Function GroceryItemToString(ByVal Item As GroceryItem) As String
        'This function takes all the property values in a GroceryItem Object and writes them as one comma separated
        'string, so it can be written as one line in to the Grocery List File, when user saves the Grocery list
        'Notice that I used the "GetName" method to get the name and not the number of the Aisle, then convert it 
        'to a string to add it to the CSV file. So when you open the CSV file with Excel as a spreadsheet, you will
        'see the Aisle name instead of just a number. Useful when printing a spreadsheet or importing the CSV file
        'into a different program. NOTE* the "space underscore return" or " _" lets the programmer split line of code
        'for easier reading.
        Return Item.Scan & "," & Item.Name & "," & Item.Price.ToString & "," & _
            [Enum].GetName(GetType(Aisle), Item.Aisle).ToString & "," & Item.Description

    End Function

    Private Sub txtBrandName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBrandName.TextChanged
        'This is just added to show the user the scan Number as they type the Item name
        'otherwise the user will always only see an empty box for ScanNumber, since when
        'the user saves a Grocery Item, the foem is then immediately cleared for the next item.
        '*** Note: txtScanNumber.Text must be at least three characters first or an exception will fire
        'from the "Substring" method because the "length" argument will be "Out of range".
        'Therefore we need the If statement to check the length first
        If txtBrandName.Text.Trim.Length > 2 Then
            'This will update the txtScanNumber textBox as the user types in the ItemName textBox
            txtScanNumber.Text = txtBrandName.Text.Substring(0, 3) & "1019"
        End If

    End Sub

End Class