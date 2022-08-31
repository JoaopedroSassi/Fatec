#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int soma_vetor(int *p, int t, int n){
   for (int i = 0; i < t; i++){
      for (int c = i+1; c < t; c++){
         if (p[i] + p[c] == n){
            return 1;
         }
      }
   }

   return 0;
}

void main(){
    setlocale(LC_ALL,"Portuguese");

   printf("-----------------------------------------\n");
   printf("           Soma 2 el Vetores!            \n");
   printf("-----------------------------------------\n");
   printf("Digite o tamanho do vetor:");
   int tam = 0;
   scanf("%d", &tam);
   int vet[tam];
   for (int i = 0; i < tam; i++){
      printf("Digite o %d� n�mero:", i + 1);
      scanf("%d", &vet[i]);
   }

   printf("Digite o n�mero da soma:");
   int num = 0;
   scanf("%d", &num);

   int resul = soma_vetor(vet, tam, num);

   if (resul == 1){
      printf("\nSim, existe!");
   } else{
      printf("\nN�o, n�o existe :(");
   }
   

   printf("\n---------------------------------\n");
}