#include <stdio.h>
#define N 50

typedef struct 
{
   int n;
   float arr[N];
} Stack;

Stack *createStack()
{
   Stack *p = (Stack*) malloc(sizeof(Stack));
   p->n = 0;
   return p;
}

void freeStack(Stack *p)
{
   free(p);
}

int emptyStack(Stack *p)
{
   if(p->n == 0) return 1;

   return 0;
}

void push(Stack *p, float value)
{
   if(p->n == N)
   {
      printf("The stack is full!");
      system("pause");
      return;
   }

   p->arr[p->n] = value;
   p->n++;
}

float pop(Stack *p)
{
   float value = p->arr[p->n-1];
   p->n--;
   return value;
}

void printStack(Stack *p)
{
   printf("The values of stack:\n");
   for(int i = p->n - 1; i >= 0; i--)
      printf("%.0f\n", p->arr[i]);
   printf("\n");

   system("pause");
}