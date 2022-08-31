#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdbool.h>

int rearranja(int *beg, int *end, int x){
   int *k = beg;
   for (int *i = beg; k !=end; ++k){
      if (*k < x){
         int aux = *k;
         *k = *i;
         *i = aux;
         ++i;
      } 
   }
}
     
void main(){
   setlocale(LC_ALL,"Portuguese");

   printf("---------------\n");
   printf(" Rearranjando! \n");
   printf("---------------\n");
   printf("Digite o tamanho do vetor:");
   int tam = 0;
   scanf("%d", &tam);
   int vet[tam];
   for (int i = 0; i < tam; i++){
      printf("Digite o %d° número:", i + 1);
      scanf("%d", &vet[i]);
   }
   printf("Digite o número para a rearranjação:");
   int num = 0;
   scanf("%d", &num);


   rearranja(vet, &vet[tam - 1], num);

   for (int i = 0; i < tam; i++){
      printf("%d ", vet[i]);
   }
}