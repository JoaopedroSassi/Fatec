#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

     
int main(){
   setlocale(LC_ALL,"Portuguese");

   int x = 10;
   int *p = &x;
   int **y = &p;
   printf("%d", **y);

}