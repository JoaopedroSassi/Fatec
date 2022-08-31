dim inicial, final, passo

call inicio

Sub inicio()
   inicial = CInt(InputBox("Digite o número inicial!", "Inicial"))
   final = CInt(InputBox("Digite o número final!", "Final al al"))
   passo = CInt(InputBox("Digite o passo!", "pa-aaso"))

   For i=inicial To final step passo
      MsgBox(i)
   Next 'i
End Sub ' inicio