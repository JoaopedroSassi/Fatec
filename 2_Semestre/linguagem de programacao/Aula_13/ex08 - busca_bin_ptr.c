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

bool binary_search_ptr(int *b, int *e, int x){
   if (e - b == 0){
      return false;
   }

   int *med = b + (e-b)/2;

   if (*med == x){
      return true;
   }
   
   if(x < *med){
      binary_search_ptr(b, med, x);
   } else {
      binary_search_ptr(med+1, e, x);
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

   sel_sort(vet, vet+tam);

   printf("Digite o número que você deseja saber:");
   int num = 0;
   scanf("%d", &num);

   bool hav = binary_search_ptr(vet, vet+tam, num);

   if (hav == false){
      printf("O número não está!");
   } else{
      printf("O número está!");
   }
}