dim n1, n2, n3, maior
dim audio

call carregar_audio
call entrada_dados

Sub carregar_audio()
    set audio=CreateObject("SAPI.SPVOICE")
    audio.volume = 100
    audio.rate = 2
End Sub 

Sub entrada_dados()
    n1 = CInt(InputBox("Digite o valor 1", "Aviso"))
    maior = n1
    n2 = CInt(InputBox("Digite o valor 2", "Aviso"))
    n3 = CInt(InputBox("Digite o valor 3", "Aviso"))

    call verifica_maior
end sub

Sub verifica_maior()
    If (n2 > maior) Then
        maior = n2
        If (n3 > maior) Then
            maior = n3
        end if
    End If
    If (n3 > maior) Then
        maior = 3
    End If

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
    audio.speak ("Você digitou os números "+ vbNewLine &_
                 "N1: " & n1 & "" + vbNewLine &_
                 "N2: " & n2 & "" + vbNewLine &_
                 "N3: " & n3 & "" + vbNewLine &_
                 "O maior valor desses foi: "& maior & "")
End Sub ' resposta_audio

sub resposta_texto()
    MsgBox("===================" + vbNewLine &_
           "O maior número" + vbNewLine &_
           "===================" + vbNewLine &_
            "N1: " & n1 & "" + vbNewLine &_
            "N2: " & n2 & "" + vbNewLine &_
            "N3: " & n3 & "" + vbNewLine &_
            "O maior valor desses foi: "& maior & ""), vbInformation + vbOKOnly, "Aviso"
end sub