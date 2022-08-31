programa
{
	
	funcao inicio()
	{
		real valor
		caracter tipo

		escreva("Digite o valor do produto: ")
		leia(valor)

		escreva("Digite qual sua categoria: ")
		escreva("\nE-Estudante")
		escreva("\nA-Assalariado")
		escreva("\nP-Aposentado")
		leia(tipo)

		escolha(tipo){
			caso 'E':
				valor = valor - (valor*15/100)
				escreva("Você ira pagar: ", valor)
			pare

			caso 'A':
				valor = valor - (valor*10/100)
				escreva("Você ira pagar: ", valor)
			pare

			caso 'P':
				valor = valor - (valor*25/100)
				escreva("Você ira pagar: ", valor)
			pare

			caso contrario: 
				escreva("Você não ganhou nenhum desconto, portanto, irá pagar: ", valor, " mesmo")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 291; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */