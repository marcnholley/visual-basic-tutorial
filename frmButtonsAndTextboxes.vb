Public Class frmButtonsAndTextboxes
    'Marc Holley, 12/15/15, CIS159 23925, Elliot R. Cherner'
    'sub that shows messagebox'
    Private Sub btnInstructions_Click(sender As Object, e As EventArgs) Handles btnInstructions.Click
        Dim message As String
        message = "Type anything in to the text box and press the Write button." &
                  " The text from the text box will appear in place of Write on the Write Button."
        MessageBox.Show(message, "Instructions")
    End Sub
    'sub that sends text box text property to a button text property'
    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        btnWrite.Text = tbInput.Text
    End Sub
    'sub that reset the button text property and clears the text box text property'
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        btnWrite.Text = "Write"
        tbInput.Clear()
    End Sub
    'sub that closes program'
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub
End Class
