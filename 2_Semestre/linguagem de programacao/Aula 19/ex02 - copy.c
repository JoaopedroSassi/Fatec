#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <string.h>

void copy(char *des, const char *src){
   while (*src != '\0'){
      *des = *src;
      des++;
      src++;
   }
   *des = '\0';
}

void main(){
   setlocale(LC_ALL,"Portuguese");

   char s[] = "Mario Leston Rey";
   char t[20];
   //strcpy(t, s);
   copy(t, s);
   printf ("%s", t);
}