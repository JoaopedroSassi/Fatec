#include <stdio.h>
#include <stdlib.h>
#include "stack.h"

Stack *divide(Stack *st)
{
   //Criando uma stack auxiliar pra poder fazer as operações
   Stack *aux = createStack();
   while(!emptyStack(st))
   {
      push(aux, pop(st));
   }

   Stack *half = createStack();
   while(!emptyStack(aux))
   {
      //Voltando os valores para a stack original E os valores / 2 na nova
      float value = pop(aux);
      push(st, value);
      push(half, value/2);
   }

   //Liberando memória
   freeStack(aux);

   return half;
}

void main(){
   Stack *stack = createStack();

   //Populating stack
   for (int i = 10; i <= 40; i=i+10)
   {
      push(stack, i);
   }

   Stack *half = divide(stack);

   printStack(stack);
   printf("");
   printStack(half);

   system("pause");
}