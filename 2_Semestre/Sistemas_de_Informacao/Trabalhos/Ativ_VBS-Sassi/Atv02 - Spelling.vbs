dim nome, audio, opcao, nivel, palavra, resp, resp2, acertos, ach, pulos, ouvir

dim palv_nivI(11) 
dim palv_nivII(11)
dim palv_nivIII(11)
'--------------------------------------------------

call carregar_voz
call redefinindo

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
   nome = InputBox("------------------------------------------" + vbNewLine & _
                   "Bem vindo ao SPELLING " + vbNewLine & _
                   "Para começar, digite seu nome: ", "Bem vindo")
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
         call jogo
      ElseIf ((nivel = 2) and (palv_nivII(opcao) <> "errado")) Then
            palavra = palv_nivII(opcao)
            palv_nivII(opcao) = "errado" 
            call jogo
         ElseIf ((nivel = 3) and (palv_nivIII(opcao) <> "errado")) Then
               palavra = palv_nivIII(opcao)
               palv_nivIII(opcao) = "errado" 
               call jogo
            Else
            End If 
   Loop
End Sub ' definindo

Sub jogo()
   audio.speak("A palavra é: " & palavra & "")
   resp = LCase(InputBox("------------------------------------------" + vbNewLine & _
                   "Digite a palavra que foi falada: " + vbNewLine & _
                   "Pular: " & pulos & "| Ouvir: " & ouvir & "" + vbNewLine & _
                   "================================================" + vbNewLine & _
                   "Jogador: " & nome & "| Nível: " & nivel & " | Pontuação: " & acertos & "", "Jogando"))

   If (resp = "ouvir") Then
      If (ouvir = 0) Then
         msgbox("Você não pode mais pular! Você acaba de perder :)"), vbInformation + vbOKOnly, "Grr"
         call redefinindo
      Else
         ouvir = ouvir - 1
         call jogo
      End If
   ElseIf (resp = "pular") Then
      If (pulos = 0) Then
         msgbox("Você não pode mais ouvir! Você acaba de perder :)"), vbInformation + vbOKOnly, "Grr"
         call redefinindo
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
      resp2 = msgbox("Oh não, você errou!" + vbNewLine & _
                     "Pontuação: " & acertos & "| Nível: " & nivel & "" + vbNewLine & _
                     "Deseja tentar novamente?", vbQuestion + vbYesNo, "Aff")
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

Sub vitoria()
   msgbox("Parabéns "& nome &", VOCÊ GANHOU AEAEAEAE" + vbNewLine & _
                 "Sua pontuação total foi de: 15" + vbNewLine & _
                 "---------------------------------------" + vbNewLine & _
                 "Estamos orgulhosos de você :p"), vbInformation + vbOKOnly, "GANHOU GANOHOU"
   resp2 = MsgBox("Deseja jogar novamente?", vbQuestion + vbYesNo, "Deseja?")
   If (resp2 = vbyes) Then
      call redefinindo
   Else
      msgbox("Ok, obrigado por jogar ;D"), vbInformation + vbOKOnly, "Até mais!"
      WScript.Quit
   End If
End Sub ' vitoria