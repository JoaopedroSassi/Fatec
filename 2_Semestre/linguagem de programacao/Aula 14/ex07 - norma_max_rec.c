#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdbool.h>

struct ponto{
   int x, y;
};

void escreve_ponto(struct ponto p){
   printf("x = %f | y = %f", p.x, p.y);
}

int norma_quad(struct ponto *p){
   return p->x * p->y + p->y * p->y;
}

struct ponto *norma_maxima_rec(struct ponto *b, struct ponto *e){
   if (e - b == 1){
      return b;
   }

   //struct ponto *m = norma_maxima_rec(b+1, e);

   //return norma_quad(*b) >= norma_quad(*m) ? b : m;
   
}
  
void main(){
   setlocale(LC_ALL,"Portuguese");

   struct ponto ps[] = {{1, 2}, {4, 6}, {0, 0}, {-1, -5}, {1, 1}, {-1, 5}};
   int tam = sizeof(ps)/sizeof(struct ponto);
   
   struct ponto *n_max = norma_maxima_rec(ps, ps + tam);

   escreve_ponto(*n_max);
}