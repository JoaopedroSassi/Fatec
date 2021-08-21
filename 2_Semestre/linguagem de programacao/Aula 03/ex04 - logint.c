#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <math.h>

int log_int(int x){
    
    int maior_num_log;
    for (int i = 0; pow(2, i) <= x; i++){
        maior_num_log = i;
    }
    return maior_num_log;
}
     
void main(){
    setlocale(LC_ALL,"Portuguese");
    
    int seq = 0;
    printf("Digite o tamanho da sequencia:");
    scanf("%d", &seq);

    int tot_log = 0;
    for (int i = 1; i <= seq; i++){
        int num = 0;
        printf("Digite o %do numero:", i);
        scanf("%d", &num);
        tot_log = tot_log + log_int(num);
    }
    
    
    printf("O somatorio dos logaritmos inteiros e igual a %d", tot_log);

}