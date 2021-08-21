programa
{
	
	funcao inicio()
	{
		inteiro a, b, c, d 

		escreva("Digite o primeiro valor: ")
		leia(a)

		escreva("Digite o segundo valor: ")
		leia(b)

		escreva("Digite o terceiro valor: ")
		leia(c)
		
		se (a == 8){
			se (b > 7) {
				d = 157
			} senao se (c < 10){
				d = 157
			} senao {
				d = -100
			}
		} senao {
			d = -100
		}

		escreva("\n", a)
		escreva("\n", b)
		escreva("\n", c)
		escreva("\n", d)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 433; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */