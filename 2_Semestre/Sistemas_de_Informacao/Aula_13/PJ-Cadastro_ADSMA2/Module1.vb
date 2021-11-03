Imports System.IO
Imports MySql.Data.MySqlClient

Module Module1
    Public resp, dir As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql, str_caminho As String
    Public cont As Integer

    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost;PORT=3306;Database=db_cadastro_si;User=root;Password=loj159951")
            MsgBox("Conexão com Mysql executada", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
        Catch ex As Exception
            MsgBox("Erro ao conectar MySQL!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Sub conectar_banco_sqlserver()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=DESKTOP-OD7S6CJ\SQLEXPRESS01;Initial Catalog=db_cadastro_si_sqlserver;trusted_connection=yes;")
            MsgBox("Conexão com SQL Server executada", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
        Catch ex As Exception
            MsgBox("Erro ao conectar SQl Server!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub
    Sub limpar_cadastro()
        Try
            With frm_clientes
                .txt_cpf.Clear()
                .txt_name.Clear()
                .txt_date.Text = Date.Now
                .txt_cep.Clear()
                .txt_address.Clear()
                .txt_complement.Clear()
                .txt_city.Clear()
                .txt_district.Clear()
                .txt_uf.Clear()
                .txt_home_phone.Clear()
                .txt_cell_phone.Clear()
                .txt_email.Clear()
                .pic_photo.Load(Application.StartupPath & "..\\img\\user.png")
                .txt_cpf.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar limpar cadastro!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub
    Sub carregar_dados()
        Try
            sql = "SELECT * FROM tb_clientes ORDER BY nome ASC"
            rs = db.Execute(sql)
            With frm_clientes.dgv_data
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0), rs.Fields(1), Nothing, Nothing)
                    rs.MoveNext()
                    cont += 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar carregar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

End Module
