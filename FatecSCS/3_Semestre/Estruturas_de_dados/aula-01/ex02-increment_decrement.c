#include <stdio.h>
#include <stdlib.h>

void main()
{
   int a = 5, b = 2;

   int c = a++;
   int d = b--;

   printf("%d and %d\n", c, a);
   printf("%d and %d", d, b);
   
   printf("\n");
   system("pause");
}