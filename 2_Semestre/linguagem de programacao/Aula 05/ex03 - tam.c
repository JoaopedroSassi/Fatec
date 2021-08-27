#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

     
int main(){
   setlocale(LC_ALL,"Portuguese");

   int n = 10;
   printf("%ld", sizeof(int));
}