#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <math.h>

int quad_perf(int x){
    if (x == 0){
        return 1;    
    } else if (x / sqrt(x) == sqrt(x)){
        return 1;
    }
}
     
void main(){
    setlocale(LC_ALL,"Portuguese");
    
    int seq = 0;
    printf("Digite o tamanho da sequencia:");
    scanf("%d", &seq);

    int tot_quad = 0;
    for (int i = 1; i <= seq; i++){
        int num = 0;
        printf("Digite o %do numero:", i);
        scanf("%d", &num);
        if (quad_perf(num) == 1){
            tot_quad = tot_quad + 1;
        }
    }
    
    
    printf("Existem %d numeros que sao quadrados perfeito na tela", tot_quad);

}