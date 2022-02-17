#include <stdio.h>
#include <stdlib.h>

int sum(int n1, int n2)
{
   return n1 + n2; 
}
     
void main()
{
   printf("Enter 2 values:");
   int n1, n2;
   scanf("%d %d", &n1, &n2);

   printf("Result = %d\n", sum(n1, n2)); 

   system("pause");
}