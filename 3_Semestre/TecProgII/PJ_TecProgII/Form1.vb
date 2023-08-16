Public Class Form1
    Private Sub CadastroClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroClientesToolStripMenuItem.Click
        Try
            FrmClientes.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro ao abrir formulário", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        OpenProgram(sender.Tag)
    End Sub

    Private Sub ExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcelToolStripMenuItem.Click
        OpenProgram(sender.Tag)
    End Sub

    Private Sub BlocoDeNotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlocoDeNotasToolStripMenuItem.Click
        OpenProgram(sender.Tag)
    End Sub

    Public Sub OpenProgram(program As String)
        Try
            Select Case program
                Case "notepad.exe"
                    Process.Start("notepad.exe")
                Case "calc.exe"
                    Process.Start("calc.exe")
                Case "excel.exe"
                    Process.Start("excel.exe")
                Case Else
                    Throw New Exception()
            End Select
        Catch ex As Exception
            MsgBox("Erro de execução - " + program, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub
End Class
