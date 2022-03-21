#include <stdio.h>
#include <stdlib.h>
#include "stack.h"

Stack *divide(Stack *st)
{
   //Creating an auxiliary stack to make the operations
   Stack *aux = createStack();
   while(!emptyStack(st))
   {
      push(aux, pop(st));
   }

   Stack *half = createStack();
   while(!emptyStack(aux))
   {
      //Returning the values ??to the original and putting the value / 2 in the new one
      float value = pop(aux);
      push(st, value);
      push(half, value/2);
   }

   //Freeing memory
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