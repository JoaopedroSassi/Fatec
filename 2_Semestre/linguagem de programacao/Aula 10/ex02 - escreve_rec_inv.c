#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

void escreve_rev(int n){
   if (n == 0){
      return;
   }

   printf("%d ", n);
   escreve_rev(n - 1);
}
     
void main(){
   setlocale(LC_ALL,"Portuguese");

   escreve_rev(10); 
   
}