#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdbool.h>

void vet_bom(int *v, int t){
   int w[t]; 
   w[0] = 0;

   for (int i = 1; i < t; i++){
      bool ach = false;
      int cont = 0;
      while (ach == false){
         if ((cont + v[i]) >= (w[i - 1] + v[i-1])){
            w[i] = cont;
            ach = true;
         }
         cont++;
      }
   }

   int tam_w = (sizeof(w)/ sizeof(int));

   for (int i = 0; i < tam_w; i++){
      printf("%d |", w[i]);
   }
}

void main(){
   setlocale(LC_ALL, "Portuguese");

   printf("Digite o tamanho do vetor:");
   int tam = 0;
   scanf("%d", &tam);
   int vet[tam];

   for (int i = 0; i < tam; i++){
      printf("Digite o %d° número:", i + 1);
      scanf("%d", &vet[i]);
   }

   vet_bom(vet, tam);
}