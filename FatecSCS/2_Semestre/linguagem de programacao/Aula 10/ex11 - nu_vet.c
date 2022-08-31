#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdbool.h>

bool contem(int *v, int t, int x){
   if (t == 0){
      return false;
   }

   if (v[t-1] == x){
      return true;
   }

   return contem(v, t-1, x);
}
     
int main(){
   setlocale(LC_ALL,"Portuguese");

   int vet[] = {2, 3, 1, 5, 4, 6, 7, 2};

   printf ("Digite qual o número quer descobrir: ");
   int num = 0;
   scanf("%d", &num);

   int hav = contem(vet, 8, num);

   if (hav == 0){
      printf("O número não está!");
   } else{
      printf("O número está!");
   }
}
