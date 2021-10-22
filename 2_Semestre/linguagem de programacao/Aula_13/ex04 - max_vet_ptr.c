#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdbool.h>

int max_vet_ptr(int *b, int *e){
   if (e - b == 1){
      return *b;
   }

   int m = max_vet_ptr(b, e-1);

   if (m >= e[-1]){
      return m;
   } else {
      return e[-1];
   }
}
     
int main(){
   setlocale(LC_ALL,"Portuguese");

   printf("Digite o tamanho do vetor:");
   int tam = 0;
   scanf("%d", &tam);
   int vet[tam];
   for (int i = 0; i < tam; i++){
      printf("Digite o %d° número:", i + 1);
      scanf("%d", &vet[i]);
   }

   int maior = max_vet_ptr(vet, vet+tam);

   printf("O maior valor do array foi %d", maior);
}