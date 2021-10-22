#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdbool.h>

int max_vet_ptr_dc(int *b, int *e){
   if (e - b == 1){
      return *b;
   }

   int m = b + (e-b)/2;
   int x = max_vet_ptr_dc(b, m);
   int y = max_vet_ptr_dc(m, e);

   if (x >= y){
      return x;
   } else {
      return y;
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

   int maior = max_vet_ptr_dc(vet, vet+tam);

   printf("O maior valor do array foi %d", maior);
}