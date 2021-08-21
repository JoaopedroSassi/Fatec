#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <math.h>

int absol(int x){
    
    int y;
    if (x < 0){
        y = x * (-1);
    } else{
        y = x;
    }
    return y;
}
     
void main(){
    setlocale(LC_ALL,"Portuguese");
    
    int seq = 0;
    printf("Digite o tamanho da sequencia:");
    scanf("%d", &seq);

    int tot_num_abs = 0;
    for (int i = 1; i <= seq; i++){
        int num = 0;
        printf("Digite o %do numero:", i);
        scanf("%d", &num);
        tot_num_abs = tot_num_abs + absol(num);
    }
    
    
    printf("O somatorio dos numeros absolutos da seq e igual a %d", tot_num_abs);

}