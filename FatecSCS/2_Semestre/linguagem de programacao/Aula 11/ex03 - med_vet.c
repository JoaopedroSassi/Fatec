#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

double media(double *v, int t){
   double med = 0;
   for (int i = 0; i < t; i++){
      med = med + v[i];
   }

   med = med / t;

   return med;
}
     
int main(){
   setlocale(LC_ALL,"Portuguese");

   int tam = 0;
   printf("Digite a quantidade de elementos do vetor:");
   scanf("%d", &tam);

   double vet[tam];
   for (int i = 0; i < tam; i++){
      printf("Digite o %d° valor do vetor:", i + 1);
      scanf("%lf", &vet[i]);
   }

   printf ("A média aritmética dos elementos do vetor é %.2lf!", media(vet, tam));
   printf("\n");
   system("pause");
}