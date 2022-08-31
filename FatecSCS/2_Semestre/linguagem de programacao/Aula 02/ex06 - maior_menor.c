#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

     
void main(){
    setlocale(LC_ALL,"Portuguese");
    
    int seq = 0;
    printf("Digite o tamanho da sequencia:");
    scanf("%d", &seq);

    int maior_num;
    printf("Entre com o primeiro elemento:");
    scanf("%d", &maior_num);
    int menor_num = maior_num;
    for (int cont = 2; cont <= seq; cont++){
        int num = 0;
        printf("Digite o %d° elemento:", cont);
        scanf("%d", &num);
        if (num > maior_num){
            maior_num = num;
        } else if  (num < menor_num){
            menor_num = num;
        }
    }
    

    printf("O maior numero digitado foi %d \n", maior_num);
    printf("E o menor numero digitado foi %d", menor_num);
}