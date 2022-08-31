#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int sum_array(int *v, int t){
   int soma = 0;
   for (int i = 0; i < t; i++){
      soma = soma + v[i];
   }

   return soma;
}
     
int main(){
   setlocale(LC_ALL,"Portuguese");

   int vet[] = {1, 5, 3};
   int tam = sizeof(vet) / sizeof(int);
   printf("A soma dos valores é: %d", sum_array(vet, tam));

}