#include <stdio.h>
#include <stdlib.h>

void main()
{
   char frase[] = "Earthbound";

   FILE *arq;
   arq = fopen("C:/temp/saida2.txt", "wt");
   for (int i = 0; frase[i] != '\0'; i++)
   {
      fputc(frase[i], arq);
   }

   fclose(arq);

   printf("Arquivo gravado!\n");
   
   system("pause");
   return 0;
}