#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <math.h>

int quad(int x){
    
    int y;
    y = pow(x, 2);
    return y;
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
        tot_quad = tot_quad + quad(num);
    }
    
    
    printf("O somatorio dos numeros absolutos da seq e igual a %d", tot_quad);
}