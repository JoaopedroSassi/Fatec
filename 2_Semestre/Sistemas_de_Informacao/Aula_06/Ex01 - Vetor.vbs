dim audio, n, cor(5)

call carregar_voz

Sub carregar_voz()
   set audio=CreateObject("SAPI.SPVOICE")
   audio.volume = 100
   audio.rate = 1
   call carregar_cores
End Sub ' carregar_voz

Sub carregar_cores()
   cor(1) = "Azul"
   cor(2) = "Vermelho"
   cor(3) = "Verde"
   cor(4) = "Amarelo"
   cor(5) = "Branco"
   n = 1
   Do While (n <= 5)
      audio.speak(cor(n))
      n = n + 1
   Loop
   msgbox("Fim da leitura!"), vbInformation + vbOKOnly, "Atenção"
End Sub ' carregar_cores