#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int ind_min(int *v, int beg, int end){

}

void sel_sort(int *p, int b, int e){
   for (int i = 0; i < e; i++){
      int men = ind_min(p, b, e);
      int aux = p[i];
      p[i] = p[men];
      p[men] = aux;
   }  
}

void main(){
   setlocale(LC_ALL,"Portuguese");

   printf("-----------------------------------------\n");
   printf("           Ordenando Vetores!            \n");
   printf("-----------------------------------------\n");
   printf("Digite o tamanho do vetor:");
   int tam = 0;
   scanf("%d", &tam);
   int vet[tam];
   for (int i = 0; i < tam; i++){
      printf("Digite o %d° número:", i + 1);
      scanf("%d", &vet[i]);
   }

   

   printf("\n---------------------------------\n");

   for (int i = 0; i < tam; i++){
      printf("%d ", vet[i]);
   }
}