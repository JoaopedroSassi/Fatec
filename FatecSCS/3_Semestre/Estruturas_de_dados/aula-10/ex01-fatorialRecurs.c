#include <stdio.h>
#include <stdlib.h>

int Fat(int value)
{ 
    if(value == 0)
        return 1;

    return value * Fat(value - 1);
}

void main(){
   int res = Fat(5);
   printf("O fatorial de %d = %d", 5, res);
   
   printf("\n");
   system("pause");
}