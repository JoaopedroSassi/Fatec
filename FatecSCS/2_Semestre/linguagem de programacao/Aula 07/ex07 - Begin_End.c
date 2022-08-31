#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int manipula_endereco_dois(int *b, int *e){
   int soma = 0;

   for (int *p = b; p < e; *p++){
      soma += *p;
   }
   
   return soma;
}
     
int main(){
   setlocale(LC_ALL,"Portuguese");

   int vet[] = {1, 5, 7, 9, 7, 3, 0, 4, 7};
   int tam = (sizeof(vet)/sizeof(int));

   int resul = manipula_endereco_dois(vet + 2, vet + 7);

   printf("%d", resul);
}