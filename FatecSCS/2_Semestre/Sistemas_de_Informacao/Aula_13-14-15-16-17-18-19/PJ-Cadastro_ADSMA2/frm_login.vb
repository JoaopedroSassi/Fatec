Public Class frm_login
    Private Sub btn_criar_conta_Click(sender As Object, e As EventArgs) Handles btn_criar_conta.Click
        Try
            sql = "SELECT * FROM tb_login WHERE usuario = '" & txt_nome_us.Text & "' OR email = '" & txt_nome_us.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                MsgBox("Conta já cadastrada!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                Exit Sub
            Else
                If txt_senha.Text <> txt_confirma_senha.Text Then
                    MsgBox("Senhas não batem!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                    Exit Sub
                Else
                    sql = "INSERT INTO tb_login VALUES (default, '" & txt_nome_us.Text & "', '" & txt_email_us.Text & "', '" & txt_senha.Text & "', 'ativa', default)"
                    rs = db.Execute(sql)
                    MsgBox("Conta cadastrada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                    txt_nome_us.Clear()
                    txt_email_us.Clear()
                    txt_senha.Clear()
                    txt_confirma_senha().Clear()
                    txt_nome_us.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("ERRO! Criação de conta", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub chk_visualizar_CheckedChanged(sender As Object, e As EventArgs) Handles chk_visualizar.CheckedChanged
        If txt_senha.PasswordChar = "•" Or txt_confirma_senha.PasswordChar = "•" Then
            txt_senha.PasswordChar = ""
            txt_confirma_senha.PasswordChar = ""
        Else
            txt_senha.PasswordChar = "•"
            txt_confirma_senha.PasswordChar = "•"
        End If
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        lbl_admin.Visible = False
        If tab_control_login.TabPages.Contains(nova_conta) And tab_control_login.TabPages.Contains(manut_conta) Then
            tab_control_login.TabPages.Remove(nova_conta)
            tab_control_login.TabPages.Remove(manut_conta)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If txt_us_nome.Text = "admin" And txt_us_senha.Text = "admin" Then
                tab_control_login.TabPages.Add(nova_conta)
                tab_control_login.TabPages.Add(manut_conta)
                txt_us_nome.Clear()
                txt_us_senha.Clear()
                lbl_admin.Visible = True
                Exit Sub
            End If

            sql = "SELECT * FROM tb_login WHERE (usuario = '" & txt_us_nome.Text & "' or email = '" & txt_us_nome.Text & "') and senha = '" & txt_us_senha.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                MsgBox("Conta logada com sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                Form1.ShowDialog()
            Else
                MsgBox("Conta inválida!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar | Login", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub lbl_admin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_admin.LinkClicked
        tab_control_login.TabPages.Remove(nova_conta)
        tab_control_login.TabPages.Remove(manut_conta)
        lbl_admin.Visible = False
    End Sub
End Class