#include <stdio.h>
#include <stdlib.h>

void calc(int a, int b, int *s, int*p)
{
   *s = a + b;
   *p = a * b;
}

void main()
{
   int x = 3, y = 4;
   int sum = 0, mult = 0;

   calc(x, y, &sum, &mult);
   printf("Sum = %d | Mult = %d", sum, mult);

   printf("\n");
   system("pause");
}