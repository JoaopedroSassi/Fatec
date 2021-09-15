#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int manipula_endereco(int *v, int t){
   printf("%d", *v);
}
     
int main(){
   setlocale(LC_ALL,"Portuguese");

   int vet[] = {1, 5, 7, 9, 7, 3, 0, 4, 7};
   int tam = (sizeof(vet)/sizeof(int));

   int resul = manipula_endereco(vet + 2, tam);


}