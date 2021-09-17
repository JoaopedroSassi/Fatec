#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

void ordena_vetores(int *p, int t){
   //code
}

void main(){
   setlocale(LC_ALL,"Portuguese");

   printf("-----------------------------------------\n");
   printf("           Ordenando Vetores!            \n");
   printf("-----------------------------------------\n");
   printf("Digite o tamanho do vetor:");
   int tam = 0;
   scanf("%d", &tam);
   int vet[tam];
   for (int i = 0; i < tam; i++){
      printf("Digite o %d° número:", i + 1);
      scanf("%d", &vet[i]);
   }

   ordena_vetores(vet, tam);

   printf("\n---------------------------------\n");

   for (int i = 0; i < tam; i++){
      printf("%d ", vet[i]);
   }
}