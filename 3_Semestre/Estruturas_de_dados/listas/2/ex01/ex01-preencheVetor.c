#include <stdio.h>
#include <stdlib.h>
#include <time.h>

void preencheVetor(int v[], int n)
{
   int founded = 0;
   n++; //Poder sortear o 0 e o n

   for (int i = 0; i < n; i++)
   {
      int value = rand()%n; //Sortear um novo a cada iteração

      for (int j = 0; j < n; j++)
      {
         if(v[j] == value)
            founded = 1; //Verificando se o numero ja esta no vetor
      }

      if(founded != 1) //Senao tiver, adiciona
         v[i] = value;
      else //Se tiver, volta pra sortear outro numero
         i--;
      
      founded = 0;
   }
}

void main()
{
   srand(time(NULL));

   int vet[5];
   preencheVetor(vet, 5);

   for (int i = 0; i < 5; i++)
   {
      printf("\n%d pos | val = %d\n", i, vet[i]);
   }   

   printf("\n");
   system("pause");
}