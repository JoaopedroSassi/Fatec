#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int fat(int n){
   if (n == 0){
      return 1;
   }

   long f = fat(n - 1);

   return f*n; 
}
     
void main(){
   setlocale(LC_ALL,"Portuguese");

   printf("%ld", fat(5)); 
}