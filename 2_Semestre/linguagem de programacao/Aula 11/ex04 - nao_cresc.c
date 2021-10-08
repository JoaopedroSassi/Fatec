#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdbool.h>

bool verifica_decs(int *p, int t){
   bool ach = false;
   int find = 0;
   for (int i = 0; i < t - 1; i++){
      if (p[i] <= p[i+1] && find != 1){
         ach = true;
      } else {
         ach = false;
         find = 1;
      }
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

   bool ac = verifica_decs(vet, tam);

   if (ac == true){
      printf("\nSim, ele esta em ordem não-descrescente!");
   } else {
      printf("\nNão, ele não esta em ordem não-descrescente!");
   }
   
   system("pause");
}