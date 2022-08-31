programa
{
	
	funcao inicio()
	{
		real sal, descinss, descir, salliqu

		escreva("Digite seu salário bruto: ")
		leia(sal)

		se (sal <= 1500)
		{
			descinss = sal * 2/10
			salliqu = sal - descinss
			escreva("Seu salário bruto é igual a: ", sal)
			escreva("\nO desconto do INSS é igual a: ", descinss)
			escreva("\nO salário liquido será igual a: ", salliqu)
		}
		senao
		{
			descinss = sal * 11/10
			descir = sal * 5/10
			salliqu = sal - (descinss + descir)
			escreva("Seu salário bruto é igual a: ", sal)
			escreva("\nO desconto do INSS é igual a: ", descinss)
			escreva("\nO desconto do INSS é igual a: ", descir)
			escreva("\nO salário liquido será igual a: ", salliqu)
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 431; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */