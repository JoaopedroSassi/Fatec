dim cor, op, resp

Call inicio

Sub inicio()
    op = CInt(InputBox("[1] - Verde" + vbNewLine & _
                       "[2] - Amarelo" + vbNewLine & _
                       "[3] - Vermelho" + vbNewLine & _
                       "[0 ou 10] - Encerrar o Script", "Cores do Sem�foro"))
    Select Case op
        Case 1
            cor = "Verde -> Siga em frente"
        case 2
            cor = "Amarelo -> Aten��o"
        case 3
            cor = "Vermelho -> Pare!!!"
        case 0,10
            resp = msgbox("Deseja encerrar o Script?", vbQuestion + vbYesNo, "Aten��o")
            If resp=vbyes Then
                WScript.Quit
            End If
        Case Else
            msgbox("Op��o inv�lida!!!!"), vbExclamation + vbOKOnly, "Aten��o"
            call inicio
    End Select
    msgbox("Voc� selecionou: "& cor &""), vbInformation+vbOKOnly, "Aten��o"
    call inicio
End Sub ' inicio