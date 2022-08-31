#include <stdio.h>
#include <stdlib.h>
#include <time.h>

void printArray(int v[], int tam)
{
   for (int i = 0; i < tam; i++)
      printf("%d - %d\n", i, v[i]);
}

void OrdenaRepetidos(int origem[], int destino[], int tam)
{
   int i, j, p;
   
   for (i = 0; i < tam; i++)
   {
      p = 0;
      for (j = 0; j < tam; j++)
      {
         if (origem[i] > origem[j])
            p++;
      }

      for (j = 0; j < tam; j++)
      {
         if(origem[i] == destino[p])
            p++;
      }

      destino[p] = origem[i];
   }
}

void main(){
   srand(time(NULL));
   
   int vet[9];
   vet[0] = 1;
   vet[1] = 3;
   vet[2] = 1;
   vet[3] = 1;
   vet[4] = 3;
   vet[5] = 2;
   vet[6] = 3;
   vet[7] = 1;
   vet[8] = 2;

   int outro[9];

   printArray(vet, sizeof(vet)/sizeof(vet[0]));

   OrdenaRepetidos(vet, outro, sizeof(vet)/sizeof(vet[0]));

   printf("\n");
   printf("-----------------------");
   printf("\n");

   printArray(outro, sizeof(vet)/sizeof(vet[0]));

   system("pause");
}