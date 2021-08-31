#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <math.h>

int main(){
    setlocale(LC_ALL,"Portuguese");
    
    int seq;
    printf("Digite o tamanho da sequencia:");
    scanf("%d", &seq);

    int bef, compr; 
    printf("Digite o 1o numero:");
    scanf("%d", &bef);
    compr = 1;

    for (int i = 1; i < seq; i++){
        int num;
        printf("Digite o %do numero:", i + 1);
        scanf("%d", &num);
        if (num > bef){
            compr++;
            bef = num;
        } 
    }

    printf("A maior sequência foi %d", compr);
}