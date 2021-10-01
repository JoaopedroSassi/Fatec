#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdbool.h>

int comp_maior_pre_pon(int *beg, int *end){
   if (beg == end){
      return 0;
   }
   
   int *ant = beg;
   ++beg;
   int compr = 1;

   while (beg < end){
      if (*ant < *beg){
         compr++;
         ++beg;
         ++ant;
      } else{
         return compr;
      }
   }

   return compr;
}
     
void main(){
   setlocale(LC_ALL,"Portuguese");

   printf("------------------------------------------\n");
   printf("Comprimento do maior prefixo com ponteiros\n");
   printf("------------------------------------------\n");
   printf("Digite o tamanho do vetor:");
   int tam = 0;
   scanf("%d", &tam);
   int vet[tam];
   for (int i = 0; i < tam; i++){
      printf("Digite o %d° número:", i + 1);
      scanf("%d", &vet[i]);
   }

   int res = comp_maior_pre_pon(vet, &vet[tam - 1]);

   printf ("O comprimento do maior prefixo crescente foi %d", res);
}