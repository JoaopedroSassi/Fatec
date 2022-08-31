programa
{
	inclua biblioteca ServicosWeb
	
	funcao inicio()
	{
		real sal, novosal

		escreva("Digite seu salário atual: ")
		leia(sal)

		se (sal <= 2000) 
		{
			escreva("Você receberá um aumento!")
			novosal = sal * 1.1
			escreva("\nSeu antigo salário é: ", sal)
			escreva("\nSeu novo salário será: ", novosal)
		} 
		senao
		{
			escreva("Você não irá receber nenhuma aumento, seu salário continuará sendo: ", sal)
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 12; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */