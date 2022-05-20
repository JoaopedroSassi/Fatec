#include <stdio.h>
#include <stdlib.h>

void main()
{
   FILE *fp;
   fp = fopen("entrada.txt", "rt");
   if (fp == NULL)
   {
      printf("Erro na abertura do arquivo!\n");
      return 1;
   }

   FILE *arq;
   arq = fopen("saida.txt", "wt");
   if(arq == NULL)
   {
      printf("Erro na abertura do arquivo!\n");
      return 1;
   }
   
   fclose(arq);
   fclose(fp);   

   printf("\n");
   system("pause");
}