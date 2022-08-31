Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub
    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        Try
            sql = "select * from tb_cliente where cpf = '" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "update tb_cliente set nome= '" & txt_name.Text & "', email='" & txt_email.Text & "' where cpf = '" & txt_cpf.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
            Else
                sql = "insert into tb_cliente values ('" & txt_cpf.Text & "', '" & txt_name.Text & "', '" & txt_email.Text & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados gravados com sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
            End If
            limpar_cadastro()
        Catch ex As Exception
            MsgBox("Erro ao Processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click
        Try
            sql = "select * from tb_cliente where cpf = '" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If (rs.EOF = False) Then
                txt_name.Text = rs.Fields(1).Value
                txt_email.Text = rs.Fields(2).Value
                btn_delete.Enabled = True
            Else
                MsgBox("CPF: '" & txt_cpf.Text & "' não localizado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
            End If
        Catch ex As Exception
            MsgBox("Erro ao Processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub txt_cpf_DoubleClick(sender As Object, e As EventArgs) Handles txt_cpf.DoubleClick
        limpar_cadastro()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            sql = "select * from tb_cliente where cpf = '" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If (rs.EOF = False) Then
                resp = MsgBox("Deseja realmente excluir o cadastro de cpf: " & txt_cpf.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")
                If (resp = MsgBoxResult.Yes) Then
                    sql = "delete from tb_cliente where cpf = '" & txt_cpf.Text & "'"
                    rs = db.Execute(sql)
                    MsgBox("Registro excluído com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                    limpar_cadastro()
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao Processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub
    Private Sub txt_cpf_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_cpf.MaskInputRejected
        'sql = "select * from tb_cliente where cpf = '" & txt_cpf.Text & "'"
        'rs = db.Execute(sql)
        'If (rs.EOF = False) Then
        'btn_delete.Enabled = True
        'Else
        'btn_delete.Enabled = False
        'End If
    End Sub
End Class
