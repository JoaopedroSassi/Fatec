Module Modulo
    Public diretorio, SQL As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset

    Sub ConectarBanco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=LAB5-13;Initial Catalog=DbSalario;trusted_connection=yes;")
            'MsgBox("Conexão com o banco efeituada com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("ERRO | Conexão ao Banco não efetuada!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Public Sub only_number(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
End Module
