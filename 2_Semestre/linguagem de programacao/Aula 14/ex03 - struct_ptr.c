#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

struct ponto{
   double x, y;
};

struct ponto soma_ptr(struct ponto *p, struct ponto *r){
   struct ponto s = {.x = p->x + r->x, .y = p->y + r->y};
   return s;
}

void escreve_ponto(struct ponto p){
   printf("x = %f | y = %f", p.x, p.y);
}
     
void main(){
   setlocale(LC_ALL,"Portuguese");

   struct ponto p = {4, 7};
   struct ponto r = {p.x++, p.y++};
   struct ponto s = soma_ptr(&p, &r);
   escreve_ponto(s);
}