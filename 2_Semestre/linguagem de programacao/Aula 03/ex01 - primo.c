#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int primo(int x){
    int acc = 0;
    for (int i = 1; i <= x; i++){
        if (x % i == 0){
            acc = acc + 1;
        }
    }
    if (acc == 2) {
        return 1;
    }
}
     
void main(){
    setlocale(LC_ALL,"Portuguese");
    
    int seq = 0;
    printf("Digite o tamanho da sequencia:");
    scanf("%d", &seq);

    int tot_primos = 0;
    for (int i = 1; i <= seq; i++){
        int num = 0;
        printf("Digite o %do numero:", i);
        scanf("%d", &num);
        if (primo(num) == 1){
            tot_primos = tot_primos + 1;
        }
    }
    
    
    printf("Existem %d numeros primos na tela", tot_primos);

}