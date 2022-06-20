#include <stdio.h>
#include <stdlib.h>

void leArq(FILE *Arq, int t)
{
   int sum = 0;

   int num[t];
   fread(num, sizeof(int), t, Arq); //Lendo o arquivo
   for (int i = 0; i < t; i++)
   {
      if(i == 0) //Verificando se é o primeiro
         printf("Primeiro elemento: %d\n", num[i]);

      sum += num[i]; //Somando

      if(i == t -1) //Verificando se é o ultimo
         printf("Ultimo elemento: %d\n", num[i]);
   }

   printf("Soma de elementos: %d", sum);
   fclose(Arq);
}

void main()
{
   FILE *fp;
   int num[10] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
   
   fp = fopen("Ex04.bin", "wb");
   fwrite(num, sizeof(int), 10, fp);
   fclose(fp);

   fp = fopen("Ex04.bin", "rb");
   leArq(fp, 10);

   printf("\n");
   system("pause");
}