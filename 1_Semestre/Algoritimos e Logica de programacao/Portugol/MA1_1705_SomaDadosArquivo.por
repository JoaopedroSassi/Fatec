programa
{
	inclua biblioteca Tipos --> tp
	inclua biblioteca Arquivos --> arq
	
	/*
	 * Criar um arquivo (entrada.txt) na mão, que contenha 3 linhas
	 * 1ª linha - colocar um numero inteiro
	 * 2ª linha - operação matematica (+ - * /)
	 * 3ª linha - colocar outro numero inteiro
	 * 
	 * ler o arquivo acima, efetuar a operação solicitada e gravar o resultado
	 * no arquivo saida.txt
	 */
	
	funcao inicio()
	{
		//referecia para os arquivos
		inteiro refEntrada, refSaida
		cadeia linha //para leitura de cada linha
		inteiro numero1, numero2, resultado=0
		caracter operacao

		//abrir o arquivo de entrada
		refEntrada = arq.abrir_arquivo("./entrada.txt", arq.MODO_LEITURA)
		refSaida = arq.abrir_arquivo("./saida.txt", arq.MODO_ESCRITA)

		//providenciar as leituras e operações
		
		//ler o primeiro numero
		linha = arq.ler_linha(refEntrada)
		//converter essa linha para o 1º numero
		numero1 = tp.cadeia_para_inteiro(linha, 10)

		//ler a operação
		linha = arq.ler_linha(refEntrada)
		operacao = tp.cadeia_para_caracter(linha)

		//ler o segundo numero
		linha = arq.ler_linha(refEntrada)
		//converter essa linha para o 2º numero
		numero2 = tp.cadeia_para_inteiro(linha, 10)

		escolha(operacao)
		{
			caso '+':
				resultado = numero1 + numero2
				pare
			caso '-':
				resultado = numero1 - numero2
				pare
			caso '*':
				resultado = numero1 * numero2
				pare
			caso '/':
				resultado = numero1 / numero2
				pare												
		}

		//gravar o resultado no arquivo
		arq.escrever_linha(tp.inteiro_para_cadeia(resultado, 10), refSaida)

		//fechar os arquivos
		arq.fechar_arquivo(refEntrada)
		arq.fechar_arquivo(refSaida)

		escreva("...Arquivo gerado")
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 558; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */