#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdbool.h>

int muda_vet(int *beg, int *end){
   while (beg < end) {
      if (*beg % 2 == 0){
         *beg = 0;
      } else {
         *beg = 1;
      }
      beg++;
   }
}
     
void main(){
   setlocale(LC_ALL,"Portuguese");

   printf("-----------\n");
   printf("  Par  - 0 \n");
   printf(" Impar - 1 \n");
   printf("-----------\n");
   printf("Digite o tamanho do vetor:");
   int tam = 0;
   scanf("%d", &tam);
   int vet[tam];
   for (int i = 0; i < tam; i++){
      printf("Digite o %d° número:", i + 1);
      scanf("%d", &vet[i]);
   }

   muda_vet(vet, vet+tam);

   printf("\n");
   for (int i = 0; i < tam; i++){
      printf("%d|", vet[i]);
   }
}