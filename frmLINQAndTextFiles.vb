Public Class frmLINQAndTextFiles
    'Marc Holley, 12/15/15, CIS159 23925, Elliot R. Cherner'
    'sub that shows messagebox'
    Private Sub btnInstructions_Click(sender As Object, e As EventArgs) Handles btnInstructions.Click
        Dim message As String
        message = "Press the Concepts button to display all of the required final project concepts." &
                  " A LINQ query will access the concepts.txt file located in the bin/debug subfolder" &
                  " and output it formatted in the data grid view box."
        MessageBox.Show(message, "Instructions")
    End Sub
    'sub that loads array and sends query to a txt file that chooses what and how to output to datagridview.
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnConcepts.Click
        Dim concepts() As String = IO.File.ReadAllLines("concepts.txt")
        Dim query = From line In concepts
                    Let number = (CInt(line.Split(","c)(0))).ToString("N0")
                    Let concept = line.Split(","c)(1)
                    Order By number Ascending
                    Select number, concept
        dgvOutput.DataSource = query.ToList
        dgvOutput.CurrentCell = Nothing
        dgvOutput.Columns("number").HeaderText = "Number"
        dgvOutput.Columns("concept").HeaderText = "Concept"
    End Sub
    'sub that closes program'
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub frmLINQAndTextFiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
