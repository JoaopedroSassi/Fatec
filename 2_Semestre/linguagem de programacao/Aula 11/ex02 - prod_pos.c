#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int prod_pos(int *v, int t){
   int mult_pos = 1;
   for (int i = 0; i < t; i++){
      if (v[i] > 0){
         mult_pos = mult_pos * v[i];
      }
   }
   
   return mult_pos;
}
     
int main(){
   setlocale(LC_ALL,"Portuguese");

   int tam = 0;
   printf("Digite a quantidade de elementos do vetor:");
   scanf("%d", &tam);

   int vet[tam];
   for (int i = 0; i < tam; i++){
      printf("Digite o %d° valor do vetor:", i + 1);
      scanf("%d", &vet[i]);
   }

   printf ("O produto de elementos positivos do vetor é %d!", prod_pos(vet, tam));
   printf("\n");
   system("pause");
}