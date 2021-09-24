dim nome, audio, opcao, nivel, palavra, resp, resp2, acertos, ach, pulos, ouvir, db, rs, cont_id, achei

dim palv_nivI(10) 
dim palv_nivII(10)
dim palv_nivIII(10)
'--------------------------------------------------

call conectar_banco
call carregar_voz
call redefinindo

Sub conectar_banco()
   set db=CreateObject("ADODB.Connection")
   db.open("Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost;PORT=3312;Database=db_vbs_spell;User=root;Password=")
   msgbox("Conexão com Mysql executada"), vbinformation + vbOKOnly, "Atenção"
End Sub ' conectar_banco

Sub carregar_voz()
   set audio=CreateObject("SAPI.SPVOICE")
   audio.volume = 100
   audio.rate = 1
End Sub ' carregar_voz

Sub redefinindo()
   palv_nivI(1) = "arroz"
   palv_nivI(2) = "teclado"
   palv_nivI(3) = "sapo"
   palv_nivI(4) = "celular"
   palv_nivI(5) = "gato"
   palv_nivI(6) = "isopor"
   palv_nivI(7) = "mesa"
   palv_nivI(8) = "cama"
   palv_nivI(9) = "perfume"
   palv_nivI(10) = "caixa"

   palv_nivII(1) = "máscara"
   palv_nivII(2) = "excel"
   palv_nivII(3) = "mouse"
   palv_nivII(4) = "álcool"
   palv_nivII(5) = "headset"
   palv_nivII(6) = "access"
   palv_nivII(7) = "sobrancelha"
   palv_nivII(8) = "quadro"
   palv_nivII(9) = "óculos"
   palv_nivII(10) = "bolsa"

   palv_nivIII(1) = "laravel"
   palv_nivIII(2) = "tupla"
   palv_nivIII(3) = "filantropo"
   palv_nivIII(4) = "pelúcia"
   palv_nivIII(5) = "travesseiro"
   palv_nivIII(6) = "jocoso"
   palv_nivIII(7) = "cônjuge"
   palv_nivIII(8) = "loquente"
   palv_nivIII(9) = "transgressão"
   palv_nivIII(10) = "quimera"

   nivel = 1
   acertos = 0
   pulos = 1
   cont = 0
   nome = ucase(InputBox("------------------------------------------" + vbNewLine & _
                   "Bem vindo ao SPELLING " + vbNewLine & _
                   "Para começar, digite seu nome: ", "Bem vindo"))
   call definindo
End Sub ' redefinindo



Sub definindo()
   ouvir = 1
   ach = false
   Do While (ach = false)
     Randomize(second(time))
     opcao = int(rnd * 10) + 1
     If ((nivel = 1) and (palv_nivI(opcao) <> "errado")) Then
         palavra = palv_nivI(opcao)
         palv_nivI(opcao) = "errado"
         call falar
         call jogo
       ElseIf ((nivel = 2) and (palv_nivII(opcao) <> "errado")) Then
            palavra = palv_nivII(opcao)
            palv_nivII(opcao) = "errado" 
            call falar
            call jogo
         ElseIf ((nivel = 3) and (palv_nivIII(opcao) <> "errado")) Then
               palavra = palv_nivIII(opcao)
               palv_nivIII(opcao) = "errado" 
               call falar
               call jogo
            Else
            End If 
   Loop
End Sub ' definindo

Sub jogo()
   resp = LCase(InputBox("------------------------------------------" + vbNewLine & _
                   "Digite a palavra que foi falada: " + vbNewLine & _
                   "Pular: " & pulos & "| Ouvir: " & ouvir & "" + vbNewLine & _
                   "================================================" + vbNewLine & _
                   "Jogador: " & nome & "| Nível: " & nivel & " | Pontuação: " & acertos & "", "Jogando"))

   If (resp = "ouvir") Then
      If (ouvir = 0) Then
         msgbox("Você não pode mais ouvir!"), vbInformation + vbOKOnly, "Grr"
         call jogo
      Else
         call falar
         ouvir = ouvir - 1
         call jogo
      End If
   ElseIf (resp = "pular") Then
      If (pulos = 0) Then
         msgbox("Você não pode mais pular!"), vbInformation + vbOKOnly, "Grr"
         call jogo
      Else
         pulos = pulos - 1
         call definindo
      End If
   end if

   If (resp = palavra) Then
      call upgrade
      msgbox("Parabéns, você acertou :D"), vbOKOnly + vbInformation, "Ebaa"
      call definindo
   Else
      call verifica_usuario
      call ranking
      resp2 = msgbox("Deseja tentar novamente?", vbQuestion + vbYesNo, "Aff")
      If (resp2 = vbyes) Then
         call redefinindo
      Else
         WScript.Quit
      End If
   End If
End Sub ' jogo

Sub upgrade()
   acertos = acertos + 1
   If (acertos => 5 and acertos < 10) Then
      nivel = 2 
   ElseIf (acertos => 10) Then
      nivel = 3
   End If

   if(acertos = 15) Then
      call vitoria
   end if
End Sub ' upgrade

Sub verifica_usuario()
   sql="select * from tb_ranking where nome='"& nome &"'"
   set rs = db.execute(sql)
   If (rs.EOF = false) Then
      achei = true
      sql="select id_jogador from tb_ranking where nome='"& nome &"'"
      set rs = db.execute(sql)
      cont_id = rs.Fields(0).value
      call select_nome
      If (acertos > rs.Fields(2).value) Then
         call inserir_ranking
      End If
   else
      achei = false
      sql="select max(id_jogador) from tb_ranking"
      set rs = db.execute(sql)
      cont_id = rs.fields(0).value + 1
      call inserir_ranking
   end if
End Sub ' verifica_usuario

Sub inserir_ranking()
   If (achei = true) Then
      sql="update tb_ranking set acertos = "& acertos &" where id_jogador="& cont_id &""
      set rs=db.Execute(sql)
   Else
      sql="insert into tb_ranking values (default, '"& nome &"', "& acertos &")"
      set rs=db.Execute(ucase(sql))
   End If
   MsgBox("Jogador adicionado ao Ranking!"), vbInformation + vbOKOnly, "Atenção"
End Sub ' inserir_ranking

Sub ranking()
   sql="select * from tb_ranking order by acertos desc"
   set rs = db.execute(sql)
   Do While (rs.EOF = false)
      MsgBox("ID: "& rs.Fields(0).value &"" + vbNewLine & _
            "Nome: "& rs.Fields(1).value & "" + vbNewLine & _
            "Acertos: "& rs.Fields(2).value &""), vbInformation + vbOKOnly, "RANKING"
   rs.movenext
   Loop
End Sub ' ranking

Sub select_nome()
   sql="select * from tb_ranking where nome='"& nome &"'"
   set rs = db.execute(sql)
End Sub ' select_nome

Sub vitoria()
   msgbox("Parabéns "& nome &", VOCÊ GANHOU AEAEAEAE" + vbNewLine & _
                 "Sua pontuação total foi de: 15" + vbNewLine & _
                 "---------------------------------------" + vbNewLine & _
                 "Estamos orgulhosos de você :p"), vbInformation + vbOKOnly, "GANHOU GANOHOU"
   call verifica_usuario
   call ranking
   resp2 = MsgBox("Deseja jogar novamente?", vbQuestion + vbYesNo, "Deseja?")
   If (resp2 = vbyes) Then
      call redefinindo
   Else
      msgbox("Ok, obrigado por jogar ;D"), vbInformation + vbOKOnly, "Até mais!"
      WScript.Quit
   End If
End Sub ' vitoria

Sub falar()
   audio.speak("A palavra é: " & palavra)
End Sub ' falar