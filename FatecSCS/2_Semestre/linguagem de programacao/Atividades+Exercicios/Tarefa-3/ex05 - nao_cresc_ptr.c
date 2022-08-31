#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdbool.h>

bool verifica_decs_ptr(int *b, int *e){
   bool ach = false;
   while (b < e){
      if (*b <= *(b + 1)){
         ach = true;
      } else {
         ach = false;
         return ach;
      }
      ++b;
   }
   
   return ach;
}

void main(){
   setlocale(LC_ALL,"Portuguese");

   int tam = 0;
   printf("Digite a quantidade de elementos do vetor:");
   scanf("%d", &tam);

   int vet[tam];
   for (int i = 0; i < tam; i++){
      printf("Digite o %d° número:", i + 1);
      scanf("%d", &vet[i]);
   }

   bool ac = verifica_decs_ptr(vet, vet+(tam-1));

   if (ac == true){
      printf("\nSim, ele esta em ordem não-descrescente!");
   } else {
      printf("\nNão, ele não esta em ordem não-descrescente!");
   }

   system("pause");
   
}