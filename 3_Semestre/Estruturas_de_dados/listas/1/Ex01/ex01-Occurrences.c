#include <stdio.h>
#include <stdlib.h>

void ocurrences(char *p)
{
   int sizePhrase = 0;
   for(int i = 0; p[i] != '\0'; p++)
      sizePhrase++;

   char letters[sizePhrase];
   for(int i = 0; p[i] != '\0'; p++)
   {
      char letter = p[i];
      for (int j = 0; j < sizePhrase; j++)
      {
         if(letters[j] == letter)
         {

         }  
      }
      int amount = 1;
      for (int j = 0; p[j] != '\0'; j++)
      {
         if(p[j+1] == letter)
            amount++;
         
      }

      printf("The letter %c appeared %d times\n", letter, amount);
   }
}

void main()
{
   char furniture[] = "arara";

   ocurrences(furniture);

   printf("\n");
   system("pause");
}