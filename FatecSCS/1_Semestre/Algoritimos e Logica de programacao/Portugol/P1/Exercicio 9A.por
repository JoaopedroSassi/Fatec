programa
{
	
	funcao inicio()
	{
		real n1, n2, n3, med
		
		faca{(escreva("Digite sua primeira nota: "))
			leia(n1)
			
			se(n1<0 ou n1>100){
				escreva("Digite uma nota dentro das condições!\n")
			}
		} enquanto (n1<0 ou n1>100)

		faca{(escreva("Digite sua segunda nota: "))
			leia(n2)
			
			se (n2<0 ou n2>100){
				escreva("Digite uma nota dentro das condições!\n")
			}
		} enquanto (n2<0 ou n2>100)

		faca{(escreva("Digite sua terceira nota: "))
			leia(n3)

			se (n3<0 ou n3>100){
				escreva("Digite uma nota dentro das condições!\n")
			}
		} enquanto (n3<0 ou n3>100)

		med = (n1+n2+n3) / 3

		se (med <= 49){
			escreva("Insuficiente!") 
		}
		
		se (med >= 49 e med <= 64){
			escreva("Regular") 
		}
		
		se (med >= 65 e med <=84){
			escreva("Bom") 
		}
		
		se (med >= 85){
			escreva("Otimo!") 
		}
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 60; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */