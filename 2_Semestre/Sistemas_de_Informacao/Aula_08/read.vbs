dim db, rs, ent_cpf, ent_nome, ent_idade, resp, exec

call conectar_banco

Sub conectar_banco()
   resp = cint(InputBox("[1] Mysql" + vbNewLine & _
                        "[2] Retornar ao menu", "Escolha a conexão"))
   
   Select Case resp
      Case 1
         set db=CreateObject("ADODB.Connection")
         db.open("Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost;PORT=3312;Database=db_VBS;User=root;Password=")
         msgbox("Conexão com Mysql executada"), vbinformation + vbOKOnly, "Atenção"
      case 2
         resp = msgbox("Deseja retornar ao menu?", vbQuestion + vbYesNo, "Aviso")
         If (resp = vbyes) Then
            set exec=CreateObject("wscript.shell")
            exec.run "C:\Users\joaop\Documents\Estudos\Fatec\2_Semestre\Sistemas_de_Informacao\Aula_08\menu.vbs"
            WScript.Quit
         Else
            call conectar_banco
         End If
      Case Else
         MsgBox("Opção inválida!"), vbExclamation + vbOKOnly, "Atenção"
         call conectar_banco
   End Select
   call consultar_dados
End Sub ' conectar_banco

Sub consultar_dados()
   ent_cpf = InputBox("Digite o CPF do cliente", "Cadastro de Clientes")

   sql="select * from tb_cadastro where CPF='"& ent_cpf &"'"
   set rs = db.execute(sql)
   If (rs.EOF = false) Then
      MsgBox("CPF do Cliente: "& rs.Fields(0).value &"" + vbNewLine & _
             "Nome do Cliente: "& rs.Fields(1).value & "" + vbNewLine & _
             "Idade do Cliente: "& rs.Fields(2).value &""), vbInformation + vbOKOnly, "Consulta de clientes por CPF"
   Else
      MsgBox("CPF: '"& ent_cpf &"'não localizado!!!"), vbInformation + vbOKOnly, "Aviso"
   End If   
   call continuar
End Sub ' consultar_dados

Sub continuar()
   resp = msgbox("Deseja realizar uma nova consulta no mesmo BD?", vbQuestion + vbYesNo, "Atenção")
   If (resp = vbyes) Then
      call consultar_dados
   Else
      call conectar_banco
   End If
End Sub ' continuar