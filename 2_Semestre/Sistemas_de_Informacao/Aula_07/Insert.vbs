dim db, rs, ent_cpf, ent_nome, ent_idade, resp

call conectar_banco

Sub conectar_banco()
   resp = cint(InputBox("[1] Mysql" + vbNewLine & _
                        "[2] Encerrar o programa", "Escolha a conexão"))
   
   Select Case resp
      Case 1
         set db=CreateObject("ADODB.Connection")
         db.open("Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost;PORT=3312;Database=vbs_aula07;User=root;Password=")
         msgbox("Conexão com Mysql executada"), vbinformation + vbOKOnly, "Atenção"
      case 2
         resp = msgbox("Deseja encerrar o Script?", vbQuestion + vbYesNo, "Aviso")
         If (resp = vbyes) Then
            WScript.quit
         Else
            call conectar_banco
         End If
      Case Else
         MsgBox("Opção inválida!"), vbExclamation + vbOKOnly, "Atenção"
         call conectar_banco
   End Select
   call gravar_dados
End Sub ' conectar_banco

Sub gravar_dados()
   ent_cpf = InputBox("Digite o CPF do cliente", "Cadastro de Clientes")
   ent_nome = InputBox("Digite o nome do cliente", "Cadastro de Clientes")
   ent_idade = cint(InputBox("Digite a idade cliente", "Cadastro de Clientes"))

   sql="select * from tb_cadastro where CPF='"& ent_cpf &"'"
   set rs = db.execute(sql)
   If (rs.EOF = false) Then
      msgbox("ERRO: CPF já cadastrado"), vbExclamation + vbOKOnly, "Aviso"
      call gravar_dados
   Else
      sql="insert into tb_cadastro values('"& ent_cpf &"', '"& ent_nome &"', "& ent_idade &")"
      set rs=db.Execute(ucase(sql))
      MsgBox("Cliente cadastrado com sucesso!"), vbInformation + vbOKOnly, "Atenção"
   End If   
   call continuar
End Sub ' gravar_dados

Sub continuar()
   resp = msgbox("Deseja cadastrar um novo cliente no mesmo BD?", vbQuestion + vbYesNo, "Atenção")

   If (resp = vbyes) Then
      call gravar_dados
   Else
      call conectar_banco
   End If
End Sub ' continuar