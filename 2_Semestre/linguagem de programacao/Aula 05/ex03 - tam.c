#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

     
int main(){
   setlocale(LC_ALL,"Portuguese");

   int vet[] = {1, 6, 7, 9, 1};
   int tam_vet = (sizeof(vet)/sizeof(int));
   printf("O tamanho do vetor vet é: %d", tam_vet);
}