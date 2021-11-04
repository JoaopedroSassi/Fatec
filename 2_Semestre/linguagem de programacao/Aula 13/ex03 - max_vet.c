#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdbool.h>

int max_vet(int *v, int t){
   if (t == 1){
      return v[0];
   }

   int m = max_vet(v, t-1);

   if (m >= v[t-1]){
      return m;
   } else {
      return v[t-1];
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

   int maior = max_vet(vet, tam);

   printf("O maior valor do array foi %d", maior);
}