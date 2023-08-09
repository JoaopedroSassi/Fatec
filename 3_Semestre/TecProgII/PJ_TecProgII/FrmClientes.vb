Public Class FrmClientes
    Dim diretorio As String
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles ImgFoto.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma foto"
                .InitialDirectory = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\Fotos\")
                .ShowDialog()
                diretorio = .FileName
                ImgFoto.Load(diretorio)
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar a imagem", MsgBoxStyle.Critical + vbOKOnly, "Atenção")
        End Try
    End Sub
End Class