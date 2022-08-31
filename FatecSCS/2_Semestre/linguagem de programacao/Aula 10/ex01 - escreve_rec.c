#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

void escreve(int n){
   if (n == 0){
      return;
   }

   escreve(n - 1);
   printf("%d ", n);
}
     
void main(){
   setlocale(LC_ALL,"Portuguese");

   escreve(10); 
   
}