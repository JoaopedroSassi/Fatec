#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdbool.h>

int busca(int *beg, int *end, int x){
   for (; beg != end; beg++){
      if (x == *beg){
         return beg;
      }
   }
}
     
void main(){
   setlocale(LC_ALL,"Portuguese");

   printf("-------\n");
   printf(" Busca \n");
   printf("-------\n");
   printf("Digite o tamanho do vetor:");
   int tam = 0;
   scanf("%d", &tam);
   int vet[tam];
   for (int i = 0; i < tam; i++){
      printf("Digite o %d� n�mero:", i + 1);
      scanf("%d", &vet[i]);
   }
   printf("Digite o n�mero para a busca:");
   int num = 0;
   scanf("%d", &num);

   int *ind = busca(vet, vet+tam, num);

   if (ind == vet + tam){
      printf ("N�mero n�o encontrado");   
   } else {
      printf ("O endere�o de mem�ria de %d �: %d", num, ind);   
   }
   
}