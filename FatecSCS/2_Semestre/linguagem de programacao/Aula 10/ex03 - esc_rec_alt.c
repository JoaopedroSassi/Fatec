#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

void escreve_alt(int n){
   if (n == 0){
      return;
   }
   if(n == 1){
      printf ("1");
   } else {
      escreve_alt(n - 2);
      printf("%d %d ", n-1, n);
   }
}
     
void main(){
   setlocale(LC_ALL,"Portuguese");

   escreve_alt(10); 
   
}