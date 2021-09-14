#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int verifica_numero(int *p, int t){
   for (int i = 0; i <= t; i++){
      if (p[i] != i + 1){
         return i + 1;
      }
   }
}

void ordena_vetores(int *p, int t){
   for (int i = 0; i < t - 1; i++){
      for (int c = i + 1; c < t; c++){
         if (p[i] > p[c]){
            int aux = p[i];
            p[i] = p[c];
            p[c] = aux;
         }
      }
   }
}
     
void main(){
   setlocale(LC_ALL,"Portuguese");

   printf("-----------------------------------------\n");
   printf("Digite o número, e iremos achar o oculto!\n");
   printf("-----------------------------------------\n");
   int num = 0;
   scanf("%d", &num);
   int tam = num - 1;
   int vet[tam];
   for (int i = 0; i < tam; i++){
      printf("Digite o %d° número:", i + 1);
      scanf("%d", &vet[i]);
   }

   ordena_vetores(vet, tam);

   int num_oculto = verifica_numero(vet, tam);

   printf("\n---------------------------------");
   printf("\nO número oculto é: %d", num_oculto);
}