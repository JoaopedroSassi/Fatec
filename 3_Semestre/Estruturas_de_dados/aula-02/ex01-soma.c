#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

void sum()
{
   int n1, n2;
   printf("Enter 2 values:");
   scanf("%d %d", &n1, &n2);

   printf("Result = %d\n", n1 + n2); 
}
     
void main()
{
   setlocale(LC_ALL,"Portuguese");

   sum();
   system("pause");
}