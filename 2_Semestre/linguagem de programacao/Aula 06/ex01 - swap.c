#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int swap(int *p, int *r){
   int t = *p;
   *p = *r;
   *r = t;
}

     
int main(){
   setlocale(LC_ALL,"Portuguese");

   int x = 10;
   int y = 20;
   swap(&x, &y);
   printf("x: %d | y: %d\n", x, y);
}