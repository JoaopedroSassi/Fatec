#include <stdio.h>
#include <stdlib.h>

void main()
{
   int arr[4] = {10,12,30, 45};
   int *p;
   p = arr;

   for (int i = 0; i < 4; i++)
      printf("%d\n", arr[i]); //or p[i] 
   
   printf("\n");

   for (int i = 0; i < 4; i++)
      printf("%d\n", *p++); 

   printf("\n");
   system("pause");
}