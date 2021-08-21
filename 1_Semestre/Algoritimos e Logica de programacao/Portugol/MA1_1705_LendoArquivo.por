programa
{
	inclua biblioteca Texto --> txt
	inclua biblioteca Arquivos --> arq
	/*
	 * Faz a leitura de um arquivo e exibe seu conteúdo na tela
	 */
	
	funcao inicio()
	{
		//referencia ao arquivo aberto
		inteiro refArq
		//indica um arquivo que encontra-se na mesma pasta do programa ".por"
		cadeia nomeArq = "./candidatos.txt"
		//especifica um arquivo em um diretorio qualquer
		cadeia outroArq = "c:/meu diretorio/arquivos/candidatos.txt"
		//para conter o conteudo de uma linha do arquivo lido/gravado
		cadeia linha

		//verificar se o arquivo existe
		se(nao arq.arquivo_existe(nomeArq)) 
		{
			escreva("O arquivo ", nomeArq, " não existe...")
			retorne //encerra o programa
		}
		
		//abrir o arquivo
		/*
		 * 3 modos de abrir os arquivos
		 * MODO_LEITURA - Serve só para ler
		 * MODO_ESCRITA - serve só para escrever/gravar
		 * MODO_ACRESCENTAR - server para adicionar algo no final do arquivo
		 */
		refArq = arq.abrir_arquivo(nomeArq, arq.MODO_LEITURA)

		//faz um laço que irá ler o arquivo até o final
		enquanto(nao arq.fim_arquivo(refArq)) {

			//lê a próxima linha
			linha = arq.ler_linha(refArq)

			//se linha lida for vazia, não imprime
			se(txt.numero_caracteres(linha) != 0)
			{
				//exibe o conteúdo
				escreva("\nConteúdo -> ", linha)
			}
		}

		escreva("\nTermino da leitura do arquivo")

		//fechar o arquivo
		arq.fechar_arquivo(refArq)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 1282; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */