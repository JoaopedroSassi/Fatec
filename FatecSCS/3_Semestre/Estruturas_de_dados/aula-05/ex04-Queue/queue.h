#define N 50

typedef struct {
   int n;
   int ini;
   float arr[N];
}Queue;

Queue *createQueue()
{
   Queue *q = (Queue*) malloc(sizeof(Queue));
   q->n = 0;
   q->ini = 0;
   return q;
}

int emptyQueue(Queue *q)
{
   if(q->n == q->ini) return 1;

   return 0;
}

void freeQueue(Queue *q)
{
   free(q);
}

void printQueue(Queue *q)
{
   if(emptyQueue(q))
   {
      printf("Queue is empty!\n");
      system("pause");
      return;
   }

   printf("The values of queue:\n");
   for(int i = q->ini; i < q->n; i++)
      printf("%.0f\n", q->arr[i]);
   printf("\n");

   system("pause");
}

void enqueue(Queue *q, float value)
{
   if(q->n == N)
   {
      printf("The queue is full!");
      system("pause");
      return;
   }

   q->arr[q->n] = value;
   q->n++;
}

float dequeue(Queue *q)
{
   float value = q->arr[q->ini];
   q->ini++;
   return value;
}

