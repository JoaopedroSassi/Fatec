#include <stdio.h>
#include <stdlib.h>
#include "stackUp.h"

void stackUp(Stack *st1, Stack *st2)
{
   float value = 0;

   Stack *aux = createStack();
   while(!emptyStack(st2))
   {
      value = pop(st2);
      push(aux, value);
   }

   while(!emptyStack(aux))
   {
      value = pop(aux);
      push(st2, value);
      push(st1, value);
   }
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
   
   stackUp(stack, stack2);

   printStack(stack);
   printf("");
   printStack(stack2);


   system("pause");
}