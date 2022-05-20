#include <stdio.h>
#include <stdlib.h>
#include <time.h>

void printArray(int v[], int tam)
{
   for (int i = 0; i < tam; i++)
      printf("%d - %d\n", i, v[i]);
}

void bubbleSort(int v[], int tam)
{
   int changed, aux;
   do
   {
      tam--;
      changed = 0;
      for (int i = 0; i < tam; i++)
      {
         if(v[i] > v[i + 1])
         {
            aux = v[i];
            v[i] = v[i+1];
            v[i+1] = aux;
            changed = 1;
         }
      }
   } while (changed);
}

void main(){
   srand(time(NULL));
   
   int vet[10];
   vet[0] = 1;
   vet[1] = 3;
   vet[2] = 9;
   vet[3] = 4;
   vet[4] = 3;
   vet[5] = 6;
   vet[6] = 72;
   vet[7] = 3;
   vet[8] = 4;
   vet[9] = 1;

   printArray(vet, sizeof(vet)/sizeof(vet[0]));
   
   bubbleSort(vet, sizeof(vet)/sizeof(vet[0]));

   printf("\n");
   printf("-----------------------");
   printf("\n");
   printArray(vet, sizeof(vet)/sizeof(vet[0]));
   
   printf("\n");
   system("pause");
}