#include <stdio.h>
#include <stdlib.h>
#include <locale.h>


int verifica_vezes(int *p, int t){
   int tot_div = 0;
   for (int i = 0; i < t; i++){
      if (p[i] % 3 == 0){
         tot_div = tot_div + 1;
      }
   }
   
   return tot_div;
}
     
void main(){
   setlocale(LC_ALL,"Portuguese");

   int tam = 0;
   printf("Digite quantos numeros ser�o analisados:");
   scanf("%d", &tam);

   int vet[tam];
   for (int i = 0; i < tam; i++){
      printf("Digite o %d� n�mero:", i + 1);
      scanf("%d", &vet[i]);
   }

   int tot_div = verifica_vezes(vet, tam);
   

   printf("Dentre os n�meros digitados, %d s�o divis�veis por 3", tot_div);
}