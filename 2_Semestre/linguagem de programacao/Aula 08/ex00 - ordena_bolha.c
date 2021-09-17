#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

void ordena_vetores(int *p, int t){
   for (int i = 0; i < t - 1; i++){
      for (int c = i + 1; c < t; c++){
         if (p[i] > p[c]){
            int aux = p[i];
            p[i] = p[c];
            p[c] = aux;
         }
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

   ordena_vetores(vet, tam);

   printf("-----------------------------------------\n");

   for (int i = 0; i < tam; i++){
      printf("%d ", vet[i]);
   }
}
