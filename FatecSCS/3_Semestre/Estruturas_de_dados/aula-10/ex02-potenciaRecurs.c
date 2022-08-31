#include <stdio.h>
#include <stdlib.h>

int Pot(int b, int p)
{
   if (p == 0)
      return 1;

   return p * Pot(b, p - 1);
}

void main(){
   int res = Pot(2, 5);
   printf("%d elevado a %d = %d", 2, 5, res);
   
   printf("\n");
   system("pause");
}