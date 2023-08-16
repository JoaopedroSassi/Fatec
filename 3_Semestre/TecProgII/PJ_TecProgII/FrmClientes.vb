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
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectarBanco()
    End Sub
End Class