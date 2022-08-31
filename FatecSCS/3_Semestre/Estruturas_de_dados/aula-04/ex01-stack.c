#include <stdio.h>
#include <stdlib.h>
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

void menu()
{
   system("cls");
   printf("Choose one of the options from menu\n");
   printf("1. Push\n");       
   printf("2. Pop\n");
   printf("3. Print stack\n");
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
         printf("Enter the value to get popped: ");
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