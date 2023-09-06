Public Class Form1
    Private Sub TxtSalarios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSalarios.KeyPress
        only_number(sender, e)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectarBanco()
    End Sub
End Class
