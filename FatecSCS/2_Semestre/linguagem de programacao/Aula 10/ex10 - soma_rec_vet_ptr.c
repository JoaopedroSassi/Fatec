#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int soma_vet_ptr(int *beg, int *end){
   if (beg == end){
      return 0;
   }

   int s = soma_vet_ptr(beg, end-1);

   return s + *(end-1);
}
     
int main(){
   setlocale(LC_ALL,"Portuguese");

   int vet[] = {2, 3, 1, 5, 4, 6, 7, 2};

   printf("%d", soma_vet_ptr(vet, vet+8)); 
}

