dim cor, op, resp

Call inicio

Sub inicio()
    op = CInt(InputBox("[1] - Verde" + vbNewLine & _
                       "[2] - Amarelo" + vbNewLine & _
                       "[3] - Vermelho" + vbNewLine & _
                       "[0 ou 10] - Encerrar o Script", "Cores do Semáforo"))
    Select Case op
        Case 1
            cor = "Verde -> Siga em frente"
        case 2
            cor = "Amarelo -> Atenção"
        case 3
            cor = "Vermelho -> Pare!!!"
        case 0,10
            resp = msgbox("Deseja encerrar o Script?", vbQuestion + vbYesNo, "Atenção")
            If resp=vbyes Then
                WScript.Quit
            End If
        Case Else
            msgbox("Opção inválida!!!!"), vbExclamation + vbOKOnly, "Atenção"
            call inicio
    End Select
    msgbox("Você selecionou: "& cor &""), vbInformation+vbOKOnly, "Atenção"
    call inicio
End Sub ' inicio