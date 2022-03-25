#include <stdio.h>
#include <stdlib.h>

typedef struct List
{
   int enrollment;
   float grade;
   struct List *next; 
} List;

List *insertList(List *li, int enrollment, float grade)
{
   List *aux = (List*) malloc(sizeof(List));
   aux->enrollment = enrollment;
   aux->grade = grade;
   aux->next = li;
   return aux;
}

List *createList() 
{
   return NULL; 
}

void lowestGrades(List *li, float value)
{
   List *first = li; //Saving the first memory address of the first list' item
   printf("Grades minors than %.0f:", value);
   printf("\n");
   while (li != NULL)
   {
      if(li->grade < value) 
         printf("%d | ", li->enrollment);

      li = li->next;   
   }
   li = first; //Returning the first memory address to the first position in list
}

void main()
{
   List *list = createList();
   list = insertList(list, 1, 9.0);
   list = insertList(list, 2, 10.0);
   list = insertList(list, 3, 6.0);
   list = insertList(list, 4, 0.0);
   list = insertList(list, 5, 7.0);
   list = insertList(list, 6, 8.0);

   lowestGrades(list, 7);

   printf("\n");
   system("pause");
}