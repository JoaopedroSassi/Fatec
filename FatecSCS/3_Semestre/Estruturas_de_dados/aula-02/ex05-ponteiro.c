#include <stdio.h>
#include <stdlib.h>
     
void main()
{
   int m, *p;

   p = &m;
   *p = 3;

   printf("p = %d - *p = %d", p, *p);

   printf("\n");
   system("pause");
}