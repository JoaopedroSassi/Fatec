#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main()
{
   FILE *fp;

   int num[20];
   int vet[5];
   for (int i = 0; i < 20; i++)
      num[i] = i;
   
   fp = fopen("vetBin.bin", "wb");
   fwrite(num, sizeof(int), 20, fp);
   fclose(fp);
   fp = fopen("vetBin.bin", "rb");

   fseek(fp, -5 *sizeof(int), SEEK_END);

   fread(vet, sizeof(int), 5, fp);
   printf("\nVetor resultante\n");
   for(int i = 0; i < 5; i++)
      printf("%d\t", vet[i]);

   print("\n\n");
   fclose(fp);

   system("pause");
   return 0;
}