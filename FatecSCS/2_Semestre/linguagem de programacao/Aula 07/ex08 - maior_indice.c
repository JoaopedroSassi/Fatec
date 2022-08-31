#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int maior_indice(int *v, int t){
   int ind = 0;

   for (int i = 0; i < t; i++){
      if (v[i] > v[ind]){
         ind = i;
      }
   }

   return ind;
}
     
int main(){
   setlocale(LC_ALL,"Portuguese");

   int vet[] = {1, 5, 7, 9, 7, 3, 0, 4, 7};
   int tam = (sizeof(vet)/sizeof(int));

   int resul = maior_indice(vet, tam);

   printf("%d", resul);
}