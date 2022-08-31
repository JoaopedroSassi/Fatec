#include <stdio.h>
#include <stdlib.h>

void main()
{
   char frase[81];

   FILE *arq;
   arq = fopen("C:/temp/entrada.txt", "rt");
   if (arq == NULL) 
   {
      printf("Erro na abertura do arquivo!\n");
      return 1;
   }

   while(fgets(frase, 80, arq) != NULL)
   {
      printf("%s", frase);
   }
   

   fclose(arq);
   
   system("pause");
   return 0;
}