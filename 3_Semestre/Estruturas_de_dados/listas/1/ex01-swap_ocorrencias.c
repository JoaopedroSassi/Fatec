#include <stdio.h>
#include <stdlib.h>

int changeOcurrence(char *p, char x, char y)
{
   int am = 0;
   for(int i = 0; p[i] != '\0'; p++)
   {
      if(p[i] == x)
      {
         p[i] = y;
         am++;
      }
   }

   return am;
}

void main()
{
   char furniture[] = "wardrobe";
   int amount = changeOcurrence(furniture, 'r', 'x');

   printf("The swap of %s was made %d times", furniture, amount);

   printf("\n");
   system("pause");
}