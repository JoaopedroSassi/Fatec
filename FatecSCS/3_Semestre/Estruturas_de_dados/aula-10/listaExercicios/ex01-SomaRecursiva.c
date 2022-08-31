#include <stdio.h>
#include <stdlib.h>

int SumElements(int a, int b)
{
   if (a == b)
      return a;

   return b + SumElements(a, b - 1);
}

void main(){
   int res = SumElements(10, 12);
   printf("A soma de %d ate %d = %d", 10, 12, res);
   
   printf("\n");
   system("pause");
}