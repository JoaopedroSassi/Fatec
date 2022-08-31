#include <stdio.h>
#include <stdlib.h>

int pesquisaVetor(int vet[], int tam, int valor)
{ 
   if(tam == 0) return -1; // Verificando se já é retorno

   if(vet[tam] == valor) //Verificando se achou o valor
      return tam;

   return pesquisaVetor(vet, tam-1, valor); //Recursando dimiuindo o tam
}

void main()
{
   int vet[] = {1, 2, 3, 4, 5};
   
   int n1 = pesquisaVetor(vet, 5, 3);
   int n2 = pesquisaVetor(vet, 5, 9);

   printf("%d\n", n1);
   printf("%d\n", n2);

   printf("\n");
   system("pause");
}