#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int sum_array_pos(int *v, int t){
   int tot_par = 0;
   for (int i = 0; i < t; i++){
      if (v[i] % 2 == 0){
         tot_par = tot_par + v[i];
      }
   }

   return tot_par;
}
     
int main(){
   setlocale(LC_ALL,"Portuguese");

   int tam = 0;
   printf("Digite a quantidade de elementos do vetor:");
   scanf("%d", &tam);

   int vet[tam];
   for (int i = 0; i < tam; i++){
      printf("Digite o %d� valor do vetor:", i + 1);
      scanf("%d", &vet[i]);
   }

   printf("A soma dos valores positivos �: %d", sum_array_pos(vet, tam));

}