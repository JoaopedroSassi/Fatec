#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
     
void main(){
   setlocale(LC_ALL,"Portuguese");

   int tam = 0;
   printf("Digite quantos numeros serão analisados:");
   scanf("%d", &tam);

   int vet[tam];
   int tot_zero = 0;
   int tot_um = 0;
   int tot_dois = 0;
   for (int i = 0; i < tam; i++){
      printf("Digite o %d° número:", i + 1);
      scanf("%d", &vet[i]);
      if (vet[i] % 3 == 0){
         tot_zero = tot_zero + 1;
      }
      if (vet[i] % 3 == 1){
         tot_um = tot_um + 1;
      }
      if (vet[i] % 3 == 2){
         tot_dois = tot_dois + 1;
      }
   }

   printf("------------------------------");
   printf("\nResto 0: %d", tot_zero);
   printf("\nResto 1: %d", tot_um);
   printf("\nResto 2: %d", tot_dois);
}