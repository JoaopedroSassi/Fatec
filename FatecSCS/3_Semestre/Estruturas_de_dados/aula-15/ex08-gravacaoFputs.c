#include <stdio.h>
#include <stdlib.h>

void main()
{
   char frase[] = "Earthbound";
   char endline = '\n';

   FILE *arq;
   arq = fopen("C:/temp/saida3.txt", "wt");
   
   fputs(frase, arq);
   fputc(endline, arq);
   fputs(frase, arq);

   fclose(arq);
   printf("Arquivo gravado!\n");
   
   system("pause");
   return 0;
}