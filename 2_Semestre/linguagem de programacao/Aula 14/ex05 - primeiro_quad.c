#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdbool.h>

struct ponto{
   int x, y;
};

int primeiro_quadrante(struct ponto *ps, int t){
   int q = 0;

   for (int i = 0; i < t; i++){
      if ((ps[i].x >= 0) && (ps[i].y >= 0)){
         ++q;
      }
   }

   return q;
}
  
void main(){
   setlocale(LC_ALL,"Portuguese");

   struct ponto ps[] = {{1, 2}, {4, 6}, {0, 0}, {-1, -5}, {1, 1}, {-1, 5}, {9, -5}};
   int tam = sizeof(ps)/sizeof(struct ponto);
   
   int qtd = primeiro_quadrante(ps, tam);

   printf("Existem %d elementos no 1° quadrante do Ciclo Trigonométrico", qtd);

}