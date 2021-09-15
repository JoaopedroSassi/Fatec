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

   int tam = 0;
   printf("Digite a quantidade de elementos do vetor:");
   scanf("%d", &tam);

   int vet[tam];
   for (int i = 0; i < tam; i++){
      printf("Digite o %d° valor do vetor:", i + 1);
      scanf("%d", &vet[i]);
   }

   printf("A soma dos valores é: %d", sum_array(vet, tam));

}