dim n1, n2, n3
dim audio

call carregar_audio
call entrada_dados

Sub carregar_audio()
    set audio=CreateObject("SAPI.SPVOICE")
    audio.volume = 100
    audio.rate = 2
End Sub 

Sub entrada_dados()
    n1 = CInt(InputBox("Digite o valor ", "Aviso"))
    call calcula_valores
end sub

Sub calcula_valores()
    n2 = n1 + 1
    n3 = n1 - 1
    call verifica_audio
End Sub 

Sub verifica_audio()
    resp = MsgBox("Deseja ter a resposta por som?", vbQuestion + vbYesNo, "Atenção")
    If (resp = vbyes) Then
        call resposta_audio
    Else
        call resposta_texto
    End If
End Sub 

Sub resposta_audio()
    audio.speak ("Você digitou o número"+ vbNewLine &_
                 "N1: " & n1 & "" + vbNewLine &_
                 "O sucessor dele é: " & n2 & "" + vbNewLine &_
                 "O antecessor dele é: " & n3 & "")
End Sub ' resposta_audio

sub resposta_texto()
    MsgBox("===================" + vbNewLine &_
           "Sucessor e Antecessor" + vbNewLine &_
           "===================" + vbNewLine &_
            "N1: " & n1 & "" + vbNewLine &_
            "O Sucessor: " & n2 & "" + vbNewLine &_
            "O Antecessor: " & n3 & ""), vbInformation + vbOKOnly, "Aviso"
end sub