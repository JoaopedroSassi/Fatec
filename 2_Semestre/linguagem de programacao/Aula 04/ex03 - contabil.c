#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <math.h>
   
void main(){
    setlocale(LC_ALL,"Portuguese");
    
    int seq = 0;
    printf("Digite o tamanho da sequencia:");
    scanf("%d", &seq);

    int tot_zero = 0, maior_zero = 0, menor_zero = 0;
    for (int i = 1; i <= seq; i++){
        int num = 0;
        printf("Digite o %do numero:", i);
        scanf("%d", &num);
        if (num == 0){
            tot_zero = tot_zero + 1;
        } else if (num > 0){
            maior_zero = maior_zero + 1;
        } else{
            menor_zero = menor_zero + 1;
        }    
    }
    
    
    printf("Existem %d numeros iguais a 0", tot_zero);
    printf("\nExistem %d numeros maiores que 0", maior_zero);
    printf("\nExistem %d numeros menores que 0", menor_zero);
}