#include <stdio.h>
#include <stdlib.h>

void ocurrences(char *p)
{
   int sizePhrase = 0;
   for (int i = 0; p[i] != '\0'; i++)
      sizePhrase++;

   char aux[sizePhrase];
   for (int i = 0; i < sizePhrase; i++)
      aux[i] = p[i];

   for(int i = 0; i < sizePhrase; i++)
   {
      char letter = p[i];
      int amount = 1;

      for (int j = i+1; j < sizePhrase; j++)
      {
         if(aux[i] != '-')
         {
            if (letter == p[j])
            {
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