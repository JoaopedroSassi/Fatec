#include <stdio.h>
#include <stdlib.h>

typedef struct List
{
   int conta;
   float saldo;
   struct List *ant;
   struct List *next; 
} List;

List *listaCria() 
{
   return NULL; 
}

List *listaInsere(List *li, int value, float sal)
{
   List *aux = (List*) malloc(sizeof(List));
   aux->conta = value;
   aux->saldo = sal;
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
   novo->conta = value;

   while(aux != NULL && aux->conta < value)
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
      if(aux->conta == value) 
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
      printf("%d | ", aux->conta);
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

void procuraConta(List *final, int cc)
{
   if(final->conta == cc) //Se achou a conta
   {
      printf("Conta: %d | Saldo: %.2f \n", cc, final->saldo);
      system("pause");
      return;
   }
   else
   {
      if(final->next == NULL) //Se for a ultima
      {
         printf("Conta nao encontrada!\n");
         system("pause");
         return;
      }
      else
         procuraConta(final->next, cc); //Senao for, vai pra proxima
   }
}

void menu()
{
   system("cls");
   printf("Choose one of the options from menu\n");
   printf("1. Insert\n");       
   printf("2. Remove\n");
   printf("3. Print List\n");
   printf("4. Search element\n");
   printf("5. Search accounts\n");
   printf("0. End\n");
}

void main()
{
   List *list = listaCria();
   int optionMenu = 0, value = 0;
   float saldo;

   do
   {
      menu();
      scanf("%d", &optionMenu);
      switch (optionMenu)
      {
      case 1:
         printf("Enter the value to get inserted: ");
         scanf("%d", &value);
         scanf("%f", &saldo);

         list = listaInsere(list, value, saldo);
         break;

      case 2:
         printf("Enter the value to get removed: ");
         scanf("%d", &value);

         list = listaRetira(list, value);
         break;
      
      case 3:
         if(listaVazia(list))
         {
            printf("Empty list!\n");
            system("pause");
         }  
         else
         {
            printf("\nList:\n");
		      listaMostra(list);
            system("pause");
         }
         break;
      
      case 4:
         printf("Enter the number which you want to find:");
         scanf("%d", &value);

         List *aux = listaBusca(list, value);
         if(aux == NULL)
         {
            printf("%d not localized\n", value);
            system("pause");
         }
         else
         {
            printf("%d localized\n", value);
            system("pause");
         }
            
         break;

      case 5:
         procuraConta(list, 5);

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