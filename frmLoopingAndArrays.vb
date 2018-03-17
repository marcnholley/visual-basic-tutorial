Public Class frmLoopingAndArrays
    'Marc Holley, 12/15/15, CIS159 23925, Elliot R. Cherner'
    'sub that shows messagebox'
    Private Sub btnInstructions_Click(sender As Object, e As EventArgs) Handles btnInstructions.Click
        Dim message As String
        message = "Press the Concepts button to display all of the required final project concepts." &
                  " A For Loop will access the arrays of numbers and concepts" &
                  " and output the matching index positions to the list box."
        MessageBox.Show(message, "Instructions")
    End Sub
    'sub that loads arrays, loops through their indexes, and outputs data to list box'
    Private Sub btnConcepts_Click(sender As Object, e As EventArgs) Handles btnConcepts.Click
        Dim numbers() As Integer = {1, 2, 3, 4, 5, 6, 7}
        Dim concepts() As String = {". Buttons and Textboxes", ". Looping and Arrays", ". LINQ", ". Text Files", ". Functions and Classes",
                                    ". Drop-down Lists and Listboxes", ". Graphics and how to insert graphics into a program"}
        For i As Integer = 0 To 6
            lbOutput.Items.Add(numbers(i) & concepts(i))
        Next
    End Sub
    'sub that closes program'
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub frmLoopingAndArrays_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
