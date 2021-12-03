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
   printf("O número de ocorrências de %c é %d", 'a', count(s, 'a'));
}