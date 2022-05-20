#include <stdio.h>
#include <stdlib.h>

void main()
{
   int nl = 0;
   char c;

   FILE *arq;
   arq = fopen("C:/temp/entrada.txt", "rt");
   if (arq == NULL) 
   {
      printf("Erro na abertura do arquivo!\n");
      return 1;
   }

   while ((c=fgetc(arq)) != EOF)
   {
      if(c == '\n')
         nl++;
   }

   fclose(arq);
   printf("Numero de linhas = %d\n", nl);
   
   system("pause");
   return 0;
}