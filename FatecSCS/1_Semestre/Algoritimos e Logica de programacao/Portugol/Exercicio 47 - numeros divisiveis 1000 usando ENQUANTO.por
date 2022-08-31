programa
{
	
	funcao inicio()
	{
		inteiro cont = 0, cont_2 = 0, cont_4 = 0, cont_7 = 0

		enquanto (cont <= 1000) {
			se(cont % 2 == 0){
				cont_2++
			}
			
		     se(cont % 4 == 0){
				cont_4++
			}
			
			se(cont % 7 == 0){
				cont_7++
			}

		cont++
		}

		escreva ("Possuem ", cont_2, " números divisíveis por 2, entre 0 e 1000")
		escreva ("\nPossuem ", cont_4, " números divisíveis por 4, entre 0 e 1000")
		escreva ("\nPossuem ", cont_7, " números divisíveis por 7, entre 0 e 1000")
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 507; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */