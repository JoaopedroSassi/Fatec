#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <math.h>
#include <stdbool.h>
   
void main(){
    setlocale(LC_ALL,"Portuguese");
    
    int seq;
    printf("Digite o tamanho da sequencia:");
    scanf("%d", &seq);

    int bef, compr; 
    printf("Digite o 1o numero:");
    scanf("%d", &bef);
    bool achei = false;
    compr = 1;

    for (int i = 1; i < seq; i++){
        int num;
        printf("Digite o %do numero:", i + 1);
        scanf("%d", &num);
        if (num > bef && !achei){
            compr++;
            bef = num;
        } else{
            achei = true;
        }
        
    }
    
    printf("O maior comprimento foi de %d", compr);
}