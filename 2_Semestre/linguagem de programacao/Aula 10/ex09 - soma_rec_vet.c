#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int soma_vet(int *v, int t){
   if (t == 0){
      return 0;
   }

   int s = soma_vet(v, t-1);

   return s + v[t-1];
}
     
int main(){
   setlocale(LC_ALL,"Portuguese");

   int vet[] = {2, 3, 1, 5, 4, 6, 7, 2};

   printf("%d", soma_vet(vet, 8)); 
}

