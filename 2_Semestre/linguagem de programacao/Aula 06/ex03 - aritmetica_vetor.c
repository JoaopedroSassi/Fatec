#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
     
int main(){
   setlocale(LC_ALL,"Portuguese");

   int v[4];
   int *p;
   p = v;

   *(p + 1) = 6;

}