#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdbool.h>

struct ponto{
   double x, y;
};

int contem_origem(struct ponto *ps, int t){
   for (int i = 0; i < t; i++){
      if ((ps[i].x == 0) && (ps[i].y == 0)){
         return 1;
      }
   }

   return 0;
}
  
void main(){
   setlocale(LC_ALL,"Portuguese");

   struct ponto ps[] = {{1, 2}, {4, 6}, {0, 0}, {-1, -5}, {1, 1}};
   int tam = sizeof(ps)/sizeof(struct ponto);
   
   int have = contem_origem(ps, tam);

   if (have == 1){
      printf("Sim, ele contém!");
   } else {
      printf("Não, ele não contém!");
   }
   

   

}