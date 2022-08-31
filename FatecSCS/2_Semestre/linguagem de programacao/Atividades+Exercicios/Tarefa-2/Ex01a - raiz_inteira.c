#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int sqrt_int(int n){

   //Como não pude add a biblioteca math.h, utilizeo o método de Newton?Raphson para fazer uma raiz quadrada
   float num2 = n;
   for (int i = 0; i < 10; ++i){
      num2 = num2/2 + n/(2*num2);
   }
   return ((int) num2);
}

     
void main(){
   setlocale(LC_ALL,"Portuguese");

   int num = 0;
   puts("Digite o número para verificação:");
   scanf("%d", &num);

   int resul = sqrt_int(num);

   printf("A raiz inteira de %d é igual a %d", num, resul);
}