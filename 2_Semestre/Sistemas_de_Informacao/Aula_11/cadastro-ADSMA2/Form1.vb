Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub
    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        Try
            sql = "select * from tb_cliente where cpf = '" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                MsgBox("CPF Já cadastrado!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
                limpar_cadastro()
            Else
                sql = "insert into tb_cliente values ('" & txt_cpf.Text & "', '" & txt_name.Text & "', '" & txt_email.Text & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados gravados com sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                limpar_cadastro()
            End If
        Catch ex As Exception
            MsgBox("Erro ao Processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub
End Class
