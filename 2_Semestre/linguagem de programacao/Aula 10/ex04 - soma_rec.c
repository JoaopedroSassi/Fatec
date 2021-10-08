#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int soma(int n){
   if (n == 0){
      return;
   }

   int s = soma(n - 1);

   return s + n; 
}
     
void main(){
   setlocale(LC_ALL,"Portuguese");

   printf("%d", soma(100)); 
}