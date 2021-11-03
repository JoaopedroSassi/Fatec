Imports MySql.Data.MySqlClient

Module Module1
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql, resp As String
    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost;PORT=3306;Database=db_cadastro-si;User=root;Password=")
            MsgBox("Conexão com Mysql executada", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
        Catch ex As Exception
            MsgBox("Erro ao conectar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub


    Sub limpar_cadastro()
        With Form1
            .txt_cpf.Clear()
            .txt_name.Clear()
            .txt_email.Clear()
            .txt_cpf.Focus()
            .btn_delete.Enabled = False
        End With
    End Sub

End Module
