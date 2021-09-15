dim op, resp, exec

Call carregar_menu

Sub carregar_menu()
   set exec=CreateObject("wscript.shell")
   op = inputbox("-------------------" +vbnewline & _
                 "[G] - Gravar dados" + vbNewLine & _
                 "[C] - Consultar dados" + vbNewLine & _
                 "[F] - Finalizar Script", "Escolha uma opção")
   Select Case op
      Case "G","g"
         exec.run "C:\Users\joaop\Documents\Estudos\Fatec\2_Semestre\Sistemas_de_Informacao\Aula_08\Insert.vbs"

      Case "C","c"
         exec.run "C:\Users\joaop\Documents\Estudos\Fatec\2_Semestre\Sistemas_de_Informacao\Aula_08\read.vbs"
      
      case "F","f"
         resp = MsgBox("Deseja realmente encerrar?", vbQuestion + vbYesNo, "Atenção")
         If (resp=vbyes) Then
            WScript.Quit
         Else
            call carregar_menu
         End If

      Case Else
         msgbox("ERRO! Opção inválida"), vbExclamation + vbOKOnly, "Atenção"
         call carregar_menu
   End Select
   wscript.Quit
End Sub ' carregar_menu