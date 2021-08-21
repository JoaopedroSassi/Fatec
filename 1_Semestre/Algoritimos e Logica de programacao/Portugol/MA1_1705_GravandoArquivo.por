programa
{
	inclua biblioteca Texto --> txt
	inclua biblioteca Arquivos --> arq
	/*
	 * Solicita do usuario diversos nomes de Frutas e grava todos os nomes
	 * fornecidos em um arquivo
	 */
	
	funcao inicio()
	{
		//referencia ao arquivo aberto
		inteiro refArq
		//indica um arquivo que encontra-se na mesma pasta do programa ".por"
		cadeia nomeArq = "./frutas.txt"
		//especifica um arquivo em um diretorio qualquer
		cadeia outroArq = "c:/meu diretorio/arquivos/candidatos.txt"
		//para conter o conteudo de uma linha do arquivo lido/gravado
		cadeia linha, fruta, tipo

		//abrir o arquivo
		/*
		 * 3 modos de abrir os arquivos
		 * MODO_LEITURA - Serve só para ler
		 * MODO_ESCRITA - serve só para escrever/gravar
		 * MODO_ACRESCENTAR - server para adicionar algo no final do arquivo
		 */
		
		//verifica se o arquivo existe para ver se o usuario que criar um 
		//novo ou acrescentar no existente
		se(arq.arquivo_existe(nomeArq))
		{
			escreva("Arquivo já existe! Deseja criar um novo ou acrescentar (N/A):")
			leia(tipo)

			se(tipo == "N")
				refArq = arq.abrir_arquivo(nomeArq, arq.MODO_ESCRITA)	
			senao
				refArq = arq.abrir_arquivo(nomeArq, arq.MODO_ACRESCENTAR)	
		} 
		senao
		{
			refArq = arq.abrir_arquivo(nomeArq, arq.MODO_ESCRITA)	
		}
		

		//solicitar as frutas, infinitamente, até a pessoa digitar FIM
		faca
		{
			escreva("Digite uma fruta, coloque FIM para terminar: ")
			leia(fruta)

			se(fruta == "FIM")
			{
				pare //enterrompe o laço de repetição, e sai fora dele
			}

			//gravar fruta no arquivo
			arq.escrever_linha(fruta, refArq)
			
		} enquanto(fruta != "FIM")
		
		escreva("\nTermino da gravação do arquivo")

		//fechar o arquivo
		arq.fechar_arquivo(refArq)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 1040; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */