#include <stdio.h>
#include <stdlib.h>
#include "queue.h"

Queue *queueIntercalate(Queue *st1, Queue *st2)
{
   float value = 0;
   int sizeQueue1 = 0, sizeQueue2 = 0;

   Queue *aux1 = createQueue();
   while(!emptyQueue(st1))
   {
      enqueue(aux1, dequeue(st1));
      sizeQueue1++;
   }

   Queue *aux2 = createQueue();
   while(!emptyQueue(st2))
   {
      enqueue(aux2, dequeue(st2));
      sizeQueue2++;
   }

   Queue *final = createQueue();
   while((sizeQueue1 + sizeQueue2) > 0)
   {
      if (sizeQueue1 != 0)
      {
         value = dequeue(aux1);
         enqueue(final, value);
         enqueue(st1, value);
         sizeQueue1--;
      }
      
      if (sizeQueue2 != 0)
      {
         value = dequeue(aux2);
         enqueue(final, value);
         enqueue(st2, value);
         sizeQueue2--;
      }
   }
   return final;
}

void main(){
   Queue *queue = createQueue();
   Queue *queue2 = createQueue();

   for (int i = 1; i <= 5; i++)
   {
      enqueue(queue, i);
   }

   for (int i = 1; i <= 2; i++)
   {
      enqueue(queue2, i+10);
   }
   
   Queue *finalQueue = createQueue();
   finalQueue = queueIntercalate(queue, queue2);

   printQueue(finalQueue);

   system("pause");
}