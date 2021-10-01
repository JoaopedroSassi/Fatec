#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdbool.h>

int soma_pref(int *beg, int *end){
   if (beg == end){
      return ;
   } else {
      int soma = *beg;
      while (beg != end){
         soma = soma + *beg;
         *beg = soma;
         ++beg;  
      }
   }
}
     
void main(){
   setlocale(LC_ALL,"Portuguese");

   printf("---------------\n");
   printf(" Soma prefixos \n");
   printf("---------------\n");
   printf("Digite o tamanho do vetor:");
   int tam = 0;
   scanf("%d", &tam);
   int vet[tam];
   for (int i = 0; i < tam; i++){
      printf("Digite o %d° número:", i + 1);
      scanf("%d", &vet[i]);
   }

   soma_pref(vet, vet+tam);

   printf("\n");
   for (int i = 0; i < tam; i++){
      printf("%d|", vet[i]);
   }
}