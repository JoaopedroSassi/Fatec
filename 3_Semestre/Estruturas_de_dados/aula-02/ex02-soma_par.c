#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

void sum(int n1, int n2)
{
   printf("Result = %d\n", n1 + n2); 
}
     
void main()
{
   setlocale(LC_ALL,"Portuguese");
   printf("Enter 2 values:");
   int n1, n2;
   scanf("%d %d", &n1, &n2);

   sum(n1, n2);
   system("pause");
}