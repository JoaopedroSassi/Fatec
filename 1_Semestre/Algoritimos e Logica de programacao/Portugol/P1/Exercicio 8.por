programa
{
	
	funcao inicio()
	{
		real res = 0.00, n1, n2
		caracter operacao

		escreva("Digite o primeiro número: ")
		leia(n1)

		escreva("Digite o segundo número: ")
		leia(n2)

		escreva("-------------------")
		escreva("\nEscolha sua opção: ")
		escreva("\nS - Somar")
		escreva("\nM - Multiplicar")
		escreva("\n-------------------")
		leia(operacao)

		escolha(operacao){
		caso 's': 
		caso	'S':
			res = n1 + n2
			escreva (res)
			pare
			
		caso 'm':
		caso 'M':
			res = n1 * n2
			escreva (res)
			pare
			
		caso contrario:
			escreva("Operação inválida!") 

		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 417; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */