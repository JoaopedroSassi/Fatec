dim inicial, final, passo

call inicio

Sub inicio()
   inicial = CInt(InputBox("Digite o n�mero inicial!", "Inicial"))
   final = CInt(InputBox("Digite o n�mero final!", "Final al al"))
   passo = CInt(InputBox("Digite o passo!", "pa-aaso"))

   For i=inicial To final step passo
      MsgBox(i)
   Next 'i
End Sub ' inicio