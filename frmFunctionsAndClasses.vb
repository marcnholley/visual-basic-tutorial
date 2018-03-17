Public Class frmFunctionsAndClasses
    'Marc Holley, 12/15/15, CIS159 23925, Elliot R. Cherner'
    'sub that shows message box'
    Private Sub btnInstructions_Click(sender As Object, e As EventArgs) Handles btnInstructions.Click
        Dim message As String
        message = " Select a number from the drop down list." &
                  " The numbers correpsond to each concept required in the tutorial." &
                  " Press the show button to display the concept in the list box. " &
                  " Press the clear button to reset the number from the drop down list" &
                  " and the erase the concept in the list box."
        MessageBox.Show(message, "Instructions")
    End Sub
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        'call to class and function'
        Number.Numbers()
    End Sub
    'sub that reset index and list box'
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cbNumber.SelectedIndex = -1
        lbOutput.Items.Clear()
    End Sub
    'sub that closes program'
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub frmFunctionsAndClasses_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
