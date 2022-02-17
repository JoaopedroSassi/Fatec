#include <stdio.h>
#include <stdlib.h>
     
void main()
{
   int a, b, c, d;
   char name[15];

   printf("Memory allocation");
   printf("\na = %d - &a=%d", a, &a);
   printf("\nb = %d - &b=%d", b, &b);
   printf("\nc = %d - &c=%d", c, &c);
   printf("\nd = %d - &d=%d", d, &d);
   printf("\nname = %s - &name=%d", name, &name);

   printf("\n");
   system("pause");
}