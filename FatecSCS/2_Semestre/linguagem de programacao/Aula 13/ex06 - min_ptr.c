#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdbool.h>

int *min_ptr(int *b, int *e){
   if (e - b == 1){
      return b;
   }

   int *m = min_ptr(b+1, e);
   if (*m <= *b){
      return m;
   } else {
      return b;
   }
}

void sel_sort(int *b, int *e){
   if (e - b <= 1){
      return;
   }
   
   int *men = min_ptr(b, e);

   int aux = *men;
   *men = *b;
   *b = aux;

   sel_sort(b + 1, e);
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

   sel_sort(vet, vet+tam);

   for (int i = 0; i < tam; i++){
      printf("%d ", vet[i]);
   }
}