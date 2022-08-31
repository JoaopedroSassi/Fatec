programa
{
	
	funcao inicio()
	{
		cadeia nome, maiornome
		real nota, maiornota, cont, alunos

		cont = 1
		maiornota = 0
		maiornome = "a"
		
		escreva ("Digite quantos alunos tem na sala: ")
		leia(alunos)

		enquanto (cont <= alunos){
			escreva("Digite o nome do ", cont, "° aluno: ")
			leia(nome)

			escreva("Digite a nota desse aluno: ")
			leia (nota)

			se (nota > maiornota){
				maiornome = nome
				maiornota = nota
			}

			cont++
		}

		escreva("O aluno que tirou a maior nota foi ", maiornome, " com ", maiornota)
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 145; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */