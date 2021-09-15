#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int max_array(int *v, int t){
   int maior = v[0];
   for (int i = 0; i < t; i++){
      if (v[i] > maior){
         maior = v[i];
      }
   }

   return maior;
}
     
int main(){
   setlocale(LC_ALL,"Portuguese");

   int vet[] = {1, 9, 6, 7, 4, 2, 7, 6, 4, 1};
   int tam = sizeof(vet) / sizeof(int);
   printf("O maior valor é: %d", max_array(vet, tam));

}