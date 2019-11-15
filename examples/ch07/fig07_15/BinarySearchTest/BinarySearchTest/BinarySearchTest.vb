﻿' Fig. 7.15: BinarySearchTest.vb
' Binary search of an array using Array.BinarySearch.
Public Class BinarySearchTest
   Dim searchData(19) As Integer ' create 20-element array
   Dim randomNumber As New Random()

   ' create random data and display it
   Private Sub createDataButton_Click(sender As Object,
      e As EventArgs) Handles createDataButton.Click

      ' create random array elements
      For i = 0 To searchData.GetUpperBound(0)
         searchData(i) = randomNumber.Next(1000)
      Next

      Array.Sort(searchData) ' sort array to enable binary searching 

      ' display sorted array elements
      dataListBox.Items.Add("Index" & vbTab & "Value")

      For i = 0 To searchData.GetUpperBound(0)
         dataListBox.Items.Add(i & vbTab & searchData(i))
      Next

      searchKeyTextBox.Clear() ' clear search key text box
      searchButton.Enabled = True ' enable search button
   End Sub ' createDataButton_Click

   ' search array for search key 
   Private Sub searchButton_Click(sender As Object,
      e As EventArgs) Handles searchButton.Click

      ' if search key text box is empty, display 
      ' message and exit method
      If searchKeyTextBox.Text = String.Empty Then
         MessageBox.Show("You must enter a search key.", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
         Exit Sub
      End If

      Dim searchKey As Integer = Convert.ToInt32(searchKeyTextBox.Text)
      Dim index As Integer = Array.BinarySearch(searchData, searchKey)

      If index >= 0 Then
         resultLabel.Text = "Found Value in index " & index
      Else
         resultLabel.Text = "Value Not Found"
      End If
   End Sub ' searchButton_Click
End Class ' BinarySearchTest



' **************************************************************************
' * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
' * Pearson Education, Inc. All Rights Reserved.                           *
' *                                                                        *
' * DISCLAIMER: The authors and publisher of this book have used their     *
' * best efforts in preparing the book. These efforts include the          *
' * development, research, and testing of the theories and programs        *
' * to determine their effectiveness. The authors and publisher make       *
' * no warranty of any kind, expressed or implied, with regard to these    *
' * programs or to the documentation contained in these books. The authors *
' * and publisher shall not be liable in any event for incidental or       *
' * consequential damages in connection with, or arising out of, the       *
' * furnishing, performance, or use of these programs.                     *
' **************************************************************************