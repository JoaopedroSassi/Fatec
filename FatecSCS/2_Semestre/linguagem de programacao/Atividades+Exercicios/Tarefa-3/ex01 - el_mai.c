#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int elem_maior(int *v, int t, int x){
   int maior = 0;

   for (int i = 0; i < t; i++){
      if (v[i] > x){
         maior++;
      }
   }
   
   return maior;
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

   printf("Digite o número que você quer saber os elementos maior no vetor:");
   int num = 0;
   scanf("%d", &num);

   printf ("A quantidade de elementos maiores que %d é %d!", num, elem_maior(vet, tam, num));
   printf("\n");
   system("pause");
}