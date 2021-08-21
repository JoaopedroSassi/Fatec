programa
{
	
	funcao inicio()
	{
		real n1, n2, cont = 1, resul = 0
		caracter operacao

		escreva("Digite o primeiro número: ")
		leia(n1)

		escreva("Digite o segundo número: ")
		leia(n2)

		escreva("-------------------")
		escreva("\nEscolha sua opção: ")
		escreva("\nM - Multiplicar")
		escreva("\nD - Dividir")
		escreva("\n-------------------")
		leia(operacao)

		escolha(operacao){
		caso 'm': 
		caso	'M':

			enquanto (cont <= n2) {
				resul = resul + n1
				cont++
			}
			escreva(resul)
			
		pare
			
		caso 'd':
		caso 'D':

			se (n2 != 1){
				enquanto (n1 > n2){
					n1 = n1 - n2
					cont++
				}
				escreva(cont)
			} senao {
				escreva(n1)
			}

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
 * @POSICAO-CURSOR = 602; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */