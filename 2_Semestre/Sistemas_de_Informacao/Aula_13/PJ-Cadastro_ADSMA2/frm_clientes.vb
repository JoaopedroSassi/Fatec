Public Class frm_clientes
    Private Sub pic_photo_Click(sender As Object, e As EventArgs) Handles pic_photo.Click
        Try
            With OpenFileDialog1
                .title = "Selecione uma foto"
                .InitialDirectory = "C:\Users\joaop\Documents\Estudos\Fatec\repo_fatec\2_Semestre\Sistemas_de_Informacao\Aula_13\PJ-Cadastro_ADSMA2\bin\Debug\img"
                .ShowDialog()
                dir = .FileName
                pic_photo.Load(dir)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub frm_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub
End Class