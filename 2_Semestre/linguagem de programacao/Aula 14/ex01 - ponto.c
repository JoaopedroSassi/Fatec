#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

struct ponto{
   double x, y;
};
     
void main(){
   setlocale(LC_ALL,"Portuguese");

   struct ponto p = {4, 7};
   printf("x = %f | y = %f", p.x, p.y);
}