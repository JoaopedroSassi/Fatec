#include <stdio.h>
#include <stdlib.h>

void ocurrences(char *p)
{
   char *aux = p;

   int sizePhrase = 0;
   for (int i = 0; aux[i] != '\0'; i++)
      sizePhrase++;

   char letters[sizePhrase];
   for(int i = 0; aux[i] != '\0'; aux++)
   {
      char letter = aux[i];
      int isInLetters = 0;
      
      for (int j = 0; j < sizePhrase; j++)
      {
         if (letter == letters[j])
         {
            isInLetters = 1;
            break;
         }  



      }




















      

      int amount = 0;
      for (int j = 0; j < p[i] != '\0'; j++)
      {
         if (letter == p[i])
            amount++;
      }
      
      if(isInLetters != 1)
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