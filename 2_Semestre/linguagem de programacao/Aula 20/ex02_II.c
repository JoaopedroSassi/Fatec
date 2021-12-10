#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdbool.h>

struct task {
	int start, finish;
};

void printEvent(struct task *v, int n){
   for (int i = 0; i < n; i++)
   {
      printf("%d° Evento: %d | %d\n", i+1, v[i].start, v[i].finish);
   }
}

void changeOrder(struct task *v, int n){
   int length[n];
   for (int i = 0; i < n; i++)
   {
      length[i] = (v[i].finish - v[i].start);
   }
   
   for (int i = 0; i < n - 1; i++)
   {
      for (int c = i + 1; c < n; c++)
      {
         if (length[i] > length[c])
         {
            struct task aux = v[i];
            v[i] = v[c];
            v[c] = aux;
         }
      }
   }
}

void main(){
   setlocale(LC_ALL,"Portuguese");

   printf("Digite quantos eventos serão:");
   int n = 0;
   scanf("%d", &n);

   struct task event[n];

   for (int i = 0; i < n; i++)
   {
      scanf("%d", &event[i].start);
      scanf("%d", &event[i].finish);
   }

   printEvent(event, n);

   changeOrder(event, n);

   printf("\n");

   printEvent(event, n);
}