#include <stdio.h>
#include <stdlib.h>

void main()
{
   char phrase[] = "CASTLEVANIA";
   char *p;

   int n = 0;
   for (p = phrase; *p != '\0'; p++)
      if(*p == 'A') n++;
   
   printf("Letters A = %d\n", n);

   printf("\n");
   system("pause");
}