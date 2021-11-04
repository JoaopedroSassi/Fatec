Public Class frm_clientes
    Private Sub pic_photo_Click(sender As Object, e As EventArgs) Handles pic_photo.Click
        Try
            With OpenFileDialog1
                .title = "Selecione uma foto"
                .InitialDirectory = Application.StartupPath & "..\img\"
                .ShowDialog()
                dir = .FileName
                replace()
                pic_photo.Load(dir)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub frm_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_dados()
    End Sub

    Private Sub txt_cep_LostFocus(sender As Object, e As EventArgs) Handles txt_cep.LostFocus
        Try
            sql = "SELECT * FROM tb_cep WHERE cep = '" & txt_cep.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_address.Text = rs.Fields(1).Value
                txt_city.Text = rs.Fields(2).Value
                txt_district.Text = rs.Fields(3).Value
                txt_uf.Text = rs.Fields(4).Value
                txt_complement.Focus()
            Else
                MsgBox("CEP: " & txt_cep.Text & "não localizado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
            End If
        Catch ex As Exception
            MsgBox("ERRO! Conexão mal sucedida!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        Try
            If txt_cpf.Text = "" Or
               txt_date.Text = "" Or
               txt_name.Text = "" Or
               txt_cep.Text = "" Or
               txt_address.Text = "" Or
               txt_complement.Text = "" Or
               txt_city.Text = "" Or
               txt_district.Text = "" Or
               txt_uf.Text = "" Or
               txt_home_phone.Text = "" Or
               txt_cell_phone.Text = "" Or
               txt_email.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                txt_cpf.Focus()
            Else
                sql = "INSERT INTO tb_clientes VALUES ('" & txt_cpf.Text & "', '" & txt_name.Text & "', '" & txt_date.Text & "', '" & txt_address.Text & "', '" & txt_complement.Text & "', '" & txt_district.Text & "',  '" & txt_city.Text & "',  '" & txt_uf.Text & "', '" & txt_cep.Text & "','" & txt_home_phone.Text & "', '" & txt_cell_phone.Text & "', '" & txt_email.Text & "', '" & dir & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados cadastrados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                limpar_cadastro()
                carregar_dados()
            End If
        Catch ex As Exception
            MsgBox("ERRO! Conexão mal sucedida!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        'Try
        sql = "SELECT * FROM tb_clientes WHERE cpf = '" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                txt_name.Focus()
            Else
                txt_name.Text = rs.Fields(1).Value
                txt_date.Text = rs.Fields(2).Value
                txt_address.Text = rs.Fields(3).Value
                txt_complement.Text = rs.Fields(4).Value
                txt_district.Text = rs.Fields(5).Value
                txt_city.Text = rs.Fields(6).Value
                txt_uf.Text = rs.Fields(7).Value
                txt_cep.Text = rs.Fields(8).Value
                txt_home_phone.Text = rs.Fields(9).Value
                txt_cell_phone.Text = rs.Fields(10).Value
                txt_email.Text = rs.Fields(11).Value
                pic_photo.Load(rs.Fields(12).Value)
            End If
        'Catch ex As Exception
        'MsgBox("Erro ao processar cpf_lostfocus!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        'End Try
    End Sub

    Private Sub txt_cpf_DoubleClick(sender As Object, e As EventArgs) Handles txt_cpf.DoubleClick
        limpar_cadastro()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Try
            sql = "SELECT * FROM tb_clientes WHERE nome LIKE '" & txt_search.Text & "%' ORDER BY nome ASC"
            rs = db.Execute(sql)
            With dgv_data
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0), rs.Fields(1), Nothing, Nothing)
                    rs.MoveNext()
                    cont += 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar text_change!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub
End Class