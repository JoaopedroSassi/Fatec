#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

void main()
{
   char opt = 's';

   int n1 = 0, n2 = 0, students = 0;
   char name[50];

   while (true)
   {
      printf("Enter the first note: ");
      scanf("%d", &n1);
      printf("Enter the second note: ");
      scanf("%d", &n2);
      printf("Enter the student's name: ");
      scanf("%s", &name);

      double avg = (float)(n1 + n2) / 2;
      printf("%s's average grade is %f\n", name, avg);
      students++;

      printf("Do you want to read another student? (s/n)");
      fflush(stdin);
      scanf("%c", &opt);

      printf("\n");
      if(opt == 'n')
      {
         break;
      }
   }
   
   printf("Total students: %d\n", students);
   printf("Thanks for the use!\n");
   
   system("pause");
}