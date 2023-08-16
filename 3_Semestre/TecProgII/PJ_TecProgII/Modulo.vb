Module Modulo
    Public diretorio, SQL As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset

    Sub ConectarBanco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=LAB5-11;Initial Catalog=CadastroTecProgII;trusted_connection=yes;")
            MsgBox("Conexão magna!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("ERRO | Conexão ao Banco não efetuada!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
End Module
