#include <stdio.h>
#include <stdlib.h>
#include "queue.h"

int countElements(Queue *queue)
{
   int counter = 0;

   Queue *aux = createQueue();
   while(!emptyQueue(queue))
   {
      enqueue(aux, dequeue(queue));
      counter++;
   }

   while(!emptyQueue(aux))
   {
      enqueue(queue, dequeue(aux));
   }

   return counter;
}

float sumElements(Queue *queue)
{
   float sum = 0, value = 0;

   Queue *aux = createQueue();
   while(!emptyQueue(queue))
   {
      value = dequeue(queue);
      sum += value;
      enqueue(aux, value);
   }

   while(!emptyQueue(aux))
   {
      enqueue(queue, dequeue(aux));
   }

   return sum;
}

float first(Queue *queue)
{
   float value = 0;
   Queue *aux = createQueue();

   value = dequeue(queue);
   enqueue(aux, value);
   float first = value;

   while(!emptyQueue(queue))
   {
      value = dequeue(queue);
      enqueue(aux, value);
   }

   while(!emptyQueue(aux))
   {
      enqueue(queue, dequeue(aux));
   }

   return first;
}

float last(Queue *queue)
{
   float value = 0;

   Queue *aux = createQueue();
   while(!emptyQueue(queue))
   {
      value = dequeue(queue);
      enqueue(aux, value);
   }
   
   while(!emptyQueue(aux))
   {
      enqueue(queue, dequeue(aux));
   }

   return value;
}

void menu()
{
   system("cls");
   printf("Choose one of the options from menu\n");
   printf("1. Enqueue\n");       
   printf("2. Dequeue\n");
   printf("3. Print queue\n");
   printf("4. Count queue\n");
   printf("5. Elements' sum\n");
   printf("6. First\n");
   printf("7. Last\n");
   printf("0. End\n");
}

void main(){
   Queue *queue = createQueue();
   int optionMenu = 0;
   float value = 0;

   do
   {
      menu();
      scanf("%d", &optionMenu);
      switch (optionMenu)
      {
      case 1:
         printf("Enter the value to get enqueued: ");
         scanf("%f", &value);
         enqueue(queue, value);
         break;

      case 2:
         if(emptyQueue(queue))
            printf("Empty queue");

         printf("Removed element: %0.f\n", dequeue(queue));
         system("pause");
         break;
      
      case 3:
         printQueue(queue);
         break;

      case 4:
         printf("The queue has %d elements\n", countElements(queue));
         system("pause");
         break;

      case 5:
         printf("The element's sum equals %0.f\n", sumElements(queue));
         system("pause");
         break;

      case 6:
         printf("The queue's first element equals %0.f\n", first(queue));
         system("pause");
         break;

      case 7:
         printf("The queue's last element equals %0.f\n", last(queue));
         system("pause");
         break;

      case 0:
         break;

      default:
         printf("Invalid option!\n");
         system("pause");
         break;
      }
   } while (optionMenu != 0);
   
   
   system("pause");
}