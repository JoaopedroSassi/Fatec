#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int soma_sqrt_int(int n){

   for (int i = 0; i < n; i++){
      if (i*i == n){
         return i;
      }     
   }
   
   float num2 = n;
   for (int i = 0; i < 10; ++i){
      num2 = num2/2 + n/(2*num2);
   }

   return ((int) num2);
}
     
void main(){
   setlocale(LC_ALL,"Portuguese");

   int tam = 0;
   printf("Digite quantos numeros ser�o somados:");
   scanf("%d", &tam);
   
   int num = 0;
   int resul = 0;
   for (int i = 0; i < tam; i++){
      printf("\nDigite o %d� n�mero:", i + 1);
      scanf("%d", &num);
      resul += soma_sqrt_int(num);
   }
   

   printf("A soma de ra�zes inteira � igual a: %d", resul);
}