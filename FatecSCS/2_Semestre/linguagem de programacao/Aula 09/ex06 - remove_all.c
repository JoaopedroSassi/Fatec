#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

void imprime_vet(int *beg, int *end){
   while(beg != end){
      printf("%d|", *beg);
      ++beg;
   }
}

int *remove_all(int *beg, int *end, int num){
   int *pon = beg;
   while (beg != end){
      if (*beg != num) {
         *pon = *beg;
         ++pon;
      }
      ++beg;
   }
   
   return pon;
}
     
void main(){
   setlocale(LC_ALL,"Portuguese");

   printf("---------------\n");
   printf(" Remove All    \n");
   printf("---------------\n");
   printf("Digite o tamanho do vetor:");
   int tam = 0;
   scanf("%d", &tam);
   int vet[tam];
   for (int i = 0; i < tam; i++){
      printf("Digite o %d° número:", i + 1);
      scanf("%d", &vet[i]);
   }
   printf ("Qual número deseja remover: ");
   int n = 0;
   scanf ("%d", &n);

   int *p = remove_all(vet, vet+tam, n);

   imprime_vet(vet, p);
   printf("\n");

}