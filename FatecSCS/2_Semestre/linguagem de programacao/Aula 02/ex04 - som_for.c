#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

     
void main(){
    setlocale(LC_ALL,"Portuguese");
    
    int seq = 0;
    puts("Digite o tamanho da sequencia");
    scanf("%d", &seq);

    int sum = 0;
    for (int cont = 1; cont <= seq; cont++){
        int num = 0;
        printf("Digite o %d° numero:", cont);
        scanf("%d", &num);
        sum += num;
    }
    

    printf("O somatorio de numeros é igual a: %d", sum);
}