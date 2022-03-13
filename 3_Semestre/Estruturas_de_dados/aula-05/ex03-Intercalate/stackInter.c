#include <stdio.h>
#include <stdlib.h>
#include "stackInter.h"

Stack *stackIntercalate(Stack *st1, Stack *st2)
{
   float value = 0;
   int sizeStacks = 0;

   Stack *aux1 = createStack();
   while(!emptyStack(st1))
   {
      push(aux1, pop(st1));
      sizeStacks++;
   }

   Stack *aux2 = createStack();
   while(!emptyStack(st2))
   {
      push(aux2, pop(st2));
      sizeStacks++;
   }

   Stack *final = createStack();
   while(sizeStacks > 0)
   {
      value = pop(aux1);
      push(final, value);
      push(st1, value);

      value = pop(aux2);
      push(final, value);
      push(st2, value);

      sizeStacks -= 2;
   }
   return final;
}

void main(){
   Stack *stack = createStack();
   Stack *stack2 = createStack();

   for (int i = 1; i <= 5; i++)
   {
      push(stack, i);
   }

   for (int i = 1; i <= 5; i++)
   {
      push(stack2, i+10);
   }
   
   Stack *stackInter = createStack();
   stackInter = stackIntercalate(stack, stack2);

   printStack(stackInter);

   system("pause");
}