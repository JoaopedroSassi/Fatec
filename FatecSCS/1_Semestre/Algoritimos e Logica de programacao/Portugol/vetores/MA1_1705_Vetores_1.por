programa
{
	/*	
	 * 	Exemplo do uso de vetores, armazenamento e exibição de 5 nomes
	 */
	funcao inicio()
	{
		//maneira arcaica
		cadeia nome_1, nome_2, nome_3, nome_4, nome_5
		escreva("Arcaica - Nome 1: ")
		leia(nome_1)
		escreva("Arcaica - Nome 2: ")
		leia(nome_2)
		escreva("Arcaica - Nome 3: ")
		leia(nome_3)
		escreva("Arcaica - Nome 4: ")
		leia(nome_4)
		escreva("Arcaica - Nome 5: ")
		leia(nome_5)

		//uso de vetores, não tão bem elaborada
		cadeia nomes[5] //o 5 indica a quantidade de elementos

		escreva("Vetor (ruim) - Nome 1: ")
		leia(nomes[0])
		escreva("Vetor (ruim) - Nome 2: ")
		leia(nomes[1])
		escreva("Vetor (ruim) - Nome 3: ")
		leia(nomes[2])
		escreva("Vetor (ruim) - Nome 4: ")
		leia(nomes[3])
		escreva("Vetor (ruim) - Nome 5: ")
		leia(nomes[4])

		//uso de vetores da melhor maneira
		inteiro indice
		cadeia nome_vet[5]

		//entrada de dados
		para(indice=0; indice<5; indice++) 
		{
			escreva("Vetor - Nome ", (indice+1), ": ")
			leia(nome_vet[indice])
		}

		//saida de dados
		para(indice=0; indice<5; indice++) 
		{
			//escreva("\nVetor - Nome[", (indice+1), "]: ", nome_vet[indice])
			escreva("\n", nome_vet[indice])
		}



	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 517; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */