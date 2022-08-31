#include <stdio.h>
#include <stdlib.h>
#include <time.h>

void main(){
   srand(time(NULL));
   
   int tam = rand()%30 + 1;
   printf("O tamanho do vetor = %d", tam);
   printf("\n-------------------------");

   int vet[tam];
   for (int i = 0; i < tam; i++)
   {
      vet[i] = rand()%30 + 1;
      printf("\n%d pos | val = %d\n", i, vet[i]);
   }
   
   printf("\n");
   system("pause");
}