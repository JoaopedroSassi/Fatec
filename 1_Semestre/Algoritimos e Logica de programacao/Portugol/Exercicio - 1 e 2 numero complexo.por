programa
{
	
	funcao inicio()
	{
		inteiro n1, n2, cont
		n1 = 0
	
		escreva("Digite o primeiro número: ")
		leia (n1)

		
		escreva("Digite o segundo número: ")
		leia (n2)

		se (n1 < n2){
			enquanto (n2 >= n1){
				escreva(n1)
				n1 = n1 + 1
			}
		}

		se (n2 < n1){
			enquanto (n1 >= n2){
				escreva(n2)
				n2 = n2 + 1
			}
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 299; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */