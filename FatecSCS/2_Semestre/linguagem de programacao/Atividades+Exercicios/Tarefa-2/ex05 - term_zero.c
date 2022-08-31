#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
     
void main(){
   setlocale(LC_ALL,"Portuguese");

   int ach = 0;
   int cont = 1;

   printf("----------------------------------\n");
   printf("Sequência! Termina quando vier o 0\n");
   printf("----------------------------------\n");
   int compr = 0;
   while (ach == 0){
      int num = 0;
      printf("Digite o %d° número:", cont);
      scanf("%d", &num); 
      compr = compr + 1;
      cont += 1;
      if (num == 0){
         ach = 1;
      }
   }
   printf("\n------------------------");
   printf("\nO comprimento total foi de: %d", compr);
}