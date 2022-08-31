#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

     
int main(){
   setlocale(LC_ALL,"Portuguese");

   int x = 10;
   int *p = &x;
   *p = 20;
   printf("%d", *p);
   printf("\n%d", x);

}