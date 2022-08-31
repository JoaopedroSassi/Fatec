#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdbool.h>

bool verifica_pref(int *b1, int *b2, int *e1, int *e2){
   if (e2 - b2 <= e1 - b1){
      return false;
   }
   
   while (b1 < e1){
      if (*b1 != *b2){
         return false;
      } 
      ++b1;
      ++b2;
   }

   return true;
}
   
void main(){
   setlocale(LC_ALL,"Portuguese");
    
   int tam = 0;
   printf("Digite a quantidade de elementos do primeiro vetor:");
   scanf("%d", &tam);

   int vet[tam];
   for (int i = 0; i < tam; i++){
      printf("Digite o %d° número:", i + 1);
      scanf("%d", &vet[i]);
   }

   int tam2 = 0;
   printf("Digite a quantidade de elementos do segundo vetor:");
   scanf("%d", &tam2);

   int vet2[tam2];
   for (int i = 0; i < tam2; i++){
      printf("Digite o %d° número:", i + 1);
      scanf("%d", &vet2[i]);
   }

   bool ac = verifica_pref(vet, vet2, vet+(tam-1), vet+(tam2-1));

   if (ac == true){
      printf("\nSim, ele tem prefixo ixo!");
   } else {
      printf("\nNão, ele não tem prefixo ixo!");
   }

   system("pause");
}