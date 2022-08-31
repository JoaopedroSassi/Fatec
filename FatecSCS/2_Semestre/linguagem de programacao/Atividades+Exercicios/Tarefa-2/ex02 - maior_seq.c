#include <stdio.h>
#include <stdlib.h>
#include <locale.h>


int verifica_vezes(int *p, int t, int m){
   int v = 0;
   for (int i = 0; i < t; i++){
      if (m == p[i]){
         v = v + 1;
      }
   }
   
   return v;
}
     
void main(){
   setlocale(LC_ALL,"Portuguese");

   int tam = 0;
   printf("Digite quantos numeros serão analisados:");
   scanf("%d", &tam);

   int vet[tam];
   printf("Digite o 1° número:");
   scanf("%d", &vet[0]);
   int maior_num = vet[0];

   for (int i = 1; i < tam; i++){
      printf("Digite o %d° número:", i + 1);
      scanf("%d", &vet[i]);
      if (vet[i] > maior_num){
         maior_num = vet[i];
      }
   }

   int vezes = verifica_vezes(vet, tam, maior_num);
   

   printf("O maior número foi %d e ele apareceu %d vezes", maior_num, vezes);
}