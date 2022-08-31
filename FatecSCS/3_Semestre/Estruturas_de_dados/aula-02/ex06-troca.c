#include <stdio.h>
#include <stdlib.h>

void swap(int *a, int*b)
{
   int aux = *a;
   *a = *b;
   *b = aux;
}

void main()
{
   int x = 3, y = 5;

   swap(&x, &y);
   printf("x = %d | y = %d\n", x, y);   

   printf("\n");
   system("pause");
}