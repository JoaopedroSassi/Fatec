#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int *menor_indice(int *b, int *e){
   int *min = b;
   for (int *i = b+1; *i < e; ++i){
      if (*i > *min){
         min = i;
      }
   }

   return min;
}

void ordena_selection (int *b, int *e){
   for (;b < e -1; ++b)  {
      int *min = menor_indice(b, e);
      int aux = *b;
      *b = *min;
      *min = aux;
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

   ordena_selection(vet, vet[tam]);

   printf("\n---------------------------------\n");

   for (int i = 0; i < tam; i++){
      printf("%d ", vet[i]);
   }
}