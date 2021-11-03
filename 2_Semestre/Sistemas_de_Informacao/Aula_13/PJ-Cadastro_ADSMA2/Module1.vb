Imports MySql.Data.MySqlClient

Module Module1
    Public resp, dir As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql As String

    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost;PORT=3306;Database=db_cadastro_si;User=root;Password=loj159951")
            MsgBox("Conexão com Mysql executada", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
        Catch ex As Exception
            MsgBox("Erro ao conectar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Sub conectar_banco_sqlserver()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=DESKTOP-OD7S6CJ\SQLEXPRESS01;Initial Catalog=db_cadastro_si_sqlserver;trusted_connection=yes;")
            MsgBox("Conexão com SQL Server executada", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
        Catch ex As Exception
            MsgBox("Erro ao conectar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub
End Module
