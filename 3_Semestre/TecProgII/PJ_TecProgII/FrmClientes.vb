Public Class FrmClientes
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles ImgFoto.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma foto"
                .InitialDirectory = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\Fotos\")
                .ShowDialog()
                diretorio = .FileName
                ImgFoto.Load(diretorio)
            End With

            NomeArquivo = My.Computer.FileSystem.GetFileInfo(diretorio).Name
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectarBanco()
        CarregarDados()
    End Sub

    Private Sub BtnGravar_Click(sender As Object, e As EventArgs) Handles BtnGravar.Click
        Try
            SQL = "SELECT * FROM tb_usuario WHERE cpf = '" & TxtCPF.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = True Then
                SQL = "INSERT INTO tb_usuario (cpf, nome, foto) VALUES ('" & TxtCPF.Text & "', " &
                      "'" & TxtNome.Text & "', '" & NomeArquivo & "')"
                rs = db.Execute(UCase(SQL))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                TxtCPF.Clear()
                TxtNome.Clear()
                ImgFoto.Load(AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\Fotos\NovaFoto.png"))
                TxtCPF.Focus()
                CarregarDados()
            Else
                MsgBox("ERRO | CPF já cadastrado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("ERRO | Registro não foi salvo no banco!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub TxtCPF_LostFocus(sender As Object, e As EventArgs) Handles TxtCPF.LostFocus
        Try
            SQL = "SELECT * FROM tb_usuario WHERE cpf = '" & TxtCPF.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = False Then
                TxtNome.Text = rs.Fields(2).Value
                ImgFoto.Load(AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\Fotos\" & rs.Fields(3).Value & ""))
            Else
                TxtNome.Focus()
            End If
        Catch ex As Exception
            MsgBox("ERRO | Consulta ao CPF no banco!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub TxtCPF_DoubleClick(sender As Object, e As EventArgs) Handles TxtCPF.DoubleClick
        TxtCPF.Clear()
        TxtNome.Clear()
        ImgFoto.Load(AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\Fotos\NovaFoto.png"))
        TxtCPF.Focus()
    End Sub
End Class