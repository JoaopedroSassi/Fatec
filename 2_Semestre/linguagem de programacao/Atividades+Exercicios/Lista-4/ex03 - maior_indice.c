#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdbool.h>

int maior_indice(int *b, int *e, int n){
   if ((n <= 0) || (b - e == 0)){
      return -1;
   }

   int soma = 0, i = 0;
   while ((b != e) && (soma <= n)){
      soma = soma + *b;
      ++i;
      ++b;
   }
   
   return i-1;
}

void main(){
   setlocale(LC_ALL,"Portuguese");

   printf("Digite o tamanho do vetor:");
   int tam = 0;
   scanf("%d", &tam);
   int vet[tam];

   for (int i = 0; i < tam; i++){
      printf("Digite o %d° número:", i + 1);
      scanf("%d", &vet[i]);
   }

   printf("Digite qual o número de comparação:");
   int n = 0;
   scanf("%d", &n);

   int ind = maior_indice(vet, vet + tam, n);

   printf("O maior índice é %d", ind);
}