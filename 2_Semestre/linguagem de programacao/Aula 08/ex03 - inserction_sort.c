#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

void ordena_inserction(int *p, int t){
   for (int i = 1; i < t; i++){
         for (int j = i; (j > 0 && p[j] < p[j - 1]); j--){
            int aux = p[j];
            p[j] = p[j - 1];
            p[j - 1] = aux;
         }
   }
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

   ordena_inserction(vet, tam);

   for (int i = 0; i < tam; i++){
      printf("%d ", vet[i]);
   }

   printf("\n---------------------------------\n");
}