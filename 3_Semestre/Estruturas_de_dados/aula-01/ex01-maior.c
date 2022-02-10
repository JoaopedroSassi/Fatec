#include <stdio.h>
#include <stdlib.h>

void main()
{
   int a, b = 0;

   printf("Enter the first value:");
   scanf("%d", &a);
   printf("Enter the second value:");
   scanf("%d", &b);

   if (a == b)
   {
      printf("The values are equals!\n");
   } else
   {
      if(a > b)
      {
         printf("The biggest is = %d\n", a);
      } else
      {
         printf("The biggest is = %d\n", b);
      }
   }
   
   system("pause");
}