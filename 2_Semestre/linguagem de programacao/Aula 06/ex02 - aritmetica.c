#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
     
int main(){
   setlocale(LC_ALL,"Portuguese");

   int x = 20;
   int *p = &x;

   p = p + 1;

}