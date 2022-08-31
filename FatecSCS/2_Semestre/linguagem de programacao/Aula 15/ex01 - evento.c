#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

struct task{
   int start, finish;
};

void print_task(struct task *ev, int tam){
   for (int i = 0; i < tam; i++){
      printf("%d: start = %d | finish = %d\n", i, ev[i].start, ev[i].finish);
   }
}

int ind_max(struct task *ev, int n) {
   int maior = 0;
   for (int i = 0; i < n; i++){
      if (ev[i].finish > ev[maior].finish){
         maior = i;
      }
   }
   return maior;
}

void sel_sort(struct task *ev, int n){
  /* while (n > 1){
      int m = ind_max(ev, n);

      struct task aux = ev[n-1];
      ev[n-1] = ev[m];
      ev[m] = aux;
      --n;
   }*/
}

int size_of_max(struct task *ev, int n){
   sel_sort(ev, n);
   int u = 0, cont = 1;
   for (int i = 1; i < n; i++){
      if (ev[i].start >= ev[u].finish){
         struct task aux = ev[i];
         ev[i] = ev[cont];
         ev[cont] = aux;
         cont++;
         u = i;
      }
   }
   
   return cont;
}
     
void main(){
   setlocale(LC_ALL,"Portuguese");

   int n = 0;
   scanf("%d", &n);
   struct task event[n];
   for (int i = 0; i < n; i++){
      scanf("%d", &event[i].start, &event[i].finish);
   }
   print_task(event, n);
   printf("Max = %d\n", size_of_max(event, n));
}