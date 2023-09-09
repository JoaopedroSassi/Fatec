Public Class Form1
    Private Sub TxtSalarios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSalarios.KeyPress
        only_number(sender, e)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectarBanco()
        CarregarDados()
        IdUsuario = -1
    End Sub

    Sub CarregarDados()
        Try
            SQL = "SELECT * FROM TbFuncionario ORDER BY nome ASC"
            rs = db.Execute(SQL)
            With DgvDados
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(5).Value, rs.Fields(6).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub PicFoto_Click(sender As Object, e As EventArgs) Handles PicFoto.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma foto"
                .InitialDirectory = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\net6.0-windows", "\Fotos\")
                .ShowDialog()
                diretorio = .FileName
                PicFoto.Load(diretorio)
            End With

            NomeArquivo = My.Computer.FileSystem.GetFileInfo(diretorio).Name
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Try
            Dim dataAdmissao = DtpData.Value.ToString("dd/MM/yyyy")
            Dim bruto = TxtBruto.Text.Replace(",", ".")
            Dim liquido = TxtLiquido.Text.Replace(",", ".")
            Dim inss = TxtINSS.Text.Replace(",", ".")
            Dim qtdeSalarios = TxtSalarios.Text.Replace(",", ".")

            If IdUsuario = -1 Then
                SQL = $"INSERT INTO TbFuncionario (nome, cargo, caminhoFoto, dataAdmissao, salarioBruto, salarioLiquido, INSS, QtdeSalarios) VALUES ('{TxtNome.Text}', '{CmbCargo.Text}', '{NomeArquivo}', '{dataAdmissao}', '{bruto}', '{liquido}', '{inss}', '{qtdeSalarios}')"
                rs = db.Execute(SQL)
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                SQL = $"UPDATE TbFuncionario SET nome ='{TxtNome.Text}', cargo ='{CmbCargo.Text}', caminhoFoto='{NomeArquivo}', dataAdmissao='{dataAdmissao}', salarioBruto='{bruto}', salarioLiquido='{liquido}', INSS='{inss}', QtdeSalarios='{qtdeSalarios}' WHERE id = {IdUsuario}"
                rs = db.Execute(SQL)
                MsgBox("Dados atualizados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If

            IdUsuario = -1
            LimparDados()
            TxtNome.Focus()
            CarregarDados()
        Catch ex As Exception
            MsgBox("ERRO | Registro não foi salvo no banco!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub TxtSalarios_Leave(sender As Object, e As EventArgs) Handles TxtSalarios.Leave
        Dim bruto As Double = TxtSalarios.Text * 1320.0
        Dim inss As Double = 0
        If bruto >= 1630 Then
            inss = bruto * 0.11
        End If
        Dim liquido As Double = bruto - inss

        TxtBruto.Text = bruto.ToString("N2")
        TxtINSS.Text = inss.ToString("N2")
        TxtLiquido.Text = liquido.ToString("N2")
    End Sub

    Private Sub DgvDados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDados.CellContentClick
        With DgvDados
            If .CurrentRow.Cells(5).Selected Then
                SQL = $"SELECT * FROM TbFuncionario WHERE id={ .CurrentRow.Cells(0).Value}"
                rs = db.Execute(SQL)

                TxtNome.Text = rs.Fields(1).Value
                CmbCargo.Text = rs.Fields(2).Value
                DtpData.Value = rs.Fields(4).Value

                Dim caminho = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\net6.0-windows", $"\Fotos\{rs.Fields(3).Value}")
                PicFoto.Load(caminho.Remove(caminho.Length - 1, 1))

                TxtSalarios.Text = rs.Fields(8).Value
                TxtBruto.Text = rs.Fields(5).Value
                TxtLiquido.Text = rs.Fields(6).Value
                TxtINSS.Text = rs.Fields(7).Value
                IdUsuario = rs.Fields(0).Value
            End If

            If .CurrentRow.Cells(6).Selected Then
                Dim idUser = .CurrentRow.Cells(0).Value
                Dim resposta As DialogResult = MessageBox.Show($"Deseja excluir o registro de id: {idUser}?", "Aviso", MessageBoxButtons.YesNo)
                If resposta = DialogResult.No Then
                ElseIf resposta = DialogResult.Yes Then
                    SQL = $"DELETE FROM TbFuncionario WHERE id={idUser}"
                    rs = db.Execute(SQL)
                    MsgBox("Registro excluído com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    CarregarDados()
                End If
            End If
        End With
        TabPages.SelectedTab = TabPages.TabPages(0)
    End Sub
End Class
