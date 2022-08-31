#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int soma_int(int beg, int end){
   if (beg == end){
      return 0;
   }

   int som = soma_int(beg, end-1);

   return som + (end - 1);
}
     
int main(){
   setlocale(LC_ALL,"Portuguese");

   printf("%d", soma_int(2, 6)); 
}