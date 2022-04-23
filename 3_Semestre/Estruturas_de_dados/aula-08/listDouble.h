#include <stdio.h>
#include <stdlib.h>

typedef struct List
{
   int info;
   struct List *ant;
   struct List *next; 
} List;

List *listaCria() 
{
   return NULL; 
}

List *listaInsere(List *li, int value)
{
   List *aux = (List*) malloc(sizeof(List));
   aux->info = value;
   aux->next = li;
   aux->ant = NULL;

   if(li != NULL)
      li->ant = aux;

   return aux;
}

List *listaOrdenada(List *li, int value)
{
   List *novo;
   List *anterior = NULL;
   List *aux = li;

   novo = (List*) malloc(sizeof(List));
   novo->info = value;

   while(aux != NULL && aux->info < value)
   {
      anterior = aux;
      aux = aux->next;
   }

   if(anterior == NULL)
   {
      if(li != NULL)
         li->ant = novo;
      
      novo->next = li;
      novo->ant = NULL;
      li = novo;
   }
   else
   {
      novo->next = anterior->next;
      novo->ant = anterior;

      if (anterior->next != NULL)
         anterior->next->ant = novo;
      
      anterior->next = novo;
   }

   return li;
}

List *listaBusca(List *li, int value)
{
   List *aux;
   for (aux = li; aux != NULL; aux = aux->next)
      if(aux->info == value) 
         return aux;

   return NULL;
}

List *listaRetira(List *li, int value)
{
   List *aux = listaBusca(li, value);
   if (aux == NULL)
      return li;

   if(li == aux)
      li = aux->next;
   else
      aux->ant->next = aux->next;
   
   if(aux->next != NULL)
      aux->next->ant = aux->ant;
   
   free(aux);
   return li;
}

void listaMostra(List *li)
{
   List *aux;
   for (aux = li; aux != NULL; aux = aux->next)
      printf("%d | ", aux->info);
}

int listaVazia(List *li)
{
   return (li==NULL);
}

void listaLibera(List *li)
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
