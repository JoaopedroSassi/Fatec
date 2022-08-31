#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int soma_dc(int beg, int end){
   if (end - beg == 0){
      return 0;
   }
   if (end - beg == 1 ){
      return beg;
   }

   int med = ((beg + end)/2);
   int x = soma_dc(beg, med);
   int y = soma_dc(med, end);

   return x + y;
}
     
int main(){
   setlocale(LC_ALL,"Portuguese");

   printf("%d", soma_dc(2, 6)); 
}

