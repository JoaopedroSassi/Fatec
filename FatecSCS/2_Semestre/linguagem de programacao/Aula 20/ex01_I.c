#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdbool.h>

bool isThere(char c){
   const char string[] = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', '\0'};

   for (int i = 0; i < 16; i++)
   {
      if (string[i] == c)
      {
         return true;
      }
   }
   
   return false;
}
     
void main(){
   setlocale(LC_ALL,"Portuguese");

   char c = 'A';

   if (isThere(c))
   {
      printf ("Sim, ele está!");
   } else {
      printf("Não, ele não está!");
   }
}