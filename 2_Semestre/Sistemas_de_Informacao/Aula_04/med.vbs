'Comentario em VBCsript
dim n1, n2, n3, media, resp, situacao
dim audio

call carregar_audio
call entrada_notas

Sub carregar_audio()
    set audio=CreateObject("SAPI.SPVOICE")
    audio.volume = 100
    audio.rate = 2
End Sub 

Sub entrada_notas()
    n1 = CDbl(InputBox("Digite a nota 1", "Aviso"))
    n2 = CDbl(InputBox("Digite a nota 2", "Aviso"))
    n3 = CDbl(InputBox("Digite a nota 3", "Aviso"))
    media = Round((n1 + n2 + n3) / 3, 1)
    If (media < 4) Then
        situacao = "Reprovado"
    ElseIf ((media >= 4) and (media < 6)) Then
        situacao = "Exame"
    Else 
        situacao = "Aprovado"    
    End If

    audio.speak ("Rendimento do aluno" + vbNewLine &_
                 "M�dia do aluno: " & media & "" + vbNewLine &_
                 "Situa��o do Aluno: "& situacao & "")

    MsgBox("===================" + vbNewLine &_
           "Rendimento do Aluno" + vbNewLine &_
           "===================" + vbNewLine &_
           "M�dia do Aluno: " & media & "" + vbNewLine &_
           "Situa��o do Aluno:" & situacao & ""), vbInformation + vbOKOnly, "Aviso"
    call pergunta
End Sub 

sub pergunta()
    resp=MsgBox("Deseja realizar um novo c�lculo?", vbQuestion + vbYesNo, "Aten��o")
    If (resp = vbyes) Then
        call entrada_notas
    Else
        WScript.Quit
    End If
end sub