#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <string.h>

int count(const char *s, char c){
   int cont = 0;
   while (*s != '\0'){
      if (*s == c){
         cont++;
      }
      s++;
   }
   
   return cont;
}


void main(){
   setlocale(LC_ALL,"Portuguese");

   char *s = "aab";
   printf("O n�mero de ocorr�ncias de %c � %d", 'a', count(s, 'a'));
}