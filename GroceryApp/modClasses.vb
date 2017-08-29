﻿Module modClasses

#Region "Aisle Enumeration"
    Public Enum Aisle
        Bakery
        CannedGood
        Drinks
        Deli
        DryGoods
        FrozenFood
        Produce
    End Enum
#End Region

#Region "Class Grocery Item"
    Public Class GroceryItem

        Public Property Scan As String
        Public Property Name As String
        Public Property Price As Double
        Public Property Aisle As Aisle
        Public Property Description As String

    End Class
#End Region

#Region "Class Grocery Basket"
    Public Class GroceryBasket

        'User Name of the Logged In User
        Public Property UserName As String

        ' Collection of Grocery Items. New Collection mjst be defined for each instance of this object
        Friend listArray As New Collection

        'Customized Grocery List File Name for each specific user
        Friend Property GroceryListFileName As String

        'Customized Grocery List File Path for each specific user
        Friend Property GroceryListFilePath As String

        ' Method for adding Grocery Items to the list
        Friend Sub Add(ByRef NewItem As GroceryItem)
            listArray.Add(NewItem)
        End Sub

        ' ********* This Method no longer used... Replaced by Basket Display Form ************

        '' Method for Building the string to View 
        'Friend Function View() As String
        '    'Create a new String Builder Object to append list items to the View of the list
        '    Dim sb As New System.Text.StringBuilder
        '    '' Make nice formatted headers
        '    If Me.UserName = "" Then
        '        sb.AppendLine("Here is the list of Items in your Grocery Basket:")
        '    Else
        '        sb.AppendLine(Me.UserName + ", Here is your Grocery Basket:")
        '    End If
        '    'format list into three columns(0,1,2) of widths(15,20,20) and insert the column headers
        '    sb.AppendLine(String.Format("{0,-15}{1,-20}{2,-20}", "Aisle ", "Scan Number", "Brand Name"))
        '    sb.AppendLine("-------------------------------------------------------")
        '    ' Now add the list of Items in a nice format to the String builder
        '    For Each itm As GroceryItem In listArray
        '        'format list into three columns(0,1,2) of widths(15,20,20) and convert Aisle Name back to name from Aisle Number
        '        sb.AppendLine(String.Format("{0,-15}{1,-20}{2,-20}", [Enum].GetName(GetType(Aisle), itm.Aisle), itm.Scan, itm.Name))
        '    Next
        '    'Output string is now built from string builder object, convert to string and return to form
        '    Return sb.ToString()
        'End Function

    End Class
#End Region
   
#Region "Class Login Exception"
    'Currently Not Used, because it causes an exception error and kills the Application
    'Better to create an ErrorLog class that writes to an ErrorLog file and capture 
    'exceptions in a "try...catch" and log the exception andinform the user, 
    'instead of letting the program fail 
    Class LoginException
        Inherits Exception

        Public Sub New()
            MessageBox.Show("Login Incorrect, Please try again", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Sub

    End Class
#End Region
    
End Module
