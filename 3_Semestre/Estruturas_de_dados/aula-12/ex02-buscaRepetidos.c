#include <stdio.h>
#include <stdlib.h>
#include <time.h>

void buscaRepetidos(int v[], int value, int tam)
{
   int found = 0;
   for (int i = 0; i < tam; i++)
   {
      if(v[i] == value)
      {
         printf("%d encontrado na pos %d\n", v[i], i);
         found = 1;
      }
   }

   if (found != 1)
      printf("O valor %d nao foi encontrado em nenhuma pos", value);
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
   
   buscaRepetidos(vet, 942, 10);
   
   printf("\n");
   system("pause");
}