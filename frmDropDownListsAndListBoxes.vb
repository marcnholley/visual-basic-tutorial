Public Class frmDropDownListsAndListBoxes
    'Marc Holley, 12/15/15, CIS159 23925, Elliot R. Cherner'
    'sub that shows messagebox'
    Private Sub btnInstructions_Click(sender As Object, e As EventArgs) Handles btnInstructions.Click
        Dim message As String
        message = " Select a number from the drop down list." &
                  " The numbers correpsond to each concept required in the tutorial." &
                  " Press the show button to display the concept in the list box. " &
                  " Press the clear button to reset the number from the drop down list " &
                  " and the erase the concept in the list box."
        MessageBox.Show(message, "Instructions")
    End Sub
    'sub that adds specific data to the list box based on the selected index from the combo box'
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click

        If cbNumber.SelectedIndex = 0 Then
            lbConcepts.Items.Add("Buttons and Text Boxes")

        ElseIf cbNumber.SelectedIndex = 1 Then
            lbConcepts.Items.Add("Looping and Arrays")

        ElseIf cbNumber.SelectedIndex = 2 Then
            lbConcepts.Items.Add("LINQ")

        ElseIf cbNumber.SelectedIndex = 3 Then
            lbConcepts.Items.Add("Text Files")

        ElseIf cbNumber.SelectedIndex = 4 Then
            lbConcepts.Items.Add("Functions and Classes")

        ElseIf cbNumber.SelectedIndex = 5 Then
            lbConcepts.Items.Add("Drop-down Lists and List Boxes")

        ElseIf cbNumber.SelectedIndex = 6 Then
            lbConcepts.Items.Add("Graphics and how to insert them in to a program")
        End If
    End Sub
    'sub that clears index and list box'
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cbNumber.SelectedIndex = -1
        lbConcepts.Items.Clear()
    End Sub
    'sub that closes program'
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub
End Class
