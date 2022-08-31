#include <stdio.h>
#include <stdlib.h>
#include "listDouble.h"

void menu()
{
   system("cls");
   printf("Choose one of the options from menu\n");
   printf("1. Insert\n");       
   printf("2. Remove\n");
   printf("3. Print List\n");
   printf("0. End\n");
}

void main()
{
   List *list = listaCria();
   int optionMenu = 0, value = 0;

   do
   {
      menu();
      scanf("%d", &optionMenu);
      switch (optionMenu)
      {
      case 1:
         printf("Enter the value to get inserted: ");
         scanf("%d", &value);

         list = listaInsere(list, value);
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