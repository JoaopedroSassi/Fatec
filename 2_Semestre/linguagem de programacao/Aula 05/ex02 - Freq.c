#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

     
int main(){
    setlocale(LC_ALL,"Portuguese");

    printf("Entre com o número de notas: ");
    int tam;
    scanf("%d", &tam);

    int freq[11] = {0};
    for (int i = 0; i < tam; i++){
       int notas = 0;
       printf("Digite a %do nota: ", i + 1);
       scanf("%d", &notas);
       freq[notas] += 1;
    }


    printf("\n___________________________");
    for (int i = 0; i < 11; i++){
        printf("\nPosição: %d  | Frequência: %d", i, freq[i]);
    }
    printf("\n________________________________");
    printf("\n");
}