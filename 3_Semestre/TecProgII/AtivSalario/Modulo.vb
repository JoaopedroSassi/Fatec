Module Modulo
    Public diretorio, SQL, NomeArquivo As String
    Public IdUsuario As Integer
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset

    Sub ConectarBanco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=localhost, 1433;Initial Catalog=DbSalario;User ID=sa;Password=@Sql012210;")
            'MsgBox("Conexão com o banco efeituada com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("ERRO | Conexão ao Banco não efetuada!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Public Sub only_number(sender As Object, e As KeyPressEventArgs)
        If (Not Char.IsDigit(e.KeyChar)) AndAlso (e.KeyChar <> ","c) AndAlso (e.KeyChar <> "."c) AndAlso (e.KeyChar <> ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub

    Sub LimparDados()
        Form1.TxtNome.Text = ""
        Form1.CmbCargo.SelectedIndex = -1
        Form1.TxtSalarios.Text = ""
        Form1.TxtBruto.Text = ""
        Form1.TxtLiquido.Text = ""
        Form1.TxtINSS.Text = ""
        Form1.DtpData.Value = Date.Now

        Dim caminho = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\net6.0-windows", "\Img\NovaFoto.png")
        Form1.PicFoto.Load(caminho.Remove(caminho.Length - 1, 1))
    End Sub
End Module
