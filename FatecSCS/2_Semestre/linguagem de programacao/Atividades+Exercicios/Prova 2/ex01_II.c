#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdbool.h>

bool isThereAll(char *c){
   const char string[] = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', '\0'};

   int have = 0;
   for (int i = 0; i < 16; i++)
   {
      for (int j = 0; j < 6; j++)
      {
         if (c[j] == string[i])
         {
            have++;
            break;
         }
      }
   }

   if (have >= 6){
      return true;
   } else{
      return false;
   }
}
     
void main(){
   setlocale(LC_ALL,"Portuguese");

   char *c = "12AB3F";

   if (isThereAll(c))
   {
      printf ("Sim, a string está!");
   } else {
      printf("Não, a string não está!");
   }
}
