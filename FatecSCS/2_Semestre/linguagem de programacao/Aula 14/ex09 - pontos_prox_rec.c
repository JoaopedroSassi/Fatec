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

int calc_dis(struct ponto pon, struct ponto loc){
   int res = (pon.x - loc.x ) * (pon.x  - loc.x ) + (pon.y- loc.y) * (pon.y - loc.y);
}

struct ponto *ponto_prox_rec(struct ponto *beg, struct ponto *end, struct ponto loc){
   if (end - beg == 1){
      return beg;
   }

   struct ponto *max = ponto_prox_rec(beg+1, end, loc);
   
   return calc_dis(*beg, loc) <= calc_dis(*max, loc) ? beg : max;
}
  
void main(){
   setlocale(LC_ALL,"Portuguese");

   struct ponto ps[] = {{1, 2}, {3, 5}, {-2, 1}, {-3, -3}, {0, 0}};
   int tam = sizeof(ps)/sizeof(struct ponto);
   struct ponto r = {3, 4};
   struct ponto *p = ponto_prox_rec(ps, ps+tam, r);
   escreve_ponto(*p);
}