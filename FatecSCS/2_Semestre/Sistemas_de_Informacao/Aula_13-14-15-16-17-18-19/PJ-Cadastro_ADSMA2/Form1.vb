Public Class Form1
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        frm_clientes.ShowDialog()
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Shell("calc.exe")
    End Sub

    Private Sub SairDoSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairDoSistemaToolStripMenuItem.Click
        Try
            resp = MsgBox("Deseja encerrar? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")
            If resp = MsgBoxResult.Yes Then
                End
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub
End Class
