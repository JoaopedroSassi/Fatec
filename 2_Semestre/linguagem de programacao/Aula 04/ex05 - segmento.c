#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <math.h>
   
void main(){
    setlocale(LC_ALL,"Portuguese");
    
    int seq = 0;
    printf("Digite o tamanho da sequencia:");
    scanf("%d", &seq);

    int compr = 0, now = 0, bef = 0, num = 0;
    for (int i = 1; i <= seq; i++){
        printf("Digite o %do numero:", i);
        scanf("%d", &num);
        if (num > bef){
            compr++;
            now = num;
            bef = now;
        } else if (num < bef && compr < i) {
            compr = 0;
            compr++;
            now = num;
            bef = now;
        }
        
    }
    
    printf("O maior comprimento foi de %d", compr);
}