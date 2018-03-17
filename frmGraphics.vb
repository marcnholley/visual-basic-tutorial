Public Class frmGraphics
    'Marc Holley, 12/15/15, CIS159 23925, Elliot R. Cherner'
    'declaring and intializing varibles and their starting values'
    Dim x As Integer = 1
    Dim y As Integer = 1
    'sub that sets and interval timer'
    Private Sub frmGraphics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

    End Sub
    'sub that adds or subrtracts along the x and or y axis based on specific conditions'
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If bpPap.Left <= 0 Or
                bpPap.Left >= (Me.ClientSize.Width - bpPap.Width) Then
            x = -x
        End If

        bpPap.Left += x And y

        If bpPap.Top <= 0 Or
            bpPap.Top >= (Me.ClientSize.Height - bpPap.Height) Then
            y = -y
        End If
        bpPap.Top += y And x
    End Sub
End Class
