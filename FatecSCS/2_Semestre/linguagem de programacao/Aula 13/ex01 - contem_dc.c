#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdbool.h>

bool contem_dc(int *v, int b, int e, int x){
   if (e - b == 0){
      return false;
   }

   int m = (b + e) / 2;

   if (v[m] == x || contem_dc(v, b, m, x) || contem_dc(v, m+1, e, x)){
      return true;
   }

   return false;
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

   printf ("Digite qual o número quer descobrir: ");
   int num = 0;
   scanf("%d", &num);

   int hav = contem_dc(vet, 0, tam, num);

   if (hav == false){
      printf("O número não está!");
   } else{
      printf("O número está!");
   }
}