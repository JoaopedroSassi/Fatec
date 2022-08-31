#include <stdio.h>
#include <stdlib.h>

typedef struct List
{
   int key;
   struct List *next; 
} List;

List *createList() 
{
   return NULL; 
}

List *insertList(List *li, int value)
{
   List *aux = (List*) malloc(sizeof(List));
   aux->key = value;
   aux->next = li;
   return aux;
}

List *sortedInsert(List *li, int value)
{
   List *prev = NULL;
   List *aux = li;

   List *newList = (List*) malloc(sizeof(List));
   newList->key = value;

   while (aux != NULL && aux->key < value)
   {
      prev = aux;
      aux = aux->next;
   }
   
   if(prev == NULL)
   {
      newList->next = li;
      li = newList;
   }
   else
   {
      newList->next = prev->next;
      prev->next = newList;
   }

   return li;
}

List *removeList(List *li, int value)
{
   List *prev = NULL;
   List *aux = li;

   while (aux != NULL && aux->key != value)
   {
      prev = aux;
      aux = aux->next;
   }

   if(aux == NULL)
   {
      printf("\nNot localized!");
      system("pause");
      return li;
   }

   if (prev == NULL)
      li = aux->next;
   else
      prev->next = aux->next;

   free(aux);
   return li;
}

void printList(List *li)
{
   List *aux;
   for (aux = li; aux != NULL; aux = aux->next)
      printf("%d | ", aux->key);
}

int emptyList(List *li)
{
   return (li==NULL);
}

List *searchList(List *li, int value)
{
   List *aux;
   for (aux = li; aux != NULL; aux = aux->next)
      if(aux->key == value) 
         return aux;

   return NULL;
}

void freeList(List *li)
{
   List *aux, *aux2; 
   aux = li;
   while (aux != NULL)
   { 
      aux2 = aux->next; 
      free(aux);
      aux = aux2;
   } 
}
