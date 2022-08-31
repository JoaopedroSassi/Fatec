#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int sum_array_cinco(int *v, int t, int r){
   int soma = 0;

   for (int *p = v; p < v + t; p++){
      if (*p % 5 == r){
         soma += *p;
      }
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

   printf("Digite o número que você quer saber % 5");
   int resto = 0;
   scanf("%d", &resto);

   printf("A soma dos elementos com resto == 0 é: %d", sum_array_cinco(vet, tam, resto));

}