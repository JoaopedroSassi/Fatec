dim num1, num2, op, opera, result, resp, pontos, opcao

call definir_variaveis

Sub definir_variaveis()
   pontos = 0
   result = 0
   call jogo
End Sub ' definir_variaveis

Sub jogo()
   Randomize(second(time))
   num1 = int(rnd * 10) + 1
   num2 = int(rnd * 10) + 1
   op = int(rnd * 3) + 1

   Select Case op
    Case 1
        result = num1+num2
        opera = "+"
    case 2:
        result = num1-num2
        opera = "-"
    case 3
        result = num1*num2
        opera = "*"
    Case Else
        result = num1+num2
        opera = "+"
   End Select

   opcao = Cint(InputBox("------------Jogo Matemático----------" + vbnewline & _
                        "Digite o resultado da expressão: " & num1 & opera & num2 & "" + vbnewline & _
                        "--------------------------------------" + vbnewline & _
                        "Pontos atuais: " & pontos & "", "Aviso"))   
   If (opcao = result) Then
      pontos = pontos + 1
      msgbox("Parabéns, você acertou!" + vbnewline & _
            "Pontos: " & pontos & ""), vbExclamation + vbOKOnly, "Aviso"
      call jogo
   Else
      msgbox("Oh não, você errou :(" + vbnewline & _
            "Pontos: " & pontos & ""), vbExclamation + vbOKOnly, "Aviso"
      resp = msgbox("Deseja tentar novamente?", vbQuestion + vbYesNo, "Atenção")
      If (resp = vbYes) Then
         call definir_variaveis
      Else
         WScript.Quit
      End If
   End If
End Sub ' jogo