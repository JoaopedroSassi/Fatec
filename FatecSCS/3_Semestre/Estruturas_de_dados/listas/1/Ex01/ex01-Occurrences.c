#include <stdio.h>
#include <stdlib.h>

void ocurrences(char *p)
{
   //Calculando o tamanho da string
   int sizePhrase = 0;
   for (int i = 0; p[i] != '\0'; i++)
      sizePhrase++;

   //Criando um vetor de chars auxiliar pra poder fazer as operações
   char aux[sizePhrase];
   for (int i = 0; i < sizePhrase; i++)
      aux[i] = p[i]; 

   for(int i = 0; i < sizePhrase; i++)
   {
      char letter = p[i];
      int amount = 1; //Amount começa com 1 pra poder já contar a letra 1 vez

      //Verificando se a letra já não foi capturada
      if(aux[i] != '-')
      {
         for (int j = i+1; j < sizePhrase; j++)
         {
            if (letter == p[j])
            {
               //Aumentando a quantidade de vezes e alterando a outra letra para -
               amount++;
               aux[j] = '-';
            }
         }
      }
      
      if(aux[i] != '-')
         printf("The letter %c appeared %d times\n", letter, amount);
   }
}

void main()
{
   char animal[] = "arara";

   ocurrences(animal);

   printf("\n");
   system("pause");
}