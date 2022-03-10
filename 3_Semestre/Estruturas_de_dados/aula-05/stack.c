#include <stdio.h>
#include <stdlib.h>
#include "stack.h"

int countElements(Stack *stack)
{
    int count = 0;
    float value = 0;
    Stack *aux = createStack();

    while(emptyStack(stack) == 0)
    {
        value = pop(stack);
        count++;
        push(aux, value);
    }

    while(emptyStack(aux) == 0)
    {
        value = pop(aux);
        push(stack, value);
    }

    freeStack(aux);
    return count;
}

float sumElements(Stack *stack)
{
   float sum = 0, value = 0;

   Stack *aux = createStack();

   while(!emptyStack(stack))
   {
      value = pop(stack);
      sum += value;
      push(aux, value);
   }

   while(!emptyStack(aux))
   {
      push(stack, pop(aux));
   }

   freeStack(aux);
   return sum;
}

float base(Stack *stack)
{
   float value = 0;

   Stack *aux = createStack();
   while(!emptyStack(stack))
   {
      value = pop(stack);
      push(aux, value);
   }

   float base = value;

   while(!emptyStack(aux))
   {
      push(stack, pop(aux));
   }  

   freeStack(aux);
   return base;
}

float top(Stack *stack)
{
   float value = 0;

   value = pop(stack);
   push(stack, value);
   return value;
}

void menu()
{
   system("cls");
   printf("Choose one of the options from menu\n");
   printf("1. Push\n");       
   printf("2. Pop\n");
   printf("3. Print stack\n");
   printf("4. Count stack\n");
   printf("5. Elements' sum\n");
   printf("6. Base\n");
   printf("7. Top\n");
   printf("0. End\n");
}

void main(){
   Stack *stack = createStack();
   int optionMenu = 0;
   float value = 0;

   do
   {
      menu();
      scanf("%d", &optionMenu);
      switch (optionMenu)
      {
      case 1:
         printf("Enter the value to get pushed: ");
         scanf("%f", &value);
         push(stack, value);
         break;

      case 2:
         if(emptyStack(stack))
            printf("Empty stack");

         printf("Removed element: %0.f\n", pop(stack));
         system("pause");
         break;
      
      case 3:
         printStack(stack);
         break;

      case 4:
         printf("The stack has %d elements\n", countElements(stack));
         system("pause");
         break;

      case 5:
         printf("The elementy's sum equals %0.f\n", sumElements(stack));
         system("pause");
         break;

      case 6:
         printf("The stack's base equals %0.f\n", base(stack));
         system("pause");
         break;

      case 7:
         printf("The stack's top equals %0.f\n", top(stack));
         system("pause");
         break;

      case 0:
         break;

      default:
         printf("Invalid option!");
         system("pause");
         break;
      }
   } while (optionMenu != 0);
   
   
   system("pause");
}