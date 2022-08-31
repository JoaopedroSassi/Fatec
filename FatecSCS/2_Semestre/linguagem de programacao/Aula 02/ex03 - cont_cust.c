#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

     
void main(){
    setlocale(LC_ALL,"Portuguese");
    
    int seq = 0;
    puts("Digite o tamanho da sequencia");
    scanf("%d", &seq);

    int cont = 1, sum = 0;
    while (cont <= seq){
        int num = 0;
        printf("Digite o %d° numero:", cont);
        scanf("%d", &num);
        sum += num;
        cont++;
    }

    printf("O somatorio de numeros é igual a: %d", sum);
}