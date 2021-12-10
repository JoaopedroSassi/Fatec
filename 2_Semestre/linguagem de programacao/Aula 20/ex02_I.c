#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdbool.h>

struct task {
	int start, finish;
};

int horaH(struct task *v, int n, int h){
   int qtd = 0;

   for (int i = 0; i < n; i++)
   {
      if (v[i].start == h)
      {
         qtd++;
      }
   }
   
   return qtd;
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

   printf("Digite qual a hora para começar:");
   int h = 0;
   scanf("%d", &h);

   int qtde = horaH(event, n, h);

   printf("Existem %d eventos que começam as %d", qtde, h);
}