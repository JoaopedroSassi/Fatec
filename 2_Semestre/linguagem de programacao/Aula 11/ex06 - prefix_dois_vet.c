#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdbool.h>

bool verifica_pref(int *v, int *w, int t_v, int t_w){
   if (t_v > t_w){
      return false;
   }
   
   for (int i = 0; i < t_v; i++){
      if (v[i] != w[i]){
         return false;
      } 
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

   bool ac = verifica_pref(vet, vet2, tam, tam2);

   if (ac == true){
      printf("\nSim, ele tem prefixo ixo!");
   } else {
      printf("\nNão, ele não tem prefixo ixo!");
   }

   system("pause");
}