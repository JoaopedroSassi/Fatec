#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

void main(){
   setlocale(LC_ALL,"Portuguese");

   int *vet = malloc(100 * sizeof(int));

   if (vet == 0){
      printf("Tristonho");
      exit(1);
   }

   for (int *i = vet; i != vet+100; i++){
      *i = 0;
   }

   free(vet);
}