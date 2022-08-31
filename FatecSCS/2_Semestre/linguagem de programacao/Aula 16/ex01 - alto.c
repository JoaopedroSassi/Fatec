#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdbool.h>

bool percorre(int *b, int *e){
   int soma = 0;

   while (b != e){
      soma = soma + *b;
      b++;
   }

   if (soma > *e){
      return false;
   }

   return true;
}

bool alto(int *b, int *e){
   if (b > e){
      return false;
   }

   int *i = b;
   while (b != e){
      bool hav = percorre(i, b);
      if (!hav){
         return false;
      }
      
      ++b;
   }

   return true;
}

void main(){
   setlocale(LC_ALL,"Portuguese");

   printf("Digite o tamanho do vetor:");
   int tam = 0;
   scanf("%d", &tam);
   int vet[tam];

   for (int i = 0; i < tam; i++){
      printf("Digite o %d° número:", i + 1);
      scanf("%d", &vet[i]);
   }

   bool height = alto(vet, vet + tam);

   if (height){
      printf("O vetor é alto");
   } else {
      printf("O vetor é baixo");
   }
}
