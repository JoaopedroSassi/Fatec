#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int zera_vetor(int *p, int n){
   for (int i = 0; i < n; i++){
      p[i] = 0;
   }
   
}
     
int main(){
   setlocale(LC_ALL,"Portuguese");

   int v[100];
   zera_vetor(v, 100);

}